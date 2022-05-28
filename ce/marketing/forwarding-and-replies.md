---
title: "Troubleshoot email forwarding and replies (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to troubleshoot issues with email forwarding and replies in Dynamics 365 Marketing."
ms.date: 05/27/2022
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Troubleshoot email forwarding and replies

This article details issues related to email forwarding and email reply-to addresses and offers possible workarounds.

## Email forwarding

Email forwarding is a standard way to share an email you received with another person. However, it may cause some issues with the formatting or functionality of email content. Put simply, emails often break when they are forwarded.

### Why email forwarding causes issues with email content

Different email clients (web and desktop versions of clients like Gmail, Yahoo, and Outlook) render emails differently. Forwarded emails also render differently depending on the client they are sent from. Depending on the client, forwarding can strip some HTML elements or it can insert some technical blocks into tje HTML code of your email. These changed elements can change the look of your email or even block the functionality.

### How to avoid content issues with forwarded emails

Unfortunately, there is not much you can do as a sender and email designer to predict the behavior of every email client that your subscribers use. It is not possible to avoid all possible changes that could result from email forwarding. However, if you are aware that your subscribers or recipients regularly forward your marketing emails, the following are some recommendations to reduce forwarding-related errors:

- Keep your email simple. Use a single–column design with a smaller number of separate elements. This can help your email retain its design after forwarding.
- Tell your recipients to forward your emails as an attachment. This approach increases the chances that original email will keep its design and elements untouched.
- Some web-based email clients offer alternative ways to share emails without touching the email code. This approach usually does not make a “classic” forward, but sends an original email on your behalf to the intended recipient or shares it through social networks.

## Reply-to addresses

When you send an email and your recipient wants to reply to your email, the reply email is usually sent to the email address listed in the "From:" header. The reply-to address is a special address (specified in the "Reply-To:" header) that provides an email address where replies to a message should go if it is different from a regular "From:" address.

The "Reply-To:" header is ignored, however, in the case of automatic responses. As detailed in [RFC3834](https://datatracker.ietf.org/doc/html/rfc3834), automatic responses should always be sent to an address specified in the "From:" header. In such a scenario, the "Reply-To:" header is ignored.

Only manual replies (when the recipient selects the “Reply” button) are sent to the "Reply-To:" address.