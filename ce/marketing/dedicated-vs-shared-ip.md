---
title: "Dedicated vs shared IPs for email delivery (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn whether a dedicated or a shared IP address is best for email delivery in your Dynamics 365 Marketing implementation."
ms.date: 10/08/2020
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

# Dedicated vs shared IPs for email delivery

Every email you send is routed through an IP address that transports your message to your subscribers' inboxes. By default, Dynamics 365 sends emails from a group of shared IPs. Our Deliverability and Compliance team monitors the health and performance of these IPs. We recommend that you use the default shared IP email setup for optimized email deliverability.

Some senders, however, might prefer to send emails through a dedicated IP address. Whether a dedicated IP address is best for your Marketing setup depends on many factors. The first step in deciding which setup is best for you is understanding the differences between dedicated and shared IPs.

## Definitions and pros and cons of different IP setups

### Definitions

**Shared IP**: Multiple senders use the same IP pool (multiple shared IPs). This is the default Dynamics 365 approach.<br>
**Dedicated IP**: A single IP address that is used by a single sender.

### Pros and cons of dedicated vs shared IPs

| IP type | Pros | Cons |
|-|-|-|
| Dedicated IP | - Full reputation control<br>- More easily pinpoint and fix IP issues | - Strict "warm-up" plan needs to be followed<br>- Any mistakes immediately damage the IP reputation<br>- Sending schedule and volume need to be consistent (no spikes or delays between customer journeys)<br>- Data quality must be good |
| Shared IP | - Avoid the need to "warm up" your IPs<br>- Benefit from other senders' good reputations<br>- Decreased risk of damaging the IP reputation<br>- Works well for inconsistent senders (spikes in sending volumes and unpredictable sending schedule) | - Deliverability can be affected by other senders<br>- No IP reputation control |

## Dedicated IP prerequisites

### Volume and frequency

To sustain a dedicated IP, you'll need to send enough volume to maintain it. We recommend that you send a minimum of 50,000 messages, 3 times per week (150,000 messages per week total).

### List quality

Carefully review you email practices, list quality, list hygiene, and list acquisition process. We strongly recommend using a double opt-in process and targeting only engaged recipients. Engaged recipients are typically those who have interacted with your emails in the past six months.

Also, review your sending stats and make sure that you comply with the following thresholds:

- Bounce rate: < 3%
- Spam complaint rate: < 0.1%
- Unsubscribe rate: < 1%

### Warm-up

When you add a new dedicated IP address to your account, you need to warm it up. You will also need to re-warm your IP if you haven't sent any emails in the last  30 days.

IP warming is the practice of gradually increasing the volume of mail sent through a dedicated IP address according to a predetermined schedule. This gradual process establishes a reputation with ISPs (Internet Service Providers) as a legitimate email sender.

When an ISP observes email suddenly coming from a new or "cold" IP address, they will take notice and immediately begin evaluating the traffic coming from that IP. Because ISPs treat email volume as a key determining factor when detecting spam, it is best to begin sending a low to moderate volume, eventually working your way up to larger volumes. This gives the receiving email providers a chance to closely observe your sending habits and record how your recipients engage with your email.

A gradual warm-up does not always guarantee a perfect sending reputation. It is still important to follow sending best practices. The warm-up process can take two to four weeks, depending on the list quality.

Reach out to our Deliverability and Compliance team if you need help with navigating this delicate process.

### See also

[Best practices for email marketing](get-ready-email-marketing.md)  
[Email policies and suspension standards](email-policies.md)  
[Email bounce categories](email-bounce-categories.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]