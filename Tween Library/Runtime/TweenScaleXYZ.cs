using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenScaleXYZ : TweenVector3Scale
    {
        public static TweenScaleXYZ Add(GameObject g, float duration)
        {
            return Add<TweenScaleXYZ>(g, duration);
        }

        public static TweenScaleXYZ Add(GameObject g, float duration, Vector3 to)
        {
            return Add<TweenScaleXYZ>(g, duration, to);
        }

        public static TweenScaleXYZ Add(GameObject g, float duration, float toSX, float toSY, float toSZ)
        {
            return Add<TweenScaleXYZ>(g, duration, toSX, toSY, toSZ);
        }

        public static TweenScaleXYZ Add(GameObject g, float duration, float toSXYZ)
        {
            return Add(g, duration, toSXYZ, toSXYZ, toSXYZ);
        }
    }
}