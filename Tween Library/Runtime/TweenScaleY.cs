using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenScaleY : TweenVector1Scale
    {
        public static TweenScaleY Add(GameObject g, float duration)
        {
            return Add<TweenScaleY>(g, duration);
        }

        public static TweenScaleY Add(GameObject g, float duration, float to)
        {
            return Add<TweenScaleY>(g, duration, to);
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