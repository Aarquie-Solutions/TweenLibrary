using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public abstract class TweenVector1Transform : TweenVector1
    {
        protected abstract Vector3 Vector { get; set; }

        private Transform T;

        protected Transform GetTransform()
        {
            if (T == null)
            {
                T = Object.transform;
            }

            return T;
        }
    }

    public abstract class TweenVector1Position : TweenVector1Transform
    {
        protected override Vector3 Vector
        {
            get { return GetTransform().localPosition; }
            set { GetTransform().localPosition = value; }
        }
    }

    public abstract class TweenVector1Rotation : TweenVector1Transform
    {
        protected override Vector3 Vector
        {
            get { return GetTransform().localRotation.eulerAngles; }
            set { GetTransform().localRotation = Quaternion.Euler(value); }
        }
    }

    public abstract class TweenVector1Scale : TweenVector1Transform
    {
        protected override Vector3 Vector
        {
            get { return GetTransform().localScale; }
            set { GetTransform().localScale = value; }
        }
    }
}