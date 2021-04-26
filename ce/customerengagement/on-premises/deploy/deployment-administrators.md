---
title: "Deployment Administrators | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.prod: crm-2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 96c87bbc-9735-4cb9-8549-10a144461c25
caps.latest.revision: 6
author: Mattp123
ms.author: matp
manager: kvivek
---
# Deployment Administrators

To run [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)], you must have the [!INCLUDE[pn_Deployment_Administrator](../includes/pn-deployment-administrator.md)] role. Deployment Administrators have unrestricted access to perform [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] tasks on all organizations and servers in a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment.  
  
> [!IMPORTANT]
>  Make sure that at least two or three trusted people have the [!INCLUDE[pn_Deployment_Administrator](../includes/pn-deployment-administrator.md)] role. This prevents system lockout if the primary deployment administrator is unavailable.  
  
 During [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] Setup, the user running Setup is automatically given the [!INCLUDE[pn_Deployment_Administrator](../includes/pn-deployment-administrator.md)] role. A [!INCLUDE[pn_Deployment_Administrator](../includes/pn-deployment-administrator.md)] can give the [!INCLUDE[pn_Deployment_Administrator](../includes/pn-deployment-administrator.md)] role to other users in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] directory service.  
  
> [!NOTE]
>  Users who have the [!INCLUDE[pn_Deployment_Administrator](../includes/pn-deployment-administrator.md)] role do not automatically become [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] users and do not consume a client access license (CAL).  
>   
>  The [!INCLUDE[pn_Deployment_Administrator](../includes/pn-deployment-administrator.md)] role cannot be managed in the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] client applications.  

## Known issue where a deployment administrator has insufficient permission

After a user is added as a deployment administrator, the member of the Deployment Administrators group might receive a message similar to the following when executing a deployment administrative task, such as importing an organization database.

Failed to install CustomControlsCoreException: Microsoft.Crm.CrmException: The user Id(s) [00000000-0000-0000-0000-000000000000] is invalid.

When this error occurs the administrative task doesn't complete. This issue occurs because the user isn't a member of the PrivUserGroup security group. To resolve this issue, [Add the deployment administrator to the PrivUserGroup Active Directory security group](add-a-new-deployment-administrator.md#add-the-deployment-administrator-to-the-privusergroup-active-directory-security-group).

## See also  
 [Add a new Deployment Administrator](add-a-new-deployment-administrator.md)   
 [Remove a Deployment Administrator](remove-a-deployment-administrator.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]