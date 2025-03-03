---
title: "Microsoft Teams Collaboration entity (msdyn_TeamsCollaboration) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Microsoft Teams Collaboration entity (msdyn_TeamsCollaboration) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Microsoft Teams Collaboration entity (msdyn_TeamsCollaboration) table/entity reference (Microsoft Dynamics 365)

Entity which stores collaboration data of Dynamics 365 with Microsoft Teams

## Messages

The following table lists the messages for the Microsoft Teams Collaboration entity (msdyn_TeamsCollaboration) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_teamscollaborations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `Delete`<br />Event: True |`DELETE` /msdyn_teamscollaborations(*msdyn_teamscollaborationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_teamscollaborations(*msdyn_teamscollaborationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_teamscollaborations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_teamscollaborations(*msdyn_teamscollaborationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `Upsert`<br />Event: False |`PATCH` /msdyn_teamscollaborations(*msdyn_teamscollaborationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Microsoft Teams Collaboration entity (msdyn_TeamsCollaboration) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Microsoft Teams Collaboration entity** |
| **DisplayCollectionName** | **Microsoft Teams Collaboration entities** |
| **SchemaName** | `msdyn_TeamsCollaboration` |
| **CollectionSchemaName** | `msdyn_TeamsCollaborations` |
| **EntitySetName** | `msdyn_teamscollaborations`|
| **LogicalName** | `msdyn_teamscollaboration` |
| **LogicalCollectionName** | `msdyn_teamscollaborations` |
| **PrimaryIdAttribute** | `msdyn_teamscollaborationid` |
| **PrimaryNameAttribute** |`msdyn_teamname` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AppId](#BKMK_msdyn_AppId)
- [msdyn_ChannelFolderRelativeUrl](#BKMK_msdyn_ChannelFolderRelativeUrl)
- [msdyn_ChannelId](#BKMK_msdyn_ChannelId)
- [msdyn_ChannelName](#BKMK_msdyn_ChannelName)
- [msdyn_channelType](#BKMK_msdyn_channelType)
- [msdyn_ContentUrl](#BKMK_msdyn_ContentUrl)
- [msdyn_GroupId](#BKMK_msdyn_GroupId)
- [msdyn_pipedEntityId](#BKMK_msdyn_pipedEntityId)
- [msdyn_TeamId](#BKMK_msdyn_TeamId)
- [msdyn_TeamName](#BKMK_msdyn_TeamName)
- [msdyn_TeamsCollaborationId](#BKMK_msdyn_TeamsCollaborationId)
- [msdyn_TeamSiteUrl](#BKMK_msdyn_TeamSiteUrl)
- [msdyn_TenantId](#BKMK_msdyn_TenantId)
- [msdyn_WebUrl](#BKMK_msdyn_WebUrl)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [RegardingObjectTypeName](#BKMK_RegardingObjectTypeName)
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

### <a name="BKMK_msdyn_AppId"></a> msdyn_AppId

|Property|Value|
|---|---|
|Description|**Collaboration appid which was used to pin the record**|
|DisplayName|**Collaboration app id  which was used to pin the record**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_appid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ChannelFolderRelativeUrl"></a> msdyn_ChannelFolderRelativeUrl

|Property|Value|
|---|---|
|Description|**Collaboration channel relative folder URL**|
|DisplayName|**Collaboration Channel Relative Folder URL**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_channelfolderrelativeurl`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_ChannelId"></a> msdyn_ChannelId

|Property|Value|
|---|---|
|Description|**Collaboration channel Id**|
|DisplayName|**Collaboration channel ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_channelid`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ChannelName"></a> msdyn_ChannelName

|Property|Value|
|---|---|
|Description|**Collaboration channel name**|
|DisplayName|**Collaboration Channel Name**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_channelname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_channelType"></a> msdyn_channelType

|Property|Value|
|---|---|
|Description|**Collaboration Channel Type required to differentiate between private and other channels**|
|DisplayName|**Collaboration Channel Type(Private, etc)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_channeltype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10|

### <a name="BKMK_msdyn_ContentUrl"></a> msdyn_ContentUrl

|Property|Value|
|---|---|
|Description|**Collaboration tab content url**|
|DisplayName|**Collaboration tab content url**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_contenturl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_GroupId"></a> msdyn_GroupId

|Property|Value|
|---|---|
|Description|**Collaboration group identifier**|
|DisplayName|**Collaboration Group Identifier**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_groupid`|
|RequiredLevel|ApplicationRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_pipedEntityId"></a> msdyn_pipedEntityId

|Property|Value|
|---|---|
|Description|**Collaboration piped entity which was used to pin the record**|
|DisplayName|**Collaboration piped entity id  which was used to pin the record**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_pipedentityid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|800|

### <a name="BKMK_msdyn_TeamId"></a> msdyn_TeamId

|Property|Value|
|---|---|
|Description|**Collaboration team Id**|
|DisplayName|**Collaboration Team ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_teamid`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_TeamName"></a> msdyn_TeamName

|Property|Value|
|---|---|
|Description|**Collaboration team name**|
|DisplayName|**Collaboration Team Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_teamname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_TeamsCollaborationId"></a> msdyn_TeamsCollaborationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Teams Collaboration Identifier**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_teamscollaborationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_TeamSiteUrl"></a> msdyn_TeamSiteUrl

|Property|Value|
|---|---|
|Description|**Team site URL**|
|DisplayName|**Team Site URL**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_teamsiteurl`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_TenantId"></a> msdyn_TenantId

|Property|Value|
|---|---|
|Description|**Collaboration tenant identifier**|
|DisplayName|**Collaboration Tenant Identifier**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_tenantid`|
|RequiredLevel|ApplicationRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_WebUrl"></a> msdyn_WebUrl

|Property|Value|
|---|---|
|Description|**Collaboration tab web url**|
|DisplayName|**Collaboration tab web url**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_weburl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|---|---|
|Description|**Related Dynamics 365 record Id**|
|DisplayName|**Related Dynamics 365 Record ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`regardingobjectid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

|Property|Value|
|---|---|
|Description|**Related Dynamics 365 record Id (entity code)**|
|DisplayName|**Related Dynamics 365 Record ID (Entity Code)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`regardingobjecttypecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_RegardingObjectTypeName"></a> RegardingObjectTypeName

|Property|Value|
|---|---|
|Description|**Related Dynamics 365 record type name**|
|DisplayName|**Related Dynamics 365 Record Type Name**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`regardingobjecttypename`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Collaboration entity**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_teamscollaboration_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Collaboration entity**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_teamscollaboration_statuscode`|

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
|DisplayName|**Organization ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets||

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

- [lk_msdyn_teamscollaboration_createdby](#BKMK_lk_msdyn_teamscollaboration_createdby)
- [lk_msdyn_teamscollaboration_createdonbehalfby](#BKMK_lk_msdyn_teamscollaboration_createdonbehalfby)
- [lk_msdyn_teamscollaboration_modifiedby](#BKMK_lk_msdyn_teamscollaboration_modifiedby)
- [lk_msdyn_teamscollaboration_modifiedonbehalfby](#BKMK_lk_msdyn_teamscollaboration_modifiedonbehalfby)

### <a name="BKMK_lk_msdyn_teamscollaboration_createdby"></a> lk_msdyn_teamscollaboration_createdby

One-To-Many Relationship: [systemuser lk_msdyn_teamscollaboration_createdby](systemuser.md#BKMK_lk_msdyn_teamscollaboration_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_teamscollaboration_createdonbehalfby"></a> lk_msdyn_teamscollaboration_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_teamscollaboration_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_teamscollaboration_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_teamscollaboration_modifiedby"></a> lk_msdyn_teamscollaboration_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_teamscollaboration_modifiedby](systemuser.md#BKMK_lk_msdyn_teamscollaboration_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_teamscollaboration_modifiedonbehalfby"></a> lk_msdyn_teamscollaboration_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_teamscollaboration_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_teamscollaboration_modifiedonbehalfby)

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

- [msdyn_teamscollaboration_AsyncOperations](#BKMK_msdyn_teamscollaboration_AsyncOperations)
- [msdyn_teamscollaboration_BulkDeleteFailures](#BKMK_msdyn_teamscollaboration_BulkDeleteFailures)
- [msdyn_teamscollaboration_MailboxTrackingFolders](#BKMK_msdyn_teamscollaboration_MailboxTrackingFolders)
- [msdyn_teamscollaboration_PrincipalObjectAttributeAccesses](#BKMK_msdyn_teamscollaboration_PrincipalObjectAttributeAccesses)
- [msdyn_teamscollaboration_ProcessSession](#BKMK_msdyn_teamscollaboration_ProcessSession)
- [msdyn_teamscollaboration_SyncErrors](#BKMK_msdyn_teamscollaboration_SyncErrors)

### <a name="BKMK_msdyn_teamscollaboration_AsyncOperations"></a> msdyn_teamscollaboration_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_teamscollaboration_AsyncOperations](asyncoperation.md#BKMK_msdyn_teamscollaboration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_teamscollaboration_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_teamscollaboration_BulkDeleteFailures"></a> msdyn_teamscollaboration_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_teamscollaboration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_teamscollaboration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_teamscollaboration_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_teamscollaboration_MailboxTrackingFolders"></a> msdyn_teamscollaboration_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_teamscollaboration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_teamscollaboration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_teamscollaboration_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_teamscollaboration_PrincipalObjectAttributeAccesses"></a> msdyn_teamscollaboration_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_teamscollaboration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_teamscollaboration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_teamscollaboration_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_teamscollaboration_ProcessSession"></a> msdyn_teamscollaboration_ProcessSession

Many-To-One Relationship: [processsession msdyn_teamscollaboration_ProcessSession](processsession.md#BKMK_msdyn_teamscollaboration_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_teamscollaboration_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_teamscollaboration_SyncErrors"></a> msdyn_teamscollaboration_SyncErrors

Many-To-One Relationship: [syncerror msdyn_teamscollaboration_SyncErrors](syncerror.md#BKMK_msdyn_teamscollaboration_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_teamscollaboration_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

