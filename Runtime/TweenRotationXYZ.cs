using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public class TweenRotationXYZ : TweenVector3Rotation
    {
        public static TweenRotationXYZ Add(GameObject g, float duration)
        {
            return Add<TweenRotationXYZ>(g, duration);
        }

        public static TweenRotationXYZ Add(GameObject g, float duration, Vector3 to)
        {
            return Add<TweenRotationXYZ>(g, duration, to);
        }

        public static TweenRotationXYZ Add(GameObject g, float duration, float toRX, float toRY, float toRZ)
        {
            return Add<TweenRotationXYZ>(g, duration, toRX, toRY, toRZ);
        }

        public static TweenRotationXYZ Add(GameObject g, float duration, float toRXYZ)
        {
            return Add(g, duration, toRXYZ, toRXYZ, toRXYZ);
        }
    }
}