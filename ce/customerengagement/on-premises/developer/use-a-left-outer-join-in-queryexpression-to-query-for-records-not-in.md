---
title: "Use a left outer join in QueryExpression to query for records &quot;not in&quot; | MicrosoftDocs"
description: Learn how to use a left outer join by using the QueryExpression class to perform a query that filters the join table.
ms.custom: 
ms.reviewer: pehecke

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: how-to
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 92be6428-d93a-4837-abd6-df052ecfa8a9
caps.latest.revision: 9
author: KumarVivek
ms.author: kvivek
search.audienceType: 
  - developer

---
# Use a left outer join in QueryExpression to query for records &quot;not in&quot;

You can use a left outer join by using the <xref:Microsoft.Crm.Sdk.Messages.SearchByKeywordsKbArticleRequest.QueryExpression> class to perform a query that filters on the join table, such as to find all contacts who did not have any campaign activities in the past two months. Another common use for this type of a query is to find records “not in” a set, such as in these cases:  
  
- Find all leads that have no tasks  
  
- Find all accounts that have no contacts  
  
- Find all leads that have one or more tasks  
  
  A left outer join returns each row that satisfies the join of the first input with the second input. It also returns any rows from the first input that had no matching rows in the second input. The nonmatching rows in the second input are returned as null values.  
  
  You can perform a left outer join in `QueryExpression` by using the `entityname` attribute as a condition operator. The `entityname` attribute is valid in conditions, filters, and nested filters.  
  
## Find all leads that have no tasks, using an alias  
 The following example shows how to construct this query:  
  
```csharp 
QueryExpression qx = new QueryExpression("lead");  
qx.ColumnSet.AddColumn("subject");  
  
LinkEntity link = qx.AddLink("task", "leadid", "regardingobjectid", JoinOperator.LeftOuter);  
link.Columns.AddColumn("subject");  
link.EntityAlias = "tsk";  
  
qx.Criteria = new FilterExpression();  
qx.Criteria.AddCondition("tsk", "activityid", ConditionOperator.Null);  
  
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
 [Build Queries with QueryExpression](/powerapps/developer/data-platform/org-service/build-queries-with-queryexpression)   
 [Test for a Null Value](/powerapps/developer/data-platform/org-service/test-null-value)   
 [Using the QueryExpression Class](/powerapps/developer/data-platform/org-service/use-queryexpression-class)   
 [Using the QueryByAttribute Class](/powerapps/developer/data-platform/org-service/use-querybyattribute-class)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
