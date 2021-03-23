---
title: "Deliverability recommendations when changing ESPs (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn about recommendations when changing your email service provider (ESP) in Dynamics 365 Marketing."
ms.date: 03/10/2021
ms.service: dynamics-365-marketing
ms.custom: 
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

# Deliverability recommendations when changing ESPs

Changing your email service provider (ESP) is a complex and sensitive process. Errors during the changeover process can negatively impact deliverability, resulting in reduced engagement.

To mitigate risks, we’ve assembled a list of recommendations to follow when switching ESPs. Following these steps will help safeguard your email deliverability and maintain a good sending reputation.

1. **Data migration**

    Migrate all necessary data. This data includes email addresses, contacts, customized templates, mail flows, and email automation. Don’t forget to ensure that not only the active data is transferred, but also the suppression data. Unsubscribed users, hard bounced addresses, and spam complaint addresses need to be migrated.

1. **Deliverability**

    Authenticate your sending domain. This is pretty much the first thing you're going to be doing.

    > [!TIP]
    > Consider using the same sending email address, even the same from address.

1. **Get to know your new ESP**

    We strongly recommend reaching out to our [Email Deliverability team](mailto:dynmktdeliverability@microsoft.com). A short conversation about your business, volume targets, and your expectations will ensure a smooth transition.

1. **Warm up your new ESP**

    > [!TIP]
    > Gradually increase send volumes.

    Suddenly sending a large volume of emails from a new IP can lead to rejected emails. This is because your Internet Service Provider (ISP) may view the activity as suspicious.

    Be prepared for a few little bumps in your metrics. Large ISPs like Gmail, Yahoo, and Microsoft may need time to adjust their metrics as they update their records regarding current and previous interactions with your mail or domain.

## Checklist for switching ESPs

**Before you move**:

- Review your subscription methods to see where your subscribers come from so you can redirect subscription sources.
- Review what’s not working (templates, mobile optimization, metrics) and optimize.
- Export your email lists and reports.
- Review your engagement lists.
- Plan a gradual transition.

**Before you send the first campaign**:

- Create a suppression list with unsubscribed and bounced email addresses.
- Set up segments.
- Check and update your signup forms.
- Set up authentication to improve deliverability.
- Consider keeping your “from” name consistent.

**After the first campaign:**

- Analyze the campaign insights.

## More help

Contact our [support team](troubleshoot-faq.md#where-can-i-find-help-for-errors-unexpected-behavior-crashes-or-bugs) if you have any questions.

### See also

[Best practices for email marketing](get-ready-email-marketing.md)  
[Email policies and suspension standards](email-policies.md)  