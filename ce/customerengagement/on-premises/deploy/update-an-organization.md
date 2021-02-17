---
title: "Update an organization | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.prod: crm-2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 6089d370-2675-4fae-a800-f01ec9927747
caps.latest.revision: 13
author: Mattp123
ms.author: matp
manager: kvivek
---
# Update an organization



When you update the organizations in your deployment, disabled organizations can’t be updated until they are enabled. In the list of organizations in the details pane for the disabled organization, the **Update** column will show that an update is **Available**.  
  
> [!IMPORTANT]
>  Before you import, upgrade, or update a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organization, you should back up the configuration and organization databases.  
  
> [!TIP]
>  You can implement the procedure described here by using a [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] cmdlet. For more information, see the [Enable-CrmOrganization](/powershell/module/microsoft.crm.powershell/enable-crmorganization?view=dynamics365ce-ps) and [Update-CrmOrganization](/powershell/module/microsoft.crm.powershell/update-crmorganization?view=dynamics365ce-ps) commands.  
  
### Update a disabled organization  
  
1.  To enable the organization, in the details pane, right-click the disabled organization, and then select **Enable**.  
  
2.  To update the organization, in the details pane, right-click the organization, and then select **Update**.  
  
## Update management  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] updates include security, performance, and functional improvements. Making sure that your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] applications have the latest updates helps make sure that your system is running as efficiently and reliably as it can.  
  
 For information about how to manage updates, see the following:  
  
-   [Windows Server Update Services](https://go.microsoft.com/fwlink/p/?LinkID=200474)  
  
-   [Introduction to Software Updates in Configuration Manager](https://technet.microsoft.com/library/gg682168.aspx)  
  
## See also  
 [Manage organizations](manage-organizations.md)   
 [Import an organization](import-an-organization.md)   
 [Upgrade an organization](upgrade-an-organization.md)   
 [Troubleshoot organization import and upgrade issues](troubleshoot-organization-import-and-upgrade-issues.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]