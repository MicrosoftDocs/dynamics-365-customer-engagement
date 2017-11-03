---
title: "msdyn_rma Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_rma entity."
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
# msdyn_rma Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Records RMAs for products to be retuned from customers

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_rmas(*msdyn_rmaid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_rmas<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_rmas(*msdyn_rmaid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_rmas(*msdyn_rmaid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_rmas<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_rmas(*msdyn_rmaid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_rmas(*msdyn_rmaid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: RMA<br />
**DisplayCollectionName**: RMAs<br />
**SchemaName**: msdyn_rma<br />
**CollectionSchemaName**: msdyn_rmas<br />
**LogicalName**: msdyn_rma<br />
**LogicalCollectionName**: msdyn_rmas<br />
**EntitySetName**: msdyn_rmas<br />
**PrimaryIdAttribute**: msdyn_rmaid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ApprovedBy](#BKMK_msdyn_ApprovedBy)
- [msdyn_BillingAccount](#BKMK_msdyn_BillingAccount)
- [msdyn_DateRequested](#BKMK_msdyn_DateRequested)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_ETA](#BKMK_msdyn_ETA)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_PackagingTrackingNo](#BKMK_msdyn_PackagingTrackingNo)
- [msdyn_PriceList](#BKMK_msdyn_PriceList)
- [msdyn_ProcessingAction](#BKMK_msdyn_ProcessingAction)
- [msdyn_ReferenceNo](#BKMK_msdyn_ReferenceNo)
- [msdyn_RequestedByContact](#BKMK_msdyn_RequestedByContact)
- [msdyn_rmaId](#BKMK_msdyn_rmaId)
- [msdyn_ServiceAccount](#BKMK_msdyn_ServiceAccount)
- [msdyn_ShippingTrackingNo](#BKMK_msdyn_ShippingTrackingNo)
- [msdyn_ShipVia](#BKMK_msdyn_ShipVia)
- [msdyn_SubStatus](#BKMK_msdyn_SubStatus)
- [msdyn_SystemStatus](#BKMK_msdyn_SystemStatus)
- [msdyn_Taxable](#BKMK_msdyn_Taxable)
- [msdyn_TaxCode](#BKMK_msdyn_TaxCode)
- [msdyn_TotalAmount](#BKMK_msdyn_TotalAmount)
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


### <a name="BKMK_msdyn_ApprovedBy"></a> msdyn_ApprovedBy

**Description**: User who approved RMA<br />
**DisplayName**: Approved By<br />
**LogicalName**: msdyn_approvedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_msdyn_BillingAccount"></a> msdyn_BillingAccount

**Description**: Account to be billed. If a billing account has been set on service account it will be populated by default. Otherwise, the billing account will be the same as the service account.<br />
**DisplayName**: Billing Account<br />
**LogicalName**: msdyn_billingaccount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_DateRequested"></a> msdyn_DateRequested

**Description**: Enter the date RMA was requested by the customer.<br />
**DisplayName**: Date Requested<br />
**LogicalName**: msdyn_daterequested<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_Description"></a> msdyn_Description

**Description**: Enter a short description of the RMA.<br />
**DisplayName**: Description<br />
**LogicalName**: msdyn_description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ETA"></a> msdyn_ETA

**Description**: ETA<br />
**DisplayName**: ETA<br />
**LogicalName**: msdyn_eta<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Shows the unique number identifying this RMA record.<br />
**DisplayName**: RMA Number<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_PackagingTrackingNo"></a> msdyn_PackagingTrackingNo

**Description**: Shows the tracking number of package<br />
**DisplayName**: Packaging Tracking No<br />
**LogicalName**: msdyn_packagingtrackingno<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

**Description**: Price List that determines the pricing for this product<br />
**DisplayName**: Price List<br />
**LogicalName**: msdyn_pricelist<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: pricelevel


### <a name="BKMK_msdyn_ProcessingAction"></a> msdyn_ProcessingAction

**Description**: Shows the default action to be taken on all RMA Products.<br />
**DisplayName**: Processing Action<br />
**LogicalName**: msdyn_processingaction<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Create RTV
- **Value**: 690970001 **Label**: Return to Warehouse
- **Value**: 690970002 **Label**: Change Asset Ownership



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


### <a name="BKMK_msdyn_RequestedByContact"></a> msdyn_RequestedByContact

**Description**: Contact who requested this return<br />
**DisplayName**: Requested By Contact<br />
**LogicalName**: msdyn_requestedbycontact<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: contact


### <a name="BKMK_msdyn_rmaId"></a> msdyn_rmaId

**Description**: Shows the entity instances.<br />
**DisplayName**: RMA<br />
**LogicalName**: msdyn_rmaid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_ServiceAccount"></a> msdyn_ServiceAccount

**Description**: Account to be serviced<br />
**DisplayName**: Service Account<br />
**LogicalName**: msdyn_serviceaccount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_ShippingTrackingNo"></a> msdyn_ShippingTrackingNo

**Description**: Shows the tracking number of the shipment.<br />
**DisplayName**: Shipping Tracking No<br />
**LogicalName**: msdyn_shippingtrackingno<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ShipVia"></a> msdyn_ShipVia

**Description**: Method of shipment by Customer<br />
**DisplayName**: Ship Via<br />
**LogicalName**: msdyn_shipvia<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_shipvia


### <a name="BKMK_msdyn_SubStatus"></a> msdyn_SubStatus

**Description**: RMA Sub-Status<br />
**DisplayName**: Sub-Status<br />
**LogicalName**: msdyn_substatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_rmasubstatus


### <a name="BKMK_msdyn_SystemStatus"></a> msdyn_SystemStatus

**Description**: Enter the current status of the RMA.<br />
**DisplayName**: System Status<br />
**LogicalName**: msdyn_systemstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Pending
- **Value**: 690970001 **Label**: Canceled
- **Value**: 690970002 **Label**: Products Received



### <a name="BKMK_msdyn_Taxable"></a> msdyn_Taxable

**Description**: Specify if RMA is taxable<br />
**DisplayName**: Taxable<br />
**LogicalName**: msdyn_taxable<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_TaxCode"></a> msdyn_TaxCode

**Description**: Tax Code to be used to calculate tax when RMA is taxable. By default the system will use the tax code specified on the service account<br />
**DisplayName**: Tax Code<br />
**LogicalName**: msdyn_taxcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_taxcode


### <a name="BKMK_msdyn_TotalAmount"></a> msdyn_TotalAmount

**Description**: Shows the total amount of all RMA Products including tax.<br />
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


### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

**Description**: Work Order this RMA is linked to<br />
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

**Description**: Status of the RMA<br />
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

**Description**: Reason for the status of the RMA<br />
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
- [msdyn_ApprovedByName](#BKMK_msdyn_ApprovedByName)
- [msdyn_ApprovedByYomiName](#BKMK_msdyn_ApprovedByYomiName)
- [msdyn_BillingAccountName](#BKMK_msdyn_BillingAccountName)
- [msdyn_BillingAccountYomiName](#BKMK_msdyn_BillingAccountYomiName)
- [msdyn_PriceListName](#BKMK_msdyn_PriceListName)
- [msdyn_RequestedByContactName](#BKMK_msdyn_RequestedByContactName)
- [msdyn_RequestedByContactYomiName](#BKMK_msdyn_RequestedByContactYomiName)
- [msdyn_ServiceAccountName](#BKMK_msdyn_ServiceAccountName)
- [msdyn_ServiceAccountYomiName](#BKMK_msdyn_ServiceAccountYomiName)
- [msdyn_ShipViaName](#BKMK_msdyn_ShipViaName)
- [msdyn_SubStatusName](#BKMK_msdyn_SubStatusName)
- [msdyn_TaxCodeName](#BKMK_msdyn_TaxCodeName)
- [msdyn_totalamount_Base](#BKMK_msdyn_totalamount_Base)
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


### <a name="BKMK_msdyn_ApprovedByName"></a> msdyn_ApprovedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_approvedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_ApprovedByYomiName"></a> msdyn_ApprovedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_approvedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_BillingAccountName"></a> msdyn_BillingAccountName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_billingaccountname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_BillingAccountYomiName"></a> msdyn_BillingAccountYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_billingaccountyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_PriceListName"></a> msdyn_PriceListName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_pricelistname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_RequestedByContactName"></a> msdyn_RequestedByContactName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_requestedbycontactname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_RequestedByContactYomiName"></a> msdyn_RequestedByContactYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_requestedbycontactyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


### <a name="BKMK_msdyn_ServiceAccountName"></a> msdyn_ServiceAccountName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_serviceaccountname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_ServiceAccountYomiName"></a> msdyn_ServiceAccountYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_serviceaccountyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


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

- [msdyn_rma_ActivityPointers](#BKMK_msdyn_rma_ActivityPointers)
- [msdyn_rma_msdyn_approvals](#BKMK_msdyn_rma_msdyn_approvals)
- [msdyn_rma_msdyn_bookingalerts](#BKMK_msdyn_rma_msdyn_bookingalerts)
- [msdyn_rma_SyncErrors](#BKMK_msdyn_rma_SyncErrors)
- [msdyn_rma_DuplicateMatchingRecord](#BKMK_msdyn_rma_DuplicateMatchingRecord)
- [msdyn_rma_DuplicateBaseRecord](#BKMK_msdyn_rma_DuplicateBaseRecord)
- [msdyn_rma_SharePointDocumentLocations](#BKMK_msdyn_rma_SharePointDocumentLocations)
- [msdyn_rma_SharePointDocuments](#BKMK_msdyn_rma_SharePointDocuments)
- [msdyn_rma_AsyncOperations](#BKMK_msdyn_rma_AsyncOperations)
- [msdyn_rma_MailboxTrackingFolders](#BKMK_msdyn_rma_MailboxTrackingFolders)
- [msdyn_rma_UserEntityInstanceDatas](#BKMK_msdyn_rma_UserEntityInstanceDatas)
- [msdyn_rma_ProcessSession](#BKMK_msdyn_rma_ProcessSession)
- [msdyn_rma_BulkDeleteFailures](#BKMK_msdyn_rma_BulkDeleteFailures)
- [msdyn_rma_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rma_PrincipalObjectAttributeAccesses)
- [msdyn_rma_Appointments](#BKMK_msdyn_rma_Appointments)
- [msdyn_rma_Emails](#BKMK_msdyn_rma_Emails)
- [msdyn_rma_Faxes](#BKMK_msdyn_rma_Faxes)
- [msdyn_rma_Letters](#BKMK_msdyn_rma_Letters)
- [msdyn_rma_PhoneCalls](#BKMK_msdyn_rma_PhoneCalls)
- [msdyn_rma_Tasks](#BKMK_msdyn_rma_Tasks)
- [msdyn_rma_RecurringAppointmentMasters](#BKMK_msdyn_rma_RecurringAppointmentMasters)
- [msdyn_rma_SocialActivities](#BKMK_msdyn_rma_SocialActivities)
- [msdyn_rma_connections1](#BKMK_msdyn_rma_connections1)
- [msdyn_rma_connections2](#BKMK_msdyn_rma_connections2)
- [msdyn_rma_Annotations](#BKMK_msdyn_rma_Annotations)
- [msdyn_rma_ServiceAppointments](#BKMK_msdyn_rma_ServiceAppointments)
- [msdyn_msdyn_rma_msdyn_rmaproduct_RMA](#BKMK_msdyn_msdyn_rma_msdyn_rmaproduct_RMA)
- [msdyn_msdyn_rma_msdyn_rmareceipt_RMA](#BKMK_msdyn_msdyn_rma_msdyn_rmareceipt_RMA)
- [msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA](#BKMK_msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA)
- [msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA](#BKMK_msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA)
- [msdyn_msdyn_rma_msdyn_rtvproduct_RMA](#BKMK_msdyn_msdyn_rma_msdyn_rtvproduct_RMA)


### <a name="BKMK_msdyn_rma_ActivityPointers"></a> msdyn_rma_ActivityPointers

Same as activitypointer entity [msdyn_rma_ActivityPointers](activitypointer.md#BKMK_msdyn_rma_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_ActivityPointers<br />
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


### <a name="BKMK_msdyn_rma_msdyn_approvals"></a> msdyn_rma_msdyn_approvals

Same as msdyn_approval entity [msdyn_rma_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_rma_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_rma_msdyn_bookingalerts"></a> msdyn_rma_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_rma_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_rma_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_rma_SyncErrors"></a> msdyn_rma_SyncErrors

Same as syncerror entity [msdyn_rma_SyncErrors](syncerror.md#BKMK_msdyn_rma_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_SyncErrors<br />
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


### <a name="BKMK_msdyn_rma_DuplicateMatchingRecord"></a> msdyn_rma_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_rma_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_rma_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_rma_DuplicateBaseRecord"></a> msdyn_rma_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_rma_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_rma_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_rma_SharePointDocumentLocations"></a> msdyn_rma_SharePointDocumentLocations

Same as sharepointdocumentlocation entity [msdyn_rma_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_rma_SharePointDocumentLocations) Many-To-One relationship.

**ReferencingEntity**: sharepointdocumentlocation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_SharePointDocumentLocations<br />
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


### <a name="BKMK_msdyn_rma_SharePointDocuments"></a> msdyn_rma_SharePointDocuments

Same as sharepointdocument entity [msdyn_rma_SharePointDocuments](sharepointdocument.md#BKMK_msdyn_rma_SharePointDocuments) Many-To-One relationship.

**ReferencingEntity**: sharepointdocument<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_SharePointDocuments<br />
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


### <a name="BKMK_msdyn_rma_AsyncOperations"></a> msdyn_rma_AsyncOperations

Same as asyncoperation entity [msdyn_rma_AsyncOperations](asyncoperation.md#BKMK_msdyn_rma_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_AsyncOperations<br />
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


### <a name="BKMK_msdyn_rma_MailboxTrackingFolders"></a> msdyn_rma_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_rma_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_rma_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_rma_UserEntityInstanceDatas"></a> msdyn_rma_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_rma_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_rma_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_rma_ProcessSession"></a> msdyn_rma_ProcessSession

Same as processsession entity [msdyn_rma_ProcessSession](processsession.md#BKMK_msdyn_rma_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_ProcessSession<br />
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


### <a name="BKMK_msdyn_rma_BulkDeleteFailures"></a> msdyn_rma_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_rma_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_rma_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_rma_PrincipalObjectAttributeAccesses"></a> msdyn_rma_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_rma_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_rma_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_rma_Appointments"></a> msdyn_rma_Appointments

Same as appointment entity [msdyn_rma_Appointments](appointment.md#BKMK_msdyn_rma_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_Appointments<br />
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


### <a name="BKMK_msdyn_rma_Emails"></a> msdyn_rma_Emails

Same as email entity [msdyn_rma_Emails](email.md#BKMK_msdyn_rma_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_Emails<br />
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


### <a name="BKMK_msdyn_rma_Faxes"></a> msdyn_rma_Faxes

Same as fax entity [msdyn_rma_Faxes](fax.md#BKMK_msdyn_rma_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_Faxes<br />
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


### <a name="BKMK_msdyn_rma_Letters"></a> msdyn_rma_Letters

Same as letter entity [msdyn_rma_Letters](letter.md#BKMK_msdyn_rma_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_Letters<br />
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


### <a name="BKMK_msdyn_rma_PhoneCalls"></a> msdyn_rma_PhoneCalls

Same as phonecall entity [msdyn_rma_PhoneCalls](phonecall.md#BKMK_msdyn_rma_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_PhoneCalls<br />
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


### <a name="BKMK_msdyn_rma_Tasks"></a> msdyn_rma_Tasks

Same as task entity [msdyn_rma_Tasks](task.md#BKMK_msdyn_rma_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_Tasks<br />
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


### <a name="BKMK_msdyn_rma_RecurringAppointmentMasters"></a> msdyn_rma_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_rma_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_rma_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_rma_SocialActivities"></a> msdyn_rma_SocialActivities

Same as socialactivity entity [msdyn_rma_SocialActivities](socialactivity.md#BKMK_msdyn_rma_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_SocialActivities<br />
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


### <a name="BKMK_msdyn_rma_connections1"></a> msdyn_rma_connections1

Same as connection entity [msdyn_rma_connections1](connection.md#BKMK_msdyn_rma_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_connections1<br />
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


### <a name="BKMK_msdyn_rma_connections2"></a> msdyn_rma_connections2

Same as connection entity [msdyn_rma_connections2](connection.md#BKMK_msdyn_rma_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_connections2<br />
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


### <a name="BKMK_msdyn_rma_Annotations"></a> msdyn_rma_Annotations

Same as annotation entity [msdyn_rma_Annotations](annotation.md#BKMK_msdyn_rma_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_Annotations<br />
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


### <a name="BKMK_msdyn_rma_ServiceAppointments"></a> msdyn_rma_ServiceAppointments

Same as serviceappointment entity [msdyn_rma_ServiceAppointments](serviceappointment.md#BKMK_msdyn_rma_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_rma_ServiceAppointments<br />
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


### <a name="BKMK_msdyn_msdyn_rma_msdyn_rmaproduct_RMA"></a> msdyn_msdyn_rma_msdyn_rmaproduct_RMA

Same as msdyn_rmaproduct entity [msdyn_msdyn_rma_msdyn_rmaproduct_RMA](msdyn_rmaproduct.md#BKMK_msdyn_msdyn_rma_msdyn_rmaproduct_RMA) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmaproduct<br />
**ReferencingAttribute**: msdyn_rma<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_rma_msdyn_rmaproduct_RMA<br />
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


### <a name="BKMK_msdyn_msdyn_rma_msdyn_rmareceipt_RMA"></a> msdyn_msdyn_rma_msdyn_rmareceipt_RMA

Same as msdyn_rmareceipt entity [msdyn_msdyn_rma_msdyn_rmareceipt_RMA](msdyn_rmareceipt.md#BKMK_msdyn_msdyn_rma_msdyn_rmareceipt_RMA) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmareceipt<br />
**ReferencingAttribute**: msdyn_rma<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_rma_msdyn_rmareceipt_RMA<br />
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


### <a name="BKMK_msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA"></a> msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA

Same as msdyn_rmareceiptproduct entity [msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA](msdyn_rmareceiptproduct.md#BKMK_msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmareceiptproduct<br />
**ReferencingAttribute**: msdyn_rma<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA<br />
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


### <a name="BKMK_msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA"></a> msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA

Same as msdyn_rtv entity [msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA](msdyn_rtv.md#BKMK_msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtv<br />
**ReferencingAttribute**: msdyn_originatingrma<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Originating RMA
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_rma_msdyn_rtvproduct_RMA"></a> msdyn_msdyn_rma_msdyn_rtvproduct_RMA

Same as msdyn_rtvproduct entity [msdyn_msdyn_rma_msdyn_rtvproduct_RMA](msdyn_rtvproduct.md#BKMK_msdyn_msdyn_rma_msdyn_rtvproduct_RMA) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtvproduct<br />
**ReferencingAttribute**: msdyn_rma<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_rma_msdyn_rtvproduct_RMA<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_rma_createdby](#BKMK_lk_msdyn_rma_createdby)
- [lk_msdyn_rma_createdonbehalfby](#BKMK_lk_msdyn_rma_createdonbehalfby)
- [lk_msdyn_rma_modifiedby](#BKMK_lk_msdyn_rma_modifiedby)
- [lk_msdyn_rma_modifiedonbehalfby](#BKMK_lk_msdyn_rma_modifiedonbehalfby)
- [user_msdyn_rma](#BKMK_user_msdyn_rma)
- [team_msdyn_rma](#BKMK_team_msdyn_rma)
- [business_unit_msdyn_rma](#BKMK_business_unit_msdyn_rma)
- [TransactionCurrency_msdyn_rma](#BKMK_TransactionCurrency_msdyn_rma)
- [msdyn_account_msdyn_rma_BillingAccount](#BKMK_msdyn_account_msdyn_rma_BillingAccount)
- [msdyn_account_msdyn_rma_ServiceAccount](#BKMK_msdyn_account_msdyn_rma_ServiceAccount)
- [msdyn_contact_msdyn_rma_RequestedByContact](#BKMK_msdyn_contact_msdyn_rma_RequestedByContact)
- [msdyn_msdyn_rmasubstatus_msdyn_rma_SubStatus](#BKMK_msdyn_msdyn_rmasubstatus_msdyn_rma_SubStatus)
- [msdyn_msdyn_shipvia_msdyn_rma_ShipVia](#BKMK_msdyn_msdyn_shipvia_msdyn_rma_ShipVia)
- [msdyn_msdyn_taxcode_msdyn_rma_TaxCode](#BKMK_msdyn_msdyn_taxcode_msdyn_rma_TaxCode)
- [msdyn_msdyn_workorder_msdyn_rma_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_rma_WorkOrder)
- [msdyn_pricelevel_msdyn_rma_PriceList](#BKMK_msdyn_pricelevel_msdyn_rma_PriceList)
- [msdyn_systemuser_msdyn_rma_ApprovedBy](#BKMK_msdyn_systemuser_msdyn_rma_ApprovedBy)


### <a name="BKMK_lk_msdyn_rma_createdby"></a> lk_msdyn_rma_createdby

See systemuser Entity [lk_msdyn_rma_createdby](systemuser.md#BKMK_lk_msdyn_rma_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rma_createdonbehalfby"></a> lk_msdyn_rma_createdonbehalfby

See systemuser Entity [lk_msdyn_rma_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_rma_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rma_modifiedby"></a> lk_msdyn_rma_modifiedby

See systemuser Entity [lk_msdyn_rma_modifiedby](systemuser.md#BKMK_lk_msdyn_rma_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rma_modifiedonbehalfby"></a> lk_msdyn_rma_modifiedonbehalfby

See systemuser Entity [lk_msdyn_rma_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_rma_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_rma"></a> user_msdyn_rma

See systemuser Entity [user_msdyn_rma](systemuser.md#BKMK_user_msdyn_rma) One-To-Many relationship.

### <a name="BKMK_team_msdyn_rma"></a> team_msdyn_rma

See team Entity [team_msdyn_rma](team.md#BKMK_team_msdyn_rma) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_rma"></a> business_unit_msdyn_rma

See businessunit Entity [business_unit_msdyn_rma](businessunit.md#BKMK_business_unit_msdyn_rma) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_rma"></a> TransactionCurrency_msdyn_rma

See transactioncurrency Entity [TransactionCurrency_msdyn_rma](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_rma) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_rma_BillingAccount"></a> msdyn_account_msdyn_rma_BillingAccount

See account Entity [msdyn_account_msdyn_rma_BillingAccount](account.md#BKMK_msdyn_account_msdyn_rma_BillingAccount) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_rma_ServiceAccount"></a> msdyn_account_msdyn_rma_ServiceAccount

See account Entity [msdyn_account_msdyn_rma_ServiceAccount](account.md#BKMK_msdyn_account_msdyn_rma_ServiceAccount) One-To-Many relationship.

### <a name="BKMK_msdyn_contact_msdyn_rma_RequestedByContact"></a> msdyn_contact_msdyn_rma_RequestedByContact

See contact Entity [msdyn_contact_msdyn_rma_RequestedByContact](contact.md#BKMK_msdyn_contact_msdyn_rma_RequestedByContact) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_rmasubstatus_msdyn_rma_SubStatus"></a> msdyn_msdyn_rmasubstatus_msdyn_rma_SubStatus

See msdyn_rmasubstatus Entity [msdyn_msdyn_rmasubstatus_msdyn_rma_SubStatus](msdyn_rmasubstatus.md#BKMK_msdyn_msdyn_rmasubstatus_msdyn_rma_SubStatus) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_shipvia_msdyn_rma_ShipVia"></a> msdyn_msdyn_shipvia_msdyn_rma_ShipVia

See msdyn_shipvia Entity [msdyn_msdyn_shipvia_msdyn_rma_ShipVia](msdyn_shipvia.md#BKMK_msdyn_msdyn_shipvia_msdyn_rma_ShipVia) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_rma_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_rma_TaxCode

See msdyn_taxcode Entity [msdyn_msdyn_taxcode_msdyn_rma_TaxCode](msdyn_taxcode.md#BKMK_msdyn_msdyn_taxcode_msdyn_rma_TaxCode) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_rma_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_rma_WorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_msdyn_rma_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_rma_WorkOrder) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_msdyn_rma_PriceList"></a> msdyn_pricelevel_msdyn_rma_PriceList

See pricelevel Entity [msdyn_pricelevel_msdyn_rma_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_rma_PriceList) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuser_msdyn_rma_ApprovedBy"></a> msdyn_systemuser_msdyn_rma_ApprovedBy

See systemuser Entity [msdyn_systemuser_msdyn_rma_ApprovedBy](systemuser.md#BKMK_msdyn_systemuser_msdyn_rma_ApprovedBy) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_rma?text=msdyn_rma EntityType" />