---
title: "Forecast (msdyn_forecastinstance) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Forecast (msdyn_forecastinstance) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Forecast (msdyn_forecastinstance) table/entity reference (Microsoft Dynamics 365)

Stores sales predictions for your team or organization. For internal use.

## Messages

The following table lists the messages for the Forecast (msdyn_forecastinstance) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_forecastinstances(*msdyn_forecastinstanceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_forecastinstances<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_forecastinstances(*msdyn_forecastinstanceid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_forecastinstances(*msdyn_forecastinstanceid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_forecastinstances<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_forecastinstances(*msdyn_forecastinstanceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_forecastinstances(*msdyn_forecastinstanceid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_forecastinstances(*msdyn_forecastinstanceid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Forecast (msdyn_forecastinstance) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Forecast** |
| **DisplayCollectionName** | **Forecasts** |
| **SchemaName** | `msdyn_forecastinstance` |
| **CollectionSchemaName** | `msdyn_forecastinstances` |
| **EntitySetName** | `msdyn_forecastinstances`|
| **LogicalName** | `msdyn_forecastinstance` |
| **LogicalCollectionName** | `msdyn_forecastinstances` |
| **PrimaryIdAttribute** | `msdyn_forecastinstanceid` |
| **PrimaryNameAttribute** |`msdyn_forecastname` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_actualamount](#BKMK_msdyn_actualamount)
- [msdyn_bestcaseamount](#BKMK_msdyn_bestcaseamount)
- [msdyn_committedamount](#BKMK_msdyn_committedamount)
- [msdyn_forecastdefinitionid](#BKMK_msdyn_forecastdefinitionid)
- [msdyn_forecastinstanceId](#BKMK_msdyn_forecastinstanceId)
- [msdyn_forecastinstancetype](#BKMK_msdyn_forecastinstancetype)
- [msdyn_forecastname](#BKMK_msdyn_forecastname)
- [msdyn_forecastparentid](#BKMK_msdyn_forecastparentid)
- [msdyn_forecastrecurrenceid](#BKMK_msdyn_forecastrecurrenceid)
- [msdyn_ismanualbestcase](#BKMK_msdyn_ismanualbestcase)
- [msdyn_ismanualcommitted](#BKMK_msdyn_ismanualcommitted)
- [msdyn_ismanualpipeline](#BKMK_msdyn_ismanualpipeline)
- [msdyn_isquotasourcemanual](#BKMK_msdyn_isquotasourcemanual)
- [msdyn_level](#BKMK_msdyn_level)
- [msdyn_manualbestcaseamount](#BKMK_msdyn_manualbestcaseamount)
- [msdyn_manualcommittedamount](#BKMK_msdyn_manualcommittedamount)
- [msdyn_manualpipelineamount](#BKMK_msdyn_manualpipelineamount)
- [msdyn_matchinggoalid](#BKMK_msdyn_matchinggoalid)
- [msdyn_pipelineamount](#BKMK_msdyn_pipelineamount)
- [msdyn_recurrenceindex](#BKMK_msdyn_recurrenceindex)
- [msdyn_targetamount](#BKMK_msdyn_targetamount)
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

### <a name="BKMK_msdyn_actualamount"></a> msdyn_actualamount

|Property|Value|
|---|---|
|Description|**Shows the actual value (money) achieved toward the target as of the last rollup date.**|
|DisplayName|**Closed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actualamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|9999999999999|
|MinValue|-9999999999999|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_bestcaseamount"></a> msdyn_bestcaseamount

|Property|Value|
|---|---|
|Description|**Shows the rollup value (money) for the best case category as of the last rollup date.**|
|DisplayName|**Best case**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bestcaseamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_committedamount"></a> msdyn_committedamount

|Property|Value|
|---|---|
|Description|**Shows the committed rollup value (money) as of the last rollup date.**|
|DisplayName|**Committed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_committedamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_forecastdefinitionid"></a> msdyn_forecastdefinitionid

|Property|Value|
|---|---|
|Description|**Unique identifier for the forecast definition that is associated with the forecast.**|
|DisplayName|**Forecast definition**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastdefinitionid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_forecastdefinition|

### <a name="BKMK_msdyn_forecastinstanceId"></a> msdyn_forecastinstanceId

|Property|Value|
|---|---|
|Description|**Unique identifier for the forecast.**|
|DisplayName|**Forecast**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastinstanceid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_forecastinstancetype"></a> msdyn_forecastinstancetype

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Forecast type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastinstancetype`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_msdyn_forecastname"></a> msdyn_forecastname

|Property|Value|
|---|---|
|Description|**Name of the forecast.**|
|DisplayName|**Forecast**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_forecastparentid"></a> msdyn_forecastparentid

|Property|Value|
|---|---|
|Description|**Unique identifier for the parent forecast that is associated with the forecast.**|
|DisplayName|**Forecast parent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastparentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_forecastinstance|

### <a name="BKMK_msdyn_forecastrecurrenceid"></a> msdyn_forecastrecurrenceid

|Property|Value|
|---|---|
|Description|**Unique identifier for the forecast recurrence associated with the forecast.**|
|DisplayName|**Forecast recurrence**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastrecurrenceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_forecastrecurrence|

### <a name="BKMK_msdyn_ismanualbestcase"></a> msdyn_ismanualbestcase

|Property|Value|
|---|---|
|Description|**Select whether the bestcase rollup has been manually updated.**|
|DisplayName|**Adjust manually (Best case)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ismanualbestcase`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_ismanualcommitted"></a> msdyn_ismanualcommitted

|Property|Value|
|---|---|
|Description|**Select whether the committed rollup has been manually updated.**|
|DisplayName|**Adjust manually (Committed)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ismanualcommitted`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_ismanualpipeline"></a> msdyn_ismanualpipeline

|Property|Value|
|---|---|
|Description|**Select whether the pipeline rollup has been manually updated.**|
|DisplayName|**Adjust manually (Pipeline)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ismanualpipeline`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_isquotasourcemanual"></a> msdyn_isquotasourcemanual

|Property|Value|
|---|---|
|Description|**Is quota source manual**|
|DisplayName|**Is quota source manual**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isquotasourcemanual`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_forecastinstance_msdyn_isquotasourcemanual`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_level"></a> msdyn_level

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Record level**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_level`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_manualbestcaseamount"></a> msdyn_manualbestcaseamount

|Property|Value|
|---|---|
|Description|**Shows the changed value of the best case rollup (Money type) as of the last rolled-up date.**|
|DisplayName|**Best case**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_manualbestcaseamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_manualcommittedamount"></a> msdyn_manualcommittedamount

|Property|Value|
|---|---|
|Description|**Shows the changed value of the committed rollup (Money type) as of the last rolled-up date.**|
|DisplayName|**Committed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_manualcommittedamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_manualpipelineamount"></a> msdyn_manualpipelineamount

|Property|Value|
|---|---|
|Description|**Shows the changed value of the pipeline rollup (Money type) as of the last rolled-up date.**|
|DisplayName|**Pipeline**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_manualpipelineamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_matchinggoalid"></a> msdyn_matchinggoalid

|Property|Value|
|---|---|
|Description|**Unique identifier for the matching goal associated with the forecast.**|
|DisplayName|**Matching goal**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_matchinggoalid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|goal|

### <a name="BKMK_msdyn_pipelineamount"></a> msdyn_pipelineamount

|Property|Value|
|---|---|
|Description|**Shows the pipeline rollup value (money) as of the last rollup date.**|
|DisplayName|**Pipeline**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pipelineamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_recurrenceindex"></a> msdyn_recurrenceindex

|Property|Value|
|---|---|
|Description|**Shows the recurrence index of the forecast created from the forecast definition.**|
|DisplayName|**Recurrence index**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recurrenceindex`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_targetamount"></a> msdyn_targetamount

|Property|Value|
|---|---|
|Description|**Select a target (Money type) to track a monetary amount, such as estimated revenue from an opportunity.**|
|DisplayName|**Quota**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_targetamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|9999999999999|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

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
|Description|**Status of the Forecast**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_forecastinstance_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Forecast**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_forecastinstance_statuscode`|

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
- [msdyn_actualamount_Base](#BKMK_msdyn_actualamount_Base)
- [msdyn_bestcaseamount_Base](#BKMK_msdyn_bestcaseamount_Base)
- [msdyn_committedamount_Base](#BKMK_msdyn_committedamount_Base)
- [msdyn_manualbestcaseamount_Base](#BKMK_msdyn_manualbestcaseamount_Base)
- [msdyn_manualcommittedamount_Base](#BKMK_msdyn_manualcommittedamount_Base)
- [msdyn_manualpipelineamount_Base](#BKMK_msdyn_manualpipelineamount_Base)
- [msdyn_percentageachieved](#BKMK_msdyn_percentageachieved)
- [msdyn_pipelineamount_Base](#BKMK_msdyn_pipelineamount_Base)
- [msdyn_targetamount_Base](#BKMK_msdyn_targetamount_Base)
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
|MinValue|1E-12|
|Precision|12|
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

### <a name="BKMK_msdyn_actualamount_Base"></a> msdyn_actualamount_Base

|Property|Value|
|---|---|
|Description|**Value of the Actual (Money) in base currency.**|
|DisplayName|**Actual (Money) (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actualamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|9999999999999|
|MinValue|-9999999999999|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_bestcaseamount_Base"></a> msdyn_bestcaseamount_Base

|Property|Value|
|---|---|
|Description|**Value of the BestCase in base currency.**|
|DisplayName|**bestcaseamount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bestcaseamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_committedamount_Base"></a> msdyn_committedamount_Base

|Property|Value|
|---|---|
|Description|**Value of the Committed in base currency.**|
|DisplayName|**Committed (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_committedamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_manualbestcaseamount_Base"></a> msdyn_manualbestcaseamount_Base

|Property|Value|
|---|---|
|Description|**Value of the Manual BestCase in base currency.**|
|DisplayName|**Manual BestCase (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_manualbestcaseamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_manualcommittedamount_Base"></a> msdyn_manualcommittedamount_Base

|Property|Value|
|---|---|
|Description|**Value of the Manual Committed in base currency.**|
|DisplayName|**Manual Committed (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_manualcommittedamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_manualpipelineamount_Base"></a> msdyn_manualpipelineamount_Base

|Property|Value|
|---|---|
|Description|**Value of the Manual Pipeline in base currency.**|
|DisplayName|**Manual Pipeline (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_manualpipelineamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_percentageachieved"></a> msdyn_percentageachieved

|Property|Value|
|---|---|
|Description|**Shows the percentage achieved against the target.**|
|DisplayName|**Achieved %**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_percentageachieved`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|1|

### <a name="BKMK_msdyn_pipelineamount_Base"></a> msdyn_pipelineamount_Base

|Property|Value|
|---|---|
|Description|**Value of the Pipeline in base currency.**|
|DisplayName|**Pipeline (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pipelineamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_targetamount_Base"></a> msdyn_targetamount_Base

|Property|Value|
|---|---|
|Description|**Value of the Target (Money) in base currency.**|
|DisplayName|**Target (Money) (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_targetamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|9999999999999|
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

- [business_unit_msdyn_forecastinstance](#BKMK_business_unit_msdyn_forecastinstance)
- [lk_msdyn_forecastinstance_createdby](#BKMK_lk_msdyn_forecastinstance_createdby)
- [lk_msdyn_forecastinstance_createdonbehalfby](#BKMK_lk_msdyn_forecastinstance_createdonbehalfby)
- [lk_msdyn_forecastinstance_modifiedby](#BKMK_lk_msdyn_forecastinstance_modifiedby)
- [lk_msdyn_forecastinstance_modifiedonbehalfby](#BKMK_lk_msdyn_forecastinstance_modifiedonbehalfby)
- [msdyn_goal_msdyn_forecastinstance](#BKMK_msdyn_goal_msdyn_forecastinstance)
- [msdyn_msdyn_forecastdefinition_msdyn_forecastinstance](#BKMK_msdyn_msdyn_forecastdefinition_msdyn_forecastinstance)
- [msdyn_msdyn_forecastinstance_msdyn_forecastinstance](#BKMK_msdyn_msdyn_forecastinstance_msdyn_forecastinstance-many-to-one)
- [msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance](#BKMK_msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance)
- [owner_msdyn_forecastinstance](#BKMK_owner_msdyn_forecastinstance)
- [team_msdyn_forecastinstance](#BKMK_team_msdyn_forecastinstance)
- [TransactionCurrency_msdyn_forecastinstance](#BKMK_TransactionCurrency_msdyn_forecastinstance)
- [user_msdyn_forecastinstance](#BKMK_user_msdyn_forecastinstance)

### <a name="BKMK_business_unit_msdyn_forecastinstance"></a> business_unit_msdyn_forecastinstance

One-To-Many Relationship: [businessunit business_unit_msdyn_forecastinstance](businessunit.md#BKMK_business_unit_msdyn_forecastinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastinstance_createdby"></a> lk_msdyn_forecastinstance_createdby

One-To-Many Relationship: [systemuser lk_msdyn_forecastinstance_createdby](systemuser.md#BKMK_lk_msdyn_forecastinstance_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastinstance_createdonbehalfby"></a> lk_msdyn_forecastinstance_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_forecastinstance_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_forecastinstance_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastinstance_modifiedby"></a> lk_msdyn_forecastinstance_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_forecastinstance_modifiedby](systemuser.md#BKMK_lk_msdyn_forecastinstance_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastinstance_modifiedonbehalfby"></a> lk_msdyn_forecastinstance_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_forecastinstance_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_forecastinstance_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_goal_msdyn_forecastinstance"></a> msdyn_goal_msdyn_forecastinstance

One-To-Many Relationship: [goal msdyn_goal_msdyn_forecastinstance](goal.md#BKMK_msdyn_goal_msdyn_forecastinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`goal`|
|ReferencedAttribute|`goalid`|
|ReferencingAttribute|`msdyn_matchinggoalid`|
|ReferencingEntityNavigationPropertyName|`msdyn_matchinggoalid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_forecastdefinition_msdyn_forecastinstance"></a> msdyn_msdyn_forecastdefinition_msdyn_forecastinstance

One-To-Many Relationship: [msdyn_forecastdefinition msdyn_msdyn_forecastdefinition_msdyn_forecastinstance](msdyn_forecastdefinition.md#BKMK_msdyn_msdyn_forecastdefinition_msdyn_forecastinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_forecastdefinition`|
|ReferencedAttribute|`msdyn_forecastdefinitionid`|
|ReferencingAttribute|`msdyn_forecastdefinitionid`|
|ReferencingEntityNavigationPropertyName|`msdyn_forecastdefinitionid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_forecastinstance_msdyn_forecastinstance-many-to-one"></a> msdyn_msdyn_forecastinstance_msdyn_forecastinstance

One-To-Many Relationship: [msdyn_forecastinstance msdyn_msdyn_forecastinstance_msdyn_forecastinstance](#BKMK_msdyn_msdyn_forecastinstance_msdyn_forecastinstance-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_forecastinstance`|
|ReferencedAttribute|`msdyn_forecastinstanceid`|
|ReferencingAttribute|`msdyn_forecastparentid`|
|ReferencingEntityNavigationPropertyName|`msdyn_forecastparentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance"></a> msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance

One-To-Many Relationship: [msdyn_forecastrecurrence msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance](msdyn_forecastrecurrence.md#BKMK_msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_forecastrecurrence`|
|ReferencedAttribute|`msdyn_forecastrecurrenceid`|
|ReferencingAttribute|`msdyn_forecastrecurrenceid`|
|ReferencingEntityNavigationPropertyName|`msdyn_forecastrecurrenceid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_forecastinstance"></a> owner_msdyn_forecastinstance

One-To-Many Relationship: [owner owner_msdyn_forecastinstance](owner.md#BKMK_owner_msdyn_forecastinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_forecastinstance"></a> team_msdyn_forecastinstance

One-To-Many Relationship: [team team_msdyn_forecastinstance](team.md#BKMK_team_msdyn_forecastinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_msdyn_forecastinstance"></a> TransactionCurrency_msdyn_forecastinstance

One-To-Many Relationship: [transactioncurrency TransactionCurrency_msdyn_forecastinstance](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_forecastinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_forecastinstance"></a> user_msdyn_forecastinstance

One-To-Many Relationship: [systemuser user_msdyn_forecastinstance](systemuser.md#BKMK_user_msdyn_forecastinstance)

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

- [msdyn_forecastinstance_AsyncOperations](#BKMK_msdyn_forecastinstance_AsyncOperations)
- [msdyn_forecastinstance_BulkDeleteFailures](#BKMK_msdyn_forecastinstance_BulkDeleteFailures)
- [msdyn_forecastinstance_DuplicateBaseRecord](#BKMK_msdyn_forecastinstance_DuplicateBaseRecord)
- [msdyn_forecastinstance_DuplicateMatchingRecord](#BKMK_msdyn_forecastinstance_DuplicateMatchingRecord)
- [msdyn_forecastinstance_MailboxTrackingFolders](#BKMK_msdyn_forecastinstance_MailboxTrackingFolders)
- [msdyn_forecastinstance_PrincipalObjectAttributeAccesses](#BKMK_msdyn_forecastinstance_PrincipalObjectAttributeAccesses)
- [msdyn_forecastinstance_ProcessSession](#BKMK_msdyn_forecastinstance_ProcessSession)
- [msdyn_forecastinstance_SyncErrors](#BKMK_msdyn_forecastinstance_SyncErrors)
- [msdyn_msdyn_forecastinstance_msdyn_forecastinstance](#BKMK_msdyn_msdyn_forecastinstance_msdyn_forecastinstance-one-to-many)

### <a name="BKMK_msdyn_forecastinstance_AsyncOperations"></a> msdyn_forecastinstance_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_forecastinstance_AsyncOperations](asyncoperation.md#BKMK_msdyn_forecastinstance_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastinstance_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastinstance_BulkDeleteFailures"></a> msdyn_forecastinstance_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_forecastinstance_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_forecastinstance_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastinstance_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastinstance_DuplicateBaseRecord"></a> msdyn_forecastinstance_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_forecastinstance_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_forecastinstance_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastinstance_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastinstance_DuplicateMatchingRecord"></a> msdyn_forecastinstance_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_forecastinstance_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_forecastinstance_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastinstance_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastinstance_MailboxTrackingFolders"></a> msdyn_forecastinstance_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_forecastinstance_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_forecastinstance_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastinstance_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastinstance_PrincipalObjectAttributeAccesses"></a> msdyn_forecastinstance_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_forecastinstance_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_forecastinstance_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastinstance_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastinstance_ProcessSession"></a> msdyn_forecastinstance_ProcessSession

Many-To-One Relationship: [processsession msdyn_forecastinstance_ProcessSession](processsession.md#BKMK_msdyn_forecastinstance_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastinstance_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastinstance_SyncErrors"></a> msdyn_forecastinstance_SyncErrors

Many-To-One Relationship: [syncerror msdyn_forecastinstance_SyncErrors](syncerror.md#BKMK_msdyn_forecastinstance_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastinstance_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_forecastinstance_msdyn_forecastinstance-one-to-many"></a> msdyn_msdyn_forecastinstance_msdyn_forecastinstance

Many-To-One Relationship: [msdyn_forecastinstance msdyn_msdyn_forecastinstance_msdyn_forecastinstance](#BKMK_msdyn_msdyn_forecastinstance_msdyn_forecastinstance-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastinstance`|
|ReferencingAttribute|`msdyn_forecastparentid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_forecastinstance_msdyn_forecastinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

