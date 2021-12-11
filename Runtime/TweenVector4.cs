using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public abstract class TweenVector4 : Tween
    {
        public static T Add<T>(GameObject g, float duration) where T : TweenVector4, new()
        {
            return Tween.Get<T>(g, duration);
        }

        public static T Add<T>(GameObject g, float duration, Vector4 to) where T : TweenVector4, new()
        {
            var t = Add<T>(g, duration);
            t.ToValue = to;
            return t;
        }

        public static T Add<T>(GameObject g, float duration, float x, float y, float z, float w) where T : TweenVector4, new()
        {
            return Add<T>(g, duration, new Vector4(x, y, z, w));
        }

        public Vector4 FromValue;
        public Vector4 ToValue;

        protected abstract Vector4 Value { get; set; }

        protected override void Reset()
        {
            base.Reset();
            FromValue = Value;
            ToValue = Value;
        }

        protected override void UpdateValue(Easings e, float t, float d)
        {
            var v = Vector4.zero;
            v.x = e.Calculate(t, FromValue.x, ToValue.x - FromValue.x, d);
            v.y = e.Calculate(t, FromValue.y, ToValue.y - FromValue.y, d);
            v.z = e.Calculate(t, FromValue.z, ToValue.z - FromValue.z, d);
            v.w = e.Calculate(t, FromValue.w, ToValue.w - FromValue.w, d);
            Value = v;
        }

        public TweenVector4 Relative()
        {
            ToValue += Value;
            return this;
        }

        public TweenVector4 FromRelative(Vector4 v)
        {
            FromValue = Value + v;
            Value = FromValue;
            return this;
        }

        public TweenVector4 FromRelative(float x, float y, float z, float w)
        {
            return FromRelative(new Vector4(x, y, z, w));
        }

        public TweenVector4 FromRelative(float v)
        {
            return FromRelative(v, v, v, v);
        }

        public TweenVector4 By()
        {
            return Relative();
        }

        public TweenVector4 From(Vector4 v)
        {
            FromValue = v;
            Value = FromValue;
            return this;
        }

        public TweenVector4 From(float x, float y, float z, float w)
        {
            return From(new Vector4(x, y, z, w));
        }

        public TweenVector4 From(float v)
        {
            return From(v, v, v, v);
        }

        public TweenVector4 FromBy(Vector4 v)
        {
            return FromRelative(v);
        }

        public TweenVector4 FromBy(float x, float y, float z, float w)
        {
            return FromRelative(x, y, z, w);
        }

        public TweenVector4 FromBy(float v)
        {
            return FromRelative(v);
        }

        public TweenVector4 FromThat()
        {
            FromValue = ToValue;
            ToValue = Value;
            Value = FromValue;
            return this;
        }

        public TweenVector4 FromThatBy()
        {
            FromValue = Value + ToValue;
            ToValue = Value;
            Value = FromValue;
            return this;
        }
    }
}