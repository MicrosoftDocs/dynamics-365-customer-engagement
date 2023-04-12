---
title: "Troubleshoot email issues (Dynamics 365 Marketing) | Microsoft Docs"
description: "Describes how to troubleshoot issues with email in Dynamics 365 Marketing."
ms.date: 04/12/2023

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

# Troubleshoot email issues

This article contains issues related to email administration in Dynamics 365 Marketing, as well as workarounds and solutions.

## Internal contacts are not receiving your marketing emails

If you are using Marketing to send email messages to internal users and they are not receiving your emails, the emails are likely being quarantined by your spam filter solution. To ensure that your emails arrive in your internal recipients' inboxes and successfully pass your spam solution checks, complete the following steps:

- [Add Dynamics 365 Marketing to your SPF record](create-spf-record.md)
- Determine if you are using any email security software (for example, Mimecast, Proofpoint, or IronPort)

Below are direct links with instructions on how to change allow list settings on common email and web filters:

- [Barracuda - Configuring inbound email](https://campus.barracuda.com/product/essentials/download/10YQ/barracuda-email-security-service-configuring-inbound-email/)
- [Cisco - How do you allow list a trusted sender?](https://www.cisco.com/c/en/us/support/docs/security/email-security-appliance/118585-qa-esa-00.html)
- [Mimecast - Configuring anti-spoofing policies](https://community.mimecast.com/s/article/Configuring-Anti-Spoofing-Policies-1695615136#jive_content_id_Configuring_an_AntiSpoofing_Policy)
- [Proofpoint - Creating a filter to allow messages from your own domain](https://help.proofpoint.com/Proofpoint_Essentials/Creating_a_filter_to_allow_messages_from_your_own_domain)
- [Sophos - Allow/block lists](https://sea.sophos.com/webhelp/sea/tasks/ConfigPolAllowBlockLists.html)
- [Symantec.Cloud/MessageLabs - About approved and blocked senders lists](https://help.symantec.com/cs/EMAIL_WEB.CLOUD/EMAILSECURITYCLOUD/Toc216427001_v116575109/About-approved-and-blocked-senders-lists)

> [!NOTE]
The above-listed URLs, as well as the Google URL below, link to external pages that are not associated with Microsoft. The URLs may change or be deactivated without notice.

If you are not using any of the above-listed email security software, use the following links to set the default options for allowing Marketing services in Office365/Exchange and GSuite/Google Apps:

- [GSuite/Google Apps - Add IP addresses to allow lists in Gmail](https://support.google.com/a/answer/60751)
- [Office365/Exhange - Configure connection filtering](/microsoft-365/security/office-365-security/configure-the-connection-filter-policy)

Find the Microsoft Dynamics 365 Marketing public IP addresses used for sending e-mails: [Public IP addresses used for sending e-mails](get-ready-email-marketing.md#public-ip-addresses-used-for-sending-e-mails)

> [!IMPORTANT]
> If you run into issues allow listing Dynamics 365 Marketing in your email security software, we recommend reaching out to the vendor support for specific instructions. 

## Troubleshoot email forwarding and replies

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

## [External] flag for emails sent to internal recipients

When sending emails to recipients within your organization, you may find that the email is being flagged as [External]. This is a common occurrence when the recipient's domain is hosted on Exchange Online or Microsoft 365.

The [External] flag is configured to notify users that an email has been sent from outside their organization. This is a security feature to protect against phishing attacks, as external emails can often be fraudulent.

If you are sending emails to recipients within your organization and they are being flagged as [External], there are a few things you can do. Firstly, check that the recipient's domain is hosted on Exchange Online or Microsoft 365. If it is, you can contact your email administrator and ask them to adjust the email configuration. They should be able to configure emails sent from your domain not to be flagged as [External].

However, if you are sending emails to recipients outside your organization, the [External] flag is expected behavior. This does not mean that your emails are marked as Spam/Junk, but it is simply a notification that the email has come from outside the organization. Unfortunately, there is nothing that can be done to fix this from the sender's side.

To avoid any confusion, it's important to clearly communicate the purpose of the [External] flag to your recipients. You can explain that it is a security feature to help identify potential phishing attempts, and that it does not mean that the email is unsafe.

In conclusion, the [External] flag is an important security feature to protect against phishing attacks. While it can be frustrating if your internal emails are being flagged as [External], there are steps you can take to resolve the issue. By working with your email administrator and clearly communicating the purpose of the flag to your recipients, you can ensure that your emails are delivered safely and securely.

### See also

[Best practices for email marketing](get-ready-email-marketing.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
