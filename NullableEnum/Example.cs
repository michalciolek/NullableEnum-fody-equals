#nullable enable

namespace NullableEnum
{
    [Equals]
    public class Example
    {
        /// <summary>
        /// This adds circular reference to self (NullableEnum.exe)!
        /// </summary>
        public ExampleEnum? ExampleEnum { get; set; }


        public static bool operator ==(Example? left, Example? right) => Operator.Weave(left, right);
        public static bool operator !=(Example? left, Example? right) => Operator.Weave(left, right);
    }
}
