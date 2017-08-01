---
title: "Recover from Exchange Server failure with Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: "2017-08-31"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 64feb3aa-3c9a-4fe2-9c1e-98773460a677
caps.latest.revision: 12
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Recover from Exchange Server failure
The process to restore a [!INCLUDE[pn_Exchange_Server_full](../includes/pn-exchange-server-full.md)] computer that is used by [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] depends on how that instance of [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)] is being used. The only time [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]-related data exists on [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)] occurs when you use a forward mailbox with the [!INCLUDE[pn_CRM_E-Mail_Router](../includes/pn-crm-e-mail-router.md)] or server-side synchronization. [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] doesn’t directly use [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)] mailboxes.  
  
## Restore Exchange Server in a Dynamics 365 environment  
  
1.  Restore [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)].  
  
2.  If the Email Router was installed on the computer that is running [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)] (not recommended), reinstall the Email Router.  
  
3.  Restore the Microsoft.Crm.Tools.EmailAgent.xml file. By default, this file is located in the C:\Program Files\Microsoft Dynamics 365 Email\Service folder on the computer where the Email Router is installed. If this file isn’t available, you must reconfigure the profiles, settings, users, queue, and forward-mailbox information by running the Email Router Configuration Manager.  
  
 For more information about [!INCLUDE[pn_Exchange_Server_2013_full](../includes/pn-exchange-server-2013-full.md)] backup and recovery, see [Backup, restore, and disaster recovery](https://technet.microsoft.com/library/dd876874\(v=exchg.150\).aspx).  
  
 For more information about [!INCLUDE[pn_Exchange_Server_2010_full](../includes/pn-exchange-server-2010-full.md)] backup and recovery, see [Understanding Backup, Restore and Disaster Recovery](https://technet.microsoft.com/library/dd876874\(v=exchg.141\).aspx).  
  
### See also  
 [Set up and manage email processing and Dynamics 365 for Outlook](../admin/integrate-synchronize-your-email-system.md)