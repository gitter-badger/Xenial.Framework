﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Xenial.Framework.Tests.Layouts.TestModelApplicationFactory;
using static Xenial.Tasty;


namespace Xenial.Framework.Tests.Layouts.Items
{
    public static class LayoutIntegrationFacts
    {
        public static void LayoutIntegrationTests() => Describe("Layout integration", () =>
        {
            It("should work with fluent syntax", () =>
            {
                var detailView = CreateComplexDetailViewWithLayout(l => new()
                {
                    //l.TabbedGroup() with
                    //{
                    //    Children = new()
                    //    {
                    //        l.Tab()
                    //    }
                    //}
                });
            });
        });
    }
}
