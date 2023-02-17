---
title: "Configure an SMS channel for TeleSign | MicrosoftDocs"
description: "Get instructions for configuring an SMS channel for TeleSign in Omnichannel for Customer Service."
ms.date: 02/17/2023
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Configure an SMS channel for TeleSign

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

An SMS channel allows your organization to connect to customers by using text messages. After you configure an SMS channel, your customers can send text messages and connect with a customer service agent. This provides your customers the flexibility to connect with their mobile devices when an internet connection is not available to connect to a chat channel.

Agents can view incoming SMS requests on their dashboard and respond accordingly.

The tasks to add SMS support for TeleSign are as follows:

1. Enable SMS channel in your Dynamics 365 organization.

2. Register with TeleSign and get your customer ID and API key, and purchase a phone number.

3. Add SMS support through Omnichannel for Customer Service.

> [!NOTE]
>
> - The maximum number of characters supported for sent and received messages is 1600.
> - To ensure that third-party SMS providers handle opt-out commands properly, you must configure your consent settings with the provider directly.
> - SMS is an asynchronous mode of communication. Agents can close the conversation and then work on them later. Ending the conversation will mark it as resolved. More information: [Understand conversation states](oc-conversation-state.md)

## Prerequisite

Verify that you have permissions on the secure columns. More information: [Configure permissions to access secure columns](add-users-assign-roles.md#configure-permissions-to-access-secure-columns)

## Enable SMS channel in your Dynamics 365 organization

You can enable the SMS channel from the Dynamics 365 admin center. For steps on enabling SMS in your organization as a part of provisioning Omnichannel for Customer Service, see [Provision Omnichannel for Customer Service](omnichannel-provision-license.md).


## Sign up for TeleSign account

An SMS channel can be enabled within Omnichannel for Customer Service by integrating with TeleSign. This integration uses public APIs of TeleSign for sending and receiving text messages. You must sign up for a TeleSign account to enable an SMS channel in your organization.

1. Go to [TeleSign](https://go.microsoft.com/fwlink/p/?linkid=2127719) to sign up for a self-service account, and upgrade to standard or enterprise account for a complete integration with Omnichannel for Customer Service. If you expect to send high volumes of SMS traffic, such as more than 100,000 messages per month, contact [TeleSign support](mailto:support@telesign.com) to request an invoiced enterprise account.

2. Purchase support phone numbers through your TeleSign account.

3. Get the customer ID and API key from your TeleSign account. You will need to provide these while setting up the SMS channel in Omnichannel for Customer Service.

4. You are provided with a callback URL that must be sent to [TeleSign support](mailto:support@telesign.com). This callback URL is specific to your organization and is available when you add SMS support for your organization. When you send an email to TeleSign support, include the callback URL, your customer ID, and enter the subject line as **Omnichannel for Customer Service callback URL update request**.

## Add SMS support

1. In Dynamics 365, go to one of the admin apps, and perform the following steps:

   ### [Customer Service admin center](#tab/customerserviceadmincenter)
    
    1. In the site map, in **Customer support**, select **Channels**.
    
    1. In **Accounts**, for **Messaging accounts**, select **Manage**.
   
   ### [Omnichannel admin center](#tab/omnichanneladmincenter) 

    - In the site map, in **General settings**, select **Channels**.

1. On the **Accounts and channels** page, select **New account**.

1. Enter the following details:

   1. In **Channel details**, enter a name, and select SMS in **Channel**.

   1. In **Account details**, select TeleSign in **Provider**, and enter the following details:
      - **Customer ID:** Customer ID generated from the TeleSign account.
      - **API key:** API key generated from the TeleSign account.

   1. In **SMS phone numbers**, select **Add**, and enter the following details in **Add SMS number**:
    - **Number:** Specify the support phone number that you purchased from TeleSign in the *<phone_number>* format, such as 14252306549. Make sure that you don't enter blank spaces, special characters, or the plus sign (+).
    - **Type:** Select Geo, Short code, or Toll free.
    - **Description:** Enter a description.
    - **Validate:** Select to validate the customer ID and API key.
   
   1. In **Callback URL**, copy the value and send it to TeleSign at [support@telesign.com](mailto:support@telesign.com) with your customer ID; enter the subject line as "Omnichannel for Customer Service callback URL update request".

1. Open the workstream that you created for the SMS channel for TeleSign.

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
   
   1. Verify the settings on the **Summary** page, and select **Finish**. The SMS for TeleSign channel is configured.

1. Configure routing rules. More information: [Configure work classification](configure-work-classification.md).

1. Configure work distribution. More information: [Work distribution settings](create-workstreams.md#configure-work-distribution)

1. Add a bot. More information: [Configure a bot](create-workstreams.md#add-a-bot-to-a-workstream).

1. In **Advanced settings**, configure the following options based on your business needs:
   - [Sessions](../app-profile-manager/session-templates.md)
   - [Agent notifications](../app-profile-manager/notification-templates.md#out-of-the-box-notification-templates)
   - [Context variables](manage-context-variables.md#add-context-variables))
   - [Smart assist bots](smart-assist-bot.md)
   - [Quick replies](create-quick-replies.md)

## Flow of data between Omnichannel for Customer Service SMS channel and TeleSign

### Incoming text messages

For an incoming text message sent by a customer to the support phone number, the message is first sent to the TeleSign service and then pushed by TeleSign to Omnichannel for Customer Service using the callback URL. After this, the message gets routed and associated to either a new or an existing conversation by Omnichannel for Customer Service.

### Outgoing text messages

For an outgoing message sent by an agent from within Dynamics 365, the message is first sent to the TeleSign service and then TeleSign sends it to the customer. In addition to the text message, Omnichannel for Customer Service uses the APIs provided by TeleSign to send the customer's phone number, support phone number (TeleSign SenderID), and the TeleSign account information (CustomerID and the API Key) to the TeleSign service.

### TeleSign API Key Validation

When you validate the API key while setting up the SMS channel, a call is made to TeleSign to validate customer ID and the API key.

#### Add SMS support in Omnichannel Administration

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../includes/cc-omnichannel-administration-deprecation-note.md)]

1. In the Omnichannel Administration app, go to **Work Streams** under **Work Distribution Management**.

2. Select **New** to create a workstream. On the **Work Distribution** tab, enter the following information:

    - **Name**: Name of the workstream.
    - **Channel**: Select **SMS**.
    - **Auto-close after inactivity**: Select a duration of at least 8 hours.
    - **Allow automated messages**: Specify **Yes** to be able to define the business hours.

    > [!div class=mx-imgBorder]
    > ![SMS channel - new workstream.](media/sms-workstream.png "SMS channel - new workstream")

3. On the **SMS Settings** tab, enter the following information:
    - **Customer ID**: Customer ID generated from the TeleSign account.
    - **API key**: API key generated from the TeleSign account.

4. Copy the value from the **TeleSign inbound URL** field, and send it to TeleSign at [support@telesign.com](mailto:support@telesign.com) with your customer ID; enter the subject line as "Omnichannel for Customer Service callback URL update request". This value is the callback URL that is used to process incoming SMS messages.

5. Select **Save**.

    > [!div class=mx-imgBorder]
    > ![SMS Settings tab.](media/sms-settings.png "SMS Settings tab")

6. On the **SMS Numbers** tab, select **New SMS Number**, and then enter the following details:

    - **Number**: Specify the support phone number that you purchased from TeleSign in the *<country_code><phone_number>* format, such as 14252306549. Make sure that you don't enter blank spaces or special characters.
    - **SMS number language**: This is the preferred language that will be used when you configure automated messages on the **Automated messages** tab. 
    - **Type**: Select **Long code**, **Short code**, or **Toll free**.
    - **Description**: Specify a description for the number. (Optional) 
    - **Operating Hours**: Specify the business hours when the customer support team is active and available to serve customers.

    > [!NOTE]
    >
    > - You can configure only one phone number per workstream.
    > - Ensure that the phone number is entered in the following format without spaces and special characters: &lt;phone number&gt;. For information on availability of international numbers, see [TeleSign coverage map](https://www.telesign.com/).
    > - Short code is supported for enterprise accounts.

7. Select **Save**.

8. (Optional). On the **Automated messages** tab, [configure automated messages](configure-automated-message.md).

9. (Optional). On the **Surveys** tab, [configure a post-conversation survey](configure-post-conversation-survey.md).

10. Select **Validate API Key** from the toolbar at the top of the page to validate the customer ID and API key.

11. Open the workstream you created for SMS.

12. On the **Routing rules items** tab, create a routing rule to transfer the SMS to an appropriate agent. Routing rule for SMS works on the **Mobile Phone** field of the Contact entity. The customer is identified based on the **Mobile Phone** field and the conversation is automatically linked to the contact record.

### See also

[Channels in Omnichannel for Customer Service](channels.md)  
[Overview of SMS channels](sms-channel-overview.md)  
[Configure SMS channel using Azure Communication Services](configure-sms-channel-acs.md)  
[Configure SMS channel for Twilio](configure-sms-channel-twilio.md)  
[Create and manage routing rules](routing-rules.md)  
[Configure automated messages](configure-automated-message.md)  
[Delete a configured channel](delete-channel.md)  
[SMS FAQ](faqs.md#sms)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
