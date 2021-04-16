---
title: "Delete an organization | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.prod: crm-2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: e610c004-0b85-4662-a903-6d4b1ba16d44
caps.latest.revision: 13
author: Mattp123
ms.author: matp
manager: kvivek
---
# Delete an organization



Before you can delete an organization, you must disable it. [Disable or enable an organization](disable-or-enable-an-organization.md) 
  
> [!NOTE]
> When you delete an organization, the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] database is not deleted. Therefore, you can import the organization later.  

<!-- >  The ability to have multiple organizations in a single deployment of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] isn’t available in all [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] editions.  -->

  
> [!TIP]
>  You can implement the procedure described here by using a [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] cmdlet. For more information, see the [Disable-CrmOrganization](/powershell/module/microsoft.crm.powershell/disable-crmorganization?view=dynamics365ce-ps) and [Remove-CrmOrganization](/powershell/module/microsoft.crm.powershell/remove-crmorganization?view=dynamics365ce-ps) commands.  
  
### Delete an organization  
  
1.  In the [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] console tree, select **Organizations**.  
  
2.  In the middle pane, right-click the organization that you want to delete, and then select **Disable**.  
  
3.  Select **Yes**.  
  
4.  Right-click the organization again, and then select **Delete**.  
  
5.  Select **Yes**.  
  
## See also  
 [Manage organizations](manage-organizations.md)   
 [Disable or enable an organization](disable-or-enable-an-organization.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]