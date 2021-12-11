using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenScaleYZ : TweenVector2Scale
    {
        public static TweenScaleYZ Add(GameObject g, float duration)
        {
            return Add<TweenScaleYZ>(g, duration);
        }

        public static TweenScaleYZ Add(GameObject g, float duration, Vector2 to)
        {
            return Add<TweenScaleYZ>(g, duration, to);
        }

        public static TweenScaleYZ Add(GameObject g, float duration, float toSY, float toSZ)
        {
            return Add<TweenScaleYZ>(g, duration, toSY, toSZ);
        }

        public static TweenScaleYZ Add(GameObject g, float duration, float toSYZ)
        {
            return Add(g, duration, toSYZ, toSYZ);
        }

        protected override Vector2 Value
        {
            get { return new Vector2(Vector.y, Vector.z); }
            set
            {
                var v = Vector;
                v.y = value.x;
                v.z = value.y;
                Vector = v;
            }
        }
    }
}