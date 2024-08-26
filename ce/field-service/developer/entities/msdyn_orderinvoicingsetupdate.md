---
title: "Order Invoicing Setup Date (msdyn_orderinvoicingsetupdate) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Order Invoicing Setup Date (msdyn_orderinvoicingsetupdate) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Order Invoicing Setup Date (msdyn_orderinvoicingsetupdate) table/entity reference



## Messages

The following table lists the messages for the Order Invoicing Setup Date (msdyn_orderinvoicingsetupdate) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_orderinvoicingsetupdates(*msdyn_orderinvoicingsetupdateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_orderinvoicingsetupdates<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_orderinvoicingsetupdates(*msdyn_orderinvoicingsetupdateid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_orderinvoicingsetupdates(*msdyn_orderinvoicingsetupdateid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_orderinvoicingsetupdates<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_orderinvoicingsetupdates(*msdyn_orderinvoicingsetupdateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_orderinvoicingsetupdates(*msdyn_orderinvoicingsetupdateid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_orderinvoicingsetupdates(*msdyn_orderinvoicingsetupdateid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Order Invoicing Setup Date (msdyn_orderinvoicingsetupdate) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Order Invoicing Setup Date (msdyn_orderinvoicingsetupdate) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Order Invoicing Setup Date** |
| **DisplayCollectionName** | **Order Invoicing Setup Dates** |
| **SchemaName** | `msdyn_orderinvoicingsetupdate` |
| **CollectionSchemaName** | `msdyn_orderinvoicingsetupdates` |
| **EntitySetName** | `msdyn_orderinvoicingsetupdates`|
| **LogicalName** | `msdyn_orderinvoicingsetupdate` |
| **LogicalCollectionName** | `msdyn_orderinvoicingsetupdates` |
| **PrimaryIdAttribute** | `msdyn_orderinvoicingsetupdateid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Invoice](#BKMK_msdyn_Invoice)
- [msdyn_InvoiceDate](#BKMK_msdyn_InvoiceDate)
- [msdyn_InvoiceSetup](#BKMK_msdyn_InvoiceSetup)
- [msdyn_InvoiceStatus](#BKMK_msdyn_InvoiceStatus)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Order](#BKMK_msdyn_Order)
- [msdyn_OrderInvoicingDate](#BKMK_msdyn_OrderInvoicingDate)
- [msdyn_orderinvoicingsetupdateId](#BKMK_msdyn_orderinvoicingsetupdateId)
- [msdyn_PostponeGenerationUntil](#BKMK_msdyn_PostponeGenerationUntil)
- [msdyn_PreviousInvoiceDate](#BKMK_msdyn_PreviousInvoiceDate)
- [msdyn_Revision](#BKMK_msdyn_Revision)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_Invoice"></a> msdyn_Invoice

|Property|Value|
|---|---|
|Description|**Shows the invoice generated for this invoice date.**|
|DisplayName|**Invoice**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_invoice`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|invoice|

### <a name="BKMK_msdyn_InvoiceDate"></a> msdyn_InvoiceDate

|Property|Value|
|---|---|
|Description|**The last day of the invoicing period.**|
|DisplayName|**Period End**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_invoicedate`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_InvoiceSetup"></a> msdyn_InvoiceSetup

|Property|Value|
|---|---|
|Description|**Invoice Setup this Invoice Date relates to**|
|DisplayName|**Invoice Setup**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_invoicesetup`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_orderinvoicingsetup|

### <a name="BKMK_msdyn_InvoiceStatus"></a> msdyn_InvoiceStatus

|Property|Value|
|---|---|
|Description|**Status of the invoice generation for this Invoice Date**|
|DisplayName|**Invoice Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_invoicestatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|690970000|
|GlobalChoiceName|`msdyn_agreementinvoicestatus`|

#### msdyn_InvoiceStatus Choices/Options

|Value|Label|
|---|---|
|690970000|**Scheduled**|
|690970001|**Processed**|
|690970002|**Canceled**|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Order"></a> msdyn_Order

|Property|Value|
|---|---|
|Description|**Order this Invoice Date relates to**|
|DisplayName|**Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_order`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|salesorder|

### <a name="BKMK_msdyn_OrderInvoicingDate"></a> msdyn_OrderInvoicingDate

|Property|Value|
|---|---|
|Description|**Reference to the Order Invoicing Date that this record relates to.**|
|DisplayName|**Order Invoicing Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_orderinvoicingdate`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_orderinvoicingdate|

### <a name="BKMK_msdyn_orderinvoicingsetupdateId"></a> msdyn_orderinvoicingsetupdateId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Order Invoicing Setup Date**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_orderinvoicingsetupdateid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_PostponeGenerationUntil"></a> msdyn_PostponeGenerationUntil

|Property|Value|
|---|---|
|Description|**Time and date used for scheduling invoice generation. Intended for internal use. Manipulating values in this field is not supported and can lead to unexpected system behavior.**|
|DisplayName|**Postpone Generation Until**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postponegenerationuntil`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_PreviousInvoiceDate"></a> msdyn_PreviousInvoiceDate

|Property|Value|
|---|---|
|Description|**The first day of the invoicing period.**|
|DisplayName|**Period Start**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_previousinvoicedate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_Revision"></a> msdyn_Revision

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Revision**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_revision`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
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
|Description|**Status of the Order Invoicing Setup Date**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_orderinvoicingsetupdate_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Order Invoicing Setup Date**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_orderinvoicingsetupdate_statuscode`|

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

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Time zone code that was in use when the record was created.**|
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
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
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
|Description|**Date and time when the record was created.**|
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
|Description|**Unique identifier of the delegate user who created the record.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

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
|Description|**Date and time when the record was modified.**|
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
|Description|**Unique identifier of the delegate user who modified the record.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

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

- [business_unit_msdyn_orderinvoicingsetupdate](#BKMK_business_unit_msdyn_orderinvoicingsetupdate)
- [lk_msdyn_orderinvoicingsetupdate_createdby](#BKMK_lk_msdyn_orderinvoicingsetupdate_createdby)
- [lk_msdyn_orderinvoicingsetupdate_createdonbehalfby](#BKMK_lk_msdyn_orderinvoicingsetupdate_createdonbehalfby)
- [lk_msdyn_orderinvoicingsetupdate_modifiedby](#BKMK_lk_msdyn_orderinvoicingsetupdate_modifiedby)
- [lk_msdyn_orderinvoicingsetupdate_modifiedonbehalfby](#BKMK_lk_msdyn_orderinvoicingsetupdate_modifiedonbehalfby)
- [msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice](#BKMK_msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice)
- [msdyn_msdyn_orderinvoicingdate_msdyn_orderinvoicingsetupdate_OrderInvoicingDate](#BKMK_msdyn_msdyn_orderinvoicingdate_msdyn_orderinvoicingsetupdate_OrderInvoicingDate)
- [msdyn_msdyn_orderinvoicingsetup_msdyn_orderinvoicingsetupdate_InvoiceSetup](#BKMK_msdyn_msdyn_orderinvoicingsetup_msdyn_orderinvoicingsetupdate_InvoiceSetup)
- [msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order](#BKMK_msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order)
- [owner_msdyn_orderinvoicingsetupdate](#BKMK_owner_msdyn_orderinvoicingsetupdate)
- [team_msdyn_orderinvoicingsetupdate](#BKMK_team_msdyn_orderinvoicingsetupdate)
- [user_msdyn_orderinvoicingsetupdate](#BKMK_user_msdyn_orderinvoicingsetupdate)

### <a name="BKMK_business_unit_msdyn_orderinvoicingsetupdate"></a> business_unit_msdyn_orderinvoicingsetupdate

One-To-Many Relationship: [businessunit business_unit_msdyn_orderinvoicingsetupdate](businessunit.md#BKMK_business_unit_msdyn_orderinvoicingsetupdate)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_orderinvoicingsetupdate_createdby"></a> lk_msdyn_orderinvoicingsetupdate_createdby

One-To-Many Relationship: [systemuser lk_msdyn_orderinvoicingsetupdate_createdby](systemuser.md#BKMK_lk_msdyn_orderinvoicingsetupdate_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_orderinvoicingsetupdate_createdonbehalfby"></a> lk_msdyn_orderinvoicingsetupdate_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_orderinvoicingsetupdate_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_orderinvoicingsetupdate_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_orderinvoicingsetupdate_modifiedby"></a> lk_msdyn_orderinvoicingsetupdate_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_orderinvoicingsetupdate_modifiedby](systemuser.md#BKMK_lk_msdyn_orderinvoicingsetupdate_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_orderinvoicingsetupdate_modifiedonbehalfby"></a> lk_msdyn_orderinvoicingsetupdate_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_orderinvoicingsetupdate_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_orderinvoicingsetupdate_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice"></a> msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice

One-To-Many Relationship: [invoice msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice](invoice.md#BKMK_msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`msdyn_invoice`|
|ReferencingEntityNavigationPropertyName|`msdyn_Invoice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_orderinvoicingdate_msdyn_orderinvoicingsetupdate_OrderInvoicingDate"></a> msdyn_msdyn_orderinvoicingdate_msdyn_orderinvoicingsetupdate_OrderInvoicingDate

One-To-Many Relationship: [msdyn_orderinvoicingdate msdyn_msdyn_orderinvoicingdate_msdyn_orderinvoicingsetupdate_OrderInvoicingDate](msdyn_orderinvoicingdate.md#BKMK_msdyn_msdyn_orderinvoicingdate_msdyn_orderinvoicingsetupdate_OrderInvoicingDate)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingdate`|
|ReferencedAttribute|`msdyn_orderinvoicingdateid`|
|ReferencingAttribute|`msdyn_orderinvoicingdate`|
|ReferencingEntityNavigationPropertyName|`msdyn_OrderInvoicingDate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_orderinvoicingsetup_msdyn_orderinvoicingsetupdate_InvoiceSetup"></a> msdyn_msdyn_orderinvoicingsetup_msdyn_orderinvoicingsetupdate_InvoiceSetup

One-To-Many Relationship: [msdyn_orderinvoicingsetup msdyn_msdyn_orderinvoicingsetup_msdyn_orderinvoicingsetupdate_InvoiceSetup](msdyn_orderinvoicingsetup.md#BKMK_msdyn_msdyn_orderinvoicingsetup_msdyn_orderinvoicingsetupdate_InvoiceSetup)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingsetup`|
|ReferencedAttribute|`msdyn_orderinvoicingsetupid`|
|ReferencingAttribute|`msdyn_invoicesetup`|
|ReferencingEntityNavigationPropertyName|`msdyn_InvoiceSetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order"></a> msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order

One-To-Many Relationship: [salesorder msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order](salesorder.md#BKMK_msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`msdyn_order`|
|ReferencingEntityNavigationPropertyName|`msdyn_Order`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_orderinvoicingsetupdate"></a> owner_msdyn_orderinvoicingsetupdate

One-To-Many Relationship: [owner owner_msdyn_orderinvoicingsetupdate](owner.md#BKMK_owner_msdyn_orderinvoicingsetupdate)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_orderinvoicingsetupdate"></a> team_msdyn_orderinvoicingsetupdate

One-To-Many Relationship: [team team_msdyn_orderinvoicingsetupdate](team.md#BKMK_team_msdyn_orderinvoicingsetupdate)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_orderinvoicingsetupdate"></a> user_msdyn_orderinvoicingsetupdate

One-To-Many Relationship: [systemuser user_msdyn_orderinvoicingsetupdate](systemuser.md#BKMK_user_msdyn_orderinvoicingsetupdate)

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

- [msdyn_orderinvoicingsetupdate_AsyncOperations](#BKMK_msdyn_orderinvoicingsetupdate_AsyncOperations)
- [msdyn_orderinvoicingsetupdate_BulkDeleteFailures](#BKMK_msdyn_orderinvoicingsetupdate_BulkDeleteFailures)
- [msdyn_orderinvoicingsetupdate_DuplicateBaseRecord](#BKMK_msdyn_orderinvoicingsetupdate_DuplicateBaseRecord)
- [msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord](#BKMK_msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord)
- [msdyn_orderinvoicingsetupdate_MailboxTrackingFolders](#BKMK_msdyn_orderinvoicingsetupdate_MailboxTrackingFolders)
- [msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses)
- [msdyn_orderinvoicingsetupdate_ProcessSession](#BKMK_msdyn_orderinvoicingsetupdate_ProcessSession)
- [msdyn_orderinvoicingsetupdate_SyncErrors](#BKMK_msdyn_orderinvoicingsetupdate_SyncErrors)

### <a name="BKMK_msdyn_orderinvoicingsetupdate_AsyncOperations"></a> msdyn_orderinvoicingsetupdate_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_orderinvoicingsetupdate_AsyncOperations](asyncoperation.md#BKMK_msdyn_orderinvoicingsetupdate_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_orderinvoicingsetupdate_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_orderinvoicingsetupdate_BulkDeleteFailures"></a> msdyn_orderinvoicingsetupdate_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_orderinvoicingsetupdate_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_orderinvoicingsetupdate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_orderinvoicingsetupdate_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_orderinvoicingsetupdate_DuplicateBaseRecord"></a> msdyn_orderinvoicingsetupdate_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_orderinvoicingsetupdate_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_orderinvoicingsetupdate_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_orderinvoicingsetupdate_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord"></a> msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_orderinvoicingsetupdate_MailboxTrackingFolders"></a> msdyn_orderinvoicingsetupdate_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_orderinvoicingsetupdate_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_orderinvoicingsetupdate_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_orderinvoicingsetupdate_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses"></a> msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_orderinvoicingsetupdate_ProcessSession"></a> msdyn_orderinvoicingsetupdate_ProcessSession

Many-To-One Relationship: [processsession msdyn_orderinvoicingsetupdate_ProcessSession](processsession.md#BKMK_msdyn_orderinvoicingsetupdate_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_orderinvoicingsetupdate_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_orderinvoicingsetupdate_SyncErrors"></a> msdyn_orderinvoicingsetupdate_SyncErrors

Many-To-One Relationship: [syncerror msdyn_orderinvoicingsetupdate_SyncErrors](syncerror.md#BKMK_msdyn_orderinvoicingsetupdate_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_orderinvoicingsetupdate_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

