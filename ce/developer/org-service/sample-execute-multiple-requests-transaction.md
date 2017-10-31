---
title: "Sample: Execute multiple requests in transaction (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to execute multiple organization message requests in a single database transaction by using a single web service method call, passing ExecuteTransactionRequest as a parameter"
keywords: ""
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 1ba7b824-6cbf-41f8-87a3-901d42ab5aa1
author: JimDaly
ms.author: jdaly
manager: sakudes
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 8
topic-status: Drafting
---

# Sample: Execute multiple requests in transaction

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement supports batching of requests into a single web service method call. Each request in the batch is executed as part of a single database transaction. Failure of any request to complete successfully causes a rollback of any completed requests and no further processing is performed on requests not yet executed.

[Download the work with execute transaction](https://code.msdn.microsoft.com/Work-with-execute-4388dac6).
  
 This code sample applies to [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)].  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to execute multiple organization message requests in a single database transaction by using a single web service method call, passing <xref:Microsoft.Xrm.Sdk.Messages.ExecuteTransactionRequest> as a parameter. A snippet showing just the key sections of the sample is shown first, followed by the [complete sample code](sample-execute-multiple-requests.md#complete_sample).  
  
## Example  
 This sample uses a single web method call to execute all message requests in a collection as part of a single database transaction. Settings to alter the execution behavior are also shown.  
  
 [!code-csharp[ExecuteTransaction#ExecuteTransaction1](../../snippets/csharp/CRMV8/executetransaction/cs/executetransaction1.cs#executetransaction1)]  
  
<a name="complete_sample"></a>   
## Complete sample code  
 [!code-csharp[ExecuteTransaction#ExecuteTransaction](../../snippets/csharp/CRMV8/executetransaction/cs/executetransaction.cs#executetransaction)]  
  
### See also  
 [Execute messages in a single database transaction](use-messages-request-response-classes-execute-method.md#bkmk_transaction)   
 [Use the IOrganizationService Web Service to Read and Write Data or Metadata](use-organization-service-read-write-data-metadata.md)
