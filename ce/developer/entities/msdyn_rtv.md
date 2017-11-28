---
title: "msdyn_rtv Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_rtv entity."
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
# msdyn_rtv Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Records RTVs for products to be retuned to vendors

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_rtvs(*msdyn_rtvid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_rtvs<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_rtvs(*msdyn_rtvid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_rtvs(*msdyn_rtvid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_rtvs<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_rtvs(*msdyn_rtvid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_rtvs(*msdyn_rtvid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: RTV<br />
**DisplayCollectionName**: RTVs<br />
**SchemaName**: msdyn_rtv<br />
**CollectionSchemaName**: msdyn_rtvs<br />
**LogicalName**: msdyn_rtv<br />
**LogicalCollectionName**: msdyn_rtvs<br />
**EntitySetName**: msdyn_rtvs<br />
**PrimaryIdAttribute**: msdyn_rtvid<br />
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
- [msdyn_ApprovedDeclinedBy](#BKMK_msdyn_ApprovedDeclinedBy)
- [msdyn_Booking](#BKMK_msdyn_Booking)
- [msdyn_City](#BKMK_msdyn_City)
- [msdyn_Country](#BKMK_msdyn_Country)
- [msdyn_Latitude](#BKMK_msdyn_Latitude)
- [msdyn_Longitude](#BKMK_msdyn_Longitude)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_OriginalPurchaseOrder](#BKMK_msdyn_OriginalPurchaseOrder)
- [msdyn_OriginatingRMA](#BKMK_msdyn_OriginatingRMA)
- [msdyn_PostalCode](#BKMK_msdyn_PostalCode)
- [msdyn_ReferenceNo](#BKMK_msdyn_ReferenceNo)
- [msdyn_RequestDate](#BKMK_msdyn_RequestDate)
- [msdyn_ReturnDate](#BKMK_msdyn_ReturnDate)
- [msdyn_ReturnedBy](#BKMK_msdyn_ReturnedBy)
- [msdyn_rtvId](#BKMK_msdyn_rtvId)
- [msdyn_ShipVia](#BKMK_msdyn_ShipVia)
- [msdyn_StateOrProvince](#BKMK_msdyn_StateOrProvince)
- [msdyn_SubStatus](#BKMK_msdyn_SubStatus)
- [msdyn_SystemStatus](#BKMK_msdyn_SystemStatus)
- [msdyn_TaxCode](#BKMK_msdyn_TaxCode)
- [msdyn_TotalAmount](#BKMK_msdyn_TotalAmount)
- [msdyn_Vendor](#BKMK_msdyn_Vendor)
- [msdyn_VendorContact](#BKMK_msdyn_VendorContact)
- [msdyn_VendorRMA](#BKMK_msdyn_VendorRMA)
- [msdyn_WorkOrder](#BKMK_msdyn_WorkOrder)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
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
**DisplayName**: Address 1<br />
**LogicalName**: msdyn_address1<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_Address2"></a> msdyn_Address2

**Description**: <br />
**DisplayName**: Address 2<br />
**LogicalName**: msdyn_address2<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_Address3"></a> msdyn_Address3

**Description**: <br />
**DisplayName**: Address 3<br />
**LogicalName**: msdyn_address3<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ApprovedDeclinedBy"></a> msdyn_ApprovedDeclinedBy

**Description**: The user who approved or rejected this return<br />
**DisplayName**: Approved/Declined By<br />
**LogicalName**: msdyn_approveddeclinedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_msdyn_Booking"></a> msdyn_Booking

**Description**: Unique identifier for Resource Booking associated with RTV.<br />
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
**MaxLength**: 100


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
**MaxLength**: 100


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

**Description**: Shows the unique number for identifying this RTV record.<br />
**DisplayName**: RTV Number<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_OriginalPurchaseOrder"></a> msdyn_OriginalPurchaseOrder

**Description**: Purchase Order from where items are originating<br />
**DisplayName**: Original Purchase Order<br />
**LogicalName**: msdyn_originalpurchaseorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_purchaseorder


### <a name="BKMK_msdyn_OriginatingRMA"></a> msdyn_OriginatingRMA

**Description**: Originating RMA if items were returned from customer<br />
**DisplayName**: Originating RMA<br />
**LogicalName**: msdyn_originatingrma<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_rma


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
**MaxLength**: 100


### <a name="BKMK_msdyn_ReferenceNo"></a> msdyn_ReferenceNo

**Description**: <br />
**DisplayName**: Reference No<br />
**LogicalName**: msdyn_referenceno<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_RequestDate"></a> msdyn_RequestDate

**Description**: Enter the date when return was requested.<br />
**DisplayName**: Request Date<br />
**LogicalName**: msdyn_requestdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_ReturnDate"></a> msdyn_ReturnDate

**Description**: Enter the date items were returned to vendor.<br />
**DisplayName**: Return Date<br />
**LogicalName**: msdyn_returndate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_ReturnedBy"></a> msdyn_ReturnedBy

**Description**: User processing this return<br />
**DisplayName**: Returned By<br />
**LogicalName**: msdyn_returnedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_msdyn_rtvId"></a> msdyn_rtvId

**Description**: Shows the entity instances.<br />
**DisplayName**: RTV<br />
**LogicalName**: msdyn_rtvid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_ShipVia"></a> msdyn_ShipVia

**Description**: Method of Shipment to Vendor<br />
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
**MaxLength**: 100


### <a name="BKMK_msdyn_SubStatus"></a> msdyn_SubStatus

**Description**: RTV Sub-Status<br />
**DisplayName**: Sub-Status<br />
**LogicalName**: msdyn_substatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_rtvsubstatus


### <a name="BKMK_msdyn_SystemStatus"></a> msdyn_SystemStatus

**Description**: Enter the current status of the RTV.<br />
**DisplayName**: System Status<br />
**LogicalName**: msdyn_systemstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Draft
- **Value**: 690970001 **Label**: Approved
- **Value**: 690970002 **Label**: Shipped
- **Value**: 690970003 **Label**: Received
- **Value**: 690970004 **Label**: Canceled



### <a name="BKMK_msdyn_TaxCode"></a> msdyn_TaxCode

**Description**: Tax code vendor charges you<br />
**DisplayName**: Tax Code<br />
**LogicalName**: msdyn_taxcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_taxcode


### <a name="BKMK_msdyn_TotalAmount"></a> msdyn_TotalAmount

**Description**: Shows the total Amount to be credited on this RTV.<br />
**DisplayName**: Total Amount<br />
**LogicalName**: msdyn_totalamount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 0


### <a name="BKMK_msdyn_Vendor"></a> msdyn_Vendor

**Description**: Vendor where items will be returned<br />
**DisplayName**: Vendor<br />
**LogicalName**: msdyn_vendor<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_VendorContact"></a> msdyn_VendorContact

**Description**: Contact person at Vendor<br />
**DisplayName**: Vendor Contact<br />
**LogicalName**: msdyn_vendorcontact<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: contact


### <a name="BKMK_msdyn_VendorRMA"></a> msdyn_VendorRMA

**Description**: RMA from Vendor<br />
**DisplayName**: Vendor RMA<br />
**LogicalName**: msdyn_vendorrma<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

**Description**: Unique identifier for Work Order associated with RTV.<br />
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


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the RTV<br />
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

**Description**: Reason for the status of the RTV<br />
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
- [msdyn_ApprovedDeclinedByName](#BKMK_msdyn_ApprovedDeclinedByName)
- [msdyn_ApprovedDeclinedByYomiName](#BKMK_msdyn_ApprovedDeclinedByYomiName)
- [msdyn_BookingName](#BKMK_msdyn_BookingName)
- [msdyn_OriginalPurchaseOrderName](#BKMK_msdyn_OriginalPurchaseOrderName)
- [msdyn_OriginatingRMAName](#BKMK_msdyn_OriginatingRMAName)
- [msdyn_ReturnedByName](#BKMK_msdyn_ReturnedByName)
- [msdyn_ReturnedByYomiName](#BKMK_msdyn_ReturnedByYomiName)
- [msdyn_ShipViaName](#BKMK_msdyn_ShipViaName)
- [msdyn_SubStatusName](#BKMK_msdyn_SubStatusName)
- [msdyn_TaxCodeName](#BKMK_msdyn_TaxCodeName)
- [msdyn_totalamount_Base](#BKMK_msdyn_totalamount_Base)
- [msdyn_VendorContactName](#BKMK_msdyn_VendorContactName)
- [msdyn_VendorContactYomiName](#BKMK_msdyn_VendorContactYomiName)
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


### <a name="BKMK_msdyn_ApprovedDeclinedByName"></a> msdyn_ApprovedDeclinedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_approveddeclinedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_ApprovedDeclinedByYomiName"></a> msdyn_ApprovedDeclinedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_approveddeclinedbyyominame<br />
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


### <a name="BKMK_msdyn_OriginalPurchaseOrderName"></a> msdyn_OriginalPurchaseOrderName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_originalpurchaseordername<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_OriginatingRMAName"></a> msdyn_OriginatingRMAName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_originatingrmaname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ReturnedByName"></a> msdyn_ReturnedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_returnedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_ReturnedByYomiName"></a> msdyn_ReturnedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_returnedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


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


### <a name="BKMK_msdyn_TaxCodeName"></a> msdyn_TaxCodeName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_taxcodename<br />
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
**PrecisionSource**: 0


### <a name="BKMK_msdyn_VendorContactName"></a> msdyn_VendorContactName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_vendorcontactname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_VendorContactYomiName"></a> msdyn_VendorContactYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_vendorcontactyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


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

- [msdyn_rtv_ActivityPointers](#BKMK_msdyn_rtv_ActivityPointers)
- [msdyn_rtv_msdyn_approvals](#BKMK_msdyn_rtv_msdyn_approvals)
- [msdyn_rtv_msdyn_bookingalerts](#BKMK_msdyn_rtv_msdyn_bookingalerts)
- [msdyn_rtv_SyncErrors](#BKMK_msdyn_rtv_SyncErrors)
- [msdyn_rtv_DuplicateMatchingRecord](#BKMK_msdyn_rtv_DuplicateMatchingRecord)
- [msdyn_rtv_DuplicateBaseRecord](#BKMK_msdyn_rtv_DuplicateBaseRecord)
- [msdyn_rtv_SharePointDocumentLocations](#BKMK_msdyn_rtv_SharePointDocumentLocations)
- [msdyn_rtv_SharePointDocuments](#BKMK_msdyn_rtv_SharePointDocuments)
- [msdyn_rtv_AsyncOperations](#BKMK_msdyn_rtv_AsyncOperations)
- [msdyn_rtv_MailboxTrackingFolders](#BKMK_msdyn_rtv_MailboxTrackingFolders)
- [msdyn_rtv_UserEntityInstanceDatas](#BKMK_msdyn_rtv_UserEntityInstanceDatas)
- [msdyn_rtv_ProcessSession](#BKMK_msdyn_rtv_ProcessSession)
- [msdyn_rtv_BulkDeleteFailures](#BKMK_msdyn_rtv_BulkDeleteFailures)
- [msdyn_rtv_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rtv_PrincipalObjectAttributeAccesses)
- [msdyn_rtv_Appointments](#BKMK_msdyn_rtv_Appointments)
- [msdyn_rtv_Emails](#BKMK_msdyn_rtv_Emails)
- [msdyn_rtv_Faxes](#BKMK_msdyn_rtv_Faxes)
- [msdyn_rtv_Letters](#BKMK_msdyn_rtv_Letters)
- [msdyn_rtv_PhoneCalls](#BKMK_msdyn_rtv_PhoneCalls)
- [msdyn_rtv_Tasks](#BKMK_msdyn_rtv_Tasks)
- [msdyn_rtv_RecurringAppointmentMasters](#BKMK_msdyn_rtv_RecurringAppointmentMasters)
- [msdyn_rtv_SocialActivities](#BKMK_msdyn_rtv_SocialActivities)
- [msdyn_rtv_connections1](#BKMK_msdyn_rtv_connections1)
- [msdyn_rtv_connections2](#BKMK_msdyn_rtv_connections2)
- [msdyn_rtv_Annotations](#BKMK_msdyn_rtv_Annotations)
- [msdyn_rtv_ServiceAppointments](#BKMK_msdyn_rtv_ServiceAppointments)
- [msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV](#BKMK_msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV)
- [msdyn_msdyn_rtv_msdyn_rtvproduct_RTV](#BKMK_msdyn_msdyn_rtv_msdyn_rtvproduct_RTV)


### <a name="BKMK_msdyn_rtv_ActivityPointers"></a> msdyn_rtv_ActivityPointers

Same as activitypointer entity [msdyn_rtv_ActivityPointers](activitypointer.md#BKMK_msdyn_rtv_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_ActivityPointers<br />
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


### <a name="BKMK_msdyn_rtv_msdyn_approvals"></a> msdyn_rtv_msdyn_approvals

Same as msdyn_approval entity [msdyn_rtv_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_rtv_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_rtv_msdyn_bookingalerts"></a> msdyn_rtv_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_rtv_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_rtv_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_rtv_SyncErrors"></a> msdyn_rtv_SyncErrors

Same as syncerror entity [msdyn_rtv_SyncErrors](syncerror.md#BKMK_msdyn_rtv_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_SyncErrors<br />
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


### <a name="BKMK_msdyn_rtv_DuplicateMatchingRecord"></a> msdyn_rtv_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_rtv_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_rtv_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_rtv_DuplicateBaseRecord"></a> msdyn_rtv_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_rtv_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_rtv_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_rtv_SharePointDocumentLocations"></a> msdyn_rtv_SharePointDocumentLocations

Same as sharepointdocumentlocation entity [msdyn_rtv_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_rtv_SharePointDocumentLocations) Many-To-One relationship.

**ReferencingEntity**: sharepointdocumentlocation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_SharePointDocumentLocations<br />
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


### <a name="BKMK_msdyn_rtv_SharePointDocuments"></a> msdyn_rtv_SharePointDocuments

Same as sharepointdocument entity [msdyn_rtv_SharePointDocuments](sharepointdocument.md#BKMK_msdyn_rtv_SharePointDocuments) Many-To-One relationship.

**ReferencingEntity**: sharepointdocument<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_SharePointDocuments<br />
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


### <a name="BKMK_msdyn_rtv_AsyncOperations"></a> msdyn_rtv_AsyncOperations

Same as asyncoperation entity [msdyn_rtv_AsyncOperations](asyncoperation.md#BKMK_msdyn_rtv_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_AsyncOperations<br />
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


### <a name="BKMK_msdyn_rtv_MailboxTrackingFolders"></a> msdyn_rtv_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_rtv_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_rtv_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_rtv_UserEntityInstanceDatas"></a> msdyn_rtv_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_rtv_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_rtv_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_rtv_ProcessSession"></a> msdyn_rtv_ProcessSession

Same as processsession entity [msdyn_rtv_ProcessSession](processsession.md#BKMK_msdyn_rtv_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_ProcessSession<br />
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


### <a name="BKMK_msdyn_rtv_BulkDeleteFailures"></a> msdyn_rtv_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_rtv_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_rtv_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_rtv_PrincipalObjectAttributeAccesses"></a> msdyn_rtv_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_rtv_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_rtv_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_rtv_Appointments"></a> msdyn_rtv_Appointments

Same as appointment entity [msdyn_rtv_Appointments](appointment.md#BKMK_msdyn_rtv_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_Appointments<br />
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


### <a name="BKMK_msdyn_rtv_Emails"></a> msdyn_rtv_Emails

Same as email entity [msdyn_rtv_Emails](email.md#BKMK_msdyn_rtv_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_Emails<br />
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


### <a name="BKMK_msdyn_rtv_Faxes"></a> msdyn_rtv_Faxes

Same as fax entity [msdyn_rtv_Faxes](fax.md#BKMK_msdyn_rtv_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_Faxes<br />
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


### <a name="BKMK_msdyn_rtv_Letters"></a> msdyn_rtv_Letters

Same as letter entity [msdyn_rtv_Letters](letter.md#BKMK_msdyn_rtv_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_Letters<br />
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


### <a name="BKMK_msdyn_rtv_PhoneCalls"></a> msdyn_rtv_PhoneCalls

Same as phonecall entity [msdyn_rtv_PhoneCalls](phonecall.md#BKMK_msdyn_rtv_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_PhoneCalls<br />
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


### <a name="BKMK_msdyn_rtv_Tasks"></a> msdyn_rtv_Tasks

Same as task entity [msdyn_rtv_Tasks](task.md#BKMK_msdyn_rtv_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_Tasks<br />
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


### <a name="BKMK_msdyn_rtv_RecurringAppointmentMasters"></a> msdyn_rtv_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_rtv_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_rtv_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_rtv_SocialActivities"></a> msdyn_rtv_SocialActivities

Same as socialactivity entity [msdyn_rtv_SocialActivities](socialactivity.md#BKMK_msdyn_rtv_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_SocialActivities<br />
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


### <a name="BKMK_msdyn_rtv_connections1"></a> msdyn_rtv_connections1

Same as connection entity [msdyn_rtv_connections1](connection.md#BKMK_msdyn_rtv_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_connections1<br />
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


### <a name="BKMK_msdyn_rtv_connections2"></a> msdyn_rtv_connections2

Same as connection entity [msdyn_rtv_connections2](connection.md#BKMK_msdyn_rtv_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_connections2<br />
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


### <a name="BKMK_msdyn_rtv_Annotations"></a> msdyn_rtv_Annotations

Same as annotation entity [msdyn_rtv_Annotations](annotation.md#BKMK_msdyn_rtv_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_Annotations<br />
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


### <a name="BKMK_msdyn_rtv_ServiceAppointments"></a> msdyn_rtv_ServiceAppointments

Same as serviceappointment entity [msdyn_rtv_ServiceAppointments](serviceappointment.md#BKMK_msdyn_rtv_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rtv_ServiceAppointments<br />
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


### <a name="BKMK_msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV"></a> msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV

Same as msdyn_rmareceiptproduct entity [msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV](msdyn_rmareceiptproduct.md#BKMK_msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmareceiptproduct<br />
**ReferencingAttribute**: msdyn_rtv<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV<br />
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


### <a name="BKMK_msdyn_msdyn_rtv_msdyn_rtvproduct_RTV"></a> msdyn_msdyn_rtv_msdyn_rtvproduct_RTV

Same as msdyn_rtvproduct entity [msdyn_msdyn_rtv_msdyn_rtvproduct_RTV](msdyn_rtvproduct.md#BKMK_msdyn_msdyn_rtv_msdyn_rtvproduct_RTV) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtvproduct<br />
**ReferencingAttribute**: msdyn_rtv<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_rtv_msdyn_rtvproduct_RTV<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_rtv_createdby](#BKMK_lk_msdyn_rtv_createdby)
- [lk_msdyn_rtv_createdonbehalfby](#BKMK_lk_msdyn_rtv_createdonbehalfby)
- [lk_msdyn_rtv_modifiedby](#BKMK_lk_msdyn_rtv_modifiedby)
- [lk_msdyn_rtv_modifiedonbehalfby](#BKMK_lk_msdyn_rtv_modifiedonbehalfby)
- [user_msdyn_rtv](#BKMK_user_msdyn_rtv)
- [team_msdyn_rtv](#BKMK_team_msdyn_rtv)
- [business_unit_msdyn_rtv](#BKMK_business_unit_msdyn_rtv)
- [TransactionCurrency_msdyn_rtv](#BKMK_TransactionCurrency_msdyn_rtv)
- [msdyn_account_msdyn_rtv_Vendor](#BKMK_msdyn_account_msdyn_rtv_Vendor)
- [msdyn_bookableresourcebooking_msdyn_rtv_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_rtv_Booking)
- [msdyn_contact_msdyn_rtv_VendorContact](#BKMK_msdyn_contact_msdyn_rtv_VendorContact)
- [msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO](#BKMK_msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO)
- [msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA](#BKMK_msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA)
- [msdyn_msdyn_rtvsubstatus_msdyn_rtv_SubStatus](#BKMK_msdyn_msdyn_rtvsubstatus_msdyn_rtv_SubStatus)
- [msdyn_msdyn_shipvia_msdyn_rtv_ShipVia](#BKMK_msdyn_msdyn_shipvia_msdyn_rtv_ShipVia)
- [msdyn_msdyn_taxcode_msdyn_rtv_TaxCode](#BKMK_msdyn_msdyn_taxcode_msdyn_rtv_TaxCode)
- [msdyn_msdyn_workorder_msdyn_rtv_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_rtv_WorkOrder)
- [msdyn_systemuser_msdyn_rtv_ApprovedDeclinedBy](#BKMK_msdyn_systemuser_msdyn_rtv_ApprovedDeclinedBy)
- [msdyn_systemuser_msdyn_rtv_ReturnedBy](#BKMK_msdyn_systemuser_msdyn_rtv_ReturnedBy)


### <a name="BKMK_lk_msdyn_rtv_createdby"></a> lk_msdyn_rtv_createdby

See systemuser Entity [lk_msdyn_rtv_createdby](systemuser.md#BKMK_lk_msdyn_rtv_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rtv_createdonbehalfby"></a> lk_msdyn_rtv_createdonbehalfby

See systemuser Entity [lk_msdyn_rtv_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_rtv_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rtv_modifiedby"></a> lk_msdyn_rtv_modifiedby

See systemuser Entity [lk_msdyn_rtv_modifiedby](systemuser.md#BKMK_lk_msdyn_rtv_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rtv_modifiedonbehalfby"></a> lk_msdyn_rtv_modifiedonbehalfby

See systemuser Entity [lk_msdyn_rtv_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_rtv_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_rtv"></a> user_msdyn_rtv

See systemuser Entity [user_msdyn_rtv](systemuser.md#BKMK_user_msdyn_rtv) One-To-Many relationship.

### <a name="BKMK_team_msdyn_rtv"></a> team_msdyn_rtv

See team Entity [team_msdyn_rtv](team.md#BKMK_team_msdyn_rtv) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_rtv"></a> business_unit_msdyn_rtv

See businessunit Entity [business_unit_msdyn_rtv](businessunit.md#BKMK_business_unit_msdyn_rtv) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_rtv"></a> TransactionCurrency_msdyn_rtv

See transactioncurrency Entity [TransactionCurrency_msdyn_rtv](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_rtv) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_rtv_Vendor"></a> msdyn_account_msdyn_rtv_Vendor

See account Entity [msdyn_account_msdyn_rtv_Vendor](account.md#BKMK_msdyn_account_msdyn_rtv_Vendor) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_rtv_Booking"></a> msdyn_bookableresourcebooking_msdyn_rtv_Booking

See bookableresourcebooking Entity [msdyn_bookableresourcebooking_msdyn_rtv_Booking](bookableresourcebooking.md#BKMK_msdyn_bookableresourcebooking_msdyn_rtv_Booking) One-To-Many relationship.

### <a name="BKMK_msdyn_contact_msdyn_rtv_VendorContact"></a> msdyn_contact_msdyn_rtv_VendorContact

See contact Entity [msdyn_contact_msdyn_rtv_VendorContact](contact.md#BKMK_msdyn_contact_msdyn_rtv_VendorContact) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO"></a> msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO

See msdyn_purchaseorder Entity [msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO](msdyn_purchaseorder.md#BKMK_msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA"></a> msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA

See msdyn_rma Entity [msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA](msdyn_rma.md#BKMK_msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_rtvsubstatus_msdyn_rtv_SubStatus"></a> msdyn_msdyn_rtvsubstatus_msdyn_rtv_SubStatus

See msdyn_rtvsubstatus Entity [msdyn_msdyn_rtvsubstatus_msdyn_rtv_SubStatus](msdyn_rtvsubstatus.md#BKMK_msdyn_msdyn_rtvsubstatus_msdyn_rtv_SubStatus) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_shipvia_msdyn_rtv_ShipVia"></a> msdyn_msdyn_shipvia_msdyn_rtv_ShipVia

See msdyn_shipvia Entity [msdyn_msdyn_shipvia_msdyn_rtv_ShipVia](msdyn_shipvia.md#BKMK_msdyn_msdyn_shipvia_msdyn_rtv_ShipVia) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_rtv_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_rtv_TaxCode

See msdyn_taxcode Entity [msdyn_msdyn_taxcode_msdyn_rtv_TaxCode](msdyn_taxcode.md#BKMK_msdyn_msdyn_taxcode_msdyn_rtv_TaxCode) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_rtv_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_rtv_WorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_msdyn_rtv_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_rtv_WorkOrder) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuser_msdyn_rtv_ApprovedDeclinedBy"></a> msdyn_systemuser_msdyn_rtv_ApprovedDeclinedBy

See systemuser Entity [msdyn_systemuser_msdyn_rtv_ApprovedDeclinedBy](systemuser.md#BKMK_msdyn_systemuser_msdyn_rtv_ApprovedDeclinedBy) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuser_msdyn_rtv_ReturnedBy"></a> msdyn_systemuser_msdyn_rtv_ReturnedBy

See systemuser Entity [msdyn_systemuser_msdyn_rtv_ReturnedBy](systemuser.md#BKMK_msdyn_systemuser_msdyn_rtv_ReturnedBy) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_rtv?text=msdyn_rtv EntityType" />