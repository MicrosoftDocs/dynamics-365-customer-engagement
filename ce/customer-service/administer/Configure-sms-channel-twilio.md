---
title: Configure an SMS channel for Twilio
description: Learn how to configure an SMS channel for Twilio.
ms.date: 03/03/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
ms.collection:
---

# Configure an SMS channel for Twilio

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

The SMS channel through Twilio allows your organization to connect to customers by using text messages. Your customers can send text messages through Twilio and connect with an appropriate customer service representative (service representative or representative). Service representatives can view incoming SMS requests on their dashboard and respond accordingly.

## Prerequisites

Make sure that the following prerequisites are met:

- SMS for Twilio is provisioned in the Customer Service admin center or Contact Center admin center application. Learn more in [Provision channels](/dynamics365/contact-center/implement/provision-channels#set-up-channels).
 
- A Twilio account with a phone number and subscription is available.
    > [!NOTE]
    > > For new Twilio accounts, you must disable a security setting that blocks media files. Learn more in [Extended notice and update on security changes: HTTP Authentication for Voice and Messaging Media enabled by default](https://go.microsoft.com/fwlink/p/?linkid=2248938).
- Permissions on the secure columns. Learn more in [Configure permissions to access secure columns](../implement/add-users-assign-roles.md#configure-permissions-to-access-secure-columns).

### Get Twilio account details

An SMS channel is enabled within the application that's integrated with Twilio. This integration uses public APIs of Twilio to send and receive text messages.

1. In your Twilio account, note the ACCOUNT SID and AUTH TOKEN values. These values are required to create the SMS configuration in the Customer Service admin center app.

2. Purchase support phone numbers through your Twilio account.

> [!NOTE]
>
> - US phone numbers only are supported.
> - To ensure that third-party SMS providers handle opt-out commands properly, you must configure your consent settings with the provider directly.  

## Set up the SMS channel for Twilio

To configure the SMS channel, complete the following tasks:
- Configure the SMS number
- Configure the workstream for the SMS channel

### Configure the SMS number

1. In the site map of Contact Center admin center or Customer Service admin center, go to **Customer support**, and then select **Channels**.
    
1. In **Accounts**, for **Messaging accounts**, select **Manage**.

1. On the **Accounts and channels** page, select **New account**.

1. Enter the following details:
   1. In **Channel details**, enter a name, and select SMS in **Channel**.
   1. In **Account details**, select **Twilio** in **Provider**, and then enter the following details:
      - **Account SID:** Enter the Twilio ACCOUNT SID.
      - **Auth token:** Enter the Twilio AUTH TOKEN.
   1. In **SMS phone numbers**, select **Add**, and enter the following details in **Add SMS number**:
      - **Number:** Specify the support phone number that you purchased from Twilio in the *<country_code><phone_number>* format, such as 14252306549. Make sure that you don't enter blank spaces or special characters.
      - **Type**: Select **Long code**, **Short code**, or **Toll free**.
      - **Description**: Specify a description for the number. (Optional)
   1. In **Callback information**, copy the callback information. The copied information is used for the Twilio account.
   1. Select **Done**. The account is configured.

### Configure the workstream for the SMS channel

To configure the workstream, make sure you perform the steps to create a workstream for the SMS channel. Learn more in [Create workstreams](create-workstreams.md).

1. Go to workstreams page and open the workstream you created for the channel.
2. In the **Set up your SMS channel** section, select **Set up SMS**, and then configure the following options:
   1. On the **SMS setup** page, select a number from the list.
   2. On the **Language** page, select the language that you want to set as the default.
   3. On the **Behaviors** page, configure the following options:
     - **Channel operation hours:** Set the toggle to **On**, and then select an operating hour record. Learn more in [Configure operating hours](create-operating-hours.md).
     - [Custom automated messages](configure-automated-message.md)
     - [Post-conversation survey](configure-post-conversation-survey.md)
   4. In **User features**, set the toggle for **File attachments** to **On** and select the following options if you want both representatives and customers to exchange files. Learn more in [Enable file attachments](enable-file-attachments.md).
     - Customers can send file attachments
     - Representatives can send file attachments
   5. Verify the settings on the **Summary** page, and then select **Finish**. The SMS for Twilio channel is configured.
3. Configure routing rules. Learn more in [Configure work classification](configure-work-classification.md).
4. Configure work distribution. Learn more in [Work distribution settings](create-workstreams.md#configure-work-distribution).
5. Add an AI agent. Learn more in [Configure an agent](create-workstreams.md#add-a-bot-to-a-workstream).
6. In **Advanced settings**, configure the following options based on your business needs:
   - [Sessions](session-templates.md)
   - [Agent notifications](notification-templates.md#out-of-the-box-notification-templates)
   - [Context variables](manage-context-variables.md#add-context-variables)
   - [Smart assist bots](../develop/smart-assist-bot.md)
   - [Quick replies](create-quick-replies.md)

## Establish a connection between omnichannel application and Twilio


Perform the following steps to configure the URL in Twilio for the SMS messages from the omnichannel application to be processed in Twilio:

1. Copy the value in **Twilio inbound URL** of the workstream for Twilio.

2. Go to your Twilio account > **Phone Numbers** > **Active Numbers**, and then select the SMS phone number.

3. In the **Messaging** section, paste the Twilio inbound URL.

## Flow of data between omnichannel application and Twilio

### Incoming text messages

For an incoming text message sent by a customer to the support phone number, the message is first sent to the Twilio messaging service. Then Twilio pushes it to omnichannel application by using the callback URL. The message is then routed and associated to either a new or an existing conversation by the application.

### Outgoing text messages

For an outgoing message sent by a representative from within the application, the message is first sent to the Twilio service and then Twilio sends it to the customer. In addition to the text message, the application uses the APIs provided by Twilio to send the customer's phone number, support phone number, and the Twilio account information (Account SID and the Auth Token) to the Twilio service.

### Twilio account and phone number validation

When you validate the SMS settings while setting up the SMS channel, a call is made to Twilio to validate the Account SID and Auth Token.


### Related information

[Overview of channels](../use/channels.md)  
[Overview of SMS channels](../use/sms-channel-overview.md)  
[Delete a configured channel](delete-channel.md)  
[Configure SMS channel using Azure Communication Services](configure-sms-channel-acs.md)	
[SMS FAQ](faqs.md#sms)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
