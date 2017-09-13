---
title: "Microsoft Dynamics 365 Customer Engagement msevtmgt_sponsorablearticle EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 80c7103a-7239-49d6-a12a-6586f6181a38
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msevtmgt_sponsorablearticle entitytype."
---
# msevtmgt_sponsorablearticle EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msevtmgt_sponsorablearticle.md](./descriptions/msevtmgt_sponsorablearticle.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msevtmgt_sponsorablearticles </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Sponsorable Article</td></tr>
<tr><td><b>Primary Key:</b></td><td>msevtmgt_sponsorablearticleid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msevtmgt_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msevtmgt_sponsorablearticle entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msevtmgt_costperunit|Edm.Decimal|**Display Name**: Cost per unit<br />|
|msevtmgt_costperunit_base|Edm.Decimal|**Display Name**: Cost per unit (Base)<br />**Description**: Value of the Cost per unit in base currency.<br />Read-only<br />|
|msevtmgt_description|Edm.String|**Display Name**: Description<br />|
|msevtmgt_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msevtmgt_numberofunits|Edm.Int32|**Display Name**: Number of units<br />|
|msevtmgt_sponsorablearticleid|Edm.Guid|**Display Name**: Sponsorable Article<br />**Description**: Unique identifier for entity instances<br />|
|msevtmgt_totalcost|Edm.Decimal|**Display Name**: Total cost<br />Computed<br />Read-only<br />|
|msevtmgt_totalcost_base|Edm.Decimal|**Display Name**: Total cost (Base)<br />**Description**: Value of the Total cost in base currency.<br />Computed<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Sponsorable Article<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Sponsorable Article<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msevtmgt_eventsponsorship_value|msevtmgt_EventSponsorship<br />||
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
|createdby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_sponsorablearticle_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_sponsorablearticle_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_sponsorablearticle_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_sponsorablearticle_modifiedonbehalfby|
|msevtmgt_EventSponsorship|[msevtmgt_sponsorship EntityType](msevtmgt_sponsorship.md)|msevtmgt_sponsorablearticle_sponsorship|
|ownerid|[principal EntityType](principal.md)|owner_msevtmgt_sponsorablearticle|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msevtmgt_sponsorablearticle|
|owningteam|[team EntityType](team.md)|team_msevtmgt_sponsorablearticle|
|owninguser|[systemuser EntityType](systemuser.md)|user_msevtmgt_sponsorablearticle|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msevtmgt_SponsorableArticle|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msevtmgt_sponsorablearticle_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msevtmgt_sponsorablearticle|  
|msevtmgt_sponsorablearticle_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msevtmgt_sponsorablearticle_adx_alertsubscription|  
|msevtmgt_sponsorablearticle_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msevtmgt_sponsorablearticle_adx_inviteredemption|  
|msevtmgt_sponsorablearticle_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msevtmgt_sponsorablearticle_adx_portalcomment|  
|msevtmgt_sponsorablearticle_Annotations|[annotation EntityType](annotation.md)|objectid_msevtmgt_sponsorablearticle|  
|msevtmgt_sponsorablearticle_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msevtmgt_sponsorablearticle_appointment|  
|msevtmgt_sponsorablearticle_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msevtmgt_sponsorablearticle|  
|msevtmgt_sponsorablearticle_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msevtmgt_sponsorablearticle|  
|msevtmgt_sponsorablearticle_Emails|[email EntityType](email.md)|regardingobjectid_msevtmgt_sponsorablearticle_email|  
|msevtmgt_sponsorablearticle_Faxes|[fax EntityType](fax.md)|regardingobjectid_msevtmgt_sponsorablearticle_fax|  
|msevtmgt_sponsorablearticle_Letters|[letter EntityType](letter.md)|regardingobjectid_msevtmgt_sponsorablearticle_letter|  
|msevtmgt_sponsorablearticle_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msevtmgt_sponsorablearticle_msdyn_approval|  
|msevtmgt_sponsorablearticle_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msevtmgt_sponsorablearticle_msdyn_bookingalert|  
|msevtmgt_sponsorablearticle_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msevtmgt_sponsorablearticle_msdyn_surveyinvite|  
|msevtmgt_sponsorablearticle_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msevtmgt_sponsorablearticle_phonecall|  
|msevtmgt_sponsorablearticle_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msevtmgt_sponsorablearticle_recurringappointmentmaster|  
|msevtmgt_sponsorablearticle_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msevtmgt_sponsorablearticle_serviceappointment|  
|msevtmgt_sponsorablearticle_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msevtmgt_sponsorablearticle_socialactivity|  
|msevtmgt_sponsorablearticle_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msevtmgt_sponsorablearticle|  
|msevtmgt_sponsorablearticle_Tasks|[task EntityType](task.md)|regardingobjectid_msevtmgt_sponsorablearticle_task|  

## Operations
The following operations can be used with the msevtmgt_sponsorablearticle entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msevtmgt_sponsorablearticle entity type.


|Name|Description |  
|----|------------|  
|[Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicseventmanagementsolution.md](../solutions/descriptions/microsoftdynamicseventmanagementsolution.md)]|    

[!INCLUDE[./remarks/msevtmgt_sponsorablearticle.md](./remarks/msevtmgt_sponsorablearticle.md)]

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