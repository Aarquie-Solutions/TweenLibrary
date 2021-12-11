using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenPositionXYZ : TweenVector3Position
    {
        public static TweenPositionXYZ Add(GameObject g, float duration)
        {
            return Add<TweenPositionXYZ>(g, duration);
        }

        public static TweenPositionXYZ Add(GameObject g, float duration, Vector3 to)
        {
            return Add<TweenPositionXYZ>(g, duration, to);
        }

        public static TweenPositionXYZ Add(GameObject g, float duration, float toX, float toY, float toZ)
        {
            return Add<TweenPositionXYZ>(g, duration, toX, toY, toZ);
        }

        protected override Vector3 Value
        {
            get { return Vector; }
            set { Vector = value; }
        }
    }
}