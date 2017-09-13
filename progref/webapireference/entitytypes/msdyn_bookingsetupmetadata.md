---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_bookingsetupmetadata EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a10a06c3-2aa0-4608-8bb3-cb4086507bd8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_bookingsetupmetadata entitytype."
---
# msdyn_bookingsetupmetadata EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_bookingsetupmetadata.md](./descriptions/msdyn_bookingsetupmetadata.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_bookingsetupmetadatas </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Booking Setup Metadata</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_bookingsetupmetadataid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_entitylogicalname</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_bookingsetupmetadata entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_bookingrelationshiplogicalname|Edm.String|**Display Name**: Booking Relationship Logical Name<br />**Description**: A unique identifier that links bookings to a scheduling entity.<br />|
|msdyn_bookingsetupmetadataid|Edm.Guid|**Display Name**: Booking Setup Metadata<br />**Description**: A unique identifier for an entity instance.<br />|
|msdyn_bookingstatusfieldlogicalname|Edm.String|**Display Name**: Booking Status Field Logical Name<br />**Description**: An option set that is used to group and filter statuses.<br />|
|msdyn_cancelbookingswhenmoving|Edm.Boolean|**Display Name**: Cancel Bookings When Moving<br />**Description**: Select whether, when moving open slots to the next day, to leave the old slots and change their status to "Cancel."<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_defaultbookingduration|Edm.Int32|**Display Name**: Default Booking Duration<br />**Description**: The default booking duration to use when a duration is not provided.<br />|
|msdyn_defaultschedulingmethod|Edm.Int32|**Display Name**: Default Scheduling Method<br />**Description**: Select the default Scheduling Method when creating Resource Requirement for the associated entity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Optimize</td></tr><tr><td>192350001</td><td>Do Not Optimize</td></tr><tbody></table>|
|msdyn_disablerequirementautocreation|Edm.Boolean|**Display Name**: Disable Requirement Auto Creation<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_entitylogicalname|Edm.String|**Display Name**: Entity Logical Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_requirementrelationshiplogicalname|Edm.String|**Display Name**: Requirement Relationship Logical Name<br />**Description**: A unique identifier that links requirements to an enabled scheduling entity.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Booking Setup Metadata<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Booking Setup Metadata<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_defaultbookingcanceledstatus_value|msdyn_DefaultBookingCanceledStatus<br />|The default booking canceled status to use when a user can't select a status.|
|_msdyn_defaultbookingcommittedstatus_value|msdyn_DefaultBookingCommittedStatus<br />|The default booking committed status to use when a user can't select a status.|
|_msdyn_defaultrequirementactivestatus_value|msdyn_DefaultRequirementActiveStatus<br />|The default requirement active status to use when a user can't select a status|
|_msdyn_defaultrequirementcanceledstatus_value|msdyn_DefaultRequirementCanceledStatus<br />|The default requirement canceled status to use when a user can't select a status.|
|_msdyn_defaultrequirementcompletedstatus_value|msdyn_DefaultRequirementCompletedStatus<br />|The default requirement completed status to use when a user can't select a status.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_bookingsetupmetadata_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_bookingsetupmetadata_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_bookingsetupmetadata_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_bookingsetupmetadata_modifiedonbehalfby|
|msdyn_DefaultBookingCanceledStatus|[bookingstatus EntityType](bookingstatus.md)|msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus|
|msdyn_DefaultBookingCommittedStatus|[bookingstatus EntityType](bookingstatus.md)|msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus|
|msdyn_DefaultRequirementActiveStatus|[msdyn_requirementstatus EntityType](msdyn_requirementstatus.md)|msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementActiveStatus|
|msdyn_DefaultRequirementCanceledStatus|[msdyn_requirementstatus EntityType](msdyn_requirementstatus.md)|msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCanceledStatus|
|msdyn_DefaultRequirementCompletedStatus|[msdyn_requirementstatus EntityType](msdyn_requirementstatus.md)|msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCompletedStatus|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_bookingsetupmetadata|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_bookingsetupmetadata|
|owningteam|[team EntityType](team.md)|team_msdyn_bookingsetupmetadata|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_bookingsetupmetadata|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_bookingsetupmetadata_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_bookingsetupmetadata|  
|msdyn_bookingsetupmetadata_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_bookingsetupmetadata|  
|msdyn_bookingsetupmetadata_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_bookingsetupmetadata|  
|msdyn_msdyn_bookingsetupmetadata_bookableresour|[bookableresourcebooking EntityType](bookableresourcebooking.md)|msdyn_BookingSetupMetadataId|  
|msdyn_msdyn_bookingsetupmetadata_msdyn_resource|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|msdyn_BookingSetupMetadataId|  

## Operations
The following operations can be used with the msdyn_bookingsetupmetadata entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_bookingsetupmetadata entity type.


|Name|Description |  
|----|------------|  
|[Unified Resource Scheduling Solution](../solutions/microsoftdynamicsscheduling.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsscheduling.md](../solutions/descriptions/microsoftdynamicsscheduling.md)]|  
|[Resource Scheduling Optimization Solution](../solutions/resourceschedulingoptimization.md)|[!INCLUDE[../solutions/descriptions/resourceschedulingoptimization.md](../solutions/descriptions/resourceschedulingoptimization.md)]|    

[!INCLUDE[./remarks/msdyn_bookingsetupmetadata.md](./remarks/msdyn_bookingsetupmetadata.md)]

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