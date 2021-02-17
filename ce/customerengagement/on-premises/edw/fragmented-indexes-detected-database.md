---
title: "Fragmented indexes were detected in the Microsoft Dynamics 365 for Customer Engagement database | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 3c5ae9ab-a17b-4600-9c53-21f069853d67
caps.latest.revision: 4
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Fragmented indexes were detected in the Microsoft Dynamics 365 for Customer Engagement database

## Cause
  
 This warning can occur when the indexes in the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database are significantly fragmented. Heavily fragmented indexes can degrade query performance.  
  
 ## Solution
  
 This is a warning and Setup can continue. However, we recommend that you remedy the index fragmentation by either reorganizing or rebuilding the indexes. After you have successfully defragmented the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database, run Setup again. For more information see [Reorganize and Rebuild Indexes](https://go.microsoft.com/fwlink/p/?LinkID=182157) in SQL Server Books Online.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]