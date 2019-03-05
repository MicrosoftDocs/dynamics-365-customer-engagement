
---
title: "Configure an SMS channel | MicrosoftDocs"
description: "Instructions to configure an SMS channel in Omni-channel Engagement Hub."
keywords: ""
author: sbmjais
ms.author: shjais
manager: shujoshi
applies_to: 
ms.date: 03/06/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 0D79FA10-B7F6-4B62-99C4-88DEEB92D5D6
ms.custom: 
---

# Configure an SMS channel

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

An SMS channel allows your organization to connect to customers by using text messages. When you configure an SMS channel, your customers can send text messages and connect with an appropriate agent. This provides your customers the flexibility to connect with their mobile devices even if there is no internet connection for connecting to chat channel.

Agents can view the incoming SMS requests in their dashboard and respond accordingly.

SMS channel is available in preview. You must sign-up for the preview through the Dynamics 365 Insider Program so that it is enabled for your organization.

## Add SMS support for your organization

To add SMS support for your organization, you must first register with TeleSign and get your customer ID and API key, and purchase a phone number. You can then add SMS support through Omni-channel Engagement Hub.

1. Sign in to Omni-channel Engagement Hub.

2. Go to **Administration** > **Work Streams**.

3. Select **New** to create a work stream.

4. On the **Summary** tab, in the **Stream source** field, select **SMS**.

5. In the **Auto-close after inactivity** field, select a duration of at least 8 hours.

    For more information on work streams, see [Create and manage work streams](work-streams-introduction.md#create-a-work-stream).

6. On the **SMS settings** tab, provide the following information:

   - **Customer ID**: Customer ID generated from the TeleSign account.

   - **API key**: API key  generated from the TeleSign account.

7. Select **Save**.

8. On the **SMS numbers** tab, select **Add new SMS number**.

9. On the **New SMS Number** page, provide the following information:

   - **Number**: Phone number purchased from TeleSign.

   - **Type**: Select if the number is long code, short code, or toll free.
    
   - **Description**: Optional description for the number.

   > [!NOTE]
   > In this preview, only one phone number is supported per work stream.

10. Select **Save**.

11. Select **Validate API Key** from the toolbar at the top of the page to validate the customer ID, API key, and phone number.

12. On the **Routing rules items** tab, create a routing rule to transfer the SMS to an appropriate agent.
