﻿using System;
using System.Collections.Generic;
using System.Text;

using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Model.Core;
using DevExpress.ExpressApp.SystemModule;

using Xenial.Framework.Base;
using Xenial.Framework.Model.GeneratorUpdaters;

namespace Xenial.Framework.Model.GeneratorUpdaters
{
    /// <summary>
    /// Class SingletonNavigationItemNodesUpdater.
    /// Implements the <see cref="DevExpress.ExpressApp.Model.ModelNodesGeneratorUpdater{DevExpress.ExpressApp.SystemModule.NavigationItemNodeGenerator}" />
    /// </summary>
    /// <seealso cref="DevExpress.ExpressApp.Model.ModelNodesGeneratorUpdater{DevExpress.ExpressApp.SystemModule.NavigationItemNodeGenerator}" />
    /// <autogeneratedoc />
    [XenialCheckLicence]
    public sealed partial class SingletonNavigationItemNodesUpdater : ModelNodesGeneratorUpdater<NavigationItemNodeGenerator>
    {
        /// <summary>
        /// Updates the Application Model node content generated by the Nodes Generator, specified by the <see cref="T:DevExpress.ExpressApp.Model.ModelNodesGeneratorUpdater`1" /> class' type parameter.
        /// </summary>
        /// <param name="node">A ModelNode Application Model node to be updated.</param>
        /// <autogeneratedoc />
        public override void UpdateNode(ModelNode node)
        {
            if (node is IModelRootNavigationItems rootNavigationItems)
            {
                foreach (var item in rootNavigationItems.Items)
                {
                    UpdateNode(item);
                }
            }

            static void UpdateNode(IModelNavigationItem item)
            {
                if (item.View is IModelObjectView modelObjectView && item.View is IModelListView)
                {
                    if (modelObjectView.ModelClass.TypeInfo.IsAttributeDefined<SingletonAttribute>(false))
                    {
                        item.View = modelObjectView.ModelClass.DefaultDetailView;
                    }
                }
                foreach (var nestedNode in item.Items)
                {
                    UpdateNode(nestedNode);
                }
            }
        }
    }
}

namespace DevExpress.ExpressApp.Model.Core
{
    /// <summary>
    /// Class SingletonNavigationItemNodesUpdaterExtensions.
    /// </summary>
    /// <autogeneratedoc />
    public static class SingletonNavigationItemNodesUpdaterExtensions
    {
        /// <summary>
        /// Uses the singleton navigation items.
        /// </summary>
        /// <param name="modelNodesGeneratorUpdaters">The model nodes generator updaters.</param>
        /// <returns>ModelNodesGeneratorUpdaters.</returns>
        /// <autogeneratedoc />
        public static ModelNodesGeneratorUpdaters UseSingletonNavigationItems(this ModelNodesGeneratorUpdaters modelNodesGeneratorUpdaters)
        {
            _ = modelNodesGeneratorUpdaters ?? throw new ArgumentNullException(nameof(modelNodesGeneratorUpdaters));
            modelNodesGeneratorUpdaters.Add(new SingletonNavigationItemNodesUpdater());
            return modelNodesGeneratorUpdaters;
        }
    }
}
