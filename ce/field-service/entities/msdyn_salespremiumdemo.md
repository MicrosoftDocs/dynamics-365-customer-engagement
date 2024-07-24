---
title: "Sales Premium Demo (msdyn_salespremiumdemo) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Sales Premium Demo (msdyn_salespremiumdemo) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Sales Premium Demo (msdyn_salespremiumdemo) table/entity reference



## Messages

The following table lists the messages for the Sales Premium Demo (msdyn_salespremiumdemo) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyn_salespremiumdemos<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_salespremiumdemos(*msdyn_salespremiumdemoid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_salespremiumdemos(*msdyn_salespremiumdemoid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_salespremiumdemos<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msdyn_salespremiumdemos(*msdyn_salespremiumdemoid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_salespremiumdemos(*msdyn_salespremiumdemoid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_salespremiumdemos(*msdyn_salespremiumdemoid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Sales Premium Demo (msdyn_salespremiumdemo) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Sales Premium Demo (msdyn_salespremiumdemo) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Sales Premium Demo** |
| **DisplayCollectionName** | **Sales Premium Demos** |
| **SchemaName** | `msdyn_salespremiumdemo` |
| **CollectionSchemaName** | `msdyn_salespremiumdemos` |
| **EntitySetName** | `msdyn_salespremiumdemos`|
| **LogicalName** | `msdyn_salespremiumdemo` |
| **LogicalCollectionName** | `msdyn_salespremiumdemos` |
| **PrimaryIdAttribute** | `msdyn_salespremiumdemoid` |
| **PrimaryNameAttribute** |`msdyn_entityfilter` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Account](#BKMK_msdyn_Account)
- [msdyn_Competitor](#BKMK_msdyn_Competitor)
- [msdyn_Contact](#BKMK_msdyn_Contact)
- [msdyn_EntityFilter](#BKMK_msdyn_EntityFilter)
- [msdyn_entityid](#BKMK_msdyn_entityid)
- [msdyn_EntityType](#BKMK_msdyn_EntityType)
- [msdyn_Grade](#BKMK_msdyn_Grade)
- [msdyn_Lead](#BKMK_msdyn_Lead)
- [msdyn_mostcontacted](#BKMK_msdyn_mostcontacted)
- [msdyn_Opportunity](#BKMK_msdyn_Opportunity)
- [msdyn_PredictionID](#BKMK_msdyn_PredictionID)
- [msdyn_PriceList](#BKMK_msdyn_PriceList)
- [msdyn_Product](#BKMK_msdyn_Product)
- [msdyn_relationshipanalyticsdaykpi](#BKMK_msdyn_relationshipanalyticsdaykpi)
- [msdyn_relationshipanalyticskpijson](#BKMK_msdyn_relationshipanalyticskpijson)
- [msdyn_relationshiphealthscorestate](#BKMK_msdyn_relationshiphealthscorestate)
- [msdyn_relationshiphealthtrend](#BKMK_msdyn_relationshiphealthtrend)
- [msdyn_salespremiumdemoId](#BKMK_msdyn_salespremiumdemoId)
- [msdyn_Score](#BKMK_msdyn_Score)
- [msdyn_ScoredOn](#BKMK_msdyn_ScoredOn)
- [msdyn_ScoreHistory](#BKMK_msdyn_ScoreHistory)
- [msdyn_ScoreReasons](#BKMK_msdyn_ScoreReasons)
- [msdyn_ScoreTrend](#BKMK_msdyn_ScoreTrend)
- [msdyn_sequence](#BKMK_msdyn_sequence)
- [msdyn_timespentbycustomer](#BKMK_msdyn_timespentbycustomer)
- [msdyn_timespentbyteam](#BKMK_msdyn_timespentbyteam)
- [msdyn_WKWJson](#BKMK_msdyn_WKWJson)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
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

### <a name="BKMK_msdyn_Account"></a> msdyn_Account

|Property|Value|
|---|---|
|Description||
|DisplayName|**Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_account`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_msdyn_Competitor"></a> msdyn_Competitor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Competitor**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_competitor`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|competitor|

### <a name="BKMK_msdyn_Contact"></a> msdyn_Contact

|Property|Value|
|---|---|
|Description||
|DisplayName|**Contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_contact`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msdyn_EntityFilter"></a> msdyn_EntityFilter

|Property|Value|
|---|---|
|Description|**Filter criteria for primary entity.**|
|DisplayName|**PrimaryEntityFilter**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entityfilter`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_entityid"></a> msdyn_entityid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Entity Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entityid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_EntityType"></a> msdyn_EntityType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Entity Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entitytype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Grade"></a> msdyn_Grade

|Property|Value|
|---|---|
|Description||
|DisplayName|**Grade**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_grade`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_salespremiumdemo_msdyn_grade`|

#### msdyn_Grade Choices/Options

|Value|Label|
|---|---|
|0|**Grade A**|
|1|**Grade B**|
|2|**Grade C**|
|3|**Grade D**|

### <a name="BKMK_msdyn_Lead"></a> msdyn_Lead

|Property|Value|
|---|---|
|Description||
|DisplayName|**Lead**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lead`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|lead|

### <a name="BKMK_msdyn_mostcontacted"></a> msdyn_mostcontacted

|Property|Value|
|---|---|
|Description||
|DisplayName|**Most Contacted Json**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_mostcontacted`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|65000|

### <a name="BKMK_msdyn_Opportunity"></a> msdyn_Opportunity

|Property|Value|
|---|---|
|Description||
|DisplayName|**Opportunity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_opportunity`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|opportunity|

### <a name="BKMK_msdyn_PredictionID"></a> msdyn_PredictionID

|Property|Value|
|---|---|
|Description||
|DisplayName|**Prediction ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_predictionid`|
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
|Description||
|DisplayName|**Price List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pricelist`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|pricelevel|

### <a name="BKMK_msdyn_Product"></a> msdyn_Product

|Property|Value|
|---|---|
|Description||
|DisplayName|**Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_product`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|product|

### <a name="BKMK_msdyn_relationshipanalyticsdaykpi"></a> msdyn_relationshipanalyticsdaykpi

|Property|Value|
|---|---|
|Description||
|DisplayName|**Realtionship Analytics Day Kpi**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relationshipanalyticsdaykpi`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|65000|

### <a name="BKMK_msdyn_relationshipanalyticskpijson"></a> msdyn_relationshipanalyticskpijson

|Property|Value|
|---|---|
|Description||
|DisplayName|**Relationship Analytics Kpi json**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relationshipanalyticskpijson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|65000|

### <a name="BKMK_msdyn_relationshiphealthscorestate"></a> msdyn_relationshiphealthscorestate

|Property|Value|
|---|---|
|Description|**KPI health score.**|
|DisplayName|**Relationship Health State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relationshiphealthscorestate`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_msdyn_kpiitem_msdyn_relationshiphealthscorestate`|

#### msdyn_relationshiphealthscorestate Choices/Options

|Value|Label|
|---|---|
|0|**Good**|
|1|**Fair**|
|2|**Poor**|
|3|**Not enough info**|
|4|**No Closed Activities**|
|5|**Health Computation In Progress**|

### <a name="BKMK_msdyn_relationshiphealthtrend"></a> msdyn_relationshiphealthtrend

|Property|Value|
|---|---|
|Description|**Direction the relationship health is moving.**|
|DisplayName|**Relationship Health Trend**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relationshiphealthtrend`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_msdyn_kpiitem_msdyn_relationshiphealthtrend`|

#### msdyn_relationshiphealthtrend Choices/Options

|Value|Label|
|---|---|
|0|**Improving**|
|1|**Steady**|
|2|**Declining**|
|3|**Not enough info**|

### <a name="BKMK_msdyn_salespremiumdemoId"></a> msdyn_salespremiumdemoId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Sales Premium Demo**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_salespremiumdemoid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_Score"></a> msdyn_Score

|Property|Value|
|---|---|
|Description||
|DisplayName|**Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_score`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_ScoredOn"></a> msdyn_ScoredOn

|Property|Value|
|---|---|
|Description||
|DisplayName|**Scored On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scoredon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_ScoreHistory"></a> msdyn_ScoreHistory

|Property|Value|
|---|---|
|Description||
|DisplayName|**Score History**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scorehistory`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_ScoreReasons"></a> msdyn_ScoreReasons

|Property|Value|
|---|---|
|Description||
|DisplayName|**Score Reasons**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scorereasons`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_ScoreTrend"></a> msdyn_ScoreTrend

|Property|Value|
|---|---|
|Description||
|DisplayName|**Score Trend**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scoretrend`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_salespremiumdemo_msdyn_scoretrend`|

#### msdyn_ScoreTrend Choices/Options

|Value|Label|
|---|---|
|0|**Improving**|
|1|**Steady**|
|2|**Declining**|
|3|**Not enough info**|

### <a name="BKMK_msdyn_sequence"></a> msdyn_sequence

|Property|Value|
|---|---|
|Description|**Sequence**|
|DisplayName|**Sequence**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sequence`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_sequence|

### <a name="BKMK_msdyn_timespentbycustomer"></a> msdyn_timespentbycustomer

|Property|Value|
|---|---|
|Description|**Time spent by external contacts on activities.**|
|DisplayName|**Time Engaged with Customer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timespentbycustomer`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_timespentbyteam"></a> msdyn_timespentbyteam

|Property|Value|
|---|---|
|Description|**Time spent by the team on activities.**|
|DisplayName|**Time Spent by Team**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timespentbyteam`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_WKWJson"></a> msdyn_WKWJson

|Property|Value|
|---|---|
|Description||
|DisplayName|**WKW JSON**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_wkwjson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Sales Premium Demo**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_salespremiumdemo_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Sales Premium Demo**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_salespremiumdemo_statuscode`|

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
- [OrganizationId](#BKMK_OrganizationId)
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

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
|DisplayName|**Organization Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|organization|

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

- [lk_msdyn_salespremiumdemo_createdby](#BKMK_lk_msdyn_salespremiumdemo_createdby)
- [lk_msdyn_salespremiumdemo_createdonbehalfby](#BKMK_lk_msdyn_salespremiumdemo_createdonbehalfby)
- [lk_msdyn_salespremiumdemo_modifiedby](#BKMK_lk_msdyn_salespremiumdemo_modifiedby)
- [lk_msdyn_salespremiumdemo_modifiedonbehalfby](#BKMK_lk_msdyn_salespremiumdemo_modifiedonbehalfby)
- [msdyn_account_msdyn_salespremiumdemo_account](#BKMK_msdyn_account_msdyn_salespremiumdemo_account)
- [msdyn_competitor_msdyn_salespremiumdemo_Competitor](#BKMK_msdyn_competitor_msdyn_salespremiumdemo_Competitor)
- [msdyn_contact_msdyn_salespremiumdemo_contact](#BKMK_msdyn_contact_msdyn_salespremiumdemo_contact)
- [msdyn_lead_msdyn_salespremiumdemo_lead](#BKMK_msdyn_lead_msdyn_salespremiumdemo_lead)
- [msdyn_msdyn_sequence_msdyn_salespremiumdemo_sequence](#BKMK_msdyn_msdyn_sequence_msdyn_salespremiumdemo_sequence)
- [msdyn_opportunity_msdyn_salespremiumdemo_opportunity](#BKMK_msdyn_opportunity_msdyn_salespremiumdemo_opportunity)
- [msdyn_pricelevel_msdyn_salespremiumdemo_PriceList](#BKMK_msdyn_pricelevel_msdyn_salespremiumdemo_PriceList)
- [msdyn_product_msdyn_salespremiumdemo_Product](#BKMK_msdyn_product_msdyn_salespremiumdemo_Product)
- [organization_msdyn_salespremiumdemo](#BKMK_organization_msdyn_salespremiumdemo)

### <a name="BKMK_lk_msdyn_salespremiumdemo_createdby"></a> lk_msdyn_salespremiumdemo_createdby

One-To-Many Relationship: [systemuser lk_msdyn_salespremiumdemo_createdby](systemuser.md#BKMK_lk_msdyn_salespremiumdemo_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salespremiumdemo_createdonbehalfby"></a> lk_msdyn_salespremiumdemo_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_salespremiumdemo_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_salespremiumdemo_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salespremiumdemo_modifiedby"></a> lk_msdyn_salespremiumdemo_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_salespremiumdemo_modifiedby](systemuser.md#BKMK_lk_msdyn_salespremiumdemo_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salespremiumdemo_modifiedonbehalfby"></a> lk_msdyn_salespremiumdemo_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_salespremiumdemo_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_salespremiumdemo_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_account_msdyn_salespremiumdemo_account"></a> msdyn_account_msdyn_salespremiumdemo_account

One-To-Many Relationship: [account msdyn_account_msdyn_salespremiumdemo_account](account.md#BKMK_msdyn_account_msdyn_salespremiumdemo_account)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_account`|
|ReferencingEntityNavigationPropertyName|`msdyn_Account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_competitor_msdyn_salespremiumdemo_Competitor"></a> msdyn_competitor_msdyn_salespremiumdemo_Competitor

One-To-Many Relationship: [competitor msdyn_competitor_msdyn_salespremiumdemo_Competitor](competitor.md#BKMK_msdyn_competitor_msdyn_salespremiumdemo_Competitor)

|Property|Value|
|---|---|
|ReferencedEntity|`competitor`|
|ReferencedAttribute|`competitorid`|
|ReferencingAttribute|`msdyn_competitor`|
|ReferencingEntityNavigationPropertyName|`msdyn_Competitor`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_contact_msdyn_salespremiumdemo_contact"></a> msdyn_contact_msdyn_salespremiumdemo_contact

One-To-Many Relationship: [contact msdyn_contact_msdyn_salespremiumdemo_contact](contact.md#BKMK_msdyn_contact_msdyn_salespremiumdemo_contact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyn_contact`|
|ReferencingEntityNavigationPropertyName|`msdyn_Contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_lead_msdyn_salespremiumdemo_lead"></a> msdyn_lead_msdyn_salespremiumdemo_lead

One-To-Many Relationship: [lead msdyn_lead_msdyn_salespremiumdemo_lead](lead.md#BKMK_msdyn_lead_msdyn_salespremiumdemo_lead)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`msdyn_lead`|
|ReferencingEntityNavigationPropertyName|`msdyn_Lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_sequence_msdyn_salespremiumdemo_sequence"></a> msdyn_msdyn_sequence_msdyn_salespremiumdemo_sequence

One-To-Many Relationship: [msdyn_sequence msdyn_msdyn_sequence_msdyn_salespremiumdemo_sequence](msdyn_sequence.md#BKMK_msdyn_msdyn_sequence_msdyn_salespremiumdemo_sequence)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sequence`|
|ReferencedAttribute|`msdyn_sequenceid`|
|ReferencingAttribute|`msdyn_sequence`|
|ReferencingEntityNavigationPropertyName|`msdyn_sequence`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_opportunity_msdyn_salespremiumdemo_opportunity"></a> msdyn_opportunity_msdyn_salespremiumdemo_opportunity

One-To-Many Relationship: [opportunity msdyn_opportunity_msdyn_salespremiumdemo_opportunity](opportunity.md#BKMK_msdyn_opportunity_msdyn_salespremiumdemo_opportunity)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`msdyn_opportunity`|
|ReferencingEntityNavigationPropertyName|`msdyn_Opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_pricelevel_msdyn_salespremiumdemo_PriceList"></a> msdyn_pricelevel_msdyn_salespremiumdemo_PriceList

One-To-Many Relationship: [pricelevel msdyn_pricelevel_msdyn_salespremiumdemo_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_salespremiumdemo_PriceList)

|Property|Value|
|---|---|
|ReferencedEntity|`pricelevel`|
|ReferencedAttribute|`pricelevelid`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencingEntityNavigationPropertyName|`msdyn_PriceList`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_product_msdyn_salespremiumdemo_Product"></a> msdyn_product_msdyn_salespremiumdemo_Product

One-To-Many Relationship: [product msdyn_product_msdyn_salespremiumdemo_Product](product.md#BKMK_msdyn_product_msdyn_salespremiumdemo_Product)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`msdyn_product`|
|ReferencingEntityNavigationPropertyName|`msdyn_Product`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_salespremiumdemo"></a> organization_msdyn_salespremiumdemo

One-To-Many Relationship: [organization organization_msdyn_salespremiumdemo](organization.md#BKMK_organization_msdyn_salespremiumdemo)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_salespremiumdemo_AsyncOperations](#BKMK_msdyn_salespremiumdemo_AsyncOperations)
- [msdyn_salespremiumdemo_BulkDeleteFailures](#BKMK_msdyn_salespremiumdemo_BulkDeleteFailures)
- [msdyn_salespremiumdemo_DuplicateBaseRecord](#BKMK_msdyn_salespremiumdemo_DuplicateBaseRecord)
- [msdyn_salespremiumdemo_DuplicateMatchingRecord](#BKMK_msdyn_salespremiumdemo_DuplicateMatchingRecord)
- [msdyn_salespremiumdemo_MailboxTrackingFolders](#BKMK_msdyn_salespremiumdemo_MailboxTrackingFolders)
- [msdyn_salespremiumdemo_PrincipalObjectAttributeAccesses](#BKMK_msdyn_salespremiumdemo_PrincipalObjectAttributeAccesses)
- [msdyn_salespremiumdemo_ProcessSession](#BKMK_msdyn_salespremiumdemo_ProcessSession)
- [msdyn_salespremiumdemo_SyncErrors](#BKMK_msdyn_salespremiumdemo_SyncErrors)

### <a name="BKMK_msdyn_salespremiumdemo_AsyncOperations"></a> msdyn_salespremiumdemo_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_salespremiumdemo_AsyncOperations](asyncoperation.md#BKMK_msdyn_salespremiumdemo_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salespremiumdemo_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salespremiumdemo_BulkDeleteFailures"></a> msdyn_salespremiumdemo_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_salespremiumdemo_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_salespremiumdemo_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salespremiumdemo_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salespremiumdemo_DuplicateBaseRecord"></a> msdyn_salespremiumdemo_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_salespremiumdemo_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_salespremiumdemo_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salespremiumdemo_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salespremiumdemo_DuplicateMatchingRecord"></a> msdyn_salespremiumdemo_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_salespremiumdemo_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_salespremiumdemo_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salespremiumdemo_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salespremiumdemo_MailboxTrackingFolders"></a> msdyn_salespremiumdemo_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_salespremiumdemo_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_salespremiumdemo_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salespremiumdemo_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salespremiumdemo_PrincipalObjectAttributeAccesses"></a> msdyn_salespremiumdemo_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_salespremiumdemo_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_salespremiumdemo_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salespremiumdemo_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salespremiumdemo_ProcessSession"></a> msdyn_salespremiumdemo_ProcessSession

Many-To-One Relationship: [processsession msdyn_salespremiumdemo_ProcessSession](processsession.md#BKMK_msdyn_salespremiumdemo_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salespremiumdemo_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salespremiumdemo_SyncErrors"></a> msdyn_salespremiumdemo_SyncErrors

Many-To-One Relationship: [syncerror msdyn_salespremiumdemo_SyncErrors](syncerror.md#BKMK_msdyn_salespremiumdemo_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salespremiumdemo_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

