---
title: "Setup detected an issue with the install folder specified | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 59e4e570-a944-4dcc-ab79-829605e26bf9
caps.latest.revision: 4
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Setup detected an issue with the install folder specified

## Cause
  
 Setup detected an issue with the specified folder that will be used to install the application. The most common causes for this problem are:  
  
-   The install folder exists. However, it is not empty.  
  
-   The install folder does not exist, does not have a valid, absolute path, or is not a mapped network drive.  
  
-   The folder name does not contain valid characters. For more information, see [Using special and extended characters](using-special-and-extended-characters.md).  
  
-   The user who is installing [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] does not have write permissions to the folder.  
  
 ## Solution
  
 Verify the following conditions, and then run Setup again.  
  
-   If the install location folder is not empty, make sure that Setup is permitted to overwrite or remove any existing files before you continue. As a precaution, you might want to copy the files to a safe location before Setup continues.  
  
-   When you specify the install folder, make sure that you enter valid, absolute folder and path names that do not contain special characters.  
  
-   Make sure that you have sufficient permissions to write to the install folder.  
  
-   If you enter a valid, absolute path, have sufficient permissions to the install folder, and this problem continues, remove all the files that are in the install folder.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]