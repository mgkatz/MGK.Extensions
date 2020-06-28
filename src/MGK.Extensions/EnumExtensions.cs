using MGK.Extensions.Attributes;
using System;

namespace MGK.Extensions
{
	public static class EnumExtensions
	{
        /// <summary>
        /// Will get the string value for a given enum value, this will only work if you assign the StringValue
        /// attribute to the items in your enum.
        /// </summary>
        /// <param name="value">The enum value.</param>
        /// <returns>The string value of an enum.</returns>
        public static string GetStringValue(this Enum value)
        {
            // Get the string value attributes
            var attribs = value
                .GetType()
                .GetField(value.ToString())
                .GetCustomAttributes(typeof(StringValueAttribute), false) as StringValueAttribute[];

            // Return the first if there was a match.
            return attribs.Length > 0 ? attribs[0].StringValue : null;
        }
    }
}
