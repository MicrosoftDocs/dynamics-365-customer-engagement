---
title: "Entities and metadata overview in Dynamics 365 Customer Engagement | MicrosoftDocs"
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
ms.assetid: 88b18946-474c-4c94-8e4c-27532f930757
caps.latest.revision: 28
ms.author: "rdubois"
manager: "brycho"
---
# Entities, metadata, and the metadata browser
This topic looks at metadata and how you can use it to customize your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment.  
  
<a name="BKMK_Metadata"></a>   
## Metadata used with customization  
 *Metadata* means data about data. [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] provides a flexible platform for your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] deployment because it is relatively easy to edit the definitions of the data that the deployment will use. In [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] the metadata is a collection of entities. Entities describe the kinds of data which is stored in the database.  Each entity corresponds to a database table and each field (also known as attribute) within an entity represents a column in that table. Entity metadata is what controls the kinds of records you can create and what kind of actions can be performed on them. Using only the entity metadata and the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] web services a developer can write code to perform actions with data on your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] organization. You have the ability to edit this metadata with the customization tools to create or edit entities, fields, and entity relationships.  
  
 The web application or different clients people use to interact with the data in your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] organization depend on the entity metadata and adapt as the entity metadata changes. But these clients also depend on other data to control what visual elements to display, any custom logic to apply, and how to apply security. This system data is also stored within entities but the entities themselves are not available for customization.  
  
<a name="BKMK_MetadataBrowser"></a>   
## Use the metadata browser  
 The solution explorer provides access to all the entities that you can customize, but this is just a fraction of all the entities that define the metadata used for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. For most basic customization tasks the information presented within the solution explorer is going to be all you need. Developers frequently need more information and an easy way to see the metadata. If you need to have in-depth discussions with developers about metadata or if you just want to have a deeper understanding of the metadata, try installing the Metadata Browser solution that is included in the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)]. The Metadata browser is a managed solution containing only HTML web resources that you can install that will let you view all the metadata and filter entities and fields to gain a better understanding of what the metadata contains.  
  
#### Download and install the metadata browser  
  
1. [!INCLUDE[sdk_download](../includes/sdk-download.md)]  
  
2.  Run MicrosoftDynamicsCRM2016SDK.exe to extract the contents to a folder of your choice on your computer.  
  
3.  In the folder containing the extracted SDK files, navigate to the `sdk\tools\metadatabrowser` folder.  
  
4.  In that folder you will find a managed solution file (MetadataBrowser_2_0_0_3_managed.zip) and a readme.docx file containing information about the solution.  
  
5.  Install the managed solution. See [Import Solutions](../customize/use-solutions-for-your-customizations.md#BKMK_ImportSolutions) for more information.  
  
6.  After you install the solution you will see it in the list of solutions. Click the solution to open it.  
  
7.  On the **Configuration** tab you will find instructions about how to use the metadata browser and buttons to open the pages it contains.  
  
<a name="BKMK_CreateNewOrUseExistingMetadata"></a>   
## Create new metadata or use existing metadata  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] comes with a number of system entities that support core [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] capabilities. For example, data about your customers or potential customers is intended to be stored using the account or contact entities. The lead entity is where information about prospects or potential sales opportunities should be kept. The opportunity entity is intended to be used to track potential revenue generating events.  
  
 Each of these entities also contain a number of fields that represent common data that [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] systems may need to store for the respective entity.  
  
 For most organizations it is to your advantage to use the system entities and attributes for the purposes they were provided. Even though you can create new custom entities, system entities may have special capabilities that you will not be able to easily replicate without writing code.  
  
 For example,  
  
-   Lead entity records can be qualified. This qualification action will deactivate the lead and create a new opportunity and account or contact record to allow moving forward in your business process.  
  
-   Case entity records have a special connection with contract entities to help define entitlements for customer services.  
  
 If you want to install a solution you can expect that the solution developer has leveraged the system entities and attributes. Creating a new custom entity that replaces a system entity or attribute will mean that any solutions available may not work for your organization.  
  
 For these reasons, we recommend that you use the provided system entities and fields when they make sense for your organization. If they don’t make sense and can’t be edited to match your need, you should evaluate if creating a new entity is required. Remember that you can change the display name of an entity so that it matches the nomenclature your organization uses. For example, it is very common for people to change the display name of the account entity to “Company” or the name of the contact entity to “Individual”. This can be done to entities or attributes without changing the behavior of the entity. For more information about renaming entities, see [Change the name of an entity](../customize/create-edit-entities.md#BKMK_ChangeEntityName).  
  
 You can’t delete system entities or fields. They are considered part of the system solution and every organization is expected to have them. If you want to hide a system entity, change the security role privileges for your organization to remove the read privilege for that entity. This will remove the entity from most parts of the application. If there is a system field that you don’t need, remove it from the form and any views that use it. Change the **Searchable** value in the field definition so that it does not appear in advanced find. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Creating and editing fields](../customize/create-edit-fields.md)  
  
<a name="BKMK_LimitationsOnMetadata"></a>   
## Limitations on creating metadata items  
 With [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] there is a limit to the number of entities you can create. You can find information about the maximum number in the **Resources In Use** page for your deployment. If you need more custom entities, contact [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] technical support. This upper limit can be adjusted. .  
  
 Within each entity there is an upper limit on the number of fields you can create. This limit is based on the technical limitations on the amount of data that can be stored in a row of a database table. It is difficult to provide a specific number because each type of field can use a different amount of space. The upper limit depends on the total space used by all the fields for the entity.  
  
 Most people do not create enough custom fields to reach the limit, but if you find yourself planning to add hundreds of custom fields to an entity, you should consider if this is the best design. Do all the fields you plan to add describe properties for a record for that entity? Do you really expect that people using your organization will be able to manage in a form that includes such a high number of fields? The number of fields you add to a form increase the amount of data that has to be transferred each time a record is edited and will affect the performance of the system. Take these factors into consideration when you are adding custom fields to an entity.  
  
 Option set fields provide a set of options that will be displayed in a drop-down control on a form or in picklist control when using advanced find. [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] can support thousands of options within an Option set, but you shouldn’t consider this as the upper limit. Usability studies have shown that people have trouble using a system where a drop-down control provides large numbers of options. Use option set field to define categories for data. Don’t use option set fields to select categories that actually represent separate items of data. For example, rather than maintain an option set field that stores each of hundreds of possible manufacturers of a type of equipment, consider creating an entity that stores references to each manufacturer and use a lookup field instead of an option set.  
  
### See also  
 [Create and edit entities](../customize/create-edit-entities.md)   
 [Create and edit virtual entities](../customize/create-edit-virtual-entities.md)   
 [Create and edit entity relationships](../customize/create-edit-entity-relationships.md)   
 [Create and edit fields](../customize/create-edit-fields.md) 
 [Create and edit global option sets](../customize/create-edit-global-option-sets.md)   
 [Customize your system](../customize/customize-your-system.md)     
 [Create and design forms](../customize/create-design-forms.md)
