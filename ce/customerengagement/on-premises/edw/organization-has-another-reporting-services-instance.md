---
title: "The organization already has another Reporting Services instance configured | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 8d8c07eb-9247-478b-a1bb-eb39bdc517cb
caps.latest.revision: 3
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# The organization already has another Reporting Services instance configured

## Cause 
  
 [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)] Setup is about to be installed for a [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)] instance that is different from the one that is being used by the organization.  
  
## Solution
  
 There are two possible solutions.  
  
1.  Configure all organizations to set the specified [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] instance as the [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] by using the **Edit Organization Wizard** in [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)].  
  
2.  Specify the [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] that is already defined for the organizations.  
  
 This is a warning and Setup can continue. [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)] Setup will install the [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)] but will not publish the reports for the organizations. Notice that the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] out-of-box reports will not work until they are published.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]