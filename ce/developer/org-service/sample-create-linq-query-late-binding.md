---
title: "Sample: Create a LINQ query with late binding (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to create .NET Language-Integrated Query (LINQ) queries using late-bound entities"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
helpviewer_keywords: 
  - "late-bound entity classes, creating LINQ queries that use late-bound entities sample"
  - "LINQ query examples and samples, creating LINQ queries that use late-bound entities sample"
  - "creating LINQ queries that use late-bound entities sample"
  - "sample for using LINQ with late binding"
  - "late binding with LINQ sample"
  - "LINQ query examples and samples, using LINQ with late binding sample"
  - "sample for creating LINQ queries that use late-bound entities"
ms.assetid: b0b5a5f6-03b9-4c42-9394-7fa6d27ee509
caps.latest.revision: 19
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Sample: Create a LINQ query with late binding

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. Download the complete sample from [Sample: Work with Queries](https://code.msdn.microsoft.com/Sample-Work-with-Queries-8265a78e).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create [!INCLUDE[pn_LINQ](../../includes/pn-linq.md)] queries using late-bound entities.  
  
## Example  
 [!code-csharp[query#UseLinqWithDotNetDataServicesDE](../../snippets/csharp/CRMV8/query/cs/uselinqwithdotnetdataservicesde.cs#uselinqwithdotnetdataservicesde)]  
  
### See also  
 [Build Queries with LINQ (.NET Language-Integrated Query)](build-queries-with-linq-net-language-integrated-query.md)   
 <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext>   
 [CreateQuery\`\`1](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.client.organizationservicecontext.createquery``1)   
 [String)](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.client.organizationservicecontext.createquery\(system.string\))