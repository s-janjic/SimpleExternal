// <copyright file="AimbotTest.cs">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Smurf.GlobalOffensive.Updaters;

namespace Smurf.GlobalOffensive.Updaters.Tests
{
    [TestClass]
    [PexClass(typeof(Aimbot))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AimbotTest
    {

        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        public void Update([PexAssumeUnderTest]Aimbot target)
        {
            target.Update();
            // TODO: add assertions to method AimbotTest.Update(Aimbot)
        }
    }
}
