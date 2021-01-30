using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvvmBase.Core.Tests.ViewModels;
using MvvmBase.Core.Commands;

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

        [TestMethod]
        public void Should_have_done_nothing()
        {
            _testObject.DoNothingCommand.Execute(null);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Should_initialize_object_correct()
        {
            _testObject.ModifyObjectPropertyCommand.Execute(null);

            var expected = new TestObject
            {
                TestValue = "Test"
            };

            var actual = _testObject.ObjectProperty;

            var areEqual = expected.Equals(actual);

            Assert.IsTrue(areEqual);
        }

        [TestMethod]
        public void Should_modify_int_property_correct()
        {
            Assert.AreEqual(0, _testObject.IntProperty);

            _testObject.ModifyIntPropertyCommand.Execute(10);

            Assert.AreEqual(10, _testObject.IntProperty);
        }
    }
}
