---
title: "Web Role (Adx_webrole) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Web Role (Adx_webrole) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Web Role (Adx_webrole) table/entity reference

Sets the user's role for the Portal.

## Messages

The following table lists the messages for the Web Role (Adx_webrole) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /adx_webroles(*adx_webroleid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /adx_webroles<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /adx_webroles(*adx_webroleid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /adx_webroles(*adx_webroleid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /adx_webroles<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /adx_webroles(*adx_webroleid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /adx_webroles(*adx_webroleid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /adx_webroles(*adx_webroleid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Web Role (Adx_webrole) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Web Role (Adx_webrole) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Web Role** |
| **DisplayCollectionName** | **Web Roles** |
| **SchemaName** | `Adx_webrole` |
| **CollectionSchemaName** | `Adx_webroles` |
| **EntitySetName** | `adx_webroles`|
| **LogicalName** | `adx_webrole` |
| **LogicalCollectionName** | `adx_webroles` |
| **PrimaryIdAttribute** | `adx_webroleid` |
| **PrimaryNameAttribute** |`adx_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [adx_anonymoususersrole](#BKMK_adx_anonymoususersrole)
- [Adx_authenticatedusersrole](#BKMK_Adx_authenticatedusersrole)
- [Adx_Description](#BKMK_Adx_Description)
- [adx_key](#BKMK_adx_key)
- [Adx_name](#BKMK_Adx_name)
- [Adx_webroleId](#BKMK_Adx_webroleId)
- [adx_websiteid](#BKMK_adx_websiteid)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_adx_anonymoususersrole"></a> adx_anonymoususersrole

|Property|Value|
|---|---|
|Description||
|DisplayName|**Anonymous Users Role**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_anonymoususersrole`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webrole_adx_anonymoususersrole`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_Adx_authenticatedusersrole"></a> Adx_authenticatedusersrole

|Property|Value|
|---|---|
|Description||
|DisplayName|**Authenticated Users Role**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_authenticatedusersrole`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webrole_adx_authenticatedusersrole`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_Adx_Description"></a> Adx_Description

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_adx_key"></a> adx_key

|Property|Value|
|---|---|
|Description|**An alternate key that is not intended to be localized to allow retrieval of a specific Web Role in workflows or code.**|
|DisplayName|**Key**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_key`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_Adx_name"></a> Adx_name

|Property|Value|
|---|---|
|Description|**Shows the name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_Adx_webroleId"></a> Adx_webroleId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Web Role**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`adx_webroleid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_adx_websiteid"></a> adx_websiteid

|Property|Value|
|---|---|
|Description|**Unique identifier for Website associated with Web Role.**|
|DisplayName|**Website**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_websiteid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_website|

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Shows the sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Shows when the record was migrated.**|
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
|Description|**Shows the owner ID.**|
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
|Description|**Status of the Web Role**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`adx_webrole_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Web Role**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`adx_webrole_statuscode`|

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
|Description|**Shows the time zone code that was in use when the record was created.**|
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
|Description|**Shows the user who created the record.**|
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
|Description|**Shows when the record was created.**|
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
|Description|**Shows who created the record on behalf of another user.**|
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
|Description|**Shows the user who updated the record.**|
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
|Description|**Shows when the record was updated.**|
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
|Description|**Shows who last updated the record on behalf of another user.**|
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

- [adx_website_webrole](#BKMK_adx_website_webrole)
- [business_unit_adx_webrole](#BKMK_business_unit_adx_webrole)
- [lk_adx_webrole_createdby](#BKMK_lk_adx_webrole_createdby)
- [lk_adx_webrole_createdonbehalfby](#BKMK_lk_adx_webrole_createdonbehalfby)
- [lk_adx_webrole_modifiedby](#BKMK_lk_adx_webrole_modifiedby)
- [lk_adx_webrole_modifiedonbehalfby](#BKMK_lk_adx_webrole_modifiedonbehalfby)
- [owner_adx_webrole](#BKMK_owner_adx_webrole)
- [team_adx_webrole](#BKMK_team_adx_webrole)
- [user_adx_webrole](#BKMK_user_adx_webrole)

### <a name="BKMK_adx_website_webrole"></a> adx_website_webrole

One-To-Many Relationship: [adx_website adx_website_webrole](adx_website.md#BKMK_adx_website_webrole)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencingEntityNavigationPropertyName|`adx_websiteid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_business_unit_adx_webrole"></a> business_unit_adx_webrole

One-To-Many Relationship: [businessunit business_unit_adx_webrole](businessunit.md#BKMK_business_unit_adx_webrole)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_webrole_createdby"></a> lk_adx_webrole_createdby

One-To-Many Relationship: [systemuser lk_adx_webrole_createdby](systemuser.md#BKMK_lk_adx_webrole_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_webrole_createdonbehalfby"></a> lk_adx_webrole_createdonbehalfby

One-To-Many Relationship: [systemuser lk_adx_webrole_createdonbehalfby](systemuser.md#BKMK_lk_adx_webrole_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_webrole_modifiedby"></a> lk_adx_webrole_modifiedby

One-To-Many Relationship: [systemuser lk_adx_webrole_modifiedby](systemuser.md#BKMK_lk_adx_webrole_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_webrole_modifiedonbehalfby"></a> lk_adx_webrole_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_adx_webrole_modifiedonbehalfby](systemuser.md#BKMK_lk_adx_webrole_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_adx_webrole"></a> owner_adx_webrole

One-To-Many Relationship: [owner owner_adx_webrole](owner.md#BKMK_owner_adx_webrole)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_adx_webrole"></a> team_adx_webrole

One-To-Many Relationship: [team team_adx_webrole](team.md#BKMK_team_adx_webrole)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_adx_webrole"></a> user_adx_webrole

One-To-Many Relationship: [systemuser user_adx_webrole](systemuser.md#BKMK_user_adx_webrole)

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

- [adx_webrole_Annotations](#BKMK_adx_webrole_Annotations)
- [adx_webrole_AsyncOperations](#BKMK_adx_webrole_AsyncOperations)
- [adx_webrole_BulkDeleteFailures](#BKMK_adx_webrole_BulkDeleteFailures)
- [adx_webrole_DuplicateBaseRecord](#BKMK_adx_webrole_DuplicateBaseRecord)
- [adx_webrole_DuplicateMatchingRecord](#BKMK_adx_webrole_DuplicateMatchingRecord)
- [adx_webrole_MailboxTrackingFolders](#BKMK_adx_webrole_MailboxTrackingFolders)
- [adx_webrole_PrincipalObjectAttributeAccesses](#BKMK_adx_webrole_PrincipalObjectAttributeAccesses)
- [adx_webrole_ProcessSession](#BKMK_adx_webrole_ProcessSession)
- [adx_webrole_SyncErrors](#BKMK_adx_webrole_SyncErrors)

### <a name="BKMK_adx_webrole_Annotations"></a> adx_webrole_Annotations

Many-To-One Relationship: [annotation adx_webrole_Annotations](annotation.md#BKMK_adx_webrole_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_webrole_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webrole_AsyncOperations"></a> adx_webrole_AsyncOperations

Many-To-One Relationship: [asyncoperation adx_webrole_AsyncOperations](asyncoperation.md#BKMK_adx_webrole_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webrole_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webrole_BulkDeleteFailures"></a> adx_webrole_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure adx_webrole_BulkDeleteFailures](bulkdeletefailure.md#BKMK_adx_webrole_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webrole_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webrole_DuplicateBaseRecord"></a> adx_webrole_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord adx_webrole_DuplicateBaseRecord](duplicaterecord.md#BKMK_adx_webrole_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`adx_webrole_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webrole_DuplicateMatchingRecord"></a> adx_webrole_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord adx_webrole_DuplicateMatchingRecord](duplicaterecord.md#BKMK_adx_webrole_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`adx_webrole_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webrole_MailboxTrackingFolders"></a> adx_webrole_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder adx_webrole_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_adx_webrole_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webrole_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webrole_PrincipalObjectAttributeAccesses"></a> adx_webrole_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess adx_webrole_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_adx_webrole_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_webrole_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webrole_ProcessSession"></a> adx_webrole_ProcessSession

Many-To-One Relationship: [processsession adx_webrole_ProcessSession](processsession.md#BKMK_adx_webrole_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webrole_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webrole_SyncErrors"></a> adx_webrole_SyncErrors

Many-To-One Relationship: [syncerror adx_webrole_SyncErrors](syncerror.md#BKMK_adx_webrole_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webrole_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [adx_CloudFlowConsumer_adx_webrole](#BKMK_adx_CloudFlowConsumer_adx_webrole)
- [adx_columnpermissionprofile_webrole](#BKMK_adx_columnpermissionprofile_webrole)
- [adx_communityforumaccesspermission_webrole](#BKMK_adx_communityforumaccesspermission_webrole)
- [adx_entitypermission_webrole](#BKMK_adx_entitypermission_webrole)
- [adx_invitation_webrole](#BKMK_adx_invitation_webrole)
- [adx_publishingstatetransitionrule_webrole](#BKMK_adx_publishingstatetransitionrule_webrole)
- [adx_webpageaccesscontrolrule_webrole](#BKMK_adx_webpageaccesscontrolrule_webrole)
- [adx_webrole_account](#BKMK_adx_webrole_account)
- [adx_webrole_contact](#BKMK_adx_webrole_contact)
- [adx_webrole_systemuser](#BKMK_adx_webrole_systemuser)
- [adx_WebRoleContentAccessLevel](#BKMK_adx_WebRoleContentAccessLevel)
- [adx_websiteaccess_webrole](#BKMK_adx_websiteaccess_webrole)

### <a name="BKMK_adx_CloudFlowConsumer_adx_webrole"></a> adx_CloudFlowConsumer_adx_webrole

See [adx_cloudflowconsumer adx_CloudFlowConsumer_adx_webrole Many-To-Many Relationship](adx_cloudflowconsumer.md#BKMK_adx_CloudFlowConsumer_adx_webrole)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_cloudflowconsumer_adx_webrole`|
|IsCustomizable|True|
|SchemaName|`adx_CloudFlowConsumer_adx_webrole`|
|IntersectAttribute|`adx_webroleid`|
|NavigationPropertyName|`adx_CloudFlowConsumer_adx_webrole`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_columnpermissionprofile_webrole"></a> adx_columnpermissionprofile_webrole

See [adx_columnpermissionprofile adx_columnpermissionprofile_webrole Many-To-Many Relationship](adx_columnpermissionprofile.md#BKMK_adx_columnpermissionprofile_webrole)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_columnpermissionprofile_webrole`|
|IsCustomizable|True|
|SchemaName|`adx_columnpermissionprofile_webrole`|
|IntersectAttribute|`adx_webroleid`|
|NavigationPropertyName|`adx_columnpermissionprofile_webrole`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_webrole"></a> adx_communityforumaccesspermission_webrole

See [adx_communityforumaccesspermission adx_communityforumaccesspermission_webrole Many-To-Many Relationship](adx_communityforumaccesspermission.md#BKMK_adx_communityforumaccesspermission_webrole)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_communityforumaccesspermission_webrole`|
|IsCustomizable|True|
|SchemaName|`adx_communityforumaccesspermission_webrole`|
|IntersectAttribute|`adx_webroleid`|
|NavigationPropertyName|`adx_communityforumaccesspermission_webrole`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entitypermission_webrole"></a> adx_entitypermission_webrole

See [adx_entitypermission adx_entitypermission_webrole Many-To-Many Relationship](adx_entitypermission.md#BKMK_adx_entitypermission_webrole)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_entitypermission_webrole`|
|IsCustomizable|True|
|SchemaName|`adx_entitypermission_webrole`|
|IntersectAttribute|`adx_webroleid`|
|NavigationPropertyName|`adx_entitypermission_webrole`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_webrole"></a> adx_invitation_webrole

See [adx_invitation adx_invitation_webrole Many-To-Many Relationship](adx_invitation.md#BKMK_adx_invitation_webrole)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_invitation_webrole`|
|IsCustomizable|True|
|SchemaName|`adx_invitation_webrole`|
|IntersectAttribute|`adx_webroleid`|
|NavigationPropertyName|`adx_invitation_webrole`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Assign To Web Roles<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_publishingstatetransitionrule_webrole"></a> adx_publishingstatetransitionrule_webrole

See [adx_publishingstatetransitionrule adx_publishingstatetransitionrule_webrole Many-To-Many Relationship](adx_publishingstatetransitionrule.md#BKMK_adx_publishingstatetransitionrule_webrole)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_publishingstatetransitionrule_webrole`|
|IsCustomizable|True|
|SchemaName|`adx_publishingstatetransitionrule_webrole`|
|IntersectAttribute|`adx_webroleid`|
|NavigationPropertyName|`adx_publishingstatetransitionrule_webrole`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpageaccesscontrolrule_webrole"></a> adx_webpageaccesscontrolrule_webrole

See [adx_webpageaccesscontrolrule adx_webpageaccesscontrolrule_webrole Many-To-Many Relationship](adx_webpageaccesscontrolrule.md#BKMK_adx_webpageaccesscontrolrule_webrole)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_webpageaccesscontrolrule_webrole`|
|IsCustomizable|True|
|SchemaName|`adx_webpageaccesscontrolrule_webrole`|
|IntersectAttribute|`adx_webroleid`|
|NavigationPropertyName|`adx_webpageaccesscontrolrule_webrole`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webrole_account"></a> adx_webrole_account

See [account adx_webrole_account Many-To-Many Relationship](account.md#BKMK_adx_webrole_account)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_webrole_account`|
|IsCustomizable|True|
|SchemaName|`adx_webrole_account`|
|IntersectAttribute|`adx_webroleid`|
|NavigationPropertyName|`adx_webrole_account`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100600<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webrole_contact"></a> adx_webrole_contact

See [contact adx_webrole_contact Many-To-Many Relationship](contact.md#BKMK_adx_webrole_contact)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_webrole_contact`|
|IsCustomizable|True|
|SchemaName|`adx_webrole_contact`|
|IntersectAttribute|`adx_webroleid`|
|NavigationPropertyName|`adx_webrole_contact`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 103100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webrole_systemuser"></a> adx_webrole_systemuser

See [systemuser adx_webrole_systemuser Many-To-Many Relationship](systemuser.md#BKMK_adx_webrole_systemuser)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_webrole_systemuser`|
|IsCustomizable|True|
|SchemaName|`adx_webrole_systemuser`|
|IntersectAttribute|`adx_webroleid`|
|NavigationPropertyName|`adx_webrole_systemuser`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_WebRoleContentAccessLevel"></a> adx_WebRoleContentAccessLevel

See [adx_contentaccesslevel adx_WebRoleContentAccessLevel Many-To-Many Relationship](adx_contentaccesslevel.md#BKMK_adx_WebRoleContentAccessLevel)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_webrolecontentaccesslevel`|
|IsCustomizable|True|
|SchemaName|`adx_WebRoleContentAccessLevel`|
|IntersectAttribute|`adx_webroleid`|
|NavigationPropertyName|`adx_WebRoleContentAccessLevel`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_websiteaccess_webrole"></a> adx_websiteaccess_webrole

See [adx_websiteaccess adx_websiteaccess_webrole Many-To-Many Relationship](adx_websiteaccess.md#BKMK_adx_websiteaccess_webrole)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_websiteaccess_webrole`|
|IsCustomizable|True|
|SchemaName|`adx_websiteaccess_webrole`|
|IntersectAttribute|`adx_webroleid`|
|NavigationPropertyName|`adx_websiteaccess_webrole`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

