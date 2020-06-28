using MGK.Extensions.Attributes;
using MGK.Extensions.Constants;

namespace MGK.Extensions.Enums
{
	public enum IndentationCharacter
	{
		[StringValue(StringConstants.Space)]
		Space = 0,

		[StringValue(StringConstants.Tab)]
		Tab = 1
	}
}
