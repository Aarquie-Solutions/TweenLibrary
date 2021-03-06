using UnityEngine;

namespace AarquieSolutions.TweenLibrary
{
    public abstract class TweenVector2 : Tween
    {
        public static T Add<T>(GameObject g, float duration) where T : TweenVector2, new()
        {
            return Tween.Get<T>(g, duration);
        }

        public static T Add<T>(GameObject g, float duration, Vector2 to) where T : TweenVector2, new()
        {
            var t = Add<T>(g, duration);
            t.ToValue = to;
            return t;
        }

        public static T Add<T>(GameObject g, float duration, float v1, float v2) where T : TweenVector2, new()
        {
            return Add<T>(g, duration, new Vector2(v1, v2));
        }

        public Vector2 FromValue;
        public Vector2 ToValue;

        protected abstract Vector2 Value { get; set; }

        protected override void Reset()
        {
            base.Reset();
            FromValue = Value;
            ToValue = Value;
        }

        protected override void UpdateValue(Easings e, float t, float d)
        {
            var v = Vector2.zero;
            v.x = e.Calculate(t, FromValue.x, ToValue.x - FromValue.x, d);
            v.y = e.Calculate(t, FromValue.y, ToValue.y - FromValue.y, d);
            Value = v;
        }

        public TweenVector2 Relative()
        {
            ToValue += Value;
            return this;
        }

        public TweenVector2 FromRelative(Vector2 v)
        {
            FromValue = Value + v;
            Value = FromValue;
            return this;
        }

        public TweenVector2 FromRelative(float v1, float v2)
        {
            return FromRelative(new Vector2(v1, v2));
        }

        public TweenVector2 FromRelative(float v)
        {
            return FromRelative(v, v);
        }

        public TweenVector2 By()
        {
            return Relative();
        }

        public TweenVector2 From(Vector2 v)
        {
            FromValue = v;
            Value = FromValue;
            return this;
        }

        public TweenVector2 From(float v1, float v2)
        {
            return From(new Vector2(v1, v2));
        }

        public TweenVector2 From(float v)
        {
            return From(v, v);
        }

        public TweenVector2 FromBy(Vector2 v)
        {
            return FromRelative(v);
        }

        public TweenVector2 FromBy(float v1, float v2)
        {
            return FromRelative(v1, v2);
        }

        public TweenVector2 FromBy(float v)
        {
            return FromRelative(v);
        }

        public TweenVector2 FromThat()
        {
            FromValue = ToValue;
            ToValue = Value;
            Value = FromValue;
            return this;
        }

        public TweenVector2 FromThatBy()
        {
            FromValue = Value + ToValue;
            ToValue = Value;
            Value = FromValue;
            return this;
        }
    }
}