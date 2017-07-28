---
title: "Microsoft Dynamics 365 Customer Engagement entitydataprovider EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3b1b4bfb-e42e-42ee-b008-6ec78c02f8de
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API entitydataprovider entitytype."
---
# entitydataprovider EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/entitydataprovider.md](./descriptions/entitydataprovider.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]entitydataproviders </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Entity Data Provider</td></tr>
<tr><td><b>Primary Key:</b></td><td>entitydataproviderid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The entitydataprovider EntityType:
* Has no lookup properties.
* Has no single-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createplugin|Edm.Guid|**Display Name**: Create Plugin<br />**Description**: Create Plugin<br />|
|datasourcelogicalname|Edm.String|**Display Name**: Meta Entity<br />**Description**: Meta Entity<br />|
|deleteplugin|Edm.Guid|**Display Name**: Delete Plugin<br />**Description**: Delete Plugin<br />|
|entitydataproviderid|Edm.Guid|**Display Name**: Entity Data Provider<br />**Description**: Unique identifier of the entity data provider.<br />|
|entitydataprovideridunique|Edm.Guid|**Display Name**: Unique Id<br />**Description**: For internal use only.<br />Read-only<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the form is introduced.<br />|
|ismanaged|Edm.Boolean|**Display Name**: State<br />**Description**: Indicates whether the solution component is part of a managed solution.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name<br />|
|organizationid|Edm.Guid|**Display Name**: Organization Id<br />**Description**: Unique identifier for the organization.<br />Read-only<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|retrievemultipleplugin|Edm.Guid|**Display Name**: MultipleRetrieve Plugin<br />**Description**: MultipleRetrieve Plugin<br />|
|retrieveplugin|Edm.Guid|**Display Name**: Retrieve Plugin<br />**Description**: Retrieve Plugin<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|updateplugin|Edm.Guid|**Display Name**: Update Plugin<br />**Description**: Update Plugin<br />|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|entitydataprovider_datasource|[entitydatasource EntityType](entitydatasource.md)|entitydataproviderid|    

[!INCLUDE[./remarks/entitydataprovider.md](./remarks/entitydataprovider.md)]

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