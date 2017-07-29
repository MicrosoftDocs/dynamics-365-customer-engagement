---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_resourceassignment EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: afecb778-5ae6-4213-901d-bf800fd5475f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_resourceassignment entitytype."
---
# msdyn_resourceassignment EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_resourceassignment.md](./descriptions/msdyn_resourceassignment.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_resourceassignments </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Resource Assignment</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_resourceassignmentid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_committype|Edm.Int32|**Display Name**: Commit Type<br />**Description**: Select the commitment type of the assignment (hard or soft).<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350004</td><td>Canceled</td></tr><tr><td>192350000</td><td>None</td></tr><tr><td>192350001</td><td>Hard Book</td></tr><tr><td>192350002</td><td>Soft Book</td></tr><tr><td>192350003</td><td>Proposed</td></tr><tbody></table>|
|msdyn_fromdate|Edm.DateTimeOffset|**Display Name**: From Date<br />**Description**: Enter the date a resource is assigned from.<br />|
|msdyn_hours|Edm.Decimal|**Display Name**: Hours<br />**Description**: Enter the number of hours for which a resource is assigned.<br />|
|msdyn_msprojectclientid|Edm.String|**Display Name**: MS Project Client Id<br />**Description**: id for resource assignment in ms project<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the custom entity.<br />|
|msdyn_resourceassignmentid|Edm.Guid|**Display Name**: Resource Assignment<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_todate|Edm.DateTimeOffset|**Display Name**: To Date<br />**Description**: Enter the end date until which a resource is assigned.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Resource Assignment<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Resource Assignment<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_bookableresourceid_value|msdyn_bookableresourceid<br />|Shows the resource.|
|_msdyn_bookingstatusid_value|msdyn_bookingstatusid<br />|Booking Status|
|_msdyn_projectid_value|msdyn_projectid<br />|Select the project for which the resource is assigned.|
|_msdyn_projectteamid_value|msdyn_projectteamid<br />|Unique identifier for Project Team Member associated with Resource Assignment.|
|_msdyn_taskid_value|msdyn_taskid<br />|Select the task for which the resource is assigned to.|
|_msdyn_userresourceid_value||Select the user whose capacity is assigned.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_resourceassignment_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_resourceassignment_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_resourceassignment_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_resourceassignment_modifiedonbehalfby|
|msdyn_bookableresourceid|[bookableresource EntityType](bookableresource.md)|msdyn_bookableresource_msdyn_resourceassignment_bookableresourceid|
|msdyn_bookingstatusid|[bookingstatus EntityType](bookingstatus.md)|msdyn_bookingstatus_msdyn_resourceassignment_bookingstatusid|
|msdyn_projectid|[msdyn_project EntityType](msdyn_project.md)|msdyn_msdyn_project_msdyn_resourceassignment_projectid|
|msdyn_projectteamid|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_msdyn_projectteam_msdyn_resourceassignment_projectteamid|
|msdyn_taskid|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_msdyn_projecttask_msdyn_resourceassignment_taskid|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_resourceassignment|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_resourceassignment|
|owningteam|[team EntityType](team.md)|team_msdyn_resourceassignment|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_resourceassignment|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_resourceassignment_msdyn_resourceassignmentdetail_resourceassignmentid|[msdyn_resourceassignmentdetail EntityType](msdyn_resourceassignmentdetail.md)|msdyn_resourceassignmentid|  
|msdyn_resourceassignment_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_resourceassignment|  
|msdyn_resourceassignment_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_resourceassignment|  
|msdyn_resourceassignment_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_resourceassignment|  

## Operations
The following operations can be used with the msdyn_resourceassignment entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[msdyn_ResourceAssignmentDetailUpdate Action](../actions/msdyn_resourceassignmentdetailupdate.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_resourceassignmentdetailupdate.md](../actions/descriptions/msdyn_resourceassignmentdetailupdate.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_resourceassignment entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_resourceassignment.md](./remarks/msdyn_resourceassignment.md)]

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