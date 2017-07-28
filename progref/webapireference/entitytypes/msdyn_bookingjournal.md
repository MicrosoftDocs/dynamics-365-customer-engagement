---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_bookingjournal EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 381b8751-db6f-4270-a0ea-ed94f05dbb74
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_bookingjournal entitytype."
---
# msdyn_bookingjournal EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_bookingjournal.md](./descriptions/msdyn_bookingjournal.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_bookingjournals </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Booking Journal</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_bookingjournalid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_bookingjournal entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_additionalcost|Edm.Decimal|**Display Name**: Additional Cost<br />**Description**: Shows the additional cost associated with this journal, if any. (This amount is not multiplied by quantity)<br />|
|msdyn_additionalcost_base|Edm.Decimal|**Display Name**: Additional Cost (Base)<br />**Description**: Shows the value of the additional cost in the base currency.<br />Read-only<br />|
|msdyn_billable|Edm.Boolean|**Display Name**: Billable<br />**Description**: Shows if this journal is billable.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_bookingjournalid|Edm.Guid|**Display Name**: Booking Journal<br />**Description**: Shows the entity instances.<br />|
|msdyn_duration|Edm.Int32|**Display Name**: Duration<br />**Description**: Enter the total duration of this journal record.<br />|
|msdyn_endtime|Edm.DateTimeOffset|**Display Name**: End Time<br />**Description**: Enter the end time of this journal record.<br />|
|msdyn_journaltype|Edm.Int32|**Display Name**: Journal Type<br />**Description**: Enter the type of journal.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Working Hours</td></tr><tr><td>690970001</td><td>Break</td></tr><tr><td>690970002</td><td>Travel</td></tr><tr><td>690970003</td><td>Overtime</td></tr><tr><td>690970004</td><td>Business Closure</td></tr><tbody></table>|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the custom entity.<br />|
|msdyn_starttime|Edm.DateTimeOffset|**Display Name**: Start Time<br />**Description**: Enter the start time of this journal record.<br />|
|msdyn_totalcost|Edm.Decimal|**Display Name**: Total Cost<br />**Description**: Shows the total cost company pays to resource.<br />|
|msdyn_totalcost_base|Edm.Decimal|**Display Name**: Total Cost (Base)<br />**Description**: Shows the value of the total cost in the base currency.<br />Read-only<br />|
|msdyn_unitcost|Edm.Decimal|**Display Name**: Unit Cost<br />**Description**: Enter the hourly cost that company pays to the resource.<br />|
|msdyn_unitcost_base|Edm.Decimal|**Display Name**: Unit Cost (Base)<br />**Description**: Shows the value of the unit cost in the base currency.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Booking Journal<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Booking Journal<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_booking_value|msdyn_booking<br />|This Resource Booking this journal pertains to|
|_msdyn_paytype_value|msdyn_paytype<br />|Unique identifier for Resource Pay Type associated with Booking Journal.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_bookingjournal_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_bookingjournal_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_bookingjournal_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_bookingjournal_modifiedonbehalfby|
|msdyn_booking|[bookableresourcebooking EntityType](bookableresourcebooking.md)|msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking|
|msdyn_paytype|[msdyn_resourcepaytype EntityType](msdyn_resourcepaytype.md)|msdyn_msdyn_resourcepaytype_msdyn_bookingjournal_PayType|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_bookingjournal|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_bookingjournal|
|owningteam|[team EntityType](team.md)|team_msdyn_bookingjournal|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_bookingjournal|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_bookingjournal|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_bookingjournal_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_bookingjournal|  
|msdyn_bookingjournal_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_bookingjournal|  
|msdyn_bookingjournal_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_bookingjournal|  
|msdyn_bookingjournal_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_bookingjournal|  

## Operations
The following operations can be used with the msdyn_bookingjournal entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_bookingjournal entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_bookingjournal.md](./remarks/msdyn_bookingjournal.md)]

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