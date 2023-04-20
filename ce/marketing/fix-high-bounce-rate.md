---
title: "Fix a high email bounce rate (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to diagnose and fix a high email bounce rate in Dynamics 365 Marketing."
ms.date: 07/19/2021

ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Fix a high email bounce rate

If you receive a notification that a past campaigns’ bounce rate surpassed the acceptable bounce limit, your email campaign requires some special attention.

## What is the email bounce rate?

In email marketing, the bounce rate refers to the percentage of emails in your contact list that did not receive an email message because it was returned by the recipient server. The bounce rate is calculated by dividing the number of bounced emails by the number of sent emails and multiplying by 100.

An acceptable bounce rate, in most cases, should not be higher that two percent. The acceptable bounce rate threshold in Dynamics 365 Marketing is up to eight percent. Learn more: [Email policies and suspension standards](email-policies.md).

## What does a high bounce rate mean for you as a sender?

Generally, a spike in bounces can lead to potential issues for your email sending reputation. That’s why it is important to keep your bounce rates at a low level.

The most common reasons for an increase bounce rate are following:

- **Issues with contact list (hard bounces)**: Old, invalid, or inactive contacts in the list, a list that has been purchased from a third party, or a broken list that has invalid contact data.
- **Reputation/blocklist issues**: Bounces due to sender IP or domain reputation, spam content decisions from the recipient side.
- **Temporary or technical issues on the recipient side**: A full recipient mailbox, recipient server failures, or networking issues.

You can check out a detailed explanation of all bounce categories in the [email bounce categories](email-bounce-categories.md) article.

## How can you lower your bounce rates?

First and foremost, you should keep your contact data clean and up to date. You should regularly clean your segments from old and invalid contacts that have already hard bounced. It is also a good idea to monitor open and click rates for your contacts. If a contact does not open and interact with your emails for a long period of time, it is a good idea to exclude the contact from sending.

Secondly, keep your email flow consistent. Do not change the frequency or volume of your campaigns, content, subjects, or media assets often. It may lead to the spam filters decide that your email is exhibiting spammy behavior.

From a deliverability perspective, sending emails regularly to approximately the same segment size is better than sending once a month, but to a one large segment.

And finally, always monitor your delivery results. Check your bounce rates and engagement rates (opens and clicks) regularly so that you do not miss any potential slow growth of bounces across your campaigns. Monitoring these rates will allow you to prevent damage to your sending reputation and keep your contacts data up to date.

Bounce rate is a key indicator of your contact list health. There will always be a few bounces in every campaign. It is expected and normal. But preventing a large number of bounces is key to maintaining your sender reputation and is achievable with consistent monitoring.

[!INCLUDE[footer-include](../includes/footer-banner.md)]