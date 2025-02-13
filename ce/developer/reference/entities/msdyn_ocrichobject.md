---
title: "Rich message (msdyn_ocrichobject) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Rich message (msdyn_ocrichobject) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Rich message (msdyn_ocrichobject) table/entity reference (Microsoft Dynamics 365)

Rich messages for Omnichannel integration

## Messages

The following table lists the messages for the Rich message (msdyn_ocrichobject) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_ocrichobjects(*msdyn_ocrichobjectid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_ocrichobjects<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocrichobjects(*msdyn_ocrichobjectid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocrichobjects(*msdyn_ocrichobjectid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocrichobjects<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocrichobjects(*msdyn_ocrichobjectid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocrichobjects(*msdyn_ocrichobjectid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocrichobjects(*msdyn_ocrichobjectid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Rich message (msdyn_ocrichobject) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Rich message** |
| **DisplayCollectionName** | **Rich messages** |
| **SchemaName** | `msdyn_ocrichobject` |
| **CollectionSchemaName** | `msdyn_ocrichobjects` |
| **EntitySetName** | `msdyn_ocrichobjects`|
| **LogicalName** | `msdyn_ocrichobject` |
| **LogicalCollectionName** | `msdyn_ocrichobjects` |
| **PrimaryIdAttribute** | `msdyn_ocrichobjectid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_allowagenttoedit](#BKMK_msdyn_allowagenttoedit)
- [msdyn_locale](#BKMK_msdyn_locale)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_objectjson](#BKMK_msdyn_objectjson)
- [msdyn_ocrichobjectId](#BKMK_msdyn_ocrichobjectId)
- [msdyn_ocrichobjecttype](#BKMK_msdyn_ocrichobjecttype)
- [msdyn_streamsource](#BKMK_msdyn_streamsource)
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

### <a name="BKMK_msdyn_allowagenttoedit"></a> msdyn_allowagenttoedit

|Property|Value|
|---|---|
|Description|**Indicates if the rich message can be edited by the agent**|
|DisplayName|**Indicates if the rich message can be edited by the agent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_allowagenttoedit`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocrichobject_msdyn_msdyn_iseditable`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_locale"></a> msdyn_locale

|Property|Value|
|---|---|
|Description|**The locale of a rich message**|
|DisplayName|**Rich message Locale**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_locale`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_ocrichobject_msdyn_locale`|

#### msdyn_locale Choices/Options

|Value|Label|
|---|---|
|1025|**ar-SA**|
|1026|**bg-BG**|
|1027|**ca-ES**|
|1028|**zh-TW**|
|1029|**cs-CZ**|
|1030|**da-DK**|
|1031|**de-DE**|
|1032|**el-GR**|
|1033|**en-US**|
|1035|**fi-FI**|
|1036|**fr-FR**|
|1037|**he-IL**|
|1038|**hu-HU**|
|1040|**it-IT**|
|1041|**ja-JP**|
|1042|**ko-KR**|
|1043|**nl-NL**|
|1044|**nb-NO**|
|1045|**pl-PL**|
|1046|**pt-BR**|
|1048|**ro-RO**|
|1049|**ru-RU**|
|1050|**hr-HR**|
|1051|**sk-SK**|
|1053|**sv-SE**|
|1054|**th-TH**|
|1055|**tr-TR**|
|1057|**id-ID**|
|1058|**uk-UA**|
|1060|**sl-SI**|
|1061|**et-EE**|
|1062|**lv-LV**|
|1063|**lt-LT**|
|1066|**vi-VN**|
|1069|**eu-ES**|
|1081|**hi-IN**|
|1086|**ms-MY**|
|1087|**kk-KZ**|
|1110|**gl-ES**|
|2052|**zh-CN**|
|2070|**pt-PT**|
|2074|**sr-Latn-CS**|
|3076|**zh-HK**|
|3082|**es-ES**|
|3098|**sr-Cyrl-CS**|

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

### <a name="BKMK_msdyn_objectjson"></a> msdyn_objectjson

|Property|Value|
|---|---|
|Description|**Rich message json**|
|DisplayName|**Rich message json**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_objectjson`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|9999|

### <a name="BKMK_msdyn_ocrichobjectId"></a> msdyn_ocrichobjectId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Identifies a rich message instance**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ocrichobjectid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ocrichobjecttype"></a> msdyn_ocrichobjecttype

|Property|Value|
|---|---|
|Description|**The rich message type**|
|DisplayName|**Rich message type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocrichobjecttype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_ocrichobjecttype`|

#### msdyn_ocrichobjecttype Choices/Options

|Value|Label|
|---|---|
|192350000|**Website Rich Link**|
|192350001|**Video Rich Link**|
|192350002|**List Picker**|
|192350003|**Time Picker**|
|192350004|**Custom JSON**|
|192350005|**Suggested Reply**|
|192350006|**Apple Pay**|
|192350007|**Authentication**|
|192350009|**Forms**|

### <a name="BKMK_msdyn_streamsource"></a> msdyn_streamsource

|Property|Value|
|---|---|
|Description|**The channel to which this rich message is attached**|
|DisplayName|**Channel Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_streamsource`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_streamsource`|

#### msdyn_streamsource Choices/Options

|Value|Label|
|---|---|
|192350000|**Entity Records**|

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
|Description|**Status of the Line Channel**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocrichobject_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the rich message**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocrichobject_statuscode`|

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
- [msdyn_objectjsonfile](#BKMK_msdyn_objectjsonfile)
- [msdyn_objectjsonfile_Name](#BKMK_msdyn_objectjsonfile_Name)
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

### <a name="BKMK_msdyn_objectjsonfile"></a> msdyn_objectjsonfile

|Property|Value|
|---|---|
|Description|**Use this field to store Object Json file to the system**|
|DisplayName|**Object Json file**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_objectjsonfile`|
|RequiredLevel|None|
|Type|File|
|MaxSizeInKB|1024|

### <a name="BKMK_msdyn_objectjsonfile_Name"></a> msdyn_objectjsonfile_Name

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_objectjsonfile_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

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
|RequiredLevel|SystemRequired|
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

- [business_unit_msdyn_ocrichobject](#BKMK_business_unit_msdyn_ocrichobject)
- [FileAttachment_msdyn_ocrichobject_msdyn_objectjsonfile](#BKMK_FileAttachment_msdyn_ocrichobject_msdyn_objectjsonfile)
- [lk_msdyn_ocrichobject_createdby](#BKMK_lk_msdyn_ocrichobject_createdby)
- [lk_msdyn_ocrichobject_createdonbehalfby](#BKMK_lk_msdyn_ocrichobject_createdonbehalfby)
- [lk_msdyn_ocrichobject_modifiedby](#BKMK_lk_msdyn_ocrichobject_modifiedby)
- [lk_msdyn_ocrichobject_modifiedonbehalfby](#BKMK_lk_msdyn_ocrichobject_modifiedonbehalfby)
- [owner_msdyn_ocrichobject](#BKMK_owner_msdyn_ocrichobject)
- [team_msdyn_ocrichobject](#BKMK_team_msdyn_ocrichobject)
- [user_msdyn_ocrichobject](#BKMK_user_msdyn_ocrichobject)

### <a name="BKMK_business_unit_msdyn_ocrichobject"></a> business_unit_msdyn_ocrichobject

One-To-Many Relationship: [businessunit business_unit_msdyn_ocrichobject](businessunit.md#BKMK_business_unit_msdyn_ocrichobject)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_FileAttachment_msdyn_ocrichobject_msdyn_objectjsonfile"></a> FileAttachment_msdyn_ocrichobject_msdyn_objectjsonfile

One-To-Many Relationship: [fileattachment FileAttachment_msdyn_ocrichobject_msdyn_objectjsonfile](fileattachment.md#BKMK_FileAttachment_msdyn_ocrichobject_msdyn_objectjsonfile)

|Property|Value|
|---|---|
|ReferencedEntity|`fileattachment`|
|ReferencedAttribute|`fileattachmentid`|
|ReferencingAttribute|`msdyn_objectjsonfile`|
|ReferencingEntityNavigationPropertyName|`msdyn_objectjsonfile`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocrichobject_createdby"></a> lk_msdyn_ocrichobject_createdby

One-To-Many Relationship: [systemuser lk_msdyn_ocrichobject_createdby](systemuser.md#BKMK_lk_msdyn_ocrichobject_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocrichobject_createdonbehalfby"></a> lk_msdyn_ocrichobject_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocrichobject_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_ocrichobject_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocrichobject_modifiedby"></a> lk_msdyn_ocrichobject_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_ocrichobject_modifiedby](systemuser.md#BKMK_lk_msdyn_ocrichobject_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocrichobject_modifiedonbehalfby"></a> lk_msdyn_ocrichobject_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocrichobject_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_ocrichobject_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_ocrichobject"></a> owner_msdyn_ocrichobject

One-To-Many Relationship: [owner owner_msdyn_ocrichobject](owner.md#BKMK_owner_msdyn_ocrichobject)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_ocrichobject"></a> team_msdyn_ocrichobject

One-To-Many Relationship: [team team_msdyn_ocrichobject](team.md#BKMK_team_msdyn_ocrichobject)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_ocrichobject"></a> user_msdyn_ocrichobject

One-To-Many Relationship: [systemuser user_msdyn_ocrichobject](systemuser.md#BKMK_user_msdyn_ocrichobject)

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

- [msdyn_ocrichobject_AsyncOperations](#BKMK_msdyn_ocrichobject_AsyncOperations)
- [msdyn_ocrichobject_BulkDeleteFailures](#BKMK_msdyn_ocrichobject_BulkDeleteFailures)
- [msdyn_ocrichobject_DuplicateBaseRecord](#BKMK_msdyn_ocrichobject_DuplicateBaseRecord)
- [msdyn_ocrichobject_DuplicateMatchingRecord](#BKMK_msdyn_ocrichobject_DuplicateMatchingRecord)
- [msdyn_ocrichobject_FileAttachments](#BKMK_msdyn_ocrichobject_FileAttachments)
- [msdyn_ocrichobject_MailboxTrackingFolders](#BKMK_msdyn_ocrichobject_MailboxTrackingFolders)
- [msdyn_ocrichobject_msdyn_ocrichobjectmap](#BKMK_msdyn_ocrichobject_msdyn_ocrichobjectmap)
- [msdyn_ocrichobject_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocrichobject_PrincipalObjectAttributeAccesses)
- [msdyn_ocrichobject_ProcessSession](#BKMK_msdyn_ocrichobject_ProcessSession)
- [msdyn_ocrichobject_SyncErrors](#BKMK_msdyn_ocrichobject_SyncErrors)

### <a name="BKMK_msdyn_ocrichobject_AsyncOperations"></a> msdyn_ocrichobject_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocrichobject_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocrichobject_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocrichobject_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocrichobject_BulkDeleteFailures"></a> msdyn_ocrichobject_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocrichobject_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocrichobject_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocrichobject_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocrichobject_DuplicateBaseRecord"></a> msdyn_ocrichobject_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocrichobject_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ocrichobject_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocrichobject_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocrichobject_DuplicateMatchingRecord"></a> msdyn_ocrichobject_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocrichobject_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ocrichobject_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocrichobject_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocrichobject_FileAttachments"></a> msdyn_ocrichobject_FileAttachments

Many-To-One Relationship: [fileattachment msdyn_ocrichobject_FileAttachments](fileattachment.md#BKMK_msdyn_ocrichobject_FileAttachments)

|Property|Value|
|---|---|
|ReferencingEntity|`fileattachment`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocrichobject_FileAttachments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocrichobject_MailboxTrackingFolders"></a> msdyn_ocrichobject_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocrichobject_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocrichobject_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocrichobject_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocrichobject_msdyn_ocrichobjectmap"></a> msdyn_ocrichobject_msdyn_ocrichobjectmap

Many-To-One Relationship: [msdyn_ocrichobjectmap msdyn_ocrichobject_msdyn_ocrichobjectmap](msdyn_ocrichobjectmap.md#BKMK_msdyn_ocrichobject_msdyn_ocrichobjectmap)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrichobjectmap`|
|ReferencingAttribute|`msdyn_ocmappedrichobjid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocrichobject_msdyn_ocrichobjectmap`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocrichobject_PrincipalObjectAttributeAccesses"></a> msdyn_ocrichobject_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocrichobject_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocrichobject_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocrichobject_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocrichobject_ProcessSession"></a> msdyn_ocrichobject_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocrichobject_ProcessSession](processsession.md#BKMK_msdyn_ocrichobject_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocrichobject_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocrichobject_SyncErrors"></a> msdyn_ocrichobject_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocrichobject_SyncErrors](syncerror.md#BKMK_msdyn_ocrichobject_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocrichobject_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [msdyn_msdyn_ocrichobject_liveworkstream](#BKMK_msdyn_msdyn_ocrichobject_liveworkstream)
- [msdyn_msdyn_ocrichobject_msdyn_octag](#BKMK_msdyn_msdyn_ocrichobject_msdyn_octag)

### <a name="BKMK_msdyn_msdyn_ocrichobject_liveworkstream"></a> msdyn_msdyn_ocrichobject_liveworkstream

See [msdyn_liveworkstream msdyn_msdyn_ocrichobject_liveworkstream Many-To-Many Relationship](msdyn_liveworkstream.md#BKMK_msdyn_msdyn_ocrichobject_liveworkstream)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_ocrichobject_liveworkstream`|
|IsCustomizable|True|
|SchemaName|`msdyn_msdyn_ocrichobject_liveworkstream`|
|IntersectAttribute|`msdyn_ocrichobjectid`|
|NavigationPropertyName|`msdyn_msdyn_ocrichobject_liveworkstream`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocrichobject_msdyn_octag"></a> msdyn_msdyn_ocrichobject_msdyn_octag

See [msdyn_octag msdyn_msdyn_ocrichobject_msdyn_octag Many-To-Many Relationship](msdyn_octag.md#BKMK_msdyn_msdyn_ocrichobject_msdyn_octag)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_ocrichobject_msdyn_octag`|
|IsCustomizable|True|
|SchemaName|`msdyn_msdyn_ocrichobject_msdyn_octag`|
|IntersectAttribute|`msdyn_ocrichobjectid`|
|NavigationPropertyName|`msdyn_msdyn_ocrichobject_msdyn_octag`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

