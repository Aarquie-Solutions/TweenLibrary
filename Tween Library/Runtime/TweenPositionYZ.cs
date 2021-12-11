using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenPositionYZ : TweenVector2Position
    {
        public static TweenPositionYZ Add(GameObject g, float duration)
        {
            return Add<TweenPositionYZ>(g, duration);
        }

        public static TweenPositionYZ Add(GameObject g, float duration, Vector2 to)
        {
            return Add<TweenPositionYZ>(g, duration, to);
        }

        public static TweenPositionYZ Add(GameObject g, float duration, float toY, float toZ)
        {
            return Add<TweenPositionYZ>(g, duration, toY, toZ);
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