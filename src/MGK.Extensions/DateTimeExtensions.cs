using MGK.Extensions.Enums;
using System.Globalization;

namespace MGK.Extensions;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Roslynator", "RCS1175:Unused 'this' parameter.", Justification = "<Pending>")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>")]
public static class DateTimeExtensions
{
	#region Days
	/// <summary>
	/// Gets the name of the day of week of a given date using the current culture.
	/// </summary>
	/// <param name="source">The given date.</param>
	/// <returns>The name of the day of week.</returns>
	public static string GetDayOfWeekName(this DateTime source)
		=> GetDayOfWeekName(source, CultureInfo.CurrentCulture);

	/// <summary>
	/// Gets the name of the day of week of a given date using a specific culture.
	/// </summary>
	/// <param name="source">The given date.</param>
	/// <param name="cultureName">The specific culture.</param>
	/// <returns>The name of the day of week.</returns>
	public static string GetDayOfWeekName(this DateTime source, string cultureName)
		=> GetDayOfWeekName(source, new CultureInfo(cultureName));

	/// <summary>
	/// Gets the name of the day of week of a given date using a specific culture.
	/// </summary>
	/// <param name="source">The given date.</param>
	/// <param name="cultureInfo">The specific culture.</param>
	/// <returns>The name of the day of week.</returns>
	public static string GetDayOfWeekName(this DateTime source, CultureInfo cultureInfo)
		=> cultureInfo.DateTimeFormat.GetDayName(source.DayOfWeek);

	/// <summary>
	/// Gets the short name of the day of week of a given date using the current culture.
	/// </summary>
	/// <param name="source">The given date.</param>
	/// <returns>The short name of the day of week.</returns>
	public static string GetDayOfWeekShortName(this DateTime source)
		=> GetDayOfWeekShortName(source, CultureInfo.CurrentCulture);

	/// <summary>
	/// Gets the short name of the day of week of a given date using a specific culture.
	/// </summary>
	/// <param name="source">The given date.</param>
	/// <param name="cultureName">The specific culture.</param>
	/// <returns>The short name of the day of week.</returns>
	public static string GetDayOfWeekShortName(this DateTime source, string cultureName)
		=> GetDayOfWeekShortName(source, new CultureInfo(cultureName));

	/// <summary>
	/// Gets the short name of the day of week of a given date using a specific culture.
	/// </summary>
	/// <param name="source">The given date.</param>
	/// <param name="cultureInfo">The specific culture.</param>
	/// <returns>The short name of the day of week.</returns>
	public static string GetDayOfWeekShortName(this DateTime source, CultureInfo cultureInfo)
		=> cultureInfo.DateTimeFormat.GetAbbreviatedDayName(source.DayOfWeek);

	/// <summary>
	/// Gets the list of the names of the days of week using the current culture.
	/// </summary>
	/// <returns>The names of the days of week.</returns>
	public static string[] GetDaysOfWeekNames(this DateTime source)
		=> GetDaysOfWeekNames(source, CultureInfo.CurrentCulture);

	/// <summary>
	/// Gets the list of the names of the days of week using a specific culture.
	/// </summary>
	/// <param name="cultureName">The specific culture.</param>
	/// <returns>The names of the days of week.</returns>
	public static string[] GetDaysOfWeekNames(this DateTime source, string cultureName)
		=> GetDaysOfWeekNames(source, new CultureInfo(cultureName));

    /// <summary>
    /// Gets the list of the names of the days of week using a specific culture.
    /// </summary>
    /// <param name="cultureInfo">The specific culture.</param>
    /// <returns>The names of the days of week.</returns>
    public static string[] GetDaysOfWeekNames(this DateTime source, CultureInfo cultureInfo)
        => cultureInfo.DateTimeFormat.DayNames;

	/// <summary>
	/// Gets the list of the short names of the days of week using the current culture.
	/// </summary>
	/// <returns>The short names of the days of week.</returns>
	public static string[] GetDaysOfWeekShortNames(this DateTime source)
		=> GetDaysOfWeekShortNames(source, CultureInfo.CurrentCulture);

	/// <summary>
	/// Gets the list of the names of the days of week using a specific culture.
	/// </summary>
	/// <param name="cultureName">The specific culture.</param>
	/// <returns>The short names of the days of week.</returns>
	public static string[] GetDaysOfWeekShortNames(this DateTime source, string cultureName)
		=> GetDaysOfWeekShortNames(source, new CultureInfo(cultureName));

    /// <summary>
    /// Gets the list of the short names of the days of week using a specific culture.
    /// </summary>
    /// <param name="cultureInfo">The specific culture.</param>
    /// <returns>The short names of the days of week.</returns>
    public static string[] GetDaysOfWeekShortNames(this DateTime source, CultureInfo cultureInfo)
		=> cultureInfo.DateTimeFormat.AbbreviatedDayNames;
	#endregion

	#region Months
	/// <summary>
	/// Gets the name of the month of a given date using the current culture.
	/// </summary>
	/// <param name="source">The given date.</param>
	/// <returns>The name of the month.</returns>
	public static string GetMonthName(this DateTime source)
		=> GetMonthName(source, CultureInfo.CurrentCulture);

	/// <summary>
	/// Gets the name of the month of a given date using a specific culture.
	/// </summary>
	/// <param name="source">The given date.</param>
	/// <param name="cultureName">The specific culture.</param>
	/// <returns>The name of the month.</returns>
	public static string GetMonthName(this DateTime source, string cultureName)
		=> GetMonthName(source, new CultureInfo(cultureName));

	/// <summary>
	/// Gets the name of the month of a given date using a specific culture.
	/// </summary>
	/// <param name="source">The given date.</param>
	/// <param name="cultureInfo">The specific culture.</param>
	/// <returns>The name of the month.</returns>
	public static string GetMonthName(this DateTime source, CultureInfo cultureInfo)
		=> cultureInfo.DateTimeFormat.GetMonthName(source.Month);

	/// <summary>
	/// Gets the list of the names of the months using the current culture.
	/// </summary>
	/// <returns>The names of the months.</returns>
	public static string[] GetMonthNames(this DateTime source)
		=> GetMonthNames(source, CultureInfo.CurrentCulture);

	/// <summary>
	/// Gets the list of the names of the months using a specific culture.
	/// </summary>
	/// <param name="cultureName">The specific culture.</param>
	/// <returns>The names of the months.</returns>
	public static string[] GetMonthNames(this DateTime source, string cultureName)
		=> GetMonthNames(source, new CultureInfo(cultureName));

	/// <summary>
	/// Gets the list of the names of the months using a specific culture.
	/// </summary>
	/// <param name="cultureInfo">The specific culture.</param>
	/// <returns>The names of the months.</returns>
	public static string[] GetMonthNames(this DateTime source, CultureInfo cultureInfo)
		=> cultureInfo.DateTimeFormat.MonthNames;

	/// <summary>
	/// Gets the short name of the month of a given date using the current culture.
	/// </summary>
	/// <param name="source">The given date.</param>
	/// <returns>The short name of the month.</returns>
	public static string GetMonthShortName(this DateTime source)
		=> GetMonthShortName(source, CultureInfo.CurrentCulture);

	/// <summary>
	/// Gets the short name of the month of a given date using a specific culture.
	/// </summary>
	/// <param name="source">The given date.</param>
	/// <param name="cultureName">The specific culture.</param>
	/// <returns>The short name of the month.</returns>
	public static string GetMonthShortName(this DateTime source, string cultureName)
		=> GetMonthShortName(source, new CultureInfo(cultureName));

	/// <summary>
	/// Gets the short name of the month of a given date using a specific culture.
	/// </summary>
	/// <param name="source">The given date.</param>
	/// <param name="cultureInfo">The specific culture.</param>
	/// <returns>The short name of the month.</returns>
	public static string GetMonthShortName(this DateTime source, CultureInfo cultureInfo)
		=> cultureInfo.DateTimeFormat.GetAbbreviatedMonthName(source.Month);

	/// <summary>
	/// Gets the list of the short names of the months using the current culture.
	/// </summary>
	/// <returns>The short names of the months.</returns>
	public static string[] GetMonthShortNames(this DateTime source)
		=> GetMonthShortNames(source, CultureInfo.CurrentCulture);

	/// <summary>
	/// Gets the list of the names of the months using a specific culture.
	/// </summary>
	/// <param name="cultureName">The specific culture.</param>
	/// <returns>The short names of the months.</returns>
	public static string[] GetMonthShortNames(this DateTime source, string cultureName)
		=> GetMonthShortNames(source, new CultureInfo(cultureName));

	/// <summary>
	/// Gets the list of the short names of the months using a specific culture.
	/// </summary>
	/// <param name="cultureInfo">The specific culture.</param>
	/// <returns>The short names of the months.</returns>
	public static string[] GetMonthShortNames(this DateTime source, CultureInfo cultureInfo)
		=> cultureInfo.DateTimeFormat.AbbreviatedMonthNames;
    #endregion

    #region Period information and management
	/// <summary>
	/// Adds an interval of time to a datetime value based on a date/time unit.
	/// </summary>
	/// <param name="source">The datetime to be modified.</param>
	/// <param name="interval">The interval to add based on the date/time unit.</param>
	/// <param name="intervalType">The date/time unit.</param>
	/// <returns>The datetime with the interval applied.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Exception thrown when the interval cannot be converted to an int value in the case of months and years, and to a long value in the case of ticks.</exception>
	/// <exception cref="ArgumentException">Exception thrown when the date/time unit provided is not valid.</exception>
	public static DateTime AddInterval(this DateTime source, double interval, DateTimeInterval intervalType)
	{
		return intervalType switch
		{
			DateTimeInterval.Days => source.AddDays(interval),
			DateTimeInterval.Hours => source.AddHours(interval),
			DateTimeInterval.Milliseconds => source.AddMilliseconds(interval),
			DateTimeInterval.Minutes => source.AddMinutes(interval),
			DateTimeInterval.Months => TryParseInterval(interval, out int monthsInterval)
								? source.AddMonths(monthsInterval)
								: throw new ArgumentOutOfRangeException(
									nameof(interval),
									ExtensionsResources.MessagesResources.ErrorIntervalOutOfRange.Format(interval, intervalType, int.MinValue, int.MaxValue)),
			DateTimeInterval.Seconds => source.AddSeconds(interval),
			DateTimeInterval.Ticks => TryParseInterval(interval, out long ticksInterval)
								? source.AddTicks(ticksInterval)
								: throw new ArgumentOutOfRangeException(
									nameof(interval),
									ExtensionsResources.MessagesResources.ErrorIntervalOutOfRange.Format(interval, intervalType, long.MinValue, long.MaxValue)),
			DateTimeInterval.Weeks => source.AddDays(interval * 7),
			DateTimeInterval.Years => TryParseInterval(interval, out int yearsInterval)
								? source.AddYears(yearsInterval)
								: throw new ArgumentOutOfRangeException(
									nameof(interval),
									ExtensionsResources.MessagesResources.ErrorIntervalOutOfRange.Format(interval, intervalType, int.MinValue, int.MaxValue)),
			_ => throw new ArgumentException(
								ExtensionsResources.MessagesResources.ErrorDateTimeIntervalNotRecognized.Format(intervalType),
								nameof(intervalType)),
		};
	}

    /// <summary>
    /// Gets the time elapsed between a given date and the present moment on a specific date/time unit.
    /// </summary>
    /// <param name="source">The given date.</param>
    /// <param name="intervalType">The date/time unit to calculate the time elapsed.</param>
    /// <param name="useUtc">A boolean value to use UTC (true) or not (false) to get the present moment.</param>
    /// <returns>The time elapsed.</returns>
    public static double GetTimeElapsed(this DateTime source, DateTimeInterval intervalType, bool useUtc = true)
        => GetTimeElapsed(source, useUtc ? DateTime.UtcNow : DateTime.Now, intervalType);

    /// <summary>
    /// Gets the time elapsed between two dates on a specific date/time unit.
    /// </summary>
    /// <param name="source">The source date.</param>
    /// <param name="target">The target date.</param>
    /// <param name="useUtc">A boolean value to use UTC (true) or not (false) to get the present moment.</param>
    /// <returns>The time elapsed.</returns>
    public static double GetTimeElapsed(this DateTime source, DateTime target, DateTimeInterval intervalType)
    {
        var firstDay = new DateTime(1, 1, 1);
        TimeSpan difference = target.Subtract(source);

        switch (intervalType)
        {
            case DateTimeInterval.Days:
                return difference.TotalDays;

            case DateTimeInterval.Hours:
                return difference.TotalHours;

            case DateTimeInterval.Milliseconds:
                return difference.TotalMilliseconds;

            case DateTimeInterval.Minutes:
                return Math.Round(difference.TotalMinutes);

            case DateTimeInterval.Months:
                int years = (firstDay + difference).Year - 1;
                return (years * 12) + (firstDay + difference).Month - 1;

            case DateTimeInterval.Seconds:
                return Math.Round(difference.TotalSeconds);

            case DateTimeInterval.Weeks:
                return Math.Ceiling(difference.TotalDays / 7);

            case DateTimeInterval.Years:
                return (firstDay + difference).Year - 1;

            // The default are the ticks
            default:
                return difference.Ticks;
        }
    }

    /// <summary>
    /// Returns a date and time at which a period of time ends from a given date.
    /// </summary>
    /// <param name="source">The given date.</param>
	/// <param name="interval">The period of time to be calculated based on the date/time unit.</param>
	/// <param name="intervalType">The date/time unit.</param>
    /// <param name="daysOfWeekExcluded">An array of days of the week that could be excluded.</param>
    /// <param name="datesExcluded">An array of dates that could be excluded.</param>
    /// <returns>The date and time when the period ends.</returns>
    public static DateTime PeriodEndsAt(
		this DateTime source,
        double interval,
		DateTimeInterval intervalType,
        DayOfWeek[] daysOfWeekExcluded,
		DateOnly[] datesExcluded)
	{
		if (daysOfWeekExcluded.IsNullOrEmpty() && datesExcluded.IsNullOrEmpty())
		{
			return source.AddInterval(interval, intervalType);
		}

		var periodEndsAt = source;
		var counterOfTime = 1;
		bool isDayOfWeekExcluded;
		bool isDateExcluded;

        while (counterOfTime <= interval)
		{
			periodEndsAt = periodEndsAt.AddInterval(1, intervalType);
			isDayOfWeekExcluded = daysOfWeekExcluded.Contains(periodEndsAt.DayOfWeek);
			isDateExcluded = datesExcluded.Contains(DateOnly.FromDateTime(periodEndsAt.Date));

            if (!isDayOfWeekExcluded && !isDateExcluded)
			{
				counterOfTime++;
			}
		}

		isDayOfWeekExcluded = daysOfWeekExcluded.Contains(source.DayOfWeek);
		isDateExcluded = datesExcluded.Contains(DateOnly.FromDateTime(source.Date));

        if (isDayOfWeekExcluded || isDateExcluded)
		{
			periodEndsAt = periodEndsAt.AddInterval(1, intervalType);
		}

		return periodEndsAt;
	}

    /// <summary>
    /// Given a certain date, it evaluates if a period of time has already passed and therefore has expired.
    /// </summary>
    /// <param name="source">The given date.</param>
	/// <param name="interval">The period of time to be calculated based on the date/time unit.</param>
	/// <param name="intervalType">The date/time unit.</param>
    /// <param name="daysOfWeekExcluded">An array of days of the week that could be excluded.</param>
    /// <param name="datesExcluded">An array of dates that could be excluded.</param>
    /// <returns>True when the period has expired, otherwise false.</returns>
    public static bool PeriodHasExpired(
		this DateTime source,
		double interval,
		DateTimeInterval intervalType,
		DayOfWeek[] daysOfWeekExcluded,
		DateOnly[] datesExcluded)
	{
		DateTime periodEndsAt = PeriodEndsAt(source, interval, intervalType, daysOfWeekExcluded, datesExcluded);
		return periodEndsAt < DateTime.UtcNow;
	}
    #endregion

    #region Private methods
	/// <summary>
	/// Try to parse an interval expressed as a double value to an integer value.
	/// </summary>
	/// <param name="interval">The interval to parse.</param>
	/// <param name="result">The interval parsed.</param>
	/// <returns>The interval parsed.</returns>
    private static bool TryParseInterval(double interval, out int result)
	{
		bool isTheConversionValid = interval >= int.MinValue && interval <= int.MaxValue;
		result = isTheConversionValid ? Convert.ToInt32(interval) : 0;
		return isTheConversionValid;
    }

    /// <summary>
    /// Try to parse an interval expressed as a double value to an long value.
    /// </summary>
    /// <param name="interval">The interval to parse.</param>
    /// <param name="result">The interval parsed.</param>
    /// <returns>The interval parsed.</returns>
    private static bool TryParseInterval(double interval, out long result)
    {
        bool isTheConversionValid = interval >= long.MinValue && interval <= long.MaxValue;
        result = isTheConversionValid ? Convert.ToInt64(interval) : 0;
        return isTheConversionValid;
    }
    #endregion
}
