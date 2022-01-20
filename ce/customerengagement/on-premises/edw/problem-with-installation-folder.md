---
title: "Setup detected a problem with the specified installation folder | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 6e6927b6-bf20-4c37-b912-074f01307c3d
caps.latest.revision: 5
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Setup detected a problem with the specified installation folder

## Cause
  
 Setup has detected an issue with the installation folder that was specified on the **Select Installation Location** page. The most common causes of this are as follows:  
  
-   The folder names in the path contain invalid characters. (See: [Using special and extended characters](using-special-and-extended-characters.md))  
  
-   The installation folder must be a valid, absolute path.  
  
-   The installation folder exists. However, it is not empty.  
  
-   You do not have sufficient permissions for the folder.  
  
 ## Solution
  
 Verify the following conditions, resolve as necessary, and then run Setup again.  
  
-   If the installation location folder is not empty, make sure that Setup is permitted to overwrite or remove any existing files before you continue. As a precaution, you may want to copy the files to a safe location before Setup continues.  
  
-   When you specify the installation folder, make sure that you enter valid, absolute folder and path names that do not contain special characters.  
  
-   Make sure that you have sufficient permissions to write to the installation folder.  
  
-   If you enter a valid, absolute path, have sufficient permissions to the installation folder, and if this problem continues, remove all the files that are in the installation folder.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]