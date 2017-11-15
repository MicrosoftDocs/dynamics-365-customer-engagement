---
title: "Discover the URL for your organization using the Organization Service (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "For a multi-tenant environment like Dynamics 365, you can use IDiscoveryService Web service to determine the organizations that a user is member of"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 29b0777c-f28d-4301-ae5c-a25064bfbcc9
caps.latest.revision: 46
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---

# Discover the URL for your organization using the Organization Service

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

The <xref:Microsoft.Xrm.Sdk.Discovery.IDiscoveryService> Web service is used to determine the organizations that a user is a member of, and the endpoint address URL to access the <xref:Microsoft.Xrm.Sdk.IOrganizationService> Web service for each of those organizations. This discovery service is necessary because [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Customer Engagement is a multi-tenant environment—a single [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] server can host multiple business organizations. By using the discovery Web service, your application can determine the endpoint address URL to access the target organization’s business data.  
  
 For [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] installations, server and organization allocation may change as part of datacenter management and load balancing. Therefore, the <xref:Microsoft.Xrm.Sdk.Discovery.IDiscoveryService> Web service provides a way to discover which [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] server is serving your organization at a given time.  
  
 The following table lists the Web service URLs for the worldwide [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] data centers.  

[!INCLUDE [regional-discovery-services](../../includes/regional-discovery-services.md)]
  
 For an Internet-facing deployment (IFD) installation, the Web service URL has the following form:  
  
```  
https://dev.<hostname[:port]>/XRMServices/2011/Discovery.svc  
```  
  
 For an on-premises installation, the web service URL has the following form:  
  
[!INCLUDE[cc_sdk_onpremises_note](../../includes/cc-sdk-onpremises-note.md)]
```  
http[s]://<hostname[:port]>/XRMServices/2011/Discovery.svc  
```  
  
 Consult the **Developer Resources** page in the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Web application for the correct URL of your installation.  
  
 To use the `IDiscoveryService` Web service, add a reference to the `Microsoft.Xrm.Sdk.dll` assembly to your [!INCLUDE[pn_Visual_Studio](../../includes/pn-visual-studio.md)] project, and then add a `using` or `imports` statement to access the Microsoft.Xrm.Sdk.Discovery namespace. Alternatively, you can add the service references for the URLs described previously to your project.  
  
## In This Section  
 [Discovery Service Methods](discovery-service-methods.md)<br />
 [Discovery Service Messages (Request and Response Classes)](discovery-service-messages-request-response-classes.md)<br />
 [Messages in the Discovery Service](messages-discovery-service.md)<br />
 [Sample: Accessing the DiscoveryService](sample-access-discovery-service.md)<br />
  
## Related Sections  
 [Write Applications and Server Extensions](../extend-dynamics-365-server.md)<br />
 [Use Dynamics 365 Services](use-services-in-code.md)<br />
 [Download endpoints using Developer resources page](../developer-resources-page.md)<br />
 [Access the Web Services in Dynamics 365](../authenticate-users.md)<br />
 [Quick Start: A Simple Program](../simple-program-web-services.md)<br />
