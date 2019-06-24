---
title: "Remove Omnichannel | MicrosoftDocs"
description: "Learn how to remove Omnichannel application and disable all channels on an organization."
keywords: "remove, deprovision, Omnichannel, disable, channels"
ms.date: 07/01/2019
ms.service:
  - "dynamics-365-customerservice"
ms.custom:
  - ""
ms.topic: article
applies_to:
  - ""
ms.assetid: 36c885b1-e696-43f3-a198-de167268f91a
author: kabala123
ms.author: kabala
manager: shujoshi
---

# Remove Omnichannel application

You can remove Omnichannel application and disable all channels on a Customer Engagement organization.


> [!NOTE]
> Removing Omnichannel application will not delete Omnichannel solutions. To delete Omnichannel solutions, see [Delete Omnichannel solutions](delete-solution.md).  

To remove Omnichannel application from the organization,

1.	In the Dynamics 365 administration center, select the omnichannel application, and select **Manage**.
 
    ![Select Manage for the Omnichannel app](../media/manage-omnichannel-application.png "Select Manage for the Omnichannel app")

    The **Manage Instances of Omnichannel** page is displayed.

2.	On the **Manage Instances of Omnichannel** page, choose the instance and select **Remove Omnichannel**. 

    ![Remove button on the Manage Omnichannel instances page](../media/choose-remove-manage-instances.png "Remove button on the Manage Omnichannel instances page")
 
3.	In the confirmation dialog box, select **Remove** to proceed. 

    ![Remove confirmation dialog box](../media/removal-confirmation-dialog-box.png "Remove confirmation dialog box")
    
> [!IMPORTANT]
> Removing Omnichannel application will disable all channels on the selected organization. 

After Omnichannel is removed, you can enable it again from the **Manage Instances** view.

### See also
[Provision Omnichannel for Customer Service](omnichannel-provision-license.md)  
[Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)  
[Delete Omnichannel solutions](delete-solution.md)
