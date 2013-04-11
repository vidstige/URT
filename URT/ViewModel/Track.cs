using System;
using URT.Model;

namespace URT.ViewModel
{
    class Track: ITrack
    {
        public double Length { get { return 1d; } }

        public double MapX(double position)
        {
            return Math.Cos(2 * Math.PI * position) * 100d + 100d;
        }
        public double MapY(double position)
        {
            return Math.Sin(2 * Math.PI * position) * 100d + 100d;
        }
    }
}