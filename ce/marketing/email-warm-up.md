---
title: "Warm up an IP or domain (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to warm up an IP or a domain for use with Dynamics 365 Marketing."
ms.date: 03/10/2021
ms.service: dynamics-365-marketing
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

# Warm up an IP or domain

### IP/domain warm-up definition

IP/domain warming is the process of methodically adding email volume to a new IP address, gradually, over several days or weeks. Gradually “warming” up the IP/domain establishes a positive sending reputation with mailbox providers.

### IP/domain warm-up summary

Mailbox providers view email from a new IP address as suspicious until the new address establishes a positive sending reputation. Achieving maximum deliverability takes four to eight weeks, depending on targeted volume and engagement. Warming could take longer if mailbox providers don’t perceive that email from the new IP/domain is "wanted" by the recipient. For example, the mailbox provider may determine that email is not wanted if the recipient has not explicitly signed up for the mailing list. Certain mailbox providers limit senders to thresholds (the number of messages delivered per day) until they establish a reputation.

We recommend starting with your best performing messages – those sent to highly engaged recipients. Focus warming your most engaged subscribers, then add older segments as you progress. Older segments should be added to the engaged segments in chunks of 15 percent of your existing volume, so as to not tip your reputation from good to bad. The goal during the warm-up process is to send to subscribers who are the least likely to complain and bounce. Such subscribers include those that have opted-in most recently and are consistent openers and clickers.

During the warm-up phase, the more consistent you are with volume, frequency, complaint, and bounce levels, the faster you will establish a positive sending reputation. If you send infrequently (anything less than weekly), it will take longer to build a positive sender reputation.

### IP/domain warm-up plan

**Key to success**

- During weeks 1-2, send to your most active subscribers – those who have opened or clicked in the past 30 days.
- During weeks 3-4, you can expand to subscribers who have opened or clicked in the past 60 days.
- During the first 6 weeks, do NOT send to subscribers who have not opened or clicked in the past 90 days.

**What to Expect**

Once you begin warming up your IPs, you can expect some bulking (mailbox providers identifying marketing emails as spam) and blocking to occur. The key is to stick with the plan. Below are details of what you can expect and actions to take.

- **Bulking** at Yahoo, AOL, and Gmail. Typically clears up after a few sends with solid positive metrics, but it can take time to get inbox delivery. *The key is to keep sending to engaged subscribers.*
- **Delays** at AOL, Microsoft, and Comcast. The delays (421 bounces) will retry for 72 hours, and, if not delivered, will bounce as a 5XX with the original 421 error in the bounce record. *Delays are normal and will lessen each day as the IP or domain’s reputation develops. So long as the emails are ultimately delivering, there is no concern.* However, if emails are timing out in large quantities, you should back down your volumes to the mailbox provider by tightening your engagement window (the time since a recipient last interacted with one of your emails).
- Possible **blocking** by mailbox providers can occur if the list isn’t engaged enough. The key is to segment carefully and tighten up engagement. *Again, the key is to keep sending.*

### Why is IP or domain warm-up important?

| Quick warm-up:                                  | Slow warm-up:                                                                                                               |
|-------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------|
| Mailbox providers see volume spikes             | Mailbox providers see a gradual build in volume                                                                             |
| Unknown senders                                 | A good reputation develops over time                                                                                        |
| Blocks, filtering, and rate limiting will occur | Blocks, filtering, and rate limiting rarely occurs (only occurs when engagement rates are low and complaint rates are high) |

### IP warm-up builds your sender reputation

Sender reputation is how mailbox providers view you and your mail.

- Email reputation controls access to the inbox
    - Bad reputation = spam folder or blocks
    - Good reputation = inbox
- Reputation can affect the domain or IP address and will be based on:
    - Spam complaints
    - Invalid email addresses (hard bounces)
    - Spam trap hits
    - Authentication (SPF, DKIM, DMARC)
    - Third-party block listing
    - Engagement

| Positive effects on your reputation are: | Negative effects on your reputation are:        |
|------------------------------------------|-------------------------------------------------|
| Opens                                    | Poor or insufficient permission                 |
| Clicks                                   | High recipient complaints (report as spam)      |
| Authentication (DKIM, SPF, DMARC)        | Poor list quality/hygiene (bad email addresses) |
|                                          | IP address and domain block listing             |
|                                          | Spam trap hits                                  |
|                                          | Large spikes in volume                          |

### The fundamentals of reputation

**Key takeaways**:

- Opt-ins are the most important.
- If people do not want your mail, your reputation suffers.
- Mailbox providers and metrics are judge and jury when it comes to getting delivered to the inbox.
- You cannot transfer your reputation from your previously used IP.
- If you use the same domain, your reputation can follow you. However, mailbox providers like Gmail use the reputation of the domain coupled with the reputation of the IP, therefore, you still must follow the warm-up process.
- Mailbox providers trust metrics from their users and what they observe; no brand will get special treatment.
- B2B senders must follow the same warm-up process as B2C senders, as many business domains are now hosted by Yahoo, Outlook, Gmail, AOL, etc.

### See also

[Best practices for email marketing](get-ready-email-marketing.md)  
[Email policies and suspension standards](email-policies.md)  