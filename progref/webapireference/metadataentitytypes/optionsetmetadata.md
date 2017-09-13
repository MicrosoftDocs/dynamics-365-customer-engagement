---
title: "OptionSetMetadata EntityType| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 07ce7eab-daed-4041-a948-a7a3a10faf06
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# OptionSetMetadata EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/optionsetmetadata.md](./descriptions/optionsetmetadata.md)]</td></tr>
<tr><td><b>Base Type:</b></td><td>[OptionSetMetadataBase EntityType](optionsetmetadatabase.md)</td></tr>
<tr><td><b>Primary Key:</b></td><td>MetadataId</td></tr>
</table>
 
 The OptionSetMetadata EntityType:
* Has no single-valued navigation properties.
* Has no collection-valued navigation properties.

## Properties
Properties represent fields of data stored in the entity.


|Name|Type|Description|  
|----|----|-------|  
|Description|[Label ComplexType](../complextypes/Label.md)|A description for the option set.<br />Inherited from [OptionSetMetadataBase EntityType](optionsetmetadatabase.md).|
|DisplayName|[Label ComplexType](../complextypes/Label.md)|A label containing the display name for the global option set.<br />Inherited from [OptionSetMetadataBase EntityType](optionsetmetadatabase.md).|
|ExternalName|Edm.String|TODO: Add description for ExternalName<br />Inherited from [OptionSetMetadataBase EntityType](optionsetmetadatabase.md).|
|HasChanged|Edm.Boolean|Indicates whether the item of metadata has changed.<br />Inherited from [MetadataBase EntityType](metadatabase.md).|
|IntroducedVersion|Edm.String|A string identifying the solution version that the solution component was added in.<br />Inherited from [OptionSetMetadataBase EntityType](optionsetmetadatabase.md).|
|IsCustomizable|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether the option set is customizable.<br />Inherited from [OptionSetMetadataBase EntityType](optionsetmetadatabase.md).|
|IsCustomOptionSet|Edm.Boolean|Whether the option set is a custom option set.<br />Inherited from [OptionSetMetadataBase EntityType](optionsetmetadatabase.md).|
|IsGlobal|Edm.Boolean|Whether the option set is a global option set.<br />Inherited from [OptionSetMetadataBase EntityType](optionsetmetadatabase.md).|
|IsManaged|Edm.Boolean|Whether the option set is part of a managed solution.<br />Inherited from [OptionSetMetadataBase EntityType](optionsetmetadatabase.md).|
|MetadataId|Edm.Guid|A unique identifier for the metadata item.<br />Inherited from [MetadataBase EntityType](metadatabase.md).|
|Name|Edm.String|The name of a global option set.<br />Inherited from [OptionSetMetadataBase EntityType](optionsetmetadatabase.md).|
|Options|Collection([OptionMetadata ComplexType](../complextypes/OptionMetadata.md))|TODO: Add description for Options|
|OptionSetType|[OptionSetType EnumType](../enumtypes/OptionSetType.md)|The type of option set.<br />Inherited from [OptionSetMetadataBase EntityType](optionsetmetadatabase.md).|

## Used by
The following operations use the OptionSetMetadata entity type.


|Name|How used |Description |  
|----|---------|------------|  
|[EnumAttributeMetadata EntityType](../metadataentitytypes/enumattributemetadata.md)|NavigationProperty|[!INCLUDE[../metadataentitytypes/descriptions/enumattributemetadata.md](../metadataentitytypes/descriptions/enumattributemetadata.md)]|

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