---
title: "How Dynamics 365 Marketing uses suppression lists (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how Dynamics 365 Marketing uses suppression lists to protect email sending reputations."
ms.date: 09/12/2022
ms.topic: article
ms.custom: 
  - dyn365-marketing
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# How Dynamics 365 Marketing uses suppression lists

A suppression list is a powerful backend tool that ensures your sending reputation stays healthy. Suppression lists prevent email messages from being sent to harmful recipient addresses.

This article discusses types of harmful address, then details how suppression lists prevent your emails from reaching these addresses.

## Recipient addresses that affect your sending reputation

### Hard-bounced addresses

Sending frequent emails to hard-bounced, invalid email addresses alerts remote spam filters to potential “spammy” behavior. These alerts affect your inbox placement and deliverability results. Sending multiple hard bounces to the same email provider in the same batch may even lead to the email provider completely blocking a sender, which can affect valid recipients.

### Spamtraps

A spamtrap is a special email address that is used by email providers and email protection systems to identify spammers. A spamtrap address can be specially created or an email address that was disabled because of the owner’s inactivity. Spamtrap addresses are never announced and can't not be separated from regular, valid email addresses, making it especially important to avoid sending to them.

### Addresses that mark your mail as spam

Another type of address that is important to avoid is an email address that has marked your emails as spam, or, in other words, an email address that has *generated complaints*. Continuing to send emails to a person who has marked your email campaigns as spam negatively affects your sending reputation and labels you as a spam source.

## How the suppression list works

A suppression list is an automated backend tool that protects your sending reputation. The list is divided into three scopes of operation:

### Hard bounce suppression

Hard bounced email addresses are collected and stored in the suppression list. The hard bounce portion of the suppression list is a per-organization list. The list stores cumulative information from organization sending statistics, making the list broad and reliable.

When a customer sends an email campaign, the system automatically checks the segment used for the campaign against the list of known hard bounces inside the suppression list and prevents such addresses from going out. Soft bounced email addresses may also be listed in this suppression list. After five sequential failed attempts to deliver to the same email address, soft bounce addresses are converted to hard bounce addresses. More details on bounce reasons and categories can be found here: [Email bounce categories](email-bounce-categories.md).

To keep the list up-to-date, the backend tool stores information about hard bounced addresses for 180 days (about 6 months). In rare cases, a hard bounced address may become valid again.

### Spam complaint suppression

The spam complaint suppression list stores information about spam complaints (*feedback loop* reports) that were received regarding a specific organization and prevents such addresses from being sent to. Spam complaints are stored only for the specific organization that received a complaint. Spam complaint listings in the suppression list don't expire automatically.

### Pattern suppression

The pattern suppression is a manual list maintained by the deliverability engineers. It contains domains or email addresses that may not be a good idea to send to. For example, test mailboxes that will never read emails or domains that host temporary or disposable email addresses. Such mailboxes and domains are accessible to anyone and sending to them may harm your sending reputation.

## How to delist email addresses

If you find that some contacts were blocked with a “suppression list” reason and you're sure that they're 100% valid and the listing was caused by false-positive, you can submit a support request, providing the following information:

-	A list of the email addresses in question.
-	Justification as to why you believe each email address was listed by mistake. You should also provide proof that each email address is valid and can be reached by any other email provider.

After that, our deliverability team will review the request and determine if the addresses should be removed.

> [!NOTE]
> If a contact is removed from a supression list that is used in a live journey, the changes will take effect in the next iteration of the journey (if the journey is recurring), not in the current one.

[!INCLUDE[footer-include](../includes/footer-banner.md)]