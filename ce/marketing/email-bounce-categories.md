---
title: "Email bounce categories (Dynamics 365 Marketing) | Microsoft Docs"
description: "A comprehensive list of email bounce categories and definitions for Dynamics 365 Marketing."
ms.date: 12/14/2020
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

# Email bounce categories

To identify the cause of bounced campaign emails, Dynamics 365 Marketing includes a bounce categorization feature. The bounce categorization feature groups typical bounce errors into bounce categories. Each category represents a type and reason for bounced emails. Here is the list of bounce categories we use:

- invalid-mailbox  
- invalid-domain  
- inactive-mailbox  
- full-mailbox
- dmarc-issues  
- reputation-issues  
- greylisting-issues  
- blocklisting-issues  
- relaying-issues  
- routing-issues  
- recipient-server-error  
- connection-error  
- policy-related  
- message-expired  
- other

## Bounce category definitions

The first two categories – **invalid-mailbox** and **invalid-domain** – are known as “hard bounces.” A hard bounce is an email that has been sent to an invalid mailbox or an invalid domain. This means that the recipient’s email address or the domain doesn't exist.

**inactive-mailbox** – This is closely related to the invalid-mailbox category. The inactive-mailbox category indicates that the recipient’s address is disabled, abandoned, or no longer exists on the recipient’s server. In most cases, inactive-mailbox addresses should be excluded from sending, as they rarely become active again.

**full-mailbox** – This category results from addresses that are unable to receive email messages due to lack of storage or limits on the number of emails received. In most cases, full mailbox-means that the recipient’s mailbox is abandoned or not being read regularly. This category is not a hard bounce, but if the error appears for a contact on a regular basis, the contact is not likely to receive future email messages.

**dmarc-issues** – This category stands for errors closely related to a recipient’s or sender’s DMARC or other internal policies related to domain authentication such as SPF record checks or DKIM signature checks. Such errors can result if the recipient’s server doesn't allow emails from domains without a valid SPF record or DKIM signature. dmarc-issues errors can also result if there is mismatched sending domain alignment to the SPF record or DKIM signature in the email. Extensive dmarc-issues errors could mean that the sending domain is misconfigured or that the sending domain doesn't fill the requirements for acceptable email delivery. This category of issues usually requires additional investigation. If you run into this kind of issue, you should open a support ticket.

**reputation-issues** – This bounce category combines types of bounces related to spam filtering on the recipient side. In most cases, if this bounce category comes up, it means that the email content, the sending domain, or sending IP address have a low sending reputation or have exceeded sending limits per minute/hour/day. Also, it may indicate that the content of the emails was treated as spam by the recipient’s spam filter. If reputation-issues errors become a significant problem, you should open a support ticket to resolve the issue. The support team will typically adjust limits on the sending server or find a solution by contacting the recipient’s email server administrators.

**greylisting** – This category represents transient errors or so called “greylisting errors.” Such errors result when the recipient’s server gets an email from a new sender domain or IP address. Such errors typically don't result in bounced emails. But, in some cases, email administrators prefer to bounce all emails from new sources to avoid spam and require some manual communications or approvals. In certain cases, delivery is only possible manually. An example of manual delivery might include adding characters to the email subject or adding special email headers that aren't possible using mass mailing or marketing software.

**blocklisting-issues** – This bounce category occurs when a sending domain or IP address is listed on any existing not trusted. This means that either the domain or sending IP address, or any link or image in the email content was marked as not trusted due to one of the following reasons:

- Multiple complaints from recipients.
- Sending to a spamtrap address. A spamtrap is an email address that is intentionally used to identify spammers. Spamtrap addresses can easily be found by automated email harvesters that are used by spammers. Legitimate senders don’t typically have these addresses in their contact lists except from human errors. Senders that send emails to these addresses are automatically identified as spammers on the recipient server side.
- Triggering anti-spam, anti-virus, or anti-phishing software on the recipient side.

Such errors don't often occur. We monitor cases related to not trusted domains and IP addresses on a daily basis and remove blocks if they appear, as well as analyze the email flow to avoid further issues.

**relaying-issues** – This category represents errors from recipient servers that don't allow incoming email flow from the outside. This category also can mean that there's a misconfiguration of the DNS records on the recipient side, such as DNS records that point to a server that doesn't host email addresses for that domain. Relaying-issues errors can be transient. Recipients shouldn't immediately be excluded from the contact list. But, if the error results from the same contact multiple times, it is recommended to exclude the contact.

**routing-errors** – This error means that the email can't reach the recipient due to an internal misconfiguration of the recipient’s server. Routing-errors can also be due to an internal forwarding misconfiguration on the recipient’s server, causing the email to transfer between mailboxes and never reach the destination. 

**recipient-server-error** – This category encompasses generic recipient server errors, such as server overload or any other temporary error. This category is caused by a technical error that can't be resolved except by contacting the email server administrator and providing proof of their infrastructure failure.

**connection-error** – This category results from errors that appear when our sending server is unable to establish a stable connection to the recipient mail server. Connection-errors can occur because of unavailability of the recipient’s server, misconfiguration of the recipient’s server, or a recipient side networking error.

**policy-related** – This category results from internal policies on the recipient’s server. For example, the recipient’s server can forbid emails from outside of the company, workgroup, or trusted senders. You can remedy this error by contacting the recipient using any other sources of communication and asking to the recipient to add the sending IP, domain, or sending email address to their trusted senders list.

Policy-related errors may also indicate that the recipient’s server can't identify the validity of the sending email address. This could occur when the “from” email address doesn't exist or doesn't accept incoming emails. Such incidents are rare and can be fixed by using an existing sending email address.

**message-expired** – This category results when, within the lifecycle of the email message, it was not able to be delivered to the recipient because of sending limitations or transient errors. If this error occurs frequently, you should open a support ticket to resolve it.

**other** – This category stands for uncategorized or atypical errors. We review and categorize such errors regularly.

### See also

[Best practices for email marketing](get-ready-email-marketing.md)  
[Email policies and suspension standards](email-policies.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]