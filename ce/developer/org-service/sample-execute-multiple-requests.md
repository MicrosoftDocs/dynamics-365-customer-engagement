---
title: "Sample: Execute multiple requests (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample uses a single web method call to execute multiple message requests"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 39f237ea-8805-4a45-925e-2663ff635611
caps.latest.revision: 18
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Sample: Execute multiple requests

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Sending a large number of individual organization message requests over a network, as you would do in a bulk data import operation, is affected by network performance. For improved performance, [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement supports batching of requests into a single web service method call.  
  
 This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. Download the complete sample here [Sample: Execute multiple requests](https://code.msdn.microsoft.com/Sample-Execute-multiple-ec698fa3). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to execute multiple organization message requests by using a single web service method call, passing <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> as a parameter. Reducing the number of message requests that must be transmitted over the network results in increased message processing performance. A snippet showing just the key sections of the sample is shown first, followed by the [Complete Sample Code](sample-execute-multiple-requests.md#complete_sample).  
  
## Example  
 This sample uses a single web method call to execute all message requests in a collection. Settings to alter the execution behavior are also shown.  
  
 [!code-csharp[ExecuteMultiple#ExecuteMultiple1](../../snippets/csharp/CRMV8/executemultiple/cs/executemultiple1.cs#executemultiple1)]  
  
<a name="complete_sample"></a>   
## Complete sample code  
 [!code-csharp[ExecuteMultiple#ExecuteMultiple](../../snippets/csharp/CRMV8/executemultiple/cs/executemultiple.cs#executemultiple)]  
  
### See also  
 [Use the IOrganizationService Web Service to Read and Write Data or Metadata](../org-service/use-organization-service-read-write-data-metadata.md)   
 <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest>   
 <xref:Microsoft.Xrm.Sdk.ExecuteMultipleSettings>   
 [Use Execute Multiple to Improve Performance for Bulk Data Load](use-executemultiple-improve-performance-bulk-data-load.md)
