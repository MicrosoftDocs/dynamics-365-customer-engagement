---
title: "Microsoft Dynamics 365 Customer Engagement importentitymapping EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 529aedcf-4062-4409-a03e-0998698ac8cb
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API importentitymapping entitytype."
---
# importentitymapping EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/importentitymapping.md](./descriptions/importentitymapping.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]importentitymappings </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Import Entity Mapping</td></tr>
<tr><td><b>Primary Key:</b></td><td>importentitymappingid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,DELETE</td></tr>
</table>
  
The importentitymapping EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Description**: Date and time when the import entity mapping was created.<br />Read-only<br />|
|dedupe|Edm.Int32|**Display Name**: Remove Duplicates<br />**Description**: Information about whether the entity needs to be processed to find and delete duplicate records.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Ignore</td></tr><tr><td>2</td><td>Eliminate</td></tr><tbody></table>|
|importentitymappingid|Edm.Guid|**Description**: Unique identifier of the import entity mapping.<br />|
|importentitymappingidunique|Edm.Guid|**Description**: Unique identifier of the Import Entity Mapping.<br />Read-only<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the component is introduced.<br />|
|ismanaged|Edm.Boolean|**Display Name**: State<br />**Description**: Information that specifies whether this component is managed.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the import entity mapping was last modified.<br />Read-only<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|processcode|Edm.Int32|**Display Name**: Process Code<br />**Description**: Information about whether the import entity mapping needs to be processed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Process</td></tr><tr><td>2</td><td>Ignore</td></tr><tr><td>3</td><td>Internal</td></tr><tbody></table>|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|sourceentityname|Edm.String|**Display Name**: Source Entity Name<br />**Description**: Name of the source entity.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the import entity mapping.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the import entity mapping.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tbody></table>|
|targetentityname|Edm.String|**Display Name**: Target Entity<br />**Description**: Name of the Microsoft Dynamics 365 entity.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the import entity mapping.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the importentitymapping.|
|_importmapid_value|importmapid<br />|Unique identifier of the associated data map.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the import entity mapping.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the importentitymapping.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_importentitymapping_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_importentitymapping_createdonbehalfby|
|importmapid|[importmap EntityType](importmap.md)|ImportEntityMapping_ImportMap|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_importentitymapping_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_importentitymapping_modifiedonbehalfby|  

[!INCLUDE[./remarks/importentitymapping.md](./remarks/importentitymapping.md)]

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