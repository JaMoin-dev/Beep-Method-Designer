using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Beep.Model
{
    public class Player
    {
        public void Play(List<ICommand> sequence)
        {
            foreach (var command in sequence)
                Play(command);
        }

        private void Play(ICommand sequence)
        {
            switch (sequence)
            {
                case BeepCommand beep:
                    Console.Beep(beep.Frequency, beep.LengthMs);
                    break;
                case PausCommand pause:
                    Thread.Sleep(pause.LengthMs);
                    break;
                case LoopCommand loop:
                    loop.Iterations.Times(() => { Play(loop.Commands); });
                    break;
            }
        }
    }

    public static class ExtMethods
    {
        public static void Times(this int count, Action a)
        {
            foreach (var _ in Enumerable.Range(0, count))
            {
                a();
            }
        }
    }
}
