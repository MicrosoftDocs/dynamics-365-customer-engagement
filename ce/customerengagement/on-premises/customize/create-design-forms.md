---
title: "Create and design forms (Customer Engagement (on-premises)) | MicrosoftDocs"
ms.custom: 
ms.date: 03/07/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 99c795e0-9165-4112-85b1-6b5e1a4aa5ec
caps.latest.revision: 33
ms.author: matp
manager: kvivek
author: Mattp123
tags: 
  - Links to topic not migrated
search.audienceType: 
  - customizer

---
# Create and design forms 

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Create and design model-driven app forms](/powerapps/maker/model-driven-apps/create-design-forms)

With Dynamics 365 Customer Engagement (on-premises), forms provide the user interface that people use to interact with the data they need to do their work. It's important that the forms people use are designed to allow them to find or enter the information they need efficiently. 

In the default solution or an unmanaged solution, you can create new forms or edit existing forms for all entities that allow form customization. 
In an unmanaged solution, you can edit the managed properties for an unmanaged custom entity that was created for the solution.
If you’re viewing a managed solution, you can’t create new forms or edit existing forms for entities. However, if the managed properties for an entity in the managed solution are set to allow customization, you can add or edit forms to that entity. 


<a name="BKMK_TypesOfForms"></a> 
## Type of forms
There are several types of forms:  

|    Form type     |                                                                                                                                                                                                                              Description                                                                                                                                                                                                                              |                                     More information                                     |
|------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------|
|     **Main**     |                                      Used in these Dynamics 365 Customer Engagement (on-premises): the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] web application, [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)], and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)].<br /><br /> These forms provide the main user interface for interacting with entity data.                                      | [Design considerations for main forms](../customize/design-considerations-main-forms.md) |
| **Quick Create** |                               Used in Dynamics 365 Customer Engagement (on-premises), the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] web application, [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)], and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)].<br /><br /> For updated entities, these forms provide a basic form optimized for creating new records.                                |    [Create and edit quick create forms](../customize/create-edit-quick-create-forms.md)    |
|  **Quick View**  | Used in Dynamics 365 Customer Engagement (on-premises), the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] web application, [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)], and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)].<br /><br /> For updated entities, these forms appear within the main form to display additional data for a record that is referenced by a lookup field in the form. |     [Create and edit quick view forms](../customize/create-edit-quick-view-forms.md)     |
|**Card** | Used in views for unified interface apps. Card forms are designed to present information in a compact format that is suitable for mobile devices. | [Create a card form](/powerapps/maker/model-driven-apps/create-card-forms) |

While each form type has specific needs, when working with forms you use the Form Editor. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Work with the form editor](work-with-form-editor.md)

<a name="BKMK_FormDifferencesByEntity"></a>   
## Updated versus classic entities  
Dynamics 365 Customer Engagement (on-premises) provides many options for designing forms. With Unified Interface, most entities were updated to better suit the responsive interface. Updated entities as well as your own custom entities include support for the [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)] client, business process flows, and business rules. When you use these entities, you can design once and deploy to all clients.  

There are still a number of entities, referred to here as classic entities, that retain the appearance and capabilities from earlier versions. These entities are used less often. They are listed here:  

||||||  
|-|-|-|-|-|  
|Address|Article|Article Comment|Bulk Delete Operation|Connection|  
|Discount|Discount List|Document Location|Email Attachment|Follow|  
|Goal|Goal Metric|Import Source File|Invoice Product|Order Product|  
|Price List|Queue Item|Quote Product|Rollup Field|Rollup Query|  
|Saved View|Service|Service Activity|SharePoint Site|Site|  
|Territory|Unit|Unit Group|||  


### See also  

[Assign form order](assign-form-order.md) <br />
[Control access to forms](control-access-forms.md) <br />
[How main forms appear in different clients](main-form-presentations.md) <br />
[Add form navigation for related entities](add-edit-form-navigation-related-entities.md) <br />
[Work with the form editor](work-with-form-editor.md) <br />


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
