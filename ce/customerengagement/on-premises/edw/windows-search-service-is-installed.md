---
title: "Windows Search Service is installed | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 80e8d771-8575-4f75-913a-1e2c3f0de6b8
caps.latest.revision: 3
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Windows Search Service is installed

## Cause
  
 Setup has detected that the Windows Search Service role service is installed on this computer. This service cannot be installed on the same computer as the Indexing Service, which is required for the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Help Server role.  
  
## Solution
  
 You must run Setup on another computer or uninstall the Windows Search Service role service.  
  
### Uninstall Windows Search Service  
  
1.  Start Server Manager.  
  
2.  Expand **Roles**, right-click **File Services**, and then select **Remove Role Services**.  
  
3.  In the Select Role Services wizard, clear the option for **Windows Search Service**, and then select **Next**.  
  
4.  Select **Remove** and follow the instructions on your screen. You will be required to restart your computer.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]