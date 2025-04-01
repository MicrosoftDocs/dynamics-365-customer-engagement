---
title: "Sequence Target Step (msdyn_sequencetargetstep) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Sequence Target Step (msdyn_sequencetargetstep) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Sequence Target Step (msdyn_sequencetargetstep) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Sequence Target Step (msdyn_sequencetargetstep) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_sequencetargetsteps(*msdyn_sequencetargetstepid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_sequencetargetsteps<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_sequencetargetsteps(*msdyn_sequencetargetstepid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_sequencetargetsteps(*msdyn_sequencetargetstepid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_sequencetargetsteps<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_sequencetargetsteps(*msdyn_sequencetargetstepid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_sequencetargetsteps(*msdyn_sequencetargetstepid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_sequencetargetsteps(*msdyn_sequencetargetstepid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Sequence Target Step (msdyn_sequencetargetstep) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Sequence Target Step** |
| **DisplayCollectionName** | **Sequence Target Steps** |
| **SchemaName** | `msdyn_sequencetargetstep` |
| **CollectionSchemaName** | `msdyn_sequencetargetsteps` |
| **EntitySetName** | `msdyn_sequencetargetsteps`|
| **LogicalName** | `msdyn_sequencetargetstep` |
| **LogicalCollectionName** | `msdyn_sequencetargetsteps` |
| **PrimaryIdAttribute** | `msdyn_sequencetargetstepid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_advancedfromstep](#BKMK_msdyn_advancedfromstep)
- [msdyn_advancedfromwaitstate](#BKMK_msdyn_advancedfromwaitstate)
- [msdyn_completedon](#BKMK_msdyn_completedon)
- [msdyn_convertedtomanualfrom](#BKMK_msdyn_convertedtomanualfrom)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_duetime](#BKMK_msdyn_duetime)
- [msdyn_errorstate](#BKMK_msdyn_errorstate)
- [msdyn_linkedactivityid](#BKMK_msdyn_linkedactivityid)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_operationparameter](#BKMK_msdyn_operationparameter)
- [msdyn_sequenceduetime](#BKMK_msdyn_sequenceduetime)
- [msdyn_sequencestepId](#BKMK_msdyn_sequencestepId)
- [msdyn_sequencetarget](#BKMK_msdyn_sequencetarget)
- [msdyn_sequencetargetstepId](#BKMK_msdyn_sequencetargetstepId)
- [msdyn_snoozecount](#BKMK_msdyn_snoozecount)
- [msdyn_subtype](#BKMK_msdyn_subtype)
- [msdyn_triggeroutcome](#BKMK_msdyn_triggeroutcome)
- [msdyn_type](#BKMK_msdyn_type)
- [msdyn_waitskippedon](#BKMK_msdyn_waitskippedon)
- [msdyn_waitstate](#BKMK_msdyn_waitstate)
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

### <a name="BKMK_msdyn_advancedfromwaitstate"></a> msdyn_advancedfromwaitstate

|Property|Value|
|---|---|
|Description|**Select state of waiting on advanced from sequence step**|
|DisplayName|**Advanced from step wait state**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_advancedfromwaitstate`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_sequencestep_advancedfromwaitstate`|

#### msdyn_advancedfromwaitstate Choices/Options

|Value|Label|
|---|---|
|0|**NA**|
|1|**None**|
|2|**Waiting**|
|3|**Waiting Completed**|

### <a name="BKMK_msdyn_completedon"></a> msdyn_completedon

|Property|Value|
|---|---|
|Description|**Date and time when the record was marked completed.**|
|DisplayName|**Completed On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_completedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_convertedtomanualfrom"></a> msdyn_convertedtomanualfrom

|Property|Value|
|---|---|
|Description|**Shows which msdyn_sequencestep_type this was before it was converted to current step type**|
|DisplayName|**Converted To Manual From**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_convertedtomanualfrom`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_sequencestep_type`|

#### msdyn_convertedtomanualfrom Choices/Options

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

### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|---|---|
|Description|**Description for Sequence target step**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_duetime"></a> msdyn_duetime

|Property|Value|
|---|---|
|Description|**Actual due time for Sequence target step**|
|DisplayName|**Due time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_duetime`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_errorstate"></a> msdyn_errorstate

|Property|Value|
|---|---|
|Description|**Select the error state for sequence step**|
|DisplayName|**Error state**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_errorstate`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_sequencestep_errorstate`|

#### msdyn_errorstate Choices/Options

|Value|Label|
|---|---|
|0|**NA**|
|1|**Field update failed**|
|2|**Automated text message failed**|
|3|**Use email template failed**|

### <a name="BKMK_msdyn_linkedactivityid"></a> msdyn_linkedactivityid

|Property|Value|
|---|---|
|Description|**Unique identifier of the activity linked to the sequence step**|
|DisplayName|**Linked activity id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_linkedactivityid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the Sequence Target step entity.**|
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

### <a name="BKMK_msdyn_operationparameter"></a> msdyn_operationparameter

|Property|Value|
|---|---|
|Description|**Parameter for operation in Sequence target step**|
|DisplayName|**Operation Parameter**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_operationparameter`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

### <a name="BKMK_msdyn_sequenceduetime"></a> msdyn_sequenceduetime

|Property|Value|
|---|---|
|Description|**Sequence proposed due time for Sequence target step**|
|DisplayName|**Sequence due time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sequenceduetime`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_sequencestepId"></a> msdyn_sequencestepId

|Property|Value|
|---|---|
|Description|**Unique Identifier for step in Sequence entity**|
|DisplayName|**Sequence Step Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sequencestepid`|
|RequiredLevel|ApplicationRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_sequencetarget"></a> msdyn_sequencetarget

|Property|Value|
|---|---|
|Description|**Related Sequence Target**|
|DisplayName|**Sequence Target**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sequencetarget`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_sequencetarget|

### <a name="BKMK_msdyn_sequencetargetstepId"></a> msdyn_sequencetargetstepId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity Sequence Target Step**|
|DisplayName|**Sequence Target Step**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_sequencetargetstepid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_snoozecount"></a> msdyn_snoozecount

|Property|Value|
|---|---|
|Description|**Number of times sequence step is snoozed.**|
|DisplayName|**Snooze count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_snoozecount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|10000|
|MinValue|0|

### <a name="BKMK_msdyn_subtype"></a> msdyn_subtype

|Property|Value|
|---|---|
|Description|**Shows the sub type of sequence target step**|
|DisplayName|**Sequence Target Sub Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_subtype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_sequencestep_subtype`|

#### msdyn_subtype Choices/Options

|Value|Label|
|---|---|
|0|**Default**|
|1|**LinkedInResearch**|
|2|**LinkedInGetIntroduced**|
|3|**LinkedInConnect**|
|4|**LinkedInMail**|
|5|**AdvanceToOtherSequence**|

### <a name="BKMK_msdyn_triggeroutcome"></a> msdyn_triggeroutcome

|Property|Value|
|---|---|
|Description|**Outcome of the trigger associated with step**|
|DisplayName|**Trigger outcome**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_triggeroutcome`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_type"></a> msdyn_type

|Property|Value|
|---|---|
|Description||
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_type`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_sequencestep_type`|

#### msdyn_type Choices/Options

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

### <a name="BKMK_msdyn_waitskippedon"></a> msdyn_waitskippedon

|Property|Value|
|---|---|
|Description|**Date time when wait associated with step is skipped**|
|DisplayName|**Wait skipped on**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_waitskippedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_waitstate"></a> msdyn_waitstate

|Property|Value|
|---|---|
|Description|**Select whether wait step is pending or skipped**|
|DisplayName|**Wait state**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_waitstate`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_sequencestep_waitstate`|

#### msdyn_waitstate Choices/Options

|Value|Label|
|---|---|
|0|**NA**|
|1|**Waiting**|
|2|**Skipped**|
|3|**Waiting for update**|
|4|**Waiting completed**|

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
|Description|**Status of the Sequence Target Step**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_sequencetargetstep_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Sequence Target Step**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_sequencetargetstep_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Open**<br />State:0<br />TransitionData: None|
|2|Label: **Completed**<br />State:1<br />TransitionData: None|
|3|Label: **Skipped**<br />State:1<br />TransitionData: None|
|4|Label: **Cancelled**<br />State:1<br />TransitionData: None|

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

- [business_unit_msdyn_sequencetargetstep](#BKMK_business_unit_msdyn_sequencetargetstep)
- [lk_msdyn_sequencetargetstep_createdby](#BKMK_lk_msdyn_sequencetargetstep_createdby)
- [lk_msdyn_sequencetargetstep_createdonbehalfby](#BKMK_lk_msdyn_sequencetargetstep_createdonbehalfby)
- [lk_msdyn_sequencetargetstep_modifiedby](#BKMK_lk_msdyn_sequencetargetstep_modifiedby)
- [lk_msdyn_sequencetargetstep_modifiedonbehalfby](#BKMK_lk_msdyn_sequencetargetstep_modifiedonbehalfby)
- [msdyn_advancedfromstep_msdyn_sequencetargetstep](#BKMK_msdyn_advancedfromstep_msdyn_sequencetargetstep-many-to-one)
- [msdyn_sequencetarget_sequencetargetstep](#BKMK_msdyn_sequencetarget_sequencetargetstep)
- [owner_msdyn_sequencetargetstep](#BKMK_owner_msdyn_sequencetargetstep)
- [team_msdyn_sequencetargetstep](#BKMK_team_msdyn_sequencetargetstep)
- [user_msdyn_sequencetargetstep](#BKMK_user_msdyn_sequencetargetstep)

### <a name="BKMK_business_unit_msdyn_sequencetargetstep"></a> business_unit_msdyn_sequencetargetstep

One-To-Many Relationship: [businessunit business_unit_msdyn_sequencetargetstep](businessunit.md#BKMK_business_unit_msdyn_sequencetargetstep)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sequencetargetstep_createdby"></a> lk_msdyn_sequencetargetstep_createdby

One-To-Many Relationship: [systemuser lk_msdyn_sequencetargetstep_createdby](systemuser.md#BKMK_lk_msdyn_sequencetargetstep_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sequencetargetstep_createdonbehalfby"></a> lk_msdyn_sequencetargetstep_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_sequencetargetstep_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_sequencetargetstep_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sequencetargetstep_modifiedby"></a> lk_msdyn_sequencetargetstep_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_sequencetargetstep_modifiedby](systemuser.md#BKMK_lk_msdyn_sequencetargetstep_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sequencetargetstep_modifiedonbehalfby"></a> lk_msdyn_sequencetargetstep_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_sequencetargetstep_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_sequencetargetstep_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_advancedfromstep_msdyn_sequencetargetstep-many-to-one"></a> msdyn_advancedfromstep_msdyn_sequencetargetstep

One-To-Many Relationship: [msdyn_sequencetargetstep msdyn_advancedfromstep_msdyn_sequencetargetstep](#BKMK_msdyn_advancedfromstep_msdyn_sequencetargetstep-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sequencetargetstep`|
|ReferencedAttribute|`msdyn_sequencetargetstepid`|
|ReferencingAttribute|`msdyn_advancedfromstep`|
|ReferencingEntityNavigationPropertyName|`msdyn_advancedfromstep`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sequencetarget_sequencetargetstep"></a> msdyn_sequencetarget_sequencetargetstep

One-To-Many Relationship: [msdyn_sequencetarget msdyn_sequencetarget_sequencetargetstep](msdyn_sequencetarget.md#BKMK_msdyn_sequencetarget_sequencetargetstep)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sequencetarget`|
|ReferencedAttribute|`msdyn_sequencetargetid`|
|ReferencingAttribute|`msdyn_sequencetarget`|
|ReferencingEntityNavigationPropertyName|`msdyn_sequencetarget`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_sequencetargetstep"></a> owner_msdyn_sequencetargetstep

One-To-Many Relationship: [owner owner_msdyn_sequencetargetstep](owner.md#BKMK_owner_msdyn_sequencetargetstep)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_sequencetargetstep"></a> team_msdyn_sequencetargetstep

One-To-Many Relationship: [team team_msdyn_sequencetargetstep](team.md#BKMK_team_msdyn_sequencetargetstep)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_sequencetargetstep"></a> user_msdyn_sequencetargetstep

One-To-Many Relationship: [systemuser user_msdyn_sequencetargetstep](systemuser.md#BKMK_user_msdyn_sequencetargetstep)

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

- [msdyn_advancedfromstep_msdyn_sequencetarget](#BKMK_msdyn_advancedfromstep_msdyn_sequencetarget)
- [msdyn_advancedfromstep_msdyn_sequencetargetstep](#BKMK_msdyn_advancedfromstep_msdyn_sequencetargetstep-one-to-many)
- [msdyn_sequencetargetstep_AsyncOperations](#BKMK_msdyn_sequencetargetstep_AsyncOperations)
- [msdyn_sequencetargetstep_BulkDeleteFailures](#BKMK_msdyn_sequencetargetstep_BulkDeleteFailures)
- [msdyn_sequencetargetstep_MailboxTrackingFolders](#BKMK_msdyn_sequencetargetstep_MailboxTrackingFolders)
- [msdyn_sequencetargetstep_PrincipalObjectAttributeAccesses](#BKMK_msdyn_sequencetargetstep_PrincipalObjectAttributeAccesses)
- [msdyn_sequencetargetstep_ProcessSession](#BKMK_msdyn_sequencetargetstep_ProcessSession)
- [msdyn_sequencetargetstep_SyncErrors](#BKMK_msdyn_sequencetargetstep_SyncErrors)

### <a name="BKMK_msdyn_advancedfromstep_msdyn_sequencetarget"></a> msdyn_advancedfromstep_msdyn_sequencetarget

Many-To-One Relationship: [msdyn_sequencetarget msdyn_advancedfromstep_msdyn_sequencetarget](msdyn_sequencetarget.md#BKMK_msdyn_advancedfromstep_msdyn_sequencetarget)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencetarget`|
|ReferencingAttribute|`msdyn_advancedfromstep`|
|ReferencedEntityNavigationPropertyName|`msdyn_advancedfromstep_msdyn_sequencetargetstep`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_advancedfromstep_msdyn_sequencetargetstep-one-to-many"></a> msdyn_advancedfromstep_msdyn_sequencetargetstep

Many-To-One Relationship: [msdyn_sequencetargetstep msdyn_advancedfromstep_msdyn_sequencetargetstep](#BKMK_msdyn_advancedfromstep_msdyn_sequencetargetstep-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencetargetstep`|
|ReferencingAttribute|`msdyn_advancedfromstep`|
|ReferencedEntityNavigationPropertyName|`msdyn_advancedfromstep_msdyn_sequencetarget`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequencetargetstep_AsyncOperations"></a> msdyn_sequencetargetstep_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_sequencetargetstep_AsyncOperations](asyncoperation.md#BKMK_msdyn_sequencetargetstep_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetargetstep_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequencetargetstep_BulkDeleteFailures"></a> msdyn_sequencetargetstep_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_sequencetargetstep_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_sequencetargetstep_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetargetstep_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequencetargetstep_MailboxTrackingFolders"></a> msdyn_sequencetargetstep_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_sequencetargetstep_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_sequencetargetstep_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetargetstep_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequencetargetstep_PrincipalObjectAttributeAccesses"></a> msdyn_sequencetargetstep_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_sequencetargetstep_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_sequencetargetstep_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetargetstep_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequencetargetstep_ProcessSession"></a> msdyn_sequencetargetstep_ProcessSession

Many-To-One Relationship: [processsession msdyn_sequencetargetstep_ProcessSession](processsession.md#BKMK_msdyn_sequencetargetstep_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetargetstep_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequencetargetstep_SyncErrors"></a> msdyn_sequencetargetstep_SyncErrors

Many-To-One Relationship: [syncerror msdyn_sequencetargetstep_SyncErrors](syncerror.md#BKMK_msdyn_sequencetargetstep_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetargetstep_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

