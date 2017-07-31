---
title: "Microsoft Dynamics 365 Customer Engagement entitydatasource EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 81b3f64c-5695-497b-a423-908ebfc2aef6
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API entitydatasource entitytype."
---
# entitydatasource EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/entitydatasource.md](./descriptions/entitydatasource.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]entitydatasources </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Entity Data Source</td></tr>
<tr><td><b>Primary Key:</b></td><td>entitydatasourceid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The entitydatasource EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|connectiondefinition|Edm.String|**Display Name**: Connection Definition<br />**Description**: Connection Definition<br />|
|connectiondefinitionsecrets|Edm.String|**Display Name**: Connection Definition Secret<br />**Description**: Connection Definition Secret<br />|
|entitydatasourceid|Edm.Guid|**Display Name**: Entity DataSource Id<br />**Description**: Unique identifier of the Entity DataSource Id<br />|
|entitydatasourceidunique|Edm.Guid|**Display Name**: Unique Id<br />**Description**: For internal use only.<br />Read-only<br />|
|entityname|Edm.String|**Display Name**: EntityName<br />**Description**: EntityName<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the form is introduced.<br />|
|ismanaged|Edm.Boolean|**Display Name**: State<br />**Description**: Indicates whether the solution component is part of a managed solution.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the Entity Data Source.<br />|
|organizationid|Edm.Guid|**Display Name**: Organization Id<br />**Description**: Unique identifier for the organization.<br />Read-only<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_entitydataproviderid_value|entitydataproviderid<br />|Choose the entity dataprovider for the entity datasource.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|entitydataproviderid|[entitydataprovider EntityType](entitydataprovider.md)|entitydataprovider_datasource|  

[!INCLUDE[./remarks/entitydatasource.md](./remarks/entitydatasource.md)]

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