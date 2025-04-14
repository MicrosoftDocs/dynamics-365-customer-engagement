---
title: "Channel Definition (msdyn_ChannelDefinition) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Channel Definition (msdyn_ChannelDefinition) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Channel Definition (msdyn_ChannelDefinition) table/entity reference (Microsoft Dynamics 365)

Stores details about a channel definition.

## Messages

The following table lists the messages for the Channel Definition (msdyn_ChannelDefinition) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_channeldefinitions(*msdyn_channeldefinitionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_channeldefinitions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_channeldefinitions(*msdyn_channeldefinitionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_channeldefinitions(*msdyn_channeldefinitionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_channeldefinitions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_channeldefinitions(*msdyn_channeldefinitionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_channeldefinitions(*msdyn_channeldefinitionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_channeldefinitions(*msdyn_channeldefinitionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Channel Definition (msdyn_ChannelDefinition) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Channel Definition** |
| **DisplayCollectionName** | **Channel Definitions** |
| **SchemaName** | `msdyn_ChannelDefinition` |
| **CollectionSchemaName** | `msdyn_ChannelDefinitions` |
| **EntitySetName** | `msdyn_channeldefinitions`|
| **LogicalName** | `msdyn_channeldefinition` |
| **LogicalCollectionName** | `msdyn_channeldefinitions` |
| **PrimaryIdAttribute** | `msdyn_channeldefinitionid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_ChannelDefinitionAccountExternalEntity](#BKMK_msdyn_ChannelDefinitionAccountExternalEntity)
- [msdyn_ChannelDefinitionAccountExternalFormId](#BKMK_msdyn_ChannelDefinitionAccountExternalFormId)
- [msdyn_ChannelDefinitionExternalEntity](#BKMK_msdyn_ChannelDefinitionExternalEntity)
- [msdyn_ChannelDefinitionExternalFormId](#BKMK_msdyn_ChannelDefinitionExternalFormId)
- [msdyn_ChannelDefinitionId](#BKMK_msdyn_ChannelDefinitionId)
- [msdyn_ChannelType](#BKMK_msdyn_ChannelType)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_DisplayName](#BKMK_msdyn_DisplayName)
- [msdyn_HasDeliveryReceipt](#BKMK_msdyn_HasDeliveryReceipt)
- [msdyn_HasInbound](#BKMK_msdyn_HasInbound)
- [msdyn_InstanceRegistrationEndpointUrlTemplate](#BKMK_msdyn_InstanceRegistrationEndpointUrlTemplate)
- [msdyn_MessageFormId](#BKMK_msdyn_MessageFormId)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_OutboundEndpointUrlTemplate](#BKMK_msdyn_OutboundEndpointUrlTemplate)
- [msdyn_SpecialConsentLabel](#BKMK_msdyn_SpecialConsentLabel)
- [msdyn_SpecialConsentRequired](#BKMK_msdyn_SpecialConsentRequired)
- [msdyn_SupportsAccount](#BKMK_msdyn_SupportsAccount)
- [msdyn_SupportsAttachment](#BKMK_msdyn_SupportsAttachment)
- [msdyn_SupportsBinary](#BKMK_msdyn_SupportsBinary)
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

### <a name="BKMK_msdyn_ChannelDefinitionAccountExternalEntity"></a> msdyn_ChannelDefinitionAccountExternalEntity

|Property|Value|
|---|---|
|Description||
|DisplayName|**Channel definition account external entity name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channeldefinitionaccountexternalentity`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ChannelDefinitionAccountExternalFormId"></a> msdyn_ChannelDefinitionAccountExternalFormId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Channel definition account external form id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channeldefinitionaccountexternalformid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ChannelDefinitionExternalEntity"></a> msdyn_ChannelDefinitionExternalEntity

|Property|Value|
|---|---|
|Description||
|DisplayName|**Channel definition external entity name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channeldefinitionexternalentity`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ChannelDefinitionExternalFormId"></a> msdyn_ChannelDefinitionExternalFormId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Channel definition external entity form id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channeldefinitionexternalformid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ChannelDefinitionId"></a> msdyn_ChannelDefinitionId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Channel Definition**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_channeldefinitionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ChannelType"></a> msdyn_ChannelType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Channel Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channeltype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_DisplayName"></a> msdyn_DisplayName

|Property|Value|
|---|---|
|Description||
|DisplayName|**Display Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_displayname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_HasDeliveryReceipt"></a> msdyn_HasDeliveryReceipt

|Property|Value|
|---|---|
|Description|**Does the channel has delivery receipt capability**|
|DisplayName|**Has Delivery Receipt**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_hasdeliveryreceipt`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_channeldefinition_msdyn_hasdeliveryreceipt`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_HasInbound"></a> msdyn_HasInbound

|Property|Value|
|---|---|
|Description|**If channel has inbound capabilities**|
|DisplayName|**Has Inbound**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_hasinbound`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_channeldefinition_msdyn_hasinbound`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_InstanceRegistrationEndpointUrlTemplate"></a> msdyn_InstanceRegistrationEndpointUrlTemplate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Instance Registration Endpoint Url Template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_instanceregistrationendpointurltemplate`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_MessageFormId"></a> msdyn_MessageFormId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Message form ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_messageformid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Name"></a> msdyn_Name

|Property|Value|
|---|---|
|Description||
|DisplayName|**Channel Name**|
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

### <a name="BKMK_msdyn_OutboundEndpointUrlTemplate"></a> msdyn_OutboundEndpointUrlTemplate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Outbound endpoint URL template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_outboundendpointurltemplate`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_SpecialConsentLabel"></a> msdyn_SpecialConsentLabel

|Property|Value|
|---|---|
|Description||
|DisplayName|**Special Consent Label**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_specialconsentlabel`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_SpecialConsentRequired"></a> msdyn_SpecialConsentRequired

|Property|Value|
|---|---|
|Description|**Does the channel require special consent**|
|DisplayName|**Special Consent Required**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_specialconsentrequired`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_channeldefinition_msdyn_specialconsentrequired`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_SupportsAccount"></a> msdyn_SupportsAccount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Supports Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_supportsaccount`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_channeldefinition_msdyn_supportsaccount`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_SupportsAttachment"></a> msdyn_SupportsAttachment

|Property|Value|
|---|---|
|Description|**Does the channel supports attachment ?**|
|DisplayName|**Supports Attachment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_supportsattachment`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_channeldefinition_msdyn_supportsattachment`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_SupportsBinary"></a> msdyn_SupportsBinary

|Property|Value|
|---|---|
|Description|**Does the channel support binary content**|
|DisplayName|**Supports Binary**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_supportsbinary`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_channeldefinition_msdyn_supportsbinary`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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
|Description|**Status of the Channel Definition**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_channeldefinition_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Channel Definition**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_channeldefinition_statuscode`|

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

- [business_unit_msdyn_channeldefinition](#BKMK_business_unit_msdyn_channeldefinition)
- [lk_msdyn_channeldefinition_createdby](#BKMK_lk_msdyn_channeldefinition_createdby)
- [lk_msdyn_channeldefinition_createdonbehalfby](#BKMK_lk_msdyn_channeldefinition_createdonbehalfby)
- [lk_msdyn_channeldefinition_modifiedby](#BKMK_lk_msdyn_channeldefinition_modifiedby)
- [lk_msdyn_channeldefinition_modifiedonbehalfby](#BKMK_lk_msdyn_channeldefinition_modifiedonbehalfby)
- [owner_msdyn_channeldefinition](#BKMK_owner_msdyn_channeldefinition)
- [team_msdyn_channeldefinition](#BKMK_team_msdyn_channeldefinition)
- [user_msdyn_channeldefinition](#BKMK_user_msdyn_channeldefinition)

### <a name="BKMK_business_unit_msdyn_channeldefinition"></a> business_unit_msdyn_channeldefinition

One-To-Many Relationship: [businessunit business_unit_msdyn_channeldefinition](businessunit.md#BKMK_business_unit_msdyn_channeldefinition)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_channeldefinition_createdby"></a> lk_msdyn_channeldefinition_createdby

One-To-Many Relationship: [systemuser lk_msdyn_channeldefinition_createdby](systemuser.md#BKMK_lk_msdyn_channeldefinition_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_channeldefinition_createdonbehalfby"></a> lk_msdyn_channeldefinition_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_channeldefinition_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_channeldefinition_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_channeldefinition_modifiedby"></a> lk_msdyn_channeldefinition_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_channeldefinition_modifiedby](systemuser.md#BKMK_lk_msdyn_channeldefinition_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_channeldefinition_modifiedonbehalfby"></a> lk_msdyn_channeldefinition_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_channeldefinition_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_channeldefinition_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_channeldefinition"></a> owner_msdyn_channeldefinition

One-To-Many Relationship: [owner owner_msdyn_channeldefinition](owner.md#BKMK_owner_msdyn_channeldefinition)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_channeldefinition"></a> team_msdyn_channeldefinition

One-To-Many Relationship: [team team_msdyn_channeldefinition](team.md#BKMK_team_msdyn_channeldefinition)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_channeldefinition"></a> user_msdyn_channeldefinition

One-To-Many Relationship: [systemuser user_msdyn_channeldefinition](systemuser.md#BKMK_user_msdyn_channeldefinition)

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

- [msdyn_channeldefinition_AsyncOperations](#BKMK_msdyn_channeldefinition_AsyncOperations)
- [msdyn_channeldefinition_BulkDeleteFailures](#BKMK_msdyn_channeldefinition_BulkDeleteFailures)
- [msdyn_channeldefinition_DuplicateBaseRecord](#BKMK_msdyn_channeldefinition_DuplicateBaseRecord)
- [msdyn_channeldefinition_DuplicateMatchingRecord](#BKMK_msdyn_channeldefinition_DuplicateMatchingRecord)
- [msdyn_channeldefinition_MailboxTrackingFolders](#BKMK_msdyn_channeldefinition_MailboxTrackingFolders)
- [msdyn_channeldefinition_PrincipalObjectAttributeAccesses](#BKMK_msdyn_channeldefinition_PrincipalObjectAttributeAccesses)
- [msdyn_channeldefinition_ProcessSession](#BKMK_msdyn_channeldefinition_ProcessSession)
- [msdyn_channeldefinition_SyncErrors](#BKMK_msdyn_channeldefinition_SyncErrors)
- [msdyn_msdyn_channeldefinitionconsent_ChannelDefinitionId](#BKMK_msdyn_msdyn_channeldefinitionconsent_ChannelDefinitionId)
- [msdyn_msdyn_channeldefinitionlocale_ChannelDefi](#BKMK_msdyn_msdyn_channeldefinitionlocale_ChannelDefi)
- [msdyn_msdyn_channelinstance_ChannelDefinition_m](#BKMK_msdyn_msdyn_channelinstance_ChannelDefinition_m)
- [msdyn_msdyn_channelinstanceaccount_ChannelDefin](#BKMK_msdyn_msdyn_channelinstanceaccount_ChannelDefin)
- [msdyn_msdyn_channelmessagecontextpart_ChannelDe](#BKMK_msdyn_msdyn_channelmessagecontextpart_ChannelDe)
- [msdyn_msdyn_channelmessagepart_ChannelDefinition_msdyn](#BKMK_msdyn_msdyn_channelmessagepart_ChannelDefinition_msdyn)

### <a name="BKMK_msdyn_channeldefinition_AsyncOperations"></a> msdyn_channeldefinition_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_channeldefinition_AsyncOperations](asyncoperation.md#BKMK_msdyn_channeldefinition_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channeldefinition_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channeldefinition_BulkDeleteFailures"></a> msdyn_channeldefinition_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_channeldefinition_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_channeldefinition_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channeldefinition_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channeldefinition_DuplicateBaseRecord"></a> msdyn_channeldefinition_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_channeldefinition_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_channeldefinition_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channeldefinition_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channeldefinition_DuplicateMatchingRecord"></a> msdyn_channeldefinition_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_channeldefinition_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_channeldefinition_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channeldefinition_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channeldefinition_MailboxTrackingFolders"></a> msdyn_channeldefinition_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_channeldefinition_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_channeldefinition_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channeldefinition_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channeldefinition_PrincipalObjectAttributeAccesses"></a> msdyn_channeldefinition_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_channeldefinition_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_channeldefinition_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channeldefinition_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channeldefinition_ProcessSession"></a> msdyn_channeldefinition_ProcessSession

Many-To-One Relationship: [processsession msdyn_channeldefinition_ProcessSession](processsession.md#BKMK_msdyn_channeldefinition_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channeldefinition_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channeldefinition_SyncErrors"></a> msdyn_channeldefinition_SyncErrors

Many-To-One Relationship: [syncerror msdyn_channeldefinition_SyncErrors](syncerror.md#BKMK_msdyn_channeldefinition_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channeldefinition_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_channeldefinitionconsent_ChannelDefinitionId"></a> msdyn_msdyn_channeldefinitionconsent_ChannelDefinitionId

Many-To-One Relationship: [msdyn_channeldefinitionconsent msdyn_msdyn_channeldefinitionconsent_ChannelDefinitionId](msdyn_channeldefinitionconsent.md#BKMK_msdyn_msdyn_channeldefinitionconsent_ChannelDefinitionId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channeldefinitionconsent`|
|ReferencingAttribute|`msdyn_channeldefinitionid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_channeldefinitionconsent_ChannelDefinitionId`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_channeldefinitionlocale_ChannelDefi"></a> msdyn_msdyn_channeldefinitionlocale_ChannelDefi

Many-To-One Relationship: [msdyn_channeldefinitionlocale msdyn_msdyn_channeldefinitionlocale_ChannelDefi](msdyn_channeldefinitionlocale.md#BKMK_msdyn_msdyn_channeldefinitionlocale_ChannelDefi)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channeldefinitionlocale`|
|ReferencingAttribute|`msdyn_channeldefinitionid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_channeldefinitionlocale_ChannelDefi`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_channelinstance_ChannelDefinition_m"></a> msdyn_msdyn_channelinstance_ChannelDefinition_m

Many-To-One Relationship: [msdyn_channelinstance msdyn_msdyn_channelinstance_ChannelDefinition_m](msdyn_channelinstance.md#BKMK_msdyn_msdyn_channelinstance_ChannelDefinition_m)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelinstance`|
|ReferencingAttribute|`msdyn_channeldefinitionid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_channelinstance_ChannelDefinition_m`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_channelinstanceaccount_ChannelDefin"></a> msdyn_msdyn_channelinstanceaccount_ChannelDefin

Many-To-One Relationship: [msdyn_channelinstanceaccount msdyn_msdyn_channelinstanceaccount_ChannelDefin](msdyn_channelinstanceaccount.md#BKMK_msdyn_msdyn_channelinstanceaccount_ChannelDefin)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelinstanceaccount`|
|ReferencingAttribute|`msdyn_channeldefinitionid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_channelinstanceaccount_ChannelDefin`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_channelmessagecontextpart_ChannelDe"></a> msdyn_msdyn_channelmessagecontextpart_ChannelDe

Many-To-One Relationship: [msdyn_channelmessagecontextpart msdyn_msdyn_channelmessagecontextpart_ChannelDe](msdyn_channelmessagecontextpart.md#BKMK_msdyn_msdyn_channelmessagecontextpart_ChannelDe)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelmessagecontextpart`|
|ReferencingAttribute|`msdyn_channeldefinitionid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_channelmessagecontextpart_ChannelDe`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_channelmessagepart_ChannelDefinition_msdyn"></a> msdyn_msdyn_channelmessagepart_ChannelDefinition_msdyn

Many-To-One Relationship: [msdyn_channelmessagepart msdyn_msdyn_channelmessagepart_ChannelDefinition_msdyn](msdyn_channelmessagepart.md#BKMK_msdyn_msdyn_channelmessagepart_ChannelDefinition_msdyn)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelmessagepart`|
|ReferencingAttribute|`msdyn_channeldefinitionid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_channelmessagepart_ChannelDefinition_msdyn`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

