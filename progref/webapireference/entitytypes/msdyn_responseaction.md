---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_responseaction EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d035aaf6-8e2b-4957-b69c-ab90316601fb
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_responseaction entitytype."
---
# msdyn_responseaction EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_responseaction.md](./descriptions/msdyn_responseaction.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_responseactions </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Response Action</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_responseactionid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_responseaction entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|emailaddress|Edm.String|**Display Name**: Email Address<br />**Description**: The primary email address for the entity.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_action|Edm.Int32|**Display Name**: Action<br />**Description**: Select the actions that can occur when the respondent enters a response.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Show</td></tr><tr><td>986540001</td><td>Hide</td></tr><tr><td>986540002</td><td>Skip to</td></tr><tr><td>986540003</td><td>End survey</td></tr><tr><td>986540004</td><td>Chain survey</td></tr><tr><td>986540005</td><td>Toggle visibility</td></tr><tbody></table>|
|msdyn_chainsurveyuniqueidentifier|Edm.String|**Display Name**: Chain Survey Uniqueidentifier<br />**Description**: Shows chain destination survey<br />|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Type a description for the response action.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_orderindex|Edm.Int32|**Display Name**: Order Index<br />**Description**: Set the order of precedence for the response action.<br />|
|msdyn_responseactionid|Edm.Guid|**Display Name**: Response Outcome Rule<br />**Description**: Shows the entity instances.<br />|
|msdyn_responseoutcometype|Edm.Int32|**Display Name**: Response Outcome Type<br />**Description**: Select the type of response outcome.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Complaint</td></tr><tr><td>986540001</td><td>Low score</td></tr><tr><td>986540002</td><td>Distress</td></tr><tr><td>986540003</td><td>Unsubscribe</td></tr><tr><td>986540004</td><td>High Score</td></tr><tr><td>986540005</td><td>Contact request</td></tr><tr><td>986540006</td><td>Follow up</td></tr><tr><td>986540007</td><td>NPS Increase</td></tr><tr><td>986540008</td><td>NPS Decrease</td></tr><tr><td>986540009</td><td>Facial Expression Increase</td></tr><tr><td>986540010</td><td>Facial Expression Decrease</td></tr><tbody></table>|
|msdyn_scope|Edm.Int32|**Display Name**: Scope<br />**Description**: Select the client or server response action.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Client</td></tr><tr><td>192350001</td><td>Server</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Response Action<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Response Action<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_chaindestinationsurvey_value|msdyn_ChainDestinationSurvey<br />|Enter the chain destination survey.|
|_msdyn_grid_value|msdyn_Grid<br />|Enter the grid.|
|_msdyn_page_value|msdyn_Page<br />|Enter the page.|
|_msdyn_question_value|msdyn_Question<br />|Enter the question.|
|_msdyn_queuetonotify_value|msdyn_Queuetonotify<br />|Shows the queue associated with the response outcome rule.|
|_msdyn_section_value|msdyn_Section<br />|Enter the section.|
|_msdyn_senderuser_value|msdyn_SenderUser<br />|Shows User associated with Response Outcome Rule.|
|_msdyn_survey_value|msdyn_Survey<br />|Enter the survey.|
|_msdyn_teamtonotify_value|msdyn_Teamtonotify<br />|Shows the team associated with the response outcome rule.|
|_msdyn_usertonotify_value|msdyn_Usertonotify<br />|Shows the user associated with the response outcome rule.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_responseaction_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_responseaction_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_responseaction_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_responseaction_modifiedonbehalfby|
|msdyn_ChainDestinationSurvey|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_msdyn_survey_msdyn_responseaction_ChainDestinationSurvey|
|msdyn_Grid|[msdyn_questiongroup EntityType](msdyn_questiongroup.md)|msdyn_questiongroup_msdyn_responseaction_Grid|
|msdyn_Page|[msdyn_page EntityType](msdyn_page.md)|msdyn_page_msdyn_responseaction_Page|
|msdyn_Question|[msdyn_question EntityType](msdyn_question.md)|msdyn_msdyn_question_msdyn_responseaction_Question|
|msdyn_Queuetonotify|[queue EntityType](queue.md)|msdyn_queue_msdyn_responseaction_Queuetonotify|
|msdyn_Section|[msdyn_section EntityType](msdyn_section.md)|msdyn_section_msdyn_responseaction_Section|
|msdyn_SenderUser|[systemuser EntityType](systemuser.md)|msdyn_systemuser_msdyn_responseaction_SenderUser|
|msdyn_Survey|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_msdyn_responseaction_Survey|
|msdyn_Teamtonotify|[team EntityType](team.md)|msdyn_team_msdyn_responseaction_Teamtonotify|
|msdyn_Usertonotify|[systemuser EntityType](systemuser.md)|msdyn_systemuser_msdyn_responseaction_Usertonotify|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_responseaction|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_responseaction|
|owningteam|[team EntityType](team.md)|team_msdyn_responseaction|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_responseaction|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_responseaction_msdyn_responseoutcome_TriggeringResponseActionRule|[msdyn_responseoutcome EntityType](msdyn_responseoutcome.md)|msdyn_TriggeringResponseActionRule|  
|msdyn_responseaction_ActivityParties|[activityparty EntityType](activityparty.md)|partyid_msdyn_responseaction|  
|msdyn_responseaction_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_responseaction|  
|msdyn_responseaction_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_responseaction_adx_alertsubscription|  
|msdyn_responseaction_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_responseaction_adx_inviteredemption|  
|msdyn_responseaction_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_responseaction_adx_portalcomment|  
|msdyn_responseaction_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_responseaction|  
|msdyn_responseaction_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_responseaction_appointment|  
|msdyn_responseaction_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_responseaction|  
|msdyn_responseaction_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_responseaction|  
|msdyn_responseaction_connections1|[connection EntityType](connection.md)|record1id_msdyn_responseaction|  
|msdyn_responseaction_connections2|[connection EntityType](connection.md)|record2id_msdyn_responseaction|  
|msdyn_responseaction_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_responseaction_email|  
|msdyn_responseaction_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_responseaction_fax|  
|msdyn_responseaction_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_responseaction_letter|  
|msdyn_responseaction_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_responseaction_msdyn_approval|  
|msdyn_responseaction_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_responseaction_msdyn_bookingalert|  
|msdyn_responseaction_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_responseaction_msdyn_surveyinvite|  
|msdyn_responseaction_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_responseaction_phonecall|  
|msdyn_responseaction_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_responseaction_recurringappointmentmaster|  
|msdyn_responseaction_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_responseaction_serviceappointment|  
|msdyn_responseaction_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_responseaction_socialactivity|  
|msdyn_responseaction_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_responseaction|  
|msdyn_responseaction_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_responseaction_task|  
|msdyn_responserouting_msdyn_responseaction|[msdyn_responserouting EntityType](msdyn_responserouting.md)|msdyn_responserouting_msdyn_responseaction|  
|msdyn_responserouting_responseaction_else|[msdyn_responserouting EntityType](msdyn_responserouting.md)|msdyn_responserouting_responseaction_else|  

## Operations
The following operations can be used with the msdyn_responseaction entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_responseaction entity type.


|Name|Description |  
|----|------------|  
|[Voice of the Customer for Microsoft Dynamics 365 Solution](../solutions/voiceofthecustomer.md)|[!INCLUDE[../solutions/descriptions/voiceofthecustomer.md](../solutions/descriptions/voiceofthecustomer.md)]|    

[!INCLUDE[./remarks/msdyn_responseaction.md](./remarks/msdyn_responseaction.md)]

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