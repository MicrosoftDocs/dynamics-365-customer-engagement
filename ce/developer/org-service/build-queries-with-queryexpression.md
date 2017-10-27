---
title: "Build queries with QueryExpression (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Read how you can use the QueryExpression class to programmatically build a query containing data filters and search conditions that define the scope of a database search"
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
  - "saving queries"
  - "query expressions, used for single-object searches"
  - "complex queries, introduction"
  - "building queries by using QueryExpression, creating queries that contain data filters and search conditions"
  - "query expressions, about; definition; using"
  - "QueryBase; QueryExpression; and QueryByAttribute classes, differences between"
  - "building queries by using QueryExpression, introduction"
  - "queries, samples"
  - "QueryBase; QueryExpression; and QueryByAttribute classes, introduction to building queries"
  - "creating queries to retrieve records, available types in CRM"
  - "queries, simple"
  - "queries, saving"
  - "queries, complex"
ms.assetid: 44d32c72-284a-43d3-96f5-d9b0a0486949
caps.latest.revision: 48
author: "KumarVivek"
ms.author: "kvivek"
manager: "jdaly"
---
# Build queries with QueryExpression
In [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement, you can use the <xref:Microsoft.Xrm.Sdk.Query.QueryExpression> class to programmatically build a query containing data filters and search conditions that define the scope of a database search. A query expression is used for single-object searches. For example, you can create a search to return all accounts that match certain search criteria. The <xref:Microsoft.Xrm.Sdk.Query.QueryBase> class is the base class for query expressions. There are two derived classes: <xref:Microsoft.Xrm.Sdk.Query.QueryExpression> and <xref:Microsoft.Xrm.Sdk.Query.QueryByAttribute>. The `QueryExpression` class supports complex queries. The `QueryByAttribute` class is a simple means to search for entities where attributes match specified values.  
  
 Query expressions are used in methods that retrieve more than one record, such as the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*> method, in messages that perform an operation on a result set specified by a query expression, such as <xref:Microsoft.Crm.Sdk.Messages.BulkDeleteRequest> and when the ID for a specific record is not known.  
  
 In addition, there is a new attribute on the organization entity, `Organization.QuickFindRecordLimitEnabled`. When this `Boolean` attribute is `true`, a limit is imposed on quick find queries. If a user provides search criteria in quick find that is not selective enough, the system detects this and stops the search. This supports a faster form of quick find and can make a big performance difference.  
  
> [!WARNING]
>  Don’t retrieve all attributes in a query because of the negative effect on performance. This is particularly true if the query is used as a parameter to an update request. In an update, if all attributes are included this sets all field values, even if they are unchanged, and often triggers cascaded updates to child records.  
  
 There are two additional ways to create queries to retrieve records from [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)]. FetchXML, the proprietary [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] query language, can be used to perform some queries by using XML-based queries. For more information, see [Building Queries with FetchXML](build-queries-fetchxml.md). You can also use [!INCLUDE[pn_LINQ](../../includes/pn-linq.md)] to write queries. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Build Queries with LINQ (.NET Language-Integrated Query)](build-queries-with-linq-net-language-integrated-query.md).  
  
 To save a query, you can convert it to FetchXML by using the <xref:Microsoft.Crm.Sdk.Messages.QueryExpressionToFetchXmlRequest> and save it as a saved view by using the `userquery` entity.  
  
## In This Section  
 [Using the QueryByAttribute Class](use-querybyattribute-class.md)  
  
 [Using the QueryExpression Class](use-queryexpression-class.md)  
  
 [Using the ColumnSet Class](use-the-columnset-class.md)  
  
 [Using the ConditionExpression Class](use-conditionexpression-class.md)  
  
 [Using the FilterExpression Class](use-filterexpression-class.md)  
  
 [Use a left outer join in QueryExpression to query for records "not in"](use-left-outer-join-queryexpression-query-records-not-in.md)  
  
 [Testing for a Null Value](test-null-value.md)  
  
 [Page Large Result Sets with Query Expression and FetchXML](page-large-result-sets-with-queryexpression.md)  
  
 [Sample: Retrieve With One-To-Many Relationship](sample-retrieve-with-one-to-many-relationship.md)  
  
 [Sample: Retrieve Multiple with Query By Attribute](sample-retrieve-multiple-querybyattribute-class.md)  
  
 [Sample: Retrieve Multiple with Query Expression](sample-retrieve-multiple-queryexpression-class.md)  
  
 [Sample: Use QueryExpression with a paging cookie](sample-use-queryexpression-with-a-paging-cookie.md)  
  
## Reference  
 <xref:Microsoft.Xrm.Sdk.Query.QueryBase>  
  
 <xref:Microsoft.Xrm.Sdk.Query.QueryExpression>  
  
 <xref:Microsoft.Xrm.Sdk.Query.QueryByAttribute>  
  
 <xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>  
  
 <xref:Microsoft.Xrm.Sdk.Query.ColumnSet>  
  
 <xref:Microsoft.Xrm.Sdk.Query.ConditionExpression>  
  
 <xref:Microsoft.Xrm.Sdk.Query.FilterExpression>  
  
 <xref:Microsoft.Xrm.Sdk.Query.PagingInfo.PagingCookie>  
  
### See also  
 [Sample: Convert queries between Fetch and QueryExpression](sample-convert-queries-fetch-queryexpression.md)
