---
title: "Routing diagnostic (msdyn_unifiedroutingrun) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Routing diagnostic (msdyn_unifiedroutingrun) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Routing diagnostic (msdyn_unifiedroutingrun) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Routing diagnostic (msdyn_unifiedroutingrun) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_unifiedroutingruns(*msdyn_unifiedroutingrunid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_unifiedroutingruns<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_unifiedroutingruns(*msdyn_unifiedroutingrunid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_unifiedroutingruns(*msdyn_unifiedroutingrunid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_unifiedroutingruns<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_unifiedroutingruns(*msdyn_unifiedroutingrunid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_unifiedroutingruns(*msdyn_unifiedroutingrunid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_unifiedroutingruns(*msdyn_unifiedroutingrunid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Routing diagnostic (msdyn_unifiedroutingrun) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Routing diagnostic** |
| **DisplayCollectionName** | **Routing diagnostics** |
| **SchemaName** | `msdyn_unifiedroutingrun` |
| **CollectionSchemaName** | `msdyn_unifiedroutingruns` |
| **EntitySetName** | `msdyn_unifiedroutingruns`|
| **LogicalName** | `msdyn_unifiedroutingrun` |
| **LogicalCollectionName** | `msdyn_unifiedroutingruns` |
| **PrimaryIdAttribute** | `msdyn_unifiedroutingrunid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_assignedagent](#BKMK_msdyn_assignedagent)
- [msdyn_diagnosticversion](#BKMK_msdyn_diagnosticversion)
- [msdyn_endtime](#BKMK_msdyn_endtime)
- [msdyn_liveworkitem](#BKMK_msdyn_liveworkitem)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_queue](#BKMK_msdyn_queue)
- [msdyn_routingduration](#BKMK_msdyn_routingduration)
- [msdyn_routingdurationinseconds](#BKMK_msdyn_routingdurationinseconds)
- [msdyn_routingstatus](#BKMK_msdyn_routingstatus)
- [msdyn_runnumber](#BKMK_msdyn_runnumber)
- [msdyn_starttime](#BKMK_msdyn_starttime)
- [msdyn_targetobject](#BKMK_msdyn_targetobject)
- [msdyn_targetobjectIdType](#BKMK_msdyn_targetobjectIdType)
- [msdyn_unifiedroutingrunId](#BKMK_msdyn_unifiedroutingrunId)
- [msdyn_workstream](#BKMK_msdyn_workstream)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
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

### <a name="BKMK_msdyn_assignedagent"></a> msdyn_assignedagent

|Property|Value|
|---|---|
|Description||
|DisplayName|**Assigned agent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_assignedagent`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_diagnosticversion"></a> msdyn_diagnosticversion

|Property|Value|
|---|---|
|Description|**Default value of diagnostic version while creating the run record**|
|DisplayName|**Diagnostic version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_diagnosticversion`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_endtime"></a> msdyn_endtime

|Property|Value|
|---|---|
|Description||
|DisplayName|**End time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_endtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_liveworkitem"></a> msdyn_liveworkitem

|Property|Value|
|---|---|
|Description||
|DisplayName|**Work item**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_liveworkitem`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocliveworkitem|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The diagnostic item.**|
|DisplayName|**Diagnostic item**|
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

### <a name="BKMK_msdyn_queue"></a> msdyn_queue

|Property|Value|
|---|---|
|Description||
|DisplayName|**Queue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_queue`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|queue|

### <a name="BKMK_msdyn_routingduration"></a> msdyn_routingduration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Routing duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_routingduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_routingdurationinseconds"></a> msdyn_routingdurationinseconds

|Property|Value|
|---|---|
|Description|**Routing duration in seconds**|
|DisplayName|**Duration (second)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_routingdurationinseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_routingstatus"></a> msdyn_routingstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Routing status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_routingstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_msdyn_unifiedroutingrun_msdyn_routingstatus`|

#### msdyn_routingstatus Choices/Options

|Value|Label|
|---|---|
|100000000|**Intake rules - completed**|
|100000001|**Workstream: Classification rules - processing...**|
|100000002|**Workstream: Route-to-queue rules - completed**|
|100000003|**Queue: Prioritization rules - completed**|
|100000004|**Queue: Assignment selection rules - completed**|
|100000005|**Queue: Assignment rules - completed**|
|100000006|**Agent assignment - completed**|

### <a name="BKMK_msdyn_runnumber"></a> msdyn_runnumber

|Property|Value|
|---|---|
|Description|**Run number**|
|DisplayName|**Run Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_runnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_starttime"></a> msdyn_starttime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Routing started on**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_starttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_targetobject"></a> msdyn_targetobject

|Property|Value|
|---|---|
|Description|**Unique identifier for the target object associated with unified routing run.**|
|DisplayName|**Target Object**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_targetobject`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocliveworkitem, queueitem|

### <a name="BKMK_msdyn_targetobjectIdType"></a> msdyn_targetobjectIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_targetobjectidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_unifiedroutingrunId"></a> msdyn_unifiedroutingrunId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Unified routing run**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_unifiedroutingrunid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_workstream"></a> msdyn_workstream

|Property|Value|
|---|---|
|Description||
|DisplayName|**Workstream**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workstream`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_liveworkstream|

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

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Unified routing run**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_unifiedroutingrun_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Unified routing run**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_unifiedroutingrun_statuscode`|

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
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
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

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record.**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
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

- [business_unit_msdyn_unifiedroutingrun](#BKMK_business_unit_msdyn_unifiedroutingrun)
- [lk_msdyn_unifiedroutingrun_createdby](#BKMK_lk_msdyn_unifiedroutingrun_createdby)
- [lk_msdyn_unifiedroutingrun_createdonbehalfby](#BKMK_lk_msdyn_unifiedroutingrun_createdonbehalfby)
- [lk_msdyn_unifiedroutingrun_modifiedby](#BKMK_lk_msdyn_unifiedroutingrun_modifiedby)
- [lk_msdyn_unifiedroutingrun_modifiedonbehalfby](#BKMK_lk_msdyn_unifiedroutingrun_modifiedonbehalfby)
- [msdyn_msdyn_liveworkstream_msdyn_unifiedroutingrun_workstream](#BKMK_msdyn_msdyn_liveworkstream_msdyn_unifiedroutingrun_workstream)
- [msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingrun_workitem](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingrun_workitem)
- [msdyn_msdyn_unifiedroutingrun_msdyn_ocliveworkitem_targetobject](#BKMK_msdyn_msdyn_unifiedroutingrun_msdyn_ocliveworkitem_targetobject)
- [msdyn_queue_msdyn_unifiedroutingrun_queue](#BKMK_msdyn_queue_msdyn_unifiedroutingrun_queue)
- [msdyn_systemuser_msdyn_unifiedroutingrun_assignedagent](#BKMK_msdyn_systemuser_msdyn_unifiedroutingrun_assignedagent)
- [msdyn_unifiedroutingrun_queueitem_targetobject](#BKMK_msdyn_unifiedroutingrun_queueitem_targetobject)
- [owner_msdyn_unifiedroutingrun](#BKMK_owner_msdyn_unifiedroutingrun)
- [team_msdyn_unifiedroutingrun](#BKMK_team_msdyn_unifiedroutingrun)
- [user_msdyn_unifiedroutingrun](#BKMK_user_msdyn_unifiedroutingrun)

### <a name="BKMK_business_unit_msdyn_unifiedroutingrun"></a> business_unit_msdyn_unifiedroutingrun

One-To-Many Relationship: [businessunit business_unit_msdyn_unifiedroutingrun](businessunit.md#BKMK_business_unit_msdyn_unifiedroutingrun)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_unifiedroutingrun_createdby"></a> lk_msdyn_unifiedroutingrun_createdby

One-To-Many Relationship: [systemuser lk_msdyn_unifiedroutingrun_createdby](systemuser.md#BKMK_lk_msdyn_unifiedroutingrun_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_unifiedroutingrun_createdonbehalfby"></a> lk_msdyn_unifiedroutingrun_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_unifiedroutingrun_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_unifiedroutingrun_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_unifiedroutingrun_modifiedby"></a> lk_msdyn_unifiedroutingrun_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_unifiedroutingrun_modifiedby](systemuser.md#BKMK_lk_msdyn_unifiedroutingrun_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_unifiedroutingrun_modifiedonbehalfby"></a> lk_msdyn_unifiedroutingrun_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_unifiedroutingrun_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_unifiedroutingrun_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_liveworkstream_msdyn_unifiedroutingrun_workstream"></a> msdyn_msdyn_liveworkstream_msdyn_unifiedroutingrun_workstream

One-To-Many Relationship: [msdyn_liveworkstream msdyn_msdyn_liveworkstream_msdyn_unifiedroutingrun_workstream](msdyn_liveworkstream.md#BKMK_msdyn_msdyn_liveworkstream_msdyn_unifiedroutingrun_workstream)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_liveworkstream`|
|ReferencedAttribute|`msdyn_liveworkstreamid`|
|ReferencingAttribute|`msdyn_workstream`|
|ReferencingEntityNavigationPropertyName|`msdyn_workstream`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingrun_workitem"></a> msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingrun_workitem

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingrun_workitem](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_unifiedroutingrun_workitem)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_liveworkitem`|
|ReferencingEntityNavigationPropertyName|`msdyn_liveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_unifiedroutingrun_msdyn_ocliveworkitem_targetobject"></a> msdyn_msdyn_unifiedroutingrun_msdyn_ocliveworkitem_targetobject

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_msdyn_unifiedroutingrun_msdyn_ocliveworkitem_targetobject](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_unifiedroutingrun_msdyn_ocliveworkitem_targetobject)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_targetobject`|
|ReferencingEntityNavigationPropertyName|`msdyn_targetobject_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_queue_msdyn_unifiedroutingrun_queue"></a> msdyn_queue_msdyn_unifiedroutingrun_queue

One-To-Many Relationship: [queue msdyn_queue_msdyn_unifiedroutingrun_queue](queue.md#BKMK_msdyn_queue_msdyn_unifiedroutingrun_queue)

|Property|Value|
|---|---|
|ReferencedEntity|`queue`|
|ReferencedAttribute|`queueid`|
|ReferencingAttribute|`msdyn_queue`|
|ReferencingEntityNavigationPropertyName|`msdyn_queue`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuser_msdyn_unifiedroutingrun_assignedagent"></a> msdyn_systemuser_msdyn_unifiedroutingrun_assignedagent

One-To-Many Relationship: [systemuser msdyn_systemuser_msdyn_unifiedroutingrun_assignedagent](systemuser.md#BKMK_msdyn_systemuser_msdyn_unifiedroutingrun_assignedagent)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_assignedagent`|
|ReferencingEntityNavigationPropertyName|`msdyn_assignedagent`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_unifiedroutingrun_queueitem_targetobject"></a> msdyn_unifiedroutingrun_queueitem_targetobject

One-To-Many Relationship: [queueitem msdyn_unifiedroutingrun_queueitem_targetobject](queueitem.md#BKMK_msdyn_unifiedroutingrun_queueitem_targetobject)

|Property|Value|
|---|---|
|ReferencedEntity|`queueitem`|
|ReferencedAttribute|`queueitemid`|
|ReferencingAttribute|`msdyn_targetobject`|
|ReferencingEntityNavigationPropertyName|`msdyn_targetobject_queueitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_unifiedroutingrun"></a> owner_msdyn_unifiedroutingrun

One-To-Many Relationship: [owner owner_msdyn_unifiedroutingrun](owner.md#BKMK_owner_msdyn_unifiedroutingrun)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_unifiedroutingrun"></a> team_msdyn_unifiedroutingrun

One-To-Many Relationship: [team team_msdyn_unifiedroutingrun](team.md#BKMK_team_msdyn_unifiedroutingrun)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_unifiedroutingrun"></a> user_msdyn_unifiedroutingrun

One-To-Many Relationship: [systemuser user_msdyn_unifiedroutingrun](systemuser.md#BKMK_user_msdyn_unifiedroutingrun)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_unifiedroutingrun_AsyncOperations](#BKMK_msdyn_unifiedroutingrun_AsyncOperations)
- [msdyn_unifiedroutingrun_BulkDeleteFailures](#BKMK_msdyn_unifiedroutingrun_BulkDeleteFailures)
- [msdyn_unifiedroutingrun_DuplicateBaseRecord](#BKMK_msdyn_unifiedroutingrun_DuplicateBaseRecord)
- [msdyn_unifiedroutingrun_DuplicateMatchingRecord](#BKMK_msdyn_unifiedroutingrun_DuplicateMatchingRecord)
- [msdyn_unifiedroutingrun_MailboxTrackingFolders](#BKMK_msdyn_unifiedroutingrun_MailboxTrackingFolders)
- [msdyn_unifiedroutingrun_msdyn_unifiedroutingdiagnostic](#BKMK_msdyn_unifiedroutingrun_msdyn_unifiedroutingdiagnostic)
- [msdyn_unifiedroutingrun_PrincipalObjectAttributeAccesses](#BKMK_msdyn_unifiedroutingrun_PrincipalObjectAttributeAccesses)
- [msdyn_unifiedroutingrun_ProcessSession](#BKMK_msdyn_unifiedroutingrun_ProcessSession)
- [msdyn_unifiedroutingrun_SyncErrors](#BKMK_msdyn_unifiedroutingrun_SyncErrors)

### <a name="BKMK_msdyn_unifiedroutingrun_AsyncOperations"></a> msdyn_unifiedroutingrun_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_unifiedroutingrun_AsyncOperations](asyncoperation.md#BKMK_msdyn_unifiedroutingrun_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_unifiedroutingrun_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_unifiedroutingrun_BulkDeleteFailures"></a> msdyn_unifiedroutingrun_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_unifiedroutingrun_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_unifiedroutingrun_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_unifiedroutingrun_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_unifiedroutingrun_DuplicateBaseRecord"></a> msdyn_unifiedroutingrun_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_unifiedroutingrun_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_unifiedroutingrun_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_unifiedroutingrun_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_unifiedroutingrun_DuplicateMatchingRecord"></a> msdyn_unifiedroutingrun_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_unifiedroutingrun_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_unifiedroutingrun_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_unifiedroutingrun_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_unifiedroutingrun_MailboxTrackingFolders"></a> msdyn_unifiedroutingrun_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_unifiedroutingrun_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_unifiedroutingrun_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_unifiedroutingrun_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_unifiedroutingrun_msdyn_unifiedroutingdiagnostic"></a> msdyn_unifiedroutingrun_msdyn_unifiedroutingdiagnostic

Many-To-One Relationship: [msdyn_unifiedroutingdiagnostic msdyn_unifiedroutingrun_msdyn_unifiedroutingdiagnostic](msdyn_unifiedroutingdiagnostic.md#BKMK_msdyn_unifiedroutingrun_msdyn_unifiedroutingdiagnostic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_unifiedroutingdiagnostic`|
|ReferencingAttribute|`msdyn_unifiedroutingrunid`|
|ReferencedEntityNavigationPropertyName|`msdyn_unifiedroutingrun_msdyn_unifiedroutingdiagnostic`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_unifiedroutingrun_PrincipalObjectAttributeAccesses"></a> msdyn_unifiedroutingrun_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_unifiedroutingrun_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_unifiedroutingrun_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_unifiedroutingrun_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_unifiedroutingrun_ProcessSession"></a> msdyn_unifiedroutingrun_ProcessSession

Many-To-One Relationship: [processsession msdyn_unifiedroutingrun_ProcessSession](processsession.md#BKMK_msdyn_unifiedroutingrun_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_unifiedroutingrun_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_unifiedroutingrun_SyncErrors"></a> msdyn_unifiedroutingrun_SyncErrors

Many-To-One Relationship: [syncerror msdyn_unifiedroutingrun_SyncErrors](syncerror.md#BKMK_msdyn_unifiedroutingrun_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_unifiedroutingrun_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

