---
title: "Originating Queue Mapping (msdyn_originatingqueue) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Originating Queue Mapping (msdyn_originatingqueue) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Originating Queue Mapping (msdyn_originatingqueue) table/entity reference (Microsoft Dynamics 365)

This entity maps entities created by ARC to the queue that was being procesed at that time

## Messages

The following table lists the messages for the Originating Queue Mapping (msdyn_originatingqueue) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_originatingqueues<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `Delete`<br />Event: True |`DELETE` /msdyn_originatingqueues(*msdyn_originatingqueueid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_originatingqueues(*msdyn_originatingqueueid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_originatingqueues<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_originatingqueues(*msdyn_originatingqueueid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `Upsert`<br />Event: False |`PATCH` /msdyn_originatingqueues(*msdyn_originatingqueueid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Originating Queue Mapping (msdyn_originatingqueue) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Originating Queue Mapping** |
| **DisplayCollectionName** | **Originating Queue Mappings** |
| **SchemaName** | `msdyn_originatingqueue` |
| **CollectionSchemaName** | `msdyn_originatingqueues` |
| **EntitySetName** | `msdyn_originatingqueues`|
| **LogicalName** | `msdyn_originatingqueue` |
| **LogicalCollectionName** | `msdyn_originatingqueues` |
| **PrimaryIdAttribute** | `msdyn_originatingqueueid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_createdentityid](#BKMK_msdyn_createdentityid)
- [msdyn_createdentitytype](#BKMK_msdyn_createdentitytype)
- [msdyn_createdincidentid](#BKMK_msdyn_createdincidentid)
- [msdyn_emailid](#BKMK_msdyn_emailid)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_originatingqueueId](#BKMK_msdyn_originatingqueueId)
- [msdyn_queueid](#BKMK_msdyn_queueid)
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

### <a name="BKMK_msdyn_createdentityid"></a> msdyn_createdentityid

|Property|Value|
|---|---|
|Description|**The Unique Identifier of the entity created while processing this queue.**|
|DisplayName|**Created Entity Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_createdentityid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|160|

### <a name="BKMK_msdyn_createdentitytype"></a> msdyn_createdentitytype

|Property|Value|
|---|---|
|Description|**The type of the entity created while processing this queue.**|
|DisplayName|**Created Entity Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_createdentitytype`|
|RequiredLevel|ApplicationRequired|
|Type|EntityName|

### <a name="BKMK_msdyn_createdincidentid"></a> msdyn_createdincidentid

|Property|Value|
|---|---|
|Description|**Lookup that is populated if the entity that was created was a case.**|
|DisplayName|**Case**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_createdincidentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets||

### <a name="BKMK_msdyn_emailid"></a> msdyn_emailid

|Property|Value|
|---|---|
|Description|**Unique Identifier of the Email Activity being procesed**|
|DisplayName|**Email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_emailid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|email|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of this entity.**|
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

### <a name="BKMK_msdyn_originatingqueueId"></a> msdyn_originatingqueueId

|Property|Value|
|---|---|
|Description|**Unique Identifier of this record**|
|DisplayName|**Originating Queue Record ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_originatingqueueid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_queueid"></a> msdyn_queueid

|Property|Value|
|---|---|
|Description|**Unique Identifier of the Queue that was being processed when the entity was created**|
|DisplayName|**Queue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_queueid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|queue|

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
|Description|**Status of the Originating Queue Mapping**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_originatingqueue_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Originating Queue Mapping**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_originatingqueue_statuscode`|

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

- [lk_msdyn_originatingqueue_createdby](#BKMK_lk_msdyn_originatingqueue_createdby)
- [lk_msdyn_originatingqueue_createdonbehalfby](#BKMK_lk_msdyn_originatingqueue_createdonbehalfby)
- [lk_msdyn_originatingqueue_modifiedby](#BKMK_lk_msdyn_originatingqueue_modifiedby)
- [lk_msdyn_originatingqueue_modifiedonbehalfby](#BKMK_lk_msdyn_originatingqueue_modifiedonbehalfby)
- [msdyn_email_msdyn_originatingqueue_email](#BKMK_msdyn_email_msdyn_originatingqueue_email)
- [msdyn_incident_msdyn_originatingqueue_createdincidentid](#BKMK_msdyn_incident_msdyn_originatingqueue_createdincidentid)
- [msdyn_queue_msdyn_originatingqueue_queueid](#BKMK_msdyn_queue_msdyn_originatingqueue_queueid)

### <a name="BKMK_lk_msdyn_originatingqueue_createdby"></a> lk_msdyn_originatingqueue_createdby

One-To-Many Relationship: [systemuser lk_msdyn_originatingqueue_createdby](systemuser.md#BKMK_lk_msdyn_originatingqueue_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_originatingqueue_createdonbehalfby"></a> lk_msdyn_originatingqueue_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_originatingqueue_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_originatingqueue_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_originatingqueue_modifiedby"></a> lk_msdyn_originatingqueue_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_originatingqueue_modifiedby](systemuser.md#BKMK_lk_msdyn_originatingqueue_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_originatingqueue_modifiedonbehalfby"></a> lk_msdyn_originatingqueue_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_originatingqueue_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_originatingqueue_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_email_msdyn_originatingqueue_email"></a> msdyn_email_msdyn_originatingqueue_email

One-To-Many Relationship: [email msdyn_email_msdyn_originatingqueue_email](email.md#BKMK_msdyn_email_msdyn_originatingqueue_email)

|Property|Value|
|---|---|
|ReferencedEntity|`email`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_emailid`|
|ReferencingEntityNavigationPropertyName|`msdyn_emailid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incident_msdyn_originatingqueue_createdincidentid"></a> msdyn_incident_msdyn_originatingqueue_createdincidentid

One-To-Many Relationship: [incident msdyn_incident_msdyn_originatingqueue_createdincidentid](incident.md#BKMK_msdyn_incident_msdyn_originatingqueue_createdincidentid)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`msdyn_createdincidentid`|
|ReferencingEntityNavigationPropertyName|`msdyn_createdincidentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_queue_msdyn_originatingqueue_queueid"></a> msdyn_queue_msdyn_originatingqueue_queueid

One-To-Many Relationship: [queue msdyn_queue_msdyn_originatingqueue_queueid](queue.md#BKMK_msdyn_queue_msdyn_originatingqueue_queueid)

|Property|Value|
|---|---|
|ReferencedEntity|`queue`|
|ReferencedAttribute|`queueid`|
|ReferencingAttribute|`msdyn_queueid`|
|ReferencingEntityNavigationPropertyName|`msdyn_queueid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_originatingqueue_AsyncOperations](#BKMK_msdyn_originatingqueue_AsyncOperations)
- [msdyn_originatingqueue_BulkDeleteFailures](#BKMK_msdyn_originatingqueue_BulkDeleteFailures)
- [msdyn_originatingqueue_MailboxTrackingFolders](#BKMK_msdyn_originatingqueue_MailboxTrackingFolders)
- [msdyn_originatingqueue_PrincipalObjectAttributeAccesses](#BKMK_msdyn_originatingqueue_PrincipalObjectAttributeAccesses)
- [msdyn_originatingqueue_ProcessSession](#BKMK_msdyn_originatingqueue_ProcessSession)
- [msdyn_originatingqueue_SyncErrors](#BKMK_msdyn_originatingqueue_SyncErrors)

### <a name="BKMK_msdyn_originatingqueue_AsyncOperations"></a> msdyn_originatingqueue_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_originatingqueue_AsyncOperations](asyncoperation.md#BKMK_msdyn_originatingqueue_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_originatingqueue_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_originatingqueue_BulkDeleteFailures"></a> msdyn_originatingqueue_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_originatingqueue_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_originatingqueue_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_originatingqueue_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_originatingqueue_MailboxTrackingFolders"></a> msdyn_originatingqueue_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_originatingqueue_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_originatingqueue_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_originatingqueue_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_originatingqueue_PrincipalObjectAttributeAccesses"></a> msdyn_originatingqueue_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_originatingqueue_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_originatingqueue_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_originatingqueue_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_originatingqueue_ProcessSession"></a> msdyn_originatingqueue_ProcessSession

Many-To-One Relationship: [processsession msdyn_originatingqueue_ProcessSession](processsession.md#BKMK_msdyn_originatingqueue_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_originatingqueue_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_originatingqueue_SyncErrors"></a> msdyn_originatingqueue_SyncErrors

Many-To-One Relationship: [syncerror msdyn_originatingqueue_SyncErrors](syncerror.md#BKMK_msdyn_originatingqueue_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_originatingqueue_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

