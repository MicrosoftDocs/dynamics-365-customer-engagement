---
title: "Uninstall, change, or repair Dynamics 365 Server | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 61d9bddb-f1ee-4765-97e4-6c87f3fbf545
caps.latest.revision: 16
ms.author: matp
author: Mattp123
manager: kvivek
---
# Uninstall, change, or repair Dynamics 365 Server



To perform [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] maintenance, select from the following options that are available. Before selecting an option, you must start **Programs and Features** in [!INCLUDE[pn_Control_Panel](../includes/pn-control-panel.md)].  
  
1.  Log on to the computer where the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] application is installed. Then, start **Programs and Features** in **Control Panel**.  
  
2.  Select from the following options.  
  
    -   **Uninstall**. Selecting this option will remove [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] from the computer. To do this, right-click **Microsoft Dynamics 365 Server**, select **Uninstall/Change**, select **Uninstall** to remove [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)], and then select **Uninstall**. Follow the instructions that are on the screen.  
  
        > [!IMPORTANT]
        >  The [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] uninstall process does not remove some components, such as the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] databases, [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] groups, or the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] website (when the website is not created by [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)]). Those components must be removed manually. Additionally, some components installed during [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)] are not removed during an uninstall.  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Components not removed during a Microsoft Dynamics 365 Server uninstall](uninstall-change-repair-dynamics-365-server.md#BKMK_comp_notremoved)  
  
    -   **Configure**. To add or remove one or more [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] server roles, right-click **Microsoft Dynamics 365 Server**, select **Uninstall/Change**, select **Configure**, and then select **Next**. Follow the instructions that are on the screen to select or clear one or more server roles. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Microsoft Dynamics 365 Server roles](microsoft-dynamics-365-server-roles.md)  
  
    -   **Repair**. To repair a [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] installation, right-click **Microsoft Dynamics 365 Server**, select **Uninstall/Change**, select **Repair**, and then select **Next**. Follow the instructions that are on the screen.  
  
        > [!NOTE]
        >  Repairing a [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] installation reinstalls the program files. It has no effect on the databases. To recover from [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database problems, you must restore the MSCRM_CONFIG and *OrganizationName*_MSCRM databases. For information about database backup and failure recovery, see [Backing up SQL Server, including Reporting Services](back-up-the-microsoft-dynamics-365-system.md#BKMK_BackupSQL).  
  
<a name="BKMK_comp_notremoved"></a>   
### Components not removed during a Microsoft Dynamics 365 Server uninstall  
 The following system components, although installed during [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)], aren’t removed when you uninstall [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)].  
  
 [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)] role services:  
  
-   Web Server Role Services  
  
    -   Static Content  
  
    -   Default Document  
  
    -   Directory Browsing  
  
    -   HTTP Errors  
  
    -   [!INCLUDE[pn_ASP.NET_short](../includes/pn-asp-net-short.md)]  
  
    -   [!INCLUDE[pn_Microsoft_.Net_Framework](../includes/pn-microsoft-net-framework.md)] Extensibility  
  
    -   ISAPI Extensions  
  
    -   ISAPI Filters  
  
    -   HTTP Logging  
  
    -   Request Monitor  
  
    -   [!INCLUDE[pn_Windows_Authentication](../includes/pn-windows-authentication.md)]  
  
    -   Request Filtering  
  
    -   Static Content Compression  
  
    -   Dynamic Content Compression  
  
    -   [!INCLUDE[pn_iis](../includes/pn-iis.md)] Management Console  
  
    -   [!INCLUDE[pn_iis](../includes/pn-iis.md)] Metabase Compatibility  
  
-   File services role services:  
  
    -   [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)] Search  
  
-   Windows features:  
  
    -   [!INCLUDE[pn_Microsoft_.Net_Framework](../includes/pn-microsoft-net-framework.md)]  
  
    -   HTTP Activation  
  
    -   [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)]  
  
    -   [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)] Process Activation  
  
## See Also  
 [Microsoft Dynamics 365 Uninstall, Repair, and Change Instructions](uninstall-repair-and-change-microsoft-dynamics-365.md)   </br>
 [Uninstall or repair Microsoft Dynamics 365 Reporting Extensions](uninstall-repair-dynamics-365-reporting-extensions.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]