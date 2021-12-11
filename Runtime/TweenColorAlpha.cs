using UnityEngine;
using UnityEngine.UI;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenColorAlpha : TweenVector4
    {
        public static TweenColorAlpha Add(GameObject g, float duration)
        {
            return Add<TweenColorAlpha>(g, duration);
        }

        public static TweenColorAlpha Add(GameObject g, float duration, Vector4 to)
        {
            return Add<TweenColorAlpha>(g, duration, to);
        }

        public static TweenColorAlpha Add(GameObject g, float duration, Color to)
        {
            return Add<TweenColorAlpha>(g, duration, (Vector4) to);
        }

        public static TweenColorAlpha Add(GameObject g, float duration, float toR, float toG, float toB, float toA)
        {
            return Add<TweenColorAlpha>(g, duration, toR, toG, toB, toA);
        }

        private Graphic G;

        protected Graphic GetGraphic()
        {
            if (G == null)
            {
                G = Object.GetComponent<Graphic>();
            }

            return G;
        }

        protected override Vector4 Value
        {
            get { return GetGraphic().color; }
            set { GetGraphic().color = value; }
        }
    }
}