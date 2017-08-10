---
title: "MetadataBase EntityType| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f942f25a-4c87-4ba7-9d3f-e0bf535eb0d0
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# MetadataBase EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/metadatabase.md](./descriptions/metadatabase.md)]</td></tr>
<tr><td><b>Base Type:</b></td><td>[crmmodelbaseentity EntityType](crmmodelbaseentity.md)</td></tr>
<tr><td><b>Primary Key:</b></td><td>MetadataId</td></tr>
</table>
 
 The MetadataBase EntityType:
* Has no single-valued navigation properties.
* Has no collection-valued navigation properties.
* Is not explicitly used by any operations but may be referenced using [crmmodelbaseentity EntityType](crmmodelbaseentity.md).

## Properties
Properties represent fields of data stored in the entity.


|Name|Type|Description|  
|----|----|-------|  
|HasChanged|Edm.Boolean|Indicates whether the item of metadata has changed.<br />Inherited from [MetadataBase EntityType](metadatabase.md).|
|MetadataId|Edm.Guid|A unique identifier for the metadata item.<br />Inherited from [MetadataBase EntityType](metadatabase.md).|

## Derived Types
The following entity types inherit from the MetadataBase entity type.


|Name|Description| 
|----|----|  
|[AttributeMetadata](attributemetadata.md)|[!INCLUDE[./descriptions/attributemetadata.md](./descriptions/attributemetadata.md)]|
|[EntityMetadata](entitymetadata.md)|[!INCLUDE[./descriptions/entitymetadata.md](./descriptions/entitymetadata.md)]|
|[EntityKeyMetadata](entitykeymetadata.md)|[!INCLUDE[./descriptions/entitykeymetadata.md](./descriptions/entitykeymetadata.md)]|
|[OptionSetMetadataBase](optionsetmetadatabase.md)|[!INCLUDE[./descriptions/optionsetmetadatabase.md](./descriptions/optionsetmetadatabase.md)]|
|[ManagedPropertyMetadata](managedpropertymetadata.md)|[!INCLUDE[./descriptions/managedpropertymetadata.md](./descriptions/managedpropertymetadata.md)]|
|[RelationshipMetadataBase](relationshipmetadatabase.md)|[!INCLUDE[./descriptions/relationshipmetadatabase.md](./descriptions/relationshipmetadatabase.md)]|

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