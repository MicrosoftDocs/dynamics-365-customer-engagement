---
title: Create and design forms for Customer Service Hub | Microsoft Docs
description: 
keywords: Main forms; Customer service; Customer Service Hub; Dynamics 365
author: NavaKiran
ms.author: Nabuthuk
manager: shellyha
ms.date: 03/09/2018
ms.service: crm-online
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: d1efcf5e-988b-4e0c-bf11-2dcde1ea739f
---

# Create and design forms for Customer Service Hub
Improve user's productivity with the new forms in the Customer Service Hub. 

The **Main** forms have an improved user experience that saves some clicks and helps maintain context while working on related records. 
  
## Supported entities  
By default, the following entities are enabled in the Customer Service Hub and have the **Main** forms created out-of-the box: 
  
- Accounts  
  
- Contacts  
  
- Cases  
  
- Activities (Phone, task, email, appointment, and social activity)  
  
- Social Profiles  
  
- Queues
  
- Knowledge Articles  
  
> [!NOTE]
>  Apart from these entities, you can also create or customize interactive dashboards. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Configure interactive experience dashboards](../customize/configure-interactive-experience-dashboards.md)  
  
You can see the forms for each entity in their list of forms in the solution explorer in the **Customization** area. You can identify the form by the form type and display name. 

![form-type](media/form-type-csh.png)

Both the **Main** type forms are available to use in the Customer Service Hub (based on Unified Interface). They are also available if you are using Interactive service hub (based on web-client).

As a customizer, you can customize these forms in a way that it is easier for the users in your organization to find or enter information efficiently. You can create more forms for these entities.  

> [!NOTE]
> All customization tasks for the Customer Service Hub must be done in the Microsoft Dynamics 365 web application
 
## Types of forms  
 The following table describes the types of forms in that are used rendering data in the Customer Service Hub:  
  
|Form Type|Description|  
|---------------|-----------------|  
|**Main** |These forms provide the main user interface for interacting with entity data. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Design considerations for main forms](../customize/design-considerations-main-forms.md).|  
|**Card Form**|These forms are used in the interactive dashboards to show the entity data in the streams of interactive dashboards. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit card forms](../customize/create-edit-quick-create-forms.md) <br /><br />  **Note:** These forms are only for use in the Customer Service Hub. You can’t use these in the Microsoft Dynamics 365 web application, Microsoft Dynamics 365 for Outlook and Microsoft Dynamics 365 for tablets.|
|**Quick Create**|These forms provide a basic form optimized for creating new records. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit quick create forms](../customize/create-edit-quick-view-forms.md)<br /><br /> The Customer Service Hub uses the same quick create form that’s used for the web application and uses the same customization experience. However, the forms are presented in the Customer Service Hub paradigm.|  
|**Quick View**|These forms appear within the main form to display additional data for a record that is referenced by a lookup field in the form.<br /><br /> There are also quick view forms created out-of-the-box for use in the reference panel to show records of related entity. When you open a record of the related entity at the runtime, it opens in a horizontal tab on top of the pane.<br /><br /> Quick view forms are shared between the Dynamics 365 web application and the customer service hub. If the quick view form contains sub-grids, the sub-grids will appear in the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web application at the runtime, but they won’t appear in the Customer Service Hub reference panel.|  
  
## Assign form order  
 When you have multiple main, quick create, or mobile forms for an entity you can assign a form order. The form order determines which of the available forms will be shown by default. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Assign form order for forms](../customize/assign-form-order.md)  
  
## See Also  
 [Create and design forms](../customize/create-design-forms.md)   
 [Create and edit quick create forms](../customize/create-edit-quick-view-forms.md)   
 [Create and edit quick view forms](../customize/create-edit-quick-view-forms.md)