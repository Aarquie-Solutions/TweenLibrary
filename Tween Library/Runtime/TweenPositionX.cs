using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenPositionX : TweenVector1Position
    {
        public static TweenPositionX Add(GameObject g, float duration)
        {
            return Add<TweenPositionX>(g, duration);
        }

        public static TweenPositionX Add(GameObject g, float duration, float to)
        {
            return Add<TweenPositionX>(g, duration, to);
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