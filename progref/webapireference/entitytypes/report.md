---
title: "Microsoft Dynamics 365 Customer Engagement report EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d3933dec-6ec8-4307-98f9-7a55fe2a662f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API report entitytype."
---
# report EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/report.md](./descriptions/report.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]reports </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Report</td></tr>
<tr><td><b>Primary Key:</b></td><td>reportid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|bodybinary|Edm.String|**Display Name**: Body Binary<br />**Description**: Binary report contents (base-64 encoded).<br />|
|bodybinary_binary|Edm.Binary|**Description**: Binary report contents (base-64 encoded).<br />|
|bodytext|Edm.String|**Display Name**: Body Text<br />**Description**: Text contents of the RDL file for a Reporting Services report.<br />|
|bodyurl|Edm.String|**Display Name**: Linked Report URL<br />**Description**: URL for a linked report.<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdinmajorversion|Edm.Int32|**Display Name**: Crm Version in which the Report is created<br />**Description**: Major version number of Crm, used to identify the version of Crm in which report is created.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the report was created.<br />Read-only<br />|
|customreportxml|Edm.String|**Display Name**: Custom Report XML<br />**Description**: XML used to define a custom report.<br />Read-only<br />|
|defaultfilter|Edm.String|**Display Name**: Default filter<br />**Description**: Default filter for the report.<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the report.<br />|
|filename|Edm.String|**Display Name**: File Name<br />**Description**: File name of the report.<br />|
|filesize|Edm.Int32|**Display Name**: File Size (Bytes)<br />**Description**: File size of the report.<br />Read-only<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the report is introduced.<br />|
|iscustomizable|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Customizable<br />**Description**: Information that specifies whether this component can be customized.<br />|
|iscustomreport|Edm.Boolean|**Display Name**: Is Custom Report<br />**Description**: Information about whether the report is a custom report.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>True</td></tr><tr><td>0</td><td>False</td></tr><tbody></table>|
|ismanaged|Edm.Boolean|**Display Name**: Is Managed<br />**Description**: Indicates whether the solution component is part of a managed solution.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|ispersonal|Edm.Boolean|**Display Name**: Viewable By<br />**Description**: Information about whether the report is personal or is available to all users.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Individual</td></tr><tr><td>0</td><td>Organization</td></tr><tbody></table>|
|isscheduledreport|Edm.Boolean|**Display Name**: Is Scheduled Report<br />**Description**: Information about whether the report is a scheduled report.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>True</td></tr><tr><td>0</td><td>False</td></tr><tbody></table>|
|languagecode|Edm.Int32|**Display Name**: Language<br />**Description**: Language in which the report will be displayed.<br />|
|mimetype|Edm.String|**Display Name**: Mime Type<br />**Description**: MIME type of the report.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the report was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the report.<br />|
|originalbodytext|Edm.String|**Display Name**: Body Text<br />**Description**: Original Text contents of the RDL file for a Reporting Services report.<br />Read-only<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|queryinfo|Edm.String|**Display Name**: Query Info Structure<br />**Description**: For internal use only.<br />Read-only<br />|
|reportid|Edm.Guid|**Display Name**: Report<br />**Description**: Unique identifier of the report.<br />|
|reportidunique|Edm.Guid|**Display Name**: Report<br />**Description**: For internal use only.<br />Read-only<br />|
|reportnameonsrs|Edm.String|**Display Name**: Name on SRS<br />**Description**: Name of the report on SRS.<br />Read-only<br />|
|reporttypecode|Edm.Int32|**Display Name**: Report Type<br />**Description**: Type of the report.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Reporting Services Report</td></tr><tr><td>2</td><td>Other Report</td></tr><tr><td>3</td><td>Linked Report</td></tr><tbody></table>|
|schedulexml|Edm.String|**Display Name**: Schedule Definition XML<br />**Description**: XML used for defining the report schedule.<br />Read-only<br />|
|signaturedate|Edm.DateTimeOffset|**Display Name**: Report Signature Date<br />**Description**: Report signature date, used to identify a report for upgrades and hotfixes.<br />|
|signatureid|Edm.Guid|**Display Name**: Signature<br />**Description**: Unique identifier of the report signature used to identify a report for upgrades and hotfixes.<br />|
|signaturelcid|Edm.Int32|**Display Name**: Signature Language Code<br />**Description**: Report signature language code used to identify a report for upgrades and hotfixes.<br />|
|signaturemajorversion|Edm.Int32|**Display Name**: Report Signature Major Version<br />**Description**: Report signature major version, used to identify a report for upgrades and hotfixes.<br />|
|signatureminorversion|Edm.Int32|**Display Name**: Report Signature Minor Version<br />**Description**: Report signature minor version, used to identify a report for upgrades and hotfixes.<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the report.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the report.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the report.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the report.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the report.|
|_ownerid_value|ownerid<br />|Unique identifier of the user or team who owns the report.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier of the business unit that owns the report.|
|_owningteam_value||Unique identifier of the team who owns the report.|
|_owninguser_value||Unique identifier of the user who owns the report.|
|_parentreportid_value|parentreportid<br />|Unique identifier of the parent report.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_reportbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_report_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_reportbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_report_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_reports|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_reports|
|parentreportid|[report EntityType](report.md)|report_parent_report|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|Report_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_report|  
|report_parent_report|[report EntityType](report.md)|parentreportid|  
|report_reportcategories|[reportcategory EntityType](reportcategory.md)|reportid|  
|Report_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_report_syncerror|  

## Operations
The following operations can be used with the report entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[DownloadReportDefinition Function](../functions/downloadreportdefinition.md)|Entity|[!INCLUDE[../functions/descriptions/downloadreportdefinition.md](../functions/descriptions/downloadreportdefinition.md)]|  
|[GetReportHistoryLimit Function](../functions/getreporthistorylimit.md)|Entity|[!INCLUDE[../functions/descriptions/getreporthistorylimit.md](../functions/descriptions/getreporthistorylimit.md)]|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  
|[SetReportRelated Action](../actions/setreportrelated.md)|Not Bound|[!INCLUDE[../actions/descriptions/setreportrelated.md](../actions/descriptions/setreportrelated.md)]|  

## Solutions
The following solutions include the report entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/report.md](./remarks/report.md)]

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