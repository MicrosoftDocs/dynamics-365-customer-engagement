---
title: "Sample: Create a LINQ query (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to create simple .NET Language-Integrated Query (LINQ) queries"
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
  - LINQ query examples and samples, creating simple LINQ queries sample
  - simple LINQ queries sample
  - creating simple LINQ queries sample
  - sample for creating simple LINQ queries
ms.assetid: 43b26b09-636e-4781-8477-65454c4c5232
caps.latest.revision: 19
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Create a LINQ query

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. [!INCLUDE[sdk_download](../../includes/sdk-download.md)] Download the complete sample from [Sample: Work with Queries](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Queries).   

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create simple [!INCLUDE[pn_LINQ](../../includes/pn-linq.md)] queries. The following queries are demonstrated:  
  
-   Retrieve all accounts that the calling user has access to.  
  
-   Retrieve all accounts owned by the user who has read access rights to the accounts and where the last name of the user is not “Cannon.”  
  
-   Return a count of all accounts that have a county specified in their addresses.  
  
-   Return a count of states in which we have an account. This uses the `distinct` keyword that counts a state only once.  
  
-   Return contacts where the city equals “Redmond” AND the first name is “Joe” OR “John.”  
  
## Example  
 [!code-csharp[query#CreateALinqQuery](../../snippets/csharp/CRMV8/query/cs/createalinqquery.cs#createalinqquery)]  
  
### See also  
 [Build Queries with LINQ (.NET Language-Integrated Query)](build-queries-with-linq-net-language-integrated-query.md)   
 [Sample: Complex LINQ Queries](sample-complex-linq-queries.md)   
 <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext>
