---
title: Forecast period rules and scheduling formats
description: Learn about the rules and calendar templates to set forecast periods, including duration, number of occurrences and scheduling format.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.topic: how-to
ms.collection: get-started
ms.date: 01/02/2025
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:08/31/2023
  - ai-gen-title
---

# Forecast period rules and scheduling formats

A forecast period is a time period for which you want to forecast sales. A forecast period defines start date, frequency, number of occurrences, and so on. This article describes the rules that you need to follow when you're adding forecast periods and information about calendar templates that you use to schedule forecast periods.  

## Forecast period rules

The following rules apply when you're adding forecast periods:


|Rule  |Condition  |
|---------|---------|
|Duration of custom periods     |     - Minimum duration: 7 days <br> - Maximum duration: 1 year         |
|Maximum duration across all periods in a forecast     |      - Only annual periods: 3 years <br> - Only weekly, monthly, or quarterly periods: 1 year <br> - Combination of period types: 1 year  <br> **Note:** If you have two or more annual periods, you can't add periods from any other period type.      |
|Maximum number of periods supported     |     - Overall: 17 <br> - Weekly periods: 17 <br> - Monthly periods: 12 <br> - Quarterly periods: 4 <br> - Annual periods: 3         |
|Period types assigned for custom periods     |    The following period types are assigned to custom periods depending on the number of days in the period. The rules, such as maximum number of periods and maximum duration, that apply to the predefined period types also apply to custom periods. <br> - Up to of 7 days (1 week): Weekly <br> - 7 days to 35 days (5 weeks): Monthly <br> - 35 days to 98 days (14 weeks): Quarterly <br> - 98 days to 1 year (52 weeks): Annual |
|Duplicate periods | Not allowed. Duplicate periods&mdash;periods with the same start date and end date&mdash;are not allowed. |


### Scheduling format

A scheduling format is a calendar template that corresponds to the number and grouping of accounting periods in your organization's calendar. You select the scheduling format when you add a forecast period.

The following table describes the templates available for scheduling forecasts.

| Scheduling format | Description |
| --- | --- |
| **Gregorian** | This template uses the most-widely used Gregorian calender with 12 weeks per quarter.  |
| **Broadcast Calendar** | In this pattern, every month has either four or five weeks that all start on Monday and end on Sunday. Broadcast calendar months have either 28 days or 35 days.<br>The key link between the broadcast and Gregorian calendars is that the first week of every broadcast month always contains the first day of the month on the Gregorian calendar. For example, if January 1 falls on a Saturday, the broadcast calendar year begins on the preceding Monday, December 27. Broadcast January has five weeks and ends on January 30. The four weeks of broadcast February begin on January 31. The number of weeks in a broadcast month is based on the number of Sundays that fall in that month. The period ends on the last Sunday of the month.<br>When you choose this option, the **Fiscal Year Start Date** is automatically set to the Monday in the week that contains January 1. To remained aligned with the established broadcast calendar logic, the start date can't be changed. |
| **3-3-3-4**, **3-3-4-3**, **3-4-3-3**, and **4-3-3-3**\* | This pattern divides a year into 13 months of 4 weeks each, with three 3-week months and one 4-week month in each quarter. For example, in the 4-3-3-3 and 3-3-3-4 calendars, the 4-week month falls at the start or end of the quarter, respectively. |
| **4-4-5**, **4-5-4**, and **5-4-4**\* | This pattern divides a year into four quarters of 13 weeks each, with two 4-week months and one 5-week month in each quarter. In the 5-4-4 and 4-4-5 patterns, the 5-week month falls at the start or end of the quarter, respectively. With 13-week quarters, the period always ends on the same day of the week. This pattern is useful for shift or manufacturing planning, because every period is the same length. |
| **Custom** |  If none of the predefined calendar templates match your organization's calendar, select **Custom** and specify the start date and end date of your forecast. The Period Name field is populated based on the start and end dates. You can edit the period name, but it'll not be localized. So, even your non-English users will see the period name in English. Review the [Forecast period rules](#forecast-period-rules) to learn about the duration and period types. |

\*The 4-4-5/4-5-4/5-4-4 and 3-3-3-4/3-3-4-3/3-4-3-3/4-3-3-3 calendars have only 364 days (7 days &times; 52 weeks). You'll need to add a fifty-third week every five or six years, which might make year-on-year comparison difficult. Instead, you can add an extra week to a specific quarter or month each year. Select the **Custom** calender template from the **Scheduling format** list. Then, specify the start date and end date of the week.


## Related information

- [Define forecast properties and scheduling](define-general-properties-scheduling-forecast.md)  
- [Manage forecast periods](manage-forecast-periods.md)  