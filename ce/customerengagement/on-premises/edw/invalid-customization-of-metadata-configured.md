---
title: "Invalid customization of metadata configured | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 6b3e8c03-d5d2-4277-a7a8-d8d02d0af60a
caps.latest.revision: 2
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Invalid customization of metadata configured

## Cause
  
 There is an invalid customization of metadata configured (a timestamp data type) in the organization database. This customization will be lost if you continue with the organization import.  
  
 ## Solution
  
 This is a warning and you can continue with the import. However, we recommend that you review the Setup log file (c:\Users\\<user\>\AppData\Roaming\Microsoft\MSCRM\Logs) to determine whether the customization can be removed. If the customization is removed, such as a customization created from a solution, the solution may not work after the organization database is imported.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]