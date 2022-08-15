---
title: "Microsoft SQL Server Reporting Services server was not found | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: 
  - ReportingURLValidator.htm
  - ReportingURLValidator
ms.assetid: d0ceba1f-b25a-40e7-b0fd-2e439b65bade
caps.latest.revision: 4
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Microsoft SQL Server Reporting Services server was not found

## Cause
  
 Setup did not find the specified [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] server. The following causes are possible reasons for this failure:  
  
-   The URL specified for the [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] cannot be resolved.  
  
-   [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] is not installed on the specified computer or the [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] version that is running on the computer is not supported.  
  
-   You may not have sufficient permissions for the specified [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] server.  
  
## Solution
  
 Verify the following details and then run Setup again:  
  
-   Make sure the URL specified is correct. To verify, enter the URL into a web browser.  
  
-   The specified computer has [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] installed and the version is supported. See [Microsoft Dynamics 365 for Customer Engagement reporting requirements](../deploy/microsoft-dynamics-365-reporting-requirements.md). 
  
-   Verify that you have at least local administrator group membership on the [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] server.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]