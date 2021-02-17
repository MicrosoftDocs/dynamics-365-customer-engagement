---
title: "Backup folder already exists | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 9a63bc12-62c4-48c6-a138-622ff6e9630a
caps.latest.revision: 6
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Backup folder already exists

## Cause
  
 During upgrade, Setup backs up the existing deployment’s files to the C:\program files\MSCRM\backup folder.  
  
 If this folder already exists, Setup cannot back up the program files before the upgrade.  
  
 ## Solution
  
1.  Stop and exit Setup.  
  
2.  Copy the files that are in the C:\program files\MSCRM\backup folder to another location and then manually delete the folder.  
  
3.  Run Setup again.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]