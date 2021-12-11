using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenScaleZ : TweenVector1Scale
    {
        public static TweenScaleZ Add(GameObject g, float duration)
        {
            return Add<TweenScaleZ>(g, duration);
        }

        public static TweenScaleZ Add(GameObject g, float duration, float to)
        {
            return Add<TweenScaleZ>(g, duration, to);
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