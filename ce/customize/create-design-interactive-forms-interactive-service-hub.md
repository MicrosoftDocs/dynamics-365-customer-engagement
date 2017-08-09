---
title: "Create and design interactive forms for the Customer Service hub or Interactive Service hub in Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: "2017-08-31"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: b6df6d11-9272-4c68-b516-e12c6e701622
caps.latest.revision: 15
ms.author: "anjgup"
manager: "sakudes"
---
# Create and design interactive forms for the Customer Service hub or Interactive Service hub
Improve your users' productivity with interactive forms. Interactive forms saves users some clicks and helps them maintain context while working on related records.  
  
 These forms were introduced for use in the Interactive Service hub and are also used in the Customer Service hub, which were both designed and optimized for customer service scenarios.  
  
> [!IMPORTANT]
>  For [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] organizations, the interactive forms feature is only available if you've installed the [!INCLUDE[pn_crm_online_2016_update_shortest](../includes/pn-crm-online-2016-update-shortest.md)]. . Interested in getting this feature? [Find your Dynamics 365 administrator or support person](http://go.microsoft.com/fwlink/p/?LinkID=513070).  
  
<a name="BKMK_SupportedEntities"></a>   
## Supported entities  
 Interactive forms are supported only for entities that are enabled for the interactive experience.  
  
 By default, the following entities are enabled for the interactive experience, and have the interactive forms created out-of-the box:  
  
-   Account  
  
-   Contact  
  
-   Case  
  
-   Out-of-the-box activities (Phone, task, email, appointment, and social activity)  
  
-   Social Profile  
  
-   Queue Item  
  
-   Knowledge Article  
  
> [!NOTE]
>  Apart from these entities, you can also create or customize interactive dashboards. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure interactive experience dashboards](../customize/configure-interactive-experience-dashboards.md)  
  
 You can see the interactive forms for each entity in their list of forms in the solution explorer in the Customization area. The form type of interactive forms is Main InteractionCentric.  
  
 As a customizer, you can customize these forms in a way that it is easier for the users in your organization to find or enter information efficiently. You can create more interactive forms for these entities.  
  
 You can enable any new custom entity or custom activity for the interactive experience, and then create interactive forms for it.  
  
> [!IMPORTANT]
> - All customization tasks for the interactive service hub must be done in the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] web application.  
> - You can’t enable out-of-the-box entities other than the ones listed about for the interactive experience.  
  
<a name="bkmk_Enable"></a>   
## Enable entities for interactive experience  
 You can enable interactive experience only for custom entities or activities. You can’t enable existing default (out-of-the-box) entities for interactive experience.  
  
1. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
2.  Click **Customize the System** to open the default solution.  
  
3.  Under **Components**, expand the **Entities** node, and select the entity you want to enable for the interactive experience.  
  
4.  Select the **Enable for interactive experience** check box.  
  
<a name="BKMK_TypesOfForms"></a>   
## Types of forms  
 The following table describes the types of forms in that are used rendering data in the interactive service hub:  
  
|Form Type|Description|  
|---------------|-----------------|  
|**Main InteractionCentric** (also referred to as Main Form – Service Console)|These forms provide the main user interface for interacting with entity data. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add or remove components](../customize/design-considerations-main-forms.md)<br /><br />**Note:**  These forms are only for use in the Customer Service hub and Interactive Service hub. You can’t use these forms in the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] web application, [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)], or [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)].|  
|**Card Form**|These forms are used in the interactive dashboards to show the entity data in the streams of interactive dashboards. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit card forms](../customize/create-edit-card-form.md)<br /><br />**Note:**  These forms are only for use in the Customer Service hub and Interactive Service hub. You can’t use these forms in the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] web application, [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)], or [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)].|  
|**Quick Create**|These forms provide a basic form optimized for creating new records. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit quick create forms](../customize/create-edit-quick-create-forms.md)<br /><br /> The Customer Service hub and Interactive Service hub use the same quick create form that’s used for the web application and uses the same customization experience. However, the forms are presented in the Customer Service hub or Interactive Service hub paradigm.|  
|**Quick View**|These forms appear within the main form to display additional data for a record that is referenced by a lookup field in the form.<br /><br /> There are also quick view forms created out-of-the-box for use in the reference panel to show records of related entity. When you open a record of the related entity at the runtime, it opens in a horizontal tab on top of the pane.<br /><br /> Quick view forms are shared between the Dynamics 365 web application and the Customer Service Hub/Interactive Service hub. If the quick view form contains sub-grids, the sub-grids will appear in the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web application at the runtime, but they won’t appear in the Customer Service hub or Interactive Service hub reference panel.|  
  
<a name="BKMK_FormOrder"></a>   
## Assign form order  
 When you have multiple main, quick create or mobile forms for an entity you can assign a form order. The form order determines which of the available forms will be shown by default. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Assign form order for forms](../customize/create-design-forms.md#BKMK_FormOrder)  
  
### See also  
 [Create and design forms](../customize/create-design-forms.md)   
 [Main interaction-centric form presentations](../customize/use-the-main-interactive-experience-form-and-its-components.md)   
 [Create and edit quick create forms](../customize/create-edit-quick-create-forms.md)   
 [Create and edit quick view forms](../customize/create-edit-quick-view-forms.md)
