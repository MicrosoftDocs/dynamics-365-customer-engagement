---
title: "Configure an SMS channel | MicrosoftDocs"
description: "Instructions to configure an SMS channel in Omni-channel Engagement Hub."
keywords: ""
author: sbmjais
ms.author: shjais
manager: shujoshi
applies_to: 
ms.date: 04/26/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 4392FF3A-51B1-42DC-A576-C3001D879469
ms.custom: 
---

# Configure an SMS channel

An SMS channel allows your organization to connect to customers by using text messages. When you configure an SMS channel, your customers can send text messages and connect with an appropriate customer service agent. This provides your customers the flexibility to connect with their mobile devices even if there is no internet connection for connecting to chat channel.

Agents can view the incoming SMS requests in their dashboard and respond accordingly.

To add SMS support for your organization, you must first register with TeleSign and get your customer ID and API key, and purchase a phone number. You can then add SMS support through Omni-channel Engagement Hub.

## Sign up for TeleSign account

SMS channel is enabled within Omni-channel Engagement Hub by integrating with TeleSign. This integration uses public APIs of TeleSign for sending and receiving text messages. You must sign up for a TeleSign account to enable SMS channel in your organization.

To sign up for TeleSign:

1.	Sign up for a [TeleSign account](https://www.telesign.com/) if you don't have one already.

2.	Purchase support phone numbers through your TeleSign account. For preview, only long code type phone numbers belonging to USA are supported.

3.	Get the Customer ID and API key from your TeleSign account. This will need to be provided while setting up SMS channel in Omni-channel Engagement Hub.

4.	You are provided with a callback URL that must be sent to TeleSign at [support@telesign.com](support@telesign.com). This callback URL is specific to your organization. The callback URL is available when adding SMS support for your organization.

## Add SMS support for your organization

1.	Sign in to Omni-channel Engagement Hub.

2.	Go to **Administration** > **Work Streams**.

3.	Select **New** to create a work stream.

4.	On the **Summary** tab, in the **Channel** field, select **SMS**.

5.	In the **Auto-close after inactivity** field, select a duration of at least 8 hours.

6.	On the **SMS settings** tab, enter the following information:
    - **Customer ID**: Customer ID generated from the TeleSign account.
    - **API key**: API key generated from the TeleSign account.

7. Copy the value from the **TeleSign inbound URL** field and send it to TeleSign at [support@telesign.com](support@telesign.com).

8.	Select **Save**.

9.	On the **SMS numbers** tab, select **Add new SMS number**.

10.	On the **New SMS Number** page, enter the following information:
    - **Number**: Phone number purchased from TeleSign.
    - **Type**: Select if the number is long code, short code, or toll free.
    - **Description**: Optional description for the number.
    
    > [!NOTE]
    > For this preview, only one phone number is supported per work stream.

11.	Select **Save**.

12.	Select **Validate API Key** from the toolbar at the top of the page to validate the customer ID, API key, and phone number.

13. Open the work stream you created for SMS.

14.	On the **Routing rules items** tab, create a routing rule to transfer the SMS to an appropriate agent. Routing rule for SMS works on the **Mobile Phone** field of the Contact entity.

### See also

[Understand and create work streams](administrator/work-streams-introduction.md)<br>
[Create and manage routing rules](administrator/routing-rules.md)
