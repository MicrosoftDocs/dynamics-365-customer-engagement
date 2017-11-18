---
title: "Use the QueryExpression class (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "In Dynamics 365 (online) Customer Engagement, you can use the QueryExpression class to build complex queries for use with the IOrganizationService.QueryBase) method or the RetrieveMultipleRequest message"
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
  - "building queries by using QueryExpression, QueryExpression class"
  - "QueryExpression class, building complex queries"
  - "QueryExpression class, obtaining record counts with the ReturnTotalRecordCount property"
  - "QueryExpression class, difference between the QueryByAttribute class"
  - "using the QueryExpression class"
  - "QueryExpression class, about; properties for; and code example"
ms.assetid: f5d2195b-8cae-49d6-a493-6f8b92e7f54e
caps.latest.revision: 29
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Use the QueryExpression class

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

In [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement, you can use the <xref:Microsoft.Xrm.Sdk.Query.QueryExpression> class to build complex queries for use with the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*> method or the <xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> message. You can set query parameters to the <xref:Microsoft.Xrm.Sdk.Query.QueryExpression> by using the <xref:Microsoft.Xrm.Sdk.Query.ConditionExpression>, <xref:Microsoft.Xrm.Sdk.Query.ColumnSet>, and <xref:Microsoft.Xrm.Sdk.Query.FilterExpression> classes.  
  
 The <xref:Microsoft.Xrm.Sdk.Query.QueryExpression> class lets you create complex queries. The <xref:Microsoft.Xrm.Sdk.Query.QueryByAttribute> class is designed to be a simple way to search for entities where attributes match specified values.  
  
 The following table lists the properties that you set to create a query expression.  
  
|Property|Description|  
|--------------|-----------------|  
|<xref:Microsoft.Xrm.Sdk.Query.QueryExpression.EntityName>|Specifies which type of entity will be retrieved. A query expression can only retrieve a collection of one entity type.|  
|<xref:Microsoft.Xrm.Sdk.Query.QueryExpression.ColumnSet>|Specifies the set of attributes (columns) to retrieve.|  
|<xref:Microsoft.Xrm.Sdk.Query.QueryExpression.Criteria>|Specifies complex conditional and logical filter expressions that filter the results of the query.|  
|<xref:Microsoft.Xrm.Sdk.Query.QueryExpression.Distinct>|Specifies whether the results of the query contain duplicate records.|  
|<xref:Microsoft.Xrm.Sdk.Query.QueryExpression.LinkEntities>|Specifies the links between multiple entity types.|  
|<xref:Microsoft.Xrm.Sdk.Query.QueryExpression.Orders>|Specifies the order in which the records are returned from the query.|  
|<xref:Microsoft.Xrm.Sdk.Query.QueryExpression.PageInfo>|Specifies the number of pages and the number of records per page returned from the query.|  
  
<a name="record_count"></a>   
## Record count  
 To find out how many records the query returned, set the <xref:Microsoft.Xrm.Sdk.Query.PagingInfo.ReturnTotalRecordCount> property to true before executing the query. When you do this, the <xref:Microsoft.Xrm.Sdk.EntityCollection.TotalRecordCount> will be set. Otherwise, this value will be -1.  
  
## Example  
 The following sample shows how to use the <xref:Microsoft.Xrm.Sdk.Query.QueryExpression> class.  
  
```csharp  
//  Query using ConditionExpression and FilterExpression  
ConditionExpression condition1 = new ConditionExpression();  
condition1.AttributeName = "lastname";  
condition1.Operator = ConditionOperator.Equal;  
condition1.Values.Add("Brown");              
  
FilterExpression filter1 = new FilterExpression();  
filter1.Conditions.Add(condition1);  
  
QueryExpression query = new QueryExpression("contact");  
query.ColumnSet.AddColumns("firstname", "lastname");  
query.Criteria.AddFilter(filter1);  
  
EntityCollection result1 = _serviceProxy.RetrieveMultiple(query);  
Console.WriteLine();Console.WriteLine("Query using Query Expression with ConditionExpression and FilterExpression");  
Console.WriteLine("---------------------------------------");  
foreach (var a in result1.Entities)  
{  
    Console.WriteLine("Name: " + a.Attributes["firstname"] + " " + a.Attributes["lastname"]);  
}  
Console.WriteLine("---------------------------------------");  
```  
  
### See also  
 [Building Queries with QueryExpression](build-queries-with-queryexpression.md)   
 [Use the ColumnSet Class](use-the-columnset-class.md)   
 [Using the ConditionExpression Class](use-conditionexpression-class.md)   
 [Using the FilterExpression Class](use-filterexpression-class.md)   
 <xref:Microsoft.Xrm.Sdk.Query.QueryExpression>