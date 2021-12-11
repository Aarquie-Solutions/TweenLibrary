using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenRotationXY : TweenVector2Rotation
    {
        public static TweenRotationXY Add(GameObject g, float duration)
        {
            return Add<TweenRotationXY>(g, duration);
        }

        public static TweenRotationXY Add(GameObject g, float duration, Vector2 to)
        {
            return Add<TweenRotationXY>(g, duration, to);
        }

        public static TweenRotationXY Add(GameObject g, float duration, float toRX, float toRY)
        {
            return Add<TweenRotationXY>(g, duration, toRX, toRY);
        }

        public static TweenRotationXY Add(GameObject g, float duration, float toRXY)
        {
            return Add(g, duration, toRXY, toRXY);
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