# Segment Query definition

Dynamic segments are based on segment query (`msdyncrm_segmentquery`). You can define a segment query by combing groups of logical expressions, each of which results in a set of `contacts`. Each group establishes a path through one or more entities that must end at the `Contact` entity (the order matters).

This topic showcaases different elements that define a segment query.

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

Expression to select all profiles linked to interaction. Similar to profile expression where queries can be run only on single interaction. Link name is mandatory parameter. Interaction can be used with Filter and Having expression but not with Traverse. 

**Syntax**
`INTERACTION(interaction_type_name, link_type_name)`

## HAVING

Conditional expression that can be used on aggregated interactions. Please, check usage limitation. 
Calculation window is optional parameter. It defines time sliding period for computation. Default value is Lifetime. Please, check Usage Limitation. 

**Syntax**
HAVING(condition, calculation_window) 

## FILTER
Expression applied for the current nodes, to filter the ones not meeting the condition. 
Please, check Usage Limitation. 

**Syntax**
FILTER(condition) 

## NOT
Conditional expression that can be used to filter out results meeting given condition.  

**Syntax**
NOT(condition) 

## DISTINCT
Expression that can be called on a node or edge collection to get a distinct set. 

## COUNT
Expression that can be called on the result of TRAVERSE call or inside HAVING function, for a purpose of grouping conditional expression. 

## AVG

Expression that can be called on the result of TRAVERSE call or inside HAVING function, for a purpose of grouping conditional expression.  

**Syntax**
`AVG(propertyName)`

## MIN

Expression that can be called on the result of TRAVERSE call or inside HAVING function, for a purpose of grouping conditional expression.  

**Syntax**
`MIN(propertyName)`

## MAX

Expression that can be called on the result of TRAVERSE call or inside HAVING function, for a purpose of grouping conditional expression. 

**Syntax**
`MAX(propertyName)`

## SUM

Expression that can be called on the result of TRAVERSE call or inside HAVING function, for a purpose of grouping conditional expression. 

**Syntax**
SUM(propertyName) 

## UNION 

Set expression that can be used to join results of two queries. Note: both queries should select the same profile type as target profile. 

## EXCEPT
Set expression that can be used to remove results from the second query from results from the first query. Note: both queries should select the same profile type as target profile. 

## INTERSECT

Set expression that can be used to select only results returned from both queries. Note: both queries should select the same profile type as target profile. 

## DATETIMEUTCNOW

Expression used to get current date and time (minutes precision) in UTC 

## DATE

Expression used to get a date specified by the parameters. 

**Syntax**
DATE(year, month, day, hour, minute, second, millisecond) 

## DATEDIFF

Expression used to get a difference between two dates. 

**Syntax**
DATEDIFF(datePart, date, date) 

## DATEADD

Expression used to add given number of years/months/days/... to a given date.

**Syntax**
DATEADD(datePart, number, date) 

##ISNULL
Function to determine if property is NULL. 

**Syntax**
`ISNULL(propertyName)`

## ISNOTNULL

 Function to determine if property ISNOTNULL.
 
 **Syntax**
 `ISNOTNULL(propertyName)`
 
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
 PROFILE segment has no limitation for FIILTER(condition). Filter has only limitation in INTERACTION segment. No support of Date, DATEDIFF, DATEADD, DATETIMEUTCNOW, CONTAINS, STARTSWITH, ENDSWITH

## Examples
Create a segment for leads that participated in ‘Campaign 1’ and that opened any email from this campaign but have not clicked on it 

`SegmentOnProfilesInCampaign =   
PROFILE(Campaign) 
  .FILTER(Name == 'Campaign 1') 
    .TRAVERSE(ActivityContactProcessed_Campaign)  
    SegmentOnEmailOpened =   
INTERACTION(EmailOpened, EmailOpenedLeadLink) 
  .FILTER(Name == 'Campaign 1')) 
    .HAVING(COUNT()>0)  
 SegmentOnClicked  =  
INTERACTION(EmailClicked, EmailClickedLeadLink) 
  .FILTER(Name == 'Campaign 1')) 
    .HAVING(COUNT()>0)   
 Result =   
SEGMENT(SegmentInCampaign)   
UNION 
SEGMENT(SegmentOnEmailOpened)   
EXCEPT 
SEGMENT(SegmentOnClicked)`

Filter on all subscriptions that stem from an email marketing campaign, but without registrations in a certain marketing event 

`SegmentOnProfilesInCampaign = 
PROFILE(Campaign) 
  .FILTER(Name == 'Campaign 1') 
    .TRAVERSE(EmailSubscriptionSubmit_Campaign) 
 SegmentOnProfilesWithoutRegistration = 
PROFILE(CampaignEvent) 
   .FILTER(Name == 'Event 1') 
      .TRAVERSE(CampaignEventRegistration_CampaignEvent) 
 Result =  
SegmentOnProfilesInCampaign 
EXCEPT 
SegmentOnProfilesWithoutRegistration`

Find all contacts from leads where the lead date is after the end date of the campaign (of the lead’s marketing context) 
`PROFILE(Campaign) 
   .TRAVERSE(ActivityLeadProcessed_Campaign) 
      .FILTER(StartDate > '2017-03-30')`

Create a Segment for all credit card customers whose credit card(s) are expiring in the next 30 days to send them a notification email 
`PROFILE(CreditCard) 
   .FILTER(DATEDIFF(day, ExpirationDate, DateTimeNowUtc()) < 30) 
      .TRAVERSE(HavingCreditCard)`
      
Create a Segment  on all company customers with at least one active Purchaseditem pi such as pi.Product=CreditCard and pi.expirationDate < [month from today] (parametric query relative to TODAY so that a marketer can set up automated campaigns via rolling queries) 

`PROFILE(Contact) 
   .FILTER( 
      NumberOfActivePurchasedItems > 0 &&  
      Product == 'CreditCard' &&  
      DATEDIFF(month, ExpirationDate, DATETIMEUTCNOW()) < 1)`

Create a segment with all contacts that have not clicked on any link in email 12345 in the last week 
`SegmentOnProfile =   
PROFILE(Contact)   
 SegmentOnClicked =  
INTERACTION(RedirectLinkClicked, RedirectLinkClicked_ContactLink) 
   .HAVING(COUNT()>0, UTCDAYS(7)) 
   .FILTER( EmailId == '12345') 
 Result =   
SEGMENT(SegmentOnProfile)   
EXCEPT 
SEGMENT(SegmentOnClicked)`

Filter on preferred activity type of some kinds of sports and select a certain range of age 
`PROFILE(Activity) 
   .FILTER(ActivityType == 'Football') 
      .TRAVERSE('SubscribedToActivity') 
         .FILTER(Age > 20 && Age < 35)`

Lead management: Lead in campaign ‘Always Active’ and Grade in ‘5to10k’ or higher. Add members from Fitness Challenge to 100. Intersect with list of ColorRun signups. Exclude all that are existing member (regular + trial) 

`SegmentOnProfilesFromAlwaysActiveAndFitnessChallenge = 
PROFILE(Campaign) 
  .FILTER(Name == 'Always Active' || Name == 'Fitness Challenge to 100') 
    .TRAVERSE(ActivityContactProcessed_Campaign) 
      .FILTER(Grade == '5to10k') 
 SegmentOnProfilesFromColorRun = 
PROFILE(Event) 
   .FILTER(Name == 'ColorRun') 
      .TRAVERSE(SignedToEvent) 
 SegmentOnProfilesWithMembership = 
PROFILE(Membership) 
   .TRAVERSE(InSubscription, FILTER(Status == 'Active')) 
 Result =  
SEGMENT(SegmentOnProfilesFromAlwaysActiveAndFitnessChallenge) 
INTERSECT 
SEGMENT(SegmentOnProfilesFromColorRun) 
EXCEPT 
SEGMENT(SegmentOnProfilesWithMembership)`

Segment all contacts that have unsubscribed in the last 1 month  

`PROFILE(Subscription) 
    .TRAVERSE(InSubscription, FILTER(DATEDIFF(month, SubscriptionEndDate, DATETIMEUTCNOW()) 1))`
    
Segment all contacts who are Marketing Managers or Sales Managers Or Finance managers belonging to Hi tech firms in US West Region with greater than 10 billion revenue and total orders of 1 billion in the last year. 

`PROFILE(Campaign)  
   .FILTER( 
      Market == 'Hi tech' && 
      Revenue > 10000000000 && 
      NumberOfOrders > 1000000000) 
      .TRAVERSE(ActivityContactProcessed_Campaign) 
         .FILTER( 
            Position == 'Marketing Manager' || 
            Position == 'Sales Manager' || 
            Position == 'Finance Manager')`

Segment all contacts part of Silver Tier campaign that received Event X email but did not register 
`SegmentOnProfile =  
PROFILE(Campaign) 
  .FILTER(Name == 'Silver Tier') 
    .TRAVERSE(ActivityContactProcessed_Campaign)  
      SegmentOnEmailDelivered =  
INTERACTION(EmailDelivered, EmailDelivered_Campaign) 
  .FILTER(CampaignName == 'Silver Tier')) 
    .HAVING(COUNT()>0) 
 SegmentRegisteredInEvent  = 
INTERACTION(CampaignEventRegistration,CampaignEventRegistration_CampaignEvent) 
  .FILTER(Name == 'Event X')) 
    .HAVING(COUNT()>0) 
 Result =  
SEGMENT(SegmentOnProfile)  
  .UNION(SegmentOnReceivedEmail) 
    .EXCEPT(SegmentRegisteredInEvent)`
    
Segment all contacts whose emails soft bounced 10 times in the last month 

`INTERACTION(EmailSoftBounced, EmailSoftBounced_ContactLink)       
   .HAVING(COUNT()>10, UTCMONTHS(1))`

Segment all male contacts living in USA b/w ages 15 - 25 and income > 50K  

`PROFILE(Contact) 
   .FILTER( 
      Sex == 'M' && 
      Country == 'USA' && 
      Age >= 15 && Age <= 25 && 
      Income > 50000 
   )`
   
Segment all CEO contacts having accounts that bought Product Xgenerator 

`PROFILE(Contact) 
   .FILTER(Position == 'CEO') 
      .TRAVERSE(HavingAccount) 
    .TRAVERSE(Ordered) 
      .FILTER(Name == 'Product Xgenerator')` 

Segment all contacts part of Campaign ThankYou Mkt segment but have an open Service ticket with high prio OR Medium prio ticket for more than a month 

`SegmentWithImportantServiceTickets = 
PROFILE(ServiceTicket) 
   .FILTER( 
      State == 'Opened' && 
      (Priority == 'High' || Priority == 'Medium') && 
DATEDIFF(month, DATETIMEUTCNOW(), StartDate) > 1)) 
      .TRAVERSE(HasServiceTicket) 
 Result =  
SEGMENT(SegmentWithImportantServiceTickets) 
INTERSECT 
SEGMENT(ThankYouMktSegment) 
Segment all customers whose birthday is within the next month 
PROFILE(Customer) 
  .FILTER(DATEDIFF(month,Birthday,DATETIMEUTCNOW())` 

Segment all contacts who unsubscribed after campaign started 
`PROFILE(Contact) 
  .FILTER(Unsubscribed > CampaignStartDate)` 

Segment all events that contains ‘run’ in name  
`PROFILE(Event) 
   .FILTER(Name CONTAINS 'run')` 

Segment all events which names ends with ‘run’ 
`PROFILE(Event) 
   .FILTER(Name ENDSWITH 'run')` 

Segment all customers without address  
`PROFILE(Customer) 
   .FILTER(ISNULL(Address))` 
