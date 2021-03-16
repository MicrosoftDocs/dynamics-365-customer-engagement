---
title: "Discover the URL for your organization using the Discovery Service (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "For a multi-tenant environment like Dynamics 365 Customer Engagement, you can use Discovery Service to determine the organizations that a user is member of"
ms.custom: on-premise
ms.date: 11/14/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 29b0777c-f28d-4301-ae5c-a25064bfbcc9
caps.latest.revision: 46
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---

# Discover the URL for your organization using the Discovery Service 

Use the discovery service to determine the organizations that a user is a member of, and the endpoint address URL to access the organization service for each of those organizations. This discovery service is necessary because [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] is a multi-tenant environment—a single [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] server can host multiple business organizations. By using the discovery service, your application can determine the endpoint address URL to access the target organization’s business data.  
  
 For [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] installations, server and organization allocation may change as part of datacenter management and load balancing. Therefore, the discovery service provides a way to discover which [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] server is serving your organization at a given time.  
  
 For an Internet-facing deployment (IFD) installation, the Web service URL has the following form:  
```  
https://dev.<hostname[:port]>/XRMServices/2011/Discovery.svc  
```  

 For an on-premises installation, the web service URL has the following form:  
```  
http[s]://<hostname[:port]>/XRMServices/2011/Discovery.svc  
```  

 Consult the **Developer Resources** page in the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Web application for the correct URL of your installation.  
  
 To use the discovery service, add a reference to the `Microsoft.Xrm.Sdk.dll` assembly to your [!INCLUDE[pn_Visual_Studio](../../includes/pn-visual-studio.md)] project, and then add a `using` or `imports` statement to access the <xref:Microsoft.Xrm.Sdk.Discovery> namespace. The <xref:Microsoft.Xrm.Sdk.Discovery.IDiscoveryService> interface provides <xref:Microsoft.Xrm.Sdk.Discovery.IDiscoveryService.Execute*> method you will use to pass a instance of the <xref:Microsoft.Xrm.Sdk.Discovery.DiscoveryRequest> class.
 
Alternatively, you can add the service references for the URLs described previously to your project.
  
## Related Sections  
 [Use the Discovery Service with the SDK Assemblies](/powerapps/developer/common-data-service/org-service/discovery-service)  
 [Write Applications and Server Extensions](../extend-dynamics-365-server.md)<br />
 [Download endpoints using Developer resources page](../developer-resources-page.md)<br />
 [Access the Web Services in Dynamics 365 Customer Engagement](../authenticate-users.md)<br />
 [Quick Start: A Simple Program](../simple-program-web-services.md)<br />


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]