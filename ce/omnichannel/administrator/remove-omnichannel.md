---
title: "Remove Omnichannel for Customer Service| MicrosoftDocs"
description: "Learn how to remove Omnichannel for Customer Service and disable all channels on an organization."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 03/17/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Remove Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

You can remove Omnichannel for Customer Service and disable all channels on a Dynamics 365 Customer Service organization.


> [!NOTE]
> Omnichannel for Customer Service will be automatically removed if you do any of the following:
> - Delete the Dynamics 365 CRM instance from the Dynamics 365 admin center.
> - Reset the Dynamics 365 CRM instance from the Dynamics 365 admin center.
> - Modify or change the Dynamics 365 CRM instance to a different organization ID.
> 
> Removing Omnichannel for Customer Service will not delete Omnichannel solutions. To delete Omnichannel solutions, see [Delete Omnichannel solutions](delete-solution.md).  

To remove the Omnichannel for Customer Service from the organization,

1.	In Dynamics 365 Administration Center, select Omnichannel for Customer Service, and select **Manage**.
 
    > [!div class=mx-imgBorder]
    > ![Select Manage for Omnichannel for Customer Service](../media/manage-omnichannel-application.png "Select Manage for Omnichannel for Customer Service")

    The **Manage** page is displayed.

2.	On the **Manage** page, choose the instance, and select **Delete**. 

    ![Remove button on the Manage Omnichannel instances page](../media/choose-remove-manage-instances.png "Remove button on the Manage Omnichannel instances page")
 
3.	In the confirmation dialog box, select **Remove** to proceed. 

    > [!div class=mx-imgBorder]
    > ![Remove confirmation dialog box](../media/removal-confirmation-dialog-box.png "Remove confirmation dialog box")
    
> [!IMPORTANT]
> Removing Omnichannel for Customer Service will disable all channels in the selected organization. 

After Omnichannel is removed, you can enable it again from the **Manage environments** view.

### See also
[Provision Omnichannel for Customer Service](omnichannel-provision-license.md)  
[Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)  
[Delete Omnichannel solutions](delete-solution.md)
