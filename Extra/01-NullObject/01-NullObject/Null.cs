﻿using ImpromptuInterface;
using System;
using System.Dynamic;

namespace _01_NullObject
{
    public class Null<T> : DynamicObject where T : class
    {
        public static T Instance
        {
            get
            {
                if (!typeof(T).IsInterface)
                    throw new ArgumentException("I must be an interface type");

                return new Null<T>().ActLike<T>();
            }
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            result = Activator.CreateInstance(binder.ReturnType);
            return true;
        }

    }
}
