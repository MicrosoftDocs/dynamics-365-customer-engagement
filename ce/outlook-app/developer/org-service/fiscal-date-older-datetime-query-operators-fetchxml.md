---
title: "Fiscal date and older than datetime query operators in FetchXML (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Read how to use FetchXML fiscal data conditional operators and &quot;older than&quot; clauses for date and time values"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4ab6e60c-161e-468f-b89c-cc3bd243b3df
caps.latest.revision: 33
author: "KumarVivek"
ms.author: "kvivek"
manager: "jdaly"
---
# Fiscal date and older than datetime query operators in FetchXML
A FetchXML query in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Customer Engagement can use special fiscal date values and *older than* clauses for date and time values in queries. For example, a FetchXML query can find all orders fulfilled in the last fiscal month or urgent cases with high severity that are older than 15 minutes.  
  
> [!NOTE]
>  For all fiscal date queries, the FetchXML query uses the organization’s fiscal year settings.  
  
<a name="FiscalDate"></a>   
## Using FetchXML fiscal date conditional operators  
 The following example shows a FetchXML expression that finds all orders fulfilled in the last fiscal period, according to the organization’s fiscal year settings. For example, if the organization uses fiscal months, the query returns orders fulfilled in the last fiscal month. If the organization uses fiscal quarters, the query returns orders fulfilled in the last fiscal quarter. If the organization uses fiscal semesters, orders fulfilled in the last fiscal semester are returned.  
  
```xml  
<fetch>  
 <entity name="order">  
  <attribute name="name"/>  
  <filter type="and">  
   <condition attribute="datefulfilled" operator="last-fiscal-period"/>  
  </filter>  
 </entity>  
</fetch>  
```  
  
 The following example shows a FetchXML expression that finds all accounts created in fiscal year 2013.  
  
```xml  
<fetch>  
 <entity name="account">  
  <attribute name="name"/>  
  <filter type="and">  
   <condition attribute="createdon" operator="in-fiscal-year" value="2013"/>  
  </filter>  
 </entity>  
</fetch>  
```  
  
 The following example shows a FetchXML expression that finds all opportunities with an estimated close date in the next three fiscal years, based on the organization’s fiscal year settings. The value for `x` is specified in the value attribute of the condition tag.  
  
```xml  
<fetch>  
 <entity name="opportunity">  
  <attribute name="name"/>  
  <filter type="and">  
   <condition attribute="estimatedclosedate" operator="next-x-fiscal-years" value="3"/>  
  </filter>  
 </entity>  
</fetch>  
```  
  
 The following example shows a FetchXML expression that finds all orders fulfilled in period three of any fiscal year, according to the organization’s fiscal year settings. The fiscal period value is specified in the value attribute of the condition tag. If the organization uses fiscal months, the query returns results from month three. If the organization uses fiscal quarters, the query returns results from quarter three. If the organization uses fiscal semesters, no results are returned; there are only two semesters, and the value supplied is therefore out-of-range.  
  
```xml  
<fetch>  
 <entity name="order">  
  <attribute name="name"/>  
  <filter type="and">  
   <condition attribute="datefulfilled" operator="in-fiscal-period" value="3"/>  
  </filter>  
 </entity>  
</fetch>  
```  
  
 The following example shows a FetchXML expression that finds all orders fulfilled in period three of fiscal year 2013, according to the organization’s fiscal year settings. If the organization uses fiscal months, the query returns results from month three. If the organization uses fiscal quarters, the query returns results from quarter three. If the organization uses fiscal semesters, no results are returned; there are only two semesters, and the value supplied is therefore out-of-range.  
  
```xml  
<fetch>  
 <entity name="order">  
  <attribute name="name"/>  
  <filter type="and">  
   <condition attribute="datefulfilled" operator="in-fiscal-period-and-year">  
    <value>3</value>  
    <value>2013</value>  
   </condition>  
  </filter>  
 </entity>  
</fetch>  
```  
  
 The following example shows a FetchXML aggregation expression that sums the total amount of orders fulfilled and groups the result by fiscal semester and fiscal year.  
  
```xml  
<fetch aggregate="true">  
 <entity name="order">  
  <attribute name="totalamount" aggregate="sum" alias="total"/>  
  <attribute name="datefulfilled" groupby="true" dategrouping="fiscal-period"/>  
 </entity>  
</fetch>  
```  
  
<a name="OlderThan"></a>   
## Using “older than” clauses for date and time values  
 The following example shows a FetchXML that finds incidents that are older than 30 minutes.  
  
```  
<fetch>  
  <entity name="incident">  
    <attribute name="title" />  
    <attribute name="ticketnumber" />  
    <attribute name="createdon" />  
    <attribute name="incidentid" />  
    <filter type="and">  
      <condition attribute="createdon" operator="olderthan-x-minutes" value="30" />  
    </filter>  
  </entity>  
</fetch>  
```  
  
 Use the following syntax to specify variious *older than* clauses in a FetchXML expression.  
  
 Older than X minutes  
 ```xml  
<condition attribute="<AttributeName>" operator="olderthan-x-minutes" value="<VALUE>" />  
```  
  
> [!NOTE]
>  This clause is not supported for date and time attributes with `DateOnly` behavior. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Date and time query operators not supported for DateOnly behavior](../behavior-format-date-time-attribute.md#date-and-time-query-operators-not-supported-for-dateonly-behavior)
  
 Older than X hours  
 ```xml  
<condition attribute="<AttributeName>" operator="olderthan-x-hours" value="<VALUE>" />  
```  
  
> [!NOTE]
>  This clause is not supported for date and time attributes with `DateOnly` behavior. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Date and time query operators not supported for DateOnly behavior](../behavior-format-date-time-attribute.md#date-and-time-query-operators-not-supported-for-dateonly-behavior)  
  
 Older than X days  
 ```xml  
<condition attribute="<AttributeName>" operator="olderthan-x-days" value="<VALUE>" />  
```  
  
 Older than X weeks  
 ```xml  
<condition attribute="<AttributeName>" operator="olderthan-x-weeks" value="<VALUE>" />  
```  
  
 Older than X months  
 ```xml  
<condition attribute="<AttributeName>" operator="olderthan-x-months" value="<VALUE>" />  
```  
  
 Older than X years  
 ```xml  
<condition attribute="<AttributeName>" operator="olderthan-x-years" value="<VALUE>" />  
```  
  
> [!NOTE]
>  Except for the **Older than X months** clause, all the other *older than* clauses are available only if you’re using versions later than [!INCLUDE[pn_crm_online_2015_update_1_shortest](../../includes/pn-crm-online-2015-update-1-shortest.md)] or [!INCLUDE[pn_crm_2015_service_pack_1_op_short](../../includes/pn-crm-2015-service-pack-1-op-short.md)].  
  
### See also  
 [Create Queries to Retrieve Data](retrieve-data-queries-sdk-assemblies.md)   
 [Building Queries with FetchXML](build-queries-fetchxml.md)   
 [Use a left outer join in FetchXML to query for records "not in"](use-left-outer-join-fetchxml-query-records-not-in.md)
