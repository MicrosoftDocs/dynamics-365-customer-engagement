---
title: Configure an SMS channel using Azure Communication Services
description: Learn how to configure an SMS channel in Dynamics 365 Contact Center using Azure Communication Services.
ms.date: 08/01/2025
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template
---

# Configure an SMS channel using Azure Communication Services

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

This article discusses how you can configure the SMS channel in Dynamics 365 Contact Center using Azure Communication Services.

## Prerequisites

- Purchase and install the voice channel for Dynamics 365 Customer Service. Learn more in [Provision channels](/dynamics365/contact-center/implement/provision-channels) and [Install voice channel](voice-channel-install.md)

- Connect to Azure Communication Services. Learn more in [Connect to Azure Communication Services](voice-channel-acs-resource.md)
  
  If you connected your existing Azure Communication Services resource, make sure that you enabled SMS services. Learn more in [Enable call recording and SMS services](voice-channel-configure-services.md).

- Set up a phone number and enable it for SMS services. Ensure that you select **Send SMS** or **Send and receive SMS** options when you choose your phone number feature in Copilot Service admin center. Learn more in [Acquire new phone numbers](voice-channel-manage-phone-numbers.md#acquire-new-phone-numbers).

  If you're using an existing phone number that isn't enabled for SMS, then you can upgrade your plan. Learn more in [Edit phone numbers](voice-channel-manage-phone-numbers.md#edit-phone-numbers).

## Configure Azure Communication Services-based mobile numbers, short code for SMS

With Azure Communication Services-based short code and mobile numbers for SMS, your customer service representatives (service representatives or representatives) can do the following tasks:

- **Mobile numbers**: Send and receive SMS messages using standard mobile numbers.
- **Short code**: Send high-volume, time-sensitive messages using preapproved short codes to make sure of reliable delivery.

The provisioning and management of the mobile numbers and short codes is simplified for your organization as it can be handled within the Azure ecosystem. Organizations easily acquire, configure, and oversee SMS capabilities directly through Azure. The integration with Azure Communication Services supports seamless deployment into contact center environments, enabling efficient two-way customer communication at scale.

### Set up a mobile number

Follow the steps in [Quickstart: Get and manage phone numbers using Azure Communication Services](/azure/communication-services/quickstarts/telephony/get-phone-number) to apply for a mobile number in Azure Communication Services.

### Set up a short code

Follow the steps in [Apply for a short code](/azure/communication-services/quickstarts/sms/apply-for-short-code) to apply for the SMS short code in Azure Communication Services.

### Assign the short code, mobile number in contact center

After you acquire a short code or mobile number, perform the following steps:

1. In the site map of Copilot Service admin center, select **Channels** under **Customer support**, select **Manage** for **Phone numbers**.

1. On the page that appears, select **Advanced**.
1. On the **Manage Azure Communication Services** dialog, select **Sync** for **Sync from Azure**. After the sync is complete, the SMS short code or the SMS mobile number that you acquired in Azure Communication Services appears in the phone numbers list.

## Configure a workstream for the SMS channel

1. Go to the **Workstreams** page, and open the workstream that you created.

1. In the **Set up your SMS channel** section, select **Set up SMS**, and then configure the following options.
   1. On the **SMS setup** page, select a number from the list.
   1. On the **Language** page, select the language that you want to set as the default.
   1. On the **Behaviors** page, configure the following options:
     - **Channel operation hours:** Set the toggle to **On**, and then select an operating hour record. Learn more in [Configure operating hours](create-operating-hours.md)
     - [Configure custom automated messages](configure-automated-message.md).
     - [Configure post-conversation survey](configure-post-conversation-survey.md).
          > [!NOTE]
          > File attachments aren't supported in the SMS channel using Azure Communication Services.
   
   1. Verify the settings on the **Summary** page, and then select **Finish**. The SMS channel is now configured.
1. [Configure routing rules](configure-work-classification.md).
1. [Configure work distribution](create-workstreams.md#configure-work-distribution).
1. [Add an agent](create-workstreams.md#add-an-agent-to-a-workstream).
1. In **Advanced settings**, configure the following options based on your business needs.
   - [Sessions](session-templates.md)
   - [Representative notifications](notification-templates.md#out-of-the-box-notification-templates)
   - [Context variables](manage-context-variables.md#add-context-variables)
   - [Smart assist bots](../develop/smart-assist-bot.md)
   - [Quick replies](create-quick-replies.md)

### Number types and region/country supported in contact center

The following table lists the Azure Communication Services-based number types and region/country supported in Dynamics 365 Contact Center.

| Supported destination | Toll-free   | Short code | Mobile number  |
|-----------------------|-------------|------------|----------------|
| United States         | Yes         | Yes        | No             |
| Canada                | Yes         | Yes        | No             |
| Puerto Rico           | Yes         | No         | No             |
| United Kingdom        | No          | Yes        | Yes            |
| Australia             | No          | No         | Yes            |
| Ireland               | No          | No         | Yes            |
| Finland               | No          | No         | Yes            |
| Denmark               | No          | No         | Yes            |
| Netherlands           | No          | No         | Yes            |
| Sweden                | No          | No         | Yes            |
| Poland                | No          | No         | Yes            |
| Belgium               | No          | No         | Yes            |
| Latvia                | No          | No         | Yes            |

## Next steps

[Create message templates](create-message-templates.md)  

### Related information

[Overview of channels](../use/channels.md)  
[Overview of SMS channels](sms-channel-overview.md)  
[Understand and create workstreams](create-workstreams.md)  
[Configure SMS channel for Twilio](Configure-sms-channel-twilio.md)  
[Delete a configured channel](delete-channel.md)  
[SMS FAQ](faqs.md#sms)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
