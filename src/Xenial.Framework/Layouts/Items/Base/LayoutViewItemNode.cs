﻿using System;

using DevExpress.ExpressApp.Model;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable IDE1006 // Naming Styles

namespace Xenial.Framework.Layouts.Items.Base
{
    /// <summary>
    /// 
    /// </summary>
    [XenialCheckLicence]
    public abstract partial record LayoutViewItemNode : LayoutItemLeaf
    {
        /// <summary>
        /// Gets or sets the view item options.
        /// </summary>
        /// <value>The view item options.</value>
        /// <autogeneratedoc />
        public Action<IModelViewItem>? ViewItemOptions { get; set; }
    }
}
