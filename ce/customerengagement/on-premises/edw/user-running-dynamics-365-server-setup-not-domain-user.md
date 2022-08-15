---
title: "User who is running Microsoft Dynamics 365 Server Setup is not a domain user | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: aad03a11-ce75-40dc-883a-370b03e4a5dc
caps.latest.revision: 6
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# User who is running Microsoft Dynamics 365 Server Setup is not a domain user

## Cause 1
  
 [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] Setup is being run by a user who is not a domain user.  

## Cause 2
  
 The Active Directory Domain Services service is not started.  
  
## Solution 1
  
 Exit [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] Setup and log on to the server where you want to install [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] as a user with the following permissions. Then, run Setup again.  
  
-   Local Administrator membership on the server where you want to install [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. 
  
-   Local Administrator membership on the [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] computer.  
  
-   Local Administrator membership on the Reporting Services computer.  
  
-   Domain Users member who has Read and Write permissions to the organizational unit in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] where [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] will be installed.  
  

## Solution  2
  
 Start the Active Directory Domain Services service, and then configure the service to start automatically. To do this, follow these steps.  
  
## To start a service  
  
1.  On the **Start** menu, select **Run**, type `services.msc`, and then press **Enter**.    
2.  Right-click the service that you want to start, and then select **Start**.  
3.  Select **OK** and then close the Services application.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]