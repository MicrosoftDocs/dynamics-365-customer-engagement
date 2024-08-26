---
title: "RMA (msdyn_rma) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the RMA (msdyn_rma) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# RMA (msdyn_rma) table/entity reference

Records RMAs for products to be retuned from customers

## Messages

The following table lists the messages for the RMA (msdyn_rma) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_rmas(*msdyn_rmaid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_rmas<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_rmas(*msdyn_rmaid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_rmas(*msdyn_rmaid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_rmas<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_rmas(*msdyn_rmaid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_rmas(*msdyn_rmaid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_rmas(*msdyn_rmaid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the RMA (msdyn_rma) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the RMA (msdyn_rma) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **RMA** |
| **DisplayCollectionName** | **RMAs** |
| **SchemaName** | `msdyn_rma` |
| **CollectionSchemaName** | `msdyn_rmas` |
| **EntitySetName** | `msdyn_rmas`|
| **LogicalName** | `msdyn_rma` |
| **LogicalCollectionName** | `msdyn_rmas` |
| **PrimaryIdAttribute** | `msdyn_rmaid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ApprovedBy](#BKMK_msdyn_ApprovedBy)
- [msdyn_AutoNumbering](#BKMK_msdyn_AutoNumbering)
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

|Property|Value|
|---|---|
|Description|**Shows the sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_ApprovedBy"></a> msdyn_ApprovedBy

|Property|Value|
|---|---|
|Description|**User who approved RMA**|
|DisplayName|**Approved By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_approvedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_AutoNumbering"></a> msdyn_AutoNumbering

|Property|Value|
|---|---|
|Description|**Internal field used to generate the next name upon entity creation. It is optionally copied to the msdyn_name field.**|
|DisplayName|**Auto-Numbering**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autonumbering`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_BillingAccount"></a> msdyn_BillingAccount

|Property|Value|
|---|---|
|Description|**Account to be billed. If a billing account has been set on service account it will be populated by default. Otherwise, the billing account will be the same as the service account.**|
|DisplayName|**Billing Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_billingaccount`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_msdyn_DateRequested"></a> msdyn_DateRequested

|Property|Value|
|---|---|
|Description|**Enter the date RMA was requested by the customer.**|
|DisplayName|**Date Requested**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_daterequested`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|---|---|
|Description|**Enter a short description of the RMA.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ETA"></a> msdyn_ETA

|Property|Value|
|---|---|
|Description|**ETA**|
|DisplayName|**ETA**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_eta`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Shows the unique number identifying this RMA record.**|
|DisplayName|**RMA Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_PackagingTrackingNo"></a> msdyn_PackagingTrackingNo

|Property|Value|
|---|---|
|Description|**Shows the tracking number of package**|
|DisplayName|**Packaging Tracking No**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_packagingtrackingno`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

|Property|Value|
|---|---|
|Description|**Price List that determines the pricing for this product**|
|DisplayName|**Price List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pricelist`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|pricelevel|

### <a name="BKMK_msdyn_ProcessingAction"></a> msdyn_ProcessingAction

|Property|Value|
|---|---|
|Description|**Shows the default action to be taken on all RMA Products.**|
|DisplayName|**Processing Action**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_processingaction`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_rmaprocessingaction`|

#### msdyn_ProcessingAction Choices/Options

|Value|Label|
|---|---|
|690970000|**Create RTV**|
|690970001|**Return to Warehouse**|
|690970002|**Change Asset Ownership**|

### <a name="BKMK_msdyn_ReferenceNo"></a> msdyn_ReferenceNo

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reference No**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_referenceno`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_RequestedByContact"></a> msdyn_RequestedByContact

|Property|Value|
|---|---|
|Description|**Contact who requested this return**|
|DisplayName|**Requested By Contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_requestedbycontact`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msdyn_rmaId"></a> msdyn_rmaId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**RMA**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_rmaid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ServiceAccount"></a> msdyn_ServiceAccount

|Property|Value|
|---|---|
|Description|**Account to be serviced**|
|DisplayName|**Service Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_serviceaccount`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_msdyn_ShippingTrackingNo"></a> msdyn_ShippingTrackingNo

|Property|Value|
|---|---|
|Description|**Shows the tracking number of the shipment.**|
|DisplayName|**Shipping Tracking No**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_shippingtrackingno`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ShipVia"></a> msdyn_ShipVia

|Property|Value|
|---|---|
|Description|**Method of shipment by Customer**|
|DisplayName|**Ship Via**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_shipvia`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_shipvia|

### <a name="BKMK_msdyn_SubStatus"></a> msdyn_SubStatus

|Property|Value|
|---|---|
|Description|**RMA Substatus**|
|DisplayName|**Substatus**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_substatus`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_rmasubstatus|

### <a name="BKMK_msdyn_SystemStatus"></a> msdyn_SystemStatus

|Property|Value|
|---|---|
|Description|**Enter the current status of the RMA.**|
|DisplayName|**System Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_systemstatus`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|690970000|
|GlobalChoiceName|`msdyn_rmasystemstatus`|

#### msdyn_SystemStatus Choices/Options

|Value|Label|
|---|---|
|690970000|**Pending**|
|690970001|**Canceled**|
|690970002|**Products Received**|

### <a name="BKMK_msdyn_Taxable"></a> msdyn_Taxable

|Property|Value|
|---|---|
|Description|**Specify if RMA is taxable**|
|DisplayName|**Taxable**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_taxable`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_rma_msdyn_taxable`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_TaxCode"></a> msdyn_TaxCode

|Property|Value|
|---|---|
|Description|**Tax Code to be used to calculate tax when RMA is taxable. By default the system will use the tax code specified on the service account**|
|DisplayName|**Tax Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_taxcode`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_taxcode|

### <a name="BKMK_msdyn_TotalAmount"></a> msdyn_TotalAmount

|Property|Value|
|---|---|
|Description|**Shows the total amount of all RMA Products including tax.**|
|DisplayName|**Total Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|0 (Precision property)|

### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

|Property|Value|
|---|---|
|Description|**Work Order this RMA is linked to**|
|DisplayName|**Work Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorder`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_workorder|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Shows the date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the RMA**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_rma_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the RMA**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_rma_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Unique identifier of the currency associated with the entity.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Shows the time zone code that was in use when the record was created.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdyn_totalamount_Base](#BKMK_msdyn_totalamount_Base)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Shows who created the record on behalf of another user.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Shows the exchange rate for the currency associated with the entity with respect to the base currency.**|
|DisplayName|**Exchange Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-10|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Shows who last updated the record on behalf of another user.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_totalamount_Base"></a> msdyn_totalamount_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the total amount in the base currency.**|
|DisplayName|**Total Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|0 (Precision property)|

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record.**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [business_unit_msdyn_rma](#BKMK_business_unit_msdyn_rma)
- [lk_msdyn_rma_createdby](#BKMK_lk_msdyn_rma_createdby)
- [lk_msdyn_rma_createdonbehalfby](#BKMK_lk_msdyn_rma_createdonbehalfby)
- [lk_msdyn_rma_modifiedby](#BKMK_lk_msdyn_rma_modifiedby)
- [lk_msdyn_rma_modifiedonbehalfby](#BKMK_lk_msdyn_rma_modifiedonbehalfby)
- [msdyn_account_msdyn_rma_BillingAccount](#BKMK_msdyn_account_msdyn_rma_BillingAccount)
- [msdyn_account_msdyn_rma_ServiceAccount](#BKMK_msdyn_account_msdyn_rma_ServiceAccount)
- [msdyn_contact_msdyn_rma_RequestedByContact](#BKMK_msdyn_contact_msdyn_rma_RequestedByContact)
- [msdyn_msdyn_rmasubstatus_msdyn_rma_SubStatus](#BKMK_msdyn_msdyn_rmasubstatus_msdyn_rma_SubStatus)
- [msdyn_msdyn_shipvia_msdyn_rma_ShipVia](#BKMK_msdyn_msdyn_shipvia_msdyn_rma_ShipVia)
- [msdyn_msdyn_taxcode_msdyn_rma_TaxCode](#BKMK_msdyn_msdyn_taxcode_msdyn_rma_TaxCode)
- [msdyn_msdyn_workorder_msdyn_rma_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_rma_WorkOrder)
- [msdyn_pricelevel_msdyn_rma_PriceList](#BKMK_msdyn_pricelevel_msdyn_rma_PriceList)
- [msdyn_systemuser_msdyn_rma_ApprovedBy](#BKMK_msdyn_systemuser_msdyn_rma_ApprovedBy)
- [owner_msdyn_rma](#BKMK_owner_msdyn_rma)
- [team_msdyn_rma](#BKMK_team_msdyn_rma)
- [TransactionCurrency_msdyn_rma](#BKMK_TransactionCurrency_msdyn_rma)
- [user_msdyn_rma](#BKMK_user_msdyn_rma)

### <a name="BKMK_business_unit_msdyn_rma"></a> business_unit_msdyn_rma

One-To-Many Relationship: [businessunit business_unit_msdyn_rma](businessunit.md#BKMK_business_unit_msdyn_rma)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_rma_createdby"></a> lk_msdyn_rma_createdby

One-To-Many Relationship: [systemuser lk_msdyn_rma_createdby](systemuser.md#BKMK_lk_msdyn_rma_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_rma_createdonbehalfby"></a> lk_msdyn_rma_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_rma_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_rma_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_rma_modifiedby"></a> lk_msdyn_rma_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_rma_modifiedby](systemuser.md#BKMK_lk_msdyn_rma_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_rma_modifiedonbehalfby"></a> lk_msdyn_rma_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_rma_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_rma_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_account_msdyn_rma_BillingAccount"></a> msdyn_account_msdyn_rma_BillingAccount

One-To-Many Relationship: [account msdyn_account_msdyn_rma_BillingAccount](account.md#BKMK_msdyn_account_msdyn_rma_BillingAccount)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_billingaccount`|
|ReferencingEntityNavigationPropertyName|`msdyn_billingaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_account_msdyn_rma_ServiceAccount"></a> msdyn_account_msdyn_rma_ServiceAccount

One-To-Many Relationship: [account msdyn_account_msdyn_rma_ServiceAccount](account.md#BKMK_msdyn_account_msdyn_rma_ServiceAccount)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_serviceaccount`|
|ReferencingEntityNavigationPropertyName|`msdyn_serviceaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_contact_msdyn_rma_RequestedByContact"></a> msdyn_contact_msdyn_rma_RequestedByContact

One-To-Many Relationship: [contact msdyn_contact_msdyn_rma_RequestedByContact](contact.md#BKMK_msdyn_contact_msdyn_rma_RequestedByContact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyn_requestedbycontact`|
|ReferencingEntityNavigationPropertyName|`msdyn_requestedbycontact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_rmasubstatus_msdyn_rma_SubStatus"></a> msdyn_msdyn_rmasubstatus_msdyn_rma_SubStatus

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_msdyn_rmasubstatus_msdyn_rma_SubStatus](msdyn_rmasubstatus.md#BKMK_msdyn_msdyn_rmasubstatus_msdyn_rma_SubStatus)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`msdyn_substatus`|
|ReferencingEntityNavigationPropertyName|`msdyn_substatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_shipvia_msdyn_rma_ShipVia"></a> msdyn_msdyn_shipvia_msdyn_rma_ShipVia

One-To-Many Relationship: [msdyn_shipvia msdyn_msdyn_shipvia_msdyn_rma_ShipVia](msdyn_shipvia.md#BKMK_msdyn_msdyn_shipvia_msdyn_rma_ShipVia)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`msdyn_shipvia`|
|ReferencingEntityNavigationPropertyName|`msdyn_shipvia`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_rma_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_rma_TaxCode

One-To-Many Relationship: [msdyn_taxcode msdyn_msdyn_taxcode_msdyn_rma_TaxCode](msdyn_taxcode.md#BKMK_msdyn_msdyn_taxcode_msdyn_rma_TaxCode)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcode`|
|ReferencedAttribute|`msdyn_taxcodeid`|
|ReferencingAttribute|`msdyn_taxcode`|
|ReferencingEntityNavigationPropertyName|`msdyn_taxcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_rma_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_rma_WorkOrder

One-To-Many Relationship: [msdyn_workorder msdyn_msdyn_workorder_msdyn_rma_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_rma_WorkOrder)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencingEntityNavigationPropertyName|`msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_pricelevel_msdyn_rma_PriceList"></a> msdyn_pricelevel_msdyn_rma_PriceList

One-To-Many Relationship: [pricelevel msdyn_pricelevel_msdyn_rma_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_rma_PriceList)

|Property|Value|
|---|---|
|ReferencedEntity|`pricelevel`|
|ReferencedAttribute|`pricelevelid`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencingEntityNavigationPropertyName|`msdyn_pricelist`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuser_msdyn_rma_ApprovedBy"></a> msdyn_systemuser_msdyn_rma_ApprovedBy

One-To-Many Relationship: [systemuser msdyn_systemuser_msdyn_rma_ApprovedBy](systemuser.md#BKMK_msdyn_systemuser_msdyn_rma_ApprovedBy)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_approvedby`|
|ReferencingEntityNavigationPropertyName|`msdyn_approvedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_rma"></a> owner_msdyn_rma

One-To-Many Relationship: [owner owner_msdyn_rma](owner.md#BKMK_owner_msdyn_rma)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_rma"></a> team_msdyn_rma

One-To-Many Relationship: [team team_msdyn_rma](team.md#BKMK_team_msdyn_rma)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_msdyn_rma"></a> TransactionCurrency_msdyn_rma

One-To-Many Relationship: [transactioncurrency TransactionCurrency_msdyn_rma](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_rma)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_rma"></a> user_msdyn_rma

One-To-Many Relationship: [systemuser user_msdyn_rma](systemuser.md#BKMK_user_msdyn_rma)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_msdyn_rma_msdyn_rmaproduct_RMA](#BKMK_msdyn_msdyn_rma_msdyn_rmaproduct_RMA)
- [msdyn_msdyn_rma_msdyn_rmareceipt_RMA](#BKMK_msdyn_msdyn_rma_msdyn_rmareceipt_RMA)
- [msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA](#BKMK_msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA)
- [msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA](#BKMK_msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA)
- [msdyn_msdyn_rma_msdyn_rtvproduct_RMA](#BKMK_msdyn_msdyn_rma_msdyn_rtvproduct_RMA)
- [msdyn_rma_ActivityPointers](#BKMK_msdyn_rma_ActivityPointers)
- [msdyn_rma_adx_inviteredemptions](#BKMK_msdyn_rma_adx_inviteredemptions)
- [msdyn_rma_adx_portalcomments](#BKMK_msdyn_rma_adx_portalcomments)
- [msdyn_rma_Annotations](#BKMK_msdyn_rma_Annotations)
- [msdyn_rma_Appointments](#BKMK_msdyn_rma_Appointments)
- [msdyn_rma_AsyncOperations](#BKMK_msdyn_rma_AsyncOperations)
- [msdyn_rma_BulkDeleteFailures](#BKMK_msdyn_rma_BulkDeleteFailures)
- [msdyn_rma_chats](#BKMK_msdyn_rma_chats)
- [msdyn_rma_connections1](#BKMK_msdyn_rma_connections1)
- [msdyn_rma_connections2](#BKMK_msdyn_rma_connections2)
- [msdyn_rma_DuplicateBaseRecord](#BKMK_msdyn_rma_DuplicateBaseRecord)
- [msdyn_rma_DuplicateMatchingRecord](#BKMK_msdyn_rma_DuplicateMatchingRecord)
- [msdyn_rma_Emails](#BKMK_msdyn_rma_Emails)
- [msdyn_rma_Faxes](#BKMK_msdyn_rma_Faxes)
- [msdyn_rma_Letters](#BKMK_msdyn_rma_Letters)
- [msdyn_rma_MailboxTrackingFolders](#BKMK_msdyn_rma_MailboxTrackingFolders)
- [msdyn_rma_msdyn_bookingalerts](#BKMK_msdyn_rma_msdyn_bookingalerts)
- [msdyn_rma_msdyn_copilottranscripts](#BKMK_msdyn_rma_msdyn_copilottranscripts)
- [msdyn_rma_msdyn_ocliveworkitems](#BKMK_msdyn_rma_msdyn_ocliveworkitems)
- [msdyn_rma_msdyn_ocsessions](#BKMK_msdyn_rma_msdyn_ocsessions)
- [msdyn_rma_msfp_alerts](#BKMK_msdyn_rma_msfp_alerts)
- [msdyn_rma_msfp_surveyinvites](#BKMK_msdyn_rma_msfp_surveyinvites)
- [msdyn_rma_msfp_surveyresponses](#BKMK_msdyn_rma_msfp_surveyresponses)
- [msdyn_rma_PhoneCalls](#BKMK_msdyn_rma_PhoneCalls)
- [msdyn_rma_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rma_PrincipalObjectAttributeAccesses)
- [msdyn_rma_ProcessSession](#BKMK_msdyn_rma_ProcessSession)
- [msdyn_rma_RecurringAppointmentMasters](#BKMK_msdyn_rma_RecurringAppointmentMasters)
- [msdyn_rma_ServiceAppointments](#BKMK_msdyn_rma_ServiceAppointments)
- [msdyn_rma_SharePointDocumentLocations](#BKMK_msdyn_rma_SharePointDocumentLocations)
- [msdyn_rma_SocialActivities](#BKMK_msdyn_rma_SocialActivities)
- [msdyn_rma_SyncErrors](#BKMK_msdyn_rma_SyncErrors)
- [msdyn_rma_Tasks](#BKMK_msdyn_rma_Tasks)

### <a name="BKMK_msdyn_msdyn_rma_msdyn_rmaproduct_RMA"></a> msdyn_msdyn_rma_msdyn_rmaproduct_RMA

Many-To-One Relationship: [msdyn_rmaproduct msdyn_msdyn_rma_msdyn_rmaproduct_RMA](msdyn_rmaproduct.md#BKMK_msdyn_msdyn_rma_msdyn_rmaproduct_RMA)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmaproduct`|
|ReferencingAttribute|`msdyn_rma`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_rma_msdyn_rmaproduct_RMA`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_rma_msdyn_rmareceipt_RMA"></a> msdyn_msdyn_rma_msdyn_rmareceipt_RMA

Many-To-One Relationship: [msdyn_rmareceipt msdyn_msdyn_rma_msdyn_rmareceipt_RMA](msdyn_rmareceipt.md#BKMK_msdyn_msdyn_rma_msdyn_rmareceipt_RMA)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmareceipt`|
|ReferencingAttribute|`msdyn_rma`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_rma_msdyn_rmareceipt_RMA`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA"></a> msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA

Many-To-One Relationship: [msdyn_rmareceiptproduct msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA](msdyn_rmareceiptproduct.md#BKMK_msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmareceiptproduct`|
|ReferencingAttribute|`msdyn_rma`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA"></a> msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA

Many-To-One Relationship: [msdyn_rtv msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA](msdyn_rtv.md#BKMK_msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtv`|
|ReferencingAttribute|`msdyn_originatingrma`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Originating RMA<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_rma_msdyn_rtvproduct_RMA"></a> msdyn_msdyn_rma_msdyn_rtvproduct_RMA

Many-To-One Relationship: [msdyn_rtvproduct msdyn_msdyn_rma_msdyn_rtvproduct_RMA](msdyn_rtvproduct.md#BKMK_msdyn_msdyn_rma_msdyn_rtvproduct_RMA)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtvproduct`|
|ReferencingAttribute|`msdyn_rma`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_rma_msdyn_rtvproduct_RMA`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_ActivityPointers"></a> msdyn_rma_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_rma_ActivityPointers](activitypointer.md#BKMK_msdyn_rma_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_adx_inviteredemptions"></a> msdyn_rma_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_rma_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_rma_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_adx_portalcomments"></a> msdyn_rma_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_rma_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_rma_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_Annotations"></a> msdyn_rma_Annotations

Many-To-One Relationship: [annotation msdyn_rma_Annotations](annotation.md#BKMK_msdyn_rma_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_Appointments"></a> msdyn_rma_Appointments

Many-To-One Relationship: [appointment msdyn_rma_Appointments](appointment.md#BKMK_msdyn_rma_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_AsyncOperations"></a> msdyn_rma_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_rma_AsyncOperations](asyncoperation.md#BKMK_msdyn_rma_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_BulkDeleteFailures"></a> msdyn_rma_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_rma_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_rma_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_chats"></a> msdyn_rma_chats

Many-To-One Relationship: [chat msdyn_rma_chats](chat.md#BKMK_msdyn_rma_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_connections1"></a> msdyn_rma_connections1

Many-To-One Relationship: [connection msdyn_rma_connections1](connection.md#BKMK_msdyn_rma_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_connections2"></a> msdyn_rma_connections2

Many-To-One Relationship: [connection msdyn_rma_connections2](connection.md#BKMK_msdyn_rma_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_DuplicateBaseRecord"></a> msdyn_rma_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_rma_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_rma_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_DuplicateMatchingRecord"></a> msdyn_rma_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_rma_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_rma_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_Emails"></a> msdyn_rma_Emails

Many-To-One Relationship: [email msdyn_rma_Emails](email.md#BKMK_msdyn_rma_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_Faxes"></a> msdyn_rma_Faxes

Many-To-One Relationship: [fax msdyn_rma_Faxes](fax.md#BKMK_msdyn_rma_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_Letters"></a> msdyn_rma_Letters

Many-To-One Relationship: [letter msdyn_rma_Letters](letter.md#BKMK_msdyn_rma_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_MailboxTrackingFolders"></a> msdyn_rma_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_rma_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_rma_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_msdyn_bookingalerts"></a> msdyn_rma_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_rma_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_rma_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_msdyn_copilottranscripts"></a> msdyn_rma_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_rma_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_rma_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_msdyn_ocliveworkitems"></a> msdyn_rma_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_rma_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_rma_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_msdyn_ocsessions"></a> msdyn_rma_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_rma_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_rma_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_msfp_alerts"></a> msdyn_rma_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_rma_msfp_alerts](msfp_alert.md#BKMK_msdyn_rma_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_msfp_surveyinvites"></a> msdyn_rma_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_rma_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_rma_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_msfp_surveyresponses"></a> msdyn_rma_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_rma_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_rma_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_PhoneCalls"></a> msdyn_rma_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_rma_PhoneCalls](phonecall.md#BKMK_msdyn_rma_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_PrincipalObjectAttributeAccesses"></a> msdyn_rma_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_rma_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_rma_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_ProcessSession"></a> msdyn_rma_ProcessSession

Many-To-One Relationship: [processsession msdyn_rma_ProcessSession](processsession.md#BKMK_msdyn_rma_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_RecurringAppointmentMasters"></a> msdyn_rma_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_rma_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_rma_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_ServiceAppointments"></a> msdyn_rma_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_rma_ServiceAppointments](serviceappointment.md#BKMK_msdyn_rma_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_SharePointDocumentLocations"></a> msdyn_rma_SharePointDocumentLocations

Many-To-One Relationship: [sharepointdocumentlocation msdyn_rma_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_rma_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencingEntity|`sharepointdocumentlocation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_SharePointDocumentLocations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_SocialActivities"></a> msdyn_rma_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_rma_SocialActivities](socialactivity.md#BKMK_msdyn_rma_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_SyncErrors"></a> msdyn_rma_SyncErrors

Many-To-One Relationship: [syncerror msdyn_rma_SyncErrors](syncerror.md#BKMK_msdyn_rma_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rma_Tasks"></a> msdyn_rma_Tasks

Many-To-One Relationship: [task msdyn_rma_Tasks](task.md#BKMK_msdyn_rma_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rma_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

