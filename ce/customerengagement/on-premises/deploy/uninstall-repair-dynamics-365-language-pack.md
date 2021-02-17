---
title: "Uninstall or repair a Dynamics 365 Language Pack | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 48d19bce-bbe6-4002-bc62-794d8460e55f
caps.latest.revision: 15
ms.author: matp
author: Mattp123
manager: kvivek
---
# Uninstall or repair a Dynamics 365 Language Pack



To perform [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)] maintenance, select from the following options that are available. Before you select an option, you must start **Programs and Features** in [!INCLUDE[pn_Control_Panel](../includes/pn-control-panel.md)].  
  
> [!IMPORTANT]
>  Rather than uninstall a [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)] that is installed on the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] server, you can disable a [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)] in the organization. After you do this, users will no longer be able to see the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] user interface and Help in the language that you disabled. Later, you can enable the [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)] by selecting the language in the **Language Settings** list.  
  
 When a [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)] is removed or disabled, users who have that [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)] language selected on the **Personal Preferences** form will have to use the base language. For example, consider the following scenario. A [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment has English as the base language, but the Spanish [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)] was used in the organization. Then, when the system administrator disables (or uninstalls) the Spanish [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)], users who selected the user interface to be in Spanish will see it in English.  
  
 To disable a [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)], see [Enable languages](../admin/enable-languages.md).  
  
 **Uninstall**. Selecting this option will remove the selected [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)] from the computer. If you uninstall a [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)], you must reinstall and then enable it before it is available to users again.  
  
### Uninstall a Language Pack  
  
1.  Right-click the [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)], such as **Microsoft Dynamics 365 German [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)]**, and then select **Uninstall**.  
  
2.  If other users are logged on to the computer, you will receive a warning message. Select **Continue** if you want to continue and remove the [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)].  
  
3.  To confirm that you want to remove the [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)], select **Yes**, and then follow the instructions that are on your screen.  
  
 **Repair**. To repair a damaged [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)] installation, right-click the [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)], select **Repair**, and then follow the instructions that are on your screen.  
  
## See Also  
 [Microsoft Dynamics 365 Uninstall, Repair, and Change Instructions](uninstall-repair-and-change-microsoft-dynamics-365.md)   </br>
 [Use the Command Prompt to Install Microsoft Dynamics 365](use-command-prompt-install-dynamics-365-server.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]