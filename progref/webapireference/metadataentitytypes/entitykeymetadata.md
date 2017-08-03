---
title: "EntityKeyMetadata EntityType| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: bbbe4ead-b1ca-4cd4-9e80-2a18d9256264
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# EntityKeyMetadata EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/entitykeymetadata.md](./descriptions/entitykeymetadata.md)]</td></tr>
<tr><td><b>Base Type:</b></td><td>[MetadataBase EntityType](metadatabase.md)</td></tr>
<tr><td><b>Primary Key:</b></td><td>MetadataId</td></tr>
</table>
 
 The EntityKeyMetadata EntityType:
* Has no single-valued navigation properties.
* Has no collection-valued navigation properties.

## Properties
Properties represent fields of data stored in the entity.


|Name|Type|Description|  
|----|----|-------|  
|AsyncJob|Edm.Guid|The asynchronous job.|
|DisplayName|[Label ComplexType](../complextypes/Label.md)|A label containing the display name for the key.|
|EntityKeyIndexStatus|[EntityKeyIndexStatus EnumType](../enumtypes/EntityKeyIndexStatus.md)|The entity key index status.|
|EntityLogicalName|Edm.String|The entity logical name.|
|HasChanged|Edm.Boolean|Indicates whether the item of metadata has changed.<br />Inherited from [MetadataBase EntityType](metadatabase.md).|
|IntroducedVersion|Edm.String|A string identifying the solution version that the solution component was added in.|
|IsCustomizable|[BooleanManagedProperty ComplexType](../complextypes/BooleanManagedProperty.md)|Whether the entity key metadata is customizable.|
|IsManaged|Edm.Boolean|Whether entity key metadata is managed or not.|
|KeyAttributes|Collection(Edm.String)|The key attributes.|
|LogicalName|Edm.String|The logical name.|
|MetadataId|Edm.Guid|A unique identifier for the metadata item.<br />Inherited from [MetadataBase EntityType](metadatabase.md).|
|SchemaName|Edm.String|The schema name.|

## Used by
The following operations use the EntityKeyMetadata entity type.


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