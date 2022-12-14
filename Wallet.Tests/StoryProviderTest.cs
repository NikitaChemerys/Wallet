using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wallet.Provider;

namespace Wallet.Provider.Tests
{
    [PexClass(typeof(StoryProvider))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class StoryProviderTest
    {
        [PexMethod]
        public void SaveStoryTest(
            [PexAssumeUnderTest]StoryProvider target,
            List<global::Story> listStory
        )
        {
            target.SaveStory(listStory);
        }
    }
}
