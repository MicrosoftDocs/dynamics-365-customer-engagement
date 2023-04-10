---
title: "Email security and connection encryption (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to use email security and connection encryption with Dynamics 365 Marketing."
ms.date: 05/27/2022
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

# Email security and connection encryption

Email security and encryption are essential for reliable email sending. There are two major security protocols used for email delivery: SSL and TLS.

- SSL (Secure Socket Layer) is an older protocol that is no longer used by major email service providers (ESPs) because it doesn't provide adequate security for connections. It's being replaced by its successor, TLS.
- TLS (Transport Layer Security) is one of the most modern and widely used protocols for email transport. Subsequent versions of TLS (v1.1, v1.2, and v1.3) are more secure than earlier versions and fix many vulnerabilities present in SSL.

In SMTP (a Simple Mail Transfer Protocol), the protocol that is widely used to send and deliver emails, the protocol command StartTLS is used to communicate email security requests. The StartTLS command informs the email server that the recipient wants to upgrade to a more secure connection and use either SSL or TLS encryption. In other words, it works with both older SSL requests and more modern TLS requests.

There are three encryption requirement options available to use with StartTLS:

1. **No TLS**: No encryption will ever be requested for sending emails.
1. **Opportunistic TLS**: Encryption will only be used if the recipient side supports it. If not, emails will be sent without connection encryption.
1. **Enforced TLS**: Usage of TLS is enforced. If the recipient side doesn't support encryption, email delivery will be canceled.

Because not all email providers support connection encryption, it isn't advisable to use the enforced TLS method. This method creates a situation where even valid recipients can't receive emails from our platform.

The Microsoft Dynamics 365 Marketing sending infrastructure uses the most flexible and reliable option, opportunistic TLS. This allows senders to deliver emails to all recipients that they want to reach, providing the maximum email security that email recipients support.
