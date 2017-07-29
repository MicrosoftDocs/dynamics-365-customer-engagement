---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_fieldservicesystemjob EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 6575aeca-bf10-41f7-b0e1-0126fc2b16be
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_fieldservicesystemjob entitytype."
---
# msdyn_fieldservicesystemjob EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_fieldservicesystemjob.md](./descriptions/msdyn_fieldservicesystemjob.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_fieldservicesystemjobs </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Field Service System Job</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_fieldservicesystemjobid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_jobname</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_fieldservicesystemjob entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_conditioncode|Edm.Int32|**Display Name**: Condition Code<br />|
|msdyn_exceptionmessage|Edm.String|**Display Name**: Exception Message<br />|
|msdyn_exceptiontrace|Edm.String|**Display Name**: Exception Trace<br />|
|msdyn_fieldservicesystemjobid|Edm.Guid|**Display Name**: Field Service System Job<br />**Description**: Shows the entity instances.<br />|
|msdyn_inputparameter|Edm.String|**Display Name**: Input Parameter<br />|
|msdyn_inputparametertype|Edm.Int32|**Display Name**: Input Parameter Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>String List</td></tr><tr><td>690970001</td><td>Json</td></tr><tr><td>690970002</td><td>Xml</td></tr><tbody></table>|
|msdyn_jobname|Edm.String|**Display Name**: Type a name for the job.<br />**Description**: Type a name for the job.<br />|
|msdyn_jobstatus|Edm.Int32|**Display Name**: Job Status<br />**Description**: Enter the status of the job.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Pending</td></tr><tr><td>690970001</td><td>In Progress</td></tr><tr><td>690970002</td><td>Completed</td></tr><tr><td>690970003</td><td>Failed</td></tr><tbody></table>|
|msdyn_jobtype|Edm.Int32|**Display Name**: Job Type<br />|
|msdyn_outputparameter|Edm.String|**Display Name**: Output Parameter<br />|
|msdyn_outputparametertype|Edm.Int32|**Display Name**: Output Parameter Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>String List</td></tr><tr><td>690970001</td><td>Json</td></tr><tr><td>690970002</td><td>Xml</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Field Service System Job<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows the reason for the status of the field service system job.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_msdyn_ownerid_value|msdyn_ownerid<br />|Shows the user associated with the field service system job.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_fieldservicesystemjob_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_fieldservicesystemjob_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_fieldservicesystemjob_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_fieldservicesystemjob_modifiedonbehalfby|
|msdyn_ownerid|[systemuser EntityType](systemuser.md)|msdyn_systemuser_msdyn_fieldservicesystemjob_OwnerId|
|organizationid|[organization EntityType](organization.md)|organization_msdyn_fieldservicesystemjob|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_fieldservicesystemjob_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_fieldservicesystemjob|  
|msdyn_fieldservicesystemjob_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_fieldservicesystemjob|  
|msdyn_fieldservicesystemjob_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_fieldservicesystemjob|  

## Operations
The following operations can be used with the msdyn_fieldservicesystemjob entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the msdyn_fieldservicesystemjob entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_fieldservicesystemjob.md](./remarks/msdyn_fieldservicesystemjob.md)]

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