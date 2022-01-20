---
title: "Create an SPF TXT record (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to create an SPF TXT record to authorize sending IPs in Dynamics 365 Marketing."
ms.date: 10/28/2020
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

# Create an SPF TXT record

Creating an SPF record for your sending domain can help [improve email deliverability results and recipient inbox placement](get-ready-email-marketing.md#set-up-an-spf-record). To create an SPF record for your sending domain, complete the following steps:

1. If your domain already has an SPF record, edit your existing TXT record and add following value:

    `include: marketing.dynamics.com`

    - **Example DNS records:**

        - *Existing SPF record:*

            `TXT record` <br>
            `TXT name: @` <br>
            `TXT value: v=spf1 ip4:192.168.1.1 -all`

        - *Updated SPF record:*

            `TXT record` <br>
            `TXT name: @`  <br>
            `TXT value: v=spf1 ip4:192.168.1.1 include:marketing.dynamics.com -all`

1. If your domain does not have an SPF record, add a new DNS record with the following parameters:

    `TXT record` <br>
    `TXT name: @` <br>
    `TXT value: v=spf1 include:marketing.dynamics.com ~all`

## SPF TXT record parameter definitions

Here is an example of an SPF TXT record, along with definitions of the parameters:

`v=spf1 ip4:192.0.2.0/24 include:_spf.contoso.com a -all`

- **v=spf1**: specifies the version of the SPF standard
- **ip4:192.0.2.0/24**: specifies the IP address or subnet that is authorized to send emails for the domain
- **include:_spf.contoso.com**: specifies that all IP addresses specified in the SPF TXT record of the domain *_spf.contoso.com* should be also included as trusted addresses for this domain
- **a**: specifies that IP addresses added to a DNS record of this domain are allowed to send emails
- **-all**: specifies that all email messages from IP addresses not specified in this SPF record should not be accepted by the recipient

> [!NOTE]
> Each parameter in the SPF TXT record should be divided by a space.

### See also

[Best practices for email marketing](get-ready-email-marketing.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]