﻿using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace Tests.Northwind.Core
{
    [TestFixture]
    public class RegionTests
    {
        [Test]
        public void CanCreateRegion() {
            string regionDesc = "Northwest";
            RegionWithPublicConstructor region = new RegionWithPublicConstructor(regionDesc);
            Assert.That(region.Description, Is.EqualTo(regionDesc));
        }
    }
}
