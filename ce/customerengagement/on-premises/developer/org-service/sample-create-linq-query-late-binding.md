---
title: "Sample: Create a LINQ query with late binding (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to create .NET Language-Integrated Query (LINQ) queries using late-bound entities"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: "pehecke"
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - late-bound entity classes, creating LINQ queries that use late-bound entities sample
  - LINQ query examples and samples, creating LINQ queries that use late-bound entities sample
  - creating LINQ queries that use late-bound entities sample
  - sample for using LINQ with late binding
  - late binding with LINQ sample
  - LINQ query examples and samples, using LINQ with late binding sample
  - sample for creating LINQ queries that use late-bound entities
ms.assetid: b0b5a5f6-03b9-4c42-9394-7fa6d27ee509
caps.latest.revision: 19
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Create a LINQ query with late binding

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Queries](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Queries).  

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
 <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext.CreateQuery(System.String)>
