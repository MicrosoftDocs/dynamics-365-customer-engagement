---
title: "This version of Microsoft Dynamics 365 Server does not support installing separate server roles | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: e91b5206-723e-4da6-9e6f-55703fedbb6e
caps.latest.revision: 6
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# This version of Microsoft Dynamics 365 Server does not support installing separate server roles

## Cause
  
 The edition of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] does not support installing server roles on separate computers.  
  
## Solution
  
 Select the needed solution.  
  
-   Remove the element that is named Roles in the XML configuration file. Then, run Setup again to install all server roles on the computer.  
  
-   Obtain a [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] Edition license. This version of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] supports installing server roles on separate computers.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]