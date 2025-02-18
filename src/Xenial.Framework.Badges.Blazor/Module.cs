﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xenial.Framework.Badges.Blazor
{
    /// <summary>
    /// Class XenialBadgesBlazorModule. This class cannot be inherited.
    /// Implements the <see cref="Xenial.Framework.XenialModuleBase" />
    /// </summary>
    /// <seealso cref="Xenial.Framework.XenialModuleBase" />
    /// <autogeneratedoc />
    [XenialCheckLicence]
    public sealed partial class XenialBadgesBlazorModule : XenialModuleBase
    {
        /// <summary>
        /// returns empty types
        /// </summary>
        /// <returns>IEnumerable&lt;Type&gt;.</returns>
        /// <autogeneratedoc />
        protected override IEnumerable<Type> GetDeclaredControllerTypes() => base.GetDeclaredControllerTypes().Concat(new[]
        {
            typeof(BadgesBlazorNavigationWindowController)
        });
    }
}
