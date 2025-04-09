---
title: "Sequence Target (msdyn_sequencetarget) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Sequence Target (msdyn_sequencetarget) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Sequence Target (msdyn_sequencetarget) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Sequence Target (msdyn_sequencetarget) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_sequencetargets(*msdyn_sequencetargetid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_sequencetargets<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_sequencetargets(*msdyn_sequencetargetid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_sequencetargets(*msdyn_sequencetargetid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_sequencetargets<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_sequencetargets(*msdyn_sequencetargetid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_sequencetargets(*msdyn_sequencetargetid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_sequencetargets(*msdyn_sequencetargetid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Sequence Target (msdyn_sequencetarget) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Sequence Target** |
| **DisplayCollectionName** | **Sequence Targets** |
| **SchemaName** | `msdyn_sequencetarget` |
| **CollectionSchemaName** | `msdyn_sequencetargets` |
| **EntitySetName** | `msdyn_sequencetargets`|
| **LogicalName** | `msdyn_sequencetarget` |
| **LogicalCollectionName** | `msdyn_sequencetargets` |
| **PrimaryIdAttribute** | `msdyn_sequencetargetid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_advancedfromstep](#BKMK_msdyn_advancedfromstep)
- [msdyn_appliedsequenceinstance](#BKMK_msdyn_appliedsequenceinstance)
- [msdyn_currentstepcount](#BKMK_msdyn_currentstepcount)
- [msdyn_currentstepdefinitionid](#BKMK_msdyn_currentstepdefinitionid)
- [msdyn_currentstepname](#BKMK_msdyn_currentstepname)
- [msdyn_currentstepsubtype](#BKMK_msdyn_currentstepsubtype)
- [msdyn_currentsteptype](#BKMK_msdyn_currentsteptype)
- [msdyn_deactivatereason](#BKMK_msdyn_deactivatereason)
- [msdyn_disconnectedafterstepdefinitionid](#BKMK_msdyn_disconnectedafterstepdefinitionid)
- [msdyn_msflowrunid](#BKMK_msdyn_msflowrunid)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_parentsequence](#BKMK_msdyn_parentsequence)
- [msdyn_ParentSequenceVersion](#BKMK_msdyn_ParentSequenceVersion)
- [msdyn_regarding](#BKMK_msdyn_regarding)
- [msdyn_segment](#BKMK_msdyn_segment)
- [msdyn_sequencetargetId](#BKMK_msdyn_sequencetargetId)
- [msdyn_sequencetargetuniquekey](#BKMK_msdyn_sequencetargetuniquekey)
- [msdyn_target](#BKMK_msdyn_target)
- [msdyn_targetIdType](#BKMK_msdyn_targetIdType)
- [msdyn_totalstepcount](#BKMK_msdyn_totalstepcount)
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

### <a name="BKMK_msdyn_advancedfromstep"></a> msdyn_advancedfromstep

|Property|Value|
|---|---|
|Description|**Related Sequence Target Step**|
|DisplayName|**Advanced From Step**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_advancedfromstep`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_sequencetargetstep|

### <a name="BKMK_msdyn_appliedsequenceinstance"></a> msdyn_appliedsequenceinstance

|Property|Value|
|---|---|
|Description||
|DisplayName|**Applied sequence instance**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_appliedsequenceinstance`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_sequence|

### <a name="BKMK_msdyn_currentstepcount"></a> msdyn_currentstepcount

|Property|Value|
|---|---|
|Description|**The current step count for the connected sequence.**|
|DisplayName|**Current Step Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_currentstepcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|400|
|MinValue|0|

### <a name="BKMK_msdyn_currentstepdefinitionid"></a> msdyn_currentstepdefinitionid

|Property|Value|
|---|---|
|Description|**Definition id of the step that is currently in progress.**|
|DisplayName|**Current step definition id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_currentstepdefinitionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_currentstepname"></a> msdyn_currentstepname

|Property|Value|
|---|---|
|Description|**The current step name of the Sequence Target Step entity.**|
|DisplayName|**Current Step**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_currentstepname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_currentstepsubtype"></a> msdyn_currentstepsubtype

|Property|Value|
|---|---|
|Description|**Shows the sub type of sequence target step**|
|DisplayName|**Sequence Target Step Sub Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_currentstepsubtype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_sequencestep_subtype`|

#### msdyn_currentstepsubtype Choices/Options

|Value|Label|
|---|---|
|0|**Default**|
|1|**LinkedInResearch**|
|2|**LinkedInGetIntroduced**|
|3|**LinkedInConnect**|
|4|**LinkedInMail**|
|5|**AdvanceToOtherSequence**|

### <a name="BKMK_msdyn_currentsteptype"></a> msdyn_currentsteptype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_currentsteptype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_sequencestep_type`|

#### msdyn_currentsteptype Choices/Options

|Value|Label|
|---|---|
|0|**Wait**|
|1|**Simple Condition**|
|3|**Automated Email**|
|4|**Auto action**|
|5|**LinkedIn action**|
|6|**Automated text message**|
|7|**Automated Experimentation**|
|4202|**Email**|
|4210|**Phone call**|
|4212|**Task**|
|4213|**Text message**|

### <a name="BKMK_msdyn_deactivatereason"></a> msdyn_deactivatereason

|Property|Value|
|---|---|
|Description|**Reason for deactivation of sequence target**|
|DisplayName|**Deactivate reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_deactivatereason`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_sequencetarget_deactivatereason`|

#### msdyn_deactivatereason Choices/Options

|Value|Label|
|---|---|
|0|**User Disconnected**|
|1|**Parent Sequence Deactivated**|
|2|**Regarding Entity Deactivated**|
|3|**Exit Criterion Met**|
|4|**Sequence Completed**|
|5|**Advanced To Other Sequence**|

### <a name="BKMK_msdyn_disconnectedafterstepdefinitionid"></a> msdyn_disconnectedafterstepdefinitionid

|Property|Value|
|---|---|
|Description|**Definition id of step in Sequence entity after completion of which sequence got disconnected.**|
|DisplayName|**Disconnected after step**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_disconnectedafterstepdefinitionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_msflowrunid"></a> msdyn_msflowrunid

|Property|Value|
|---|---|
|Description|**MS Flow Run Identifier**|
|DisplayName|**MS Flow Run Identifier**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_msflowrunid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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

### <a name="BKMK_msdyn_parentsequence"></a> msdyn_parentsequence

|Property|Value|
|---|---|
|Description||
|DisplayName|**Parent Sequence**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parentsequence`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_sequence|

### <a name="BKMK_msdyn_ParentSequenceVersion"></a> msdyn_ParentSequenceVersion

|Property|Value|
|---|---|
|Description|**Version of the sequence**|
|DisplayName|**Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parentsequenceversion`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|500|
|MinValue|1|

### <a name="BKMK_msdyn_regarding"></a> msdyn_regarding

|Property|Value|
|---|---|
|Description|**The information about record to which this sequence instance is related**|
|DisplayName|**Regarding**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regarding`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_segment"></a> msdyn_segment

|Property|Value|
|---|---|
|Description|**Unique identifier for Segment associated with Sequence Target.**|
|DisplayName|**Segment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_segment`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_segment|

### <a name="BKMK_msdyn_sequencetargetId"></a> msdyn_sequencetargetId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Sales Cadence Target**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_sequencetargetid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_sequencetargetuniquekey"></a> msdyn_sequencetargetuniquekey

|Property|Value|
|---|---|
|Description|**It stores unique key for each record.**|
|DisplayName|**Sequence Target Unique key**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sequencetargetuniquekey`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_msdyn_target"></a> msdyn_target

|Property|Value|
|---|---|
|Description|**Target Record**|
|DisplayName|**Target Record**|
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

### <a name="BKMK_msdyn_totalstepcount"></a> msdyn_totalstepcount

|Property|Value|
|---|---|
|Description|**The total step count for the connected sequence.**|
|DisplayName|**Total Step Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalstepcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|400|
|MinValue|0|

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
|Description|**Status of the Sequence Target**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_sequencetarget_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 3<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Sequence Target**|
|DisplayName|**Progress**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_sequencetarget_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Connecting…**<br />State:0<br />TransitionData: None|
|2|Label: **Connected**<br />State:0<br />TransitionData: None|
|3|Label: **Completed**<br />State:1<br />TransitionData: None|
|4|Label: **Error**<br />State:1<br />TransitionData: None|
|5|Label: **Disconnected**<br />State:1<br />TransitionData: None|

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
|Description|**Date and time when the record was connected to the sequence.**|
|DisplayName|**Connected On**|
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

- [business_unit_msdyn_sequencetarget](#BKMK_business_unit_msdyn_sequencetarget)
- [lk_msdyn_sequencetarget_createdby](#BKMK_lk_msdyn_sequencetarget_createdby)
- [lk_msdyn_sequencetarget_createdonbehalfby](#BKMK_lk_msdyn_sequencetarget_createdonbehalfby)
- [lk_msdyn_sequencetarget_modifiedby](#BKMK_lk_msdyn_sequencetarget_modifiedby)
- [lk_msdyn_sequencetarget_modifiedonbehalfby](#BKMK_lk_msdyn_sequencetarget_modifiedonbehalfby)
- [msdyn_advancedfromstep_msdyn_sequencetarget](#BKMK_msdyn_advancedfromstep_msdyn_sequencetarget)
- [msdyn_segment_msdyn_sequencetarget](#BKMK_msdyn_segment_msdyn_sequencetarget)
- [msdyn_sequence_appliedsequenceinstance](#BKMK_msdyn_sequence_appliedsequenceinstance)
- [msdyn_sequenceparent](#BKMK_msdyn_sequenceparent)
- [msdyn_sequencetarget_account_msdyn_target](#BKMK_msdyn_sequencetarget_account_msdyn_target)
- [msdyn_sequencetarget_contact_msdyn_target](#BKMK_msdyn_sequencetarget_contact_msdyn_target)
- [msdyn_sequencetarget_lead_msdyn_target](#BKMK_msdyn_sequencetarget_lead_msdyn_target)
- [msdyn_sequencetarget_opportunity_msdyn_target](#BKMK_msdyn_sequencetarget_opportunity_msdyn_target)
- [owner_msdyn_sequencetarget](#BKMK_owner_msdyn_sequencetarget)
- [team_msdyn_sequencetarget](#BKMK_team_msdyn_sequencetarget)
- [user_msdyn_sequencetarget](#BKMK_user_msdyn_sequencetarget)

### <a name="BKMK_business_unit_msdyn_sequencetarget"></a> business_unit_msdyn_sequencetarget

One-To-Many Relationship: [businessunit business_unit_msdyn_sequencetarget](businessunit.md#BKMK_business_unit_msdyn_sequencetarget)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sequencetarget_createdby"></a> lk_msdyn_sequencetarget_createdby

One-To-Many Relationship: [systemuser lk_msdyn_sequencetarget_createdby](systemuser.md#BKMK_lk_msdyn_sequencetarget_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sequencetarget_createdonbehalfby"></a> lk_msdyn_sequencetarget_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_sequencetarget_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_sequencetarget_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sequencetarget_modifiedby"></a> lk_msdyn_sequencetarget_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_sequencetarget_modifiedby](systemuser.md#BKMK_lk_msdyn_sequencetarget_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sequencetarget_modifiedonbehalfby"></a> lk_msdyn_sequencetarget_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_sequencetarget_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_sequencetarget_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_advancedfromstep_msdyn_sequencetarget"></a> msdyn_advancedfromstep_msdyn_sequencetarget

One-To-Many Relationship: [msdyn_sequencetargetstep msdyn_advancedfromstep_msdyn_sequencetarget](msdyn_sequencetargetstep.md#BKMK_msdyn_advancedfromstep_msdyn_sequencetarget)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sequencetargetstep`|
|ReferencedAttribute|`msdyn_sequencetargetstepid`|
|ReferencingAttribute|`msdyn_advancedfromstep`|
|ReferencingEntityNavigationPropertyName|`msdyn_advancedfromstep`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_segment_msdyn_sequencetarget"></a> msdyn_segment_msdyn_sequencetarget

One-To-Many Relationship: [msdyn_segment msdyn_segment_msdyn_sequencetarget](msdyn_segment.md#BKMK_msdyn_segment_msdyn_sequencetarget)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_segment`|
|ReferencedAttribute|`msdyn_segmentid`|
|ReferencingAttribute|`msdyn_segment`|
|ReferencingEntityNavigationPropertyName|`msdyn_segment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sequence_appliedsequenceinstance"></a> msdyn_sequence_appliedsequenceinstance

One-To-Many Relationship: [msdyn_sequence msdyn_sequence_appliedsequenceinstance](msdyn_sequence.md#BKMK_msdyn_sequence_appliedsequenceinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sequence`|
|ReferencedAttribute|`msdyn_sequenceid`|
|ReferencingAttribute|`msdyn_appliedsequenceinstance`|
|ReferencingEntityNavigationPropertyName|`msdyn_appliedsequenceinstance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sequenceparent"></a> msdyn_sequenceparent

One-To-Many Relationship: [msdyn_sequence msdyn_sequenceparent](msdyn_sequence.md#BKMK_msdyn_sequenceparent)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sequence`|
|ReferencedAttribute|`msdyn_sequenceid`|
|ReferencingAttribute|`msdyn_parentsequence`|
|ReferencingEntityNavigationPropertyName|`msdyn_parentsequence`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sequencetarget_account_msdyn_target"></a> msdyn_sequencetarget_account_msdyn_target

One-To-Many Relationship: [account msdyn_sequencetarget_account_msdyn_target](account.md#BKMK_msdyn_sequencetarget_account_msdyn_target)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_target`|
|ReferencingEntityNavigationPropertyName|`msdyn_target`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sequencetarget_contact_msdyn_target"></a> msdyn_sequencetarget_contact_msdyn_target

One-To-Many Relationship: [contact msdyn_sequencetarget_contact_msdyn_target](contact.md#BKMK_msdyn_sequencetarget_contact_msdyn_target)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyn_target`|
|ReferencingEntityNavigationPropertyName|`msdyn_target`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sequencetarget_lead_msdyn_target"></a> msdyn_sequencetarget_lead_msdyn_target

One-To-Many Relationship: [lead msdyn_sequencetarget_lead_msdyn_target](lead.md#BKMK_msdyn_sequencetarget_lead_msdyn_target)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`msdyn_target`|
|ReferencingEntityNavigationPropertyName|`msdyn_target`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sequencetarget_opportunity_msdyn_target"></a> msdyn_sequencetarget_opportunity_msdyn_target

One-To-Many Relationship: [opportunity msdyn_sequencetarget_opportunity_msdyn_target](opportunity.md#BKMK_msdyn_sequencetarget_opportunity_msdyn_target)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`msdyn_target`|
|ReferencingEntityNavigationPropertyName|`msdyn_target`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_sequencetarget"></a> owner_msdyn_sequencetarget

One-To-Many Relationship: [owner owner_msdyn_sequencetarget](owner.md#BKMK_owner_msdyn_sequencetarget)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_sequencetarget"></a> team_msdyn_sequencetarget

One-To-Many Relationship: [team team_msdyn_sequencetarget](team.md#BKMK_team_msdyn_sequencetarget)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_sequencetarget"></a> user_msdyn_sequencetarget

One-To-Many Relationship: [systemuser user_msdyn_sequencetarget](systemuser.md#BKMK_user_msdyn_sequencetarget)

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

- [msdyn_sequencetarget_AsyncOperations](#BKMK_msdyn_sequencetarget_AsyncOperations)
- [msdyn_sequencetarget_BulkDeleteFailures](#BKMK_msdyn_sequencetarget_BulkDeleteFailures)
- [msdyn_sequencetarget_connections1](#BKMK_msdyn_sequencetarget_connections1)
- [msdyn_sequencetarget_connections2](#BKMK_msdyn_sequencetarget_connections2)
- [msdyn_sequencetarget_DuplicateBaseRecord](#BKMK_msdyn_sequencetarget_DuplicateBaseRecord)
- [msdyn_sequencetarget_DuplicateMatchingRecord](#BKMK_msdyn_sequencetarget_DuplicateMatchingRecord)
- [msdyn_sequencetarget_MailboxTrackingFolders](#BKMK_msdyn_sequencetarget_MailboxTrackingFolders)
- [msdyn_sequencetarget_PrincipalObjectAttributeAccesses](#BKMK_msdyn_sequencetarget_PrincipalObjectAttributeAccesses)
- [msdyn_sequencetarget_ProcessSession](#BKMK_msdyn_sequencetarget_ProcessSession)
- [msdyn_sequencetarget_sequencetargetstep](#BKMK_msdyn_sequencetarget_sequencetargetstep)
- [msdyn_sequencetarget_SyncErrors](#BKMK_msdyn_sequencetarget_SyncErrors)

### <a name="BKMK_msdyn_sequencetarget_AsyncOperations"></a> msdyn_sequencetarget_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_sequencetarget_AsyncOperations](asyncoperation.md#BKMK_msdyn_sequencetarget_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetarget_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequencetarget_BulkDeleteFailures"></a> msdyn_sequencetarget_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_sequencetarget_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_sequencetarget_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetarget_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequencetarget_connections1"></a> msdyn_sequencetarget_connections1

Many-To-One Relationship: [connection msdyn_sequencetarget_connections1](connection.md#BKMK_msdyn_sequencetarget_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetarget_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequencetarget_connections2"></a> msdyn_sequencetarget_connections2

Many-To-One Relationship: [connection msdyn_sequencetarget_connections2](connection.md#BKMK_msdyn_sequencetarget_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetarget_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequencetarget_DuplicateBaseRecord"></a> msdyn_sequencetarget_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_sequencetarget_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_sequencetarget_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetarget_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequencetarget_DuplicateMatchingRecord"></a> msdyn_sequencetarget_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_sequencetarget_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_sequencetarget_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetarget_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequencetarget_MailboxTrackingFolders"></a> msdyn_sequencetarget_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_sequencetarget_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_sequencetarget_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetarget_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequencetarget_PrincipalObjectAttributeAccesses"></a> msdyn_sequencetarget_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_sequencetarget_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_sequencetarget_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetarget_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequencetarget_ProcessSession"></a> msdyn_sequencetarget_ProcessSession

Many-To-One Relationship: [processsession msdyn_sequencetarget_ProcessSession](processsession.md#BKMK_msdyn_sequencetarget_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetarget_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequencetarget_sequencetargetstep"></a> msdyn_sequencetarget_sequencetargetstep

Many-To-One Relationship: [msdyn_sequencetargetstep msdyn_sequencetarget_sequencetargetstep](msdyn_sequencetargetstep.md#BKMK_msdyn_sequencetarget_sequencetargetstep)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencetargetstep`|
|ReferencingAttribute|`msdyn_sequencetarget`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetarget_sequencetargetstep`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequencetarget_SyncErrors"></a> msdyn_sequencetarget_SyncErrors

Many-To-One Relationship: [syncerror msdyn_sequencetarget_SyncErrors](syncerror.md#BKMK_msdyn_sequencetarget_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetarget_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

