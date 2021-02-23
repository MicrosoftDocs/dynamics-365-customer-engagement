---
title: "The Base Extension table merge process might fail due to limits on SQL Server table row size | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 47b3d6c9-a2f6-4cd6-8174-885e6e405b98
caps.latest.revision: 2
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# The Base Extension table merge process might fail due to limits on SQL Server table row size

## Cause
  
 Combining the Base and Extension tables might exceed SQL Server limits and cause the merge operation to fail. This can be caused by a large number of attributes on the reported entities.  
  
 ## Solution
  
 Remove unused attributes or move some of the attributes to a related entity. You can also disable the Base Extension table merge process for your import.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]