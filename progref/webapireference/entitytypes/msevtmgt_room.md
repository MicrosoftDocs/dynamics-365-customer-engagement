---
title: "Microsoft Dynamics 365 Customer Engagement msevtmgt_room EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: e3a44ec9-15be-4c9d-93b8-3bbfbdb11725
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msevtmgt_room entitytype."
---
# msevtmgt_room EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msevtmgt_room.md](./descriptions/msevtmgt_room.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msevtmgt_rooms </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Room</td></tr>
<tr><td><b>Primary Key:</b></td><td>msevtmgt_roomid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msevtmgt_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msevtmgt_room entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msevtmgt_avsupport|Edm.Int32|**Display Name**: A/V support<br />**Description**: Does A/V support or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>No</td></tr><tr><td>100000002</td><td>Yes</td></tr><tbody></table>|
|msevtmgt_capacity|Edm.Int32|**Display Name**: Capacity<br />**Description**: Capacity<br />|
|msevtmgt_description|Edm.String|**Display Name**: Description<br />**Description**: Description of the room.<br />|
|msevtmgt_disabledaccess|Edm.Int32|**Display Name**: Disabled Access<br />**Description**: There is disabled access or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>No</td></tr><tr><td>100000002</td><td>Yes</td></tr><tbody></table>|
|msevtmgt_internetconnection|Edm.Int32|**Display Name**: Internet connection<br />**Description**: There is internet connection or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>No</td></tr><tr><td>100000002</td><td>Yes</td></tr><tbody></table>|
|msevtmgt_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msevtmgt_other|Edm.String|**Display Name**: Other<br />**Description**: Other<br />|
|msevtmgt_roomid|Edm.Guid|**Display Name**: Room<br />**Description**: Unique identifier for entity instances<br />|
|msevtmgt_videoconferencing|Edm.Int32|**Display Name**: Video conferencing<br />**Description**: There is video conferencing or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>No</td></tr><tr><td>100000002</td><td>Yes</td></tr><tbody></table>|
|msevtmgt_whiteboard|Edm.Int32|**Display Name**: Whiteboard<br />**Description**: There is whiteboard or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>No</td></tr><tr><td>100000002</td><td>Yes</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Room<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Room<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msevtmgt_building_value|msevtmgt_Building<br />|Link to building.|
|_msevtmgt_primarycontact_value|msevtmgt_PrimaryContact<br />|A person who is responsible for the room.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_room_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_room_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_room_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_room_modifiedonbehalfby|
|msevtmgt_Building|[msevtmgt_building EntityType](msevtmgt_building.md)|msevtmgt_building_msevtmgt_room_Building|
|msevtmgt_PrimaryContact|[contact EntityType](contact.md)|msevtmgt_contact_msevtmgt_room_PrimaryContact|
|ownerid|[principal EntityType](principal.md)|owner_msevtmgt_room|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msevtmgt_room|
|owningteam|[team EntityType](team.md)|team_msevtmgt_room|
|owninguser|[systemuser EntityType](systemuser.md)|user_msevtmgt_room|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msevtmgt_msevtmgt_room_msevtmgt_venue|[msevtmgt_venue EntityType](msevtmgt_venue.md)|msevtmgt_RoomId|  
|msevtmgt_room_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msevtmgt_room|  
|msevtmgt_room_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msevtmgt_room_adx_alertsubscription|  
|msevtmgt_room_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msevtmgt_room_adx_inviteredemption|  
|msevtmgt_room_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msevtmgt_room_adx_portalcomment|  
|msevtmgt_room_Annotations|[annotation EntityType](annotation.md)|objectid_msevtmgt_room|  
|msevtmgt_room_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msevtmgt_room_appointment|  
|msevtmgt_room_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msevtmgt_room|  
|msevtmgt_room_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msevtmgt_room|  
|msevtmgt_room_Emails|[email EntityType](email.md)|regardingobjectid_msevtmgt_room_email|  
|msevtmgt_room_Faxes|[fax EntityType](fax.md)|regardingobjectid_msevtmgt_room_fax|  
|msevtmgt_room_Letters|[letter EntityType](letter.md)|regardingobjectid_msevtmgt_room_letter|  
|msevtmgt_room_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msevtmgt_room_msdyn_approval|  
|msevtmgt_room_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msevtmgt_room_msdyn_bookingalert|  
|msevtmgt_room_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msevtmgt_room_msdyn_surveyinvite|  
|msevtmgt_room_msevtmgt_layout_Room|[msevtmgt_layout EntityType](msevtmgt_layout.md)|msevtmgt_Room|  
|msevtmgt_room_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msevtmgt_room_phonecall|  
|msevtmgt_room_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msevtmgt_room_recurringappointmentmaster|  
|msevtmgt_room_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msevtmgt_room_serviceappointment|  
|msevtmgt_room_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msevtmgt_room_socialactivity|  
|msevtmgt_room_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msevtmgt_room|  
|msevtmgt_room_Tasks|[task EntityType](task.md)|regardingobjectid_msevtmgt_room_task|  

## Operations
The following operations can be used with the msevtmgt_room entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msevtmgt_room entity type.


|Name|Description |  
|----|------------|  
|[Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicseventmanagementsolution.md](../solutions/descriptions/microsoftdynamicseventmanagementsolution.md)]|    

[!INCLUDE[./remarks/msevtmgt_room.md](./remarks/msevtmgt_room.md)]

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