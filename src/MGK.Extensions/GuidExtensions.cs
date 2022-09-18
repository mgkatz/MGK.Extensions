namespace MGK.Extensions;

public static class GuidExtensions
{
	/// <summary>
	/// Evaluates if a given Guid value is empty or not.
	/// </summary>
	/// <param name="source">The given Guid value.</param>
	/// <returns>True if the Guid value is empty, otherwise returns false.</returns>
	public static bool IsEmpty(this Guid source)
		=> source == Guid.Empty;
}
