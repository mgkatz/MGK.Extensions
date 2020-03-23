using System;
using System.Globalization;

namespace MGK.Extensions
{
	public static class DateTimeExtensions
	{
		#region Rounds
		public static DateTime Ceiling(this DateTime source, TimeSpan time)
		{
			long lnTicks = (source.Ticks + time.Ticks - 1) / time.Ticks;
			return new DateTime(lnTicks * time.Ticks);
		}

		public static DateTime Floor(this DateTime source, TimeSpan time)
		{
			long lnTicks = source.Ticks / time.Ticks;
			return new DateTime(lnTicks * time.Ticks);
		}

		public static DateTime Round(this DateTime source, TimeSpan time)
		{
			long lnTicks = (source.Ticks + (time.Ticks / 2)) / time.Ticks;
			return new DateTime(lnTicks * time.Ticks);
		}
		#endregion

		#region Days
		public static string GetDayOfWeekName(this DateTime source, string cultureName)
			=> GetDayOfWeekName(source, new CultureInfo(cultureName));

		public static string GetDayOfWeekName(this DateTime source, CultureInfo cultureInfo)
			=> cultureInfo.DateTimeFormat.GetDayName(source.DayOfWeek);

		public static string[] GetDaysOfWeekNames(this DateTime source, string cultureName)
			=> GetDaysOfWeekNames(source, new CultureInfo(cultureName));

		public static string[] GetDaysOfWeekNames(this DateTime source, CultureInfo cultureInfo)
			=> cultureInfo.DateTimeFormat.DayNames;

		public static string GetDayOfWeekShortName(this DateTime source, string cultureName)
			=> GetDayOfWeekShortName(source, new CultureInfo(cultureName));

		public static string GetDayOfWeekShortName(this DateTime source, CultureInfo cultureInfo)
			=> cultureInfo.DateTimeFormat.GetAbbreviatedDayName(source.DayOfWeek);

		public static string[] GetDaysOfWeekShortNames(this DateTime source, string cultureName)
			=> GetDaysOfWeekShortNames(source, new CultureInfo(cultureName));

		public static string[] GetDaysOfWeekShortNames(this DateTime source, CultureInfo cultureInfo)
			=> cultureInfo.DateTimeFormat.AbbreviatedDayNames;
		#endregion

		#region Months
		public static string GetMonthName(this DateTime source, string cultureName)
			=> source.GetMonthName(new CultureInfo(cultureName));

		public static string GetMonthName(this DateTime source, CultureInfo cultureInfo)
			=> cultureInfo.DateTimeFormat.GetMonthName(source.Month);

		public static string[] GetMonthNames(this DateTime source, string cultureName)
			=> GetMonthNames(source, new CultureInfo(cultureName));

		public static string[] GetMonthNames(this DateTime source, CultureInfo cultureInfo)
			=> cultureInfo.DateTimeFormat.MonthNames;

		public static string GetMonthShortName(this DateTime source, string cultureName)
			=> source.GetMonthShortName(new CultureInfo(cultureName));

		public static string GetMonthShortName(this DateTime source, CultureInfo cultureInfo)
			=> cultureInfo.DateTimeFormat.GetAbbreviatedMonthName(source.Month);

		public static string[] GetMonthShortNames(this DateTime source, string cultureName)
			=> GetMonthShortNames(source, new CultureInfo(cultureName));

		public static string[] GetMonthShortNames(this DateTime source, CultureInfo cultureInfo)
			=> cultureInfo.DateTimeFormat.AbbreviatedMonthNames;
		#endregion
	}
}
