using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beep.Model
{
    public interface ICommand
    {
    }

    public class LoopCommand : ICommand
    {
        public LoopCommand(int iterations)
        {
            Iterations = iterations;
        }

        public int Iterations { get; set; }

        public List<ICommand> Commands { get; set; }
    }


    public class PausCommand : ICommand
    {
        public PausCommand(int lengthMs)
        {
            LengthMs = lengthMs;
        }

        public int LengthMs { get; set; }
    }

    public class BeepCommand : ICommand
    {
        public BeepCommand(int frequency, int lengthMs)
        {
            Frequency = frequency;
            LengthMs = lengthMs;
        }

        public int Frequency { get; set; }

        public int LengthMs { get; set; }
    }
}
