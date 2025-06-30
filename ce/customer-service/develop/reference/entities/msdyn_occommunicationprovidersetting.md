---
title: "Communication Provider Setting (msdyn_occommunicationprovidersetting) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Communication Provider Setting (msdyn_occommunicationprovidersetting) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Communication Provider Setting (msdyn_occommunicationprovidersetting) table/entity reference (Microsoft Dynamics 365 Customer Service)



## Messages

The following table lists the messages for the Communication Provider Setting (msdyn_occommunicationprovidersetting) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_occommunicationprovidersettings(*msdyn_occommunicationprovidersettingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_occommunicationprovidersettings<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_occommunicationprovidersettings(*msdyn_occommunicationprovidersettingid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `msdyn_TelephonyResourceDeprovisionAction`<br />Event: False |**msdyn_TelephonyResourceDeprovisionAction action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `msdyn_TelephonyResourceProvisionAction`<br />Event: False |**msdyn_TelephonyResourceProvisionAction action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_occommunicationprovidersettings(*msdyn_occommunicationprovidersettingid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_occommunicationprovidersettings<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_occommunicationprovidersettings(*msdyn_occommunicationprovidersettingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_occommunicationprovidersettings(*msdyn_occommunicationprovidersettingid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_occommunicationprovidersettings(*msdyn_occommunicationprovidersettingid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Communication Provider Setting (msdyn_occommunicationprovidersetting) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Communication Provider Setting** |
| **DisplayCollectionName** | **Communication Provider Settings** |
| **SchemaName** | `msdyn_occommunicationprovidersetting` |
| **CollectionSchemaName** | `msdyn_occommunicationprovidersettings` |
| **EntitySetName** | `msdyn_occommunicationprovidersettings`|
| **LogicalName** | `msdyn_occommunicationprovidersetting` |
| **LogicalCollectionName** | `msdyn_occommunicationprovidersettings` |
| **PrimaryIdAttribute** | `msdyn_occommunicationprovidersettingid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_AccountSID](#BKMK_msdyn_AccountSID)
- [msdyn_appmodule](#BKMK_msdyn_appmodule)
- [msdyn_isTrial](#BKMK_msdyn_isTrial)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_OcCommunicationProvider](#BKMK_msdyn_OcCommunicationProvider)
- [msdyn_occommunicationproviderdatalocation](#BKMK_msdyn_occommunicationproviderdatalocation)
- [msdyn_occommunicationproviderimmutableid](#BKMK_msdyn_occommunicationproviderimmutableid)
- [msdyn_occommunicationprovidersettingId](#BKMK_msdyn_occommunicationprovidersettingId)
- [msdyn_Secret](#BKMK_msdyn_Secret)
- [msdyn_securesecret](#BKMK_msdyn_securesecret)
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

### <a name="BKMK_msdyn_AccountSID"></a> msdyn_AccountSID

|Property|Value|
|---|---|
|Description|**Account SID**|
|DisplayName|**Account SID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_accountsid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|800|

### <a name="BKMK_msdyn_appmodule"></a> msdyn_appmodule

|Property|Value|
|---|---|
|Description|**Application module picklist**|
|DisplayName|**Application module**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_appmodule`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_appmodule`|

#### msdyn_appmodule Choices/Options

|Value|Label|
|---|---|
|192350000|**Service**|

### <a name="BKMK_msdyn_isTrial"></a> msdyn_isTrial

|Property|Value|
|---|---|
|Description|**Flag specifying whether account is trial or not.**|
|DisplayName|**isTrial**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_istrial`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_occommunicationprovidersetting_msdyn_istrial`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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

### <a name="BKMK_msdyn_OcCommunicationProvider"></a> msdyn_OcCommunicationProvider

|Property|Value|
|---|---|
|Description|**Communication provider picklist**|
|DisplayName|**Communication Provider**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_occommunicationprovider`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_occommunicationprovider`|

#### msdyn_OcCommunicationProvider Choices/Options

|Value|Label|
|---|---|
|192350000|**Azure Communication Services**|
|192350001|**Twilio**|
|192350002|**TeleSign**|
|192350003|**Microsoft Teams Phone System**|

### <a name="BKMK_msdyn_occommunicationproviderdatalocation"></a> msdyn_occommunicationproviderdatalocation

|Property|Value|
|---|---|
|Description|**The data residency location of the resource.**|
|DisplayName|**Data Location**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_occommunicationproviderdatalocation`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|800|

### <a name="BKMK_msdyn_occommunicationproviderimmutableid"></a> msdyn_occommunicationproviderimmutableid

|Property|Value|
|---|---|
|Description|**The immutable id of the resource.**|
|DisplayName|**Immutable Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_occommunicationproviderimmutableid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|800|

### <a name="BKMK_msdyn_occommunicationprovidersettingId"></a> msdyn_occommunicationprovidersettingId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Communication Provider Setting**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_occommunicationprovidersettingid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_Secret"></a> msdyn_Secret

|Property|Value|
|---|---|
|Description|**Authtoken or connectionstring**|
|DisplayName|**Secret**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_secret`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_securesecret"></a> msdyn_securesecret

|Property|Value|
|---|---|
|Description|**Secure Authtoken or connectionstring value**|
|DisplayName|**Secure Secret value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_securesecret`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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
|Description|**Status of the Communication Provider Setting**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_occommunicationprovidersetting_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Communication Provider Setting**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_occommunicationprovidersetting_statuscode`|

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

- [business_unit_msdyn_occommunicationprovidersetting](#BKMK_business_unit_msdyn_occommunicationprovidersetting)
- [lk_msdyn_occommunicationprovidersetting_createdby](#BKMK_lk_msdyn_occommunicationprovidersetting_createdby)
- [lk_msdyn_occommunicationprovidersetting_createdonbehalfby](#BKMK_lk_msdyn_occommunicationprovidersetting_createdonbehalfby)
- [lk_msdyn_occommunicationprovidersetting_modifiedby](#BKMK_lk_msdyn_occommunicationprovidersetting_modifiedby)
- [lk_msdyn_occommunicationprovidersetting_modifiedonbehalfby](#BKMK_lk_msdyn_occommunicationprovidersetting_modifiedonbehalfby)
- [owner_msdyn_occommunicationprovidersetting](#BKMK_owner_msdyn_occommunicationprovidersetting)
- [team_msdyn_occommunicationprovidersetting](#BKMK_team_msdyn_occommunicationprovidersetting)
- [user_msdyn_occommunicationprovidersetting](#BKMK_user_msdyn_occommunicationprovidersetting)

### <a name="BKMK_business_unit_msdyn_occommunicationprovidersetting"></a> business_unit_msdyn_occommunicationprovidersetting

One-To-Many Relationship: [businessunit business_unit_msdyn_occommunicationprovidersetting](businessunit.md#BKMK_business_unit_msdyn_occommunicationprovidersetting)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_occommunicationprovidersetting_createdby"></a> lk_msdyn_occommunicationprovidersetting_createdby

One-To-Many Relationship: [systemuser lk_msdyn_occommunicationprovidersetting_createdby](systemuser.md#BKMK_lk_msdyn_occommunicationprovidersetting_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_occommunicationprovidersetting_createdonbehalfby"></a> lk_msdyn_occommunicationprovidersetting_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_occommunicationprovidersetting_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_occommunicationprovidersetting_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_occommunicationprovidersetting_modifiedby"></a> lk_msdyn_occommunicationprovidersetting_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_occommunicationprovidersetting_modifiedby](systemuser.md#BKMK_lk_msdyn_occommunicationprovidersetting_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_occommunicationprovidersetting_modifiedonbehalfby"></a> lk_msdyn_occommunicationprovidersetting_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_occommunicationprovidersetting_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_occommunicationprovidersetting_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_occommunicationprovidersetting"></a> owner_msdyn_occommunicationprovidersetting

One-To-Many Relationship: [owner owner_msdyn_occommunicationprovidersetting](owner.md#BKMK_owner_msdyn_occommunicationprovidersetting)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_occommunicationprovidersetting"></a> team_msdyn_occommunicationprovidersetting

One-To-Many Relationship: [team team_msdyn_occommunicationprovidersetting](team.md#BKMK_team_msdyn_occommunicationprovidersetting)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_occommunicationprovidersetting"></a> user_msdyn_occommunicationprovidersetting

One-To-Many Relationship: [systemuser user_msdyn_occommunicationprovidersetting](systemuser.md#BKMK_user_msdyn_occommunicationprovidersetting)

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

- [msdyn_msdyn_occommunicationprovidersetting_msdyn_ocbotchannelregistration_communicationprovider](#BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocbotchannelregistration_communicationprovider)
- [msdyn_msdyn_occommunicationprovidersetting_msdyn_ocphonenumber_communicationprovidersettingid](#BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocphonenumber_communicationprovidersettingid)
- [msdyn_msdyn_occommunicationprovidersetting_msdyn_ocprovisioningstate_communicationprovidersettingid](#BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocprovisioningstate_communicationprovidersettingid)
- [msdyn_occommunicationprovidersetting_AsyncOperations](#BKMK_msdyn_occommunicationprovidersetting_AsyncOperations)
- [msdyn_occommunicationprovidersetting_BulkDeleteFailures](#BKMK_msdyn_occommunicationprovidersetting_BulkDeleteFailures)
- [msdyn_occommunicationprovidersetting_DuplicateBaseRecord](#BKMK_msdyn_occommunicationprovidersetting_DuplicateBaseRecord)
- [msdyn_occommunicationprovidersetting_DuplicateMatchingRecord](#BKMK_msdyn_occommunicationprovidersetting_DuplicateMatchingRecord)
- [msdyn_occommunicationprovidersetting_MailboxTrackingFolders](#BKMK_msdyn_occommunicationprovidersetting_MailboxTrackingFolders)
- [msdyn_occommunicationprovidersetting_msdyn_entr](#BKMK_msdyn_occommunicationprovidersetting_msdyn_entr)
- [msdyn_occommunicationprovidersetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_occommunicationprovidersetting_PrincipalObjectAttributeAccesses)
- [msdyn_occommunicationprovidersetting_ProcessSession](#BKMK_msdyn_occommunicationprovidersetting_ProcessSession)
- [msdyn_occommunicationprovidersetting_SyncErrors](#BKMK_msdyn_occommunicationprovidersetting_SyncErrors)

### <a name="BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocbotchannelregistration_communicationprovider"></a> msdyn_msdyn_occommunicationprovidersetting_msdyn_ocbotchannelregistration_communicationprovider

Many-To-One Relationship: [msdyn_ocbotchannelregistration msdyn_msdyn_occommunicationprovidersetting_msdyn_ocbotchannelregistration_communicationprovider](msdyn_ocbotchannelregistration.md#BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocbotchannelregistration_communicationprovider)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocbotchannelregistration`|
|ReferencingAttribute|`msdyn_communicationprovidersettingid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_occommunicationprovidersetting_msdyn_ocbotchannelregistration_communicationprovider`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocphonenumber_communicationprovidersettingid"></a> msdyn_msdyn_occommunicationprovidersetting_msdyn_ocphonenumber_communicationprovidersettingid

Many-To-One Relationship: [msdyn_ocphonenumber msdyn_msdyn_occommunicationprovidersetting_msdyn_ocphonenumber_communicationprovidersettingid](msdyn_ocphonenumber.md#BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocphonenumber_communicationprovidersettingid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocphonenumber`|
|ReferencingAttribute|`msdyn_occommunicationprovidersettingid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_occommunicationprovidersetting_msdyn_ocphonenumber_communicationprovidersettingid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocprovisioningstate_communicationprovidersettingid"></a> msdyn_msdyn_occommunicationprovidersetting_msdyn_ocprovisioningstate_communicationprovidersettingid

Many-To-One Relationship: [msdyn_ocprovisioningstate msdyn_msdyn_occommunicationprovidersetting_msdyn_ocprovisioningstate_communicationprovidersettingid](msdyn_ocprovisioningstate.md#BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocprovisioningstate_communicationprovidersettingid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocprovisioningstate`|
|ReferencingAttribute|`msdyn_communicationprovidersettingid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_occommunicationprovidersetting_msdyn_ocprovisioningstate_communicationprovidersettingid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_occommunicationprovidersetting_AsyncOperations"></a> msdyn_occommunicationprovidersetting_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_occommunicationprovidersetting_AsyncOperations](asyncoperation.md#BKMK_msdyn_occommunicationprovidersetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_occommunicationprovidersetting_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_occommunicationprovidersetting_BulkDeleteFailures"></a> msdyn_occommunicationprovidersetting_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_occommunicationprovidersetting_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_occommunicationprovidersetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_occommunicationprovidersetting_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_occommunicationprovidersetting_DuplicateBaseRecord"></a> msdyn_occommunicationprovidersetting_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_occommunicationprovidersetting_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_occommunicationprovidersetting_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_occommunicationprovidersetting_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_occommunicationprovidersetting_DuplicateMatchingRecord"></a> msdyn_occommunicationprovidersetting_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_occommunicationprovidersetting_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_occommunicationprovidersetting_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_occommunicationprovidersetting_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_occommunicationprovidersetting_MailboxTrackingFolders"></a> msdyn_occommunicationprovidersetting_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_occommunicationprovidersetting_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_occommunicationprovidersetting_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_occommunicationprovidersetting_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_occommunicationprovidersetting_msdyn_entr"></a> msdyn_occommunicationprovidersetting_msdyn_entr

Many-To-One Relationship: [msdyn_occommunicationprovidersettingentry msdyn_occommunicationprovidersetting_msdyn_entr](msdyn_occommunicationprovidersettingentry.md#BKMK_msdyn_occommunicationprovidersetting_msdyn_entr)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occommunicationprovidersettingentry`|
|ReferencingAttribute|`msdyn_communicationprovidersettingentid`|
|ReferencedEntityNavigationPropertyName|`msdyn_occommunicationprovidersetting_msdyn_entr`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_occommunicationprovidersetting_PrincipalObjectAttributeAccesses"></a> msdyn_occommunicationprovidersetting_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_occommunicationprovidersetting_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_occommunicationprovidersetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_occommunicationprovidersetting_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_occommunicationprovidersetting_ProcessSession"></a> msdyn_occommunicationprovidersetting_ProcessSession

Many-To-One Relationship: [processsession msdyn_occommunicationprovidersetting_ProcessSession](processsession.md#BKMK_msdyn_occommunicationprovidersetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_occommunicationprovidersetting_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_occommunicationprovidersetting_SyncErrors"></a> msdyn_occommunicationprovidersetting_SyncErrors

Many-To-One Relationship: [syncerror msdyn_occommunicationprovidersetting_SyncErrors](syncerror.md#BKMK_msdyn_occommunicationprovidersetting_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_occommunicationprovidersetting_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

