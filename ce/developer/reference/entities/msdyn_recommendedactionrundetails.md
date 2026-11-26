---
title: "recommendedactionrundetails (msdyn_recommendedactionrundetails) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the recommendedactionrundetails (msdyn_recommendedactionrundetails) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# recommendedactionrundetails (msdyn_recommendedactionrundetails) table/entity reference (Microsoft Dynamics 365)

Stores execution run details for recommended actions.

## Messages

The following table lists the messages for the recommendedactionrundetails (msdyn_recommendedactionrundetails) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_recommendedactionrundetailses<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_recommendedactionrundetailses(*msdyn_recommendedactionrundetailsid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_recommendedactionrundetailses(*msdyn_recommendedactionrundetailsid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_recommendedactionrundetailses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_recommendedactionrundetailses(*msdyn_recommendedactionrundetailsid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_recommendedactionrundetailses(*msdyn_recommendedactionrundetailsid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_recommendedactionrundetailses(*msdyn_recommendedactionrundetailsid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the recommendedactionrundetails (msdyn_recommendedactionrundetails) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **recommendedactionrundetails** |
| **DisplayCollectionName** | **recommendedactionrundetails** |
| **SchemaName** | `msdyn_recommendedactionrundetails` |
| **CollectionSchemaName** | `msdyn_recommendedactionrundetailses` |
| **EntitySetName** | `msdyn_recommendedactionrundetailses`|
| **LogicalName** | `msdyn_recommendedactionrundetails` |
| **LogicalCollectionName** | `msdyn_recommendedactionrundetailses` |
| **PrimaryIdAttribute** | `msdyn_recommendedactionrundetailsid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_actionid](#BKMK_msdyn_actionid)
- [msdyn_executiondetails](#BKMK_msdyn_executiondetails)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_rawactioncatalogueId](#BKMK_msdyn_rawactioncatalogueId)
- [msdyn_recommendedactionrundetailsId](#BKMK_msdyn_recommendedactionrundetailsId)
- [msdyn_retryafter](#BKMK_msdyn_retryafter)
- [msdyn_sourceagentconfigid](#BKMK_msdyn_sourceagentconfigid)
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

### <a name="BKMK_msdyn_actionid"></a> msdyn_actionid

|Property|Value|
|---|---|
|Description|**Identifier of the action this run detail is associated with, used for pull-mode identity.**|
|DisplayName|**Action Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_executiondetails"></a> msdyn_executiondetails

|Property|Value|
|---|---|
|Description|**Details of the action execution run.**|
|DisplayName|**Execution Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_executiondetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Name of the recommended action run details record.**|
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
|MaxLength|850|

### <a name="BKMK_msdyn_rawactioncatalogueId"></a> msdyn_rawactioncatalogueId

|Property|Value|
|---|---|
|Description|**Lookup to the raw action catalogue record this run detail is associated with.**|
|DisplayName|**Raw Action Catalogue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rawactioncatalogueid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_rawactioncatalogue|

### <a name="BKMK_msdyn_recommendedactionrundetailsId"></a> msdyn_recommendedactionrundetailsId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**RecommendedActionRunDetails**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_recommendedactionrundetailsid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_retryafter"></a> msdyn_retryafter

|Property|Value|
|---|---|
|Description|**The date and time after which the action execution should be retried.**|
|DisplayName|**Retry After**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_retryafter`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_sourceagentconfigid"></a> msdyn_sourceagentconfigid

|Property|Value|
|---|---|
|Description|**Lookup to the source agent configuration record associated with this run detail.**|
|DisplayName|**Source Agent Config**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sourceagentconfigid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_recommendedactionsourceagentconfig|

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
|Description|**Status of the Recommended Action Run Details**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_recommendedactionrundetails_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 7<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Recommended Action Run Details**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_recommendedactionrundetails_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **NotStarted**<br />State:0<br />TransitionData: None|
|2|Label: **InProgress**<br />State:0<br />TransitionData: None|
|3|Label: **Completed**<br />State:0<br />TransitionData: None|
|4|Label: **PendingRefresh**<br />State:0<br />TransitionData: None|
|5|Label: **PendingRetry**<br />State:0<br />TransitionData: None|
|6|Label: **Failed**<br />State:1<br />TransitionData: None|
|7|Label: **Inactive**<br />State:1<br />TransitionData: None|

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

- [lk_msdyn_recommendedactionrundetails_createdby](#BKMK_lk_msdyn_recommendedactionrundetails_createdby)
- [lk_msdyn_recommendedactionrundetails_createdonbehalfby](#BKMK_lk_msdyn_recommendedactionrundetails_createdonbehalfby)
- [lk_msdyn_recommendedactionrundetails_modifiedby](#BKMK_lk_msdyn_recommendedactionrundetails_modifiedby)
- [lk_msdyn_recommendedactionrundetails_modifiedonbehalfby](#BKMK_lk_msdyn_recommendedactionrundetails_modifiedonbehalfby)
- [msdyn_recommendedactionrundetails_msdyn_rawactioncatalogue](#BKMK_msdyn_recommendedactionrundetails_msdyn_rawactioncatalogue)
- [msdyn_recommendedactionrundetails_msdyn_recommendedactionsourceagentconfig](#BKMK_msdyn_recommendedactionrundetails_msdyn_recommendedactionsourceagentconfig)
- [organization_msdyn_recommendedactionrundetails](#BKMK_organization_msdyn_recommendedactionrundetails)

### <a name="BKMK_lk_msdyn_recommendedactionrundetails_createdby"></a> lk_msdyn_recommendedactionrundetails_createdby

One-To-Many Relationship: [systemuser lk_msdyn_recommendedactionrundetails_createdby](systemuser.md#BKMK_lk_msdyn_recommendedactionrundetails_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_recommendedactionrundetails_createdonbehalfby"></a> lk_msdyn_recommendedactionrundetails_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_recommendedactionrundetails_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_recommendedactionrundetails_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_recommendedactionrundetails_modifiedby"></a> lk_msdyn_recommendedactionrundetails_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_recommendedactionrundetails_modifiedby](systemuser.md#BKMK_lk_msdyn_recommendedactionrundetails_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_recommendedactionrundetails_modifiedonbehalfby"></a> lk_msdyn_recommendedactionrundetails_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_recommendedactionrundetails_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_recommendedactionrundetails_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_recommendedactionrundetails_msdyn_rawactioncatalogue"></a> msdyn_recommendedactionrundetails_msdyn_rawactioncatalogue

One-To-Many Relationship: [msdyn_rawactioncatalogue msdyn_recommendedactionrundetails_msdyn_rawactioncatalogue](msdyn_rawactioncatalogue.md#BKMK_msdyn_recommendedactionrundetails_msdyn_rawactioncatalogue)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rawactioncatalogue`|
|ReferencedAttribute|`msdyn_rawactioncatalogueid`|
|ReferencingAttribute|`msdyn_rawactioncatalogueid`|
|ReferencingEntityNavigationPropertyName|`msdyn_rawactioncatalogueid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_recommendedactionrundetails_msdyn_recommendedactionsourceagentconfig"></a> msdyn_recommendedactionrundetails_msdyn_recommendedactionsourceagentconfig

One-To-Many Relationship: [msdyn_recommendedactionsourceagentconfig msdyn_recommendedactionrundetails_msdyn_recommendedactionsourceagentconfig](msdyn_recommendedactionsourceagentconfig.md#BKMK_msdyn_recommendedactionrundetails_msdyn_recommendedactionsourceagentconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_recommendedactionsourceagentconfig`|
|ReferencedAttribute|`msdyn_recommendedactionsourceagentconfigid`|
|ReferencingAttribute|`msdyn_sourceagentconfigid`|
|ReferencingEntityNavigationPropertyName|`msdyn_sourceagentconfigid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_recommendedactionrundetails"></a> organization_msdyn_recommendedactionrundetails

One-To-Many Relationship: [organization organization_msdyn_recommendedactionrundetails](organization.md#BKMK_organization_msdyn_recommendedactionrundetails)

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

- [msdyn_recommendedactionrundetails_AsyncOperations](#BKMK_msdyn_recommendedactionrundetails_AsyncOperations)
- [msdyn_recommendedactionrundetails_BulkDeleteFailures](#BKMK_msdyn_recommendedactionrundetails_BulkDeleteFailures)
- [msdyn_recommendedactionrundetails_DuplicateBaseRecord](#BKMK_msdyn_recommendedactionrundetails_DuplicateBaseRecord)
- [msdyn_recommendedactionrundetails_DuplicateMatchingRecord](#BKMK_msdyn_recommendedactionrundetails_DuplicateMatchingRecord)
- [msdyn_recommendedactionrundetails_MailboxTrackingFolders](#BKMK_msdyn_recommendedactionrundetails_MailboxTrackingFolders)
- [msdyn_recommendedactionrundetails_PrincipalObjectAttributeAccesses](#BKMK_msdyn_recommendedactionrundetails_PrincipalObjectAttributeAccesses)
- [msdyn_recommendedactionrundetails_ProcessSession](#BKMK_msdyn_recommendedactionrundetails_ProcessSession)
- [msdyn_recommendedactionrundetails_SyncErrors](#BKMK_msdyn_recommendedactionrundetails_SyncErrors)

### <a name="BKMK_msdyn_recommendedactionrundetails_AsyncOperations"></a> msdyn_recommendedactionrundetails_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_recommendedactionrundetails_AsyncOperations](asyncoperation.md#BKMK_msdyn_recommendedactionrundetails_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_recommendedactionrundetails_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_recommendedactionrundetails_BulkDeleteFailures"></a> msdyn_recommendedactionrundetails_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_recommendedactionrundetails_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_recommendedactionrundetails_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_recommendedactionrundetails_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_recommendedactionrundetails_DuplicateBaseRecord"></a> msdyn_recommendedactionrundetails_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_recommendedactionrundetails_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_recommendedactionrundetails_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_recommendedactionrundetails_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_recommendedactionrundetails_DuplicateMatchingRecord"></a> msdyn_recommendedactionrundetails_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_recommendedactionrundetails_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_recommendedactionrundetails_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_recommendedactionrundetails_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_recommendedactionrundetails_MailboxTrackingFolders"></a> msdyn_recommendedactionrundetails_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_recommendedactionrundetails_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_recommendedactionrundetails_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_recommendedactionrundetails_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_recommendedactionrundetails_PrincipalObjectAttributeAccesses"></a> msdyn_recommendedactionrundetails_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_recommendedactionrundetails_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_recommendedactionrundetails_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_recommendedactionrundetails_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_recommendedactionrundetails_ProcessSession"></a> msdyn_recommendedactionrundetails_ProcessSession

Many-To-One Relationship: [processsession msdyn_recommendedactionrundetails_ProcessSession](processsession.md#BKMK_msdyn_recommendedactionrundetails_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_recommendedactionrundetails_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_recommendedactionrundetails_SyncErrors"></a> msdyn_recommendedactionrundetails_SyncErrors

Many-To-One Relationship: [syncerror msdyn_recommendedactionrundetails_SyncErrors](syncerror.md#BKMK_msdyn_recommendedactionrundetails_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_recommendedactionrundetails_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

