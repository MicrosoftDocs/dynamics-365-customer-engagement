---
title: "Use ExecuteMultiple to improve performance for bulk data load (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "ExecuteMultipleRequest message supports higher throughput bulk message passing scenarios in Dynamics 365 Customer Engagement (on-premises), particularly in the case where Internet latency can be the largest limiting factor"
ms.custom: on-premise
ms.reviewer: pehecke

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 8029be0f-0dd6-44d2-b458-94fb40095ec3
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer

---
# How to use ExecuteMultiple to improve performance for bulk data load

You can use the <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> message to support higher throughput bulk message passing scenarios in [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] , particularly in the case where Internet latency can be the largest limiting factor. <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> accepts an input collection of message <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest.Requests>, executes each of the message requests in the order they appear in the input collection, and optionally returns a collection of <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleResponse.Responses> containing each message's response or the error that occurred. Each message request in the input collection is processed in a separate database transaction. <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> is executed by using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*> method.  
  
In general, <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> behaves the same as if you executed each message request in the input request collection separately, except with better performance. Use of the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy.CallerId> parameter of the service proxy is honored and will apply to the execution of every message in the input request collection. Plug-ins and workflow activities are executed as you would expect for each message processed.  

Custom code in the form of plug-ins and custom workflow activities may execute <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest>. However, there are a few key points to keep in mind. An exception thrown by a synchronous registered plug-in is returned in the response collection item <xref:Microsoft.Xrm.Sdk.ExecuteMultipleResponseItem.Fault> parameter. If a plug-in executes within a database transaction, the plug-in executes <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest>, and a transaction rollback is initiated, the rollback includes any data changes resulting from requests executed by <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest>.

For the latest information about ExecuteMultiple, see [Execute multiple requests using the Organization service](/powerapps/developer/data-platform/org-service/execute-multiple-requests). For recommendations and guidance, see [Don't use batch request types in plug-ins and workflow activities](/power-apps/developer/data-platform/best-practices/business-logic/avoid-batch-requests-plugin).
  
<a name="limitations"></a>

## Apply limits for concurrent requests

There are several constraints related to the use of the <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest>. One limit that applies only to an on-premises deployment is described below and the other two (no recursion, and maximum batch size) are documented in (Dataverse) [Run-time limitations](/powerapps/developer/common-data-service/org-service/execute-multiple-requests#run-time-limitations).

Throttling of concurrent calls – for Dynamics 365 for Customer Engagement it's possible to set a limit on the number of concurrent <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> executions per organization. This helps prevent one app from monopolizing the server resources. If that limit is exceeded, a "Server Busy" fault is thrown before the first request is ever executed. This isn't enabled by default. The deployment setting for this limit is <xref:Microsoft.Xrm.Sdk.Deployment.ThrottleSettings.ExecuteMultiplePerOrgMaxConnectionsPerServer>.
  
  > [!TIP]
  >  For any [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] deployment, a deployment administrator can set or change the throttling limit.  
  
### See also  
 [Read and Write Data and Metadata using the IOrganizationService Web Service](use-organization-service-read-write-data-metadata.md)   
 [Microsoft.Xrm.Sdk Messages](/dotnet/api/microsoft.xrm.sdk.messages)   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*>   
 <xref:Microsoft.Xrm.Sdk.OrganizationRequest>   
 <xref:Microsoft.Xrm.Sdk.OrganizationResponse>   
 [Microsoft.Crm.Sdk Messages](/dotnet/api/microsoft.crm.sdk.messages)   
 [Import data](../import-data.md)
 

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
