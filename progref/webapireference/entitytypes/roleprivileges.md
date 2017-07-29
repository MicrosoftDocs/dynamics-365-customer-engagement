---
title: "Microsoft Dynamics 365 Customer Engagement roleprivileges EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 5ee2951b-ab87-4553-9c64-3dfc484475e7
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API roleprivileges entitytype."
---
# roleprivileges EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/roleprivileges.md](./descriptions/roleprivileges.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]roleprivilegescollection </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>None</td></tr>
<tr><td><b>Primary Key:</b></td><td>roleprivilegeid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET (RetrieveMultiple Only)</td></tr>
</table>
  
The roleprivileges EntityType:
* Has no lookup properties.
* Has no single-valued navigation properties.
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|ismanaged|Edm.Boolean|Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|privilegedepthmask|Edm.Int32|**Description**: System-generated attribute that stores the privileges associated with the role.<br />|
|privilegeid|Edm.Guid|**Description**: Unique identifier of the privilege associated with the role.<br />Read-only<br />|
|roleid|Edm.Guid|**Description**: Unique identifier of the role that is associated with the role privilege.<br />Read-only<br />|
|roleprivilegeid|Edm.Guid|**Description**: Unique identifier of the role privilege.<br />|
|roleprivilegeidunique|Edm.Guid|**Description**: For internal use only.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|versionnumber|Edm.Int64|Read-only<br />|  

[!INCLUDE[./remarks/roleprivileges.md](./remarks/roleprivileges.md)]

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