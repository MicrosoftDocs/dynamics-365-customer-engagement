---
title: "msdyn_purchaseorder Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_purchaseorder entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_purchaseorder Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Record Purchase Orders pertaining to Work Orders or otherwise

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorders(*msdyn_purchaseorderid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_purchaseorders<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_purchaseorders(*msdyn_purchaseorderid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_purchaseorders(*msdyn_purchaseorderid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_purchaseorders<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorders(*msdyn_purchaseorderid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorders(*msdyn_purchaseorderid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Purchase Order<br />
**DisplayCollectionName**: Purchase Orders<br />
**SchemaName**: msdyn_purchaseorder<br />
**CollectionSchemaName**: msdyn_purchaseorders<br />
**LogicalName**: msdyn_purchaseorder<br />
**LogicalCollectionName**: msdyn_purchaseorders<br />
**EntitySetName**: msdyn_purchaseorders<br />
**PrimaryIdAttribute**: msdyn_purchaseorderid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Address1](#BKMK_msdyn_Address1)
- [msdyn_Address2](#BKMK_msdyn_Address2)
- [msdyn_Address3](#BKMK_msdyn_Address3)
- [msdyn_AddressName](#BKMK_msdyn_AddressName)
- [msdyn_AmountBilled](#BKMK_msdyn_AmountBilled)
- [msdyn_ApprovalStatus](#BKMK_msdyn_ApprovalStatus)
- [msdyn_ApprovedRejectedBy](#BKMK_msdyn_ApprovedRejectedBy)
- [msdyn_Booking](#BKMK_msdyn_Booking)
- [msdyn_City](#BKMK_msdyn_City)
- [msdyn_Country](#BKMK_msdyn_Country)
- [msdyn_DateExpected](#BKMK_msdyn_DateExpected)
- [msdyn_Latitude](#BKMK_msdyn_Latitude)
- [msdyn_Longitude](#BKMK_msdyn_Longitude)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_OrderedBy](#BKMK_msdyn_OrderedBy)
- [msdyn_PaymentTerm](#BKMK_msdyn_PaymentTerm)
- [msdyn_PODate](#BKMK_msdyn_PODate)
- [msdyn_PostalCode](#BKMK_msdyn_PostalCode)
- [msdyn_purchaseorderId](#BKMK_msdyn_purchaseorderId)
- [msdyn_ReceivetoWarehouse](#BKMK_msdyn_ReceivetoWarehouse)
- [msdyn_RequestedByResource](#BKMK_msdyn_RequestedByResource)
- [msdyn_ShipTo](#BKMK_msdyn_ShipTo)
- [msdyn_ShipVia](#BKMK_msdyn_ShipVia)
- [msdyn_StateOrProvince](#BKMK_msdyn_StateOrProvince)
- [msdyn_SubStatus](#BKMK_msdyn_SubStatus)
- [msdyn_SystemStatus](#BKMK_msdyn_SystemStatus)
- [msdyn_TotalAmount](#BKMK_msdyn_TotalAmount)
- [msdyn_Vendor](#BKMK_msdyn_Vendor)
- [msdyn_VendorNote](#BKMK_msdyn_VendorNote)
- [msdyn_WorkOrder](#BKMK_msdyn_WorkOrder)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [processid](#BKMK_processid)
- [stageid](#BKMK_stageid)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [traversedpath](#BKMK_traversedpath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Shows the sequence number of the import that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_msdyn_Address1"></a> msdyn_Address1

**Description**: <br />
**DisplayName**: Address1<br />
**LogicalName**: msdyn_address1<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_msdyn_Address2"></a> msdyn_Address2

**Description**: <br />
**DisplayName**: Address2<br />
**LogicalName**: msdyn_address2<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_msdyn_Address3"></a> msdyn_Address3

**Description**: <br />
**DisplayName**: Address3<br />
**LogicalName**: msdyn_address3<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_msdyn_AddressName"></a> msdyn_AddressName

**Description**: Enter the location to ship the products of this PO to.<br />
**DisplayName**: Address Name<br />
**LogicalName**: msdyn_addressname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_msdyn_AmountBilled"></a> msdyn_AmountBilled

**Description**: <br />
**DisplayName**: Amount Billed<br />
**LogicalName**: msdyn_amountbilled<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 900000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_ApprovalStatus"></a> msdyn_ApprovalStatus

**Description**: Enter the current status of the approval.<br />
**DisplayName**: Approval Status<br />
**LogicalName**: msdyn_approvalstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Approved
- **Value**: 690970001 **Label**: Rejected



### <a name="BKMK_msdyn_ApprovedRejectedBy"></a> msdyn_ApprovedRejectedBy

**Description**: The user who approved or rejected this PO<br />
**DisplayName**: Approved/Rejected By<br />
**LogicalName**: msdyn_approvedrejectedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_msdyn_Booking"></a> msdyn_Booking

**Description**: If purchase order is being ordered directly to a booking specify here. Note, when specified, by default all products will receive directly to booking.<br />
**DisplayName**: Booking<br />
**LogicalName**: msdyn_booking<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresourcebooking


### <a name="BKMK_msdyn_City"></a> msdyn_City

**Description**: <br />
**DisplayName**: City<br />
**LogicalName**: msdyn_city<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 80


### <a name="BKMK_msdyn_Country"></a> msdyn_Country

**Description**: <br />
**DisplayName**: Country/Region<br />
**LogicalName**: msdyn_country<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 80


### <a name="BKMK_msdyn_DateExpected"></a> msdyn_DateExpected

**Description**: Enter the date you expect to receive your order. Note that products added once the date is specified here will automatically be set to this date.<br />
**DisplayName**: Date Expected<br />
**LogicalName**: msdyn_dateexpected<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_Latitude"></a> msdyn_Latitude

**Description**: <br />
**DisplayName**: Latitude<br />
**LogicalName**: msdyn_latitude<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 90<br />
**MinValue**: -90<br />
**Precision**: 5


### <a name="BKMK_msdyn_Longitude"></a> msdyn_Longitude

**Description**: <br />
**DisplayName**: Longitude<br />
**LogicalName**: msdyn_longitude<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 180<br />
**MinValue**: -180<br />
**Precision**: 5


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Enter the name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_OrderedBy"></a> msdyn_OrderedBy

**Description**: Unique identifier for User associated with Purchase Order.<br />
**DisplayName**: Ordered By<br />
**LogicalName**: msdyn_orderedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_msdyn_PaymentTerm"></a> msdyn_PaymentTerm

**Description**: The payment terms for this PO<br />
**DisplayName**: Payment Term<br />
**LogicalName**: msdyn_paymentterm<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_paymentterm


### <a name="BKMK_msdyn_PODate"></a> msdyn_PODate

**Description**: Shows the date you submitted your order to the vendor. Note this field is for information only.<br />
**DisplayName**: Purchase Order Date<br />
**LogicalName**: msdyn_purchaseorderdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_PostalCode"></a> msdyn_PostalCode

**Description**: <br />
**DisplayName**: Postal Code<br />
**LogicalName**: msdyn_postalcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 20


### <a name="BKMK_msdyn_purchaseorderId"></a> msdyn_purchaseorderId

**Description**: Shows the entity instances.<br />
**DisplayName**: Purchase Order<br />
**LogicalName**: msdyn_purchaseorderid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_ReceivetoWarehouse"></a> msdyn_ReceivetoWarehouse

**Description**: Warehouse where products of this PO will be received to<br />
**DisplayName**: Receive to Warehouse<br />
**LogicalName**: msdyn_receivetowarehouse<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_warehouse


### <a name="BKMK_msdyn_RequestedByResource"></a> msdyn_RequestedByResource

**Description**: Resource that requested the purchase<br />
**DisplayName**: Requested By Resource<br />
**LogicalName**: msdyn_requestedbyresource<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresource


### <a name="BKMK_msdyn_ShipTo"></a> msdyn_ShipTo

**Description**: Enter the location to ship to. If the PO has been associated to a work order or a schedule, you can ship directly to the service account address.<br />
**DisplayName**: Ship To<br />
**LogicalName**: msdyn_shipto<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Site
- **Value**: 690970001 **Label**: Business Unit
- **Value**: 690970002 **Label**: Service Account
- **Value**: 690970003 **Label**: Other



### <a name="BKMK_msdyn_ShipVia"></a> msdyn_ShipVia

**Description**: Method of shipment by vendor<br />
**DisplayName**: Ship Via<br />
**LogicalName**: msdyn_shipvia<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_shipvia


### <a name="BKMK_msdyn_StateOrProvince"></a> msdyn_StateOrProvince

**Description**: <br />
**DisplayName**: State Or Province<br />
**LogicalName**: msdyn_stateorprovince<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_msdyn_SubStatus"></a> msdyn_SubStatus

**Description**: Purchase Order Sub Status<br />
**DisplayName**: Sub-Status<br />
**LogicalName**: msdyn_substatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_purchaseordersubstatus


### <a name="BKMK_msdyn_SystemStatus"></a> msdyn_SystemStatus

**Description**: Enter the current status of the purchase order.<br />
**DisplayName**: System Status<br />
**LogicalName**: msdyn_systemstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Draft
- **Value**: 690970001 **Label**: Submitted
- **Value**: 690970002 **Label**: Canceled
- **Value**: 690970003 **Label**: Products Received
- **Value**: 690970004 **Label**: Billed



### <a name="BKMK_msdyn_TotalAmount"></a> msdyn_TotalAmount

**Description**: <br />
**DisplayName**: Total Amount<br />
**LogicalName**: msdyn_totalamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_Vendor"></a> msdyn_Vendor

**Description**: Vendor you wish to purchase from<br />
**DisplayName**: Vendor<br />
**LogicalName**: msdyn_vendor<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_VendorNote"></a> msdyn_VendorNote

**Description**: If you wish to display a note for the vendor on this PO specify it here<br />
**DisplayName**: Vendor Note<br />
**LogicalName**: msdyn_vendornote<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

**Description**: If purchase order is being ordered directly to a work order specify here. Note, when specified, by default all products will receive directly to work order.<br />
**DisplayName**: Work Order<br />
**LogicalName**: msdyn_workorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_workorder


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Shows the date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Owner Id<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Owner Id Type<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_processid"></a> processid

**Description**: Contains the ID of the process associated with the entity.<br />
**DisplayName**: Process Id<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_stageid"></a> stageid

**Description**: Contains the ID of the stage where the entity is located.<br />
**DisplayName**: Stage Id<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Purchase Order<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 1 **InvariantName**: Active
- **Value**: 1 **Label**: Inactive **DefaultStatus**: 2 **InvariantName**: Inactive



### <a name="BKMK_statuscode"></a> statuscode

**Description**: Reason for the status of the Purchase Order<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Active **State**: 0
- **Value**: 2 **Label**: Inactive **State**: 1



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: Time Zone Rule Version Number<br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Unique identifier of the currency associated with the entity.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_traversedpath"></a> traversedpath

**Description**: Shows a comma-separated list of string values that represent the unique identifiers of stages in a business process flow instance in the order that they occur.<br />
**DisplayName**: Traversed Path<br />
**LogicalName**: traversedpath<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1250


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Shows the time zone code that was in use when the record was created.<br />
**DisplayName**: UTC Conversion Time Zone Code<br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_amountbilled_Base](#BKMK_msdyn_amountbilled_Base)
- [msdyn_ApprovedRejectedByName](#BKMK_msdyn_ApprovedRejectedByName)
- [msdyn_ApprovedRejectedByYomiName](#BKMK_msdyn_ApprovedRejectedByYomiName)
- [msdyn_BookingName](#BKMK_msdyn_BookingName)
- [msdyn_OrderedByName](#BKMK_msdyn_OrderedByName)
- [msdyn_OrderedByYomiName](#BKMK_msdyn_OrderedByYomiName)
- [msdyn_PaymentTermName](#BKMK_msdyn_PaymentTermName)
- [msdyn_ReceivetoWarehouseName](#BKMK_msdyn_ReceivetoWarehouseName)
- [msdyn_RequestedByResourceName](#BKMK_msdyn_RequestedByResourceName)
- [msdyn_ShipViaName](#BKMK_msdyn_ShipViaName)
- [msdyn_SubStatusName](#BKMK_msdyn_SubStatusName)
- [msdyn_totalamount_Base](#BKMK_msdyn_totalamount_Base)
- [msdyn_VendorName](#BKMK_msdyn_VendorName)
- [msdyn_VendorYomiName](#BKMK_msdyn_VendorYomiName)
- [msdyn_WorkOrderName](#BKMK_msdyn_WorkOrderName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Shows the exchange rate for the currency associated with the entity with respect to the base currency.<br />
**DisplayName**: Exchange Rate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who modified the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Shows who last updated the record on behalf of another user.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_amountbilled_Base"></a> msdyn_amountbilled_Base

**Description**: Shows the value of the amount billed in the base currency.<br />
**DisplayName**: Amount Billed (Base)<br />
**LogicalName**: msdyn_amountbilled_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_ApprovedRejectedByName"></a> msdyn_ApprovedRejectedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_approvedrejectedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_ApprovedRejectedByYomiName"></a> msdyn_ApprovedRejectedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_approvedrejectedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_BookingName"></a> msdyn_BookingName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_bookingname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_OrderedByName"></a> msdyn_OrderedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_orderedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_OrderedByYomiName"></a> msdyn_OrderedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_orderedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_PaymentTermName"></a> msdyn_PaymentTermName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_paymenttermname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ReceivetoWarehouseName"></a> msdyn_ReceivetoWarehouseName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_receivetowarehousename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_RequestedByResourceName"></a> msdyn_RequestedByResourceName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_requestedbyresourcename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ShipViaName"></a> msdyn_ShipViaName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_shipvianame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_SubStatusName"></a> msdyn_SubStatusName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_substatusname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_totalamount_Base"></a> msdyn_totalamount_Base

**Description**: Shows the value of the total amount in the base currency.<br />
**DisplayName**: Total Amount (Base)<br />
**LogicalName**: msdyn_totalamount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 1


### <a name="BKMK_msdyn_VendorName"></a> msdyn_VendorName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_vendorname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_VendorYomiName"></a> msdyn_VendorYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_vendoryominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_WorkOrderName"></a> msdyn_WorkOrderName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_workordername<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: Name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Description**: Yomi name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier for the business unit that owns the record<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier for the team that owns the record.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier for the user that owns the record.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: transactioncurrencyidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version Number<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [msdyn_purchaseorder_ActivityPointers](#BKMK_msdyn_purchaseorder_ActivityPointers)
- [msdyn_purchaseorder_msdyn_approvals](#BKMK_msdyn_purchaseorder_msdyn_approvals)
- [msdyn_purchaseorder_msdyn_bookingalerts](#BKMK_msdyn_purchaseorder_msdyn_bookingalerts)
- [msdyn_purchaseorder_SyncErrors](#BKMK_msdyn_purchaseorder_SyncErrors)
- [msdyn_purchaseorder_DuplicateMatchingRecord](#BKMK_msdyn_purchaseorder_DuplicateMatchingRecord)
- [msdyn_purchaseorder_DuplicateBaseRecord](#BKMK_msdyn_purchaseorder_DuplicateBaseRecord)
- [msdyn_purchaseorder_SharePointDocumentLocations](#BKMK_msdyn_purchaseorder_SharePointDocumentLocations)
- [msdyn_purchaseorder_SharePointDocuments](#BKMK_msdyn_purchaseorder_SharePointDocuments)
- [msdyn_purchaseorder_AsyncOperations](#BKMK_msdyn_purchaseorder_AsyncOperations)
- [msdyn_purchaseorder_MailboxTrackingFolders](#BKMK_msdyn_purchaseorder_MailboxTrackingFolders)
- [msdyn_purchaseorder_UserEntityInstanceDatas](#BKMK_msdyn_purchaseorder_UserEntityInstanceDatas)
- [msdyn_purchaseorder_ProcessSession](#BKMK_msdyn_purchaseorder_ProcessSession)
- [msdyn_purchaseorder_BulkDeleteFailures](#BKMK_msdyn_purchaseorder_BulkDeleteFailures)
- [msdyn_purchaseorder_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseorder_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseorder_Appointments](#BKMK_msdyn_purchaseorder_Appointments)
- [msdyn_purchaseorder_Emails](#BKMK_msdyn_purchaseorder_Emails)
- [msdyn_purchaseorder_Faxes](#BKMK_msdyn_purchaseorder_Faxes)
- [msdyn_purchaseorder_Letters](#BKMK_msdyn_purchaseorder_Letters)
- [msdyn_purchaseorder_PhoneCalls](#BKMK_msdyn_purchaseorder_PhoneCalls)
- [msdyn_purchaseorder_Tasks](#BKMK_msdyn_purchaseorder_Tasks)
- [msdyn_purchaseorder_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorder_RecurringAppointmentMasters)
- [msdyn_purchaseorder_SocialActivities](#BKMK_msdyn_purchaseorder_SocialActivities)
- [msdyn_purchaseorder_connections1](#BKMK_msdyn_purchaseorder_connections1)
- [msdyn_purchaseorder_connections2](#BKMK_msdyn_purchaseorder_connections2)
- [msdyn_purchaseorder_Annotations](#BKMK_msdyn_purchaseorder_Annotations)
- [msdyn_purchaseorder_ServiceAppointments](#BKMK_msdyn_purchaseorder_ServiceAppointments)
- [bpf_msdyn_purchaseorder_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799](#BKMK_bpf_msdyn_purchaseorder_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799)
- [msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder](#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder)
- [msdyn_msdyn_purchaseorder_msdyn_purchaseorderproduct_PurchaseOrder](#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderproduct_PurchaseOrder)
- [msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder](#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder)
- [msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder](#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder)
- [msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO](#BKMK_msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO)


### <a name="BKMK_msdyn_purchaseorder_ActivityPointers"></a> msdyn_purchaseorder_ActivityPointers

Same as activitypointer entity [msdyn_purchaseorder_ActivityPointers](activitypointer.md#BKMK_msdyn_purchaseorder_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_ActivityPointers<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_purchaseorder_msdyn_approvals"></a> msdyn_purchaseorder_msdyn_approvals

Same as msdyn_approval entity [msdyn_purchaseorder_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_purchaseorder_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_msdyn_approvals<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_purchaseorder_msdyn_bookingalerts"></a> msdyn_purchaseorder_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_purchaseorder_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_purchaseorder_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_msdyn_bookingalerts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_purchaseorder_SyncErrors"></a> msdyn_purchaseorder_SyncErrors

Same as syncerror entity [msdyn_purchaseorder_SyncErrors](syncerror.md#BKMK_msdyn_purchaseorder_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_purchaseorder_DuplicateMatchingRecord"></a> msdyn_purchaseorder_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_purchaseorder_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_purchaseorder_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_DuplicateMatchingRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_purchaseorder_DuplicateBaseRecord"></a> msdyn_purchaseorder_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_purchaseorder_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_purchaseorder_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_DuplicateBaseRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_purchaseorder_SharePointDocumentLocations"></a> msdyn_purchaseorder_SharePointDocumentLocations

Same as sharepointdocumentlocation entity [msdyn_purchaseorder_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_purchaseorder_SharePointDocumentLocations) Many-To-One relationship.

**ReferencingEntity**: sharepointdocumentlocation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_SharePointDocumentLocations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_purchaseorder_SharePointDocuments"></a> msdyn_purchaseorder_SharePointDocuments

Same as sharepointdocument entity [msdyn_purchaseorder_SharePointDocuments](sharepointdocument.md#BKMK_msdyn_purchaseorder_SharePointDocuments) Many-To-One relationship.

**ReferencingEntity**: sharepointdocument<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_SharePointDocuments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 60

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_purchaseorder_AsyncOperations"></a> msdyn_purchaseorder_AsyncOperations

Same as asyncoperation entity [msdyn_purchaseorder_AsyncOperations](asyncoperation.md#BKMK_msdyn_purchaseorder_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_purchaseorder_MailboxTrackingFolders"></a> msdyn_purchaseorder_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_purchaseorder_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_purchaseorder_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_MailboxTrackingFolders<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_purchaseorder_UserEntityInstanceDatas"></a> msdyn_purchaseorder_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_purchaseorder_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_purchaseorder_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_UserEntityInstanceDatas<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_purchaseorder_ProcessSession"></a> msdyn_purchaseorder_ProcessSession

Same as processsession entity [msdyn_purchaseorder_ProcessSession](processsession.md#BKMK_msdyn_purchaseorder_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_ProcessSession<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_purchaseorder_BulkDeleteFailures"></a> msdyn_purchaseorder_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_purchaseorder_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_purchaseorder_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_purchaseorder_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseorder_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_purchaseorder_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_purchaseorder_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_PrincipalObjectAttributeAccesses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_purchaseorder_Appointments"></a> msdyn_purchaseorder_Appointments

Same as appointment entity [msdyn_purchaseorder_Appointments](appointment.md#BKMK_msdyn_purchaseorder_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_Appointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_purchaseorder_Emails"></a> msdyn_purchaseorder_Emails

Same as email entity [msdyn_purchaseorder_Emails](email.md#BKMK_msdyn_purchaseorder_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_Emails<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_purchaseorder_Faxes"></a> msdyn_purchaseorder_Faxes

Same as fax entity [msdyn_purchaseorder_Faxes](fax.md#BKMK_msdyn_purchaseorder_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_Faxes<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_purchaseorder_Letters"></a> msdyn_purchaseorder_Letters

Same as letter entity [msdyn_purchaseorder_Letters](letter.md#BKMK_msdyn_purchaseorder_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_Letters<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_purchaseorder_PhoneCalls"></a> msdyn_purchaseorder_PhoneCalls

Same as phonecall entity [msdyn_purchaseorder_PhoneCalls](phonecall.md#BKMK_msdyn_purchaseorder_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_PhoneCalls<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_purchaseorder_Tasks"></a> msdyn_purchaseorder_Tasks

Same as task entity [msdyn_purchaseorder_Tasks](task.md#BKMK_msdyn_purchaseorder_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_Tasks<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_purchaseorder_RecurringAppointmentMasters"></a> msdyn_purchaseorder_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_purchaseorder_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_purchaseorder_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_RecurringAppointmentMasters<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_purchaseorder_SocialActivities"></a> msdyn_purchaseorder_SocialActivities

Same as socialactivity entity [msdyn_purchaseorder_SocialActivities](socialactivity.md#BKMK_msdyn_purchaseorder_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_SocialActivities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_purchaseorder_connections1"></a> msdyn_purchaseorder_connections1

Same as connection entity [msdyn_purchaseorder_connections1](connection.md#BKMK_msdyn_purchaseorder_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_connections1<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_purchaseorder_connections2"></a> msdyn_purchaseorder_connections2

Same as connection entity [msdyn_purchaseorder_connections2](connection.md#BKMK_msdyn_purchaseorder_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_connections2<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_purchaseorder_Annotations"></a> msdyn_purchaseorder_Annotations

Same as annotation entity [msdyn_purchaseorder_Annotations](annotation.md#BKMK_msdyn_purchaseorder_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_Annotations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_purchaseorder_ServiceAppointments"></a> msdyn_purchaseorder_ServiceAppointments

Same as serviceappointment entity [msdyn_purchaseorder_ServiceAppointments](serviceappointment.md#BKMK_msdyn_purchaseorder_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorder_ServiceAppointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bpf_msdyn_purchaseorder_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799"></a> bpf_msdyn_purchaseorder_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799

Same as msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 entity [bpf_msdyn_purchaseorder_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_bpf_msdyn_purchaseorder_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799) Many-To-One relationship.

**ReferencingEntity**: msdyn_bpf_2c5fe86acc8b414b8322ae571000c799<br />
**ReferencingAttribute**: bpf_msdyn_purchaseorderid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bpf_msdyn_purchaseorder_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: msdyn_purchaseorder
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder"></a> msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder

Same as msdyn_purchaseorderbill entity [msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder](msdyn_purchaseorderbill.md#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderbill<br />
**ReferencingAttribute**: msdyn_purchaseorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderproduct_PurchaseOrder"></a> msdyn_msdyn_purchaseorder_msdyn_purchaseorderproduct_PurchaseOrder

Same as msdyn_purchaseorderproduct entity [msdyn_msdyn_purchaseorder_msdyn_purchaseorderproduct_PurchaseOrder](msdyn_purchaseorderproduct.md#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderproduct_PurchaseOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderproduct<br />
**ReferencingAttribute**: msdyn_purchaseorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_purchaseorder_msdyn_purchaseorderproduct_PurchaseOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: Purchase Order
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder"></a> msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder

Same as msdyn_purchaseorderreceipt entity [msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder](msdyn_purchaseorderreceipt.md#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderreceipt<br />
**ReferencingAttribute**: msdyn_purchaseorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder"></a> msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder

Same as msdyn_purchaseorderreceiptproduct entity [msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderreceiptproduct<br />
**ReferencingAttribute**: msdyn_purchaseorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO"></a> msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO

Same as msdyn_rtv entity [msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO](msdyn_rtv.md#BKMK_msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtv<br />
**ReferencingAttribute**: msdyn_originalpurchaseorder<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Original Purchase Order
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_purchaseorder_createdby](#BKMK_lk_msdyn_purchaseorder_createdby)
- [lk_msdyn_purchaseorder_createdonbehalfby](#BKMK_lk_msdyn_purchaseorder_createdonbehalfby)
- [lk_msdyn_purchaseorder_modifiedby](#BKMK_lk_msdyn_purchaseorder_modifiedby)
- [lk_msdyn_purchaseorder_modifiedonbehalfby](#BKMK_lk_msdyn_purchaseorder_modifiedonbehalfby)
- [user_msdyn_purchaseorder](#BKMK_user_msdyn_purchaseorder)
- [team_msdyn_purchaseorder](#BKMK_team_msdyn_purchaseorder)
- [business_unit_msdyn_purchaseorder](#BKMK_business_unit_msdyn_purchaseorder)
- [processstage_msdyn_purchaseorder](#BKMK_processstage_msdyn_purchaseorder)
- [TransactionCurrency_msdyn_purchaseorder](#BKMK_TransactionCurrency_msdyn_purchaseorder)
- [msdyn_account_msdyn_purchaseorder_Vendor](#BKMK_msdyn_account_msdyn_purchaseorder_Vendor)
- [msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource](#BKMK_msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource)
- [msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking)
- [msdyn_msdyn_paymentterm_msdyn_purchaseorder_PaymentTerm](#BKMK_msdyn_msdyn_paymentterm_msdyn_purchaseorder_PaymentTerm)
- [msdyn_msdyn_purchaseordersubstatus_msdyn_purchaseorder_SubStatus](#BKMK_msdyn_msdyn_purchaseordersubstatus_msdyn_purchaseorder_SubStatus)
- [msdyn_msdyn_shipvia_msdyn_purchaseorder_ShipVia](#BKMK_msdyn_msdyn_shipvia_msdyn_purchaseorder_ShipVia)
- [msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse)
- [msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder)
- [msdyn_systemuser_msdyn_purchaseorder_ApprovedRejectedBy](#BKMK_msdyn_systemuser_msdyn_purchaseorder_ApprovedRejectedBy)
- [msdyn_systemuser_msdyn_purchaseorder_OrderedBy](#BKMK_msdyn_systemuser_msdyn_purchaseorder_OrderedBy)


### <a name="BKMK_lk_msdyn_purchaseorder_createdby"></a> lk_msdyn_purchaseorder_createdby

See systemuser Entity [lk_msdyn_purchaseorder_createdby](systemuser.md#BKMK_lk_msdyn_purchaseorder_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorder_createdonbehalfby"></a> lk_msdyn_purchaseorder_createdonbehalfby

See systemuser Entity [lk_msdyn_purchaseorder_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_purchaseorder_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorder_modifiedby"></a> lk_msdyn_purchaseorder_modifiedby

See systemuser Entity [lk_msdyn_purchaseorder_modifiedby](systemuser.md#BKMK_lk_msdyn_purchaseorder_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorder_modifiedonbehalfby"></a> lk_msdyn_purchaseorder_modifiedonbehalfby

See systemuser Entity [lk_msdyn_purchaseorder_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_purchaseorder_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_purchaseorder"></a> user_msdyn_purchaseorder

See systemuser Entity [user_msdyn_purchaseorder](systemuser.md#BKMK_user_msdyn_purchaseorder) One-To-Many relationship.

### <a name="BKMK_team_msdyn_purchaseorder"></a> team_msdyn_purchaseorder

See team Entity [team_msdyn_purchaseorder](team.md#BKMK_team_msdyn_purchaseorder) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_purchaseorder"></a> business_unit_msdyn_purchaseorder

See businessunit Entity [business_unit_msdyn_purchaseorder](businessunit.md#BKMK_business_unit_msdyn_purchaseorder) One-To-Many relationship.

### <a name="BKMK_processstage_msdyn_purchaseorder"></a> processstage_msdyn_purchaseorder

See processstage Entity [processstage_msdyn_purchaseorder](processstage.md#BKMK_processstage_msdyn_purchaseorder) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_purchaseorder"></a> TransactionCurrency_msdyn_purchaseorder

See transactioncurrency Entity [TransactionCurrency_msdyn_purchaseorder](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_purchaseorder) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_purchaseorder_Vendor"></a> msdyn_account_msdyn_purchaseorder_Vendor

See account Entity [msdyn_account_msdyn_purchaseorder_Vendor](account.md#BKMK_msdyn_account_msdyn_purchaseorder_Vendor) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource"></a> msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource

See bookableresource Entity [msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking"></a> msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking

See bookableresourcebooking Entity [msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking](bookableresourcebooking.md#BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_paymentterm_msdyn_purchaseorder_PaymentTerm"></a> msdyn_msdyn_paymentterm_msdyn_purchaseorder_PaymentTerm

See msdyn_paymentterm Entity [msdyn_msdyn_paymentterm_msdyn_purchaseorder_PaymentTerm](msdyn_paymentterm.md#BKMK_msdyn_msdyn_paymentterm_msdyn_purchaseorder_PaymentTerm) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_purchaseordersubstatus_msdyn_purchaseorder_SubStatus"></a> msdyn_msdyn_purchaseordersubstatus_msdyn_purchaseorder_SubStatus

See msdyn_purchaseordersubstatus Entity [msdyn_msdyn_purchaseordersubstatus_msdyn_purchaseorder_SubStatus](msdyn_purchaseordersubstatus.md#BKMK_msdyn_msdyn_purchaseordersubstatus_msdyn_purchaseorder_SubStatus) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_shipvia_msdyn_purchaseorder_ShipVia"></a> msdyn_msdyn_shipvia_msdyn_purchaseorder_ShipVia

See msdyn_shipvia Entity [msdyn_msdyn_shipvia_msdyn_purchaseorder_ShipVia](msdyn_shipvia.md#BKMK_msdyn_msdyn_shipvia_msdyn_purchaseorder_ShipVia) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse"></a> msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse

See msdyn_warehouse Entity [msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuser_msdyn_purchaseorder_ApprovedRejectedBy"></a> msdyn_systemuser_msdyn_purchaseorder_ApprovedRejectedBy

See systemuser Entity [msdyn_systemuser_msdyn_purchaseorder_ApprovedRejectedBy](systemuser.md#BKMK_msdyn_systemuser_msdyn_purchaseorder_ApprovedRejectedBy) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuser_msdyn_purchaseorder_OrderedBy"></a> msdyn_systemuser_msdyn_purchaseorder_OrderedBy

See systemuser Entity [msdyn_systemuser_msdyn_purchaseorder_OrderedBy](systemuser.md#BKMK_msdyn_systemuser_msdyn_purchaseorder_OrderedBy) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_purchaseorder?text=msdyn_purchaseorder EntityType" />