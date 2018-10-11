---
title: "Maximize email deliverability (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to design and send marketing email messages that avoid spam filters and get opened by customers in Dynamics 365 for Marketing"
keywords: "administration; spam; deliverability; SPF; best practice"
ms.date: 10/01/2018
ms.service: 
  - "dynamics-365-marketing"
ms.custom: 
  - "dyn365-marketing"
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: d6e63962-e06a-4bc2-90d2-e7bca4e12d61
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Best practices for email marketing

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

Sending marketing email is not the same as sending personal email as most people know it. They might seem similar, but there is an important difference: personal emails get delivered to just one or a few people, whereas marketing emails get delivered to many thousands or more every month.

In response to various email abuses, such as widely targeted spam and scams, most companies and email providers now implement filtering and blocking mechanisms to defend their bandwidth and keep their users' inboxes clean. So, when somebody begins sending a large volume of email, the internet takes notice and defensive mechanisms might begin to kick in, which might result in keeping your messages out of your contacts' inboxes. Individual email clients also apply their own filtering algorithms that, among other things, can filter based on each user's personal history of interactions, which can mean that an identical message that gets delivered to one recipient could get blocked by another recipient's email client.

These systems are not intended to stop all forms of legitimate marketing email, just to block abuse. [!INCLUDE[pn-ms-dyn-365](../includes/pn-ms-dyn-365.md)] is designed to be one of the good guys—to facilitate collaborative, opt-in marketing—but you do need to be aware of how to work in the context of common filtering strategies, anti-spam laws and other anti-abuse mechanisms to help make sure your marketing messages get delivered to your contacts rather than stuck in their spam filters.

## Building and protecting your sender reputation

When a message goes out over the internet, the IP address that sent it is available to each server that processes that message. Third-party watchdog organizations, such as ReturnPath, monitor activity, message content, and complaints associated with sending addresses and generate a reputation score for each sending IP address and/or domain name. The lower your reputation score, the more likely your messages are to get dropped or filtered out; if your score gets low enough, you'll end up on a block list and none of your messages will get delivered.

Large email providers (such as Hotmail or Gmail), and private email systems at large organizations, use similar techniques to generate their own, internal, sender reputations and scores, which apply yet another layer of filtering.

In addition to send  reputation, many countries and regions have laws that regulate commercial email messages, and breaking these laws can expose you to expensive litigation . Examples of these include CAN-SPAM in the United States and CASL in Canada. The new [GDPR regulations](gdpr.md) in the European Union also establish strict rules for how companies are permitted to handle data and communicate digitally with individuals.

So what can you do to maximize your deliverability and remain within the law, and how can [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] help? Here are a few of the most important factors for building and maintaining a good sender score:

- **Create clean, collaborative, and responsible content**  
    Both spam filters and sender-reputation systems analyze the content of the messages you are trying to send. They look for signs that you are working together with your recipients and are identifying yourself honestly. Common requirements here are the presence of unsubscribe links and your organization's physical street address in the message body. Messages in HTML format should also include a plain-text version that has the same information. [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] provides features to make it easy to include these essential items in your messages, and helps prevent you from leaving them out by mistake.
- **Authenticate your messages, sending IP, and domain**  
    Several standards are in place to help ensure that sending IP addresses really do represent the organizations they claim to, and that messages coming from those IPs are authentic and untampered with. These include _Sender Policy Framework_ ([SPF](http://www.openspf.org/FAQ)) and _DomainKeys Identified Mail_ ([DKIM](http://dkim.org/info/dkim-faq.html)). In a standard setup, [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] implements both of these technologies for you, and does what it can to maintain a good sender reputation for all [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] sender IPs.  
    > [!IMPORTANT]
    > If you are already using DMARC to authenticate messages sent from your domains, then contact [!INCLUDE[pn-microsoft-support](../includes/pn-microsoft-support.md)] to get help setting it up to authenticate messages sent on your behalf by [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. This is very important because if you don't integrate [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] into your DMARC configuration, your marketing emails are very likely to be labelled as junk and removed from inboxes by many private domains and most large email providers including Gmail and Outlook.com. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Work with Microsoft Support if you use, or want to use, DMARC](#dmarc)
- **Avoid sending to invalid and inactive email addresses**  
    If you send a message to an invalid, inactive, or canceled email address, the message is typically returned as what is called a "hard bounce." Hard bounces happen, but the reputation watchdogs, public providers, and private hosts  will notice, and the more hard bounces you have associated with your sending IP, the lower your reputation score will be. Addresses associated with a hard bounce will probably never come back online, so you don't want them in your database; [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] will automatically stop sending to hard-bouncing addresses for six months before trying them again. [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] needs to defend the reputation of our sending IPs, so organizations that consistently generate a large number of hard bounces might be placed into a higher-risk sending pool or might even eventually have their accounts closed.
- **Send consistent volumes**  
    High-scoring sender reputations are associated with IP addresses that send a consistent volume of email. A sudden spike will lower the score, as will intermittent send volumes. [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] maintains several pools of IP addresses dedicated to sending messages from [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], and might share these between customers with similar reputation scores. This means that we can distribute email sends across our pools and thereby ensure a roughly consistent send volume for each IP. Each time we add a new address to a pool, we "warm it up" by gradually increasing the volume it sends until it eventually reaches the same level as the other IPs in its pool. For most [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] subscribers this is handled automatically and invisibly, but new subscribers who plan to send marketing messages to very large numbers of recipients (in the millions) might need to start small and ramp up over time before reaching full volume; in this case, [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] support will notify you and help you during this process.

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] provides detailed analytics and KPIs for how your contacts interact with your marketing email messages (and other initiatives), including counts of opens, clicks, bounces, and forwards. Use this information to evaluate your success in engaging contacts and to keep your database free of hard-bouncing addresses. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Analyze results to gain insights](insights.md)

For more information about deliverability and sender reputation, search with [!INCLUDE[pn-bing](../includes/pn-bing.md)] for many more good articles about this topic.

<a name="dmarc"></a>

## Work with Microsoft Support if you use, or want to use, DMARC

_Domain-based Message Authentication, Reporting and Conformance_ ([DMARC](https://dmarc.org/wiki/FAQ)) is a standard that helps email recipients confirm that messages claiming to come from one of your email domains actually came from your organization. This standard helps ensure the authenticity of both your organization's day-to-day email messages and messages sent on your behalf by [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. As a result, your messages are much more likely to get through, rather than get flagged as junk. We therefore recommend that all organizations set up DMARC for their domains, including the sending domains used by [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

DMARC builds on the SPF and DKIM standards that [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] normally sets up for you on your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] sending domains. However, if you would also like to use DMARC (or if you are already using it on your other sending domains), then you must [contact Microsoft Support](../admin/contact-technical-support.md) for assistance with setting it up for [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]. [!INCLUDE[pn-microsoft-support](../includes/pn-microsoft-support.md)] will assist you by doing the following:

- Generate a DKIM key pair for you.
- Provide you with a value that you must add as a TXT record on your domain.
- Enable custom domain DKIM signing for you.

DMARC requires you to have either your own envelope domain or your own DKIM signing domain. It's best to have both to minimize false positives during a DMARC check by the receiving party.

> [!IMPORTANT]
> If are using DMARC but fail to integrate [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] into your DMARC configuration, your marketing emails are very likely to be labelled as junk and removed from inboxes by many private domains and most large email providers including Gmail and Outlook.com.

## Test your deliverability

Once you have all of the relevant email-authentication systems in place, we highly recommend that you test your deliverability to all of the major email hosts (such as Gmail, Outlook.com, Yahoo mail, and more), and to as many private domains as your can (including your own). To do this:

1. Set up an email account that you can read on as many services and domains as you can.
1. Set up a contact record for each of these addresses in [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)].
1. Run a [simple email campaign](create-simple-customer-journey.md) that targets all of your test contacts.
1. Inspect the inbox for each account to confirm your messages arrive in the inbox and don't get labelled as junk.

## Using a custom, dedicated sender IP

In a standard [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] setup, all sender IPs are managed by [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] and shared among customers that have similar reputation scores. This lets us manage reputation, balance the send load, and warm up new IPs as needed. However, some organizations prefer to use one or more of their own, dedicated sender IPs, especially if they will be sending very high volumes.

> [!NOTE]
> Dedicated sender IPs are not part of the standard [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] subscription agreement, and [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] does not generally recommend them because they introduce extra complexity and expense—and can result reduced deliverability compared to our standard sender IP pools. [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] considers applications for dedicated sender IPs on a case-by-case basis, and we can support multiple dedicated sender IPs if needed. If you think your organization could benefit from a dedicated sender IP, please [contact Microsoft Support](../admin/contact-technical-support.md) to find out if you qualify. The main goal of this process is to help you achieve as high a delivery rate as possible. Some of the most important factors to consider when making this decision include:
> 
> - How many messages does your organization send each month?
> - Is your content of high quality and in compliance with all relevant regulations?
> - Have there been many spam complaints associated with your messages until now?
> - Does your organization send a consistent volume of messages throughout the month?

Though there can be a few advantages to arranging for a dedicated sender IP, there are also disadvantages, and it is not for everyone. Consider the following:

- **A new sender IP requires time to warm up**  
    When your new sender IP comes online, you must start by sending just a few messages at a time and then slowly ramp up over several weeks until you reach your intended send volume, which you must then continue to maintain. A sudden spike of email coming from a new IP will severely damage your send reputation and might land you on a block list right away. During the warm-up period, it is also important that you only send to valid and engaged recipients. Later, when you have established a reputation, you can begin to add less-engaged recipients.
- **Maintain a regular and consistent send volume**  
    You must spread out your email sends to ensure that you send roughly the same volume every week or so. Don't try to send all your messages at once at the start of each month, for example.
- **You should set up sender authentication for your domain**  
    As mentioned previously, Microsoft sets up the [SPF](http://www.openspf.org/FAQ) and [DKIM](http://dkim.org/info/dkim-faq.html) sender-authentication standards for all of the sender IPs that we use in a standard solution, but when you use your own sender IP, you must do this yourself. You should also consider setting up [DMARC](https://dmarc.org/wiki/FAQ), which builds on these two standards. These technologies help ensure that spam filters and reputation watchdogs will be able to see that each IP address sending your messages is a legitimate sender and that it matches your envelope sender domain. Doing this is likely to greatly improve your message deliverability. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Work with Microsoft Support if you use, or want to use, DMARC](#dmarc)
- **You concentrate risk on yourself and can pay a high price for any mistakes**  
    When you are the only one using your sending IP, any mistakes you make will affect your sender reputation directly, without being diluted by the large volume of compliant messages being sent by a large pool of other users.

### See also

[Create a marketing email and go live](create-marketing-email.md)  
[Prepare marketing email messages](prepare-marketing-emails.md)
