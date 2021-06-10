---
title: "Upgrade an organization | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.prod: crm-2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 74fefb8c-2c70-4f61-85ad-83ede2d4158a
caps.latest.revision: 15
author: Mattp123
ms.author: matp
manager: kvivek
---
# Upgrade an organization



You can upgrade organizations from earlier versions of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] on-premises by using [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] to import them into the new deployment.  
  
> [!TIP]
>  You can implement the procedure described here by using a [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] cmdlet. For more information, see the [Import-CrmOrganization](/powershell/module/microsoft.crm.powershell/import-crmorganization?view=dynamics365ce-ps) and [Update-CrmOrganization](/powershell/module/microsoft.crm.powershell/update-crmorganization?view=dynamics365ce-ps) commands.  
  
## Upgrade an organization by importing it  
 During the import process, the Import Organization Wizard detects the version and upgrades the organization automatically.  
  
> [!IMPORTANT]
>  Before you import, upgrade, or update a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organization, you should back up the configuration and organization databases.  
>   
>  Only December 2016 update for Dynamics 365 Customer Engagement (on-premises) (8.2) or later organizations are supported for importing with this version of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. <!-- To upgrade earlier versions, see [Upgrade from Dynamics 365 Server 2013 or Dynamics Server 2011](upgrade-dynamics-crm-server-2013-or-2011.md). --> 
  
## Upgrade an organization in-place  
 After you upgrade [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)], if the deployment contains additional organizations from the earlier version of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], those organizations become disabled and aren’t upgraded. You can upgrade those organizations by using the steps described here.  
  
### Use Deployment Manager to upgrade organizations  
  
1.  On the [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] home page, in the console tree, select **Organizations**.  
  
2.  In the details pane for each organization, review the **Version** column.  
  
3.  For each organization where the **Version** is earlier than the latest version installed, right-click the organization, and then select **Upgrade Organization**.  
  
## See also  
 [Manage organizations](manage-organizations.md)   
 [Import an organization](import-an-organization.md)   
 [Update an organization](update-an-organization.md)   
 [Troubleshoot organization import and upgrade issues](troubleshoot-organization-import-and-upgrade-issues.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]