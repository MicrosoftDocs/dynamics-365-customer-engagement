---
title: "Authenticate users in Dynamics 365 Customer Engagement (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Learn about the various security models for authentication that Dynamics 365 Customer Engagement supports"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a9cbe79f-6f3b-44a7-aac4-f6f982bee2e5
caps.latest.revision: 55
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Authenticate users in Dynamics 365 Customer Engagement

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement supports three security models for authentication: claims-based authentication, [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] authentication, and OAuth 2.0. The type of authentication used depends on the type of deployment your application is accessing (Online, on-premises, or internet facing deployment) and if your application is using the Web API or the Organization Service.  
  
 In addition to using the correct security model, applications must establish a communication channel with the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] web services on the target deployment. The SDK run-time assemblies use [Windows Communication Foundation](https://msdn.microsoft.com/netframework/aa663324.aspx) ([!INCLUDE[pn_WCF_short](../includes/pn-wcf-short.md)]) technology to establish this communication channel.  
  
 The SDK assemblies simplify use of [!INCLUDE[pn_WCF_short](../includes/pn-wcf-short.md)] technology and claims-based authentication by providing helper proxy classes that make it easy to write applications that connect to and authenticate with the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] web services. By using these helper classes in your application, you can access any [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] deployment using the same code and you don’t have to become an expert in claims-based security or [!INCLUDE[pn_WCF_short](../includes/pn-wcf-short.md)] programming.  
  
## In This Section  
 [Use OAuth to connect to Dynamics 365 web Services](connect-customer-engagement-web-services-using-oauth.md)  
  
 [Use OAuth with Cross-Origin Resource Sharing  to connect a Single Page Application  to Dynamics 365 (online)](oauth-cross-origin-resource-sharing-connect-single-page-application.md)  
  
 [Active Directory and Claims-Based Authentication](active-directory-claims-based-authentication.md)  
  
## Related Sections  
 [Connect to Dynamics 365](connect-customer-engagement.md)  
  
 [OAuth 2.0](http://oauth.net/2/)  
  
 [Authorization Code Grant Flow](https://msdn.microsoft.com/en-us/library/azure/dn645542.aspx)  
  
 [Use the Dynamics 365 Web API](use-microsoft-dynamics-365-web-api.md)  
  
 [Use the Dynamics 365 Organization service](use-microsoft-dynamics-365-organization-service.md)
