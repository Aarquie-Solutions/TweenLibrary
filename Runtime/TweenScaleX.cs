using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenScaleX : TweenVector1Scale
    {
        public static TweenScaleX Add(GameObject g, float duration)
        {
            return Add<TweenScaleX>(g, duration);
        }

        public static TweenScaleX Add(GameObject g, float duration, float to)
        {
            return Add<TweenScaleX>(g, duration, to);
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