---
title: "Activity Analysis CleanUp State (msdyn_activityanalysiscleanupstate) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Activity Analysis CleanUp State (msdyn_activityanalysiscleanupstate) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Activity Analysis CleanUp State (msdyn_activityanalysiscleanupstate) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Activity Analysis CleanUp State (msdyn_activityanalysiscleanupstate) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_activityanalysiscleanupstates<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_activityanalysiscleanupstates(*msdyn_activityanalysiscleanupstateid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_activityanalysiscleanupstates(*msdyn_activityanalysiscleanupstateid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_activityanalysiscleanupstates<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_activityanalysiscleanupstates(*msdyn_activityanalysiscleanupstateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_activityanalysiscleanupstates(*msdyn_activityanalysiscleanupstateid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_activityanalysiscleanupstates(*msdyn_activityanalysiscleanupstateid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Activity Analysis CleanUp State (msdyn_activityanalysiscleanupstate) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Activity Analysis CleanUp State** |
| **DisplayCollectionName** | **Activity Analysis CleanUp States** |
| **SchemaName** | `msdyn_activityanalysiscleanupstate` |
| **CollectionSchemaName** | `msdyn_activityanalysiscleanupstates` |
| **EntitySetName** | `msdyn_activityanalysiscleanupstates`|
| **LogicalName** | `msdyn_activityanalysiscleanupstate` |
| **LogicalCollectionName** | `msdyn_activityanalysiscleanupstates` |
| **PrimaryIdAttribute** | `msdyn_activityanalysiscleanupstateid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AccountKPICleanUpBatchNum](#BKMK_msdyn_AccountKPICleanUpBatchNum)
- [msdyn_AccountKPICleanUpStatus](#BKMK_msdyn_AccountKPICleanUpStatus)
- [msdyn_activityanalysiscleanupstateId](#BKMK_msdyn_activityanalysiscleanupstateId)
- [msdyn_ContactKPICleanUpBatchNum](#BKMK_msdyn_ContactKPICleanUpBatchNum)
- [msdyn_ContactKPICleanUpStatus](#BKMK_msdyn_ContactKPICleanUpStatus)
- [msdyn_LeadKPICleanUpBatchNum](#BKMK_msdyn_LeadKPICleanUpBatchNum)
- [msdyn_LeadKPICleanUpStatus](#BKMK_msdyn_LeadKPICleanUpStatus)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_OpportunityKPICleanUpBatchNum](#BKMK_msdyn_OpportunityKPICleanUpBatchNum)
- [msdyn_OpportunityKPICleanUpStatus](#BKMK_msdyn_OpportunityKPICleanUpStatus)
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

### <a name="BKMK_msdyn_AccountKPICleanUpBatchNum"></a> msdyn_AccountKPICleanUpBatchNum

|Property|Value|
|---|---|
|Description|**Shows the Cleanup batch number of the Account KPI record.**|
|DisplayName|**Account KPI Cleanup Batch Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_accountkpicleanupbatchnum`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_AccountKPICleanUpStatus"></a> msdyn_AccountKPICleanUpStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Account KPI Cleanup Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_accountkpicleanupstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_activityanalysiscleanupstate_msdyn_accountkpicleanupstatus`|

#### msdyn_AccountKPICleanUpStatus Choices/Options

|Value|Label|
|---|---|
|0|**None**|
|1|**InProgress**|
|2|**Completed**|

### <a name="BKMK_msdyn_activityanalysiscleanupstateId"></a> msdyn_activityanalysiscleanupstateId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances.**|
|DisplayName|**Activity Analysis Cleanup State**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_activityanalysiscleanupstateid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ContactKPICleanUpBatchNum"></a> msdyn_ContactKPICleanUpBatchNum

|Property|Value|
|---|---|
|Description|**Shows the Cleanup batch number of the Contact KPI record.**|
|DisplayName|**Contact KPI Cleanup Batch Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_contactkpicleanupbatchnum`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_ContactKPICleanUpStatus"></a> msdyn_ContactKPICleanUpStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Contact KPI Cleanup Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_contactkpicleanupstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_activityanalysiscleanupstate_msdyn_contactkpicleanupstatus`|

#### msdyn_ContactKPICleanUpStatus Choices/Options

|Value|Label|
|---|---|
|0|**None**|
|1|**InProgress**|
|2|**Completed**|

### <a name="BKMK_msdyn_LeadKPICleanUpBatchNum"></a> msdyn_LeadKPICleanUpBatchNum

|Property|Value|
|---|---|
|Description|**Shows the Cleanup batch number of the Lead KPI record.**|
|DisplayName|**Lead KPI Cleanup Batch Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_leadkpicleanupbatchnum`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_LeadKPICleanUpStatus"></a> msdyn_LeadKPICleanUpStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Lead KPI Cleanup Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_leadkpicleanupstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_activityanalysiscleanupstate_msdyn_leadkpicleanupstatus`|

#### msdyn_LeadKPICleanUpStatus Choices/Options

|Value|Label|
|---|---|
|0|**None**|
|1|**InProgress**|
|2|**Completed**|

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

### <a name="BKMK_msdyn_OpportunityKPICleanUpBatchNum"></a> msdyn_OpportunityKPICleanUpBatchNum

|Property|Value|
|---|---|
|Description|**Shows the Cleanup batch number of the Opportunity KPI record.**|
|DisplayName|**Opportunity KPI Cleanup Batch Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_opportunitykpicleanupbatchnum`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_OpportunityKPICleanUpStatus"></a> msdyn_OpportunityKPICleanUpStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Opportunity KPI Cleanup Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_opportunitykpicleanupstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_activityanalysiscleanupstate_msdyn_opportunitykpicleanupstatus`|

#### msdyn_OpportunityKPICleanUpStatus Choices/Options

|Value|Label|
|---|---|
|0|**None**|
|1|**InProgress**|
|2|**Completed**|

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
|Description|**Status of the ActivityAnalysisCleanUpState**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_activityanalysiscleanupstate_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the ActivityAnalysisCleanUpState**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_activityanalysiscleanupstate_statuscode`|

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
|Description|**Unique identifier for the organization.**|
|DisplayName|**Organization ID**|
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

- [lk_msdyn_activityanalysiscleanupstate_createdby](#BKMK_lk_msdyn_activityanalysiscleanupstate_createdby)
- [lk_msdyn_activityanalysiscleanupstate_createdonbehalfby](#BKMK_lk_msdyn_activityanalysiscleanupstate_createdonbehalfby)
- [lk_msdyn_activityanalysiscleanupstate_modifiedby](#BKMK_lk_msdyn_activityanalysiscleanupstate_modifiedby)
- [lk_msdyn_activityanalysiscleanupstate_modifiedonbehalfby](#BKMK_lk_msdyn_activityanalysiscleanupstate_modifiedonbehalfby)
- [organization_msdyn_activityanalysiscleanupstate](#BKMK_organization_msdyn_activityanalysiscleanupstate)

### <a name="BKMK_lk_msdyn_activityanalysiscleanupstate_createdby"></a> lk_msdyn_activityanalysiscleanupstate_createdby

One-To-Many Relationship: [systemuser lk_msdyn_activityanalysiscleanupstate_createdby](systemuser.md#BKMK_lk_msdyn_activityanalysiscleanupstate_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_activityanalysiscleanupstate_createdonbehalfby"></a> lk_msdyn_activityanalysiscleanupstate_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_activityanalysiscleanupstate_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_activityanalysiscleanupstate_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_activityanalysiscleanupstate_modifiedby"></a> lk_msdyn_activityanalysiscleanupstate_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_activityanalysiscleanupstate_modifiedby](systemuser.md#BKMK_lk_msdyn_activityanalysiscleanupstate_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_activityanalysiscleanupstate_modifiedonbehalfby"></a> lk_msdyn_activityanalysiscleanupstate_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_activityanalysiscleanupstate_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_activityanalysiscleanupstate_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_activityanalysiscleanupstate"></a> organization_msdyn_activityanalysiscleanupstate

One-To-Many Relationship: [organization organization_msdyn_activityanalysiscleanupstate](organization.md#BKMK_organization_msdyn_activityanalysiscleanupstate)

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

- [msdyn_activityanalysiscleanupstate_AsyncOperations](#BKMK_msdyn_activityanalysiscleanupstate_AsyncOperations)
- [msdyn_activityanalysiscleanupstate_BulkDeleteFailures](#BKMK_msdyn_activityanalysiscleanupstate_BulkDeleteFailures)
- [msdyn_activityanalysiscleanupstate_MailboxTrackingFolders](#BKMK_msdyn_activityanalysiscleanupstate_MailboxTrackingFolders)
- [msdyn_activityanalysiscleanupstate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_activityanalysiscleanupstate_PrincipalObjectAttributeAccesses)
- [msdyn_activityanalysiscleanupstate_ProcessSession](#BKMK_msdyn_activityanalysiscleanupstate_ProcessSession)
- [msdyn_activityanalysiscleanupstate_SyncErrors](#BKMK_msdyn_activityanalysiscleanupstate_SyncErrors)

### <a name="BKMK_msdyn_activityanalysiscleanupstate_AsyncOperations"></a> msdyn_activityanalysiscleanupstate_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_activityanalysiscleanupstate_AsyncOperations](asyncoperation.md#BKMK_msdyn_activityanalysiscleanupstate_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_activityanalysiscleanupstate_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_activityanalysiscleanupstate_BulkDeleteFailures"></a> msdyn_activityanalysiscleanupstate_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_activityanalysiscleanupstate_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_activityanalysiscleanupstate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_activityanalysiscleanupstate_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_activityanalysiscleanupstate_MailboxTrackingFolders"></a> msdyn_activityanalysiscleanupstate_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_activityanalysiscleanupstate_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_activityanalysiscleanupstate_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_activityanalysiscleanupstate_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_activityanalysiscleanupstate_PrincipalObjectAttributeAccesses"></a> msdyn_activityanalysiscleanupstate_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_activityanalysiscleanupstate_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_activityanalysiscleanupstate_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_activityanalysiscleanupstate_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_activityanalysiscleanupstate_ProcessSession"></a> msdyn_activityanalysiscleanupstate_ProcessSession

Many-To-One Relationship: [processsession msdyn_activityanalysiscleanupstate_ProcessSession](processsession.md#BKMK_msdyn_activityanalysiscleanupstate_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_activityanalysiscleanupstate_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_activityanalysiscleanupstate_SyncErrors"></a> msdyn_activityanalysiscleanupstate_SyncErrors

Many-To-One Relationship: [syncerror msdyn_activityanalysiscleanupstate_SyncErrors](syncerror.md#BKMK_msdyn_activityanalysiscleanupstate_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_activityanalysiscleanupstate_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

