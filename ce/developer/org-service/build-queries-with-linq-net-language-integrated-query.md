---
title: "Build queries with LINQ (.NET language-integrated query) (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Read how to use .NET Language-Integrated Query (LINQ) to write queries in Dynamics 365 (online & on-premises)"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 1c2b2e80-e85d-422c-a3f4-f48895d9c70b
caps.latest.revision: 27
author: "KumarVivek"
ms.author: "kvivek"
manager: "jdaly"
---
# Build queries with LINQ (.NET language-integrated query)
You can use [!INCLUDE[pn_LINQ](../../includes/pn-linq.md)] to write queries in [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. You can use the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext> class or a deriving class created by the [!INCLUDE[sdk_CodeGenUtility](../../includes/sdk-codegenutility.md)] tool to write [LINQ](https://msdn.microsoft.com/library/bb397897.aspx) queries that access the SOAP endpoint (Organization.svc). The <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext> class contains an underlying LINQ query provider that translates LINQ queries from [!INCLUDE[pn_MS_Visual_C#](../../includes/pn-ms-visual-csharp.md)] or [!INCLUDE[pn_Visual_Basic](../../includes/pn-visual-basic.md)] syntax into the query API used by [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].  
  
 When you use early-bound programming classes you can generate a class derived from the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext> class if you specify the name of the class using the **servicecontextname** parameter when using the Code Generation Tool (CrmSvcUtil.exe). Use of this class allows for referencing an [IQueryable](https://msdn.microsoft.com/library/system.linq.iqueryable.aspx) entity set using the pattern `<entity schema name>+Set`, for example **AccountSet** to reference the collection of `Account` entity records. All samples in the [!INCLUDE[pn_sdk](../../includes/pn-sdk.md)] use **ServiceContext** as the name for this class but your code may use a different name. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Create Early Bound Entity Classes with the Code Generation Tool (CrmSvcUtil.exe)](create-early-bound-entity-classes-code-generation-tool.md) 
  
## In This Section  
 [Use LINQ to Construct a Query](use-linq-construct-query.md)  
  
 [Use Late-Bound Entity Class with a LINQ Query](use-late-bound-entity-class-linq-query.md)  
  
 [Use Entity Lookup Attributes with LINQ](order-results-entity-attributes-linq.md)  
  
 [Order Results Using Entity Attributes with LINQ](order-results-entity-attributes-linq.md)  
  
 [Paging Large Result Sets with LINQ](page-large-result-sets-linq.md)  
  
 [LINQ Query Examples](linq-query-examples.md)  
  
 [Sample: Create a LINQ Query](sample-create-linq-query.md)  
  
 [Sample: LINQ Query Examples](sample-complex-linq-queries.md)  
  
 [Sample: RetrieveMultiple With Condition Operators Using LINQ](sample-retrieve-multiple-with-condition-operators-using-linq.md)  
  
 [Sample: More LINQ Query Examples](sample-more-linq-query-examples.md)  
  
 [Sample: Use LINQ with Late Binding](sample-create-linq-query-late-binding.md)
