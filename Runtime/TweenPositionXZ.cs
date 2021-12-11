using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenPositionXZ : TweenVector2Position
    {
        public static TweenPositionXZ Add(GameObject g, float duration)
        {
            return Add<TweenPositionXZ>(g, duration);
        }

        public static TweenPositionXZ Add(GameObject g, float duration, Vector2 to)
        {
            return Add<TweenPositionXZ>(g, duration, to);
        }

        public static TweenPositionXZ Add(GameObject g, float duration, float toX, float toZ)
        {
            return Add<TweenPositionXZ>(g, duration, toX, toZ);
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