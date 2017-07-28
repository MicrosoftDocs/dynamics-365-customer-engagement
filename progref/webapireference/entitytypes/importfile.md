---
title: "Microsoft Dynamics 365 Customer Engagement importfile EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 36e70a00-7d6f-4aa1-86e9-59a70ba5729f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API importfile entitytype."
---
# importfile EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/importfile.md](./descriptions/importfile.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]importfiles </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Import Source File</td></tr>
<tr><td><b>Primary Key:</b></td><td>importfileid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|additionalheaderrow|Edm.String|**Display Name**: Additional Header<br />**Description**: Shows the secondary column headers. The additional headers are used during the process of transforming the import file into import data records.<br />Read-only<br />|
|completedon|Edm.DateTimeOffset|**Display Name**: Completed On<br />**Description**: Shows the date and time when the import associated with the import file was completed.<br />Read-only<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|content|Edm.String|**Description**: Stores the content of the import file, stored as comma-separated values.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|datadelimitercode|Edm.Int32|**Display Name**: Data Delimiter<br />**Description**: Select the single-character data delimiter used in the import file. This is typically a single or double quotation mark.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>DoubleQuote</td></tr><tr><td>2</td><td>None</td></tr><tr><td>3</td><td>SingleQuote</td></tr><tbody></table>|
|enableduplicatedetection|Edm.Boolean|**Display Name**: Enable Duplicate Detection<br />**Description**: Select whether duplicate-detection rules should be run against the import job.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|entitykeyid|Edm.Guid|**Display Name**: Entity Key ID<br />**Description**: Unique identifier of the Alternate key Id<br />|
|failurecount|Edm.Int32|**Display Name**: Errors<br />**Description**: Shows the number of records in the import file that cannot be imported.<br />Read-only<br />|
|fielddelimitercode|Edm.Int32|**Display Name**: Field Delimiter<br />**Description**: Select the character that is used to separate each field in the import file. Typically, it is a comma.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Colon</td></tr><tr><td>2</td><td>Comma</td></tr><tr><td>3</td><td>Tab</td></tr><tr><td>4</td><td>Semicolon</td></tr><tbody></table>|
|filetypecode|Edm.Int32|**Display Name**: File Type<br />**Description**: Shows the type of source file that is uploaded for import.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>CSV</td></tr><tr><td>1</td><td>XML Spreadsheet 2003</td></tr><tr><td>2</td><td>Attachment</td></tr><tr><td>3</td><td>XLSX</td></tr><tbody></table>|
|headerrow|Edm.String|**Display Name**: Header<br />**Description**: Shows a list of each column header in the import file separated by a comma. The header is used for parsing the file during the import job.<br />Read-only<br />|
|importfileid|Edm.Guid|**Display Name**: Import<br />**Description**: Unique identifier of the import file.<br />|
|importfileidunique|Edm.Guid|**Description**: Unique identifier of the ImportFile.<br />Read-only<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />|
|isfirstrowheader|Edm.Boolean|**Display Name**: Is First Row Header<br />**Description**: Select whether the first row of the import file contains column headings, which are used for data mapping during the import job.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ismanaged|Edm.Boolean|**Display Name**: State<br />**Description**: Information that specifies whether this component is managed.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Import Name<br />**Description**: Shows the name of the import file. This name is based on the name of the uploaded file.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|parsedtablecolumnprefix|Edm.String|**Display Name**: Parse Table Column Prefix<br />**Description**: Shows the prefix applied to each column after the import file is parsed.<br />Read-only<br />|
|parsedtablecolumnsnumber|Edm.Int32|**Display Name**: Parse Table Column Number<br />**Description**: Shows the number of columns included in the parsed import file.<br />Read-only<br />|
|parsedtablename|Edm.String|**Display Name**: Parse Table<br />**Description**: Shows the name of the table that contains the parsed data from the import file.<br />Read-only<br />|
|partialfailurecount|Edm.Int32|**Display Name**: Partial Failures<br />**Description**: Shows the number of records in this file that had failures during the import.<br />Read-only<br />|
|processcode|Edm.Int32|**Display Name**: Process Code<br />**Description**: Tells whether the import file should be ignored or processed during the import.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Process</td></tr><tr><td>2</td><td>Ignore</td></tr><tr><td>3</td><td>Internal</td></tr><tbody></table>|
|processingstatus|Edm.Int32|**Display Name**: Processing Status<br />**Description**: Shows the import file's processing status code. This indicates whether the data in the import file has been parsed, transformed, or imported.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Not Started</td></tr><tr><td>2</td><td>Parsing</td></tr><tr><td>3</td><td>Parsing Complete</td></tr><tr><td>4</td><td>Complex Transformation</td></tr><tr><td>5</td><td>Lookup Transformation</td></tr><tr><td>6</td><td>Picklist Transformation</td></tr><tr><td>7</td><td>Owner Transformation</td></tr><tr><td>8</td><td>Transformation Complete</td></tr><tr><td>9</td><td>Import Pass 1</td></tr><tr><td>10</td><td>Import Pass 2</td></tr><tr><td>11</td><td>Import Complete</td></tr><tr><td>12</td><td>Primary Key Transformation</td></tr><tbody></table>|
|progresscounter|Edm.Int32|**Display Name**: Progress Counter<br />**Description**: Shows the progress code for the processing of the import file. This field is used when a paused import job is resumed.<br />Read-only<br />|
|relatedentitycolumns|Edm.String|**Description**: Shows the columns that are mapped to a related record type (entity) of the primary record type (entity) included in the import file.<br />|
|size|Edm.String|**Display Name**: Size<br />**Description**: Shows the size of the import file, in kilobytes.<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|source|Edm.String|**Display Name**: Source<br />**Description**: Shows the name of the data source file uploaded in the import job.<br />|
|sourceentityname|Edm.String|**Display Name**: Source Entity<br />**Description**: Shows the record type (entity) of the source data.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the import file record. By default, all records are active and can't be deactivated.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows the reason code that explains the import file's status to identify the stage of the import process, from parsing the data to completed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Submitted</td></tr><tr><td>1</td><td>Parsing</td></tr><tr><td>2</td><td>Transforming</td></tr><tr><td>3</td><td>Importing</td></tr><tr><td>4</td><td>Completed</td></tr><tr><td>5</td><td>Failed</td></tr><tbody></table>|
|successcount|Edm.Int32|**Display Name**: Successes<br />**Description**: Shows the number of records in the import file that are imported successfully.<br />Read-only<br />|
|targetentityname|Edm.String|**Display Name**: Target Entity<br />**Description**: Select the target record type (entity) for the records that will be created during the import job.<br />|
|timezoneruleversionnumber|Edm.Int32|**Description**: For internal use only.<br />|
|totalcount|Edm.Int32|**Display Name**: Total Processed<br />**Description**: Shows the total number of records in the import file.<br />Read-only<br />|
|upsertmodecode|Edm.Int32|**Display Name**: Upsert Mode<br />**Description**: Select the value which is used for identify the upsert mode. By Default, it is a Create.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Create</td></tr><tr><td>1</td><td>Update</td></tr><tr><td>2</td><td>Ignore</td></tr><tbody></table>|
|usesystemmap|Edm.Boolean|**Display Name**: Use System Map<br />**Description**: Tells whether an automatic system map was applied to the import file, which automatically maps the import data to the target entity in Microsoft Dynamics 365.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|utcconversiontimezonecode|Edm.Int32|**Description**: Time zone code that was in use when the record was created.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_importid_value|importid<br />|Choose the import job that the file was uploaded for.|
|_importmapid_value|importmapid<br />|Choose a data map to match the import file and its column headers with the record types and fields in Microsoft Dynamics 365. If the column headers in the file match the display names of the target fields in Microsoft Dynamics 365, we import the data automatically. If not, you can manually define matches during import.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who created the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Enter the user who is assigned to follow up with or manage the import file. This field is updated every time the import file is assigned to a different user.|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that the record owner belongs to.|
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns the import file.|
|_owninguser_value|owninguser<br />|Unique identifier of the user who owns the import file.|
|_recordsownerid_value|recordsownerid_team<br />recordsownerid_systemuser<br />|Choose the user that the records created during the import job should be assigned to.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_importfilebase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_importfilebase_createdonbehalfby|
|importid|[import EntityType](import.md)|Import_ImportFile|
|importmapid|[importmap EntityType](importmap.md)|ImportMap_ImportFile|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_importfilebase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_importfilebase_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_importfiles|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|BusinessUnit_ImportFiles|
|owningteam|[team EntityType](team.md)|team_ImportFiles|
|owninguser|[systemuser EntityType](systemuser.md)|SystemUser_ImportFiles|
|recordsownerid_systemuser|[systemuser EntityType](systemuser.md)|ImportFile_SystemUser|
|recordsownerid_team|[team EntityType](team.md)|ImportFile_Team|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|ImportFile_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_importfile|  
|ImportFile_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_importfile|  
|ImportFile_ImportData|[importdata EntityType](importdata.md)|importfileid|  
|ImportLog_ImportFile|[importlog EntityType](importlog.md)|importfileid|  

## Operations
The following operations can be used with the importfile entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GetDistinctValuesImportFile Function](../functions/getdistinctvaluesimportfile.md)|Entity|[!INCLUDE[../functions/descriptions/getdistinctvaluesimportfile.md](../functions/descriptions/getdistinctvaluesimportfile.md)]|  
|[GetHeaderColumnsImportFile Function](../functions/getheadercolumnsimportfile.md)|Entity|[!INCLUDE[../functions/descriptions/getheadercolumnsimportfile.md](../functions/descriptions/getheadercolumnsimportfile.md)]|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrieveParsedDataImportFile Function](../functions/retrieveparseddataimportfile.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveparseddataimportfile.md](../functions/descriptions/retrieveparseddataimportfile.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the importfile entity type.


|Name|Description |  
|----|------------|  
|[AppCommon Solution](../solutions/appcommon.md)|[!INCLUDE[../solutions/descriptions/appcommon.md](../solutions/descriptions/appcommon.md)]|    

[!INCLUDE[./remarks/importfile.md](./remarks/importfile.md)]

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