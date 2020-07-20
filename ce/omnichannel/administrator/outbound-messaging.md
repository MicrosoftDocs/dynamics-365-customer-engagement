---
title: "Configure outbound messaging in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn about how to configure outbound messaging in Omnichannel for Customer Service."
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 07/20/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---
# Preview: Configure outbound messaging

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
>
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided "as-is," "with all faults," "as available," and without warranty.​
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

## Overview

Outbound messaging enables organizations to dynamically send messages to their customers based on certain events through supported channels. In this preview, Omnichannel for Customer Service supports the sending of outbound messages through the SMS channel only.

With outbound messaging, organizations can do the following:

- Create message templates that can be adopted for outbound messages.
- Configure outbound messages based on certain events on any entity and send the messages when those events are triggered.

Organizations can send messages to customers automatically based on a system event, such as case creation. Organizations also can send notices to customers based on non-system events such as a shipping delays due to weather. 

When the customer responds back to the outbound messages, the customer messages will be treated like any other incoming conversation that exists today in Omnichannel for Customer Service. The conversation will be routed and assigned to an agent, and the agent will be able to respond back to the customer.

## Prerequisites

Before you configure outbound messaging, make sure that the following prerequisites are met:

- You must have the SMS channel provisioned in your environment. For information, see [Provision Omnichannel for Customer Service](omnichannel-provision-license.md).
- You must configure the SMS channel using an account with an SMS provider, either Twilio or Telesign. 
- You must have a Power Automate account.

After completing the prerequisites, you can send outbound messages from your organization by following these steps:

1. Set up message templates.
2. Set up outbound configuration.
3. Set up a Power Automate flow.

## Step 1: Set up message templates

1. Consider the scenarios that require your organization to send outbound messages.

2. Set up triggered and automatic outbound messages [link to Message templages topic].

## Step 2: Set up outbound configuration

1. Under Settings, click Outbound.

2. Complete the following fields:

    | Field               | Sample value                         |
    |---------------------|--------------------------------------|
    | Name                | Case create message                  |
    | Show in timeline    | Yes                                  |
    | Channel type        | SMS                                  |
    | Channel             | For SMS, the 10-digit SMS number     |
    | Language            | English                              |
    | Message template    | (your previously created template)   |

The **Configuration ID** will be generated when you click **Save**. You will use this later to identify this outbound message when you set up the Flow.

The **Conversation record** is set to automatically create a conversation in Omnichannel for Customer Service when a customer responds to the outbound message. This field cannot be modified.

Set **Show in timeline** to **Yes** for event-based messages that apply to the support journey of a specific set of customers. For bulk messages that will be sent to a high volume of customers, it is recommended to leave this setting at **No** in order to conserve resources in your Omnichannel environment and storage. 

## Step 3: Set up a Power Automate flow

Power Automate provides a low code platform for workflow and process automation. 

1. Go to https://us.flow.microsoft.com/en-us/ 

2. Set up an automated or instant flow.

    - **Automated:** Send an automatic message triggered by a system event, for example, case creation.

    - **Instant:** Send a message manually about a non-system event, for example, a shipping delay or a sale on products.
    
When the customer responds back to the outbound messages, the customer messages will be treated like any other incoming conversation that exists today in Omnichannel for Customer Service. The conversation will be routed and assigned to an agent, and the agent will be able to respond back to the customer.

### See also

[Channels in Omnichannel for Customer Service](channels.md) <br> 
[Configure an SMS channel for TeleSign](configure-sms-channel.md)<br>
[Configure an SMS channel for Twilio](configure-sms-channel-twilio.md)<br>
[SMS FAQ](../faqs.md#sms)
