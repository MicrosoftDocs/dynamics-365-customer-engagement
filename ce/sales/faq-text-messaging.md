---
title: Text messaging FAQs
description: Get answers to frequently asked questions about text messaging.
ms.date: 03/15/2024
ms.topic: troubleshooting
author: udaykirang
ms.author: udag
ms.owner: shujoshi
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/11/2024
---

# Text messaging FAQs

This article answers frequently asked questions about text messaging in Dynamics 365 Sales and Sales premium.

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

In this case, all the users see the notification and can choose to respond to the customer. If a message comes from an unknown number, only the team admin gets the notification. Team members can view the message only in the **Activities** page.

