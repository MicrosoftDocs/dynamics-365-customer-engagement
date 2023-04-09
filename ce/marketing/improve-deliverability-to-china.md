---
title: "Improve email deliverability to China (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to improve email deliverability to China in Dynamics 365 Marketing."
ms.date: 07/17/2021

ms.custom:
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Improve email deliverability to China

If you are sending email to China, it will be subjected to stricter email filtering than any other country in the world. This could result in email delays, delivered emails with unclickable links, or flat-out non-deliverability.

Making sure your marketing emails to China are delivered is crucial. China has vast opportunities to win customers (assuming you can reach them). Consumers show less brand loyalty in China than in most other countries, tending to look for the best deal unless they are shopping for high-end products.

Below you will find tips and tricks on how to boost your deliverability when targeting customers behind China-based ISPs.

## Chinese email market landscape

Local providers dominate the Chinese email landscape.

Largest ISPs (mailbox providers):

- NetEase
- QQ Mail
- Sina Mail
- Sohu Mail

Other providers include:

- 263.com
- 189.com
- 139 Mail
- AliCloud
- 188.com
- TOM Mail

## Email best practices for China

### Consent

- Obtain explicit consent from all Chinese subscribers and keep a record of when and through what method permission was obtained.

### Content

- Avoid commonly filtered content:
    - Political and religious content is sensitive. Avoid this content or risk damaging your sending reputation.
    - Refrain from using generic salutations, such as “Dear Friend.” You should, however, consider using a first name to personalize your greeting.
    - Avoid adult content, including pornography or ads for pornography, gambling, tobacco, and illegal drugs (alcohol is permissible).
    - Avoid anything that “compromises State security, discloses State secrets, subverts State power or damages national unity” or “other content prohibited by laws or administrative regulations.”

- Font size
    - In terms of deliverability, font size matters. Anything below a 10-point font can be interpreted as an attempt to hide additional content, thereby exposing the content to additional filtering.

- Language
    - Send as many emails as possible to China in Chinese. Sending content in English can be flagged by content filtering services.

- List hygiene
    - China is known for its high attrition rates when it comes to email lists. If an email address does not interact with (open or click) an email after two to three sends, it may be abandoned. Continuing to mail to this type of email address can adversely affect your sending reputation and subject you to further filtering.

- Email flows
    - Segment mail streams (such as transactional and marketing emails) into different "From" addresses.

- HTML recommendations
    - Avoid coding your HTML email template using CSS. Many email service providers will strip it out. Use traditional `<font>` and `<table>` tags instead.
    - Avoid dark background colors with light font colors.
    - Do not exceed your email template width of 600 pixels. Bigger pixel width templates will not fit the email preview pane.
    - Always use alt and title text. It's likely that your images may not load; be sure to apply both alt and title text behind the images so that these texts display when this happens.
    - Limit use of images to no more than 40 percent of your email template. Remember, most email service providers won't allow images to load.
    - Use mobile friendly content design due to the large number of mobile users in China. Most of the population accesses the internet on smartphones or tablets.

- Subject line
    - Label your promotional messages as “AD” in the subject line.
    - Limit subject lines to fewer than 35 characters.

- Sending limits
    - Expect delivery delays. Chinese mailbox providers have slower processing speeds than other ISPs. Many Chinese mailbox providers impose daily sending limits and vary them based on a sender's subscriber engagement metrics.
    - Microsoft Dynamics 365 has internal outgoing limits that are constantly adjusted based on feedback received.
    - Avoid sending large segments through customer journeys. It’s  better to split your journey into small segments and spread the sending over multiple days.

## How do I check if I am blocklisted in China?

The following URL can be useful depending on your target ISP: http://www.blockedinchina.net/. Be sure to check domains and subdomains.

> [!IMPORTANT]
> Being blocklisted is usually temporary. The length can vary depending on your past history. Delisting is usually not possible. Follow the best practice tips in this article to improve your sending reputation.
