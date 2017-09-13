---
title: "Microsoft Dynamics 365 Customer Engagement privilege EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4f09008e-0654-48ff-8da9-de30c5f29afd
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API privilege entitytype."
---
# privilege EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/privilege.md](./descriptions/privilege.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]privileges </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Privilege</td></tr>
<tr><td><b>Primary Key:</b></td><td>privilegeid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET</td></tr>
</table>
  
The privilege EntityType:
* Has no lookup properties.
* Has no single-valued navigation properties.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|accessright|Edm.Int32|**Description**: Rights a user has to an instance of an entity.<br />|
|canbebasic|Edm.Boolean|**Description**: Information that specifies whether the privilege applies to the user, the user's team, or objects shared by the user.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|canbedeep|Edm.Boolean|**Description**: Information that specifies whether the privilege applies to child business units of the business unit associated with the user.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|canbeentityreference|Edm.Boolean|**Description**: Information that specifies whether the privilege applies to the local reference of an external party.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|canbeglobal|Edm.Boolean|**Description**: Information that specifies whether the privilege applies to the entire organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|canbelocal|Edm.Boolean|**Description**: Information that specifies whether the privilege applies to the user's business unit.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|canbeparententityreference|Edm.Boolean|**Description**: Information that specifies whether the privilege applies to parent reference of the external party.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the component is introduced.<br />|
|ismanaged|Edm.Boolean|**Display Name**: State<br />**Description**: Information that specifies whether this component is managed.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|name|Edm.String|**Description**: Name of the privilege.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|privilegeid|Edm.Guid|**Description**: Unique identifier of the privilege.<br />|
|privilegerowid|Edm.Guid||
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|Privilege_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_privilege|  
|Privilege_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_privilege|  
|roleprivileges_association|[role EntityType](role.md)|roleprivileges_association|  
|roletemplateprivileges_association|[roletemplate EntityType](roletemplate.md)|roletemplateprivileges_association|  

## Operations
The following operations can be used with the privilege entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrievePrivilegeSet Function](../functions/retrieveprivilegeset.md)|Collection|[!INCLUDE[../functions/descriptions/retrieveprivilegeset.md](../functions/descriptions/retrieveprivilegeset.md)]|    

[!INCLUDE[./remarks/privilege.md](./remarks/privilege.md)]

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