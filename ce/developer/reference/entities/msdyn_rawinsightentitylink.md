---
title: "msdyn_rawinsightentitylink table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the msdyn_rawinsightentitylink table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# msdyn_rawinsightentitylink table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the msdyn_rawinsightentitylink table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_rawinsightentitylinks<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_rawinsightentitylinks(*msdyn_rawinsightentitylinkid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_rawinsightentitylinks(*msdyn_rawinsightentitylinkid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_rawinsightentitylinks<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_rawinsightentitylinks(*msdyn_rawinsightentitylinkid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_rawinsightentitylinks(*msdyn_rawinsightentitylinkid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_rawinsightentitylinks(*msdyn_rawinsightentitylinkid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the msdyn_rawinsightentitylink table.

|Property|Value|
| --- | --- |
| **DisplayName** | **msdyn_rawinsightentitylink** |
| **DisplayCollectionName** | **msdyn_rawinsightentitylinks** |
| **SchemaName** | `msdyn_rawinsightentitylink` |
| **CollectionSchemaName** | `msdyn_rawinsightentitylinks` |
| **EntitySetName** | `msdyn_rawinsightentitylinks`|
| **LogicalName** | `msdyn_rawinsightentitylink` |
| **LogicalCollectionName** | `msdyn_rawinsightentitylinks` |
| **PrimaryIdAttribute** | `msdyn_rawinsightentitylinkid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_crmactivityid](#BKMK_msdyn_crmactivityid)
- [msdyn_externalcrmorgid](#BKMK_msdyn_externalcrmorgid)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_rawinsightentitylinkconfirmedby](#BKMK_msdyn_rawinsightentitylinkconfirmedby)
- [msdyn_rawinsightentitylinkId](#BKMK_msdyn_rawinsightentitylinkId)
- [msdyn_rawinsightsourcegroupid](#BKMK_msdyn_rawinsightsourcegroupid)
- [msdyn_rawinsightsourceid](#BKMK_msdyn_rawinsightsourceid)
- [msdyn_rawinsightsourcetype](#BKMK_msdyn_rawinsightsourcetype)
- [msdyn_regardingentityid](#BKMK_msdyn_regardingentityid)
- [msdyn_regardingentitytype](#BKMK_msdyn_regardingentitytype)
- [msdyn_relevancescore](#BKMK_msdyn_relevancescore)
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

### <a name="BKMK_msdyn_crmactivityid"></a> msdyn_crmactivityid

|Property|Value|
|---|---|
|Description|**Unique identifier for the corresponding CRM activity**|
|DisplayName|**msdyn_crmactivityid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_crmactivityid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_externalcrmorgid"></a> msdyn_externalcrmorgid

|Property|Value|
|---|---|
|Description|**Unique identifier of External CRM organization.**|
|DisplayName|**msdyn_externalcrmorgid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_externalcrmorgid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description||
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

### <a name="BKMK_msdyn_rawinsightentitylinkconfirmedby"></a> msdyn_rawinsightentitylinkconfirmedby

|Property|Value|
|---|---|
|Description|**Identifier of the source that confirmed the matched link**|
|DisplayName|**msdyn_rawinsightentitylinkconfirmedby**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rawinsightentitylinkconfirmedby`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_rawinsightentitylinkId"></a> msdyn_rawinsightentitylinkId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**msdyn_rawinsightentitylinkid**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_rawinsightentitylinkid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_rawinsightsourcegroupid"></a> msdyn_rawinsightsourcegroupid

|Property|Value|
|---|---|
|Description|**Unique id of the source group (e.g: Email thread id) used to generate rawinsight**|
|DisplayName|**msdyn_rawinsightsourcegroupid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rawinsightsourcegroupid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_rawinsightsourceid"></a> msdyn_rawinsightsourceid

|Property|Value|
|---|---|
|Description|**unique identifier of the rawinsight source**|
|DisplayName|**msdyn_rawinsightsourceid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rawinsightsourceid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_rawinsightsourcetype"></a> msdyn_rawinsightsourcetype

|Property|Value|
|---|---|
|Description|**Type of the source used to generate rawinsight**|
|DisplayName|**msdyn_rawinsightsourcetype**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rawinsightsourcetype`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_regardingentityid"></a> msdyn_regardingentityid

|Property|Value|
|---|---|
|Description|**Unique identifier of the related entity**|
|DisplayName|**regardingentityid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingentityid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_regardingentitytype"></a> msdyn_regardingentitytype

|Property|Value|
|---|---|
|Description|**Type of the related entity**|
|DisplayName|**regardingentitytype**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingentitytype`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_relevancescore"></a> msdyn_relevancescore

|Property|Value|
|---|---|
|Description|**Relevance Score**|
|DisplayName|**relevancescore**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relevancescore`|
|RequiredLevel|ApplicationRequired|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|

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
|Description|**Status of the AI Matched Activity**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_rawinsightentitylink_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the AI Matched Activity**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_rawinsightentitylink_statuscode`|

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
|DisplayName|**Created By**|
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

- [lk_msdyn_rawinsightentitylink_createdby](#BKMK_lk_msdyn_rawinsightentitylink_createdby)
- [lk_msdyn_rawinsightentitylink_createdonbehalfby](#BKMK_lk_msdyn_rawinsightentitylink_createdonbehalfby)
- [lk_msdyn_rawinsightentitylink_modifiedby](#BKMK_lk_msdyn_rawinsightentitylink_modifiedby)
- [lk_msdyn_rawinsightentitylink_modifiedonbehalfby](#BKMK_lk_msdyn_rawinsightentitylink_modifiedonbehalfby)
- [organization_msdyn_rawinsightentitylink](#BKMK_organization_msdyn_rawinsightentitylink)

### <a name="BKMK_lk_msdyn_rawinsightentitylink_createdby"></a> lk_msdyn_rawinsightentitylink_createdby

One-To-Many Relationship: [systemuser lk_msdyn_rawinsightentitylink_createdby](systemuser.md#BKMK_lk_msdyn_rawinsightentitylink_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_rawinsightentitylink_createdonbehalfby"></a> lk_msdyn_rawinsightentitylink_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_rawinsightentitylink_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_rawinsightentitylink_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_rawinsightentitylink_modifiedby"></a> lk_msdyn_rawinsightentitylink_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_rawinsightentitylink_modifiedby](systemuser.md#BKMK_lk_msdyn_rawinsightentitylink_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_rawinsightentitylink_modifiedonbehalfby"></a> lk_msdyn_rawinsightentitylink_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_rawinsightentitylink_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_rawinsightentitylink_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_rawinsightentitylink"></a> organization_msdyn_rawinsightentitylink

One-To-Many Relationship: [organization organization_msdyn_rawinsightentitylink](organization.md#BKMK_organization_msdyn_rawinsightentitylink)

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

- [msdyn_rawinsightentitylink_AsyncOperations](#BKMK_msdyn_rawinsightentitylink_AsyncOperations)
- [msdyn_rawinsightentitylink_BulkDeleteFailures](#BKMK_msdyn_rawinsightentitylink_BulkDeleteFailures)
- [msdyn_rawinsightentitylink_DuplicateBaseRecord](#BKMK_msdyn_rawinsightentitylink_DuplicateBaseRecord)
- [msdyn_rawinsightentitylink_DuplicateMatchingRecord](#BKMK_msdyn_rawinsightentitylink_DuplicateMatchingRecord)
- [msdyn_rawinsightentitylink_MailboxTrackingFolders](#BKMK_msdyn_rawinsightentitylink_MailboxTrackingFolders)
- [msdyn_rawinsightentitylink_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rawinsightentitylink_PrincipalObjectAttributeAccesses)
- [msdyn_rawinsightentitylink_ProcessSession](#BKMK_msdyn_rawinsightentitylink_ProcessSession)
- [msdyn_rawinsightentitylink_SyncErrors](#BKMK_msdyn_rawinsightentitylink_SyncErrors)

### <a name="BKMK_msdyn_rawinsightentitylink_AsyncOperations"></a> msdyn_rawinsightentitylink_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_rawinsightentitylink_AsyncOperations](asyncoperation.md#BKMK_msdyn_rawinsightentitylink_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rawinsightentitylink_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rawinsightentitylink_BulkDeleteFailures"></a> msdyn_rawinsightentitylink_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_rawinsightentitylink_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_rawinsightentitylink_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rawinsightentitylink_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rawinsightentitylink_DuplicateBaseRecord"></a> msdyn_rawinsightentitylink_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_rawinsightentitylink_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_rawinsightentitylink_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rawinsightentitylink_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rawinsightentitylink_DuplicateMatchingRecord"></a> msdyn_rawinsightentitylink_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_rawinsightentitylink_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_rawinsightentitylink_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rawinsightentitylink_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rawinsightentitylink_MailboxTrackingFolders"></a> msdyn_rawinsightentitylink_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_rawinsightentitylink_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_rawinsightentitylink_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rawinsightentitylink_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rawinsightentitylink_PrincipalObjectAttributeAccesses"></a> msdyn_rawinsightentitylink_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_rawinsightentitylink_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_rawinsightentitylink_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rawinsightentitylink_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rawinsightentitylink_ProcessSession"></a> msdyn_rawinsightentitylink_ProcessSession

Many-To-One Relationship: [processsession msdyn_rawinsightentitylink_ProcessSession](processsession.md#BKMK_msdyn_rawinsightentitylink_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rawinsightentitylink_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rawinsightentitylink_SyncErrors"></a> msdyn_rawinsightentitylink_SyncErrors

Many-To-One Relationship: [syncerror msdyn_rawinsightentitylink_SyncErrors](syncerror.md#BKMK_msdyn_rawinsightentitylink_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rawinsightentitylink_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

