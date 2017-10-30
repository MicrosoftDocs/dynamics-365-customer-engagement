---
title: "Sample: Use FetchXML with a paging cookie (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to use the paging cookie in a FetchXML query to retrieve successive pages of query results. It uses the IOrganizationService. QueryBase) method"
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
  - "retrieving successive pages of query results by using FetchXML sample"
  - "FetchXML queries, samples"
  - "using FetchXML with a paging cookie sample"
  - "building queries with FetchXML, samples"
  - "sample for retrieving successive pages of query results by using FetchXML"
  - "sample for using FetchXML with a paging cookie"
ms.assetid: 1d8acb4e-f8c3-478a-ae4f-e462973cd63d
caps.latest.revision: 27
author: "KumarVivek"
ms.author: "kvivek"
manager: "jdaly"
---
# Sample: Use FetchXML with a paging cookie
This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. Download the complete sample here [Sample: Work with Queries](https://code.msdn.microsoft.com/Sample-Work-with-Queries-8265a78e) 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Example  
 This sample shows how to use the paging cookie in a FetchXML query to retrieve successive pages of query results. It uses the<xref:Microsoft.Xrm.Sdk.IOrganizationService>. <xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*> method.  
  
 [!code-csharp[Query#FetchPagingWithCookie](../../snippets/csharp/CRMV8/query/cs/fetchpagingwithcookie.cs#fetchpagingwithcookie)]  
  
### See also  
 [Build Queries with FetchXML](build-queries-fetchxml.md)   
 [Sample: Convert queries between Fetch and QueryExpression](sample-convert-queries-fetch-queryexpression.md)   
 [Sample: CrmServiceHelper Class](helper-code-serverconnection-class.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>   
 [Using FetchXML Aggregration](use-fetchxml-aggregation.md)   
 [Using FetchXML](use-fetchxml-construct-query.md)
