---
title: "wkwcolleaguesforcontact (msdyn_wkwcolleaguesforcontact) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the wkwcolleaguesforcontact (msdyn_wkwcolleaguesforcontact) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# wkwcolleaguesforcontact (msdyn_wkwcolleaguesforcontact) table/entity reference (Microsoft Dynamics 365)

Entity for storing contact introducer

## Messages

The following table lists the messages for the wkwcolleaguesforcontact (msdyn_wkwcolleaguesforcontact) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_wkwcolleaguesforcontacts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_wkwcolleaguesforcontacts(*msdyn_wkwcolleaguesforcontactid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_wkwcolleaguesforcontacts(*msdyn_wkwcolleaguesforcontactid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_wkwcolleaguesforcontacts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_wkwcolleaguesforcontacts(*msdyn_wkwcolleaguesforcontactid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_wkwcolleaguesforcontacts(*msdyn_wkwcolleaguesforcontactid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_wkwcolleaguesforcontacts(*msdyn_wkwcolleaguesforcontactid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the wkwcolleaguesforcontact (msdyn_wkwcolleaguesforcontact) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **wkwcolleaguesforcontact** |
| **DisplayCollectionName** | **wkwcolleaguesforcontacts** |
| **SchemaName** | `msdyn_wkwcolleaguesforcontact` |
| **CollectionSchemaName** | `msdyn_wkwcolleaguesforcontacts` |
| **EntitySetName** | `msdyn_wkwcolleaguesforcontacts`|
| **LogicalName** | `msdyn_wkwcolleaguesforcontact` |
| **LogicalCollectionName** | `msdyn_wkwcolleaguesforcontacts` |
| **PrimaryIdAttribute** | `msdyn_wkwcolleaguesforcontactid` |
| **PrimaryNameAttribute** |`msdyn_introducer_emailaddress` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_computationaccuracy](#BKMK_msdyn_computationaccuracy)
- [msdyn_introduced_entity_id](#BKMK_msdyn_introduced_entity_id)
- [msdyn_introducer_emailaddress](#BKMK_msdyn_introducer_emailaddress)
- [msdyn_introducer_systemuserid](#BKMK_msdyn_introducer_systemuserid)
- [msdyn_last_interaction_dataflow](#BKMK_msdyn_last_interaction_dataflow)
- [msdyn_last_interaction_datetime](#BKMK_msdyn_last_interaction_datetime)
- [msdyn_last_interaction_type](#BKMK_msdyn_last_interaction_type)
- [msdyn_score](#BKMK_msdyn_score)
- [msdyn_wkwcolleaguesforcontactId](#BKMK_msdyn_wkwcolleaguesforcontactId)
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

### <a name="BKMK_msdyn_computationaccuracy"></a> msdyn_computationaccuracy

|Property|Value|
|---|---|
|Description||
|DisplayName|**Computation Accuracy**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_computationaccuracy`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msdyn_computationaccuracy`|

#### msdyn_computationaccuracy Choices/Options

|Value|Label|
|---|---|
|100000000|**Complete**|
|100000001|**Partial**|

### <a name="BKMK_msdyn_introduced_entity_id"></a> msdyn_introduced_entity_id

|Property|Value|
|---|---|
|Description||
|DisplayName|**Introduced Entity Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_introduced_entity_id`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_introducer_emailaddress"></a> msdyn_introducer_emailaddress

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Introducer Email Address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_introducer_emailaddress`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_introducer_systemuserid"></a> msdyn_introducer_systemuserid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Introducer systemuserid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_introducer_systemuserid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_last_interaction_dataflow"></a> msdyn_last_interaction_dataflow

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last Interaction Data flow**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_last_interaction_dataflow`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_last_interaction_datetime"></a> msdyn_last_interaction_datetime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last Interaction datetime**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_last_interaction_datetime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_last_interaction_type"></a> msdyn_last_interaction_type

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last Interaction type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_last_interaction_type`|
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
|Description||
|DisplayName|**score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_score`|
|RequiredLevel|ApplicationRequired|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_wkwcolleaguesforcontactId"></a> msdyn_wkwcolleaguesforcontactId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**msdyn\_wkwcolleaguesforcontact**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_wkwcolleaguesforcontactid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|Description|**Status of the msdyn\_wkwcolleaguesforcontact**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_wkwcolleaguesforcontact_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the msdyn\_wkwcolleaguesforcontact**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_wkwcolleaguesforcontact_statuscode`|

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

- [lk_msdyn_wkwcolleaguesforcontact_createdby](#BKMK_lk_msdyn_wkwcolleaguesforcontact_createdby)
- [lk_msdyn_wkwcolleaguesforcontact_createdonbehalfby](#BKMK_lk_msdyn_wkwcolleaguesforcontact_createdonbehalfby)
- [lk_msdyn_wkwcolleaguesforcontact_modifiedby](#BKMK_lk_msdyn_wkwcolleaguesforcontact_modifiedby)
- [lk_msdyn_wkwcolleaguesforcontact_modifiedonbehalfby](#BKMK_lk_msdyn_wkwcolleaguesforcontact_modifiedonbehalfby)
- [organization_msdyn_wkwcolleaguesforcontact](#BKMK_organization_msdyn_wkwcolleaguesforcontact)
- [systemuser_msdyn_wkwcolleaguesforcontact_introducer_systemuserid](#BKMK_systemuser_msdyn_wkwcolleaguesforcontact_introducer_systemuserid)

### <a name="BKMK_lk_msdyn_wkwcolleaguesforcontact_createdby"></a> lk_msdyn_wkwcolleaguesforcontact_createdby

One-To-Many Relationship: [systemuser lk_msdyn_wkwcolleaguesforcontact_createdby](systemuser.md#BKMK_lk_msdyn_wkwcolleaguesforcontact_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_wkwcolleaguesforcontact_createdonbehalfby"></a> lk_msdyn_wkwcolleaguesforcontact_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_wkwcolleaguesforcontact_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_wkwcolleaguesforcontact_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_wkwcolleaguesforcontact_modifiedby"></a> lk_msdyn_wkwcolleaguesforcontact_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_wkwcolleaguesforcontact_modifiedby](systemuser.md#BKMK_lk_msdyn_wkwcolleaguesforcontact_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_wkwcolleaguesforcontact_modifiedonbehalfby"></a> lk_msdyn_wkwcolleaguesforcontact_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_wkwcolleaguesforcontact_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_wkwcolleaguesforcontact_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_wkwcolleaguesforcontact"></a> organization_msdyn_wkwcolleaguesforcontact

One-To-Many Relationship: [organization organization_msdyn_wkwcolleaguesforcontact](organization.md#BKMK_organization_msdyn_wkwcolleaguesforcontact)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_systemuser_msdyn_wkwcolleaguesforcontact_introducer_systemuserid"></a> systemuser_msdyn_wkwcolleaguesforcontact_introducer_systemuserid

One-To-Many Relationship: [systemuser systemuser_msdyn_wkwcolleaguesforcontact_introducer_systemuserid](systemuser.md#BKMK_systemuser_msdyn_wkwcolleaguesforcontact_introducer_systemuserid)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_introducer_systemuserid`|
|ReferencingEntityNavigationPropertyName|`msdyn_introducer_systemuserid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_wkwcolleaguesforcontact_AsyncOperations](#BKMK_msdyn_wkwcolleaguesforcontact_AsyncOperations)
- [msdyn_wkwcolleaguesforcontact_BulkDeleteFailures](#BKMK_msdyn_wkwcolleaguesforcontact_BulkDeleteFailures)
- [msdyn_wkwcolleaguesforcontact_DuplicateBaseRecord](#BKMK_msdyn_wkwcolleaguesforcontact_DuplicateBaseRecord)
- [msdyn_wkwcolleaguesforcontact_DuplicateMatchingRecord](#BKMK_msdyn_wkwcolleaguesforcontact_DuplicateMatchingRecord)
- [msdyn_wkwcolleaguesforcontact_MailboxTrackingFolders](#BKMK_msdyn_wkwcolleaguesforcontact_MailboxTrackingFolders)
- [msdyn_wkwcolleaguesforcontact_PrincipalObjectAttributeAccesses](#BKMK_msdyn_wkwcolleaguesforcontact_PrincipalObjectAttributeAccesses)
- [msdyn_wkwcolleaguesforcontact_ProcessSession](#BKMK_msdyn_wkwcolleaguesforcontact_ProcessSession)
- [msdyn_wkwcolleaguesforcontact_SyncErrors](#BKMK_msdyn_wkwcolleaguesforcontact_SyncErrors)

### <a name="BKMK_msdyn_wkwcolleaguesforcontact_AsyncOperations"></a> msdyn_wkwcolleaguesforcontact_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_wkwcolleaguesforcontact_AsyncOperations](asyncoperation.md#BKMK_msdyn_wkwcolleaguesforcontact_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wkwcolleaguesforcontact_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_wkwcolleaguesforcontact_BulkDeleteFailures"></a> msdyn_wkwcolleaguesforcontact_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_wkwcolleaguesforcontact_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_wkwcolleaguesforcontact_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wkwcolleaguesforcontact_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_wkwcolleaguesforcontact_DuplicateBaseRecord"></a> msdyn_wkwcolleaguesforcontact_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_wkwcolleaguesforcontact_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_wkwcolleaguesforcontact_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wkwcolleaguesforcontact_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_wkwcolleaguesforcontact_DuplicateMatchingRecord"></a> msdyn_wkwcolleaguesforcontact_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_wkwcolleaguesforcontact_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_wkwcolleaguesforcontact_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wkwcolleaguesforcontact_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_wkwcolleaguesforcontact_MailboxTrackingFolders"></a> msdyn_wkwcolleaguesforcontact_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_wkwcolleaguesforcontact_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_wkwcolleaguesforcontact_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wkwcolleaguesforcontact_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_wkwcolleaguesforcontact_PrincipalObjectAttributeAccesses"></a> msdyn_wkwcolleaguesforcontact_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_wkwcolleaguesforcontact_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_wkwcolleaguesforcontact_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wkwcolleaguesforcontact_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_wkwcolleaguesforcontact_ProcessSession"></a> msdyn_wkwcolleaguesforcontact_ProcessSession

Many-To-One Relationship: [processsession msdyn_wkwcolleaguesforcontact_ProcessSession](processsession.md#BKMK_msdyn_wkwcolleaguesforcontact_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wkwcolleaguesforcontact_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_wkwcolleaguesforcontact_SyncErrors"></a> msdyn_wkwcolleaguesforcontact_SyncErrors

Many-To-One Relationship: [syncerror msdyn_wkwcolleaguesforcontact_SyncErrors](syncerror.md#BKMK_msdyn_wkwcolleaguesforcontact_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wkwcolleaguesforcontact_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

