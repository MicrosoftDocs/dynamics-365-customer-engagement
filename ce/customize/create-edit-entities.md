---
title: "Create and edit entities in Dynamics 365 Customer Engagement | MicrosoftDocs"
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
ms.assetid: 02ba7668-028c-4886-9f05-9116a605f3c8
caps.latest.revision: 41
ms.author: "rdubois"
manager: "brycho"
---
# Create and edit entities (record types)
Entities define the types of records people can use in a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organization. In the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] application, you can edit customizable system entities and create, edit, and delete custom entities.  
  
<a name="BKMK_TypesOfEntities"></a>   
## Types of entities  
 Before creating or editing entities you should understand that there are different types of entities. Once a custom entity is created, these types cannot be changed. The two major divisions are based on entity ownership and whether the entities are activity entities.  
  
<a name="BKMK_EntityOwnership"></a>   
### Entity ownership  
 There are four different types of entity ownership. When you create a custom entity the only options are **user or team owned** or **organization-owned**, but you should be aware that other entities have different ownership types.  
  
|Ownership|Description|  
|---------------|-----------------|  
|**Business-owned**|There are 12 business-owned system entities. These include Business Unit, Calendar, Team, Security Role, and User.|  
|**None**|There are 127 system entities that don’t have an owner, but most of these aren’t visible in the solution explorer. These mostly consist of intersect entities created to support Many-to-Many relationships or where access to the record is controlled by a parent record. For example, Opportunity Product records must be accessed through a user or team owned Opportunity record.|  
|**Organization-owned**|There are 68 organization-owned system entities. These include Article, Article Template, Competitor, Currency, and Web Resource.|  
|**User or Team Owned**|There are 59 user or team owned system entities. Because these records are owned by a user or team, they’re connected to a business unit and specific security roles for the business unit. Therefore, these entities participate in role-based security.|  
  
 The custom entities that you create, and most customizable system entities, are either **organization-owned** or **user or team owned**.  
  
> [!IMPORTANT]
>  After an entity is created, you can’t change the ownership. Before you create an entity, make sure that you choose the correct type of ownership. If you later determine that your custom entity must be of a different type, you have to delete it and create a new one. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Deleting custom entities](../customize/create-edit-entities.md#BKMK_DeleteCustomEntities)  
  
<a name="BKMK_ActivityEntities"></a>   
### Activity entities  
 An activity can be thought of as any action for which an entry can be made on a calendar. An activity has time dimensions (start time, stop time, due date, and duration) that help determine when the action occurred or will occur. Activities also contain data that helps determine what action the activity represents, for example, subject and description. An activity can be opened, canceled, or completed. The completed status of an activity will have several sub-status values associated with it to clarify the way that the activity was completed.  
  
 Activity entities can only be owned by a user or team, they can’t be owned by an organization.  
  
 There are 15 system entities that represent activities as shown in the following table.  
  
|Name|Description|Display in activity menus|  
|----------|-----------------|-------------------------------|  
|**Appointment**|Commitment representing a time interval with start/end times and duration.|Yes|  
|**Campaign Response**|Response from an existing or a potential new customer for a campaign.|Yes|  
|**Email**|Activity that is delivered using email protocols.|Yes|  
|**Fax**|Activity that tracks call outcome and number of pages for a fax and optionally stores an electronic copy of the document.|Yes|  
|**Letter**|Activity that tracks the delivery of a letter. The activity can contain the electronic copy of the letter.|Yes|  
|**Phone Call**|Activity to track a telephone call.|Yes|  
|**Recurring Appointment**|The master appointment of a recurring appointment series.|Yes|  
|**Service Activity**|Activity offered by the organization to satisfy its customer's needs. Each service activity includes date, time, duration, and required resources.|Yes|  
|**Task**|Generic activity representing work needed to be done.|Yes|  
|**Campaign Activity**|Task performed, or to be performed, by a user for planning or running a campaign.|No|  
|**Case Resolution**|Special type of activity that includes description of the resolution, billing status, and the duration of the case.|No|  
|**Opportunity Close**|Activity created automatically when an opportunity is closed, containing information such as the description of the closing and actual revenue.|No|  
|**Order Close**|Activity generated automatically when an order is closed.|No|  
|**Quick Campaign**|System operation used to perform lengthy and asynchronous operations on large data sets, such as distributing a campaign activity or quick campaign.|No|  
|**Quote Close**|Activity generated when a quote is closed.|No|  
  
 You can create new custom activity entities. For example you might create a custom activity entity to record instant message communications. Creating an activity entity is different from creating a non-activity entity because you don’t specify a primary field. All activity entities have a **Primary Field** set to **Subject** and other common fields that are defined by the Activity entity. This allows all types of activities to be shown in a view where just the common fields are displayed.  
  
 To create a custom activity entity, select **Define as an activity entity**. After you select this, you’ll see that **Display in Activity Menus** is selected. This setting allows people to create this type of activity in the activity menus. This isn’t selected for activities that are typically associated with specific events and created behind using code or by a workflow. After you save the entity, you can’t change these settings.  
  
<a name="Security"></a>   
## Security considerations: Accessing activities and entities  
 In [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], a user with a specific security role has the same set of privileges to all system and custom activities. You can’t add or remove privileges for individual activities. For example, you can’t give a user the Delete privilege to the system activity, such as Task, and not give the Delete privilege to the custom activities. However, you can give a user different privileges to individual system or custom entities. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Community blog: Custom Entity or Custom Activity](https://community.dynamics.com/crm/b/gonzaloruiz/archive/2012/08/13/custom-entity-or-custom-activity-in-crm-2011)  
  
<a name="BKMK_CreatingEntities"></a>   
## Create entities  
 Before you create a custom entity, evaluate whether using an existing entity will meet your requirements. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create new metadata or use existing metadata](../customize/create-edit-metadata.md#BKMK_CreateNewOrUseExistingMetadata)  
  
 Part of the name of any custom entity you create is the customization prefix. This is set based on the solution publisher for the solution you’re working in. If you care about the customization prefix, make sure that you are working in an unmanaged solution or the default solution where the customization prefix is the one you want for this entity. For information about how to change the customization prefix, see [Solution Publisher](../customize/customization-concepts.md#BKMK_SolutionPublisher).  
  
 For step-by-step instructions to create an entity, see [Create a new entity](http://go.microsoft.com/fwlink/p/?LinkId=316859).  
  
> [!NOTE]
>  If you are using [!INCLUDE[tn_Safari](../includes/tn-safari.md)] as your browser, you may receive a timeout error when trying to save or publish a new custom entity. If this occurs we recommend you use a different browser to create entities.  
  
 The minimum required fields to create a custom entity are:  
  
|Field|Description|  
|-----------|-----------------|  
|**Display Name**|This is the singular name for the entity that will be shown in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].|  
|**Plural Name**|This is the plural name for the entity that will be shown in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].|  
|**Name**|This field is pre-populated based on the display name you enter. It includes the solution publisher customization prefix.|  
|**Ownership**|You can choose either user or team-owned or organization owned. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Entity Ownership](../customize/create-edit-entities.md#BKMK_EntityOwnership).|  
  
 To create an activity entity, select **Define as an activity entity** before you save the entity. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Activity Entities](../customize/create-edit-entities.md#BKMK_ActivityEntities)  
  
 Under **Areas that display this entity**, select which of the areas available in the navigation bar you want this entity to be available from. This isn’t required, but if you need people to be able to discover the entity easily, choose one of these. Making changes here updates the data that defines the navigation pane. You can’t change the settings for system entities. However, you can edit this data to modify where each entity is displayed and how it is displayed by editing the sitemap.  
  
 There are a number of options that are set by default. If you’re not sure you want these for your custom entity, disable them before you save. You can always choose to enable them later, but certain options can’t be disabled after they are enabled. **Notes**, **Activities**, and **Connections** are enabled by default and can’t be disabled later. For more information about available options, see [Edit entities](../customize/create-edit-entities.md#BKMK_EditingEntities).  
  
 Each custom entity has a primary field. This is defined in the **Primary Field** tab. This field is used when records for the entity are displayed in a list. The primary field is typically a link that opens the record. This field must be a **Single Line of Text** field with the format of **Text**. When creating the entity the only value that can’t be changed later is the **Name**. By default the **Display Name** is “Name” and the **Name** is your solution publisher customizations prefix, an underscore, and “name”. If this isn’t what you want, change this before you create the entity. After you save the entity, you can’t edit the primary field values from the Primary Field tab for the entity. You must locate this field in the entity fields. You’ll be able to edit it there like any other single line of text field.  
  
 People with the system administrator or system customizer security roles can see all new custom entities. This allows you to test your custom entities before showing them to people who will use the system. Before people with other security roles can see these entities, you need to edit the security roles and grant access to other users so that they can see them. When the custom entity is created it will be included on the Custom Entities tab for each security role. You must provide at least user-level read access to the custom entity before people will be able to see it in the application.  
  
 When a new entity is created, a number of metadata and supporting system records are created for it. You continue editing the entity by working with these.  
  
<a name="createVE"></a>   
## Create a virtual entity  
 Virtual entities are a special kind of entity in [!INCLUDE[pn_dyn_365](../includes/pn-dyn-365.md)] that have one or more fields containing data from an external data source.  Once you have a data source record created, you can create a virtual entity by creating a custom entity and clicking the Virtual Entity option on the entity definition. For more information about how to create a virtual entity, see [Create and edit virtual entities](../customize/create-edit-virtual-entities.md).  
  
<a name="BKMK_EditingEntities"></a>   
## Edit entities  
 You can edit any custom entities that you create. System entities or managed custom entities may have limitations about changes you can make.  
  
 System entities are any entities that are included with [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. Managed custom entities are entities that have been added to the system by importing a managed solution. The degree to which you can edit these entities is determined by the managed properties set for each entity. Any properties that can’t be edited will be disabled. To view the [Managed properties](../customize/customization-concepts.md#BKMK_ManagedProperties) for an entity selected in the solution explorer, click the **Managed Properties** button in the menu bar.  
  
> [!NOTE]
>  You must publish customizations after you save changes to an existing entity. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Publishing Customizations](../customize/customization-concepts.md#BKMK_PublishingCustomizations)  
  
 When you edit entities you can make the following metadata changes:  
  
- **Edit the entity fields**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Creating and editing fields](../customize/create-edit-fields.md)  
  
- **Edit the entity relationships**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Creating and editing entity relationships](../customize/create-edit-entity-relationships.md)  
  
 You can also make changes to records that support the entity:  
  
- **Forms**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Creating and designing forms](../customize/create-design-forms.md)  
  
- **Business Rules**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Creating and editing business rules](../customize/create-edit-business-rules.md)  
  
 For your custom entities you can change the **Areas that display this entity**, but for system entities or managed custom entities you will find that the options are disabled.  
  
<a name="BKMK_ChangeEntityName"></a>   
### Change the name of an entity  
 Use the **Display Name** and **Plural Name** properties to change the name of the entity in the application. However, the name of many system entities may also be used in other text in the application. To locate and change text where this name was used, see [Edit system entity messages](../customize/create-edit-entities.md#BKMK_EditSystemEntityMessages).  
  
<a name="BKMK_ChangeEntityIcon"></a>   
### Change the icons used for custom entities  
 By default, all custom entities in the web application have the same icons. You can create image web resources for the icons you want for your custom entities and set them using the **Update Icons** button on the toolbar. There are two sizes of icons:  
  
- **Icon in Web Application** This icon should be 16x16 pixels.  
  
- **Icon for Entity Forms** This icon should be 32x32 pixels.  
  
 Both icons should be no larger than 10 KB. PNG format files with transparent backgrounds are recommended. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Change entity icons](http://go.microsoft.com/fwlink/p/?LinkId=316860).  
  
> [!NOTE]
> [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)] and [!INCLUDE[pn_Mobile_Express_long](../includes/pn-mobile-express-long.md)] don’t display custom icons for custom entities.  
  
<a name="BKMK_EnableOptions"></a>   
### Entity options that can only be enabled  
 The following table lists the options that you can enable for an entity, but after these items are enabled, they can’t be disabled:  
  
|Option|Description|  
|------------|-----------------|  
|**Business process flows**|Create business process flows for this entity. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Business Process Flows](../customize/business-process-flows.md)|  
|**Notes**|Append notes to records for this entity. Notes include the ability to add attachments.|  
|**Activities**|Associate activities to records for this entity.|  
|**Connections**|Use the connections feature to show how records for this entity have connections to records of other entities that also have connections enabled.|  
|**Sending e-mail (if an e-mail field does not exist, one will be created)**|Send emails using an email address stored in one of the fields for this entity. If a **Single Line of Text** field with format set to **email** doesn’t already exist for this entity, a new one will be created when you enable sending email.|  
|**Queues**|Use the entity with queues. Queues improve routing and sharing of work by making records for this entity available in a central place that everyone can access.|  
  
<a name="BKMK_EnableDisableOptions"></a>   
### Enable or disable entity options  
 The following table lists the entity options that you can enable or disable at any time.  
  
|Option|Description|  
|------------|-----------------|  
|**Primary Image**|System entities that support images will already have an **Image** field. You can choose whether to display data in this field as the image for the record by setting this field to **[None]** or **Default Image**.<br /><br /> For custom entities you must first create an image field. Each entity can have only one image field. After you create one, you can change this setting to set the primary image. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Image fields](../customize/create-edit-fields.md#BKMK_ImageFields)|  
|**Mail Merge**|People can use this entity with mail merge.|  
|**Document Management**|After other tasks have been performed to enable document management for your organization, enabling this feature allows for this entity to participate in integration with [!INCLUDE[pn_ms_SharePoint_long](../includes/pn-ms-sharepoint-long.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage SharePoint documents from within Microsoft Dynamics 365](http://go.microsoft.com/fwlink/p/?LinkId=320378)|  
|**Duplicate Detection**|If duplicate detection is enabled for your organization, enabling this allows you to create duplicate detection rules for this entity. For information about enabling duplicate detection, see [Turn duplicate detection on or off](http://go.microsoft.com/fwlink/p/?LinkId=320379).|  
|**Allow Quick Create**|After you have created and published a **Quick Create Form** for this entity, people will have the option to create a new record using the **Create** button in the navigation pane. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Creating and designing forms](../customize/create-design-forms.md)<br /><br /> When this is enabled for a custom activity entity, the custom activity will be visible in the group of activity entities when people use the **Create** button in the navigation pane. However, because activities don’t support quick create forms, the main form will be used when the custom entity icon is clicked.|  
|**Auditing**|When auditing is enabled for your organization, this allows for changes to entity records to be captured over time. When you enable auditing for an entity, auditing is also enabled on all its fields. You can select or clear fields that you want to enable auditing on.|  
|**Access Teams**|Create team templates for this entity. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [About team templates](http://go.microsoft.com/fwlink/p/?LinkId=316513)|  
|**Enable for phone express**|Make this entity available to the [!INCLUDE[pn_microsoft_dynamics_crm_for_phones_express](../includes/pn-microsoft-dynamics-crm-for-phones-express.md)] app.|  
|**Enable for mobile**|Make this entity available to the Dynamics 365 for phones and tablets apps. You also have the option to make this entity **Read-only in mobile**.<br /><br /> If the forms for an entity require an extension not supported in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] for phones and tablets, such as iFrame or web resource controls, use this setting to ensure that mobile app users can’t edit the data for these entities.|  
|**Offline capability for Dynamics 365 for Outlook**|People using [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../includes/pn-microsoft-dynamics-crm-for-outlook.md)] can choose to include data from this entity with the data they take offline. **Warning:**  Each entity that you enable for offline capability directly affects the time required for people to synchronize data when they come back online. This is especially true for people with less powerful computers. Carefully consider if an entity must be available for people while working offline.|  
|**Reading pane in Dynamics 365 for Outlook**|Records for this entity can display in a read-only view in [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Dynamics 365 for Outlook reading pane](../customize/main-form-presentations.md#BKMK_ReadingPane)|  
  
<a name="BKMK_EditSystemEntityMessages"></a>   
## Edit system entity messages  
 The default display name of some system entities are used in user interface text and error messages in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. If you change the display name, you should also update any messages that use the default display name. For example, if you change the display name from “Account” to “Company,” you could still see an error message using the old name.  
  
 In the solution explorer, below the entity, if you see a **Messages** node you can edit certain text that includes references to the original entity display name. Editing this text is straightforward. Open the message to see a form with three fields:  
  
|Field|Description|  
|-----------|-----------------|  
|**Default Display String**|Shows the original text.|  
|**Custom Display String**|Edit this text to change the display string.|  
|**Comment**|Optional. Include a comment about what you changed and why.|  
  
 Some of the message text may have placeholders in them. These placeholders are numbers with brackets on either side. For example: {0}. These placeholders allow for text to be inserted  in the message. If you edit messages, make sure that you keep these placeholders.  
  
<a name="BKMK_DeleteCustomEntities"></a>   
## Delete custom entities  
 As someone with the system administrator security role, you can delete custom entities that aren’t part of a managed solution.  
  
> [!IMPORTANT]
>  When you delete a custom entity, the database tables that store data for that entity are deleted and all data they contain is lost. Any associated records that have a parental relationship to the custom entity are also deleted. For more information about parental relationships, see [Creating and editing entity relationships](../customize/create-edit-entity-relationships.md).  
  
 Before you can delete a custom entity, you must remove any dependencies that exist in other solution components. For example, if another entity has a lookup field on a form that uses this custom entity, you must first remove that field from the form before you can delete the custom entity. This also applies to views defined for other entities that include a reference to this entity. If you try to delete the entity and any dependencies are discovered, the deletion won’t be allowed. Click or tap **Show Dependencies** on the menu bar to help identify any dependencies that you have to remove before the entity can be deleted.  
  
 The only way to recover data from an entity that was deleted is to restore the database from a point before the entity was deleted.  
  
<a name="BKMK_ManagedProperties"></a>   
## Set managed properties  
 [Managed properties](../customize/customization-concepts.md#BKMK_ManagedProperties) only apply when you include an entity with a managed solution and import it into another organization. These settings allow a solution developer to have some control over the level of customization that they want to allow people who install their solution to have. To set managed properties for an entity, select the entity and click **Managed Properties** on the menu bar.  
  
 The **Can be customized** option controls all the other options. If this option is `False`, none of the other settings apply. When it is `True`, you can specify the other customization options.  
  
 Entities have more managed properties than any other type of solution component. If the entity is customizable, you can set the following options:  
  
- **Display name can be modified**  
  
- **Can Change Additional Properties**  
  
- **New forms can be created**  
  
- **New charts can be created**  
  
- **New views can be created**  
  
 Except for **Can Change Additional Properties**, these options should be self-explanatory. The **Can Change Additional Properties** property simply means anything not covered by the other options. If you set all the individual options to `False`, you might as well set **Can be customized** to `False`.  
  
### See also  
 [Use virtual entities to seamlessly integrate data from an external data source_deleted](Use-Virtual-Entities-seamlessly-integrate-data-external-data-source_deleted.md)   
 [Entities and metadata overview](../customize/create-edit-metadata.md)   
 [Create and edit fields](../customize/create-edit-fields.md)   
 [Create and edit entity relationships](../customize/create-edit-entity-relationships.md)   
 [Create and edit global option sets](../customize/create-edit-global-option-sets.md)   
 [Community blog: Custom Entity or Custom Activity](https://community.dynamics.com/crm/b/gonzaloruiz/archive/2012/08/13/custom-entity-or-custom-activity-in-crm-2011)
