---
title: "Google's Business Messages partner account (msdyn_ocgooglebusinessmessagespartneraccount) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Google's Business Messages partner account (msdyn_ocgooglebusinessmessagespartneraccount) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Google's Business Messages partner account (msdyn_ocgooglebusinessmessagespartneraccount) table/entity reference (Microsoft Dynamics 365 Customer Service)

Google's Business Messages partner account

## Messages

The following table lists the messages for the Google's Business Messages partner account (msdyn_ocgooglebusinessmessagespartneraccount) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_ocgooglebusinessmessagespartneraccounts(*msdyn_ocgooglebusinessmessagespartneraccountid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_ocgooglebusinessmessagespartneraccounts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocgooglebusinessmessagespartneraccounts(*msdyn_ocgooglebusinessmessagespartneraccountid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocgooglebusinessmessagespartneraccounts(*msdyn_ocgooglebusinessmessagespartneraccountid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocgooglebusinessmessagespartneraccounts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocgooglebusinessmessagespartneraccounts(*msdyn_ocgooglebusinessmessagespartneraccountid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocgooglebusinessmessagespartneraccounts(*msdyn_ocgooglebusinessmessagespartneraccountid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocgooglebusinessmessagespartneraccounts(*msdyn_ocgooglebusinessmessagespartneraccountid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Google's Business Messages partner account (msdyn_ocgooglebusinessmessagespartneraccount) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Google's Business Messages partner account** |
| **DisplayCollectionName** | **Google's Business Messages partner accounts** |
| **SchemaName** | `msdyn_ocgooglebusinessmessagespartneraccount` |
| **CollectionSchemaName** | `msdyn_ocgooglebusinessmessagespartneraccounts` |
| **EntitySetName** | `msdyn_ocgooglebusinessmessagespartneraccounts`|
| **LogicalName** | `msdyn_ocgooglebusinessmessagespartneraccount` |
| **LogicalCollectionName** | `msdyn_ocgooglebusinessmessagespartneraccounts` |
| **PrimaryIdAttribute** | `msdyn_ocgooglebusinessmessagespartneraccountid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_base64credentialfilestring](#BKMK_msdyn_base64credentialfilestring)
- [msdyn_base64credentialfilestringcontd](#BKMK_msdyn_base64credentialfilestringcontd)
- [msdyn_credentialfilename](#BKMK_msdyn_credentialfilename)
- [msdyn_googlebusinessmessagescallbackurl](#BKMK_msdyn_googlebusinessmessagescallbackurl)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ocgooglebusinessmessagespartneraccountId](#BKMK_msdyn_ocgooglebusinessmessagespartneraccountId)
- [msdyn_partneraccountclienttoken](#BKMK_msdyn_partneraccountclienttoken)
- [msdyn_partneraccountid](#BKMK_msdyn_partneraccountid)
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

### <a name="BKMK_msdyn_base64credentialfilestring"></a> msdyn_base64credentialfilestring

|Property|Value|
|---|---|
|Description|**Base 64 credential file string of the Google's Business Messages partner account.**|
|DisplayName|**Base 64 credential file string**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_base64credentialfilestring`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_base64credentialfilestringcontd"></a> msdyn_base64credentialfilestringcontd

|Property|Value|
|---|---|
|Description|**Base 64 credential file string of the Google's Business Messages partner account. - Continued**|
|DisplayName|**Base 64 credential file string - Continued**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_base64credentialfilestringcontd`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_credentialfilename"></a> msdyn_credentialfilename

|Property|Value|
|---|---|
|Description|**Credential file name of the Google's Business Messages partner account.**|
|DisplayName|**Credential file name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_credentialfilename`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_googlebusinessmessagescallbackurl"></a> msdyn_googlebusinessmessagescallbackurl

|Property|Value|
|---|---|
|Description|**Google's Business Messages callback URL of the Google's Business Messages partner account.**|
|DisplayName|**Google's Business Messages callback URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_googlebusinessmessagescallbackurl`|
|RequiredLevel|ApplicationRequired|
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

### <a name="BKMK_msdyn_ocgooglebusinessmessagespartneraccountId"></a> msdyn_ocgooglebusinessmessagespartneraccountId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Google's Business Messages partner account**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ocgooglebusinessmessagespartneraccountid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_partneraccountclienttoken"></a> msdyn_partneraccountclienttoken

|Property|Value|
|---|---|
|Description|**Partner account client token of the Google's Business Messages partner account.**|
|DisplayName|**Partner account client token**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_partneraccountclienttoken`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_partneraccountid"></a> msdyn_partneraccountid

|Property|Value|
|---|---|
|Description|**Partner account ID of the Google's Business Messages partner account.**|
|DisplayName|**Partner account ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_partneraccountid`|
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
|Description|**Status of the Google's Business Messages partner account**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocgooglebusinessmessagespartneraccount_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Google's Business Messages partner account**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocgooglebusinessmessagespartneraccount_statuscode`|

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

- [business_unit_msdyn_ocgooglebusinessmessagespartneraccount](#BKMK_business_unit_msdyn_ocgooglebusinessmessagespartneraccount)
- [lk_msdyn_ocgooglebusinessmessagespartneraccount_createdby](#BKMK_lk_msdyn_ocgooglebusinessmessagespartneraccount_createdby)
- [lk_msdyn_ocgooglebusinessmessagespartneraccount_createdonbehalfby](#BKMK_lk_msdyn_ocgooglebusinessmessagespartneraccount_createdonbehalfby)
- [lk_msdyn_ocgooglebusinessmessagespartneraccount_modifiedby](#BKMK_lk_msdyn_ocgooglebusinessmessagespartneraccount_modifiedby)
- [lk_msdyn_ocgooglebusinessmessagespartneraccount_modifiedonbehalfby](#BKMK_lk_msdyn_ocgooglebusinessmessagespartneraccount_modifiedonbehalfby)
- [owner_msdyn_ocgooglebusinessmessagespartneraccount](#BKMK_owner_msdyn_ocgooglebusinessmessagespartneraccount)
- [team_msdyn_ocgooglebusinessmessagespartneraccount](#BKMK_team_msdyn_ocgooglebusinessmessagespartneraccount)
- [user_msdyn_ocgooglebusinessmessagespartneraccount](#BKMK_user_msdyn_ocgooglebusinessmessagespartneraccount)

### <a name="BKMK_business_unit_msdyn_ocgooglebusinessmessagespartneraccount"></a> business_unit_msdyn_ocgooglebusinessmessagespartneraccount

One-To-Many Relationship: [businessunit business_unit_msdyn_ocgooglebusinessmessagespartneraccount](businessunit.md#BKMK_business_unit_msdyn_ocgooglebusinessmessagespartneraccount)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocgooglebusinessmessagespartneraccount_createdby"></a> lk_msdyn_ocgooglebusinessmessagespartneraccount_createdby

One-To-Many Relationship: [systemuser lk_msdyn_ocgooglebusinessmessagespartneraccount_createdby](systemuser.md#BKMK_lk_msdyn_ocgooglebusinessmessagespartneraccount_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocgooglebusinessmessagespartneraccount_createdonbehalfby"></a> lk_msdyn_ocgooglebusinessmessagespartneraccount_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocgooglebusinessmessagespartneraccount_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_ocgooglebusinessmessagespartneraccount_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocgooglebusinessmessagespartneraccount_modifiedby"></a> lk_msdyn_ocgooglebusinessmessagespartneraccount_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_ocgooglebusinessmessagespartneraccount_modifiedby](systemuser.md#BKMK_lk_msdyn_ocgooglebusinessmessagespartneraccount_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocgooglebusinessmessagespartneraccount_modifiedonbehalfby"></a> lk_msdyn_ocgooglebusinessmessagespartneraccount_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocgooglebusinessmessagespartneraccount_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_ocgooglebusinessmessagespartneraccount_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_ocgooglebusinessmessagespartneraccount"></a> owner_msdyn_ocgooglebusinessmessagespartneraccount

One-To-Many Relationship: [owner owner_msdyn_ocgooglebusinessmessagespartneraccount](owner.md#BKMK_owner_msdyn_ocgooglebusinessmessagespartneraccount)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_ocgooglebusinessmessagespartneraccount"></a> team_msdyn_ocgooglebusinessmessagespartneraccount

One-To-Many Relationship: [team team_msdyn_ocgooglebusinessmessagespartneraccount](team.md#BKMK_team_msdyn_ocgooglebusinessmessagespartneraccount)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_ocgooglebusinessmessagespartneraccount"></a> user_msdyn_ocgooglebusinessmessagespartneraccount

One-To-Many Relationship: [systemuser user_msdyn_ocgooglebusinessmessagespartneraccount](systemuser.md#BKMK_user_msdyn_ocgooglebusinessmessagespartneraccount)

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

- [msdyn_msdyn_ocgbmpartneraccount_msdyn_ocbotchannelregistration_ocgbmpartneraccount](#BKMK_msdyn_msdyn_ocgbmpartneraccount_msdyn_ocbotchannelregistration_ocgbmpartneraccount)
- [msdyn_msdyn_ocgbmpartneraccount_msdyn_ocgbmagentaccount_ocgbmpartneraccount](#BKMK_msdyn_msdyn_ocgbmpartneraccount_msdyn_ocgbmagentaccount_ocgbmpartneraccount)
- [msdyn_ocgooglebusinessmessagespartneraccount_AsyncOperations](#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_AsyncOperations)
- [msdyn_ocgooglebusinessmessagespartneraccount_BulkDeleteFailures](#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_BulkDeleteFailures)
- [msdyn_ocgooglebusinessmessagespartneraccount_DuplicateBaseRecord](#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_DuplicateBaseRecord)
- [msdyn_ocgooglebusinessmessagespartneraccount_DuplicateMatchingRecord](#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_DuplicateMatchingRecord)
- [msdyn_ocgooglebusinessmessagespartneraccount_MailboxTrackingFolders](#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_MailboxTrackingFolders)
- [msdyn_ocgooglebusinessmessagespartneraccount_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_PrincipalObjectAttributeAccesses)
- [msdyn_ocgooglebusinessmessagespartneraccount_ProcessSession](#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_ProcessSession)
- [msdyn_ocgooglebusinessmessagespartneraccount_SyncErrors](#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_SyncErrors)

### <a name="BKMK_msdyn_msdyn_ocgbmpartneraccount_msdyn_ocbotchannelregistration_ocgbmpartneraccount"></a> msdyn_msdyn_ocgbmpartneraccount_msdyn_ocbotchannelregistration_ocgbmpartneraccount

Many-To-One Relationship: [msdyn_ocbotchannelregistration msdyn_msdyn_ocgbmpartneraccount_msdyn_ocbotchannelregistration_ocgbmpartneraccount](msdyn_ocbotchannelregistration.md#BKMK_msdyn_msdyn_ocgbmpartneraccount_msdyn_ocbotchannelregistration_ocgbmpartneraccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocbotchannelregistration`|
|ReferencingAttribute|`msdyn_ocgbmpartneraccount`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocgbmpartneraccount_msdyn_ocbotchannelregistration_ocgbmpartneraccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocgbmpartneraccount_msdyn_ocgbmagentaccount_ocgbmpartneraccount"></a> msdyn_msdyn_ocgbmpartneraccount_msdyn_ocgbmagentaccount_ocgbmpartneraccount

Many-To-One Relationship: [msdyn_ocgooglebusinessmessagesagentaccount msdyn_msdyn_ocgbmpartneraccount_msdyn_ocgbmagentaccount_ocgbmpartneraccount](msdyn_ocgooglebusinessmessagesagentaccount.md#BKMK_msdyn_msdyn_ocgbmpartneraccount_msdyn_ocgbmagentaccount_ocgbmpartneraccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocgooglebusinessmessagesagentaccount`|
|ReferencingAttribute|`msdyn_ocgbmpartneraccount`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocgbmpartneraccount_msdyn_ocgbmagentaccount_ocgbmpartneraccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagespartneraccount_AsyncOperations"></a> msdyn_ocgooglebusinessmessagespartneraccount_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocgooglebusinessmessagespartneraccount_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagespartneraccount_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagespartneraccount_BulkDeleteFailures"></a> msdyn_ocgooglebusinessmessagespartneraccount_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocgooglebusinessmessagespartneraccount_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagespartneraccount_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagespartneraccount_DuplicateBaseRecord"></a> msdyn_ocgooglebusinessmessagespartneraccount_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocgooglebusinessmessagespartneraccount_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagespartneraccount_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagespartneraccount_DuplicateMatchingRecord"></a> msdyn_ocgooglebusinessmessagespartneraccount_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocgooglebusinessmessagespartneraccount_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagespartneraccount_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagespartneraccount_MailboxTrackingFolders"></a> msdyn_ocgooglebusinessmessagespartneraccount_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocgooglebusinessmessagespartneraccount_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagespartneraccount_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagespartneraccount_PrincipalObjectAttributeAccesses"></a> msdyn_ocgooglebusinessmessagespartneraccount_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocgooglebusinessmessagespartneraccount_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagespartneraccount_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagespartneraccount_ProcessSession"></a> msdyn_ocgooglebusinessmessagespartneraccount_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocgooglebusinessmessagespartneraccount_ProcessSession](processsession.md#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagespartneraccount_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagespartneraccount_SyncErrors"></a> msdyn_ocgooglebusinessmessagespartneraccount_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocgooglebusinessmessagespartneraccount_SyncErrors](syncerror.md#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocgooglebusinessmessagespartneraccount_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

