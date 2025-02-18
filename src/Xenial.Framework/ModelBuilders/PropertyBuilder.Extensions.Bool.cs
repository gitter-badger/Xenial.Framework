﻿
using System;

using DevExpress.Persistent.Base;

namespace Xenial.Framework.ModelBuilders
{
    public static partial class PropertyBuilderExtensions
    {
        /// <summary>
        /// Withes the captions.
        /// </summary>
        /// <typeparam name="TClassType">The type of the t class type.</typeparam>
        /// <param name="builder">The builder.</param>
        /// <param name="trueCaption">The true caption.</param>
        /// <param name="falseCaption">The false caption.</param>
        /// <returns>IPropertyBuilder&lt;System.Boolean, TClassType&gt;.</returns>
        /// <exception cref="ArgumentNullException">builder</exception>
        /// <autogeneratedoc />
        public static IPropertyBuilder<bool, TClassType> WithCaptions<TClassType>(this IPropertyBuilder<bool, TClassType> builder, string trueCaption, string falseCaption)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));
            return builder.WithAttribute(new CaptionsForBoolValuesAttribute(trueCaption, falseCaption));
        }

        /// <summary>
        /// Withes the images.
        /// </summary>
        /// <typeparam name="TClassType">The type of the t class type.</typeparam>
        /// <param name="builder">The builder.</param>
        /// <param name="trueImageName">Name of the true image.</param>
        /// <param name="falseImageName">Name of the false image.</param>
        /// <returns>IPropertyBuilder&lt;System.Boolean, TClassType&gt;.</returns>
        /// <exception cref="ArgumentNullException">builder</exception>
        /// <autogeneratedoc />
        public static IPropertyBuilder<bool, TClassType> WithImages<TClassType>(this IPropertyBuilder<bool, TClassType> builder, string trueImageName, string falseImageName)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));
            return builder.WithAttribute(new ImagesForBoolValuesAttribute(trueImageName, falseImageName));
        }

        /// <summary>
        /// Withes the captions.
        /// </summary>
        /// <typeparam name="TClassType">The type of the t class type.</typeparam>
        /// <param name="builder">The builder.</param>
        /// <param name="trueCaption">The true caption.</param>
        /// <param name="falseCaption">The false caption.</param>
        /// <returns>IPropertyBuilder&lt;System.Nullable&lt;System.Boolean&gt;, TClassType&gt;.</returns>
        /// <exception cref="ArgumentNullException">builder</exception>
        /// <autogeneratedoc />
        public static IPropertyBuilder<bool?, TClassType> WithCaptions<TClassType>(this IPropertyBuilder<bool?, TClassType> builder, string trueCaption, string falseCaption)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));
            return builder.WithAttribute(new CaptionsForBoolValuesAttribute(trueCaption, falseCaption));
        }

        /// <summary>
        /// Withes the images.
        /// </summary>
        /// <typeparam name="TClassType">The type of the t class type.</typeparam>
        /// <param name="builder">The builder.</param>
        /// <param name="trueImageName">Name of the true image.</param>
        /// <param name="falseImageName">Name of the false image.</param>
        /// <returns>IPropertyBuilder&lt;System.Nullable&lt;System.Boolean&gt;, TClassType&gt;.</returns>
        /// <exception cref="ArgumentNullException">builder</exception>
        /// <autogeneratedoc />
        public static IPropertyBuilder<bool?, TClassType> WithImages<TClassType>(this IPropertyBuilder<bool?, TClassType> builder, string trueImageName, string falseImageName)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));
            return builder.WithAttribute(new ImagesForBoolValuesAttribute(trueImageName, falseImageName));
        }
    }
}
