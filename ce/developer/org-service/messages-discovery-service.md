---
title: "Messages in the discovery service (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This article discusses the messages that are used with the discovery service DiscoveryRequest) method. Some supported messages are RetrieveUserIdByExternalIdRequest, RetrieveOrganizationRequest and RetrieveOrganizationsRequest."
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
  - "discovery service web service, messages in"
  - "messages in the discovery service, about"
  - "discovery service web service, supported messages for the Execute method"
  - "discovery service web service, deployment types"
ms.assetid: d6ecf6b2-6d20-4d7f-8577-ef5d42637a1a
caps.latest.revision: 32
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Messages in the discovery service

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Messages are used with the discovery service <xref:Microsoft.Xrm.Sdk.Discovery.IDiscoveryService.Execute(Microsoft.Xrm.Sdk.Discovery.DiscoveryRequest)> method. All messages available in the discovery web service for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement apply to all deployment types.  
  
 The following table lists the messages that are supported with <xref:Microsoft.Xrm.Sdk.Discovery.IDiscoveryService.Execute(Microsoft.Xrm.Sdk.Discovery.DiscoveryRequest)> method. Each message derives from the abstract base class <xref:Microsoft.Xrm.Sdk.Discovery.DiscoveryRequest>.  
  
|Message|Description|  
|-------------|-----------------|  
|<xref:Microsoft.Xrm.Sdk.Discovery.RetrieveUserIdByExternalIdRequest>|Retrieves the logged-on user's ID in [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)]. This message is available in [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] only.|  
|<xref:Microsoft.Xrm.Sdk.Discovery.RetrieveOrganizationRequest>|Retrieves information about a single organization.|  
|<xref:Microsoft.Xrm.Sdk.Discovery.RetrieveOrganizationsRequest>|Retrieves information about all organizations to which the user belongs.|  
  
### See also  
 [Discover the URL for Your Organization With IDiscoveryService Web Service](discover-url-organization-organization-service.md)   
 [Sample: Access the Discovery Service](sample-access-discovery-service.md)   
 [Use Messages (Request and Response Classes)](discovery-service-messages-request-response-classes.md)
