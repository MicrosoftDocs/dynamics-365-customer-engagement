---
title: "Google's Business Messages engagement context (msdyn_ocgooglebusinessmessagesengagementctx) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Google's Business Messages engagement context (msdyn_ocgooglebusinessmessagesengagementctx) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Google's Business Messages engagement context (msdyn_ocgooglebusinessmessagesengagementctx) table/entity reference (Microsoft Dynamics 365 Customer Service)

Google's Business Messages engagement context

## Messages

The following table lists the messages for the Google's Business Messages engagement context (msdyn_ocgooglebusinessmessagesengagementctx) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_ocgooglebusinessmessagesengagementctxes(*msdyn_ocgooglebusinessmessagesengagementctxid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_ocgooglebusinessmessagesengagementctxes<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocgooglebusinessmessagesengagementctxes(*msdyn_ocgooglebusinessmessagesengagementctxid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocgooglebusinessmessagesengagementctxes(*msdyn_ocgooglebusinessmessagesengagementctxid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocgooglebusinessmessagesengagementctxes<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocgooglebusinessmessagesengagementctxes(*msdyn_ocgooglebusinessmessagesengagementctxid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocgooglebusinessmessagesengagementctxes(*msdyn_ocgooglebusinessmessagesengagementctxid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocgooglebusinessmessagesengagementctxes(*msdyn_ocgooglebusinessmessagesengagementctxid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Google's Business Messages engagement context (msdyn_ocgooglebusinessmessagesengagementctx) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Google's Business Messages engagement context** |
| **DisplayCollectionName** | **Google's Business Messages engagement contexts** |
| **SchemaName** | `msdyn_ocgooglebusinessmessagesengagementctx` |
| **CollectionSchemaName** | `msdyn_ocgooglebusinessmessagesengagementctxes` |
| **EntitySetName** | `msdyn_ocgooglebusinessmessagesengagementctxes`|
| **LogicalName** | `msdyn_ocgooglebusinessmessagesengagementctx` |
| **LogicalCollectionName** | `msdyn_ocgooglebusinessmessagesengagementctxes` |
| **PrimaryIdAttribute** | `msdyn_ocgooglebusinessmessagesengagementctxid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_customerid](#BKMK_msdyn_customerid)
- [msdyn_entrypoint](#BKMK_msdyn_entrypoint)
- [msdyn_liveworkitemid](#BKMK_msdyn_liveworkitemid)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ocgooglebusinessmessagesengagementctxId](#BKMK_msdyn_ocgooglebusinessmessagesengagementctxId)
- [msdyn_placeid](#BKMK_msdyn_placeid)
- [msdyn_resolvedlocale](#BKMK_msdyn_resolvedlocale)
- [msdyn_userdevicelocale](#BKMK_msdyn_userdevicelocale)
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

### <a name="BKMK_msdyn_customerid"></a> msdyn_customerid

|Property|Value|
|---|---|
|Description|**Customer id of the Google's Business Messages engagement context.**|
|DisplayName|**Customer id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customerid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_entrypoint"></a> msdyn_entrypoint

|Property|Value|
|---|---|
|Description|**Entry point of the Google's Business Messages engagement context.**|
|DisplayName|**Entry point**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entrypoint`|
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
|Description|**Live work item id of the Google's Business Messages engagement context.**|
|DisplayName|**Live work item id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_liveworkitemid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocliveworkitem|

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

### <a name="BKMK_msdyn_ocgooglebusinessmessagesengagementctxId"></a> msdyn_ocgooglebusinessmessagesengagementctxId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Google's Business Messages engagement context**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ocgooglebusinessmessagesengagementctxid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_placeid"></a> msdyn_placeid

|Property|Value|
|---|---|
|Description|**Place id of the Google's Business Messages engagement context.**|
|DisplayName|**Place id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_placeid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_resolvedlocale"></a> msdyn_resolvedlocale

|Property|Value|
|---|---|
|Description|**Resolved locale of the Google's Business Messages engagement context.**|
|DisplayName|**Resolved locale**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_resolvedlocale`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_userdevicelocale"></a> msdyn_userdevicelocale

|Property|Value|
|---|---|
|Description|**User device locale of the Google's Business Messages engagement context.**|
|DisplayName|**User device locale**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_userdevicelocale`|
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
|Description|**Status of the Google's Business Messages engagement context**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocgooglebusinessmessagesengagementctx_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Google's Business Messages engagement context**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocgooglebusinessmessagesengagementctx_statuscode`|

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

- [business_unit_msdyn_ocgooglebusinessmessagesengagementctx](#BKMK_business_unit_msdyn_ocgooglebusinessmessagesengagementctx)
- [lk_msdyn_ocgooglebusinessmessagesengagementctx_createdby](#BKMK_lk_msdyn_ocgooglebusinessmessagesengagementctx_createdby)
- [lk_msdyn_ocgooglebusinessmessagesengagementctx_createdonbehalfby](#BKMK_lk_msdyn_ocgooglebusinessmessagesengagementctx_createdonbehalfby)
- [lk_msdyn_ocgooglebusinessmessagesengagementctx_modifiedby](#BKMK_lk_msdyn_ocgooglebusinessmessagesengagementctx_modifiedby)
- [lk_msdyn_ocgooglebusinessmessagesengagementctx_modifiedonbehalfby](#BKMK_lk_msdyn_ocgooglebusinessmessagesengagementctx_modifiedonbehalfby)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid)
- [owner_msdyn_ocgooglebusinessmessagesengagementctx](#BKMK_owner_msdyn_ocgooglebusinessmessagesengagementctx)
- [team_msdyn_ocgooglebusinessmessagesengagementctx](#BKMK_team_msdyn_ocgooglebusinessmessagesengagementctx)
- [user_msdyn_ocgooglebusinessmessagesengagementctx](#BKMK_user_msdyn_ocgooglebusinessmessagesengagementctx)

### <a name="BKMK_business_unit_msdyn_ocgooglebusinessmessagesengagementctx"></a> business_unit_msdyn_ocgooglebusinessmessagesengagementctx

One-To-Many Relationship: [businessunit business_unit_msdyn_ocgooglebusinessmessagesengagementctx](businessunit.md#BKMK_business_unit_msdyn_ocgooglebusinessmessagesengagementctx)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocgooglebusinessmessagesengagementctx_createdby"></a> lk_msdyn_ocgooglebusinessmessagesengagementctx_createdby

One-To-Many Relationship: [systemuser lk_msdyn_ocgooglebusinessmessagesengagementctx_createdby](systemuser.md#BKMK_lk_msdyn_ocgooglebusinessmessagesengagementctx_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocgooglebusinessmessagesengagementctx_createdonbehalfby"></a> lk_msdyn_ocgooglebusinessmessagesengagementctx_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocgooglebusinessmessagesengagementctx_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_ocgooglebusinessmessagesengagementctx_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocgooglebusinessmessagesengagementctx_modifiedby"></a> lk_msdyn_ocgooglebusinessmessagesengagementctx_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_ocgooglebusinessmessagesengagementctx_modifiedby](systemuser.md#BKMK_lk_msdyn_ocgooglebusinessmessagesengagementctx_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocgooglebusinessmessagesengagementctx_modifiedonbehalfby"></a> lk_msdyn_ocgooglebusinessmessagesengagementctx_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocgooglebusinessmessagesengagementctx_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_ocgooglebusinessmessagesengagementctx_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencingEntityNavigationPropertyName|`msdyn_liveworkitemid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_ocgooglebusinessmessagesengagementctx"></a> owner_msdyn_ocgooglebusinessmessagesengagementctx

One-To-Many Relationship: [owner owner_msdyn_ocgooglebusinessmessagesengagementctx](owner.md#BKMK_owner_msdyn_ocgooglebusinessmessagesengagementctx)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_ocgooglebusinessmessagesengagementctx"></a> team_msdyn_ocgooglebusinessmessagesengagementctx

One-To-Many Relationship: [team team_msdyn_ocgooglebusinessmessagesengagementctx](team.md#BKMK_team_msdyn_ocgooglebusinessmessagesengagementctx)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_ocgooglebusinessmessagesengagementctx"></a> user_msdyn_ocgooglebusinessmessagesengagementctx

One-To-Many Relationship: [systemuser user_msdyn_ocgooglebusinessmessagesengagementctx](systemuser.md#BKMK_user_msdyn_ocgooglebusinessmessagesengagementctx)

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

- [msdyn_ocgooglebusinessmessagesengagementctx_AsyncOperations](#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_AsyncOperations)
- [msdyn_ocgooglebusinessmessagesengagementctx_BulkDeleteFailures](#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_BulkDeleteFailures)
- [msdyn_ocgooglebusinessmessagesengagementctx_DuplicateBaseRecord](#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_DuplicateBaseRecord)
- [msdyn_ocgooglebusinessmessagesengagementctx_DuplicateMatchingRecord](#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_DuplicateMatchingRecord)
- [msdyn_ocgooglebusinessmessagesengagementctx_MailboxTrackingFolders](#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_MailboxTrackingFolders)
- [msdyn_ocgooglebusinessmessagesengagementctx_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_PrincipalObjectAttributeAccesses)
- [msdyn_ocgooglebusinessmessagesengagementctx_ProcessSession](#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_ProcessSession)
- [msdyn_ocgooglebusinessmessagesengagementctx_SyncErrors](#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_SyncErrors)

### <a name="BKMK_msdyn_ocgooglebusinessmessagesengagementctx_AsyncOperations"></a> msdyn_ocgooglebusinessmessagesengagementctx_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocgooglebusinessmessagesengagementctx_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagesengagementctx_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesengagementctx_BulkDeleteFailures"></a> msdyn_ocgooglebusinessmessagesengagementctx_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocgooglebusinessmessagesengagementctx_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagesengagementctx_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesengagementctx_DuplicateBaseRecord"></a> msdyn_ocgooglebusinessmessagesengagementctx_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocgooglebusinessmessagesengagementctx_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagesengagementctx_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesengagementctx_DuplicateMatchingRecord"></a> msdyn_ocgooglebusinessmessagesengagementctx_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocgooglebusinessmessagesengagementctx_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagesengagementctx_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesengagementctx_MailboxTrackingFolders"></a> msdyn_ocgooglebusinessmessagesengagementctx_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocgooglebusinessmessagesengagementctx_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagesengagementctx_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesengagementctx_PrincipalObjectAttributeAccesses"></a> msdyn_ocgooglebusinessmessagesengagementctx_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocgooglebusinessmessagesengagementctx_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagesengagementctx_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesengagementctx_ProcessSession"></a> msdyn_ocgooglebusinessmessagesengagementctx_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocgooglebusinessmessagesengagementctx_ProcessSession](processsession.md#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagesengagementctx_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesengagementctx_SyncErrors"></a> msdyn_ocgooglebusinessmessagesengagementctx_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocgooglebusinessmessagesengagementctx_SyncErrors](syncerror.md#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagesengagementctx_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

