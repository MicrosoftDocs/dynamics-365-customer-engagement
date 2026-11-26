---
title: "Gatekeeper Engagement Context (msdyn_ocgatekeeperengagementctx) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Gatekeeper Engagement Context (msdyn_ocgatekeeperengagementctx) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Gatekeeper Engagement Context (msdyn_ocgatekeeperengagementctx) table/entity reference (Microsoft Dynamics 365 Customer Service)

Gatekeeper engagement context

## Messages

The following table lists the messages for the Gatekeeper Engagement Context (msdyn_ocgatekeeperengagementctx) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_ocgatekeeperengagementctxes(*msdyn_ocgatekeeperengagementctxid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_ocgatekeeperengagementctxes<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocgatekeeperengagementctxes(*msdyn_ocgatekeeperengagementctxid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocgatekeeperengagementctxes(*msdyn_ocgatekeeperengagementctxid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocgatekeeperengagementctxes<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocgatekeeperengagementctxes(*msdyn_ocgatekeeperengagementctxid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocgatekeeperengagementctxes(*msdyn_ocgatekeeperengagementctxid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocgatekeeperengagementctxes(*msdyn_ocgatekeeperengagementctxid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Gatekeeper Engagement Context (msdyn_ocgatekeeperengagementctx) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Gatekeeper Engagement Context** |
| **DisplayCollectionName** | **Gatekeeper Engagement Contexts** |
| **SchemaName** | `msdyn_ocgatekeeperengagementctx` |
| **CollectionSchemaName** | `msdyn_ocgatekeeperengagementctxes` |
| **EntitySetName** | `msdyn_ocgatekeeperengagementctxes`|
| **LogicalName** | `msdyn_ocgatekeeperengagementctx` |
| **LogicalCollectionName** | `msdyn_ocgatekeeperengagementctxes` |
| **PrimaryIdAttribute** | `msdyn_ocgatekeeperengagementctxid` |
| **PrimaryNameAttribute** |`msdyn_gatekeeperpersonid` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_enrollstatus](#BKMK_msdyn_enrollstatus)
- [msdyn_gatekeeperpersonid](#BKMK_msdyn_gatekeeperpersonid)
- [msdyn_issuspicious](#BKMK_msdyn_issuspicious)
- [msdyn_issuspiciousreason](#BKMK_msdyn_issuspiciousreason)
- [msdyn_liveworkitemid](#BKMK_msdyn_liveworkitemid)
- [msdyn_ocgatekeeperengagementctxId](#BKMK_msdyn_ocgatekeeperengagementctxId)
- [msdyn_optedoutreason](#BKMK_msdyn_optedoutreason)
- [msdyn_optstatus](#BKMK_msdyn_optstatus)
- [msdyn_verificationstatus](#BKMK_msdyn_verificationstatus)
- [msdyn_verificationstatusreason](#BKMK_msdyn_verificationstatusreason)
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

### <a name="BKMK_msdyn_enrollstatus"></a> msdyn_enrollstatus

|Property|Value|
|---|---|
|Description|**Gatekeeper customer enrollment status.**|
|DisplayName|**Enrollment status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enrollstatus`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_gatekeeperpersonid"></a> msdyn_gatekeeperpersonid

|Property|Value|
|---|---|
|Description|**Id used to identify a person with Gatekeeper authentication.**|
|DisplayName|**Gatekeeper person id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_gatekeeperpersonid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_issuspicious"></a> msdyn_issuspicious

|Property|Value|
|---|---|
|Description|**Marking a customer as suspicious and potentially fraud.**|
|DisplayName|**Is suspicious**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_issuspicious`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocgatekeeperengagementctx_msdyn_issuspicious`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_issuspiciousreason"></a> msdyn_issuspiciousreason

|Property|Value|
|---|---|
|Description|**Reason for marking person as suspicious.**|
|DisplayName|**Suspicious reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_issuspiciousreason`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_liveworkitemid"></a> msdyn_liveworkitemid

|Property|Value|
|---|---|
|Description|**Unique identifier for Conversation associated with Gatekeeper Engagement Context.**|
|DisplayName|**Conversation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_liveworkitemid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocliveworkitem|

### <a name="BKMK_msdyn_ocgatekeeperengagementctxId"></a> msdyn_ocgatekeeperengagementctxId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**ocgatekeeperengagementctx**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ocgatekeeperengagementctxid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_optedoutreason"></a> msdyn_optedoutreason

|Property|Value|
|---|---|
|Description|**Reason for opting out of Gatekeeper authentication.**|
|DisplayName|**Opted out reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_optedoutreason`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_optstatus"></a> msdyn_optstatus

|Property|Value|
|---|---|
|Description|**Specifies whether a person has opted into or out of Gatekeeper authentication.**|
|DisplayName|**Opt status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_optstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|615860000|
|GlobalChoiceName|`msdyn_ocgatekeeperengagementctx_msdyn_optstatus`|

#### msdyn_optstatus Choices/Options

|Value|Label|
|---|---|
|615860000|**Unspecified**|
|615860001|**OptedIn**|
|615860002|**OptedOut**|

### <a name="BKMK_msdyn_verificationstatus"></a> msdyn_verificationstatus

|Property|Value|
|---|---|
|Description|**Shows the customer verification status.**|
|DisplayName|**Verification status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_verificationstatus`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_verificationstatusreason"></a> msdyn_verificationstatusreason

|Property|Value|
|---|---|
|Description|**Provides the reason behind the verification result.**|
|DisplayName|**Verification status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_verificationstatusreason`|
|RequiredLevel|None|
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
|Description|**Status of the ocgatekeeperengagementctx**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocgatekeeperengagementctx_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the ocgatekeeperengagementctx**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocgatekeeperengagementctx_statuscode`|

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

- [business_unit_msdyn_ocgatekeeperengagementctx](#BKMK_business_unit_msdyn_ocgatekeeperengagementctx)
- [lk_msdyn_ocgatekeeperengagementctx_createdby](#BKMK_lk_msdyn_ocgatekeeperengagementctx_createdby)
- [lk_msdyn_ocgatekeeperengagementctx_createdonbehalfby](#BKMK_lk_msdyn_ocgatekeeperengagementctx_createdonbehalfby)
- [lk_msdyn_ocgatekeeperengagementctx_modifiedby](#BKMK_lk_msdyn_ocgatekeeperengagementctx_modifiedby)
- [lk_msdyn_ocgatekeeperengagementctx_modifiedonbehalfby](#BKMK_lk_msdyn_ocgatekeeperengagementctx_modifiedonbehalfby)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocgatekeeperengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocgatekeeperengagementctx_liveworkitemid)
- [owner_msdyn_ocgatekeeperengagementctx](#BKMK_owner_msdyn_ocgatekeeperengagementctx)
- [team_msdyn_ocgatekeeperengagementctx](#BKMK_team_msdyn_ocgatekeeperengagementctx)
- [user_msdyn_ocgatekeeperengagementctx](#BKMK_user_msdyn_ocgatekeeperengagementctx)

### <a name="BKMK_business_unit_msdyn_ocgatekeeperengagementctx"></a> business_unit_msdyn_ocgatekeeperengagementctx

One-To-Many Relationship: [businessunit business_unit_msdyn_ocgatekeeperengagementctx](businessunit.md#BKMK_business_unit_msdyn_ocgatekeeperengagementctx)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocgatekeeperengagementctx_createdby"></a> lk_msdyn_ocgatekeeperengagementctx_createdby

One-To-Many Relationship: [systemuser lk_msdyn_ocgatekeeperengagementctx_createdby](systemuser.md#BKMK_lk_msdyn_ocgatekeeperengagementctx_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocgatekeeperengagementctx_createdonbehalfby"></a> lk_msdyn_ocgatekeeperengagementctx_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocgatekeeperengagementctx_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_ocgatekeeperengagementctx_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocgatekeeperengagementctx_modifiedby"></a> lk_msdyn_ocgatekeeperengagementctx_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_ocgatekeeperengagementctx_modifiedby](systemuser.md#BKMK_lk_msdyn_ocgatekeeperengagementctx_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocgatekeeperengagementctx_modifiedonbehalfby"></a> lk_msdyn_ocgatekeeperengagementctx_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocgatekeeperengagementctx_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_ocgatekeeperengagementctx_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocgatekeeperengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocgatekeeperengagementctx_liveworkitemid

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_msdyn_ocliveworkitem_msdyn_ocgatekeeperengagementctx_liveworkitemid](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocgatekeeperengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencingEntityNavigationPropertyName|`msdyn_liveworkitemid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_ocgatekeeperengagementctx"></a> owner_msdyn_ocgatekeeperengagementctx

One-To-Many Relationship: [owner owner_msdyn_ocgatekeeperengagementctx](owner.md#BKMK_owner_msdyn_ocgatekeeperengagementctx)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_ocgatekeeperengagementctx"></a> team_msdyn_ocgatekeeperengagementctx

One-To-Many Relationship: [team team_msdyn_ocgatekeeperengagementctx](team.md#BKMK_team_msdyn_ocgatekeeperengagementctx)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_ocgatekeeperengagementctx"></a> user_msdyn_ocgatekeeperengagementctx

One-To-Many Relationship: [systemuser user_msdyn_ocgatekeeperengagementctx](systemuser.md#BKMK_user_msdyn_ocgatekeeperengagementctx)

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

- [msdyn_ocgatekeeperengagementctx_AsyncOperations](#BKMK_msdyn_ocgatekeeperengagementctx_AsyncOperations)
- [msdyn_ocgatekeeperengagementctx_BulkDeleteFailures](#BKMK_msdyn_ocgatekeeperengagementctx_BulkDeleteFailures)
- [msdyn_ocgatekeeperengagementctx_DuplicateBaseRecord](#BKMK_msdyn_ocgatekeeperengagementctx_DuplicateBaseRecord)
- [msdyn_ocgatekeeperengagementctx_DuplicateMatchingRecord](#BKMK_msdyn_ocgatekeeperengagementctx_DuplicateMatchingRecord)
- [msdyn_ocgatekeeperengagementctx_MailboxTrackingFolders](#BKMK_msdyn_ocgatekeeperengagementctx_MailboxTrackingFolders)
- [msdyn_ocgatekeeperengagementctx_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocgatekeeperengagementctx_PrincipalObjectAttributeAccesses)
- [msdyn_ocgatekeeperengagementctx_ProcessSession](#BKMK_msdyn_ocgatekeeperengagementctx_ProcessSession)
- [msdyn_ocgatekeeperengagementctx_SyncErrors](#BKMK_msdyn_ocgatekeeperengagementctx_SyncErrors)

### <a name="BKMK_msdyn_ocgatekeeperengagementctx_AsyncOperations"></a> msdyn_ocgatekeeperengagementctx_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocgatekeeperengagementctx_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocgatekeeperengagementctx_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgatekeeperengagementctx_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgatekeeperengagementctx_BulkDeleteFailures"></a> msdyn_ocgatekeeperengagementctx_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocgatekeeperengagementctx_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocgatekeeperengagementctx_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgatekeeperengagementctx_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgatekeeperengagementctx_DuplicateBaseRecord"></a> msdyn_ocgatekeeperengagementctx_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocgatekeeperengagementctx_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ocgatekeeperengagementctx_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgatekeeperengagementctx_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgatekeeperengagementctx_DuplicateMatchingRecord"></a> msdyn_ocgatekeeperengagementctx_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocgatekeeperengagementctx_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ocgatekeeperengagementctx_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgatekeeperengagementctx_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgatekeeperengagementctx_MailboxTrackingFolders"></a> msdyn_ocgatekeeperengagementctx_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocgatekeeperengagementctx_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocgatekeeperengagementctx_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgatekeeperengagementctx_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgatekeeperengagementctx_PrincipalObjectAttributeAccesses"></a> msdyn_ocgatekeeperengagementctx_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocgatekeeperengagementctx_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocgatekeeperengagementctx_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgatekeeperengagementctx_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgatekeeperengagementctx_ProcessSession"></a> msdyn_ocgatekeeperengagementctx_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocgatekeeperengagementctx_ProcessSession](processsession.md#BKMK_msdyn_ocgatekeeperengagementctx_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgatekeeperengagementctx_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgatekeeperengagementctx_SyncErrors"></a> msdyn_ocgatekeeperengagementctx_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocgatekeeperengagementctx_SyncErrors](syncerror.md#BKMK_msdyn_ocgatekeeperengagementctx_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgatekeeperengagementctx_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

