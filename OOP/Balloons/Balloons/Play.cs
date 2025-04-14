using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Balloons
{
    public class Play
    {
        private List<Balloon> Balloons = new List<Balloon>();
        private List<Arrow> Arrows = new List<Arrow>();
        private int scoreRedTeam = 0;
        private int scoreBlueTeam = 0;
        private bool skipTurnRed = false;
        private bool skipTurnBlue = false;

        public event EventHandler<PlayEventArgs> PlayTurnHappened;

        public void Game()
        {
            PlayRotation();

            for (int i = 0; i < Balloons.Count; i++)
            {
                Turn(i);
            }

            Console.WriteLine(ToString());
        }

        private void Turn(int i)
        {
            var arrow = Arrows[i];
            var balloon = Balloons[i];
            string result = string.Empty;

            if (arrow.Color == "Red")
            {
                if (skipTurnRed)
                {
                    result = "Red skipped.";
                    skipTurnRed = false;
                }
                else if (balloon.Color == "Red" && arrow.Size >= balloon.Size)
                {
                    scoreRedTeam++;
                    result = "Red scored a point.";
                }
                else if (balloon.Color == "Black" && arrow.Size >= balloon.Size)
                {
                    skipTurnRed = true;
                    result = "Red hit black balloon. Skips next turn.";
                }
                else
                {
                    result = "Red missed.";
                }
            }
            else if (arrow.Color == "Blue")
            {
                if (skipTurnBlue)
                {
                    result = "Blue skipped.";
                    skipTurnBlue = false;
                }
                else if (balloon.Color == "Blue" && arrow.Size >= balloon.Size)
                {
                    scoreBlueTeam++;
                    result = "Blue scored a point.";
                }
                else if (balloon.Color == "Black" && arrow.Size >= balloon.Size)
                {
                    skipTurnBlue = true;
                    result = "Blue hit black balloon. Skips next turn.";
                }
                else
                {
                    result = "Blue missed.";
                }
            }

            // Raise the event
            PlayTurnHappened?.Invoke(this, new PlayEventArgs(
                i + 1,
                arrow.Color,
                balloon.Color,
                arrow.Size,
                balloon.Size,
                result
            ));
        }

        public override string ToString()
        {
            return $"Final Scores:\nRed Team: {scoreRedTeam} points\nBlue Team: {scoreBlueTeam} points";
        }

        public void PlayRotation()
        {
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                int balloonSize = random.Next(1, 20);
                int arrowSize = random.Next(1, 20);
                int colorChoice = random.Next(1, 3);

                if (i % 2 == 0)
                {
                    string balloonColor = colorChoice == 1 ? "Red" : "Black";
                    CreateBallon(balloonColor, balloonSize);
                    CreateArrow("Red", arrowSize);
                }
                else
                {
                    string balloonColor = colorChoice == 1 ? "Blue" : "Black";
                    CreateBallon(balloonColor, balloonSize);
                    CreateArrow("Blue", arrowSize);
                }
            }
        }

        private void CreateBallon(string color, int size)
        {
            Balloons.Add(new Balloon(color, size));
        }

        private void CreateArrow(string color, int size)
        {
            Arrows.Add(new Arrow(color, size));
        }



    }
}