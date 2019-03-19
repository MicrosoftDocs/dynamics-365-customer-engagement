# Segment Query definition

[!INCLUDE[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

Dynamic segments are based on segment query (`msdyncrm_segmentquery`). You can define a segment query by combing groups of logical expressions, each of which results in a set of `contacts`. Each group establishes a path through one or more entities that must end at the `Contact` entity (the order matters).

This topic showcases different elements that define a segment query.

> [!IMPORTANT]

> - [!INCLUDE[cc_preview_features_definition](../../includes/cc-preview-features-definition.md)] 
> - [!INCLUDE[cc_preview_features_no_MS_support](../../includes/cc-preview-features-no-ms-support.md)]

## PROFILE

This is the base expresesion for the query which selects all the profiles with a given profile type. The profiles matching the query will be the target profiles for the segment.

**Syntax**
`PROFILE(profile_type_name)`

> [!NOTE]
> Queries usig `UNION`, `MINUS`, `INTERSECT` or `SEGMENT` functions should select the same profile type.

## SEGMENT

Expression to access all profiles that belongs to a given segment. 

**Syntax**
`SEGMENT(segment_name)`

## TRAVERSE

Function to move in the graph, using the relationship type provided as a parameter. Optionally an expression can be applied for the current edges, to filter the one that are not meeting the condition. 

**Syntax**
`TRAVERSE(relationship_type_name, FILTER(condition))`

## INTERACTION

Expression to select all profiles linked to interaction. Similar to `PROFILE` expression where queries can be run only on single interaction. Interaction can be used with `FILTER` and `HAVING` expression but not with `TRAVERSE`. The `link_type_name` value is mandatory.

**Syntax**
`INTERACTION(interaction_type_name, link_type_name)`

## HAVING

Conditional expression that can be used on aggregated interactions. Calculation window is an optional parameter. It defines time sliding period for computation. Default value is Lifetime. More information [Usage Limitation](#usage-limitations). 

**Syntax**
`HAVING(condition, calculation_window)` 

## FILTER
Expression applied for the current nodes, to filter the ones not meeting the condition. More inforamtion [Usage Limitations](#usage-limitations). 

**Syntax**
`FILTER(condition)` 

## NOT
Conditional expression that can be used to filter out results that matches given condition.  

**Syntax**
`NOT(condition)` 

## DISTINCT
Expression that can be called on a node or edge collection to get a distinct set. 

**Syntax**
`DISTINCT()`

## COUNT
Expression that can be called on the result of `TRAVERSE` call or inside `HAVING` function, for the purpose of grouping conditional expression. 

**Syntax**
`COUNT()`

## AVG

Expression that can be called on the result of `TRAVERSE` call or inside `HAVING` function, for a purpose of grouping conditional expression.  

**Syntax**
`AVG(propertyName)`

## MIN

Expression that can be called on the result of `TRAVERSE` call or inside `HAVING` function, for a purpose of grouping conditional expression.  

**Syntax**
`MIN(propertyName)`

## MAX

Expression that can be called on the result of `TRAVERSE` call or inside `HAVING` function, for a purpose of grouping conditional expression. 

**Syntax**
`MAX(propertyName)`

## SUM

Expression that can be called on the result of `TRAVERSE` call or inside `HAVING` function, for a purpose of grouping conditional expression. 

**Syntax**
`SUM(propertyName)` 

## UNION 

Expression that can be used to join results of two queries.  

## EXCEPT

Expression that can be used to remove results from the second query from results from the first query. 

> [!NOTE]
> Both queries should select the same profile type as target profile. 

## INTERSECT

Expression that can be used to select only results returned from both queries. 

> [!NOTE]
> Both queries should select the same profile type as target profile. 

## DATETIMEUTCNOW

Expression used to get current date and time (minutes precision) in UTC. 

## DATE

Expression used to get a date specified by the parameters. 

**Syntax**
`DATE(year, month, day, hour, minute, second, millisecond)` 

## DATEDIFF

Expression used to get a difference between two dates. 

**Syntax**
`DATEDIFF(datePart, date, date)` 

## DATEADD

Expression used to add given number of years/months/days/ to a given date.

**Syntax**
`DATEADD(datePart, number, date)` 

##ISNULL
Function to determine if property is NULL. 

**Syntax**
`ISNULL(propertyName)`

## ISNOTNULL

 Function to determine if property is not NULL.
 
 **Syntax**
 `ISNOTNULL(propertyName)`
 
 ## propertyName CONTAINS stringValue
 
 String function determing whether property contains given substring.
 
 ## propertyName STARTSWITH stringValue
 
 String function determining whether string property starts with given substring. 
 
 ## propertyName ENDSWITH stringValue
 
 String function determining whether string property ends with given substring.  
 
 ## Grammar
 
 Grammar definition describes how you can use the query language.
 
 ### Dynamic Segment
 
 dynamicSegmentDefinitionQuery = simpleProfileSegmentDefinition | compoundProfileSegmentDefinition | interactionSegmentDefinition 
 
 ### Static Segment 
 
 staticSegmentDefinitionQuery = profileFunction | profileFunction.filterFunction | profileFunction.orderByFunction.skipFunction.takeFunction.selectFunction | profileFunction.filterFunction.orderByFunction.skipFunction.takeFunction.selectFunction 

## Rules
|Function| Value|
|-------|-------|
|simpleProfileSegmentDefinition| profileFunction or profileFunction.traverseQueryList |
|profileFunction| PROFILE(identifier)| 
|traverseQueryList |traverseQueryList.traverseQuery or traverseQuery| 
|traverseQuery|traverseFunction or filterFunction| 
|traverseFunction| TRAVERSE(identifier) or TRAVERSE(identifier,filterFunction) |
|filterFunction|FILTER(propertyCondition)| 
|propertyCondition| comparisonCondition or notFunction or logicalCondition or stringComparisonCondition or nullFunction| 
|comparisonCondition|  valueExpression comparisonOperator valueExpression (valueExpression comparisonOperator valueExpression)|
|valueExpression |booleanValue or string  or number or aliasedIdentifier or dateDiffFunction or dateAddFunction or dateFunction or dateTimeUtcNowFunction or arithmeticOperation| 
|booleanValue | TRUE or FALSE| 
|aliasedIdentifier| identifier or identifier.identifier| 
|dateDiffFunction| DATEDIFF(datePart,valueExpression,valueExpression)| 
|datePart |YEAR MONTH  DAY  HOUR  MINUTE SECOND  MILLISECOND |
|dateAddFunction| DATEADD(datePart,number,valueExpression)|
|dateFunction| Date(/*year*/ number, /*month*/ number, /*day*/ number) or Date(/*year*/ number, /*month*/ number, /*day*/ number, /*hour*/ number) or Date(/*year*/ number, /*month*/ number, /*day*/ number, /*hour*/ number, /*minute*/ number)  or Date(/*year*/ number, /*month*/ number, /*day*/ number, /*hour*/ number, /*minute*/ number, /*second*/ number) or Date(/*year*/ number, /*month*/ number, /*day*/ number, /*hour*/ number, /*minute*/ number, /*second*/ number, /*millisecond*/ number)|
|dateTimeUtcNowFunction| DATETIMEUTCNOW()| 
|nullFunction | nullFuctionKeyword|
|nullFunctionKeyword|ISNULL or ISNOTNULL| 
|arithmeticOperation | numericExpression arithmeticOperator numericExpression (numericExpression arithmeticOperator numericExpression)| 
|numericExpression| number or aliasedIdentifier or arithmeticOperation| 
|arithmeticOperator | + or - or * or / |
|comparisonOperator| == or != or > or >= or < or <=|
|notFunction| NOT(propertyCondition)| 
|logicalCondition| propertyCondition logicalOperator propertyCondition (propertyCondition logicalOperator propertyCondition)| 
|logicalOperator |&&, OR|
|stringComparisonCondition|alisedIdentifier stringComparisonOperator string (aliasedIdentifier stringComparisonOperator string)| 
|stringComparisonOperator| CONTAINS or STARTSWITH or ENDSWITH|
|compoundProfileSegmentDefinition|setOperation| 
|setOperation| setExpression setOperator setExpression (setExpression setOperator setExpression)| 
|setExpression |segmentFunction or simpleProfileSegmentDefinition or setOperation| 
|segmentFunction |SEGMENT(identifier)| 
|setOperator |UNION or INTERSECT or EXCEPT| 
|interactionSegmentDefinition |interactionFunction.havingFunction or interactionFunction.filterFunction.havingFunction| 
|interactionFunction |INTERACTION(identifier,identifier)| 
|havingFunction | HAVING(aggregationFunction comparisonOperator number, calculationWindowFunctionExpression) or HAVING(aggregationFunction comparisonOperator number)| 
|aggregationFunction|countFunction or sumFunction or avgFunction or minFunction or maxFunction| 
|countFunction |COUNT()| 
|sumFunction |SUM(identifier)|
|avgFunction |AVG(identifier)| 
|minFunction| MIN(identifier)| 
|maxFunction | MAX(identifier)| 
|calculationWindowFunctionExpression | daysCalculationWindowFunction or monthsCalculationWindowFunction or yearsCalculationWindowFunction |
|daysCalculationWindowFunction |UTCDAYS(number)| 
|monthsCalculationWindowFunction |UTCMONTHS(number)| 
|yearsCalculationWindowFunction |UTCYEARS(number)| 
|orderByFunction |ORDERBY(orderByArgumentList)| 
|orderByArgumentList |orderByArgumentList,orderByArgument or orderByArgument| 
|orderByArgument |aliasedIdentifier or aliasedIdentifier sortDirection|
|sortDirection | ASC or DESC |
|skipFunction | SKIP(number)| 
|takeFunction | TAKE(number) |
|selectFunction |SELECT(propertyList)| 
|propertyList| propertyList,aliasedIdentifier or aliasedIdentifier|

 ## Usage Limitations
 ### HAVING 
 
 **Condition forbidden**
 
 |Function|Operator|Value|
 |----|----|----|
 |COUNT ()| `>=`, `!=`|Positive integer|
 ||`>=`, `!=`, `>`, `==`, `<=`, `<`|Negative numeric<br />Non-integer value|
 ||`==`|0|
 |SUM (identifer)|No limitation|No limitation|
 |AVG (identifier)|No limitation|No limitation|
 |MIN (identifier)|No limitation|No limitation|
 |MAX (identifier)|No limitation|No limitation|
 
 **FILTER(condition)**
 
 PROFILE and SEGMENT has no limitation for FIILTER(condition). Filter has only limitation in INTERACTION segment. No support of Date, DATEDIFF, DATEADD, DATETIMEUTCNOW, CONTAINS, STARTSWITH, ENDSWITH.

## Examples

1. Create a segment for leads that participated in `Campaign 1` and that opened any email from this campaign but have not clicked on it. 

`SegmentOnProfilesInCampaign = PROFILE(Campaign).FILTER(Name == 'Campaign 1').TRAVERSE(ActivityContactProcessed_Campaign)  
    SegmentOnEmailOpened = INTERACTION(EmailOpened, EmailOpenedLeadLink).FILTER(Name == 'Campaign 1')).HAVING(COUNT()>0)  
 SegmentOnClicked  = INTERACTION(EmailClicked, EmailClickedLeadLink).FILTER(Name == 'Campaign 1')).HAVING(COUNT()>0)`   
 
**Result** 

`SEGMENT(SegmentInCampaign)   
UNION 
SEGMENT(SegmentOnEmailOpened)   
EXCEPT 
SEGMENT(SegmentOnClicked)`

2. Filter on all subscriptions that sent from an email marketing campaign, but without registrations in a certain marketing event.

`SegmentOnProfilesInCampaign =PROFILE(Campaign).FILTER(Name == 'Campaign 1').TRAVERSE(EmailSubscriptionSubmit_Campaign) 
 SegmentOnProfilesWithoutRegistration =PROFILE(CampaignEvent).FILTER(Name == 'Even1').TRAVERSE(CampaignEventRegistration_CampaignEvent)` 

**Result**

`SegmentOnProfilesInCampaign 
EXCEPT 
SegmentOnProfilesWithoutRegistration`

3. Find all contacts from leads where the lead date is after the end date of the campaign (of the lead’s marketing context) 

`PROFILE(Campaign) 
   .TRAVERSE(ActivityLeadProcessed_Campaign) 
      .FILTER(StartDate > '2017-03-30')`

4. Create a Segment for all credit card customers whose credit card(s) are expiring in the next 30 days to send them a notification email.

`PROFILE(CreditCard).FILTER(DATEDIFF(day, ExpirationDate, DateTimeNowUtc()) < 30).TRAVERSE(HavingCreditCard)`
      
5. Create a segment  on all company customers with at least one active `Purchaseditem pi` such as `pi.Product=CreditCard` and `pi.expirationDate < [month from today]` (parametric query relative to TODAY so that a marketer can set up automated campaigns via rolling queries). 

`PROFILE(Contact).FILTER(NumberOfActivePurchasedItems > 0 && Product == 'CreditCard' && DATEDIFF(month, ExpirationDate,DATETIMEUTCNOW()) < 1)`

6. Create a segment with all contacts that have not clicked on any link in email 12345 in the last week. 

`SegmentOnProfile = PROFILE(Contact)   
 SegmentOnClicked = INTERACTION(RedirectLinkClicked, RedirectLinkClicked_ContactLink).HAVING(COUNT()>0, UTCDAYS(7)).FILTER(EmailId=='12345')` 

**Result**

`SEGMENT(SegmentOnProfile)   
EXCEPT 
SEGMENT(SegmentOnClicked)`

7. Filter on preferred activity type of some kinds of sports and select a certain range of age.

`PROFILE(Activity).FILTER(ActivityType == 'Football').TRAVERSE('SubscribedToActivity').FILTER(Age > 20 && Age < 35)`

8. Lead in campaign `Always Active` and Grade in `5to10k` or higher. Add members from `Fitness Challenge to 100`. Intersect with list of `ColorRun` signups. Exclude all that are existing member (regular + trial).

`SegmentOnProfilesFromAlwaysActiveAndFitnessChallenge = PROFILE(Campaign).FILTER(Name == 'Always Active' || Name == 'Fitness Challenge to 100').TRAVERSE(ActivityContactProcessed_Campaign).FILTER(Grade == '5to10k') 
 SegmentOnProfilesFromColorRun =PROFILE(Event).FILTER(Name == 'ColorRun').TRAVERSE(SignedToEvent) 
 SegmentOnProfilesWithMembership =PROFILE(Membership).TRAVERSE(InSubscription, FILTER(Status == 'Active'))` 

**Result**

`SEGMENT(SegmentOnProfilesFromAlwaysActiveAndFitnessChallenge) 
INTERSECT 
SEGMENT(SegmentOnProfilesFromColorRun) 
EXCEPT 
SEGMENT(SegmentOnProfilesWithMembership)`

9. Segment all contacts that have unsubscribed in the last 1 month.  

`PROFILE(Subscription).TRAVERSE(InSubscription, FILTER(DATEDIFF(month, SubscriptionEndDate, DATETIMEUTCNOW()) 1))`
    
10. Segment all contacts who are `Marketing Managers` or `Sales Managers` Or `Finance managers` belonging to `Hi tech` firms in US West Region with greater than 10 billion revenue and total orders of 1 billion in the last year. 

`PROFILE(Campaign) .FILTER(Market == 'Hi tech' && Revenue > 10000000000 && NumberOfOrders > 1000000000).TRAVERSE(ActivityContactProcessed_Campaign).FILTER(Position == 'Marketing Manager' || Position == 'Sales Manager' || 
 Position == 'Finance Manager')`

11. Segment all contacts part of Silver Tier campaign that received Event X email but did not register.

`SegmentOnProfile = PROFILE(Campaign).FILTER(Name == 'Silver Tier').TRAVERSE(ActivityContactProcessed_Campaign)  
      SegmentOnEmailDelivered = INTERACTION(EmailDelivered, EmailDelivered_Campaign).FILTER(CampaignName == 'Silver Tier')).HAVING(COUNT()>0) 
 SegmentRegisteredInEvent  =INTERACTION(CampaignEventRegistration,CampaignEventRegistration_CampaignEvent).FILTER(Name == 'Event X')) 
    .HAVING(COUNT()>0)` 

**Result**

`SEGMENT(SegmentOnProfile)  
  .UNION(SegmentOnReceivedEmail) 
    .EXCEPT(SegmentRegisteredInEvent)`
    
12. Segment all contacts whose emails soft bounced 10 times in the last month. 

`INTERACTION(EmailSoftBounced, EmailSoftBounced_ContactLink).HAVING(COUNT()>10, UTCMONTHS(1))`

13. Segment all male contacts living in USA b/w ages 15 - 25 and income > 50K.  

`PROFILE(Contact).FILTER(Sex == 'M' && Country == 'USA' && Age >= 15 && Age <= 25 && Income > 50000 )`
   
14. Segment all CEO contacts having accounts that bought Product Xgenerator. 

`PROFILE(Contact).FILTER(Position == 'CEO').TRAVERSE(HavingAccount).TRAVERSE(Ordered).FILTER(Name == 'Product Xgenerator')` 

15. Segment all contacts part of Campaign ThankYou Mkt segment but have an open Service ticket with high prio or Medium prio ticket for more than a month.

`SegmentWithImportantServiceTickets = PROFILE(ServiceTicket).FILTER(State == 'Opened' &&(Priority == 'High' || Priority == 'Medium') && 
DATEDIFF(month, DATETIMEUTCNOW(), StartDate) > 1)).TRAVERSE(HasServiceTicket)` 

**Result**

`SEGMENT(SegmentWithImportantServiceTickets) 
INTERSECT 
SEGMENT(ThankYouMktSegment) 
Segment all customers whose birthday is within the next month 
PROFILE(Customer).FILTER(DATEDIFF(month,Birthday,DATETIMEUTCNOW())` 

16. Segment all contacts who unsubscribed after campaign started.

`PROFILE(Contact).FILTER(Unsubscribed > CampaignStartDate)` 

17. Segment all events that contains `run` in name field. 

`PROFILE(Event).FILTER(Name CONTAINS 'run')` 

18. Segment all events whose names ends with `run`. 

`PROFILE(Event).FILTER(Name ENDSWITH 'run')` 

19. Segment all customers without address.

`PROFILE(Customer).FILTER(ISNULL(Address))` 

## See also 
[Basic operations on segments using code](extend-segments.md)
