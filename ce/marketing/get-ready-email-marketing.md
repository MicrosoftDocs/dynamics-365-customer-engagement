---
title: Maximize email deliverability (Dynamics 365 Marketing)
description: How to design and send marketing email messages that avoid spam filters and get opened by customers in Dynamics 365 Marketing.
ms.date: 04/21/2023
ms.service: dynamics-365-marketing
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

# Best practices for email marketing

[!INCLUDE[consolidated-sku-rtm-only](../includes/consolidated-sku-rtm-only.md)]

Sending marketing email isn't the same as sending personal email as most people know it. They might seem similar, but there's an important difference: personal emails get delivered to just one or a few people, whereas marketing emails get delivered to many thousands or more every month.

In response to various email abuses, such as widely targeted spam and scams, most companies and email providers now implement filtering and blocking mechanisms to defend their bandwidth and keep their users' inboxes clean. So, when somebody begins sending a large volume of email, the internet takes notice and defensive mechanisms might begin to kick in, which might result in keeping your messages out of your contacts' inboxes. Individual email clients also apply their own filtering algorithms that, among other things, can filter based on each user's personal history of interactions, which can mean that an identical message that gets delivered to one recipient could get blocked by another recipient's email client.

These systems aren't intended to stop all forms of legitimate marketing email, just to block abuse. Dynamics 365 Marketing is designed to be one of the good guys—to facilitate collaborative, opt-in marketing—but you do need to be aware of how to work in the context of common filtering strategies, anti-spam laws, and other anti-abuse mechanisms to help make sure your marketing messages get delivered to your contacts rather than stuck in their spam filters.

## Build and protect your sender reputation

When a message goes out over the internet, the IP address that sent it's available to each server that processes that message. Third-party watchdog organizations, such as ReturnPath, monitor activity, message content, and complaints associated with sending addresses and generate a reputation score for each sending IP address and/or domain name. The lower your reputation score, the more likely your messages are to get dropped or filtered out; if your score gets low enough, you'll end up on a blocklist and none of your messages will get delivered.

Large email providers (such as Hotmail or Gmail), and private email systems at large organizations, use similar techniques to generate their own, internal, sender reputations and scores, which apply yet another layer of filtering.

In addition to sender reputation, many countries and regions have laws that regulate commercial email messages, and breaking these laws can expose you to expensive litigation. Examples of these include CAN-SPAM in the United States and CASL in Canada. Other [privacy laws and regulations](privacy.md) establish strict rules for how companies are permitted to handle data and communicate digitally with individuals.

So what can you do to maximize your deliverability and remain within the law, and how can Dynamics 365 Marketing help? Read the following subsections to find out. For more information about deliverability and sender reputation, search with Bing for many more good articles about this article.

### Create clean, collaborative, and responsible content

Both spam filters and sender-reputation systems analyze the content of the messages you're trying to send. They look for signs that you're working together with your recipients and are identifying yourself honestly. Common requirements here are the presence of unsubscribe links and your organization's physical street address in the message body. Messages in HTML format should also include a plain-text version that has the same information. Dynamics 365 Marketing provides features to make it easy to include these essential items in your messages, and helps prevent you from leaving them out by mistake.

### Be mindful of the size of your HTML content

Limit the HTML content of email messages to a maximum size of 100 KB. This size limit includes all HTML text, styles, comments, and embedded graphics (but not anchored external graphics). If the HTML content exceeds 128 KB, you'll receive a size warning, but you can still go live with the email and any customer journey that includes the email.

The HTML size limit is important because email providers (such as Gmail) "clip" email messages that are above a certain size (102 KB, in Gmail's case). Instead of including the full message in a recipient's inbox, the email provider will truncate the message and include a link to view the entire message. Additionally, some spam filters scrutinize more intensely when they see large emails.

When you go live with a message, Marketing processes the HTML content to create inline styles, compress spaces, and more, so it can be hard to know the exact final size of the message. If you have a message that you suspect violates the HTML size limit, do the following:

1. Open a web browser and enter a URL of the form:   `https://<your_domain>/api/data/v9.0/msdyncrm_marketingemails(<email_id>)`  

Where:
- _&lt;your_domain&gt;_ is the root of your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] instance (such as "contoso.crm.dynamics.com").
- _&lt;email_id&gt;_ is the ID for the message you want to check. To find this ID, open the message in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] and find the value of the `id=` parameter shown in your browser's address bar.

2. Search for the value of the field "msdyncrm_emailbody" in the returned JSON.

1. Copy the value of that field into a text program that can tell you the exact size of the HTML content.

### Authenticate your sending domain

Dynamics 365 Marketing provides a feature that enables you to set up _DomainKeys Identified Mail_ ([DKIM](https://dkim.org/info/dkim-faq.html)) to link your Dynamics 365 Marketing sending domain with your own email domain. For complete details on why this is important and how to do it, see [Set up DKIM for your sending domain](#dkim).

### Avoid sending to invalid and inactive email addresses

If you send a message to an invalid, inactive, or canceled email address, the message is typically returned as what is called a "hard bounce." Hard bounces happen, but the reputation watchdogs, public providers, and private hosts  will notice, and the more hard bounces you've associated with your sending IP, the lower your reputation score will be. Addresses associated with a hard bounce will probably never come back online, so you don't want them in your database; Dynamics 365 Marketing will automatically stop sending to hard-bouncing addresses for six months before trying them again.

Microsoft needs to defend the reputation of our sending IPs, so organizations that consistently generate a large number of hard bounces and/or spam complaints may be contacted by Microsoft Support with advice for how to improve their sending lists and/or messaging. Organizations that continue to generate hard bounces and spam complaints may eventually risk having their accounts closed.

Dynamics 365 Marketing provides detailed analytics and KPIs for how your contacts interact with your marketing email messages (and other initiatives), including counts of opens, clicks, bounces, and forwards. Use this information to evaluate your success in engaging contacts and to keep your database free of hard-bouncing addresses. More information: [Analyze results to gain insights](insights.md)

> [!NOTE]
> Dynamics 365 Marketing won't try to send to a known hard-bouncing address during the six-month quarantine period. However, your email insights will still indicate a hard-bounce result for each such delivery that you have requested. These "virtual" hard bounces don't impact your sending IP reputation, but they do count against your monthly send quota in Dynamics 365 Marketing&mdash;and these addresses will be tried again after the six-month quarantine. We therefore recommend that you regularly check your results for hard bounces, and remove the hard-bouncing addresses from your contact records.

### Don't use purchased or rented mailing lists

Dynamics 365 Marketing is designed to facilitate _opt-in marketing_, in which all contacts have chosen to receive marketing messages from your organization, and can easily choose to stop doing so at any time. The app helps you build your mailing lists organically and in collaboration with your current and prospective customers by providing features such as [double opt-in](double-opt-in.md), [subscription management](set-up-subscription-center.md), and [consent-management for data privacy compliance](privacy.md). [Marketing pages](create-deploy-marketing-pages.md) and the [event website](set-up-event-portal.md) also provide avenues for new customers to join your database and sign up for mailing lists.

We strongly recommend that you don't purchase or rent mailing lists because such lists may violate data privacy consent laws and regulations and other local laws in other countries/regions. Rented and purchased lists are also ineffective because they're likely to contain many expired addresses that will hard bounce, and they're likely to contain many contacts that aren't interested in your products and who may complain about receiving unsolicited email (possibly to legal authorities); both complaints and hard bounces will lower your sending reputation, and with it, your deliverability rate.

### Send consistent volumes

High-scoring sender reputations are associated with IP addresses that send a consistent volume of email. A sudden spike will lower the score, as will intermittent send volumes. Microsoft maintains several IP addresses dedicated to sending messages from Dynamics 365 Marketing in each region, and balances the sending load among them to keep sending volume consistent over time for each IP. Each time we add a new sending IP to a region, we "warm it up" by gradually increasing the volume it sends until it eventually reaches the same level as the other IPs in that region. For most Dynamics 365 Marketing subscribers this is handled automatically and invisibly, but new subscribers who plan to send marketing messages to large numbers of recipients (in the millions) might need to start small and ramp up over time before reaching full volume; in this case, Microsoft Support will notify you and help you during this process.

<a name="dkim"></a>

## Set up DKIM for your sending domain

One of the most common online scams, also known as *phishing*, occurs when a fraudulent message pretends to come from a well-known online service or financial institution. The goal is to trick recipients into responding to the message by providing private details such as passwords or credit card numbers. One way to prevent phishing is for email recipients to authenticate the from-address for each message to confirm it really was sent from a domain that belongs to the company or organization it claims to belong to. A technology called DKIM (DomainKeys Identified Mail) helps accomplish this by incorporating the following elements:

- A public/private key signature that proves the message was sent from a server owned by a known organization.
- A central register of authenticated signatures, which enables the DNS (Domain Name System) to confirm that each signature is legitimate and that the sending domain and claimed from-address both belong to the same organization.

When you send email from Dynamics 365 Marketing, your messages come from a domain owned by Microsoft (such as `contosomarketing.onmicrosoft.com`), but the from-address will probably belong to one of your own marketing, sales, or account managers using a more well-known domain that belongs to your organization (such as `you@contoso.com`). This discrepancy can be a red flag when an inbound email server does a DKIM check on incoming messages, which is why a full implementation of DKIM is so important for ensuring high deliverability, especially when you're using a third-party sending service like Dynamics 365 Marketing.

Dynamics 365 Marketing helps you to generate, register, and confirm DKIM keys for each of your sending domains. See [Authenticate your domains](mkt-settings-authenticate-domains.md) for instructions.

> [!IMPORTANT]
> If your organization uses _Domain-based Message Authentication, Reporting and Conformance_ ([DMARC](https://dmarc.org/wiki/FAQ)) to protect against phishing attacks involving your domain, then it's extra important that you set up DKIM for your sending domains as described in [Authenticate your domains](mkt-settings-authenticate-domains.md). This will help to prevent false positives during DMARC checks made by receiving systems.

## Test your deliverability

Once you have all of the relevant email-authentication systems in place, we highly recommend that you test your deliverability to all of the major email hosts (such as Gmail, Outlook.com, Yahoo mail, and more), and to as many private domains as your can (including your own). To do this:

1. Set up an email account that you can read on as each of as many services and domains as you can.
1. Set up a contact record for each of these addresses in Dynamics 365 Marketing.
1. Run a [simple email campaign](create-simple-customer-journey.md) that targets all of your test contacts.
1. Inspect the inbox for each account to confirm your messages arrive in the inbox and don't get labeled as junk.

## Microsoft's spam policy for email marketing

Throughout this article, we've stressed the importance of maintaining clean, opted-in send lists combined with valued content and collaborative sending behavior. These are all important aspects of building a strong sender reputation and thereby achieving high deliverability and inbox placement. Because email sent by Dynamics 365 Marketing is delivered from shared sending domains, Microsoft constantly monitors all delivery results, spam complaints, and blocklists to make sure our sending domains maintain their high reputation for the benefit of all customers.

To help protect you, the responsible marketer, against the behavior of bad actors beyond your control, Dynamics 365 Marketing has implemented an anti-spam policy that protects your sending reputation. Here's how it works:

### Stage 1: Inform and warn

When we notice that a Dynamics 365 Marketing environment is generating a high bounce rate or spam complaints, we'll send an email to the administrator to inform them of the issue and offer assistance in remedying the problem. If further assistance is needed, the communication will urge the administrator to contact Microsoft Support.

### Stage 2: Move to a high-risk sending pool

If the bounce rate or spam complaint problem persists for more than a few days, and if the administrator has still not contacted Microsoft Support, we'll move the Marketing environment to a high-risk sending pool. The high-risk sending pool has a lower reputation score than the standard high-deliverability sending pool.

When a Marketing environment is moved to the high-risk sending pool, we'll send an email to the administrator to inform them of the sending pool change and to urge them to contact Microsoft Support for assistance. It may still be possible for the Marketing environment to return to the low-risk sending pool, but not before the administrator contacts Microsoft Support to address the issue.

## Using a dedicated sender IP

In a standard Dynamics 365 Marketing setup, all sender IPs are managed by Microsoft and shared among customers that have similar reputation scores. This lets us manage reputation, balance the send load, and warm up new IPs as needed. However, some organizations prefer to use one or more of their own, dedicated sender IPs, especially if they will be sending high volumes.

> [!NOTE]
> Dedicated sender IPs are not part of the standard Dynamics 365 Marketing subscription agreement, and Microsoft does not generally recommend them because they introduce extra complexity and expense—and can result reduced deliverability compared to our standard sender IPs. Microsoft considers applications for dedicated sender IPs on a case-by-case basis, and we can support multiple dedicated sender IPs if needed. If you think your organization could benefit from a dedicated sender IP, please [contact Microsoft Support](setup-troubleshooting.yml#contact-support) to find out if you qualify. The main goal of this process is to help you achieve as high a delivery rate as possible. Some of the most important factors to consider when making this decision include:
> 
> - How many messages does your organization send each month?
> - Is your content of high quality and in compliance with all relevant regulations?
> - Have there been many spam complaints associated with your messages until now?
> - Does your organization send a consistent volume of messages throughout the month?

Though there can be a few advantages to arranging for a dedicated sender IP, there are also disadvantages, and it isn't for everyone. Consider the following:

- **A new sender IP requires time to warm up**  
    When your new sender IP comes online, you must start by sending just a few messages at a time and then slowly ramp up over several weeks until you reach your intended send volume, which you must then continue to maintain. A sudden spike of email coming from a new IP will severely damage your send reputation and might land you on a blocklist right away. During the warm-up period, it's also important that you only send to valid and engaged recipients. Later, when you've established a reputation, you can begin to add less-engaged recipients.
- **Maintain a regular and consistent send volume**  
    You must spread out your email sends to ensure that you send roughly the same volume every week or so. Don't try to send all your messages at once at the start of each month, for example.
- **You should still set up DKIM**  
    The DKIM sender-authentication standard is essential for optimizing your marketing email deliverability. It's as important when you're using a dedicated IP as when using a shared IP, and you set it up in exactly the same way. For complete details on why this is important and how to do it, see [Set up DKIM for your sending domain](#dkim).
- **You concentrate risk on yourself and can pay a high price for any mistakes**  
    When you're the only one using your sending IP, any mistakes you make will affect your sender reputation directly, without being diluted by the large volume of compliant messages being sent by a large pool of other users.

### See also 
[Public IP addresses used for sending e-mails](public-ip-addresses-for-email-sending.md)

[Create a marketing email and go live](create-marketing-email.md)

[Email marketing overview](prepare-marketing-emails.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
