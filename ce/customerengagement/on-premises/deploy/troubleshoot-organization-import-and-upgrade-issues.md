---
title: "Troubleshoot organization import and upgrade issues | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.prod: crm-2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 9c1397cb-f45d-4a4a-a2e5-abae714e4d5d
caps.latest.revision: 6
author: Mattp123
ms.author: matp
manager: kvivek
---
# Troubleshoot organization import and upgrade issues



If you encounter any issues during organization import and upgrade, here are some tips for troubleshooting them:  
  
-   Make sure that the user account that’s running the import has administrative permissions for the instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. For more information about how to grant permissions in [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)], see [Managing Logins, Users, and Schemas How-to Topics](/sql/relational-databases/security/authentication-access/managing-logins-users-and-schemas-how-to-topics?view=sql-server-2017).  
  
-   View the DMSnapin log file located in the following folder: \<*drive*:>%appdata%\Microsoft\MSCRM\Logs.  
  
## See also  
 [Manage organizations](manage-organizations.md)   
 [Import an organization](import-an-organization.md)   
 [Upgrade an organization](upgrade-an-organization.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]