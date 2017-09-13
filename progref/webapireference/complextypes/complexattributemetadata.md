---
title: "ComplexAttributeMetadata ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 33bfd6cc-064b-46d4-be51-90e7b8831911
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ComplexAttributeMetadata ComplexType
[!INCLUDE[./descriptions/complexattributemetadata.md](./descriptions/complexattributemetadata.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|AttributeOf|Edm.String|true|false|The name of the attribute that this attribute extends.| 
|AttributeType|[AttributeTypeCode EnumType](../enumtypes/AttributeTypeCode.md)|true|true|The type of the attribute.| 
|AttributeTypeName|[AttributeTypeDisplayName ComplexType](../complextypes/AttributeTypeDisplayName.md)|true|true|The name of the type of the attribute.| 
|ColumnNumber|Edm.Int32|true|true|Organization-specific ID for the attribute used for auditing.| 
|Description|[Label ComplexType](../complextypes/Label.md)|true|true|The Label containing the description for the attribute.| 
|DisplayName|[Label ComplexType](../complextypes/Label.md)|true|true|A label containing the display name for the attribute.| 
|DeprecatedVersion|Edm.String|true|false|The Microsoft Dynamics 365 version that the attribute was deprecated in.| 
|IntroducedVersion|Edm.String|true|false|A string identifying the solution version that the solution component was added in.| 
|EntityLogicalName|Edm.String|true|false|The logical name of the entity that contains the attribute.| 
|IsAuditEnabled|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether the attribute is enabled for auditing.| 
|IsCustomAttribute|Edm.Boolean|true|true|Whether the attribute is a custom attribute.| 
|IsPrimaryId|Edm.Boolean|true|true|Whether the attribute represents the unique identifier for the record.| 
|IsPrimaryName|Edm.Boolean|true|true|Whether the attribute represents the primary attribute for the entity.| 
|IsValidForCreate|Edm.Boolean|true|true|Whether the value can be set when a record is created.| 
|IsValidForRead|Edm.Boolean|true|true|Whether the value can be retrieved.| 
|IsValidForUpdate|Edm.Boolean|true|true|Whether the value can be updated.| 
|CanBeSecuredForRead|Edm.Boolean|true|true|Whether field-level security can be applied to prevent a user from viewing data from this attribute.| 
|CanBeSecuredForCreate|Edm.Boolean|true|true|Whether field-level security can be applied to prevent a user from adding data to this attribute.| 
|CanBeSecuredForUpdate|Edm.Boolean|true|true|Whether field-level security can be applied to prevent a user from updating data for this attribute.| 
|IsSecured|Edm.Boolean|true|true|Whether the attribute is secured for field-level security.| 
|IsRetrievable|Edm.Boolean|true|true|For internal use only.| 
|IsFilterable|Edm.Boolean|true|true|For internal use only.| 
|IsSearchable|Edm.Boolean|true|true|For internal use only.| 
|IsManaged|Edm.Boolean|true|true|Whether the attribute is part of a managed solution.| 
|IsGlobalFilterEnabled|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|For internal use only.| 
|IsSortableEnabled|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|For internal use only.| 
|LinkedAttributeId|Edm.Guid|true|true|The id of the attribute that is linked between appointments and recurring appointments.| 
|LogicalName|Edm.String|true|false|The logical name for the attribute.| 
|IsCustomizable|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether the attribute allows customization.| 
|IsRenameable|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether the attribute display name can be changed.| 
|IsValidForAdvancedFind|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether the attribute appears in Advanced Find.| 
|IsValidForForm|Edm.Boolean|true|true|TODO: Add description for ComplexAttributeMetadata.IsValidForForm property.| 
|IsRequiredForForm|Edm.Boolean|true|true|TODO: Add description for ComplexAttributeMetadata.IsRequiredForForm property.| 
|IsValidForGrid|Edm.Boolean|true|true|TODO: Add description for ComplexAttributeMetadata.IsValidForGrid property.| 
|RequiredLevel|[AttributeRequiredLevelManagedProperty ComplexType](../complextypes/AttributeRequiredLevelManagedProperty.md)|true|true|The property that determines the data entry requirement level enforced for the attribute.| 
|CanModifyAdditionalSettings|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|true|true|Whether any settings not controlled by managed properties can be changed.| 
|SchemaName|Edm.String|true|false|The schema name for the attribute.| 
|ExternalName|Edm.String|true|false|TODO: Add description for ComplexAttributeMetadata.ExternalName property.| 
|IsLogical|Edm.Boolean|true|true|Whether the attribute is a logical attribute.| 
|IsDataSourceSecret|Edm.Boolean|true|true|TODO: Add description for ComplexAttributeMetadata.IsDataSourceSecret property.| 
|InheritsFrom|Edm.String|true|false|For internal use only.| 
|SourceType|Edm.Int32|true|true|A value that indicates the source type for a calculated or rollup attribute.| 
|AutoNumberFormat|Edm.String|true|false|TODO: Add description for ComplexAttributeMetadata.AutoNumberFormat property.| 
|MetadataId|Edm.Guid|true|true|A unique identifier for the metadata item.| 
|HasChanged|Edm.Boolean|true|true|Indicates whether the item of metadata has changed.| 

## Used by
The following use the ComplexAttributeMetadata ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[ComplexEntityMetadata ComplexType](../complextypes/complexentitymetadata.md)|Property|[!INCLUDE[../complextypes/descriptions/complexentitymetadata.md](../complextypes/descriptions/complexentitymetadata.md)]|

[!INCLUDE[./remarks/complexattributemetadata.md](./remarks/complexattributemetadata.md)]

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