---
title: "Browse the metadata for your organization (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "You can use the Entity Metadata Browser to view entities and their properties in Dynamics 365 Customer Engagement (on-premises). The Entity Metadata Browser is a managed solution you can download and install on your organization."
keywords: 
ms.date: 03/29/2019
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 46306470-dca2-4d4e-8a98-d7a6eb47ecfe
author: JimDaly
ms.author: jdaly
manager: amyla
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 40
topic-status: Drafting
search.audienceType: 
  - developer

---

# Browse the metadata for your organization

You can use the Entity Metadata Browser to view entities and their properties in Dynamics 365 Customer Engagement (on-premises). The Entity Metadata Browser is a managed solution you can download using the links below.


|                                                                                               Version                                                                                                |                                                                                     Download                                                                                      |
|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|                                                              Dynamics 365 Customer Engagement (on-premises)                                                              | [Microsoft Downloads: MetadataBrowser_3_0_0_5_managed.zip](https://download.microsoft.com/download/8/E/3/8E3279FE-7915-48FE-A68B-ACAFB86DA69C/MetadataBrowser_3_0_0_5_managed.zip) |
| [!INCLUDE[pn_dyn_365](../includes/pn-dyn-365.md)] (v8.2\) [!INCLUDE[pn_crm_8_1_0_online](../includes/pn-crm-8-1-0-online.md)] and [!INCLUDE[pn_crm_8_1_0_op](../includes/pn-crm-8-1-0-op.md)] (v8.1) | [Microsoft Downloads: MetadataBrowser_3_0_0_4_managed.zip](https://download.microsoft.com/download/C/5/D/C5DEA99B-5CD1-40BA-BAB8-15CDC956FDAB/MetadataBrowser_3_0_0_4_managed.zip) |
|                                                                         Dynamics CRM Online 2016 Update and CRM 2016 (v8.0)                                                                          | [Microsoft Downloads: MetadataBrowser_3_0_0_2_managed.zip](https://download.microsoft.com/download/6/D/3/6D341DDC-01B4-44A3-925D-D9188342E3B4/MetadataBrowser_3_0_0_2_managed.zip) |

After you download the solution, you must install it. For information about how to install a managed solution, see [Import, update, and export solutions](../customize/import-update-upgrade-solution.md)  

## Open as an app
The [!INCLUDE[pn_crm_9_0_0_online](../includes/pn-crm-9-0-0-online.md)] (v9.0) version is configured as an app. After you install the **Entity Metadata Browser** solution, locate the **Metadata Tools** app and open it. **Entities** is the default view. From the **Tools** navigation area you can select **Entity Metadata** to inspect individual entities.

## Open from the solution configuration page
For earlier versions you must use the following steps, but these also work for the latest verison.  

After you install the **Entity Metadata Browser** solution, open the managed solution by double-clicking the row in the solutions list and view the **Configuration** page to view information about the Entity Metadata Browser and buttons to launch two different views.
- **Metadata Browser** is equivilent to the **Entities** view in the app.
- **Entity Metadata Browser** is equivilent to the **Entity Metadata** view in the app.

## Entities view
You can perform the following actions:

- **View Entity Details**: Select an entity to view using the **Entity Metadata** view.
- **Edit Entity**: Open the selected entity form in the default organization, if the entity supports this.
- **Text Search**: Perform a text search to filter displayed entities using the following entity properties: <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.SchemaName>, <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.LogicalName>, <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.DisplayName>, <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.ObjectTypeCode>, or <xref:Microsoft.Xrm.Sdk.Metadata.MetadataBase.MetadataId>.
- **Filter Entities**: Set simple criteria to view a sub-set of entities. All criteria are evaluated using AND logic.
- **Filter Properties**: Filter the properties displayed for any selected entity. There are nearly 100 properties in the list. Use this to select just the ones you are interested in.

## Entity Metadata view
 You can perform the following actions for a single entity:

- **Entity**: Change the entity that you want to view.
- **Properties**: View all the properties for the entity and filter the properties displayed.

    - **Edit Entity**: Open the selected entity edit form in the default organization, if the entity supports this.
    - **Filter Properties**: Filter the properties displayed for any selected entity. There are nearly 100 properties in the list. Use this to select just the ones you are interested in.

- **Attributes**: View the entity attributes in a master/detail view. With this view you can:

    - **Edit Attribute**: Open the selected attribute form in the default organization, if the attribute supports this.
    - **Text Search**: Perform a text search to filter displayed attributes using the following attribute properties: <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.SchemaName>, <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.LogicalName>, <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.DisplayName>, or <xref:Microsoft.Xrm.Sdk.Metadata.MetadataBase.MetadataId>.
    - **Filter Attributes**: Filter attributes by any attribute property values.
    - **Filter Properties**: Filter the properties displayed for the selected attribute.

- **Keys**: If alternate keys are enabled for an entity you can examine how they are configured.

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

## Community tools

**Metadata Browser** is a tool that XrmToolbox community developed for Dynamics 365 Customer Engagement (on-premises). Please see the [Developer tools](developer-tools.md) topic for community developed tools.

> [!NOTE]
> The community tools are not a product of [!include[pn_microsoft_dynamics](../includes/pn-microsoft-dynamics.md)] and does not extend support to the community tools. 
> If you have questions pertaining to the tool, please contact the publisher. More Information: [XrmToolBox](https://www.xrmtoolbox.com).

### See also

 [Developer Tools for Dynamics 365 Customer Engagement (on-premises)](developer-tools.md)<br />
 [Customize Entity Metadata](customize-entity-metadata.md)<br />
 [Extend the Metadata Model for Dynamics 365 Customer Engagement (on-premises)](org-service/use-organization-service-metadata.md)<br />
 [Create Early Bound Entity Classes with the Code Generation Tool (CrmSvcUtil.exe)](org-service/create-early-bound-entity-classes-code-generation-tool.md)<br />
 [Solution Tools for Team Development](solution-tools-team-development.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]