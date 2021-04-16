---
title: "Recover from Exchange Server failure  | MicrosoftDocs"
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 64feb3aa-3c9a-4fe2-9c1e-98773460a677
caps.latest.revision: 12
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin

---
# Recover from Exchange Server failure

The process to restore a [!INCLUDE[pn_Exchange_Server_full](../includes/pn-exchange-server-full.md)] computer that is used by Dynamics 365 Customer Engagement (on-premises) depends on how that instance of [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)] is being used. The only time Customer Engagement (on-premises) -related data exists on [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)] occurs when you use a forward mailbox with the [!INCLUDE[pn_CRM_E-Mail_Router](../includes/pn-crm-e-mail-router.md)] or server-side synchronization. Customer Engagement (on-premises) doesn’t directly use [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)] mailboxes.  

> [!NOTE]
> This topic applies to Email Router which has been deprecated and was removed in version 9.0 of Dynamics 365 for Customer Engagement. We strongly recommend that you migrate all email routing functionality to use the server-side synchronization feature.
  
## Restore Exchange Server  
  
1. Restore [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)].  
  
2. If the Email Router was installed on the computer that is running [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)] (not recommended), reinstall the Email Router.  
  
3. Restore the Microsoft.Crm.Tools.EmailAgent.xml file. By default, this file is located in the C:\Program Files\Microsoft Dynamics 365 Email\Service folder on the computer where the Email Router is installed. If this file isn’t available, you must reconfigure the profiles, settings, users, queue, and forward-mailbox information by running the Email Router Configuration Manager.  
  
For more information about [!INCLUDE[pn_Exchange_Server_2016](../includes/pn-exchange-server-2016-short.md)] backup and recovery, see [Backup, restore, and disaster recovery](/Exchange/high-availability/disaster-recovery/disaster-recovery).  

For more information about [!INCLUDE[pn_Exchange_Server_2013_full](../includes/pn-exchange-server-2013-full.md)] backup and recovery, see [Backup, restore, and disaster recovery](https://technet.microsoft.com/library/dd876874\(v=exchg.150\).aspx).  
  
For more information about [!INCLUDE[pn_Exchange_Server_2010_full](../includes/pn-exchange-server-2010-full.md)] backup and recovery, see [Understanding Backup, Restore and Disaster Recovery](https://technet.microsoft.com/library/dd876874\(v=exchg.141\).aspx).  



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]