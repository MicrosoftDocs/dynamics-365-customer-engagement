---
title: "Configure a custom channel | MicrosoftDocs"
description: "Learn what is a custom channel and how to configure the channel in Omnichannel for Customer Service."
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 04/01/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Configure a custom channel

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]


## Overview of custom channel

Many customers use social messaging channels for their personal communication needs. Customer expectations are rising, and many prefer using these messaging channels to engage with businesses. Expectations of customer service via social channels are rising to the point that customers now expect the same level of service they’re used to from call and live chat to those on social channels. 

The success of social media customer service, like all other customer service, depends on the quality of care provided. Communications from agents should be timely, accurate, sensitive, brief, and friendly, which ultimately improves the customer satisfaction and brand loyalty.

The custom channel feature lets you integrate a social messaging channel of your social channel with Omnichannel for Customer Service so as to engage with customers who prefer these social channels.

## End-to-end walk-through

[Step 1: Register your social channel](#step-1-register-your-social-channel)

[Step 2: Create a work stream](step-2-create-a-work-stream)

Step 3: Create a custom channel

### Step 1: Register your social channel

To integrate your social channel with Omnichannel for Customer Service, you need to register your channel in **Azure Bot Service**. To learn how to register, see [Register a bot with Azure Bot Service](https://docs.microsoft.com/azure/bot-service/bot-service-quickstart-registration).

After you register, save the **Microsoft App ID** and **Password** values safely for future use. These two values are required to create a custom channel in the Omnichannel Administration app. 

You need to use it as follows:

| Azure Bot Service field name | Omnichannel Administrator custom channel field name |
|------------------------------|------------------------------------------------------|
| Microsoft App ID | MS App ID |
| Password | MS App Secret |

## Step 2: Create a work stream

After registering your social channel, you need to create a work stream for the custom channel. Follow these steps:

1. Sign in to Omnichannel Administrator.

2. Select **Work Streams** under **Work Distribution Management**.

3. Select **+ New** to create a new work stream.

4. Specify the values for the fields.

5. Select the **Custom** option for the **Channel** field.

6. Save the changes.


