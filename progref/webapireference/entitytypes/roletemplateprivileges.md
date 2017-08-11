---
title: "Microsoft Dynamics 365 Customer Engagement roletemplateprivileges EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: fa269ab3-7d65-4e03-8f6e-e40f47ca9814
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API roletemplateprivileges entitytype."
---
# roletemplateprivileges EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/roletemplateprivileges.md](./descriptions/roletemplateprivileges.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]roletemplateprivilegescollection </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>None</td></tr>
<tr><td><b>Primary Key:</b></td><td>roletemplateprivilegeid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>None</td></tr>
</table>
  
The roletemplateprivileges EntityType:
* Has no lookup properties.
* Has no single-valued navigation properties.
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|isbasic|Edm.Boolean|**Description**: Information about whether the role in the template applies to the user, the user's team, or objects shared by the user.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isdeep|Edm.Boolean|**Description**: Information about whether the role in the template applies to child business units of the business unit associated with the user.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isglobal|Edm.Boolean|**Description**: Information about whether the role in the template applies to the entire organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|islocal|Edm.Boolean|**Description**: Information about whether the role in the template applies to the user's business unit.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|privilegeid|Edm.Guid|**Description**: Unique identifier of the privilege assigned to the role template.<br />Read-only<br />|
|roletemplateid|Edm.Guid|**Description**: Unique identifier of the role template that is associated with the role privilege.<br />Read-only<br />|
|roletemplateprivilegeid|Edm.Guid|**Description**: Unique identifier of the role template privileges.<br />|  

[!INCLUDE[./remarks/roletemplateprivileges.md](./remarks/roletemplateprivileges.md)]

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