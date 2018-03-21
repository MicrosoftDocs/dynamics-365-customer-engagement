---
title: "Enable additional languages (Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "rdubois-msft"
ms.assetid: ece68f5f-ad40-4bfa-465a-3e5bafb854aa
caps.latest.revision: 55
ms.author: "rdubois"
manager: "brycho"
---

<a name="BKMK_Localization"></a>   
# Enable additional languages 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]
 
 If your organization has people who use a language other than the base language you chose when you deployed [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], you can add more languages.  
  
 For [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)], you’ll find all the languages are already installed; you just need to enable them.  
  
> [!NOTE]
>  Enabling a language can take several minutes. During this time, people might not be able to use [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)].  
  
## Enable additional languages  
  
1. [!INCLUDE[proc_settings_administration](../includes/proc-settings-administration.md)]  
  
2.  Choose **Languages**.  
  
3.  In the **Language Settings** dialog box, choose any available languages and choose **Apply** to enable them.  
  
 While you can enable additional languages, the localized text is only available for text that’s included in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] before it is customized. You can only customize [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] using the base language. Users of other languages will see the text in the base language unless you export translations and add localized text for any user interface items that you have added or changed. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Export customized entity and field text for translation](../customize/export-customized-entity-field-text-translation.md)  
  
> [!NOTE]
>  Because customization is supported only in the base language, as the System Customizer you may be working with the base language set as your language preference. To verify that the translated text is appearing, you must change your language preference for the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] user interface. To perform additional customization work, you must change back to the base language.  

### See also

[Export customized entity and field text for translation](../customize/export-customized-entity-field-text-translation.md)
[Import translated entity and field text](../customize/import-translated-entity-field-text.md)
