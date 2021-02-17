---
title: "A Microsoft Dynamics 365 for Customer Engagement database already exists with the specified name | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: 
  - DatabaseFilesValidator
  - DatabaseFilesValidator.htm
ms.assetid: 7fdded02-0c2a-4487-a6f0-62682b06b89e
caps.latest.revision: 4
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# A Microsoft Dynamics 365 for Customer Engagement database already exists with the specified name

## Cause
  
 Setup either found an existing database, or database files that have the same name that were specified during installation.  
  
 If Setup cannot verify an existing database, this is a warning and Setup can continue.  
  
 ## Solution
  
 If this is an error, do one or more of the following actions and then run Setup again:  
  
-   Select a different organization name or a different [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] for the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database.  
  
-   Select a different [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] server.  
  
-   Delete the database and log files.  
  
 If this is a warning, you can ignore this message and installation of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] should complete successfully. However, all data in the existing database that has the specified name will be lost.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]