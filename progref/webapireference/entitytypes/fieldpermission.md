---
title: "Microsoft Dynamics 365 Customer Engagement fieldpermission EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 386a9884-4e5f-45c5-ac39-4fa4a8b2f17d
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API fieldpermission entitytype."
---
# fieldpermission EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/fieldpermission.md](./descriptions/fieldpermission.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]fieldpermissions </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Field Permission</td></tr>
<tr><td><b>Primary Key:</b></td><td>fieldpermissionid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The fieldpermission EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|attributelogicalname|Edm.String|**Display Name**: Name of the attribute for which this privilege is defined<br />**Description**: Attribute Name.<br />|
|cancreate|Edm.Int32|**Display Name**: Can create the attribute<br />**Description**: Can this Profile create the attribute<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Not Allowed</td></tr><tr><td>4</td><td>Allowed</td></tr><tbody></table>|
|canread|Edm.Int32|**Display Name**: Can Read the attribute<br />**Description**: Can this Profile read the attribute<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Not Allowed</td></tr><tr><td>4</td><td>Allowed</td></tr><tbody></table>|
|canupdate|Edm.Int32|**Display Name**: Can Update the attribute<br />**Description**: Can this Profile update the attribute<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Not Allowed</td></tr><tr><td>4</td><td>Allowed</td></tr><tbody></table>|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|entityname|Edm.String|**Display Name**: Name of the Entity for which this privilege is defined<br />**Description**: Entity name.<br />|
|fieldpermissionid|Edm.Guid|**Display Name**: Field Permission<br />**Description**: Unique identifier of the Field Permission.<br />|
|fieldpermissionidunique|Edm.Guid|**Display Name**: Field Permission<br />**Description**: For internal use only.<br />Read-only<br />|
|ismanaged|Edm.Boolean|**Display Name**: Is Managed<br />**Description**: Indicates whether the solution component is part of a managed solution.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_fieldsecurityprofileid_value|fieldsecurityprofileid<br />|Unique identifier of profile to which this privilege belongs.|
|_organizationid_value||Unique identifier for the organization|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|fieldsecurityprofileid|[fieldsecurityprofile EntityType](fieldsecurityprofile.md)|lk_fieldpermission_fieldsecurityprofileid|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|FieldPermission_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_fieldpermission_syncerror|    

[!INCLUDE[./remarks/fieldpermission.md](./remarks/fieldpermission.md)]

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