---
title: "RMA Receipt Product (msdyn_rmareceiptproduct) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the RMA Receipt Product (msdyn_rmareceiptproduct) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# RMA Receipt Product (msdyn_rmareceiptproduct) table/entity reference (Microsoft Dynamics 365 Field Service)

Specify RMA receipt product.

## Messages

The following table lists the messages for the RMA Receipt Product (msdyn_rmareceiptproduct) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_rmareceiptproducts(*msdyn_rmareceiptproductid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_rmareceiptproducts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_rmareceiptproducts(*msdyn_rmareceiptproductid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_rmareceiptproducts(*msdyn_rmareceiptproductid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_rmareceiptproducts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_rmareceiptproducts(*msdyn_rmareceiptproductid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_rmareceiptproducts(*msdyn_rmareceiptproductid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_rmareceiptproducts(*msdyn_rmareceiptproductid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the RMA Receipt Product (msdyn_rmareceiptproduct) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the RMA Receipt Product (msdyn_rmareceiptproduct) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **RMA Receipt Product** |
| **DisplayCollectionName** | **RMA Receipt Products** |
| **SchemaName** | `msdyn_rmareceiptproduct` |
| **CollectionSchemaName** | `msdyn_rmareceiptproducts` |
| **EntitySetName** | `msdyn_rmareceiptproducts`|
| **LogicalName** | `msdyn_rmareceiptproduct` |
| **LogicalCollectionName** | `msdyn_rmareceiptproducts` |
| **PrimaryIdAttribute** | `msdyn_rmareceiptproductid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Quantity](#BKMK_msdyn_Quantity)
- [msdyn_RMA](#BKMK_msdyn_RMA)
- [msdyn_RMAProduct](#BKMK_msdyn_RMAProduct)
- [msdyn_RMAReceipt](#BKMK_msdyn_RMAReceipt)
- [msdyn_rmareceiptproductId](#BKMK_msdyn_rmareceiptproductId)
- [msdyn_RTV](#BKMK_msdyn_RTV)
- [msdyn_RTVProduct](#BKMK_msdyn_RTVProduct)
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
|Description|**Shows the sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Enter the name of the custom entity.**|
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

### <a name="BKMK_msdyn_Quantity"></a> msdyn_Quantity

|Property|Value|
|---|---|
|Description|**Enter the quantity received.**|
|DisplayName|**Quantity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_quantity`|
|RequiredLevel|ApplicationRequired|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|

### <a name="BKMK_msdyn_RMA"></a> msdyn_RMA

|Property|Value|
|---|---|
|Description|**RMA this product relates to**|
|DisplayName|**RMA**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rma`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_rma|

### <a name="BKMK_msdyn_RMAProduct"></a> msdyn_RMAProduct

|Property|Value|
|---|---|
|Description|**RMA Product this product relates to**|
|DisplayName|**RMA Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rmaproduct`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_rmaproduct|

### <a name="BKMK_msdyn_RMAReceipt"></a> msdyn_RMAReceipt

|Property|Value|
|---|---|
|Description|**RMA Receipt this product relates to**|
|DisplayName|**RMA Receipt**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rmareceipt`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_rmareceipt|

### <a name="BKMK_msdyn_rmareceiptproductId"></a> msdyn_rmareceiptproductId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**RMA Receipt Product**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_rmareceiptproductid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_RTV"></a> msdyn_RTV

|Property|Value|
|---|---|
|Description|**RTV this product relates to (if Product Action is RTV)**|
|DisplayName|**RTV**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rtv`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_rtv|

### <a name="BKMK_msdyn_RTVProduct"></a> msdyn_RTVProduct

|Property|Value|
|---|---|
|Description|**RTV Product this product relates to (if Product Action is RTV)**|
|DisplayName|**RTV Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rtvproduct`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_rtvproduct|

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
|Description|**Status of the RMA Receipt Product**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_rmareceiptproduct_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the RMA Receipt Product**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_rmareceiptproduct_statuscode`|

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

- [business_unit_msdyn_rmareceiptproduct](#BKMK_business_unit_msdyn_rmareceiptproduct)
- [lk_msdyn_rmareceiptproduct_createdby](#BKMK_lk_msdyn_rmareceiptproduct_createdby)
- [lk_msdyn_rmareceiptproduct_createdonbehalfby](#BKMK_lk_msdyn_rmareceiptproduct_createdonbehalfby)
- [lk_msdyn_rmareceiptproduct_modifiedby](#BKMK_lk_msdyn_rmareceiptproduct_modifiedby)
- [lk_msdyn_rmareceiptproduct_modifiedonbehalfby](#BKMK_lk_msdyn_rmareceiptproduct_modifiedonbehalfby)
- [msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA](#BKMK_msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA)
- [msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct](#BKMK_msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct)
- [msdyn_msdyn_rmareceipt_msdyn_rmareceiptproduct_RMAReceipt](#BKMK_msdyn_msdyn_rmareceipt_msdyn_rmareceiptproduct_RMAReceipt)
- [msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV](#BKMK_msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV)
- [msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct](#BKMK_msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct)
- [owner_msdyn_rmareceiptproduct](#BKMK_owner_msdyn_rmareceiptproduct)
- [team_msdyn_rmareceiptproduct](#BKMK_team_msdyn_rmareceiptproduct)
- [user_msdyn_rmareceiptproduct](#BKMK_user_msdyn_rmareceiptproduct)

### <a name="BKMK_business_unit_msdyn_rmareceiptproduct"></a> business_unit_msdyn_rmareceiptproduct

One-To-Many Relationship: [businessunit business_unit_msdyn_rmareceiptproduct](businessunit.md#BKMK_business_unit_msdyn_rmareceiptproduct)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_rmareceiptproduct_createdby"></a> lk_msdyn_rmareceiptproduct_createdby

One-To-Many Relationship: [systemuser lk_msdyn_rmareceiptproduct_createdby](systemuser.md#BKMK_lk_msdyn_rmareceiptproduct_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_rmareceiptproduct_createdonbehalfby"></a> lk_msdyn_rmareceiptproduct_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_rmareceiptproduct_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_rmareceiptproduct_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_rmareceiptproduct_modifiedby"></a> lk_msdyn_rmareceiptproduct_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_rmareceiptproduct_modifiedby](systemuser.md#BKMK_lk_msdyn_rmareceiptproduct_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_rmareceiptproduct_modifiedonbehalfby"></a> lk_msdyn_rmareceiptproduct_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_rmareceiptproduct_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_rmareceiptproduct_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA"></a> msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA

One-To-Many Relationship: [msdyn_rma msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA](msdyn_rma.md#BKMK_msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`msdyn_rma`|
|ReferencingEntityNavigationPropertyName|`msdyn_rma`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct"></a> msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct

One-To-Many Relationship: [msdyn_rmaproduct msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct](msdyn_rmaproduct.md#BKMK_msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`msdyn_rmaproduct`|
|ReferencingEntityNavigationPropertyName|`msdyn_rmaproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_rmareceipt_msdyn_rmareceiptproduct_RMAReceipt"></a> msdyn_msdyn_rmareceipt_msdyn_rmareceiptproduct_RMAReceipt

One-To-Many Relationship: [msdyn_rmareceipt msdyn_msdyn_rmareceipt_msdyn_rmareceiptproduct_RMAReceipt](msdyn_rmareceipt.md#BKMK_msdyn_msdyn_rmareceipt_msdyn_rmareceiptproduct_RMAReceipt)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`msdyn_rmareceipt`|
|ReferencingEntityNavigationPropertyName|`msdyn_rmareceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV"></a> msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV

One-To-Many Relationship: [msdyn_rtv msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV](msdyn_rtv.md#BKMK_msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`msdyn_rtv`|
|ReferencingEntityNavigationPropertyName|`msdyn_rtv`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct"></a> msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct

One-To-Many Relationship: [msdyn_rtvproduct msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct](msdyn_rtvproduct.md#BKMK_msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`msdyn_rtvproduct`|
|ReferencingEntityNavigationPropertyName|`msdyn_rtvproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_rmareceiptproduct"></a> owner_msdyn_rmareceiptproduct

One-To-Many Relationship: [owner owner_msdyn_rmareceiptproduct](owner.md#BKMK_owner_msdyn_rmareceiptproduct)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_rmareceiptproduct"></a> team_msdyn_rmareceiptproduct

One-To-Many Relationship: [team team_msdyn_rmareceiptproduct](team.md#BKMK_team_msdyn_rmareceiptproduct)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_rmareceiptproduct"></a> user_msdyn_rmareceiptproduct

One-To-Many Relationship: [systemuser user_msdyn_rmareceiptproduct](systemuser.md#BKMK_user_msdyn_rmareceiptproduct)

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

- [msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct](#BKMK_msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct)
- [msdyn_rmareceiptproduct_ActivityPointers](#BKMK_msdyn_rmareceiptproduct_ActivityPointers)
- [msdyn_rmareceiptproduct_adx_inviteredemptions](#BKMK_msdyn_rmareceiptproduct_adx_inviteredemptions)
- [msdyn_rmareceiptproduct_adx_portalcomments](#BKMK_msdyn_rmareceiptproduct_adx_portalcomments)
- [msdyn_rmareceiptproduct_Annotations](#BKMK_msdyn_rmareceiptproduct_Annotations)
- [msdyn_rmareceiptproduct_Appointments](#BKMK_msdyn_rmareceiptproduct_Appointments)
- [msdyn_rmareceiptproduct_AsyncOperations](#BKMK_msdyn_rmareceiptproduct_AsyncOperations)
- [msdyn_rmareceiptproduct_BulkDeleteFailures](#BKMK_msdyn_rmareceiptproduct_BulkDeleteFailures)
- [msdyn_rmareceiptproduct_chats](#BKMK_msdyn_rmareceiptproduct_chats)
- [msdyn_rmareceiptproduct_connections1](#BKMK_msdyn_rmareceiptproduct_connections1)
- [msdyn_rmareceiptproduct_connections2](#BKMK_msdyn_rmareceiptproduct_connections2)
- [msdyn_rmareceiptproduct_DuplicateBaseRecord](#BKMK_msdyn_rmareceiptproduct_DuplicateBaseRecord)
- [msdyn_rmareceiptproduct_DuplicateMatchingRecord](#BKMK_msdyn_rmareceiptproduct_DuplicateMatchingRecord)
- [msdyn_rmareceiptproduct_Emails](#BKMK_msdyn_rmareceiptproduct_Emails)
- [msdyn_rmareceiptproduct_Faxes](#BKMK_msdyn_rmareceiptproduct_Faxes)
- [msdyn_rmareceiptproduct_Letters](#BKMK_msdyn_rmareceiptproduct_Letters)
- [msdyn_rmareceiptproduct_MailboxTrackingFolders](#BKMK_msdyn_rmareceiptproduct_MailboxTrackingFolders)
- [msdyn_rmareceiptproduct_msdyn_bookingalerts](#BKMK_msdyn_rmareceiptproduct_msdyn_bookingalerts)
- [msdyn_rmareceiptproduct_msdyn_copilottranscripts](#BKMK_msdyn_rmareceiptproduct_msdyn_copilottranscripts)
- [msdyn_rmareceiptproduct_msdyn_ocliveworkitems](#BKMK_msdyn_rmareceiptproduct_msdyn_ocliveworkitems)
- [msdyn_rmareceiptproduct_msdyn_ocsessions](#BKMK_msdyn_rmareceiptproduct_msdyn_ocsessions)
- [msdyn_rmareceiptproduct_msfp_alerts](#BKMK_msdyn_rmareceiptproduct_msfp_alerts)
- [msdyn_rmareceiptproduct_msfp_surveyinvites](#BKMK_msdyn_rmareceiptproduct_msfp_surveyinvites)
- [msdyn_rmareceiptproduct_msfp_surveyresponses](#BKMK_msdyn_rmareceiptproduct_msfp_surveyresponses)
- [msdyn_rmareceiptproduct_PhoneCalls](#BKMK_msdyn_rmareceiptproduct_PhoneCalls)
- [msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses)
- [msdyn_rmareceiptproduct_ProcessSession](#BKMK_msdyn_rmareceiptproduct_ProcessSession)
- [msdyn_rmareceiptproduct_RecurringAppointmentMasters](#BKMK_msdyn_rmareceiptproduct_RecurringAppointmentMasters)
- [msdyn_rmareceiptproduct_ServiceAppointments](#BKMK_msdyn_rmareceiptproduct_ServiceAppointments)
- [msdyn_rmareceiptproduct_SocialActivities](#BKMK_msdyn_rmareceiptproduct_SocialActivities)
- [msdyn_rmareceiptproduct_SyncErrors](#BKMK_msdyn_rmareceiptproduct_SyncErrors)
- [msdyn_rmareceiptproduct_Tasks](#BKMK_msdyn_rmareceiptproduct_Tasks)

### <a name="BKMK_msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct"></a> msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct

Many-To-One Relationship: [msdyn_inventoryjournal msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct](msdyn_inventoryjournal.md#BKMK_msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryjournal`|
|ReferencingAttribute|`msdyn_rmareceiptproduct`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_ActivityPointers"></a> msdyn_rmareceiptproduct_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_rmareceiptproduct_ActivityPointers](activitypointer.md#BKMK_msdyn_rmareceiptproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_adx_inviteredemptions"></a> msdyn_rmareceiptproduct_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_rmareceiptproduct_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_rmareceiptproduct_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_adx_portalcomments"></a> msdyn_rmareceiptproduct_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_rmareceiptproduct_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_rmareceiptproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_Annotations"></a> msdyn_rmareceiptproduct_Annotations

Many-To-One Relationship: [annotation msdyn_rmareceiptproduct_Annotations](annotation.md#BKMK_msdyn_rmareceiptproduct_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_Appointments"></a> msdyn_rmareceiptproduct_Appointments

Many-To-One Relationship: [appointment msdyn_rmareceiptproduct_Appointments](appointment.md#BKMK_msdyn_rmareceiptproduct_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_AsyncOperations"></a> msdyn_rmareceiptproduct_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_rmareceiptproduct_AsyncOperations](asyncoperation.md#BKMK_msdyn_rmareceiptproduct_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_BulkDeleteFailures"></a> msdyn_rmareceiptproduct_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_rmareceiptproduct_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_rmareceiptproduct_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_chats"></a> msdyn_rmareceiptproduct_chats

Many-To-One Relationship: [chat msdyn_rmareceiptproduct_chats](chat.md#BKMK_msdyn_rmareceiptproduct_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_connections1"></a> msdyn_rmareceiptproduct_connections1

Many-To-One Relationship: [connection msdyn_rmareceiptproduct_connections1](connection.md#BKMK_msdyn_rmareceiptproduct_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_connections2"></a> msdyn_rmareceiptproduct_connections2

Many-To-One Relationship: [connection msdyn_rmareceiptproduct_connections2](connection.md#BKMK_msdyn_rmareceiptproduct_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_DuplicateBaseRecord"></a> msdyn_rmareceiptproduct_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_rmareceiptproduct_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_rmareceiptproduct_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_DuplicateMatchingRecord"></a> msdyn_rmareceiptproduct_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_rmareceiptproduct_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_rmareceiptproduct_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_Emails"></a> msdyn_rmareceiptproduct_Emails

Many-To-One Relationship: [email msdyn_rmareceiptproduct_Emails](email.md#BKMK_msdyn_rmareceiptproduct_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_Faxes"></a> msdyn_rmareceiptproduct_Faxes

Many-To-One Relationship: [fax msdyn_rmareceiptproduct_Faxes](fax.md#BKMK_msdyn_rmareceiptproduct_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_Letters"></a> msdyn_rmareceiptproduct_Letters

Many-To-One Relationship: [letter msdyn_rmareceiptproduct_Letters](letter.md#BKMK_msdyn_rmareceiptproduct_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_MailboxTrackingFolders"></a> msdyn_rmareceiptproduct_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_rmareceiptproduct_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_rmareceiptproduct_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_msdyn_bookingalerts"></a> msdyn_rmareceiptproduct_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_rmareceiptproduct_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_rmareceiptproduct_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_msdyn_copilottranscripts"></a> msdyn_rmareceiptproduct_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_rmareceiptproduct_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_rmareceiptproduct_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_msdyn_ocliveworkitems"></a> msdyn_rmareceiptproduct_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_rmareceiptproduct_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_rmareceiptproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_msdyn_ocsessions"></a> msdyn_rmareceiptproduct_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_rmareceiptproduct_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_rmareceiptproduct_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_msfp_alerts"></a> msdyn_rmareceiptproduct_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_rmareceiptproduct_msfp_alerts](msfp_alert.md#BKMK_msdyn_rmareceiptproduct_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_msfp_surveyinvites"></a> msdyn_rmareceiptproduct_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_rmareceiptproduct_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_rmareceiptproduct_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_msfp_surveyresponses"></a> msdyn_rmareceiptproduct_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_rmareceiptproduct_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_rmareceiptproduct_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_PhoneCalls"></a> msdyn_rmareceiptproduct_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_rmareceiptproduct_PhoneCalls](phonecall.md#BKMK_msdyn_rmareceiptproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses"></a> msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_ProcessSession"></a> msdyn_rmareceiptproduct_ProcessSession

Many-To-One Relationship: [processsession msdyn_rmareceiptproduct_ProcessSession](processsession.md#BKMK_msdyn_rmareceiptproduct_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_RecurringAppointmentMasters"></a> msdyn_rmareceiptproduct_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_rmareceiptproduct_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_rmareceiptproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_ServiceAppointments"></a> msdyn_rmareceiptproduct_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_rmareceiptproduct_ServiceAppointments](serviceappointment.md#BKMK_msdyn_rmareceiptproduct_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_SocialActivities"></a> msdyn_rmareceiptproduct_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_rmareceiptproduct_SocialActivities](socialactivity.md#BKMK_msdyn_rmareceiptproduct_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_SyncErrors"></a> msdyn_rmareceiptproduct_SyncErrors

Many-To-One Relationship: [syncerror msdyn_rmareceiptproduct_SyncErrors](syncerror.md#BKMK_msdyn_rmareceiptproduct_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rmareceiptproduct_Tasks"></a> msdyn_rmareceiptproduct_Tasks

Many-To-One Relationship: [task msdyn_rmareceiptproduct_Tasks](task.md#BKMK_msdyn_rmareceiptproduct_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rmareceiptproduct_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

