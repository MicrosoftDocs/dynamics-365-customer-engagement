---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_purchaseorder EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 0d3baf6c-925d-4762-b302-cd38fd9ce1f3
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_purchaseorder entitytype."
---
# msdyn_purchaseorder EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_purchaseorder.md](./descriptions/msdyn_purchaseorder.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_purchaseorders </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Purchase Order</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_purchaseorderid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_purchaseorder entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_address1|Edm.String|**Display Name**: Address1<br />|
|msdyn_address2|Edm.String|**Display Name**: Address2<br />|
|msdyn_address3|Edm.String|**Display Name**: Address3<br />|
|msdyn_addressname|Edm.String|**Display Name**: Address Name<br />**Description**: Enter the location to ship the products of this PO to.<br />|
|msdyn_amountbilled|Edm.Decimal|**Display Name**: Amount Billed<br />|
|msdyn_amountbilled_base|Edm.Decimal|**Display Name**: Amount Billed (Base)<br />**Description**: Shows the value of the amount billed in the base currency.<br />Read-only<br />|
|msdyn_approvalstatus|Edm.Int32|**Display Name**: Approval Status<br />**Description**: Enter the current status of the approval.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Approved</td></tr><tr><td>690970001</td><td>Rejected</td></tr><tbody></table>|
|msdyn_city|Edm.String|**Display Name**: City<br />|
|msdyn_country|Edm.String|**Display Name**: Country/Region<br />|
|msdyn_dateexpected|Edm.DateTimeOffset|**Display Name**: Date Expected<br />**Description**: Enter the date you expect to receive your order. Note that products added once the date is specified here will automatically be set to this date.<br />|
|msdyn_latitude|Edm.Double|**Display Name**: Latitude<br />|
|msdyn_longitude|Edm.Double|**Display Name**: Longitude<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the custom entity.<br />|
|msdyn_postalcode|Edm.String|**Display Name**: Postal Code<br />|
|msdyn_purchaseorderdate|Edm.DateTimeOffset|**Display Name**: Purchase Order Date<br />**Description**: Shows the date you submitted your order to the vendor. Note this field is for information only.<br />|
|msdyn_purchaseorderid|Edm.Guid|**Display Name**: Purchase Order<br />**Description**: Shows the entity instances.<br />|
|msdyn_shipto|Edm.Int32|**Display Name**: Ship To<br />**Description**: Enter the location to ship to. If the PO has been associated to a work order or a schedule, you can ship directly to the service account address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Site</td></tr><tr><td>690970001</td><td>Business Unit</td></tr><tr><td>690970002</td><td>Service Account</td></tr><tr><td>690970003</td><td>Other</td></tr><tbody></table>|
|msdyn_stateorprovince|Edm.String|**Display Name**: State Or Province<br />|
|msdyn_systemstatus|Edm.Int32|**Display Name**: System Status<br />**Description**: Enter the current status of the purchase order.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Draft</td></tr><tr><td>690970001</td><td>Submitted</td></tr><tr><td>690970002</td><td>Canceled</td></tr><tr><td>690970003</td><td>Products Received</td></tr><tr><td>690970004</td><td>Billed</td></tr><tbody></table>|
|msdyn_totalamount|Edm.Decimal|**Display Name**: Total Amount<br />|
|msdyn_totalamount_base|Edm.Decimal|**Display Name**: Total Amount (Base)<br />**Description**: Shows the value of the total amount in the base currency.<br />Read-only<br />|
|msdyn_vendornote|Edm.String|**Display Name**: Vendor Note<br />**Description**: If you wish to display a note for the vendor on this PO specify it here<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the ID of the process associated with the entity.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Purchase Order<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Purchase Order<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: Shows a comma-separated list of string values that represent the unique identifiers of stages in a business process flow instance in the order that they occur.<br />|
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
|_msdyn_approvedrejectedby_value|msdyn_approvedrejectedby<br />|The user who approved or rejected this PO|
|_msdyn_booking_value|msdyn_booking<br />|If purchase order is being ordered directly to a booking specify here. Note, when specified, by default all products will receive directly to booking.|
|_msdyn_orderedby_value|msdyn_orderedby<br />|Unique identifier for User associated with Purchase Order.|
|_msdyn_paymentterm_value|msdyn_paymentterm<br />|The payment terms for this PO|
|_msdyn_receivetowarehouse_value|msdyn_receivetowarehouse<br />|Warehouse where products of this PO will be received to|
|_msdyn_requestedbyresource_value|msdyn_requestedbyresource<br />|Resource that requested the purchase|
|_msdyn_shipvia_value|msdyn_shipvia<br />|Method of shipment by vendor|
|_msdyn_substatus_value|msdyn_substatus<br />|Purchase Order Sub Status|
|_msdyn_vendor_value|msdyn_vendor<br />|Vendor you wish to purchase from|
|_msdyn_workorder_value|msdyn_workorder<br />|If purchase order is being ordered directly to a work order specify here. Note, when specified, by default all products will receive directly to work order.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_stageid_value|stageid<br />|Contains the ID of the stage where the entity is located.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_purchaseorder_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_purchaseorder_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_purchaseorder_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_purchaseorder_modifiedonbehalfby|
|msdyn_approvedrejectedby|[systemuser EntityType](systemuser.md)|msdyn_systemuser_msdyn_purchaseorder_ApprovedRejectedBy|
|msdyn_booking|[bookableresourcebooking EntityType](bookableresourcebooking.md)|msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking|
|msdyn_orderedby|[systemuser EntityType](systemuser.md)|msdyn_systemuser_msdyn_purchaseorder_OrderedBy|
|msdyn_paymentterm|[msdyn_paymentterm EntityType](msdyn_paymentterm.md)|msdyn_msdyn_paymentterm_msdyn_purchaseorder_PaymentTerm|
|msdyn_receivetowarehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse|
|msdyn_requestedbyresource|[bookableresource EntityType](bookableresource.md)|msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource|
|msdyn_shipvia|[msdyn_shipvia EntityType](msdyn_shipvia.md)|msdyn_msdyn_shipvia_msdyn_purchaseorder_ShipVia|
|msdyn_substatus|[msdyn_purchaseordersubstatus EntityType](msdyn_purchaseordersubstatus.md)|msdyn_msdyn_purchaseordersubstatus_msdyn_purchaseorder_SubStatus|
|msdyn_vendor|[account EntityType](account.md)|msdyn_account_msdyn_purchaseorder_Vendor|
|msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_purchaseorder|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_purchaseorder|
|owningteam|[team EntityType](team.md)|team_msdyn_purchaseorder|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_purchaseorder|
|stageid|[processstage EntityType](processstage.md)|processstage_msdyn_purchaseorder|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_purchaseorder|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder|[msdyn_purchaseorderbill EntityType](msdyn_purchaseorderbill.md)|msdyn_purchaseorder|  
|msdyn_msdyn_purchaseorder_msdyn_purchaseorderproduct_PurchaseOrder|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|msdyn_purchaseorder|  
|msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder|[msdyn_purchaseorderreceipt EntityType](msdyn_purchaseorderreceipt.md)|msdyn_purchaseorder|  
|msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|msdyn_purchaseorder|  
|msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_originalpurchaseorder|  
|msdyn_purchaseorder_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_purchaseorder|  
|msdyn_purchaseorder_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_purchaseorder_adx_alertsubscription|  
|msdyn_purchaseorder_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_purchaseorder_adx_inviteredemption|  
|msdyn_purchaseorder_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_purchaseorder_adx_portalcomment|  
|msdyn_purchaseorder_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_purchaseorder|  
|msdyn_purchaseorder_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_purchaseorder_appointment|  
|msdyn_purchaseorder_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_purchaseorder|  
|msdyn_purchaseorder_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_purchaseorder|  
|msdyn_purchaseorder_connections1|[connection EntityType](connection.md)|record1id_msdyn_purchaseorder|  
|msdyn_purchaseorder_connections2|[connection EntityType](connection.md)|record2id_msdyn_purchaseorder|  
|msdyn_purchaseorder_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_purchaseorder|  
|msdyn_purchaseorder_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_purchaseorder|  
|msdyn_purchaseorder_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_purchaseorder_email|  
|msdyn_purchaseorder_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_purchaseorder_fax|  
|msdyn_purchaseorder_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_purchaseorder_letter|  
|msdyn_purchaseorder_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_purchaseorder_msdyn_approval|  
|msdyn_purchaseorder_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_purchaseorder_msdyn_bookingalert|  
|msdyn_purchaseorder_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_purchaseorder_msdyn_surveyinvite|  
|msdyn_purchaseorder_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_purchaseorder_phonecall|  
|msdyn_purchaseorder_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_purchaseorder_recurringappointmentmaster|  
|msdyn_purchaseorder_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_purchaseorder_serviceappointment|  
|msdyn_purchaseorder_SharePointDocumentLocations|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_msdyn_purchaseorder|  
|msdyn_purchaseorder_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_purchaseorder_socialactivity|  
|msdyn_purchaseorder_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_purchaseorder|  
|msdyn_purchaseorder_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_purchaseorder_task|  

## Operations
The following operations can be used with the msdyn_purchaseorder entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_purchaseorder entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_purchaseorder.md](./remarks/msdyn_purchaseorder.md)]

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