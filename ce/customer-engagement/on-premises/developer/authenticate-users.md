---
title: "Authenticate users in Dynamics 365 Customer Engagement (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "Learn about the various security models for authentication that Dynamics 365 Customer Engagement (on-premises) support"
ms.custom: 
ms.date: 03/29/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: a9cbe79f-6f3b-44a7-aac4-f6f982bee2e5
caps.latest.revision: 55
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Authenticate users in Dynamics 365 Customer Engagement (on-premises)

Dynamics 365 Customer Engagement (on-premises) support three security models for authentication: claims-based authentication, [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] authentication, and OAuth 2.0. The type of authentication used depends on the type of deployment your application is accessing (Online, on-premises, or internet facing deployment) and if your application is using the Web API or the Organization Service.  
  
 In addition to using the correct security model, applications must establish a communication channel with the Dynamics 365 Customer Engagement (on-premises) web services on the target deployment. The SDK run-time assemblies use [Windows Communication Foundation](https://msdn.microsoft.com/netframework/aa663324.aspx) ([!INCLUDE[pn_WCF_short](../includes/pn-wcf-short.md)]) technology to establish this communication channel.  
  
 The SDK assemblies simplify use of [!INCLUDE[pn_WCF_short](../includes/pn-wcf-short.md)] technology and claims-based authentication by providing helper proxy classes that make it easy to write applications that connect to and authenticate with the Dynamics 365 Customer Engagement (on-premises) web services. By using these helper classes in your application, you can access any Dynamics 365 Customer Engagement (on-premises) deployment using the same code and you don’t have to become an expert in claims-based security or [!INCLUDE[pn_WCF_short](../includes/pn-wcf-short.md)] programming.  
  
## Related Sections  
 [Active Directory and Claims-Based Authentication](active-directory-claims-based-authentication.md)  
  
 [Use the Dynamics 365 Customer Engagement Web API](use-microsoft-dynamics-365-web-api.md)  
  
 [Use the Dynamics 365 Customer Engagement Organization Service](use-microsoft-dynamics-365-organization-service.md)
