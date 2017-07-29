---
title: "Microsoft Dynamics 365 Customer Engagement adx_poll EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 48b3185d-b20a-426e-bc69-e1387eb1bdfa
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API adx_poll entitytype."
---
# adx_poll EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/adx_poll.md](./descriptions/adx_poll.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]adx_polls </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Poll</td></tr>
<tr><td><b>Primary Key:</b></td><td>adx_pollid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>adx_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The adx_poll entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|adx_active|Edm.Boolean|**Display Name**: Active<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_closevotingdate|Edm.DateTimeOffset|**Display Name**: Close Voting Date<br />|
|adx_expirationdate|Edm.DateTimeOffset|**Display Name**: Expiration Date<br />|
|adx_name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the custom entity.<br />|
|adx_pollid|Edm.Guid|**Display Name**: Poll<br />**Description**: Shows the entity instance.<br />|
|adx_question|Edm.String|**Display Name**: Question<br />|
|adx_releasedate|Edm.DateTimeOffset|**Display Name**: Release Date<br />|
|adx_submitbuttonlabel|Edm.String|**Display Name**: Submit Button Label<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Poll<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the poll's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_adx_websiteid_value|adx_websiteid<br />|Unique identifier for Website associated with Poll.|
|_adx_webtemplateid_value|adx_webtemplateid<br />|Unique identifier for Web Template associated with Poll.|
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Enter the user who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that owns the record.|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|adx_websiteid|[adx_website EntityType](adx_website.md)|adx_website_poll|
|adx_webtemplateid|[adx_webtemplate EntityType](adx_webtemplate.md)|adx_webtemplate_poll|
|createdby|[systemuser EntityType](systemuser.md)|lk_adx_poll_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_poll_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_adx_poll_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_poll_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_adx_poll|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_adx_poll|
|owningteam|[team EntityType](team.md)|team_adx_poll|
|owninguser|[systemuser EntityType](systemuser.md)|user_adx_poll|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_poll_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_adx_poll|  
|adx_poll_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_adx_poll_adx_alertsubscription|  
|adx_poll_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_adx_poll_adx_inviteredemption|  
|adx_poll_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_adx_poll_adx_portalcomment|  
|adx_poll_Annotations|[annotation EntityType](annotation.md)|objectid_adx_poll|  
|adx_poll_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_adx_poll_appointment|  
|adx_poll_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_adx_poll|  
|adx_poll_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_adx_poll|  
|adx_poll_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_adx_poll|  
|adx_poll_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_adx_poll|  
|adx_poll_Emails|[email EntityType](email.md)|regardingobjectid_adx_poll_email|  
|adx_poll_Faxes|[fax EntityType](fax.md)|regardingobjectid_adx_poll_fax|  
|adx_poll_Letters|[letter EntityType](letter.md)|regardingobjectid_adx_poll_letter|  
|adx_poll_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_adx_poll_msdyn_approval|  
|adx_poll_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_adx_poll_msdyn_bookingalert|  
|adx_poll_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_adx_poll_msdyn_surveyinvite|  
|adx_poll_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_adx_poll_phonecall|  
|adx_poll_polloption|[adx_polloption EntityType](adx_polloption.md)|adx_pollid|  
|adx_poll_pollsubmission|[adx_pollsubmission EntityType](adx_pollsubmission.md)|adx_pollid|  
|adx_poll_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_adx_poll_recurringappointmentmaster|  
|adx_poll_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_adx_poll_serviceappointment|  
|adx_poll_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_adx_poll_socialactivity|  
|adx_poll_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_adx_poll|  
|adx_poll_Tasks|[task EntityType](task.md)|regardingobjectid_adx_poll_task|  
|adx_pollplacement_poll|[adx_pollplacement EntityType](adx_pollplacement.md)|adx_pollplacement_poll|  

## Operations
The following operations can be used with the adx_poll entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the adx_poll entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Portal Base Solution](../solutions/microsoftcrmportalbase.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportalbase.md](../solutions/descriptions/microsoftcrmportalbase.md)]|    

[!INCLUDE[./remarks/adx_poll.md](./remarks/adx_poll.md)]

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