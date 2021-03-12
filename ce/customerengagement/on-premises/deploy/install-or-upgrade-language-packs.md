---
title: "Install or upgrade Language Packs | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 25af20e4-2eac-4bed-888e-be35015b59fb
caps.latest.revision: 19
ms.author: matp
author: Mattp123
manager: kvivek
---
# Install or upgrade Language Packs

::: moniker range="op-9-1"
[!INCLUDE [applies-not-to-9-1](../includes/applies-not-to-9-1.md)]

::: moniker-end

::: moniker range="op-9-0"

The [!INCLUDE[pn_Microsoft_Dynamics_CRM_Language_Pack](../includes/pn-microsoft-dynamics-crm-language-pack.md)] enables users to change the language of the user interface or Help that is displayed in the application. For example, your multinational organization might have standardized on an English user interface to simplify internal training and troubleshooting, but if you prefer to read Help in your native language, you can specify that [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] display Help in that language.  
  
## Language Pack overview  
 The basic steps to install or upgrade and provision one or more [!INCLUDE[cc_Language_Packs_short](../includes/cc-language-packs-short.md)] are described here.  
  
1.  Download the [!INCLUDE[cc_Language_Packs_short](../includes/cc-language-packs-short.md)] that you want. [!INCLUDE[cc_Language_Packs_short](../includes/cc-language-packs-short.md)] are not included with other [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] applications and are only available through the [!INCLUDE[pn_Microsoft_Download_Center](../includes/pn-microsoft-download-center.md)]. Each language pack installation (.msi) file includes the locale id (LCID) that represents that language. Download a [Microsoft Dynamics CRM 2016 Language Pack](https://go.microsoft.com/fwlink/p/?LinkId=624615).  
  
    > [!NOTE]
    >  For a list of locale IDs and the associated language, see [MSDN: Locale IDs assigned by Microsoft](https://msdn.microsoft.com/goglobal/bb964664.aspx).  
    >   
    >  You can’t install a [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)] that is the same locale ID as the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] base language.  
  
2.  Install the [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)] .msi package on the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)]. If you have deployed server roles, install it on the [!INCLUDE[Front_End_Server](../includes/front-end-server.md)] or the servers that are running the [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] role.  
  
3.  Sign-in to the organizations that you want to provide language support for and enable each [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Install and enable a Language Pack](install-and-enable-a-language-pack.md)  
  
4.  For [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)] users, the same language packs must also be installed on the users’ PCs.  
  
 After installing and enabling a [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)], its capabilities and corresponding options are available for users to select in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] client applications from personal **Settings** > **Options**.  
  
 For more detailed installation and enabling instructions, see the following topics.  
  
 
## See Also  
 [Install or upgrade Dynamics 365 Server](install-or-upgrade-microsoft-dynamics-365-server.md)   </br>

::: moniker-end


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]