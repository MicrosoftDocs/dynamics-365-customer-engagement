---
title: "sabackupdiagnostic (msdyn_sabackupdiagnostic) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the sabackupdiagnostic (msdyn_sabackupdiagnostic) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# sabackupdiagnostic (msdyn_sabackupdiagnostic) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the sabackupdiagnostic (msdyn_sabackupdiagnostic) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_sabackupdiagnostics<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_sabackupdiagnostics(*msdyn_sabackupdiagnosticid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_sabackupdiagnostics(*msdyn_sabackupdiagnosticid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_sabackupdiagnostics<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_sabackupdiagnostics(*msdyn_sabackupdiagnosticid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_sabackupdiagnostics(*msdyn_sabackupdiagnosticid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_sabackupdiagnostics(*msdyn_sabackupdiagnosticid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the sabackupdiagnostic (msdyn_sabackupdiagnostic) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **sabackupdiagnostic** |
| **DisplayCollectionName** | **sabackupdiagnostics** |
| **SchemaName** | `msdyn_sabackupdiagnostic` |
| **CollectionSchemaName** | `msdyn_sabackupdiagnostics` |
| **EntitySetName** | `msdyn_sabackupdiagnostics`|
| **LogicalName** | `msdyn_sabackupdiagnostic` |
| **LogicalCollectionName** | `msdyn_sabackupdiagnostics` |
| **PrimaryIdAttribute** | `msdyn_sabackupdiagnosticid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_changedata](#BKMK_msdyn_changedata)
- [msdyn_diagnostictype](#BKMK_msdyn_diagnostictype)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_sabackupdiagnosticId](#BKMK_msdyn_sabackupdiagnosticId)
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

### <a name="BKMK_msdyn_changedata"></a> msdyn_changedata

|Property|Value|
|---|---|
|Description||
|DisplayName|**changes related to segmentation, routing and connect sequence**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_changedata`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_diagnostictype"></a> msdyn_diagnostictype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Diagnostic type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_diagnostictype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyn_sabackupdiagnostic_msdyn_diagnostictype`|

#### msdyn_diagnostictype Choices/Options

|Value|Label|
|---|---|
|1|**Segmentation**|
|2|**Routing**|
|3|**ConnectSequence**|

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

### <a name="BKMK_msdyn_sabackupdiagnosticId"></a> msdyn_sabackupdiagnosticId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**sabackupdiagnostic**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_sabackupdiagnosticid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_target"></a> msdyn_target

|Property|Value|
|---|---|
|Description||
|DisplayName|**target**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_target`|
|RequiredLevel|ApplicationRequired|
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
|Description|**Status of the sabackupdiagnostic**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_sabackupdiagnostic_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the sabackupdiagnostic**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_sabackupdiagnostic_statuscode`|

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

- [lk_msdyn_sabackupdiagnostic_createdby](#BKMK_lk_msdyn_sabackupdiagnostic_createdby)
- [lk_msdyn_sabackupdiagnostic_createdonbehalfby](#BKMK_lk_msdyn_sabackupdiagnostic_createdonbehalfby)
- [lk_msdyn_sabackupdiagnostic_modifiedby](#BKMK_lk_msdyn_sabackupdiagnostic_modifiedby)
- [lk_msdyn_sabackupdiagnostic_modifiedonbehalfby](#BKMK_lk_msdyn_sabackupdiagnostic_modifiedonbehalfby)
- [msdyn_sabackupdiagnostic_account_msdyn_target](#BKMK_msdyn_sabackupdiagnostic_account_msdyn_target)
- [msdyn_sabackupdiagnostic_contact_msdyn_target](#BKMK_msdyn_sabackupdiagnostic_contact_msdyn_target)
- [msdyn_sabackupdiagnostic_lead_msdyn_target](#BKMK_msdyn_sabackupdiagnostic_lead_msdyn_target)
- [msdyn_sabackupdiagnostic_opportunity_msdyn_target](#BKMK_msdyn_sabackupdiagnostic_opportunity_msdyn_target)
- [organization_msdyn_sabackupdiagnostic](#BKMK_organization_msdyn_sabackupdiagnostic)

### <a name="BKMK_lk_msdyn_sabackupdiagnostic_createdby"></a> lk_msdyn_sabackupdiagnostic_createdby

One-To-Many Relationship: [systemuser lk_msdyn_sabackupdiagnostic_createdby](systemuser.md#BKMK_lk_msdyn_sabackupdiagnostic_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sabackupdiagnostic_createdonbehalfby"></a> lk_msdyn_sabackupdiagnostic_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_sabackupdiagnostic_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_sabackupdiagnostic_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sabackupdiagnostic_modifiedby"></a> lk_msdyn_sabackupdiagnostic_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_sabackupdiagnostic_modifiedby](systemuser.md#BKMK_lk_msdyn_sabackupdiagnostic_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sabackupdiagnostic_modifiedonbehalfby"></a> lk_msdyn_sabackupdiagnostic_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_sabackupdiagnostic_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_sabackupdiagnostic_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sabackupdiagnostic_account_msdyn_target"></a> msdyn_sabackupdiagnostic_account_msdyn_target

One-To-Many Relationship: [account msdyn_sabackupdiagnostic_account_msdyn_target](account.md#BKMK_msdyn_sabackupdiagnostic_account_msdyn_target)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_target`|
|ReferencingEntityNavigationPropertyName|`msdyn_target`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sabackupdiagnostic_contact_msdyn_target"></a> msdyn_sabackupdiagnostic_contact_msdyn_target

One-To-Many Relationship: [contact msdyn_sabackupdiagnostic_contact_msdyn_target](contact.md#BKMK_msdyn_sabackupdiagnostic_contact_msdyn_target)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyn_target`|
|ReferencingEntityNavigationPropertyName|`msdyn_target`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sabackupdiagnostic_lead_msdyn_target"></a> msdyn_sabackupdiagnostic_lead_msdyn_target

One-To-Many Relationship: [lead msdyn_sabackupdiagnostic_lead_msdyn_target](lead.md#BKMK_msdyn_sabackupdiagnostic_lead_msdyn_target)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`msdyn_target`|
|ReferencingEntityNavigationPropertyName|`msdyn_target`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sabackupdiagnostic_opportunity_msdyn_target"></a> msdyn_sabackupdiagnostic_opportunity_msdyn_target

One-To-Many Relationship: [opportunity msdyn_sabackupdiagnostic_opportunity_msdyn_target](opportunity.md#BKMK_msdyn_sabackupdiagnostic_opportunity_msdyn_target)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`msdyn_target`|
|ReferencingEntityNavigationPropertyName|`msdyn_target`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_sabackupdiagnostic"></a> organization_msdyn_sabackupdiagnostic

One-To-Many Relationship: [organization organization_msdyn_sabackupdiagnostic](organization.md#BKMK_organization_msdyn_sabackupdiagnostic)

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

- [msdyn_sabackupdiagnostic_AsyncOperations](#BKMK_msdyn_sabackupdiagnostic_AsyncOperations)
- [msdyn_sabackupdiagnostic_BulkDeleteFailures](#BKMK_msdyn_sabackupdiagnostic_BulkDeleteFailures)
- [msdyn_sabackupdiagnostic_DuplicateBaseRecord](#BKMK_msdyn_sabackupdiagnostic_DuplicateBaseRecord)
- [msdyn_sabackupdiagnostic_DuplicateMatchingRecord](#BKMK_msdyn_sabackupdiagnostic_DuplicateMatchingRecord)
- [msdyn_sabackupdiagnostic_MailboxTrackingFolders](#BKMK_msdyn_sabackupdiagnostic_MailboxTrackingFolders)
- [msdyn_sabackupdiagnostic_PrincipalObjectAttributeAccesses](#BKMK_msdyn_sabackupdiagnostic_PrincipalObjectAttributeAccesses)
- [msdyn_sabackupdiagnostic_ProcessSession](#BKMK_msdyn_sabackupdiagnostic_ProcessSession)
- [msdyn_sabackupdiagnostic_SyncErrors](#BKMK_msdyn_sabackupdiagnostic_SyncErrors)

### <a name="BKMK_msdyn_sabackupdiagnostic_AsyncOperations"></a> msdyn_sabackupdiagnostic_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_sabackupdiagnostic_AsyncOperations](asyncoperation.md#BKMK_msdyn_sabackupdiagnostic_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sabackupdiagnostic_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sabackupdiagnostic_BulkDeleteFailures"></a> msdyn_sabackupdiagnostic_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_sabackupdiagnostic_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_sabackupdiagnostic_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sabackupdiagnostic_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sabackupdiagnostic_DuplicateBaseRecord"></a> msdyn_sabackupdiagnostic_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_sabackupdiagnostic_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_sabackupdiagnostic_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sabackupdiagnostic_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sabackupdiagnostic_DuplicateMatchingRecord"></a> msdyn_sabackupdiagnostic_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_sabackupdiagnostic_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_sabackupdiagnostic_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sabackupdiagnostic_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sabackupdiagnostic_MailboxTrackingFolders"></a> msdyn_sabackupdiagnostic_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_sabackupdiagnostic_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_sabackupdiagnostic_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sabackupdiagnostic_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sabackupdiagnostic_PrincipalObjectAttributeAccesses"></a> msdyn_sabackupdiagnostic_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_sabackupdiagnostic_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_sabackupdiagnostic_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sabackupdiagnostic_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sabackupdiagnostic_ProcessSession"></a> msdyn_sabackupdiagnostic_ProcessSession

Many-To-One Relationship: [processsession msdyn_sabackupdiagnostic_ProcessSession](processsession.md#BKMK_msdyn_sabackupdiagnostic_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sabackupdiagnostic_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sabackupdiagnostic_SyncErrors"></a> msdyn_sabackupdiagnostic_SyncErrors

Many-To-One Relationship: [syncerror msdyn_sabackupdiagnostic_SyncErrors](syncerror.md#BKMK_msdyn_sabackupdiagnostic_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sabackupdiagnostic_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

