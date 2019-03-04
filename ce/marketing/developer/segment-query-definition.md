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




