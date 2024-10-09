---
title: Try channels
description: Learn how you can try channels in Customer Service to connect and engage with your customers in real time.
ms.date: 10/09/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer:
ms.collection:
ms.custom: bap-template
---

# Try channels 

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Channels, like Live Chat, voice, and SMS, are engagement channels that let your agents connect with customers in real time and provide quick personalized help.

You can perform the following steps to try channels in Customer Service:

1. Sign up for a free 30-day trial of channels through Microsoft 365 admin center.

1. [Provision channels](#provision-channels-in-your-organization).


## Channels trial through Microsoft 365 admin center

The Dynamics 365 Customer Service Digital Messaging Add-on Trial is a free 30-day trial of Chat, SMS, and social channels that you can download from the Microsoft 365 admin center.

### Prerequisites for trial through Microsoft 365 admin center

You must obtain one of the following subscriptions through the Microsoft 365 admin center (that is, Web Direct):

- Paid or trial subscription of Dynamics 365 Customer Service Enterprise
- Paid or trial subscription of Dynamics 365 Customer Engagement
- For voice channel, subscription of Dynamics 365 Customer Engagement Applications Trial
- For voice channel, make sure that trial is supported in the [cloud location](../administer/voice-channel-region-availability.md)

> [!IMPORTANT]
> If you don't have one of these subscriptions, or if you purchased your subscription somewhere other than Web Direct, then the option to try channels isn't be available in the Microsoft 365 admin center. In such cases, we recommend that you use the [Customer Service trial](https://dynamics.microsoft.com/customer-service/overview/).

For information about the Digital Messaging license, pricing, and prerequisites, see the [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?LinkId=866544).

### Get a trial subscription of channels

1. Sign in to [Microsoft 365 admin center](https://admin.microsoft.com) with the global administrator credentials.

2. Go to **Billing** > **Purchase Services**, scroll down, and select **Add-ons**.

3. Select **Dynamics 365 Customer Service Digital Messaging add-on Trial**.

4. You can start a 30-day trial of Digital Messaging with 25 user licenses.

5. After signing up for a trial, you must assign licenses of Digital Messaging to the users who need to engage with customers and provide support via Omnichannel for Customer Service. Select one or more active users and edit their product licenses. After you're done, select **Save**.

    > [!div class=mx-imgBorder]
    > ![Digital Messaging product licenses dialog box.](../media/digital-trial-assign-users.png "Digital Messaging product licenses dialog box")

### Get a trial subscription of voice channel

1. In Microsoft 365 admin center, expand **Billing**, and select **Purchase services**.

1. Search for **Dynamics 365 Customer Engagement Applications Trial**, and select it.

1. Select the **Add-ons** tab, and then select one of the following add-ons to get the trial subscription of the voice channel:

   - Dynamics 365 Customer Service Voice Channel Add-in Trial
   - Dynamics 365 Customer Service Digital Messaging and Voice Add-in Trial

1. Select **Details**, and on the page that appears, select **Start free trial** to complete your purchase.

1. Go to the **Active users** page, and assign the trial license to the user who will provision the voice trial. Only then can the user see the voice trial for provisioning it.

1. Provision the channel in your environment by following the steps mentioned in the next section of this article.

## Provision channels in your organization

Perform the tasks in [Provision channels](/dynamics365/contact-center/implement/provision-channels#set-up-channels) to enable Chat, SMS, social, and voice channels in your organization.


To configure the following channels, perform the steps provided in:

- [Configure the chat channel](../administer/set-up-chat-widget.md)
- [Configure the SMS channel](../administer/configure-sms-channel-acs.md)
- [Configure the Facebook channel](../administer/configure-facebook-channel.md)
- [Configure the voice channel](../administer/voice-channel-inbound-calling.md)

### Get a Power BI (free) subscription

If you already have a subscription of Dynamics 365 Customer Service Enterprise or a subscription of Power BI in your tenant, you can skip this step. Otherwise, you must get a Power BI (free) subscription.

1. Sign in to [Microsoft 365 admin center](https://admin.microsoft.com) with the global administrator credentials.

2. Go to **Billing** > **Purchase services**.

3. Search for Power BI (free) and complete the purchase of Power BI (free) subscription.

    > [!div class=mx-imgBorder]
    > ![Power BI (free) subscription.](../media/powerbi-free.png "Power BI (free) subscription")

### Videos

To view videos on Omnichannel for Customer Service, see [Videos](../use/videos.md).

### Related information

[Provision channels](/dynamics365/contact-center/implement/provision-channels#set-up-channels)  
[Configure a chat channel](../administer/set-up-chat-widget.md)  
[Configure an SMS channel](../administer/configure-sms-channel-acs.md)  
[Configure a Facebook channel](../administer/configure-facebook-channel.md)  
[Try Customer Service](try-customer-service.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
