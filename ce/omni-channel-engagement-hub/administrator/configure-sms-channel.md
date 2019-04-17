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

## Add SMS support for your organization

To add SMS support for your organization, you must first register with TeleSign and get your customer ID and API key, and purchase a phone number. You can then add SMS support through Omni-channel Engagement Hub.

1.	Sign in to Omni-channel Engagement Hub.

2.	Go to **Administration** > **Work Streams**.

3.	Select **New** to create a work stream.

4.	On the **Summary** tab, in the **Channel** field, select **SMS**.

5.	In the **Auto-close after inactivity** field, select a duration of at least 8 hours.

6.	On the **SMS settings** tab, enter the following information:
    - **Customer ID**: Customer ID generated from the TeleSign account.
    - **API key**: API key generated from the TeleSign account.

7.	Select **Save**.

8.	On the **SMS numbers** tab, select **Add new SMS number**.

9.	On the **New SMS Number** page, enter the following information:
    - **Number**: Phone number purchased from TeleSign.
    - **Type**: Select if the number is long code, short code, or toll free.
    - **Description**: Optional description for the number.
    
    > [!NOTE]
    > In this preview, only one phone number of type long code is supported per work stream.

10.	Select **Save**.

11.	Select Validate API Key from the toolbar at the top of the page to validate the customer ID, API key, and phone number.

12.	On the Routing rules items tab, create a routing rule to transfer the SMS to an appropriate agent.


