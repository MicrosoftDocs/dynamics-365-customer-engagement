---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_agreementbookingservice EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 245dab4e-0711-4865-b675-0986f8b22571
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_agreementbookingservice entitytype."
---
# msdyn_agreementbookingservice EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_agreementbookingservice.md](./descriptions/msdyn_agreementbookingservice.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_agreementbookingservices </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Agreement Booking Service</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_agreementbookingserviceid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_agreementbookingservice entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_agreementbookingserviceid|Edm.Guid|**Display Name**: Agreement Booking Service<br />**Description**: Shows the entity instances.<br />|
|msdyn_currency|Edm.Decimal|**Display Name**: Currency<br />|
|msdyn_currency_base|Edm.Decimal|**Display Name**: Currency (Base)<br />**Description**: Shows the value of the currency in the base currency.<br />Read-only<br />|
|msdyn_duration|Edm.Int32|**Display Name**: Duration<br />**Description**: Shows the actual duration of service.<br />|
|msdyn_durationtobill|Edm.Int32|**Display Name**: Duration To Bill<br />**Description**: Enter the duration you want to bill the customer for. By default, this will default to the same value as the "Duration" field.<br />|
|msdyn_iscopied|Edm.Boolean|**Display Name**: Is Copied<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_lineorder|Edm.Int32|**Display Name**: Line Order<br />**Description**: Shows the order of this service within the agreement services.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the custom entity.<br />|
|msdyn_unitamount|Edm.Decimal|**Display Name**: Unit Amount<br />**Description**: Enter the amount you wish to charge the customer per unit. This field is optional.<br />|
|msdyn_unitamount_base|Edm.Decimal|**Display Name**: Unit Amount (Base)<br />**Description**: Shows the value of the unit amount in the base currency.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Agreement Booking Service<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Agreement Booking Service<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_msdyn_agreement_value|msdyn_agreement<br />|Unique identifier for Agreement associated with Agreement Booking Service.|
|_msdyn_agreementbookingincident_value|msdyn_agreementbookingincident<br />|The Agreement Booking Incident related to this service|
|_msdyn_agreementbookingsetup_value|msdyn_agreementbookingsetup<br />|Unique identifier for Agreement Booking Setup associated with Agreement Booking Service.|
|_msdyn_customerasset_value|msdyn_customerasset<br />|Customer Asset related to this Service|
|_msdyn_pricelist_value|msdyn_pricelist<br />|Optionally set Price List that will determine the pricing for this service on the Work Order|
|_msdyn_service_value|msdyn_service<br />|Unique identifier for Product/Service associated with Agreement Booking Service.|
|_msdyn_unit_value|msdyn_unit<br />|The unit that determines the pricing for this service when Price List is set|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_agreementbookingservice_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_agreementbookingservice_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_agreementbookingservice_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_agreementbookingservice_modifiedonbehalfby|
|msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement|
|msdyn_agreementbookingincident|[msdyn_agreementbookingincident EntityType](msdyn_agreementbookingincident.md)|msdyn_msdyn_agreementbookingincident_msdyn_agreementbookingservice_AgreementBookingIncident|
|msdyn_agreementbookingsetup|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup|
|msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset|
|msdyn_pricelist|[pricelevel EntityType](pricelevel.md)|msdyn_pricelevel_msdyn_agreementbookingservice_PriceList|
|msdyn_service|[product EntityType](product.md)|msdyn_product_msdyn_agreementbookingservice_Service|
|msdyn_unit|[uom EntityType](uom.md)|msdyn_uom_msdyn_agreementbookingservice_Unit|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_agreementbookingservice|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_agreementbookingservice|
|owningteam|[team EntityType](team.md)|team_msdyn_agreementbookingservice|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_agreementbookingservice|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_agreementbookingservice|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_agreementbookingservice_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_agreementbookingservice|  
|msdyn_agreementbookingservice_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_agreementbookingservice_adx_alertsubscription|  
|msdyn_agreementbookingservice_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_agreementbookingservice_adx_inviteredemption|  
|msdyn_agreementbookingservice_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_agreementbookingservice_adx_portalcomment|  
|msdyn_agreementbookingservice_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_agreementbookingservice|  
|msdyn_agreementbookingservice_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_agreementbookingservice_appointment|  
|msdyn_agreementbookingservice_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_agreementbookingservice|  
|msdyn_agreementbookingservice_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_agreementbookingservice|  
|msdyn_agreementbookingservice_connections1|[connection EntityType](connection.md)|record1id_msdyn_agreementbookingservice|  
|msdyn_agreementbookingservice_connections2|[connection EntityType](connection.md)|record2id_msdyn_agreementbookingservice|  
|msdyn_agreementbookingservice_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_agreementbookingservice|  
|msdyn_agreementbookingservice_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_agreementbookingservice|  
|msdyn_agreementbookingservice_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_agreementbookingservice_email|  
|msdyn_agreementbookingservice_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_agreementbookingservice_fax|  
|msdyn_agreementbookingservice_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_agreementbookingservice_letter|  
|msdyn_agreementbookingservice_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_agreementbookingservice_msdyn_approval|  
|msdyn_agreementbookingservice_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_agreementbookingservice_msdyn_bookingalert|  
|msdyn_agreementbookingservice_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_agreementbookingservice_msdyn_surveyinvite|  
|msdyn_agreementbookingservice_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_agreementbookingservice_phonecall|  
|msdyn_agreementbookingservice_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_agreementbookingservice_recurringappointmentmaster|  
|msdyn_agreementbookingservice_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_agreementbookingservice_serviceappointment|  
|msdyn_agreementbookingservice_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_agreementbookingservice_socialactivity|  
|msdyn_agreementbookingservice_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_agreementbookingservice|  
|msdyn_agreementbookingservice_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_agreementbookingservice_task|  
|msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_agreementbookingservice|  

## Operations
The following operations can be used with the msdyn_agreementbookingservice entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_agreementbookingservice entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_agreementbookingservice.md](./remarks/msdyn_agreementbookingservice.md)]

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