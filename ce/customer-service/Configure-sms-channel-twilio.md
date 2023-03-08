---
title: Configure an SMS channel for Twilio
description: Learn how to configure an SMS channel for Twilio in Omnichannel for Customer Service.
ms.date: 03/08/2023
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.custom: bap-template
---

# Configure an SMS channel for Twilio

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

The SMS channel through Twilio in Omnichannel for Customer Service allows your organization to connect to customers by using text messages. Your customers can send text messages through Twilio and connect with an appropriate customer service agent. Agents can view incoming SMS requests on their dashboard and respond accordingly.

## Prerequisites

Make sure that the following prerequisites are met:

- SMS for Twilio is provisioned in Omnichannel for Customer Service. More information: [Provision Omnichannel for Customer Service](omnichannel-provision-license.md)
    > [!NOTE]
    >
    > To enable the SMS channel for Twilio in an existing Omnichannel for Customer Service environment, you must upgrade to the latest version of Omnichannel for Customer Service. More information: [Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)

- A Twilio account with a phone number and subscription is available.
- Permissions on the secure columns. More information: [Configure permissions to access secure columns](add-users-assign-roles.md#configure-permissions-to-access-secure-columns)

### Get Twilio account details

An SMS channel is enabled within Omnichannel for Customer Service by integrating with Twilio. This integration uses public APIs of Twilio for sending and receiving text messages.

1. In your Twilio account, note the ACCOUNT SID and AUTH TOKEN values. These values are required to create the SMS configuration in the Omnichannel admin center app.

2. Purchase support phone numbers through your Twilio account.

> [!NOTE]
>
> - Only US phone numbers are supported.
> - To ensure that third-party SMS providers handle opt-out commands properly, you must configure your consent settings with the provider directly.  

## Set up the SMS channel for Twilio

To configure the SMS channel, you'll do the following tasks:
- Configure the SMS number
- Configure the workstream for the SMS channel

### Configure the SMS number

1. In Dynamics 365, go to one of the apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)
    
    1. In the site map, in **Customer support**, select **Channels**.
    
    1. In **Accounts**, for **Messaging accounts**, select **Manage**.
   
   ### [Omnichannel admin center](#tab/omnichanneladmincenter) 

    - In the site map, in **General settings**, select **Channels**.

1. On the **Accounts and channels** page, select **New account**.

1. Enter the following details:
   1. In **Channel details**, enter a name, and select SMS in **Channel**.
   2. In **Account details**, select **Twilio** in **Provider**, and then enter the following details:
      - **Account SID:** Enter the Twilio ACCOUNT SID.
      - **Auth token:** Enter the Twilio AUTH TOKEN.
   3. In **SMS phone numbers**, select **Add**, and enter the following details in **Add SMS number**:
      - **Number:** Specify the support phone number that you purchased from Twilio in the *<country_code><phone_number>* format, such as 14252306549. Make sure that you don't enter blank spaces or special characters.
      - **Type**: Select **Long code**, **Short code**, or **Toll free**.
      - **Description**: Specify a description for the number. (Optional)
   4. In **Callback information**, copy the callback information. You'll use the copied information for the Twilio account.
   5. Select **Done**. The account is configured.

### Configure the workstream for the SMS channel

To configure the workstream, make sure you perform the steps to create a workstream for the SMS channel. More information: [Create workstreams](create-workstreams.md)

1. Go to workstreams page and open the workstream you created for the channel.
2. In the **Set up your SMS channel** section, select **Set up SMS**, and then configure the following options:
   1. On the **SMS setup** page, select a number from the list.
   2. On the **Language** page, select the language that you want to set as the default.
   3. On the **Behaviors** page, configure the following options:
     - **Channel operation hours:** Set the toggle to **On**, and then select an operating hour record. More information: [Configure operating hours](create-operating-hours.md)
     - [Custom automated messages](configure-automated-message.md)
     - [Post-conversation survey](configure-post-conversation-survey.md)
   4. In **User features**, set the toggle for **File attachments** to **On** and select the following options if you want both agents and customers to exchange files. More information: [Enable file attachments](enable-file-attachments.md)
     - Customers can send file attachments
     - Agents can send file attachments
   5. Verify the settings on the **Summary** page, and then select **Finish**. The SMS for Twilio channel is configured.
3. Configure routing rules. More information: [Configure work classification](configure-work-classification.md)
4. Configure work distribution. More information: [Work distribution settings](create-workstreams.md#configure-work-distribution)
5. Add a bot. More information: [Configure a bot](create-workstreams.md#add-a-bot-to-a-workstream)
6. In **Advanced settings**, configure the following options based on your business needs:
   - [Sessions](../app-profile-manager/session-templates.md)
   - [Agent notifications](../app-profile-manager/notification-templates.md#out-of-the-box-notification-templates)
   - [Context variables](manage-context-variables.md#add-context-variables)
   - [Smart assist bots](smart-assist-bot.md)
   - [Quick replies](create-quick-replies.md)

## Establish a connection between Omnichannel for Customer Service and the Twilio account

Perform the following steps to configure the URL in Twilio for the SMS messages from Omnichannel for Customer Service to be processed in Twilio:

1. Copy the value in **Twilio inbound URL** of the workstream for Twilio.

2. Go to your Twilio account > **Phone Numbers** > **Active Numbers**, and then select the SMS phone number.

3. In the **Messaging** section, paste the Twilio inbound URL.

## Flow of data between Omnichannel for Customer Service - SMS channel and Twilio

### Incoming text messages

For an incoming text message sent by a customer to the support phone number, the message is first sent to the Twilio messaging service and then pushed by Twilio to Omnichannel for Customer Service by using the callback URL. After this, the message gets routed and associated to either a new or an existing conversation by Omnichannel for Customer Service.

### Outgoing text messages

For an outgoing message sent by an agent from within Dynamics 365, the message is first sent to the Twilio service and then Twilio sends it to the customer. In addition to the text message, Omnichannel for Customer Service uses the APIs provided by Twilio to send the customer's phone number, support phone number, and the Twilio account information (Account SID and the Auth Token) to the Twilio service.

### Twilio account and phone number validation

When you validate the SMS settings while setting up the SMS channel, a call is made to Twilio to validate the Account SID and Auth Token.

#### Configure the SMS for Twilio channel in the Omnichannel Administration app

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../includes/cc-omnichannel-administration-deprecation-note.md)]

The information in this section is not applicable if you are using the new Omnichannel admin center app in the latest version of Omnichannel for Customer Service.

Perform the following steps to create a work stream for the SMS channel for Twilio:

1. In Omnichannel Administration, go to **Work Streams** under **Work Distribution Management**.

2. Select **New**. The **New Work Stream** page appears.

3. In the **General information** area, enter the following details:

    - **Channel**: Select **SMS**.
    - **Auto-close after inactivity**: Select a value that indicates a duration of eight hours or longer.
    - **Allow automated messages**: Specify **Yes** to be able to define the business hours.

4. In **Work distribution**, specify the necessary details. More information: [Create a work stream](work-streams-introduction.md#create-a-work-stream)

5. On the **SMS Settings** tab, enter the following details:

    - **SMS Provider**: Select **Twilio**.
    - **Account SID**: Enter the Twilio ACCOUNT SID.
    - **Auth Token**: Enter the Twilio AUTH TOKEN.

6. Select **Save**. The **Twilio inbound URL** is generated and displayed.

7. On the **SMS Numbers** tab, select **New SMS Number**, and then enter the following details:

    - **Number**: Specify the support phone number that you purchased from Twilio in the *<country_code><phone_number>* format, such as 14252306549. Make sure that you don't enter blank spaces or special characters.
    - **SMS number language**: This is the preferred language that will be used when you configure automated messages on the **Automated messages** tab. 
    - **Type**: Select **Long code**, **Short code**, or **Toll free**.
    - **Description**: Specify a description for the number. (Optional) 
    - **Operating Hours**: Specify the business hours when the customer support team is active and available to serve customers.

    > [!NOTE]
    > You can configure only one phone number per workstream.

8. Select **Save**.

9. (Optional). On the **Automated messages** tab, [configure automated messages](configure-automated-message.md).

10. (Optional). On the **Surveys** tab, [configure a post-conversation survey](configure-post-conversation-survey.md).

11. On the command bar, select **Validate API Key**. The Twilio account and phone number are validated.

12. Configure the routing rules on the **Routing rule items** tab. The routing rule for SMS works on **Mobile Phone** of the **Contact** entity. The customer is identified based on **Mobile Phone**, and the conversation is automatically linked to the contact record.

    > [!NOTE]
    > To configure routing rules and other options in the workstream for Twilio, see the following:
    > - [Skill-based routing](overview-skill-work-distribution.md)
    > - [Productivity tools](../app-profile-manager/productivity-tools.md)
    > - [Smart assist](../app-profile-manager/smart-assist.md)
    > - [Templates](/dynamics365/app-profile-manager/templates-overview)

### See also

[Channels in Omnichannel for Customer Service](channels.md)  
[Overview of SMS channels](sms-channel-overview.md)  
[Delete a configured channel](delete-channel.md)  
[Configure SMS channel using Azure Communication Services](configure-sms-channel-acs.md)	
[Configure SMS channel using TeleSign](configure-sms-channel.md)	
[SMS FAQ](faqs.md#sms)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
