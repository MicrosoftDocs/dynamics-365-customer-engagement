---
title: "msdyn_purchaseorder Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_purchaseorder entity."
ms.date: 04/02/2019
ms.service: "crm-online"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
manager: "annbe"
search.audienceType: 
  - developer

---
# msdyn_purchaseorder Entity Reference

Record Purchase Orders pertaining to Work Orders or otherwise

**Added by**: Field Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorders(*msdyn_purchaseorderid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_purchaseorders<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_purchaseorders(*msdyn_purchaseorderid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_purchaseorders(*msdyn_purchaseorderid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_purchaseorders<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorders(*msdyn_purchaseorderid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorders(*msdyn_purchaseorderid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_purchaseorders|
|DisplayCollectionName|Purchase Orders|
|DisplayName|Purchase Order|
|EntitySetName|msdyn_purchaseorders|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_purchaseorders|
|LogicalName|msdyn_purchaseorder|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_purchaseorderid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_purchaseorder|

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
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
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

|Property|Value|
|--------|-----|
|Description|Shows the sequence number of the import that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_Address1"></a> msdyn_Address1

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Street 1|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_address1|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_Address2"></a> msdyn_Address2

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Street 2|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_address2|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_Address3"></a> msdyn_Address3

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Street 3|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_address3|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_AddressName"></a> msdyn_AddressName

|Property|Value|
|--------|-----|
|Description|Enter the location to ship the products of this PO to.|
|DisplayName|Address Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_addressname|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_AmountBilled"></a> msdyn_AmountBilled

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Amount Billed|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_amountbilled|
|MaxValue|900000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_ApprovalStatus"></a> msdyn_ApprovalStatus

|Property|Value|
|--------|-----|
|Description|Enter the current status of the approval.|
|DisplayName|Approval Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_approvalstatus|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_ApprovalStatus Options

|Value|Label|
|-----|-----|
|690970000|Approved|
|690970001|Rejected|



### <a name="BKMK_msdyn_ApprovedRejectedBy"></a> msdyn_ApprovedRejectedBy

|Property|Value|
|--------|-----|
|Description|The user who approved or rejected this PO|
|DisplayName|Approved/Rejected By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_approvedrejectedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_msdyn_Booking"></a> msdyn_Booking

|Property|Value|
|--------|-----|
|Description|If purchase order is being ordered directly to a booking specify here. Note, when specified, by default all products will receive directly to booking.|
|DisplayName|Booking|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_booking|
|RequiredLevel|None|
|Targets|bookableresourcebooking|
|Type|Lookup|


### <a name="BKMK_msdyn_City"></a> msdyn_City

|Property|Value|
|--------|-----|
|Description||
|DisplayName|City|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_city|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_Country"></a> msdyn_Country

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Country/Region|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_country|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DateExpected"></a> msdyn_DateExpected

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date you expect to receive your order. Note that products added once the date is specified here will automatically be set to this date.|
|DisplayName|Date Expected|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_dateexpected|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Internal Flags|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_internalflags|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_Latitude"></a> msdyn_Latitude

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Latitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_latitude|
|MaxValue|90|
|MinValue|-90|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_Longitude"></a> msdyn_Longitude

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Longitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_longitude|
|MaxValue|180|
|MinValue|-180|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Enter the name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_OrderedBy"></a> msdyn_OrderedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier for User associated with Purchase Order.|
|DisplayName|Ordered By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_orderedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_msdyn_PaymentTerm"></a> msdyn_PaymentTerm

|Property|Value|
|--------|-----|
|Description|The payment terms for this PO|
|DisplayName|Payment Term|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_paymentterm|
|RequiredLevel|None|
|Targets|msdyn_paymentterm|
|Type|Lookup|


### <a name="BKMK_msdyn_PODate"></a> msdyn_PODate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date you submitted your order to the vendor. Note this field is for information only.|
|DisplayName|Purchase Order Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_purchaseorderdate|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|


### <a name="BKMK_msdyn_PostalCode"></a> msdyn_PostalCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Postal Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_postalcode|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_purchaseorderId"></a> msdyn_purchaseorderId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Purchase Order|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_purchaseorderid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_ReceivetoWarehouse"></a> msdyn_ReceivetoWarehouse

|Property|Value|
|--------|-----|
|Description|Warehouse where products of this PO will be received to|
|DisplayName|Receive to Warehouse|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_receivetowarehouse|
|RequiredLevel|None|
|Targets|msdyn_warehouse|
|Type|Lookup|


### <a name="BKMK_msdyn_RequestedByResource"></a> msdyn_RequestedByResource

|Property|Value|
|--------|-----|
|Description|Resource that requested the purchase|
|DisplayName|Requested By Resource|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_requestedbyresource|
|RequiredLevel|None|
|Targets|bookableresource|
|Type|Lookup|


### <a name="BKMK_msdyn_ShipTo"></a> msdyn_ShipTo

|Property|Value|
|--------|-----|
|Description|Enter the location to ship to. If the PO has been associated to a work order or a schedule, you can ship directly to the service account address.|
|DisplayName|Ship To|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_shipto|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_ShipTo Options

|Value|Label|
|-----|-----|
|690970000|Site|
|690970001|Business Unit|
|690970002|Service Account|
|690970003|Other|



### <a name="BKMK_msdyn_ShipVia"></a> msdyn_ShipVia

|Property|Value|
|--------|-----|
|Description|Method of shipment by vendor|
|DisplayName|Ship Via|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_shipvia|
|RequiredLevel|None|
|Targets|msdyn_shipvia|
|Type|Lookup|


### <a name="BKMK_msdyn_StateOrProvince"></a> msdyn_StateOrProvince

|Property|Value|
|--------|-----|
|Description||
|DisplayName|State Or Province|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_stateorprovince|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SubStatus"></a> msdyn_SubStatus

|Property|Value|
|--------|-----|
|Description|Purchase Order Substatus|
|DisplayName|Substatus|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_substatus|
|RequiredLevel|None|
|Targets|msdyn_purchaseordersubstatus|
|Type|Lookup|


### <a name="BKMK_msdyn_SystemStatus"></a> msdyn_SystemStatus

|Property|Value|
|--------|-----|
|Description|Enter the current status of the purchase order.|
|DisplayName|System Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_systemstatus|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_SystemStatus Options

|Value|Label|
|-----|-----|
|690970000|Draft|
|690970001|Submitted|
|690970002|Canceled|
|690970003|Products Received|
|690970004|Billed|



### <a name="BKMK_msdyn_TotalAmount"></a> msdyn_TotalAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Total Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalamount|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_Vendor"></a> msdyn_Vendor

|Property|Value|
|--------|-----|
|Description|Vendor you wish to purchase from|
|DisplayName|Vendor|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_vendor|
|RequiredLevel|ApplicationRequired|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_msdyn_VendorNote"></a> msdyn_VendorNote

|Property|Value|
|--------|-----|
|Description|If you wish to display a note for the vendor on this PO specify it here|
|DisplayName|Vendor Note|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_vendornote|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

|Property|Value|
|--------|-----|
|Description|If purchase order is being ordered directly to a work order specify here. Note, when specified, by default all products will receive directly to work order.|
|DisplayName|Work Order|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workorder|
|RequiredLevel|None|
|Targets|msdyn_workorder|
|Type|Lookup|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_OwnerId"></a> OwnerId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_processid"></a> processid

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Contains the ID of the process associated with the entity.|
|DisplayName|Process Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_stageid"></a> stageid

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Contains the ID of the stage where the entity is located.|
|DisplayName|Stage Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Purchase Order|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### statecode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Purchase Order|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the currency associated with the entity.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|ApplicationRequired|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_traversedpath"></a> traversedpath

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows a comma-separated list of string values that represent the unique identifiers of stages in a business process flow instance in the order that they occur.|
|DisplayName|Traversed Path|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|traversedpath|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Shows the time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|

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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows who created the record on behalf of another user.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows the exchange rate for the currency associated with the entity with respect to the base currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows who last updated the record on behalf of another user.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_msdyn_amountbilled_Base"></a> msdyn_amountbilled_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the amount billed in the base currency.|
|DisplayName|Amount Billed (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_amountbilled_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_ApprovedRejectedByName"></a> msdyn_ApprovedRejectedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_approvedrejectedbyname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ApprovedRejectedByYomiName"></a> msdyn_ApprovedRejectedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_approvedrejectedbyyominame|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_BookingName"></a> msdyn_BookingName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_bookingname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_OrderedByName"></a> msdyn_OrderedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_orderedbyname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_OrderedByYomiName"></a> msdyn_OrderedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_orderedbyyominame|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PaymentTermName"></a> msdyn_PaymentTermName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_paymenttermname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ReceivetoWarehouseName"></a> msdyn_ReceivetoWarehouseName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_receivetowarehousename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_RequestedByResourceName"></a> msdyn_RequestedByResourceName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_requestedbyresourcename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ShipViaName"></a> msdyn_ShipViaName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_shipvianame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SubStatusName"></a> msdyn_SubStatusName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_substatusname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_totalamount_Base"></a> msdyn_totalamount_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the total amount in the base currency.|
|DisplayName|Total Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_VendorName"></a> msdyn_VendorName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_vendorname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_VendorYomiName"></a> msdyn_VendorYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_vendoryominame|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_WorkOrderName"></a> msdyn_WorkOrderName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_workordername|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Yomi name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the business unit that owns the record|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the team that owns the record.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the user that owns the record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|transactioncurrencyidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [msdyn_purchaseorder_ActivityPointers](#BKMK_msdyn_purchaseorder_ActivityPointers)
- [msdyn_purchaseorder_msdyn_bookingalerts](#BKMK_msdyn_purchaseorder_msdyn_bookingalerts)
- [msdyn_purchaseorder_msdyn_approvals](#BKMK_msdyn_purchaseorder_msdyn_approvals)
- [msdyn_purchaseorder_SyncErrors](#BKMK_msdyn_purchaseorder_SyncErrors)
- [msdyn_purchaseorder_DuplicateMatchingRecord](#BKMK_msdyn_purchaseorder_DuplicateMatchingRecord)
- [msdyn_purchaseorder_DuplicateBaseRecord](#BKMK_msdyn_purchaseorder_DuplicateBaseRecord)
- [msdyn_purchaseorder_SharePointDocumentLocations](#BKMK_msdyn_purchaseorder_SharePointDocumentLocations)
- [msdyn_purchaseorder_AsyncOperations](#BKMK_msdyn_purchaseorder_AsyncOperations)
- [msdyn_purchaseorder_MailboxTrackingFolders](#BKMK_msdyn_purchaseorder_MailboxTrackingFolders)
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

**Added by**: System Solution Solution

Same as activitypointer entity [msdyn_purchaseorder_ActivityPointers](activitypointer.md#BKMK_msdyn_purchaseorder_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorder_msdyn_bookingalerts"></a> msdyn_purchaseorder_msdyn_bookingalerts

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [msdyn_purchaseorder_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_purchaseorder_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorder_msdyn_approvals"></a> msdyn_purchaseorder_msdyn_approvals

**Added by**: Active Solution Solution

Same as msdyn_approval entity [msdyn_purchaseorder_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_purchaseorder_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorder_SyncErrors"></a> msdyn_purchaseorder_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_purchaseorder_SyncErrors](syncerror.md#BKMK_msdyn_purchaseorder_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorder_DuplicateMatchingRecord"></a> msdyn_purchaseorder_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_purchaseorder_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_purchaseorder_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorder_DuplicateBaseRecord"></a> msdyn_purchaseorder_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_purchaseorder_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_purchaseorder_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorder_SharePointDocumentLocations"></a> msdyn_purchaseorder_SharePointDocumentLocations

**Added by**: System Solution Solution

Same as sharepointdocumentlocation entity [msdyn_purchaseorder_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_purchaseorder_SharePointDocumentLocations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocumentlocation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_SharePointDocumentLocations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorder_AsyncOperations"></a> msdyn_purchaseorder_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_purchaseorder_AsyncOperations](asyncoperation.md#BKMK_msdyn_purchaseorder_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorder_MailboxTrackingFolders"></a> msdyn_purchaseorder_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_purchaseorder_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_purchaseorder_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorder_ProcessSession"></a> msdyn_purchaseorder_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_purchaseorder_ProcessSession](processsession.md#BKMK_msdyn_purchaseorder_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorder_BulkDeleteFailures"></a> msdyn_purchaseorder_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_purchaseorder_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_purchaseorder_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorder_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseorder_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_purchaseorder_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_purchaseorder_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorder_Appointments"></a> msdyn_purchaseorder_Appointments

**Added by**: System Solution Solution

Same as appointment entity [msdyn_purchaseorder_Appointments](appointment.md#BKMK_msdyn_purchaseorder_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorder_Emails"></a> msdyn_purchaseorder_Emails

**Added by**: System Solution Solution

Same as email entity [msdyn_purchaseorder_Emails](email.md#BKMK_msdyn_purchaseorder_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorder_Faxes"></a> msdyn_purchaseorder_Faxes

**Added by**: System Solution Solution

Same as fax entity [msdyn_purchaseorder_Faxes](fax.md#BKMK_msdyn_purchaseorder_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorder_Letters"></a> msdyn_purchaseorder_Letters

**Added by**: System Solution Solution

Same as letter entity [msdyn_purchaseorder_Letters](letter.md#BKMK_msdyn_purchaseorder_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorder_PhoneCalls"></a> msdyn_purchaseorder_PhoneCalls

**Added by**: System Solution Solution

Same as phonecall entity [msdyn_purchaseorder_PhoneCalls](phonecall.md#BKMK_msdyn_purchaseorder_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorder_Tasks"></a> msdyn_purchaseorder_Tasks

**Added by**: System Solution Solution

Same as task entity [msdyn_purchaseorder_Tasks](task.md#BKMK_msdyn_purchaseorder_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorder_RecurringAppointmentMasters"></a> msdyn_purchaseorder_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as recurringappointmentmaster entity [msdyn_purchaseorder_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_purchaseorder_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorder_SocialActivities"></a> msdyn_purchaseorder_SocialActivities

**Added by**: System Solution Solution

Same as socialactivity entity [msdyn_purchaseorder_SocialActivities](socialactivity.md#BKMK_msdyn_purchaseorder_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorder_connections1"></a> msdyn_purchaseorder_connections1

**Added by**: System Solution Solution

Same as connection entity [msdyn_purchaseorder_connections1](connection.md#BKMK_msdyn_purchaseorder_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorder_connections2"></a> msdyn_purchaseorder_connections2

**Added by**: System Solution Solution

Same as connection entity [msdyn_purchaseorder_connections2](connection.md#BKMK_msdyn_purchaseorder_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_purchaseorder_Annotations"></a> msdyn_purchaseorder_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_purchaseorder_Annotations](annotation.md#BKMK_msdyn_purchaseorder_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_purchaseorder_ServiceAppointments"></a> msdyn_purchaseorder_ServiceAppointments

**Added by**: Service Solution

Same as serviceappointment entity [msdyn_purchaseorder_ServiceAppointments](serviceappointment.md#BKMK_msdyn_purchaseorder_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_purchaseorder_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bpf_msdyn_purchaseorder_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799"></a> bpf_msdyn_purchaseorder_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799

Same as msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 entity [bpf_msdyn_purchaseorder_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_bpf_msdyn_purchaseorder_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_2c5fe86acc8b414b8322ae571000c799|
|ReferencingAttribute|bpf_msdyn_purchaseorderid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bpf_msdyn_purchaseorder_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: msdyn_purchaseorder<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder"></a> msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder

Same as msdyn_purchaseorderbill entity [msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder](msdyn_purchaseorderbill.md#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderbill|
|ReferencingAttribute|msdyn_purchaseorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_purchaseorder_msdyn_purchaseorderbill_PurchaseOrder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderproduct_PurchaseOrder"></a> msdyn_msdyn_purchaseorder_msdyn_purchaseorderproduct_PurchaseOrder

Same as msdyn_purchaseorderproduct entity [msdyn_msdyn_purchaseorder_msdyn_purchaseorderproduct_PurchaseOrder](msdyn_purchaseorderproduct.md#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderproduct_PurchaseOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderproduct|
|ReferencingAttribute|msdyn_purchaseorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_purchaseorder_msdyn_purchaseorderproduct_PurchaseOrder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: Purchase Order<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder"></a> msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder

Same as msdyn_purchaseorderreceipt entity [msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder](msdyn_purchaseorderreceipt.md#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderreceipt|
|ReferencingAttribute|msdyn_purchaseorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder"></a> msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder

Same as msdyn_purchaseorderreceiptproduct entity [msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderreceiptproduct|
|ReferencingAttribute|msdyn_purchaseorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceiptproduct_PurchaseOrder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO"></a> msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO

Same as msdyn_rtv entity [msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO](msdyn_rtv.md#BKMK_msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rtv|
|ReferencingAttribute|msdyn_originalpurchaseorder|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Original Purchase Order<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

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

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_purchaseorder_createdby](systemuser.md#BKMK_lk_msdyn_purchaseorder_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorder_createdonbehalfby"></a> lk_msdyn_purchaseorder_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_purchaseorder_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_purchaseorder_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorder_modifiedby"></a> lk_msdyn_purchaseorder_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_purchaseorder_modifiedby](systemuser.md#BKMK_lk_msdyn_purchaseorder_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorder_modifiedonbehalfby"></a> lk_msdyn_purchaseorder_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_purchaseorder_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_purchaseorder_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_purchaseorder"></a> user_msdyn_purchaseorder

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_purchaseorder](systemuser.md#BKMK_user_msdyn_purchaseorder) One-To-Many relationship.

### <a name="BKMK_team_msdyn_purchaseorder"></a> team_msdyn_purchaseorder

**Added by**: System Solution Solution

See team Entity [team_msdyn_purchaseorder](team.md#BKMK_team_msdyn_purchaseorder) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_purchaseorder"></a> business_unit_msdyn_purchaseorder

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_purchaseorder](businessunit.md#BKMK_business_unit_msdyn_purchaseorder) One-To-Many relationship.

### <a name="BKMK_processstage_msdyn_purchaseorder"></a> processstage_msdyn_purchaseorder

**Added by**: System Solution Solution

See processstage Entity [processstage_msdyn_purchaseorder](processstage.md#BKMK_processstage_msdyn_purchaseorder) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_purchaseorder"></a> TransactionCurrency_msdyn_purchaseorder

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_msdyn_purchaseorder](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_purchaseorder) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_purchaseorder_Vendor"></a> msdyn_account_msdyn_purchaseorder_Vendor

**Added by**: System Solution Solution

See account Entity [msdyn_account_msdyn_purchaseorder_Vendor](account.md#BKMK_msdyn_account_msdyn_purchaseorder_Vendor) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource"></a> msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource

**Added by**: Scheduling Solution

See bookableresource Entity [msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking"></a> msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking

**Added by**: Scheduling Solution

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

**Added by**: System Solution Solution

See systemuser Entity [msdyn_systemuser_msdyn_purchaseorder_ApprovedRejectedBy](systemuser.md#BKMK_msdyn_systemuser_msdyn_purchaseorder_ApprovedRejectedBy) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuser_msdyn_purchaseorder_OrderedBy"></a> msdyn_systemuser_msdyn_purchaseorder_OrderedBy

**Added by**: System Solution Solution

See systemuser Entity [msdyn_systemuser_msdyn_purchaseorder_OrderedBy](systemuser.md#BKMK_msdyn_systemuser_msdyn_purchaseorder_OrderedBy) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_purchaseorder?text=msdyn_purchaseorder EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]