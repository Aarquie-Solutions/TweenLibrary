using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public abstract class TweenVector3 : Tween
    {
        public static T Add<T>(GameObject g, float duration) where T : TweenVector3, new()
        {
            return Tween.Get<T>(g, duration);
        }

        public static T Add<T>(GameObject g, float duration, Vector3 to) where T : TweenVector3, new()
        {
            var t = Add<T>(g, duration);
            t.ToValue = to;
            return t;
        }

        public static T Add<T>(GameObject g, float duration, float x, float y, float z) where T : TweenVector3, new()
        {
            return Add<T>(g, duration, new Vector3(x, y, z));
        }

        public Vector3 FromValue;
        public Vector3 ToValue;

        protected abstract Vector3 Value { get; set; }

        protected override void Reset()
        {
            base.Reset();
            FromValue = Value;
            ToValue = Value;
        }

        protected override void UpdateValue(Easings e, float t, float d)
        {
            var v = Vector3.zero;
            v.x = e.Calculate(t, FromValue.x, ToValue.x - FromValue.x, d);
            v.y = e.Calculate(t, FromValue.y, ToValue.y - FromValue.y, d);
            v.z = e.Calculate(t, FromValue.z, ToValue.z - FromValue.z, d);
            Value = v;
        }

        public TweenVector3 Relative()
        {
            ToValue += Value;
            return this;
        }

        public TweenVector3 By()
        {
            return Relative();
        }

        public TweenVector3 From(Vector3 v)
        {
            FromValue = v;
            Value = FromValue;
            return this;
        }

        public TweenVector3 FromRelative(Vector3 v)
        {
            FromValue = Value + v;
            Value = FromValue;
            return this;
        }

        public TweenVector3 FromRelative(float x, float y, float z)
        {
            return FromRelative(new Vector3(x, y, z));
        }

        public TweenVector3 FromRelative(float v)
        {
            return FromRelative(v, v, v);
        }

        public TweenVector3 From(float x, float y, float z)
        {
            return From(new Vector3(x, y, z));
        }

        public TweenVector3 From(float v)
        {
            return From(v, v, v);
        }

        public TweenVector3 FromBy(Vector3 v)
        {
            return FromRelative(v);
        }

        public TweenVector3 FromBy(float x, float y, float z)
        {
            return FromRelative(x, y, z);
        }

        public TweenVector3 FromBy(float v)
        {
            return FromRelative(v);
        }

        public TweenVector3 FromThat()
        {
            FromValue = ToValue;
            ToValue = Value;
            Value = FromValue;
            return this;
        }

        public TweenVector3 FromThatBy()
        {
            FromValue = Value + ToValue;
            ToValue = Value;
            Value = FromValue;
            return this;
        }
    }
}