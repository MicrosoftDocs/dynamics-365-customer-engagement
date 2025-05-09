---
title: "Unified Routing Setup Tracker (msdyn_unifiedroutingsetuptracker) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Unified Routing Setup Tracker (msdyn_unifiedroutingsetuptracker) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Unified Routing Setup Tracker (msdyn_unifiedroutingsetuptracker) table/entity reference (Microsoft Dynamics 365)

Unified Routing Setup Trackers

## Messages

The following table lists the messages for the Unified Routing Setup Tracker (msdyn_unifiedroutingsetuptracker) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_unifiedroutingsetuptrackers<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_unifiedroutingsetuptrackers(*msdyn_unifiedroutingsetuptrackerid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_unifiedroutingsetuptrackers(*msdyn_unifiedroutingsetuptrackerid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_unifiedroutingsetuptrackers<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_unifiedroutingsetuptrackers(*msdyn_unifiedroutingsetuptrackerid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_unifiedroutingsetuptrackers(*msdyn_unifiedroutingsetuptrackerid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_unifiedroutingsetuptrackers(*msdyn_unifiedroutingsetuptrackerid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Unified Routing Setup Tracker (msdyn_unifiedroutingsetuptracker) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Unified Routing Setup Tracker** |
| **DisplayCollectionName** | **Unified Routing Setup Trackers** |
| **SchemaName** | `msdyn_unifiedroutingsetuptracker` |
| **CollectionSchemaName** | `msdyn_unifiedroutingsetuptrackers` |
| **EntitySetName** | `msdyn_unifiedroutingsetuptrackers`|
| **LogicalName** | `msdyn_unifiedroutingsetuptracker` |
| **LogicalCollectionName** | `msdyn_unifiedroutingsetuptrackers` |
| **PrimaryIdAttribute** | `msdyn_unifiedroutingsetuptrackerid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_enableunifiedrouting](#BKMK_msdyn_enableunifiedrouting)
- [msdyn_errorcode](#BKMK_msdyn_errorcode)
- [msdyn_errormessage](#BKMK_msdyn_errormessage)
- [msdyn_executionstatus](#BKMK_msdyn_executionstatus)
- [msdyn_issuccessnotificationdisplayed](#BKMK_msdyn_issuccessnotificationdisplayed)
- [msdyn_isTeachingBubbleDisplayed](#BKMK_msdyn_isTeachingBubbleDisplayed)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_servicerequestid](#BKMK_msdyn_servicerequestid)
- [msdyn_skipProvisioning](#BKMK_msdyn_skipProvisioning)
- [msdyn_token](#BKMK_msdyn_token)
- [msdyn_transactionid](#BKMK_msdyn_transactionid)
- [msdyn_unifiedroutingsetuptrackerId](#BKMK_msdyn_unifiedroutingsetuptrackerId)
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

### <a name="BKMK_msdyn_enableunifiedrouting"></a> msdyn_enableunifiedrouting

|Property|Value|
|---|---|
|Description||
|DisplayName|**Enable Unified Routing**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enableunifiedrouting`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_unifiedroutingsetuptracker_msdyn_enableunifiedrouting`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_errorcode"></a> msdyn_errorcode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Error Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_errorcode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_errormessage"></a> msdyn_errormessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Error Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_errormessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_executionstatus"></a> msdyn_executionstatus

|Property|Value|
|---|---|
|Description|**Execution Status**|
|DisplayName|**Execution Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_executionstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_unifiedroutingsetuptracker_msdyn_executionstatus`|

#### msdyn_executionstatus Choices/Options

|Value|Label|
|---|---|
|0|**Started**|
|1|**Completed**|
|2|**Provisioning Started**|
|3|**Provisioning Completed**|
|4|**Deprovisioning Started**|
|5|**Deprovisioning Completed**|
|6|**Toggled**|
|7|**Record Created**|
|8|**Failed**|

### <a name="BKMK_msdyn_issuccessnotificationdisplayed"></a> msdyn_issuccessnotificationdisplayed

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is success notification displayed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_issuccessnotificationdisplayed`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_unifiedroutingsetuptracker_msdyn_issuccessnotificationdisplayed`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_isTeachingBubbleDisplayed"></a> msdyn_isTeachingBubbleDisplayed

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is Unified Routing teaching bubble displayed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isteachingbubbledisplayed`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_unifiedroutingsetuptracker_msdyn_isteachingbubbledisplayed`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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

### <a name="BKMK_msdyn_servicerequestid"></a> msdyn_servicerequestid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Service Request Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_servicerequestid`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|30000|

### <a name="BKMK_msdyn_skipProvisioning"></a> msdyn_skipProvisioning

|Property|Value|
|---|---|
|Description|**Skip Provisioning**|
|DisplayName|**Skip Provisioning**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_skipprovisioning`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_unifiedroutingsetuptracker_msdyn_skipprovisioning`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_token"></a> msdyn_token

|Property|Value|
|---|---|
|Description||
|DisplayName|**Token**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_token`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20000|

### <a name="BKMK_msdyn_transactionid"></a> msdyn_transactionid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Transaction Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_transactionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_unifiedroutingsetuptrackerId"></a> msdyn_unifiedroutingsetuptrackerId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Unified Routing Setup Tracker**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_unifiedroutingsetuptrackerid`|
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
|Description|**Status of the Unified Routing Setup Tracker**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_unifiedroutingsetuptracker_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Unified Routing Setup Tracker**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_unifiedroutingsetuptracker_statuscode`|

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

- [lk_msdyn_unifiedroutingsetuptracker_createdby](#BKMK_lk_msdyn_unifiedroutingsetuptracker_createdby)
- [lk_msdyn_unifiedroutingsetuptracker_createdonbehalfby](#BKMK_lk_msdyn_unifiedroutingsetuptracker_createdonbehalfby)
- [lk_msdyn_unifiedroutingsetuptracker_modifiedby](#BKMK_lk_msdyn_unifiedroutingsetuptracker_modifiedby)
- [lk_msdyn_unifiedroutingsetuptracker_modifiedonbehalfby](#BKMK_lk_msdyn_unifiedroutingsetuptracker_modifiedonbehalfby)
- [organization_msdyn_unifiedroutingsetuptracker](#BKMK_organization_msdyn_unifiedroutingsetuptracker)

### <a name="BKMK_lk_msdyn_unifiedroutingsetuptracker_createdby"></a> lk_msdyn_unifiedroutingsetuptracker_createdby

One-To-Many Relationship: [systemuser lk_msdyn_unifiedroutingsetuptracker_createdby](systemuser.md#BKMK_lk_msdyn_unifiedroutingsetuptracker_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_unifiedroutingsetuptracker_createdonbehalfby"></a> lk_msdyn_unifiedroutingsetuptracker_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_unifiedroutingsetuptracker_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_unifiedroutingsetuptracker_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_unifiedroutingsetuptracker_modifiedby"></a> lk_msdyn_unifiedroutingsetuptracker_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_unifiedroutingsetuptracker_modifiedby](systemuser.md#BKMK_lk_msdyn_unifiedroutingsetuptracker_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_unifiedroutingsetuptracker_modifiedonbehalfby"></a> lk_msdyn_unifiedroutingsetuptracker_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_unifiedroutingsetuptracker_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_unifiedroutingsetuptracker_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_unifiedroutingsetuptracker"></a> organization_msdyn_unifiedroutingsetuptracker

One-To-Many Relationship: [organization organization_msdyn_unifiedroutingsetuptracker](organization.md#BKMK_organization_msdyn_unifiedroutingsetuptracker)

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

- [msdyn_unifiedroutingsetuptracker_AsyncOperations](#BKMK_msdyn_unifiedroutingsetuptracker_AsyncOperations)
- [msdyn_unifiedroutingsetuptracker_BulkDeleteFailures](#BKMK_msdyn_unifiedroutingsetuptracker_BulkDeleteFailures)
- [msdyn_unifiedroutingsetuptracker_DuplicateBaseRecord](#BKMK_msdyn_unifiedroutingsetuptracker_DuplicateBaseRecord)
- [msdyn_unifiedroutingsetuptracker_DuplicateMatchingRecord](#BKMK_msdyn_unifiedroutingsetuptracker_DuplicateMatchingRecord)
- [msdyn_unifiedroutingsetuptracker_MailboxTrackingFolders](#BKMK_msdyn_unifiedroutingsetuptracker_MailboxTrackingFolders)
- [msdyn_unifiedroutingsetuptracker_PrincipalObjectAttributeAccesses](#BKMK_msdyn_unifiedroutingsetuptracker_PrincipalObjectAttributeAccesses)
- [msdyn_unifiedroutingsetuptracker_ProcessSession](#BKMK_msdyn_unifiedroutingsetuptracker_ProcessSession)
- [msdyn_unifiedroutingsetuptracker_SyncErrors](#BKMK_msdyn_unifiedroutingsetuptracker_SyncErrors)

### <a name="BKMK_msdyn_unifiedroutingsetuptracker_AsyncOperations"></a> msdyn_unifiedroutingsetuptracker_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_unifiedroutingsetuptracker_AsyncOperations](asyncoperation.md#BKMK_msdyn_unifiedroutingsetuptracker_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_unifiedroutingsetuptracker_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_unifiedroutingsetuptracker_BulkDeleteFailures"></a> msdyn_unifiedroutingsetuptracker_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_unifiedroutingsetuptracker_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_unifiedroutingsetuptracker_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_unifiedroutingsetuptracker_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_unifiedroutingsetuptracker_DuplicateBaseRecord"></a> msdyn_unifiedroutingsetuptracker_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_unifiedroutingsetuptracker_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_unifiedroutingsetuptracker_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_unifiedroutingsetuptracker_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_unifiedroutingsetuptracker_DuplicateMatchingRecord"></a> msdyn_unifiedroutingsetuptracker_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_unifiedroutingsetuptracker_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_unifiedroutingsetuptracker_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_unifiedroutingsetuptracker_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_unifiedroutingsetuptracker_MailboxTrackingFolders"></a> msdyn_unifiedroutingsetuptracker_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_unifiedroutingsetuptracker_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_unifiedroutingsetuptracker_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_unifiedroutingsetuptracker_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_unifiedroutingsetuptracker_PrincipalObjectAttributeAccesses"></a> msdyn_unifiedroutingsetuptracker_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_unifiedroutingsetuptracker_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_unifiedroutingsetuptracker_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_unifiedroutingsetuptracker_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_unifiedroutingsetuptracker_ProcessSession"></a> msdyn_unifiedroutingsetuptracker_ProcessSession

Many-To-One Relationship: [processsession msdyn_unifiedroutingsetuptracker_ProcessSession](processsession.md#BKMK_msdyn_unifiedroutingsetuptracker_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_unifiedroutingsetuptracker_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_unifiedroutingsetuptracker_SyncErrors"></a> msdyn_unifiedroutingsetuptracker_SyncErrors

Many-To-One Relationship: [syncerror msdyn_unifiedroutingsetuptracker_SyncErrors](syncerror.md#BKMK_msdyn_unifiedroutingsetuptracker_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_unifiedroutingsetuptracker_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

