---
title: Use trial phone numbers in the voice channel
description: Use this article to understand how you can use trial phone numbers in Omnichannel for Customer Service.
ms.date: 01/18/2023
ms.custom: bap-template
ms.topic: how-to
author: gandhamm
ms.author: mgandham
---

# Use trial phone numbers

The voice channel provides trial phone numbers with 60 minutes of free calling time. You can choose to use a maximum of two trial phone numbers in your organization. When you try the voice demo for the first time, you're automatically assigned a toll-free trial phone number with 60 minutes of free calling time.

> [!NOTE]
> You don't need to connect to Azure Communication Services to use trial numbers.

## Prerequisites

- You must have an active subscription of **Dynamics 365 Customer Service Voice Channel Add-in** or **Dynamics 365 Customer Service Digital Messaging and Voice Add-in**. More information: [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/p/?LinkId=866544)
- You must install the voice channel. More information: [Install the voice channel](voice-channel-install.md)

## How trial phone numbers work

The trial phone number is a US number, so you can't call this number if you're outside of the US. As a workaround, we recommend that you use a geographic US number as your second trial number to receive calls, so that it's not chargeable. 

> [!NOTE]
> - The total free calling time for two trial phone numbers is limited to 60 minutes.
> - If you're calling the geographic number from outside the US, then international carrier rates will apply.


Your voice trial automatically ends after the free calling time elapses. If you'd like to end the trial manually before the free calling time expires, then you can manually end the trial. To do this, see [End the trial](#end-the-trial).

After your free calling time has elapsed, you can either [purchase new phone numbers](voice-channel-manage-phone-numbers.md) or request Microsoft Support for more calling minutes. 

> [!NOTE]
> You can't reuse or purchase the trial phone number.

## End the trial

If you want to end the trial before it expires, select **End trial** on the **Phone numbers** page. Then, you'll be able to connect to Azure Communication Services using new or existing resources. More information: [Connect to Azure Communication Services](voice-channel-acs-resource.md)

> [!NOTE]
> You can't recover trial phone number and any related data after the trial organization has expired and has been deprovisioned.