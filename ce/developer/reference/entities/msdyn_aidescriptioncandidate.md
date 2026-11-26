---
title: "msdyn_aidescriptioncandidate table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the msdyn_aidescriptioncandidate table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# msdyn_aidescriptioncandidate table/entity reference (Microsoft Dynamics 365)

One row per field value per run.

## Messages

The following table lists the messages for the msdyn_aidescriptioncandidate table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_aidescriptioncandidates(*msdyn_aidescriptioncandidateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_aidescriptioncandidates<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_aidescriptioncandidates(*msdyn_aidescriptioncandidateid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_aidescriptioncandidates(*msdyn_aidescriptioncandidateid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_aidescriptioncandidates<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_aidescriptioncandidates(*msdyn_aidescriptioncandidateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_aidescriptioncandidates(*msdyn_aidescriptioncandidateid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_aidescriptioncandidates(*msdyn_aidescriptioncandidateid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the msdyn_aidescriptioncandidate table.

|Property|Value|
| --- | --- |
| **DisplayName** | **msdyn_aidescriptioncandidate** |
| **DisplayCollectionName** | **msdyn_aidescriptioncandidates** |
| **SchemaName** | `msdyn_aidescriptioncandidate` |
| **CollectionSchemaName** | `msdyn_aidescriptioncandidates` |
| **EntitySetName** | `msdyn_aidescriptioncandidates`|
| **LogicalName** | `msdyn_aidescriptioncandidate` |
| **LogicalCollectionName** | `msdyn_aidescriptioncandidates` |
| **PrimaryIdAttribute** | `msdyn_aidescriptioncandidateid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_adaptivek](#BKMK_msdyn_adaptivek)
- [msdyn_aidescriptioncandidateId](#BKMK_msdyn_aidescriptioncandidateId)
- [msdyn_aidescriptionrunid](#BKMK_msdyn_aidescriptionrunid)
- [msdyn_displayvalue](#BKMK_msdyn_displayvalue)
- [msdyn_entitylogicalname](#BKMK_msdyn_entitylogicalname)
- [msdyn_errordetails](#BKMK_msdyn_errordetails)
- [msdyn_fieldlogicalname](#BKMK_msdyn_fieldlogicalname)
- [msdyn_generateddescription](#BKMK_msdyn_generateddescription)
- [msdyn_hasdraftchanges](#BKMK_msdyn_hasdraftchanges)
- [msdyn_holdcount](#BKMK_msdyn_holdcount)
- [msdyn_initialdescription](#BKMK_msdyn_initialdescription)
- [msdyn_islowdata](#BKMK_msdyn_islowdata)
- [msdyn_language](#BKMK_msdyn_language)
- [msdyn_lastimprovedround](#BKMK_msdyn_lastimprovedround)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_status](#BKMK_msdyn_status)
- [msdyn_targetrowid](#BKMK_msdyn_targetrowid)
- [msdyn_topksiblingsjson](#BKMK_msdyn_topksiblingsjson)
- [msdyn_traincount](#BKMK_msdyn_traincount)
- [msdyn_valcount](#BKMK_msdyn_valcount)
- [msdyn_valuekey](#BKMK_msdyn_valuekey)
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

### <a name="BKMK_IsCustomizable"></a> IsCustomizable

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Is Customizable**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`iscustomizable`|
|RequiredLevel|SystemRequired|
|Type|ManagedProperty|

### <a name="BKMK_msdyn_adaptivek"></a> msdyn_adaptivek

|Property|Value|
|---|---|
|Description|**Number of sibling values to defend (0 means never rewritten).**|
|DisplayName|**Adaptive K**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_adaptivek`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_aidescriptioncandidateId"></a> msdyn_aidescriptioncandidateId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances.**|
|DisplayName|**AI Description Candidate**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_aidescriptioncandidateid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_aidescriptionrunid"></a> msdyn_aidescriptionrunid

|Property|Value|
|---|---|
|Description|**Foreign key to the run.**|
|DisplayName|**AI Description Run**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_aidescriptionrunid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_aidescriptionrun|

### <a name="BKMK_msdyn_displayvalue"></a> msdyn_displayvalue

|Property|Value|
|---|---|
|Description|**Human-readable label for the value (e.g. Refund).**|
|DisplayName|**Display Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_displayvalue`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|800|

### <a name="BKMK_msdyn_entitylogicalname"></a> msdyn_entitylogicalname

|Property|Value|
|---|---|
|Description|**Denormalized entity name to query without joining through run.**|
|DisplayName|**Entity Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entitylogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_errordetails"></a> msdyn_errordetails

|Property|Value|
|---|---|
|Description|**Error details if generation failed.**|
|DisplayName|**Error Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_errordetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_fieldlogicalname"></a> msdyn_fieldlogicalname

|Property|Value|
|---|---|
|Description|**Logical name of the field. Alternate key component.**|
|DisplayName|**Field Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fieldlogicalname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_generateddescription"></a> msdyn_generateddescription

|Property|Value|
|---|---|
|Description|**Latest generated description.**|
|DisplayName|**Generated Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_generateddescription`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_hasdraftchanges"></a> msdyn_hasdraftchanges

|Property|Value|
|---|---|
|Description|**True if generated description differs from initial.**|
|DisplayName|**Has Draft Changes**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_hasdraftchanges`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_aidescriptioncandidate_msdyn_hasdraftchanges`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_holdcount"></a> msdyn_holdcount

|Property|Value|
|---|---|
|Description|**Holdout split size for this candidate (never evaluated).**|
|DisplayName|**Hold Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_holdcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_initialdescription"></a> msdyn_initialdescription

|Property|Value|
|---|---|
|Description|**Snapshot at run start (optimization diff view).**|
|DisplayName|**Initial Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_initialdescription`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_islowdata"></a> msdyn_islowdata

|Property|Value|
|---|---|
|Description|**True if below the MinPerCandidate sample floor.**|
|DisplayName|**Is Low Data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_islowdata`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_aidescriptioncandidate_msdyn_islowdata`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_language"></a> msdyn_language

|Property|Value|
|---|---|
|Description|**BCP-47 language tag. Alternate key component.**|
|DisplayName|**Language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_language`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10|

### <a name="BKMK_msdyn_lastimprovedround"></a> msdyn_lastimprovedround

|Property|Value|
|---|---|
|Description|**Round that last improved this value.**|
|DisplayName|**Last Improved Round**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastimprovedround`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Primary name.**|
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
|MaxLength|800|

### <a name="BKMK_msdyn_status"></a> msdyn_status

|Property|Value|
|---|---|
|Description|**Candidate lifecycle status.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_status`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|700610000|
|GlobalChoiceName|`msdyn_aidescriptioncandidate_msdyn_status`|

#### msdyn_status Choices/Options

|Value|Label|
|---|---|
|700610000|**Pending**|
|700610001|**Generated**|
|700610002|**Approved**|
|700610003|**Discarded**|
|700610004|**Published**|
|700610005|**Failed**|
|700610006|**ReadyForRewrite**|
|700610007|**Rewritten**|

### <a name="BKMK_msdyn_targetrowid"></a> msdyn_targetrowid

|Property|Value|
|---|---|
|Description|**Target-entity row id (value-key GUID string). Written at candidate creation; used by DescriptionWriter and Revert.**|
|DisplayName|**Target Row Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_targetrowid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_topksiblingsjson"></a> msdyn_topksiblingsjson

|Property|Value|
|---|---|
|Description|**Ordered sibling list plus adaptive-K audit (MinAbsEffUsed, CutoffUsed).**|
|DisplayName|**Top K Siblings JSON**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_topksiblingsjson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdyn_traincount"></a> msdyn_traincount

|Property|Value|
|---|---|
|Description|**Train split size for this candidate.**|
|DisplayName|**Train Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_traincount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_valcount"></a> msdyn_valcount

|Property|Value|
|---|---|
|Description|**Validation split size for this candidate.**|
|DisplayName|**Val Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_valcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_valuekey"></a> msdyn_valuekey

|Property|Value|
|---|---|
|Description|**OptionSet int value or Lookup record GUID. Alternate key component.**|
|DisplayName|**Value Key**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_valuekey`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|Description|**Status.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_aidescriptioncandidate_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_aidescriptioncandidate_statuscode`|

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

- [ComponentIdUnique](#BKMK_ComponentIdUnique)
- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OverwriteTime](#BKMK_OverwriteTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_ComponentIdUnique"></a> ComponentIdUnique

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Row id unique**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentidunique`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Component State**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentstate`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`componentstate`|

#### ComponentState Choices/Options

|Value|Label|
|---|---|
|0|**Published**|
|1|**Unpublished**|
|2|**Deleted**|
|3|**Deleted Unpublished**|

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

### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|---|---|
|Description|**Indicates whether the solution component is part of a managed solution.**|
|DisplayName|**Is Managed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ismanaged`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`ismanaged`|
|DefaultValue|False|
|True Label|Managed|
|False Label|Unmanaged|

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

### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Record Overwrite Time**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overwritetime`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

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
|Description|**Unique identifier for the business unit that owns the record.**|
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

### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|---|---|
|Description|**Unique identifier of the associated solution.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`solutionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`supportingsolutionid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

- [business_unit_msdyn_aidescriptioncandidate](#BKMK_business_unit_msdyn_aidescriptioncandidate)
- [lk_msdyn_aidescriptioncandidate_createdby](#BKMK_lk_msdyn_aidescriptioncandidate_createdby)
- [lk_msdyn_aidescriptioncandidate_createdonbehalfby](#BKMK_lk_msdyn_aidescriptioncandidate_createdonbehalfby)
- [lk_msdyn_aidescriptioncandidate_modifiedby](#BKMK_lk_msdyn_aidescriptioncandidate_modifiedby)
- [lk_msdyn_aidescriptioncandidate_modifiedonbehalfby](#BKMK_lk_msdyn_aidescriptioncandidate_modifiedonbehalfby)
- [msdyn_aidescriptioncandidate_msdyn_aidescriptionrunid_msdyn_aidescriptionrun](#BKMK_msdyn_aidescriptioncandidate_msdyn_aidescriptionrunid_msdyn_aidescriptionrun)
- [owner_msdyn_aidescriptioncandidate](#BKMK_owner_msdyn_aidescriptioncandidate)
- [team_msdyn_aidescriptioncandidate](#BKMK_team_msdyn_aidescriptioncandidate)
- [user_msdyn_aidescriptioncandidate](#BKMK_user_msdyn_aidescriptioncandidate)

### <a name="BKMK_business_unit_msdyn_aidescriptioncandidate"></a> business_unit_msdyn_aidescriptioncandidate

One-To-Many Relationship: [businessunit business_unit_msdyn_aidescriptioncandidate](businessunit.md#BKMK_business_unit_msdyn_aidescriptioncandidate)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aidescriptioncandidate_createdby"></a> lk_msdyn_aidescriptioncandidate_createdby

One-To-Many Relationship: [systemuser lk_msdyn_aidescriptioncandidate_createdby](systemuser.md#BKMK_lk_msdyn_aidescriptioncandidate_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aidescriptioncandidate_createdonbehalfby"></a> lk_msdyn_aidescriptioncandidate_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_aidescriptioncandidate_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_aidescriptioncandidate_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aidescriptioncandidate_modifiedby"></a> lk_msdyn_aidescriptioncandidate_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_aidescriptioncandidate_modifiedby](systemuser.md#BKMK_lk_msdyn_aidescriptioncandidate_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aidescriptioncandidate_modifiedonbehalfby"></a> lk_msdyn_aidescriptioncandidate_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_aidescriptioncandidate_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_aidescriptioncandidate_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_aidescriptioncandidate_msdyn_aidescriptionrunid_msdyn_aidescriptionrun"></a> msdyn_aidescriptioncandidate_msdyn_aidescriptionrunid_msdyn_aidescriptionrun

One-To-Many Relationship: [msdyn_aidescriptionrun msdyn_aidescriptioncandidate_msdyn_aidescriptionrunid_msdyn_aidescriptionrun](msdyn_aidescriptionrun.md#BKMK_msdyn_aidescriptioncandidate_msdyn_aidescriptionrunid_msdyn_aidescriptionrun)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_aidescriptionrun`|
|ReferencedAttribute|`msdyn_aidescriptionrunid`|
|ReferencingAttribute|`msdyn_aidescriptionrunid`|
|ReferencingEntityNavigationPropertyName|`msdyn_aidescriptionrunid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_aidescriptioncandidate"></a> owner_msdyn_aidescriptioncandidate

One-To-Many Relationship: [owner owner_msdyn_aidescriptioncandidate](owner.md#BKMK_owner_msdyn_aidescriptioncandidate)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_aidescriptioncandidate"></a> team_msdyn_aidescriptioncandidate

One-To-Many Relationship: [team team_msdyn_aidescriptioncandidate](team.md#BKMK_team_msdyn_aidescriptioncandidate)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_aidescriptioncandidate"></a> user_msdyn_aidescriptioncandidate

One-To-Many Relationship: [systemuser user_msdyn_aidescriptioncandidate](systemuser.md#BKMK_user_msdyn_aidescriptioncandidate)

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

- [msdyn_aidescriptioncandidate_AsyncOperations](#BKMK_msdyn_aidescriptioncandidate_AsyncOperations)
- [msdyn_aidescriptioncandidate_BulkDeleteFailures](#BKMK_msdyn_aidescriptioncandidate_BulkDeleteFailures)
- [msdyn_aidescriptioncandidate_DuplicateBaseRecord](#BKMK_msdyn_aidescriptioncandidate_DuplicateBaseRecord)
- [msdyn_aidescriptioncandidate_DuplicateMatchingRecord](#BKMK_msdyn_aidescriptioncandidate_DuplicateMatchingRecord)
- [msdyn_aidescriptioncandidate_MailboxTrackingFolders](#BKMK_msdyn_aidescriptioncandidate_MailboxTrackingFolders)
- [msdyn_aidescriptioncandidate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_aidescriptioncandidate_PrincipalObjectAttributeAccesses)
- [msdyn_aidescriptioncandidate_ProcessSession](#BKMK_msdyn_aidescriptioncandidate_ProcessSession)
- [msdyn_aidescriptioncandidate_SyncErrors](#BKMK_msdyn_aidescriptioncandidate_SyncErrors)

### <a name="BKMK_msdyn_aidescriptioncandidate_AsyncOperations"></a> msdyn_aidescriptioncandidate_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_aidescriptioncandidate_AsyncOperations](asyncoperation.md#BKMK_msdyn_aidescriptioncandidate_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescriptioncandidate_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescriptioncandidate_BulkDeleteFailures"></a> msdyn_aidescriptioncandidate_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_aidescriptioncandidate_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_aidescriptioncandidate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescriptioncandidate_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescriptioncandidate_DuplicateBaseRecord"></a> msdyn_aidescriptioncandidate_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_aidescriptioncandidate_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_aidescriptioncandidate_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescriptioncandidate_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescriptioncandidate_DuplicateMatchingRecord"></a> msdyn_aidescriptioncandidate_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_aidescriptioncandidate_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_aidescriptioncandidate_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescriptioncandidate_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescriptioncandidate_MailboxTrackingFolders"></a> msdyn_aidescriptioncandidate_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_aidescriptioncandidate_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_aidescriptioncandidate_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescriptioncandidate_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescriptioncandidate_PrincipalObjectAttributeAccesses"></a> msdyn_aidescriptioncandidate_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_aidescriptioncandidate_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_aidescriptioncandidate_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescriptioncandidate_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescriptioncandidate_ProcessSession"></a> msdyn_aidescriptioncandidate_ProcessSession

Many-To-One Relationship: [processsession msdyn_aidescriptioncandidate_ProcessSession](processsession.md#BKMK_msdyn_aidescriptioncandidate_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescriptioncandidate_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aidescriptioncandidate_SyncErrors"></a> msdyn_aidescriptioncandidate_SyncErrors

Many-To-One Relationship: [syncerror msdyn_aidescriptioncandidate_SyncErrors](syncerror.md#BKMK_msdyn_aidescriptioncandidate_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescriptioncandidate_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

