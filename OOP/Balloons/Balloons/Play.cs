using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Balloons
{
    public class Play : EventArgs
    {
        List<Balloon> balloons = new List<Balloon>();
        List<Arrow> arrows = new List<Arrow>();
        int scoreRedTeam = 0;
        int scoreBlueTeam = 0;



        public void PlayRotaion()
        {
            Random random = new Random();
            Random balloonColor = new Random();

            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    switch (balloonColor.Next(1, 2))
                    {
                        case 1:
                            balloons.Add(new Balloon("Red", random.Next(1, 20)));
                            break;
                        case 2:
                            balloons.Add(new Balloon("Black", random.Next(1, 20)));
                            break;

                    }

                    arrows.Add(new Arrow("Red", random.Next(1, 20)));
                }
                else
                {
                    switch (balloonColor.Next(1, 2))
                    {
                        case 1:
                            balloons.Add(new Balloon("Blue", random.Next(1, 20)));
                            break;
                        case 2:
                            balloons.Add(new Balloon("Black", random.Next(1, 20)));
                            break;

                    }

                    balloons.Add(new Balloon("Blue", random.Next(1, 20)));
                    arrows.Add(new Arrow("Blue", random.Next(1, 20)));
                }
            }
        }
        public void Game()
        {
            bool skipTurnBlue = false;
            bool skipTurnRed = false;

            for (int i = 0; i < 20; i++)
            {
                if (arrows[i].Color == "Red" && balloons[i].Color == "Red")
                {
                    if (skipTurnRed)
                    {
                        Console.WriteLine("Red skipped.");
                        skipTurnRed = false;

                    }
                    else if (arrows[i].Size >= balloons[i].Size)
                    {
                        Console.WriteLine("Red point.");
                        scoreRedTeam++;
                    }
                }
                else if (arrows[i].Color == "Blue" && balloons[i].Color == "Blue")
                {
                    if (skipTurnBlue)
                    {
                        Console.WriteLine("Blue skipped.");
                        skipTurnBlue = false;
                        continue;
                    }
                    else if (arrows[i].Size >= balloons[i].Size)
                    {
                        Console.WriteLine("Blue point.");
                        scoreBlueTeam++;
                    }
                }
                else if (arrows[i].Color == "Red" && balloons[i].Color == "Black")
                {
                    if (skipTurnRed)
                    {
                        Console.WriteLine("Red skipped.");
                        skipTurnRed = false;
                        continue;
                    }
                    else if (arrows[i].Size >= balloons[i].Size)
                    {
                        Console.WriteLine("Red black.");
                        skipTurnRed = true;
                    }
                }
                else if (arrows[i].Color == "Blue" && balloons[i].Color == "Black")
                {
                    if (skipTurnBlue)
                    {
                        Console.WriteLine("Blue skipped.");
                        skipTurnBlue = false;
                        continue;
                    }
                    else if (arrows[i].Size >= balloons[i].Size)
                    {
                        Console.WriteLine("Blue black.");
                        skipTurnBlue = true;
                    }
                }

            }

        }
        public override string ToString()
        {
            return $"The Red team has {scoreRedTeam} points.\n" +
            $"The Blue team has {scoreBlueTeam} points.";
        }
    }
}