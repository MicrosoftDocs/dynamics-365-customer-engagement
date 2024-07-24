---
title: "SmsSubmission (msdynmkt_smssubmission) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the SmsSubmission (msdynmkt_smssubmission) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# SmsSubmission (msdynmkt_smssubmission) table/entity reference



## Messages

The following table lists the messages for the SmsSubmission (msdynmkt_smssubmission) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdynmkt_smssubmissions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_smssubmissions(*msdynmkt_smssubmissionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_smssubmissions(*msdynmkt_smssubmissionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_smssubmissions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /msdynmkt_smssubmissions(*msdynmkt_smssubmissionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: True |`PATCH` /msdynmkt_smssubmissions(*msdynmkt_smssubmissionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the SmsSubmission (msdynmkt_smssubmission) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the SmsSubmission (msdynmkt_smssubmission) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **SmsSubmission** |
| **DisplayCollectionName** | **SmsSubmissions** |
| **SchemaName** | `msdynmkt_smssubmission` |
| **CollectionSchemaName** | `msdynmkt_smssubmissions` |
| **EntitySetName** | `msdynmkt_smssubmissions`|
| **LogicalName** | `msdynmkt_smssubmission` |
| **LogicalCollectionName** | `msdynmkt_smssubmissions` |
| **PrimaryIdAttribute** | `msdynmkt_smssubmissionid` |
| **PrimaryNameAttribute** |`msdynmkt_organizationcontactpoint` |
| **TableType** | `Elastic` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_direction](#BKMK_msdynmkt_direction)
- [msdynmkt_organizationcontactpoint](#BKMK_msdynmkt_organizationcontactpoint)
- [msdynmkt_profileid](#BKMK_msdynmkt_profileid)
- [msdynmkt_profiletype](#BKMK_msdynmkt_profiletype)
- [msdynmkt_smssubmissionId](#BKMK_msdynmkt_smssubmissionId)
- [msdynmkt_text](#BKMK_msdynmkt_text)
- [msdynmkt_trackingcontextid](#BKMK_msdynmkt_trackingcontextid)
- [msdynmkt_trackingcontextidPId](#BKMK_msdynmkt_trackingcontextidPId)
- [msdynmkt_usercontactpoint](#BKMK_msdynmkt_usercontactpoint)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [PartitionId](#BKMK_PartitionId)
- [TTLInSeconds](#BKMK_TTLInSeconds)

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

### <a name="BKMK_msdynmkt_direction"></a> msdynmkt_direction

|Property|Value|
|---|---|
|Description||
|DisplayName|**Direction**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_direction`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|534130000|
|GlobalChoiceName|`msdynmkt_smssubmission_msdynmkt_direction`|

#### msdynmkt_direction Choices/Options

|Value|Label|
|---|---|
|534130000|**Outbound**|
|534130001|**Inbound**|

### <a name="BKMK_msdynmkt_organizationcontactpoint"></a> msdynmkt_organizationcontactpoint

|Property|Value|
|---|---|
|Description|**Contact point from the organization side**|
|DisplayName|**Contact point from the organization side**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_organizationcontactpoint`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdynmkt_profileid"></a> msdynmkt_profileid

|Property|Value|
|---|---|
|Description|**ID of profile associated with SMS submission.**|
|DisplayName|**Profile ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_profileid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdynmkt_profiletype"></a> msdynmkt_profiletype

|Property|Value|
|---|---|
|Description|**Type of profile associated with SMS submission.**|
|DisplayName|**Profile Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_profiletype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_smssubmissionId"></a> msdynmkt_smssubmissionId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Sms submission ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_smssubmissionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_text"></a> msdynmkt_text

|Property|Value|
|---|---|
|Description|**Submission text**|
|DisplayName|**Submission text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_text`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_trackingcontextid"></a> msdynmkt_trackingcontextid

|Property|Value|
|---|---|
|Description|**Identifier of the tracking context.**|
|DisplayName|**Tracking Context ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_trackingcontextid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_trackingcontext|

### <a name="BKMK_msdynmkt_trackingcontextidPId"></a> msdynmkt_trackingcontextidPId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_trackingcontextidpid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_usercontactpoint"></a> msdynmkt_usercontactpoint

|Property|Value|
|---|---|
|Description|**Contact point from the user side**|
|DisplayName|**Contact point from the user side**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_usercontactpoint`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

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

### <a name="BKMK_PartitionId"></a> PartitionId

|Property|Value|
|---|---|
|Description|**Logical partition id. A logical partition consists of a set of records with same partition id.**|
|DisplayName|**Partition Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`partitionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_TTLInSeconds"></a> TTLInSeconds

|Property|Value|
|---|---|
|Description|**Time to live in seconds.**|
|DisplayName|**Time to live**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ttlinseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|


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

- [lk_msdynmkt_smssubmission_createdby](#BKMK_lk_msdynmkt_smssubmission_createdby)
- [lk_msdynmkt_smssubmission_createdonbehalfby](#BKMK_lk_msdynmkt_smssubmission_createdonbehalfby)
- [lk_msdynmkt_smssubmission_modifiedby](#BKMK_lk_msdynmkt_smssubmission_modifiedby)
- [lk_msdynmkt_smssubmission_modifiedonbehalfby](#BKMK_lk_msdynmkt_smssubmission_modifiedonbehalfby)
- [msdynmkt_msdynmkt_trackingcontext_msdynmkt_smssubmission](#BKMK_msdynmkt_msdynmkt_trackingcontext_msdynmkt_smssubmission)

### <a name="BKMK_lk_msdynmkt_smssubmission_createdby"></a> lk_msdynmkt_smssubmission_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_smssubmission_createdby](systemuser.md#BKMK_lk_msdynmkt_smssubmission_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_smssubmission_createdonbehalfby"></a> lk_msdynmkt_smssubmission_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_smssubmission_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_smssubmission_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_smssubmission_modifiedby"></a> lk_msdynmkt_smssubmission_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_smssubmission_modifiedby](systemuser.md#BKMK_lk_msdynmkt_smssubmission_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_smssubmission_modifiedonbehalfby"></a> lk_msdynmkt_smssubmission_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_smssubmission_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_smssubmission_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_trackingcontext_msdynmkt_smssubmission"></a> msdynmkt_msdynmkt_trackingcontext_msdynmkt_smssubmission

One-To-Many Relationship: [msdynmkt_trackingcontext msdynmkt_msdynmkt_trackingcontext_msdynmkt_smssubmission](msdynmkt_trackingcontext.md#BKMK_msdynmkt_msdynmkt_trackingcontext_msdynmkt_smssubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_trackingcontext`|
|ReferencedAttribute|`msdynmkt_trackingcontextid`|
|ReferencingAttribute|`msdynmkt_trackingcontextid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_trackingcontextid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

