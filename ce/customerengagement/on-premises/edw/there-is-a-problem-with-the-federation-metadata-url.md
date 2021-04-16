---
title: "There is a problem with the federation metadata URL | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: e210ef8a-3e72-4022-8d15-b4e1a7aa23cc
caps.latest.revision: 8
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# There is a problem with the federation metadata URL
There is a problem with the federation metadata. Either it could not be accessed by using the specified URL or the URL is valid but there is some other problem with the federation metadata. The metadata is a feature of claims-based authentication, which is required to let users connect to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] by using the internet.  
  
## Cause
  
 This error can occur when one of the following is true:  
  
-   You do not have a network connection to the website where the metadata resides.  
  
-   You do not have permission to access the website where the metadata resides.  
  
-   A valid [!INCLUDE[pn_security_token_service](../includes/pn-security-token-service.md)], such as [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)], is not available at the specified URL.  
  
-   The certificate is not located in the certificate store. This could be an indication that the certificate did not come from a trusted source.  
  
## Solution
  
-   Verify that you have a connection and appropriate permission to access the website where the metadata XML file resides.  
  
-   Install a valid STS on the network.  
  
-   Verify that the certificate associated with the [!INCLUDE[pn_security_token_service](../includes/pn-security-token-service.md)] website is trusted.  
  
For more information about the certificate requirements for claims-based authentication, see [Certificate selection and requirements](/previous-versions/dynamicscrm-2013/crm.6/gg188582(v=crm.6)).



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]