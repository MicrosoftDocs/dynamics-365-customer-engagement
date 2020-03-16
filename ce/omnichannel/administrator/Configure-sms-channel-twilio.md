---
title: "Configure SMS channel for Twilio | MicrosoftDocs"
description: "Instructions for configuring an SMS channel for Twilio in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/01/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Configure an SMS channel for Twilio

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## What is SMS channel for Twilio?

## Prerequisites

Make sure that the following prerequisites are met:
SMS for Twilio is provisioned in Omnichannel for Customer Service and SMS channel is installed in your environment.
A Twilio account with appropriate phone number and subscription is available.

## Configure an SMS channel for Twilio in Omnichannel

### Step 1: Get Twilio account details

An SMS channel is enabled within Omnichannel for Customer Service by integrating with Twilio. This integration uses public APIs of Twilio for sending and receiving text messages.

1. In your Twilio account, note the ACCOUNT SID and AUTH TOKEN values. The values are required to create the SMS configuration in the Omnichannel Administration app.
2. Purchase support phone numbers through your Twilio account.

> [!NOTE]
> 
> In this release, only long code type US phone numbers are supported.
> 
### Step 2: Create a work stream

Perform the following steps to create a work stream for the SMS channel for Twilio:

1. Sign in to Omnichannel Administration.
2. Select **Work Streams** under **Work Distribution Management**.
3. Select **New**. The **New Work Stream **page appears.
4. In **General information**, do the following:
    - **Channel:** Select SMS.
    - **Auto-close after inactivity:** Select a value that indicates a duration of eight hours or more.
    - **Allow automated messages:** Accept the default value **No**. This option is for future use only.
5. In **Work distribution**, specify the necessary details. For information, see [Create a work stream](work-streams-introduction.md#create-a-work-stream).
6. On the **SMS Settings** tab, do the following:
    - **SMS Provider:** Select Twilio.
    - **Account SID:** Enter the Twilio ACCOUNT SID.
    - **Auth Token:** Enter the Twilio AUTH TOKEN.
7. Select **Save**. The **Twilio inbound URL** is generated and displayed.
8. On the **SMS Numbers** tab, select **New SMS Number**, and do the following:
    - **Number:** Specify the phone number in the <country_code><phone_number> format. Make sure that you don't enter blank spaces or special characters.
    - **Type:** Select Long code. 
    - **Description:** Specify optional description for the number.
    - **Operating Hours:** Specify the business hours when the customer support team is active and available to serve customers. You can specify a value only when the **Allow automated messages** option is set to Yes on the **Work Distribution Management** tab.
    > [!NOTE]
    >
    > You can configure only one phone number per work stream.
9. Select **Save**. 
