---
title: "Microsoft Dynamics 365 Customer Engagement msdyncrm_marketingemailtestsend EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: fbc4a85b-e12d-4670-bd90-511c12f07abf
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyncrm_marketingemailtestsend entitytype."
---
# msdyncrm_marketingemailtestsend EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyncrm_marketingemailtestsend.md](./descriptions/msdyncrm_marketingemailtestsend.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyncrm_marketingemailtestsends </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Marketing Email Test Send</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyncrm_marketingemailtestsendid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyncrm_subject</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyncrm_marketingemailtestsend entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyncrm_emailbody|Edm.String|**Display Name**: Email Body<br />|
|msdyncrm_emailid|Edm.String|**Display Name**: emailid<br />|
|msdyncrm_from|Edm.String|**Display Name**: From<br />|
|msdyncrm_fromexpression|Edm.String|**Display Name**: From Expression<br />|
|msdyncrm_htmlpart|Edm.String|**Display Name**: Html Part<br />|
|msdyncrm_keywords|Edm.String|**Display Name**: Keywords<br />|
|msdyncrm_marketingemailtestsendid|Edm.Guid|**Display Name**: Marketing Email Test Send<br />**Description**: Unique identifier for entity instances<br />|
|msdyncrm_marketinglistid|Edm.String|**Display Name**: Marketing List Id<br />|
|msdyncrm_messagetype|Edm.Int32|**Display Name**: Message Type<br />|
|msdyncrm_replytoexpression|Edm.String|**Display Name**: Reply To Expression<br />|
|msdyncrm_subject|Edm.String|**Display Name**: Subject<br />**Description**: The name of the custom entity.<br />|
|msdyncrm_testsendemailaddress|Edm.String|**Display Name**: Test Send Email Address<br />|
|msdyncrm_textpart|Edm.String|**Display Name**: Text Part<br />|
|msdyncrm_toexpression|Edm.String|**Display Name**: To Expression<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Marketing Email Test Send<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Marketing Email Test Send<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyncrm_testcontactid_value|msdyncrm_testcontactid<br />||
|_msdyncrm_testcontentsettingsid_value|msdyncrm_testcontentsettingsid<br />||
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingemailtestsend_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingemailtestsend_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingemailtestsend_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingemailtestsend_modifiedonbehalfby|
|msdyncrm_testcontactid|[contact EntityType](contact.md)|msdyncrm_contact_msdyncrm_marketingemailtestsend_testcontactid|
|msdyncrm_testcontentsettingsid|[msdyncrm_contentsettings EntityType](msdyncrm_contentsettings.md)|msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingemailtestsend_testcontentsettingsid|
|ownerid|[principal EntityType](principal.md)|owner_msdyncrm_marketingemailtestsend|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyncrm_marketingemailtestsend|
|owningteam|[team EntityType](team.md)|team_msdyncrm_marketingemailtestsend|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyncrm_marketingemailtestsend|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyncrm_marketingemailtestsend_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyncrm_marketingemailtestsend|  
|msdyncrm_marketingemailtestsend_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyncrm_marketingemailtestsend_adx_alertsubscription|  
|msdyncrm_marketingemailtestsend_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyncrm_marketingemailtestsend_adx_inviteredemption|  
|msdyncrm_marketingemailtestsend_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyncrm_marketingemailtestsend_adx_portalcomment|  
|msdyncrm_marketingemailtestsend_Annotations|[annotation EntityType](annotation.md)|objectid_msdyncrm_marketingemailtestsend|  
|msdyncrm_marketingemailtestsend_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyncrm_marketingemailtestsend_appointment|  
|msdyncrm_marketingemailtestsend_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyncrm_marketingemailtestsend|  
|msdyncrm_marketingemailtestsend_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyncrm_marketingemailtestsend|  
|msdyncrm_marketingemailtestsend_connections1|[connection EntityType](connection.md)|record1id_msdyncrm_marketingemailtestsend|  
|msdyncrm_marketingemailtestsend_connections2|[connection EntityType](connection.md)|record2id_msdyncrm_marketingemailtestsend|  
|msdyncrm_marketingemailtestsend_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyncrm_marketingemailtestsend|  
|msdyncrm_marketingemailtestsend_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyncrm_marketingemailtestsend|  
|msdyncrm_marketingemailtestsend_Emails|[email EntityType](email.md)|regardingobjectid_msdyncrm_marketingemailtestsend_email|  
|msdyncrm_marketingemailtestsend_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyncrm_marketingemailtestsend_fax|  
|msdyncrm_marketingemailtestsend_Feedback|[feedback EntityType](feedback.md)|regardingobjectid_msdyncrm_marketingemailtestsend|  
|msdyncrm_marketingemailtestsend_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyncrm_marketingemailtestsend_letter|  
|msdyncrm_marketingemailtestsend_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyncrm_marketingemailtestsend_msdyn_approval|  
|msdyncrm_marketingemailtestsend_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyncrm_marketingemailtestsend_msdyn_bookingalert|  
|msdyncrm_marketingemailtestsend_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyncrm_marketingemailtestsend_msdyn_surveyinvite|  
|msdyncrm_marketingemailtestsend_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyncrm_marketingemailtestsend_phonecall|  
|msdyncrm_marketingemailtestsend_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyncrm_marketingemailtestsend_recurringappointmentmaster|  
|msdyncrm_marketingemailtestsend_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyncrm_marketingemailtestsend_serviceappointment|  
|msdyncrm_marketingemailtestsend_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyncrm_marketingemailtestsend_socialactivity|  
|msdyncrm_marketingemailtestsend_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyncrm_marketingemailtestsend|  
|msdyncrm_marketingemailtestsend_Tasks|[task EntityType](task.md)|regardingobjectid_msdyncrm_marketingemailtestsend_task|  

## Operations
The following operations can be used with the msdyncrm_marketingemailtestsend entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyncrm_marketingemailtestsend entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Marketing Solution](../solutions/microsoftdynamicsmarketingcrmsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md](../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md)]|    

[!INCLUDE[./remarks/msdyncrm_marketingemailtestsend.md](./remarks/msdyncrm_marketingemailtestsend.md)]

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