---
title: "Macro Action Template (msdyn_productivitymacroactiontemplate) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Macro Action Template (msdyn_productivitymacroactiontemplate) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Macro Action Template (msdyn_productivitymacroactiontemplate) table/entity reference (Microsoft Dynamics 365)

Attributes for macro action template

## Messages

The following table lists the messages for the Macro Action Template (msdyn_productivitymacroactiontemplate) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_productivitymacroactiontemplates(*msdyn_productivitymacroactiontemplateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_productivitymacroactiontemplates<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_productivitymacroactiontemplates(*msdyn_productivitymacroactiontemplateid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_productivitymacroactiontemplates(*msdyn_productivitymacroactiontemplateid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_productivitymacroactiontemplates<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_productivitymacroactiontemplates(*msdyn_productivitymacroactiontemplateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_productivitymacroactiontemplates(*msdyn_productivitymacroactiontemplateid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_productivitymacroactiontemplates(*msdyn_productivitymacroactiontemplateid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Macro Action Template (msdyn_productivitymacroactiontemplate) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Macro Action Template** |
| **DisplayCollectionName** | **Macro Action Templates** |
| **SchemaName** | `msdyn_productivitymacroactiontemplate` |
| **CollectionSchemaName** | `msdyn_productivitymacroactiontemplates` |
| **EntitySetName** | `msdyn_productivitymacroactiontemplates`|
| **LogicalName** | `msdyn_productivitymacroactiontemplate` |
| **LogicalCollectionName** | `msdyn_productivitymacroactiontemplates` |
| **PrimaryIdAttribute** | `msdyn_productivitymacroactiontemplateid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_actionDescription](#BKMK_msdyn_actionDescription)
- [msdyn_brandcolor](#BKMK_msdyn_brandcolor)
- [msdyn_displayname](#BKMK_msdyn_displayname)
- [msdyn_icon](#BKMK_msdyn_icon)
- [msdyn_inputparameters](#BKMK_msdyn_inputparameters)
- [msdyn_kind](#BKMK_msdyn_kind)
- [msdyn_macroconnector](#BKMK_msdyn_macroconnector)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_outputparameters](#BKMK_msdyn_outputparameters)
- [msdyn_productivitymacroactiontemplateId](#BKMK_msdyn_productivitymacroactiontemplateId)
- [msdyn_runtimeapi](#BKMK_msdyn_runtimeapi)
- [msdyn_subtitle](#BKMK_msdyn_subtitle)
- [msdyn_summary](#BKMK_msdyn_summary)
- [msdyn_title](#BKMK_msdyn_title)
- [msdyn_UniqueName](#BKMK_msdyn_UniqueName)
- [msdyn_visibility](#BKMK_msdyn_visibility)
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

### <a name="BKMK_msdyn_actionDescription"></a> msdyn_actionDescription

|Property|Value|
|---|---|
|Description|**The description of this macro action.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actiondescription`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|True|
|MaxLength|100|

### <a name="BKMK_msdyn_brandcolor"></a> msdyn_brandcolor

|Property|Value|
|---|---|
|Description|**Unique value to set the brand color**|
|DisplayName|**Brand Color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_brandcolor`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_displayname"></a> msdyn_displayname

|Property|Value|
|---|---|
|Description|**Unique value to set the display name**|
|DisplayName|**Display Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_displayname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|True|
|MaxLength|1000|

### <a name="BKMK_msdyn_icon"></a> msdyn_icon

|Property|Value|
|---|---|
|Description|**Unique value to set the icon**|
|DisplayName|**Icon**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_icon`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_inputparameters"></a> msdyn_inputparameters

|Property|Value|
|---|---|
|Description|**Input parameters for the macro action template**|
|DisplayName|**Input Parameters**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inputparameters`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_kind"></a> msdyn_kind

|Property|Value|
|---|---|
|Description|**Kind is either 'TRIGGERS' or 'ACTIONS'**|
|DisplayName|**Kind**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_kind`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_macroconnector"></a> msdyn_macroconnector

|Property|Value|
|---|---|
|Description|**Sets the value of macro connector**|
|DisplayName|**FUNDU_MACRO_CONNECTOR**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_macroconnector`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_productivitymacroconnector|

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

### <a name="BKMK_msdyn_outputparameters"></a> msdyn_outputparameters

|Property|Value|
|---|---|
|Description|**Output parameters for macro action template entity**|
|DisplayName|**Output Parameters**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_outputparameters`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_productivitymacroactiontemplateId"></a> msdyn_productivitymacroactiontemplateId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Macro Action Template**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_productivitymacroactiontemplateid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_runtimeapi"></a> msdyn_runtimeapi

|Property|Value|
|---|---|
|Description|**Function to be executed at runtime**|
|DisplayName|**Runtime API**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_runtimeapi`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_subtitle"></a> msdyn_subtitle

|Property|Value|
|---|---|
|Description|**Unique value to set the subtitle value**|
|DisplayName|**Subtitle**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_subtitle`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|True|
|MaxLength|1000|

### <a name="BKMK_msdyn_summary"></a> msdyn_summary

|Property|Value|
|---|---|
|Description|**Unique value to set the summary**|
|DisplayName|**Summary**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_summary`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|True|
|MaxLength|2000|

### <a name="BKMK_msdyn_title"></a> msdyn_title

|Property|Value|
|---|---|
|Description|**The title of this macro action.**|
|DisplayName|**Title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_title`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|True|
|MaxLength|100|

### <a name="BKMK_msdyn_UniqueName"></a> msdyn_UniqueName

|Property|Value|
|---|---|
|Description|**Unique Name for the entity.**|
|DisplayName|**Unique Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_uniquename`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|

### <a name="BKMK_msdyn_visibility"></a> msdyn_visibility

|Property|Value|
|---|---|
|Description|**Unique value to set the visibility value**|
|DisplayName|**Visibility**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_visibility`|
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
|Description|**Status of the Macro Action Template**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_productivitymacroactiontemplate_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Macro Action Template**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_productivitymacroactiontemplate_statuscode`|

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

- [business_unit_msdyn_productivitymacroactiontemplate](#BKMK_business_unit_msdyn_productivitymacroactiontemplate)
- [lk_msdyn_productivitymacroactiontemplate_createdby](#BKMK_lk_msdyn_productivitymacroactiontemplate_createdby)
- [lk_msdyn_productivitymacroactiontemplate_createdonbehalfby](#BKMK_lk_msdyn_productivitymacroactiontemplate_createdonbehalfby)
- [lk_msdyn_productivitymacroactiontemplate_modifiedby](#BKMK_lk_msdyn_productivitymacroactiontemplate_modifiedby)
- [lk_msdyn_productivitymacroactiontemplate_modifiedonbehalfby](#BKMK_lk_msdyn_productivitymacroactiontemplate_modifiedonbehalfby)
- [msdyn_msdyn_Prod_macroconnector_msdyn_macroactiontemplate_macroconnector](#BKMK_msdyn_msdyn_Prod_macroconnector_msdyn_macroactiontemplate_macroconnector)
- [owner_msdyn_productivitymacroactiontemplate](#BKMK_owner_msdyn_productivitymacroactiontemplate)
- [team_msdyn_productivitymacroactiontemplate](#BKMK_team_msdyn_productivitymacroactiontemplate)
- [user_msdyn_productivitymacroactiontemplate](#BKMK_user_msdyn_productivitymacroactiontemplate)

### <a name="BKMK_business_unit_msdyn_productivitymacroactiontemplate"></a> business_unit_msdyn_productivitymacroactiontemplate

One-To-Many Relationship: [businessunit business_unit_msdyn_productivitymacroactiontemplate](businessunit.md#BKMK_business_unit_msdyn_productivitymacroactiontemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_productivitymacroactiontemplate_createdby"></a> lk_msdyn_productivitymacroactiontemplate_createdby

One-To-Many Relationship: [systemuser lk_msdyn_productivitymacroactiontemplate_createdby](systemuser.md#BKMK_lk_msdyn_productivitymacroactiontemplate_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_productivitymacroactiontemplate_createdonbehalfby"></a> lk_msdyn_productivitymacroactiontemplate_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_productivitymacroactiontemplate_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_productivitymacroactiontemplate_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_productivitymacroactiontemplate_modifiedby"></a> lk_msdyn_productivitymacroactiontemplate_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_productivitymacroactiontemplate_modifiedby](systemuser.md#BKMK_lk_msdyn_productivitymacroactiontemplate_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_productivitymacroactiontemplate_modifiedonbehalfby"></a> lk_msdyn_productivitymacroactiontemplate_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_productivitymacroactiontemplate_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_productivitymacroactiontemplate_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_Prod_macroconnector_msdyn_macroactiontemplate_macroconnector"></a> msdyn_msdyn_Prod_macroconnector_msdyn_macroactiontemplate_macroconnector

One-To-Many Relationship: [msdyn_productivitymacroconnector msdyn_msdyn_Prod_macroconnector_msdyn_macroactiontemplate_macroconnector](msdyn_productivitymacroconnector.md#BKMK_msdyn_msdyn_Prod_macroconnector_msdyn_macroactiontemplate_macroconnector)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productivitymacroconnector`|
|ReferencedAttribute|`msdyn_productivitymacroconnectorid`|
|ReferencingAttribute|`msdyn_macroconnector`|
|ReferencingEntityNavigationPropertyName|`msdyn_macroconnector`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_productivitymacroactiontemplate"></a> owner_msdyn_productivitymacroactiontemplate

One-To-Many Relationship: [owner owner_msdyn_productivitymacroactiontemplate](owner.md#BKMK_owner_msdyn_productivitymacroactiontemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_productivitymacroactiontemplate"></a> team_msdyn_productivitymacroactiontemplate

One-To-Many Relationship: [team team_msdyn_productivitymacroactiontemplate](team.md#BKMK_team_msdyn_productivitymacroactiontemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_productivitymacroactiontemplate"></a> user_msdyn_productivitymacroactiontemplate

One-To-Many Relationship: [systemuser user_msdyn_productivitymacroactiontemplate](systemuser.md#BKMK_user_msdyn_productivitymacroactiontemplate)

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

- [msdyn_msdyn_prod_macroactiontemplate_msdyn_actioninput](#BKMK_msdyn_msdyn_prod_macroactiontemplate_msdyn_actioninput)
- [msdyn_msdyn_prod_macroactiontemplate_msdyn_actionout](#BKMK_msdyn_msdyn_prod_macroactiontemplate_msdyn_actionout)
- [msdyn_productivitymacroactiontemplate_AsyncOperations](#BKMK_msdyn_productivitymacroactiontemplate_AsyncOperations)
- [msdyn_productivitymacroactiontemplate_BulkDeleteFailures](#BKMK_msdyn_productivitymacroactiontemplate_BulkDeleteFailures)
- [msdyn_productivitymacroactiontemplate_DuplicateBaseRecord](#BKMK_msdyn_productivitymacroactiontemplate_DuplicateBaseRecord)
- [msdyn_productivitymacroactiontemplate_DuplicateMatchingRecord](#BKMK_msdyn_productivitymacroactiontemplate_DuplicateMatchingRecord)
- [msdyn_productivitymacroactiontemplate_MailboxTrackingFolders](#BKMK_msdyn_productivitymacroactiontemplate_MailboxTrackingFolders)
- [msdyn_productivitymacroactiontemplate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_productivitymacroactiontemplate_PrincipalObjectAttributeAccesses)
- [msdyn_productivitymacroactiontemplate_ProcessSession](#BKMK_msdyn_productivitymacroactiontemplate_ProcessSession)
- [msdyn_productivitymacroactiontemplate_SyncErrors](#BKMK_msdyn_productivitymacroactiontemplate_SyncErrors)

### <a name="BKMK_msdyn_msdyn_prod_macroactiontemplate_msdyn_actioninput"></a> msdyn_msdyn_prod_macroactiontemplate_msdyn_actioninput

Many-To-One Relationship: [msdyn_productivityactioninputparameter msdyn_msdyn_prod_macroactiontemplate_msdyn_actioninput](msdyn_productivityactioninputparameter.md#BKMK_msdyn_msdyn_prod_macroactiontemplate_msdyn_actioninput)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivityactioninputparameter`|
|ReferencingAttribute|`msdyn_actiontemplateinputparameterid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_prod_macroactiontemplate_msdyn_actioninput`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_prod_macroactiontemplate_msdyn_actionout"></a> msdyn_msdyn_prod_macroactiontemplate_msdyn_actionout

Many-To-One Relationship: [msdyn_productivityactionoutputparameter msdyn_msdyn_prod_macroactiontemplate_msdyn_actionout](msdyn_productivityactionoutputparameter.md#BKMK_msdyn_msdyn_prod_macroactiontemplate_msdyn_actionout)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivityactionoutputparameter`|
|ReferencingAttribute|`msdyn_actiontemplateoutputparameterid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_prod_macroactiontemplate_msdyn_actionout`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_productivitymacroactiontemplate_AsyncOperations"></a> msdyn_productivitymacroactiontemplate_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_productivitymacroactiontemplate_AsyncOperations](asyncoperation.md#BKMK_msdyn_productivitymacroactiontemplate_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_productivitymacroactiontemplate_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_productivitymacroactiontemplate_BulkDeleteFailures"></a> msdyn_productivitymacroactiontemplate_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_productivitymacroactiontemplate_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_productivitymacroactiontemplate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_productivitymacroactiontemplate_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_productivitymacroactiontemplate_DuplicateBaseRecord"></a> msdyn_productivitymacroactiontemplate_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_productivitymacroactiontemplate_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_productivitymacroactiontemplate_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_productivitymacroactiontemplate_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_productivitymacroactiontemplate_DuplicateMatchingRecord"></a> msdyn_productivitymacroactiontemplate_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_productivitymacroactiontemplate_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_productivitymacroactiontemplate_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_productivitymacroactiontemplate_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_productivitymacroactiontemplate_MailboxTrackingFolders"></a> msdyn_productivitymacroactiontemplate_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_productivitymacroactiontemplate_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_productivitymacroactiontemplate_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_productivitymacroactiontemplate_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_productivitymacroactiontemplate_PrincipalObjectAttributeAccesses"></a> msdyn_productivitymacroactiontemplate_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_productivitymacroactiontemplate_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_productivitymacroactiontemplate_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_productivitymacroactiontemplate_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_productivitymacroactiontemplate_ProcessSession"></a> msdyn_productivitymacroactiontemplate_ProcessSession

Many-To-One Relationship: [processsession msdyn_productivitymacroactiontemplate_ProcessSession](processsession.md#BKMK_msdyn_productivitymacroactiontemplate_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_productivitymacroactiontemplate_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_productivitymacroactiontemplate_SyncErrors"></a> msdyn_productivitymacroactiontemplate_SyncErrors

Many-To-One Relationship: [syncerror msdyn_productivitymacroactiontemplate_SyncErrors](syncerror.md#BKMK_msdyn_productivitymacroactiontemplate_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_productivitymacroactiontemplate_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

