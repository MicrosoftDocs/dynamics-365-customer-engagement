---
title: "Use a left outer join in FetchXML to query for records &quot;not in&quot; (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Read how to use a left outer join in FetchXML to perform a query that filters on the join table and build a query to find records “not in” a set"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c4f2e2df-7b9a-4842-ba1e-29c5b59d8fc7
caps.latest.revision: 11
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Use a left outer join in FetchXML to query for records &quot;not in&quot;

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

You can use a left outer join in FetchXML to perform a query that filters on the join table, such as to find all contacts who did not have any campaign activities in the past two months. Another common use for this type of a query is to find records “not in” a set, such as in these cases:  
  
- Find all leads that have no tasks  
  
- Find all accounts that have no contacts  
  
- Find all leads that have one or more tasks  
  
  A left outer join returns each row that satisfies the join of the first input with the second input. It also returns any rows from the first input that had no matching rows in the second input. The nonmatching rows in the second input are returned as null values.  
  
  You can perform a left outer join in FetchXML by using the `entityname` attribute as a condition operator. The `entityname` attribute is valid in conditions, filters, and nested filters.  
  
  You can create a query using a left outer join programmatically and execute the query using the <xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest>, and you can save the query by creating a `SavedQuery` record. You can open a saved query that contains a left outer join in the Advanced Find or Saved Query editors in the web application and execute and view results, but some editor functionality is disabled. Those editors will allow modifications to the query, such as to change the columns returned, but the editor does not support changing the left outer join.  
  
## Example: Find all accounts that have no leads  
 The following shows how to construct the query in FetchXML:  
  
```xml  
<fetch mapping='logical'>  
 <entity name='account'>  
  <attribute name='name'/>  
  <link-entity name='lead'  
               from='leadid'  
               to='originatingleadid'  
               link-type='outer'/>  
  <filter type='and'>  
   <condition entityname='lead'  
              attribute='leadid'  
              operator='null'/>  
  </filter>  
 </entity>  
</fetch>  
  
```  
  
## Example: Find all leads that have no tasks, using an alias  
 The following shows how to construct the query in FetchXML:  
  
```xml  
<fetch version="1.0" output-format="xml-platform" mapping="logical" distinct="true">  
  <entity name="lead">  
    <attribute name="fullname" />  
    <link-entity name="task" from="regardingobjectid" to="leadid" alias="ab" link-type="outer">  
       <attribute name="regardingobjectid" />  
    </link-entity>  
    <filter type="and">  
        <condition entityname="ab" attribute="regardingobjectid" operator="null" />  
    </filter>  
  </entity>  
<fetch/>  
  
```  
  
 This is equivalent to the following SQL:  
  
```sql  
SELECT lead.FullName  
FROM Leads as lead  
LEFT OUTER JOIN Tasks as ab  
ON (lead.leadId  =  ab.RegardingObjectId)  
WHERE ab.RegardingObjectId is null  
  
```  
  
### See also  
 [Build Queries with FetchXML](build-queries-fetchxml.md)   
 [Sample: Use Aggregation in FetchXML](sample-use-aggregation-fetchxml.md)   
 [Use FetchXML to Construct a Query](use-fetchxml-construct-query.md)   
 [Sample: Validate and Execute a Saved Query](sample-validate-execute-saved-query.md)
