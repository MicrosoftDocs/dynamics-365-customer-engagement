---
title: "Microsoft Dynamics 365 for Customer Engagement log file does not exist | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 16796962-c7f9-4830-8fa6-f95ef91828cb
caps.latest.revision: 3
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Microsoft Dynamics 365 for Customer Engagement log file does not exist

## Cause
  
 Setup cannot find the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database file (.mdf) or the transaction log file (.ldf) for the selected database.  
  
 ## Solution
  
 To resolve this issue, perform one of the following actions:  
  
-   Restore the database or transaction log file for the associated database, and then run Setup again.  
  
-   Remove the .mdf or .ldf file from the folder, and then run Setup again and choose to create a new database.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]