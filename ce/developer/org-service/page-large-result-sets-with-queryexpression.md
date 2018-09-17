---
title: "Page large result sets with QueryExpression (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "In Dynamics 365 (online) Customer Engagement, you can use the paging cookie feature to make paging in an application faster for large datasets. The feature is available in both FetchXML and QueryExpression queries"
ms.custom: ""
ms.date: 09/13/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 0be338b9-dbb1-41b6-b313-c632e40d2af5
caps.latest.revision: 29
author: "mayadumesh"
ms.author: "kvivek"
manager: "amyla"
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Page large result sets with QueryExpression

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

In [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement, you can use the paging cookie feature to make paging in an application faster for large datasets. The feature is available in both FetchXML and <xref:Microsoft.Xrm.Sdk.Query.QueryExpression> queries. When you use the paging cookie feature when querying a set of records, the result contains a value for the paging cookie. To improve system performance, you can then pass that value when you retrieve the next set of records.  
  
 <xref:Microsoft.Xrm.Sdk.Query.QueryExpression> and FetchXML use different formats for their paging cookies. If you convert from one query format to the other by using the <xref:Microsoft.Crm.Sdk.Messages.QueryExpressionToFetchXmlRequest> message or the <xref:Microsoft.Crm.Sdk.Messages.FetchXmlToQueryExpressionRequest> message, the paging cookie value is ignored. In addition, if you request nonconsecutive pages, the paging cookie value is ignored.  
  
<a name="QueryExpression"></a> 

## Using a paging cookie with QueryExpression  
 The following example shows how to use the paging cookie with a query expression. For the complete sample code, see [Sample: Use QueryExpression with a paging cookie](sample-use-queryexpression-with-a-paging-cookie.md).  
  
 [!code-csharp[Query#QueryExpressionPagingWithCookie1](../../snippets/csharp/CRMV8/query/cs/queryexpressionpagingwithcookie1.cs#queryexpressionpagingwithcookie1)]  
  
## When not to use paging 


Paging depends on the common case where each row returned represents a unique entity record. There are some queries you can construct that will provide rows that combine data from the primary entity with related entities. This will result in multiple primary entity rows that refer to the same primary key value. If you depend on paging in this situation you will get inconsistent results.

In this case, here are several strategies you can apply.

### Write your Query so that the primary entity ids are unique

If your query includes only one related entity and doesn't include many-to-many relationships, you can usually make the related entity the primary entity in your query to resolve this.

### Don't set the PagingCookie 

Rather than include the paging, just set the `PageNumber`. This will work but there will be some performance impact for large data sets.

### Split your query into multiple queries

You can compose multiple queries which you then join the results together in your code.

### See also  
 [Building Queries with QueryExpression](build-queries-with-queryexpression.md)   
 [Sample: Use QueryExpression with a paging cookie](sample-use-queryexpression-with-a-paging-cookie.md)   
 [Sample: Retrieve with one-to-many relationship](sample-retrieve-with-one-to-many-relationship.md)   
 [Using the QueryExpression Class](use-queryexpression-class.md)   
 [Page Large Result Sets with FetchXML](page-large-result-sets-with-fetchxml.md)
