﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DevExpress.ExpressApp;

namespace Xenial.Framework
{
    /// <summary>
    /// Class ObjectSpaceExtensions.
    /// </summary>
    /// <autogeneratedoc />
    public static class ObjectSpaceExtensions
    {
        /// <summary>
        /// Gets the singleton.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objectSpace">The object space.</param>
        /// <returns>T.</returns>
        /// <autogeneratedoc />
        public static T GetSingleton<T>(this IObjectSpace objectSpace)
        {
            _ = objectSpace ?? throw new ArgumentNullException(nameof(objectSpace));
            var obj = objectSpace.FindObject<T>(null, true);
            if (obj is T tObject)
            {
                return tObject;
            }
            return objectSpace.CreateObject<T>();
        }

        /// <summary>
        /// Returns an <see cref="IObjectSpace" /> for the specified type.
        /// </summary>
        /// <param name="baseObject">The base object.</param>
        /// <param name="type">The type.</param>
        /// <returns>System.Nullable&lt;IObjectSpace&gt;.</returns>
        /// <exception cref="ArgumentNullException">baseObject</exception>
        public static IObjectSpace? ObjectSpaceFor(this IObjectSpaceLink baseObject, Type type)
        {
            _ = baseObject ?? throw new ArgumentNullException(nameof(baseObject));

            if (baseObject.ObjectSpace is NonPersistentObjectSpace nonPersistentObjectSpace)
            {
                return nonPersistentObjectSpace.AdditionalObjectSpaces.FirstOrDefault(os => os.CanInstantiate(type));
            }
            return baseObject.ObjectSpace;
        }

        /// <summary>
        /// Returns an <see cref="IObjectSpace"/> for the specified type.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns></returns>
        public static IObjectSpace? ObjectSpaceFor<T>(this IObjectSpaceLink baseObject)
            => baseObject.ObjectSpaceFor(typeof(T));
    }
}