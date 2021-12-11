using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenRotationYZ : TweenVector2Rotation
    {
        public static TweenRotationYZ Add(GameObject g, float duration)
        {
            return Add<TweenRotationYZ>(g, duration);
        }

        public static TweenRotationYZ Add(GameObject g, float duration, float toRY, float toRZ)
        {
            return Add<TweenRotationYZ>(g, duration, toRY, toRZ);
        }

        public static TweenRotationYZ Add(GameObject g, float duration, float toRYZ)
        {
            return Add(g, duration, toRYZ, toRYZ);
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