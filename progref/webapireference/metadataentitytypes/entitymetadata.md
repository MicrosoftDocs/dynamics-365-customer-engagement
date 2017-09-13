---
title: "EntityMetadata EntityType| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 8595cb4f-a592-4dfa-b66f-af5970c35148
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# EntityMetadata EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/entitymetadata.md](./descriptions/entitymetadata.md)]</td></tr>
<tr><td><b>Base Type:</b></td><td>[MetadataBase EntityType](metadatabase.md)</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]EntityDefinitions</td></tr>
<tr><td><b>Primary Key:</b></td><td>MetadataId</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET,PUT,DELETE</td></tr>
</table>
 
 The EntityMetadata EntityType:
* Has no single-valued navigation properties.
* Is not explicitly used by any operations but may be referenced using [MetadataBase EntityType](metadatabase.md).

## Properties
Properties represent fields of data stored in the entity.


|Name|Type|Description|  
|----|----|-------|  
|ActivityTypeMask|Edm.Int32|Whether a custom activity should appear in the activity menus in the Web application. |
|AutoCreateAccessTeams|Edm.Boolean|Indicates whether the entity is enabled for auto created access teams. |
|AutoRouteToOwnerQueue|Edm.Boolean|Indicates whether to automatically move records to the owner’s default queue when a record of this type is created or assigned|
|CanBeInManyToMany|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether the entity can be in a Many-to-Many entity relationship.|
|CanBePrimaryEntityInRelationship|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether the entity can be the referenced entity in a One-to-Many entity relationship.|
|CanBeRelatedEntityInRelationship|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether the entity can be the referencing entity in a One-to-Many entity relationship.|
|CanChangeHierarchicalRelationship|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether the hierarchical state of entity relationships included in your managed solutions can be changed.|
|CanChangeTrackingBeEnabled|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|For internal use only.|
|CanCreateAttributes|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether additional attributes can be added to the entity.|
|CanCreateCharts|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether new charts can be created for the entity.|
|CanCreateForms|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether new forms can be created for the entity.|
|CanCreateViews|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether new views can be created for the entity.|
|CanEnableSyncToExternalSearchIndex|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|For internal use only.|
|CanModifyAdditionalSettings|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether any other entity properties not represented by a managed property can be changed.|
|CanTriggerWorkflow|Edm.Boolean|Whether the entity can trigger a workflow process.|
|ChangeTrackingEnabled|Edm.Boolean|Whether change tracking is enabled for an entity.|
|CollectionSchemaName|Edm.String|The collection schema name of the entity.|
|DataProviderId|Edm.Guid|TODO: Add description for DataProviderId|
|DataSourceId|Edm.Guid|TODO: Add description for DataSourceId|
|DaysSinceRecordLastModified|Edm.Int32|TODO: Add description for DaysSinceRecordLastModified|
|Description|[Label ComplexType](../complextypes/Label.md)|The label containing the description for the entity.|
|DisplayCollectionName|[Label ComplexType](../complextypes/Label.md)|A label containing the plural display name for the entity.|
|DisplayName|[Label ComplexType](../complextypes/Label.md)|A label containing the display name for the entity.|
|EnforceStateTransitions|Edm.Boolean|Whether the entity will enforce custom state transitions.|
|EntityColor|Edm.String|The hexadecimal code to represent the color to be used for this entity in the application.|
|EntityHelpUrl|Edm.String|The URL of the resource to display help content for this entity|
|EntityHelpUrlEnabled|Edm.Boolean|Whether the entity supports custom help content.|
|EntitySetName|Edm.String|The name of the Web API entity set for this entity.|
|ExternalCollectionName|Edm.String|TODO: Add description for ExternalCollectionName|
|ExternalName|Edm.String|TODO: Add description for ExternalName|
|HasActivities|Edm.Boolean|Whether activities are associated with this entity.|
|HasChanged|Edm.Boolean|Indicates whether the item of metadata has changed.<br />Inherited from [MetadataBase EntityType](metadatabase.md).|
|HasFeedback|Edm.Boolean|Whether the entity will have a special relationship to the Feedback entity.|
|HasNotes|Edm.Boolean|Whether notes are associated with this entity.|
|IconLargeName|Edm.String|The name of the image web resource for the large icon for the entity.|
|IconMediumName|Edm.String|The name of the image web resource for the medium icon for the entity.|
|IconSmallName|Edm.String|The name of the image web resource for the small icon for the entity.|
|IconVectorName|Edm.String|TODO: Add description for IconVectorName|
|IntroducedVersion|Edm.String|A string identifying the solution version that the solution component was added in.|
|IsActivity|Edm.Boolean|Whether the entity is an activity.|
|IsActivityParty|Edm.Boolean|Whether the email messages can be sent to an email address stored in a record of this type.|
|IsAIRUpdated|Edm.Boolean|Whether the entity uses the updated user interface.|
|IsAuditEnabled|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether auditing has been enabled for the entity.|
|IsAvailableOffline|Edm.Boolean|Whether the entity is available offline.|
|IsBPFEntity|Edm.Boolean|TODO: Add description for IsBPFEntity|
|IsBusinessProcessEnabled|Edm.Boolean|Whether the entity is enabled for business process flows.|
|IsChildEntity|Edm.Boolean|Whether the entity is a child entity.|
|IsConnectionsEnabled|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether connections are enabled for this entity.|
|IsCustomEntity|Edm.Boolean|Whether the entity is a custom entity.|
|IsCustomizable|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether the entity is customizable.|
|IsDocumentManagementEnabled|Edm.Boolean|Whether document management is enabled.|
|IsDocumentRecommendationsEnabled|Edm.Boolean|TODO: Add description for IsDocumentRecommendationsEnabled|
|IsDuplicateDetectionEnabled|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether duplicate detection is enabled.|
|IsEnabledForCharts|Edm.Boolean|Whether charts are enabled.|
|IsEnabledForExternalChannels|Edm.Boolean|Whether this entity is enabled for external channels|
|IsEnabledForTrace|Edm.Boolean|For internal use only.|
|IsImportable|Edm.Boolean|Whether the entity can be imported using the Import Wizard.|
|IsInteractionCentricEnabled|Edm.Boolean|Whether the entity is enabled for interactive experience.|
|IsIntersect|Edm.Boolean|Whether the entity is an intersection table for two other entities.|
|IsKnowledgeManagementEnabled|Edm.Boolean|Whether Parature knowledge management integration is enabled for the entity.|
|IsLogicalEntity|Edm.Boolean|TODO: Add description for IsLogicalEntity|
|IsMailMergeEnabled|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether mail merge is enabled for this entity.|
|IsManaged|Edm.Boolean|Whether the entity is part of a managed solution.|
|IsMappable|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether entity mapping is available for the entity.|
|IsOfflineInMobileClient|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether this entity is enabled for offline data with Dynamics 365 for tablets and Dynamics 365 for phones.|
|IsOneNoteIntegrationEnabled|Edm.Boolean|Whether OneNote integration is enabled for the entity.|
|IsOptimisticConcurrencyEnabled|Edm.Boolean|Whether optimistic concurrency is enabled for the entity|
|IsPrivate|Edm.Boolean|For internal use only.|
|IsQuickCreateEnabled|Edm.Boolean|Whether the entity is enabled for quick create forms.|
|IsReadingPaneEnabled|Edm.Boolean|For internal use only.|
|IsReadOnlyInMobileClient|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether Microsoft Dynamics 365 for tablets users can update data for this entity.|
|IsRenameable|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether the entity DisplayName and DisplayCollectionName can be changed by editing the entity in the application.|
|IsSLAEnabled|Edm.Boolean|TODO: Add description for IsSLAEnabled|
|IsStateModelAware|Edm.Boolean|Whether the entity supports setting custom state transitions.|
|IsValidForAdvancedFind|Edm.Boolean|Whether the entity is will be shown in Advanced Find.|
|IsValidForQueue|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether the entity is enabled for queues.|
|IsVisibleInMobile|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether Microsoft Dynamics 365 for phones users can see data for this entity.|
|IsVisibleInMobileClient|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether Microsoft Dynamics 365 for tablets users can see data for this entity.|
|LogicalCollectionName|Edm.String|The logical collection name.|
|LogicalName|Edm.String|The logical name for the entity.|
|MetadataId|Edm.Guid|A unique identifier for the metadata item.<br />Inherited from [MetadataBase EntityType](metadatabase.md).|
|MobileOfflineFilters|Edm.String|TODO: Add description for MobileOfflineFilters|
|ObjectTypeCode|Edm.Int32|The entity type code.|
|OwnershipType|[OwnershipTypes EnumType](../enumtypes/OwnershipTypes.md)|The ownership type for the entity.|
|PrimaryIdAttribute|Edm.String|The name of the attribute that is the primary id for the entity.|
|PrimaryImageAttribute|Edm.String|The name of the primary image attribute for an entity.|
|PrimaryNameAttribute|Edm.String|The name of the primary attribute for an entity.|
|Privileges|Collection([SecurityPrivilegeMetadata ComplexType](../complextypes/SecurityPrivilegeMetadata.md))|The privilege metadata for the entity.|
|RecurrenceBaseEntityLogicalName|Edm.String|The name of the entity that is recurring.|
|ReportViewName|Edm.String|The name of the report view for the entity.|
|SchemaName|Edm.String|The schema name for the entity.|
|SyncToExternalSearchIndex|Edm.Boolean|TODO: Add description for SyncToExternalSearchIndex|
|UsesBusinessDataLabelTable|Edm.Boolean|TODO: Add description for UsesBusinessDataLabelTable|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between entities.


|Name|Type| 
|----|----|  
|Attributes|[AttributeMetadata EntityType](attributemetadata.md)|
|Keys|[EntityKeyMetadata EntityType](entitykeymetadata.md)|
|ManyToManyRelationships|[ManyToManyRelationshipMetadata EntityType](manytomanyrelationshipmetadata.md)|
|ManyToOneRelationships|[OneToManyRelationshipMetadata EntityType](onetomanyrelationshipmetadata.md)|
|OneToManyRelationships|[OneToManyRelationshipMetadata EntityType](onetomanyrelationshipmetadata.md)|

### See also  
 [Use the Microsoft Dynamics CRM Web API](https://msdn.microsoft.com/library/mt593051.aspx)<br />
 [Web API EntityType Reference](../entitytypereference.md)<br />
 [Web API Action Reference](../actionreference.md)<br />
 [Web API Function Reference](../functionreference.md)<br />
 [Web API Query Function Reference](../queryfunctionreference.md)<br />
 [Web API EnumType Reference](../enumtypereference.md)<br />
 [Web API ComplexType Reference](../complextypereference.md)<br />
 [Web API Metadata EntityType Reference](../entitytypereference.md)<br />
 [Web API Solutions Reference](../solutionreference.md)<br />