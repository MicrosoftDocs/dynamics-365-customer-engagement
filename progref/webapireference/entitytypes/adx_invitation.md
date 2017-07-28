---
title: "Microsoft Dynamics 365 Customer Engagement adx_invitation EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 395c2d11-2bf2-4277-8383-5064e6d667ea
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API adx_invitation entitytype."
---
# adx_invitation EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/adx_invitation.md](./descriptions/adx_invitation.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]adx_invitations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Invitation</td></tr>
<tr><td><b>Primary Key:</b></td><td>adx_invitationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>adx_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The adx_invitation entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|adx_expirydate|Edm.DateTimeOffset|**Display Name**: Expiry Date<br />**Description**: The date the invitation is no longer valid for redemption.<br />|
|adx_invitationcode|Edm.String|**Display Name**: Invitation Code<br />**Description**: Shows the user who is redeeming the invitation.<br />|
|adx_invitationid|Edm.Guid|**Display Name**: Invitation<br />**Description**: Shows the entity instance.<br />|
|adx_maximumredemptions|Edm.Int32|**Display Name**: Maximum Redemptions<br />|
|adx_name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the custom entity.<br />|
|adx_redemptions|Edm.Int32|**Display Name**: Redemptions<br />**Description**: The current number of times this invitation has been redeemed.<br />|
|adx_type|Edm.Int32|**Display Name**: Type<br />**Description**: The type of invitation.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>756150000</td><td>Single</td></tr><tr><td>756150001</td><td>Group</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Invitation<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the invitation's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>New</td></tr><tr><td>756150000</td><td>Sent</td></tr><tr><td>756150001</td><td>Redeemed</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_adx_assigntoaccount_value|adx_assignToAccount<br />|An account record to assign the redeemed contact to.|
|_adx_invitecontact_value|adx_inviteContact<br />|The contact to send an invitation to.|
|_adx_invitercontact_value|adx_invitercontact<br />|The contact that invited.|
|_adx_redeemedcontact_value|adx_redeemedContact<br />|The contact associated with the redemption of this invitation.|
|_adx_redemptionworkflow_value|adx_redemptionWorkflow<br />|A workflow to execute on the redeeming contact.|
|_adx_website_value|adx_website<br />|Unique identifier for Website associated with Invitation.|
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
|adx_assignToAccount|[account EntityType](account.md)|adx_invitation_assigntoaccount|
|adx_inviteContact|[contact EntityType](contact.md)|adx_invitation_invitecontact|
|adx_invitercontact|[contact EntityType](contact.md)|adx_invitation_invitercontact|
|adx_redeemedContact|[contact EntityType](contact.md)|adx_invitation_redeemedContact|
|adx_redemptionWorkflow|[workflow EntityType](workflow.md)|adx_invitation_redemptionworkflow|
|adx_website|[adx_website EntityType](adx_website.md)|adx_invitation_website|
|createdby|[systemuser EntityType](systemuser.md)|lk_adx_invitation_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_invitation_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_adx_invitation_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_invitation_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_adx_invitation|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_adx_invitation|
|owningteam|[team EntityType](team.md)|team_adx_invitation|
|owninguser|[systemuser EntityType](systemuser.md)|user_adx_invitation|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_invitation_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_adx_invitation|  
|adx_invitation_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_adx_invitation_adx_alertsubscription|  
|adx_invitation_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_adx_invitation_adx_inviteredemption|  
|adx_invitation_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_adx_invitation_adx_portalcomment|  
|adx_invitation_Annotations|[annotation EntityType](annotation.md)|objectid_adx_invitation|  
|adx_invitation_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_adx_invitation_appointment|  
|adx_invitation_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_adx_invitation|  
|adx_invitation_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_adx_invitation|  
|adx_invitation_connections1|[connection EntityType](connection.md)|record1id_adx_invitation|  
|adx_invitation_connections2|[connection EntityType](connection.md)|record2id_adx_invitation|  
|adx_invitation_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_adx_invitation|  
|adx_invitation_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_adx_invitation|  
|adx_invitation_Emails|[email EntityType](email.md)|regardingobjectid_adx_invitation_email|  
|adx_invitation_Faxes|[fax EntityType](fax.md)|regardingobjectid_adx_invitation_fax|  
|adx_invitation_invitecontacts|[contact EntityType](contact.md)|adx_invitation_invitecontacts|  
|adx_invitation_Letters|[letter EntityType](letter.md)|regardingobjectid_adx_invitation_letter|  
|adx_invitation_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_adx_invitation_msdyn_approval|  
|adx_invitation_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_adx_invitation_msdyn_bookingalert|  
|adx_invitation_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_adx_invitation_msdyn_surveyinvite|  
|adx_invitation_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_adx_invitation_phonecall|  
|adx_invitation_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_adx_invitation_recurringappointmentmaster|  
|adx_invitation_redeemedcontacts|[contact EntityType](contact.md)|adx_invitation_redeemedcontacts|  
|adx_invitation_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_adx_invitation_serviceappointment|  
|adx_invitation_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_adx_invitation_socialactivity|  
|adx_invitation_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_adx_invitation|  
|adx_invitation_Tasks|[task EntityType](task.md)|regardingobjectid_adx_invitation_task|  
|adx_invitation_webrole|[adx_webrole EntityType](adx_webrole.md)|adx_invitation_webrole|  

## Operations
The following operations can be used with the adx_invitation entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the adx_invitation entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Portal Base Solution](../solutions/microsoftcrmportalbase.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportalbase.md](../solutions/descriptions/microsoftcrmportalbase.md)]|    

[!INCLUDE[./remarks/adx_invitation.md](./remarks/adx_invitation.md)]

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