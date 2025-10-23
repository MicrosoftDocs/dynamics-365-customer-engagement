---
title: "salesroutingdiagnostic (msdyn_salesroutingdiagnostic) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the salesroutingdiagnostic (msdyn_salesroutingdiagnostic) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# salesroutingdiagnostic (msdyn_salesroutingdiagnostic) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the salesroutingdiagnostic (msdyn_salesroutingdiagnostic) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_salesroutingdiagnostics<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_salesroutingdiagnostics(*msdyn_salesroutingdiagnosticid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_salesroutingdiagnostics(*msdyn_salesroutingdiagnosticid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_salesroutingdiagnostics<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_salesroutingdiagnostics(*msdyn_salesroutingdiagnosticid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_salesroutingdiagnostics(*msdyn_salesroutingdiagnosticid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_salesroutingdiagnostics(*msdyn_salesroutingdiagnosticid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the salesroutingdiagnostic (msdyn_salesroutingdiagnostic) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **salesroutingdiagnostic** |
| **DisplayCollectionName** | **salesroutingdiagnostics** |
| **SchemaName** | `msdyn_salesroutingdiagnostic` |
| **CollectionSchemaName** | `msdyn_salesroutingdiagnostics` |
| **EntitySetName** | `msdyn_salesroutingdiagnostics`|
| **LogicalName** | `msdyn_salesroutingdiagnostic` |
| **LogicalCollectionName** | `msdyn_salesroutingdiagnostics` |
| **PrimaryIdAttribute** | `msdyn_salesroutingdiagnosticid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_connectsequencehistory](#BKMK_msdyn_connectsequencehistory)
- [msdyn_latestconnectsequence](#BKMK_msdyn_latestconnectsequence)
- [msdyn_latestrouting](#BKMK_msdyn_latestrouting)
- [msdyn_latestsegmentation](#BKMK_msdyn_latestsegmentation)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_objecttype](#BKMK_msdyn_objecttype)
- [msdyn_recordid](#BKMK_msdyn_recordid)
- [msdyn_routinghistory](#BKMK_msdyn_routinghistory)
- [msdyn_salesroutingdiagnosticId](#BKMK_msdyn_salesroutingdiagnosticId)
- [msdyn_segmentationhistory](#BKMK_msdyn_segmentationhistory)
- [msdyn_segmentmoved](#BKMK_msdyn_segmentmoved)
- [msdyn_target](#BKMK_msdyn_target)
- [msdyn_targetIdType](#BKMK_msdyn_targetIdType)
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

### <a name="BKMK_msdyn_connectsequencehistory"></a> msdyn_connectsequencehistory

|Property|Value|
|---|---|
|Description||
|DisplayName|**Connect sequence history**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_connectsequencehistory`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_latestconnectsequence"></a> msdyn_latestconnectsequence

|Property|Value|
|---|---|
|Description||
|DisplayName|**Latest connect sequence**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_latestconnectsequence`|
|RequiredLevel|None|
|Type|String|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_latestrouting"></a> msdyn_latestrouting

|Property|Value|
|---|---|
|Description||
|DisplayName|**Latest routing**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_latestrouting`|
|RequiredLevel|None|
|Type|String|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_latestsegmentation"></a> msdyn_latestsegmentation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Latest segmentation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_latestsegmentation`|
|RequiredLevel|None|
|Type|String|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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

### <a name="BKMK_msdyn_objecttype"></a> msdyn_objecttype

|Property|Value|
|---|---|
|Description||
|DisplayName|**objecttype**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_objecttype`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_recordid"></a> msdyn_recordid

|Property|Value|
|---|---|
|Description||
|DisplayName|**recordid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recordid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_routinghistory"></a> msdyn_routinghistory

|Property|Value|
|---|---|
|Description||
|DisplayName|**Routing history**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_routinghistory`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_salesroutingdiagnosticId"></a> msdyn_salesroutingdiagnosticId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**salesroutingdiagnostic**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_salesroutingdiagnosticid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_segmentationhistory"></a> msdyn_segmentationhistory

|Property|Value|
|---|---|
|Description||
|DisplayName|**Segmentation history**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_segmentationhistory`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_segmentmoved"></a> msdyn_segmentmoved

|Property|Value|
|---|---|
|Description||
|DisplayName|**segmentmoved**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_segmentmoved`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_salesroutingdiagnostic_msdyn_segmentmoved`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_target"></a> msdyn_target

|Property|Value|
|---|---|
|Description||
|DisplayName|**target**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_target`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account, contact, lead, opportunity|

### <a name="BKMK_msdyn_targetIdType"></a> msdyn_targetIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_targetidtype`|
|RequiredLevel|None|
|Type|EntityName|

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
|Description|**Status of the salesroutingdiagnostic**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_salesroutingdiagnostic_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the salesroutingdiagnostic**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_salesroutingdiagnostic_statuscode`|

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

- [lk_msdyn_salesroutingdiagnostic_createdby](#BKMK_lk_msdyn_salesroutingdiagnostic_createdby)
- [lk_msdyn_salesroutingdiagnostic_createdonbehalfby](#BKMK_lk_msdyn_salesroutingdiagnostic_createdonbehalfby)
- [lk_msdyn_salesroutingdiagnostic_modifiedby](#BKMK_lk_msdyn_salesroutingdiagnostic_modifiedby)
- [lk_msdyn_salesroutingdiagnostic_modifiedonbehalfby](#BKMK_lk_msdyn_salesroutingdiagnostic_modifiedonbehalfby)
- [msdyn_salesroutingdiagnostic_account_msdyn_target](#BKMK_msdyn_salesroutingdiagnostic_account_msdyn_target)
- [msdyn_salesroutingdiagnostic_contact_msdyn_target](#BKMK_msdyn_salesroutingdiagnostic_contact_msdyn_target)
- [msdyn_salesroutingdiagnostic_lead_msdyn_target](#BKMK_msdyn_salesroutingdiagnostic_lead_msdyn_target)
- [msdyn_salesroutingdiagnostic_opportunity_msdyn_target](#BKMK_msdyn_salesroutingdiagnostic_opportunity_msdyn_target)
- [organization_msdyn_salesroutingdiagnostic](#BKMK_organization_msdyn_salesroutingdiagnostic)

### <a name="BKMK_lk_msdyn_salesroutingdiagnostic_createdby"></a> lk_msdyn_salesroutingdiagnostic_createdby

One-To-Many Relationship: [systemuser lk_msdyn_salesroutingdiagnostic_createdby](systemuser.md#BKMK_lk_msdyn_salesroutingdiagnostic_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesroutingdiagnostic_createdonbehalfby"></a> lk_msdyn_salesroutingdiagnostic_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_salesroutingdiagnostic_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_salesroutingdiagnostic_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesroutingdiagnostic_modifiedby"></a> lk_msdyn_salesroutingdiagnostic_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_salesroutingdiagnostic_modifiedby](systemuser.md#BKMK_lk_msdyn_salesroutingdiagnostic_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesroutingdiagnostic_modifiedonbehalfby"></a> lk_msdyn_salesroutingdiagnostic_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_salesroutingdiagnostic_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_salesroutingdiagnostic_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salesroutingdiagnostic_account_msdyn_target"></a> msdyn_salesroutingdiagnostic_account_msdyn_target

One-To-Many Relationship: [account msdyn_salesroutingdiagnostic_account_msdyn_target](account.md#BKMK_msdyn_salesroutingdiagnostic_account_msdyn_target)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_target`|
|ReferencingEntityNavigationPropertyName|`msdyn_target`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salesroutingdiagnostic_contact_msdyn_target"></a> msdyn_salesroutingdiagnostic_contact_msdyn_target

One-To-Many Relationship: [contact msdyn_salesroutingdiagnostic_contact_msdyn_target](contact.md#BKMK_msdyn_salesroutingdiagnostic_contact_msdyn_target)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyn_target`|
|ReferencingEntityNavigationPropertyName|`msdyn_target`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salesroutingdiagnostic_lead_msdyn_target"></a> msdyn_salesroutingdiagnostic_lead_msdyn_target

One-To-Many Relationship: [lead msdyn_salesroutingdiagnostic_lead_msdyn_target](lead.md#BKMK_msdyn_salesroutingdiagnostic_lead_msdyn_target)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`msdyn_target`|
|ReferencingEntityNavigationPropertyName|`msdyn_target`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salesroutingdiagnostic_opportunity_msdyn_target"></a> msdyn_salesroutingdiagnostic_opportunity_msdyn_target

One-To-Many Relationship: [opportunity msdyn_salesroutingdiagnostic_opportunity_msdyn_target](opportunity.md#BKMK_msdyn_salesroutingdiagnostic_opportunity_msdyn_target)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`msdyn_target`|
|ReferencingEntityNavigationPropertyName|`msdyn_target`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_salesroutingdiagnostic"></a> organization_msdyn_salesroutingdiagnostic

One-To-Many Relationship: [organization organization_msdyn_salesroutingdiagnostic](organization.md#BKMK_organization_msdyn_salesroutingdiagnostic)

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

- [msdyn_salesroutingdiagnostic_AsyncOperations](#BKMK_msdyn_salesroutingdiagnostic_AsyncOperations)
- [msdyn_salesroutingdiagnostic_BulkDeleteFailures](#BKMK_msdyn_salesroutingdiagnostic_BulkDeleteFailures)
- [msdyn_salesroutingdiagnostic_DuplicateBaseRecord](#BKMK_msdyn_salesroutingdiagnostic_DuplicateBaseRecord)
- [msdyn_salesroutingdiagnostic_DuplicateMatchingRecord](#BKMK_msdyn_salesroutingdiagnostic_DuplicateMatchingRecord)
- [msdyn_salesroutingdiagnostic_MailboxTrackingFolders](#BKMK_msdyn_salesroutingdiagnostic_MailboxTrackingFolders)
- [msdyn_salesroutingdiagnostic_PrincipalObjectAttributeAccesses](#BKMK_msdyn_salesroutingdiagnostic_PrincipalObjectAttributeAccesses)
- [msdyn_salesroutingdiagnostic_ProcessSession](#BKMK_msdyn_salesroutingdiagnostic_ProcessSession)
- [msdyn_salesroutingdiagnostic_SyncErrors](#BKMK_msdyn_salesroutingdiagnostic_SyncErrors)

### <a name="BKMK_msdyn_salesroutingdiagnostic_AsyncOperations"></a> msdyn_salesroutingdiagnostic_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_salesroutingdiagnostic_AsyncOperations](asyncoperation.md#BKMK_msdyn_salesroutingdiagnostic_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesroutingdiagnostic_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesroutingdiagnostic_BulkDeleteFailures"></a> msdyn_salesroutingdiagnostic_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_salesroutingdiagnostic_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_salesroutingdiagnostic_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesroutingdiagnostic_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesroutingdiagnostic_DuplicateBaseRecord"></a> msdyn_salesroutingdiagnostic_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_salesroutingdiagnostic_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_salesroutingdiagnostic_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesroutingdiagnostic_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesroutingdiagnostic_DuplicateMatchingRecord"></a> msdyn_salesroutingdiagnostic_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_salesroutingdiagnostic_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_salesroutingdiagnostic_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesroutingdiagnostic_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesroutingdiagnostic_MailboxTrackingFolders"></a> msdyn_salesroutingdiagnostic_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_salesroutingdiagnostic_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_salesroutingdiagnostic_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesroutingdiagnostic_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesroutingdiagnostic_PrincipalObjectAttributeAccesses"></a> msdyn_salesroutingdiagnostic_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_salesroutingdiagnostic_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_salesroutingdiagnostic_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesroutingdiagnostic_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesroutingdiagnostic_ProcessSession"></a> msdyn_salesroutingdiagnostic_ProcessSession

Many-To-One Relationship: [processsession msdyn_salesroutingdiagnostic_ProcessSession](processsession.md#BKMK_msdyn_salesroutingdiagnostic_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesroutingdiagnostic_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesroutingdiagnostic_SyncErrors"></a> msdyn_salesroutingdiagnostic_SyncErrors

Many-To-One Relationship: [syncerror msdyn_salesroutingdiagnostic_SyncErrors](syncerror.md#BKMK_msdyn_salesroutingdiagnostic_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesroutingdiagnostic_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

