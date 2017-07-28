---
title: "Microsoft Dynamics 365 Customer Engagement import EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 1d2a805f-a2ba-47a5-ab9f-f7517f48d2d7
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API import entitytype."
---
# import EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/import.md](./descriptions/import.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]imports </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Data Import</td></tr>
<tr><td><b>Primary Key:</b></td><td>importid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The import entitytype is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the import was initiated.<br />Read-only<br />|
|emailaddress|Edm.String|**Display Name**: Email<br />**Description**: Type the email address that the import completion notification must be sent to.<br />|
|importid|Edm.Guid|**Display Name**: Import<br />**Description**: Unique identifier of the import job.<br />|
|modecode|Edm.Int32|**Display Name**: Mode<br />**Description**: Select whether to create or update records in Microsoft Dynamics 365 during the import job.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Create</td></tr><tr><td>1</td><td>Update</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Import Name<br />**Description**: Shows the name of the import job, based on the import file and the entity being imported.<br />|
|sendnotification|Edm.Boolean|**Display Name**: Send Notification<br />**Description**: Select whether to send a notification email message to a selected user after the import is completed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|sequence|Edm.Int32|**Display Name**: Sequence<br />**Description**: Order in which the import was created.<br />Read-only<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the import job. By default, import jobs are active and can't be deactivated.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows the reason code that explains the import job's status to identify the job's stage of the import processes, from transforming the data to completed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Submitted</td></tr><tr><td>1</td><td>Parsing</td></tr><tr><td>2</td><td>Transforming</td></tr><tr><td>3</td><td>Importing</td></tr><tr><td>4</td><td>Completed</td></tr><tr><td>5</td><td>Failed</td></tr><tbody></table>|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who created the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|_owningbusinessunit_value|owningbusinessunit<br />|Business unit that owns the import job.|
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns the import.|
|_owninguser_value|owninguser<br />|Unique identifier of the user who owns the import.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_importbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_import_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_importbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_import_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_imports|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|BusinessUnit_Imports|
|owningteam|[team EntityType](team.md)|team_Imports|
|owninguser|[systemuser EntityType](systemuser.md)|SystemUser_Imports|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|Import_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_import|  
|Import_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_import|  
|Import_ImportFile|[importfile EntityType](importfile.md)|importid|  

## Operations
The following operations can be used with the import entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ImportRecordsImport Action](../actions/importrecordsimport.md)|Entity|[!INCLUDE[../actions/descriptions/importrecordsimport.md](../actions/descriptions/importrecordsimport.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[ParseImport Action](../actions/parseimport.md)|Entity|[!INCLUDE[../actions/descriptions/parseimport.md](../actions/descriptions/parseimport.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  
|[TransformImport Action](../actions/transformimport.md)|Not Bound|[!INCLUDE[../actions/descriptions/transformimport.md](../actions/descriptions/transformimport.md)]|    

[!INCLUDE[./remarks/import.md](./remarks/import.md)]

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