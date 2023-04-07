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
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Troubleshoot email forwarding and replies

This article details issues and best practices related to email forwarding and email reply-to addresses.

## Email forwarding

Email forwarding is a standard way to share an email you received with another person. However, forwarding emails may cause issues with the formatting or functionality of email content. Put simply, emails often break when they're forwarded.

### Why email forwarding causes issues with email content

Different email clients (web and desktop versions of clients like Gmail, Yahoo, and Outlook) render emails differently. Forwarded emails also render differently, depending on the client they're sent from. Depending on the client, forwarding can strip some HTML elements or insert technical blocks into the HTML code of the email. The modified elements can change the look of the email or even block the functionality.

### How to avoid content issues with forwarded emails

Unfortunately, as a sender and email designer, there isn't much you can do to predict the behavior of every email client that your subscribers use. As such, it's impossible to avoid all changes that could result from email forwarding. However, if you're aware that your subscribers or recipients regularly forward your marketing emails, the following are some recommendations to reduce forwarding-related errors:

- Keep your email design simple. Use a single–column design with few separate elements. This reduces the possibility of design-related HTML errors when forwarding the email.
- Tell your recipients to forward your emails as an attachment. This approach increases the chances that original email will keep its design and elements untouched.
- Some web-based email clients offer alternative ways to share emails without touching the email code. This approach usually doesn't make a “classic” forward, but sends an original email on your behalf to the intended recipient or shares it through social networks.

## Reply-to addresses

When you send an email and your recipient wants to reply to your email, the reply email is usually sent to the email address listed in the "From:" header. The reply-to address is a special address (specified in the "Reply-To:" header) that provides an email address where replies to a message should go if the address is different from a regular "From:" address.

The "Reply-To:" header is ignored, however, in the case of automatic responses. As detailed in [RFC3834](https://datatracker.ietf.org/doc/html/rfc3834), automatic responses should always be sent to the address specified in the "From:" header. In such a scenario, the "Reply-To:" header is ignored.

Only manual replies (when the recipient selects the “Reply” button) are sent to the "Reply-To:" address.

[!INCLUDE[footer-include](../includes/footer-banner.md)]