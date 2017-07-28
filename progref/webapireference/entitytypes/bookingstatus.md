---
title: "Microsoft Dynamics 365 Customer Engagement bookingstatus EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 1ce10d11-fdd8-438b-aee0-fde44bf10637
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API bookingstatus entitytype."
---
# bookingstatus EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/bookingstatus.md](./descriptions/bookingstatus.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]bookingstatuses </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Booking Status</td></tr>
<tr><td><b>Primary Key:</b></td><td>bookingstatusid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The bookingstatus entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|bookingstatusid|Edm.Guid|**Display Name**: Booking Status<br />**Description**: Unique identifier of the booking status.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type a detailed description for the booking status.<br />|
|exchangerate|Edm.Decimal|**Display Name**: ExchangeRate<br />**Description**: Exchange rate for the currency associated with the bookingstatus with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_committype|Edm.Int32|**Display Name**: Commit Type<br />**Description**: Commit Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350004</td><td>Canceled</td></tr><tr><td>192350000</td><td>None</td></tr><tr><td>192350001</td><td>Hard Book</td></tr><tr><td>192350002</td><td>Soft Book</td></tr><tr><td>192350003</td><td>Proposed</td></tr><tbody></table>|
|msdyn_fieldservicestatus|Edm.Int32|**Display Name**: Field Service Status<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Scheduled</td></tr><tr><td>690970001</td><td>Traveling</td></tr><tr><td>690970003</td><td>In Progress</td></tr><tr><td>690970002</td><td>On Break</td></tr><tr><td>690970004</td><td>Completed</td></tr><tr><td>690970005</td><td>Canceled</td></tr><tbody></table>|
|msdyn_imageurl|Edm.String|**Display Name**: Image Url<br />**Description**: The URL for a web resource image.<br />|
|msdyn_internalflags|Edm.String|**Display Name**: Internal Flags<br />**Description**: For internal use only.<br />|
|msdyn_schedulingmethod|Edm.Int32|**Display Name**: Scheduling Method<br />**Description**: Whether bookings with this status should be included in the routing optimization or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Optimize</td></tr><tr><td>192350001</td><td>Do Not Move</td></tr><tr><td>192350002</td><td>Ignore</td></tr><tbody></table>|
|msdyn_statuscolor|Edm.String|**Display Name**: Status Color<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the booking status.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Booking Status<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|status|Edm.Int32|**Display Name**: Status<br />**Description**: Select whether the booking status should be proposed, committed or canceled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Proposed</td></tr><tr><td>2</td><td>Committed</td></tr><tr><td>3</td><td>Canceled</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Booking Status<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdbyname<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfbyname<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedbyname<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfbyname<br />|Unique identifier of the delegate user who modified the record.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Exchange rate for the currency associated with the BookingStatus with respect to the base currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdbyname|[systemuser EntityType](systemuser.md)|lk_bookingstatus_createdby|
|createdonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_bookingstatus_createdonbehalfby|
|modifiedbyname|[systemuser EntityType](systemuser.md)|lk_bookingstatus_modifiedby|
|modifiedonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_bookingstatus_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_bookingstatus|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_bookingstatus|
|owningteam|[team EntityType](team.md)|team_bookingstatus|
|owninguser|[systemuser EntityType](systemuser.md)|user_bookingstatus|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_bookingstatus|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|bookingstatus_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_bookingstatus|  
|bookingstatus_bookableresourcebooking_BookingStatus|[bookableresourcebooking EntityType](bookableresourcebooking.md)|BookingStatus|  
|bookingstatus_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_bookingstatus|  
|bookingstatus_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_bookingstatus|  
|bookingstatus_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_bookingstatus|  
|BookingStatus_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_bookingstatus_syncerror|  
|msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|msdyn_bookingstatusid|  
|msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus|[msdyn_bookingsetupmetadata EntityType](msdyn_bookingsetupmetadata.md)|msdyn_DefaultBookingCanceledStatus|  
|msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus|[msdyn_bookingsetupmetadata EntityType](msdyn_bookingsetupmetadata.md)|msdyn_DefaultBookingCommittedStatus|  
|msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus|[msdyn_fieldservicesetting EntityType](msdyn_fieldservicesetting.md)|msdyn_defaultcanceledbookingstatus|  
|msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus|[msdyn_fieldservicesetting EntityType](msdyn_fieldservicesetting.md)|msdyn_defaultscheduledbookingstatus|  
|msdyn_bookingstatus_msdyn_resourceassignment_bookingstatusid|[msdyn_resourceassignment EntityType](msdyn_resourceassignment.md)|msdyn_bookingstatusid|  

## Operations
The following operations can be used with the bookingstatus entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the bookingstatus entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Microsoft Dynamics Scheduling Workload Solution](../solutions/scheduling.md)|[!INCLUDE[../solutions/descriptions/scheduling.md](../solutions/descriptions/scheduling.md)]|  
|[Unified Resource Scheduling Solution](../solutions/microsoftdynamicsscheduling.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsscheduling.md](../solutions/descriptions/microsoftdynamicsscheduling.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|  
|[Resource Scheduling Optimization Solution](../solutions/resourceschedulingoptimization.md)|[!INCLUDE[../solutions/descriptions/resourceschedulingoptimization.md](../solutions/descriptions/resourceschedulingoptimization.md)]|    

[!INCLUDE[./remarks/bookingstatus.md](./remarks/bookingstatus.md)]

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