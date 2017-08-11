---
title: "AttributeMetadata EntityType| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 418c8a27-99ca-45d6-9a12-2e43e5364f2e
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AttributeMetadata EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/attributemetadata.md](./descriptions/attributemetadata.md)]</td></tr>
<tr><td><b>Base Type:</b></td><td>[MetadataBase EntityType](metadatabase.md)</td></tr>
<tr><td><b>Primary Key:</b></td><td>MetadataId</td></tr>
</table>
 
 The AttributeMetadata EntityType:
* Has no single-valued navigation properties.
* Has no collection-valued navigation properties.

## Properties
Properties represent fields of data stored in the entity.


|Name|Type|Description|  
|----|----|-------|  
|AttributeOf|Edm.String|The name of the attribute that this attribute extends.|
|AttributeType|[AttributeTypeCode EnumType](../enumtypes/AttributeTypeCode.md)|The type for the attribute.|
|AttributeTypeName|[AttributeTypeDisplayName ComplexType](../complextypes/AttributeTypeDisplayName.md)|The name of the type for the attribute.|
|AutoNumberFormat|Edm.String|TODO: Add description for AutoNumberFormat|
|CanBeSecuredForCreate|Edm.Boolean|Whether field-level security can be applied to prevent a user from adding data to this attribute. |
|CanBeSecuredForRead|Edm.Boolean|Whether field-level security can be applied to prevent a user from viewing data from this attribute.|
|CanBeSecuredForUpdate|Edm.Boolean|Whether field-level security can be applied to prevent a user from updating data for this attribute.|
|CanModifyAdditionalSettings|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether any settings not controlled by managed properties can be changed.|
|ColumnNumber|Edm.Int32|An organization-specific ID for the attribute used for auditing.|
|DeprecatedVersion|Edm.String|The Microsoft Dynamics 365 version that the attribute was deprecated in.|
|Description|[Label ComplexType](../complextypes/Label.md)|The label containing the description for the attribute.|
|DisplayName|[Label ComplexType](../complextypes/Label.md)|A label containing the display name for the attribute.|
|EntityLogicalName|Edm.String|The logical name of the entity that contains the attribute.|
|ExternalName|Edm.String|TODO: Add description for ExternalName|
|HasChanged|Edm.Boolean|Indicates whether the item of metadata has changed.<br />Inherited from [MetadataBase EntityType](metadatabase.md).|
|InheritsFrom|Edm.String|For internal use only.|
|IntroducedVersion|Edm.String|A string identifying the solution version that the solution component was added in.|
|IsAuditEnabled|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether the attribute is enabled for auditing.|
|IsCustomAttribute|Edm.Boolean|Whether the attribute is a custom attribute.|
|IsCustomizable|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether the attribute allows customization.|
|IsDataSourceSecret|Edm.Boolean|TODO: Add description for IsDataSourceSecret|
|IsFilterable|Edm.Boolean|For internal use only.|
|IsGlobalFilterEnabled|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|For internal use only.|
|IsLogical|Edm.Boolean|Whether the attribute is a logical attribute.|
|IsManaged|Edm.Boolean|Whether the attribute is part of a managed solution.|
|IsPrimaryId|Edm.Boolean|Whether the attribute represents the unique identifier for the record.|
|IsPrimaryName|Edm.Boolean|Whether the attribute represents the primary attribute for the entity.|
|IsRenameable|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether the attribute display name can be changed.|
|IsRequiredForForm|Edm.Boolean|TODO: Add description for IsRequiredForForm|
|IsRetrievable|Edm.Boolean|For internal use only.|
|IsSearchable|Edm.Boolean|For internal use only.|
|IsSecured|Edm.Boolean|Whether the attribute is secured for field-level security.|
|IsSortableEnabled|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|For internal use only.|
|IsValidForAdvancedFind|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether the attribute appears in Advanced Find.|
|IsValidForCreate|Edm.Boolean|Whether the value can be set when a record is created.|
|IsValidForForm|Edm.Boolean|TODO: Add description for IsValidForForm|
|IsValidForGrid|Edm.Boolean|TODO: Add description for IsValidForGrid|
|IsValidForRead|Edm.Boolean|Whether the value can be retrieved.|
|IsValidForUpdate|Edm.Boolean|Whether the value can be updated.|
|LinkedAttributeId|Edm.Guid|The id of the attribute that is linked between appointments and recurring appointments.|
|LogicalName|Edm.String|The logical name for the attribute.|
|MetadataId|Edm.Guid|A unique identifier for the metadata item.<br />Inherited from [MetadataBase EntityType](metadatabase.md).|
|RequiredLevel|[AttributeRequiredLevelManagedProperty ComplexType](../complextypes/AttributeRequiredLevelManagedProperty.md)|The property that determines the data entry requirement level enforced for the attribute.|
|SchemaName|Edm.String|The schema name for the attribute.|
|SourceType|Edm.Int32|A value that indicates the source type for a calculated or rollup attribute.|

## Derived Types
The following entity types inherit from the AttributeMetadata entity type.


|Name|Description| 
|----|----|  
|[BigIntAttributeMetadata](bigintattributemetadata.md)|[!INCLUDE[./descriptions/bigintattributemetadata.md](./descriptions/bigintattributemetadata.md)]|
|[BooleanAttributeMetadata](booleanattributemetadata.md)|[!INCLUDE[./descriptions/booleanattributemetadata.md](./descriptions/booleanattributemetadata.md)]|
|[DateTimeAttributeMetadata](datetimeattributemetadata.md)|[!INCLUDE[./descriptions/datetimeattributemetadata.md](./descriptions/datetimeattributemetadata.md)]|
|[DecimalAttributeMetadata](decimalattributemetadata.md)|[!INCLUDE[./descriptions/decimalattributemetadata.md](./descriptions/decimalattributemetadata.md)]|
|[DoubleAttributeMetadata](doubleattributemetadata.md)|[!INCLUDE[./descriptions/doubleattributemetadata.md](./descriptions/doubleattributemetadata.md)]|
|[EnumAttributeMetadata](enumattributemetadata.md)|[!INCLUDE[./descriptions/enumattributemetadata.md](./descriptions/enumattributemetadata.md)]|
|[ImageAttributeMetadata](imageattributemetadata.md)|[!INCLUDE[./descriptions/imageattributemetadata.md](./descriptions/imageattributemetadata.md)]|
|[IntegerAttributeMetadata](integerattributemetadata.md)|[!INCLUDE[./descriptions/integerattributemetadata.md](./descriptions/integerattributemetadata.md)]|
|[LookupAttributeMetadata](lookupattributemetadata.md)|[!INCLUDE[./descriptions/lookupattributemetadata.md](./descriptions/lookupattributemetadata.md)]|
|[ManagedPropertyAttributeMetadata](managedpropertyattributemetadata.md)|[!INCLUDE[./descriptions/managedpropertyattributemetadata.md](./descriptions/managedpropertyattributemetadata.md)]|
|[MemoAttributeMetadata](memoattributemetadata.md)|[!INCLUDE[./descriptions/memoattributemetadata.md](./descriptions/memoattributemetadata.md)]|
|[MoneyAttributeMetadata](moneyattributemetadata.md)|[!INCLUDE[./descriptions/moneyattributemetadata.md](./descriptions/moneyattributemetadata.md)]|
|[StringAttributeMetadata](stringattributemetadata.md)|[!INCLUDE[./descriptions/stringattributemetadata.md](./descriptions/stringattributemetadata.md)]|
|[UniqueIdentifierAttributeMetadata](uniqueidentifierattributemetadata.md)|[!INCLUDE[./descriptions/uniqueidentifierattributemetadata.md](./descriptions/uniqueidentifierattributemetadata.md)]|

## Used by
The following operations use the AttributeMetadata entity type.


|Name|How used |Description |  
|----|---------|------------|  
|[EntityMetadata EntityType](../metadataentitytypes/entitymetadata.md)|NavigationProperty|[!INCLUDE[../metadataentitytypes/descriptions/entitymetadata.md](../metadataentitytypes/descriptions/entitymetadata.md)]|

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