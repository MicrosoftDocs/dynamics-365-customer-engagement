---
title: Provision channels
description: Perform the steps in this article to provision channels so that can you start using the product.
ms.date: 06/14/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
ms.collection:
---

# Provision channels 

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[cc-trial-sign-up](../../includes/cc-trial-sign-up.md)]

Customer Service provides a modern, customizable, and high-productivity app that lets agents help customers across different channels via a unified interface. It lets organizations select the channel that meets their business needs. It also ensures that a high level of responsive, quality service is received across channels.

You can check if the omnichannel capability is available in your region. Learn more in [International availability](../implement/international-availability.md).

> [!NOTE]
> If you don't see the provisioning option in the admin center, it's not yet available in your region. You can [provision the channels](omnichannel-provision-license.md) in Power Platform admin center.


You can provision the following channels in Customer Service admin center or Contact Center admin center:

- [Chat](../administer/set-up-chat-widget.md)
- [Voice](../administer/voice-channel.md)
- [SMS](../administer/configure-sms-channel.md)
- [Social](../use/channels.md)
- [Microsoft Teams](../administer/configure-microsoft-teams.md)

> [!IMPORTANT]
> The channels that you want to provision might require a license. More information: [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?LinkId=866544).

## Prerequisites

- Obtain an active subscription of one or more of the following:

  - Chat for Dynamics 365 Customer Service or Digital Messaging for Dynamics 365 Customer Service
  - To provision the voice channel, Voice Channel for Dynamics 365 Customer Service
  
    > [!NOTE]
    > More information: [Pricing](https://dynamics.microsoft.com/customer-service/pricing/), Dynamics 365 Licensing Guide, and [How to purchase through Volume Licensing](https://www.microsoft.com/en-us/licensing/how-to-buy/how-to-buy). You can also get a free 30-day trial if you have the required prerequisites. More information: [Try channels for Dynamics 365 Customer Service](../use/channels.md).

- Set up the prerequisites mentioned in the system requirements. More information: [Prerequisites](../implement/system-requirements-omnichannel.md#prerequisites).

- Ensure that the provisioning user has the Dynamics 365 System Administrator role on the root business unit for your organization. More information: [Assign security roles to a user in Power Platform](/power-platform/admin/assign-security-roles) and [Create or edit business units](/power-platform/admin/create-edit-business-units)


## Set up channels<a name="set-up-omnichannel"> </a>

> [!NOTE]
> You can set up channels in the Customer Service admin center or Contact Center admin center application. In the Power Platform admin center application, you can only view existing environments and channels; you can't enable, edit, or delete channels.
  
To set up the channels, perform the following steps:

1. Select **Channels** in **Customer Support**. 
1. Select **Manage** for **Manage channels**. The Manage channels page appears. 
1. Select the channels that you want to use. 
    Depending on your licenses, you can view the channels that you can enable. If you don't have the required licenses, the checkboxes for the corresponding channels are disabled. Learn more about licenses at More information: [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?LinkId=866544).
1. Select **Save**.

The channel setup can take several minutes. The application provisions the channel in the background. You can close the window and check after some time, or refresh to see if it's complete. When the setup is complete, the enabled channels appear in your environment.

If the provisioning fails, an error message appears that indicates that the provisioning failed. Select the error message to view the details.

### Turn off channels

1. Select  **Customer Support** > **Channels** > **Manage channels**. 
1. Clear the checkbox for the channel you want to turn off. The application displays a message asking you to confirm the action. Select **Turn off** to confirm.

Once you turn off the channel, agents will no longer be able to access the channel.

### Related information

[Create workstreams](../administer/create-workstreams.md)  
[Manage users](../administer/users-user-profiles.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
