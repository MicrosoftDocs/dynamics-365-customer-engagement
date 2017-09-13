---
title: "Microsoft Dynamics 365 Customer Engagement principalobjectaccess EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: bafc662e-f085-449d-a5b2-f824391cd278
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API principalobjectaccess entitytype."
---
# principalobjectaccess EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/principalobjectaccess.md](./descriptions/principalobjectaccess.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]principalobjectaccessset </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>None</td></tr>
<tr><td><b>Primary Key:</b></td><td>principalobjectaccessid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>None</td></tr>
</table>
  
The principalobjectaccess EntityType:
* Has no lookup properties.
* Has no single-valued navigation properties.
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|accessrightsmask|Edm.Int32||
|changedon|Edm.DateTimeOffset||
|inheritedaccessrightsmask|Edm.Int32||
|objectid|Edm.Guid|Read-only<br />|
|objecttypecode|Edm.String||
|principalid|Edm.Guid|Read-only<br />|
|principalobjectaccessid|Edm.Guid|**Description**: Unique identifier of the principal object access.<br />|
|principaltypecode|Edm.String||
|timezoneruleversionnumber|Edm.Int32|**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|Read-only<br />|  

[!INCLUDE[./remarks/principalobjectaccess.md](./remarks/principalobjectaccess.md)]

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