// <copyright file="Form1Test.cs">Copyright ©  2018</copyright>
using System;
using KeywordsExtractor;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KeywordsExtractor.Tests
{
    /// <summary>This class contains parameterized unit tests for Form1</summary>
    [PexClass(typeof(Form1))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class Form1Test
    {
        /// <summary>Test stub for PopulateSourceListView()</summary>
        [PexMethod]
        public void PopulateSourceListViewTest([PexAssumeUnderTest]Form1 target)
        {
            target.PopulateSourceListView();
            // TODO: add assertions to method Form1Test.PopulateSourceListViewTest(Form1)
        }
    }
}
