---
title: "Microsoft Dynamics 365 Customer Engagement roletemplate EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 763100f7-315a-4b0c-8319-0f992220862c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API roletemplate entitytype."
---
# roletemplate EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/roletemplate.md](./descriptions/roletemplate.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]roletemplates </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Role Template</td></tr>
<tr><td><b>Primary Key:</b></td><td>roletemplateid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>None</td></tr>
</table>
  
The roletemplate EntityType:
* Has no lookup properties.
* Has no single-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|name|Edm.String|**Description**: Name of the role template.<br />|
|roletemplateid|Edm.Guid|**Description**: Unique identifier of the role template.<br />|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|role_template_roles|[role EntityType](role.md)|roletemplateid|  
|roletemplateprivileges_association|[privilege EntityType](privilege.md)|roletemplateprivileges_association|    

[!INCLUDE[./remarks/roletemplate.md](./remarks/roletemplate.md)]

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