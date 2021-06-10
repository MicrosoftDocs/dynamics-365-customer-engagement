---
title: "Uninstall or repair Microsoft Dynamics 365 for Outlook | MicrosoftDocs"
ms.custom: 
ms.date: 11/28/2016
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 apps 
ms.assetid: 6bf2bc59-9949-4afd-aee5-5b6101e90f75
caps.latest.revision: 30
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Outlook
---
# Uninstall or repair Microsoft Dynamics 365 for Outlook
If other users run [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] on the same device, those users should sign out of [!INCLUDE[pn_ms_Windows_long](../../includes/pn-ms-windows-long.md)] before uninstalling [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]. This is especially true for [!INCLUDE[pn_citrix](../../includes/pn-citrix.md)] or Remote Desktop environments where additional sessions are common and should be closed before uninstalling [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)].  
  
> [!TIP]
>  You might want to disable [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] instead of uninstalling it. To disable [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], go to **File > Options**. Click **Add-Ins**, click the **Go** button next to **Manage: COM Add-ins**, clear both **[!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]** add-ins, and then click **OK**.  
  
1. Start **Programs and Features** in the [!INCLUDE[pn_Control_Panel](../../includes/pn-control-panel.md)].  
  
2. On the **Uninstall or change a program** page, select the version of [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] you want to uninstall, and then click **Uninstall/Change**.  
  
3. In the Setup wizard, on the **Choose the installation you want** page, click **Uninstall** or **Repair**.  
  
4. When the wizard finishes, click **Close**.  
  
5. If prompted, restart your computer.  
  
> [!NOTE]
>  If an uninstallation is not completed while you are logged on to the client computer as the user who originally installed the application, the offline database will remain attached to the instance of [!INCLUDE[pn_ms_SQL_Server_Express_long](../../includes/pn-ms-sql-server-express-long.md)]. After the uninstall is complete, you can manually detach the offline database.  
  
## Files not removed during a Microsoft Dynamics 365 for Outlook uninstall  
 The following files aren’t removed when you uninstall [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)].  
  
- <sup>1</sup>Program Files\Microsoft Dynamics CRM\Client\ConfigWizard\CrmForOutlookInstaller.exe  
  
- Windows\CrmClient.mif  
  
  <sup>1</sup>The default folder name is **Program Files** or **Program Files (x86)**.  
  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]