---
title: Segmentation Query Language Reference (Microsoft Dynamics 365 for Customer Insights) | MicrosoftDocs
description: A segmentation query expression defines a Customer Insights segment.
keywords: Customer Insights; Hub API, Segmentation Query Language
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 07/26/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 2c6ac418-9758-43e8-b5f7-b8c27bas1020
---

Segmentation Query Language Reference
=====================================

[!include[pre release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

Membership in static segments is defined by specifying either the Profile ID for each member or supplying a _segmentation query_; membership in a dynamic segment is defined by only by the latter. A segmentation query is a filtering expression that describes the desired membership set.  Each expression is composed of one or more sub-expressions that each have the form:
* Each expression has one input, either a [Profile](./types/profile.md) or a [Relationship](./types/relationship.md) type.  Each expression may contain an optional filter.  Filters can be combined with logical operators.  
* An expression has an implied output Profile type, representing the the result set.
* With the exception of the first expression, each expression can use as an input one of the following:
    * The same input profile or relationship type as the prior expression
    * The output profile type of the prior expression

For example, the following is a simple example of a query with the Salesperson profile type used explicitly as input and implicitly as output, and a single filter expression:  
&emsp; `"PROFILE(Salesperson).FILTER(FirstName!='Sally')"`

A segmentation clause is stored as a JSON string in the **SegmentDefinition** property of the [Segment](./types/segment.md) entity. Segmentation clauses can also be constructed interactively with the Segment Builder <!--TODO: Add link.--> in Customer Insights.

Note: The segmentation query for a static segment is typically run only once, during it's initial construction (or explicit updating). In contrast, the segmentation query for a dynamic segment is reevaluated on a periodic basis, whose time interval is specified by the **segmentRefreshRateIntervalMinutes** property of the associated segment. 


## Query Elements
An expression is constructed of one or more of the following elements.

|**Query Element**|**Description**|
| --------------- | ---------- | 
| PROFILE(_profile-type-name_) | The starting expression for the query that selects all profiles of the specified profile type. <br>Limitation: queries using UNION, MINUS, INTERSECT or SEGMENT functions must consistently operate on the same profile type. |
| SEGMENT(_segment-name_) | Selects all profiles belonging to a given segment |
| TRAVERSE(_relationship-type-name_, FILTER(_condition_)) | Function to select the targets of the specified relationship. Optionally a filter condition can be supplied to the narrow the targets. |
| INTERACTION(_interaction-type-name_, _link-type-name_) | Select all profiles linked to interaction. (Both parameters are required.) Similar to profile expression where queries can be run only on single interaction. <br>Limitation: INTERACTION can be used with FILTER and HAVING expressions but not with TRAVERSE. |
| HAVING(_condition_) | Conditional expression that can be used on aggregated interactions |
| FILTER(_condition_) | Applied to the current selection to exclude items not meeting the specified condition |
| NOT(_condition_) | Applied to the current selection to exclude items that meet the specified condition |
| COUNT() | Resolves to the number of items in the current selection.* |
| AVG(_propertyName_) | Resolves to the average of the specified property values in the current selection.* |
| MIN(_propertyName_) | Resolves to the smallest value of the specified property in the current selection.* |
| MAX(_propertyName_) | Resolves to the largest value of the specified property in the current selection.* |
| SUM(_propertyName_) | Resolves to the summation of the specified property values in the current selection.* |
| UNION | Set operation that joins the resulting sets of two queries |
| EXCEPT | Set operation that removes the results of the second query from results from the first query |
| INTERSECT | Set operation that selects the items common to both queries |
| DATETIMEUTCNOW() | Returns the current date and time (minutes precision) in UTC |
| DATEDIFF(_datePart_, _date_, _date_) | Returns the count of the specified datepart boundaries crossed between the specified startdate and enddate. For complete documentation, see [DATEDIFF (Transact-SQL)](https://docs.microsoft.com/sql/t-sql/functions/datediff-transact-sql). |
| DATEADD(_datePart_, _number_, _date_) | Returns a specified date with the specified number interval added to a specified datepart of that date. For complete documentation, see [DATEADD (Transact-SQL)](https://docs.microsoft.com/sql/t-sql/functions/dateadd-transact-sql). |
| | |

&emsp; * The aggregation functions COUNT, AVG, MIN, MAX, and SUM can be invoked inside of a HAVING expression, typically for a purpose of grouping a conditional expression.

###	Filtering Operations
The filtering operations supported in an expression depend upon the the data type of the target property as follows:

|**Property Type**|	**Supported Filtering Operations**|
| --------------- | ---------- | 
| Boolean	| equals |
| DateTime | equals, greater-than, greater-than-or-equals, less-than, less-than-or-equals, not-equals |
| GUID | equals, not-equals, one-of |
| _Numeric_ (byte, decimal, <br>double, int, long, short) | equals, greater-than, greater-than-or-equals, less-than, less-than-or-equals, not-equals |
| String | equals, not-equals, one-of |
| | |

## Examples

The following examples are based on a typical Dynamics 365 Customer Engagement schema.

<br>
Select all male contacts living in USA from the ages 15 to 25 and income over $50K:

~~~{query}
PROFILE(Contact)
   .FILTER(
      Sex == 'M' &&
      Country == 'USA' &&
      Age >= 15 && Age <= 25 &&
      Income > 50000
   )
~~~

<br>
Select all contacts from leads where the lead date is after the end date of the campaign (of the lead’s marketing context):

~~~{query}
PROFILE(Campaign)
   .TRAVERSE(ActivityLeadProcessed_Campaign)
      .FILTER(StartDate > '2017-03-30')
~~~

<br>
Select all company customers with at least one active purchase of a credit card where the expiration date is a month from today (useful to set up automated campaigns via rolling queries):

~~~{query}
PROFILE(Contact)
   .FILTER(
      NumberOfActivePurchasedItems > 0 && 
      Product == 'CreditCard' && 
      DATEDIFF(month, ExpirationDate, DATETIMEUTCNOW()) < 1)
~~~

<br>
Select all CEO contacts having accounts that bought "Product Xgenerator":

~~~{query}
PROFILE(Contact)
   .FILTER(Position == 'CEO')
      .TRAVERSE(HavingAccount)
    .TRAVERSE(Ordered)
      .FILTER(Name == 'Product Xgenerator')
~~~

<br>
Select all contacts that have clicked on any link in email "12345" in the last week:

~~~{query}
INTERACTION(RedirectLinkClicked, RedirectLinkClicked_ContactLink)
   .FILTER(EmailId == '12345')
   .HAVING(COUNT()>0, UTCDAYS(7)) 
~~~

<br>
Select all customers whose birthday is within the next month:

~~~{query}
PROFILE(Customer)
  .FILTER(DATEDIFF(month,Birthday,DATETIMEUTCNOW()) == 1)
~~~

<br>
Filter on all subscriptions that stem from this same email marketing campaign, but leaving out registrations from the first marketing event:

~~~{query}
PROFILE(Campaign)
  .FILTER(Name == 'Campaign 1')
    .TRAVERSE(EmailSubscriptionSubmit_Campaign)
EXCEPT
PROFILE(CampaignEvent)
   .FILTER(Name == 'Event 1')
      .TRAVERSE(CampaignEventRegistration_CampaignEvent)
~~~

<br>
Create a compound segment that consists of segments AllFromSeattle and SubscribedToEvent:

~~~{query}
SEGMENT(AllFromSeattle)
UNION
SEGMENT(SubscribedToEvent)
~~~
