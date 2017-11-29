---
title: "Sample: Use aggregation in FetchXML (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to retrieve aggregate record data using FetchXML"
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
  - "retrieving aggregate record data by using FetchXML sample"
  - "using aggregation in FetchXML sample"
  - "FetchXML queries, samples"
  - "sample for retrieving aggregate record data by using FetchXML"
  - "building queries with FetchXML, samples"
  - "sample for using aggregation in FetchXML"
ms.assetid: 283151dc-212c-445d-8181-9baec0dcba75
caps.latest.revision: 28
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Sample: Use aggregation in FetchXML

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_crm_2016_and_online_full](../../includes/pn-crm-2016-and-online-full.md)]. Download the complete sample from [Sample: Work with Queries](https://code.msdn.microsoft.com/Sample-Work-with-Queries-8265a78e).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to retrieve aggregate record data using FetchXML.  
  
## Example  
 [!code-csharp[Query#FetchAggregationAndGroupBy](../../snippets/csharp/CRMV8/query/cs/fetchaggregationandgroupby.cs#fetchaggregationandgroupby)]  
  
### See also  
 [Sample: CrmServiceHelper Class](helper-code-serverconnection-class.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>   
 [Using FetchXML Aggregration](use-fetchxml-aggregation.md)   
 [Build Queries with FetchXML](build-queries-fetchxml.md)   
 [Sample: Use FetchXML with a Paging Cookie](sample-use-fetchxml-paging-cookie.md)   
 <xref:Microsoft.Xrm.Sdk.Query.FetchExpression>