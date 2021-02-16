---
title: "Create an entity with Dynamics 365 for Customer Engagement | MicrosoftDocs"
description: "Learn how to create an entity"
ms.custom: 
ms.date: 02/13/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
author: Mattp123
ms.assetid: fa04f99d-a5f9-48cb-8bfb-f0f50718ccee
caps.latest.revision: 41
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---
# Create an entity

<a name="BKMK_CreatingEntities"></a>   

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Create a custom entity](/powerapps/maker/common-data-service/data-platform-create-entity)

 Before you create a custom entity, evaluate whether using an existing entity will meet your requirements. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create new metadata or use existing metadata](../customize/create-edit-metadata.md#BKMK_CreateNewOrUseExistingMetadata)  

 Part of the name of any custom entity you create is the customization prefix. This is set based on the solution publisher for the solution you’re working in. If you care about the customization prefix, make sure that you are working in an unmanaged solution or the default solution where the customization prefix is the one you want for this entity. For information about how to change the customization prefix, see [Change the solution publisher prefix](../customize/change-solution-publisher-prefix.md).  

## Overview for creating an entity
 The minimum required fields to create a custom entity are:  


|      Field       |                                                                                                     Description                                                                                                     |
|------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Display Name** |                                                                       This is the singular name for the entity that will be shown in the app.                                                                       |
| **Plural Name**  |                                                                        This is the plural name for the entity that will be shown in the app.                                                                        |
|     **Name**     |                                              This field is pre-populated based on the display name you enter. It includes the solution publisher customization prefix.      |
|  **Ownership**   | You can choose either user or team-owned or organization owned. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Entity ownership](../customize/types-of-entities.md#BKMK_EntityOwnership). |

> [!NOTE]
>  - If you are using [!INCLUDE[tn_Safari](../includes/tn-safari.md)] as your browser, you may receive a timeout error when trying to save or publish a new custom entity. If this occurs we recommend you use a different browser to create entities.  
>  - In order for the entity name to work with [Dynamics 365 for Customer Service embedded knowledge search](https://docs.microsoft.com/dynamics365/customer-engagement/customer-service/set-up-knowledge-management-embedded-knowledge-search), the maximum entity name length including the publisher prefix can’t exceed 24 characters.
 
To create an activity entity, select **Define as an activity entity** before you save the entity. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Activity entities](../customize/types-of-entities.md#BKMK_ActivityEntities)  

 Under **Areas that display this entity**, select which of the areas available in the navigation bar you want this entity to be available from. This isn’t required, but if you need people to be able to discover the entity easily, choose one of these. Making changes here updates the data that defines the navigation pane. You can’t change the settings for system entities. However, you can edit this data to modify where each entity is displayed and how it is displayed by editing the sitemap.  

 There are a number of options that are set by default. If you’re not sure you want these for your custom entity, disable them before you save. You can always choose to enable them later, but certain options can’t be disabled after they are enabled. **Notes**, **Activities**, and **Connections** are enabled by default and can’t be disabled later. For more information about available options, see [Edit an entity](../customize/edit-entities.md).  

 Each custom entity has a primary field. This is defined in the **Primary Field** tab. This field is used when records for the entity are displayed in a list. The primary field is typically a link that opens the record. This field must be a **Single Line of Text** field with the format of **Text**. When creating the entity the only value that can’t be changed later is the **Name**. By default the **Display Name** is “Name” and the **Name** is your solution publisher customizations prefix, an underscore, and “name”. If this isn’t what you want, change this before you create the entity. After you save the entity, you can’t edit the primary field values from the Primary Field tab for the entity. You must locate this field in the entity fields. You’ll be able to edit it there like any other single line of text field.  

 People with the system administrator or system customizer security roles can see all new custom entities. This allows you to test your custom entities before showing them to people who will use the system. Before people with other security roles can see these entities, you need to edit the security roles and grant access to other users so that they can see them. When the custom entity is created it will be included on the Custom Entities tab for each security role. You must provide at least user-level read access to the custom entity before people will be able to see it in the apps.  

 When a new entity is created, a number of metadata and supporting system records are created for it. You continue editing the entity by working with these.  

## Create an entity
As an app maker or customizer, you can create and edit entities by using solution explorer.
1. Sign in to your Dynamics 365 Customer Engagement (on-premises) instance. 
2. Start solution explorer. **Settings** > **Customizations** > **Customize the System**.
3. In the **Component Type** list, select **New**, and then select **Entity**.
4. Enter the following required information. For more information about the optional properties available, see [Entity options that can only be enabled](edit-entities.md#entity-options-that-can-only-be-enabled) and [Enable or disable entity options](edit-entities.md#enable-or-disable-entity-options).
   - **Display Name**. Defines the label displayed in apps for entity references and records created that are based on the entity, such as *Widget*. 
   - **Plural Name**. This is the label displayed in apps for references to entity records that may include multiple records, such as *Widgets*. 
   - **Name**. This field is prepopulated based on the **Display Name** you entered and includes the solution publisher customization prefix, such as *new_widget*. You can change the **Display Name** later, but the **Name** can’t be changed after the field is saved. More information: [Change the solution publisher prefix for the default publisher](change-solution-publisher-prefix.md)


### See also
[Create and edit fields (attributes)](create-edit-fields.md) <br />
[Create or edit a main form for an entity](create-edit-main-forms.md) <br />
[Understand views (lists)](create-edit-views.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]