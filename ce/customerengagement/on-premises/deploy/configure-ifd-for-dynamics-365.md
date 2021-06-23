---
title: "Configure IFD for Dynamics 365 Customer Engagement (on-premises) | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: eee528fb-ef2f-4a77-ad0f-3d29bcb42351
caps.latest.revision: 10
ms.author: matp
author: Mattp123
manager: kvivek
---
# Configure IFD for Dynamics 365 Customer Engagement (on-premises)



[!INCLUDE[pn_crm_op_edition](../includes/pn-crm-op-edition.md)] uses claims-based authentication to authenticate internal users and to enable Internet access for external users not using VPN.  
  
 In claims-based authentication, an identity provider that contains a security token service (STS) responds to authentication requests and issues SAML security tokens that include any number of claims about a user, such as a user name and groups the user belongs to. A relying party application receives the SAML token and uses the claims inside to decide whether to grant the client access to the requested resource. Claims-based authentication can be used to authenticate your organization's internal users, external users, and users from partner organizations.  
  
 This content provides the steps needed to configure [!INCLUDE[pn_Internet_facing_deployment](../includes/pn-internet-facing-deployment.md)] using claims-based authentication.  
  
### See also
[Implement claims-based authentication: internal access](implement-claims-based-authentication-internal-access.md) <br />
[Implement claims-based authentication: external access](implement-claims-based-authentication-external-access.md)
 



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]