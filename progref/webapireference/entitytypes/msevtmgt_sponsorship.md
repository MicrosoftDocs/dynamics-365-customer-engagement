---
title: "Microsoft Dynamics 365 Customer Engagement msevtmgt_sponsorship EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 75ed0a36-65d9-4875-b330-a505314d3723
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msevtmgt_sponsorship entitytype."
---
# msevtmgt_sponsorship EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msevtmgt_sponsorship.md](./descriptions/msevtmgt_sponsorship.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msevtmgt_sponsorships </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Sponsorship</td></tr>
<tr><td><b>Primary Key:</b></td><td>msevtmgt_sponsorshipid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msevtmgt_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msevtmgt_sponsorship entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|entityimage|Edm.Binary|**Display Name**: Sponsor image<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msevtmgt_description|Edm.String|**Display Name**: Description<br />|
|msevtmgt_name|Edm.String|**Display Name**: Name<br />|
|msevtmgt_sponsorshipamount|Edm.Decimal|**Display Name**: Sponsorship Amount<br />|
|msevtmgt_sponsorshipamount_base|Edm.Decimal|**Display Name**: Sponsorship Amount (Base)<br />**Description**: Value of the Sponsorship Amount in base currency.<br />Read-only<br />|
|msevtmgt_sponsorshipcategory|Edm.Int32|**Display Name**: Sponsorship Category<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Platinum</td></tr><tr><td>100000001</td><td>Gold</td></tr><tr><td>100000002</td><td>Silver</td></tr><tr><td>100000003</td><td>Bronze</td></tr><tbody></table>|
|msevtmgt_sponsorshipid|Edm.Guid|**Display Name**: Sponsorship<br />**Description**: Unique identifier for entity instances<br />|
|msevtmgt_sponsorshiptype|Edm.Int32|**Display Name**: Sponsorship Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Monetary</td></tr><tr><td>100000001</td><td>Services</td></tr><tr><td>100000002</td><td>Equipment</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Sponsorship<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Sponsorship<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msevtmgt_event_value|msevtmgt_Event<br />||
|_msevtmgt_sponsor_value|msevtmgt_Sponsor<br />||
|_msevtmgt_transactioncurrencyid_value||Unique identifier of the currency associated with the entity.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_sponsorship_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_sponsorship_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_sponsorship_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_sponsorship_modifiedonbehalfby|
|msevtmgt_Event|[msevtmgt_event EntityType](msevtmgt_event.md)|msevtmgt_Event_msevtmgt_Sponsorship|
|msevtmgt_Sponsor|[account EntityType](account.md)|msevtmgt_account_msevtmgt_sponsorship_Sponsor|
|ownerid|[principal EntityType](principal.md)|owner_msevtmgt_sponsorship|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msevtmgt_sponsorship|
|owningteam|[team EntityType](team.md)|team_msevtmgt_sponsorship|
|owninguser|[systemuser EntityType](systemuser.md)|user_msevtmgt_sponsorship|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msevtmgt_Sponsorship|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msevtmgt_sponsorablearticle_sponsorship|[msevtmgt_sponsorablearticle EntityType](msevtmgt_sponsorablearticle.md)|msevtmgt_EventSponsorship|  
|msevtmgt_sponsorship_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msevtmgt_sponsorship|  
|msevtmgt_sponsorship_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msevtmgt_sponsorship_adx_alertsubscription|  
|msevtmgt_sponsorship_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msevtmgt_sponsorship_adx_inviteredemption|  
|msevtmgt_sponsorship_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msevtmgt_sponsorship_adx_portalcomment|  
|msevtmgt_sponsorship_Annotations|[annotation EntityType](annotation.md)|objectid_msevtmgt_sponsorship|  
|msevtmgt_sponsorship_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msevtmgt_sponsorship_appointment|  
|msevtmgt_sponsorship_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msevtmgt_sponsorship|  
|msevtmgt_sponsorship_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msevtmgt_sponsorship|  
|msevtmgt_sponsorship_Emails|[email EntityType](email.md)|regardingobjectid_msevtmgt_sponsorship_email|  
|msevtmgt_sponsorship_Faxes|[fax EntityType](fax.md)|regardingobjectid_msevtmgt_sponsorship_fax|  
|msevtmgt_sponsorship_Letters|[letter EntityType](letter.md)|regardingobjectid_msevtmgt_sponsorship_letter|  
|msevtmgt_sponsorship_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msevtmgt_sponsorship_msdyn_approval|  
|msevtmgt_sponsorship_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msevtmgt_sponsorship_msdyn_bookingalert|  
|msevtmgt_sponsorship_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msevtmgt_sponsorship_msdyn_surveyinvite|  
|msevtmgt_sponsorship_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msevtmgt_sponsorship_phonecall|  
|msevtmgt_sponsorship_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msevtmgt_sponsorship_recurringappointmentmaster|  
|msevtmgt_sponsorship_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msevtmgt_sponsorship_serviceappointment|  
|msevtmgt_sponsorship_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msevtmgt_sponsorship_socialactivity|  
|msevtmgt_sponsorship_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msevtmgt_sponsorship|  
|msevtmgt_sponsorship_Tasks|[task EntityType](task.md)|regardingobjectid_msevtmgt_sponsorship_task|  

## Operations
The following operations can be used with the msevtmgt_sponsorship entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msevtmgt_sponsorship entity type.


|Name|Description |  
|----|------------|  
|[Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicseventmanagementsolution.md](../solutions/descriptions/microsoftdynamicseventmanagementsolution.md)]|    

[!INCLUDE[./remarks/msevtmgt_sponsorship.md](./remarks/msevtmgt_sponsorship.md)]

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