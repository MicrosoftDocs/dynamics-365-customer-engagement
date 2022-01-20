---
title: "Microsoft SQL Server Reporting Services server was not found | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 45c877d0-2255-4fd6-b0d5-95c1a558f071
caps.latest.revision: 6
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Microsoft SQL Server Reporting Services server was not found

## Cause
  
 Setup cannot find [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] server by using the specified URL. The following causes are possible reasons for this failure:  
  
-   [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] server is not installed on the specified computer.  
  
-   If the [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] server is installed on a different computer, a network connectivity problem is preventing this test from completing.  
  
-   The URL specified is incorrect or invalid.  
  
-   You may not have sufficient permissions for the specified [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] server.  
  
-   The default website does not exist, is not running, or is not valid.  
  
## Solution
  
 Verify the following conditions, and then run Setup again:  
  
-   [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] is installed on the specified computer.  
  
-   If the [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] server is installed on a different computer, verify network connectivity.  
  
-   Verify that you have at least local administrator group membership on the [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] server.  
  
-   Verify that you can connect to the [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] server by entering the [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] URL in a web browser. 



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]