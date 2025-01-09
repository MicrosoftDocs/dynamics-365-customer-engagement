---
title: "We recommend a dedicated domain user account for this Microsoft Dynamics 365 for Customer Engagement service | Microsoft Docs"
description: Environment diagnostics warning that a dedicated domain user account is recommended as the service identity.

ms.custom: 
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: b07fc992-0525-441f-b2bc-1310e9883f42
caps.latest.revision: 9
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# We recommend a dedicated domain user account for this Microsoft Dynamics 365 for Customer Engagement service

## Cause
  
 Setup has detected that a dedicated least-privileged domain user account is not specified for the service listed in the warning message.  
  
 ## Solution
  
 This is a warning and Setup can continue. However, for a more secure deployment of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], we recommend that you specify a separate least-privileged user account for each [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] service. For more information, see [Minimum permissions required for Microsoft Dynamics CRM Setup and services](/previous-versions/dynamicscrm-2016/deployment-administrators-guide/hh699825(v=crm.8)).



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]