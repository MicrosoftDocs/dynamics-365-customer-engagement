---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_schedulingoptimizationhealthlog EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 715675a7-b930-4e3a-a8e9-bbef6ac36052
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_schedulingoptimizationhealthlog entitytype."
---
# msdyn_schedulingoptimizationhealthlog EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_schedulingoptimizationhealthlog.md](./descriptions/msdyn_schedulingoptimizationhealthlog.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_schedulingoptimizationhealthlogs </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Scheduling Optimization Health Log</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_schedulingoptimizationhealthlogid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_schedulingoptimizationhealthlog entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Last Run<br />**Description**: Date and time when the record was modified. This is also used to show when was the associated Diagnostic Rule last run<br />Read-only<br />|
|msdyn_details|Edm.String|**Display Name**: Details<br />**Description**: Details of the result of health check on a diagnostic rule of RSO<br />|
|msdyn_diagnosticrule|Edm.Int32|**Display Name**: Diagnostic Rule<br />**Description**: Diagnostic Rule of RSO that this log record corresponds to<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350001</td><td>Dead Letter</td></tr><tr><td>192350002</td><td>Error Queue</td></tr><tr><td>192350000</td><td>SQL DB Connection</td></tr><tbody></table>|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_schedulingoptimizationhealthlogid|Edm.Guid|**Display Name**: Scheduling Optimization Health Log<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_status|Edm.Int32|**Display Name**: Status<br />**Description**: Status of health check on a diagnostic rule of RSO<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Pass</td></tr><tr><td>192350001</td><td>Warning</td></tr><tr><td>192350002</td><td>Fail</td></tr><tbody></table>|
|msdyn_suggestedaction|Edm.Int32|**Display Name**: Suggested Action<br />**Description**: Suggested action that the user can take based on the result of the health check on the diagnostic rule<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350002</td><td>None</td></tr><tr><td>192350000</td><td>Contact Administrator</td></tr><tr><td>192350001</td><td>Update Password</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Scheduling Optimization Health Log<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Scheduling Optimization Health Log<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_schedulingoptimizationhealthlog_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_schedulingoptimizationhealthlog_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_schedulingoptimizationhealthlog_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_schedulingoptimizationhealthlog_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_schedulingoptimizationhealthlog|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_schedulingoptimizationhealthlog|
|owningteam|[team EntityType](team.md)|team_msdyn_schedulingoptimizationhealthlog|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_schedulingoptimizationhealthlog|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_schedulingoptimizationhealthlog_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_schedulingoptimizationhealthlog|  
|msdyn_schedulingoptimizationhealthlog_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_schedulingoptimizationhealthlog|  
|msdyn_schedulingoptimizationhealthlog_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_schedulingoptimizationhealthlog|  

## Operations
The following operations can be used with the msdyn_schedulingoptimizationhealthlog entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_schedulingoptimizationhealthlog entity type.


|Name|Description |  
|----|------------|  
|[Resource Scheduling Optimization Solution](../solutions/resourceschedulingoptimization.md)|[!INCLUDE[../solutions/descriptions/resourceschedulingoptimization.md](../solutions/descriptions/resourceschedulingoptimization.md)]|    

[!INCLUDE[./remarks/msdyn_schedulingoptimizationhealthlog.md](./remarks/msdyn_schedulingoptimizationhealthlog.md)]

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