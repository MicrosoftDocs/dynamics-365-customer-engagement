---
title: "Import translated entity and field text in Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 08/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 3d77d149-819b-45e6-8e70-1fbe54d5c153
caps.latest.revision: 19
ms.author: "rdubois"
manager: "brycho"
---
# Import translated entity and field text back into Dynamics 365
If you have customized entity or field text, such as field labels or drop-down list values, you can provide the users in your organization who are not working with the base language version of your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] implementation with this customized text in their own languages. To do so, you export the text strings for all your customizations so that they can be translated into the languages you use in your organization.  
  
 After the translation, you need to import the translated text strings into your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] implementation before users can take advantage of the changes.  
  
> [!IMPORTANT]
> - The file that you import must be a compressed file that contains the CrmTranslations.xml and the [Content_Types].xml file at the root.  
> - [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] can’t import translated text that is over 500 characters long. If any of the items in your translation file are longer than 500 characters, the import process will fail. If the import process fails, review the line in the file that caused the failure, reduce the number of characters, and try to import again. Also note that after you import translated text, you must republish customizations.  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    ### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
3.  Click **Customize the System**.  
  
4.  In the solution explorer, on the Actions toolbar, click **Import Translations**.  
  
5.  In the **Import Translated Text** dialog box, specify the file that contains the translated text, and then click **Import**.  
  
6.  When [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] finishes importing the translated text, click **Close**.  
  
> [!NOTE]
>  Publishing customizations can interfere with normal system operation. We recommend you schedule publishing when it’s least disruptive to users.  
  
### See also  
 [Export customized entity and field text for translation](../customize/export-customized-entity-field-text-translation.md)
