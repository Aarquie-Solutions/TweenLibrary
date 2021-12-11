using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenScaleXZ : TweenVector2Scale
    {
        public static TweenScaleXZ Add(GameObject g, float duration)
        {
            return Add<TweenScaleXZ>(g, duration);
        }

        public static TweenScaleXZ Add(GameObject g, float duration, Vector2 to)
        {
            return Add<TweenScaleXZ>(g, duration, to);
        }

        public static TweenScaleXZ Add(GameObject g, float duration, float toSX, float toSZ)
        {
            return Add<TweenScaleXZ>(g, duration, toSX, toSZ);
        }

        public static TweenScaleXZ Add(GameObject g, float duration, float toSXZ)
        {
            return Add(g, duration, toSXZ, toSXZ);
        }

        protected override Vector2 Value
        {
            get { return new Vector2(Vector.x, Vector.z); }
            set
            {
                var v = Vector;
                v.x = value.x;
                v.z = value.y;
                Vector = v;
            }
        }
    }
}