---
title: "Microsoft Dynamics 365 Customer Engagement msevtmgt_eventpurchaseattendee EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 114487e5-363f-4cc8-a67c-81a152f3a9df
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msevtmgt_eventpurchaseattendee entitytype."
---
# msevtmgt_eventpurchaseattendee EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msevtmgt_eventpurchaseattendee.md](./descriptions/msevtmgt_eventpurchaseattendee.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msevtmgt_eventpurchaseattendees </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Event Purchase Attendee</td></tr>
<tr><td><b>Primary Key:</b></td><td>msevtmgt_eventpurchaseattendeeid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msevtmgt_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msevtmgt_eventpurchaseattendee entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msevtmgt_eventpurchaseattendeeid|Edm.Guid|**Display Name**: Event Purchase Attendee<br />**Description**: Unique identifier for entity instances<br />|
|msevtmgt_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Event Purchase Attendee<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Event Purchase Attendee<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msevtmgt_attendeecontactid_value|msevtmgt_AttendeeContactId<br />|The contact which is going to attend the event|
|_msevtmgt_eventregistrationid_value||Unique identifier for Event Registration associated with Event Purchase Attendee.|
|_msevtmgt_purchaseid_value|msevtmgt_PurchaseId<br />|Unique identifier for Event Purchase associated with Event Purchase Attendee.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_eventpurchaseattendee_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_eventpurchaseattendee_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_eventpurchaseattendee_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_eventpurchaseattendee_modifiedonbehalfby|
|msevtmgt_AttendeeContactId|[contact EntityType](contact.md)|msevtmgt_contact_msevtmgt_eventpurchaseattendee|
|msevtmgt_PurchaseId|[msevtmgt_eventpurchase EntityType](msevtmgt_eventpurchase.md)|msevtmgt_msevtmgt_eventpurchase_msevtmgt_eventpurc|
|ownerid|[principal EntityType](principal.md)|owner_msevtmgt_eventpurchaseattendee|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msevtmgt_eventpurchaseattendee|
|owningteam|[team EntityType](team.md)|team_msevtmgt_eventpurchaseattendee|
|owninguser|[systemuser EntityType](systemuser.md)|user_msevtmgt_eventpurchaseattendee|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msevtmgt_eventpurchaseattendee_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msevtmgt_eventpurchaseattendee|  
|msevtmgt_eventpurchaseattendee_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msevtmgt_eventpurchaseattendee_adx_alertsubscription|  
|msevtmgt_eventpurchaseattendee_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msevtmgt_eventpurchaseattendee_adx_inviteredemption|  
|msevtmgt_eventpurchaseattendee_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msevtmgt_eventpurchaseattendee_adx_portalcomment|  
|msevtmgt_eventpurchaseattendee_Annotations|[annotation EntityType](annotation.md)|objectid_msevtmgt_eventpurchaseattendee|  
|msevtmgt_eventpurchaseattendee_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msevtmgt_eventpurchaseattendee_appointment|  
|msevtmgt_eventpurchaseattendee_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msevtmgt_eventpurchaseattendee|  
|msevtmgt_eventpurchaseattendee_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msevtmgt_eventpurchaseattendee|  
|msevtmgt_eventpurchaseattendee_Emails|[email EntityType](email.md)|regardingobjectid_msevtmgt_eventpurchaseattendee_email|  
|msevtmgt_eventpurchaseattendee_Faxes|[fax EntityType](fax.md)|regardingobjectid_msevtmgt_eventpurchaseattendee_fax|  
|msevtmgt_eventpurchaseattendee_Letters|[letter EntityType](letter.md)|regardingobjectid_msevtmgt_eventpurchaseattendee_letter|  
|msevtmgt_eventpurchaseattendee_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msevtmgt_eventpurchaseattendee_msdyn_approval|  
|msevtmgt_eventpurchaseattendee_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msevtmgt_eventpurchaseattendee_msdyn_bookingalert|  
|msevtmgt_eventpurchaseattendee_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msevtmgt_eventpurchaseattendee_msdyn_surveyinvite|  
|msevtmgt_eventpurchaseattendee_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msevtmgt_eventpurchaseattendee_phonecall|  
|msevtmgt_eventpurchaseattendee_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msevtmgt_eventpurchaseattendee_recurringappointmentmaster|  
|msevtmgt_eventpurchaseattendee_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msevtmgt_eventpurchaseattendee_serviceappointment|  
|msevtmgt_eventpurchaseattendee_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msevtmgt_eventpurchaseattendee_socialactivity|  
|msevtmgt_eventpurchaseattendee_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msevtmgt_eventpurchaseattendee|  
|msevtmgt_eventpurchaseattendee_Tasks|[task EntityType](task.md)|regardingobjectid_msevtmgt_eventpurchaseattendee_task|  
|msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_e|[msevtmgt_eventpurchasepass EntityType](msevtmgt_eventpurchasepass.md)|msevtmgt_AttendeeId|  

## Operations
The following operations can be used with the msevtmgt_eventpurchaseattendee entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msevtmgt_eventpurchaseattendee entity type.


|Name|Description |  
|----|------------|  
|[Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicseventmanagementsolution.md](../solutions/descriptions/microsoftdynamicseventmanagementsolution.md)]|  
|[Event Portal Base Solution](../solutions/eventportallink.md)|[!INCLUDE[../solutions/descriptions/eventportallink.md](../solutions/descriptions/eventportallink.md)]|    

[!INCLUDE[./remarks/msevtmgt_eventpurchaseattendee.md](./remarks/msevtmgt_eventpurchaseattendee.md)]

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