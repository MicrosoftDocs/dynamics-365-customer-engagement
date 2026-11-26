---
title: Configure payment profiles
description: Learn how to configure payment profiles for Apple Messages for Business in Dynamics 365 Customer Service.
ms.date: 08/31/2026
ms.topic: how-to
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
---

# Configure payment profiles

[!INCLUDE[pva-rebrand](../../includes/cc-pva-rebrand.md)]

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

Create payment profiles to enable conversational commerce for supported channels. After you configure a payment profile, your customer service representatives can help customers complete secure transactions without leaving the messaging experience.

After you create a payment profile, add it to a channel instance in the workstream's channel setup. Apple Messages for Business supports conversational commerce.

> [!NOTE]
> The Apple Messages for Business channel is deprecated and will be removed from Copilot Service admin center on September 30, 2026. Review [Deprecations in Dynamics 365 Customer Service](../implement/deprecations-customer-service.md#apple-messages-for-business-channel-is-deprecated).

## Create an Apple Messages for Business payment profile for Apple Pay

### Prerequisites

Verify that you have permissions on the secure columns. Learn more in [Configure permissions to access secure columns](../implement/add-users-assign-roles.md#configure-permissions-to-access-secure-columns).

Before you add an Apple Pay payment profile, complete the Apple Pay integration requirements in [Apple Business Register](https://register.apple.com/).

### Create an Apple Pay payment profile

1. In the site map of the Copilot Service admin center app, select **Customer settings**, and then select **Manage** for **Payment profiles**. A list of existing records appears.

1. Select **Add** at the top of the page.

1. On the **Create new Payment profile** page, provide the following information:<br>

   - On the **Channel type** page, enter a name and select Apple Messages for Business as the channel type. Apple Messages for Business is the only supported channel type.<br>

1. On the **Details** page, provide the following information:<br>

   - **Merchant friendly name**: The customer-facing name of your business. This name appears in the Apple Pay request and shouldn't be localized.<br>

   - **Merchant ID**: The unique identifier assigned to your business when you register as an Apple Pay merchant.<br>

   - **Merchant certificate**: The certificate associated with your merchant ID. Apple Pay servers use the certificate's public key to encrypt payment data.<br>

   - **Certificate password**: The private key used to generate secure Apple Pay sessions.<br>

   - **Payment gateway URL**: The endpoint where payment and requested contact information are sent for processing.<br>

   - **Merchant domain URL**: The website domain associated with your Apple Pay merchant account.<br>

   - **Merchant two-letter country code**: The ISO 3166-1 alpha-2 code for the country or region where payments are processed.<br>

1. On the **Payment options** page, provide the following information:<br>

   - **Merchant capabilities**: The payment types you can accept. 3D Secure is required for channel support.<br>

   - **Supported Networks**: The networks that support transactions between your Apple Pay merchant account and card issuers.<br>

1. On the **Rich message** page, select **Add**, and then select one or more Apple Pay rich messages to associate with the payment profile.<br>

   An Apple Pay rich message can be associated with more than one payment profile. However, each channel instance can use only one payment profile.<br>

1. Review the **Summary** page, and then select **Finish**. The payment profile is configured.

### Add a payment profile to an Apple Messages for Business channel

1. Open the workstream that contains the channel instance where you want to enable Apple Pay.

1. On **User features**, go to **Apple Pay**, turn on the capability, and select the payment profile. Learn more in [Configure an Apple Messages for Business channel instance](configure-apple-messages-for-business-channel.md).

1. Save your changes.

1. To review or update the Apple Pay settings for a channel instance, select **Edit**.

### Limitations

| Description | Limitation |
|---|---|
| **Country code**: The two-letter ISO 3166-1 alpha-2 code that identifies where payments are processed. | China isn't currently supported because payments must use a separate payment endpoint. |
| **Merchant capabilities**: Capabilities for processing payments. | - China UnionPay isn't supported.<br><br>- You can build an adaptive card by adding a skill through Copilot Studio. Learn more in [Use Microsoft Bot Framework Skills in Copilot Studio](/microsoft-copilot-studio/advanced-use-skills).<br><br>- Adaptive card styling isn't supported. |
| **Supported networks**: The payment methods that customers can use to fund the payment. | - Supported networks are limited to American Express, Visa, Discover, and Mastercard.<br><br>- Some locally issued cards might not work even when the **Merchant two-letter country code** is correct. This limitation might affect Saudi Arabia and China. |

### Related information

[Configure Apple Messages for Business](configure-apple-messages-for-business-channel.md)  
[Understand and create workstreams](../work-streams-introduction.md)  
[Configure automated messages](configure-automated-message.md)  
[Configure a post-conversation survey](configure-post-conversation-survey.md)  
[Skill-based routing](overview-skill-work-distribution.md)  
[Create message templates](create-message-templates.md)  
[Templates](/dynamics365/app-profile-manager/templates-overview)  
[Delete a configured channel](delete-channel.md)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
