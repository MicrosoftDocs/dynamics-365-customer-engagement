---
title: "msdyn_aidescriptionrun table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the msdyn_aidescriptionrun table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# msdyn_aidescriptionrun table/entity reference (Microsoft Dynamics 365)

Central record for both Standalone generation and Optimization runs.

## Messages

The following table lists the messages for the msdyn_aidescriptionrun table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_aidescriptionruns(*msdyn_aidescriptionrunid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_aidescriptionruns<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_aidescriptionruns(*msdyn_aidescriptionrunid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_aidescriptionruns(*msdyn_aidescriptionrunid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_aidescriptionruns<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_aidescriptionruns(*msdyn_aidescriptionrunid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_aidescriptionruns(*msdyn_aidescriptionrunid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_aidescriptionruns(*msdyn_aidescriptionrunid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the msdyn_aidescriptionrun table.

|Property|Value|
| --- | --- |
| **DisplayName** | **msdyn_aidescriptionrun** |
| **DisplayCollectionName** | **msdyn_aidescriptionruns** |
| **SchemaName** | `msdyn_aidescriptionrun` |
| **CollectionSchemaName** | `msdyn_aidescriptionruns` |
| **EntitySetName** | `msdyn_aidescriptionruns`|
| **LogicalName** | `msdyn_aidescriptionrun` |
| **LogicalCollectionName** | `msdyn_aidescriptionruns` |
| **PrimaryIdAttribute** | `msdyn_aidescriptionrunid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_adminfilterxml](#BKMK_msdyn_adminfilterxml)
- [msdyn_aidescoptimizationrunid](#BKMK_msdyn_aidescoptimizationrunid)
- [msdyn_aidescriptionrunId](#BKMK_msdyn_aidescriptionrunId)
- [msdyn_aisimulationrunid](#BKMK_msdyn_aisimulationrunid)
- [msdyn_completedon](#BKMK_msdyn_completedon)
- [msdyn_confusioninsightjson](#BKMK_msdyn_confusioninsightjson)
- [msdyn_correlationid](#BKMK_msdyn_correlationid)
- [msdyn_currentround](#BKMK_msdyn_currentround)
- [msdyn_dataprepjson](#BKMK_msdyn_dataprepjson)
- [msdyn_entitylogicalname](#BKMK_msdyn_entitylogicalname)
- [msdyn_errordetails](#BKMK_msdyn_errordetails)
- [msdyn_failedcount](#BKMK_msdyn_failedcount)
- [msdyn_fieldlogicalname](#BKMK_msdyn_fieldlogicalname)
- [msdyn_fieldsjson](#BKMK_msdyn_fieldsjson)
- [msdyn_filtercriteriajson](#BKMK_msdyn_filtercriteriajson)
- [msdyn_finalaccuracyjson](#BKMK_msdyn_finalaccuracyjson)
- [msdyn_intermediatelog](#BKMK_msdyn_intermediatelog)
- [msdyn_isactivedraft](#BKMK_msdyn_isactivedraft)
- [msdyn_language](#BKMK_msdyn_language)
- [msdyn_maxrounds](#BKMK_msdyn_maxrounds)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_optimizeoptionsjson](#BKMK_msdyn_optimizeoptionsjson)
- [msdyn_plateaudetected](#BKMK_msdyn_plateaudetected)
- [msdyn_preflightreportjson](#BKMK_msdyn_preflightreportjson)
- [msdyn_previousaidescriptionrun](#BKMK_msdyn_previousaidescriptionrun)
- [msdyn_processedcount](#BKMK_msdyn_processedcount)
- [msdyn_processstatusmsg](#BKMK_msdyn_processstatusmsg)
- [msdyn_progresspercent](#BKMK_msdyn_progresspercent)
- [msdyn_publishedmode](#BKMK_msdyn_publishedmode)
- [msdyn_resultjson](#BKMK_msdyn_resultjson)
- [msdyn_roundhistoryjson](#BKMK_msdyn_roundhistoryjson)
- [msdyn_runtype](#BKMK_msdyn_runtype)
- [msdyn_sourcesimulationrunid](#BKMK_msdyn_sourcesimulationrunid)
- [msdyn_startedon](#BKMK_msdyn_startedon)
- [msdyn_status](#BKMK_msdyn_status)
- [msdyn_successcount](#BKMK_msdyn_successcount)
- [msdyn_targetaccuracy](#BKMK_msdyn_targetaccuracy)
- [msdyn_targetattributename](#BKMK_msdyn_targetattributename)
- [msdyn_targetentity](#BKMK_msdyn_targetentity)
- [msdyn_totalvaluecount](#BKMK_msdyn_totalvaluecount)
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

### <a name="BKMK_IsCustomizable"></a> IsCustomizable

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Is Customizable**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`iscustomizable`|
|RequiredLevel|SystemRequired|
|Type|ManagedProperty|

### <a name="BKMK_msdyn_adminfilterxml"></a> msdyn_adminfilterxml

|Property|Value|
|---|---|
|Description|**Optimization only. Optional admin-supplied FetchXML fragment spliced verbatim into the Data-Prep case fetch to scope which cases feed the optimizer. Null means no extra filter.**|
|DisplayName|**Admin Filter XML**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_adminfilterxml`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_aidescoptimizationrunid"></a> msdyn_aidescoptimizationrunid

|Property|Value|
|---|---|
|Description|**Non-null when this run is part of a Manage AI Accuracy optimization loop. Points to the parent msdyn\_aidescoptimizationrun. Used for filter views, audit, and orchestrator idempotency queries.**|
|DisplayName|**AI Description Optimization Run**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_aidescoptimizationrunid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_aidescoptimizationrun|

### <a name="BKMK_msdyn_aidescriptionrunId"></a> msdyn_aidescriptionrunId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances.**|
|DisplayName|**AI Description Run**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_aidescriptionrunid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_aisimulationrunid"></a> msdyn_aisimulationrunid

|Property|Value|
|---|---|
|Description|**Optimization only. Lookup to msdyn\_aisimulationrun (external — in another solution).**|
|DisplayName|**AI Simulation Run**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_aisimulationrunid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_aisimulationrun|

### <a name="BKMK_msdyn_completedon"></a> msdyn_completedon

|Property|Value|
|---|---|
|Description|**Stamped on terminal status.**|
|DisplayName|**Completed On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_completedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_confusioninsightjson"></a> msdyn_confusioninsightjson

|Property|Value|
|---|---|
|Description|**Optimization only. Step-4 global insight raw JSON.**|
|DisplayName|**Confusion Insight JSON**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_confusioninsightjson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_correlationid"></a> msdyn_correlationid

|Property|Value|
|---|---|
|Description|**End-to-end telemetry id.**|
|DisplayName|**Correlation Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_correlationid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_currentround"></a> msdyn_currentround

|Property|Value|
|---|---|
|Description|**Optimization only. Round currently running.**|
|DisplayName|**Current Round**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_currentround`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_dataprepjson"></a> msdyn_dataprepjson

|Property|Value|
|---|---|
|Description|**Optimization only. Step-0 splits plus admin filter plus target metadata.**|
|DisplayName|**Data Prep JSON**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_dataprepjson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_entitylogicalname"></a> msdyn_entitylogicalname

|Property|Value|
|---|---|
|Description|**Logical name of the parent entity (e.g. incident).**|
|DisplayName|**Entity Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entitylogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_errordetails"></a> msdyn_errordetails

|Property|Value|
|---|---|
|Description|**Error details if any.**|
|DisplayName|**Error Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_errordetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_failedcount"></a> msdyn_failedcount

|Property|Value|
|---|---|
|Description|**Standalone only.**|
|DisplayName|**Failed Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_failedcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_fieldlogicalname"></a> msdyn_fieldlogicalname

|Property|Value|
|---|---|
|Description|**Logical name of the field (e.g. msdyn\_category) for Standalone runs.**|
|DisplayName|**Field Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fieldlogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_fieldsjson"></a> msdyn_fieldsjson

|Property|Value|
|---|---|
|Description|**Optimization only. JSON array of fields being optimized.**|
|DisplayName|**Fields Json**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fieldsjson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_filtercriteriajson"></a> msdyn_filtercriteriajson

|Property|Value|
|---|---|
|Description|**Standalone only. JSON: \{ selectedValueKeys, caseFilter \}.**|
|DisplayName|**Filter Criteria Json**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_filtercriteriajson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_finalaccuracyjson"></a> msdyn_finalaccuracyjson

|Property|Value|
|---|---|
|Description|**Optimization only. Final accuracy per field.**|
|DisplayName|**Final Accuracy Json**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_finalaccuracyjson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_intermediatelog"></a> msdyn_intermediatelog

|Property|Value|
|---|---|
|Description|**Append-only start/complete progress log (JSON array). End-of-run size budget is approximately 20 KB.**|
|DisplayName|**Intermediate Log**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_intermediatelog`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_isactivedraft"></a> msdyn_isactivedraft

|Property|Value|
|---|---|
|Description|**True if this run's candidates are the active draft.**|
|DisplayName|**Is Active Draft**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isactivedraft`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_aidescriptionrun_msdyn_isactivedraft`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_language"></a> msdyn_language

|Property|Value|
|---|---|
|Description|**BCP-47 language tag (e.g. en-US).**|
|DisplayName|**Language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_language`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10|

### <a name="BKMK_msdyn_maxrounds"></a> msdyn_maxrounds

|Property|Value|
|---|---|
|Description|**Optimization only. Default 10.**|
|DisplayName|**Max Rounds**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_maxrounds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Primary name; auto-generated.**|
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
|MaxLength|200|

### <a name="BKMK_msdyn_optimizeoptionsjson"></a> msdyn_optimizeoptionsjson

|Property|Value|
|---|---|
|Description|**Optimization only. Effective run options after defaults plus overrides.**|
|DisplayName|**Optimize Options JSON**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_optimizeoptionsjson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_plateaudetected"></a> msdyn_plateaudetected

|Property|Value|
|---|---|
|Description|**Optimization only. True if plateau detected.**|
|DisplayName|**Plateau Detected**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_plateaudetected`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_aidescriptionrun_msdyn_plateaudetected`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_preflightreportjson"></a> msdyn_preflightreportjson

|Property|Value|
|---|---|
|Description|**Optimization only. Module 3 full rule-by-rule report.**|
|DisplayName|**Pre-Flight Report JSON**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_preflightreportjson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_previousaidescriptionrun"></a> msdyn_previousaidescriptionrun

|Property|Value|
|---|---|
|Description|**GUID of the previous run for the same field, stored as a string. Null on the first run.**|
|DisplayName|**Previous AI Description Run**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_previousaidescriptionrun`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_processedcount"></a> msdyn_processedcount

|Property|Value|
|---|---|
|Description|**Standalone only. PCF reads for progress bar.**|
|DisplayName|**Processed Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_processedcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_processstatusmsg"></a> msdyn_processstatusmsg

|Property|Value|
|---|---|
|Description|**Single-line human-readable status, overwritten at each module boundary. Companion to the append-only intermediate log.**|
|DisplayName|**Process Status Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_processstatusmsg`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_progresspercent"></a> msdyn_progresspercent

|Property|Value|
|---|---|
|Description|**Standalone only. Stored, not computed.**|
|DisplayName|**Progress Percent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_progresspercent`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_publishedmode"></a> msdyn_publishedmode

|Property|Value|
|---|---|
|Description|**When true, DescriptionGenerationFlow skips AI generation and snapshots currently-published descriptions instead. Set by the orchestrator for Round 0 only. Default false.**|
|DisplayName|**Published Mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_publishedmode`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_aidescriptionrun_msdyn_publishedmode`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_resultjson"></a> msdyn_resultjson

|Property|Value|
|---|---|
|Description|**Optimization only. Consolidated run result plus raw insight JSON (Module 11).**|
|DisplayName|**Result JSON**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_resultjson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_roundhistoryjson"></a> msdyn_roundhistoryjson

|Property|Value|
|---|---|
|Description|**Optimization only. Per-round accuracy per field.**|
|DisplayName|**Round History Json**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_roundhistoryjson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_runtype"></a> msdyn_runtype

|Property|Value|
|---|---|
|Description|**Drives which PA Flow triggers.**|
|DisplayName|**Run Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_runtype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|700610000|
|GlobalChoiceName|`msdyn_aidescriptionrun_msdyn_runtype`|

#### msdyn_runtype Choices/Options

|Value|Label|
|---|---|
|700610000|**Standalone**|
|700610001|**Optimization**|

### <a name="BKMK_msdyn_sourcesimulationrunid"></a> msdyn_sourcesimulationrunid

|Property|Value|
|---|---|
|Description|**Optimization only. GUID of source msdyn\_aisimulationrun stored as text to avoid cross-solution dependency.**|
|DisplayName|**Source Simulation Run Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sourcesimulationrunid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_startedon"></a> msdyn_startedon

|Property|Value|
|---|---|
|Description|**Stamped when status moves to InProgress.**|
|DisplayName|**Started On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_status"></a> msdyn_status

|Property|Value|
|---|---|
|Description|**Lifecycle status of the run.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_status`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|700610000|
|GlobalChoiceName|`msdyn_aidescriptionrun_msdyn_status`|

#### msdyn_status Choices/Options

|Value|Label|
|---|---|
|700610000|**Pending**|
|700610001|**InProgress**|
|700610002|**Completed**|
|700610003|**PartiallyCompleted**|
|700610004|**Plateaued**|
|700610005|**Stopped**|
|700610006|**Failed**|
|700610007|**Cancelling**|
|700610008|**Cancelled**|

### <a name="BKMK_msdyn_successcount"></a> msdyn_successcount

|Property|Value|
|---|---|
|Description|**Standalone only.**|
|DisplayName|**Success Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_successcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_targetaccuracy"></a> msdyn_targetaccuracy

|Property|Value|
|---|---|
|Description|**Optimization only. Target accuracy fraction (e.g. 0.80).**|
|DisplayName|**Target Accuracy**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_targetaccuracy`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|1|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_targetattributename"></a> msdyn_targetattributename

|Property|Value|
|---|---|
|Description|**Logical name of the target attribute on the referenced entity record where the description is written.**|
|DisplayName|**Target Attribute Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_targetattributename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_targetentity"></a> msdyn_targetentity

|Property|Value|
|---|---|
|Description|**Optimization only. Logical name of the lookup target entity whose rows hold the descriptions (e.g. subject). Distinct from msdyn\_entitylogicalname (the analyzed entity, e.g. incident). Read by DescriptionWriter and Revert.**|
|DisplayName|**Target Entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_targetentity`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_totalvaluecount"></a> msdyn_totalvaluecount

|Property|Value|
|---|---|
|Description|**Standalone only. Total values to process — written by PCF at run creation.**|
|DisplayName|**Total Value Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalvaluecount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

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
|Description|**Status.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_aidescriptionrun_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_aidescriptionrun_statuscode`|

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

- [ComponentIdUnique](#BKMK_ComponentIdUnique)
- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OverwriteTime](#BKMK_OverwriteTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_ComponentIdUnique"></a> ComponentIdUnique

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Row id unique**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentidunique`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Component State**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentstate`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`componentstate`|

#### ComponentState Choices/Options

|Value|Label|
|---|---|
|0|**Published**|
|1|**Unpublished**|
|2|**Deleted**|
|3|**Deleted Unpublished**|

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

### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|---|---|
|Description|**Indicates whether the solution component is part of a managed solution.**|
|DisplayName|**Is Managed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ismanaged`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`ismanaged`|
|DefaultValue|False|
|True Label|Managed|
|False Label|Unmanaged|

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

### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Record Overwrite Time**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overwritetime`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

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
|Description|**Unique identifier for the business unit that owns the record.**|
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

### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|---|---|
|Description|**Unique identifier of the associated solution.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`solutionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`supportingsolutionid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

- [business_unit_msdyn_aidescriptionrun](#BKMK_business_unit_msdyn_aidescriptionrun)
- [lk_msdyn_aidescriptionrun_createdby](#BKMK_lk_msdyn_aidescriptionrun_createdby)
- [lk_msdyn_aidescriptionrun_createdonbehalfby](#BKMK_lk_msdyn_aidescriptionrun_createdonbehalfby)
- [lk_msdyn_aidescriptionrun_modifiedby](#BKMK_lk_msdyn_aidescriptionrun_modifiedby)
- [lk_msdyn_aidescriptionrun_modifiedonbehalfby](#BKMK_lk_msdyn_aidescriptionrun_modifiedonbehalfby)
- [msdyn_aidescriptionrun_msdyn_aidescoptimizationrunid_msdyn_aidescoptimizationrun](#BKMK_msdyn_aidescriptionrun_msdyn_aidescoptimizationrunid_msdyn_aidescoptimizationrun)
- [msdyn_aidescriptionrun_msdyn_aisimulationrunid_msdyn_aisimulationrun](#BKMK_msdyn_aidescriptionrun_msdyn_aisimulationrunid_msdyn_aisimulationrun)
- [owner_msdyn_aidescriptionrun](#BKMK_owner_msdyn_aidescriptionrun)
- [team_msdyn_aidescriptionrun](#BKMK_team_msdyn_aidescriptionrun)
- [user_msdyn_aidescriptionrun](#BKMK_user_msdyn_aidescriptionrun)

### <a name="BKMK_business_unit_msdyn_aidescriptionrun"></a> business_unit_msdyn_aidescriptionrun

One-To-Many Relationship: [businessunit business_unit_msdyn_aidescriptionrun](businessunit.md#BKMK_business_unit_msdyn_aidescriptionrun)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aidescriptionrun_createdby"></a> lk_msdyn_aidescriptionrun_createdby

One-To-Many Relationship: [systemuser lk_msdyn_aidescriptionrun_createdby](systemuser.md#BKMK_lk_msdyn_aidescriptionrun_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aidescriptionrun_createdonbehalfby"></a> lk_msdyn_aidescriptionrun_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_aidescriptionrun_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_aidescriptionrun_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aidescriptionrun_modifiedby"></a> lk_msdyn_aidescriptionrun_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_aidescriptionrun_modifiedby](systemuser.md#BKMK_lk_msdyn_aidescriptionrun_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aidescriptionrun_modifiedonbehalfby"></a> lk_msdyn_aidescriptionrun_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_aidescriptionrun_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_aidescriptionrun_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_aidescriptionrun_msdyn_aidescoptimizationrunid_msdyn_aidescoptimizationrun"></a> msdyn_aidescriptionrun_msdyn_aidescoptimizationrunid_msdyn_aidescoptimizationrun

One-To-Many Relationship: [msdyn_aidescoptimizationrun msdyn_aidescriptionrun_msdyn_aidescoptimizationrunid_msdyn_aidescoptimizationrun](msdyn_aidescoptimizationrun.md#BKMK_msdyn_aidescriptionrun_msdyn_aidescoptimizationrunid_msdyn_aidescoptimizationrun)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_aidescoptimizationrun`|
|ReferencedAttribute|`msdyn_aidescoptimizationrunid`|
|ReferencingAttribute|`msdyn_aidescoptimizationrunid`|
|ReferencingEntityNavigationPropertyName|`msdyn_aidescoptimizationrunid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_aidescriptionrun_msdyn_aisimulationrunid_msdyn_aisimulationrun"></a> msdyn_aidescriptionrun_msdyn_aisimulationrunid_msdyn_aisimulationrun

One-To-Many Relationship: [msdyn_aisimulationrun msdyn_aidescriptionrun_msdyn_aisimulationrunid_msdyn_aisimulationrun](msdyn_aisimulationrun.md#BKMK_msdyn_aidescriptionrun_msdyn_aisimulationrunid_msdyn_aisimulationrun)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_aisimulationrun`|
|ReferencedAttribute|`msdyn_aisimulationrunid`|
|ReferencingAttribute|`msdyn_aisimulationrunid`|
|ReferencingEntityNavigationPropertyName|`msdyn_aisimulationrunid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_aidescriptionrun"></a> owner_msdyn_aidescriptionrun

One-To-Many Relationship: [owner owner_msdyn_aidescriptionrun](owner.md#BKMK_owner_msdyn_aidescriptionrun)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_aidescriptionrun"></a> team_msdyn_aidescriptionrun

One-To-Many Relationship: [team team_msdyn_aidescriptionrun](team.md#BKMK_team_msdyn_aidescriptionrun)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_aidescriptionrun"></a> user_msdyn_aidescriptionrun

One-To-Many Relationship: [systemuser user_msdyn_aidescriptionrun](systemuser.md#BKMK_user_msdyn_aidescriptionrun)

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

- [msdyn_aidescriptioncandidate_msdyn_aidescriptionrunid_msdyn_aidescriptionrun](#BKMK_msdyn_aidescriptioncandidate_msdyn_aidescriptionrunid_msdyn_aidescriptionrun)
- [msdyn_aidescriptionpublishjob_msdyn_aidescriptionrunid_msdyn_aidescriptionrun](#BKMK_msdyn_aidescriptionpublishjob_msdyn_aidescriptionrunid_msdyn_aidescriptionrun)
- [msdyn_aidescriptionrun_AsyncOperations](#BKMK_msdyn_aidescriptionrun_AsyncOperations)
- [msdyn_aidescriptionrun_BulkDeleteFailures](#BKMK_msdyn_aidescriptionrun_BulkDeleteFailures)
- [msdyn_aidescriptionrun_MailboxTrackingFolders](#BKMK_msdyn_aidescriptionrun_MailboxTrackingFolders)
- [msdyn_aidescriptionrun_PrincipalObjectAttributeAccesses](#BKMK_msdyn_aidescriptionrun_PrincipalObjectAttributeAccesses)
- [msdyn_aidescriptionrun_ProcessSession](#BKMK_msdyn_aidescriptionrun_ProcessSession)
- [msdyn_aidescriptionrun_SyncErrors](#BKMK_msdyn_aidescriptionrun_SyncErrors)
- [msdyn_aidescriptionvalue_msdyn_activedraftrunid_msdyn_aidescriptionrun](#BKMK_msdyn_aidescriptionvalue_msdyn_activedraftrunid_msdyn_aidescriptionrun)

### <a name="BKMK_msdyn_aidescriptioncandidate_msdyn_aidescriptionrunid_msdyn_aidescriptionrun"></a> msdyn_aidescriptioncandidate_msdyn_aidescriptionrunid_msdyn_aidescriptionrun

Many-To-One Relationship: [msdyn_aidescriptioncandidate msdyn_aidescriptioncandidate_msdyn_aidescriptionrunid_msdyn_aidescriptionrun](msdyn_aidescriptioncandidate.md#BKMK_msdyn_aidescriptioncandidate_msdyn_aidescriptionrunid_msdyn_aidescriptionrun)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_aidescriptioncandidate`|
|ReferencingAttribute|`msdyn_aidescriptionrunid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescriptioncandidate_msdyn_aidescriptionrunid_msdyn_aidescriptionrun`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescriptionpublishjob_msdyn_aidescriptionrunid_msdyn_aidescriptionrun"></a> msdyn_aidescriptionpublishjob_msdyn_aidescriptionrunid_msdyn_aidescriptionrun

Many-To-One Relationship: [msdyn_aidescriptionpublishjob msdyn_aidescriptionpublishjob_msdyn_aidescriptionrunid_msdyn_aidescriptionrun](msdyn_aidescriptionpublishjob.md#BKMK_msdyn_aidescriptionpublishjob_msdyn_aidescriptionrunid_msdyn_aidescriptionrun)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_aidescriptionpublishjob`|
|ReferencingAttribute|`msdyn_aidescriptionrunid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescriptionpublishjob_msdyn_aidescriptionrunid_msdyn_aidescriptionrun`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescriptionrun_AsyncOperations"></a> msdyn_aidescriptionrun_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_aidescriptionrun_AsyncOperations](asyncoperation.md#BKMK_msdyn_aidescriptionrun_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescriptionrun_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescriptionrun_BulkDeleteFailures"></a> msdyn_aidescriptionrun_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_aidescriptionrun_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_aidescriptionrun_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescriptionrun_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescriptionrun_MailboxTrackingFolders"></a> msdyn_aidescriptionrun_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_aidescriptionrun_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_aidescriptionrun_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescriptionrun_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescriptionrun_PrincipalObjectAttributeAccesses"></a> msdyn_aidescriptionrun_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_aidescriptionrun_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_aidescriptionrun_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescriptionrun_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescriptionrun_ProcessSession"></a> msdyn_aidescriptionrun_ProcessSession

Many-To-One Relationship: [processsession msdyn_aidescriptionrun_ProcessSession](processsession.md#BKMK_msdyn_aidescriptionrun_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescriptionrun_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescriptionrun_SyncErrors"></a> msdyn_aidescriptionrun_SyncErrors

Many-To-One Relationship: [syncerror msdyn_aidescriptionrun_SyncErrors](syncerror.md#BKMK_msdyn_aidescriptionrun_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescriptionrun_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescriptionvalue_msdyn_activedraftrunid_msdyn_aidescriptionrun"></a> msdyn_aidescriptionvalue_msdyn_activedraftrunid_msdyn_aidescriptionrun

Many-To-One Relationship: [msdyn_aidescriptionvalue msdyn_aidescriptionvalue_msdyn_activedraftrunid_msdyn_aidescriptionrun](msdyn_aidescriptionvalue.md#BKMK_msdyn_aidescriptionvalue_msdyn_activedraftrunid_msdyn_aidescriptionrun)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_aidescriptionvalue`|
|ReferencingAttribute|`msdyn_activedraftrunid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescriptionvalue_msdyn_activedraftrunid_msdyn_aidescriptionrun`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

