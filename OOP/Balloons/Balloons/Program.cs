using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balloons
{
    public class Program
    {
        static void Main(string[] args)
        {
            var play = new Play();

            // Subscribe to event
            play.PlayTurnHappened += OnPlayTurn;

            play.Game();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
        private static void OnPlayTurn(object sender, PlayEventArgs e)
        {
            Console.WriteLine($"Turn {e.TurnNumber}:");
            Console.WriteLine($"Arrow - {e.ArrowColor} ({e.ArrowSize}) | Balloon - {e.BalloonColor} ({e.BalloonSize})");
            Console.WriteLine($"Result: {e.Result}");
            Console.WriteLine();
        }
    }
}
