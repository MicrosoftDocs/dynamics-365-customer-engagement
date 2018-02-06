---
title: "Maximize email deliverability (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to design and send marketing email messages that avoid spam filters and get opened by customers in Dynamics 365 for Marketing"
keywords: "administration; spam; deliverability; SPF; best practice"
ms.date: 12/15/2017
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: d6e63962-e06a-4bc2-90d2-e7bca4e12d61
author: kamaybac
ms.author: kamaybac
robots: noindex,nofollow
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Best practices for email marketing

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Sending marketing email is not the same as sending personal email as most people know it. They might seem similar, but the difference is actually obvious: personal emails get delivered to just one or a few people, whereas marketing emails get delivered to many thousands or more every month.

In response to various email abuses, such as widely targeted spam and scams, most companies and email providers now implement filtering and blocking mechanisms to defend their bandwidth and keep their users' inboxes clean. So, when somebody begins sending a large volume of email, the internet takes notice and defensive mechanisms might begin to kick in, which might result in keeping your messages out of your contacts' inboxes. These systems are not intended to stop all forms of legitimate marketing email, just to block abuse. [!INCLUDE[pn-ms-dyn-365](../includes/pn-ms-dyn-365.md)] is designed to be one of the good guys—to facilitate collaborative, opt-in marketing—but you do need to be aware of how to work in the context of common anti-spam laws and other anti-abuse mechanisms to help make sure your marketing messages get delivered to your contacts rather than stuck in their spam filters.

## Building and protecting your sender reputation

When a message goes out over the internet, the IP address that sent it is available to each server that processes that message. Third-party watchdog organizations, such as ReturnPath, monitor activity, message content, and complaints associated with sending addresses and generate a reputation score for each sending IP. The lower your reputation score, the more likely your messages are to get dropped or filtered out; if your score gets low enough, you'll end up on a block list and none of your messages will get delivered.

In addition to send reputation, many countries and regions have laws that regulate commercial email messages, and breaking these laws can expose you to expensive litigation. Examples of these include CAN-SPAM in the United States and CASL in Canada.

So what can you do to maximize your deliverability and remain within the law, and how can [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] help? Here are a few of the most important factors for building and maintaining a good sender score:

- **Create clean, collaborative, and responsible content**  
    Both spam filters and sender-reputation systems analyze the content of the messages you are trying to send. They look for signs that you are working together with your recipients and are identifying yourself honestly. Common requirements here are the presence of unsubscribe links and your organization's physical street address in the message body. Messages in HTML format should also include a plain-text version that has the same information. [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] provides features to make it easy to include these essential items in your messages, and helps prevent you from leaving them out by mistake. Other types of content to avoid include overuse of exclamation points (especially in the subject), all-caps text, "buy now" buttons, body text hidden in bitmaps, and certain hot-button terms. You know what spam looks like—don't look like that!
- **Authenticate your messages and sending IP**  
    Several standards are in place to help ensure that sending IP addresses really do represent the organizations they claim to, and that messages coming from those IPs are authentic and untampered with. These include sender policy framework (SPF), SenderID, and DomainKeys Identified Mail (DKIM). [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] does what it can to maintain a good sender reputation and to sign and authenticate messages sent from our servers, but you can also improve deliverability by associating your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] sending IPs with your organization's domain name in the DNS system (as described in the next section).
- **Avoid sending to invalid email addresses**  
    If you send a message to an invalid or canceled email address, the message is typically returned as what is called a "hard bounce." Hard bounces happen, but the reputation watchdogs will notice, and the more hard bounces you have associated with your sending IP, the lower your reputation score will be. Addresses associated with a hard bounce will probably never come back online, so you don't want them in your database; [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] will automatically stop sending to addresses that report a hard bounce and can optionally purge them from your database. [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] needs to defend the reputation of our sending IPs, so organizations that consistently generate a large number of hard bounces might be placed into a higher-risk sending pool or might even eventually have their accounts closed.
- **Send consistent volumes**  
    High-scoring sender reputations are associated with IP addresses that send a consistent volume of email. A sudden spike will lower the score, as will intermittent send volumes. [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] maintains several pools of IP addresses dedicated to sending messages from [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], and might share these between customers with similar reputation scores. This means that we can distribute email sends across our pools and thereby ensure a roughly consistent send volume for each IP. Each time we add a new address to a pool, we "warm it up" by gradually increasing the volume it sends until it eventually reaches the same level as the other IPs in its pool. For most [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] subscribers this is handled automatically and invisibly, but new subscribers who plan to send marketing messages to very large numbers of recipients (in the millions) might need to start small and ramp up over time before reaching full volume; in this case, [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] support will notify you and help you during this process.

For more information about deliverability and sender reputation, search with [!INCLUDE[pn-bing](../includes/pn-bing.md)] for many more good articles about this topic.

## Improve your deliverability with SPF

As mentioned previously, one way to improve your email deliverability is to use the Sender Policy Framework (SPF) to link your organization's domain name with the sending IPs used by [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] in the DNS system. This will ensure that spam filters and reputation watchdogs will be able to see that the IP address sending your message is a legitimate sender for the domain name shown in the From address. This step is not strictly required, but it is highly recommended because it should dramatically improve your deliverability rates.

To enable this, you must contact your domain-name registrar and tell them which IP addresses or domains you want to authenticate as legitimate senders for your domain. Some registrars might have an online form that lets you do this yourself; if you are not sure how, contact your registrar for assistance. You'll need to provide the sending IPs that [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] uses to send marketing email messages; please contact [!INCLUDE[pn-microsoft-support](../includes/pn-microsoft-support.md)] for the latest list of these for various locations.

You might also have heard about a related technology called DomainKeys Identified Mail (DKIM), which is used to authenticate and sign messages by using encryption keys. [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] has already set this up for our sending domains, so your organization will automatically benefit from this technology. (However, you need to set up your own custom DKIM keys if you decide to use a dedicated IP, as mentioned in the next section.)

## Using a custom, dedicated sender IP

In a standard [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] setup, all sender IPs are managed by [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] and shared among customers that have similar reputation scores. This lets us manage reputation, balance the send load, and warm up new IPs as needed. However, some organizations prefer to use their own, dedicated sender IP, especially if they will be sending very high volumes.

> [!NOTE]
> Dedicated sender IPs are not part of the standard [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] subscription agreement, and [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] does not generally recommend them because they introduce extra complexity and expense—and can result reduced deliverability compared to our standard sender IP pools. [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] considers applications for dedicated sender IPs on a case-by-case basis. If you think your organization could benefit from a dedicated sender IP, please contact your [!INCLUDE[pn-microsoft-support](../includes/pn-microsoft-support.md)] representative to find out if you qualify.


Though there can be a few advantages to arranging for a dedicated sender IP, there are also disadvantages, and it is not for everyone. Consider the following:

- **A new sender IP requires time to warm up**  
    When your new sender IP comes online, you must start by sending just a few messages at a time and then slowly ramp up over several weeks until you reach your intended send volume, which you must then continue to maintain. A sudden spike of email coming from a new IP will severely damage your send reputation and might land you on a block list right away.
- **Maintain a regular and consistent send volume**  
    You must spread out your email sends to ensure that you send roughly the same volume every week or so. Don't try to send all your messages at once at the start of each month, for example.
- **You should set up your own DKIM keys**  
    As mentioned in the previous section, DKIM technology lets email servers authenticate the sender and signed content of your messages. In a standard, shared-IP scenario, [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] handles this for you, but if you are using a private IP, you must coordinate with [!INCLUDE[pn-microsoft-support](../includes/pn-microsoft-support.md)] to get these encryption keys registered and in place. Doing this is likely to greatly improve your message deliverability.
- **You concentrate risk on yourself and can pay a high price for any mistakes**  
    When you are the only one using your sending IP, any mistakes you make will affect your sender reputation directly, without being diluted by the large volume of compliant messages being sent by a large pool of other users.

### See also

[Create a marketing email and go live](create-marketing-email.md)  
[Prepare marketing email messages](prepare-marketing-emails.md)