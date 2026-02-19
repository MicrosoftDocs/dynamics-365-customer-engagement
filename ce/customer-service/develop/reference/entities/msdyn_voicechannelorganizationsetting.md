---
title: "Voice channel organization setting (msdyn_voicechannelorganizationsetting) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Voice channel organization setting (msdyn_voicechannelorganizationsetting) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Voice channel organization setting (msdyn_voicechannelorganizationsetting) table/entity reference (Microsoft Dynamics 365 Customer Service)

Entity for storing organization settings pertaining to voice channel

## Messages

The following table lists the messages for the Voice channel organization setting (msdyn_voicechannelorganizationsetting) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_voicechannelorganizationsettings(*msdyn_voicechannelorganizationsettingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_voicechannelorganizationsettings<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_voicechannelorganizationsettings(*msdyn_voicechannelorganizationsettingid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_voicechannelorganizationsettings(*msdyn_voicechannelorganizationsettingid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_voicechannelorganizationsettings<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_voicechannelorganizationsettings(*msdyn_voicechannelorganizationsettingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_voicechannelorganizationsettings(*msdyn_voicechannelorganizationsettingid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_voicechannelorganizationsettings(*msdyn_voicechannelorganizationsettingid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Voice channel organization setting (msdyn_voicechannelorganizationsetting) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Voice channel organization setting** |
| **DisplayCollectionName** | **Voice channel organization setting** |
| **SchemaName** | `msdyn_voicechannelorganizationsetting` |
| **CollectionSchemaName** | `msdyn_voicechannelorganizationsettings` |
| **EntitySetName** | `msdyn_voicechannelorganizationsettings`|
| **LogicalName** | `msdyn_voicechannelorganizationsetting` |
| **LogicalCollectionName** | `msdyn_voicechannelorganizationsettings` |
| **PrimaryIdAttribute** | `msdyn_voicechannelorganizationsettingid` |
| **PrimaryNameAttribute** |`msdyn_voicechannelorganizationsettingname` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_agentendofcallsurveyenddate](#BKMK_msdyn_agentendofcallsurveyenddate)
- [msdyn_agentendofcallsurveyfrequency](#BKMK_msdyn_agentendofcallsurveyfrequency)
- [msdyn_agentendofcallsurveystartdate](#BKMK_msdyn_agentendofcallsurveystartdate)
- [msdyn_enableagentendofcallsurvey](#BKMK_msdyn_enableagentendofcallsurvey)
- [msdyn_enableagentendofcallsurveyduration](#BKMK_msdyn_enableagentendofcallsurveyduration)
- [msdyn_enableautomaticremovalofonhold](#BKMK_msdyn_enableautomaticremovalofonhold)
- [msdyn_enablebroadcastdtmf](#BKMK_msdyn_enablebroadcastdtmf)
- [msdyn_enablecitrixintegration](#BKMK_msdyn_enablecitrixintegration)
- [msdyn_enabledevicepreheat](#BKMK_msdyn_enabledevicepreheat)
- [msdyn_enableshowpostcallsurveyresult](#BKMK_msdyn_enableshowpostcallsurveyresult)
- [msdyn_voicechannelorganizationsettingId](#BKMK_msdyn_voicechannelorganizationsettingId)
- [msdyn_voicechannelorganizationsettingname](#BKMK_msdyn_voicechannelorganizationsettingname)
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

### <a name="BKMK_msdyn_agentendofcallsurveyenddate"></a> msdyn_agentendofcallsurveyenddate

|Property|Value|
|---|---|
|Description|**End date till which the end of call survey is active**|
|DisplayName|**End of call survey end date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentendofcallsurveyenddate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_agentendofcallsurveyfrequency"></a> msdyn_agentendofcallsurveyfrequency

|Property|Value|
|---|---|
|Description|**The number of phone calls after which the survey should be shown to the agent.**|
|DisplayName|**End of call survey frequency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentendofcallsurveyfrequency`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|1|

### <a name="BKMK_msdyn_agentendofcallsurveystartdate"></a> msdyn_agentendofcallsurveystartdate

|Property|Value|
|---|---|
|Description|**Start date from which the end of call survey is active**|
|DisplayName|**End of call survey start date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentendofcallsurveystartdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_enableagentendofcallsurvey"></a> msdyn_enableagentendofcallsurvey

|Property|Value|
|---|---|
|Description|**Toggle to enable the end of call survey agent experience**|
|DisplayName|**Enable end of call survey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enableagentendofcallsurvey`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_voicechannelorganizationsetting_msdyn_enableagentendofcallsurvey`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enableagentendofcallsurveyduration"></a> msdyn_enableagentendofcallsurveyduration

|Property|Value|
|---|---|
|Description|**Toggle to enable a date range for which the call survey is active**|
|DisplayName|**Enable end of call survey duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enableagentendofcallsurveyduration`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_voicechannelorganizationsetting_msdyn_enableagentendofcallsurveyduration`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enableautomaticremovalofonhold"></a> msdyn_enableautomaticremovalofonhold

|Property|Value|
|---|---|
|Description|**Toggle to enable automatic removal of onhold**|
|DisplayName|**Enable automatic removal of onhold**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enableautomaticremovalofonhold`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_voicechannelorganizationsetting_msdyn_enableautomaticremovalofonhold`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enablebroadcastdtmf"></a> msdyn_enablebroadcastdtmf

|Property|Value|
|---|---|
|Description|**Toggle to enable broadcast DTMF**|
|DisplayName|**Enable broadcast DTMF**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablebroadcastdtmf`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_voicechannelorganizationsetting_msdyn_enablebroadcastdtmf`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enablecitrixintegration"></a> msdyn_enablecitrixintegration

|Property|Value|
|---|---|
|Description|**Toggle to enable Citrix integration**|
|DisplayName|**Enable Citrix integration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablecitrixintegration`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_voicechannelorganizationsetting_msdyn_enablecitrixintegration`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enabledevicepreheat"></a> msdyn_enabledevicepreheat

|Property|Value|
|---|---|
|Description|**Toggle to enable device preheat**|
|DisplayName|**Enable device preheat**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enabledevicepreheat`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_voicechannelorganizationsetting_msdyn_enabledevicepreheat`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enableshowpostcallsurveyresult"></a> msdyn_enableshowpostcallsurveyresult

|Property|Value|
|---|---|
|Description|**Toggle to enable post call survey result**|
|DisplayName|**Enable post call survey result**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enableshowpostcallsurveyresult`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_voicechannelorganizationsetting_msdyn_enableshowpostcallsurveyresult`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_voicechannelorganizationsettingId"></a> msdyn_voicechannelorganizationsettingId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Voice channel organization setting**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_voicechannelorganizationsettingid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_voicechannelorganizationsettingname"></a> msdyn_voicechannelorganizationsettingname

|Property|Value|
|---|---|
|Description|**Name for the organization setting**|
|DisplayName|**Voice channel organization setting name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_voicechannelorganizationsettingname`|
|RequiredLevel|SystemRequired|
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
|Description|**Status of the Voice channel organization setting**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_voicechannelorganizationsetting_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Voice channel organization setting**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_voicechannelorganizationsetting_statuscode`|

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

- [business_unit_msdyn_voicechannelorganizationsetting](#BKMK_business_unit_msdyn_voicechannelorganizationsetting)
- [lk_msdyn_voicechannelorganizationsetting_createdby](#BKMK_lk_msdyn_voicechannelorganizationsetting_createdby)
- [lk_msdyn_voicechannelorganizationsetting_createdonbehalfby](#BKMK_lk_msdyn_voicechannelorganizationsetting_createdonbehalfby)
- [lk_msdyn_voicechannelorganizationsetting_modifiedby](#BKMK_lk_msdyn_voicechannelorganizationsetting_modifiedby)
- [lk_msdyn_voicechannelorganizationsetting_modifiedonbehalfby](#BKMK_lk_msdyn_voicechannelorganizationsetting_modifiedonbehalfby)
- [owner_msdyn_voicechannelorganizationsetting](#BKMK_owner_msdyn_voicechannelorganizationsetting)
- [team_msdyn_voicechannelorganizationsetting](#BKMK_team_msdyn_voicechannelorganizationsetting)
- [user_msdyn_voicechannelorganizationsetting](#BKMK_user_msdyn_voicechannelorganizationsetting)

### <a name="BKMK_business_unit_msdyn_voicechannelorganizationsetting"></a> business_unit_msdyn_voicechannelorganizationsetting

One-To-Many Relationship: [businessunit business_unit_msdyn_voicechannelorganizationsetting](businessunit.md#BKMK_business_unit_msdyn_voicechannelorganizationsetting)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_voicechannelorganizationsetting_createdby"></a> lk_msdyn_voicechannelorganizationsetting_createdby

One-To-Many Relationship: [systemuser lk_msdyn_voicechannelorganizationsetting_createdby](systemuser.md#BKMK_lk_msdyn_voicechannelorganizationsetting_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_voicechannelorganizationsetting_createdonbehalfby"></a> lk_msdyn_voicechannelorganizationsetting_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_voicechannelorganizationsetting_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_voicechannelorganizationsetting_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_voicechannelorganizationsetting_modifiedby"></a> lk_msdyn_voicechannelorganizationsetting_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_voicechannelorganizationsetting_modifiedby](systemuser.md#BKMK_lk_msdyn_voicechannelorganizationsetting_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_voicechannelorganizationsetting_modifiedonbehalfby"></a> lk_msdyn_voicechannelorganizationsetting_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_voicechannelorganizationsetting_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_voicechannelorganizationsetting_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_voicechannelorganizationsetting"></a> owner_msdyn_voicechannelorganizationsetting

One-To-Many Relationship: [owner owner_msdyn_voicechannelorganizationsetting](owner.md#BKMK_owner_msdyn_voicechannelorganizationsetting)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_voicechannelorganizationsetting"></a> team_msdyn_voicechannelorganizationsetting

One-To-Many Relationship: [team team_msdyn_voicechannelorganizationsetting](team.md#BKMK_team_msdyn_voicechannelorganizationsetting)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_voicechannelorganizationsetting"></a> user_msdyn_voicechannelorganizationsetting

One-To-Many Relationship: [systemuser user_msdyn_voicechannelorganizationsetting](systemuser.md#BKMK_user_msdyn_voicechannelorganizationsetting)

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

- [msdyn_voicechannelorganizationsetting_AsyncOperations](#BKMK_msdyn_voicechannelorganizationsetting_AsyncOperations)
- [msdyn_voicechannelorganizationsetting_BulkDeleteFailures](#BKMK_msdyn_voicechannelorganizationsetting_BulkDeleteFailures)
- [msdyn_voicechannelorganizationsetting_DuplicateBaseRecord](#BKMK_msdyn_voicechannelorganizationsetting_DuplicateBaseRecord)
- [msdyn_voicechannelorganizationsetting_DuplicateMatchingRecord](#BKMK_msdyn_voicechannelorganizationsetting_DuplicateMatchingRecord)
- [msdyn_voicechannelorganizationsetting_MailboxTrackingFolders](#BKMK_msdyn_voicechannelorganizationsetting_MailboxTrackingFolders)
- [msdyn_voicechannelorganizationsetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_voicechannelorganizationsetting_PrincipalObjectAttributeAccesses)
- [msdyn_voicechannelorganizationsetting_ProcessSession](#BKMK_msdyn_voicechannelorganizationsetting_ProcessSession)
- [msdyn_voicechannelorganizationsetting_SyncErrors](#BKMK_msdyn_voicechannelorganizationsetting_SyncErrors)

### <a name="BKMK_msdyn_voicechannelorganizationsetting_AsyncOperations"></a> msdyn_voicechannelorganizationsetting_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_voicechannelorganizationsetting_AsyncOperations](asyncoperation.md#BKMK_msdyn_voicechannelorganizationsetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_voicechannelorganizationsetting_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_voicechannelorganizationsetting_BulkDeleteFailures"></a> msdyn_voicechannelorganizationsetting_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_voicechannelorganizationsetting_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_voicechannelorganizationsetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_voicechannelorganizationsetting_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_voicechannelorganizationsetting_DuplicateBaseRecord"></a> msdyn_voicechannelorganizationsetting_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_voicechannelorganizationsetting_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_voicechannelorganizationsetting_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_voicechannelorganizationsetting_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_voicechannelorganizationsetting_DuplicateMatchingRecord"></a> msdyn_voicechannelorganizationsetting_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_voicechannelorganizationsetting_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_voicechannelorganizationsetting_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_voicechannelorganizationsetting_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_voicechannelorganizationsetting_MailboxTrackingFolders"></a> msdyn_voicechannelorganizationsetting_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_voicechannelorganizationsetting_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_voicechannelorganizationsetting_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_voicechannelorganizationsetting_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_voicechannelorganizationsetting_PrincipalObjectAttributeAccesses"></a> msdyn_voicechannelorganizationsetting_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_voicechannelorganizationsetting_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_voicechannelorganizationsetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_voicechannelorganizationsetting_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_voicechannelorganizationsetting_ProcessSession"></a> msdyn_voicechannelorganizationsetting_ProcessSession

Many-To-One Relationship: [processsession msdyn_voicechannelorganizationsetting_ProcessSession](processsession.md#BKMK_msdyn_voicechannelorganizationsetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_voicechannelorganizationsetting_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_voicechannelorganizationsetting_SyncErrors"></a> msdyn_voicechannelorganizationsetting_SyncErrors

Many-To-One Relationship: [syncerror msdyn_voicechannelorganizationsetting_SyncErrors](syncerror.md#BKMK_msdyn_voicechannelorganizationsetting_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_voicechannelorganizationsetting_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

