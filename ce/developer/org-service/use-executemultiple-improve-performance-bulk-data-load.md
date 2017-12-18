---
title: "Use ExecuteMultiple to improve performance for bulk data load (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "ExecuteMultipleRequest message supports higher throughput bulk message passing scenarios in Dynamics 365 (online) Customer Engagement, particularly in the case of Dynamics 365 (online) where Internet latency can be the largest limiting factor"
ms.custom: ""
ms.date: 12/15/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 8029be0f-0dd6-44d2-b458-94fb40095ec3
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Use ExecuteMultiple to improve performance for bulk data load

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

You can use the <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> message to support higher throughput bulk message passing scenarios in [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement, particularly in the case of [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] where Internet latency can be the largest limiting factor. <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> accepts an input collection of message <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest.Requests>, executes each of the message requests in the order they appear in the input collection, and optionally returns a collection of <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleResponse.Responses> containing each message’s response or the error that occurred. Each message request in the input collection is processed in a separate database transaction. <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> is executed by using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*> method.  
  
 In general, <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> behaves the same as if you executed each message request in the input request collection separately, except with better performance. Use of the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy.CallerId> parameter of the service proxy is honored and will apply to the execution of every message in the input request collection. Plug-ins and workflow activities are executed as you would expect for each message processed.  
  
 Custom code in the form of plug-ins and custom workflow activities can even execute <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest>. However, there are a few key points to keep in mind. An exception thrown by a synchronous registered plug-in is returned in the response collection item <xref:Microsoft.Xrm.Sdk.ExecuteMultipleResponseItem.Fault> parameter. If a plug-in executes within a database transaction, the plug-in executes <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest>, and a transaction rollback is initiated, the rollback includes any data changes resulting from requests executed by <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest>.  
  
<a name="example"></a>   
## Example  
 The following sample code demonstrates a single <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> that performs multiple create operations. Run-time execution options called *Settings* are used to control the request processing and returned results. These run-time options are discussed in the next section.  
  
 [!code-csharp[ExecuteMultiple#ExecuteMultiple1](../../snippets/csharp/CRMV8/executemultiple/cs/executemultiple1.cs#executemultiple1)]  
  
 [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Sample: Execute Multiple Requests](sample-execute-multiple-requests.md).  
  
<a name="options"></a>   
## Specify run-time execution options  
 The <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest.Settings> parameter of <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> applies to all of the requests in the request collection controlling execution behavior and results returned. Let’s take a look at these options in more detail.  
  
|ExecuteMultipleSettings Member|Description|  
|------------------------------------|-----------------|  
|<xref:Microsoft.Xrm.Sdk.ExecuteMultipleSettings.ContinueOnError>|When `true`, continue processing the next request in the collection even if a fault has been returned from processing the current request in the collection. When `false`, do not continue processing the next request.|  
|<xref:Microsoft.Xrm.Sdk.ExecuteMultipleSettings.ReturnResponses>|When `true`, return responses from each message request processed. When `false`, do not return responses.<br /><br /> If set to `true` and a request does not return a response, because that is its design, the <xref:Microsoft.Xrm.Sdk.ExecuteMultipleResponseItem> for that request is set to `null`.<br /><br /> However, even when `false`, the <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleResponse.Responses> collection will not be empty if errors are returned. If errors are returned, there will be one response item in the collection for each processed request that returned a fault and <xref:Microsoft.Xrm.Sdk.ExecuteMultipleResponseItem.Fault> will be set to the actual fault that occurred.|  
  
 For example, in a request collection that contains six requests where the third and fifth request return faults, the following table indicates what the <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleResponse.Responses> collection would contain.  
  
|Settings|Responses Collection Contents|  
|--------------|-----------------------------------|  
|ContinueOnError=true, ReturnResponses=true|6 response items: 2 have <xref:Microsoft.Xrm.Sdk.ExecuteMultipleResponseItem.Fault> set to a value.|  
|ContinueOnError=false, ReturnResponses=true|3 response items: 1 has <xref:Microsoft.Xrm.Sdk.ExecuteMultipleResponseItem.Fault> set to a value.|  
|ContinueOnError=true, ReturnResponses=false|2 response items: 2 have <xref:Microsoft.Xrm.Sdk.ExecuteMultipleResponseItem.Fault> set to a value.|  
|ContinueOnError=false, ReturnResponses=false|1 response item: 1 has <xref:Microsoft.Xrm.Sdk.ExecuteMultipleResponseItem.Fault> set to a value.|  
  
 An <xref:Microsoft.Xrm.Sdk.ExecuteMultipleResponseItem.RequestIndex> parameter in the response item indicates the sequence number, starting at zero, of the request that the response is associated with. In the previous example, the third request has a request index of 2.  
  
<a name="limitations"></a>   
## Run-time limitations  
 There are several constraints related to the use of the <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> as described in the following list.  
  
-   No recursion is allowed - <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> cannot invoke <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest>. An <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> found in the request collection will generate a fault for that request item.  
  
-   Maximum batch size – there is a limit to how many requests can be added to a request collection. If that limit is exceeded, a fault is thrown before the first request is ever executed. A limit of 1000 requests is typical though this maximum amount can be set for the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] deployment. The deployment setting for this limit is <xref:Microsoft.Xrm.Sdk.Deployment.ImportSettings.BatchSize>.  
  
-   Throttling of concurrent calls – for [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] there is a limit of 2 concurrent <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> executions per organization. If that limit is exceeded, a “Server Busy” fault is thrown before the first request is ever executed. For an on-premises deployment, throttling is not enabled by default. The deployment setting for this limit is <xref:Microsoft.Xrm.Sdk.Deployment.ThrottleSettings.ExecuteAsyncPerOrgMaxConnectionsPerServer>.  
  
    > [!TIP]
    >  For any [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] deployment, a deployment administrator can set or change the throttling limit.  
  
<a name="fault"></a>   
## Handle a batch size fault  
 What should you do when your input request collection exceeds the maximum batch size? Your code can’t directly query the maximum batch size through the deployment web service unless it is run under an account that has the deployment administrator role.  
  
 Fortunately, there is another method that you can use. When the number of requests in the input <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest.Requests> collection exceeds the maximum batch size allowed for an organization, a fault is returned from the <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> call. The maximum batch size is returned in the fault. Your code can check for that value, resize the input request collection to be within the indicated limit, and re-submit the <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest>. The following code snippet demonstrates some of this logic.  
  
 [!code-csharp[ExecuteMultiple#ExecuteMultiple2](../../snippets/csharp/CRMV8/executemultiple/cs/executemultiple2.cs#executemultiple2)]  

  
### See also  
 [Read and Write Data and Metadata using the IOrganizationService Web Service](use-organization-service-read-write-data-metadata.md)   
 [Microsoft.Xrm.Sdk Messages](xrm-messages-organization-service.md)   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*>   
 <xref:Microsoft.Xrm.Sdk.OrganizationRequest>   
 <xref:Microsoft.Xrm.Sdk.OrganizationResponse>   
 [Microsoft.Xrm.Sdk.Discovery Messages](messages-discovery-service.md)   
 [Microsoft.Crm.Sdk Messages](organization-service-messages.md)   
 [Import data](../import-data.md)
