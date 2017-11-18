---
title: "Sample: Convert queries between Fetch and QueryExpression (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to convert queries between FetchXML and Query Expression"
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
  - "sample for converting queries between fetch and query expressions"
  - "converting queries between fetch and query expressions sample"
  - "FetchXML queries, samples"
  - "building queries with FetchXML, samples"
ms.assetid: fa08b0e7-11e1-4ac5-b809-91660a4fb147
caps.latest.revision: 15
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Sample: Convert queries between Fetch and QueryExpression

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code   is for [!INCLUDE[pn_crm_2016_and_online_full](../../includes/pn-crm-2016-and-online-full.md)]. Download the complete sample from [Sample: Work with Queries](https://code.msdn.microsoft.com/Sample-Work-with-Queries-8265a78e). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to convert queries between FetchXML and  Query Expression.  
  
## Example  
 [!code-csharp[Query#FetchXmlAndQueryExpressionQueryConversion](../../snippets/csharp/CRMV8/query/cs/fetchxmlandqueryexpressionqueryconversion.cs#fetchxmlandqueryexpressionqueryconversion)]  
  
### See also  
 [Sample: CrmServiceHelper Class](helper-code-serverconnection-class.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>   
 [Build Queries with FetchXML](build-queries-fetchxml.md)   
 [Sample: Validate and Execute a Saved Query](sample-validate-execute-saved-query.md)   
 [Build Queries with QueryExpression](build-queries-with-queryexpression.md)   
 <xref:Microsoft.Xrm.Sdk.Query.FetchExpression>
