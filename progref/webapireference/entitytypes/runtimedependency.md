---
title: "Microsoft Dynamics 365 Customer Engagement runtimedependency EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 7144d0a4-0f39-434f-ac92-520b80f88202
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API runtimedependency entitytype."
---
# runtimedependency EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/runtimedependency.md](./descriptions/runtimedependency.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]runtimedependencies </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>RuntimeDependency</td></tr>
<tr><td><b>Primary Key:</b></td><td>dependencyid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>None</td></tr>
</table>
  
The runtimedependency EntityType:
* Has no lookup properties.
* Has no single-valued navigation properties.
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdtime|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|dependencyid|Edm.Guid|**Display Name**: Dependency Identifier<br />**Description**: Unique identifier of a dependency.<br />Read-only<br />|
|dependentcomponentnodeid|Edm.String|**Display Name**: Dependent Component<br />**Description**: Unique identifier of the dependent component's node.<br />|
|dependentcomponenttype|Edm.Int32|**Display Name**: Dependent Component Node Type<br />**Description**: Dependent Component Node Type<br />|
|ispublished|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: IsPublished<br />**Description**: Determines whether required component is published<br />|
|requiredcomponentmodifiedtime|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the required component was modified.<br />Read-only<br />|
|requiredcomponentnodeid|Edm.String|**Display Name**: Required Component<br />**Description**: Unique identifier of the required component's node<br />|
|requiredcomponenttype|Edm.Int32|**Display Name**: Required Component Node Type<br />**Description**: Required Component Node Type<br />|  

[!INCLUDE[./remarks/runtimedependency.md](./remarks/runtimedependency.md)]

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