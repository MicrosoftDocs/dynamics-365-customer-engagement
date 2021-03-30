---
title: "Track S/S/MIME signed emails using App for Outlook (Dynamics 365 apps) | MicrosoftDocs"
description: Track S/S/MIME signed emails using Dynamics 365 App for Outlook.
ms.custom: 
ms.date: 03/19/2021
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
caps.latest.revision: 1
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Outlook
---

# Track S/MIME signed emails

Dynamics 365 App for Outlook can track [S/MIME (Secure/Multipurpose Internet Mail Extensions)](/microsoft-365/security/office-365-security/s-mime-for-message-signing-and-encryption?view=o365-worldwide&preserve-view=true) signed emails in Outlook Desktop and Outlook Web App (OWA). 

This is enabled on [Click-to-Run](/office/troubleshoot/office-suite-issues/office-click-to-run-installation) Outlook 2016 build 16.0.8730.1000 or later. To determine your Outlook version, go to **File** > **Office Account** > **About Outlook**.

Using encryption software with server-side synchronization is not supported.

- If you use server-side synchronization with Dynamics 365 Customer Engagement (on-premises), you won't be able to view S/MIME encrypted messages. Encrypting emails with S/MIME requires an application to use an S/MIME control, which server-side synchronization doesn't support. For more information on S/MIME encryption, see [Encrypt messages by using S/MIME in Outlook Web App](https://support.microsoft.com/office/encrypt-messages-by-using-s-mime-in-outlook-web-app-2e57e4bd-4cc2-4531-9a39-426e7c873e26?).

- Encrypted mails can only be tracked from the Microsoft Outlook Client (web or desktop) once they are decrypted, any corresponding Dynamics 365 activities created will not be encrypted.

## Known issues and FAQs

1. When an email is signed or encrypted, attachments are stored inside a single smime.p7m attachment. If the email is tracked in Dynamics 365 then you will see a **.p7m** attachment that needs to be decoded using an [S/MIME reader](https://www.microsoft.com/p/s-mime-reader/9nblggh5lhc3?activetab=pivot:overviewtab).

2. If your email isn't syncing with Dynamics 365, see [Email fail to synchronize to Dynamics 365 when encoded with PEC](https://support.microsoft.com/topic/email-fail-to-synchronize-to-dynamics-365-when-encoded-with-pec-631b7dd7-f797-8cc2-046c-313ea7e724f7)
	




