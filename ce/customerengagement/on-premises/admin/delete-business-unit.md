---
title: "Delete a business unit | MicrosoftDocs"
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
author: jimholtz
ms.assetid: d36a3897-24c4-434e-b255-4e1a1233ba41
caps.latest.revision: 15
ms.author: jimholtz
search.audienceType: 
  - admin
---
# Delete a business unit

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

You can delete a business unit to completely remove it from Dynamics 365 Customer Engagement (on-premises).  
  
> [!IMPORTANT]
>  Before deleting a business unit, be sure to consider the following:  
>   
> -   Deleting a business unit is irreversible.  
> -   The records owned by the business unit (for example: Teams, Facilities/Equipment, and Resource Groups) are deleted at the same time you delete the business unit.  
> -   You can’t delete a business unit until you delete any associated users, teams, and child business units.  

1. [!INCLUDE[proc_settings_security](../includes/proc-settings-security.md)]  
  
2. Choose **Business Units**.  
  
3. Click to select the business unit that you want to delete.  
  
4. On the Actions toolbar, choose **More Actions** > **Disable**.  
  
> [!IMPORTANT]
> When you disable a business unit, all users and teams associated with the business unit will not be able to sign in. You will need to reparent users and teams to another business unit and reassign security roles.

5. In the **Confirm Deactivation** dialog box, choose **Deactivate**.  
  
6. Change the view to **Inactive Business Units**.

7. Select the business unit to delete, and then choose the **Delete** icon ![Delete button](../admin/media/delete.gif "Delete button").  
  
8. In the **Confirm Deletion** dialog box, choose **Delete**.  
  
> [!TIP]
> If you get an error, be sure to reparent users and teams to another business unit.

### See also  
 [Assign a business unit a different parent business](../admin/assign-business-unit-different-parent.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]