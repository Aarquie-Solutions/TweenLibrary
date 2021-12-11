using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public abstract class TweenVector1 : Tween
    {
        public static T Add<T>(GameObject g, float duration) where T : TweenVector1, new()
        {
            return Tween.Get<T>(g, duration);
        }

        public static T Add<T>(GameObject g, float duration, float to) where T : TweenVector1, new()
        {
            var t = Add<T>(g, duration);
            t.ToValue = to;
            return t;
        }

        public float FromValue;
        public float ToValue;

        protected abstract float Value { get; set; }

        protected override void Reset()
        {
            base.Reset();
            FromValue = Value;
            ToValue = Value;
        }

        protected override void UpdateValue(Easings e, float t, float d)
        {
            Value = e.Calculate(t, FromValue, ToValue - FromValue, d);
        }

        public TweenVector1 Relative()
        {
            ToValue += Value;
            return this;
        }

        public TweenVector1 FromRelative(float v)
        {
            FromValue = Value + v;
            Value = FromValue;
            return this;
        }

        public TweenVector1 By()
        {
            return Relative();
        }

        public TweenVector1 From(float v)
        {
            FromValue = v;
            Value = FromValue;
            return this;
        }

        public TweenVector1 FromBy(float v)
        {
            return FromRelative(v);
        }

        public TweenVector1 FromThat()
        {
            FromValue = ToValue;
            ToValue = Value;
            Value = FromValue;
            return this;
        }

        public TweenVector1 FromThatBy()
        {
            FromValue = Value + ToValue;
            ToValue = Value;
            Value = FromValue;
            return this;
        }
    }
}