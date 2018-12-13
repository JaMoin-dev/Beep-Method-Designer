using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beep.Model;

namespace Beep.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = new List<ICommand>()
            {
                new BeepCommand(300, 500),
                new PausCommand(500),
                new LoopCommand(3)
                {
                    Commands = new List<ICommand>()
                    {
                        new BeepCommand(500, 300),
                        new PausCommand(200),
                    }
                },
                new PausCommand(500),
                new BeepCommand(300, 500),
            };


            var player = new Player();
            player.Play(sequence);
        }
    }
}
