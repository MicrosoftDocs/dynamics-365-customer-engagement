---
title: "Use FetchXML aggregation (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Read about the grouping and aggregation features of FetchXML that let you calculate sum, average min, max and count"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
helpviewer_keywords: 
  - "FetchXML queries"
  - "using FetchXML aggregation (grouping), code examples"
  - "using FetchXML aggregation (grouping), null value limitations when computing averages (avgaggregate attribute)"
  - "using FetchXML aggregation (grouping), difference between aggregate queries and standard queries"
  - "using FetchXML aggregation (grouping), aggregation functions supported"
  - "FetchXML queries, grouping and aggregation features"
  - "FetchXML queries, using FetchXML to construct queries"
  - "building queries with FetchXML, using FetchXML aggregation (grouping)"
  - "using FetchXML aggregation (grouping), effects of null values when minimum or maximum data is computed"
ms.assetid: be0fb5cf-4ba8-487f-b517-ae1c24045478
caps.latest.revision: 31
author: "KumarVivek"
ms.author: "kvivek"
manager: "jdaly"
---
# Use FetchXML aggregation
In [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Customer Engagement and [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)], `FetchXML` includes grouping and aggregation features that let you calculate sum, average min, max and count.  
  
 The following aggregate functions are supported:  
  
-   sum  
  
-   avg  
  
-   min  
  
-   max  
  
-   count(*)  
  
-   count(*attribute name*)  
  
<a name="Aggregation"></a>   
## About aggregation  
 To create an aggregate attribute, set the keyword `aggregate` to `true`, then specify a valid *entity name*, *attribute name*, and *alias* (variable name). You must also specify the type of aggregation you want to perform.  
  
 The following example shows a simple aggregate attribute in `FetchXML`.  
  
```xml  
  
<fetch distinct='false' mapping='logical' aggregate='true'>   
   <entity name='entity name'>   
      <attribute name='attribute name' aggregate='count' alias='alias name'/>   
   </entity>   
</fetch>"  
  
```  
  
 The result of a query with an aggregate attribute is different from the results of a standard query. The alias value is used as the tag identifier for the aggregate result.  
  
 The following example shows the format of the result of an aggregate query.  
  
```xml  
  
<resultset morerecords="0"'>   
   <result>  
      <alias>aggregate value</alias>  
   </result>  
</resultset>"  
  
```  
  
 The following example shows the results of a query when the alias variable is set to `account_count`.  
  
```  
  
<resultset morerecords="0"'>   
   <result>  
      <account_count>20</account_count>  
   </result>  
</resultset>"  
  
```  
  
<a name="AVG"></a>   
## Avg  
 The following example shows how to use the `avg``aggregate` attribute.  
  
 [!code-csharp[Query#FetchAggregationAndGroupBy1](../../snippets/csharp/CRMV8/query/cs/fetchaggregationandgroupby1.cs#fetchaggregationandgroupby1)]  
  
### Limitation with null values while computing average  
 **Null** values are not considered when [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] computes the average of data. However, zero (0) is used.  
  
 In the following example, with the following data, the average for Account 1 (two entries) is shown as 250 whereas the average for Account 2 (two entries) is shown as 125.  
  
|Topic|Potential Customer|Estimated value|  
|-----------|------------------------|---------------------|  
|Opportunity 1|Account 1|null|  
|Opportunity 2|Account 1|250|  
|Opportunity 3|Account 2|0|  
|Opportunity 4|Account 2|250|  
  
<a name="count"></a>   
## Count  
 The following example shows how to use the `count``aggregate` attribute.  
  
 [!code-csharp[Query#FetchAggregationAndGroupBy2](../../snippets/csharp/CRMV8/query/cs/fetchaggregationandgroupby2.cs#fetchaggregationandgroupby2)]  
  
<a name="count_column"></a>   
### CountColumn  
 The following example shows how to use the `countcolumn``aggregate` attribute to count columns.  
  
 [!code-csharp[Query#FetchAggregationAndGroupBy3](../../snippets/csharp/CRMV8/query/cs/fetchaggregationandgroupby3.cs#fetchaggregationandgroupby3)]  
  
<a name="count_distinct"></a>   
### Count distinct columns  
 The following example shows how to use the `countcolumn``aggregate` attribute with the `distinct` attribute to count distinct columns.  
  
 [!code-csharp[Query#FetchAggregationAndGroupBy4](../../snippets/csharp/CRMV8/query/cs/fetchaggregationandgroupby4.cs#fetchaggregationandgroupby4)]  
  
<a name="max"></a>   
## Max  
 **Null** values are not considered when [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] computes the maximum of data. However, zero (0) is used.  
  
 The following example shows how to use the `max``aggregate` attribute.  
  
 [!code-csharp[Query#FetchAggregationAndGroupBy5](../../snippets/csharp/CRMV8/query/cs/fetchaggregationandgroupby5.cs#fetchaggregationandgroupby5)]  
  
<a name="min"></a>   
## Min  
 **Null** values are not considered when [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] computes the minimum of data. However, zero (0) is used.  
  
 The following example shows how to use the `min``aggregate` attribute.  
  
 [!code-csharp[Query#FetchAggregationAndGroupBy6](../../snippets/csharp/CRMV8/query/cs/fetchaggregationandgroupby6.cs#fetchaggregationandgroupby6)]  
  
<a name="sum"></a>   
## Sum  
 The following example shows how to use the `sum``aggregate` attribute.  
  
 [!code-csharp[Query#FetchAggregationAndGroupBy7](../../snippets/csharp/CRMV8/query/cs/fetchaggregationandgroupby7.cs#fetchaggregationandgroupby7)]  
  
<a name="mult_agg"></a>   
## Multiple aggregates  
 The following example shows how to use multiple `aggregate` attributes to set a minimum and maximum.  
  
 [!code-csharp[Query#FetchAggregationAndGroupBy8](../../snippets/csharp/CRMV8/query/cs/fetchaggregationandgroupby8.cs#fetchaggregationandgroupby8)]  
  
<a name="groupby"></a>   
## Group by  
 The following example shows how to use multiple `aggregate` attributes and a linked `groupby` attribute.  
  
 [!code-csharp[Query#FetchAggregationAndGroupBy9](../../snippets/csharp/CRMV8/query/cs/fetchaggregationandgroupby9.cs#fetchaggregationandgroupby9)]  
  
 The samples below show the following group by examples:  
  
 [Group by with linked entity](use-fetchxml-aggregation.md#groupby_linked)  
  
 [Group by year](use-fetchxml-aggregation.md#groupby_year)  
  
 [Group by quarter](use-fetchxml-aggregation.md#groupby_quarter)  
  
 [Group by month](use-fetchxml-aggregation.md#groupby_month)  
  
 [Group by week](use-fetchxml-aggregation.md#groupby_week)  
  
 [Group by day](use-fetchxml-aggregation.md#groupby_day)  
  
 [Multiple group by](use-fetchxml-aggregation.md#Multiple_GroupBy)  
  
<a name="groupby_linked"></a>   
### Group by with linked entity  
 The following example shows how to use the `sum``aggregate` attribute to sum linked entity values.  
  
 [!code-csharp[Query#FetchAggregationAndGroupBy10](../../snippets/csharp/CRMV8/query/cs/fetchaggregationandgroupby10.cs#fetchaggregationandgroupby10)]  
  
<a name="groupby_year"></a>   
### Group by year  
 Group By for dates uses the day, week, month, quarter, or year value. The following example shows how to use the `aggregate` attribute and the `groupby` attribute to group the results by year.  
  
 [!code-csharp[Query#FetchAggregationAndGroupBy11](../../snippets/csharp/CRMV8/query/cs/fetchaggregationandgroupby11.cs#fetchaggregationandgroupby11)]  
  
<a name="groupby_quarter"></a>   
### Group by quarter  
 The following example shows how to use the `aggregate` attribute and the `groupby` attribute to group the results by quarter.  
  
 [!code-csharp[Query#FetchAggregationAndGroupBy12](../../snippets/csharp/CRMV8/query/cs/fetchaggregationandgroupby12.cs#fetchaggregationandgroupby12)]  
  
<a name="groupby_month"></a>   
### Group by month  
 The following example shows how to use the `aggregate` attribute and the `groupby` attribute to group the results by month.  
  
 [!code-csharp[Query#FetchAggregationAndGroupBy13](../../snippets/csharp/CRMV8/query/cs/fetchaggregationandgroupby13.cs#fetchaggregationandgroupby13)]  
  
<a name="groupby_week"></a>   
### Group by week  
 The following example shows how to use the `aggregate` attribute and the `groupby` attribute to group the results by week.  
  
 [!code-csharp[Query#FetchAggregationAndGroupBy14](../../snippets/csharp/CRMV8/query/cs/fetchaggregationandgroupby14.cs#fetchaggregationandgroupby14)]  
  
<a name="groupby_day"></a>   
### Group by day  
 The following example shows how to use the `aggregate` attribute and the `groupby` attribute to group the results by day.  
  
 [!code-csharp[Query#FetchAggregationAndGroupBy15](../../snippets/csharp/CRMV8/query/cs/fetchaggregationandgroupby15.cs#fetchaggregationandgroupby15)]  
  
<a name="Multiple_GroupBy"></a>   
### Multiple group by  
 The following example shows how to use the `aggregate` attribute and multiple `groupby` clauses.  
  
 [!code-csharp[Query#FetchAggregationAndGroupBy16](../../snippets/csharp/CRMV8/query/cs/fetchaggregationandgroupby16.cs#fetchaggregationandgroupby16)]  
  
<a name="orderby_aggregate"></a>   
## Order by  
 The following example shows how to use the `aggregate` attribute and multiple `orderby` clauses.  
  
 [!code-csharp[Query#FetchAggregationAndGroupBy17](../../snippets/csharp/CRMV8/query/cs/fetchaggregationandgroupby17.cs#fetchaggregationandgroupby17)]  
  
### See also  
 [Build Queries with FetchXML](build-queries-fetchxml.md)   
 [Page Large Result Sets with FetchXML](page-large-result-sets-with-fetchxml.md)   
 [Fetch XML Schema](fetchxml-schema.md)   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>   
 <xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest>   
 <xref:Microsoft.Xrm.Sdk.Query.FetchExpression>