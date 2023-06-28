---
title: "Add a new Deployment Administrator | Microsoft Docs"
description: Find out how to add a deployment administrator using Deployment Manager
ms.custom: 
ms.date: 01/30/2023
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 88335e4a-14d3-4431-82b8-b13ce7f4694b
caps.latest.revision: 12
author: Mattp123
ms.author: matp
---
# Add a new Deployment Administrator

You can grant or remove the [!INCLUDE[pn_Deployment_Administrator](../includes/pn-deployment-administrator.md)] role in the **Deployment Administrators** node in [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)].  
  
> [!TIP]
>  You can implement the procedure described here by using a [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] cmdlet. For more information, see [Using Windows PowerShell to perform Deployment Manager tasks](powershell-deployment-manager-tasks.md).  

### Add a Deployment Administrator
  
1. In the console tree, right-click **Deployment Administrators**, and then select **New [!INCLUDE[pn_Deployment_Administrator](../includes/pn-deployment-administrator.md)]**.  
  
1. In the **Select User** dialog box, in the **Enter object name to select** box, type the name of a user, who must exist in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)], and then select **Check Names**.  
  
1. After the user name is accepted, select **OK**.
1. [Add the deployment administrator to the PrivUserGroup Active Directory security group](#add-the-deployment-administrator-to-the-privusergroup-active-directory-security-group)

#### Permissions required deployment administration tasks

In addition to Deployment Administrators role membership, additional permissions are required to perform deployment administration tasks:

- Be a member of the Administrators group on all computers that are running the Dynamics 365 Deployment Administration or Deployment Tools server roles.
- Have **Program Files** folder read and write permission on the local computer where Deployment Manager is running.  
- Be a member of the Administrators group on the local computer where the instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] is located that will be used to store the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] databases.  
- Have sysadmin membership on the instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] that will be used to store the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] databases.  
- Have [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] organizational unit and security group creation and add membership permission to the organizational and security groups used by Dynamics 365 Server.

#### Add the deployment administrator to the PrivUserGroup Active Directory security group

1. Open the Active Directory Users and Computers snap-in on a computer that's in the same domain where Dynamics Server is deployed.
1. Select the **Users** folder from the right navigation pane.
1. Right-click the user name that you added as a deployment administrator in the earlier step, and then select **Add to group**.
1. In the **Select Groups** dialog box, type *privusergroup* in the **Enter the object names to select** text box, make sure the active directory name is **PrivUserGroup_OUname**, where *OUname* is the name of the Active Directory organizational unit where the security groups that are used by Dynamics 365 Customer Engagement are located, and then select **Check Names**.
   
    The name is resolved in the **Select Groups** dialog box. 

1. Select **OK**, and then close Active Directory Users and Computers.

## See also  
 [Deployment Administrators](deployment-administrators.md)   
 [Remove a Deployment Administrator](remove-a-deployment-administrator.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
