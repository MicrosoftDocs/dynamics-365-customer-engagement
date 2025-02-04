---
title: "Translate product names and properties into multiple languages (Dynamics 365 Sales) | MicrosoftDocs"
description: "Make all the relevant information like cross-sell or upsell suggestions, or properties, available to sales users in their preferred language by translating product names and properties in Dynamics 365 Sales."
ms.date: 10/29/2024
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: 
  - dyn365-sales
---
# Translate product names and properties into multiple languages (Sales Hub) 

Translate all the relevant information like cross-sell or upsell suggestions, or properties, and make it available to sellers in their preferred language.

## Step 1: Export data for translation  
  
1. [!INCLUDE[proc_permissions_admin_cust_mgr_vp_sales_ceo](../includes/proc-permissions-admin-cust-mgr-vp-sales-ceo.md)]  
  
   #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  

2. Select **Settings** > **Advanced Settings**.

3. Select **Settings** > **System** > **Data Management**.
  
4. Select **Export Field Translations**.  
  
5. In the **Export Field Translations** dialog box, select **OK**.  
  
    All product fields that are marked as localizable by default will be exported. Your internal developers can mark the fields as localizable. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Localize product property values](developer/localize-product-property-values.md)

  
6. Save the .zip file to your local computer.  
  
    Exported text is saved as a compressed file that contains a CrmFieldTranslations.xml that you can open by using [!INCLUDE[pn_microsoft_excel](../includes/pn-microsoft-excel.md)]. You can send this file to a linguistic expert, translation agency, or localization firm.  
  
<a name="bkmk_Import"></a>   
## Step 2: Import translated data  
 When you get the localized data back from translation, import it into [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)].  
  
> [!IMPORTANT]
>  It is important to provision the language packs first. If you import translated values for languages that aren't provisioned in the organization, they'll be discarded. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Install or upgrade Language Packs](/previous-versions/dynamicscrm-2016/deployment-administrators-guide/hh699674(v=crm.8))  
> <!-- Fix this link - cannot find it in migrated content -->

1. [!INCLUDE[proc_permissions_mgr_vp_ceo_busmgr_sysadmin_syscust](../includes/proc-permissions-mgr-vp-ceo-busmgr-sysadmin-syscust.md)]  
  
   #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  

2. Select **Settings** > **Advanced Settings**.

3. Select **Settings** > **System** > **Data Management**.
  
4. Select **Import Field Translations**.  
  
5. In the **Field Translation Import Jobs** page, on the action toolbar, select **Import Field Translations**.  
  
6. In the **Import Translated Text** dialog box, select **Choose file**, and select the file that you've received from your translation agency.  
  
7. Select **OK**.  
  
    This starts the import job. You can check the status to see if the import has succeeded or failed.  
  
   After you've imported the translated text, users in your organization will see the data in their preferred language. If a value for the preferred language doesn't exist, the results will be shown in the user's base language.  
  
<a name="bkmk_LanguageSelection"></a>   
## Selection of language in different scenarios  
 This section explains how the duplicate detection and workflow logic affect translation in [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)]:  
  
-   Calculated fields logic, including conditional clauses, uses only the base language. The label for the user's preferred language (user interface language) is used if present. Otherwise, the base language is used.  
  
-   When a record is created or updated, duplicates are detected from the localizable fields (attributes) that are in the base language. Creating or updating a localizable field isn't applicable in a non-base language.  
  
-   During data import,  
  
    -   For updating or creating records through import, when import is executed in base language, only the labels in the base language are used for duplication detection.  
  
    -   When import is executed in non-base language, import fails because update can't be performed in a non-base language.  
  
-   When you run duplicate detection in the base language, only the base language is used in conditional clauses.  
  
-   When you run duplicate detection job in the preferred language, label in the preferred language is used first. When preferred language isn't available, it uses the base language.  

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]
  
## Related information  
 [Set up a product catalog: Walkthrough](set-up-product-catalog-walkthrough.md)   
 [Set up duplicate detection rules to keep your data clean](/power-platform/admin/set-up-duplicate-detection-rules-keep-data-clean)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
