---
title: "Microsoft Dynamics 365 Customer Engagement msevtmgt_hotelroomallocation EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 783375c2-ce9b-424c-80b9-2ece0b769242
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msevtmgt_hotelroomallocation entitytype."
---
# msevtmgt_hotelroomallocation EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msevtmgt_hotelroomallocation.md](./descriptions/msevtmgt_hotelroomallocation.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msevtmgt_hotelroomallocations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Hotel Room Allocation</td></tr>
<tr><td><b>Primary Key:</b></td><td>msevtmgt_hotelroomallocationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msevtmgt_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msevtmgt_hotelroomallocation entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msevtmgt_additionaldetails|Edm.String|**Display Name**: Additional Details<br />**Description**: Room allocation additional details<br />|
|msevtmgt_hotelroomallocationid|Edm.Guid|**Display Name**: Hotel Room Allocation<br />**Description**: Unique identifier for entity instances<br />|
|msevtmgt_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msevtmgt_numberofroomsallocated|Edm.Int32|**Display Name**: Number of rooms allocated<br />**Description**: Number of allocated rooms<br />|
|msevtmgt_numberofroomsleft|Edm.Int32|**Display Name**: Number of rooms left<br />**Description**: Number of rooms left<br />Computed<br />Read-only<br />|
|msevtmgt_numberofroomsreserved|Edm.Int32|**Display Name**: Number of rooms reserved<br />**Description**: Number of reserved rooms<br />Computed<br />Read-only<br />|
|msevtmgt_numberofroomsreserved_date|Edm.DateTimeOffset|**Display Name**: Number of rooms reserved (Last Updated On)<br />**Description**: Last Updated time of rollup field Number of rooms reserved.<br />Read-only<br />|
|msevtmgt_numberofroomsreserved_state|Edm.Int32|**Display Name**: Number of rooms reserved (State)<br />**Description**: State of rollup field Number of rooms reserved.<br />Read-only<br />|
|msevtmgt_priceperroom|Edm.Decimal|**Display Name**: Price per room<br />**Description**: Price per room<br />|
|msevtmgt_priceperroom_base|Edm.Decimal|**Display Name**: Price per Room (Base)<br />**Description**: Value of the Price per Room in base currency.<br />Read-only<br />|
|msevtmgt_roomtype|Edm.Int32|**Display Name**: Room Type<br />**Description**: Room type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Single Room</td></tr><tr><td>100000001</td><td>Double Room</td></tr><tr><td>100000002</td><td>Junior Suite</td></tr><tr><td>100000003</td><td>Executive Suite</td></tr><tr><td>100000004</td><td>Luxury Suite</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Hotel Room Allocation<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Hotel Room Allocation<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msevtmgt_event_value|msevtmgt_Event<br />|Related event|
|_msevtmgt_hotelproperty_value|msevtmgt_HotelProperty<br />|Related hotel property|
|_msevtmgt_primarycontact_value|msevtmgt_PrimaryContact<br />|Primary contact|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_hotelroomallocation_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_hotelroomallocation_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_hotelroomallocation_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_hotelroomallocation_modifiedonbehalfby|
|msevtmgt_Event|[msevtmgt_event EntityType](msevtmgt_event.md)|msevtmgt_msevtmgt_event_hotelroomallocation_Event|
|msevtmgt_HotelProperty|[msevtmgt_hotel EntityType](msevtmgt_hotel.md)|msevtmgt_msevtmgt_hotel_hotelroomallocation_HotelProperty|
|msevtmgt_PrimaryContact|[contact EntityType](contact.md)|msevtmgt_contact_msevtmgt_hotelroomallocation_PrimaryContact|
|ownerid|[principal EntityType](principal.md)|owner_msevtmgt_hotelroomallocation|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msevtmgt_hotelroomallocation|
|owningteam|[team EntityType](team.md)|team_msevtmgt_hotelroomallocation|
|owninguser|[systemuser EntityType](systemuser.md)|user_msevtmgt_hotelroomallocation|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msevtmgt_HotelRoomAllocation|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msevtmgt_hotelroomallocation_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msevtmgt_hotelroomallocation|  
|msevtmgt_hotelroomallocation_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msevtmgt_hotelroomallocation_adx_alertsubscription|  
|msevtmgt_hotelroomallocation_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msevtmgt_hotelroomallocation_adx_inviteredemption|  
|msevtmgt_hotelroomallocation_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msevtmgt_hotelroomallocation_adx_portalcomment|  
|msevtmgt_hotelroomallocation_Annotations|[annotation EntityType](annotation.md)|objectid_msevtmgt_hotelroomallocation|  
|msevtmgt_hotelroomallocation_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msevtmgt_hotelroomallocation_appointment|  
|msevtmgt_hotelroomallocation_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msevtmgt_hotelroomallocation|  
|msevtmgt_hotelroomallocation_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msevtmgt_hotelroomallocation|  
|msevtmgt_hotelroomallocation_Emails|[email EntityType](email.md)|regardingobjectid_msevtmgt_hotelroomallocation_email|  
|msevtmgt_hotelroomallocation_Faxes|[fax EntityType](fax.md)|regardingobjectid_msevtmgt_hotelroomallocation_fax|  
|msevtmgt_hotelroomallocation_Letters|[letter EntityType](letter.md)|regardingobjectid_msevtmgt_hotelroomallocation_letter|  
|msevtmgt_hotelroomallocation_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msevtmgt_hotelroomallocation_msdyn_approval|  
|msevtmgt_hotelroomallocation_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msevtmgt_hotelroomallocation_msdyn_bookingalert|  
|msevtmgt_hotelroomallocation_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msevtmgt_hotelroomallocation_msdyn_surveyinvite|  
|msevtmgt_hotelroomallocation_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msevtmgt_hotelroomallocation_phonecall|  
|msevtmgt_hotelroomallocation_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msevtmgt_hotelroomallocation_recurringappointmentmaster|  
|msevtmgt_hotelroomallocation_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msevtmgt_hotelroomallocation_serviceappointment|  
|msevtmgt_hotelroomallocation_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msevtmgt_hotelroomallocation_socialactivity|  
|msevtmgt_hotelroomallocation_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msevtmgt_hotelroomallocation|  
|msevtmgt_hotelroomallocation_Tasks|[task EntityType](task.md)|regardingobjectid_msevtmgt_hotelroomallocation_task|  
|msevtmgt_msevtmgt_hotelroomallocation_msevtmgt_hotelroomreservation_HotelRoomAllocation|[msevtmgt_hotelroomreservation EntityType](msevtmgt_hotelroomreservation.md)|msevtmgt_HotelRoomAllocation|  

## Operations
The following operations can be used with the msevtmgt_hotelroomallocation entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msevtmgt_hotelroomallocation entity type.


|Name|Description |  
|----|------------|  
|[Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicseventmanagementsolution.md](../solutions/descriptions/microsoftdynamicseventmanagementsolution.md)]|    

[!INCLUDE[./remarks/msevtmgt_hotelroomallocation.md](./remarks/msevtmgt_hotelroomallocation.md)]

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