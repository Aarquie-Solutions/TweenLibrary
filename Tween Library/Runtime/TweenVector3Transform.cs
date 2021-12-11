using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public abstract class TweenVector3Transform : TweenVector3
    {
        protected abstract Vector3 Vector { get; set; }

        protected override Vector3 Value
        {
            get { return Vector; }
            set { Vector = value; }
        }

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

    public abstract class TweenVector3Position : TweenVector3Transform
    {
        protected override Vector3 Vector
        {
            get { return GetTransform().localPosition; }
            set { GetTransform().localPosition = value; }
        }
    }

    public abstract class TweenVector3Rotation : TweenVector3Transform
    {
        protected override Vector3 Vector
        {
            get { return GetTransform().localRotation.eulerAngles; }
            set { GetTransform().localRotation = Quaternion.Euler(value); }
        }
    }

    public abstract class TweenVector3Scale : TweenVector3Transform
    {
        protected override Vector3 Vector
        {
            get { return GetTransform().localScale; }
            set { GetTransform().localScale = value; }
        }
    }
}