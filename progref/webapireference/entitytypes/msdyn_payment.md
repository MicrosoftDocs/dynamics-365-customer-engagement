---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_payment EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d38e16a9-8351-4484-9926-bb76440909bf
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_payment entitytype."
---
# msdyn_payment EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_payment.md](./descriptions/msdyn_payment.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_payments </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Payment</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_paymentid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_payment entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_amount|Edm.Decimal|**Display Name**: Amount<br />|
|msdyn_amount_base|Edm.Decimal|**Display Name**: Amount (Base)<br />**Description**: Shows the value of the amount in the base currency.<br />Read-only<br />|
|msdyn_checknumber|Edm.String|**Display Name**: Check Number<br />|
|msdyn_date|Edm.DateTimeOffset|**Display Name**: Date<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the custom entity.<br />|
|msdyn_paymentid|Edm.Guid|**Display Name**: Payment<br />**Description**: Shows the entity instances.<br />|
|msdyn_paymenttype|Edm.Int32|**Display Name**: Payment Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Cash</td></tr><tr><td>690970001</td><td>Check</td></tr><tr><td>690970002</td><td>Credit Card</td></tr><tr><td>690970003</td><td>Other</td></tr><tbody></table>|
|msdyn_unappliedamount|Edm.Decimal|**Display Name**: Unapplied Amount<br />|
|msdyn_unappliedamount_base|Edm.Decimal|**Display Name**: Unapplied Amount (Base)<br />**Description**: Shows the value of the unapplied amount in the base currency.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Payment<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Payment<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_account_value|msdyn_account<br />|Unique identifier for Account associated with Payment.|
|_msdyn_paymentmethod_value|msdyn_paymentmethod<br />|Unique identifier for Payment Method associated with Payment.|
|_msdyn_workorder_value|msdyn_workorder<br />|Unique identifier for Work Order associated with Payment.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_payment_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_payment_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_payment_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_payment_modifiedonbehalfby|
|msdyn_account|[account EntityType](account.md)|msdyn_account_msdyn_payment_Account|
|msdyn_paymentmethod|[msdyn_paymentmethod EntityType](msdyn_paymentmethod.md)|msdyn_msdyn_paymentmethod_msdyn_payment_PaymentMethod|
|msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_msdyn_workorder_msdyn_payment_WorkOrder|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_payment|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_payment|
|owningteam|[team EntityType](team.md)|team_msdyn_payment|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_payment|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_payment|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_payment_msdyn_paymentdetail_Payment|[msdyn_paymentdetail EntityType](msdyn_paymentdetail.md)|msdyn_payment|  
|msdyn_payment_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_payment|  
|msdyn_payment_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_payment_adx_alertsubscription|  
|msdyn_payment_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_payment_adx_inviteredemption|  
|msdyn_payment_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_payment_adx_portalcomment|  
|msdyn_payment_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_payment|  
|msdyn_payment_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_payment_appointment|  
|msdyn_payment_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_payment|  
|msdyn_payment_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_payment|  
|msdyn_payment_connections1|[connection EntityType](connection.md)|record1id_msdyn_payment|  
|msdyn_payment_connections2|[connection EntityType](connection.md)|record2id_msdyn_payment|  
|msdyn_payment_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_payment|  
|msdyn_payment_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_payment|  
|msdyn_payment_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_payment_email|  
|msdyn_payment_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_payment_fax|  
|msdyn_payment_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_payment_letter|  
|msdyn_payment_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_payment_msdyn_approval|  
|msdyn_payment_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_payment_msdyn_bookingalert|  
|msdyn_payment_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_payment_msdyn_surveyinvite|  
|msdyn_payment_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_payment_phonecall|  
|msdyn_payment_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_payment_recurringappointmentmaster|  
|msdyn_payment_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_payment_serviceappointment|  
|msdyn_payment_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_payment_socialactivity|  
|msdyn_payment_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_payment|  
|msdyn_payment_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_payment_task|  

## Operations
The following operations can be used with the msdyn_payment entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_payment entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_payment.md](./remarks/msdyn_payment.md)]

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