using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmFrontEnd
{
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
