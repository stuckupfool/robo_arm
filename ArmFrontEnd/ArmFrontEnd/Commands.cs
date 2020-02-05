using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmFrontEnd
{
    class LedSetCommand : Command
    {
        public byte Mode { get; set; }
        public ushort Palette { get; set; }

        public LedSetCommand() : base(51) { }

        public override byte[] ProvideParametersForDispatch()
        {
            return new[] { Mode, (byte)(Palette >> 8), (byte)Palette };
        }
    }

    public class LedCustomCommand : Command
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
        public byte Mode { get; set; }
        public byte Delay { get; set; }
        public PaletteEntry[] Palette { get; set; }

        public LedCustomCommand() : base(52) { }

        public override byte[] ProvideParametersForDispatch()
        {
            byte[] data = new byte[3 + (Palette.Length * 4)];
            data[0] = Mode;
            data[1] = Delay;
            data[2] = (byte)Palette.Length;
            for(int i = 0; i < Palette.Length; i++)
            {
                Palette[i].SetData(i, data);
            }
            return data;
        }
    }

    public class PaletteEntry
    {
        public byte Step { get; set; }
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }
        public string Label { get { return $"{Step} [{R},{G},{B}]"; } }
        public Color Color { get { return Color.FromArgb(R, G, B); } }
        public void SetData(int elementIndex, byte[] data)
        {
            data[3 + (elementIndex * 4) + 0] = Step;
            data[3 + (elementIndex * 4) + 1] = R;
            data[3 + (elementIndex * 4) + 2] = G;
            data[3 + (elementIndex * 4) + 3] = B;
        }
    }

    class LedPowerCommand: Command
    {
        //Any value > 0 = It is On
        public bool IsPowered { get; set; }

        public LedPowerCommand() : base(50) { }

        public override byte[] ProvideParametersForDispatch()
        {
            return new[] { Convert.ToByte(IsPowered) };
        }
    }
    class EchoCommand : Command
    {
        public string Message { get; set;}

        public EchoCommand() : base(48) { }

        public override byte[] ProvideParametersForDispatch()
        {
            return Message.Select((char character) => (byte)character).ToArray();
        }
    }

    class ServoCommand : Command
    {
        public byte ServoNum { get; set; }
        public byte Position { get; set; }
        public ServoCommand() : base(49) { }
        public override byte[] ProvideParametersForDispatch()
        {
            return new[] { ServoNum, Position };
        }
    }
}
