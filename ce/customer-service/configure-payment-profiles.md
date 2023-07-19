---
title: "Configure payment profiles | MicrosoftDocs"
description: "This article provides steps to help you configure payment profiles in Omnichannel for Customer Service."
ms.date: 10/27/2022
ms.topic: article
author: lalexms
ms.author: laalexan
---

# Configure payment profiles

You can create payment profiles to enable conversational commerce for supported channels. Once configured, your agents can help customers complete secure transactions without having to leave the messaging experience.

After you create a payment profile record, you must add it to a channel instance within a workstream's channel setup to make it work. Conversational commerce is supported for Apple Messages for Business.

## Create an Apple Messages for Business payment profile for Apple Pay

### Prerequisites

Verify that you have permissions on the secure columns. More information: [Configure permissions to access secure columns](add-users-assign-roles.md#configure-permissions-to-access-secure-columns)

Before adding an Apple Pay payment profile, make sure to complete the Apple Pay integration steps documented by Apple. More information: [Apple Pay - Apple Messages for Business](https://register.apple.com/resources/messages/msp-api-tutorial/applepay#integrating-apple-pay)

### Create an Apple Pay payment profile

1. In the site map of Omnichannel admin center app, select **Customer settings**, and then select **Manage for Payment profiles**. A list of existing records is shown.

1. Select **Add** at the top of the page to create a new record.	

1. In the **Create new payment profile** pages, provide the following details:<br>

     - On the **Channel type** page, enter a name and select Apple Messages for Business as the channel type. By default, the only channel type currently supported is Apple Messages for Business.<br>

1. On the **Details** page, provide the following information:<br>

     - **Merchant friendly name**: Your business's customer-facing name. This will be the name your customer sees within the Apple Pay request. This name shouldn't be localized.<br>
     
     - **Merchant ID**: Your unique identifier assigned to your business when registering as a merchant for Apple Pay.<br>
     
     - **Merchant certificate**: A certificate associated with your merchant ID, used to secure transaction data. Apple Pay servers use the certificate’s public key to encrypt payment data.<br>
     
     - **Certificate password**: The private key used to generate secure Apple Pay sessions. <br>
     
     - **Payment gateway URL**: The endpoint where payment information and requested contact information and sent to be processed.<br>
     
     - **Merchant domain URL**: The website domain associated with your Apple Pay Merchant Account. <br>
     
     - **Merchant two-letter country code**: Country codes are formatted by their ISO 3166-1 alpha-2 code. Use the country code for where payments will be processed. <br>
     
1. On the **Payment options** page, provide the following information:<br>
    
     - **Merchant capabilities**: The payment types you can accept. 3D Secure is required for channel support.<br>
     
     - **Supported Networks**: The networks that support transactions between your Apple Pay merchant account and card issuers.<br>

1. On the **Rich messages** page, select **Add**, and then select one or more Apple Pay rich messages to associate with this authentication setting. <br>
An Apple Pay type rich message may be associated to more than one payment profile. This is because each channel instance may only support one payment profile. <br>

1. Review the **Summary** page, and then select **Finish**. The authentication setting is configured. 

### Add a payment profile to an Apple Messages for Business channel

1. Open the workstream containing the channel instance for which you want to enable Apple Pay.

1. On the **User features** page of the channel settings, navigate to **Apple Pay**, enable the capability, and select the correct setting from the dropdown. More information: Configure an Apple Messages for Business channel instance in Omnichannel admin center

1. Save your changes.

1. Review or update the Apple Pay settings for any channel instance by selecting **Edit**.

### Limitations

|Description | Limitation |
|-----------|---------------|
| **Country code**: This is the two-letter ISO 3166-1 alpha-2 code that denotes which country payments will be processed in. | China isn't currently a supported country, as payments must go through a separate payment endpoint. |
| **Merchant capabilities**: Capabilities for processing payments | - It isn't currently possible to enable support for China UnionPay. <br><br> - You can build an adaptive card by adding a skill through Power Virtual Agents. More information: [Use Microsoft Bot Framework Skills in Power Virtual Agents]() <br><br> - Adaptive card styling isn't supported. |
| **Supported networks**: This property constrains the payment methods that the user can select to fund the payment. | - Supported networks are currently limited to American Express, Visa, Discover, and Mastercard. <br> <br> - Some locally issued cards may not work even when the **Merchant two-letter country code** is correct. The following countries/regions may be impacted: Saudi Arabia and China. | 


### See also

[Configure Apple Messages for Business](configure-apple-messages-for-business-channel.md)  
[Understand and create workstreams](work-streams-introduction.md)  
[Create and manage routing rules](routing-rules.md)  
[Configure automated messages](configure-automated-message.md)  
[Configure a post-conversation survey](configure-post-conversation-survey.md)  
[Skill-based routing](overview-skill-work-distribution.md)  
[Create message templates](create-message-templates.md)  
[Templates](/dynamics365/app-profile-manager/templates-overview)  
[Delete a configured channel](delete-channel.md)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
