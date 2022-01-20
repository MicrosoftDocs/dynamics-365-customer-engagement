---
title: "Windows NT Authentication Provider | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: ef40507a-722f-4d85-a29a-27a0f70d7a80
caps.latest.revision: 7
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Windows NT Authentication Provider

## Cause

 Setup validates that the **NTAuthenticationProvider** attribute on the Root virtual directory for the Microsoft Dynamics 365 for Customer Engagement website selected during server setup has the value of Negotiate,NTLM.  
  
 The **NTAuthenticationProvider** defines what authentication mechanism (Kerberos or NTLM) will be used when client users attempt to connect to the Microsoft Dynamics 365 for Customer Engagement website or the virtual directory that this attribute is configured for. This attribute is applicable only when the corresponding website or virtual directory is configured for integrated authentication.  
  
 The possible values for this attribute are:  
  
-   NTLM - Only NTLM authentication will be used.  
  
-   Negotiate - Only Kerberos authentication will be used.  
  
-   Negotiate,NTLM - Precedence will be given to Kerberos authentication and, if Kerberos fails, authentication will fall back to NTLM.  
  
## Solution
  
 This attribute must be configured to support both Kerberos and NTLM authentication (Negotiate,NTLM).  
  
 For information about how to set this attribute, see [How to configure IIS to support both the Kerberos protocol and the NTLM protocol for network authentication](https://go.microsoft.com/fwlink/p/?LinkID=24925).



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]