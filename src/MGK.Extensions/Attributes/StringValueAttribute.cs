using System;

namespace MGK.Extensions.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    /// <summary>
    /// This attribute is used to represent a string value, for example: a value in an enum.
    /// </summary>
    public class StringValueAttribute : Attribute
    {
        /// <summary>
        /// Gets the string value.
        /// </summary>
        public string StringValue { get; }

        public StringValueAttribute(string value)
        {
            StringValue = value;
        }
    }
}
