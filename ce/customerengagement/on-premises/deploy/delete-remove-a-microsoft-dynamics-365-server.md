---
title: "Delete (remove) a Microsoft Dynamics 365 Server | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.prod: crm-2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: de32c74a-906b-444d-92f1-028d73637eab
caps.latest.revision: 13
author: Mattp123
ms.author: matp
manager: kvivek
---
# Delete (remove) a Microsoft Dynamics 365 Server



To delete a [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] from a deployment, use the **Servers** area. However, before you can delete a server, you must disable it.  
  
> [!CAUTION]
>  After you delete a server, users might no longer be able to access or use the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] application, or use certain features, such as reporting. To restore a deleted server, you must run [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] Setup and reinstall the server roles that were removed when the server was deleted.  
  
> [!TIP]
>  The procedure described here can be implemented by using a [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] cmdlet. For more information, see the [Disable-CrmServer](/powershell/module/microsoft.crm.powershell/disable-crmserver?view=dynamics365ce-ps) and [Remove-CrmServer](/powershell/module/microsoft.crm.powershell/remove-crmserver?view=dynamics365ce-ps) commands.  
  
### Delete a server  
  
1.  In the [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] console tree, select **Servers**.  
  
2.  In the details pane, right-click the server that you want to delete, and then select **Disable**.  
  
3.  Select **Yes**.  
  
4.  After the server is disabled, in the details pane, right-click the server that you want to delete, and then select **Delete**.  
  
5.  Select **Yes**.  
  
## See also  
 [Manage servers](manage-servers.md)   
 [Disable or enable a server](disable-or-enable-a-server.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]