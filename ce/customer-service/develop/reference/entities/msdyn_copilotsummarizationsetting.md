---
title: Copilot Summarization Setting (msdyn_copilotsummarizationsetting) table
description: Includes schema information and supported messages for the Copilot Summarization Setting (msdyn_copilotsummarizationsetting) table/entity with Microsoft Dynamics 365.
ms.date: 01/21/2025
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Copilot Summarization Setting (msdyn_copilotsummarizationsetting) table



## Messages

The following table lists the messages for the Copilot Summarization Setting (msdyn_copilotsummarizationsetting) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyn_copilotsummarizationsettings<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_copilotsummarizationsettings(*msdyn_copilotsummarizationsettingid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_copilotsummarizationsettings(*msdyn_copilotsummarizationsettingid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_copilotsummarizationsettings<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msdyn_copilotsummarizationsettings(*msdyn_copilotsummarizationsettingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_copilotsummarizationsettings(*msdyn_copilotsummarizationsettingid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_copilotsummarizationsettings(*msdyn_copilotsummarizationsettingid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Copilot Summarization Setting (msdyn_copilotsummarizationsetting) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Copilot Summarization Setting (msdyn_copilotsummarizationsetting) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Copilot Summarization Setting** |
| **DisplayCollectionName** | **Copilot Summarization Settings** |
| **SchemaName** | `msdyn_copilotsummarizationsetting` |
| **CollectionSchemaName** | `msdyn_copilotsummarizationsettings` |
| **EntitySetName** | `msdyn_copilotsummarizationsettings`|
| **LogicalName** | `msdyn_copilotsummarizationsetting` |
| **LogicalCollectionName** | `msdyn_copilotsummarizationsettings` |
| **PrimaryIdAttribute** | `msdyn_copilotsummarizationsettingid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_allowcreatecase](#BKMK_msdyn_allowcreatecase)
- [msdyn_allowcrossgeo](#BKMK_msdyn_allowcrossgeo)
- [msdyn_allowtranslation](#BKMK_msdyn_allowtranslation)
- [msdyn_autoenabled](#BKMK_msdyn_autoenabled)
- [msdyn_autoenableddone](#BKMK_msdyn_autoenableddone)
- [msdyn_casesummaryconfiguration](#BKMK_msdyn_casesummaryconfiguration)
- [msdyn_casesummaryenabled](#BKMK_msdyn_casesummaryenabled)
- [msdyn_consentacceptedon](#BKMK_msdyn_consentacceptedon)
- [msdyn_conversationsummaryconfiguration](#BKMK_msdyn_conversationsummaryconfiguration)
- [msdyn_copilotsummarizationsettingId](#BKMK_msdyn_copilotsummarizationsettingId)
- [msdyn_enabled](#BKMK_msdyn_enabled)
- [msdyn_featureaccessrolelist](#BKMK_msdyn_featureaccessrolelist)
- [msdyn_interactionsenabled](#BKMK_msdyn_interactionsenabled)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ondemandenabled](#BKMK_msdyn_ondemandenabled)
- [msdyn_systemmetadata](#BKMK_msdyn_systemmetadata)
- [msdyn_useagentlanguage](#BKMK_msdyn_useagentlanguage)
- [msdyn_whenagentjoinsenabled](#BKMK_msdyn_whenagentjoinsenabled)
- [msdyn_whenconversationendsenabled](#BKMK_msdyn_whenconversationendsenabled)
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

### <a name="BKMK_msdyn_allowcreatecase"></a> msdyn_allowcreatecase

|Property|Value|
|---|---|
|Description||
|DisplayName|**Enable For Case Create**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_allowcreatecase`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_copilotsummarizationsetting_msdyn_allowcreatecase`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_allowcrossgeo"></a> msdyn_allowcrossgeo

|Property|Value|
|---|---|
|Description||
|DisplayName|**Enable For Cross Geo**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_allowcrossgeo`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_copilotsummarizationsetting_msdyn_allowcrossgeo`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_allowtranslation"></a> msdyn_allowtranslation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Allow agents to translate summaries**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_allowtranslation`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_copilotsummarizationsetting_msdyn_allowtranslation`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_autoenabled"></a> msdyn_autoenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**auto enabled for default on**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autoenabled`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_copilotsummarizationsetting_msdyn_autoenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_autoenableddone"></a> msdyn_autoenableddone

|Property|Value|
|---|---|
|Description||
|DisplayName|**auto enabled for default on**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autoenableddone`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_copilotsummarizationsetting_msdyn_autoenableddone`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_casesummaryconfiguration"></a> msdyn_casesummaryconfiguration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Case Summary Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_casesummaryconfiguration`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdyn_casesummaryenabled"></a> msdyn_casesummaryenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Case Summary Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_casesummaryenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_copilotsummarizationsetting_msdyn_casesummaryenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_consentacceptedon"></a> msdyn_consentacceptedon

|Property|Value|
|---|---|
|Description|**The date when the admin has most recently consented**|
|DisplayName|**Consent Accepted On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_consentacceptedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_conversationsummaryconfiguration"></a> msdyn_conversationsummaryconfiguration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Conversation Summary Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationsummaryconfiguration`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdyn_copilotsummarizationsettingId"></a> msdyn_copilotsummarizationsettingId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Copilot Summarization Setting**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_copilotsummarizationsettingid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_enabled"></a> msdyn_enabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enabled`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_copilotsummarizationsetting_msdyn_enabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_featureaccessrolelist"></a> msdyn_featureaccessrolelist

|Property|Value|
|---|---|
|Description||
|DisplayName|**Feature Access Role List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_featureaccessrolelist`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_interactionsenabled"></a> msdyn_interactionsenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Interactions Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_interactionsenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_copilotsummarizationsetting_msdyn_interactionsenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_name"></a> msdyn_name

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

### <a name="BKMK_msdyn_ondemandenabled"></a> msdyn_ondemandenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Enable For On Demand**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ondemandenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_copilotsummarizationsetting_msdyn_ondemandenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_systemmetadata"></a> msdyn_systemmetadata

|Property|Value|
|---|---|
|Description||
|DisplayName|**System Metadata**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_systemmetadata`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdyn_useagentlanguage"></a> msdyn_useagentlanguage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Use Agent Language Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_useagentlanguage`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_copilotsummarizationsetting_msdyn_useagentlanguage`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_whenagentjoinsenabled"></a> msdyn_whenagentjoinsenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Enable When Agent Joins**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_whenagentjoinsenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_copilotsummarizationsetting_msdyn_whenagentjoinsenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_whenconversationendsenabled"></a> msdyn_whenconversationendsenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Enable When Conversation Ends**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_whenconversationendsenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_copilotsummarizationsetting_msdyn_whenconversationendsenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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
|Description|**Status of the Copilot Summarization Setting**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_copilotsummarizationsetting_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Copilot Summarization Setting**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_copilotsummarizationsetting_statuscode`|

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
- [OrganizationId](#BKMK_OrganizationId)
- [OverwriteTime](#BKMK_OverwriteTime)
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

- [lk_msdyn_copilotsummarizationsetting_createdby](#BKMK_lk_msdyn_copilotsummarizationsetting_createdby)
- [lk_msdyn_copilotsummarizationsetting_createdonbehalfby](#BKMK_lk_msdyn_copilotsummarizationsetting_createdonbehalfby)
- [lk_msdyn_copilotsummarizationsetting_modifiedby](#BKMK_lk_msdyn_copilotsummarizationsetting_modifiedby)
- [lk_msdyn_copilotsummarizationsetting_modifiedonbehalfby](#BKMK_lk_msdyn_copilotsummarizationsetting_modifiedonbehalfby)
- [organization_msdyn_copilotsummarizationsetting](#BKMK_organization_msdyn_copilotsummarizationsetting)

### <a name="BKMK_lk_msdyn_copilotsummarizationsetting_createdby"></a> lk_msdyn_copilotsummarizationsetting_createdby

One-To-Many Relationship: [systemuser lk_msdyn_copilotsummarizationsetting_createdby](systemuser.md#BKMK_lk_msdyn_copilotsummarizationsetting_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_copilotsummarizationsetting_createdonbehalfby"></a> lk_msdyn_copilotsummarizationsetting_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_copilotsummarizationsetting_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_copilotsummarizationsetting_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_copilotsummarizationsetting_modifiedby"></a> lk_msdyn_copilotsummarizationsetting_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_copilotsummarizationsetting_modifiedby](systemuser.md#BKMK_lk_msdyn_copilotsummarizationsetting_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_copilotsummarizationsetting_modifiedonbehalfby"></a> lk_msdyn_copilotsummarizationsetting_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_copilotsummarizationsetting_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_copilotsummarizationsetting_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_copilotsummarizationsetting"></a> organization_msdyn_copilotsummarizationsetting

One-To-Many Relationship: [organization organization_msdyn_copilotsummarizationsetting](organization.md#BKMK_organization_msdyn_copilotsummarizationsetting)

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

- [msdyn_copilotsummarizationsetting_AsyncOperations](#BKMK_msdyn_copilotsummarizationsetting_AsyncOperations)
- [msdyn_copilotsummarizationsetting_BulkDeleteFailures](#BKMK_msdyn_copilotsummarizationsetting_BulkDeleteFailures)
- [msdyn_copilotsummarizationsetting_DuplicateBaseRecord](#BKMK_msdyn_copilotsummarizationsetting_DuplicateBaseRecord)
- [msdyn_copilotsummarizationsetting_DuplicateMatchingRecord](#BKMK_msdyn_copilotsummarizationsetting_DuplicateMatchingRecord)
- [msdyn_copilotsummarizationsetting_MailboxTrackingFolders](#BKMK_msdyn_copilotsummarizationsetting_MailboxTrackingFolders)
- [msdyn_copilotsummarizationsetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_copilotsummarizationsetting_PrincipalObjectAttributeAccesses)
- [msdyn_copilotsummarizationsetting_ProcessSession](#BKMK_msdyn_copilotsummarizationsetting_ProcessSession)
- [msdyn_copilotsummarizationsetting_SyncErrors](#BKMK_msdyn_copilotsummarizationsetting_SyncErrors)

### <a name="BKMK_msdyn_copilotsummarizationsetting_AsyncOperations"></a> msdyn_copilotsummarizationsetting_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_copilotsummarizationsetting_AsyncOperations](asyncoperation.md#BKMK_msdyn_copilotsummarizationsetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilotsummarizationsetting_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_copilotsummarizationsetting_BulkDeleteFailures"></a> msdyn_copilotsummarizationsetting_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_copilotsummarizationsetting_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_copilotsummarizationsetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilotsummarizationsetting_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_copilotsummarizationsetting_DuplicateBaseRecord"></a> msdyn_copilotsummarizationsetting_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_copilotsummarizationsetting_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_copilotsummarizationsetting_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilotsummarizationsetting_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_copilotsummarizationsetting_DuplicateMatchingRecord"></a> msdyn_copilotsummarizationsetting_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_copilotsummarizationsetting_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_copilotsummarizationsetting_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilotsummarizationsetting_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_copilotsummarizationsetting_MailboxTrackingFolders"></a> msdyn_copilotsummarizationsetting_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_copilotsummarizationsetting_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_copilotsummarizationsetting_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilotsummarizationsetting_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_copilotsummarizationsetting_PrincipalObjectAttributeAccesses"></a> msdyn_copilotsummarizationsetting_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_copilotsummarizationsetting_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_copilotsummarizationsetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilotsummarizationsetting_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_copilotsummarizationsetting_ProcessSession"></a> msdyn_copilotsummarizationsetting_ProcessSession

Many-To-One Relationship: [processsession msdyn_copilotsummarizationsetting_ProcessSession](processsession.md#BKMK_msdyn_copilotsummarizationsetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilotsummarizationsetting_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_copilotsummarizationsetting_SyncErrors"></a> msdyn_copilotsummarizationsetting_SyncErrors

Many-To-One Relationship: [syncerror msdyn_copilotsummarizationsetting_SyncErrors](syncerror.md#BKMK_msdyn_copilotsummarizationsetting_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilotsummarizationsetting_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

