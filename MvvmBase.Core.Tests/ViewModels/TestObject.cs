using System;

namespace MvvmBase.Core.Tests.ViewModels
{
    public class TestObject : IEquatable<TestObject>
    {
        public string TestValue { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as TestObject);
        }

        public bool Equals(TestObject other)
        {
            return TestValue == other.TestValue;
        }

        public override int GetHashCode()
        {
            return TestValue.GetHashCode();
        }
    }
}
