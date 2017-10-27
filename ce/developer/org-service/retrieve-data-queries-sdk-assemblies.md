---
title: "Retrieve data with queries using SDK assemblies (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "There are several ways to create queries in Dynamics 365 (online) Customer Engagement. This topic lists the basic capabilities of each query style"
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
  - "queries, using to retrieve data"
  - "creating queries to retrieve data, by using FetchXML"
  - "creating queries to retrieve data, by using .NET language-Integrated Query (LINQ)"
  - "retrieving data, by creating queries"
  - "creating queries to retrieve data, early and late binding scenarios"
  - "creating queries to retrieve data, by using QueryExpression"
ms.assetid: e9d32d0c-c0f1-43bf-8bc8-a1f8836f661a
caps.latest.revision: 30
author: "KumarVivek"
ms.author: "kvivek"
manager: "jdaly"
---
# Retrieve data with queries using SDK assemblies
There are several ways to create queries in [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. You can use [!INCLUDE[pn_LINQ](../../includes/pn-linq.md)] in early and late binding scenarios, you can write queries by using FetchXML, the proprietary [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] query language, or you can build a query by using QueryExpression and the <xref:Microsoft.Xrm.Sdk.Query.QueryExpression> class.  
  
 The following table lists the basic capabilities of each query style.  
  
|Query style|Capabilities|  
|-----------------|------------------|  
|FetchXML|Supports all the features of `QueryExpression` plus aggregates and grouping. Queries are built as XML statements.|  
|QueryExpression|Queries are built as an object model. Supports all the features in FetchXML except for aggregates and grouping.|  
|LINQ|Queries are built using standard language, but internally uses `QueryExpression` so is limited to the features of `QueryExpression`.|  
  
 Use FetchXML to create queries that return aggregates such as the sum of a value for all returned records. You can also perform “group by” operations with FetchXML.  
  
 [!INCLUDE[pn_LINQ](../../includes/pn-linq.md)] uses standard query patterns. The <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext> class contains the LINQ query provider and is efficient at creating multiple associations.  
  
 The following messages are useful for working with queries when you want to convert between FetchXml and QueryExpression: <xref:Microsoft.Crm.Sdk.Messages.FetchXmlToQueryExpressionRequest> and <xref:Microsoft.Crm.Sdk.Messages.QueryExpressionToFetchXmlRequest>.  
  
## In this section  
 [Build Queries with LINQ (.NET Language-Integrated Query)](build-queries-with-linq-net-language-integrated-query.md)  
  
 [Building Queries with FetchXML](build-queries-fetchxml.md)  
  
 [Building Queries with QueryExpression](build-queries-with-queryexpression.md)  
  
 [Query hierarchical data](query-hierarchical-data.md)  
  
 [Retrieve Records for Many-To-Many Relationships using Intersect Entities](retrieve-records-many-to-many-relationships-intersect-entities.md)  
  
 [FetchXML Schema](fetchxml-schema.md)
