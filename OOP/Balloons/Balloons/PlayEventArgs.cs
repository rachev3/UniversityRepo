using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balloons
{
    public class PlayEventArgs : EventArgs
    {
        public int TurnNumber { get; }
        public string ArrowColor { get; }
        public string BalloonColor { get; }
        public int ArrowSize { get; }
        public int BalloonSize { get; }
        public string Result { get; }

        public PlayEventArgs(int turn, string arrowColor, string balloonColor, int arrowSize, int balloonSize, string result)
        {
            TurnNumber = turn;
            ArrowColor = arrowColor;
            BalloonColor = balloonColor;
            ArrowSize = arrowSize;
            BalloonSize = balloonSize;
            Result = result;
        }
    }
}
