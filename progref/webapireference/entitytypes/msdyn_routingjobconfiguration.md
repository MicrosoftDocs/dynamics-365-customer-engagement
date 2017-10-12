---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_routingjobconfiguration EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 10d49d11-af7f-470c-8a47-95246d185e03
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_routingjobconfiguration entitytype."
---
# msdyn_routingjobconfiguration EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_routingjobconfiguration.md](./descriptions/msdyn_routingjobconfiguration.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_routingjobconfigurations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Scheduling Optimization Scope</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_routingjobconfigurationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_routingjobconfiguration entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_duration|Edm.Int32|**Display Name**: Range Duration (days)<br />**Description**: Enter the amount of days that should be added to the range start to define the range end.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Type the name for this scope.<br />|
|msdyn_routingjobconfigurationid|Edm.Guid|**Display Name**: Optimization Job Configuration<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_schedulescope|Edm.Int32|**Display Name**: Resource Requirement State<br />**Description**: Resource requirements that will be selected for resource scheduling optimization, based on their current state.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Only Scheduled</td></tr><tr><td>192350001</td><td>Scheduled or Unscheduled</td></tr><tbody></table>|
|msdyn_starttime|Edm.Int32|**Display Name**: Range Reference<br />**Description**: Start point for all subsequent resource requirement range calculations. Scheduled resource requirements must fall into the range start and end times to be considered for resource scheduling optimization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Job Current Time</td></tr><tr><td>192350001</td><td>Beginning of the Job's Current Day - 12:00 AM UTC time zone</td></tr><tbody></table>|
|msdyn_starttimebuffer|Edm.Int32|**Display Name**: Range Offset<br />**Description**: Enter the amount of time that should be added to the range reference to define the range start.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Optimization Job Configuration<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Optimization Job Configuration<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_scheduleboardsetting_value|msdyn_ScheduleBoardSetting<br />|Reference to the schedule board settings for this scope.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_routingjobconfiguration_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_routingjobconfiguration_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_routingjobconfiguration_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_routingjobconfiguration_modifiedonbehalfby|
|msdyn_ScheduleBoardSetting|[msdyn_scheduleboardsetting EntityType](msdyn_scheduleboardsetting.md)|msdyn_msdyn_scheduleboardsetting_msdyn_routingjobconfiguration_ScheduleBoardSetting|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_routingjobconfiguration|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_routingjobconfiguration|
|owningteam|[team EntityType](team.md)|team_msdyn_routingjobconfiguration|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_routingjobconfiguration|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_routingjobconfiguration_msdyn_routingprofileconfiguration_JobConfiguration|[msdyn_routingprofileconfiguration EntityType](msdyn_routingprofileconfiguration.md)|msdyn_JobConfiguration|  
|msdyn_msdyn_routingjobconfiguration_territory|[territory EntityType](territory.md)|msdyn_msdyn_routingjobconfiguration_territory|  
|msdyn_routingjobconfiguration_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_routingjobconfiguration|  
|msdyn_routingjobconfiguration_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_routingjobconfiguration|  
|msdyn_routingjobconfiguration_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_routingjobconfiguration|  
|msdyn_routingjobconfiguration_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_routingjobconfiguration|  
|msdyn_routingjobconfiguration_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_routingjobconfiguration|  

## Operations
The following operations can be used with the msdyn_routingjobconfiguration entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_routingjobconfiguration entity type.


|Name|Description |  
|----|------------|  
|[Resource Scheduling Optimization Solution](../solutions/resourceschedulingoptimization.md)|[!INCLUDE[../solutions/descriptions/resourceschedulingoptimization.md](../solutions/descriptions/resourceschedulingoptimization.md)]|    

[!INCLUDE[./remarks/msdyn_routingjobconfiguration.md](./remarks/msdyn_routingjobconfiguration.md)]

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