---
title: "Discovery Service methods (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "The IDiscoveryService Web service provides a single method which can be used to determine the correct organization and URL to use to interact with the Dynamics 365 Server"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 8ad9ac57-55f6-4951-9266-672b60ef4aed
caps.latest.revision: 17
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Discovery Service methods

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

The <xref:Microsoft.Xrm.Sdk.Discovery.IDiscoveryService> Web service provides a single method you can use to determine the correct organization and URL to use to interact with the [!INCLUDE[pn_microsoftcrm_server](../../includes/pn-microsoftcrm-server.md)].  
  
 To access the `IDiscoveryService` Web service, you add a reference to Microsoft.Xrm.Sdk.dll assembly to your [!INCLUDE[pn_Visual_Studio](../../includes/pn-visual-studio.md)] project, and then add a `using` or `imports` statement for the Microsoft.Xrm.Sdk.Discovery namespace.  
  
## Execute  
 Use the <xref:Microsoft.Xrm.Sdk.Discovery.IDiscoveryService.Execute(Microsoft.Xrm.Sdk.Discovery.DiscoveryRequest)> method to execute a discovery service message. For a list of the messages you can use with this method, see [Microsoft.Xrm.Sdk.Discovery Messages](messages-discovery-service.md).  
  
### See also  
 [Discover the URL for Your Organization With IDiscoveryService Web Service](discover-url-organization-organization-service.md)   
 [Discovery Service Messages (Request and Response Classes)](discovery-service-messages-request-response-classes.md)   
 [Access the Web Services in Dynamics 365](../authenticate-users.md)
