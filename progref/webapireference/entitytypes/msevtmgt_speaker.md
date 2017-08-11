---
title: "Microsoft Dynamics 365 Customer Engagement msevtmgt_speaker EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 9efb9f39-5ac8-4dee-b8a5-62584301a720
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msevtmgt_speaker entitytype."
---
# msevtmgt_speaker EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msevtmgt_speaker.md](./descriptions/msevtmgt_speaker.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msevtmgt_speakers </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Speaker</td></tr>
<tr><td><b>Primary Key:</b></td><td>msevtmgt_speakerid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msevtmgt_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msevtmgt_speaker entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|entityimage|Edm.Binary|**Display Name**: Image<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msevtmgt_about|Edm.String|**Display Name**: About<br />**Description**: About<br />|
|msevtmgt_accomplishments|Edm.String|**Display Name**: Accomplishments<br />**Description**: Accomplishments<br />|
|msevtmgt_blog|Edm.String|**Display Name**: Blog<br />**Description**: Blog<br />|
|msevtmgt_email|Edm.String|**Display Name**: Email<br />**Description**: Speaker Email.<br />|
|msevtmgt_linkedin|Edm.String|**Display Name**: LinkedIn<br />**Description**: LinkedIn<br />|
|msevtmgt_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msevtmgt_publications|Edm.String|**Display Name**: Publications<br />**Description**: Publications<br />|
|msevtmgt_speakercost|Edm.Decimal|**Display Name**: Speaker Cost<br />**Description**: Value of the Speaker Cost.<br />|
|msevtmgt_speakercost_base|Edm.Decimal|**Display Name**: Speaker Cost (Base)<br />**Description**: Value of the Speaker Cost in base currency.<br />Read-only<br />|
|msevtmgt_speakerid|Edm.Guid|**Display Name**: Speaker<br />**Description**: Unique identifier for entity instances<br />|
|msevtmgt_title|Edm.String|**Display Name**: Title<br />**Description**: Title<br />|
|msevtmgt_twitter|Edm.String|**Display Name**: Twitter<br />**Description**: Twitter<br />|
|msevtmgt_type|Edm.Int32|**Display Name**: Type<br />**Description**: Speaker Type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Internal Speaker</td></tr><tr><td>100000001</td><td>External Speaker</td></tr><tbody></table>|
|msevtmgt_website|Edm.String|**Display Name**: Website<br />**Description**: Website URL<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Event Speaker<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Event Speaker<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
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
|_msevtmgt_contact_value|msevtmgt_Contact<br />|Lookup field for Contact|
|_msevtmgt_eventid_value|msevtmgt_EventId<br />|Unique identifier for Event associated with Speaker.|
|_msevtmgt_eventregistration_value||Lookup from Event Registration|
|_msevtmgt_transactioncurrencyid_value||Unique identifier of the currency associated with the entity.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_stageid_value|stageid<br />|Contains the id of the stage where the entity is located.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_speaker_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_speaker_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_speaker_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_speaker_modifiedonbehalfby|
|msevtmgt_Contact|[contact EntityType](contact.md)|msevtmgt_contact_msevtmgt_speaker_Contact|
|msevtmgt_EventId|[msevtmgt_event EntityType](msevtmgt_event.md)|msevtmgt_Event_Speaker|
|ownerid|[principal EntityType](principal.md)|owner_msevtmgt_speaker|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msevtmgt_speaker|
|owningteam|[team EntityType](team.md)|team_msevtmgt_speaker|
|owninguser|[systemuser EntityType](systemuser.md)|user_msevtmgt_speaker|
|stageid|[processstage EntityType](processstage.md)|processstage_msevtmgt_Speaker|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msevtmgt_Speaker|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msevtmgt_msevtmgt_speaker_msevtmgt_speakerengagement_Speaker|[msevtmgt_speakerengagement EntityType](msevtmgt_speakerengagement.md)|msevtmgt_Speaker|  
|msevtmgt_session_msevtmgt_speaker|[msevtmgt_session EntityType](msevtmgt_session.md)|msevtmgt_session_msevtmgt_speaker|  
|msevtmgt_speaker_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msevtmgt_speaker|  
|msevtmgt_speaker_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msevtmgt_speaker_adx_alertsubscription|  
|msevtmgt_speaker_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msevtmgt_speaker_adx_inviteredemption|  
|msevtmgt_speaker_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msevtmgt_speaker_adx_portalcomment|  
|msevtmgt_speaker_Annotations|[annotation EntityType](annotation.md)|objectid_msevtmgt_speaker|  
|msevtmgt_speaker_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msevtmgt_speaker_appointment|  
|msevtmgt_speaker_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msevtmgt_speaker|  
|msevtmgt_speaker_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msevtmgt_speaker|  
|msevtmgt_speaker_Emails|[email EntityType](email.md)|regardingobjectid_msevtmgt_speaker_email|  
|msevtmgt_speaker_Faxes|[fax EntityType](fax.md)|regardingobjectid_msevtmgt_speaker_fax|  
|msevtmgt_speaker_Letters|[letter EntityType](letter.md)|regardingobjectid_msevtmgt_speaker_letter|  
|msevtmgt_speaker_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msevtmgt_speaker_msdyn_approval|  
|msevtmgt_speaker_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msevtmgt_speaker_msdyn_bookingalert|  
|msevtmgt_speaker_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msevtmgt_speaker_msdyn_surveyinvite|  
|msevtmgt_speaker_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msevtmgt_speaker_phonecall|  
|msevtmgt_speaker_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msevtmgt_speaker_recurringappointmentmaster|  
|msevtmgt_speaker_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msevtmgt_speaker_serviceappointment|  
|msevtmgt_speaker_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msevtmgt_speaker_socialactivity|  
|msevtmgt_speaker_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msevtmgt_speaker|  
|msevtmgt_speaker_Tasks|[task EntityType](task.md)|regardingobjectid_msevtmgt_speaker_task|  

## Operations
The following operations can be used with the msevtmgt_speaker entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msevtmgt_speaker entity type.


|Name|Description |  
|----|------------|  
|[Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicseventmanagementsolution.md](../solutions/descriptions/microsoftdynamicseventmanagementsolution.md)]|  
|[Event Portal Base Solution](../solutions/eventportallink.md)|[!INCLUDE[../solutions/descriptions/eventportallink.md](../solutions/descriptions/eventportallink.md)]|    

[!INCLUDE[./remarks/msevtmgt_speaker.md](./remarks/msevtmgt_speaker.md)]

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