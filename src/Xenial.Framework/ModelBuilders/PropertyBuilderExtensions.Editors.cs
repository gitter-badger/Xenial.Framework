﻿using System;

using DevExpress.Persistent.Base;

namespace Xenial.Framework.ModelBuilders
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class PropertyBuilderExtensions
    {
        /// <summary>
        /// Usings the property editor.
        /// </summary>
        /// <typeparam name="TProperty">The type of the property.</typeparam>
        /// <typeparam name="TClassType">The type of the type.</typeparam>
        /// <param name="builder">The builder.</param>
        /// <param name="propertyEditorTypeName">Name of the property editor type.</param>
        /// <returns></returns>
        public static IPropertyBuilder<TProperty?, TClassType> UsingPropertyEditor<TProperty, TClassType>(this IPropertyBuilder<TProperty?, TClassType> builder, string propertyEditorTypeName)
            => builder.WithModelDefault(ModelDefaults.PropertyEditorType, propertyEditorTypeName);

        /// <summary>
        /// Usings the property editor.
        /// </summary>
        /// <typeparam name="TProperty">The type of the property.</typeparam>
        /// <typeparam name="TClassType">The type of the type.</typeparam>
        /// <param name="builder">The builder.</param>
        /// <param name="propertyEditorType">Type of the property editor.</param>
        /// <returns></returns>
        public static IPropertyBuilder<TProperty?, TClassType> UsingPropertyEditor<TProperty, TClassType>(this IPropertyBuilder<TProperty?, TClassType> builder, Type propertyEditorType)
        {
            _ = propertyEditorType ?? throw new ArgumentNullException(nameof(propertyEditorType));
            return builder.UsingPropertyEditor(propertyEditorType.FullName ?? string.Empty);
        }

        /// <summary>
        /// Usings the editor alias.
        /// </summary>
        /// <typeparam name="TProperty">The type of the property.</typeparam>
        /// <typeparam name="TClassType">The type of the type.</typeparam>
        /// <param name="builder">The builder.</param>
        /// <param name="editorAlias">The editor alias.</param>
        /// <returns></returns>
        public static IPropertyBuilder<TProperty?, TClassType> UsingEditorAlias<TProperty, TClassType>(this IPropertyBuilder<TProperty?, TClassType> builder, string editorAlias)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));
            return builder.WithAttribute(new EditorAliasAttribute(editorAlias));
        }

    }
}
