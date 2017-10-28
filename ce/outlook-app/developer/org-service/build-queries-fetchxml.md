---
title: "Build queries with FetchXML (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "FetchXML is a proprietary query language that is used in Dynamics 365 (online) Customer Engagement. A FetchXML query can be executed by using the IOrganizationService.QueryBase) method. FetchXML query can be converted to a query expression with the FetchXmlToQueryExpressionRequest message"
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
  - "FetchXML queries, building queries with FetchXML"
  - "FetchXML queries, introduction to creating queries"
  - "FetchXML queries, executing by using the IOrganizationService.RetrieveMultiple method"
  - "building queries with FetchXML, introduction"
  - "using FetchXML to create queries, introduction"
  - "creating queries with FetchXML, introduction"
  - "FetchXML queries, saving a query as a user-owned or organization-owned view"
ms.assetid: 8ff32261-4a9a-4186-bf2f-ee28496b16ef
caps.latest.revision: 47
author: "KumarVivek"
ms.author: "kvivek"
manager: "jdaly"
---
# Build queries with FetchXML
FetchXML is a proprietary query language that is used in [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. It’s based on a schema that describes the capabilities of the language. The FetchXML language supports similar query capabilities as query expressions. In addition, it’s used as a serialized form of query, used to save a query as a user-owned saved view in the `userquery` entity and as an organization-owned saved view in the `savedquery` entity.  
  
 A FetchXML query can be executed by using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*> method. You can convert a FetchXML query to a query expression with the <xref:Microsoft.Crm.Sdk.Messages.FetchXmlToQueryExpressionRequest> message.  
  
 For information about how to use LINQPad to work with FetchXML, see this blog post: [Getting FetchXML from LINQPad](http://blogs.msdn.com/b/devkeydet/archive/2012/04/22/getting-fetchxml-from-linqpad.aspx).  
  
 For information about a utility that you can use to convert SQL scripts to FetchXML, see [SQL2FetchXML Help](http://www.sql2fetchxml.com/help.aspx).  
  
## In This Section  
 [Use FetchXML to Construct a Query](use-fetchxml-construct-query.md)  
  
 [Use FetchXML Aggregation](use-fetchxml-aggregation.md)  
  
 [Page Large Result Sets with FetchXML](page-large-result-sets-with-fetchxml.md)  
  
 [Fiscal Date Query Operators in FetchXML](fiscal-date-older-datetime-query-operators-fetchxml.md)  
  
 [Use a left outer join in FetchXML to query for records not in](use-left-outer-join-fetchxml-query-records-not-in.md)  
  
 [Sample: Use Aggregation in FetchXML](sample-use-aggregation-fetchxml.md)  
  
 [Sample: Use FetchXML with a Paging Cookie](sample-use-fetchxml-paging-cookie.md)  
  
 [Sample: Convert Queries Between Fetch and Query Expression](sample-convert-queries-fetch-queryexpression.md)  
  
 [Sample: Validate and execute a saved query](sample-validate-execute-saved-query.md)  
  
## Related Sections  
 [Build queries with LINQ (.NET language-integrated query)](build-queries-with-linq-net-language-integrated-query.md)  
  
 [Build queries with QueryExpression](build-queries-with-queryexpression.md)  
  
 [Retrieve Records for Many-To-Many Relationships using Intersect Entities](retrieve-records-many-to-many-relationships-intersect-entities.md)  
  
 [FetchXML schema](fetchxml-schema.md)
