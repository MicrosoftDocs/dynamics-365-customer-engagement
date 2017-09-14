---
title: "Microsoft Dynamics 365 Customer Engagement msdyncrm_linkedinformsubmission EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3c2c5376-d1fa-4c18-bbc1-66d7ee9b3f2c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyncrm_linkedinformsubmission entitytype."
---
# msdyncrm_linkedinformsubmission EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyncrm_linkedinformsubmission.md](./descriptions/msdyncrm_linkedinformsubmission.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyncrm_linkedinformsubmissions </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>LinkedIn Form Submission</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyncrm_linkedinformsubmissionid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyncrm_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyncrm_linkedinformsubmission entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyncrm_linkedinaccountid|Edm.String|**Display Name**: LinkedIn account<br />**Description**: LinkedIn account this submission came from<br />|
|msdyncrm_linkedincampaignid|Edm.String|**Display Name**: LinkedIn campaign ID<br />**Description**: Unique identifier of the LinkedIn campaign this submission is for<br />|
|msdyncrm_linkedincreativeid|Edm.String|**Display Name**: LinkedIn Creative ID<br />**Description**: Unique identifier of the LinkedIn creative campaign this submission is for<br />|
|msdyncrm_linkedinformname|Edm.String|**Display Name**: Source Form<br />Computed<br />Read-only<br />|
|msdyncrm_linkedinformsubmission_textid|Edm.String|**Display Name**: LinkedIn Form Submission Text Id<br />|
|msdyncrm_linkedinformsubmissionid|Edm.Guid|**Display Name**: LinkedIn ID<br />**Description**: Unique identifier of the LinkedIn form submission<br />|
|msdyncrm_matchingstatus|Edm.Int32|**Display Name**: Matching status<br />**Description**: Status of matching and lead association with Dynamics 365<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Pending lead matching</td></tr><tr><td>192350001</td><td>New lead created</td></tr><tr><td>192350002</td><td>Updated existing lead</td></tr><tr><td>192350003</td><td>Match failed</td></tr><tr><td>192350004</td><td>Lead creation failed</td></tr><tr><td>192350005</td><td>Lead update failed</td></tr><tr><td>192350006</td><td>Lead matched but not updated</td></tr><tbody></table>|
|msdyncrm_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyncrm_processingstate|Edm.Int32|**Display Name**: Processing State<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Unprocessed</td></tr><tr><td>192350001</td><td>Processing Succeeded</td></tr><tr><td>192350002</td><td>Processing Failed</td></tr><tbody></table>|
|msdyncrm_submissiondate|Edm.DateTimeOffset|**Display Name**: Submission date<br />**Description**: Date and time submission was captured<br />|
|msdyncrm_type|Edm.String|**Display Name**: Type<br />**Description**: Submission type<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the LinkedIn Form Submission<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the LinkedIn Form Submission<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyncr2_customerjourney_value|msdyncr2_customerjourney<br />||
|_msdyncrm_lead_value|msdyncrm_Lead<br />|Dynamics 365 lead associated with this submission|
|_msdyncrm_linkedincampaign_value|msdyncrm_LinkedInCampaign<br />||
|_msdyncrm_linkedinformid_value|msdyncrm_LinkedInFormID<br />|LinkedIn form this submission came from|
|_msdyncrm_linkedinuserprofileid_value|msdyncrm_LinkedInUserProfileID<br />||
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_linkedinformsubmission_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_linkedinformsubmission_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_linkedinformsubmission_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_linkedinformsubmission_modifiedonbehalfby|
|msdyncr2_customerjourney|[msdyncrm_customerjourney EntityType](msdyncrm_customerjourney.md)|msdyncr2_linkedinformsubmission_customerjourney|
|msdyncrm_Lead|[lead EntityType](lead.md)|msdyncrm_lead_msdyncrm_linkedinformsubmission_Lead|
|msdyncrm_LinkedInCampaign|[msdyncrm_linkedincampaign EntityType](msdyncrm_linkedincampaign.md)|msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedinformsubmission_LinkedInCampaign|
|msdyncrm_LinkedInFormID|[msdyncrm_linkedinform EntityType](msdyncrm_linkedinform.md)|msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformsubmission_LinkedInFormID|
|msdyncrm_LinkedInUserProfileID|[msdyncrm_linkedinuserprofile EntityType](msdyncrm_linkedinuserprofile.md)|msdyncrm_userprofile_linkedinformsubmission|
|ownerid|[principal EntityType](principal.md)|owner_msdyncrm_linkedinformsubmission|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyncrm_linkedinformsubmission|
|owningteam|[team EntityType](team.md)|team_msdyncrm_linkedinformsubmission|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyncrm_linkedinformsubmission|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyncrm_linkedinformsubmission_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyncrm_linkedinformsubmission|  
|msdyncrm_linkedinformsubmission_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyncrm_linkedinformsubmission_adx_alertsubscription|  
|msdyncrm_linkedinformsubmission_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyncrm_linkedinformsubmission_adx_inviteredemption|  
|msdyncrm_linkedinformsubmission_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyncrm_linkedinformsubmission_adx_portalcomment|  
|msdyncrm_linkedinformsubmission_Annotations|[annotation EntityType](annotation.md)|objectid_msdyncrm_linkedinformsubmission|  
|msdyncrm_linkedinformsubmission_answer|[msdyncrm_linkedinformanswer EntityType](msdyncrm_linkedinformanswer.md)|msdyncrm_linkedinformsubmission|  
|msdyncrm_linkedinformsubmission_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyncrm_linkedinformsubmission_appointment|  
|msdyncrm_linkedinformsubmission_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyncrm_linkedinformsubmission|  
|msdyncrm_linkedinformsubmission_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyncrm_linkedinformsubmission|  
|msdyncrm_linkedinformsubmission_connections1|[connection EntityType](connection.md)|record1id_msdyncrm_linkedinformsubmission|  
|msdyncrm_linkedinformsubmission_connections2|[connection EntityType](connection.md)|record2id_msdyncrm_linkedinformsubmission|  
|msdyncrm_linkedinformsubmission_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyncrm_linkedinformsubmission|  
|msdyncrm_linkedinformsubmission_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyncrm_linkedinformsubmission|  
|msdyncrm_linkedinformsubmission_Emails|[email EntityType](email.md)|regardingobjectid_msdyncrm_linkedinformsubmission_email|  
|msdyncrm_linkedinformsubmission_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyncrm_linkedinformsubmission_fax|  
|msdyncrm_linkedinformsubmission_Feedback|[feedback EntityType](feedback.md)|regardingobjectid_msdyncrm_linkedinformsubmission|  
|msdyncrm_linkedinformsubmission_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyncrm_linkedinformsubmission_letter|  
|msdyncrm_linkedinformsubmission_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyncrm_linkedinformsubmission_msdyn_approval|  
|msdyncrm_linkedinformsubmission_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyncrm_linkedinformsubmission_msdyn_bookingalert|  
|msdyncrm_linkedinformsubmission_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyncrm_linkedinformsubmission_msdyn_surveyinvite|  
|msdyncrm_linkedinformsubmission_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyncrm_linkedinformsubmission_phonecall|  
|msdyncrm_linkedinformsubmission_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyncrm_linkedinformsubmission_recurringappointmentmaster|  
|msdyncrm_linkedinformsubmission_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyncrm_linkedinformsubmission_serviceappointment|  
|msdyncrm_linkedinformsubmission_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyncrm_linkedinformsubmission_socialactivity|  
|msdyncrm_linkedinformsubmission_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyncrm_linkedinformsubmission|  
|msdyncrm_linkedinformsubmission_Tasks|[task EntityType](task.md)|regardingobjectid_msdyncrm_linkedinformsubmission_task|  

## Operations
The following operations can be used with the msdyncrm_linkedinformsubmission entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyncrm_linkedinformsubmission entity type.


|Name|Description |  
|----|------------|  
|[LinkedIn Lead Gen Forms (Link to Marketing) Solution](../solutions/linkedinleadgenintegrationlink.md)|[!INCLUDE[../solutions/descriptions/linkedinleadgenintegrationlink.md](../solutions/descriptions/linkedinleadgenintegrationlink.md)]|  
|[LinkedIn Lead Gen Forms Solution](../solutions/linkedinleadgenintegration.md)|[!INCLUDE[../solutions/descriptions/linkedinleadgenintegration.md](../solutions/descriptions/linkedinleadgenintegration.md)]|    

[!INCLUDE[./remarks/msdyncrm_linkedinformsubmission.md](./remarks/msdyncrm_linkedinformsubmission.md)]

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