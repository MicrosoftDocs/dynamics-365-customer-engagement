---
title: "Use ExecuteMultiple to improve performance for bulk data load (Developer Guide for Dynamics 365 Customer Engagement (on-premises) )| MicrosoftDocs"
description: "The ExecuteMultiple message supports higher throughput bulk message passing scenarios in Dynamics 365 Customer Engagement (on-premises), particularly in the case of Customer Engagement (on-premises) where Internet latency can be the largest limiting factor."
ms.custom: on-premise
ms.date: 09/05/2019
ms.reviewer: pehecke
ms.prod: dynamicscrm-2016 
ms.topic: article
ms.assetid: 8029be0f-0dd6-44d2-b458-94fb40095ec3
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer

---
# Use ExecuteMultiple to improve performance for bulk data load

You can use the <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> message to support higher throughput bulk message passing scenarios in Dynamics 365 Customer Engagement (on-premises). <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> accepts an input collection of message <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest.Requests>, executes each of the message requests in the order they appear in the input collection, and optionally returns a collection of <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleResponse.Responses> containing each message’s response or the error that occurred. Each message request in the input collection is processed in a separate database transaction. <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> is executed by using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*> method.  
  
In general, <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> behaves the same as if you executed each message request in the input request collection separately, except with better performance. Use of the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy.CallerId> parameter of the service proxy is honored and will apply to the execution of every message in the input request collection. Plug-ins and workflow activities are executed as you would expect for each message processed.  

Custom code in the form of plug-ins and custom workflow activities can even execute <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest>. However, there are a few key points to keep in mind. An exception thrown by a synchronous registered plug-in is returned in the response collection item <xref:Microsoft.Xrm.Sdk.ExecuteMultipleResponseItem.Fault> parameter. If a plug-in executes within a database transaction, the plug-in executes <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest>, and a transaction rollback is initiated, the rollback includes any data changes resulting from requests executed by <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest>.

For more detailed information about ExecuteMultiple, see the Dataverse topic [Execute multiple requests using the Organization service](/powerapps/developer/common-data-service/org-service/execute-multiple-requests).
  
<a name="limitations"></a>

## On-premise run-time limitations

There are several constraints related to the use of the <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> as described in the following list.  
  
- No recursion is allowed - <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> cannot invoke <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest>. An <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> found in the request collection will generate a fault for that request item.  
  
- Maximum batch size – there is a limit to how many requests can be added to a request collection. If that limit is exceeded, a fault is thrown before the first request is ever executed. A limit of 1000 requests is typical though this maximum amount can be set for the Dynamics 365 Customer Engagement (on-premises) deployment. The deployment setting for this limit is <xref:Microsoft.Xrm.Sdk.Deployment.ImportSettings.BatchSize>.  
  
- Throttling of concurrent calls – there is a limit of 2 concurrent <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> executions per organization. If that limit is exceeded, a “Server Busy” fault is thrown before the first request is ever executed. For an on-premises deployment, throttling is not enabled by default. The deployment setting for this limit is <xref:Microsoft.Xrm.Sdk.Deployment.ThrottleSettings.ExecuteMultiplePerOrgMaxConnectionsPerServer>.  
  
  > [!TIP]
  >  A deployment administrator can set or change the throttling limit.  
  
### See also  
 [Read and Write Data and Metadata using the IOrganizationService Web Service](use-organization-service-read-write-data-metadata.md)   
 <xref:Microsoft.Xrm.Sdk.Messages>   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*>   
 <xref:Microsoft.Xrm.Sdk.OrganizationRequest>   
 <xref:Microsoft.Xrm.Sdk.OrganizationResponse>   
 <xref:Microsoft.Crm.Sdk.Messages>   
 [Import data](import-data.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]