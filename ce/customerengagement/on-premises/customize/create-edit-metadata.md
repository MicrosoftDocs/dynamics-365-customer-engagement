---
title: "Entities and metadata overview in Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
description: "Learn about entities and metadata"
ms.custom: 
ms.date: 11/09/2018
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
author: Mattp123
ms.assetid: 88b18946-474c-4c94-8e4c-27532f930757
caps.latest.revision: 28
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---

# Entities, metadata, and the metadata browser

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Entities and metadata in Dataverse](/powerapps/maker/common-data-service/create-edit-metadata)

This topic looks at metadata and how you can use it to create Dynamics 365 Customer Engagement (on-premises) or customize an existing [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] app.  

<a name="BKMK_Metadata"></a>

## Metadata used with customization  
 *Metadata* means data about data. Dynamics 365 Customer Engagement (on-premises) provides a flexible platform for you because it is relatively easy to edit the definitions of the data that the environment will use. In Dynamics 365 Customer Engagement (on-premises) the metadata is a collection of entities. Entities describe the kinds of data which is stored in the database.  Each entity corresponds to a database table and each field (also known as attribute) within an entity represents a column in that table. Entity metadata is what controls the kinds of records you can create and what kind of actions can be performed on them. Using only the entity metadata and web services a developer can write code to perform actions with data on your environment. You have the ability to edit this metadata with the customization tools to create or edit entities, fields, and entity relationships.  

 The web application or different clients people use to interact with the data in your environment depend on the entity metadata and adapt as the entity metadata changes. But these clients also depend on other data to control what visual elements to display, any custom logic to apply, and how to apply security. This system data is also stored within entities but the entities themselves are not available for customization.  


<a name="BKMK_MetadataBrowser"></a>

## Use the metadata browser  
 The solution explorer provides access to all the entities that you can customize, but this is just a fraction of all the entities that define the metadata used in the system. For most basic customization tasks the information presented within the solution explorer is going to be all you need. Developers frequently need more information and an easy way to see the metadata. If you need to have in-depth discussions with developers about metadata or if you just want to have a deeper understanding of the metadata, try installing the Metadata Browser solution. The Metadata browser is a managed solution containing only HTML web resources that you can install that will let you view all the metadata and filter entities and fields to gain a better understanding of what the metadata contains.  

### Download and install the metadata browser 
Use the appropriate link below to download the metadata browser solution so you can install it.


|                                                                                               Version                                                                                                |                                                                                     Download                                                                                      |
|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|                                                              [!INCLUDE[pn_crm_9_0_0_online](../includes/pn-crm-9-0-0-online.md)] (v9.0)                                                              | [Microsoft Downloads: MetadataBrowser_3_0_0_5_managed.zip](https://download.microsoft.com/download/8/E/3/8E3279FE-7915-48FE-A68B-ACAFB86DA69C/MetadataBrowser_3_0_0_5_managed.zip) |
| [!INCLUDE[pn_dyn_365](../includes/pn-dyn-365.md)] (v8.2\) [!INCLUDE[pn_crm_8_1_0_online](../includes/pn-crm-8-1-0-online.md)] and [!INCLUDE[pn_crm_8_1_0_op](../includes/pn-crm-8-1-0-op.md)] (v8.1) | [Microsoft Downloads: MetadataBrowser_3_0_0_4_managed.zip](https://download.microsoft.com/download/C/5/D/C5DEA99B-5CD1-40BA-BAB8-15CDC956FDAB/MetadataBrowser_3_0_0_4_managed.zip) |
|                                                                         Dynamics CRM Online 2016 Update and CRM 2016 (v8.0)                                                                          | [Microsoft Downloads: MetadataBrowser_3_0_0_2_managed.zip](https://download.microsoft.com/download/6/D/3/6D341DDC-01B4-44A3-925D-D9188342E3B4/MetadataBrowser_3_0_0_2_managed.zip) |

#### Install the solution
After you download the solution, you must install it. For information about how to install a managed solution, see [Import, update, and export solutions](import-update-upgrade-solution.md)  

#### Open as an app
The [!INCLUDE[pn_crm_9_0_0_online](../includes/pn-crm-9-0-0-online.md)] (v9.0) version is configured as an app. After you install the **Entity Metadata Browser** solution, locate the **Metadata Tools** app and open it. **Entities** is the default view. From the **Tools** navigation area you can select **Entity Metadata** to inspect individual entities.

#### Open from the solution configuration page
For earlier versions you must use the following steps, but these also work for the latest verison.  

After you install the **Entity Metadata Browser** solution, open the managed solution by double-clicking the row in the solutions list and view the **Configuration** page to view information about the Entity Metadata Browser and buttons to launch two different views.
- **Metadata Browser** is equivilent to the **Entities** view in the app.
- **Entity Metadata Browser** is equivilent to the **Entity Metadata** view in the app.

#### Entities view
You can perform the following actions:

- **View Entity Details**: Select an entity to view using the **Entity Metadata** view.
- **Edit Entity**: Open the selected entity form in the default organization, if the entity supports this.
- **Text Search**: Perform a text search to filter displayed entities using the following entity properties: `SchemaName`, `LogicalName`, `DisplayName`, `ObjectTypeCode`, and `MetadataId`.
- **Filter Entities**: Set simple criteria to view a sub-set of entities. All criteria are evaluated using AND logic.
- **Filter Properties**: Filter the properties displayed for any selected entity. There are nearly 100 properties in the list. Use this to select just the ones you are interested in.

#### Entity Metadata view
 You can perform the following actions for a single entity:

- **Entity**: Change the entity that you want to view.
- **Properties**: View all the properties for the entity and filter the properties displayed.

    - **Edit Entity**: Open the selected entity edit form in the default organization, if the entity supports this.
    - **Filter Properties**: Filter the properties displayed for any selected entity. There are nearly 100 properties in the list. Use this to select just the ones you are interested in.

- **Attributes**: View the entity attributes in a master/detail view. With this view you can:

    - **Edit Attribute**: Open the selected attribute form in the default organization, if the attribute supports this.
    - **Text Search**: Perform a text search to filter displayed attributes using the following attribute properties: `SchemaName`, `LogicalName`, `DisplayName`, and `MetadataId`.
    - **Filter Attributes**: Filter attributes by any attribute property values.
    - **Filter Properties**: Filter the properties displayed for the selected attribute.

- **Keys**: If alternate keys are enabled for an entity you can examine how they are configured. More information: [Define alternate keys](../customize/define-alternate-keys-reference-records.md)

- **Relationships**: View the three types of entity relationships: One-To-Many, Many-To-One, and Many-To-Many. With these views you can:  
    - **Edit Relationship**: Open the selected relationship form in the default organization, if the relationship supports this.  
    - **Text Search**: Perform a text search to filter displayed relationships using values relevant to the type of relationship.  
    - **Filter Properties**: Filter the relationship by any relationship property value.

- **Privileges**: View entity privileges. With this view you can:  
    - Filter the displayed privilege using the `PrivilegeId`.

> [!NOTE]
> When viewing the entity detail properties, you’ll see that many complex properties are expandable. The most useful value is displayed with a link that allows toggling to a more detailed view. The detailed view reflects the structure of the data if you were to retrieve it programmatically. The detailed view also reveals other relevant data that can be retrieved in the same area, for example, if any localized labels are present for **Display Name** properties.

> [!TIP]
> To copy text from the page, simply select the text and use the Ctrl+C keyboard shortcut or the context menu **Copy** command. 

<a name="BKMK_CreateNewOrUseExistingMetadata"></a>

## Create new metadata or use existing metadata  
 Dynamics 365 Customer Engagement (on-premises) comes with a number of system entities that support core business application capabilities. For example, data about your customers or potential customers is intended to be stored using the account or contact entities. The lead entity is where information about prospects or potential sales opportunities should be kept. The opportunity entity is intended to be used to track potential revenue generating events.  

 Each of these entities also contain a number of fields that represent common data that the system may need to store for the respective entity.  

 For most organizations it is to your advantage to use the system entities and attributes for the purposes they were provided. Even though you can create new custom entities, system entities may have special capabilities that you will not be able to easily replicate without writing code.  

 For example,  

- Lead entity records can be qualified. This qualification action will deactivate the lead and create a new opportunity and account or contact record to allow moving forward in your business process.  

- Case entity records have a special connection with contract entities to help define entitlements for customer services.  

  If you want to install a solution you can expect that the solution developer has leveraged the system entities and attributes. Creating a new custom entity that replaces a system entity or attribute will mean that any solutions available may not work for your organization.  

  For these reasons, we recommend that you use the provided system entities and fields when they make sense for your organization. If they don’t make sense and can’t be edited to match your need, you should evaluate if creating a new entity is required. Remember that you can change the display name of an entity so that it matches the nomenclature your organization uses. For example, it is very common for people to change the display name of the account entity to “Company” or the name of the contact entity to “Individual”. This can be done to entities or attributes without changing the behavior of the entity. For more information about renaming entities, see [Change the name of an entity](../customize/edit-entities.md#BKMK_ChangeEntityName).  

  You can’t delete system entities or fields. They are considered part of the system solution and every organization is expected to have them. If you want to hide a system entity, change the security role privileges for your organization to remove the read privilege for that entity. This will remove the entity from most parts of the application. If there is a system field that you don’t need, remove it from the form and any views that use it. Change the **Searchable** value in the field definition so that it does not appear in advanced find. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Creating and editing fields](../customize/create-edit-fields.md)  

<a name="BKMK_LimitationsOnMetadata"></a>   
## Limitations on creating metadata items  
 There is a limit to the number of entities you can create. You can find information about the maximum number in the **Resources In Use** page. If you need more custom entities, contact Dynamics 365 Customer Engagement (on-premises) technical support. This upper limit can be adjusted.  

 Within each entity there is an upper limit on the number of fields you can create. This limit is based on the technical limitations on the amount of data that can be stored in a row of a database table. It is difficult to provide a specific number because each type of field can use a different amount of space. The upper limit depends on the total space used by all the fields for the entity.  

 Most people do not create enough custom fields to reach the limit, but if you find yourself planning to add hundreds of custom fields to an entity, you should consider if this is the best design. Do all the fields you plan to add describe properties for a record for that entity? Do you really expect that people using your organization will be able to manage a form that includes such a high number of fields? The number of fields you add to a form increase the amount of data that has to be transferred each time a record is edited and will affect the performance of the system. Take these factors into consideration when you are adding custom fields to an entity.  

 Option set fields provide a set of options that will be displayed in a drop-down control on a form or in picklist control when using advanced find. Your environment can support thousands of options within an Option set, but you shouldn’t consider this as the upper limit. Usability studies have shown that people have trouble using a system where a drop-down control provides large numbers of options. Use option set field to define categories for data. Don’t use option set fields to select categories that actually represent separate items of data. For example, rather than maintain an option set field that stores each of hundreds of possible manufacturers of a type of equipment, consider creating an entity that stores references to each manufacturer and use a lookup field instead of an option set.  
 
 Views are limited to 1000 attributes per view. If a view is created on an entity that exceeds this limit, then a subset of available attributes must be used in the view. Adding an attribute over the 1000 limit will result in an error message indicating the maximum number of attributes has been exceeded. 

### See also  
 [Create and edit entities](../customize/create-edit-entities.md)   
 [Create and edit entity relationships](../customize/create-edit-entity-relationships.md)   
 [Create and edit fields](../customize/create-edit-fields.md) <br/>      
 [Create and design forms](../customize/create-design-forms.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]