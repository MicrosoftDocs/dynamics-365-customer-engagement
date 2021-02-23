---
title: "Microsoft Dynamics 365 for Customer Engagement website cannot be accessed | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 01f421a9-da60-4d47-a06a-75550ee94430
caps.latest.revision: 7
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Microsoft Dynamics 365 for Customer Engagement website cannot be accessed

## Cause
  
 Setup cannot access the specified website. The error message provides HTTP status codes and error details. There are several possible causes for this error:  
  
-   One or more folders where the Microsoft Dynamics 365 for Customer Engagement website is installed are missing.  
  
-   The user account running Setup does not have sufficient permissions on the folder or subfolders where the Microsoft Dynamics 365 for Customer Engagement website is installed. By default, the top-level folder is located in \<Drive>:\Program Files\Microsoft Dynamics 365 for Customer Engagement\CRMWeb and the account must have Read, Write, and Modify permissions.  
  
-   Internet options specify using a proxy server for local addresses (HTTP status 502 Bad Gateway).  
  
-   Server certificate is not valid. An SSL encrypted channel cannot be established successfully when you connect to a specified secure URL.  
  
-   The URL host name differs from the common name (CN) in the server certificate. The server certificate cannot be verified when you connect to the specified secure URL.  
  
-   Other HTTP errors are preventing access to a specified URL. See the error message for more information.  
  
 ## Solution
  
 View the details for information about the errors that are listed, correct the problem, and then run Setup again.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]