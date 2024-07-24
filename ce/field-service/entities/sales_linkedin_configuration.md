---
title: "LinkedIn Sales Navigator Configuration (sales_linkedin_configuration) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the LinkedIn Sales Navigator Configuration (sales_linkedin_configuration) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# LinkedIn Sales Navigator Configuration (sales_linkedin_configuration) table/entity reference

Optional configuration for LinkedIn Sales Navigator integration with Dynamics 365

## Messages

The following table lists the messages for the LinkedIn Sales Navigator Configuration (sales_linkedin_configuration) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /sales_linkedin_configurations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `Delete`<br />Event: True |`DELETE` /sales_linkedin_configurations(*sales_linkedin_configurationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /sales_linkedin_configurations(*sales_linkedin_configurationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /sales_linkedin_configurations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /sales_linkedin_configurations(*sales_linkedin_configurationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `Upsert`<br />Event: False |`PATCH` /sales_linkedin_configurations(*sales_linkedin_configurationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|


## Events

The following table lists the events for the LinkedIn Sales Navigator Configuration (sales_linkedin_configuration) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the LinkedIn Sales Navigator Configuration (sales_linkedin_configuration) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **LinkedIn Sales Navigator Configuration** |
| **DisplayCollectionName** | **LinkedIn Sales Navigator Configurations** |
| **SchemaName** | `sales_linkedin_configuration` |
| **CollectionSchemaName** | `sales_linkedin_configurations` |
| **EntitySetName** | `sales_linkedin_configurations`|
| **LogicalName** | `sales_linkedin_configuration` |
| **LogicalCollectionName** | `sales_linkedin_configurations` |
| **PrimaryIdAttribute** | `sales_linkedin_configurationid` |
| **PrimaryNameAttribute** |`sales_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_lisnserviceurl](#BKMK_msdyn_lisnserviceurl)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [sales_LinkedIn_ApiKey](#BKMK_sales_LinkedIn_ApiKey)
- [sales_linkedin_configurationId](#BKMK_sales_linkedin_configurationId)
- [sales_linkedin_enable_feature](#BKMK_sales_linkedin_enable_feature)
- [sales_linkedin_profile_feature](#BKMK_sales_linkedin_profile_feature)
- [sales_linkedin_profileFetch_Status](#BKMK_sales_linkedin_profileFetch_Status)
- [sales_name](#BKMK_sales_name)
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

### <a name="BKMK_msdyn_lisnserviceurl"></a> msdyn_lisnserviceurl

|Property|Value|
|---|---|
|Description|**Url for LinkedIn Sales Navigator Integration Service**|
|DisplayName|**LinkedIn Sales Navigator Integration Service Url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lisnserviceurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

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

### <a name="BKMK_sales_LinkedIn_ApiKey"></a> sales_LinkedIn_ApiKey

|Property|Value|
|---|---|
|Description||
|DisplayName|**LinkedIn_ApiKey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sales_linkedin_apikey`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_sales_linkedin_configurationId"></a> sales_linkedin_configurationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**LinkedIn_Configuration**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`sales_linkedin_configurationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_sales_linkedin_enable_feature"></a> sales_linkedin_enable_feature

|Property|Value|
|---|---|
|Description||
|DisplayName|**LinkedIn_Enable_Feature**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sales_linkedin_enable_feature`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`sales_linkedin_configuration_sales_linkedin_enable_feature`|
|DefaultValue|False|
|True Label|true|
|False Label|false|

### <a name="BKMK_sales_linkedin_profile_feature"></a> sales_linkedin_profile_feature

|Property|Value|
|---|---|
|Description||
|DisplayName|**LinkedIn_Enable_Feature**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sales_linkedin_profile_feature`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`sales_linkedin_configuration_sales_linkedin_profile_feature`|
|DefaultValue|False|
|True Label|true|
|False Label|false|

### <a name="BKMK_sales_linkedin_profileFetch_Status"></a> sales_linkedin_profileFetch_Status

|Property|Value|
|---|---|
|Description||
|DisplayName|**sales_linkedin_profileFetch_Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sales_linkedin_profileFetch_Status`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_sales_name"></a> sales_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sales_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the LinkedIn_Configuration**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`sales_linkedin_configuration_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the LinkedIn_Configuration**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`sales_linkedin_configuration_statuscode`|

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

- [lk_sales_linkedin_configuration_createdby](#BKMK_lk_sales_linkedin_configuration_createdby)
- [lk_sales_linkedin_configuration_createdonbehalfby](#BKMK_lk_sales_linkedin_configuration_createdonbehalfby)
- [lk_sales_linkedin_configuration_modifiedby](#BKMK_lk_sales_linkedin_configuration_modifiedby)
- [lk_sales_linkedin_configuration_modifiedonbehalfby](#BKMK_lk_sales_linkedin_configuration_modifiedonbehalfby)

### <a name="BKMK_lk_sales_linkedin_configuration_createdby"></a> lk_sales_linkedin_configuration_createdby

One-To-Many Relationship: [systemuser lk_sales_linkedin_configuration_createdby](systemuser.md#BKMK_lk_sales_linkedin_configuration_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_sales_linkedin_configuration_createdonbehalfby"></a> lk_sales_linkedin_configuration_createdonbehalfby

One-To-Many Relationship: [systemuser lk_sales_linkedin_configuration_createdonbehalfby](systemuser.md#BKMK_lk_sales_linkedin_configuration_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_sales_linkedin_configuration_modifiedby"></a> lk_sales_linkedin_configuration_modifiedby

One-To-Many Relationship: [systemuser lk_sales_linkedin_configuration_modifiedby](systemuser.md#BKMK_lk_sales_linkedin_configuration_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_sales_linkedin_configuration_modifiedonbehalfby"></a> lk_sales_linkedin_configuration_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_sales_linkedin_configuration_modifiedonbehalfby](systemuser.md#BKMK_lk_sales_linkedin_configuration_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [sales_linkedin_configuration_AsyncOperations](#BKMK_sales_linkedin_configuration_AsyncOperations)
- [sales_linkedin_configuration_BulkDeleteFailures](#BKMK_sales_linkedin_configuration_BulkDeleteFailures)
- [sales_linkedin_configuration_DuplicateBaseRecord](#BKMK_sales_linkedin_configuration_DuplicateBaseRecord)
- [sales_linkedin_configuration_DuplicateMatchingRecord](#BKMK_sales_linkedin_configuration_DuplicateMatchingRecord)
- [sales_linkedin_configuration_MailboxTrackingFolders](#BKMK_sales_linkedin_configuration_MailboxTrackingFolders)
- [sales_linkedin_configuration_PrincipalObjectAttributeAccesses](#BKMK_sales_linkedin_configuration_PrincipalObjectAttributeAccesses)
- [sales_linkedin_configuration_ProcessSession](#BKMK_sales_linkedin_configuration_ProcessSession)
- [sales_linkedin_configuration_SyncErrors](#BKMK_sales_linkedin_configuration_SyncErrors)

### <a name="BKMK_sales_linkedin_configuration_AsyncOperations"></a> sales_linkedin_configuration_AsyncOperations

Many-To-One Relationship: [asyncoperation sales_linkedin_configuration_AsyncOperations](asyncoperation.md#BKMK_sales_linkedin_configuration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sales_linkedin_configuration_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sales_linkedin_configuration_BulkDeleteFailures"></a> sales_linkedin_configuration_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure sales_linkedin_configuration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_sales_linkedin_configuration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sales_linkedin_configuration_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sales_linkedin_configuration_DuplicateBaseRecord"></a> sales_linkedin_configuration_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord sales_linkedin_configuration_DuplicateBaseRecord](duplicaterecord.md#BKMK_sales_linkedin_configuration_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`sales_linkedin_configuration_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sales_linkedin_configuration_DuplicateMatchingRecord"></a> sales_linkedin_configuration_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord sales_linkedin_configuration_DuplicateMatchingRecord](duplicaterecord.md#BKMK_sales_linkedin_configuration_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`sales_linkedin_configuration_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sales_linkedin_configuration_MailboxTrackingFolders"></a> sales_linkedin_configuration_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder sales_linkedin_configuration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_sales_linkedin_configuration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sales_linkedin_configuration_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sales_linkedin_configuration_PrincipalObjectAttributeAccesses"></a> sales_linkedin_configuration_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess sales_linkedin_configuration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_sales_linkedin_configuration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`sales_linkedin_configuration_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sales_linkedin_configuration_ProcessSession"></a> sales_linkedin_configuration_ProcessSession

Many-To-One Relationship: [processsession sales_linkedin_configuration_ProcessSession](processsession.md#BKMK_sales_linkedin_configuration_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sales_linkedin_configuration_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sales_linkedin_configuration_SyncErrors"></a> sales_linkedin_configuration_SyncErrors

Many-To-One Relationship: [syncerror sales_linkedin_configuration_SyncErrors](syncerror.md#BKMK_sales_linkedin_configuration_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`sales_linkedin_configuration_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

