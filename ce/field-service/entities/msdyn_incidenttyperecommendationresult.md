---
title: "Incident Type Suggestion Result (msdyn_incidenttyperecommendationresult) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Incident Type Suggestion Result (msdyn_incidenttyperecommendationresult) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Incident Type Suggestion Result (msdyn_incidenttyperecommendationresult) table/entity reference

Incident Type Suggestion Results store all suggestion results.

## Messages

The following table lists the messages for the Incident Type Suggestion Result (msdyn_incidenttyperecommendationresult) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_incidenttyperecommendationresults(*msdyn_incidenttyperecommendationresultid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_incidenttyperecommendationresults<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_incidenttyperecommendationresults(*msdyn_incidenttyperecommendationresultid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_incidenttyperecommendationresults(*msdyn_incidenttyperecommendationresultid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_incidenttyperecommendationresults<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_incidenttyperecommendationresults(*msdyn_incidenttyperecommendationresultid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_incidenttyperecommendationresults(*msdyn_incidenttyperecommendationresultid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_incidenttyperecommendationresults(*msdyn_incidenttyperecommendationresultid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Incident Type Suggestion Result (msdyn_incidenttyperecommendationresult) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Incident Type Suggestion Result (msdyn_incidenttyperecommendationresult) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Incident Type Suggestion Result** |
| **DisplayCollectionName** | **Incident Type Suggestion Results** |
| **SchemaName** | `msdyn_incidenttyperecommendationresult` |
| **CollectionSchemaName** | `msdyn_incidenttyperecommendationresults` |
| **EntitySetName** | `msdyn_incidenttyperecommendationresults`|
| **LogicalName** | `msdyn_incidenttyperecommendationresult` |
| **LogicalCollectionName** | `msdyn_incidenttyperecommendationresults` |
| **PrimaryIdAttribute** | `msdyn_incidenttyperecommendationresultid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_IncidentType](#BKMK_msdyn_IncidentType)
- [msdyn_IncidentTypeForMerge](#BKMK_msdyn_IncidentTypeForMerge)
- [msdyn_IncidentTypeId](#BKMK_msdyn_IncidentTypeId)
- [msdyn_IncidentTypeIdForMerge](#BKMK_msdyn_IncidentTypeIdForMerge)
- [msdyn_incidenttyperecommendationresultId](#BKMK_msdyn_incidenttyperecommendationresultId)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_OccurrenceTimes](#BKMK_msdyn_OccurrenceTimes)
- [msdyn_ProductService](#BKMK_msdyn_ProductService)
- [msdyn_ProductServiceId](#BKMK_msdyn_ProductServiceId)
- [msdyn_RecommendationDescription](#BKMK_msdyn_RecommendationDescription)
- [msdyn_RecommendationType](#BKMK_msdyn_RecommendationType)
- [msdyn_RunHistoryId](#BKMK_msdyn_RunHistoryId)
- [msdyn_RunId](#BKMK_msdyn_RunId)
- [msdyn_ScoreRanking](#BKMK_msdyn_ScoreRanking)
- [msdyn_SuggestedValue](#BKMK_msdyn_SuggestedValue)
- [msdyn_TotalOccurrenceTimes](#BKMK_msdyn_TotalOccurrenceTimes)
- [msdyn_Unit](#BKMK_msdyn_Unit)
- [msdyn_UnitId](#BKMK_msdyn_UnitId)
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

### <a name="BKMK_msdyn_IncidentType"></a> msdyn_IncidentType

|Property|Value|
|---|---|
|Description|**Shows the incident related to this suggestion result.**|
|DisplayName|**Incident Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_incidenttype`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_incidenttype|

### <a name="BKMK_msdyn_IncidentTypeForMerge"></a> msdyn_IncidentTypeForMerge

|Property|Value|
|---|---|
|Description|**Shows the incident (for merge) related to this suggestion result.**|
|DisplayName|**Incident Type (For Merge)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_incidenttypeformerge`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_incidenttype|

### <a name="BKMK_msdyn_IncidentTypeId"></a> msdyn_IncidentTypeId

|Property|Value|
|---|---|
|Description|**Shows unique identifier of an incident type.**|
|DisplayName|**Incident Type Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_incidenttypeid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_IncidentTypeIdForMerge"></a> msdyn_IncidentTypeIdForMerge

|Property|Value|
|---|---|
|Description|**Shows unique identifier of an incident (for merge).**|
|DisplayName|**Incident Type Id (For Merge)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_incidenttypeidformerge`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_incidenttyperecommendationresultId"></a> msdyn_incidenttyperecommendationresultId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Incident Type Suggestion Result**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_incidenttyperecommendationresultid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

### <a name="BKMK_msdyn_OccurrenceTimes"></a> msdyn_OccurrenceTimes

|Property|Value|
|---|---|
|Description|**Shows the occurrence times of the related incident type.**|
|DisplayName|**Occurrence Times**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_occurrencetimes`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_ProductService"></a> msdyn_ProductService

|Property|Value|
|---|---|
|Description|**Shows the product related to this suggestion result.**|
|DisplayName|**Product/Service**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_productservice`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|product|

### <a name="BKMK_msdyn_ProductServiceId"></a> msdyn_ProductServiceId

|Property|Value|
|---|---|
|Description|**Shows unique identifier of a product.**|
|DisplayName|**Product/Service Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_productserviceid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_RecommendationDescription"></a> msdyn_RecommendationDescription

|Property|Value|
|---|---|
|Description|**Shows the suggestion description.**|
|DisplayName|**Suggestion Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recommendationdescription`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8000|

### <a name="BKMK_msdyn_RecommendationType"></a> msdyn_RecommendationType

|Property|Value|
|---|---|
|Description|**Shows the type of incident type suggestion.**|
|DisplayName|**Suggestion Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recommendationtype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_incidenttyperecommendationresult_msdyn_recommendationtype`|

#### msdyn_RecommendationType Choices/Options

|Value|Label|
|---|---|
|192350000|**Work Order Product**|
|192350001|**Work Order Service**|
|192350002|**Incident Type**|

### <a name="BKMK_msdyn_RunHistoryId"></a> msdyn_RunHistoryId

|Property|Value|
|---|---|
|Description|**Id of Incident Type Suggestion Run History**|
|DisplayName|**Run History Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_runhistoryid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_incidenttyperecommendationrunhistory|

### <a name="BKMK_msdyn_RunId"></a> msdyn_RunId

|Property|Value|
|---|---|
|Description|**Shows unique identifier of the related run job.**|
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

### <a name="BKMK_msdyn_ScoreRanking"></a> msdyn_ScoreRanking

|Property|Value|
|---|---|
|Description|**Shows the score ranking of the result.**|
|DisplayName|**Score Ranking**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scoreranking`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|1000|
|MinValue|0|

### <a name="BKMK_msdyn_SuggestedValue"></a> msdyn_SuggestedValue

|Property|Value|
|---|---|
|Description|**Shows the suggested value of product quantity or service duration.**|
|DisplayName|**Suggested Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestedvalue`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_TotalOccurrenceTimes"></a> msdyn_TotalOccurrenceTimes

|Property|Value|
|---|---|
|Description|**Shows the total occurrence times of the related incident type.**|
|DisplayName|**Total Occurrence Times**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totaloccurrencetimes`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_Unit"></a> msdyn_Unit

|Property|Value|
|---|---|
|Description|**The unit that determines the pricing and final quantity for this product or service.**|
|DisplayName|**Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|uom|

### <a name="BKMK_msdyn_UnitId"></a> msdyn_UnitId

|Property|Value|
|---|---|
|Description|**Shows unique identifier of the unit.**|
|DisplayName|**Unit Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unitid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|Description|**Status of the Incident Type Suggestion Result**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_incidenttyperecommendationresult_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Incident Type Suggestion Result**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_incidenttyperecommendationresult_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|
|192350000|Label: **Disliked**<br />State:1<br />TransitionData: None|
|192350001|Label: **Applied**<br />State:1<br />TransitionData: None|

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

- [business_unit_msdyn_incidenttyperecommendationresult](#BKMK_business_unit_msdyn_incidenttyperecommendationresult)
- [lk_msdyn_incidenttyperecommendationresult_createdby](#BKMK_lk_msdyn_incidenttyperecommendationresult_createdby)
- [lk_msdyn_incidenttyperecommendationresult_createdonbehalfby](#BKMK_lk_msdyn_incidenttyperecommendationresult_createdonbehalfby)
- [lk_msdyn_incidenttyperecommendationresult_modifiedby](#BKMK_lk_msdyn_incidenttyperecommendationresult_modifiedby)
- [lk_msdyn_incidenttyperecommendationresult_modifiedonbehalfby](#BKMK_lk_msdyn_incidenttyperecommendationresult_modifiedonbehalfby)
- [msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentType)
- [msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentTypeForMerge](#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentTypeForMerge)
- [msdyn_msdyn_incidenttyperecommendationrunhistory_msdyn_incidenttyperecommendationresult_RunHistoryId](#BKMK_msdyn_msdyn_incidenttyperecommendationrunhistory_msdyn_incidenttyperecommendationresult_RunHistoryId)
- [msdyn_product_msdyn_incidenttyperecommendationresult_ProductService](#BKMK_msdyn_product_msdyn_incidenttyperecommendationresult_ProductService)
- [msdyn_uom_msdyn_incidenttyperecommendationresult_Unit](#BKMK_msdyn_uom_msdyn_incidenttyperecommendationresult_Unit)
- [owner_msdyn_incidenttyperecommendationresult](#BKMK_owner_msdyn_incidenttyperecommendationresult)
- [team_msdyn_incidenttyperecommendationresult](#BKMK_team_msdyn_incidenttyperecommendationresult)
- [user_msdyn_incidenttyperecommendationresult](#BKMK_user_msdyn_incidenttyperecommendationresult)

### <a name="BKMK_business_unit_msdyn_incidenttyperecommendationresult"></a> business_unit_msdyn_incidenttyperecommendationresult

One-To-Many Relationship: [businessunit business_unit_msdyn_incidenttyperecommendationresult](businessunit.md#BKMK_business_unit_msdyn_incidenttyperecommendationresult)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_incidenttyperecommendationresult_createdby"></a> lk_msdyn_incidenttyperecommendationresult_createdby

One-To-Many Relationship: [systemuser lk_msdyn_incidenttyperecommendationresult_createdby](systemuser.md#BKMK_lk_msdyn_incidenttyperecommendationresult_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_incidenttyperecommendationresult_createdonbehalfby"></a> lk_msdyn_incidenttyperecommendationresult_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_incidenttyperecommendationresult_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_incidenttyperecommendationresult_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_incidenttyperecommendationresult_modifiedby"></a> lk_msdyn_incidenttyperecommendationresult_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_incidenttyperecommendationresult_modifiedby](systemuser.md#BKMK_lk_msdyn_incidenttyperecommendationresult_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_incidenttyperecommendationresult_modifiedonbehalfby"></a> lk_msdyn_incidenttyperecommendationresult_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_incidenttyperecommendationresult_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_incidenttyperecommendationresult_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentType

One-To-Many Relationship: [msdyn_incidenttype msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentType](msdyn_incidenttype.md#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentType)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype`|
|ReferencedAttribute|`msdyn_incidenttypeid`|
|ReferencingAttribute|`msdyn_incidenttype`|
|ReferencingEntityNavigationPropertyName|`msdyn_IncidentType`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentTypeForMerge"></a> msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentTypeForMerge

One-To-Many Relationship: [msdyn_incidenttype msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentTypeForMerge](msdyn_incidenttype.md#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentTypeForMerge)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype`|
|ReferencedAttribute|`msdyn_incidenttypeid`|
|ReferencingAttribute|`msdyn_incidenttypeformerge`|
|ReferencingEntityNavigationPropertyName|`msdyn_IncidentTypeForMerge`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_incidenttyperecommendationrunhistory_msdyn_incidenttyperecommendationresult_RunHistoryId"></a> msdyn_msdyn_incidenttyperecommendationrunhistory_msdyn_incidenttyperecommendationresult_RunHistoryId

One-To-Many Relationship: [msdyn_incidenttyperecommendationrunhistory msdyn_msdyn_incidenttyperecommendationrunhistory_msdyn_incidenttyperecommendationresult_RunHistoryId](msdyn_incidenttyperecommendationrunhistory.md#BKMK_msdyn_msdyn_incidenttyperecommendationrunhistory_msdyn_incidenttyperecommendationresult_RunHistoryId)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperecommendationrunhistory`|
|ReferencedAttribute|`msdyn_incidenttyperecommendationrunhistoryid`|
|ReferencingAttribute|`msdyn_runhistoryid`|
|ReferencingEntityNavigationPropertyName|`msdyn_RunHistoryId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_product_msdyn_incidenttyperecommendationresult_ProductService"></a> msdyn_product_msdyn_incidenttyperecommendationresult_ProductService

One-To-Many Relationship: [product msdyn_product_msdyn_incidenttyperecommendationresult_ProductService](product.md#BKMK_msdyn_product_msdyn_incidenttyperecommendationresult_ProductService)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`msdyn_productservice`|
|ReferencingEntityNavigationPropertyName|`msdyn_ProductService`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_uom_msdyn_incidenttyperecommendationresult_Unit"></a> msdyn_uom_msdyn_incidenttyperecommendationresult_Unit

One-To-Many Relationship: [uom msdyn_uom_msdyn_incidenttyperecommendationresult_Unit](uom.md#BKMK_msdyn_uom_msdyn_incidenttyperecommendationresult_Unit)

|Property|Value|
|---|---|
|ReferencedEntity|`uom`|
|ReferencedAttribute|`uomid`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencingEntityNavigationPropertyName|`msdyn_Unit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_incidenttyperecommendationresult"></a> owner_msdyn_incidenttyperecommendationresult

One-To-Many Relationship: [owner owner_msdyn_incidenttyperecommendationresult](owner.md#BKMK_owner_msdyn_incidenttyperecommendationresult)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_incidenttyperecommendationresult"></a> team_msdyn_incidenttyperecommendationresult

One-To-Many Relationship: [team team_msdyn_incidenttyperecommendationresult](team.md#BKMK_team_msdyn_incidenttyperecommendationresult)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_incidenttyperecommendationresult"></a> user_msdyn_incidenttyperecommendationresult

One-To-Many Relationship: [systemuser user_msdyn_incidenttyperecommendationresult](systemuser.md#BKMK_user_msdyn_incidenttyperecommendationresult)

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

- [msdyn_incidenttyperecommendationresult_AsyncOperations](#BKMK_msdyn_incidenttyperecommendationresult_AsyncOperations)
- [msdyn_incidenttyperecommendationresult_BulkDeleteFailures](#BKMK_msdyn_incidenttyperecommendationresult_BulkDeleteFailures)
- [msdyn_incidenttyperecommendationresult_DuplicateBaseRecord](#BKMK_msdyn_incidenttyperecommendationresult_DuplicateBaseRecord)
- [msdyn_incidenttyperecommendationresult_DuplicateMatchingRecord](#BKMK_msdyn_incidenttyperecommendationresult_DuplicateMatchingRecord)
- [msdyn_incidenttyperecommendationresult_MailboxTrackingFolders](#BKMK_msdyn_incidenttyperecommendationresult_MailboxTrackingFolders)
- [msdyn_incidenttyperecommendationresult_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttyperecommendationresult_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttyperecommendationresult_ProcessSession](#BKMK_msdyn_incidenttyperecommendationresult_ProcessSession)
- [msdyn_incidenttyperecommendationresult_SyncErrors](#BKMK_msdyn_incidenttyperecommendationresult_SyncErrors)
- [msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeproduct_AppliedSuggestionResult](#BKMK_msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeproduct_AppliedSuggestionResult)
- [msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeservice_AppliedSuggestionResult](#BKMK_msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeservice_AppliedSuggestionResult)

### <a name="BKMK_msdyn_incidenttyperecommendationresult_AsyncOperations"></a> msdyn_incidenttyperecommendationresult_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_incidenttyperecommendationresult_AsyncOperations](asyncoperation.md#BKMK_msdyn_incidenttyperecommendationresult_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttyperecommendationresult_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttyperecommendationresult_BulkDeleteFailures"></a> msdyn_incidenttyperecommendationresult_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_incidenttyperecommendationresult_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_incidenttyperecommendationresult_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttyperecommendationresult_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttyperecommendationresult_DuplicateBaseRecord"></a> msdyn_incidenttyperecommendationresult_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_incidenttyperecommendationresult_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_incidenttyperecommendationresult_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttyperecommendationresult_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttyperecommendationresult_DuplicateMatchingRecord"></a> msdyn_incidenttyperecommendationresult_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_incidenttyperecommendationresult_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_incidenttyperecommendationresult_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttyperecommendationresult_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttyperecommendationresult_MailboxTrackingFolders"></a> msdyn_incidenttyperecommendationresult_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_incidenttyperecommendationresult_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_incidenttyperecommendationresult_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttyperecommendationresult_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttyperecommendationresult_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttyperecommendationresult_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_incidenttyperecommendationresult_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_incidenttyperecommendationresult_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttyperecommendationresult_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttyperecommendationresult_ProcessSession"></a> msdyn_incidenttyperecommendationresult_ProcessSession

Many-To-One Relationship: [processsession msdyn_incidenttyperecommendationresult_ProcessSession](processsession.md#BKMK_msdyn_incidenttyperecommendationresult_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttyperecommendationresult_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttyperecommendationresult_SyncErrors"></a> msdyn_incidenttyperecommendationresult_SyncErrors

Many-To-One Relationship: [syncerror msdyn_incidenttyperecommendationresult_SyncErrors](syncerror.md#BKMK_msdyn_incidenttyperecommendationresult_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttyperecommendationresult_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeproduct_AppliedSuggestionResult"></a> msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeproduct_AppliedSuggestionResult

Many-To-One Relationship: [msdyn_incidenttypeproduct msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeproduct_AppliedSuggestionResult](msdyn_incidenttypeproduct.md#BKMK_msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeproduct_AppliedSuggestionResult)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeproduct`|
|ReferencingAttribute|`msdyn_appliedsuggestionresult`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeproduct_AppliedSuggestionResult`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeservice_AppliedSuggestionResult"></a> msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeservice_AppliedSuggestionResult

Many-To-One Relationship: [msdyn_incidenttypeservice msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeservice_AppliedSuggestionResult](msdyn_incidenttypeservice.md#BKMK_msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeservice_AppliedSuggestionResult)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeservice`|
|ReferencingAttribute|`msdyn_appliedsuggestionresult`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeservice_AppliedSuggestionResult`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

