---
title: "Create or edit quick create forms in Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
description: "Learn how to create or edit a quick create form"
ms.custom: 
ms.date: 04/29/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
author: Mattp123
ms.assetid: 68ca9059-cc5a-45e7-88bd-cc57186bbb48
caps.latest.revision: 18
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---
# Create or edit quick create forms for a streamlined data entry experience

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Create or edit model-driven app quick create forms for a streamlined data entry experience](/powerapps/maker/model-driven-apps/create-edit-quick-create-forms) 

 With quick create forms, your app can have a streamlined data entry experience with full support for logic defined by form scripts and business rules. In Dynamics 365 Customer Engagement (on-premises), quick create forms appear when you select the **Create** button in the navigation bar or when you choose **+ New** when creating a new record from a lookup or sub-grid.
  
 The [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] customer engagement mobile apps use quick create forms for creating new records. If an entity already has a quick create form configured for it, the mobile apps use that form. If an entity doesn't have a configured quick create form, [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] generates a quick create form  for creating records in the mobile apps based on the main form definition.  
  
<a name="BKMK_QuickCreateFormEntities"></a>   
## Entities with quick create forms  
 By default only the following system entities have quick create forms.  
  
|||||  
|-|-|-|-|  
|Account|Campaign Response|Case|Competitor|  
|Contact|Lead|Opportunity| Activity |  
  
<!-- Although you can create quick create forms for system activity entities, with the exception of the appointment entity, they do not support quick create forms. With the release of Dynamics 365 for Customer Engagement, version 9.0, the appointment entity includes a quick create form for use with the Unified Interface. Currently, the option to disable the quick create form for the appointment entity is not supported.--> 
Any of the [updated entities](../customize/create-design-forms.md) and any custom entities can be enabled to support these forms by selecting **Allow Quick Create** in the entity definition and creating a quick create form for the entity. 

You can enable custom activity entities to support quick create forms, and you can create quick create forms for those entities. However, the quick create form for custom activity entities will not be used when people select **Create** on the navigation bar. These quick create forms can be used only when people add a new record for a sub-grid that displays that specific custom activity entity. 

<a name="BKMK_CreateQuickCreate"></a>   
## Create a quick create form  
 Although you can define multiple quick create forms, only one quick create form can be used by everyone. The form everyone will use is set using the form order. Quick create forms cannot be assigned to security roles and they do not provide the capability for the user to switch forms.  
  
> [!NOTE]
>  - The entity must have the **Allow Quick Create** option enabled for the quick create form to be displayed.
>  - You must also add the entity and the quick create form to your app.
>  - Some fields, such as the CREATEDON field, aren’t available to add to a quick create form.  
  
### To create a quick create form  
  
1.  In the solutions explorer, expand the entity that you want and select **Forms**.  
  
2.  Select **New** > **Quick Create Form** from the toolbar.  
  
3.  Drag any fields from the **Field Explorer** into the sections in the form.  
  
4.  When you are finished, select **Save and Close**.  
  
5.  Publish customizations to see the new form in the application.  
  
<a name="BKMK_EditQuickCreate"></a>   
## Edit a quick create form  
 While quick create forms support form scripts and business rules, their purpose is different from main forms and they don’t support all the capabilities of main forms. Quick create forms always have one section with three columns. You can’t add additional sections or columns.  
  
 The following controls cannot be added to quick create forms:  
  
-   Sub-grids  
  
-   Quick View Forms  
  
-   Web resources  
  
-   iFrames  
  
-   Notes  
  
-   Bing Maps  
  
If you add a composite field to a quick create form, it will be displayed as separate fields.  
  
### To edit a quick create form  
  
1.  In the solutions explorer, expand the entity that you want and select **Forms**.  
  
2.  In the form list, double-click a form where the **Form Type** is **Quick Create**.  
  
3.  Drag any fields from the **Field Explorer** into the sections in the form.  
  
     See [Configure event handlers](../customize/configure-event-handlers-legacy.md) for information about editing event handlers for form scripts.  
  
4.  When you are finished, select **Save and Close**.  
  
5.  Publish customizations to see the modified form in the application.  



### See also  
 [Create and design forms](../customize/create-design-forms.md)</br>
 [Create and edit quick view forms](../customize/create-edit-quick-view-forms.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]