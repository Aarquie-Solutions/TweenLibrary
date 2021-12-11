using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenScaleXY : TweenVector2Scale
    {
        public static TweenScaleXY Add(GameObject g, float duration)
        {
            return Add<TweenScaleXY>(g, duration);
        }

        public static TweenScaleXY Add(GameObject g, float duration, Vector2 to)
        {
            return Add<TweenScaleXY>(g, duration, to);
        }

        public static TweenScaleXY Add(GameObject g, float duration, float toSX, float toSY)
        {
            return Add<TweenScaleXY>(g, duration, toSX, toSY);
        }

        public static TweenScaleXY Add(GameObject g, float duration, float toSXY)
        {
            return Add(g, duration, toSXY, toSXY);
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