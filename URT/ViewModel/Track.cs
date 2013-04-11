using System;
using URT.Model;

namespace URT.ViewModel
{
    class Track: ITrack
    {
        public double Length { get { return 1d; } }

        public double MapX(double position)
        {
            return Math.Cos(2 * Math.PI * position) * 100d + 150d;
        }

        public double MapY(double position)
        {
            return Math.Sin(2 * Math.PI * position) * 100d + 150d;
        }

        public double MapAngle(double position)
        {
            const double fullCircle = 360d;
            return fullCircle * position;
        }
    }

    static class TrackExtensions
    {
        public static double Distance(this ITrack track, Car a, Car b)
        {
            if (a.Position < b.Position) return b.Position - a.Position;
            return track.Length + b.Position - a.Position;
        }
    }
}