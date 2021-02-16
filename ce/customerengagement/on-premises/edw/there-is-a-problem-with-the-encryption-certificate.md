---
title: "There is a problem with the encryption certificate | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 379e429f-2485-4a15-9e18-3672eccc5748
caps.latest.revision: 9
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# There is a problem with the encryption certificate

This check will fail if any of the following conditions are true.  

## Cause 1  
The specified encryption certificate could not be found in the local certificate store. A valid certificate is required to configure claims-based authentication. This issue can occur when one of the following are true:  
  
-   Claims-based authentication was previously configured with a certificate that exists on another computer but is not installed on this computer's local certificate store.  
  
-   The specified encryption certificate was deleted.  

## Cause 2  
The service account configured for the Microsoft Dynamics 365 for Customer Engagement application pool (CrmAppPool) does not have permission to read the Claims Signing certificate in the local store.  
  
## Solution
  
### Resolve cause 1

You must install the specified certificate to the local certificate store or select a different certificate.  
  
## Resolve cause 2 

Grant the CRMAppPool account of each Microsoft Dynamics CRM web application read permission to the private key of the encryption certificate. The claims signing certificate must be located in the local certificate store.  For more information, see *The CRMAppPool account and the Microsoft Dynamics CRM encryption certificate* in the [Configure the Microsoft Dynamics CRM Server for claims-based authentication](https://go.microsoft.com/fwlink/p/?LinkId=296783) topic.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]