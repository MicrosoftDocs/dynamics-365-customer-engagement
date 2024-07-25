---
title: Text messaging FAQs
description: Get answers to frequently asked questions about text messaging.
ms.date: 07/19/2024
ms.topic: troubleshooting
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.owner: shujoshi
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/11/2024
---

# Text messaging FAQs

This article answers frequently asked questions about text messaging in Dynamics 365 Sales and Sales premium.

## Why can't I see the SMS feature in my sales app?​

Before you can see the SMS feature, an administraton must [configure SMS provider it in your sales app](configure-sms-provider.md) and necessary [permissions are granted](sms-intro.md#permissions-required). Also, ensure that your organization is in the [supported regions](sms-intro.md#in-which-regions-is-the-text-message-feature-available).​

## Which service providers are supported?

Currently, only Azure Communication Service, Telesign, Twilio, Infobip, and Vibes are supported as SMS channel providers.​ More information: [Configure SMS provider](configure-sms-provider.md)

## Can a same number be used across multiple Dynamics 365 applications such as Sales and Marketing?​

No. The number must be unique for each application, although the same channel provider can be used across applications.​

## Can I add my teammate to an ongoing SMS conversation with my customer?​

No. Currently, group SMS isn't supported as part of the SMS capability. However, a number can be assigned to a team, which can be used by the team to collaborate with a customer. All the conversations are added to the entity timeline.​

## Can I see if my customer has read the message or the message content?​

​No. Currently, you can only see if the message is delivered to the customer.

## Can I send or receive SMS through my mobile device?​

​No. You can't send or receive SMS through your mobile device.​

## Who can see an incoming SMS notification if the number is assigned to a team?​

Notifications are sent to the top 20 sellers when a new incoming message is received. The top 20 sellers are selected based on the following criteria:

1. Sellers who are already part of the conversation. If the conversation has at least one seller associated with it, the application skips criteria 2 and 3 to avoid spamming.
1. Sellers who have used the number to send messages.
1. Sellers who are part of the same team to which the number belongs.

However, other sellers can still view their team's chat history from the **All/My text messages** option in the **Activities** page. 
