using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenPositionY : TweenVector1Position
    {
        public static TweenPositionY Add(GameObject g, float duration)
        {
            return Add<TweenPositionY>(g, duration);
        }

        public static TweenPositionY Add(GameObject g, float duration, float to)
        {
            return Add<TweenPositionY>(g, duration, to);
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