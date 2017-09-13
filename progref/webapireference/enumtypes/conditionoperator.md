---
title: "ConditionOperator EnumType| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 44bb0e44-b2a1-45cd-94cb-470ea5fa594a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ConditionOperator EnumType
[!INCLUDE[./descriptions/conditionoperator.md](./descriptions/conditionoperator.md)]

## Members
Members define the discrete options for the enumeration type.
|Name|Value|Description|
|---|---|---|
|Equal|0|The values are compared for equality.| 
|NotEqual|1|The two values are not equal.| 
|GreaterThan|2|The value is greater than the compared value. | 
|LessThan|3|The value is less than the compared value. | 
|GreaterEqual|4|The value is greater than or equal to the compared value. | 
|LessEqual|5|The value is less than or equal to the compared value.| 
|Like|6|The character string is matched to the specified pattern.| 
|NotLike|7|The character string does not match the specified pattern.| 
|In|8|The value exists in a list of values. | 
|NotIn|9|The given value is not matched to a value in a subquery or a list.  | 
|Between|10|The value is between two values.  | 
|NotBetween|11|The value is not between two values. | 
|Null|12|The value is null.| 
|NotNull|13|The value is not null. | 
|Yesterday|14|The value equals yesterday’s date. | 
|Today|15|The value equals today’s date. | 
|Tomorrow|16|The value equals tomorrow’s date.| 
|Last7Days|17|The value is within the last seven days including today.| 
|Next7Days|18|The value is within the next seven days.| 
|LastWeek|19|The value is within the previous week including Sunday through Saturday. | 
|ThisWeek|20|The value is within the current week. | 
|NextWeek|21|The value is within the next week.| 
|LastMonth|22|The value is within the last month including first day of the last month and last day of the last month. | 
|ThisMonth|23|The value is within the current month. | 
|NextMonth|24|The value is within the next month.| 
|On|25|The value is on a specified date. | 
|OnOrBefore|26|The value is on or before a specified date. | 
|OnOrAfter|27|The value is on or after a specified date.| 
|LastYear|28|The value is within the previous year.  | 
|ThisYear|29|The value is within the current year. | 
|NextYear|30|The value is within the next year.  | 
|LastXHours|31|The value is within the last X hours.| 
|NextXHours|32|The value is within the next X (specified value) hours. | 
|LastXDays|33|The value is within last X days.| 
|NextXDays|34|The value is within the next X (specified value) days.| 
|LastXWeeks|35|The value is within the last X (specified value) weeks. | 
|NextXWeeks|36|The value is within the next X weeks. | 
|LastXMonths|37|The value is within the last X (specified value) months. | 
|NextXMonths|38|The value is within the next X (specified value) months. | 
|LastXYears|39|The value is within the last X years. | 
|NextXYears|40|The value is within the next X years.| 
|EqualUserId|41|The value is equal to the specified user ID.| 
|NotEqualUserId|42|The value is not equal to the specified user ID.| 
|EqualBusinessId|43|The value is equal to the specified business ID.| 
|NotEqualBusinessId|44|The value is not equal to the specified business ID. | 
|ChildOf|45|For internal use only.| 
|Mask|46|The value is found in the specified bit-mask value. | 
|NotMask|47|The value is not found in the specified bit-mask value. | 
|MasksSelect|48|For internal use only.| 
|Contains|49|For an attribute enabled for full-text indexing: the string contains another string. | 
|DoesNotContain|50|The string does not contain another string. | 
|EqualUserLanguage|51|The value is equal to the language for the user.  | 
|NotOn|52|For internal use only. | 
|OlderThanXMonths|53|The value is older than the specified number of months.| 
|BeginsWith|54|The string occurs at the beginning of another string. | 
|DoesNotBeginWith|55|The string does not begin with another string| 
|EndsWith|56|The string ends with another string.| 
|DoesNotEndWith|57|The string does not end with another string. | 
|ThisFiscalYear|58|The value is within the current fiscal year .| 
|ThisFiscalPeriod|59|The value is within the current fiscal period. | 
|NextFiscalYear|60|The value is within the next fiscal year.  | 
|NextFiscalPeriod|61|The value is within the next fiscal period. | 
|LastFiscalYear|62|The value is within the last fiscal year.| 
|LastFiscalPeriod|63|The value is within the last fiscal period. | 
|LastXFiscalYears|64|The value is within the last X (specified value) fiscal periods.| 
|LastXFiscalPeriods|65|The value is within the last X (specified value) fiscal periods. | 
|NextXFiscalYears|66|The value is within the next X (specified value) fiscal years.| 
|NextXFiscalPeriods|67|The value is within the next X (specified value) fiscal period. | 
|InFiscalYear|68|The value is within the specified year.| 
|InFiscalPeriod|69|The value is within the specified fiscal period.| 
|InFiscalPeriodAndYear|70|The value is within the specified fiscal period and year. | 
|InOrBeforeFiscalPeriodAndYear|71|The value is within or before the specified fiscal period and year.| 
|InOrAfterFiscalPeriodAndYear|72|The value is within or after the specified fiscal period and year. | 
|EqualUserTeams|73|The record is owned by teams that the user is a member of. | 
|EqualUserOrUserTeams|74|The record is owned by a user or teams that the user is a member of. | 
|Under|75|Returns all child records below the referenced record in the hierarchy. | 
|NotUnder|76|Returns all records not below the referenced record in the hierarchy.| 
|UnderOrEqual|77|Returns the referenced record and all child records below it in the hierarchy. | 
|Above|78|All records in referenced record's hierarchical ancestry line.  | 
|AboveOrEqual|79|The referenced record and all records above it in the hierarchy. | 
|EqualUserOrUserHierarchy|80|When hierarchical security models are used, Equals current user or their reporting hierarchy. | 
|EqualUserOrUserHierarchyAndTeams|81|When hierarchical security models are used, Equals current user and his teams or their reporting hierarchy and their teams. | 
|OlderThanXYears|82|The value is older than the specified number of years. | 
|OlderThanXWeeks|83|The value is older than the specified number of weeks.| 
|OlderThanXDays|84|The value is older than the specified number of days.| 
|OlderThanXHours|85|The value is older than the specified number of hours.| 
|OlderThanXMinutes|86|The value is older than the specified number of minutes. | 
|ContainValues|87|TODO: Add description for ConditionOperator.ContainValues member.| 
|DoesNotContainValues|88|TODO: Add description for ConditionOperator.DoesNotContainValues member.| 

## Used by
The following use the ConditionOperator enum type.
|Name|How used|Description|
|---|---|---|
|[ConditionExpression ComplexType](../complextypes/conditionexpression.md)|Property|[!INCLUDE[../complextypes/descriptions/conditionexpression.md](../complextypes/descriptions/conditionexpression.md)]|

[!INCLUDE[./remarks/conditionoperator.md](./remarks/conditionoperator.md)]

### See also  
 [Use the Microsoft Dynamics CRM Web API](https://msdn.microsoft.com/library/mt593051.aspx)   
 [Web API EntityType Reference](../entitytypereference.md)   
 [Web API Action Reference](../actionreference.md)   
 [Web API Function Reference](../functionreference.md)   
 [Web API Query Function Reference](../queryfunctionreference.md)   
 [Web API EnumType Reference](../enumtypereference.md)   
 [Web API ComplexType Reference](../complextypereference.md)   
 [Web API Metadata EntityType Reference](../entitytypereference.md)   
 [Web API Solutions Reference](../solutionreference.md)