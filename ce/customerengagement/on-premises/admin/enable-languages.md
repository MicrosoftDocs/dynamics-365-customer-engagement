---
title: "Enable languages in Dynamics 365 Customer Engagement (on-premises)"
description: "Enable languages in your organization to display the user interface and Dynamics 365 Help in a language that’s different from the base language."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: how-to
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: d5ac01dc-ebc6-455a-9a73-3367ff69eb1a
caps.latest.revision: 11
author: Mattp123
ms.author: matp
search.audienceType: 
  - admin
---
# Set and enable languages

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

Enable languages in your organization to display the user interface and Dynamics 365 Help in a language that’s different from the base language. 

> [!IMPORTANT]
>  - If you’re running [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)], you must download one or more [Language Packs](https://go.microsoft.com/fwlink/p/?LinkID=513276) before you can enable additional languages.   
>  - Enabling language packs may affect application performance. More information: [Performance tuning and optimization](performance-tuning-and-optimization.md) 

 The following table shows tasks that are associated with changing regional and language options for your organization.  


|                    Task                     |                                                                                                                                                                                       Description                                                                                                                                                                                       |
|---------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|          **Set the base language**          |                                                                                          The base language determines default settings for regional and language options in Customer Engagement (on-premises). After the base language is set, you can’t change it.                                                                                           |
|       **Enable or disable languages**       |                                                                                                                                                         You can enable or disable available languages in the **Settings** area.                                                                                                                                                         |
|        **Add and remove currencies**        | Similar to setting the base language, you select your organization's base currency during the purchasing process for a subscription to Customer Engagement (on-premises). After the base currency is set, you can’t change it.<br /><br /> However, if your organization uses more than one currency to track financial transactions, you can add currencies. |
| **Deactivate or activate currency records** |                                                                                       You can’t delete currency records that are being used by other records, such as opportunities or invoices. However, you can deactivate currency records so they won’t be available for future transactions.                                                                                       |

<a name="BKMK_Step2Provision"></a>   

## Enable the language  

 Before users can start using a Language Pack to display a language, the Language Pack must be enabled in your Customer Engagement (on-premises) organization.  

1. Start the Customer Engagement (on-premises) web application. You’ll need a System Administrator security role or equivalent privileges for the Customer Engagement (on-premises) organization that you want to provision a Language Pack for.  

2. [!INCLUDE[proc_settings_administration](../includes/proc-settings-administration.md)]  

3. Click **Languages** to open the **Language Settings** dialog box. Here you’ll see each Language Pack installed in your Customer Engagement (on-premises) deployment, with a check box to the left of each listed Language Pack  

4. For each Language Pack that you want to provision (enable), select the check box next to it. For each Language Pack that you want to unprovision (disable), clear the check box.  

5. Click **Apply**.  

6. Click **OK** on any confirmation dialog boxes that open.  

   > [!NOTE]
   >  It may take several minutes for Customer Engagement (on-premises) to provision or unprovision the languages.  

7. To close the **Language Settings** dialog box, click **Close**.  

   Repeat the previous steps for each organization in your Customer Engagement (on-premises) deployment.  

<a name="BKMK_Step3Select"></a>   
## Select the language to display the user interface and Help  
 Each user selects the language to display in both the Customer Engagement (on-premises) web client and [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] applications.  

> [!IMPORTANT]
>  For [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../includes/pn-microsoft-dynamics-crm-for-outlook.md)], you must download and install the Language Packs before you can select them. <!--[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Install and enable a Language Pack](Install%20and%20enable%20a%20Language%20Pack.md)  -->


1. Sign in to Customer Engagement (on-premises) and open the **Set Personal Options** page, as follows:  

   - If you’re using the Customer Engagement (on-premises) web client, click the **Settings** button ![Settings button.](../admin/media/settings-button.png "Settings button"), and then click **Options**.  

   - If you are using [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)], on the top menu bar, choose **Dynamics 365**, and then click **Options**.  

2. Choose the **Languages** tab.  

3. In the **User Interface Language** list, select the language in which you want to display Customer Engagement (on-premises).  

4. In the **Help Language** list, select the language in which you want to display [!INCLUDE[pn_Microsoft_Dynamics_CRM_Help](../includes/pn-microsoft-dynamics-crm-help.md)].  

5. To save your changes and close the dialog box, click **OK**.  

> [!NOTE]
>  In [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)], the user language settings only apply to [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] features, such as the user interface display of the **Dynamics 365** menu, and don’t affect other areas of [!INCLUDE[pn_MS_Outlook_Full](../includes/pn-ms-outlook-full.md)]. To display all of the [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] user interface or Help in multiple languages, you need to install one or more [!INCLUDE[pn_MS_Office](../includes/pn-ms-office.md)]Language Packs.  

### See also  
 [Add resources to a site](../admin/add-resources-site.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
