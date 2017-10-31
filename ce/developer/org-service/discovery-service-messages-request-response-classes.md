---
title: "Discovery service messages (request and response classes) (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "The IDiscoveryService provides a DiscoveryRequest method that takes message request class as a parameter and returns a message response class. DiscoveryRequest method performs supported operations"
description: ""
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
helpviewer_keywords: 
  - "IDiscoveryService web service, request and response classes"
  - "IDiscoveryService web service, base classes: DiscoveryRequest and DiscoveryResponse"
  - "request and response classes, discovery service messages"
  - "discovery service messages (request and response classes)"
ms.assetid: 053f259e-40c9-46ba-8c47-39e29e228590
caps.latest.revision: 8
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Discovery service messages (request and response classes)

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

The <xref:Microsoft.Xrm.Sdk.Discovery.IDiscoveryService> provides an [DiscoveryRequest)](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.discovery.idiscoveryservice.execute\(microsoft.xrm.sdk.discovery.discoveryrequest\)) method to perform supported operations. This method takes a message request class as a parameter and returns a message response class. Request message class names end with "Request" and response message class names end with "Response”.  
  
 ![Execute message flow](../media/crm-v5s-executemessage.png)  
  
 <xref:Microsoft.Xrm.Sdk.Discovery.DiscoveryRequest> is the base class for all discovery message requests and <xref:Microsoft.Xrm.Sdk.Discovery.DiscoveryResponse> is the base class for all discovery message responses. Typically, you use one of the derived request and response class pairs in your application, for example: <xref:Microsoft.Xrm.Sdk.Discovery.RetrieveOrganizationRequest> and  <xref:Microsoft.Xrm.Sdk.Discovery.RetrieveOrganizationResponse>.  
  
 For a list of the messages supported by the `Execute` method, see [Messages in the Discovery Service](messages-discovery-service.md).  
  
### See also  
 [Discover the URL for Your Organization With IDiscoveryService Web Service](discover-url-organization-organization-service.md)   
 [Messages in the Discovery Service](messages-discovery-service.md)   
 [Sample: Accessing the Discovery Service](sample-access-discovery-service.md)
