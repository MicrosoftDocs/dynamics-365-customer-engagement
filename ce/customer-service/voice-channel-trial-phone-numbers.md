---
title: Use trial phone numbers in the voice channel
description: Use this article to understand how you can use trial phone numbers. Also, learn how to extend and end the trial in Omnichannel for Customer Service.
ms.date: 01/18/2023
ms.custom: bap-template
ms.topic: conceptual
author: gandhamm
ms.author: mgandham
---

# Use trial phone numbers

The voice channel includes a trial phone number that comes with 60 minutes of free calling. When the 60 minutes of free calling time elapses, you can choose to extend your trial or purchase a new number.

To extend your trial minutes, raise a request with Microsoft Support.
To purchase a new number at the end of the trial, see [Manage phone numbers](voice-channel-manage-phone-numbers.md). Note that you can't reuse or purchase the trial number.

> [!NOTE]
> You don't need to connect to Azure Communication Services to use trial numbers.

## Prerequisites

- You must have an active subscription of **Dynamics 365 Customer Service Voice Channel Add-in** or **Dynamics 365 Customer Service Digital Messaging and Voice Add-in**. More information: [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/p/?LinkId=866544)
- You must install the voice channel. More information: [Install the voice channel](voice-channel-install.md)

## Use trial numbers

The trial number is a toll-free US number, therefore you can't make a call to this number if you aren't in the US. As a workaround, you could use a geographic US number that's not chargeable. However, trial numbers are capped at two, therefore it's the last trial number that you can acquire and should receive calls from anywhere. If you're calling from outside the US, international rates from your carrier will apply.

## End the trial

If you want to end the trial before it expires, select **End trial** on the **Phone numbers** page. Then, you'll be able to connect to Azure Communication Services using new or existing resources. More information: [Connect to Azure Communication Services](voice-channel-acs-resource.md)

> [!NOTE]
> You can't recover trial phone number and data after the trial has expired and been deprovisioned.