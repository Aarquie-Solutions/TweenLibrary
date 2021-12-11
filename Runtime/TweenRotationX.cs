using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenRotationX : TweenVector1Rotation
    {
        public static TweenRotationX Add(GameObject g, float duration)
        {
            return Add<TweenRotationX>(g, duration);
        }

        public static TweenRotationX Add(GameObject g, float duration, float to)
        {
            return Add<TweenRotationX>(g, duration, to);
        }

        protected override float Value
        {
            get { return Vector.x; }
            set
            {
                var v = Vector;
                v.x = value;
                Vector = v;
            }
        }
    }
}