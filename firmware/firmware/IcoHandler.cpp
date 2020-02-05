#include "IcoHandler.h"
//#include "Palettes.h"

bool IcoHandler::processOnOff(Command* command)
{
	if (command->dataLength == 1) {
		if (command->parameters[0] > 0) {
			isOn = true;
			isAnimating = false;
			FastLED.setBrightness(max_bright);
			//Serial.println(LEDS_ON);
		}
		else
		{
			isOn = false;
			isAnimating = false;
			FastLED.setBrightness(0);
			FastLED.show();
			FastLED.clear();
			//Serial.println(LEDS_OFF);
		}
		return true;
	}
	return false;
}

bool IcoHandler::processModePalette(Command* command)
{
	/*Serial.print("LEDs Mode: ");
	if (command->dataLength == 3) {
		//1st byte: action
		//2nd,3rd bytes: pallette
		mode = (uint8_t)command->parameters[0];
		short paletteInd = ((short)command->parameters[1] << 8) + (short)command->parameters[2];
		target_palette = g_gradient_palettes[paletteInd];
		palette_index = (byte)paletteInd;
		nblendPaletteTowardPalette(current_palette, target_palette, 1);

		Serial.print(mode);
		Serial.print(" Palette Index: ");
		Serial.println(paletteInd);

		isAnimating = true;
		return true;
	}*/
	//Serial.println("ERR: Not implemented :(");
	return false;
}

bool IcoHandler::processModeCustom(Command* command)
{
	/*
		Parameters Format:
			byte 0: Mode
			     1: Delay
				 2: Palette Entry Count
				 3-N: Palette Entries:
				 ------------------------
					byte 0: Gradient Step
					     1: Red Color Channel
						 2: Green Color Channel
						 3: Blue Color Channel
	*/
	if (command->dataLength >= 3) {
		mode = (uint8_t)command->parameters[0];

		ico_delay = (uint8_t)command->parameters[1];
		
		const byte entryCount = command->parameters[2];
		custom_palette_size = entryCount;
		
		current_palette.loadDynamicGradientPalette(command->parameters + 3);
		//nblendPaletteTowardPalette(current_palette, target_palette, 1);

		isAnimating = true;
		return true;
	}
	return false;
}

IcoHandler::IcoHandler()
{
	LEDS.addLeds<LED_TYPE, DATA_PIN, CLOCK_PIN, COLOR_ORDER>(leds, NUM_LEDS)/*LEDS.addLeds<LED_TYPE, DATA_PIN, COLOR_ORDER>(leds, NUM_LEDS)*/.setDither(max_bright < 255);
	FastLED.setBrightness(max_bright);
	set_max_power_in_volts_and_milliamps(5, 1000);
	isNew = true;
}

bool IcoHandler::Process(Command* command)
{
	switch (command->operation)
	{
	case 50: //On/Off
		return processOnOff(command);
	case 51: //Mode & Palette
		return processModePalette(command);
	case 52: //Mode & Custom Palette
		return processModeCustom(command);
	default:
		return false;
	}
}

void IcoHandler::Tick()
{
	if (isOn) {
		if (isCustom) {

		}
		else {
			if (isAnimating) {
				EVERY_N_MILLIS_I(this_timer, ico_delay) {
					this_timer.setPeriod(ico_delay);
					_tick();
				}
			}
			else {
				fill_solid(leds, NUM_LEDS, CRGB(255, 255, 255));
			}
			FastLED.show();
		}
	}
}

void IcoHandler::_tick() {
	if (isNew) {
		fill_solid(leds, NUM_LEDS, CRGB(0, 0, 0));
	}

	switch (mode) {
	case 0:
		if (isNew) { /*ico_delay = 30;*/ fade_val = 128; ico_index = 0; isNew = 0; };
		spin();
		break;

	case 1:
		if (isNew) { /*ico_delay = 15;*/ delta = 128; increment = 1; isNew = 0; };
		ico_fill_rainbow();
		break;

	case 2:
		if (isNew) { /*ico_delay = 15;*/ target_palette = HeatColors_p; /*palette_index = 0*/; delta = 8; increment = 2; isNew = 0; };
		ico_palette();
		break;

	case 3:
		if (isNew) { /*ico_delay = 10;*/ fade_val = 200; numdots = 2; beat = 16; hue = 0; isNew = 0; };
		juggle();
		break;

	case 4:
		if (isNew) { /*ico_delay = 12;*/ fade_val = 128; numdots = 2; beat = 20; /*palette_index = 0*/; isNew = 0; };
		juggle_palette();
		break;

	case 5:
		if (isNew) { /*ico_delay = 30;*/ fade_val = 160; numdots = 2; beat = 60; hue = 0; isNew = 0; };
		juggle_up_and_down();
		break;

	case 6:
		if (isNew) { /*ico_delay = 60;*/ fade_val = 160; isNew = 0; };
		confetti();
		break;

	case 7:
		if (isNew) { /*ico_delay = 60;*/ fade_val = 180; isNew = 0; };
		confetti_palette();
		break;
	case 8:
		if (isNew) { isNew = 0; }
		palette_debug();
		break;
	}
}

void IcoHandler::fadeall() { for (int i = 0; i < NUM_LEDS; i++) { leds[i].nscale8(fade_val); } }

void IcoHandler::ico_fill_rainbow() {
	hue = ico_index;
	for (int i = 0; i < 4; i++) {
		for (int j = 0; j < 5; j++) {
			leds[icosahedron[i][j]] = CHSV(hue, 255, 240);
		}
		hue -= delta;
	}
	ico_index += increment;
}

void IcoHandler::ico_palette() {
	for (int i = 0; i < 4; i++) {
		for (int j = 0; j < 5; j++) {
			leds[icosahedron[i][j]] = ColorFromPalette(current_palette, stagger + i * delta, 255);
		}
	}
	stagger = (stagger + increment) % 256;
}

void IcoHandler::spin() {
	fadeall();
	leds[spin_order[ico_index][0]] = CHSV(hue, 255, 255);
	leds[spin_order[ico_index][1]] = CHSV(hue, 255, 255);
	hue++;
	ico_index = (ico_index + 1) % (NUM_LEDS / 2);
}

void IcoHandler::juggle() {
	fadeall();
	for (uint8_t dot = 0; dot < numdots; dot++) {
		juggle_position = beatsin16(beat + dot + numdots, 0, NUM_LEDS - 1);
		leds[spiral_order[juggle_position]] += CHSV(hue++, 255, 255);
	}
}

void IcoHandler::juggle_palette() {
	fadeall();
	for (uint8_t dot = 0; dot < numdots; dot++) {
		juggle_position = beatsin16(beat + dot + numdots, 0, NUM_LEDS - 1);
		leds[spiral_order[juggle_position]] += ColorFromPalette(current_palette, stagger, max_bright, LINEARBLEND);
		stagger = (stagger + 1) % 256;
	}
}

void IcoHandler::juggle_up_and_down() {
	fadeall();
	for (uint8_t dot = 0; dot < numdots; dot++) {
		juggle_position = beatsin16(beat + dot + numdots, 0, 3);
		for (int row = 0; row < 5; row++) {
			leds[icosahedron[juggle_position][row]] += CHSV(hue++, 255, 255);
		}
	}
}

void IcoHandler::confetti() {
	fadeall();
	confetti_position = random8(NUM_LEDS);
	leds[confetti_position] += CHSV(random8(), 200, 255);
}

void IcoHandler::confetti_palette() {
	fadeall();
	confetti_position = random8(NUM_LEDS);
	leds[confetti_position] += ColorFromPalette(current_palette, random8(), max_bright);
}

void IcoHandler::palette_debug()
{
	fadeall();
	for (int i = 0; i < NUM_LEDS; i++) {
		float r = (float)(i % NUM_LEDS) / (float)NUM_LEDS;
		uint8_t paletteIndex = r * 256;
		leds[i] = ColorFromPalette(current_palette, paletteIndex);
	}
}
