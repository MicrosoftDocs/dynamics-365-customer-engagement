---
title: "Microsoft Dynamics 365 Customer Engagement importjob EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 5b5acc10-4ab9-4e15-bb42-3115f8470b50
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API importjob entitytype."
---
# importjob EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/importjob.md](./descriptions/importjob.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]importjobs </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Import Job</td></tr>
<tr><td><b>Primary Key:</b></td><td>importjobid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The importjob EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|completedon|Edm.DateTimeOffset|**Display Name**: Completed On<br />**Description**: Date and time when the import job was completed.<br />Read-only<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the import job record was created.<br />Read-only<br />|
|data|Edm.String|**Display Name**: Data<br />**Description**: Unstructured data associated with the import job.<br />|
|importjobid|Edm.Guid|**Display Name**: Import Job<br />**Description**: Unique identifier of the import job.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the import job was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Import Job Name<br />**Description**: Name of the import job.<br />|
|progress|Edm.Double|**Display Name**: Progress<br />**Description**: Import Progress Percentage.<br />|
|solutionname|Edm.String|**Display Name**: SolutionName<br />**Description**: Unique identifier of the solution.<br />|
|startedon|Edm.DateTimeOffset|**Display Name**: Started On<br />**Description**: Date and time when the import job was started.<br />Read-only<br />|
|timezoneruleversionnumber|Edm.Int32|**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Description**: Time zone code that was in use when the record was created.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the importJob.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the import job record.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the importJob.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the import job record.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the importjob.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_importjobbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_importjobbase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_importjobbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_importjobbase_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_importjob|  

[!INCLUDE[./remarks/importjob.md](./remarks/importjob.md)]

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