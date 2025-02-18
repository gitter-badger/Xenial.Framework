﻿using System;
using System.Collections.Generic;

namespace Xenial.Framework.ModelBuilders
{
    /// <summary>
    /// Interface IAggregatedPropertyBuilder
    /// Implements the <see cref="Xenial.Framework.ModelBuilders.IPropertyBuilder{TPropertyType, TClassType}" />
    /// </summary>
    /// <typeparam name="TPropertyType">The type of the t property type.</typeparam>
    /// <typeparam name="TClassType">The type of the t class type.</typeparam>
    /// <seealso cref="Xenial.Framework.ModelBuilders.IPropertyBuilder{TPropertyType, TClassType}" />
    /// <autogeneratedoc />
    public interface IAggregatedPropertyBuilder<TPropertyType, TClassType> : IPropertyBuilder<TPropertyType, TClassType>
    {
        /// <summary>
        /// Gets the property builders.
        /// </summary>
        /// <value>The property builders.</value>
        /// <autogeneratedoc />
        IEnumerable<IPropertyBuilder<TPropertyType, TClassType>> PropertyBuilders { get; }

        /// <summary>
        /// Gets the model builder.
        /// </summary>
        /// <value>The model builder.</value>
        /// <autogeneratedoc />
        IModelBuilder<TClassType> ModelBuilder { get; }
    }
}
