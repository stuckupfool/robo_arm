#pragma once
#include "Common.h"
#include "CommandHandler.h"
#include <FastLED.h>

/*#define DATA_PIN 12
#define LED_TYPE WS2812*/

#define DATA_PIN 11
#define CLOCK_PIN 13
#define LED_TYPE APA102

#define NUM_LEDS 48 
//20
#define COLOR_ORDER BGR
//RGB

class IcoHandler :
	public CommandHandler
{
private:
	uint8_t max_bright = 255;
	struct CRGB leds[NUM_LEDS];
	CRGBPalette16 current_palette;
	CRGBPalette16 target_palette = CRGBPalette16(*RainbowStripeColors_p);
	//uint8_t palette_index = 0;

	uint8_t mode = 7;//2;
	uint8_t max_mode = 7;
	bool isNew = 1;

	uint8_t icosahedron[4][5] = { { 0, 1, 2, 3, 4 }, { 5, 7, 9, 11, 13 }, { 6, 8, 10, 12, 14 }, { 15, 16, 17, 18, 19 } };
	uint8_t spiral_order[20] = { 0, 1, 2, 3, 4, 11, 12, 13, 14, 5, 6, 7, 8, 9, 10, 15, 18, 19, 17, 16 };
	uint8_t spin_order[10][2] = { {1,5}, {6,17}, {2,7}, {8,16}, {3,9}, {10,15}, {4,11}, {12,19}, {0,13}, {14,18} };

	uint8_t fade_val = 128;
	uint8_t hue = 0;
	uint8_t ico_index = 0;
	uint8_t delta = 10;
	uint8_t increment = 1;
	uint8_t ico_delay = 150;
	uint8_t numdots = 3;
	uint8_t beat = 12;
	uint8_t juggle_position = 0;
	uint8_t confetti_position = 0;
	uint8_t custom_palette_size = 0;
	int stagger = 0;

	bool isOn = false;
	bool isCustom = false;
	bool isAnimating = false;

	bool processOnOff(Command* command);
	bool processModePalette(Command* command);
	bool processModeCustom(Command* command);

	void _tick();
public:
	IcoHandler();

	// Inherited via CommandHandler
	virtual bool Process(Command* command) override;


	// Light stuff adapted from: https://github.com/IAmBecomeJeff/led_repo
	void fadeall();
	void ico_fill_rainbow();
	void ico_palette();
	void spin();
	void juggle();
	void juggle_palette();
	void juggle_up_and_down();
	void confetti();
	void confetti_palette();
	void palette_debug();

	void Tick();
};

