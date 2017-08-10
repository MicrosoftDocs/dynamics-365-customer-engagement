---
title: "Microsoft Dynamics 365 Customer Engagement importlog EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 15121964-4015-42dc-a77d-a5ae2aa98f1a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API importlog entitytype."
---
# importlog EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/importlog.md](./descriptions/importlog.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]importlogs </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Import Log</td></tr>
<tr><td><b>Primary Key:</b></td><td>importlogid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET</td></tr>
</table>
  
The importlog EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|additionalinfo|Edm.String|**Display Name**: More Information<br />**Description**: Additional information related to the error.<br />|
|columnvalue|Edm.String|**Display Name**: Column Value<br />**Description**: Value in the column.<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the import log was created.<br />Read-only<br />|
|errordescription|Edm.String|**Display Name**: Description<br />**Description**: Description of an error.<br />|
|errornumber|Edm.Int32|**Display Name**: Error Code<br />**Description**: Error code of an error.<br />|
|headercolumn|Edm.String|**Display Name**: Column Heading<br />**Description**: Name of the column heading.<br />|
|importlogid|Edm.Guid|**Description**: Unique identifier of the import log.<br />|
|importlogidunique|Edm.Guid|**Description**: Unique identifier of the Impport Log.<br />Read-only<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the component is introduced.<br />|
|ismanaged|Edm.Boolean|**Display Name**: State<br />**Description**: Information that specifies whether this component is managed.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|linenumber|Edm.Int32|**Display Name**: Original Row Number<br />**Description**: Original line number of the data used in this log.<br />|
|logphasecode|Edm.Int32|**Display Name**: Log Phase<br />**Description**: Phase for which the log is recorded.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Parse</td></tr><tr><td>1</td><td>Transform</td></tr><tr><td>2</td><td>Import Create</td></tr><tr><td>3</td><td>Import Update</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the import log was last modified.<br />Read-only<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|sequencenumber|Edm.Int32|**Display Name**: Sequence Number<br />**Description**: Sequence number of the error in this log.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the import log.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the import log.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tbody></table>|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the import log.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the importlog.|
|_importdataid_value|importdataid<br />|Unique identifier of the import data for this import log.|
|_importfileid_value|importfileid<br />|Unique identifier of the import file for this import log.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the import log.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the importlog.|
|_ownerid_value|ownerid<br />|Unique identifier of the user or team who owns the import log.|
|_owningbusinessunit_value|owningbusinessunit<br />|Business unit that owns the import log.|
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns the import log.|
|_owninguser_value|owninguser<br />|Unique identifier of the user who owns the import log.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_importlogbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_importlog_createdonbehalfby|
|importdataid|[importdata EntityType](importdata.md)|ImportLog_ImportData|
|importfileid|[importfile EntityType](importfile.md)|ImportLog_ImportFile|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_importlogbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_importlog_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_importlogs|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|BusinessUnit_ImportLogs|
|owningteam|[team EntityType](team.md)|team_ImportLogs|
|owninguser|[systemuser EntityType](systemuser.md)|SystemUser_ImportLogs|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|ImportLog_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_importlog|  
|ImportLog_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_importlog|    

[!INCLUDE[./remarks/importlog.md](./remarks/importlog.md)]

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