---
title: "Message Template (msdyn_oc_message_template) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Message Template (msdyn_oc_message_template) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: puneet-singh1
ms.author: puneetsingh
search.audienceType: 
  - developer
---

# Message Template (msdyn_oc_message_template) table/entity reference (Microsoft Dynamics 365 Field Service)

Provider-agnostic catalog of reusable message templates (WhatsApp / SMS / MMS / RCS) that Omnichannel consumers fetch or create across providers (Meta-Direct, ACS, Twilio).

## Messages

The following table lists the messages for the Message Template (msdyn_oc_message_template) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_oc_message_templates<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_oc_message_templates(*msdyn_oc_message_templateid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_oc_message_templates(*msdyn_oc_message_templateid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_oc_message_templates<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_oc_message_templates(*msdyn_oc_message_templateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_oc_message_templates(*msdyn_oc_message_templateid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_oc_message_templates(*msdyn_oc_message_templateid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Message Template (msdyn_oc_message_template) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Message Template** |
| **DisplayCollectionName** | **Message Templates** |
| **SchemaName** | `msdyn_oc_message_template` |
| **CollectionSchemaName** | `msdyn_oc_message_templates` |
| **EntitySetName** | `msdyn_oc_message_templates`|
| **LogicalName** | `msdyn_oc_message_template` |
| **LogicalCollectionName** | `msdyn_oc_message_templates` |
| **PrimaryIdAttribute** | `msdyn_oc_message_templateid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_bodytext](#BKMK_msdyn_bodytext)
- [msdyn_category](#BKMK_msdyn_category)
- [msdyn_channelinstanceid](#BKMK_msdyn_channelinstanceid)
- [msdyn_channeltype](#BKMK_msdyn_channeltype)
- [msdyn_content](#BKMK_msdyn_content)
- [msdyn_displayname](#BKMK_msdyn_displayname)
- [msdyn_language](#BKMK_msdyn_language)
- [msdyn_lastsyncedon](#BKMK_msdyn_lastsyncedon)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_oc_message_template_type](#BKMK_msdyn_oc_message_template_type)
- [msdyn_oc_message_templateId](#BKMK_msdyn_oc_message_templateId)
- [msdyn_providerlastupdatedon](#BKMK_msdyn_providerlastupdatedon)
- [msdyn_providerstatus](#BKMK_msdyn_providerstatus)
- [msdyn_providertemplateid](#BKMK_msdyn_providertemplateid)
- [msdyn_providertype](#BKMK_msdyn_providertype)
- [msdyn_qualityscore](#BKMK_msdyn_qualityscore)
- [msdyn_rejectionreason](#BKMK_msdyn_rejectionreason)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
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

### <a name="BKMK_msdyn_bodytext"></a> msdyn_bodytext

|Property|Value|
|---|---|
|Description|**Denormalized body text for quick preview and search. Non-authoritative; the authoritative structure lives in Content.**|
|DisplayName|**Body Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bodytext`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_category"></a> msdyn_category

|Property|Value|
|---|---|
|Description|**WhatsApp template category (Marketing / Utility / Authentication). Null for non-WhatsApp providers.**|
|DisplayName|**Category**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_category`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_oc_message_template_category`|

#### msdyn_category Choices/Options

|Value|Label|
|---|---|
|700610000|**Marketing**|
|700610001|**Utility**|
|700610002|**Authentication**|

### <a name="BKMK_msdyn_channelinstanceid"></a> msdyn_channelinstanceid

|Property|Value|
|---|---|
|Description|**WABA / channel instance the template belongs to. Part of the alternate key; must never be null — use a reserved sentinel for instance-less rows.**|
|DisplayName|**Channel Instance Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channelinstanceid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_channeltype"></a> msdyn_channeltype

|Property|Value|
|---|---|
|Description|**Channel the template belongs to (WhatsApp / SMS). The format within the channel is carried separately by Template Format.**|
|DisplayName|**Channel Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channeltype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_oc_message_template_channeltype`|

#### msdyn_channeltype Choices/Options

|Value|Label|
|---|---|
|700610000|**WhatsApp**|
|700610001|**SMS**|

### <a name="BKMK_msdyn_content"></a> msdyn_content

|Property|Value|
|---|---|
|Description|**Uniform self-describing JSON definition of the template (provider structure plus parameter definitions). WhatsApp components; MMS \{text, mediaAttachments\}; SMS \{text\}.**|
|DisplayName|**Content**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_content`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_displayname"></a> msdyn_displayname

|Property|Value|
|---|---|
|Description|**Optional friendly label shown in the template picker.**|
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
|MaxLength|200|

### <a name="BKMK_msdyn_language"></a> msdyn_language

|Property|Value|
|---|---|
|Description|**Canonical BCP-47 language code (e.g. en-US). The provider-specific code is resolved at the provider adapter, not stored here.**|
|DisplayName|**Language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_language`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_msdyn_lastsyncedon"></a> msdyn_lastsyncedon

|Property|Value|
|---|---|
|Description|**Timestamp of the last reconcile of this catalog row with the provider (cache providers).**|
|DisplayName|**Last Synced On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastsyncedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Provider template name — the value sent to the provider.**|
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
|MaxLength|200|

### <a name="BKMK_msdyn_oc_message_template_type"></a> msdyn_oc_message_template_type

|Property|Value|
|---|---|
|Description|**Message format / channel discriminator (SMS / MMS / RCS / WhatsApp). Part of the alternate key, so it is always populated with the row's single canonical value.**|
|DisplayName|**Template Format**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_oc_message_template_type`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_octemplateformat`|

#### msdyn_oc_message_template_type Choices/Options

|Value|Label|
|---|---|
|100000000|**SMS**|
|100000001|**MMS**|
|100000002|**RCS**|
|100000004|**WhatsApp**|

### <a name="BKMK_msdyn_oc_message_templateId"></a> msdyn_oc_message_templateId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Message Template**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_oc_message_templateid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_providerlastupdatedon"></a> msdyn_providerlastupdatedon

|Property|Value|
|---|---|
|Description|**Provider's last-updated timestamp for the template (UTC).**|
|DisplayName|**Provider Last Updated On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_providerlastupdatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_providerstatus"></a> msdyn_providerstatus

|Property|Value|
|---|---|
|Description|**Template lifecycle status reported by the provider (e.g. Meta approval state).**|
|DisplayName|**Provider Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_providerstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_oc_message_template_providerstatus`|

#### msdyn_providerstatus Choices/Options

|Value|Label|
|---|---|
|700610000|**Approved**|
|700610001|**Pending**|
|700610002|**Rejected**|
|700610003|**Paused**|
|700610004|**Disabled**|
|700610005|**In Appeal**|
|700610006|**Pending Deletion**|

### <a name="BKMK_msdyn_providertemplateid"></a> msdyn_providertemplateid

|Property|Value|
|---|---|
|Description|**Provider-side identifier where one exists (e.g. Meta template id); null for authored ACS / MMS templates.**|
|DisplayName|**Provider Template Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_providertemplateid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_providertype"></a> msdyn_providertype

|Property|Value|
|---|---|
|Description|**Messaging provider that owns this template (Twilio / Azure Communication Services / Meta).**|
|DisplayName|**Provider Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_providertype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_oc_message_template_providertype`|

#### msdyn_providertype Choices/Options

|Value|Label|
|---|---|
|192350000|**Twilio**|
|192350001|**Azure Communication Services**|
|192350002|**Meta**|

### <a name="BKMK_msdyn_qualityscore"></a> msdyn_qualityscore

|Property|Value|
|---|---|
|Description|**Provider-reported quality rating for the template (Green / Yellow / Red).**|
|DisplayName|**Quality Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_qualityscore`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_oc_message_template_qualityscore`|

#### msdyn_qualityscore Choices/Options

|Value|Label|
|---|---|
|700610000|**Green**|
|700610001|**Yellow**|
|700610002|**Red**|

### <a name="BKMK_msdyn_rejectionreason"></a> msdyn_rejectionreason

|Property|Value|
|---|---|
|Description|**Reason supplied by the provider when the template was rejected.**|
|DisplayName|**Rejection Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rejectionreason`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Message Template**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_oc_message_template_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Message Template**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_oc_message_template_statuscode`|

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
- [OrganizationId](#BKMK_OrganizationId)
- [OverwriteTime](#BKMK_OverwriteTime)
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

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
|DisplayName|**Organization Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|organization|

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

## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_proactive_engagement_message_template_msdyn_oc_message_template"></a> msdyn_proactive_engagement_message_template_msdyn_oc_message_template

Many-To-One Relationship: [msdyn_proactive_engagement_message_template msdyn_proactive_engagement_message_template_msdyn_oc_message_template](msdyn_proactive_engagement_message_template.md#BKMK_msdyn_proactive_engagement_message_template_msdyn_oc_message_template)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_engagement_message_template`|
|ReferencingAttribute|`msdyn_ocmessagetemplateid`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_message_template_msdyn_oc_message_template`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

