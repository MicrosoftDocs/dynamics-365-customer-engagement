---
title: "Configure SMS channel for Twilio | MicrosoftDocs"
description: "Instructions for configuring an SMS channel for Twilio in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/09/2021
ms.topic: article
ms.service: "dynamics-365-customerservice"
---

# Configure an SMS channel for Twilio

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Overview

The SMS channel through Twilio in Omnichannel for Customer Service allows your organization to connect to customers by using text messages. Your customers can send text messages through Twilio and connect with an appropriate customer service agent. Agents can view the incoming SMS requests on their dashboard and respond accordingly.

## Prerequisites

Make sure that the following prerequisites are met:

- SMS for Twilio is provisioned in Omnichannel for Customer Service. More information: [Provision Omnichannel for Customer Service](omnichannel-provision-license.md)
    > [!NOTE]
    >
    > To enable the SMS channel for Twilio in an existing Omnichannel for Customer Service environment, you must upgrade to the latest version of Omnichannel for Customer Service. More information: [Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)

- A Twilio account with a phone number and subscription is available.

## Configure an SMS channel for Twilio in Omnichannel for Customer Service

### Get Twilio account details

An SMS channel is enabled within Omnichannel for Customer Service by integrating with Twilio. This integration uses public APIs of Twilio for sending and receiving text messages.

1. In your Twilio account, note the ACCOUNT SID and AUTH TOKEN values. These values are required to create the SMS configuration in the Omnichannel Administration app.

2. Purchase support phone numbers through your Twilio account.

> [!NOTE]
> Only US phone numbers are supported.

### Configure the SMS channel in Omnichannel admin center

1. In the site map of Omnichannel admin center, select **Channels** under **General Settings**, and select **Add account**.
2. Enter the following details:
   a. In **Channel details**, enter a name, and then select SMS in **Channel**.
   b. In **Account details**, select **Twilio** in **Provider**, and enter the following details:
      - **Account SID:** Enter the Twilio ACCOUNT SID.
      -  **Auth token:** Enter the Twilio AUTH TOKEN.
   c. In **SMS phone numbers**, select **Add**, and then enter the following details in **Add SMS number**:
      - **Number:** Specify the support phone number that you purchased from Twilio in the *<country_code><phone_number>* format, such as 14252306549. Make sure that you don't enter blank spaces or special characters.
      - **Type**: Select **Long code**, **Short code**, or **Toll free**.
      - **Description**: Specify a description for the number. (Optional)
   d. In **Callback information**, copy the callback information. You'll use the copied information for the Twilio account.
   e. Select **Done**. The account is configured.
3. Open the workstream that you created for the SMS channel for Twilio.
4. Select **Add SMS Channel**, and configure the following options:
   a. On the **SMS number** page, select a number from the list.
   b. On the **Language** page, select the language that you want to set as the default.
   c. On the **Behaviors** page, configure the following options:
     - **Channel operation hours:** Set the toggle to **On**, and then select an operating hour record. More information: [Configure operating hours](create-operating-hours.md).
     - [Custom automated messages](configure-automated-message.md)
     - [Post-conversation survey](configure-post-conversation-survey.md)
   d. In **User features**, set the toggle for **File attachments** to On and select the following options if you want both agents and customers to exchange files. More information: [Enable file attachments](enable-file-attachments.md).
     - Customers can send file attachments
     - Agents can send file attachments
   e. Verify the settings on the **Summary** page, and select **Finish**. The SMS for Twilio channel is configured.
5. Configure routing rules. More information: [Configure work classification](configure-work-classification.md).
6. Configure work distribution. More information: [Work distribution settings](create-workstreams.md#configure-work-distribution)
7. Add a bot. More information [Configure a bot](create-workstreams.md#add-a-bot).
8. In **Advanced settings**, configure the following options based on your business needs:
   - [Sessions](../app-profile-manager/session-templates.md)
   - [Agent notifications](../app-profile-manager/notification-templates.md#out-of-the-box-notification-templates)
   - [Context variables](#configure-context-variables)
   - [Smart assist bots](smart-assist-bot.md)
   - [Quick replies](create-quick-replies.md)


### Create a work stream in Omnichannel Administration

Perform the following steps to create a work stream for the SMS channel for Twilio:

1. Sign in to Omnichannel Administration.

2. Under **Work Distribution Management**, select **Work Streams**.

3. Select **New**. The **New Work Stream** page appears.

4. In the **General information** area, enter the following details:

    - **Channel**: Select **SMS**.
    - **Auto-close after inactivity**: Select a value that indicates a duration of eight hours or more.
    - **Allow automated messages**: Specify **Yes** to be able to define the business hours.

5. In **Work distribution**, specify the necessary details. More information: [Create a work stream](work-streams-introduction.md#create-a-work-stream)

   > [!div class=mx-imgBorder]
   > ![Works stream settings for Twilio](media/sms-twilio.png "Work stream settings for Twilio")

6. On the **SMS Settings** tab, enter the following details:

    - **SMS Provider**: Select **Twilio**.
    - **Account SID**: Enter the Twilio ACCOUNT SID.
    - **Auth Token**: Enter the Twilio AUTH TOKEN.

7. Select **Save**. The **Twilio inbound URL** is generated and displayed.

   > [!div class=mx-imgBorder]
   > ![SMS settings for Twilio](media/sms-settings-twilio.png "SMS settings for Twilio")

8. On the **SMS Numbers** tab, select **New SMS Number**, and then enter the following details:

    - **Number**: Specify the support phone number that you purchased from Twilio in the *<country_code><phone_number>* format, such as 14252306549. Make sure that you don't enter blank spaces or special characters.
    - **SMS number language**: This is the preferred language that will be used when you configure automated messages on the **Automated messages** tab. 
    - **Type**: Select **Long code**, **Short code**, or **Toll free**.
    - **Description**: Specify a description for the number. (Optional) 
    - **Operating Hours**: Specify the business hours when the customer support team is active and available to serve customers.

    > [!NOTE]
    > You can configure only one phone number per work stream.

9. Select **Save**.

10. Optionally, on the **Automated messages** tab, [configure automated messages](configure-automated-message.md).

11. Optionally, on the **Surveys** tab, [configure a post-conversation survey](configure-post-conversation-survey.md).

12. On the command bar, select **Validate API Key**. The Twilio account and phone number are validated.

13. Configure the routing rules on the **Routing rule items** tab. The routing rule for SMS works on **Mobile Phone** of the **Contact** entity. The customer is identified based on **Mobile Phone**, and the conversation is automatically linked to the contact record.

    > [!NOTE]
    > To configure routing rules and other options in the work stream for Twilio, see the following:
    > - [Skill-based routing](overview-skill-work-distribution.md)
    > - [Productivity tools](productivity-tools.md)
    > - [Smart assist](../app-profile-manager/smart-assist.md)
    > - [Templates](templates-overview.md)

## Establish a connection between Omnichannel for Customer Service and the Twilio account

Perform the following steps to configure the URL in Twilio for the SMS messages from Omnichannel for Customer Service to be processed in Twilio:

1. Copy the value in **Twilio inbound URL** of the work stream for Twilio.

2. Go to your Twilio account > **Phone Numbers** > **Active Numbers**, and then select the SMS phone number.

3. In the **Messaging** section, paste the Twilio inbound URL.

## Flow of data between Omnichannel for Customer Service - SMS channel and Twilio

### Incoming text messages

For an incoming text message sent by a customer to the support phone number, the message is first sent to the Twilio messaging service and then pushed by Twilio to Omnichannel for Customer Service by using the callback URL. After this, the message gets routed and associated to either a new or an existing conversation by Omnichannel for Customer Service.

### Outgoing text messages

For an outgoing message sent by an agent from within Dynamics 365, the message is first sent to the Twilio service and then Twilio sends it to the customer. In addition to the text message, Omnichannel for Customer Service uses the APIs provided by Twilio to send the customer's phone number, support phone number, and the Twilio account information (Account SID and the Auth Token) to the Twilio service.

### Twilio account and phone number validation

When you validate the SMS settings while setting up the SMS channel, a call is made to Twilio to validate the Account SID and Auth Token.

### See also

[Channels in Omnichannel for Customer Service](channels.md)  
[Delete a configured channel](delete-channel.md)  
[SMS FAQ](faqs.md#sms)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
