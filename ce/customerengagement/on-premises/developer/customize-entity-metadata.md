---
title: "Customize entity metadata (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Entities are defined by metadata. By defining or changing the entity metadata, you can control the capabilities of an entity."
ms.custom: 
ms.date: 11/03/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: a55bbb88-a323-4f69-9551-0d2951dd12ec
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Customize entity metadata

Entities are defined by metadata. By defining or changing the entity metadata, you can control the capabilities of an entity. To view the metadata for your organization, use the metadata browser. [Download the metadata browser](https://download.microsoft.com/download/8/E/3/8E3279FE-7915-48FE-A68B-ACAFB86DA69C/MetadataBrowser_3_0_0_5_managed.zip).

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Browse the Metadata for Your Organization](browse-your-metadata.md)  
  
 This topic is about how to work with entities programmatically. See [Create or edit entities (record types)](../customize/create-edit-entities.md)  for information about working with entities in the application.  

Entities can be created using either the Organization service or the Web API. The following information can be applied to both.

- With the Organization service you will use the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata> class. More information: [Create a custom entity](/powerapps/developer/data-platform/org-service/create-custom-entity) and [Retrieve, update, and delete entities](/powerapps/developer/data-platform/org-service/metadata-retrieve-update-delete-entities)
- With the Web API you will use the <xref:Microsoft.Dynamics.CRM.EntityMetadata> EntityType. More information : [Create and update entity definitions using the Web API](/powerapps/developer/data-platform/webapi/create-update-entity-definitions-using-web-api).
 
<a name="BKMK_EntityMetadataMessages"></a>

## Entity metadata operations
How you work with entity metadata depends on which service you use.

Since the Web API is a RESTful endpoint, it uses a different way to create, retrieve, update, and delete metadata. Use `POST`, `GET`, `PUT`, and `DELETE` HTTP verbs to work with metadata entitytypes. More information : [Create and update entity definitions using the Web API](/powerapps/developer/data-platform/webapi/create-update-entity-definitions-using-web-api).

One exception to this is the <xref href="Microsoft.Dynamics.CRM.RetrieveMetadataChanges?text=RetrieveMetadataChanges Function" /> provides a way to compose a metadata query and track changes over time. 

If working with Organization Service, use <xref:Microsoft.Xrm.Sdk.Messages.RetrieveMetadataChangesRequest> class. This class contains the data that is needed to retrieve a collection of metadata records that satisfy the specified criteria. The <xref:Microsoft.Xrm.Sdk.Messages.RetrieveMetadataChangesResponse> returns a timestamp value that can be used with this request at a later time to return information about how metadata has changed since the last request.
   

|                                                                                                                                                                          Message                                                                                                                                                                           |                                               Web API                                                |                           SDK Assembly                           |
|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------|------------------------------------------------------------------|
|                                                                                                                                                                        CreateEntity                                                                                                                                                                        |                         Use a POST request to send data to create an entity.                         |      <xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest>       |
|                                                                                                                                                                        DeleteEntity                                                                                                                                                                        |                              Use a DELETE request to delete an entity.                               |      <xref:Microsoft.Xrm.Sdk.Messages.DeleteEntityRequest>       |
|                                                                                                                                                                    RetrieveAllEntities                                                                                                                                                                     |                               Use GET request to retrieve entity data.                               |   <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesRequest>   |
|                                                                                                                                                                       RetrieveEntity                                                                                                                                                                       |          <xref href="Microsoft.Dynamics.CRM.RetrieveEntity?text=RetrieveEntity Function" />          |     <xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityRequest>      |
|                                                                                                                                                                        UpdateEntity                                                                                                                                                                        |                                Use a PUT request to update an entity.                                |      <xref:Microsoft.Xrm.Sdk.Messages.UpdateEntityRequest>       |
| RetrieveMetadataChanges</br>Used together with objects in the <xref:Microsoft.Xrm.Sdk.Metadata.Query> namespace to create a query to efficiently retrieve and detect changes to specific metadata. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Retrieve and Detect Changes to Metadata](retrieve-detect-changes-metadata.md). | <xref href="Microsoft.Dynamics.CRM.RetrieveMetadataChanges?text=RetrieveMetadataChanges Function" /> | <xref:Microsoft.Xrm.Sdk.Messages.RetrieveMetadataChangesRequest> |

<a name="BKMK_CreationOptions"></a>   
## Options available when you create a custom entity  
 The following table lists the options that are available when you create a custom entity. You can only set these properties when you create a custom entity.  

|Option|Description|  
|------------|-----------------|  
|**Create as custom activity**|You can create an entity that is an activity by setting the `IsActivity` property when using the organization service or Web API respectively. For more information, see [Custom Activities in Dynamics 365 Customer Engagement (on-premises)](custom-activities.md).|  
|**Entity Names**|There are two types of names, and both must have a customization prefix:<br /><br /> `LogicalName`: Name that is the version of the entity name that is set in all lowercase letters.<br /><br /> `SchemaName`: Name that will be used to create the database tables for the entity. This name can be mixed case. The casing that you use sets the name of the object generated for programming with strong types or when you use the REST endpoint.<br /><br /> **Note**: If the logical name differs from the schema name, the schema name will override the value that you set for the logical name.<br /><br /> When an entity is created in the application in the context of a specific solution, the customization prefix used is the one set for the `Publisher` of the solution. When an entity is created programmatically, you can set the customization prefix to a string that is between two and eight characters in length, all alphanumeric characters and it must start with a letter. It cannot start with “mscrm”. The best practice is to use the customization prefix defined by the publisher that the solution is associated with, but this is not a requirement. An underscore character must be included between the customization prefix and the logical or schema name.|  
|**Ownership**|Use the `OwnershipType` property to set this. Use the <xref:Microsoft.Xrm.Sdk.Metadata.OwnershipTypes> enumeration or <xref:Microsoft.Dynamics.CRM.OwnershipTypes> EnumType to set the type of entity ownership. The only valid values for custom entities are `OrgOwned` or `UserOwned`. For more information, see [Entity Ownership](introduction-entities.md#EntityOwnership).|  
|**Primary Attribute**|With the Organization service, use <xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest>.<xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest.PrimaryAttribute> property to set this.<br /><br />With the Web API the JSON defining the entity must include one <xref:Microsoft.Dynamics.CRM.StringAttributeMetadata> with the `IsPrimaryName` property set to true.<br /><br /> In both cases string attribute must be formatted as `Text`. The value of this attribute is what is shown in a lookup for any related entities. Therefore, the value of the field should represent a name for the entity record.|  

<a name="BKMK_OptInOptions"></a>

## Enable entity capabilities  
 The following table lists entity capabilities. You can set these capabilities when you create an entity or you can enable them later. Once enabled, these capabilities cannot be disabled.  

|Capability|Description|  
|----------------|-----------------|  
|**Business Process flows**|Set `IsBusinessProcessEnabled` to true in order to enable the entity for business process flows.|  
|**Notes**| To create an entity relationship with the `Annotation` entity and enable the inclusion of a **Notes** area in the entity form. By including **Notes**, you can also add attachments to records. <br /><br />With the Organization service, use the <xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest> or <xref:Microsoft.Xrm.Sdk.Messages.UpdateEntityRequest> `HasNotes` property <br /><br />With the Web API set the <xref:Microsoft.Dynamics.CRM.EntityMetadata>.`HasNotes` property.|  
|**Activities**|To create an entity relationship with the `ActivityPointer` entity so that all the activity type entities can be associated with this entity.<br /><br /> With the Organization service  use the <xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest> or <xref:Microsoft.Xrm.Sdk.Messages.UpdateEntityRequest> `HasActivities` property. <br /><br /> With the Web API, set the  <xref:Microsoft.Dynamics.CRM.EntityMetadata>.`HasActivities` property.| 
|**Connections**|To enable creating connection records to associate this entity with other connection entities set the `IsConnectionsEnabled.Value` property value to true.|  
|**Queues**|Use the `IsValidForQueue` property to add support for queues. When you enable this option, you can also set the `AutoRouteToOwnerQueue` property to automatically move records to the owner’s default queue when a record of this type is created or assigned.|  
|**E-mail**|Set the `IsActivityParty` property so that you can send e-mail to an e-mail address in this type of record.|  

<a name="BKMK_OpenOptions"></a>   

## Editable entity properties  
 The following table lists entity properties that you can edit. Unless a managed property disallows these options, you can update them at any time.  


|                                        Property                                        |                                                                                                                                                                                                     Description                                                                                                                                                                                                     |
|----------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|                                 **Allow Quick Create**                                 |                                                                                   Use `IsQuickCreateEnabled` to enable quick create forms for the entity. Before you can use quick create forms you must first create and publish a quick create form.<br /> **Note**:<br /> Activity entities do not support quick create forms.                                                                                   |
|                                    **Access Teams**                                    |                                                                                                                                Use `AutoCreateAccessTeams` to enable the entity for access teams. See [About team templates](../admin/about-team-templates.md) for more information.                                                                                                                                |
|                                   **Primary Image**                                    |                                                                                             If an entity has an image attribute you can enable or disable displaying that image in the application using `PrimaryImageAttribute`. For more information see [Entity Images](introduction-entities.md#BKMK_EntityImages).                                                                                             |
|                                **Change display text**                                 |                                                                                             The managed property `IsRenameable` prevents the display name from being changed in the application. You can still programmatically change the labels by updating the `DisplayName` and `DisplayCollectionName` properties.                                                                                             |
|                            **Edit the entity Description**                             |                                                                                                         The managed property `IsRenameable` prevents the entity description from being changed in the application. You can still programmatically change the labels by updating the `Description` property.                                                                                                         |
|                            **Enable for use while offline**                            |                                                                                                          Use `IsAvailableOffline` to enable or disable the ability of [!INCLUDE[pn_crm_outlook_offline_access](../includes/pn-crm-outlook-offline-access.md)] users to take data for this entity offline.                                                                                                           |
|                          **Enable the Outlook Reading Pane**                           | **Note**:<br /><br /> The `IsReadingPaneEnabled` property is [!INCLUDE[internal](../includes/internal.md)]<br /><br /> To enable or disable the ability of [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)] users to view data for this entity, use the [!INCLUDE[pn_MS_Outlook_Short](../includes/pn-ms-outlook-short.md)] reading pane. You must set this property in the application. |
|                                 **Enable Mail Merge**                                  |                                                                                                                 Use `IsMailMergeEnabled` to enable or disable the ability to generate [!INCLUDE[pn_MS_Word_Full](../includes/pn-ms-word-full.md)] merged documents that use data from this entity.                                                                                                                  |
|                             **Enable Duplicate Detection**                             |                                                                                                       Use `IsDuplicateDetectionEnabled` to enable or disable duplicate detection for the entity. For more information, see [Detect Duplicate Data in Dynamics 365 Customer Engagement (on-premises)](detect-duplicate-data-for-developers.md).                                                                                                        |
|                           **Enable SharePoint Integration**                            |                                                          Use `IsDocumentManagementEnabled` to enable or disable [!INCLUDE[pn_SharePoint_Server_short](../includes/pn-sharepoint-server-short.md)] integration for the entity. For more information, see [Enable Document Management for Entities](integration-dev/enable-document-management-entities.md).                                                          |
| **Enable [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)]** |                                                                                                                      Use `IsVisibleInMobile` to enable or disable the ability of [!INCLUDE[pn_Mobile_Express_long](../includes/pn-mobile-express-long.md)] users to see data for this entity.                                                                                                                       |
|              **[!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)]**               |                             Use `IsVisibleInMobileClient` to enable or disable the ability of [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)] users to see data for this entity.<br /><br /> If the entity is available for [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)] you can use `IsReadOnlyInMobileClient` to specify that the data for the record is read-only.                              |
|                                  **Enable Auditing**                                   |                                                                                                              Use `IsAuditEnabled` to enable or disable auditing for the entity. For more information, see [Configure Entities and Attributes for Auditing](configure-entities-attributes-auditing.md).                                                                                                              |
|                        **Change areas that display the entity**                        |                                                                                                                                                  You can control where entity grids appear in the application Navigation Pane. This is controlled by the SiteMap.                                                                                                                                                   |
|                              **Add or Remove Attributes**                              |                                                                                     As long as the managed property `CanCreateAttributes.Value` allows for creating attributes, you can add attributes to the entity. For more information, see [Customize Entity Attribute Metadata](customize-entity-attribute-metadata.md).                                                                                      |
|                                **Add or Remove Views**                                 |                                                                                                                                As long as the managed property `CanCreateViews.Value` allows for creating views, you can use the `SavedQuery` entity to create views for an entity.                                                                                                                                 |
|                                **Add or Remove Charts**                                |              As long as the managed property `CanCreateCharts.Value` allows for creating charts and the `IsEnabledForCharts` entity property is true, you can use the [SavedQueryVisualization Entity](entities/savedqueryvisualization.md) to create charts for an entity. For more information, see [View Data with Visualizations (Charts)](customize-dev/view-data-with-visualizations-charts.md).              |
|                         **Add or Remove Entity Relationships**                         |                                                                                        There are several managed properties that control the types of entity relationships that you can create for an entity. For more information, see [Customize Entity Relationship Metadata](customize-entity-relationship-metadata.md).                                                                                        |
|                                    **Change Icons**                                    |                                                                                                                                             You can change the icons used for custom entities. For more information, see [Modify Entity Icons](modify-icons-entity.md).                                                                                                                                             |
|                        **Can Change Hierarchical Relationship**                        |                                                                                        `CanChangeHierarchicalRelationship.Value` controls whether the hierarchical state of entity relationships included in your managed solutions can be changed. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)]                                                                                         |
  
<a name="BKMK_MessagesForCustomEntites"></a>
 
## Messages supported by custom entities  
 Custom entities support the same base messages as system entities. The set of messages available depends on whether the custom entity is user-owned or organization owned. For more information, see [Actions on Entity Records](introduction-entities.md#ActionsOnEntityRecords).  
  
### See also  
 [Extend the Metadata Model for Dynamics 365 Customer Engagement (on-premises)](org-service/use-organization-service-metadata.md)   
 [Introduction to Entities in Dynamics 365 Customer Engagement (on-premises)](introduction-entities.md)   
 [Browse the Metadata for Your Organization](browse-your-metadata.md)   
 [Customize Entity Attribute Metadata](customize-entity-attribute-metadata.md)   
 [Entity Relationship Metadata](customize-entity-relationship-metadata.md)   
 [Detect Duplicate Data in Dynamics 365 Customer Engagement (on-premises)](detect-duplicate-data-for-developers.md)   
 [Enable Document Management for Entities](integration-dev/enable-document-management-entities.md)   
 [Configure Entities and Attributes for Auditing](configure-entities-attributes-auditing.md)  
 [View Data using Charts (Visualizations)](customize-dev/view-data-with-visualizations-charts.md)   
 [Which Entities are Customizable?](which-entities-are-customizable.md)   
 [Create a Custom Entity](/powerapps/developer/data-platform/org-service/create-custom-entity)   
 [Retrieve, Update and Delete Entities](/powerapps/developer/data-platform/org-service/metadata-retrieve-update-delete-entities)   
 [Create and Update an Emailable Entity](/powerapps/developer/data-platform/org-service/create-update-entity-emailed)   
 [Create a Custom Activity Entity](/powerapps/developer/data-platform/org-service/samples/create-custom-activity)   
 [Modify Entity Icons](modify-icons-entity.md)   
 [Modify Entity Messages](modify-messages-entity.md)   
 [Sample: Create and Update Entity Metadata](/powerapps/developer/data-platform/org-service/create-custom-entity)   
 [Sample: Create a Custom Activity Entity](/powerapps/developer/data-platform/org-service/samples/create-custom-activity)   
 [Sample: Create and Update an Emailable Entity](/powerapps/developer/data-platform/org-service/samples/work-activity-party-records)   
 [Sample: Dump Entity Metadata to a File](/powerapps/developer/data-platform/org-service/samples/dump-entity-metadata-file)   
 [Sample: Dump Entity Privlege Information to a File](/powerapps/developer/data-platform/org-service/samples/dump-entity-metadata-file)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]