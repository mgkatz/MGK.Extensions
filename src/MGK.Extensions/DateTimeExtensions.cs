﻿using System;
using System.Globalization;

namespace MGK.Extensions
{
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
	}
}
