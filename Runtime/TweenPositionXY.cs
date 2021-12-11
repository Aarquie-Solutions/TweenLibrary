using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenPositionXY : TweenVector2Position
    {
        public static TweenPositionXY Add(GameObject g, float duration)
        {
            return Add<TweenPositionXY>(g, duration);
        }

        public static TweenPositionXY Add(GameObject g, float duration, Vector2 to)
        {
            return Add<TweenPositionXY>(g, duration, to);
        }

        public static TweenPositionXY Add(GameObject g, float duration, float toX, float toY)
        {
            return Add<TweenPositionXY>(g, duration, toX, toY);
        }

        protected override Vector2 Value
        {
            get { return new Vector2(Vector.x, Vector.y); }
            set
            {
                var v = Vector;
                v.x = value.x;
                v.y = value.y;
                Vector = v;
            }
        }
    }
}