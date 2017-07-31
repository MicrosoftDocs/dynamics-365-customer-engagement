---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_rma EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 39a665c0-5ece-4d07-aa96-bcd0db76954b
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_rma entitytype."
---
# msdyn_rma EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_rma.md](./descriptions/msdyn_rma.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_rmas </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>RMA</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_rmaid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_rma entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_daterequested|Edm.DateTimeOffset|**Display Name**: Date Requested<br />**Description**: Enter the date RMA was requested by the customer.<br />|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Enter a short description of the RMA.<br />|
|msdyn_eta|Edm.DateTimeOffset|**Display Name**: ETA<br />**Description**: ETA<br />|
|msdyn_name|Edm.String|**Display Name**: RMA Number<br />**Description**: Shows the unique number identifying this RMA record.<br />|
|msdyn_packagingtrackingno|Edm.String|**Display Name**: Packaging Tracking No<br />**Description**: Shows the tracking number of package<br />|
|msdyn_processingaction|Edm.Int32|**Display Name**: Processing Action<br />**Description**: Shows the default action to be taken on all RMA Products.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Create RTV</td></tr><tr><td>690970001</td><td>Return to Warehouse</td></tr><tr><td>690970002</td><td>Change Asset Ownership</td></tr><tbody></table>|
|msdyn_referenceno|Edm.String|**Display Name**: Reference No<br />|
|msdyn_rmaid|Edm.Guid|**Display Name**: RMA<br />**Description**: Shows the entity instances.<br />|
|msdyn_shippingtrackingno|Edm.String|**Display Name**: Shipping Tracking No<br />**Description**: Shows the tracking number of the shipment.<br />|
|msdyn_systemstatus|Edm.Int32|**Display Name**: System Status<br />**Description**: Enter the current status of the RMA.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Pending</td></tr><tr><td>690970001</td><td>Canceled</td></tr><tr><td>690970002</td><td>Products Received</td></tr><tbody></table>|
|msdyn_taxable|Edm.Boolean|**Display Name**: Taxable<br />**Description**: Specify if RMA is taxable<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_totalamount|Edm.Decimal|**Display Name**: Total Amount<br />**Description**: Shows the total amount of all RMA Products including tax.<br />|
|msdyn_totalamount_base|Edm.Decimal|**Display Name**: Total Amount (Base)<br />**Description**: Shows the value of the total amount in the base currency.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the RMA<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the RMA<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_approvedby_value|msdyn_approvedby<br />|User who approved RMA|
|_msdyn_billingaccount_value|msdyn_billingaccount<br />|Account to be billed. If a billing account has been set on service account it will be populated by default. Otherwise, the billing account will be the same as the service account.|
|_msdyn_pricelist_value|msdyn_pricelist<br />|Price List that determines the pricing for this product|
|_msdyn_requestedbycontact_value|msdyn_requestedbycontact<br />|Contact who requested this return|
|_msdyn_serviceaccount_value|msdyn_serviceaccount<br />|Account to be serviced|
|_msdyn_shipvia_value|msdyn_shipvia<br />|Method of shipment by Customer|
|_msdyn_substatus_value|msdyn_substatus<br />|RMA Sub-Status|
|_msdyn_taxcode_value|msdyn_taxcode<br />|Tax Code to be used to calculate tax when RMA is taxable. By default the system will use the tax code specified on the service account|
|_msdyn_workorder_value|msdyn_workorder<br />|Work Order this RMA is linked to|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_rma_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_rma_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_rma_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_rma_modifiedonbehalfby|
|msdyn_approvedby|[systemuser EntityType](systemuser.md)|msdyn_systemuser_msdyn_rma_ApprovedBy|
|msdyn_billingaccount|[account EntityType](account.md)|msdyn_account_msdyn_rma_BillingAccount|
|msdyn_pricelist|[pricelevel EntityType](pricelevel.md)|msdyn_pricelevel_msdyn_rma_PriceList|
|msdyn_requestedbycontact|[contact EntityType](contact.md)|msdyn_contact_msdyn_rma_RequestedByContact|
|msdyn_serviceaccount|[account EntityType](account.md)|msdyn_account_msdyn_rma_ServiceAccount|
|msdyn_shipvia|[msdyn_shipvia EntityType](msdyn_shipvia.md)|msdyn_msdyn_shipvia_msdyn_rma_ShipVia|
|msdyn_substatus|[msdyn_rmasubstatus EntityType](msdyn_rmasubstatus.md)|msdyn_msdyn_rmasubstatus_msdyn_rma_SubStatus|
|msdyn_taxcode|[msdyn_taxcode EntityType](msdyn_taxcode.md)|msdyn_msdyn_taxcode_msdyn_rma_TaxCode|
|msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_msdyn_workorder_msdyn_rma_WorkOrder|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_rma|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_rma|
|owningteam|[team EntityType](team.md)|team_msdyn_rma|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_rma|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_rma|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_rma_msdyn_rmaproduct_RMA|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|msdyn_rma|  
|msdyn_msdyn_rma_msdyn_rmareceipt_RMA|[msdyn_rmareceipt EntityType](msdyn_rmareceipt.md)|msdyn_rma|  
|msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|msdyn_rma|  
|msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_originatingrma|  
|msdyn_msdyn_rma_msdyn_rtvproduct_RMA|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|msdyn_rma|  
|msdyn_rma_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_rma|  
|msdyn_rma_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_rma_adx_alertsubscription|  
|msdyn_rma_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_rma_adx_inviteredemption|  
|msdyn_rma_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_rma_adx_portalcomment|  
|msdyn_rma_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_rma|  
|msdyn_rma_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_rma_appointment|  
|msdyn_rma_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_rma|  
|msdyn_rma_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_rma|  
|msdyn_rma_connections1|[connection EntityType](connection.md)|record1id_msdyn_rma|  
|msdyn_rma_connections2|[connection EntityType](connection.md)|record2id_msdyn_rma|  
|msdyn_rma_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_rma|  
|msdyn_rma_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_rma|  
|msdyn_rma_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_rma_email|  
|msdyn_rma_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_rma_fax|  
|msdyn_rma_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_rma_letter|  
|msdyn_rma_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_rma_msdyn_approval|  
|msdyn_rma_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_rma_msdyn_bookingalert|  
|msdyn_rma_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_rma_msdyn_surveyinvite|  
|msdyn_rma_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_rma_phonecall|  
|msdyn_rma_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_rma_recurringappointmentmaster|  
|msdyn_rma_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_rma_serviceappointment|  
|msdyn_rma_SharePointDocumentLocations|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_msdyn_rma|  
|msdyn_rma_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_rma_socialactivity|  
|msdyn_rma_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_rma|  
|msdyn_rma_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_rma_task|  

## Operations
The following operations can be used with the msdyn_rma entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_rma entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_rma.md](./remarks/msdyn_rma.md)]

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