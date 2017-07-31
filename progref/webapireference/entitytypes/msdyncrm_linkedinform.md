---
title: "Microsoft Dynamics 365 Customer Engagement msdyncrm_linkedinform EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: ed63fad3-244d-431a-9b1e-fd656aff5c2a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyncrm_linkedinform entitytype."
---
# msdyncrm_linkedinform EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyncrm_linkedinform.md](./descriptions/msdyncrm_linkedinform.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyncrm_linkedinforms </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>LinkedIn Form</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyncrm_linkedinformid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyncrm_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyncrm_linkedinform entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyncrm_description|Edm.String|**Display Name**: Description<br />**Description**: Description of the LinkedIn form<br />|
|msdyncrm_headline|Edm.String|**Display Name**: LinkedIn form headline<br />**Description**: Headline displayed to leads on LinkedIn<br />|
|msdyncrm_landingpageurl|Edm.String|**Display Name**: Landing page URL<br />**Description**: Landing page URL used on the LinkedIn form<br />|
|msdyncrm_lastondemandprocesssubmissions|Edm.DateTimeOffset|**Display Name**: Last on-demand process - Submissions<br />|
|msdyncrm_lastondemandsyncquestions|Edm.DateTimeOffset|**Display Name**: Last on-demand sync - Questions<br />|
|msdyncrm_lastondemandsyncsubmissions|Edm.DateTimeOffset|**Display Name**: Last on-demand sync - Submissions<br />|
|msdyncrm_linkedinformid|Edm.Guid|**Display Name**: LinkedIn Form<br />**Description**: Unique identifier for entity instances<br />|
|msdyncrm_linkedinid|Edm.String|**Display Name**: LinkedIn ID<br />**Description**: Unique identifier of the LinkedIn form<br />|
|msdyncrm_localecountry|Edm.String|**Display Name**: Locale country<br />**Description**: Locale country information for the LinkedIn form<br />|
|msdyncrm_localelanguage|Edm.String|**Display Name**: Locale language<br />**Description**: Locale language information for the LinkedIn form<br />|
|msdyncrm_name|Edm.String|**Display Name**: Name<br />**Description**: LinkedIn form name<br />|
|msdyncrm_privacypolicyurl|Edm.String|**Display Name**: Privacy policy URL<br />**Description**: Privacy policy URL displayed on the LinkedIn form<br />|
|msdyncrm_statusofondemandprocesssubmissions|Edm.Int32|**Display Name**: Status of on-demand process - Submissions<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Not Initialized</td></tr><tr><td>192350001</td><td>Synced</td></tr><tr><td>192350002</td><td>Error</td></tr><tbody></table>|
|msdyncrm_statusofondemandsyncquestions|Edm.Int32|**Display Name**: Status of on-demand sync - Questions<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Not Initialized</td></tr><tr><td>192350001</td><td>Synced</td></tr><tr><td>192350002</td><td>Error</td></tr><tbody></table>|
|msdyncrm_statusofondemandsyncsubmissions|Edm.Int32|**Display Name**: Status of on-demand sync - Submissions<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Not Initialized</td></tr><tr><td>192350001</td><td>Synced</td></tr><tr><td>192350002</td><td>Error</td></tr><tbody></table>|
|msdyncrm_thankyoumessage|Edm.String|**Display Name**: Thank you message<br />**Description**: Thank you message to leads who submit a form on LinkedIn<br />|
|msdyncrm_totalsubmissions|Edm.Int32|**Display Name**: Total submissions<br />**Description**: Total number of submissions received on this form<br />Computed<br />Read-only<br />|
|msdyncrm_totalsubmissions_date|Edm.DateTimeOffset|**Display Name**: Total submissions (Last Updated On)<br />**Description**: Last Updated time of rollup field Total submissions.<br />Read-only<br />|
|msdyncrm_totalsubmissions_state|Edm.Int32|**Display Name**: Total submissions (State)<br />**Description**: State of rollup field Total submissions.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the LinkedIn Form<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the LinkedIn Form<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyncrm_linkedinaccount_value|msdyncrm_LinkedInAccount<br />|LinkedIn account record to which this form belongs to|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_linkedinform_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_linkedinform_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_linkedinform_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_linkedinform_modifiedonbehalfby|
|msdyncrm_LinkedInAccount|[msdyncrm_linkedinaccount EntityType](msdyncrm_linkedinaccount.md)|msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedinform_LinkedInAccount|
|ownerid|[principal EntityType](principal.md)|owner_msdyncrm_linkedinform|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyncrm_linkedinform|
|owningteam|[team EntityType](team.md)|team_msdyncrm_linkedinform|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyncrm_linkedinform|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyncrm_linkedinform_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyncrm_linkedinform|  
|msdyncrm_linkedinform_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyncrm_linkedinform_adx_alertsubscription|  
|msdyncrm_linkedinform_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyncrm_linkedinform_adx_inviteredemption|  
|msdyncrm_linkedinform_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyncrm_linkedinform_adx_portalcomment|  
|msdyncrm_linkedinform_Annotations|[annotation EntityType](annotation.md)|objectid_msdyncrm_linkedinform|  
|msdyncrm_linkedinform_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyncrm_linkedinform_appointment|  
|msdyncrm_linkedinform_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyncrm_linkedinform|  
|msdyncrm_linkedinform_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyncrm_linkedinform|  
|msdyncrm_linkedinform_connections1|[connection EntityType](connection.md)|record1id_msdyncrm_linkedinform|  
|msdyncrm_linkedinform_connections2|[connection EntityType](connection.md)|record2id_msdyncrm_linkedinform|  
|msdyncrm_linkedinform_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyncrm_linkedinform|  
|msdyncrm_linkedinform_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyncrm_linkedinform|  
|msdyncrm_linkedinform_Emails|[email EntityType](email.md)|regardingobjectid_msdyncrm_linkedinform_email|  
|msdyncrm_linkedinform_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyncrm_linkedinform_fax|  
|msdyncrm_linkedinform_Feedback|[feedback EntityType](feedback.md)|regardingobjectid_msdyncrm_linkedinform|  
|msdyncrm_linkedinform_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyncrm_linkedinform_letter|  
|msdyncrm_linkedinform_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyncrm_linkedinform_msdyn_approval|  
|msdyncrm_linkedinform_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyncrm_linkedinform_msdyn_bookingalert|  
|msdyncrm_linkedinform_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyncrm_linkedinform_msdyn_surveyinvite|  
|msdyncrm_linkedinform_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyncrm_linkedinform_phonecall|  
|msdyncrm_linkedinform_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyncrm_linkedinform_recurringappointmentmaster|  
|msdyncrm_linkedinform_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyncrm_linkedinform_serviceappointment|  
|msdyncrm_linkedinform_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyncrm_linkedinform_socialactivity|  
|msdyncrm_linkedinform_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyncrm_linkedinform|  
|msdyncrm_linkedinform_Tasks|[task EntityType](task.md)|regardingobjectid_msdyncrm_linkedinform_task|  
|msdyncrm_msdyncrm_linkedinform_lead_sourceform|[lead EntityType](lead.md)|msdyncrm_sourceform|  
|msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformquestion_LinkedinForm|[msdyncrm_linkedinformquestion EntityType](msdyncrm_linkedinformquestion.md)|msdyncrm_LinkedinForm|  
|msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformsubmission_LinkedInFormID|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|msdyncrm_LinkedInFormID|  

## Operations
The following operations can be used with the msdyncrm_linkedinform entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyncrm_linkedinform entity type.


|Name|Description |  
|----|------------|  
|[LinkedIn Lead Gen Forms Solution](../solutions/linkedinleadgenintegration.md)|[!INCLUDE[../solutions/descriptions/linkedinleadgenintegration.md](../solutions/descriptions/linkedinleadgenintegration.md)]|    

[!INCLUDE[./remarks/msdyncrm_linkedinform.md](./remarks/msdyncrm_linkedinform.md)]

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