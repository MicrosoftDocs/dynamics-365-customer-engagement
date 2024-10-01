---
title: Configure an SMS channel for Telesign
description: Get instructions for configuring an SMS channel for Telesign.
ms.date: 07/11/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
ms.collection:
---

# Configure an SMS channel for Telesign

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

> [!Important]
> The Telesign channel will be deprecated and removed from Omnichannel for Customer Service on October 8, 2024. After this date, you won't be able to use this channel, and this article will be removed. Learn more at [Deprecations in Customer Service](../implement/deprecations-customer-service.md).

An SMS channel allows your organization to connect to customers by using text messages. After you configure an SMS channel, your customers can send text messages and connect with a customer service agent. This channel provides your customers with the flexibility to connect on their mobile devices when an internet connection isn't available to connect to a chat channel.

Agents can view incoming SMS requests on their dashboard and respond accordingly.

The tasks to add SMS support for Telesign are as follows:

1. Enable SMS channel in the Customer Service admin center or Contact Center admin center application.

2. Register with Telesign and get your customer ID and API key, and purchase a phone number.

3. Add SMS support.

> [!NOTE]
>
> - The maximum number of characters supported for sent and received messages is 1600.
> - To ensure that third-party SMS providers handle opt-out commands properly, you must configure your consent settings with the provider directly.
> - SMS is an asynchronous mode of communication. Agents can close the conversation and then work on them later. Ending the conversation will mark it as resolved. More information: [Understand conversation states](../use/oc-conversation-state.md)

## Prerequisite

Verify that you have permissions on the secure columns. More information: [Configure permissions to access secure columns.](../implement/add-users-assign-roles.md#configure-permissions-to-access-secure-columns)

## Enable SMS channel in your Dynamics 365 organization

You can enable the SMS channel from the Dynamics 365 admin center. For steps on enabling SMS in your organization, go to [provision channels](/dynamics365/contact-center/implement/provision-channels).


## Sign up for Telesign account

You can integrate an SMS channel in Customer Service with Telesign. This integration uses public APIs of Telesign to send and receive text messages. You must sign up for a TeleSign account to enable an SMS channel in your organization.

1. Go to [Telesign](https://go.microsoft.com/fwlink/p/?linkid=2127719) to sign up for a self-service account, and upgrade to standard or enterprise account for a complete integration. If you expect to send high volumes of SMS traffic, such as more than 100,000 messages per month, contact [Telesign support](mailto:support@telesign.com) to request an invoiced enterprise account.

2. Purchase support phone numbers through your Telesign account.

3. Get the customer ID and API key from your Telesign account. You need to provide the ID and key while setting up the SMS channel in  the admin app.

4. You receive a callback URL that must be sent to [Telesign support](mailto:support@telesign.com). This callback URL is specific to your organization and is available when you add SMS support for your organization. When you send an email to TeleSign support, include the callback URL, your customer ID, and enter the subject line as **Omnichannel for Customer Service callback URL update request**.

## Add SMS support

1. In the site map of Customer Service admin center or Contact Center admin center, in **Customer support**, select **Channels**.
    
1. In **Accounts**, for **Messaging accounts**, select **Manage**.
   
1. On the **Accounts and channels** page, select **New account**.

1. Enter the following details:

   1. In **Channel details**, enter a name, and select SMS in **Channel**.

   1. In **Account details**, select Telesign in **Provider**, and enter the following details:
      - **Customer ID:** Customer ID generated from the TeleSign account.
      - **API key:** API key generated from the TeleSign account.

   1. In **SMS phone numbers**, select **Add**, and enter the following details in **Add SMS number**:
    - **Number:** Specify the support phone number that you purchased from Telesign in the *<phone_number>* format, such as 14252306549. Make sure that you don't enter blank spaces, special characters, or the plus sign (+).
    - **Type:** Select Geo, Short code, or Toll free.
    - **Description:** Enter a description.
    - **Validate:** Select to validate the customer ID and API key.
   
   1. In **Callback URL**, copy the value and send it to Telesign at [support@telesign.com](mailto:support@telesign.com) with your customer ID; enter the subject line as "Omnichannel for Customer Service callback URL update request".

1. Open the workstream that you created for the SMS channel for Telesign.

1. Select **Add SMS Channel**, and configure the following options:
   
   1. On the **SMS number** page, select a number from the list.
   
   1. On the **Language** page, select the language that you want to set as the default.
   
   1. On the **Behaviors** page, configure the following options:
     - **Channel operation hours:** Set the toggle to **On**, and then select an operating hour record. More information: [Configure operating hours](create-operating-hours.md).
     - [Custom automated messages](configure-automated-message.md)
     - [Post-conversation survey](configure-post-conversation-survey.md)
   
   1. In **User features**, set the toggle for **File attachments** to **On** and select the following options if you want both agents and customers to exchange files. More information: [Enable file attachments](enable-file-attachments.md).
     - Customers can send file attachments
     - Agents can send file attachments
   
   1. Verify the settings on the **Summary** page, and select **Finish**. The SMS for Telesign channel is configured.

1. Configure routing rules. More information: [Configure work classification](configure-work-classification.md).

1. Configure work distribution. More information: [Work distribution settings](create-workstreams.md#configure-work-distribution)

1. Add a bot. More information: [Configure a bot](create-workstreams.md#add-a-bot-to-a-workstream).

1. In **Advanced settings**, configure the following options based on your business needs:
   - [Sessions](session-templates.md)
   - [Agent notifications](notification-templates.md#out-of-the-box-notification-templates)
   - [Context variables](manage-context-variables.md#add-context-variables))
   - [Smart assist bots](../develop/smart-assist-bot.md)
   - [Quick replies](create-quick-replies.md)

## Flow of data between the SMS channel and Telesign

### Incoming text messages

For an incoming text message sent by a customer to the support phone number, the system first sends the message to the Telesign service. Telesign then pushes the message to Customer Service using the callback URL. After this action, the message gets routed and associated to either a new or an existing conversation by the application.

### Outgoing text messages

For an outgoing message sent by an agent, the message is first sent to the Telesign service and then Telesign sends it to the customer. In addition to the text message, the application uses the APIs provided by Telesign to send the customer's phone number, support phone number (Telesign SenderID), and the TeleSign account information (CustomerID and the API Key) to the Telesign service.

### TeleSign API Key Validation

When you validate the API key while setting up the SMS channel, a call is made to Telesign to validate customer ID and the API key.

### Related information

[Overview of channels](../use/channels.md)  
[Overview of SMS channels](../use/sms-channel-overview.md)  
[Configure SMS channel using Azure Communication Services](configure-sms-channel-acs.md)  
[Configure SMS channel for Twilio](Configure-sms-channel-twilio.md)  
[Create and manage workstreams](create-workstreams.md)  
[Configure automated messages](configure-automated-message.md)  
[Delete a configured channel](delete-channel.md)  
[SMS FAQ](faqs.md#sms)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
