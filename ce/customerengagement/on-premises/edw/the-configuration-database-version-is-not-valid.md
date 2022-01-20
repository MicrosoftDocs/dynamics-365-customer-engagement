---
title: "The configuration database version is not valid | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 021bc738-4f11-4442-9c2b-e49a6f2aee45
caps.latest.revision: 6
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# The configuration database version is not valid

## Cause
  
 The [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] configuration database (MSCRM_CONFIG) is not the correct version.  
  
 This issue can occur for the following reasons:  
  
-   The existing database version is later than the version of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] you are installing.  
  
-   You are attempting to install [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)] before upgrading [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)].  
  
## Solution
  
 Select the following solution that is most appropriate for you.  
  
-   Redeploying [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] by installing an earlier version of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] is not supported. You must use a version that is supported by the existing configuration database.  
  
-   You must first upgrade [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] before you install [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)].



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]