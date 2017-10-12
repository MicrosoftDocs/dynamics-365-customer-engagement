---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_routingprofileconfiguration EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 24cfc771-a4ac-4ad6-be46-e52e74abaabe
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_routingprofileconfiguration entitytype."
---
# msdyn_routingprofileconfiguration EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_routingprofileconfiguration.md](./descriptions/msdyn_routingprofileconfiguration.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_routingprofileconfigurations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Scheduling Optimization Schedule</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_routingprofileconfigurationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_routingprofileconfiguration entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_daysofmonth|Edm.String|**Display Name**: Days of Month<br />**Description**: Days of the month a schedule will run.<br />|
|msdyn_daysofweek|Edm.String|**Display Name**: Days of Week<br />**Description**: Days of the week that resource scheduling optimization will run.<br />|
|msdyn_errormessage|Edm.String|**Display Name**: Error Details<br />**Description**: Contains the error details from publishing.<br />|
|msdyn_filtertimezone|Edm.Int32|**Display Name**: Filter Time Zone<br />**Description**: Specifies the time zone for the schedule's filter.<br />|
|msdyn_hours|Edm.String|**Display Name**: Hours<br />**Description**: Hours on which a schedule will run.<br />|
|msdyn_interval|Edm.Int32|**Display Name**: Timer<br />**Description**: How frequently a schedule will run. Execution times also depend on the selected timer mode.<br />|
|msdyn_intervalfrom|Edm.Int32|**Display Name**: Timer Mode<br />**Description**: Reference point from when the schedule will start the defined timer.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Fixed</td></tr><tr><td>192350001</td><td>After Job Completion</td></tr><tbody></table>|
|msdyn_minutes|Edm.String|**Display Name**: Minutes<br />**Description**: Minutes on which a schedule will run.<br />|
|msdyn_months|Edm.String|**Display Name**: Months<br />**Description**: Months in which a schedule will run.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Name of a schedule.<br />|
|msdyn_nextscheduledrunat|Edm.DateTimeOffset|**Display Name**: Next Scheduled Run At<br />**Description**: Next scheduled run time, based on the schedule frequency that is set up, but that is not guaranteed due to potential conflicts and timer settings.<br />|
|msdyn_publishdate|Edm.DateTimeOffset|**Display Name**: Last Publish Date<br />**Description**: Last date and time a schedule was published.<br />|
|msdyn_routingprofileconfigurationid|Edm.Guid|**Display Name**: Scheduling Optimization Profile Configuration<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_status|Edm.Int32|**Display Name**: Status<br />**Description**: Status of this schedule.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Unpublished</td></tr><tr><td>192350001</td><td>Publishing</td></tr><tr><td>192350002</td><td>Published</td></tr><tr><td>192350003</td><td>Failed</td></tr><tr><td>192350004</td><td>Out of Sync</td></tr><tr><td>192350005</td><td>Under Maintenance</td></tr><tbody></table>|
|msdyn_validtimefrom|Edm.DateTimeOffset|**Display Name**: Valid From<br />**Description**: First date and time when a schedule can run.<br />|
|msdyn_validtimeto|Edm.DateTimeOffset|**Display Name**: Valid To<br />**Description**: Last date and time when a schedule will run.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the scheduling optimization profile configuration.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of a scheduling optimization profile configuration.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_msdyn_engineconfiguration_value|msdyn_EngineConfiguration<br />|Set of objectives and constraints that the resource scheduling optimization will target when running a job.|
|_msdyn_jobconfiguration_value|msdyn_JobConfiguration<br />|Set of resource requirements that the resource scheduling optimization will optimize when running a job.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_routingprofileconfiguration_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_routingprofileconfiguration_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_routingprofileconfiguration_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_routingprofileconfiguration_modifiedonbehalfby|
|msdyn_EngineConfiguration|[msdyn_routingengineconfiguration EntityType](msdyn_routingengineconfiguration.md)|msdyn_msdyn_routingengineconfiguration_msdyn_routingprofileconfiguration_EngineConfiguration|
|msdyn_JobConfiguration|[msdyn_routingjobconfiguration EntityType](msdyn_routingjobconfiguration.md)|msdyn_msdyn_routingjobconfiguration_msdyn_routingprofileconfiguration_JobConfiguration|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_routingprofileconfiguration|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_routingprofileconfiguration|
|owningteam|[team EntityType](team.md)|team_msdyn_routingprofileconfiguration|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_routingprofileconfiguration|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_BlockingSchedule|[msdyn_routingoptimizationrequest EntityType](msdyn_routingoptimizationrequest.md)|msdyn_BlockingSchedule|  
|msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_Source|[msdyn_routingoptimizationrequest EntityType](msdyn_routingoptimizationrequest.md)|msdyn_SourceAutoRoutingSchedule|  
|msdyn_routingprofileconfiguration_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_routingprofileconfiguration|  
|msdyn_routingprofileconfiguration_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_routingprofileconfiguration|  
|msdyn_routingprofileconfiguration_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_routingprofileconfiguration|  
|msdyn_routingprofileconfiguration_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_routingprofileconfiguration|  
|msdyn_routingprofileconfiguration_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_routingprofileconfiguration|  

## Operations
The following operations can be used with the msdyn_routingprofileconfiguration entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_routingprofileconfiguration entity type.


|Name|Description |  
|----|------------|  
|[Resource Scheduling Optimization Solution](../solutions/resourceschedulingoptimization.md)|[!INCLUDE[../solutions/descriptions/resourceschedulingoptimization.md](../solutions/descriptions/resourceschedulingoptimization.md)]|    

[!INCLUDE[./remarks/msdyn_routingprofileconfiguration.md](./remarks/msdyn_routingprofileconfiguration.md)]

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