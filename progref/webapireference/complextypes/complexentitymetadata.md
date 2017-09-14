---
title: "ComplexEntityMetadata ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 271618ff-8839-4989-a0d3-431084be5b3f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ComplexEntityMetadata ComplexType
[!INCLUDE[./descriptions/complexentitymetadata.md](./descriptions/complexentitymetadata.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|ActivityTypeMask|Edm.Int32|true|true|Whether a custom activity should appear in the activity menus in the Web application.| 
|Attributes|Collection([ComplexAttributeMetadata ComplexType](../complextypes/ComplexAttributeMetadata.md))||true|Collection of attributes.| 
|AutoRouteToOwnerQueue|Edm.Boolean|true|true|Whether to automatically move records to the owner’s default queue when a record of this type is created or assigned.| 
|CanTriggerWorkflow|Edm.Boolean|true|true|Whether the complex entity can trigger a workflow process.| 
|Description|[Label ComplexType](../complextypes/Label.md)|true|true|The label containing the description for the complex entity.| 
|DisplayCollectionName|[Label ComplexType](../complextypes/Label.md)|true|true|A label containing the plural display name for the complex entity.| 
|DisplayName|[Label ComplexType](../complextypes/Label.md)|true|true|A label containing the display name for the complex entity.| 
|EntityHelpUrlEnabled|Edm.Boolean|true|true|Whether the entity supports custom help content.| 
|EntityHelpUrl|Edm.String|true|false|The URL of the resource to display help content for this complex entity.| 
|IsDocumentManagementEnabled|Edm.Boolean|true|true|Whether document management is enabled.| 
|IsOneNoteIntegrationEnabled|Edm.Boolean|true|true|Whether OneNote integration is enabled for the complex entity.| 
|IsInteractionCentricEnabled|Edm.Boolean|true|true|Whether interactive service hub dashboards are enabled for this  complex entity.| 
|IsKnowledgeManagementEnabled|Edm.Boolean|true|true|Whether Parature knowledge management integration is enabled for the complex entity.| 
|IsSLAEnabled|Edm.Boolean|true|true|Indicating if the entity is enabled for service level agreements (SLAs).| 
|IsBPFEntity|Edm.Boolean|true|true|For internal use only| 
|IsDocumentRecommendationsEnabled|Edm.Boolean|true|true|For internal use only. Whether the entity is enabled for document recommendations.| 
|DataProviderId|Edm.Guid|true|true|TODO: Add description for ComplexEntityMetadata.DataProviderId property.| 
|DataSourceId|Edm.Guid|true|true|TODO: Add description for ComplexEntityMetadata.DataSourceId property.| 
|AutoCreateAccessTeams|Edm.Boolean|true|true|Whether the complex entity is enabled for auto created access teams.| 
|IsActivity|Edm.Boolean|true|true|Whether the complex entity is an activity.| 
|IsActivityParty|Edm.Boolean|true|true|Whether the email messages can be sent to an email address stored in a record of this type.| 
|IsAuditEnabled|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether auditing has been enabled for the complex entity.| 
|IsAvailableOffline|Edm.Boolean|true|true|Whether the complex entity is available offline.| 
|IsChildEntity|Edm.Boolean|true|true|Whether the complex entity is a child entity.| 
|IsAIRUpdated|Edm.Boolean|true|true|Whether the complex entity uses the updated user interface.| 
|IsValidForQueue|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether the complex entity is enabled for queues.| 
|IsConnectionsEnabled|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether connections are enabled for this complex entity.| 
|IconLargeName|Edm.String|true|false|The name of the image web resource for the large icon for the complex entity.| 
|IconMediumName|Edm.String|true|false|The name of the image web resource for the medium icon for the complex entity.| 
|IconSmallName|Edm.String|true|false|The name of the image web resource for the small icon for the complex entity.| 
|IconVectorName|Edm.String|true|false|TODO: Add description for ComplexEntityMetadata.IconVectorName property.| 
|IsCustomEntity|Edm.Boolean|true|true|Whether the complex entity is a custom entity.| 
|IsBusinessProcessEnabled|Edm.Boolean|true|true|Whether the complex entity is enabled for business process flows.| 
|IsCustomizable|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether the complex entity is customizable.| 
|IsRenameable|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether the entity DisplayName and DisplayCollectionName can be changed by editing the complex entity in the application.| 
|IsMappable|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether entity mapping is available for the complex entity.| 
|IsDuplicateDetectionEnabled|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether duplicate detection is enabled.| 
|CanCreateAttributes|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether additional attributes can be added to the complex entity.| 
|CanCreateForms|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether new forms can be created for the complex entity.| 
|CanCreateViews|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether new views can be created for the complex entity.| 
|CanCreateCharts|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether new charts can be created for the complex entity.| 
|CanBeRelatedEntityInRelationship|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether the complex entity can be the referencing entity in a One-to-Many entity relationship| 
|CanBePrimaryEntityInRelationship|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether the complex entity can be the referenced entity in a One-to-Many entity relationship.| 
|CanBeInManyToMany|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether the complex entity can be in a Many-to-Many entity relationship.| 
|CanEnableSyncToExternalSearchIndex|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|For internal use only.| 
|SyncToExternalSearchIndex|Edm.Boolean|true|true|Whether the complex entity can be synced to external search index.| 
|CanModifyAdditionalSettings|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether any other entity properties not represented by a managed property can be changed.| 
|CanChangeHierarchicalRelationship|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether the hierarchical state of entity relationships included in your managed solutions can be changed.| 
|IsOptimisticConcurrencyEnabled|Edm.Boolean|true|true|Whether optimistic concurrency is enabled for the complex entity.| 
|ChangeTrackingEnabled|Edm.Boolean|true|true|Whether change tracking is enabled for the complex entity.| 
|CanChangeTrackingBeEnabled|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether change tracking can be enabled for the complex entity.| 
|IsImportable|Edm.Boolean|true|true|Whether the complex entity can be imported using the Import Wizard.| 
|IsIntersect|Edm.Boolean|true|true|Whether the complex entity is an intersection table for two other entities.| 
|IsMailMergeEnabled|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether mail merge is enabled for this complex entity.| 
|IsManaged|Edm.Boolean|true|true|Whether the complex entity is part of a managed solution.| 
|IsEnabledForCharts|Edm.Boolean|true|true|Whether charts are enabled.| 
|IsEnabledForTrace|Edm.Boolean|true|true|For internal use only.| 
|IsValidForAdvancedFind|Edm.Boolean|true|true|Whether the entity will be shown in Advanced Find.| 
|IsVisibleInMobile|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether Microsoft Dynamics 365 for phones users can see data for this complex entity.| 
|IsVisibleInMobileClient|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether Microsoft Dynamics 365 for tablets users can see data for this complex entity.| 
|IsReadOnlyInMobileClient|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether Microsoft Dynamics 365 for tablets users can update data for this complex entity.| 
|IsOfflineInMobileClient|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether this complex entity is enabled for offline data with Dynamics 365 for tablets and Dynamics 365 for phones.| 
|DaysSinceRecordLastModified|Edm.Int32|true|true|The number of days since the record was last modified.| 
|MobileOfflineFilters|Edm.String|true|false|For internal use only.| 
|IsReadingPaneEnabled|Edm.Boolean|true|true|For internal use only.| 
|IsQuickCreateEnabled|Edm.Boolean|true|true|Whether the complex entity is enabled for quick create forms.| 
|LogicalName|Edm.String|true|false|The logical name for the complex entity.| 
|ManyToManyRelationships|Collection([ComplexManyToManyRelationshipMetadata ComplexType](../complextypes/ComplexManyToManyRelationshipMetadata.md))||true|Array of many to many relationships for the complex entity.| 
|ManyToOneRelationships|Collection([ComplexOneToManyRelationshipMetadata ComplexType](../complextypes/ComplexOneToManyRelationshipMetadata.md))||true|Array of many to one relationships for the complex entity.| 
|OneToManyRelationships|Collection([ComplexOneToManyRelationshipMetadata ComplexType](../complextypes/ComplexOneToManyRelationshipMetadata.md))||true|Array of many to one relationships for the complex entity.| 
|ObjectTypeCode|Edm.Int32|true|true|The complex entity type code.| 
|OwnershipType|[OwnershipTypes EnumType](../enumtypes/OwnershipTypes.md)|true|true|The ownership type for the complex entity.| 
|PrimaryNameAttribute|Edm.String|true|false|The name of the attribute that is the primary id for the complex entity.| 
|PrimaryImageAttribute|Edm.String|true|false|The name of the primary image attribute for the complex entity.| 
|PrimaryIdAttribute|Edm.String|true|false|The name of the attribute that is the primary id for the complex entity.| 
|Privileges|Collection([SecurityPrivilegeMetadata ComplexType](../complextypes/SecurityPrivilegeMetadata.md))||true|The privilege metadata for the complex entity.| 
|RecurrenceBaseEntityLogicalName|Edm.String|true|false|The name of the complex entity that is recurring.| 
|ReportViewName|Edm.String|true|false|The name of the report view for the complex entity.| 
|SchemaName|Edm.String|true|false|The schema name for the complex entity.| 
|IntroducedVersion|Edm.String|true|false|A string identifying the solution version that the solution component was added in.| 
|IsStateModelAware|Edm.Boolean|true|true|Whether the complex entity supports setting custom state transitions.| 
|EnforceStateTransitions|Edm.Boolean|true|true|Whether the entity will enforce custom state transitions.| 
|ExternalName|Edm.String|true|false|TODO: Add description for ComplexEntityMetadata.ExternalName property.| 
|EntityColor|Edm.String|true|false|The hexadecimal code to represent the color to be used for this complex entity in the application.| 
|Keys|Collection([ComplexEntityKeyMetadata ComplexType](../complextypes/ComplexEntityKeyMetadata.md))||true|Array of keys for the complex entity.| 
|LogicalCollectionName|Edm.String|true|false|The logical collection name.| 
|ExternalCollectionName|Edm.String|true|false|TODO: Add description for ComplexEntityMetadata.ExternalCollectionName property.| 
|CollectionSchemaName|Edm.String|true|false|The collection schema name of the complex entity.| 
|EntitySetName|Edm.String|true|false|The name of the Web API entity set for this entity.| 
|IsEnabledForExternalChannels|Edm.Boolean|true|true|For internal use only.| 
|IsPrivate|Edm.Boolean|true|true|For internal use only.| 
|UsesBusinessDataLabelTable|Edm.Boolean|true|true|For internal use only.| 
|IsLogicalEntity|Edm.Boolean|true|true|For internal use only. | 
|MetadataId|Edm.Guid|true|true|A unique identifier for the metadata item.| 
|HasChanged|Edm.Boolean|true|true|Indicates whether the item of metadata has changed.| 

## Used by
The following use the ComplexEntityMetadata ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[RetrieveAllEntitiesResponse ComplexType](../complextypes/retrieveallentitiesresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/retrieveallentitiesresponse.md](../complextypes/descriptions/retrieveallentitiesresponse.md)]|

[!INCLUDE[./remarks/complexentitymetadata.md](./remarks/complexentitymetadata.md)]

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