using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenRotationY : TweenVector1Rotation
    {
        public static TweenRotationY Add(GameObject g, float duration)
        {
            return Add<TweenRotationY>(g, duration);
        }

        public static TweenRotationY Add(GameObject g, float duration, float to)
        {
            return Add<TweenRotationY>(g, duration, to);
        }

        protected override float Value
        {
            get { return Vector.y; }
            set
            {
                var v = Vector;
                v.y = value;
                Vector = v;
            }
        }
    }
}