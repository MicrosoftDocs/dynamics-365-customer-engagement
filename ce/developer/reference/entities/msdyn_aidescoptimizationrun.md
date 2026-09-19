---
title: "msdyn_aidescoptimizationrun table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the msdyn_aidescoptimizationrun table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# msdyn_aidescoptimizationrun table/entity reference (Microsoft Dynamics 365)

Orchestrator record for an iterative AI description optimization run. One row per Improve-accuracy click; spans multiple rounds.

## Messages

The following table lists the messages for the msdyn_aidescoptimizationrun table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_aidescoptimizationruns(*msdyn_aidescoptimizationrunid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_aidescoptimizationruns<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_aidescoptimizationruns(*msdyn_aidescoptimizationrunid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_aidescoptimizationruns(*msdyn_aidescoptimizationrunid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_aidescoptimizationruns<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_aidescoptimizationruns(*msdyn_aidescoptimizationrunid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_aidescoptimizationruns(*msdyn_aidescoptimizationrunid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_aidescoptimizationruns(*msdyn_aidescoptimizationrunid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the msdyn_aidescoptimizationrun table.

|Property|Value|
| --- | --- |
| **DisplayName** | **msdyn_aidescoptimizationrun** |
| **DisplayCollectionName** | **msdyn_aidescoptimizationruns** |
| **SchemaName** | `msdyn_aidescoptimizationrun` |
| **CollectionSchemaName** | `msdyn_aidescoptimizationruns` |
| **EntitySetName** | `msdyn_aidescoptimizationruns`|
| **LogicalName** | `msdyn_aidescoptimizationrun` |
| **LogicalCollectionName** | `msdyn_aidescoptimizationruns` |
| **PrimaryIdAttribute** | `msdyn_aidescoptimizationrunid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_aidescoptimizationrunId](#BKMK_msdyn_aidescoptimizationrunId)
- [msdyn_bestroundjson](#BKMK_msdyn_bestroundjson)
- [msdyn_bestroundnumber](#BKMK_msdyn_bestroundnumber)
- [msdyn_completedon](#BKMK_msdyn_completedon)
- [msdyn_correlationid](#BKMK_msdyn_correlationid)
- [msdyn_currentiteration](#BKMK_msdyn_currentiteration)
- [msdyn_entitylogicalname](#BKMK_msdyn_entitylogicalname)
- [msdyn_errordetails](#BKMK_msdyn_errordetails)
- [msdyn_fieldlogicalname](#BKMK_msdyn_fieldlogicalname)
- [msdyn_initialsimulationrunid](#BKMK_msdyn_initialsimulationrunid)
- [msdyn_iterateonbest](#BKMK_msdyn_iterateonbest)
- [msdyn_language](#BKMK_msdyn_language)
- [msdyn_maxrounds](#BKMK_msdyn_maxrounds)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_processstatusmsg](#BKMK_msdyn_processstatusmsg)
- [msdyn_progresslog](#BKMK_msdyn_progresslog)
- [msdyn_roundresultsjson](#BKMK_msdyn_roundresultsjson)
- [msdyn_startedon](#BKMK_msdyn_startedon)
- [msdyn_status](#BKMK_msdyn_status)
- [msdyn_targetaccuracy](#BKMK_msdyn_targetaccuracy)
- [msdyn_targetattributename](#BKMK_msdyn_targetattributename)
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

### <a name="BKMK_msdyn_aidescoptimizationrunId"></a> msdyn_aidescoptimizationrunId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances.**|
|DisplayName|**AI Description Optimization Run**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_aidescoptimizationrunid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_bestroundjson"></a> msdyn_bestroundjson

|Property|Value|
|---|---|
|Description|**JSON \{ aidescriptionrunid, simulationrunid, simulationscore \}. Updated continuously after each round, not just at end.**|
|DisplayName|**Best Round Json**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bestroundjson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_bestroundnumber"></a> msdyn_bestroundnumber

|Property|Value|
|---|---|
|Description|**Mirror of best round number in bestroundjson, for grid views.**|
|DisplayName|**Best Round Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bestroundnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|10|
|MinValue|0|

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

### <a name="BKMK_msdyn_correlationid"></a> msdyn_correlationid

|Property|Value|
|---|---|
|Description|**End-to-end correlation ID.**|
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

### <a name="BKMK_msdyn_currentiteration"></a> msdyn_currentiteration

|Property|Value|
|---|---|
|Description|**Updated by the orchestrator as the loop progresses (0..maxrounds).**|
|DisplayName|**Current Iteration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_currentiteration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|10|
|MinValue|0|

### <a name="BKMK_msdyn_entitylogicalname"></a> msdyn_entitylogicalname

|Property|Value|
|---|---|
|Description|**Logical name of the parent entity (e.g. incident).**|
|DisplayName|**Entity Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entitylogicalname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_errordetails"></a> msdyn_errordetails

|Property|Value|
|---|---|
|Description|**Terminal error (if status=Failed).**|
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

### <a name="BKMK_msdyn_fieldlogicalname"></a> msdyn_fieldlogicalname

|Property|Value|
|---|---|
|Description|**Logical name of the target field being optimized.**|
|DisplayName|**Field Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fieldlogicalname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_initialsimulationrunid"></a> msdyn_initialsimulationrunid

|Property|Value|
|---|---|
|Description|**GUID of the simulation run the admin started from, stored as a string to avoid cross-solution dependency.**|
|DisplayName|**Initial Simulation Run Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_initialsimulationrunid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_iterateonbest"></a> msdyn_iterateonbest

|Property|Value|
|---|---|
|Description|**When true, each round uses the current best run as previousaidescriptionrun instead of the immediately-previous round. Default false.**|
|DisplayName|**Iterate On Best**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iterateonbest`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_aidescoptimizationrun_msdyn_iterateonbest`|
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
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10|

### <a name="BKMK_msdyn_maxrounds"></a> msdyn_maxrounds

|Property|Value|
|---|---|
|Description|**Maximum number of optimization rounds. Default 5, capped at 10.**|
|DisplayName|**Max Rounds**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_maxrounds`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|10|
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

### <a name="BKMK_msdyn_processstatusmsg"></a> msdyn_processstatusmsg

|Property|Value|
|---|---|
|Description|**Current status message, overwritten at each major orchestrator step. For at-a-glance UX display (companion to append-only progresslog).**|
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

### <a name="BKMK_msdyn_progresslog"></a> msdyn_progresslog

|Property|Value|
|---|---|
|Description|**Append-only timestamped log lines (full history).**|
|DisplayName|**Progress Log**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_progresslog`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50000|

### <a name="BKMK_msdyn_roundresultsjson"></a> msdyn_roundresultsjson

|Property|Value|
|---|---|
|Description|**JSON array of per-round results.**|
|DisplayName|**Round Results Json**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_roundresultsjson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50000|

### <a name="BKMK_msdyn_startedon"></a> msdyn_startedon

|Property|Value|
|---|---|
|Description|**Stamped when the optimization run begins.**|
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
|Description|**Lifecycle status of the optimization run.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_status`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|700610000|
|GlobalChoiceName|`msdyn_aidescoptimizationrun_msdyn_status`|

#### msdyn_status Choices/Options

|Value|Label|
|---|---|
|700610000|**New**|
|700610001|**InProgress**|
|700610002|**Completed**|
|700610003|**Failed**|
|700610004|**Cancelling**|
|700610005|**Cancelled**|

### <a name="BKMK_msdyn_targetaccuracy"></a> msdyn_targetaccuracy

|Property|Value|
|---|---|
|Description|**Optional early-exit threshold (0-100). If a round's score reaches this, the loop finalizes early.**|
|DisplayName|**Target Accuracy**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_targetaccuracy`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100|
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
|GlobalChoiceName|`msdyn_aidescoptimizationrun_statecode`|

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
|GlobalChoiceName|`msdyn_aidescoptimizationrun_statuscode`|

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

- [business_unit_msdyn_aidescoptimizationrun](#BKMK_business_unit_msdyn_aidescoptimizationrun)
- [lk_msdyn_aidescoptimizationrun_createdby](#BKMK_lk_msdyn_aidescoptimizationrun_createdby)
- [lk_msdyn_aidescoptimizationrun_createdonbehalfby](#BKMK_lk_msdyn_aidescoptimizationrun_createdonbehalfby)
- [lk_msdyn_aidescoptimizationrun_modifiedby](#BKMK_lk_msdyn_aidescoptimizationrun_modifiedby)
- [lk_msdyn_aidescoptimizationrun_modifiedonbehalfby](#BKMK_lk_msdyn_aidescoptimizationrun_modifiedonbehalfby)
- [owner_msdyn_aidescoptimizationrun](#BKMK_owner_msdyn_aidescoptimizationrun)
- [team_msdyn_aidescoptimizationrun](#BKMK_team_msdyn_aidescoptimizationrun)
- [user_msdyn_aidescoptimizationrun](#BKMK_user_msdyn_aidescoptimizationrun)

### <a name="BKMK_business_unit_msdyn_aidescoptimizationrun"></a> business_unit_msdyn_aidescoptimizationrun

One-To-Many Relationship: [businessunit business_unit_msdyn_aidescoptimizationrun](businessunit.md#BKMK_business_unit_msdyn_aidescoptimizationrun)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aidescoptimizationrun_createdby"></a> lk_msdyn_aidescoptimizationrun_createdby

One-To-Many Relationship: [systemuser lk_msdyn_aidescoptimizationrun_createdby](systemuser.md#BKMK_lk_msdyn_aidescoptimizationrun_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aidescoptimizationrun_createdonbehalfby"></a> lk_msdyn_aidescoptimizationrun_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_aidescoptimizationrun_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_aidescoptimizationrun_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aidescoptimizationrun_modifiedby"></a> lk_msdyn_aidescoptimizationrun_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_aidescoptimizationrun_modifiedby](systemuser.md#BKMK_lk_msdyn_aidescoptimizationrun_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aidescoptimizationrun_modifiedonbehalfby"></a> lk_msdyn_aidescoptimizationrun_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_aidescoptimizationrun_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_aidescoptimizationrun_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_aidescoptimizationrun"></a> owner_msdyn_aidescoptimizationrun

One-To-Many Relationship: [owner owner_msdyn_aidescoptimizationrun](owner.md#BKMK_owner_msdyn_aidescoptimizationrun)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_aidescoptimizationrun"></a> team_msdyn_aidescoptimizationrun

One-To-Many Relationship: [team team_msdyn_aidescoptimizationrun](team.md#BKMK_team_msdyn_aidescoptimizationrun)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_aidescoptimizationrun"></a> user_msdyn_aidescoptimizationrun

One-To-Many Relationship: [systemuser user_msdyn_aidescoptimizationrun](systemuser.md#BKMK_user_msdyn_aidescoptimizationrun)

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

- [msdyn_aidescoptimizationrun_AsyncOperations](#BKMK_msdyn_aidescoptimizationrun_AsyncOperations)
- [msdyn_aidescoptimizationrun_BulkDeleteFailures](#BKMK_msdyn_aidescoptimizationrun_BulkDeleteFailures)
- [msdyn_aidescoptimizationrun_MailboxTrackingFolders](#BKMK_msdyn_aidescoptimizationrun_MailboxTrackingFolders)
- [msdyn_aidescoptimizationrun_PrincipalObjectAttributeAccesses](#BKMK_msdyn_aidescoptimizationrun_PrincipalObjectAttributeAccesses)
- [msdyn_aidescoptimizationrun_ProcessSession](#BKMK_msdyn_aidescoptimizationrun_ProcessSession)
- [msdyn_aidescoptimizationrun_SyncErrors](#BKMK_msdyn_aidescoptimizationrun_SyncErrors)
- [msdyn_aidescriptionrun_msdyn_aidescoptimizationrunid_msdyn_aidescoptimizationrun](#BKMK_msdyn_aidescriptionrun_msdyn_aidescoptimizationrunid_msdyn_aidescoptimizationrun)

### <a name="BKMK_msdyn_aidescoptimizationrun_AsyncOperations"></a> msdyn_aidescoptimizationrun_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_aidescoptimizationrun_AsyncOperations](asyncoperation.md#BKMK_msdyn_aidescoptimizationrun_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescoptimizationrun_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescoptimizationrun_BulkDeleteFailures"></a> msdyn_aidescoptimizationrun_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_aidescoptimizationrun_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_aidescoptimizationrun_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescoptimizationrun_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescoptimizationrun_MailboxTrackingFolders"></a> msdyn_aidescoptimizationrun_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_aidescoptimizationrun_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_aidescoptimizationrun_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescoptimizationrun_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescoptimizationrun_PrincipalObjectAttributeAccesses"></a> msdyn_aidescoptimizationrun_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_aidescoptimizationrun_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_aidescoptimizationrun_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescoptimizationrun_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescoptimizationrun_ProcessSession"></a> msdyn_aidescoptimizationrun_ProcessSession

Many-To-One Relationship: [processsession msdyn_aidescoptimizationrun_ProcessSession](processsession.md#BKMK_msdyn_aidescoptimizationrun_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescoptimizationrun_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescoptimizationrun_SyncErrors"></a> msdyn_aidescoptimizationrun_SyncErrors

Many-To-One Relationship: [syncerror msdyn_aidescoptimizationrun_SyncErrors](syncerror.md#BKMK_msdyn_aidescoptimizationrun_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescoptimizationrun_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescriptionrun_msdyn_aidescoptimizationrunid_msdyn_aidescoptimizationrun"></a> msdyn_aidescriptionrun_msdyn_aidescoptimizationrunid_msdyn_aidescoptimizationrun

Many-To-One Relationship: [msdyn_aidescriptionrun msdyn_aidescriptionrun_msdyn_aidescoptimizationrunid_msdyn_aidescoptimizationrun](msdyn_aidescriptionrun.md#BKMK_msdyn_aidescriptionrun_msdyn_aidescoptimizationrunid_msdyn_aidescoptimizationrun)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_aidescriptionrun`|
|ReferencingAttribute|`msdyn_aidescoptimizationrunid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescriptionrun_msdyn_aidescoptimizationrunid_msdyn_aidescoptimizationrun`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

