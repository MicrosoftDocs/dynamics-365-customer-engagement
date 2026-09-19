---
title: "msdyn_guardrail_execution_info table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the msdyn_guardrail_execution_info table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# msdyn_guardrail_execution_info table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the msdyn_guardrail_execution_info table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_guardrail_execution_infos(*msdyn_guardrail_execution_infoid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_guardrail_execution_infos<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_guardrail_execution_infos(*msdyn_guardrail_execution_infoid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_guardrail_execution_infos(*msdyn_guardrail_execution_infoid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_guardrail_execution_infos<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_guardrail_execution_infos(*msdyn_guardrail_execution_infoid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_guardrail_execution_infos(*msdyn_guardrail_execution_infoid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_guardrail_execution_infos(*msdyn_guardrail_execution_infoid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the msdyn_guardrail_execution_info table.

|Property|Value|
| --- | --- |
| **DisplayName** | **msdyn_guardrail_execution_info** |
| **DisplayCollectionName** | **msdyn_guardrail_execution_infos** |
| **SchemaName** | `msdyn_guardrail_execution_info` |
| **CollectionSchemaName** | `msdyn_guardrail_execution_infos` |
| **EntitySetName** | `msdyn_guardrail_execution_infos`|
| **LogicalName** | `msdyn_guardrail_execution_info` |
| **LogicalCollectionName** | `msdyn_guardrail_execution_infos` |
| **PrimaryIdAttribute** | `msdyn_guardrail_execution_infoid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_attachmentfilename](#BKMK_msdyn_attachmentfilename)
- [msdyn_attachmentid](#BKMK_msdyn_attachmentid)
- [msdyn_detectionaction](#BKMK_msdyn_detectionaction)
- [msdyn_error](#BKMK_msdyn_error)
- [msdyn_feedback](#BKMK_msdyn_feedback)
- [msdyn_guardrail_execution_infoId](#BKMK_msdyn_guardrail_execution_infoId)
- [msdyn_guardrail_ruleid](#BKMK_msdyn_guardrail_ruleid)
- [msdyn_guardrail_runid](#BKMK_msdyn_guardrail_runid)
- [msdyn_guardrail_scenariotypeid](#BKMK_msdyn_guardrail_scenariotypeid)
- [msdyn_invokedby](#BKMK_msdyn_invokedby)
- [msdyn_issendemail](#BKMK_msdyn_issendemail)
- [msdyn_isviolated](#BKMK_msdyn_isviolated)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_objectid](#BKMK_msdyn_objectid)
- [msdyn_reason](#BKMK_msdyn_reason)
- [msdyn_regardingid](#BKMK_msdyn_regardingid)
- [msdyn_regardingtype](#BKMK_msdyn_regardingtype)
- [msdyn_score](#BKMK_msdyn_score)
- [msdyn_shadowmode](#BKMK_msdyn_shadowmode)
- [msdyn_version](#BKMK_msdyn_version)
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

### <a name="BKMK_msdyn_attachmentfilename"></a> msdyn_attachmentfilename

|Property|Value|
|---|---|
|Description|**Name of the file attachment that was validated**|
|DisplayName|**Attachment File Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attachmentfilename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|255|

### <a name="BKMK_msdyn_attachmentid"></a> msdyn_attachmentid

|Property|Value|
|---|---|
|Description|**ID of the attachment that was validated**|
|DisplayName|**Attachment ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attachmentid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_detectionaction"></a> msdyn_detectionaction

|Property|Value|
|---|---|
|Description|**type of action to be taken after guardrail execution**|
|DisplayName|**msdyn\_detectionaction**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_detectionaction`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_guardrail_detection_action`|

#### msdyn_detectionaction Choices/Options

|Value|Label|
|---|---|
|192350000|**Log Only**|
|192350001|**Log and Block**|
|192350002|**Log and Warn**|

### <a name="BKMK_msdyn_error"></a> msdyn_error

|Property|Value|
|---|---|
|Description|**Error description**|
|DisplayName|**msdyn\_error**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_error`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_feedback"></a> msdyn_feedback

|Property|Value|
|---|---|
|Description||
|DisplayName|**msdyn\_feedback**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_feedback`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_guardrail_execution_infoId"></a> msdyn_guardrail_execution_infoId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**msdyn\_guardrail\_execution\_infoid**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_guardrail_execution_infoid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_guardrail_ruleid"></a> msdyn_guardrail_ruleid

|Property|Value|
|---|---|
|Description|**Lookup record to guardrail rule table**|
|DisplayName|**msdyn\_guardrail\_ruleid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_guardrail_ruleid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_guardrail_rule|

### <a name="BKMK_msdyn_guardrail_runid"></a> msdyn_guardrail_runid

|Property|Value|
|---|---|
|Description|**Guardrail Run ID linking guardrail execution records to a single validation run**|
|DisplayName|**Guardrail Run ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_guardrail_runid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_guardrail_scenariotypeid"></a> msdyn_guardrail_scenariotypeid

|Property|Value|
|---|---|
|Description|**Lookup record to Guardrail Scenario type table**|
|DisplayName|**msdyn\_guardrail\_scenariotypeid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_guardrail_scenariotypeid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_guardrail_scenariotype|

### <a name="BKMK_msdyn_invokedby"></a> msdyn_invokedby

|Property|Value|
|---|---|
|Description|**User who invoked the guardrail validation plugin**|
|DisplayName|**Invoked By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_invokedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_issendemail"></a> msdyn_issendemail

|Property|Value|
|---|---|
|Description|**Indicates whether the user chose to override violated guardrail rules and send the email.**|
|DisplayName|**Send Email Override**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_issendemail`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_guardrail_execution_info_msdyn_issendemail`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_isviolated"></a> msdyn_isviolated

|Property|Value|
|---|---|
|Description|**Result whether guardrail rule is violated or not**|
|DisplayName|**msdyn\_isviolated**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isviolated`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_guardrail_execution_info_msdyn_isviolated`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**name of record**|
|DisplayName|**msdyn\_name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|850|

### <a name="BKMK_msdyn_objectid"></a> msdyn_objectid

|Property|Value|
|---|---|
|Description|**record for which guardrail validation was invoked**|
|DisplayName|**msdyn\_objectid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_objectid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_reason"></a> msdyn_reason

|Property|Value|
|---|---|
|Description|**Violation reason description**|
|DisplayName|**msdyn\_reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_reason`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_regardingid"></a> msdyn_regardingid

|Property|Value|
|---|---|
|Description|**related record on which applicable conditions would be checked**|
|DisplayName|**msdyn\_regardingid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_regardingtype"></a> msdyn_regardingtype

|Property|Value|
|---|---|
|Description|**Entity logical name of reference record**|
|DisplayName|**msdyn\_regardingtype**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingtype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_score"></a> msdyn_score

|Property|Value|
|---|---|
|Description|**The LLM-assigned compliance score (1-10) for this policy evaluation**|
|DisplayName|**Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_score`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|10|
|MinValue|0|

### <a name="BKMK_msdyn_shadowmode"></a> msdyn_shadowmode

|Property|Value|
|---|---|
|Description|**Indicates if the record was generated when running in shadow mode**|
|DisplayName|**msdyn\_shadowmode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_shadowmode`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_guardrail_execution_info_msdyn_shadowmode`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_version"></a> msdyn_version

|Property|Value|
|---|---|
|Description|**version of guardrail on which execution was done**|
|DisplayName|**msdyn\_version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_version`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

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
|Description|**Status of the msdyn\_guardrail\_execution\_info**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_guardrail_execution_info_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the msdyn\_guardrail\_execution\_info**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_guardrail_execution_info_statuscode`|

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

- [business_unit_msdyn_guardrail_execution_info](#BKMK_business_unit_msdyn_guardrail_execution_info)
- [lk_msdyn_guardrail_execution_info_createdby](#BKMK_lk_msdyn_guardrail_execution_info_createdby)
- [lk_msdyn_guardrail_execution_info_createdonbehalfby](#BKMK_lk_msdyn_guardrail_execution_info_createdonbehalfby)
- [lk_msdyn_guardrail_execution_info_modifiedby](#BKMK_lk_msdyn_guardrail_execution_info_modifiedby)
- [lk_msdyn_guardrail_execution_info_modifiedonbehalfby](#BKMK_lk_msdyn_guardrail_execution_info_modifiedonbehalfby)
- [msdyn_guardrail_execution_info_msdyn_guardrail_ruleid_msdyn_guardrail_rule](#BKMK_msdyn_guardrail_execution_info_msdyn_guardrail_ruleid_msdyn_guardrail_rule)
- [msdyn_guardrail_execution_info_msdyn_guardrail_scenariotypeid_msdyn_guardrail_scenarioty](#BKMK_msdyn_guardrail_execution_info_msdyn_guardrail_scenariotypeid_msdyn_guardrail_scenarioty)
- [msdyn_systemuser_msdyn_guardrail_execution_info_msdyn_invokedby](#BKMK_msdyn_systemuser_msdyn_guardrail_execution_info_msdyn_invokedby)
- [owner_msdyn_guardrail_execution_info](#BKMK_owner_msdyn_guardrail_execution_info)
- [team_msdyn_guardrail_execution_info](#BKMK_team_msdyn_guardrail_execution_info)
- [user_msdyn_guardrail_execution_info](#BKMK_user_msdyn_guardrail_execution_info)

### <a name="BKMK_business_unit_msdyn_guardrail_execution_info"></a> business_unit_msdyn_guardrail_execution_info

One-To-Many Relationship: [businessunit business_unit_msdyn_guardrail_execution_info](businessunit.md#BKMK_business_unit_msdyn_guardrail_execution_info)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_guardrail_execution_info_createdby"></a> lk_msdyn_guardrail_execution_info_createdby

One-To-Many Relationship: [systemuser lk_msdyn_guardrail_execution_info_createdby](systemuser.md#BKMK_lk_msdyn_guardrail_execution_info_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_guardrail_execution_info_createdonbehalfby"></a> lk_msdyn_guardrail_execution_info_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_guardrail_execution_info_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_guardrail_execution_info_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_guardrail_execution_info_modifiedby"></a> lk_msdyn_guardrail_execution_info_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_guardrail_execution_info_modifiedby](systemuser.md#BKMK_lk_msdyn_guardrail_execution_info_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_guardrail_execution_info_modifiedonbehalfby"></a> lk_msdyn_guardrail_execution_info_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_guardrail_execution_info_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_guardrail_execution_info_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_guardrail_execution_info_msdyn_guardrail_ruleid_msdyn_guardrail_rule"></a> msdyn_guardrail_execution_info_msdyn_guardrail_ruleid_msdyn_guardrail_rule

One-To-Many Relationship: [msdyn_guardrail_rule msdyn_guardrail_execution_info_msdyn_guardrail_ruleid_msdyn_guardrail_rule](msdyn_guardrail_rule.md#BKMK_msdyn_guardrail_execution_info_msdyn_guardrail_ruleid_msdyn_guardrail_rule)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_guardrail_rule`|
|ReferencedAttribute|`msdyn_guardrail_ruleid`|
|ReferencingAttribute|`msdyn_guardrail_ruleid`|
|ReferencingEntityNavigationPropertyName|`msdyn_guardrail_ruleid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_guardrail_execution_info_msdyn_guardrail_scenariotypeid_msdyn_guardrail_scenarioty"></a> msdyn_guardrail_execution_info_msdyn_guardrail_scenariotypeid_msdyn_guardrail_scenarioty

One-To-Many Relationship: [msdyn_guardrail_scenariotype msdyn_guardrail_execution_info_msdyn_guardrail_scenariotypeid_msdyn_guardrail_scenarioty](msdyn_guardrail_scenariotype.md#BKMK_msdyn_guardrail_execution_info_msdyn_guardrail_scenariotypeid_msdyn_guardrail_scenarioty)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_guardrail_scenariotype`|
|ReferencedAttribute|`msdyn_guardrail_scenariotypeid`|
|ReferencingAttribute|`msdyn_guardrail_scenariotypeid`|
|ReferencingEntityNavigationPropertyName|`msdyn_guardrail_scenariotypeid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuser_msdyn_guardrail_execution_info_msdyn_invokedby"></a> msdyn_systemuser_msdyn_guardrail_execution_info_msdyn_invokedby

One-To-Many Relationship: [systemuser msdyn_systemuser_msdyn_guardrail_execution_info_msdyn_invokedby](systemuser.md#BKMK_msdyn_systemuser_msdyn_guardrail_execution_info_msdyn_invokedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_invokedby`|
|ReferencingEntityNavigationPropertyName|`msdyn_invokedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_guardrail_execution_info"></a> owner_msdyn_guardrail_execution_info

One-To-Many Relationship: [owner owner_msdyn_guardrail_execution_info](owner.md#BKMK_owner_msdyn_guardrail_execution_info)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_guardrail_execution_info"></a> team_msdyn_guardrail_execution_info

One-To-Many Relationship: [team team_msdyn_guardrail_execution_info](team.md#BKMK_team_msdyn_guardrail_execution_info)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_guardrail_execution_info"></a> user_msdyn_guardrail_execution_info

One-To-Many Relationship: [systemuser user_msdyn_guardrail_execution_info](systemuser.md#BKMK_user_msdyn_guardrail_execution_info)

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

- [msdyn_guardrail_execution_info_AsyncOperations](#BKMK_msdyn_guardrail_execution_info_AsyncOperations)
- [msdyn_guardrail_execution_info_BulkDeleteFailures](#BKMK_msdyn_guardrail_execution_info_BulkDeleteFailures)
- [msdyn_guardrail_execution_info_DuplicateBaseRecord](#BKMK_msdyn_guardrail_execution_info_DuplicateBaseRecord)
- [msdyn_guardrail_execution_info_DuplicateMatchingRecord](#BKMK_msdyn_guardrail_execution_info_DuplicateMatchingRecord)
- [msdyn_guardrail_execution_info_MailboxTrackingFolders](#BKMK_msdyn_guardrail_execution_info_MailboxTrackingFolders)
- [msdyn_guardrail_execution_info_PrincipalObjectAttributeAccesses](#BKMK_msdyn_guardrail_execution_info_PrincipalObjectAttributeAccesses)
- [msdyn_guardrail_execution_info_ProcessSession](#BKMK_msdyn_guardrail_execution_info_ProcessSession)
- [msdyn_guardrail_execution_info_SyncErrors](#BKMK_msdyn_guardrail_execution_info_SyncErrors)

### <a name="BKMK_msdyn_guardrail_execution_info_AsyncOperations"></a> msdyn_guardrail_execution_info_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_guardrail_execution_info_AsyncOperations](asyncoperation.md#BKMK_msdyn_guardrail_execution_info_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_guardrail_execution_info_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_guardrail_execution_info_BulkDeleteFailures"></a> msdyn_guardrail_execution_info_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_guardrail_execution_info_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_guardrail_execution_info_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_guardrail_execution_info_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_guardrail_execution_info_DuplicateBaseRecord"></a> msdyn_guardrail_execution_info_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_guardrail_execution_info_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_guardrail_execution_info_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_guardrail_execution_info_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_guardrail_execution_info_DuplicateMatchingRecord"></a> msdyn_guardrail_execution_info_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_guardrail_execution_info_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_guardrail_execution_info_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_guardrail_execution_info_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_guardrail_execution_info_MailboxTrackingFolders"></a> msdyn_guardrail_execution_info_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_guardrail_execution_info_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_guardrail_execution_info_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_guardrail_execution_info_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_guardrail_execution_info_PrincipalObjectAttributeAccesses"></a> msdyn_guardrail_execution_info_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_guardrail_execution_info_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_guardrail_execution_info_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_guardrail_execution_info_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_guardrail_execution_info_ProcessSession"></a> msdyn_guardrail_execution_info_ProcessSession

Many-To-One Relationship: [processsession msdyn_guardrail_execution_info_ProcessSession](processsession.md#BKMK_msdyn_guardrail_execution_info_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_guardrail_execution_info_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_guardrail_execution_info_SyncErrors"></a> msdyn_guardrail_execution_info_SyncErrors

Many-To-One Relationship: [syncerror msdyn_guardrail_execution_info_SyncErrors](syncerror.md#BKMK_msdyn_guardrail_execution_info_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_guardrail_execution_info_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

