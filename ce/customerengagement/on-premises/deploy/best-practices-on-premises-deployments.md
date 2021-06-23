---
title: "Administration best practices for on-premises deployments of Dynamics 365 Customer Engagement (on-premises) | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 507567f3-2354-4ef3-a093-0f209ebf2b29
caps.latest.revision: 12
ms.author: matp
author: Mattp123
manager: kvivek
---
# Administration best practices for on-premises deployments of Dynamics 365 Customer Engagement (on-premises)



By following some simple rules of administration, you can significantly improve the security of your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] on-premises deployment.  
  
-   Typically, there is no need for [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] users to have administrative privileges over the domain. Therefore, all [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] user accounts should be restricted to Domain Users membership. Also, following the principle of least-privilege, anyone who uses the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] system should have minimal rights. This starts at the domain level. A domain user account should be created and used to run [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. Domain Administrator accounts should never be used to run [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].  
  
-   Limit the number of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)][!INCLUDE[pn_Deployment_Administrator](../includes/pn-deployment-administrator.md)] and System Administrator roles to a few people who are responsible for rule changes. Others who are [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], [!INCLUDE[pn_Exchange_Server_full](../includes/pn-exchange-server-full.md)], or [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] administrators do not have to be members of the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] users group.  
  
-   Make sure that at least two or three trusted people have the [!INCLUDE[pn_Deployment_Administrator](../includes/pn-deployment-administrator.md)] role. This avoids system lockout if the primary [!INCLUDE[pn_Deployment_Administrator](../includes/pn-deployment-administrator.md)] is unavailable.  
  
-   In some organizations it is a common practice to reuse passwords across systems and domains. For example, an administrator responsible for two domains may create Domain Administrator accounts in each domain that use the same password, and even set local administrator passwords on domain computers that are the same across the domain. In such a case, a compromise of a single account or computer could lead to a compromise of the entire domain. Passwords should never be reused in this manner.  
  
-   It is also common practice to use Domain Administrator accounts as service accounts for common services such as back-up systems. However, it is a security risk to use Domain Administrator accounts as service accounts. The password can easily be retrieved by anyone who has administrative rights over the computer. In such a case, the compromise could affect the entire domain. Service accounts should never be Domain Administrator accounts, and they should be limited in privilege as much as possible.  
  
-   A domain user account that is specified to run a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] service must not also be configured as a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] user. This can cause unexpected behavior in the application.  
  
## See Also  
 [Microsoft Dynamics 365 security model](../admin/security-concepts.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]