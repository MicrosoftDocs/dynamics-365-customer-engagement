---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_timeentry EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4d3f168b-b26a-44b4-b7cb-5298b2c200e3
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_timeentry entitytype."
---
# msdyn_timeentry EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_timeentry.md](./descriptions/msdyn_timeentry.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_timeentries </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Time Entry</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_timeentryid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_description</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_timeentry entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_date|Edm.DateTimeOffset|**Display Name**: Date<br />**Description**: Enter the time entry date.<br />|
|msdyn_description|Edm.String|**Display Name**: Internal Comments<br />**Description**: Type the description of the time entry.<br />|
|msdyn_duration|Edm.Int32|**Display Name**: Duration<br />**Description**: Shows the time spent.<br />|
|msdyn_entrystatus|Edm.Int32|**Display Name**: Entry Status<br />**Description**: Select the entry status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Draft</td></tr><tr><td>192350001</td><td>Returned</td></tr><tr><td>192350002</td><td>Approved</td></tr><tr><td>192350003</td><td>Submitted</td></tr><tbody></table>|
|msdyn_externaldescription|Edm.String|**Display Name**: External Comments<br />**Description**: Type the external description of the time entry.<br />|
|msdyn_relateditemid|Edm.String|**Display Name**: Related item identifier<br />**Description**: The identifier of the related item.<br />|
|msdyn_relateditemtype|Edm.Int32|**Display Name**: Related item type<br />**Description**: The related item type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>None</td></tr><tr><td>192350001</td><td>Resource Booking</td></tr><tr><td>192350002</td><td>Resource Assignment</td></tr><tr><td>192350100</td><td>Exchange Appointments</td></tr><tbody></table>|
|msdyn_targetentrystatus|Edm.Int32|**Display Name**: Target Entry Status<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Draft</td></tr><tr><td>192350001</td><td>Returned</td></tr><tr><td>192350002</td><td>Approved</td></tr><tr><td>192350003</td><td>Submitted</td></tr><tbody></table>|
|msdyn_timeentryid|Edm.Guid|**Display Name**: Time Entry<br />**Description**: The unique identifier for a time entry.<br />|
|msdyn_type|Edm.Int32|**Display Name**: Type<br />**Description**: Select the time entry type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Work</td></tr><tr><td>192350001</td><td>Absence</td></tr><tr><td>192350002</td><td>Vacation</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Time Entry<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Time Entry<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_bookableresource_value|msdyn_bookableresource<br />|Shows the bookable resource.|
|_msdyn_manager_value|msdyn_manager<br />|Select the manager of the time entry user. This field is used for approval.|
|_msdyn_project_value|msdyn_project<br />|Select the project that the time entry is related to.|
|_msdyn_projecttask_value|msdyn_projectTask<br />|Select the project task that the time entry is related to.|
|_msdyn_resourcecategory_value|msdyn_resourceCategory<br />|Select the role that the user has in the project that the time entry is for.|
|_msdyn_resourceorganizationalunitid_value|msdyn_ResourceOrganizationalUnitId<br />|Select the organizational unit at the time the entry was registered of the resource who performed the work.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_timeentry_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_timeentry_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_timeentry_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_timeentry_modifiedonbehalfby|
|msdyn_bookableresource|[bookableresource EntityType](bookableresource.md)|msdyn_bookableresource_msdyn_timeentry_bookableresource|
|msdyn_manager|[systemuser EntityType](systemuser.md)|msdyn_systemuser_msdyn_timeentry_manager|
|msdyn_project|[msdyn_project EntityType](msdyn_project.md)|msdyn_msdyn_project_msdyn_timeentry_project|
|msdyn_projectTask|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_msdyn_projecttask_msdyn_timeentry_projectTask|
|msdyn_resourceCategory|[bookableresourcecategory EntityType](bookableresourcecategory.md)|msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory|
|msdyn_ResourceOrganizationalUnitId|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_organizationalunit_timeentry|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_timeentry|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_timeentry|
|owningteam|[team EntityType](team.md)|team_msdyn_timeentry|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_timeentry|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_timeentry_msdyn_projectapproval_TimeEntry|[msdyn_projectapproval EntityType](msdyn_projectapproval.md)|msdyn_TimeEntry|  
|msdyn_msdyn_timeentry_msdyn_timeoffcalendar_timeEntry|[msdyn_timeoffcalendar EntityType](msdyn_timeoffcalendar.md)|msdyn_timeEntry|  
|msdyn_timeentry_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_timeentry|  
|msdyn_timeentry_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_timeentry|  
|msdyn_timeentry_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_timeentry|  
|msdyn_timeentry_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_timeentry|  

## Operations
The following operations can be used with the msdyn_timeentry entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_timeentry entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_timeentry.md](./remarks/msdyn_timeentry.md)]

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