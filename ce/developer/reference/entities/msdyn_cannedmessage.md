---
title: "Quick reply (msdyn_cannedmessage) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Quick reply (msdyn_cannedmessage) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Quick reply (msdyn_cannedmessage) table/entity reference (Microsoft Dynamics 365)

Stores the quick replies that agents can use in the conversation control while interacting with the customers

## Messages

The following table lists the messages for the Quick reply (msdyn_cannedmessage) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_cannedmessages<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_cannedmessages(*msdyn_cannedmessageid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_cannedmessages(*msdyn_cannedmessageid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_cannedmessages<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_cannedmessages(*msdyn_cannedmessageid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_cannedmessages(*msdyn_cannedmessageid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_cannedmessages(*msdyn_cannedmessageid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Quick reply (msdyn_cannedmessage) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Quick reply** |
| **DisplayCollectionName** | **Quick replies** |
| **SchemaName** | `msdyn_cannedmessage` |
| **CollectionSchemaName** | `msdyn_cannedmessages` |
| **EntitySetName** | `msdyn_cannedmessages`|
| **LogicalName** | `msdyn_cannedmessage` |
| **LogicalCollectionName** | `msdyn_cannedmessages` |
| **PrimaryIdAttribute** | `msdyn_cannedmessageid` |
| **PrimaryNameAttribute** |`msdyn_title` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_cannedmessageId](#BKMK_msdyn_cannedmessageId)
- [msdyn_Locale_Field](#BKMK_msdyn_Locale_Field)
- [msdyn_message](#BKMK_msdyn_message)
- [msdyn_tagscontrolfield](#BKMK_msdyn_tagscontrolfield)
- [msdyn_title](#BKMK_msdyn_title)
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

### <a name="BKMK_msdyn_cannedmessageId"></a> msdyn_cannedmessageId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Quick reply**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_cannedmessageid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_Locale_Field"></a> msdyn_Locale_Field

|Property|Value|
|---|---|
|Description|**The locale of a canned message**|
|DisplayName|**Locale**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_locale_field`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|1033|
|GlobalChoiceName|`msdyn_cannedmessage_msdyn_locale_field`|

#### msdyn_Locale_Field Choices/Options

|Value|Label|
|---|---|
|1025|**ar-SA**|
|1026|**bg-BG**|
|1027|**ca-ES**|
|1028|**zh-TW**|
|1029|**cs-CZ**|
|1030|**da-DK**|
|1031|**de-DE**|
|1032|**el-GR**|
|1033|**en-US**|
|1035|**fi-FI**|
|1036|**fr-FR**|
|1037|**he-IL**|
|1038|**hu-HU**|
|1040|**it-IT**|
|1041|**ja-JP**|
|1042|**ko-KR**|
|1043|**nl-NL**|
|1044|**nb-NO**|
|1045|**pl-PL**|
|1046|**pt-BR**|
|1048|**ro-RO**|
|1049|**ru-RU**|
|1050|**hr-HR**|
|1051|**sk-SK**|
|1053|**sv-SE**|
|1054|**th-TH**|
|1055|**tr-TR**|
|1057|**id-ID**|
|1058|**uk-UA**|
|1060|**sl-SI**|
|1061|**et-EE**|
|1062|**lv-LV**|
|1063|**lt-LT**|
|1066|**vi-VN**|
|1069|**eu-ES**|
|1081|**hi-IN**|
|1086|**ms-MY**|
|1087|**kk-KZ**|
|1110|**gl-ES**|
|2052|**zh-CN**|
|2070|**pt-PT**|
|3076|**zh-HK**|
|3082|**es-ES**|
|3098|**sr-Cyrl-CS**|

### <a name="BKMK_msdyn_message"></a> msdyn_message

|Property|Value|
|---|---|
|Description|**Canned message text**|
|DisplayName|**Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_message`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_tagscontrolfield"></a> msdyn_tagscontrolfield

|Property|Value|
|---|---|
|Description|**Dummy field to render the tags control**|
|DisplayName|**TagsControlField**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_tagscontrolfield`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_title"></a> msdyn_title

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_title`|
|RequiredLevel|ApplicationRequired|
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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Quick replies**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_cannedmessage_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Quick replies**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_cannedmessage_statuscode`|

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

- [lk_msdyn_cannedmessage_createdby](#BKMK_lk_msdyn_cannedmessage_createdby)
- [lk_msdyn_cannedmessage_createdonbehalfby](#BKMK_lk_msdyn_cannedmessage_createdonbehalfby)
- [lk_msdyn_cannedmessage_modifiedby](#BKMK_lk_msdyn_cannedmessage_modifiedby)
- [lk_msdyn_cannedmessage_modifiedonbehalfby](#BKMK_lk_msdyn_cannedmessage_modifiedonbehalfby)
- [organization_msdyn_cannedmessage](#BKMK_organization_msdyn_cannedmessage)

### <a name="BKMK_lk_msdyn_cannedmessage_createdby"></a> lk_msdyn_cannedmessage_createdby

One-To-Many Relationship: [systemuser lk_msdyn_cannedmessage_createdby](systemuser.md#BKMK_lk_msdyn_cannedmessage_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_cannedmessage_createdonbehalfby"></a> lk_msdyn_cannedmessage_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_cannedmessage_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_cannedmessage_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_cannedmessage_modifiedby"></a> lk_msdyn_cannedmessage_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_cannedmessage_modifiedby](systemuser.md#BKMK_lk_msdyn_cannedmessage_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_cannedmessage_modifiedonbehalfby"></a> lk_msdyn_cannedmessage_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_cannedmessage_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_cannedmessage_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_cannedmessage"></a> organization_msdyn_cannedmessage

One-To-Many Relationship: [organization organization_msdyn_cannedmessage](organization.md#BKMK_organization_msdyn_cannedmessage)

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

- [msdyn_cannedmessage_AsyncOperations](#BKMK_msdyn_cannedmessage_AsyncOperations)
- [msdyn_cannedmessage_BulkDeleteFailures](#BKMK_msdyn_cannedmessage_BulkDeleteFailures)
- [msdyn_cannedmessage_DuplicateBaseRecord](#BKMK_msdyn_cannedmessage_DuplicateBaseRecord)
- [msdyn_cannedmessage_DuplicateMatchingRecord](#BKMK_msdyn_cannedmessage_DuplicateMatchingRecord)
- [msdyn_cannedmessage_MailboxTrackingFolders](#BKMK_msdyn_cannedmessage_MailboxTrackingFolders)
- [msdyn_cannedmessage_PrincipalObjectAttributeAccesses](#BKMK_msdyn_cannedmessage_PrincipalObjectAttributeAccesses)
- [msdyn_cannedmessage_ProcessSession](#BKMK_msdyn_cannedmessage_ProcessSession)
- [msdyn_cannedmessage_SyncErrors](#BKMK_msdyn_cannedmessage_SyncErrors)

### <a name="BKMK_msdyn_cannedmessage_AsyncOperations"></a> msdyn_cannedmessage_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_cannedmessage_AsyncOperations](asyncoperation.md#BKMK_msdyn_cannedmessage_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_cannedmessage_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_cannedmessage_BulkDeleteFailures"></a> msdyn_cannedmessage_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_cannedmessage_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_cannedmessage_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_cannedmessage_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_cannedmessage_DuplicateBaseRecord"></a> msdyn_cannedmessage_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_cannedmessage_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_cannedmessage_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_cannedmessage_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_cannedmessage_DuplicateMatchingRecord"></a> msdyn_cannedmessage_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_cannedmessage_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_cannedmessage_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_cannedmessage_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_cannedmessage_MailboxTrackingFolders"></a> msdyn_cannedmessage_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_cannedmessage_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_cannedmessage_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_cannedmessage_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_cannedmessage_PrincipalObjectAttributeAccesses"></a> msdyn_cannedmessage_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_cannedmessage_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_cannedmessage_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_cannedmessage_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_cannedmessage_ProcessSession"></a> msdyn_cannedmessage_ProcessSession

Many-To-One Relationship: [processsession msdyn_cannedmessage_ProcessSession](processsession.md#BKMK_msdyn_cannedmessage_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_cannedmessage_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_cannedmessage_SyncErrors"></a> msdyn_cannedmessage_SyncErrors

Many-To-One Relationship: [syncerror msdyn_cannedmessage_SyncErrors](syncerror.md#BKMK_msdyn_cannedmessage_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_cannedmessage_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [msdyn_msdyn_cannedmessage_liveworkstream](#BKMK_msdyn_msdyn_cannedmessage_liveworkstream)
- [msdyn_msdyn_cannedmessage_msdyn_octag](#BKMK_msdyn_msdyn_cannedmessage_msdyn_octag)

### <a name="BKMK_msdyn_msdyn_cannedmessage_liveworkstream"></a> msdyn_msdyn_cannedmessage_liveworkstream

See [msdyn_liveworkstream msdyn_msdyn_cannedmessage_liveworkstream Many-To-Many Relationship](msdyn_liveworkstream.md#BKMK_msdyn_msdyn_cannedmessage_liveworkstream)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_cannedmessage_liveworkstream`|
|IsCustomizable|True|
|SchemaName|`msdyn_msdyn_cannedmessage_liveworkstream`|
|IntersectAttribute|`msdyn_cannedmessageid`|
|NavigationPropertyName|`msdyn_msdyn_cannedmessage_liveworkstream`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_cannedmessage_msdyn_octag"></a> msdyn_msdyn_cannedmessage_msdyn_octag

See [msdyn_octag msdyn_msdyn_cannedmessage_msdyn_octag Many-To-Many Relationship](msdyn_octag.md#BKMK_msdyn_msdyn_cannedmessage_msdyn_octag)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_cannedmessage_msdyn_octag`|
|IsCustomizable|True|
|SchemaName|`msdyn_msdyn_cannedmessage_msdyn_octag`|
|IntersectAttribute|`msdyn_cannedmessageid`|
|NavigationPropertyName|`msdyn_msdyn_cannedmessage_msdyn_octag`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

