---
title: "Dynamics 365 Customer Engagement (on-premises) multiple-server deployment | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 61f3e0eb-24f3-4410-83c5-0b08776b5ce2
caps.latest.revision: 17
ms.author: matp
author: Mattp123
manager: kvivek
---
# Dynamics 365 Customer Engagement (on-premises) multiple-server deployment



[!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] deployments can include multiple servers, which provide additional performance and scaling benefits.   
  
## Install server roles by running Microsoft Dynamics 365 Server Setup  
 During [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)], you can select to install a server role:  
  
-   Individually.  
  
-   As one of the three predefined groups of server roles.  
  
-   As a full server installation that includes all roles.  
  
 Server roles let you increase flexibility and scalability of the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment. Note that all server roles must be running and available on the network to provide a fully functioning [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] system.  
  
### Install server roles by running Microsoft Dynamics 365 Server Setup at the command prompt  
 You can install [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] roles and [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] from their respective installation disks or file download location unattended by using the command prompt. The required setup information is provided to the Setup program both as command-line parameters and as an XML configuration file that the Setup program references.  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Use the Command Prompt to Install Microsoft Dynamics 365](use-command-prompt-install-dynamics-365-server.md).  
  
## Microsoft Dynamics 365 Server placement  
 For improved application performance, the computer or computers that run the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] roles and the computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] should be on the same LAN. This is because of the large amount of network traffic passing between the computers. This is also recommended with [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] where the computer or computers on which [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] and the [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain controller are running should be on the same LAN to guarantee efficient [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] access to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
## SQL Server and Active Directory domain controller placement  
 For each organization, [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] stores all customer relationship management data in a [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] database. Make sure that the computer on which [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] is running that maintains the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] databases is located near the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)]. This means there should be a high-speed, permanent network connection between the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] and the computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. A network communications failure between these computers can result in data loss and service becoming unavailable.  
  
 The same is true for [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] because [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] depends on it for security information. If communication with [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] is lost, [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] will not function correctly. If communication with [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] is inefficient, [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] performance will be affected. Therefore, it is important to put an [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain controller on the same high-speed, permanent network connection as the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] and [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] computers.  
  
## See also  
 [Microsoft Dynamics 365 supported configurations](microsoft-dynamics-365-supported-configurations.md)   </br>
 [Microsoft Dynamics 365 Server roles](microsoft-dynamics-365-server-roles.md)   </br>
 [Support for Microsoft Dynamics 365 multiple-server topologies](dynamics-365-multiple-server-topologies.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]