---
title: "Source folder was not found | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: d883ae31-50ee-4a98-b548-1a8cdc714be9
caps.latest.revision: 6
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Source folder was not found

## Cause
  
 Setup did not find the specified source folder where the installation files are located. There can be several causes of this, including the following:  
  
-   The location such as a network share where the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] installation files are located is not available.  
  
-   The path to the specified folder is not valid.  
  
-   The folder names in the path contain invalid characters. For more information about invalid characters, view [Using special and extended characters](using-special-and-extended-characters.md)  
  
-   You do not have sufficient file system permissions to access the folder.  
  
-   The path to the specified folder may be correct, but there is a problem in the [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)] Installer (.msi) file.  
  
 ## Solution
  
 Verify that the source folder is correct and that you have sufficient permissions to access it, and then run Setup again.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]