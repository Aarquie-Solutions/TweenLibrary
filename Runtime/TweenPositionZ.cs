using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenPositionZ : TweenVector1Position
    {
        public static TweenPositionZ Add(GameObject g, float duration)
        {
            return Add<TweenPositionZ>(g, duration);
        }

        public static TweenPositionZ Add(GameObject g, float duration, float to)
        {
            return Add<TweenPositionZ>(g, duration, to);
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