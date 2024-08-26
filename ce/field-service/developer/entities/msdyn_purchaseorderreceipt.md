---
title: "Purchase Order Receipt (msdyn_purchaseorderreceipt) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Purchase Order Receipt (msdyn_purchaseorderreceipt) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Purchase Order Receipt (msdyn_purchaseorderreceipt) table/entity reference

Specify purchase order receipt.

## Messages

The following table lists the messages for the Purchase Order Receipt (msdyn_purchaseorderreceipt) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_purchaseorderreceipts(*msdyn_purchaseorderreceiptid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_purchaseorderreceipts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_purchaseorderreceipts(*msdyn_purchaseorderreceiptid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_purchaseorderreceipts(*msdyn_purchaseorderreceiptid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_purchaseorderreceipts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_purchaseorderreceipts(*msdyn_purchaseorderreceiptid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_purchaseorderreceipts(*msdyn_purchaseorderreceiptid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_purchaseorderreceipts(*msdyn_purchaseorderreceiptid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Purchase Order Receipt (msdyn_purchaseorderreceipt) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Purchase Order Receipt (msdyn_purchaseorderreceipt) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Purchase Order Receipt** |
| **DisplayCollectionName** | **Purchase Order Receipts** |
| **SchemaName** | `msdyn_purchaseorderreceipt` |
| **CollectionSchemaName** | `msdyn_purchaseorderreceipts` |
| **EntitySetName** | `msdyn_purchaseorderreceipts`|
| **LogicalName** | `msdyn_purchaseorderreceipt` |
| **LogicalCollectionName** | `msdyn_purchaseorderreceipts` |
| **PrimaryIdAttribute** | `msdyn_purchaseorderreceiptid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_DateReceived](#BKMK_msdyn_DateReceived)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Note](#BKMK_msdyn_Note)
- [msdyn_PurchaseOrder](#BKMK_msdyn_PurchaseOrder)
- [msdyn_purchaseorderreceiptId](#BKMK_msdyn_purchaseorderreceiptId)
- [msdyn_ReceivedBy](#BKMK_msdyn_ReceivedBy)
- [msdyn_ShipVia](#BKMK_msdyn_ShipVia)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [processid](#BKMK_processid)
- [stageid](#BKMK_stageid)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [traversedpath](#BKMK_traversedpath)
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

### <a name="BKMK_msdyn_DateReceived"></a> msdyn_DateReceived

|Property|Value|
|---|---|
|Description||
|DisplayName|**Date Received**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_datereceived`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Enter the name of the custom entity.**|
|DisplayName|**Name**|
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

### <a name="BKMK_msdyn_Note"></a> msdyn_Note

|Property|Value|
|---|---|
|Description||
|DisplayName|**Note**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_note`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_PurchaseOrder"></a> msdyn_PurchaseOrder

|Property|Value|
|---|---|
|Description|**Unique identifier for Purchase Order associated with Purchase Order Receipt.**|
|DisplayName|**Purchase Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_purchaseorder`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_purchaseorder|

### <a name="BKMK_msdyn_purchaseorderreceiptId"></a> msdyn_purchaseorderreceiptId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Purchase Order Receipt**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_purchaseorderreceiptid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ReceivedBy"></a> msdyn_ReceivedBy

|Property|Value|
|---|---|
|Description|**Unique identifier for User associated with Purchase Order Receipt.**|
|DisplayName|**Received By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_receivedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_ShipVia"></a> msdyn_ShipVia

|Property|Value|
|---|---|
|Description|**Unique identifier for Ship Via associated with Purchase Order Receipt.**|
|DisplayName|**Ship Via**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_shipvia`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_shipvia|

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

### <a name="BKMK_processid"></a> processid

|Property|Value|
|---|---|
|Description|**Contains the ID of the process associated with the entity.**|
|DisplayName|**Process Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_stageid"></a> stageid

|Property|Value|
|---|---|
|Description|**Contains the ID of the stage where the entity is located.**|
|DisplayName|**Stage Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Purchase Order Receipt**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_purchaseorderreceipt_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Purchase Order Receipt**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_purchaseorderreceipt_statuscode`|

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

### <a name="BKMK_traversedpath"></a> traversedpath

|Property|Value|
|---|---|
|Description|**Shows a comma-separated list of string values that represent the unique identifiers of stages in a business process flow instance in the order that they occur.**|
|DisplayName|**Traversed Path**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`traversedpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

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

- [business_unit_msdyn_purchaseorderreceipt](#BKMK_business_unit_msdyn_purchaseorderreceipt)
- [lk_msdyn_purchaseorderreceipt_createdby](#BKMK_lk_msdyn_purchaseorderreceipt_createdby)
- [lk_msdyn_purchaseorderreceipt_createdonbehalfby](#BKMK_lk_msdyn_purchaseorderreceipt_createdonbehalfby)
- [lk_msdyn_purchaseorderreceipt_modifiedby](#BKMK_lk_msdyn_purchaseorderreceipt_modifiedby)
- [lk_msdyn_purchaseorderreceipt_modifiedonbehalfby](#BKMK_lk_msdyn_purchaseorderreceipt_modifiedonbehalfby)
- [msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder](#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder)
- [msdyn_msdyn_shipvia_msdyn_purchaseorderreceipt_ShipVia](#BKMK_msdyn_msdyn_shipvia_msdyn_purchaseorderreceipt_ShipVia)
- [msdyn_systemuser_msdyn_purchaseorderreceipt_ReceivedBy](#BKMK_msdyn_systemuser_msdyn_purchaseorderreceipt_ReceivedBy)
- [owner_msdyn_purchaseorderreceipt](#BKMK_owner_msdyn_purchaseorderreceipt)
- [processstage_msdyn_purchaseorderreceipt](#BKMK_processstage_msdyn_purchaseorderreceipt)
- [team_msdyn_purchaseorderreceipt](#BKMK_team_msdyn_purchaseorderreceipt)
- [user_msdyn_purchaseorderreceipt](#BKMK_user_msdyn_purchaseorderreceipt)

### <a name="BKMK_business_unit_msdyn_purchaseorderreceipt"></a> business_unit_msdyn_purchaseorderreceipt

One-To-Many Relationship: [businessunit business_unit_msdyn_purchaseorderreceipt](businessunit.md#BKMK_business_unit_msdyn_purchaseorderreceipt)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_purchaseorderreceipt_createdby"></a> lk_msdyn_purchaseorderreceipt_createdby

One-To-Many Relationship: [systemuser lk_msdyn_purchaseorderreceipt_createdby](systemuser.md#BKMK_lk_msdyn_purchaseorderreceipt_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_purchaseorderreceipt_createdonbehalfby"></a> lk_msdyn_purchaseorderreceipt_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_purchaseorderreceipt_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_purchaseorderreceipt_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_purchaseorderreceipt_modifiedby"></a> lk_msdyn_purchaseorderreceipt_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_purchaseorderreceipt_modifiedby](systemuser.md#BKMK_lk_msdyn_purchaseorderreceipt_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_purchaseorderreceipt_modifiedonbehalfby"></a> lk_msdyn_purchaseorderreceipt_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_purchaseorderreceipt_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_purchaseorderreceipt_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder"></a> msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder

One-To-Many Relationship: [msdyn_purchaseorder msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder](msdyn_purchaseorder.md#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`msdyn_purchaseorder`|
|ReferencingEntityNavigationPropertyName|`msdyn_purchaseorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_shipvia_msdyn_purchaseorderreceipt_ShipVia"></a> msdyn_msdyn_shipvia_msdyn_purchaseorderreceipt_ShipVia

One-To-Many Relationship: [msdyn_shipvia msdyn_msdyn_shipvia_msdyn_purchaseorderreceipt_ShipVia](msdyn_shipvia.md#BKMK_msdyn_msdyn_shipvia_msdyn_purchaseorderreceipt_ShipVia)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`msdyn_shipvia`|
|ReferencingEntityNavigationPropertyName|`msdyn_shipvia`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuser_msdyn_purchaseorderreceipt_ReceivedBy"></a> msdyn_systemuser_msdyn_purchaseorderreceipt_ReceivedBy

One-To-Many Relationship: [systemuser msdyn_systemuser_msdyn_purchaseorderreceipt_ReceivedBy](systemuser.md#BKMK_msdyn_systemuser_msdyn_purchaseorderreceipt_ReceivedBy)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_receivedby`|
|ReferencingEntityNavigationPropertyName|`msdyn_receivedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_purchaseorderreceipt"></a> owner_msdyn_purchaseorderreceipt

One-To-Many Relationship: [owner owner_msdyn_purchaseorderreceipt](owner.md#BKMK_owner_msdyn_purchaseorderreceipt)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_msdyn_purchaseorderreceipt"></a> processstage_msdyn_purchaseorderreceipt

One-To-Many Relationship: [processstage processstage_msdyn_purchaseorderreceipt](processstage.md#BKMK_processstage_msdyn_purchaseorderreceipt)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_purchaseorderreceipt"></a> team_msdyn_purchaseorderreceipt

One-To-Many Relationship: [team team_msdyn_purchaseorderreceipt](team.md#BKMK_team_msdyn_purchaseorderreceipt)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_purchaseorderreceipt"></a> user_msdyn_purchaseorderreceipt

One-To-Many Relationship: [systemuser user_msdyn_purchaseorderreceipt](systemuser.md#BKMK_user_msdyn_purchaseorderreceipt)

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

- [bpf_msdyn_purchaseorderreceipt_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799](#BKMK_bpf_msdyn_purchaseorderreceipt_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799)
- [msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt](#BKMK_msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt)
- [msdyn_purchaseorderreceipt_ActivityPointers](#BKMK_msdyn_purchaseorderreceipt_ActivityPointers)
- [msdyn_purchaseorderreceipt_adx_inviteredemptions](#BKMK_msdyn_purchaseorderreceipt_adx_inviteredemptions)
- [msdyn_purchaseorderreceipt_adx_portalcomments](#BKMK_msdyn_purchaseorderreceipt_adx_portalcomments)
- [msdyn_purchaseorderreceipt_Annotations](#BKMK_msdyn_purchaseorderreceipt_Annotations)
- [msdyn_purchaseorderreceipt_Appointments](#BKMK_msdyn_purchaseorderreceipt_Appointments)
- [msdyn_purchaseorderreceipt_AsyncOperations](#BKMK_msdyn_purchaseorderreceipt_AsyncOperations)
- [msdyn_purchaseorderreceipt_BulkDeleteFailures](#BKMK_msdyn_purchaseorderreceipt_BulkDeleteFailures)
- [msdyn_purchaseorderreceipt_chats](#BKMK_msdyn_purchaseorderreceipt_chats)
- [msdyn_purchaseorderreceipt_connections1](#BKMK_msdyn_purchaseorderreceipt_connections1)
- [msdyn_purchaseorderreceipt_connections2](#BKMK_msdyn_purchaseorderreceipt_connections2)
- [msdyn_purchaseorderreceipt_DuplicateBaseRecord](#BKMK_msdyn_purchaseorderreceipt_DuplicateBaseRecord)
- [msdyn_purchaseorderreceipt_DuplicateMatchingRecord](#BKMK_msdyn_purchaseorderreceipt_DuplicateMatchingRecord)
- [msdyn_purchaseorderreceipt_Emails](#BKMK_msdyn_purchaseorderreceipt_Emails)
- [msdyn_purchaseorderreceipt_Faxes](#BKMK_msdyn_purchaseorderreceipt_Faxes)
- [msdyn_purchaseorderreceipt_Letters](#BKMK_msdyn_purchaseorderreceipt_Letters)
- [msdyn_purchaseorderreceipt_MailboxTrackingFolders](#BKMK_msdyn_purchaseorderreceipt_MailboxTrackingFolders)
- [msdyn_purchaseorderreceipt_msdyn_bookingalerts](#BKMK_msdyn_purchaseorderreceipt_msdyn_bookingalerts)
- [msdyn_purchaseorderreceipt_msdyn_copilottranscripts](#BKMK_msdyn_purchaseorderreceipt_msdyn_copilottranscripts)
- [msdyn_purchaseorderreceipt_msdyn_ocliveworkitems](#BKMK_msdyn_purchaseorderreceipt_msdyn_ocliveworkitems)
- [msdyn_purchaseorderreceipt_msdyn_ocsessions](#BKMK_msdyn_purchaseorderreceipt_msdyn_ocsessions)
- [msdyn_purchaseorderreceipt_msfp_alerts](#BKMK_msdyn_purchaseorderreceipt_msfp_alerts)
- [msdyn_purchaseorderreceipt_msfp_surveyinvites](#BKMK_msdyn_purchaseorderreceipt_msfp_surveyinvites)
- [msdyn_purchaseorderreceipt_msfp_surveyresponses](#BKMK_msdyn_purchaseorderreceipt_msfp_surveyresponses)
- [msdyn_purchaseorderreceipt_PhoneCalls](#BKMK_msdyn_purchaseorderreceipt_PhoneCalls)
- [msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseorderreceipt_ProcessSession](#BKMK_msdyn_purchaseorderreceipt_ProcessSession)
- [msdyn_purchaseorderreceipt_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorderreceipt_RecurringAppointmentMasters)
- [msdyn_purchaseorderreceipt_ServiceAppointments](#BKMK_msdyn_purchaseorderreceipt_ServiceAppointments)
- [msdyn_purchaseorderreceipt_SharePointDocumentLocations](#BKMK_msdyn_purchaseorderreceipt_SharePointDocumentLocations)
- [msdyn_purchaseorderreceipt_SocialActivities](#BKMK_msdyn_purchaseorderreceipt_SocialActivities)
- [msdyn_purchaseorderreceipt_SyncErrors](#BKMK_msdyn_purchaseorderreceipt_SyncErrors)
- [msdyn_purchaseorderreceipt_Tasks](#BKMK_msdyn_purchaseorderreceipt_Tasks)

### <a name="BKMK_bpf_msdyn_purchaseorderreceipt_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799"></a> bpf_msdyn_purchaseorderreceipt_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799

Many-To-One Relationship: [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 bpf_msdyn_purchaseorderreceipt_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_bpf_msdyn_purchaseorderreceipt_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|ReferencingAttribute|`bpf_msdyn_purchaseorderreceiptid`|
|ReferencedEntityNavigationPropertyName|`bpf_msdyn_purchaseorderreceipt_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: msdyn_purchaseorderreceipt<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt"></a> msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt

Many-To-One Relationship: [msdyn_purchaseorderreceiptproduct msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencingAttribute|`msdyn_purchaseorderreceipt`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_ActivityPointers"></a> msdyn_purchaseorderreceipt_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_purchaseorderreceipt_ActivityPointers](activitypointer.md#BKMK_msdyn_purchaseorderreceipt_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_adx_inviteredemptions"></a> msdyn_purchaseorderreceipt_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_purchaseorderreceipt_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_purchaseorderreceipt_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_adx_portalcomments"></a> msdyn_purchaseorderreceipt_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_purchaseorderreceipt_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_purchaseorderreceipt_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_Annotations"></a> msdyn_purchaseorderreceipt_Annotations

Many-To-One Relationship: [annotation msdyn_purchaseorderreceipt_Annotations](annotation.md#BKMK_msdyn_purchaseorderreceipt_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_Appointments"></a> msdyn_purchaseorderreceipt_Appointments

Many-To-One Relationship: [appointment msdyn_purchaseorderreceipt_Appointments](appointment.md#BKMK_msdyn_purchaseorderreceipt_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_AsyncOperations"></a> msdyn_purchaseorderreceipt_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_purchaseorderreceipt_AsyncOperations](asyncoperation.md#BKMK_msdyn_purchaseorderreceipt_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_BulkDeleteFailures"></a> msdyn_purchaseorderreceipt_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_purchaseorderreceipt_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_purchaseorderreceipt_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_chats"></a> msdyn_purchaseorderreceipt_chats

Many-To-One Relationship: [chat msdyn_purchaseorderreceipt_chats](chat.md#BKMK_msdyn_purchaseorderreceipt_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_connections1"></a> msdyn_purchaseorderreceipt_connections1

Many-To-One Relationship: [connection msdyn_purchaseorderreceipt_connections1](connection.md#BKMK_msdyn_purchaseorderreceipt_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_connections2"></a> msdyn_purchaseorderreceipt_connections2

Many-To-One Relationship: [connection msdyn_purchaseorderreceipt_connections2](connection.md#BKMK_msdyn_purchaseorderreceipt_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_DuplicateBaseRecord"></a> msdyn_purchaseorderreceipt_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_purchaseorderreceipt_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_purchaseorderreceipt_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_DuplicateMatchingRecord"></a> msdyn_purchaseorderreceipt_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_purchaseorderreceipt_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_purchaseorderreceipt_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_Emails"></a> msdyn_purchaseorderreceipt_Emails

Many-To-One Relationship: [email msdyn_purchaseorderreceipt_Emails](email.md#BKMK_msdyn_purchaseorderreceipt_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_Faxes"></a> msdyn_purchaseorderreceipt_Faxes

Many-To-One Relationship: [fax msdyn_purchaseorderreceipt_Faxes](fax.md#BKMK_msdyn_purchaseorderreceipt_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_Letters"></a> msdyn_purchaseorderreceipt_Letters

Many-To-One Relationship: [letter msdyn_purchaseorderreceipt_Letters](letter.md#BKMK_msdyn_purchaseorderreceipt_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_MailboxTrackingFolders"></a> msdyn_purchaseorderreceipt_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_purchaseorderreceipt_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_purchaseorderreceipt_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_msdyn_bookingalerts"></a> msdyn_purchaseorderreceipt_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_purchaseorderreceipt_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_purchaseorderreceipt_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_msdyn_copilottranscripts"></a> msdyn_purchaseorderreceipt_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_purchaseorderreceipt_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_purchaseorderreceipt_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_msdyn_ocliveworkitems"></a> msdyn_purchaseorderreceipt_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_purchaseorderreceipt_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_purchaseorderreceipt_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_msdyn_ocsessions"></a> msdyn_purchaseorderreceipt_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_purchaseorderreceipt_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_purchaseorderreceipt_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_msfp_alerts"></a> msdyn_purchaseorderreceipt_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_purchaseorderreceipt_msfp_alerts](msfp_alert.md#BKMK_msdyn_purchaseorderreceipt_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_msfp_surveyinvites"></a> msdyn_purchaseorderreceipt_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_purchaseorderreceipt_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_purchaseorderreceipt_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_msfp_surveyresponses"></a> msdyn_purchaseorderreceipt_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_purchaseorderreceipt_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_purchaseorderreceipt_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_PhoneCalls"></a> msdyn_purchaseorderreceipt_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_purchaseorderreceipt_PhoneCalls](phonecall.md#BKMK_msdyn_purchaseorderreceipt_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_ProcessSession"></a> msdyn_purchaseorderreceipt_ProcessSession

Many-To-One Relationship: [processsession msdyn_purchaseorderreceipt_ProcessSession](processsession.md#BKMK_msdyn_purchaseorderreceipt_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_RecurringAppointmentMasters"></a> msdyn_purchaseorderreceipt_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_purchaseorderreceipt_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_purchaseorderreceipt_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_ServiceAppointments"></a> msdyn_purchaseorderreceipt_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_purchaseorderreceipt_ServiceAppointments](serviceappointment.md#BKMK_msdyn_purchaseorderreceipt_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_SharePointDocumentLocations"></a> msdyn_purchaseorderreceipt_SharePointDocumentLocations

Many-To-One Relationship: [sharepointdocumentlocation msdyn_purchaseorderreceipt_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_purchaseorderreceipt_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencingEntity|`sharepointdocumentlocation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_SharePointDocumentLocations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_SocialActivities"></a> msdyn_purchaseorderreceipt_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_purchaseorderreceipt_SocialActivities](socialactivity.md#BKMK_msdyn_purchaseorderreceipt_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_SyncErrors"></a> msdyn_purchaseorderreceipt_SyncErrors

Many-To-One Relationship: [syncerror msdyn_purchaseorderreceipt_SyncErrors](syncerror.md#BKMK_msdyn_purchaseorderreceipt_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseorderreceipt_Tasks"></a> msdyn_purchaseorderreceipt_Tasks

Many-To-One Relationship: [task msdyn_purchaseorderreceipt_Tasks](task.md#BKMK_msdyn_purchaseorderreceipt_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseorderreceipt_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

