---
title: "Forecast definition (msdyn_forecastdefinition) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Forecast definition (msdyn_forecastdefinition) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Forecast definition (msdyn_forecastdefinition) table/entity reference (Microsoft Dynamics 365)

Defines the parameters used for forecasting.

## Messages

The following table lists the messages for the Forecast definition (msdyn_forecastdefinition) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_forecastdefinitions(*msdyn_forecastdefinitionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_forecastdefinitions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_forecastdefinitions(*msdyn_forecastdefinitionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_forecastdefinitions(*msdyn_forecastdefinitionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_forecastdefinitions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_forecastdefinitions(*msdyn_forecastdefinitionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_forecastdefinitions(*msdyn_forecastdefinitionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_forecastdefinitions(*msdyn_forecastdefinitionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Forecast definition (msdyn_forecastdefinition) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Forecast definition** |
| **DisplayCollectionName** | **Forecast definitions** |
| **SchemaName** | `msdyn_forecastdefinition` |
| **CollectionSchemaName** | `msdyn_forecastdefinitions` |
| **EntitySetName** | `msdyn_forecastdefinitions`|
| **LogicalName** | `msdyn_forecastdefinition` |
| **LogicalCollectionName** | `msdyn_forecastdefinitions` |
| **PrimaryIdAttribute** | `msdyn_forecastdefinitionid` |
| **PrimaryNameAttribute** |`msdyn_forecastdefinitionname` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_fiscalmonth](#BKMK_msdyn_fiscalmonth)
- [msdyn_fiscalquarter](#BKMK_msdyn_fiscalquarter)
- [msdyn_fiscalyear](#BKMK_msdyn_fiscalyear)
- [msdyn_forecastdefinitionId](#BKMK_msdyn_forecastdefinitionId)
- [msdyn_forecastdefinitionname](#BKMK_msdyn_forecastdefinitionname)
- [msdyn_forecastperiodtype](#BKMK_msdyn_forecastperiodtype)
- [msdyn_metricid](#BKMK_msdyn_metricid)
- [msdyn_numberofrecurrences](#BKMK_msdyn_numberofrecurrences)
- [msdyn_quotasource](#BKMK_msdyn_quotasource)
- [msdyn_rollupquery](#BKMK_msdyn_rollupquery)
- [msdyn_validfrom](#BKMK_msdyn_validfrom)
- [msdyn_validto](#BKMK_msdyn_validto)
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

### <a name="BKMK_msdyn_fiscalmonth"></a> msdyn_fiscalmonth

|Property|Value|
|---|---|
|Description|**Select the fiscal month for the forecast definition.**|
|DisplayName|**Fiscal month**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fiscalmonth`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_fcdefinition_msdyn_fiscalmonth`|

#### msdyn_fiscalmonth Choices/Options

|Value|Label|
|---|---|
|0|**January**|
|1|**February**|
|2|**March**|
|3|**April**|
|4|**May**|
|5|**June**|
|6|**July**|
|7|**August**|
|8|**September**|
|9|**October**|
|10|**November**|
|11|**December**|

### <a name="BKMK_msdyn_fiscalquarter"></a> msdyn_fiscalquarter

|Property|Value|
|---|---|
|Description|**Select the fiscal quarter for the forecast definition.**|
|DisplayName|**Fiscal quarter**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fiscalquarter`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_fcdefinition_msdyn_fiscalquarter`|

#### msdyn_fiscalquarter Choices/Options

|Value|Label|
|---|---|
|0|**Q1**|
|1|**Q2**|
|2|**Q3**|
|3|**Q4**|

### <a name="BKMK_msdyn_fiscalyear"></a> msdyn_fiscalyear

|Property|Value|
|---|---|
|Description|**Select the fiscal year for the forecast definition.**|
|DisplayName|**Fiscal year**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fiscalyear`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_forecastdefinition_msdyn_fiscalyear`|

#### msdyn_fiscalyear Choices/Options

|Value|Label|
|---|---|
|0|**FY2018**|
|1|**FY2019**|
|2|**FY2020**|
|3|**FY2021**|
|4|**FY2022**|
|5|**FY2023**|
|6|**FY2024**|
|7|**FY2025**|
|8|**FY2026**|
|9|**FY2027**|
|10|**FY2028**|
|11|**FY2029**|
|12|**FY2030**|
|13|**FY2031**|
|14|**FY2032**|
|15|**FY2033**|
|16|**FY2034**|
|17|**FY2035**|
|18|**FY2036**|
|19|**FY2037**|
|20|**FY2038**|
|21|**FY2039**|
|22|**FY2040**|

### <a name="BKMK_msdyn_forecastdefinitionId"></a> msdyn_forecastdefinitionId

|Property|Value|
|---|---|
|Description|**Unique identifier for the forecast definition.**|
|DisplayName|**Forecast definition**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastdefinitionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_forecastdefinitionname"></a> msdyn_forecastdefinitionname

|Property|Value|
|---|---|
|Description|**Name of the forecast definition.**|
|DisplayName|**Forecast name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastdefinitionname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_forecastperiodtype"></a> msdyn_forecastperiodtype

|Property|Value|
|---|---|
|Description|**Select the type of period for which the forecast must be generated.**|
|DisplayName|**Forecast period**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastperiodtype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyn_forecastdefinition_msdyn_forecastperiodtype`|

#### msdyn_forecastperiodtype Choices/Options

|Value|Label|
|---|---|
|0|**Monthly**|
|1|**Quarterly**|
|2|**Custom**|

### <a name="BKMK_msdyn_metricid"></a> msdyn_metricid

|Property|Value|
|---|---|
|Description|**Select metric to attach with forecast**|
|DisplayName|**Forecast metric**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_metricid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|metric|

### <a name="BKMK_msdyn_numberofrecurrences"></a> msdyn_numberofrecurrences

|Property|Value|
|---|---|
|Description|**Indicate the number of recurrences that the forecast will be generated.**|
|DisplayName|**Number of recurrences**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_numberofrecurrences`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|12|
|MinValue|1|

### <a name="BKMK_msdyn_quotasource"></a> msdyn_quotasource

|Property|Value|
|---|---|
|Description|**Select whether the quota for the forecast must to be taken from a goal or entered manually.**|
|DisplayName|**Quota source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_quotasource`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_forecastdefinition_msdyn_quotasource`|

#### msdyn_quotasource Choices/Options

|Value|Label|
|---|---|
|192350000|**Goal-based**|
|192350001|**Manual**|

### <a name="BKMK_msdyn_rollupquery"></a> msdyn_rollupquery

|Property|Value|
|---|---|
|Description|**Select the query that will be used to calculate data for the rollup field.**|
|DisplayName|**Rollup query**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rollupquery`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|goalrollupquery|

### <a name="BKMK_msdyn_validfrom"></a> msdyn_validfrom

|Property|Value|
|---|---|
|Description|**Shows the date from which the forecast is applicable. The date and time are displayed in the time zone selected in Dynamics 365 Customer Engagement apps options.**|
|DisplayName|**Valid from**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_validfrom`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|DateOnly|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_validto"></a> msdyn_validto

|Property|Value|
|---|---|
|Description|**Shows the date till which the forecast is applicable. The date and time are displayed in the time zone selected in Dynamics 365 Customer Engagement apps options.**|
|DisplayName|**Valid to**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_validto`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|DateOnly|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

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
|Description|**Status of the Forecast Definition**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_forecastdefinition_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Draft**<br />DefaultStatus: 1<br />InvariantName: `Draft`|
|1|Label: **Published**<br />DefaultStatus: 2<br />InvariantName: `Published`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Forecast Definition**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_forecastdefinition_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Draft**<br />State:0<br />TransitionData: None|
|2|Label: **In progress**<br />State:1<br />TransitionData: None|
|3|Label: **Success**<br />State:1<br />TransitionData: None|
|4|Label: **Failed**<br />State:1<br />TransitionData: None|

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

- [business_unit_msdyn_forecastdefinition](#BKMK_business_unit_msdyn_forecastdefinition)
- [lk_msdyn_forecastdefinition_createdby](#BKMK_lk_msdyn_forecastdefinition_createdby)
- [lk_msdyn_forecastdefinition_createdonbehalfby](#BKMK_lk_msdyn_forecastdefinition_createdonbehalfby)
- [lk_msdyn_forecastdefinition_modifiedby](#BKMK_lk_msdyn_forecastdefinition_modifiedby)
- [lk_msdyn_forecastdefinition_modifiedonbehalfby](#BKMK_lk_msdyn_forecastdefinition_modifiedonbehalfby)
- [msdyn_goalrollupquery_msdyn_forecastdefinition_rollupquery](#BKMK_msdyn_goalrollupquery_msdyn_forecastdefinition_rollupquery)
- [msdyn_metric_msdyn_forecastdefinition_metricid](#BKMK_msdyn_metric_msdyn_forecastdefinition_metricid)
- [owner_msdyn_forecastdefinition](#BKMK_owner_msdyn_forecastdefinition)
- [team_msdyn_forecastdefinition](#BKMK_team_msdyn_forecastdefinition)
- [user_msdyn_forecastdefinition](#BKMK_user_msdyn_forecastdefinition)

### <a name="BKMK_business_unit_msdyn_forecastdefinition"></a> business_unit_msdyn_forecastdefinition

One-To-Many Relationship: [businessunit business_unit_msdyn_forecastdefinition](businessunit.md#BKMK_business_unit_msdyn_forecastdefinition)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastdefinition_createdby"></a> lk_msdyn_forecastdefinition_createdby

One-To-Many Relationship: [systemuser lk_msdyn_forecastdefinition_createdby](systemuser.md#BKMK_lk_msdyn_forecastdefinition_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastdefinition_createdonbehalfby"></a> lk_msdyn_forecastdefinition_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_forecastdefinition_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_forecastdefinition_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastdefinition_modifiedby"></a> lk_msdyn_forecastdefinition_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_forecastdefinition_modifiedby](systemuser.md#BKMK_lk_msdyn_forecastdefinition_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastdefinition_modifiedonbehalfby"></a> lk_msdyn_forecastdefinition_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_forecastdefinition_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_forecastdefinition_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_goalrollupquery_msdyn_forecastdefinition_rollupquery"></a> msdyn_goalrollupquery_msdyn_forecastdefinition_rollupquery

One-To-Many Relationship: [goalrollupquery msdyn_goalrollupquery_msdyn_forecastdefinition_rollupquery](goalrollupquery.md#BKMK_msdyn_goalrollupquery_msdyn_forecastdefinition_rollupquery)

|Property|Value|
|---|---|
|ReferencedEntity|`goalrollupquery`|
|ReferencedAttribute|`goalrollupqueryid`|
|ReferencingAttribute|`msdyn_rollupquery`|
|ReferencingEntityNavigationPropertyName|`msdyn_rollupquery`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_metric_msdyn_forecastdefinition_metricid"></a> msdyn_metric_msdyn_forecastdefinition_metricid

One-To-Many Relationship: [metric msdyn_metric_msdyn_forecastdefinition_metricid](metric.md#BKMK_msdyn_metric_msdyn_forecastdefinition_metricid)

|Property|Value|
|---|---|
|ReferencedEntity|`metric`|
|ReferencedAttribute|`metricid`|
|ReferencingAttribute|`msdyn_metricid`|
|ReferencingEntityNavigationPropertyName|`msdyn_metricid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_forecastdefinition"></a> owner_msdyn_forecastdefinition

One-To-Many Relationship: [owner owner_msdyn_forecastdefinition](owner.md#BKMK_owner_msdyn_forecastdefinition)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_forecastdefinition"></a> team_msdyn_forecastdefinition

One-To-Many Relationship: [team team_msdyn_forecastdefinition](team.md#BKMK_team_msdyn_forecastdefinition)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_forecastdefinition"></a> user_msdyn_forecastdefinition

One-To-Many Relationship: [systemuser user_msdyn_forecastdefinition](systemuser.md#BKMK_user_msdyn_forecastdefinition)

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

- [msdyn_forecastdefinition_AsyncOperations](#BKMK_msdyn_forecastdefinition_AsyncOperations)
- [msdyn_forecastdefinition_BulkDeleteFailures](#BKMK_msdyn_forecastdefinition_BulkDeleteFailures)
- [msdyn_forecastdefinition_DuplicateBaseRecord](#BKMK_msdyn_forecastdefinition_DuplicateBaseRecord)
- [msdyn_forecastdefinition_DuplicateMatchingRecord](#BKMK_msdyn_forecastdefinition_DuplicateMatchingRecord)
- [msdyn_forecastdefinition_MailboxTrackingFolders](#BKMK_msdyn_forecastdefinition_MailboxTrackingFolders)
- [msdyn_forecastdefinition_PrincipalObjectAttributeAccesses](#BKMK_msdyn_forecastdefinition_PrincipalObjectAttributeAccesses)
- [msdyn_forecastdefinition_ProcessSession](#BKMK_msdyn_forecastdefinition_ProcessSession)
- [msdyn_forecastdefinition_SyncErrors](#BKMK_msdyn_forecastdefinition_SyncErrors)
- [msdyn_msdyn_forecastdefinition_msdyn_forecastinstance](#BKMK_msdyn_msdyn_forecastdefinition_msdyn_forecastinstance)
- [msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence](#BKMK_msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence)

### <a name="BKMK_msdyn_forecastdefinition_AsyncOperations"></a> msdyn_forecastdefinition_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_forecastdefinition_AsyncOperations](asyncoperation.md#BKMK_msdyn_forecastdefinition_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastdefinition_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastdefinition_BulkDeleteFailures"></a> msdyn_forecastdefinition_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_forecastdefinition_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_forecastdefinition_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastdefinition_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastdefinition_DuplicateBaseRecord"></a> msdyn_forecastdefinition_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_forecastdefinition_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_forecastdefinition_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastdefinition_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastdefinition_DuplicateMatchingRecord"></a> msdyn_forecastdefinition_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_forecastdefinition_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_forecastdefinition_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastdefinition_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastdefinition_MailboxTrackingFolders"></a> msdyn_forecastdefinition_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_forecastdefinition_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_forecastdefinition_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastdefinition_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastdefinition_PrincipalObjectAttributeAccesses"></a> msdyn_forecastdefinition_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_forecastdefinition_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_forecastdefinition_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastdefinition_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastdefinition_ProcessSession"></a> msdyn_forecastdefinition_ProcessSession

Many-To-One Relationship: [processsession msdyn_forecastdefinition_ProcessSession](processsession.md#BKMK_msdyn_forecastdefinition_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastdefinition_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastdefinition_SyncErrors"></a> msdyn_forecastdefinition_SyncErrors

Many-To-One Relationship: [syncerror msdyn_forecastdefinition_SyncErrors](syncerror.md#BKMK_msdyn_forecastdefinition_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastdefinition_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_forecastdefinition_msdyn_forecastinstance"></a> msdyn_msdyn_forecastdefinition_msdyn_forecastinstance

Many-To-One Relationship: [msdyn_forecastinstance msdyn_msdyn_forecastdefinition_msdyn_forecastinstance](msdyn_forecastinstance.md#BKMK_msdyn_msdyn_forecastdefinition_msdyn_forecastinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastinstance`|
|ReferencingAttribute|`msdyn_forecastdefinitionid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_forecastdefinition_msdyn_forecastinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence"></a> msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence

Many-To-One Relationship: [msdyn_forecastrecurrence msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence](msdyn_forecastrecurrence.md#BKMK_msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastrecurrence`|
|ReferencingAttribute|`msdyn_forecastdefinitionid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: Unique identifier for Forecast Definition associated with Forecast Recurrence.<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

