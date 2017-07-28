---
title: "Microsoft Dynamics 365 Customer Engagement msdyncrm_linkedinformquestion EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 468e9844-d1d7-4f24-9171-353dcd8facfb
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyncrm_linkedinformquestion entitytype."
---
# msdyncrm_linkedinformquestion EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyncrm_linkedinformquestion.md](./descriptions/msdyncrm_linkedinformquestion.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyncrm_linkedinformquestions </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>LinkedIn Form Question</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyncrm_linkedinformquestionid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyncrm_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyncrm_linkedinformquestion entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyncrm_displayname|Edm.String|**Display Name**: Display name<br />**Description**: Display name on the LinkedIn form<br />|
|msdyncrm_linkedinformquestionid|Edm.Guid|**Display Name**: LinkedIn Form Question<br />**Description**: Unique identifier for entity instances<br />|
|msdyncrm_linkedinid|Edm.String|**Display Name**: LinkedIn ID<br />**Description**: Unique identifier of the form question on LinkedIn<br />|
|msdyncrm_name|Edm.String|**Display Name**: Name<br />**Description**: Enter the LinkedIn form question name<br />|
|msdyncrm_responseeditable|Edm.Boolean|**Display Name**: Response editable<br />**Description**: Can a LinkedIn user edit this response, or is it pre-filled based on their profile?<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyncrm_responsetype|Edm.String|**Display Name**: Response type<br />**Description**: Response format used for this question<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the LinkedIn Form Question<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the LinkedIn Form Question<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyncrm_linkedinform_value|msdyncrm_LinkedinForm<br />|LinkedIn form where this question appears|
|_msdyncrm_linkedinpredefinedfield_value|msdyncrm_LinkedInPredefinedField<br />||
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_linkedinformquestion_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_linkedinformquestion_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_linkedinformquestion_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_linkedinformquestion_modifiedonbehalfby|
|msdyncrm_LinkedinForm|[msdyncrm_linkedinform EntityType](msdyncrm_linkedinform.md)|msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformquestion_LinkedinForm|
|msdyncrm_LinkedInPredefinedField|[msdyncrm_linkedinfieldmapping EntityType](msdyncrm_linkedinfieldmapping.md)|msdyncrm_msdyncrm_linkedinfieldmapping_msdyncrm_linkedinformquestion_LinkedInPredefinedField|
|ownerid|[principal EntityType](principal.md)|owner_msdyncrm_linkedinformquestion|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyncrm_linkedinformquestion|
|owningteam|[team EntityType](team.md)|team_msdyncrm_linkedinformquestion|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyncrm_linkedinformquestion|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyncrm_linkedinformanswer_linkedinformquestion_relation|[msdyncrm_linkedinformanswer EntityType](msdyncrm_linkedinformanswer.md)|msdyncrm_linkedinformquestion|  
|msdyncrm_linkedinformquestion_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyncrm_linkedinformquestion|  
|msdyncrm_linkedinformquestion_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyncrm_linkedinformquestion_adx_alertsubscription|  
|msdyncrm_linkedinformquestion_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyncrm_linkedinformquestion_adx_inviteredemption|  
|msdyncrm_linkedinformquestion_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyncrm_linkedinformquestion_adx_portalcomment|  
|msdyncrm_linkedinformquestion_Annotations|[annotation EntityType](annotation.md)|objectid_msdyncrm_linkedinformquestion|  
|msdyncrm_linkedinformquestion_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyncrm_linkedinformquestion_appointment|  
|msdyncrm_linkedinformquestion_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyncrm_linkedinformquestion|  
|msdyncrm_linkedinformquestion_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyncrm_linkedinformquestion|  
|msdyncrm_linkedinformquestion_connections1|[connection EntityType](connection.md)|record1id_msdyncrm_linkedinformquestion|  
|msdyncrm_linkedinformquestion_connections2|[connection EntityType](connection.md)|record2id_msdyncrm_linkedinformquestion|  
|msdyncrm_linkedinformquestion_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyncrm_linkedinformquestion|  
|msdyncrm_linkedinformquestion_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyncrm_linkedinformquestion|  
|msdyncrm_linkedinformquestion_Emails|[email EntityType](email.md)|regardingobjectid_msdyncrm_linkedinformquestion_email|  
|msdyncrm_linkedinformquestion_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyncrm_linkedinformquestion_fax|  
|msdyncrm_linkedinformquestion_Feedback|[feedback EntityType](feedback.md)|regardingobjectid_msdyncrm_linkedinformquestion|  
|msdyncrm_linkedinformquestion_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyncrm_linkedinformquestion_letter|  
|msdyncrm_linkedinformquestion_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyncrm_linkedinformquestion_msdyn_approval|  
|msdyncrm_linkedinformquestion_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyncrm_linkedinformquestion_msdyn_bookingalert|  
|msdyncrm_linkedinformquestion_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyncrm_linkedinformquestion_msdyn_surveyinvite|  
|msdyncrm_linkedinformquestion_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyncrm_linkedinformquestion_phonecall|  
|msdyncrm_linkedinformquestion_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyncrm_linkedinformquestion_recurringappointmentmaster|  
|msdyncrm_linkedinformquestion_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyncrm_linkedinformquestion_serviceappointment|  
|msdyncrm_linkedinformquestion_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyncrm_linkedinformquestion_socialactivity|  
|msdyncrm_linkedinformquestion_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyncrm_linkedinformquestion|  
|msdyncrm_linkedinformquestion_Tasks|[task EntityType](task.md)|regardingobjectid_msdyncrm_linkedinformquestion_task|  

## Operations
The following operations can be used with the msdyncrm_linkedinformquestion entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyncrm_linkedinformquestion entity type.


|Name|Description |  
|----|------------|  
|[LinkedIn Lead Gen Forms Solution](../solutions/linkedinleadgenintegration.md)|[!INCLUDE[../solutions/descriptions/linkedinleadgenintegration.md](../solutions/descriptions/linkedinleadgenintegration.md)]|    

[!INCLUDE[./remarks/msdyncrm_linkedinformquestion.md](./remarks/msdyncrm_linkedinformquestion.md)]

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