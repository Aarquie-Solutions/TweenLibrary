using UnityEngine;
using UnityEngine.UI;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenAlpha : TweenVector1
    {
        public static TweenAlpha Add(GameObject g, float duration)
        {
            return Add<TweenAlpha>(g, duration);
        }

        public static TweenAlpha Add(GameObject g, float duration, float to)
        {
            return Add<TweenAlpha>(g, duration, to);
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

        protected override float Value
        {
            get { return GetGraphic().color.a; }
            set
            {
                var g = GetGraphic();
                var c = g.color;
                c.a = value;
                g.color = c;
            }
        }
    }
}