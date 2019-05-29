---
title: "Enable additional languages (Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
ms.custom: 
ms.date: 04/29/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
author: Mattp123
ms.assetid: ece68f5f-ad40-4bfa-465a-3e5bafb854aa
caps.latest.revision: 55
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer
search.app: 
  - D365CE
---

<a name="BKMK_Localization"></a>   
# Enable additional languages 

[!INCLUDE [cc_applies_to_on-prem-9_0_0](../includes/cc_applies_to_on-prem-9_0_0.md)]
 
 If your organization has people who use a language other than the base language you chose when you deployed [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps, you can add more languages.  
  
 Before you can enable a language, you must first install the language pack. More information: [Install or upgrade Language Packs](../on-premises/install-or-upgrade-language-packs.md) 
  
> [!NOTE]
>  Enabling a language can take several minutes. During this time, people might not be able to use [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps.  
  
## Enable additional languages  
  
1. [!INCLUDE[proc_settings_administration](../includes/proc-settings-administration.md)]  
  
2. Choose **Languages**.  
  
3. In the **Language Settings** dialog box, choose any available languages and choose **Apply** to enable them.  
  
   While you can enable additional languages, the localized text is only available for text that’s included in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] before it is customized. You can only customize [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] using the base language. Users of other languages will see the text in the base language unless you export translations and add localized text for any user interface items that you have added or changed. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Export customized entity and field text for translation](../customize/export-customized-entity-field-text-translation.md)  
  
> [!NOTE]
>  Because customization is supported only in the base language, as the System Customizer you may be working with the base language set as your language preference. To verify that the translated text is appearing, you must change your language preference for the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps user interface. To perform additional customization work, you must change back to the base language.  

### See also

[Export customized entity and field text for translation](../customize/export-customized-entity-field-text-translation.md)
[Import translated entity and field text](../customize/import-translated-entity-field-text.md)
