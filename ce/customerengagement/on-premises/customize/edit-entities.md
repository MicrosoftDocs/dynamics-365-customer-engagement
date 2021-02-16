---
title: "Edit an entity | MicrosoftDocs"
description: "Learn the different ways that an entity can be edited"
ms.custom: 
ms.date: 11/03/2018
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
author: Mattp123
ms.assetid: 8b00780c-74f0-4e3a-b570-b9289d0d5383
caps.latest.revision: 41
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---
# Edit an entity

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Edit an entity in Power Apps](/powerapps/maker/common-data-service/edit-entities)

<a name="BKMK_EditingEntities"></a>   

You can edit any custom entity that you create. System entities or managed custom entities may have limitations about changes you can make.  

 System entities are any entities that are included with your environment. Managed custom entities are entities that have been added to the system by importing a managed solution. The degree to which you can edit these entities is determined by the managed properties set for each entity. Any properties that can’t be edited will be disabled. To view the [Managed properties](../customize/set-managed-properties.md) for an entity selected in the solution explorer, select **Managed Properties** on the menu bar.  

> [!NOTE]
>  You must publish customizations after you save changes to an existing entity. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Publishing Customizations](../customize/getting-started-customization.md#BKMK_PublishingCustomizations)  

 When you edit entities you can make the following metadata changes:  

- **Edit the entity fields**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit fields](../customize/create-edit-fields.md)  

- **Edit the entity relationships**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit entity relationships](../customize/create-edit-entity-relationships.md)  

  You can also make changes to records that support the entity:  

- **Forms**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and design forms](../customize/create-design-forms.md)  

- **Business Rules**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a business process flow to standardize processes](../customize/create-business-process-flow.md)  

  For your custom entities you can change the **Areas that display this entity**, but for system entities or managed custom entities you will find that the options are disabled.  

<a name="BKMK_ChangeEntityName"></a>   
## Change the name of an entity  
 Use the **Display Name** and **Plural Name** properties to change the name of the entity in the application. However, the name of many system entities may also be used in other text in the application. To locate and change text where this name was used, see [Edit system entity messages](../customize/edit-system-entity-messages.md).  

<a name="BKMK_ChangeEntityIcon"></a>   
## Change the icons used for custom entities  
 By default, all custom entities in the web application have the same icons. You can create image web resources for the icons you want for your custom entities and set them using the **Update Icons** button on the toolbar. There are two sizes of icons:  

- **Icon in Web Application** This icon should be 16x16 pixels.  

- **Icon for Entity Forms** This icon should be 32x32 pixels.  

  Both icons should be no larger than 10 KB. PNG format files with transparent backgrounds are recommended. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Change icons for custom entities](../customize/change-custom-entity-icons.md).  

> [!NOTE]
> [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)] and [!INCLUDE[pn_Mobile_Express_long](../includes/pn-mobile-express-long.md)] don’t display custom icons for custom entities.  

<a name="BKMK_EnableOptions"></a>   
## Entity options that can only be enabled  
 The following table lists the options that you can enable for an entity, but after these items are enabled, they can’t be disabled:  


|                                   Option                                    |                                                                                                                   Description                                                                                                                   |
|-----------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|                         **Business process flows**                          |         Create business process flows for this entity. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a business process flow to standardize processes](../customize/create-business-process-flow.md)          |
|                                  **Notes**                                  |                                                                             Append notes to records for this entity. Notes include the ability to add attachments.                                                                              |
|                               **Activities**                                |                                                                                                Associate activities to records for this entity.                                                                                                 |
|                               **Connections**                               |                                                Use the connections feature to show how records for this entity have connections to records of other entities that also have connections enabled.                                                |
| **Sending e-mail (if an e-mail field does not exist, one will be created)** | Send emails using an email address stored in one of the fields for this entity. If a **Single Line of Text** field with format set to **email** doesn’t already exist for this entity, a new one will be created when you enable sending email. |
|                                 **Queues**                                  |                                         Use the entity with queues. Queues improve routing and sharing of work by making records for this entity available in a central place that everyone can access.                                         |

<a name="BKMK_EnableDisableOptions"></a>   
## Enable or disable entity options  
 The following table lists the entity options that you can enable or disable at any time.  


|            Option            |                                                                                                                                                                                                                                                                                                                                          Description                                                                                                                                                                                                                                                                                                                                          |
|------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|      **Primary Image**       |                                                                  System entities that support images will already have an **Image** field. You can choose whether to display data in this field as the image for the record by setting this field to **[None]** or **Default Image**.<br /><br /> For custom entities you must first create an image field. Each entity can have only one image field. After you create one, you can change this setting to set the primary image. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Image fields](../customize/types-of-fields.md#BKMK_ImageFields)                                                                   |
|        **Mail Merge**        |                                                                                                                                                                                                                                                                                                                          People can use this entity with mail merge.                                                                                                                                                                                                                                                                                                                          |
|   **Document Management**    |                                                                                                                                            After other tasks have been performed to enable document management for your organization, enabling this feature allows for this entity to participate in integration with [!INCLUDE[pn_ms_SharePoint_long](../includes/pn-ms-sharepoint-long.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up SharePoint integration](../admin/set-up-sharepoint-integration.md)                                                                                                                                             |
|   **Duplicate Detection**    |                                                                                                                                                                           If duplicate detection is enabled for your organization, enabling this allows you to create duplicate detection rules for this entity. For information about enabling duplicate detection, see [Turn duplicate detection rules on or off for the whole organization](/power-platform/admin/turn-duplicate-detection-rules-off-whole-organization).                                                                                                                                                                            |
|    **Allow Quick Create**    |                After you have created and published a **Quick Create Form** for this entity, people will have the option to create a new record using the **Create** button in the navigation pane. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and design forms](../customize/create-design-forms.md)<br /><br /> When this is enabled for a custom activity entity, the custom activity will be visible in the group of activity entities when people use the **Create** button in the navigation pane. However, because activities don’t support quick create forms, the main form will be used when the custom entity icon is clicked.                |
|         **Auditing**         |                                                                                                                                                                                                          When auditing is enabled for your organization, this allows for changes to entity records to be captured over time. When you enable auditing for an entity, auditing is also enabled on all its fields. You can select or clear fields that you want to enable auditing on.                                                                                                                                                                                                          |
|       **Access Teams**       |                                                                                                                                                                                                                                                            Create team templates for this entity. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [About team templates](../admin/about-team-templates.md)                                                                                                                                                                                                                                                            |
| **Enable for phone express** |                                                                                                                                                                                                                                                                               Make this entity available to the [!INCLUDE[pn_microsoft_dynamics_crm_for_phones_express](../includes/pn-dyn-365-phones.md)] app.                                                                                                                                                                                                                                                                               |
|    **Enable for mobile**     | Make this entity available to the Dynamics 365 for phones and tablets apps. You also have the option to make this entity **Read-only in mobile**.<br /><br /> If the forms for an entity require an extension not supported in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] for phones and tablets, such as iFrame or web resource controls, use this setting to ensure that mobile app users can’t edit the data for these entities.</br><br />**Important:** If you have previously installed any portal solution, to create a case in the Customer Service Hub or to use the Merge cases command, you must turn off the **Read-only in mobile option** for the Case entity. |

### See also
[Create or edit an entity (overview)](create-edit-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]