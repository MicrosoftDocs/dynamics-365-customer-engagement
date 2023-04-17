---
title: "Warmup process for marketing senders (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to warmup process for marketing senders in Dynamics 365 Marketing."
ms.date: 04/17/2023
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

# Warmup process for marketing senders

## Warm-up definition
Domain warming is the process of methodically adding email volume to a new domain over several days or weeks. Gradually “warming” up the domain establishes a positive sending reputation with mailbox providers.

Whether you use shared or dedicated IP addresses, the warmup process is initial and crucial for every sender. Warming up your domain together with your ESP’s IP addresses is crucial, whether you use a brand new (with 0 reputation) or already used domain (with good reputation) for your email campaigns.

Warmup is critical for senders who plan to use brand new domains and send large volumes of emails in their Customer Journeys (up to 500k emails per day/CJ).

## Warm-up summary
Mailbox providers view email from a new domain as suspicious until the new address establishes a positive sending reputation. Achieving maximum deliverability takes four to eight weeks, depending on targeted volume and engagement. Warming could take longer if mailbox providers don't perceive that email from the new domain is "wanted" by the recipient. For example, the mailbox provider may determine that email isn't wanted if the recipient hasn't explicitly signed up for the mailing list. Certain mailbox providers limit senders to thresholds (the number of messages delivered per day) until they establish a reputation.

We recommend starting with your best performing messages – those sent to highly engaged recipients. Focus warming your most engaged subscribers, then add older segments as you progress. Avoid tipping your reputation from good to bad by adding older segments to the engaged segments in chunks of 15 percent of your existing volume. The goal during the warm-up process is to send to subscribers who are the least likely to complain and bounce. These subscribers comprise the most recent opt-ins and regular opens and clickers.

During the warm-up phase, the more consistent you are with volume, frequency, complaint, and bounce levels, the faster you establish a positive sending reputation. If you send infrequently (anything less than weekly), it takes longer to build a positive sender reputation.

## Warm-up plan
### Key to success
- During weeks 1-2, send to your most active subscribers – those who have opened or clicked in the past 30 days.
- During weeks 3-4, expand your reach to subscribers who have opened or clicked in the past 60 days.
- During the first six weeks, don't send it to subscribers who haven't opened or clicked in the past 90 days.

### What to Expect
As the warm-up process begins, expect some bulking (mailbox providers identifying marketing emails as spam) and blocking. The key is to stick with the plan. Below are details of what you can expect and actions to take.
- **Bulking** at Yahoo, AOL, and Gmail typically clears up after a few sends with solid positive metrics, but can take time to get inbox delivery. The key is to keep sending it to engaged subscribers.
- **Delays** at AOL, Microsoft, and Comcast. The delays (421 bounces) will retry for 72 hours, and, if not delivered, will bounce as a 5XX with the original 421 error in the bounce record. There's no need to be concerned as long as the emails are delivered. If emails are timed out in significant numbers, reduce your volumes to the mailbox provider by tightening your engagement window (the time since a recipient last interacted with one of your emails).
- Possible **blocking** by mailbox providers can occur if the list isn't engaged enough. The key is to segment carefully and tighten up engagement. Again, the key is to keep sending.

### Why is warm-up process important?
| No warm-up: | Warm-up: |
|---|---|
| Mailbox providers see volume spikes | Mailbox providers see a gradual build in volume |
| Unknown senders | A good reputation develops over time |
| Blocks, filtering,   and rate limiting will occur | Blocks, filtering, and rate limiting rarely occurs (only occurs when engagement rates are low and complaint rates are high) |

Warm-up builds your sender reputation.
Sender reputation is how mailbox providers view you and your mail.
- Email reputation controls access to the inbox
    - Bad reputation = spam folder or blocks
    - Good reputation = inbox
- Reputation can affect the domain or IP address and will be based on:
    - Spam complaints
    - Invalid email addresses (hard bounces)
    - Spam trap hits
    - Authentication (SPF (Sender Policy Framework), DKIM (DomainKeys Identified Mail), DMARC (Domain-based Message Authentication, Reporting and Conformance))
-    Third-party block listing
-    Engagement

| Positive effects on your reputation are: | Negative effects on your reputation are: |
|---|---|
| Opens | Poor or insufficient permission |
| Clicks | High recipient complaints (report as spam) |
| Authentication (DKIM, SPF, DMARC) | Poor list quality/hygiene (bad email addresses) |
|   | IP address and domain block listing |
|   | Spam trap hits |
|   | Large spikes in volume |

## The fundamentals of reputation
### Key takeaways:
- Opt-ins are the most important.
- If people don't want your mail, your reputation suffers.
- Mailbox providers and metrics are the judge and jury when it comes to getting delivered to the inbox.
- You can't transfer your reputation from one domain to another or from your previously used IPs to the ones you use in Dynamics Marketing.
- If you use the same domain, your reputation can follow you. However, mailbox providers like Gmail use the reputation of the domain coupled with the reputation of the IP, therefore, you still must follow the warm-up process. 
- Dynamics Marketing platform by default covers the IP part of warmup by providing you with a high reputation set of IP addresses. So, you have a good base from the start to build up reputation for your domain.
- Mailbox providers trust metrics from their users and what they observe; no brand will get special treatment.
- B2B (business-to-business commerce) senders must follow the same warm-up process as B2C (Business 2 Consumers) senders, as many business domains are now hosted by Yahoo, Outlook, Gmail, AOL, etc.

## Dedicated IP Warm-up
Some senders may demand a dedicated IP address to send emails. Several factors influence whether a dedicated IP address is ideal for your Marketing setup. 

Warming up a dedicated IP address in combination with your domain would require additional effort as the entire process gets more delicate and complex. In addition to the domain warmup, keep an eye on the dedicated IP reputation.

Furthermore, dedicated IP requires a stable email flow to keep it “warmed” and maintain its reputation at acceptable levels. It would require you to re-warm your IP if you haven't sent any emails in the last 30 days.

IP warming, like domain warmup, is the practice of gradually increasing the volume of mail delivered through a dedicated IP address on a set timetable. This continuous approach creates a reputation as a legitimate email sender with ISPs (Internet Service Providers).

When an ISP observes email suddenly from a new or "cold" IP address, they take note and immediately begin evaluating the traffic from that IP. Because ISPs treat email volume as a key determining factor when detecting spam, it's best to begin sending a low to moderate volume, eventually work your way up to larger volumes. This gives the receiving email providers a chance to closely observe your sending habits and record how your recipients engage with your email.

A gradual warm-up doesn't always guarantee a perfect sending reputation. It's still important to follow sending best practices. The warm-up process can take two to four weeks, depending on the list quality and the overall planned volumes of email traffic.

There's no general rule, numbers or standard warmup schedule to suit every sender. Every warmup plan is unique and may require additional analysis done by deliverability expert to make the process smooth and effective. It depends on several factors like overall planned daily/monthly volume of emails, target recipient IPS’s frequency of the email campaigns, type of emails(marketing/transactional) etc.

If you need assistance and help with navigating this delicate process of the warmup planning and email sending habits analysis, please reach out to our  [Deliverability and Compliance team](mailto:dynmktdeliverability@microsoft.com).

## Dedicated vs Shared IP for email delivery
### Definitions
**Shared IP**: Multiple senders use the same IP pool (multiple shared IPs (Internet Protocol)). This is the default Dynamics 365 approach.
**Dedicated IP**: A single IP address that is used by a single sender.
Pros and cons of dedicated vs shared IPs

|     <br>IP type     |     <br>Pros     |     <br>Cons     |
|---|---|---|
|    <br>Dedicated IP    |    <br>- Full reputation control<br>- More easily pinpoint and fix IP issues    |    <br>- Strict "warm-up" plan needs to be followed<br>- Any mistakes immediately damage the IP reputation<br>- Sending schedule and volume need to be consistent (no spikes or delays   between customer journeys)<br>- Data quality must be good    |
|    <br>Shared IP    |    <br>- Avoid the need to "warm up" your IPs<br>- Benefit from other senders' good reputations<br>- Decreased risk of damaging the IP reputation<br>- Works well for inconsistent senders (spikes in sending volumes and unpredictable sending schedule)    |    <br>- Deliverability can be affected by other senders<br>- No IP reputation control    |

## Dedicated IP prerequisites
### Volume and frequency
To sustain a dedicated IP, you need to send enough volume to maintain it. Maintain a minimum of 50,000 messages, three times per week (150,000 messages per week total).
### List quality
Carefully review your email practices, list quality, list hygiene, and list acquisition process. We strongly recommend using a double opt-in process and targeting only engaged recipients. Engaged recipients are typically those who have interacted with your emails in the past six months.
Also, review your sending stats and make sure that you comply with the following thresholds:
- Bounce rate: < 3%
- Spam complaint rate: < 0.1%
- Unsubscribe rate: < 1%
### How to apply
To request a dedicated IP address for your organization, please reach out to our [Deliverability and Compliance team](mailto:dynmktdeliverability@microsoft.com) that will help you evaluate if your sending strategy and if it qualifies for usage of dedicated IP addresses.
