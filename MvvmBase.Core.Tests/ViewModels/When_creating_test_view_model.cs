using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvvmBase.Core.Tests.ViewModels;

namespace MvvmBase.Core.ViewModels
{
    [TestClass]
    public class When_creating_test_view_model
    {
        private TestViewModel _testObject;

        [TestInitialize]
        public void OnInitialize()
        {
            _testObject = new TestViewModel();
        }

        [TestMethod]
        public void Should_have_initialized_all_string_properties_with_an_empty_string()
        {
            Assert.AreEqual(string.Empty, _testObject.StringPropertyA);
            Assert.AreEqual(string.Empty, _testObject.StringPropertyB);
        }

        [TestMethod]
        public void Should_have_initialized_not_initialized_object_property()
        {
            Assert.IsNull(_testObject.ObjectProperty);
        }

        [TestMethod]
        public void Should_have_initialized_int_property_with_default_value()
        {
            Assert.AreEqual(0, _testObject.IntProperty);
        }
    }
}
