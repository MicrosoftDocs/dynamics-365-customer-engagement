---
title: "Suggestions Setting (msdyn_suggestionssetting) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Suggestions Setting (msdyn_suggestionssetting) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Suggestions Setting (msdyn_suggestionssetting) table/entity reference (Microsoft Dynamics 365)

Suggestions settings entity

## Messages

The following table lists the messages for the Suggestions Setting (msdyn_suggestionssetting) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_suggestionssettings<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_suggestionssettings(*msdyn_suggestionssettingid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_suggestionssettings(*msdyn_suggestionssettingid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_suggestionssettings<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_suggestionssettings(*msdyn_suggestionssettingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_suggestionssettings(*msdyn_suggestionssettingid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_suggestionssettings(*msdyn_suggestionssettingid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Suggestions Setting (msdyn_suggestionssetting) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Suggestions Setting** |
| **DisplayCollectionName** | **Suggestions Settings** |
| **SchemaName** | `msdyn_suggestionssetting` |
| **CollectionSchemaName** | `msdyn_suggestionssettings` |
| **EntitySetName** | `msdyn_suggestionssettings`|
| **LogicalName** | `msdyn_suggestionssetting` |
| **LogicalCollectionName** | `msdyn_suggestionssettings` |
| **PrimaryIdAttribute** | `msdyn_suggestionssettingid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_casecustommapping](#BKMK_msdyn_casecustommapping)
- [msdyn_casecustommodelmapping](#BKMK_msdyn_casecustommodelmapping)
- [msdyn_CaseDetailMapping](#BKMK_msdyn_CaseDetailMapping)
- [msdyn_CaseDetailModelMapping](#BKMK_msdyn_CaseDetailModelMapping)
- [msdyn_CaseIsEnabled](#BKMK_msdyn_CaseIsEnabled)
- [msdyn_casepreprocessingrule](#BKMK_msdyn_casepreprocessingrule)
- [msdyn_casepreprocessingruleenabled](#BKMK_msdyn_casepreprocessingruleenabled)
- [msdyn_CaseTitleMapping](#BKMK_msdyn_CaseTitleMapping)
- [msdyn_CaseTitleModelMapping](#BKMK_msdyn_CaseTitleModelMapping)
- [msdyn_KBContentMapping](#BKMK_msdyn_KBContentMapping)
- [msdyn_KBContentModelMapping](#BKMK_msdyn_KBContentModelMapping)
- [msdyn_kbcustommapping](#BKMK_msdyn_kbcustommapping)
- [msdyn_kbcustommodelmapping](#BKMK_msdyn_kbcustommodelmapping)
- [msdyn_KBIsEnabled](#BKMK_msdyn_KBIsEnabled)
- [msdyn_kbpreprocessingrule](#BKMK_msdyn_kbpreprocessingrule)
- [msdyn_kbpreprocessingruleenabled](#BKMK_msdyn_kbpreprocessingruleenabled)
- [msdyn_KBTitleMapping](#BKMK_msdyn_KBTitleMapping)
- [msdyn_KBTitleModelMapping](#BKMK_msdyn_KBTitleModelMapping)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_refreshonsaveevent](#BKMK_msdyn_refreshonsaveevent)
- [msdyn_suggestionssettingId](#BKMK_msdyn_suggestionssettingId)
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

### <a name="BKMK_msdyn_casecustommapping"></a> msdyn_casecustommapping

|Property|Value|
|---|---|
|Description|**Additional custom field mappings for case entity**|
|DisplayName|**Case Custom Fields Mapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_casecustommapping`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdyn_casecustommodelmapping"></a> msdyn_casecustommodelmapping

|Property|Value|
|---|---|
|Description|**Additional custom field model mappings for case entity**|
|DisplayName|**Case Custom Fields Model Mapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_casecustommodelmapping`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdyn_CaseDetailMapping"></a> msdyn_CaseDetailMapping

|Property|Value|
|---|---|
|Description|**Case attribute which describes Issue Detail**|
|DisplayName|**Case Detail Mapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_casedetailmapping`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_CaseDetailModelMapping"></a> msdyn_CaseDetailModelMapping

|Property|Value|
|---|---|
|Description|**Case attribute which describes Issue Detail**|
|DisplayName|**Case Detail Model Mapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_casedetailmodelmapping`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_CaseIsEnabled"></a> msdyn_CaseIsEnabled

|Property|Value|
|---|---|
|Description|**Is Similar Case Suggestion Enabled for Case Entity. Default set is No.**|
|DisplayName|**Case Is Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_caseisenabled`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_suggestionssetting_msdyn_caseisenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_casepreprocessingrule"></a> msdyn_casepreprocessingrule

|Property|Value|
|---|---|
|Description|**Defines the model pre-processing rule for case suggestions**|
|DisplayName|**Case Preprocessing Rule**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_casepreprocessingrule`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdyn_casepreprocessingruleenabled"></a> msdyn_casepreprocessingruleenabled

|Property|Value|
|---|---|
|Description|**Enables the model pre-processing rule for case suggestions**|
|DisplayName|**Case Preprocessing Rule Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_casepreprocessingruleenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_suggestionssetting_msdyn_casepreprocessingruleenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_CaseTitleMapping"></a> msdyn_CaseTitleMapping

|Property|Value|
|---|---|
|Description|**Case attribute which describes Issue Summary**|
|DisplayName|**Case Title Mapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_casetitlemapping`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_CaseTitleModelMapping"></a> msdyn_CaseTitleModelMapping

|Property|Value|
|---|---|
|Description|**Case attribute which describes Issue Summary**|
|DisplayName|**Case Title Model Mapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_casetitlemodelmapping`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_KBContentMapping"></a> msdyn_KBContentMapping

|Property|Value|
|---|---|
|Description|**Knowledge attribute which describes Issue Detail**|
|DisplayName|**KB Content Mapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_kbcontentmapping`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_KBContentModelMapping"></a> msdyn_KBContentModelMapping

|Property|Value|
|---|---|
|Description|**Knowledge Content attribute mapping which describes Issue Detail and Training pipeline has used to generate model data.**|
|DisplayName|**KB Content Model Mapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_kbcontentmodelmapping`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_kbcustommapping"></a> msdyn_kbcustommapping

|Property|Value|
|---|---|
|Description|**Additional custom field mappings for KB entity**|
|DisplayName|**KB Custom Fields Mapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_kbcustommapping`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdyn_kbcustommodelmapping"></a> msdyn_kbcustommodelmapping

|Property|Value|
|---|---|
|Description|**Additional custom field model mappings for KB entity**|
|DisplayName|**KB Custom Fields Model Mapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_kbcustommodelmapping`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdyn_KBIsEnabled"></a> msdyn_KBIsEnabled

|Property|Value|
|---|---|
|Description|**Is Similar KB Suggestions is enabled. Default is No**|
|DisplayName|**KB Is Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_kbisenabled`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_suggestionssetting_msdyn_kbisenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_kbpreprocessingrule"></a> msdyn_kbpreprocessingrule

|Property|Value|
|---|---|
|Description|**Defines the model pre-processing rule for KB suggestions**|
|DisplayName|**KB Preprocessing Rule**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_kbpreprocessingrule`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdyn_kbpreprocessingruleenabled"></a> msdyn_kbpreprocessingruleenabled

|Property|Value|
|---|---|
|Description|**Enables the model pre-processing rule for KB suggestions**|
|DisplayName|**KB Preprocessing Rule Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_kbpreprocessingruleenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_suggestionssetting_msdyn_kbpreprocessingruleenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_KBTitleMapping"></a> msdyn_KBTitleMapping

|Property|Value|
|---|---|
|Description|**Knowledge attribute which describes Issue Summary**|
|DisplayName|**KB Title Mapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_kbtitlemapping`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_KBTitleModelMapping"></a> msdyn_KBTitleModelMapping

|Property|Value|
|---|---|
|Description|**Knowledge Title mapping attribute which used by training pipeline to generate model data.**|
|DisplayName|**KB Title Model Mapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_kbtitlemodelmapping`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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

### <a name="BKMK_msdyn_refreshonsaveevent"></a> msdyn_refreshonsaveevent

|Property|Value|
|---|---|
|Description|**Whether or not the suggestions should refresh when their corresponding entity record has been saved**|
|DisplayName|**Refresh on Save event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_refreshonsaveevent`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_suggestionssetting_msdyn_refreshonsaveevent`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_suggestionssettingId"></a> msdyn_suggestionssettingId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Suggestions Setting Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestionssettingid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|Description|**Status of the suggestionssetting**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_suggestionssetting_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the suggestionssetting**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_suggestionssetting_statuscode`|

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

- [lk_msdyn_suggestionssetting_createdby](#BKMK_lk_msdyn_suggestionssetting_createdby)
- [lk_msdyn_suggestionssetting_createdonbehalfby](#BKMK_lk_msdyn_suggestionssetting_createdonbehalfby)
- [lk_msdyn_suggestionssetting_modifiedby](#BKMK_lk_msdyn_suggestionssetting_modifiedby)
- [lk_msdyn_suggestionssetting_modifiedonbehalfby](#BKMK_lk_msdyn_suggestionssetting_modifiedonbehalfby)
- [organization_msdyn_suggestionssetting](#BKMK_organization_msdyn_suggestionssetting)

### <a name="BKMK_lk_msdyn_suggestionssetting_createdby"></a> lk_msdyn_suggestionssetting_createdby

One-To-Many Relationship: [systemuser lk_msdyn_suggestionssetting_createdby](systemuser.md#BKMK_lk_msdyn_suggestionssetting_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_suggestionssetting_createdonbehalfby"></a> lk_msdyn_suggestionssetting_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_suggestionssetting_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_suggestionssetting_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_suggestionssetting_modifiedby"></a> lk_msdyn_suggestionssetting_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_suggestionssetting_modifiedby](systemuser.md#BKMK_lk_msdyn_suggestionssetting_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_suggestionssetting_modifiedonbehalfby"></a> lk_msdyn_suggestionssetting_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_suggestionssetting_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_suggestionssetting_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_suggestionssetting"></a> organization_msdyn_suggestionssetting

One-To-Many Relationship: [organization organization_msdyn_suggestionssetting](organization.md#BKMK_organization_msdyn_suggestionssetting)

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

- [msdyn_suggestionssetting_AsyncOperations](#BKMK_msdyn_suggestionssetting_AsyncOperations)
- [msdyn_suggestionssetting_BulkDeleteFailures](#BKMK_msdyn_suggestionssetting_BulkDeleteFailures)
- [msdyn_suggestionssetting_MailboxTrackingFolders](#BKMK_msdyn_suggestionssetting_MailboxTrackingFolders)
- [msdyn_suggestionssetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_suggestionssetting_PrincipalObjectAttributeAccesses)
- [msdyn_suggestionssetting_ProcessSession](#BKMK_msdyn_suggestionssetting_ProcessSession)
- [msdyn_suggestionssetting_SyncErrors](#BKMK_msdyn_suggestionssetting_SyncErrors)

### <a name="BKMK_msdyn_suggestionssetting_AsyncOperations"></a> msdyn_suggestionssetting_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_suggestionssetting_AsyncOperations](asyncoperation.md#BKMK_msdyn_suggestionssetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_suggestionssetting_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_suggestionssetting_BulkDeleteFailures"></a> msdyn_suggestionssetting_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_suggestionssetting_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_suggestionssetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_suggestionssetting_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_suggestionssetting_MailboxTrackingFolders"></a> msdyn_suggestionssetting_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_suggestionssetting_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_suggestionssetting_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_suggestionssetting_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_suggestionssetting_PrincipalObjectAttributeAccesses"></a> msdyn_suggestionssetting_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_suggestionssetting_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_suggestionssetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_suggestionssetting_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_suggestionssetting_ProcessSession"></a> msdyn_suggestionssetting_ProcessSession

Many-To-One Relationship: [processsession msdyn_suggestionssetting_ProcessSession](processsession.md#BKMK_msdyn_suggestionssetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_suggestionssetting_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_suggestionssetting_SyncErrors"></a> msdyn_suggestionssetting_SyncErrors

Many-To-One Relationship: [syncerror msdyn_suggestionssetting_SyncErrors](syncerror.md#BKMK_msdyn_suggestionssetting_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_suggestionssetting_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

