---
title: "Conversation Summary Interaction (msdyn_conversationsummaryinteraction) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Conversation Summary Interaction (msdyn_conversationsummaryinteraction) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Conversation Summary Interaction (msdyn_conversationsummaryinteraction) table/entity reference (Microsoft Dynamics 365)

Conversation Summary Interaction Entity

## Messages

The following table lists the messages for the Conversation Summary Interaction (msdyn_conversationsummaryinteraction) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_conversationsummaryinteractions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_conversationsummaryinteractions(*msdyn_conversationsummaryinteractionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_conversationsummaryinteractions(*msdyn_conversationsummaryinteractionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_conversationsummaryinteractions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_conversationsummaryinteractions(*msdyn_conversationsummaryinteractionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_conversationsummaryinteractions(*msdyn_conversationsummaryinteractionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_conversationsummaryinteractions(*msdyn_conversationsummaryinteractionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Conversation Summary Interaction (msdyn_conversationsummaryinteraction) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Conversation Summary Interaction** |
| **DisplayCollectionName** | **Conversation Summary Interactions** |
| **SchemaName** | `msdyn_conversationsummaryinteraction` |
| **CollectionSchemaName** | `msdyn_conversationsummaryinteractions` |
| **EntitySetName** | `msdyn_conversationsummaryinteractions`|
| **LogicalName** | `msdyn_conversationsummaryinteraction` |
| **LogicalCollectionName** | `msdyn_conversationsummaryinteractions` |
| **PrimaryIdAttribute** | `msdyn_conversationsummaryinteractionid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_conversationid](#BKMK_msdyn_conversationid)
- [msdyn_conversationsummaryinteractionId](#BKMK_msdyn_conversationsummaryinteractionId)
- [msdyn_feedbackverbatim](#BKMK_msdyn_feedbackverbatim)
- [msdyn_helpful](#BKMK_msdyn_helpful)
- [msdyn_interactioncontext](#BKMK_msdyn_interactioncontext)
- [msdyn_issuefeedbackverbatim](#BKMK_msdyn_issuefeedbackverbatim)
- [msdyn_issueinaccurate](#BKMK_msdyn_issueinaccurate)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_resolutionfeedbackverbatim](#BKMK_msdyn_resolutionfeedbackverbatim)
- [msdyn_resolutioninaccurate](#BKMK_msdyn_resolutioninaccurate)
- [msdyn_summary](#BKMK_msdyn_summary)
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

### <a name="BKMK_msdyn_conversationid"></a> msdyn_conversationid

|Property|Value|
|---|---|
|Description|**Defines the conversation that the interaction occurred on**|
|DisplayName|**Conversation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_ocliveworkitem|

### <a name="BKMK_msdyn_conversationsummaryinteractionId"></a> msdyn_conversationsummaryinteractionId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Conversation Summary Interaction**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationsummaryinteractionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_feedbackverbatim"></a> msdyn_feedbackverbatim

|Property|Value|
|---|---|
|Description|**Provides the feedback verbatim provided by agent, when they identified the summary as unhelpful**|
|DisplayName|**Feedback Verbatim**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_feedbackverbatim`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_helpful"></a> msdyn_helpful

|Property|Value|
|---|---|
|Description|**Indicates the helpful signal provided by agent**|
|DisplayName|**Helpful**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_helpful`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_conversationsummaryinteraction_msdyn_helpful`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_interactioncontext"></a> msdyn_interactioncontext

|Property|Value|
|---|---|
|Description|**Provides additional interaction context**|
|DisplayName|**Interaction Context**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_interactioncontext`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_issuefeedbackverbatim"></a> msdyn_issuefeedbackverbatim

|Property|Value|
|---|---|
|Description|**Provides the issue feedback verbatim provided by agent, when they identified the summary as unhelpful**|
|DisplayName|**Issue Feedback Verbatim**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_issuefeedbackverbatim`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_issueinaccurate"></a> msdyn_issueinaccurate

|Property|Value|
|---|---|
|Description|**Indicates the issue summary being inaccurate signal provided by agent, when they identified the summary as unhelpful**|
|DisplayName|**Issue Inaccurate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_issueinaccurate`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_conversationsummaryinteraction_msdyn_issueinaccurate`|
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
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_resolutionfeedbackverbatim"></a> msdyn_resolutionfeedbackverbatim

|Property|Value|
|---|---|
|Description|**Provides the resolution feedback verbatim provided by agent, when they identified the summary as unhelpful**|
|DisplayName|**Resolution Feedback Verbatim**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_resolutionfeedbackverbatim`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_resolutioninaccurate"></a> msdyn_resolutioninaccurate

|Property|Value|
|---|---|
|Description|**Indicates the resolution summary being inaccurate signal provided by agent, when they identified the summary as unhelpful**|
|DisplayName|**Resolution Inaccurate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_resolutioninaccurate`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_conversationsummaryinteraction_msdyn_resolutioninaccurate`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_summary"></a> msdyn_summary

|Property|Value|
|---|---|
|Description|**Provides the summary that the agent interacted on**|
|DisplayName|**Summary**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_summary`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|102400|

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
|Description|**Status of the Conversation Summary Interaction**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_conversationsummaryinteraction_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Conversation Summary Interaction**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_conversationsummaryinteraction_statuscode`|

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

- [lk_msdyn_conversationsummaryinteraction_createdby](#BKMK_lk_msdyn_conversationsummaryinteraction_createdby)
- [lk_msdyn_conversationsummaryinteraction_createdonbehalfby](#BKMK_lk_msdyn_conversationsummaryinteraction_createdonbehalfby)
- [lk_msdyn_conversationsummaryinteraction_modifiedby](#BKMK_lk_msdyn_conversationsummaryinteraction_modifiedby)
- [lk_msdyn_conversationsummaryinteraction_modifiedonbehalfby](#BKMK_lk_msdyn_conversationsummaryinteraction_modifiedonbehalfby)
- [msdyn_msdyn_ocliveworkitem_msdyn_conversationsummaryinteraction_conversationid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_conversationsummaryinteraction_conversationid)
- [organization_msdyn_conversationsummaryinteraction](#BKMK_organization_msdyn_conversationsummaryinteraction)

### <a name="BKMK_lk_msdyn_conversationsummaryinteraction_createdby"></a> lk_msdyn_conversationsummaryinteraction_createdby

One-To-Many Relationship: [systemuser lk_msdyn_conversationsummaryinteraction_createdby](systemuser.md#BKMK_lk_msdyn_conversationsummaryinteraction_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_conversationsummaryinteraction_createdonbehalfby"></a> lk_msdyn_conversationsummaryinteraction_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_conversationsummaryinteraction_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_conversationsummaryinteraction_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_conversationsummaryinteraction_modifiedby"></a> lk_msdyn_conversationsummaryinteraction_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_conversationsummaryinteraction_modifiedby](systemuser.md#BKMK_lk_msdyn_conversationsummaryinteraction_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_conversationsummaryinteraction_modifiedonbehalfby"></a> lk_msdyn_conversationsummaryinteraction_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_conversationsummaryinteraction_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_conversationsummaryinteraction_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_conversationsummaryinteraction_conversationid"></a> msdyn_msdyn_ocliveworkitem_msdyn_conversationsummaryinteraction_conversationid

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_msdyn_ocliveworkitem_msdyn_conversationsummaryinteraction_conversationid](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_conversationsummaryinteraction_conversationid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_conversationid`|
|ReferencingEntityNavigationPropertyName|`msdyn_conversationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_conversationsummaryinteraction"></a> organization_msdyn_conversationsummaryinteraction

One-To-Many Relationship: [organization organization_msdyn_conversationsummaryinteraction](organization.md#BKMK_organization_msdyn_conversationsummaryinteraction)

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

- [msdyn_conversationsummaryinteraction_AsyncOperations](#BKMK_msdyn_conversationsummaryinteraction_AsyncOperations)
- [msdyn_conversationsummaryinteraction_BulkDeleteFailures](#BKMK_msdyn_conversationsummaryinteraction_BulkDeleteFailures)
- [msdyn_conversationsummaryinteraction_MailboxTrackingFolders](#BKMK_msdyn_conversationsummaryinteraction_MailboxTrackingFolders)
- [msdyn_conversationsummaryinteraction_PrincipalObjectAttributeAccesses](#BKMK_msdyn_conversationsummaryinteraction_PrincipalObjectAttributeAccesses)
- [msdyn_conversationsummaryinteraction_ProcessSession](#BKMK_msdyn_conversationsummaryinteraction_ProcessSession)
- [msdyn_conversationsummaryinteraction_SyncErrors](#BKMK_msdyn_conversationsummaryinteraction_SyncErrors)

### <a name="BKMK_msdyn_conversationsummaryinteraction_AsyncOperations"></a> msdyn_conversationsummaryinteraction_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_conversationsummaryinteraction_AsyncOperations](asyncoperation.md#BKMK_msdyn_conversationsummaryinteraction_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationsummaryinteraction_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationsummaryinteraction_BulkDeleteFailures"></a> msdyn_conversationsummaryinteraction_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_conversationsummaryinteraction_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_conversationsummaryinteraction_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationsummaryinteraction_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationsummaryinteraction_MailboxTrackingFolders"></a> msdyn_conversationsummaryinteraction_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_conversationsummaryinteraction_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_conversationsummaryinteraction_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationsummaryinteraction_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationsummaryinteraction_PrincipalObjectAttributeAccesses"></a> msdyn_conversationsummaryinteraction_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_conversationsummaryinteraction_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_conversationsummaryinteraction_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationsummaryinteraction_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationsummaryinteraction_ProcessSession"></a> msdyn_conversationsummaryinteraction_ProcessSession

Many-To-One Relationship: [processsession msdyn_conversationsummaryinteraction_ProcessSession](processsession.md#BKMK_msdyn_conversationsummaryinteraction_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationsummaryinteraction_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationsummaryinteraction_SyncErrors"></a> msdyn_conversationsummaryinteraction_SyncErrors

Many-To-One Relationship: [syncerror msdyn_conversationsummaryinteraction_SyncErrors](syncerror.md#BKMK_msdyn_conversationsummaryinteraction_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationsummaryinteraction_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

