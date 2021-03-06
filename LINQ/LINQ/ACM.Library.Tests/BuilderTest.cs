// <copyright file="BuilderTest.cs">Copyright ©  2017</copyright>
using System;
using System.Collections.Generic;
using ACM.Library;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.Library.Tests
{
    /// <summary>This class contains parameterized unit tests for Builder</summary>
    [PexClass(typeof(Builder))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class BuilderTest
    {
        /// <summary>Test stub for BuildIntegersSequence()</summary>
        [PexMethod]
        public IEnumerable<int> BuildIntegersSequenceTest([PexAssumeUnderTest]Builder target)
        {
            IEnumerable<int> result = target.BuildIntegersSequence();
            return result;
            // TODO: add assertions to method BuilderTest.BuildIntegersSequenceTest(Builder)
        }
    }
}
