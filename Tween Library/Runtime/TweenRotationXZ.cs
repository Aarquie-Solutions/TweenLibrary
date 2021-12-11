using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenRotationXZ : TweenVector2Rotation
    {
        public static TweenRotationXZ Add(GameObject g, float duration)
        {
            return Add<TweenRotationXZ>(g, duration);
        }

        public static TweenRotationXZ Add(GameObject g, float duration, Vector2 to)
        {
            return Add<TweenRotationXZ>(g, duration, to);
        }

        public static TweenRotationXZ Add(GameObject g, float duration, float toRX, float toRZ)
        {
            return Add<TweenRotationXZ>(g, duration, toRX, toRZ);
        }

        public static TweenRotationXZ Add(GameObject g, float duration, float toRXZ)
        {
            return Add(g, duration, toRXZ, toRXZ);
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