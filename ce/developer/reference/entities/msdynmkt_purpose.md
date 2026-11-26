---
title: "Purpose (msdynmkt_purpose) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Purpose (msdynmkt_purpose) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Purpose (msdynmkt_purpose) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Purpose (msdynmkt_purpose) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_purposes(*msdynmkt_purposeid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdynmkt_purposes<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_purposes(*msdynmkt_purposeid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_purposes(*msdynmkt_purposeid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_purposes<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_purposes(*msdynmkt_purposeid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_purposes(*msdynmkt_purposeid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_purposes(*msdynmkt_purposeid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Purpose (msdynmkt_purpose) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Purpose** |
| **DisplayCollectionName** | **Purposes** |
| **SchemaName** | `msdynmkt_purpose` |
| **CollectionSchemaName** | `msdynmkt_purposes` |
| **EntitySetName** | `msdynmkt_purposes`|
| **LogicalName** | `msdynmkt_purpose` |
| **LogicalCollectionName** | `msdynmkt_purposes` |
| **PrimaryIdAttribute** | `msdynmkt_purposeid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdynmkt_customenforcementmodel](#BKMK_msdynmkt_customenforcementmodel)
- [msdynmkt_description](#BKMK_msdynmkt_description)
- [msdynmkt_enforcementmodel](#BKMK_msdynmkt_enforcementmodel)
- [msdynmkt_extendedentityId](#BKMK_msdynmkt_extendedentityId)
- [msdynmkt_extendedentityIdType](#BKMK_msdynmkt_extendedentityIdType)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_purposeId](#BKMK_msdynmkt_purposeId)
- [msdynmkt_smsenforcementmodel](#BKMK_msdynmkt_smsenforcementmodel)
- [msdynmkt_topiccount](#BKMK_msdynmkt_topiccount)
- [msdynmkt_type](#BKMK_msdynmkt_type)
- [msdynmkt_uionlycomplianceprofilelookup](#BKMK_msdynmkt_uionlycomplianceprofilelookup)
- [msdynmkt_uionlypurposelookup](#BKMK_msdynmkt_uionlypurposelookup)
- [msdynmkt_voiceenforcementmodel](#BKMK_msdynmkt_voiceenforcementmodel)
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

### <a name="BKMK_msdynmkt_customenforcementmodel"></a> msdynmkt_customenforcementmodel

|Property|Value|
|---|---|
|Description|**Enforcement model for custom channel.**|
|DisplayName|**Custom Enforcement Model**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_customenforcementmodel`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|534120000|
|GlobalChoiceName|`msdynmkt_purposeenforcementmodel`|

#### msdynmkt_customenforcementmodel Choices/Options

|Value|Label|
|---|---|
|534120000|**Restrictive**|
|534120001|**Non-Restrictive**|
|534120002|**Disabled**|

### <a name="BKMK_msdynmkt_description"></a> msdynmkt_description

|Property|Value|
|---|---|
|Description|**the description of the purpose**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_description`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_enforcementmodel"></a> msdynmkt_enforcementmodel

|Property|Value|
|---|---|
|Description|**enforcement model of purpose**|
|DisplayName|**Email Enforcement Model**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_enforcementmodel`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_purposeenforcementmodel`|

#### msdynmkt_enforcementmodel Choices/Options

|Value|Label|
|---|---|
|534120000|**Restrictive**|
|534120001|**Non-Restrictive**|
|534120002|**Disabled**|

### <a name="BKMK_msdynmkt_extendedentityId"></a> msdynmkt_extendedentityId

|Property|Value|
|---|---|
|Description|**LookUp for Extended Entities brought in by custom channels.**|
|DisplayName|**Extended Entity Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_extendedentityid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_consentproviderdefaultpurpose|

### <a name="BKMK_msdynmkt_extendedentityIdType"></a> msdynmkt_extendedentityIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_extendedentityidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdynmkt_name"></a> msdynmkt_name

|Property|Value|
|---|---|
|Description|**The name of the purpose**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_purposeId"></a> msdynmkt_purposeId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Purpose**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_purposeid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_smsenforcementmodel"></a> msdynmkt_smsenforcementmodel

|Property|Value|
|---|---|
|Description|**Enforcement model for SMS channel.**|
|DisplayName|**SMS Enforcement Model**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_smsenforcementmodel`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|534120000|
|GlobalChoiceName|`msdynmkt_purposeenforcementmodel`|

#### msdynmkt_smsenforcementmodel Choices/Options

|Value|Label|
|---|---|
|534120000|**Restrictive**|
|534120001|**Non-Restrictive**|
|534120002|**Disabled**|

### <a name="BKMK_msdynmkt_topiccount"></a> msdynmkt_topiccount

|Property|Value|
|---|---|
|Description|**Number of topics associated with this purpose**|
|DisplayName|**Topics**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_topiccount`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdynmkt_type"></a> msdynmkt_type

|Property|Value|
|---|---|
|Description|**Purpose Type (Commerical, Transactional, Tracking)**|
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_type`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_purposetype`|

#### msdynmkt_type Choices/Options

|Value|Label|
|---|---|
|534120000|**Commercial Communication**|
|534120001|**Transactional Communication**|
|534120002|**Tracking**|

### <a name="BKMK_msdynmkt_uionlycomplianceprofilelookup"></a> msdynmkt_uionlycomplianceprofilelookup

|Property|Value|
|---|---|
|Description|**UIOnly Compliance profile lookup**|
|DisplayName|**Compliance profile lookup**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_uionlycomplianceprofilelookup`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_compliancesettings4|

### <a name="BKMK_msdynmkt_uionlypurposelookup"></a> msdynmkt_uionlypurposelookup

|Property|Value|
|---|---|
|Description|**Purpose lookup**|
|DisplayName|**UIOnly Purpose lookup**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_uionlypurposelookup`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_purpose|

### <a name="BKMK_msdynmkt_voiceenforcementmodel"></a> msdynmkt_voiceenforcementmodel

|Property|Value|
|---|---|
|Description|**Enforcement model for Voice channel.**|
|DisplayName|**Voice Enforcement Model**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_voiceenforcementmodel`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|534120000|
|GlobalChoiceName|`msdynmkt_purposeenforcementmodel`|

#### msdynmkt_voiceenforcementmodel Choices/Options

|Value|Label|
|---|---|
|534120000|**Restrictive**|
|534120001|**Non-Restrictive**|
|534120002|**Disabled**|

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
|Description|**Status of the Purpose**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_purpose_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Purpose**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_purpose_statuscode`|

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
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Business Unit**|
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

- [business_unit_msdynmkt_purpose](#BKMK_business_unit_msdynmkt_purpose)
- [lk_msdynmkt_purpose_createdby](#BKMK_lk_msdynmkt_purpose_createdby)
- [lk_msdynmkt_purpose_createdonbehalfby](#BKMK_lk_msdynmkt_purpose_createdonbehalfby)
- [lk_msdynmkt_purpose_modifiedby](#BKMK_lk_msdynmkt_purpose_modifiedby)
- [lk_msdynmkt_purpose_modifiedonbehalfby](#BKMK_lk_msdynmkt_purpose_modifiedonbehalfby)
- [msdynmkt_msdynmkt_uionly_compliancesettings4_lookup](#BKMK_msdynmkt_msdynmkt_uionly_compliancesettings4_lookup)
- [msdynmkt_msdynmkt_uionly_purpose_lookup](#BKMK_msdynmkt_msdynmkt_uionly_purpose_lookup-many-to-one)
- [msdynmkt_purpose_msdynmkt_consentproviderdefaultpurpose](#BKMK_msdynmkt_purpose_msdynmkt_consentproviderdefaultpurpose)
- [owner_msdynmkt_purpose](#BKMK_owner_msdynmkt_purpose)
- [team_msdynmkt_purpose](#BKMK_team_msdynmkt_purpose)
- [user_msdynmkt_purpose](#BKMK_user_msdynmkt_purpose)

### <a name="BKMK_business_unit_msdynmkt_purpose"></a> business_unit_msdynmkt_purpose

One-To-Many Relationship: [businessunit business_unit_msdynmkt_purpose](businessunit.md#BKMK_business_unit_msdynmkt_purpose)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_purpose_createdby"></a> lk_msdynmkt_purpose_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_purpose_createdby](systemuser.md#BKMK_lk_msdynmkt_purpose_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_purpose_createdonbehalfby"></a> lk_msdynmkt_purpose_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_purpose_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_purpose_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_purpose_modifiedby"></a> lk_msdynmkt_purpose_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_purpose_modifiedby](systemuser.md#BKMK_lk_msdynmkt_purpose_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_purpose_modifiedonbehalfby"></a> lk_msdynmkt_purpose_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_purpose_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_purpose_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_uionly_compliancesettings4_lookup"></a> msdynmkt_msdynmkt_uionly_compliancesettings4_lookup

One-To-Many Relationship: [msdynmkt_compliancesettings4 msdynmkt_msdynmkt_uionly_compliancesettings4_lookup](msdynmkt_compliancesettings4.md#BKMK_msdynmkt_msdynmkt_uionly_compliancesettings4_lookup)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_compliancesettings4`|
|ReferencedAttribute|`msdynmkt_compliancesettings4id`|
|ReferencingAttribute|`msdynmkt_uionlycomplianceprofilelookup`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_uionlycomplianceprofilelookup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_uionly_purpose_lookup-many-to-one"></a> msdynmkt_msdynmkt_uionly_purpose_lookup

One-To-Many Relationship: [msdynmkt_purpose msdynmkt_msdynmkt_uionly_purpose_lookup](#BKMK_msdynmkt_msdynmkt_uionly_purpose_lookup-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_purpose`|
|ReferencedAttribute|`msdynmkt_purposeid`|
|ReferencingAttribute|`msdynmkt_uionlypurposelookup`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_uionlypurposelookup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_purpose_msdynmkt_consentproviderdefaultpurpose"></a> msdynmkt_purpose_msdynmkt_consentproviderdefaultpurpose

One-To-Many Relationship: [msdynmkt_consentproviderdefaultpurpose msdynmkt_purpose_msdynmkt_consentproviderdefaultpurpose](msdynmkt_consentproviderdefaultpurpose.md#BKMK_msdynmkt_purpose_msdynmkt_consentproviderdefaultpurpose)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_consentproviderdefaultpurpose`|
|ReferencedAttribute|`msdynmkt_consentproviderdefaultpurposeid`|
|ReferencingAttribute|`msdynmkt_extendedentityid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_extendedentityId_msdynmkt_consentproviderdefaultpurpose`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_purpose"></a> owner_msdynmkt_purpose

One-To-Many Relationship: [owner owner_msdynmkt_purpose](owner.md#BKMK_owner_msdynmkt_purpose)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_purpose"></a> team_msdynmkt_purpose

One-To-Many Relationship: [team team_msdynmkt_purpose](team.md#BKMK_team_msdynmkt_purpose)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_purpose"></a> user_msdynmkt_purpose

One-To-Many Relationship: [systemuser user_msdynmkt_purpose](systemuser.md#BKMK_user_msdynmkt_purpose)

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

- [msdynmkt_msdynmkt_compliancesettings4_TrackingCons](#BKMK_msdynmkt_msdynmkt_compliancesettings4_TrackingCons)
- [msdynmkt_msdynmkt_contactpointconsent4_purposeId_m](#BKMK_msdynmkt_msdynmkt_contactpointconsent4_purposeId_m)
- [msdynmkt_msdynmkt_purpose_msdynmkt_topic](#BKMK_msdynmkt_msdynmkt_purpose_msdynmkt_topic)
- [msdynmkt_msdynmkt_uionly_purpose_lookup](#BKMK_msdynmkt_msdynmkt_uionly_purpose_lookup-one-to-many)
- [msdynmkt_purpose_AsyncOperations](#BKMK_msdynmkt_purpose_AsyncOperations)
- [msdynmkt_purpose_BulkDeleteFailures](#BKMK_msdynmkt_purpose_BulkDeleteFailures)
- [msdynmkt_purpose_DuplicateBaseRecord](#BKMK_msdynmkt_purpose_DuplicateBaseRecord)
- [msdynmkt_purpose_DuplicateMatchingRecord](#BKMK_msdynmkt_purpose_DuplicateMatchingRecord)
- [msdynmkt_purpose_MailboxTrackingFolders](#BKMK_msdynmkt_purpose_MailboxTrackingFolders)
- [msdynmkt_purpose_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_purpose_PrincipalObjectAttributeAccesses)
- [msdynmkt_purpose_ProcessSession](#BKMK_msdynmkt_purpose_ProcessSession)
- [msdynmkt_purpose_SyncErrors](#BKMK_msdynmkt_purpose_SyncErrors)

### <a name="BKMK_msdynmkt_msdynmkt_compliancesettings4_TrackingCons"></a> msdynmkt_msdynmkt_compliancesettings4_TrackingCons

Many-To-One Relationship: [msdynmkt_compliancesettings4 msdynmkt_msdynmkt_compliancesettings4_TrackingCons](msdynmkt_compliancesettings4.md#BKMK_msdynmkt_msdynmkt_compliancesettings4_TrackingCons)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_compliancesettings4`|
|ReferencingAttribute|`msdynmkt_trackingconsentpurpose`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_msdynmkt_compliancesettings4_TrackingCons`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_msdynmkt_contactpointconsent4_purposeId_m"></a> msdynmkt_msdynmkt_contactpointconsent4_purposeId_m

Many-To-One Relationship: [msdynmkt_contactpointconsent4 msdynmkt_msdynmkt_contactpointconsent4_purposeId_m](msdynmkt_contactpointconsent4.md#BKMK_msdynmkt_msdynmkt_contactpointconsent4_purposeId_m)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_contactpointconsent4`|
|ReferencingAttribute|`msdynmkt_purposeid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_msdynmkt_contactpointconsent4_purposeId_m`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_msdynmkt_purpose_msdynmkt_topic"></a> msdynmkt_msdynmkt_purpose_msdynmkt_topic

Many-To-One Relationship: [msdynmkt_topic msdynmkt_msdynmkt_purpose_msdynmkt_topic](msdynmkt_topic.md#BKMK_msdynmkt_msdynmkt_purpose_msdynmkt_topic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_topic`|
|ReferencingAttribute|`msdynmkt_purposeid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_msdynmkt_purpose_msdynmkt_topic`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_msdynmkt_uionly_purpose_lookup-one-to-many"></a> msdynmkt_msdynmkt_uionly_purpose_lookup

Many-To-One Relationship: [msdynmkt_purpose msdynmkt_msdynmkt_uionly_purpose_lookup](#BKMK_msdynmkt_msdynmkt_uionly_purpose_lookup-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_purpose`|
|ReferencingAttribute|`msdynmkt_uionlypurposelookup`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_msdynmkt_uionly_purpose_lookup`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_purpose_AsyncOperations"></a> msdynmkt_purpose_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_purpose_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_purpose_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_purpose_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_purpose_BulkDeleteFailures"></a> msdynmkt_purpose_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_purpose_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_purpose_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_purpose_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_purpose_DuplicateBaseRecord"></a> msdynmkt_purpose_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_purpose_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdynmkt_purpose_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_purpose_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_purpose_DuplicateMatchingRecord"></a> msdynmkt_purpose_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_purpose_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdynmkt_purpose_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_purpose_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_purpose_MailboxTrackingFolders"></a> msdynmkt_purpose_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_purpose_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_purpose_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_purpose_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_purpose_PrincipalObjectAttributeAccesses"></a> msdynmkt_purpose_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_purpose_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_purpose_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_purpose_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_purpose_ProcessSession"></a> msdynmkt_purpose_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_purpose_ProcessSession](processsession.md#BKMK_msdynmkt_purpose_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_purpose_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_purpose_SyncErrors"></a> msdynmkt_purpose_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_purpose_SyncErrors](syncerror.md#BKMK_msdynmkt_purpose_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_purpose_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdynmkt_msdynmkt_purpose_msdynmkt_compliancev4"></a> msdynmkt_msdynmkt_purpose_msdynmkt_compliancev4

See [msdynmkt_compliancesettings4 msdynmkt_msdynmkt_purpose_msdynmkt_compliancev4 Many-To-Many Relationship](msdynmkt_compliancesettings4.md#BKMK_msdynmkt_msdynmkt_purpose_msdynmkt_compliancev4)

|Property|Value|
|---|---|
|IntersectEntityName|`msdynmkt_msdynmkt_purpose_msdynmkt_compliancev4`|
|IsCustomizable|False|
|SchemaName|`msdynmkt_msdynmkt_purpose_msdynmkt_compliancev4`|
|IntersectAttribute|`msdynmkt_purposeid`|
|NavigationPropertyName|`msdynmkt_msdynmkt_purpose_msdynmkt_compliancev4`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

