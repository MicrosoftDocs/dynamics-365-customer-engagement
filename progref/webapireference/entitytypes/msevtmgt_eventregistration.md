---
title: "Microsoft Dynamics 365 Customer Engagement msevtmgt_eventregistration EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 9ca019ac-4769-4b23-b1ee-84bc0838e193
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msevtmgt_eventregistration entitytype."
---
# msevtmgt_eventregistration EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msevtmgt_eventregistration.md](./descriptions/msevtmgt_eventregistration.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msevtmgt_eventregistrations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Event Registration</td></tr>
<tr><td><b>Primary Key:</b></td><td>msevtmgt_eventregistrationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msevtmgt_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msevtmgt_eventregistration entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msevtmgt_area|Edm.Int32|**Display Name**: Area<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Administration</td></tr><tr><td>100000001</td><td>Customer Service</td></tr><tr><td>100000002</td><td>Executive/Management</td></tr><tr><td>100000003</td><td>Logistics</td></tr><tr><td>100000004</td><td>Finance</td></tr><tr><td>100000005</td><td>HR</td></tr><tr><td>100000006</td><td>IT</td></tr><tr><td>100000007</td><td>Legal</td></tr><tr><td>100000008</td><td>Marketing</td></tr><tr><td>100000009</td><td>Sales</td></tr><tbody></table>|
|msevtmgt_companysize|Edm.Int32|**Display Name**: Company Size<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>50 or less</td></tr><tr><td>100000001</td><td>51 to 100</td></tr><tr><td>100000002</td><td>101 to 250</td></tr><tr><td>100000003</td><td>251 to 500</td></tr><tr><td>100000004</td><td>501 to 1000</td></tr><tr><td>100000005</td><td>1001 to 2500</td></tr><tr><td>100000006</td><td>2501 to 5000</td></tr><tr><td>100000007</td><td>5001 to 10000</td></tr><tr><td>100000008</td><td>10001 or more</td></tr><tbody></table>|
|msevtmgt_eventregistrationid|Edm.Guid|**Display Name**: Event Registration<br />**Description**: Unique identifier for entity instances<br />|
|msevtmgt_industry|Edm.Int32|**Display Name**: Industry<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Architecture and Engineering</td></tr><tr><td>100000001</td><td>Financial Services</td></tr><tr><td>100000002</td><td>Manufacturing</td></tr><tr><td>100000003</td><td>Media, Entertainment</td></tr><tr><td>100000004</td><td>Professional Services</td></tr><tr><td>100000005</td><td>Public Sector</td></tr><tr><td>100000006</td><td>Retail</td></tr><tr><td>100000007</td><td>Wholesale and Distribution</td></tr><tr><td>100000008</td><td>Other</td></tr><tbody></table>|
|msevtmgt_memo|Edm.String|**Display Name**: Memo<br />|
|msevtmgt_name|Edm.String|**Display Name**: Registration ID<br />**Description**: The name of the custom entity.<br />|
|msevtmgt_primaryrole|Edm.Int32|**Display Name**: Primary Role<br />**Description**: Primary Role of the event attendee.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Attendee</td></tr><tr><td>100000001</td><td>Journalist</td></tr><tr><td>100000002</td><td>Other</td></tr><tbody></table>|
|msevtmgt_syncedwithprovider|Edm.Int32|**Display Name**: Synced with Provider<br />**Description**: A flag that indicates that the registration was synced with provider<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>No</td></tr><tr><td>100000002</td><td>Yes</td></tr><tbody></table>|
|msevtmgt_timescheckedin|Edm.Int32|**Display Name**: Times Checked-in<br />**Description**: Hidden field. Number of Event Check-ins related to this ER.
Used as partial aggregation for Check-in count of Event.
Increasing and decreasing done by corresponding workflows.<br />|
|msevtmgt_yearsinindustry|Edm.Int32|**Display Name**: Years in Industry<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Under 1 year</td></tr><tr><td>100000001</td><td>1 to 5 year</td></tr><tr><td>100000002</td><td>5 to 10 years</td></tr><tr><td>100000003</td><td>Over 10 years</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Event Registration<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Event Registration<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msevtmgt_contactid_value|msevtmgt_ContactId<br />||
|_msevtmgt_eventid_value|msevtmgt_EventId<br />|Unique identifier for Event associated with Event Registration.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_eventregistration_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_eventregistration_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_eventregistration_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_eventregistration_modifiedonbehalfby|
|msevtmgt_ContactId|[contact EntityType](contact.md)|msevtmgt_contact_msevtmgt_eventregistration_Contact|
|msevtmgt_EventId|[msevtmgt_event EntityType](msevtmgt_event.md)|msevtmgt_Event_EventRegistration|
|ownerid|[principal EntityType](principal.md)|owner_msevtmgt_eventregistration|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msevtmgt_eventregistration|
|owningteam|[team EntityType](team.md)|team_msevtmgt_eventregistration|
|owninguser|[systemuser EntityType](systemuser.md)|user_msevtmgt_eventregistration|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msevtmgt_eventregistration_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msevtmgt_eventregistration|  
|msevtmgt_eventregistration_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msevtmgt_eventregistration_adx_alertsubscription|  
|msevtmgt_eventregistration_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msevtmgt_eventregistration_adx_inviteredemption|  
|msevtmgt_eventregistration_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msevtmgt_eventregistration_adx_portalcomment|  
|msevtmgt_eventregistration_Annotations|[annotation EntityType](annotation.md)|objectid_msevtmgt_eventregistration|  
|msevtmgt_eventregistration_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msevtmgt_eventregistration_appointment|  
|msevtmgt_eventregistration_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msevtmgt_eventregistration|  
|msevtmgt_EventRegistration_AttendeePass|[msevtmgt_attendeepass EntityType](msevtmgt_attendeepass.md)|msevtmgt_EventRegistrationId|  
|msevtmgt_eventregistration_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msevtmgt_eventregistration|  
|msevtmgt_eventregistration_Emails|[email EntityType](email.md)|regardingobjectid_msevtmgt_eventregistration_email|  
|msevtmgt_eventregistration_Faxes|[fax EntityType](fax.md)|regardingobjectid_msevtmgt_eventregistration_fax|  
|msevtmgt_eventregistration_Letters|[letter EntityType](letter.md)|regardingobjectid_msevtmgt_eventregistration_letter|  
|msevtmgt_eventregistration_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msevtmgt_eventregistration_msdyn_approval|  
|msevtmgt_eventregistration_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msevtmgt_eventregistration_msdyn_bookingalert|  
|msevtmgt_eventregistration_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msevtmgt_eventregistration_msdyn_surveyinvite|  
|msevtmgt_eventregistration_msevtmgt_checkin_RegistrationId|[msevtmgt_checkin EntityType](msevtmgt_checkin.md)|msevtmgt_RegistrationId|  
|msevtmgt_eventregistration_msevtmgt_hotelroomreservation_Attendee|[msevtmgt_hotelroomreservation EntityType](msevtmgt_hotelroomreservation.md)|msevtmgt_Attendee|  
|msevtmgt_eventregistration_msevtmgt_session|[msevtmgt_session EntityType](msevtmgt_session.md)|msevtmgt_eventregistration_msevtmgt_session|  
|msevtmgt_eventregistration_msevtmgt_sessionregistration_RegistrationID|[msevtmgt_sessionregistration EntityType](msevtmgt_sessionregistration.md)|msevtmgt_RegistrationID|  
|msevtmgt_eventregistration_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msevtmgt_eventregistration_phonecall|  
|msevtmgt_eventregistration_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msevtmgt_eventregistration_recurringappointmentmaster|  
|msevtmgt_eventregistration_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msevtmgt_eventregistration_serviceappointment|  
|msevtmgt_eventregistration_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msevtmgt_eventregistration_socialactivity|  
|msevtmgt_eventregistration_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msevtmgt_eventregistration|  
|msevtmgt_eventregistration_Tasks|[task EntityType](task.md)|regardingobjectid_msevtmgt_eventregistration_task|  

## Operations
The following operations can be used with the msevtmgt_eventregistration entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msevtmgt_eventregistration entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Marketing Event Management Integration Solution Solution](../solutions/microsoftdynamicsmktevtmgmtlinksolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmktevtmgmtlinksolution.md](../solutions/descriptions/microsoftdynamicsmktevtmgmtlinksolution.md)]|  
|[Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicseventmanagementsolution.md](../solutions/descriptions/microsoftdynamicseventmanagementsolution.md)]|    

[!INCLUDE[./remarks/msevtmgt_eventregistration.md](./remarks/msevtmgt_eventregistration.md)]

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