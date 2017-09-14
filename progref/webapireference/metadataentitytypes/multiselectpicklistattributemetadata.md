---
title: "MultiSelectPicklistAttributeMetadata EntityType| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 73a01b9d-dabe-4a8c-80d9-819396c9ed75
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# MultiSelectPicklistAttributeMetadata EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/multiselectpicklistattributemetadata.md](./descriptions/multiselectpicklistattributemetadata.md)]</td></tr>
<tr><td><b>Base Type:</b></td><td>[EnumAttributeMetadata EntityType](enumattributemetadata.md)</td></tr>
<tr><td><b>Primary Key:</b></td><td>MetadataId</td></tr>
</table>
 
 The MultiSelectPicklistAttributeMetadata EntityType:
* Has no collection-valued navigation properties.
* Is not explicitly used by any operations but may be referenced using [EnumAttributeMetadata EntityType](enumattributemetadata.md).

## Properties
Properties represent fields of data stored in the entity.


|Name|Type|Description|  
|----|----|-------|  
|AttributeOf|Edm.String|The name of the attribute that this attribute extends.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|AttributeType|[AttributeTypeCode EnumType](../enumtypes/AttributeTypeCode.md)|The type for the attribute.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|AttributeTypeName|[AttributeTypeDisplayName ComplexType](../complextypes/AttributeTypeDisplayName.md)|The name of the type for the attribute.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|AutoNumberFormat|Edm.String|TODO: Add description for AutoNumberFormat<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|CanBeSecuredForCreate|Edm.Boolean|Whether field-level security can be applied to prevent a user from adding data to this attribute. <br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|CanBeSecuredForRead|Edm.Boolean|Whether field-level security can be applied to prevent a user from viewing data from this attribute.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|CanBeSecuredForUpdate|Edm.Boolean|Whether field-level security can be applied to prevent a user from updating data for this attribute.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|CanModifyAdditionalSettings|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether any settings not controlled by managed properties can be changed.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|ColumnNumber|Edm.Int32|An organization-specific ID for the attribute used for auditing.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|DefaultFormValue|Edm.Int32|The default form value for the attribute.<br />Inherited from [EnumAttributeMetadata EntityType](enumattributemetadata.md).|
|DeprecatedVersion|Edm.String|The Microsoft Dynamics 365 version that the attribute was deprecated in.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|Description|[Label ComplexType](../complextypes/Label.md)|The label containing the description for the attribute.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|DisplayName|[Label ComplexType](../complextypes/Label.md)|A label containing the display name for the attribute.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|EntityLogicalName|Edm.String|The logical name of the entity that contains the attribute.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|ExternalName|Edm.String|TODO: Add description for ExternalName<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|FormulaDefinition|Edm.String|TODO: Add description for FormulaDefinition|
|HasChanged|Edm.Boolean|Indicates whether the item of metadata has changed.<br />Inherited from [MetadataBase EntityType](metadatabase.md).|
|InheritsFrom|Edm.String|For internal use only.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IntroducedVersion|Edm.String|A string identifying the solution version that the solution component was added in.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsAuditEnabled|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether the attribute is enabled for auditing.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsCustomAttribute|Edm.Boolean|Whether the attribute is a custom attribute.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsCustomizable|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether the attribute allows customization.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsDataSourceSecret|Edm.Boolean|TODO: Add description for IsDataSourceSecret<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsFilterable|Edm.Boolean|For internal use only.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsGlobalFilterEnabled|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|For internal use only.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsLogical|Edm.Boolean|Whether the attribute is a logical attribute.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsManaged|Edm.Boolean|Whether the attribute is part of a managed solution.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsPrimaryId|Edm.Boolean|Whether the attribute represents the unique identifier for the record.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsPrimaryName|Edm.Boolean|Whether the attribute represents the primary attribute for the entity.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsRenameable|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether the attribute display name can be changed.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsRequiredForForm|Edm.Boolean|TODO: Add description for IsRequiredForForm<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsRetrievable|Edm.Boolean|For internal use only.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsSearchable|Edm.Boolean|For internal use only.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsSecured|Edm.Boolean|Whether the attribute is secured for field-level security.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsSortableEnabled|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|For internal use only.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsValidForAdvancedFind|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether the attribute appears in Advanced Find.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsValidForCreate|Edm.Boolean|Whether the value can be set when a record is created.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsValidForForm|Edm.Boolean|TODO: Add description for IsValidForForm<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsValidForGrid|Edm.Boolean|TODO: Add description for IsValidForGrid<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsValidForRead|Edm.Boolean|Whether the value can be retrieved.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|IsValidForUpdate|Edm.Boolean|Whether the value can be updated.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|LinkedAttributeId|Edm.Guid|The id of the attribute that is linked between appointments and recurring appointments.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|LogicalName|Edm.String|The logical name for the attribute.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|MetadataId|Edm.Guid|A unique identifier for the metadata item.<br />Inherited from [MetadataBase EntityType](metadatabase.md).|
|RequiredLevel|[AttributeRequiredLevelManagedProperty ComplexType](../complextypes/AttributeRequiredLevelManagedProperty.md)|The property that determines the data entry requirement level enforced for the attribute.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|SchemaName|Edm.String|The schema name for the attribute.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|SourceType|Edm.Int32|A value that indicates the source type for a calculated or rollup attribute.<br />Inherited from [AttributeMetadata EntityType](attributemetadata.md).|
|SourceTypeMask|Edm.Int32|TODO: Add description for SourceTypeMask|

## Single-valued navigation properties
These properties refer to data stored in a different entity.


|Name|Type|  
|----|----|  
|GlobalOptionSet|[OptionSetMetadata EntityType](optionsetmetadata.md)|
|OptionSet|[OptionSetMetadata EntityType](optionsetmetadata.md)|

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