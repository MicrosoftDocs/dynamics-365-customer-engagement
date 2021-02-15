---
title: "Remove Omnichannel for Customer Service| MicrosoftDocs"
description: "Learn how to remove Omnichannel for Customer Service and disable all channels on an organization."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 09/01/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Remove Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

You can remove Omnichannel for Customer Service and disable all channels for a Dynamics 365 Customer Service organization.

> [!NOTE]
> Omnichannel for Customer Service will be automatically removed if you do any of the following:
>
> - Delete the Dynamics 365 CRM instance from the Dynamics 365 admin center.
> - Reset the Dynamics 365 CRM instance from the Dynamics 365 admin center.
> - Modify or change the Dynamics 365 CRM instance to a different organization ID.
>
> Removing Omnichannel for Customer Service will not delete Omnichannel solutions. To delete Omnichannel solutions, see [Delete Omnichannel solutions](delete-solution.md).  

To remove the Omnichannel for Customer Service from the organization,

1. In **Power Platform Admin Center**, on the **Environments** page, select the environment in which Omnichannel for Customer Service needs to be removed.

    > [!div class=mx-imgBorder]
    > ![Manage omnichannel](media/OC-provisioning-ppadmin.png)

2. In the left pane, expand **Resources**, and select **Dynamics 365 Apps**.
3. On the **Dynamics 365 apps** page, select **More commands** beside **Omnichannel for Customer Service**, and then select **Manage**.
4. On the **Manage *<environment_name>*** page, select **Delete**.

    ![Remove button on the Manage Omnichannel instances page](media/choose-remove-manage-instances.png "Remove button on the Manage Omnichannel instances page")

5. In the confirmation dialog box, select **Remove** to proceed.

    > [!div class=mx-imgBorder]
    > ![Remove confirmation dialog box](media/removal-confirmation-dialog-box.png "Remove confirmation dialog box")

> [!IMPORTANT]
> Removing Omnichannel for Customer Service will disable all channels in the selected organization.

After Omnichannel is removed, you can enable it again from the **Manage environments** view.

### See also

[Provision Omnichannel for Customer Service](omnichannel-provision-license.md)  
[Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)  
[Delete Omnichannel solutions](delete-solution.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]