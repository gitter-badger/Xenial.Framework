﻿using System;

using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates.ActionContainers;

namespace Xenial.Framework.Model.GeneratorUpdaters
{
    /// <summary>
    /// 
    /// </summary>
    [XenialCheckLicence]
    public partial record NavigationOptions
    {
        /// <summary>
        /// Gets or sets the startup navigation item identifier.
        /// </summary>
        /// <value>The startup navigation item identifier.</value>
        /// <autogeneratedoc />
        public string? StartupNavigationItemId { get; set; }

        /// <summary>
        /// Gets or sets the startup navigation item.
        /// </summary>
        /// <value>The startup navigation item.</value>
        /// <autogeneratedoc />
        public Func<IModelNavigationItem, bool>? StartupNavigationItem { get; set; }

        /// <summary>
        /// Gets or sets the default name of the parent image.
        /// </summary>
        /// <value>The default name of the parent image.</value>
        /// <autogeneratedoc />
        public string? DefaultParentImageName { get; set; }

        /// <summary>
        /// Gets or sets the default name of the leaf image.
        /// </summary>
        /// <value>The default name of the leaf image.</value>
        /// <autogeneratedoc />
        public string? DefaultLeafImageName { get; set; }

        /// <summary>
        /// Gets or sets the navigation style.
        /// </summary>
        /// <value>The navigation style.</value>
        /// <autogeneratedoc />
        public NavigationStyle? NavigationStyle { get; set; }

        /// <summary>
        /// Gets or sets the default child items display style.
        /// </summary>
        /// <value>The default child items display style.</value>
        /// <autogeneratedoc />
        public ItemsDisplayStyle? DefaultChildItemsDisplayStyle { get; set; }

        /// <summary>
        /// Gets or sets the show images.
        /// </summary>
        /// <value>The show images.</value>
        /// <autogeneratedoc />
        public bool? ShowImages { get; set; }
    }
}
