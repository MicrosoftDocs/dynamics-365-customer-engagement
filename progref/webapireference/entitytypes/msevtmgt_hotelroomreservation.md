---
title: "Microsoft Dynamics 365 Customer Engagement msevtmgt_hotelroomreservation EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a824b616-70c8-448c-b425-9ab9e82a75da
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msevtmgt_hotelroomreservation entitytype."
---
# msevtmgt_hotelroomreservation EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msevtmgt_hotelroomreservation.md](./descriptions/msevtmgt_hotelroomreservation.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msevtmgt_hotelroomreservations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Hotel Room Reservation</td></tr>
<tr><td><b>Primary Key:</b></td><td>msevtmgt_hotelroomreservationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msevtmgt_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msevtmgt_hotelroomreservation entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msevtmgt_hotelroomreservationid|Edm.Guid|**Display Name**: Hotel Room Reservation<br />**Description**: Unique identifier for entity instances<br />|
|msevtmgt_name|Edm.String|**Display Name**: Reservation Number<br />**Description**: The Reservation Number.<br />|
|msevtmgt_rewardsprogramnumber|Edm.String|**Display Name**: Rewards Program Number<br />**Description**: Room reservation rewards program number<br />|
|msevtmgt_specialrequests|Edm.String|**Display Name**: Special Requests<br />**Description**: Room reservation special requests<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Hotel Room Reservation<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Hotel Room Reservation<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msevtmgt_attendee_value|msevtmgt_Attendee<br />|Room reservation attendee|
|_msevtmgt_hotelroomallocation_value|msevtmgt_HotelRoomAllocation<br />||
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_hotelroomreservation_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_hotelroomreservation_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_hotelroomreservation_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_hotelroomreservation_modifiedonbehalfby|
|msevtmgt_Attendee|[msevtmgt_eventregistration EntityType](msevtmgt_eventregistration.md)|msevtmgt_eventregistration_msevtmgt_hotelroomreservation_Attendee|
|msevtmgt_HotelRoomAllocation|[msevtmgt_hotelroomallocation EntityType](msevtmgt_hotelroomallocation.md)|msevtmgt_msevtmgt_hotelroomallocation_msevtmgt_hotelroomreservation_HotelRoomAllocation|
|ownerid|[principal EntityType](principal.md)|owner_msevtmgt_hotelroomreservation|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msevtmgt_hotelroomreservation|
|owningteam|[team EntityType](team.md)|team_msevtmgt_hotelroomreservation|
|owninguser|[systemuser EntityType](systemuser.md)|user_msevtmgt_hotelroomreservation|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msevtmgt_hotelroomreservation_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msevtmgt_hotelroomreservation|  
|msevtmgt_hotelroomreservation_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msevtmgt_hotelroomreservation_adx_alertsubscription|  
|msevtmgt_hotelroomreservation_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msevtmgt_hotelroomreservation_adx_inviteredemption|  
|msevtmgt_hotelroomreservation_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msevtmgt_hotelroomreservation_adx_portalcomment|  
|msevtmgt_hotelroomreservation_Annotations|[annotation EntityType](annotation.md)|objectid_msevtmgt_hotelroomreservation|  
|msevtmgt_hotelroomreservation_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msevtmgt_hotelroomreservation_appointment|  
|msevtmgt_hotelroomreservation_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msevtmgt_hotelroomreservation|  
|msevtmgt_hotelroomreservation_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msevtmgt_hotelroomreservation|  
|msevtmgt_hotelroomreservation_Emails|[email EntityType](email.md)|regardingobjectid_msevtmgt_hotelroomreservation_email|  
|msevtmgt_hotelroomreservation_Faxes|[fax EntityType](fax.md)|regardingobjectid_msevtmgt_hotelroomreservation_fax|  
|msevtmgt_hotelroomreservation_Letters|[letter EntityType](letter.md)|regardingobjectid_msevtmgt_hotelroomreservation_letter|  
|msevtmgt_hotelroomreservation_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msevtmgt_hotelroomreservation_msdyn_approval|  
|msevtmgt_hotelroomreservation_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msevtmgt_hotelroomreservation_msdyn_bookingalert|  
|msevtmgt_hotelroomreservation_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msevtmgt_hotelroomreservation_msdyn_surveyinvite|  
|msevtmgt_hotelroomreservation_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msevtmgt_hotelroomreservation_phonecall|  
|msevtmgt_hotelroomreservation_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msevtmgt_hotelroomreservation_recurringappointmentmaster|  
|msevtmgt_hotelroomreservation_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msevtmgt_hotelroomreservation_serviceappointment|  
|msevtmgt_hotelroomreservation_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msevtmgt_hotelroomreservation_socialactivity|  
|msevtmgt_hotelroomreservation_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msevtmgt_hotelroomreservation|  
|msevtmgt_hotelroomreservation_Tasks|[task EntityType](task.md)|regardingobjectid_msevtmgt_hotelroomreservation_task|  

## Operations
The following operations can be used with the msevtmgt_hotelroomreservation entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msevtmgt_hotelroomreservation entity type.


|Name|Description |  
|----|------------|  
|[Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicseventmanagementsolution.md](../solutions/descriptions/microsoftdynamicseventmanagementsolution.md)]|    

[!INCLUDE[./remarks/msevtmgt_hotelroomreservation.md](./remarks/msevtmgt_hotelroomreservation.md)]

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