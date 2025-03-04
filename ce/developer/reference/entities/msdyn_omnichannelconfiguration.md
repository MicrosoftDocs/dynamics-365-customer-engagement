---
title: "Omnichannel Configuration (msdyn_omnichannelconfiguration) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Omnichannel Configuration (msdyn_omnichannelconfiguration) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Omnichannel Configuration (msdyn_omnichannelconfiguration) table/entity reference (Microsoft Dynamics 365)

Configuration for Omnichannel

## Messages

The following table lists the messages for the Omnichannel Configuration (msdyn_omnichannelconfiguration) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_omnichannelconfigurations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_omnichannelconfigurations(*msdyn_omnichannelconfigurationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_omnichannelconfigurations(*msdyn_omnichannelconfigurationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_omnichannelconfigurations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_omnichannelconfigurations(*msdyn_omnichannelconfigurationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_omnichannelconfigurations(*msdyn_omnichannelconfigurationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_omnichannelconfigurations(*msdyn_omnichannelconfigurationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Omnichannel Configuration (msdyn_omnichannelconfiguration) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Omnichannel Configuration** |
| **DisplayCollectionName** | **Omnichannel Configurations** |
| **SchemaName** | `msdyn_omnichannelconfiguration` |
| **CollectionSchemaName** | `msdyn_omnichannelconfigurations` |
| **EntitySetName** | `msdyn_omnichannelconfigurations`|
| **LogicalName** | `msdyn_omnichannelconfiguration` |
| **LogicalCollectionName** | `msdyn_omnichannelconfigurations` |
| **PrimaryIdAttribute** | `msdyn_omnichannelconfigurationid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_defaultAgentInputLanguage](#BKMK_msdyn_defaultAgentInputLanguage)
- [msdyn_delegated_prioritization_migration](#BKMK_msdyn_delegated_prioritization_migration)
- [msdyn_dnd_presence_lookup](#BKMK_msdyn_dnd_presence_lookup)
- [msdyn_enable_advance_entity_routing](#BKMK_msdyn_enable_advance_entity_routing)
- [msdyn_enable_agent_reject_notifications](#BKMK_msdyn_enable_agent_reject_notifications)
- [msdyn_enable_missed_notifications](#BKMK_msdyn_enable_missed_notifications)
- [msdyn_enable_new_consult_exp](#BKMK_msdyn_enable_new_consult_exp)
- [msdyn_enable_preferred_agent_routing](#BKMK_msdyn_enable_preferred_agent_routing)
- [msdyn_enable_supervisor_assign](#BKMK_msdyn_enable_supervisor_assign)
- [msdyn_enable_supervisor_forceclose](#BKMK_msdyn_enable_supervisor_forceclose)
- [msdyn_enable_supervisor_monitor](#BKMK_msdyn_enable_supervisor_monitor)
- [msdyn_enable_supervisor_transfer](#BKMK_msdyn_enable_supervisor_transfer)
- [msdyn_enable_unified_routing_diagnostic](#BKMK_msdyn_enable_unified_routing_diagnostic)
- [msdyn_enable_visitorjourney](#BKMK_msdyn_enable_visitorjourney)
- [msdyn_enablemarkdown](#BKMK_msdyn_enablemarkdown)
- [msdyn_enablenewconversationform](#BKMK_msdyn_enablenewconversationform)
- [msdyn_EnableRealTimeTranslation](#BKMK_msdyn_EnableRealTimeTranslation)
- [msdyn_enablesoundnotifications](#BKMK_msdyn_enablesoundnotifications)
- [msdyn_inactive_presence_lookup](#BKMK_msdyn_inactive_presence_lookup)
- [msdyn_isdefaultpersonamapped](#BKMK_msdyn_isdefaultpersonamapped)
- [msdyn_ispersonalizationofsoundenabled](#BKMK_msdyn_ispersonalizationofsoundenabled)
- [msdyn_isPersonalMessagesEnabled](#BKMK_msdyn_isPersonalMessagesEnabled)
- [msdyn_ispersonasecurityrolemappingenabled](#BKMK_msdyn_ispersonasecurityrolemappingenabled)
- [msdyn_IsSkillBasedRoutingEnabled](#BKMK_msdyn_IsSkillBasedRoutingEnabled)
- [msdyn_IsUpdateSkillsEnabled](#BKMK_msdyn_IsUpdateSkillsEnabled)
- [msdyn_maskforagent](#BKMK_msdyn_maskforagent)
- [msdyn_maskforcustomer](#BKMK_msdyn_maskforcustomer)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_number_of_declines_allowed](#BKMK_msdyn_number_of_declines_allowed)
- [msdyn_omnichannelconfigurationId](#BKMK_msdyn_omnichannelconfigurationId)
- [msdyn_preferredagentbackupmode](#BKMK_msdyn_preferredagentbackupmode)
- [msdyn_SoundFormControl](#BKMK_msdyn_SoundFormControl)
- [msdyn_translationwebresourceurl](#BKMK_msdyn_translationwebresourceurl)
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

### <a name="BKMK_msdyn_defaultAgentInputLanguage"></a> msdyn_defaultAgentInputLanguage

|Property|Value|
|---|---|
|Description|**Default language in which customer's messages are translated for an org**|
|DisplayName|**Default input language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultagentinputlanguage`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1033|
|GlobalChoiceName|`msdyn_agentinputlanguage`|

#### msdyn_defaultAgentInputLanguage Choices/Options

|Value|Label|
|---|---|
|1025|**Arabic - Saudi Arabia**|
|1026|**Bulgarian - Bulgaria**|
|1027|**Catalan - Spain**|
|1029|**Czech - Czech Republic**|
|1030|**Danish - Denmark**|
|1031|**German - Germany**|
|1032|**Greek - Greece**|
|1033|**English - United States**|
|1035|**Finnish - Finland**|
|1036|**French - France**|
|1037|**Hebrew - Israel**|
|1038|**Hungarian - Hungary**|
|1040|**Italian - Italy**|
|1041|**Japanese - Japan**|
|1042|**Korean - Korea**|
|1043|**Dutch - Netherlands**|
|1044|**Norwegian Bokmal - Norway**|
|1045|**Polish - Poland**|
|1046|**Portuguese - Brazil**|
|1048|**Romanian - Romania**|
|1049|**Russian - Russia**|
|1050|**Croatian - Croatia**|
|1051|**Slovak - Slovakia**|
|1053|**Swedish - Sweden**|
|1054|**Thai - Thailand**|
|1055|**Turkish - Türkiye**|
|1057|**Indonesian - Indonesia**|
|1058|**Ukrainian - Ukraine**|
|1060|**Slovenian - Slovenia**|
|1061|**Estonian - Estonia**|
|1062|**Latvian - Latvia**|
|1063|**Lithuanian - Lithuania**|
|1066|**Vietnamese - Vietnam**|
|1069|**Basque - Spain**|
|1081|**Hindi - India**|
|1086|**Malay - Malaysia**|
|1087|**Kazakh - Kazakhstan**|
|1110|**Galician - Spain**|
|2052|**Chinese - China**|
|2070|**Portuguese - Portugal**|
|2074|**Serbian (Latin) - Serbia**|
|3076|**Chinese - Hong Kong**|
|3082|**Spanish - Spain**|
|3098|**Serbian (Cyrillic) - Serbia**|

### <a name="BKMK_msdyn_delegated_prioritization_migration"></a> msdyn_delegated_prioritization_migration

|Property|Value|
|---|---|
|Description|**Store if migration for Delegated Prioritization is complete/not complete.**|
|DisplayName|**Status of migration for Delegated Prioritization**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_delegated_prioritization_migration`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_omnichannelconfiguration_msdyn_delegated_prioritization_migration`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_dnd_presence_lookup"></a> msdyn_dnd_presence_lookup

|Property|Value|
|---|---|
|Description|**Lookup to display DND presence.**|
|DisplayName|**DND Presnce**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_dnd_presence_lookup`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_presence|

### <a name="BKMK_msdyn_enable_advance_entity_routing"></a> msdyn_enable_advance_entity_routing

|Property|Value|
|---|---|
|Description|**Setting to change advance entity routing for the org.**|
|DisplayName|**Enable advance entity routing**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enable_advance_entity_routing`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_omnichannelconfiguration_msdyn_enable_advance_entity_routing`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enable_agent_reject_notifications"></a> msdyn_enable_agent_reject_notifications

|Property|Value|
|---|---|
|Description|**Setting to change agent status when agent rejects a notification.**|
|DisplayName|**Enable Agent Reject Notification Setting**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enable_agent_reject_notifications`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_omnichannelconfiguration_msdyn_enable_agent_reject_notifications`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enable_missed_notifications"></a> msdyn_enable_missed_notifications

|Property|Value|
|---|---|
|Description|**Setting to change agent status when a notification has been missed.**|
|DisplayName|**Enable missed notifications setting**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enable_missed_notifications`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_omnichannelconfiguration_msdyn_enable_missed_notifications`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enable_new_consult_exp"></a> msdyn_enable_new_consult_exp

|Property|Value|
|---|---|
|Description|**Enable consult pane**|
|DisplayName|**Enable consult pane**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enable_new_consult_exp`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_omnichannelconfiguration_msdyn_enable_new_consult_exp`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enable_preferred_agent_routing"></a> msdyn_enable_preferred_agent_routing

|Property|Value|
|---|---|
|Description|**Setting to enable/disable preferred agent routing for an organization.**|
|DisplayName|**Enable preferred agent routing**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enable_preferred_agent_routing`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_omnichannelconfiguration_msdyn_enable_preferred_agent_routing`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enable_supervisor_assign"></a> msdyn_enable_supervisor_assign

|Property|Value|
|---|---|
|Description|**Enables supervisor assign feature for the org**|
|DisplayName|**Enable supervisor assign**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enable_supervisor_assign`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_omnichannelconfiguration_msdyn_enable_supervisor_assign`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enable_supervisor_forceclose"></a> msdyn_enable_supervisor_forceclose

|Property|Value|
|---|---|
|Description|**Enables supervisor force close feature for the org**|
|DisplayName|**Enable supervisor force close**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enable_supervisor_forceclose`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_omnichannelconfiguration_msdyn_enable_supervisor_forceclose`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enable_supervisor_monitor"></a> msdyn_enable_supervisor_monitor

|Property|Value|
|---|---|
|Description|**Enables supervisor monitor feature for the org**|
|DisplayName|**Enable supervisor monitor**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enable_supervisor_monitor`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_omnichannelconfiguration_msdyn_enable_supervisor_monitor`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enable_supervisor_transfer"></a> msdyn_enable_supervisor_transfer

|Property|Value|
|---|---|
|Description|**Enables supervisor transfer feature for the org**|
|DisplayName|**Enable supervisor transfer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enable_supervisor_transfer`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_omnichannelconfiguration_msdyn_enable_supervisor_transfer`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enable_unified_routing_diagnostic"></a> msdyn_enable_unified_routing_diagnostic

|Property|Value|
|---|---|
|Description|**Setting to change unified routing diagnostic for the org.**|
|DisplayName|**Enable unified routing diagnostic**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enable_unified_routing_diagnostic`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_omnichannelconfiguration_msdyn_enable_unified_routing_diagnostic`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enable_visitorjourney"></a> msdyn_enable_visitorjourney

|Property|Value|
|---|---|
|Description|**Enables self service feature for the org**|
|DisplayName|**Enable self service**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enable_visitorjourney`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_omnichannelconfiguration_msdyn_enable_visitorjourney`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enablemarkdown"></a> msdyn_enablemarkdown

|Property|Value|
|---|---|
|Description|**Enable markdown support for messages**|
|DisplayName|**Enable Markdown**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablemarkdown`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_omnichannelconfiguration_msdyn_enablemarkdown`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enablenewconversationform"></a> msdyn_enablenewconversationform

|Property|Value|
|---|---|
|Description|**Enable new conversation form feature**|
|DisplayName|**Enable new conversation form**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablenewconversationform`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_omnichannelconfiguration_msdyn_enablenewconversationform`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_EnableRealTimeTranslation"></a> msdyn_EnableRealTimeTranslation

|Property|Value|
|---|---|
|Description|**Enable real time translation feature for the org**|
|DisplayName|**Enable Real Time Translation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablerealtimetranslation`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_omnichannelconfiguration_msdyn_enablerealtimetranslation`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enablesoundnotifications"></a> msdyn_enablesoundnotifications

|Property|Value|
|---|---|
|Description|**Enable sound notifications feature**|
|DisplayName|**Enable sound notifications**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablesoundnotifications`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_enablesoundnotifications`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_inactive_presence_lookup"></a> msdyn_inactive_presence_lookup

|Property|Value|
|---|---|
|Description|**Lookup to display inactive presence settings.**|
|DisplayName|**Inactive Presence**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inactive_presence_lookup`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_presence|

### <a name="BKMK_msdyn_isdefaultpersonamapped"></a> msdyn_isdefaultpersonamapped

|Property|Value|
|---|---|
|Description||
|DisplayName|**isdefaultpersonamapped**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isdefaultpersonamapped`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_omnichannelconfiguration_msdyn_isdefaultpersonamapped`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_ispersonalizationofsoundenabled"></a> msdyn_ispersonalizationofsoundenabled

|Property|Value|
|---|---|
|Description|**Allow agents to create personal sound settings**|
|DisplayName|**Allow agents to create personal sound settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ispersonalizationofsoundenabled`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ispersonalizationofsoundenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_isPersonalMessagesEnabled"></a> msdyn_isPersonalMessagesEnabled

|Property|Value|
|---|---|
|Description|**Enable personal messages feature for the org**|
|DisplayName|**Enable personal messages**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ispersonalmessagesenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_omnichannelconfiguration_msdyn_ispersonalmessagesenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_ispersonasecurityrolemappingenabled"></a> msdyn_ispersonasecurityrolemappingenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**ispersonasecurityrolemappingenabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ispersonasecurityrolemappingenabled`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_omnichannelconfiguration_msdyn_ispersonasecurityrolemappingenabled`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_IsSkillBasedRoutingEnabled"></a> msdyn_IsSkillBasedRoutingEnabled

|Property|Value|
|---|---|
|Description|**Enable Skill Based Routing for Agents & Supervisors**|
|DisplayName|**Enable Skill Based Routing**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isskillbasedroutingenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_omnichannelconfiguration_msdyn_isskillbasedroutingenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_IsUpdateSkillsEnabled"></a> msdyn_IsUpdateSkillsEnabled

|Property|Value|
|---|---|
|Description|**This will enable agents to view and update skills for a conversation.**|
|DisplayName|**Enable update skill control**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isupdateskillsenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_omnichannelconfiguration_msdyn_msdyn_isupdateskillsenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_maskforagent"></a> msdyn_maskforagent

|Property|Value|
|---|---|
|Description|**Mask agent data**|
|DisplayName|**Mask for agent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_maskforagent`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_omnichannelconfiguration_msdyn_maskforagent`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_maskforcustomer"></a> msdyn_maskforcustomer

|Property|Value|
|---|---|
|Description|**Mask customer data**|
|DisplayName|**Mask for customer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_maskforcustomer`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_omnichannelconfiguration_msdyn_maskforcustomer`|
|DefaultValue|True|
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

### <a name="BKMK_msdyn_number_of_declines_allowed"></a> msdyn_number_of_declines_allowed

|Property|Value|
|---|---|
|Description|**Number of times an agent can reject or time-out notification.**|
|DisplayName|**Number Of Declines Allowed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_number_of_declines_allowed`|
|RequiredLevel|SystemRequired|
|Type|Integer|
|MaxValue|5|
|MinValue|1|

### <a name="BKMK_msdyn_omnichannelconfigurationId"></a> msdyn_omnichannelconfigurationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Omnichannel Configuration**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_omnichannelconfigurationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_preferredagentbackupmode"></a> msdyn_preferredagentbackupmode

|Property|Value|
|---|---|
|Description|**Setting the Preferred Agent Backup Mode for Preferred Agent Routing.**|
|DisplayName|**Preferred Agent Backup Mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_preferredagentbackupmode`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350001|
|GlobalChoiceName|`msdyn_preferredagentbackupmode`|

#### msdyn_preferredagentbackupmode Choices/Options

|Value|Label|
|---|---|
|192350000|**NoAssignment**|
|192350001|**NextBestAssignment**|

### <a name="BKMK_msdyn_SoundFormControl"></a> msdyn_SoundFormControl

|Property|Value|
|---|---|
|Description|**Field to host sound form control**|
|DisplayName|**Sound Form Control**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_soundformcontrol`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_translationwebresourceurl"></a> msdyn_translationwebresourceurl

|Property|Value|
|---|---|
|Description|**Webresource URL used for real time translation of the messages**|
|DisplayName|**Web resource URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_translationwebresourceurl`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

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
|Description|**Status of the Omnichannel Configuration**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_omnichannelconfiguration_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Omnichannel Configuration**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_omnichannelconfiguration_statuscode`|

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

- [lk_msdyn_omnichannelconfiguration_createdby](#BKMK_lk_msdyn_omnichannelconfiguration_createdby)
- [lk_msdyn_omnichannelconfiguration_createdonbehalfby](#BKMK_lk_msdyn_omnichannelconfiguration_createdonbehalfby)
- [lk_msdyn_omnichannelconfiguration_modifiedby](#BKMK_lk_msdyn_omnichannelconfiguration_modifiedby)
- [lk_msdyn_omnichannelconfiguration_modifiedonbehalfby](#BKMK_lk_msdyn_omnichannelconfiguration_modifiedonbehalfby)
- [msdyn_presence_msdyn_omnichannelconfiguration_msdyn_dnd_presence_lookup](#BKMK_msdyn_presence_msdyn_omnichannelconfiguration_msdyn_dnd_presence_lookup)
- [msdyn_presence_msdyn_omnichannelconfiguration_msdyn_inactive_presence_lookup](#BKMK_msdyn_presence_msdyn_omnichannelconfiguration_msdyn_inactive_presence_lookup)
- [organization_msdyn_omnichannelconfiguration](#BKMK_organization_msdyn_omnichannelconfiguration)

### <a name="BKMK_lk_msdyn_omnichannelconfiguration_createdby"></a> lk_msdyn_omnichannelconfiguration_createdby

One-To-Many Relationship: [systemuser lk_msdyn_omnichannelconfiguration_createdby](systemuser.md#BKMK_lk_msdyn_omnichannelconfiguration_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_omnichannelconfiguration_createdonbehalfby"></a> lk_msdyn_omnichannelconfiguration_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_omnichannelconfiguration_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_omnichannelconfiguration_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_omnichannelconfiguration_modifiedby"></a> lk_msdyn_omnichannelconfiguration_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_omnichannelconfiguration_modifiedby](systemuser.md#BKMK_lk_msdyn_omnichannelconfiguration_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_omnichannelconfiguration_modifiedonbehalfby"></a> lk_msdyn_omnichannelconfiguration_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_omnichannelconfiguration_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_omnichannelconfiguration_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_presence_msdyn_omnichannelconfiguration_msdyn_dnd_presence_lookup"></a> msdyn_presence_msdyn_omnichannelconfiguration_msdyn_dnd_presence_lookup

One-To-Many Relationship: [msdyn_presence msdyn_presence_msdyn_omnichannelconfiguration_msdyn_dnd_presence_lookup](msdyn_presence.md#BKMK_msdyn_presence_msdyn_omnichannelconfiguration_msdyn_dnd_presence_lookup)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_presence`|
|ReferencedAttribute|`msdyn_presenceid`|
|ReferencingAttribute|`msdyn_dnd_presence_lookup`|
|ReferencingEntityNavigationPropertyName|`msdyn_dnd_presence_lookup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_presence_msdyn_omnichannelconfiguration_msdyn_inactive_presence_lookup"></a> msdyn_presence_msdyn_omnichannelconfiguration_msdyn_inactive_presence_lookup

One-To-Many Relationship: [msdyn_presence msdyn_presence_msdyn_omnichannelconfiguration_msdyn_inactive_presence_lookup](msdyn_presence.md#BKMK_msdyn_presence_msdyn_omnichannelconfiguration_msdyn_inactive_presence_lookup)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_presence`|
|ReferencedAttribute|`msdyn_presenceid`|
|ReferencingAttribute|`msdyn_inactive_presence_lookup`|
|ReferencingEntityNavigationPropertyName|`msdyn_inactive_presence_lookup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_omnichannelconfiguration"></a> organization_msdyn_omnichannelconfiguration

One-To-Many Relationship: [organization organization_msdyn_omnichannelconfiguration](organization.md#BKMK_organization_msdyn_omnichannelconfiguration)

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

- [msdyn_omnichannelconfiguration_AsyncOperations](#BKMK_msdyn_omnichannelconfiguration_AsyncOperations)
- [msdyn_omnichannelconfiguration_BulkDeleteFailures](#BKMK_msdyn_omnichannelconfiguration_BulkDeleteFailures)
- [msdyn_omnichannelconfiguration_DuplicateBaseRecord](#BKMK_msdyn_omnichannelconfiguration_DuplicateBaseRecord)
- [msdyn_omnichannelconfiguration_DuplicateMatchingRecord](#BKMK_msdyn_omnichannelconfiguration_DuplicateMatchingRecord)
- [msdyn_omnichannelconfiguration_MailboxTrackingFolders](#BKMK_msdyn_omnichannelconfiguration_MailboxTrackingFolders)
- [msdyn_omnichannelconfiguration_PrincipalObjectAttributeAccesses](#BKMK_msdyn_omnichannelconfiguration_PrincipalObjectAttributeAccesses)
- [msdyn_omnichannelconfiguration_ProcessSession](#BKMK_msdyn_omnichannelconfiguration_ProcessSession)
- [msdyn_omnichannelconfiguration_SyncErrors](#BKMK_msdyn_omnichannelconfiguration_SyncErrors)

### <a name="BKMK_msdyn_omnichannelconfiguration_AsyncOperations"></a> msdyn_omnichannelconfiguration_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_omnichannelconfiguration_AsyncOperations](asyncoperation.md#BKMK_msdyn_omnichannelconfiguration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_omnichannelconfiguration_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_omnichannelconfiguration_BulkDeleteFailures"></a> msdyn_omnichannelconfiguration_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_omnichannelconfiguration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_omnichannelconfiguration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_omnichannelconfiguration_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_omnichannelconfiguration_DuplicateBaseRecord"></a> msdyn_omnichannelconfiguration_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_omnichannelconfiguration_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_omnichannelconfiguration_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_omnichannelconfiguration_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_omnichannelconfiguration_DuplicateMatchingRecord"></a> msdyn_omnichannelconfiguration_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_omnichannelconfiguration_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_omnichannelconfiguration_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_omnichannelconfiguration_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_omnichannelconfiguration_MailboxTrackingFolders"></a> msdyn_omnichannelconfiguration_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_omnichannelconfiguration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_omnichannelconfiguration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_omnichannelconfiguration_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_omnichannelconfiguration_PrincipalObjectAttributeAccesses"></a> msdyn_omnichannelconfiguration_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_omnichannelconfiguration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_omnichannelconfiguration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_omnichannelconfiguration_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_omnichannelconfiguration_ProcessSession"></a> msdyn_omnichannelconfiguration_ProcessSession

Many-To-One Relationship: [processsession msdyn_omnichannelconfiguration_ProcessSession](processsession.md#BKMK_msdyn_omnichannelconfiguration_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_omnichannelconfiguration_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_omnichannelconfiguration_SyncErrors"></a> msdyn_omnichannelconfiguration_SyncErrors

Many-To-One Relationship: [syncerror msdyn_omnichannelconfiguration_SyncErrors](syncerror.md#BKMK_msdyn_omnichannelconfiguration_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_omnichannelconfiguration_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

