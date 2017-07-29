---
title: "Microsoft Dynamics 365 Customer Engagement importdata EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: fffb4b6c-fa3c-419f-b396-a885cc2814b4
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API importdata entitytype."
---
# importdata EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/importdata.md](./descriptions/importdata.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]importdataset </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Import Data</td></tr>
<tr><td><b>Primary Key:</b></td><td>importdataid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>data</td></tr>
<tr><td><b>Operations supported:</b></td><td>None</td></tr>
</table>
  
The importdata EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Description**: Date and time when the import data was created.<br />Read-only<br />|
|data|Edm.String|**Display Name**: Data<br />**Description**: Data row of the import file.<br />|
|errortype|Edm.Int32|**Display Name**: Error Type<br />**Description**: Type of the import error.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Create</td></tr><tr><td>1</td><td>Update</td></tr><tbody></table>|
|haserror|Edm.Boolean|**Display Name**: Has Error<br />**Description**: Information about whether this import data has an error.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|importdataid|Edm.Guid|**Description**: Unique identifier of the import data.<br />|
|importdataidunique|Edm.Guid|**Description**: Unique identifier of the Impport Data.<br />Read-only<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the component is introduced.<br />|
|ismanaged|Edm.Boolean|**Display Name**: State<br />**Description**: Information that specifies whether this component is managed.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|linenumber|Edm.Int32|**Display Name**: Line Number<br />**Description**: Original line number of the data present in the file.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the import data was last modified.<br />Read-only<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|recordid|Edm.Guid|**Display Name**: Record<br />**Description**: Unique identifier of the record.<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the import data.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the import data.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tbody></table>|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the import data.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the importdata.|
|_importfileid_value|importfileid<br />|Unique identifier of the import file for this import data.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the import data.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the importdata.|
|_ownerid_value|ownerid<br />|Unique identifier of the user or team who owns the import data.|
|_owningbusinessunit_value|owningbusinessunit<br />|Business unit that owns the import data.|
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns the import data.|
|_owninguser_value|owninguser<br />|Unique identifier of the user who owns the import data.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_importdatabase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_importdata_createdonbehalfby|
|importfileid|[importfile EntityType](importfile.md)|ImportFile_ImportData|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_importdatabase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_importdata_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_importdatas|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|BusinessUnit_ImportData|
|owningteam|[team EntityType](team.md)|team_ImportData|
|owninguser|[systemuser EntityType](systemuser.md)|SystemUser_ImportData|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|ImportData_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_importdata|  
|ImportData_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_importdata|  
|ImportLog_ImportData|[importlog EntityType](importlog.md)|importdataid|    

[!INCLUDE[./remarks/importdata.md](./remarks/importdata.md)]

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