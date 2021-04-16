---
title: "Install and enable a Language Pack | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.prod: crm-2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
  - Dynamics CRM 2016
ms.assetid: 3ffb8f29-2bc2-4074-8c44-f7e3cb4a14be
caps.latest.revision: 19
author: Mattp123
ms.author: matp
manager: kvivek
---
# Install and enable a Language Pack



Follow the procedures in this topic to install a [!INCLUDE[pn_Microsoft_Dynamics_CRM_Language_Pack](../includes/pn-microsoft-dynamics-crm-language-pack.md)].  
  

## Install the Language Pack 
 If you have users who are running [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)], in addition to installing [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)] on the computer running [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)], you must also install the same [!INCLUDE[cc_Language_Packs_short](../includes/cc-language-packs-short.md)] on the computer where [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] is installed.  
  
1.  Log on to the computer where [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] or [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] is installed.  
  
2.  Verify that you have local Administrator permission on the computer and System Administrator security role or equivalent privileges on [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
3. Download the [Microsoft Dynamics 365 Customer Engagement (on-premises) Language Pack](https://go.microsoft.com/fwlink/?linkid=2025434).  
  
4.  Where the [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)] files are located, double-click the file MUISetup_<`loc_code`>_<`proc_type`>.msi file,  
  
     where:  
  
     <`loc_code`> is the locale code for the Language Pack that you’re installing. (For example, "1031" for German or "1041" for Japanese.)  
  
     <`proc_type`> specifies the application processor version. (For example, **amd64** for [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] and 64-bit versions of [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] or **i386** for 32-bit versions of [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)].)  
  
5.  On the  **License Agreement** page, review the information and, if you accept the terms of the agreement, select **I accept the terms in the License Agreement**, and then select **Install**.  
  
     Setup copies the [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)] files to the correct locations in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. By default, the [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)] files are copied to drive:\Program Files\Microsoft Dynamics 365 Customer Engagement (on-premises)\LangPacks\\<loc_code>, where <loc_code> is the locale code for the [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)] that you are installing.  
  
6.  To complete the installation, select **Finish**.  
  
     Repeat the previous steps for each [!INCLUDE[pn_Language_Pack_short](../includes/pn-language-pack-short.md)] that you want to make available to your [!INCLUDE[pn_crm_op_edition](../includes/pn-crm-op-edition.md)] [!INCLUDE[cc_Deployment](../includes/cc-deployment.md)].  
  
7.  Enable the language packs that you want to make available to users. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Enable languages](../admin/enable-languages.md)  
  
## See also  
[Microsoft Dynamics 365 Customer Engagement (on-premises) language support](microsoft-dynamics-365-language-support.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]