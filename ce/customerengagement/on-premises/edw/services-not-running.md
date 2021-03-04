---
title: "Services not running | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: b0595980-377c-4e8f-9e71-d48300304f3d
caps.latest.revision: 6
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Services not running

## Cause
  
 Setup has found that one or more services are not running on this computer. For example, this issue can occur during [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] Setup when the Indexing Service is not started or is not configured to start automatically.  
  
 ## Solution
  
 If the Indexing Service is not installed on [!INCLUDE[pn_ms_Windows_Server_long](../includes/pn-ms-windows-server-long.md)], do the following:  
  
### Install Indexing Service on Windows Server  
  
1.  Start **Server Manager**.  
  
2.  In Server Manager, expand **Roles**, right-click **File Services**, and then select **Add Role Services**.  
  
3.  In the Select Role Services wizard, select **Indexing Service**, and then select **Next**.  
  
4.  Select **Install** and follow the instructions that are on your screen.  
  
5.  Close **Server Manager**.  
  
 To start the Indexing Service, do the following:  
  
### Start Indexing Service on Windows Server  
  
1.  Right-click **Start**, select **Run**, enter *services.msc*, and then press **ENTER**.  
  
2.  Right-click **Indexing Service**, and then select **Start**.  
  
3.  Close the Services application.  
  
 If the Indexing Service is not set to start automatically, complete the following procedure.  
  
### Configure Indexing Service to start automatically on Windows Server  
  
1.  In the search box enter *services.msc*, and then press **ENTER**.  
  
2.  Right-click **Indexing Service**, and then select **Properties**.  
  
3.  In the **Startup type** list select **Automatic**, and then select **OK**.  
  
4.  Close the Services application.  
  



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]