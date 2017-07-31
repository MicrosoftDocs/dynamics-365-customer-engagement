---
title: "Microsoft Dynamics 365 Customer Engagement msevtmgt_session EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4c4aa09e-f28b-4c81-929b-2ea536856521
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msevtmgt_session entitytype."
---
# msevtmgt_session EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msevtmgt_session.md](./descriptions/msevtmgt_session.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msevtmgt_sessions </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Session</td></tr>
<tr><td><b>Primary Key:</b></td><td>msevtmgt_sessionid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msevtmgt_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msevtmgt_session entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msevtmgt_audiencetype|Edm.Int32|**Display Name**: Audience Type<br />**Description**: Audience Type of the Session.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>General</td></tr><tr><td>100000001</td><td>Introductory</td></tr><tr><td>100000002</td><td>Intermediate</td></tr><tr><td>100000003</td><td>Advanced</td></tr><tbody></table>|
|msevtmgt_avsupport|Edm.Int32|**Display Name**: A/V Support<br />**Description**: Audio/Video Support.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_byinvitationonly|Edm.Int32|**Display Name**: By invitation only<br />**Description**: Is access by invitation only.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_cameraspermitted|Edm.Int32|**Display Name**: Cameras permitted<br />**Description**: Are cameras permitted.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_checkincount|Edm.Int32|**Display Name**: Check-in count<br />**Description**: Check-in count<br />|
|msevtmgt_detaileddescription|Edm.String|**Display Name**: Detailed Description<br />**Description**: Detailed description of the Session.<br />|
|msevtmgt_durationmins|Edm.Int32|**Display Name**: Duration (mins)<br />**Description**: Duration of the Session in minutes.<br />Computed<br />Read-only<br />|
|msevtmgt_endtime|Edm.DateTimeOffset|**Display Name**: End Time<br />**Description**: End time of the Session.<br />|
|msevtmgt_externalurl|Edm.String|**Display Name**: Session Url<br />**Description**: External url for the Session.<br />|
|msevtmgt_flipchart|Edm.Int32|**Display Name**: Flip-Chart<br />**Description**: Is available flip-chart for the Session.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_industry|Edm.Int32|**Display Name**: Industry<br />**Description**: Industry of the Session.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Architecture and Engineering</td></tr><tr><td>100000001</td><td>Financial Services</td></tr><tr><td>100000002</td><td>Manufacturing</td></tr><tr><td>100000003</td><td>Media, Entertainment</td></tr><tr><td>100000004</td><td>Professional Services</td></tr><tr><td>100000005</td><td>Public Sector</td></tr><tr><td>100000006</td><td>Retail</td></tr><tr><td>100000007</td><td>Wholesale and Distribution</td></tr><tr><td>100000008</td><td>Other</td></tr><tbody></table>|
|msevtmgt_internetconnection|Edm.Int32|**Display Name**: Internet Connection<br />**Description**: Are internet connections available.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_keywords|Edm.String|**Display Name**: Keywords<br />**Description**: Comma-delimited keyword list for this session<br />|
|msevtmgt_language|Edm.Int32|**Display Name**: Language<br />**Description**: The language of the webinar<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>English</td></tr><tr><td>100000001</td><td>French</td></tr><tr><td>100000002</td><td>German</td></tr><tr><td>100000003</td><td>Spanish</td></tr><tr><td>100000004</td><td>Italian</td></tr><tr><td>100000005</td><td>Russian</td></tr><tr><td>100000006</td><td>Dutch</td></tr><tr><td>100000007</td><td>Turkish</td></tr><tr><td>100000008</td><td>Portuguese</td></tr><tr><td>100000009</td><td>Chinese (Simplified)</td></tr><tr><td>100000013</td><td>Chinese (Traditional)</td></tr><tr><td>100000010</td><td>Japanese</td></tr><tr><td>100000011</td><td>Korean</td></tr><tr><td>100000012</td><td>Hebrew</td></tr><tbody></table>|
|msevtmgt_name|Edm.String|**Display Name**: Session Title<br />**Description**: The name of the custom entity.<br />|
|msevtmgt_nda|Edm.Int32|**Display Name**: NDA<br />**Description**: Non Disclosure Agreement<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_presentationmanagerurl|Edm.String|**Display Name**: Presentation Manager URL<br />|
|msevtmgt_publishstatus|Edm.Int32|**Display Name**: Publish Status<br />**Description**: Publish status of the Session<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Draft</td></tr><tr><td>100000001</td><td>Ready to publish</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Published</td></tr><tbody></table>|
|msevtmgt_recordingspermitted|Edm.Int32|**Display Name**: Recordings permitted<br />**Description**: Are recordings permitted.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_registrationcount|Edm.Int32|**Display Name**: Registration count<br />**Description**: Registration count of the Session.<br />|
|msevtmgt_sessioncode|Edm.String|**Display Name**: Session Code<br />**Description**: Code of the Session.<br />|
|msevtmgt_sessionformat|Edm.Int32|**Display Name**: Session Format<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>On Site</td></tr><tr><td>100000002</td><td>Webinar</td></tr><tr><td>100000003</td><td>Hybrid</td></tr><tbody></table>|
|msevtmgt_sessionid|Edm.Guid|**Display Name**: Session<br />**Description**: Unique identifier for entity instances<br />|
|msevtmgt_sessionmaxcapacity|Edm.Int32|**Display Name**: Session max. capacity<br />**Description**: Maximum capacity of the Session.<br />|
|msevtmgt_sessionobjectives|Edm.String|**Display Name**: Session Objectives<br />**Description**: Objectives of the Session.<br />|
|msevtmgt_sessionprerequisites|Edm.String|**Display Name**: Session Pre-Requisites<br />**Description**: Pre-Requisites of the Session.<br />|
|msevtmgt_sessionsummary|Edm.String|**Display Name**: Session Summary<br />**Description**: Summary of the Session.<br />|
|msevtmgt_sessiontype|Edm.Int32|**Display Name**: Session Type<br />**Description**: Type of the Session.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Lab</td></tr><tr><td>100000001</td><td>Keynote</td></tr><tr><td>100000002</td><td>General</td></tr><tr><td>100000003</td><td>Interactive</td></tr><tbody></table>|
|msevtmgt_starttime|Edm.DateTimeOffset|**Display Name**: Start Time<br />**Description**: Start time of the Session.<br />|
|msevtmgt_totalnumberofquestionsasked|Edm.Int32|**Display Name**: Total number of questions asked<br />**Description**: Total numbers of questions asked on the Session.<br />Computed<br />Read-only<br />|
|msevtmgt_totalnumberofquestionsasked_date|Edm.DateTimeOffset|**Display Name**: Total number of questions asked (Last Updated On)<br />**Description**: Last Updated time of rollup field Total number of questions asked.<br />Read-only<br />|
|msevtmgt_totalnumberofquestionsasked_state|Edm.Int32|**Display Name**: Total number of questions asked (State)<br />**Description**: State of rollup field Total number of questions asked.<br />Read-only<br />|
|msevtmgt_videoconferencing|Edm.Int32|**Display Name**: Video Conferencing<br />**Description**: Is available video conferencing for the Session.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_webinarid|Edm.String|**Display Name**: Webinar ID<br />**Description**: Webinar ID of the Session.<br />|
|msevtmgt_webinarurl|Edm.String|**Display Name**: Webinar URL<br />|
|msevtmgt_whiteboard|Edm.Int32|**Display Name**: Whiteboard<br />**Description**: Is available white board for the Session.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Session<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status<br />**Description**: Reason for the status of the Session<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msevtmgt_event_value|msevtmgt_Event<br />|Unique identifier for Event associated with Event Session.|
|_msevtmgt_eventspeakerid_value||Unique identifier for Speaker associated with Session.|
|_msevtmgt_passsessions_value|msevtmgt_passsessions<br />|Unique identifier for Product associated with Session.|
|_msevtmgt_producer_value|msevtmgt_Producer<br />|Producer of the session|
|_msevtmgt_venue_value|msevtmgt_Venue<br />|Active Venue records for this Session.|
|_msevtmgt_webinarconfigurationid_value|msevtmgt_WebinarConfigurationId<br />|Webinar Configuration|
|_msevtmgt_webinartype_value|msevtmgt_WebinarType<br />||
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_session_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_session_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_session_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_session_modifiedonbehalfby|
|msevtmgt_Event|[msevtmgt_event EntityType](msevtmgt_event.md)|msevtmgt_event_msevtmgt_session_Event|
|msevtmgt_passsessions|[msevtmgt_pass EntityType](msevtmgt_pass.md)|msevtmgt_pass_msevtmgt_session_PassSessions|
|msevtmgt_Producer|[msevtmgt_eventteammember EntityType](msevtmgt_eventteammember.md)|msevtmgt_EventTeamMember_msevtmgt_Session_Producer|
|msevtmgt_Venue|[msevtmgt_venue EntityType](msevtmgt_venue.md)|msevtmgt_Venue_msevtmgt_Session_Venue|
|msevtmgt_WebinarConfigurationId|[msevtmgt_webinarconfiguration EntityType](msevtmgt_webinarconfiguration.md)|msevtmgt_webinarconfiguration_msevtmgt_session_Web|
|msevtmgt_WebinarType|[msevtmgt_webinartype EntityType](msevtmgt_webinartype.md)|msevtmgt_msevtmgt_webinartype_msevtmgt_session_WebinarType|
|ownerid|[principal EntityType](principal.md)|owner_msevtmgt_session|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msevtmgt_session|
|owningteam|[team EntityType](team.md)|team_msevtmgt_session|
|owninguser|[systemuser EntityType](systemuser.md)|user_msevtmgt_session|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msevtmgt_eventregistration_msevtmgt_session|[msevtmgt_eventregistration EntityType](msevtmgt_eventregistration.md)|msevtmgt_eventregistration_msevtmgt_session|  
|msevtmgt_msevtmgt_session_msevtmgt_speakerengagement_Session|[msevtmgt_speakerengagement EntityType](msevtmgt_speakerengagement.md)|msevtmgt_Session|  
|msevtmgt_session_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msevtmgt_session|  
|msevtmgt_session_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msevtmgt_session_adx_alertsubscription|  
|msevtmgt_session_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msevtmgt_session_adx_inviteredemption|  
|msevtmgt_session_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msevtmgt_session_adx_portalcomment|  
|msevtmgt_session_Annotations|[annotation EntityType](annotation.md)|objectid_msevtmgt_session|  
|msevtmgt_session_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msevtmgt_session_appointment|  
|msevtmgt_session_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msevtmgt_session|  
|msevtmgt_session_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msevtmgt_session|  
|msevtmgt_session_Emails|[email EntityType](email.md)|regardingobjectid_msevtmgt_session_email|  
|msevtmgt_session_Faxes|[fax EntityType](fax.md)|regardingobjectid_msevtmgt_session_fax|  
|msevtmgt_session_Letters|[letter EntityType](letter.md)|regardingobjectid_msevtmgt_session_letter|  
|msevtmgt_session_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msevtmgt_session_msdyn_approval|  
|msevtmgt_session_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msevtmgt_session_msdyn_bookingalert|  
|msevtmgt_session_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msevtmgt_session_msdyn_surveyinvite|  
|msevtmgt_session_msevtmgt_attendeepass|[msevtmgt_attendeepass EntityType](msevtmgt_attendeepass.md)|msevtmgt_session_msevtmgt_attendeepass|  
|msevtmgt_session_msevtmgt_checkin_SessionAttended|[msevtmgt_checkin EntityType](msevtmgt_checkin.md)|msevtmgt_SessionAttended|  
|msevtmgt_session_msevtmgt_pass|[msevtmgt_pass EntityType](msevtmgt_pass.md)|msevtmgt_session_msevtmgt_pass|  
|msevtmgt_session_msevtmgt_session|[msevtmgt_session EntityType](msevtmgt_session.md)|msevtmgt_session_msevtmgt_session_referenced|  
|msevtmgt_session_msevtmgt_session_referenced|[msevtmgt_session EntityType](msevtmgt_session.md)|msevtmgt_session_msevtmgt_session|  
|msevtmgt_session_msevtmgt_sessionregistration|[msevtmgt_sessionregistration EntityType](msevtmgt_sessionregistration.md)|msevtmgt_SessionId|  
|msevtmgt_session_msevtmgt_speaker|[msevtmgt_speaker EntityType](msevtmgt_speaker.md)|msevtmgt_session_msevtmgt_speaker|  
|msevtmgt_session_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msevtmgt_session_phonecall|  
|msevtmgt_session_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msevtmgt_session_recurringappointmentmaster|  
|msevtmgt_session_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msevtmgt_session_serviceappointment|  
|msevtmgt_session_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msevtmgt_session_socialactivity|  
|msevtmgt_session_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msevtmgt_session|  
|msevtmgt_session_Tasks|[task EntityType](task.md)|regardingobjectid_msevtmgt_session_task|  
|msevtmgt_sessiontrack_msevtmgt_session|[msevtmgt_sessiontrack EntityType](msevtmgt_sessiontrack.md)|msevtmgt_sessiontrack_msevtmgt_session|  

## Operations
The following operations can be used with the msevtmgt_session entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msevtmgt_session entity type.


|Name|Description |  
|----|------------|  
|[Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicseventmanagementsolution.md](../solutions/descriptions/microsoftdynamicseventmanagementsolution.md)]|  
|[Event Portal Base Solution](../solutions/eventportallink.md)|[!INCLUDE[../solutions/descriptions/eventportallink.md](../solutions/descriptions/eventportallink.md)]|    

[!INCLUDE[./remarks/msevtmgt_session.md](./remarks/msevtmgt_session.md)]

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