---
title: "MockSmsProvider channel instance account (msdynmkt_mocksmsproviderchannelinstanceaccount) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the MockSmsProvider channel instance account (msdynmkt_mocksmsproviderchannelinstanceaccount) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# MockSmsProvider channel instance account (msdynmkt_mocksmsproviderchannelinstanceaccount) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the MockSmsProvider channel instance account (msdynmkt_mocksmsproviderchannelinstanceaccount) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_mocksmsproviderchannelinstanceaccounts(*msdynmkt_mocksmsproviderchannelinstanceaccountid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdynmkt_mocksmsproviderchannelinstanceaccounts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_mocksmsproviderchannelinstanceaccounts(*msdynmkt_mocksmsproviderchannelinstanceaccountid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_mocksmsproviderchannelinstanceaccounts(*msdynmkt_mocksmsproviderchannelinstanceaccountid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_mocksmsproviderchannelinstanceaccounts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_mocksmsproviderchannelinstanceaccounts(*msdynmkt_mocksmsproviderchannelinstanceaccountid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_mocksmsproviderchannelinstanceaccounts(*msdynmkt_mocksmsproviderchannelinstanceaccountid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_mocksmsproviderchannelinstanceaccounts(*msdynmkt_mocksmsproviderchannelinstanceaccountid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the MockSmsProvider channel instance account (msdynmkt_mocksmsproviderchannelinstanceaccount) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **MockSmsProvider channel instance account** |
| **DisplayCollectionName** | **MockSmsProvider channel instance accounts** |
| **SchemaName** | `msdynmkt_mocksmsproviderchannelinstanceaccount` |
| **CollectionSchemaName** | `msdynmkt_mocksmsproviderchannelinstanceaccounts` |
| **EntitySetName** | `msdynmkt_mocksmsproviderchannelinstanceaccounts`|
| **LogicalName** | `msdynmkt_mocksmsproviderchannelinstanceaccount` |
| **LogicalCollectionName** | `msdynmkt_mocksmsproviderchannelinstanceaccounts` |
| **PrimaryIdAttribute** | `msdynmkt_mocksmsproviderchannelinstanceaccountid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_accountsid](#BKMK_msdynmkt_accountsid)
- [msdynmkt_authtoken](#BKMK_msdynmkt_authtoken)
- [msdynmkt_mocksmsproviderchannelinstanceaccountId](#BKMK_msdynmkt_mocksmsproviderchannelinstanceaccountId)
- [msdynmkt_name](#BKMK_msdynmkt_name)
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

### <a name="BKMK_msdynmkt_accountsid"></a> msdynmkt_accountsid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Account SID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_accountsid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdynmkt_authtoken"></a> msdynmkt_authtoken

|Property|Value|
|---|---|
|Description||
|DisplayName|**Auth Token**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_authtoken`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_mocksmsproviderchannelinstanceaccountId"></a> msdynmkt_mocksmsproviderchannelinstanceaccountId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**MockSmsProvider channel instance account**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_mocksmsproviderchannelinstanceaccountid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_name"></a> msdynmkt_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
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
|Description|**Status of the MockSmsProvider channel instance account**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_mocksmsproviderchannelinstanceaccount_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the MockSmsProvider channel instance account**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_mocksmsproviderchannelinstanceaccount_statuscode`|

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

- [business_unit_msdynmkt_mocksmsproviderchannelinstanceaccount](#BKMK_business_unit_msdynmkt_mocksmsproviderchannelinstanceaccount)
- [lk_msdynmkt_mocksmsproviderchannelinstanceaccount_createdby](#BKMK_lk_msdynmkt_mocksmsproviderchannelinstanceaccount_createdby)
- [lk_msdynmkt_mocksmsproviderchannelinstanceaccount_createdonbehalfby](#BKMK_lk_msdynmkt_mocksmsproviderchannelinstanceaccount_createdonbehalfby)
- [lk_msdynmkt_mocksmsproviderchannelinstanceaccount_modifiedby](#BKMK_lk_msdynmkt_mocksmsproviderchannelinstanceaccount_modifiedby)
- [lk_msdynmkt_mocksmsproviderchannelinstanceaccount_modifiedonbehalfby](#BKMK_lk_msdynmkt_mocksmsproviderchannelinstanceaccount_modifiedonbehalfby)
- [owner_msdynmkt_mocksmsproviderchannelinstanceaccount](#BKMK_owner_msdynmkt_mocksmsproviderchannelinstanceaccount)
- [team_msdynmkt_mocksmsproviderchannelinstanceaccount](#BKMK_team_msdynmkt_mocksmsproviderchannelinstanceaccount)
- [user_msdynmkt_mocksmsproviderchannelinstanceaccount](#BKMK_user_msdynmkt_mocksmsproviderchannelinstanceaccount)

### <a name="BKMK_business_unit_msdynmkt_mocksmsproviderchannelinstanceaccount"></a> business_unit_msdynmkt_mocksmsproviderchannelinstanceaccount

One-To-Many Relationship: [businessunit business_unit_msdynmkt_mocksmsproviderchannelinstanceaccount](businessunit.md#BKMK_business_unit_msdynmkt_mocksmsproviderchannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_mocksmsproviderchannelinstanceaccount_createdby"></a> lk_msdynmkt_mocksmsproviderchannelinstanceaccount_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_mocksmsproviderchannelinstanceaccount_createdby](systemuser.md#BKMK_lk_msdynmkt_mocksmsproviderchannelinstanceaccount_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_mocksmsproviderchannelinstanceaccount_createdonbehalfby"></a> lk_msdynmkt_mocksmsproviderchannelinstanceaccount_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_mocksmsproviderchannelinstanceaccount_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_mocksmsproviderchannelinstanceaccount_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_mocksmsproviderchannelinstanceaccount_modifiedby"></a> lk_msdynmkt_mocksmsproviderchannelinstanceaccount_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_mocksmsproviderchannelinstanceaccount_modifiedby](systemuser.md#BKMK_lk_msdynmkt_mocksmsproviderchannelinstanceaccount_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_mocksmsproviderchannelinstanceaccount_modifiedonbehalfby"></a> lk_msdynmkt_mocksmsproviderchannelinstanceaccount_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_mocksmsproviderchannelinstanceaccount_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_mocksmsproviderchannelinstanceaccount_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_mocksmsproviderchannelinstanceaccount"></a> owner_msdynmkt_mocksmsproviderchannelinstanceaccount

One-To-Many Relationship: [owner owner_msdynmkt_mocksmsproviderchannelinstanceaccount](owner.md#BKMK_owner_msdynmkt_mocksmsproviderchannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_mocksmsproviderchannelinstanceaccount"></a> team_msdynmkt_mocksmsproviderchannelinstanceaccount

One-To-Many Relationship: [team team_msdynmkt_mocksmsproviderchannelinstanceaccount](team.md#BKMK_team_msdynmkt_mocksmsproviderchannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_mocksmsproviderchannelinstanceaccount"></a> user_msdynmkt_mocksmsproviderchannelinstanceaccount

One-To-Many Relationship: [systemuser user_msdynmkt_mocksmsproviderchannelinstanceaccount](systemuser.md#BKMK_user_msdynmkt_mocksmsproviderchannelinstanceaccount)

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

- [msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_mocksmsproviderchannelinstanceaccount](#BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_mocksmsproviderchannelinstanceaccount)
- [msdynmkt_mocksmsproviderchannelinstanceaccount_AsyncOperations](#BKMK_msdynmkt_mocksmsproviderchannelinstanceaccount_AsyncOperations)
- [msdynmkt_mocksmsproviderchannelinstanceaccount_BulkDeleteFailures](#BKMK_msdynmkt_mocksmsproviderchannelinstanceaccount_BulkDeleteFailures)
- [msdynmkt_mocksmsproviderchannelinstanceaccount_MailboxTrackingFolders](#BKMK_msdynmkt_mocksmsproviderchannelinstanceaccount_MailboxTrackingFolders)
- [msdynmkt_mocksmsproviderchannelinstanceaccount_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_mocksmsproviderchannelinstanceaccount_PrincipalObjectAttributeAccesses)
- [msdynmkt_mocksmsproviderchannelinstanceaccount_ProcessSession](#BKMK_msdynmkt_mocksmsproviderchannelinstanceaccount_ProcessSession)
- [msdynmkt_mocksmsproviderchannelinstanceaccount_SyncErrors](#BKMK_msdynmkt_mocksmsproviderchannelinstanceaccount_SyncErrors)

### <a name="BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_mocksmsproviderchannelinstanceaccount"></a> msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_mocksmsproviderchannelinstanceaccount

Many-To-One Relationship: [msdyn_channelinstanceaccount msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_mocksmsproviderchannelinstanceaccount](msdyn_channelinstanceaccount.md#BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_mocksmsproviderchannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelinstanceaccount`|
|ReferencingAttribute|`msdyn_extendedentityid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_mocksmsproviderchannelinstanceaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_mocksmsproviderchannelinstanceaccount_AsyncOperations"></a> msdynmkt_mocksmsproviderchannelinstanceaccount_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_mocksmsproviderchannelinstanceaccount_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_mocksmsproviderchannelinstanceaccount_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_mocksmsproviderchannelinstanceaccount_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_mocksmsproviderchannelinstanceaccount_BulkDeleteFailures"></a> msdynmkt_mocksmsproviderchannelinstanceaccount_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_mocksmsproviderchannelinstanceaccount_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_mocksmsproviderchannelinstanceaccount_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_mocksmsproviderchannelinstanceaccount_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_mocksmsproviderchannelinstanceaccount_MailboxTrackingFolders"></a> msdynmkt_mocksmsproviderchannelinstanceaccount_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_mocksmsproviderchannelinstanceaccount_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_mocksmsproviderchannelinstanceaccount_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_mocksmsproviderchannelinstanceaccount_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_mocksmsproviderchannelinstanceaccount_PrincipalObjectAttributeAccesses"></a> msdynmkt_mocksmsproviderchannelinstanceaccount_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_mocksmsproviderchannelinstanceaccount_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_mocksmsproviderchannelinstanceaccount_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_mocksmsproviderchannelinstanceaccount_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_mocksmsproviderchannelinstanceaccount_ProcessSession"></a> msdynmkt_mocksmsproviderchannelinstanceaccount_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_mocksmsproviderchannelinstanceaccount_ProcessSession](processsession.md#BKMK_msdynmkt_mocksmsproviderchannelinstanceaccount_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_mocksmsproviderchannelinstanceaccount_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_mocksmsproviderchannelinstanceaccount_SyncErrors"></a> msdynmkt_mocksmsproviderchannelinstanceaccount_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_mocksmsproviderchannelinstanceaccount_SyncErrors](syncerror.md#BKMK_msdynmkt_mocksmsproviderchannelinstanceaccount_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_mocksmsproviderchannelinstanceaccount_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

