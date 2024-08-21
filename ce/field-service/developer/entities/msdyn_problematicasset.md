---
title: "Asset Suggestion (msdyn_problematicasset) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Asset Suggestion (msdyn_problematicasset) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Asset Suggestion (msdyn_problematicasset) table/entity reference

Asset Suggestions

## Messages

The following table lists the messages for the Asset Suggestion (msdyn_problematicasset) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_problematicassets(*msdyn_problematicassetid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_problematicassets<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_problematicassets(*msdyn_problematicassetid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_problematicassets(*msdyn_problematicassetid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_problematicassets<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_problematicassets(*msdyn_problematicassetid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_problematicassets(*msdyn_problematicassetid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_problematicassets(*msdyn_problematicassetid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Asset Suggestion (msdyn_problematicasset) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Asset Suggestion (msdyn_problematicasset) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Asset Suggestion** |
| **DisplayCollectionName** | **Asset Suggestions** |
| **SchemaName** | `msdyn_problematicasset` |
| **CollectionSchemaName** | `msdyn_problematicassets` |
| **EntitySetName** | `msdyn_problematicassets`|
| **LogicalName** | `msdyn_problematicasset` |
| **LogicalCollectionName** | `msdyn_problematicassets` |
| **PrimaryIdAttribute** | `msdyn_problematicassetid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Asset](#BKMK_msdyn_Asset)
- [msdyn_AssetId](#BKMK_msdyn_AssetId)
- [msdyn_BreakfixCost](#BKMK_msdyn_BreakfixCost)
- [msdyn_BreakfixSale](#BKMK_msdyn_BreakfixSale)
- [msdyn_BreakfixWorkOrderCount](#BKMK_msdyn_BreakfixWorkOrderCount)
- [msdyn_Confidence](#BKMK_msdyn_Confidence)
- [msdyn_HigherTotalCost](#BKMK_msdyn_HigherTotalCost)
- [msdyn_HigherWorkOrderCount](#BKMK_msdyn_HigherWorkOrderCount)
- [msdyn_MaintenanceCost](#BKMK_msdyn_MaintenanceCost)
- [msdyn_MaintenanceSale](#BKMK_msdyn_MaintenanceSale)
- [msdyn_MaintenanceWorkOrderCount](#BKMK_msdyn_MaintenanceWorkOrderCount)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_NumberofDays](#BKMK_msdyn_NumberofDays)
- [msdyn_problematicassetId](#BKMK_msdyn_problematicassetId)
- [msdyn_ReplacementCost](#BKMK_msdyn_ReplacementCost)
- [msdyn_ReplacementSale](#BKMK_msdyn_ReplacementSale)
- [msdyn_RunId](#BKMK_msdyn_RunId)
- [msdyn_Score](#BKMK_msdyn_Score)
- [msdyn_Suggestion](#BKMK_msdyn_Suggestion)
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
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_Asset"></a> msdyn_Asset

|Property|Value|
|---|---|
|Description|**Lookup field for customer asset**|
|DisplayName|**Asset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_asset`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_customerasset|

### <a name="BKMK_msdyn_AssetId"></a> msdyn_AssetId

|Property|Value|
|---|---|
|Description|**Unique identifier of customer asset**|
|DisplayName|**Asset Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_assetid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_BreakfixCost"></a> msdyn_BreakfixCost

|Property|Value|
|---|---|
|Description|**Value of breakfix cost for customer asset**|
|DisplayName|**Breakfix Cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_breakfixcost`|
|RequiredLevel|ApplicationRequired|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_BreakfixSale"></a> msdyn_BreakfixSale

|Property|Value|
|---|---|
|Description|**Value of breakfix sale of customer asset**|
|DisplayName|**Breakfix Sale**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_breakfixsale`|
|RequiredLevel|ApplicationRequired|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_BreakfixWorkOrderCount"></a> msdyn_BreakfixWorkOrderCount

|Property|Value|
|---|---|
|Description|**Expected break/fix work order count for customer asset**|
|DisplayName|**Expected Break/fix Work Order Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_breakfixworkordercount`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_Confidence"></a> msdyn_Confidence

|Property|Value|
|---|---|
|Description|**Probability of predicting customer asset to be problematic in current date**|
|DisplayName|**Confidence**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_confidence`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1|
|MinValue|0|
|Precision|3|

### <a name="BKMK_msdyn_HigherTotalCost"></a> msdyn_HigherTotalCost

|Property|Value|
|---|---|
|Description|**Flag value indicating if customer asset has higher total cost than similar assets or not**|
|DisplayName|**Higher Total Cost?**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_highertotalcost`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_problematicasset_msdyn_highertotalcost`|

#### msdyn_HigherTotalCost Choices/Options

|Value|Label|
|---|---|
|0|**No**|
|1|**Yes**|

### <a name="BKMK_msdyn_HigherWorkOrderCount"></a> msdyn_HigherWorkOrderCount

|Property|Value|
|---|---|
|Description|**Flag value indicating if customer asset work order count is higher than similar assets or not**|
|DisplayName|**Higher Work Order Count?**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_higherworkordercount`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_problematicasset_msdyn_higherworkordercount`|

#### msdyn_HigherWorkOrderCount Choices/Options

|Value|Label|
|---|---|
|0|**No**|
|1|**Yes**|

### <a name="BKMK_msdyn_MaintenanceCost"></a> msdyn_MaintenanceCost

|Property|Value|
|---|---|
|Description|**Value of maintenance cost of customer asset**|
|DisplayName|**Maintenance Cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_maintenancecost`|
|RequiredLevel|ApplicationRequired|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_MaintenanceSale"></a> msdyn_MaintenanceSale

|Property|Value|
|---|---|
|Description|**Value of maintenance sale of customer asset**|
|DisplayName|**Maintenance Sale**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_maintenancesale`|
|RequiredLevel|ApplicationRequired|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_MaintenanceWorkOrderCount"></a> msdyn_MaintenanceWorkOrderCount

|Property|Value|
|---|---|
|Description|**Expected maintenance work order count from model output**|
|DisplayName|**Expected Maintenance Work Order Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_maintenanceworkordercount`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_Name"></a> msdyn_Name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
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

### <a name="BKMK_msdyn_NumberofDays"></a> msdyn_NumberofDays

|Property|Value|
|---|---|
|Description|**The option set value indicating how many days the record is preficted from current**|
|DisplayName|**Number Of Days**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_numberofdays`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_numberofdays`|

#### msdyn_NumberofDays Choices/Options

|Value|Label|
|---|---|
|192350000|**0**|
|192350001|**15**|
|192350002|**30**|
|192350003|**60**|
|192350004|**90**|

### <a name="BKMK_msdyn_problematicassetId"></a> msdyn_problematicassetId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Problematic Asset**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_problematicassetid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ReplacementCost"></a> msdyn_ReplacementCost

|Property|Value|
|---|---|
|Description|**Value of replacement cost of customer asset**|
|DisplayName|**Replacement Cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_replacementcost`|
|RequiredLevel|ApplicationRequired|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_ReplacementSale"></a> msdyn_ReplacementSale

|Property|Value|
|---|---|
|Description|**Value of replacement sale of customer asset**|
|DisplayName|**Replacement Sale**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_replacementsale`|
|RequiredLevel|ApplicationRequired|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_RunId"></a> msdyn_RunId

|Property|Value|
|---|---|
|Description|**Unique identifier of model run id**|
|DisplayName|**Run Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_runid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Score"></a> msdyn_Score

|Property|Value|
|---|---|
|Description|**Probability of customer asset to be problematic asset**|
|DisplayName|**Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_score`|
|RequiredLevel|ApplicationRequired|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1|
|MinValue|0|
|Precision|3|

### <a name="BKMK_msdyn_Suggestion"></a> msdyn_Suggestion

|Property|Value|
|---|---|
|Description|**Optionset value of suggestions for customer asset**|
|DisplayName|**Suggestion**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestion`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_problematicasset_msdyn_suggestion`|

#### msdyn_Suggestion Choices/Options

|Value|Label|
|---|---|
|192350000|**Repair**|
|192350001|**Replace**|
|192350002|**None**|

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
|Description|**Status of the Problematic Asset**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_problematicasset_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Problematic Asset**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_problematicasset_statuscode`|

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
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

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
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdyn_breakfixcost_Base](#BKMK_msdyn_breakfixcost_Base)
- [msdyn_breakfixsale_Base](#BKMK_msdyn_breakfixsale_Base)
- [msdyn_maintenancecost_Base](#BKMK_msdyn_maintenancecost_Base)
- [msdyn_maintenancesale_Base](#BKMK_msdyn_maintenancesale_Base)
- [msdyn_replacementcost_Base](#BKMK_msdyn_replacementcost_Base)
- [msdyn_replacementsale_Base](#BKMK_msdyn_replacementsale_Base)
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

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Exchange rate for the currency associated with the entity with respect to the base currency.**|
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

### <a name="BKMK_msdyn_breakfixcost_Base"></a> msdyn_breakfixcost_Base

|Property|Value|
|---|---|
|Description|**Value of the Breakfix Cost in base currency.**|
|DisplayName|**Breakfix Cost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_breakfixcost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_breakfixsale_Base"></a> msdyn_breakfixsale_Base

|Property|Value|
|---|---|
|Description|**Value of the Breakfix Sale in base currency.**|
|DisplayName|**Breakfix Sale (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_breakfixsale_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_maintenancecost_Base"></a> msdyn_maintenancecost_Base

|Property|Value|
|---|---|
|Description|**Value of the Maintenance Cost in base currency.**|
|DisplayName|**Maintenance Cost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_maintenancecost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_maintenancesale_Base"></a> msdyn_maintenancesale_Base

|Property|Value|
|---|---|
|Description|**Value of the Maintenance Sale in base currency.**|
|DisplayName|**Maintenance Sale (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_maintenancesale_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_replacementcost_Base"></a> msdyn_replacementcost_Base

|Property|Value|
|---|---|
|Description|**Value of the Replacement Cost in base currency.**|
|DisplayName|**Replacement Cost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_replacementcost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_replacementsale_Base"></a> msdyn_replacementsale_Base

|Property|Value|
|---|---|
|Description|**Value of the Replacement Sale in base currency.**|
|DisplayName|**Replacement Sale (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_replacementsale_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

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

- [business_unit_msdyn_problematicasset](#BKMK_business_unit_msdyn_problematicasset)
- [lk_msdyn_problematicasset_createdby](#BKMK_lk_msdyn_problematicasset_createdby)
- [lk_msdyn_problematicasset_createdonbehalfby](#BKMK_lk_msdyn_problematicasset_createdonbehalfby)
- [lk_msdyn_problematicasset_modifiedby](#BKMK_lk_msdyn_problematicasset_modifiedby)
- [lk_msdyn_problematicasset_modifiedonbehalfby](#BKMK_lk_msdyn_problematicasset_modifiedonbehalfby)
- [msdyn_msdyn_customerasset_msdyn_problematicasset_asset](#BKMK_msdyn_msdyn_customerasset_msdyn_problematicasset_asset)
- [owner_msdyn_problematicasset](#BKMK_owner_msdyn_problematicasset)
- [team_msdyn_problematicasset](#BKMK_team_msdyn_problematicasset)
- [TransactionCurrency_msdyn_problematicasset](#BKMK_TransactionCurrency_msdyn_problematicasset)
- [user_msdyn_problematicasset](#BKMK_user_msdyn_problematicasset)

### <a name="BKMK_business_unit_msdyn_problematicasset"></a> business_unit_msdyn_problematicasset

One-To-Many Relationship: [businessunit business_unit_msdyn_problematicasset](businessunit.md#BKMK_business_unit_msdyn_problematicasset)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_problematicasset_createdby"></a> lk_msdyn_problematicasset_createdby

One-To-Many Relationship: [systemuser lk_msdyn_problematicasset_createdby](systemuser.md#BKMK_lk_msdyn_problematicasset_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_problematicasset_createdonbehalfby"></a> lk_msdyn_problematicasset_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_problematicasset_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_problematicasset_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_problematicasset_modifiedby"></a> lk_msdyn_problematicasset_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_problematicasset_modifiedby](systemuser.md#BKMK_lk_msdyn_problematicasset_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_problematicasset_modifiedonbehalfby"></a> lk_msdyn_problematicasset_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_problematicasset_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_problematicasset_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_problematicasset_asset"></a> msdyn_msdyn_customerasset_msdyn_problematicasset_asset

One-To-Many Relationship: [msdyn_customerasset msdyn_msdyn_customerasset_msdyn_problematicasset_asset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_problematicasset_asset)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`msdyn_asset`|
|ReferencingEntityNavigationPropertyName|`msdyn_asset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_problematicasset"></a> owner_msdyn_problematicasset

One-To-Many Relationship: [owner owner_msdyn_problematicasset](owner.md#BKMK_owner_msdyn_problematicasset)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_problematicasset"></a> team_msdyn_problematicasset

One-To-Many Relationship: [team team_msdyn_problematicasset](team.md#BKMK_team_msdyn_problematicasset)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_msdyn_problematicasset"></a> TransactionCurrency_msdyn_problematicasset

One-To-Many Relationship: [transactioncurrency TransactionCurrency_msdyn_problematicasset](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_problematicasset)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_problematicasset"></a> user_msdyn_problematicasset

One-To-Many Relationship: [systemuser user_msdyn_problematicasset](systemuser.md#BKMK_user_msdyn_problematicasset)

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

- [msdyn_problematicasset_AsyncOperations](#BKMK_msdyn_problematicasset_AsyncOperations)
- [msdyn_problematicasset_BulkDeleteFailures](#BKMK_msdyn_problematicasset_BulkDeleteFailures)
- [msdyn_problematicasset_DuplicateBaseRecord](#BKMK_msdyn_problematicasset_DuplicateBaseRecord)
- [msdyn_problematicasset_DuplicateMatchingRecord](#BKMK_msdyn_problematicasset_DuplicateMatchingRecord)
- [msdyn_problematicasset_MailboxTrackingFolders](#BKMK_msdyn_problematicasset_MailboxTrackingFolders)
- [msdyn_problematicasset_PrincipalObjectAttributeAccesses](#BKMK_msdyn_problematicasset_PrincipalObjectAttributeAccesses)
- [msdyn_problematicasset_ProcessSession](#BKMK_msdyn_problematicasset_ProcessSession)
- [msdyn_problematicasset_SyncErrors](#BKMK_msdyn_problematicasset_SyncErrors)

### <a name="BKMK_msdyn_problematicasset_AsyncOperations"></a> msdyn_problematicasset_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_problematicasset_AsyncOperations](asyncoperation.md#BKMK_msdyn_problematicasset_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_problematicasset_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_problematicasset_BulkDeleteFailures"></a> msdyn_problematicasset_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_problematicasset_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_problematicasset_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_problematicasset_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_problematicasset_DuplicateBaseRecord"></a> msdyn_problematicasset_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_problematicasset_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_problematicasset_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_problematicasset_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_problematicasset_DuplicateMatchingRecord"></a> msdyn_problematicasset_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_problematicasset_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_problematicasset_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_problematicasset_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_problematicasset_MailboxTrackingFolders"></a> msdyn_problematicasset_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_problematicasset_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_problematicasset_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_problematicasset_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_problematicasset_PrincipalObjectAttributeAccesses"></a> msdyn_problematicasset_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_problematicasset_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_problematicasset_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_problematicasset_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_problematicasset_ProcessSession"></a> msdyn_problematicasset_ProcessSession

Many-To-One Relationship: [processsession msdyn_problematicasset_ProcessSession](processsession.md#BKMK_msdyn_problematicasset_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_problematicasset_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_problematicasset_SyncErrors"></a> msdyn_problematicasset_SyncErrors

Many-To-One Relationship: [syncerror msdyn_problematicasset_SyncErrors](syncerror.md#BKMK_msdyn_problematicasset_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_problematicasset_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

