using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenRotationZ : TweenVector1Rotation
    {
        public static TweenRotationZ Add(GameObject g, float duration)
        {
            return Add<TweenRotationZ>(g, duration);
        }

        public static TweenRotationZ Add(GameObject g, float duration, float to)
        {
            return Add<TweenRotationZ>(g, duration, to);
        }

        protected override float Value
        {
            get { return Vector.z; }
            set
            {
                var v = Vector;
                v.z = value;
                Vector = v;
            }
        }
    }
}