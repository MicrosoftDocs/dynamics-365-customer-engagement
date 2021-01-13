---
title: "Troubleshoot email issues (Dynamics 365 Marketing) | Microsoft Docs"
description: "Describes how to troubleshoot issues with email in Dynamics 365 Marketing."
ms.date: 01/12/2021
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
- [Office365/Exhange - Configure connection filtering](https://docs.microsoft.com/microsoft-365/security/office-365-security/configure-the-connection-filter-policy)

Find the Microsoft Dynamics 365 Marketing public IP addresses used for sending e-mails: [Public IP addresses used for sending e-mails](get-ready-email-marketing.md#public-ip-addresses-used-for-sending-e-mails)

> [!IMPORTANT]
> If you run into issues allow listing Dynamics 365 Marketing in your email security software, we recommend reaching out to the vendor support for specific instructions. 

### See also

[Best practices for email marketing](get-ready-email-marketing.md)  