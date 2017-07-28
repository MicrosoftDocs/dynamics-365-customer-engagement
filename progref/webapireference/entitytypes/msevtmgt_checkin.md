---
title: "Microsoft Dynamics 365 Customer Engagement msevtmgt_checkin EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b14ca5d1-1e42-4a20-b3d4-07c4f9cc2186
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msevtmgt_checkin entitytype."
---
# msevtmgt_checkin EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msevtmgt_checkin.md](./descriptions/msevtmgt_checkin.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msevtmgt_checkins </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Check-in</td></tr>
<tr><td><b>Primary Key:</b></td><td>msevtmgt_checkinid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msevtmgt_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msevtmgt_checkin entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Check-in-time<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msevtmgt_audiencetype|Edm.Int32|**Display Name**: Audience Type<br />**Description**: Audience type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>General</td></tr><tr><td>100000001</td><td>Introductory</td></tr><tr><td>100000002</td><td>Intermediate</td></tr><tr><td>100000003</td><td>Advanced</td></tr><tbody></table>|
|msevtmgt_checkinid|Edm.Guid|**Display Name**: Check-in<br />**Description**: Unique identifier for entity instances<br />|
|msevtmgt_checkintime|Edm.DateTimeOffset|**Display Name**: Check-in time<br />**Description**: Check-in time.<br />|
|msevtmgt_checkintype|Edm.Int32|**Display Name**: Check-in Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Session Check-in</td></tr><tr><td>100000001</td><td>Event Check-in</td></tr><tbody></table>|
|msevtmgt_checkouttime|Edm.DateTimeOffset|**Display Name**: Check-out time<br />**Description**: Check-out time.<br />|
|msevtmgt_name|Edm.String|**Display Name**: Name<br />**Description**: Check-in records are used to log the attendance of an attendee at particular event or session.<br />|
|msevtmgt_numberofquestionsasked|Edm.Int32|**Display Name**: Number of interactions<br />|
|msevtmgt_sessioncode|Edm.String|**Display Name**: Session Code<br />|
|msevtmgt_sessiontype|Edm.Int32|**Display Name**: Session Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Lab</td></tr><tr><td>100000001</td><td>Keynote</td></tr><tr><td>100000002</td><td>General</td></tr><tr><td>100000003</td><td>Interactive</td></tr><tbody></table>|
|msevtmgt_viewingdurationinmins|Edm.Int32|**Display Name**: Viewing Duration in mins<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Check-in<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Check-in<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msevtmgt_contact_value|msevtmgt_Contact<br />|Contact records of the Check-in.|
|_msevtmgt_event_value|msevtmgt_Event<br />|Unique identifier for Event associated with Check-in.|
|_msevtmgt_purchasedpassesid_value|msevtmgt_PurchasedPassesId<br />|Unique identifier for Attendee Pass associated with Check-in.|
|_msevtmgt_registrationid_value|msevtmgt_RegistrationId<br />||
|_msevtmgt_sessionattended_value|msevtmgt_SessionAttended<br />|Session records of the Check-in.|
|_msevtmgt_sessionregistration_value|msevtmgt_SessionRegistration<br />|All Active Session Registration Records for this Check-in.|
|_msevtmgt_transactioncurrencyid_value||Unique identifier of the currency associated with the entity.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_checkin_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_checkin_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_checkin_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_checkin_modifiedonbehalfby|
|msevtmgt_Contact|[contact EntityType](contact.md)|msevtmgt_contact_msevtmgt_checkin_Contact|
|msevtmgt_Event|[msevtmgt_event EntityType](msevtmgt_event.md)|msevtmgt_event_msevtmgt_checkin_Event|
|msevtmgt_PurchasedPassesId|[msevtmgt_attendeepass EntityType](msevtmgt_attendeepass.md)|msevtmgt_attendeepass_msevtmgt_checkin|
|msevtmgt_RegistrationId|[msevtmgt_eventregistration EntityType](msevtmgt_eventregistration.md)|msevtmgt_eventregistration_msevtmgt_checkin_RegistrationId|
|msevtmgt_SessionAttended|[msevtmgt_session EntityType](msevtmgt_session.md)|msevtmgt_session_msevtmgt_checkin_SessionAttended|
|msevtmgt_SessionRegistration|[msevtmgt_sessionregistration EntityType](msevtmgt_sessionregistration.md)|msevtmgt_SessionRegistration_msevtmgt_CheckIn_SessionRegistration|
|ownerid|[principal EntityType](principal.md)|owner_msevtmgt_checkin|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msevtmgt_checkin|
|owningteam|[team EntityType](team.md)|team_msevtmgt_checkin|
|owninguser|[systemuser EntityType](systemuser.md)|user_msevtmgt_checkin|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msevtmgt_checkin_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msevtmgt_checkin|  
|msevtmgt_checkin_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msevtmgt_checkin_adx_alertsubscription|  
|msevtmgt_checkin_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msevtmgt_checkin_adx_inviteredemption|  
|msevtmgt_checkin_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msevtmgt_checkin_adx_portalcomment|  
|msevtmgt_checkin_Annotations|[annotation EntityType](annotation.md)|objectid_msevtmgt_checkin|  
|msevtmgt_checkin_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msevtmgt_checkin_appointment|  
|msevtmgt_checkin_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msevtmgt_checkin|  
|msevtmgt_checkin_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msevtmgt_checkin|  
|msevtmgt_checkin_contact|[contact EntityType](contact.md)|msevtmgt_ContactId|  
|msevtmgt_checkin_Emails|[email EntityType](email.md)|regardingobjectid_msevtmgt_checkin_email|  
|msevtmgt_checkin_Faxes|[fax EntityType](fax.md)|regardingobjectid_msevtmgt_checkin_fax|  
|msevtmgt_checkin_Letters|[letter EntityType](letter.md)|regardingobjectid_msevtmgt_checkin_letter|  
|msevtmgt_checkin_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msevtmgt_checkin_msdyn_approval|  
|msevtmgt_checkin_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msevtmgt_checkin_msdyn_bookingalert|  
|msevtmgt_checkin_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msevtmgt_checkin_msdyn_surveyinvite|  
|msevtmgt_checkin_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msevtmgt_checkin_phonecall|  
|msevtmgt_checkin_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msevtmgt_checkin_recurringappointmentmaster|  
|msevtmgt_checkin_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msevtmgt_checkin_serviceappointment|  
|msevtmgt_checkin_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msevtmgt_checkin_socialactivity|  
|msevtmgt_checkin_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msevtmgt_checkin|  
|msevtmgt_checkin_Tasks|[task EntityType](task.md)|regardingobjectid_msevtmgt_checkin_task|  

## Operations
The following operations can be used with the msevtmgt_checkin entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msevtmgt_checkin entity type.


|Name|Description |  
|----|------------|  
|[Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicseventmanagementsolution.md](../solutions/descriptions/microsoftdynamicseventmanagementsolution.md)]|    

[!INCLUDE[./remarks/msevtmgt_checkin.md](./remarks/msevtmgt_checkin.md)]

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