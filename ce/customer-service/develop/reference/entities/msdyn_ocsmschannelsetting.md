---
title: "SMS Number settings (msdyn_ocsmschannelsetting) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the SMS Number settings (msdyn_ocsmschannelsetting) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# SMS Number settings (msdyn_ocsmschannelsetting) table/entity reference (Microsoft Dynamics 365 Customer Service)

Stores information about the properties of SMS support number configured to send and receive text messages

## Messages

The following table lists the messages for the SMS Number settings (msdyn_ocsmschannelsetting) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_ocsmschannelsettings<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocsmschannelsettings(*msdyn_ocsmschannelsettingid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocsmschannelsettings(*msdyn_ocsmschannelsettingid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocsmschannelsettings<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocsmschannelsettings(*msdyn_ocsmschannelsettingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocsmschannelsettings(*msdyn_ocsmschannelsettingid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocsmschannelsettings(*msdyn_ocsmschannelsettingid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the SMS Number settings (msdyn_ocsmschannelsetting) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **SMS Number settings** |
| **DisplayCollectionName** | **SMS Number settings** |
| **SchemaName** | `msdyn_ocsmschannelsetting` |
| **CollectionSchemaName** | `msdyn_ocsmschannelsettings` |
| **EntitySetName** | `msdyn_ocsmschannelsettings`|
| **LogicalName** | `msdyn_ocsmschannelsetting` |
| **LogicalCollectionName** | `msdyn_ocsmschannelsettings` |
| **PrimaryIdAttribute** | `msdyn_ocsmschannelsettingid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_enablefileattachmentforagents](#BKMK_msdyn_enablefileattachmentforagents)
- [msdyn_enablefileattachmentforcustomers](#BKMK_msdyn_enablefileattachmentforcustomers)
- [msdyn_inboundurl](#BKMK_msdyn_inboundurl)
- [msdyn_language](#BKMK_msdyn_language)
- [msdyn_liveworkstreamid](#BKMK_msdyn_liveworkstreamid)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ocsmschannelsettingId](#BKMK_msdyn_ocsmschannelsettingId)
- [msdyn_operatinghourid](#BKMK_msdyn_operatinghourid)
- [msdyn_PhoneNumberId](#BKMK_msdyn_PhoneNumberId)
- [msdyn_postconversationsurvey](#BKMK_msdyn_postconversationsurvey)
- [msdyn_postconversationsurveybotsurvey](#BKMK_msdyn_postconversationsurveybotsurvey)
- [msdyn_postconversationsurveybotsurveymessagetext](#BKMK_msdyn_postconversationsurveybotsurveymessagetext)
- [msdyn_postconversationsurveybotsurveymode](#BKMK_msdyn_postconversationsurveybotsurveymode)
- [msdyn_postconversationsurveyenable](#BKMK_msdyn_postconversationsurveyenable)
- [msdyn_postconversationsurveymessagetext](#BKMK_msdyn_postconversationsurveymessagetext)
- [msdyn_postconversationsurveymode](#BKMK_msdyn_postconversationsurveymode)
- [msdyn_postconversationsurveyseparatebotsurvey](#BKMK_msdyn_postconversationsurveyseparatebotsurvey)
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

### <a name="BKMK_msdyn_enablefileattachmentforagents"></a> msdyn_enablefileattachmentforagents

|Property|Value|
|---|---|
|Description|**Enable file attachments for agents**|
|DisplayName|**Enable file attachments for agents**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablefileattachmentforagents`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocsmschannelsetting_msdyn_enablefileattachmentforagents`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enablefileattachmentforcustomers"></a> msdyn_enablefileattachmentforcustomers

|Property|Value|
|---|---|
|Description|**Enable file attachments for customers**|
|DisplayName|**Enable file attachments for customers**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablefileattachmentforcustomers`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocsmschannelsetting_msdyn_enablefileattachmentforcustomers`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_inboundurl"></a> msdyn_inboundurl

|Property|Value|
|---|---|
|Description|**URL for Inbound link**|
|DisplayName|**Inbound URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inboundurl`|
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
|Description|**The language setting for the SMS number**|
|DisplayName|**SMS number language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_language`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_oclanguage|

### <a name="BKMK_msdyn_liveworkstreamid"></a> msdyn_liveworkstreamid

|Property|Value|
|---|---|
|Description|**Unique identifier for Work Stream associated with SMS Number**|
|DisplayName|**Work Stream**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_liveworkstreamid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_liveworkstream|

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

### <a name="BKMK_msdyn_ocsmschannelsettingId"></a> msdyn_ocsmschannelsettingId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**ocsmschannelsetting**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ocsmschannelsettingid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_operatinghourid"></a> msdyn_operatinghourid

|Property|Value|
|---|---|
|Description|**Used to denote operating hours for the sms numbers record**|
|DisplayName|**Operating Hours**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_operatinghourid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_operatinghour|

### <a name="BKMK_msdyn_PhoneNumberId"></a> msdyn_PhoneNumberId

|Property|Value|
|---|---|
|Description|**Phone Number**|
|DisplayName|**Phone Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_phonenumberid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_ocphonenumber|

### <a name="BKMK_msdyn_postconversationsurvey"></a> msdyn_postconversationsurvey

|Property|Value|
|---|---|
|Description|**Lookup to Dynamics 365 Customer Voice survey field**|
|DisplayName|**Survey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postconversationsurvey`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msfp_survey|

### <a name="BKMK_msdyn_postconversationsurveybotsurvey"></a> msdyn_postconversationsurveybotsurvey

|Property|Value|
|---|---|
|Description|**Enable or disable bot survey**|
|DisplayName|**Bot Survey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postconversationsurveybotsurvey`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_smschannel_postconversationsurveybotsurvey`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_postconversationsurveybotsurveymessagetext"></a> msdyn_postconversationsurveybotsurveymessagetext

|Property|Value|
|---|---|
|Description|**Prefix text for survey link message that will be sent to the user.**|
|DisplayName|**Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postconversationsurveybotsurveymessagetext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_postconversationsurveybotsurveymode"></a> msdyn_postconversationsurveybotsurveymode

|Property|Value|
|---|---|
|Description|**Mode of the survey to be sent**|
|DisplayName|**Survey Mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postconversationsurveybotsurveymode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_postconversationsurveymode`|

#### msdyn_postconversationsurveybotsurveymode Choices/Options

|Value|Label|
|---|---|
|192350000|**Insert survey in conversation**|
|192350001|**Send survey link to conversation**|

### <a name="BKMK_msdyn_postconversationsurveyenable"></a> msdyn_postconversationsurveyenable

|Property|Value|
|---|---|
|Description|**To enable or disable post conversation survey**|
|DisplayName|**Enable**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postconversationsurveyenable`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_postconversationsurveyenable`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_postconversationsurveymessagetext"></a> msdyn_postconversationsurveymessagetext

|Property|Value|
|---|---|
|Description|**Prefix text for survey link message that will be sent to the user.**|
|DisplayName|**Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postconversationsurveymessagetext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_postconversationsurveymode"></a> msdyn_postconversationsurveymode

|Property|Value|
|---|---|
|Description|**Mode of the survey to be sent**|
|DisplayName|**Survey Mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postconversationsurveymode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_postconversationsurveymode`|

#### msdyn_postconversationsurveymode Choices/Options

|Value|Label|
|---|---|
|192350000|**Insert survey in conversation**|
|192350001|**Send survey link to conversation**|

### <a name="BKMK_msdyn_postconversationsurveyseparatebotsurvey"></a> msdyn_postconversationsurveyseparatebotsurvey

|Property|Value|
|---|---|
|Description|**Lookup to Dynamics 365 Customer Voice survey field**|
|DisplayName|**Survey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postconversationsurveyseparatebotsurvey`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msfp_survey|

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
|Description|**Status of the ocsmschannelsetting**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocsmschannelsetting_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the ocsmschannelsetting**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocsmschannelsetting_statuscode`|

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

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [lk_msdyn_ocsmschannelsetting_createdby](#BKMK_lk_msdyn_ocsmschannelsetting_createdby)
- [lk_msdyn_ocsmschannelsetting_createdonbehalfby](#BKMK_lk_msdyn_ocsmschannelsetting_createdonbehalfby)
- [lk_msdyn_ocsmschannelsetting_modifiedby](#BKMK_lk_msdyn_ocsmschannelsetting_modifiedby)
- [lk_msdyn_ocsmschannelsetting_modifiedonbehalfby](#BKMK_lk_msdyn_ocsmschannelsetting_modifiedonbehalfby)
- [msdyn_msdyn_liveworkstream_msdyn_ocsmschannelsetting_liveworkstreamid](#BKMK_msdyn_msdyn_liveworkstream_msdyn_ocsmschannelsetting_liveworkstreamid)
- [msdyn_msdyn_oclanguage_msdyn_ocsmschannelsetting_ocsmschannelsettinglanguage](#BKMK_msdyn_msdyn_oclanguage_msdyn_ocsmschannelsetting_ocsmschannelsettinglanguage)
- [msdyn_msdyn_ocphonenumber_msdyn_ocsmschannelsetting_phonenumberid](#BKMK_msdyn_msdyn_ocphonenumber_msdyn_ocsmschannelsetting_phonenumberid)
- [msdyn_msdyn_operatinghour_msdyn_ocsmschannelsetting_operatinghoursid](#BKMK_msdyn_msdyn_operatinghour_msdyn_ocsmschannelsetting_operatinghoursid)
- [msdyn_msfp_survey_msdyn_ocsmschannelsetting_PostConversationSurvey](#BKMK_msdyn_msfp_survey_msdyn_ocsmschannelsetting_PostConversationSurvey)
- [msdyn_msfp_survey_msdyn_ocsmschannelsetting_PostConversationSurveySeparateBotSurvey](#BKMK_msdyn_msfp_survey_msdyn_ocsmschannelsetting_PostConversationSurveySeparateBotSurvey)
- [organization_msdyn_ocsmschannelsetting](#BKMK_organization_msdyn_ocsmschannelsetting)

### <a name="BKMK_lk_msdyn_ocsmschannelsetting_createdby"></a> lk_msdyn_ocsmschannelsetting_createdby

One-To-Many Relationship: [systemuser lk_msdyn_ocsmschannelsetting_createdby](systemuser.md#BKMK_lk_msdyn_ocsmschannelsetting_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocsmschannelsetting_createdonbehalfby"></a> lk_msdyn_ocsmschannelsetting_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocsmschannelsetting_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_ocsmschannelsetting_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocsmschannelsetting_modifiedby"></a> lk_msdyn_ocsmschannelsetting_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_ocsmschannelsetting_modifiedby](systemuser.md#BKMK_lk_msdyn_ocsmschannelsetting_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocsmschannelsetting_modifiedonbehalfby"></a> lk_msdyn_ocsmschannelsetting_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocsmschannelsetting_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_ocsmschannelsetting_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_liveworkstream_msdyn_ocsmschannelsetting_liveworkstreamid"></a> msdyn_msdyn_liveworkstream_msdyn_ocsmschannelsetting_liveworkstreamid

One-To-Many Relationship: [msdyn_liveworkstream msdyn_msdyn_liveworkstream_msdyn_ocsmschannelsetting_liveworkstreamid](msdyn_liveworkstream.md#BKMK_msdyn_msdyn_liveworkstream_msdyn_ocsmschannelsetting_liveworkstreamid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_liveworkstream`|
|ReferencedAttribute|`msdyn_liveworkstreamid`|
|ReferencingAttribute|`msdyn_liveworkstreamid`|
|ReferencingEntityNavigationPropertyName|`msdyn_liveworkstreamid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_ocsmschannelsetting_ocsmschannelsettinglanguage"></a> msdyn_msdyn_oclanguage_msdyn_ocsmschannelsetting_ocsmschannelsettinglanguage

One-To-Many Relationship: [msdyn_oclanguage msdyn_msdyn_oclanguage_msdyn_ocsmschannelsetting_ocsmschannelsettinglanguage](msdyn_oclanguage.md#BKMK_msdyn_msdyn_oclanguage_msdyn_ocsmschannelsetting_ocsmschannelsettinglanguage)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_oclanguage`|
|ReferencedAttribute|`msdyn_oclanguageid`|
|ReferencingAttribute|`msdyn_language`|
|ReferencingEntityNavigationPropertyName|`msdyn_language`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocphonenumber_msdyn_ocsmschannelsetting_phonenumberid"></a> msdyn_msdyn_ocphonenumber_msdyn_ocsmschannelsetting_phonenumberid

One-To-Many Relationship: [msdyn_ocphonenumber msdyn_msdyn_ocphonenumber_msdyn_ocsmschannelsetting_phonenumberid](msdyn_ocphonenumber.md#BKMK_msdyn_msdyn_ocphonenumber_msdyn_ocsmschannelsetting_phonenumberid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocphonenumber`|
|ReferencedAttribute|`msdyn_ocphonenumberid`|
|ReferencingAttribute|`msdyn_phonenumberid`|
|ReferencingEntityNavigationPropertyName|`msdyn_PhoneNumberId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_operatinghour_msdyn_ocsmschannelsetting_operatinghoursid"></a> msdyn_msdyn_operatinghour_msdyn_ocsmschannelsetting_operatinghoursid

One-To-Many Relationship: [msdyn_operatinghour msdyn_msdyn_operatinghour_msdyn_ocsmschannelsetting_operatinghoursid](msdyn_operatinghour.md#BKMK_msdyn_msdyn_operatinghour_msdyn_ocsmschannelsetting_operatinghoursid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_operatinghour`|
|ReferencedAttribute|`msdyn_operatinghourid`|
|ReferencingAttribute|`msdyn_operatinghourid`|
|ReferencingEntityNavigationPropertyName|`msdyn_operatinghourid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msfp_survey_msdyn_ocsmschannelsetting_PostConversationSurvey"></a> msdyn_msfp_survey_msdyn_ocsmschannelsetting_PostConversationSurvey

One-To-Many Relationship: [msfp_survey msdyn_msfp_survey_msdyn_ocsmschannelsetting_PostConversationSurvey](msfp_survey.md#BKMK_msdyn_msfp_survey_msdyn_ocsmschannelsetting_PostConversationSurvey)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_survey`|
|ReferencedAttribute|`msfp_surveyid`|
|ReferencingAttribute|`msdyn_postconversationsurvey`|
|ReferencingEntityNavigationPropertyName|`msdyn_postconversationsurvey`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msfp_survey_msdyn_ocsmschannelsetting_PostConversationSurveySeparateBotSurvey"></a> msdyn_msfp_survey_msdyn_ocsmschannelsetting_PostConversationSurveySeparateBotSurvey

One-To-Many Relationship: [msfp_survey msdyn_msfp_survey_msdyn_ocsmschannelsetting_PostConversationSurveySeparateBotSurvey](msfp_survey.md#BKMK_msdyn_msfp_survey_msdyn_ocsmschannelsetting_PostConversationSurveySeparateBotSurvey)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_survey`|
|ReferencedAttribute|`msfp_surveyid`|
|ReferencingAttribute|`msdyn_postconversationsurveyseparatebotsurvey`|
|ReferencingEntityNavigationPropertyName|`msdyn_postconversationsurveyseparatebotsurvey`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_ocsmschannelsetting"></a> organization_msdyn_ocsmschannelsetting

One-To-Many Relationship: [organization organization_msdyn_ocsmschannelsetting](organization.md#BKMK_organization_msdyn_ocsmschannelsetting)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_ocsmschannelsetting_AsyncOperations](#BKMK_msdyn_ocsmschannelsetting_AsyncOperations)
- [msdyn_ocsmschannelsetting_BulkDeleteFailures](#BKMK_msdyn_ocsmschannelsetting_BulkDeleteFailures)
- [msdyn_ocsmschannelsetting_DuplicateBaseRecord](#BKMK_msdyn_ocsmschannelsetting_DuplicateBaseRecord)
- [msdyn_ocsmschannelsetting_DuplicateMatchingRecord](#BKMK_msdyn_ocsmschannelsetting_DuplicateMatchingRecord)
- [msdyn_ocsmschannelsetting_MailboxTrackingFolders](#BKMK_msdyn_ocsmschannelsetting_MailboxTrackingFolders)
- [msdyn_ocsmschannelsetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocsmschannelsetting_PrincipalObjectAttributeAccesses)
- [msdyn_ocsmschannelsetting_ProcessSession](#BKMK_msdyn_ocsmschannelsetting_ProcessSession)
- [msdyn_ocsmschannelsetting_SyncErrors](#BKMK_msdyn_ocsmschannelsetting_SyncErrors)

### <a name="BKMK_msdyn_ocsmschannelsetting_AsyncOperations"></a> msdyn_ocsmschannelsetting_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocsmschannelsetting_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocsmschannelsetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsmschannelsetting_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsmschannelsetting_BulkDeleteFailures"></a> msdyn_ocsmschannelsetting_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocsmschannelsetting_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocsmschannelsetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsmschannelsetting_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsmschannelsetting_DuplicateBaseRecord"></a> msdyn_ocsmschannelsetting_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocsmschannelsetting_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ocsmschannelsetting_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsmschannelsetting_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsmschannelsetting_DuplicateMatchingRecord"></a> msdyn_ocsmschannelsetting_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocsmschannelsetting_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ocsmschannelsetting_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsmschannelsetting_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsmschannelsetting_MailboxTrackingFolders"></a> msdyn_ocsmschannelsetting_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocsmschannelsetting_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocsmschannelsetting_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsmschannelsetting_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsmschannelsetting_PrincipalObjectAttributeAccesses"></a> msdyn_ocsmschannelsetting_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocsmschannelsetting_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocsmschannelsetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsmschannelsetting_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsmschannelsetting_ProcessSession"></a> msdyn_ocsmschannelsetting_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocsmschannelsetting_ProcessSession](processsession.md#BKMK_msdyn_ocsmschannelsetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsmschannelsetting_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsmschannelsetting_SyncErrors"></a> msdyn_ocsmschannelsetting_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocsmschannelsetting_SyncErrors](syncerror.md#BKMK_msdyn_ocsmschannelsetting_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsmschannelsetting_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

