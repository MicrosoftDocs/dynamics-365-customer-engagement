---
title: "Agent Copilot Setting (msdyn_agentcopilotsetting) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Agent Copilot Setting (msdyn_agentcopilotsetting) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Agent Copilot Setting (msdyn_agentcopilotsetting) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Agent Copilot Setting (msdyn_agentcopilotsetting) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_agentcopilotsettings<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_agentcopilotsettings(*msdyn_agentcopilotsettingid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_agentcopilotsettings(*msdyn_agentcopilotsettingid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_agentcopilotsettings<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_agentcopilotsettings(*msdyn_agentcopilotsettingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_agentcopilotsettings(*msdyn_agentcopilotsettingid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_agentcopilotsettings(*msdyn_agentcopilotsettingid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Agent Copilot Setting (msdyn_agentcopilotsetting) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Agent Copilot Setting** |
| **DisplayCollectionName** | **Agent Copilot Settings** |
| **SchemaName** | `msdyn_agentcopilotsetting` |
| **CollectionSchemaName** | `msdyn_agentcopilotsettings` |
| **EntitySetName** | `msdyn_agentcopilotsettings`|
| **LogicalName** | `msdyn_agentcopilotsetting` |
| **LogicalCollectionName** | `msdyn_agentcopilotsettings` |
| **PrimaryIdAttribute** | `msdyn_agentcopilotsettingid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_agentassistenabled](#BKMK_msdyn_agentassistenabled)
- [msdyn_agentassistkbfilter](#BKMK_msdyn_agentassistkbfilter)
- [msdyn_agentassistkbfilterlive](#BKMK_msdyn_agentassistkbfilterlive)
- [msdyn_agentassisturl](#BKMK_msdyn_agentassisturl)
- [msdyn_agentcopilotsettingId](#BKMK_msdyn_agentcopilotsettingId)
- [msdyn_agentlist](#BKMK_msdyn_agentlist)
- [msdyn_allagentsenabled](#BKMK_msdyn_allagentsenabled)
- [msdyn_allowcrossgeo](#BKMK_msdyn_allowcrossgeo)
- [msdyn_allowtranslation](#BKMK_msdyn_allowtranslation)
- [msdyn_allworkstreamsenabled](#BKMK_msdyn_allworkstreamsenabled)
- [msdyn_answerassistenabled](#BKMK_msdyn_answerassistenabled)
- [msdyn_answerassistkbfilter](#BKMK_msdyn_answerassistkbfilter)
- [msdyn_answerassistkbfilterlive](#BKMK_msdyn_answerassistkbfilterlive)
- [msdyn_answerassisturl](#BKMK_msdyn_answerassisturl)
- [msdyn_autocaseclosureenabled](#BKMK_msdyn_autocaseclosureenabled)
- [msdyn_autocaseclosuresettings](#BKMK_msdyn_autocaseclosuresettings)
- [msdyn_casetocaseresolutionmanualflowenabled](#BKMK_msdyn_casetocaseresolutionmanualflowenabled)
- [msdyn_companyscopeurls](#BKMK_msdyn_companyscopeurls)
- [msdyn_consentacceptanceby](#BKMK_msdyn_consentacceptanceby)
- [msdyn_consentacceptedon](#BKMK_msdyn_consentacceptedon)
- [msdyn_conversationtocaseautonomousflowenabled](#BKMK_msdyn_conversationtocaseautonomousflowenabled)
- [msdyn_conversationtocasemanualflowenabled](#BKMK_msdyn_conversationtocasemanualflowenabled)
- [msdyn_copilotcustomconfiguration](#BKMK_msdyn_copilotcustomconfiguration)
- [msdyn_copilotemailenabledmode](#BKMK_msdyn_copilotemailenabledmode)
- [msdyn_copilotembedsettings](#BKMK_msdyn_copilotembedsettings)
- [msdyn_copilotenabled](#BKMK_msdyn_copilotenabled)
- [msdyn_displayname](#BKMK_msdyn_displayname)
- [msdyn_dvcopilotstatus](#BKMK_msdyn_dvcopilotstatus)
- [msdyn_dynamicfilterconfig](#BKMK_msdyn_dynamicfilterconfig)
- [msdyn_dynamicfilterconfiglive](#BKMK_msdyn_dynamicfilterconfiglive)
- [msdyn_emailassistconfiguration](#BKMK_msdyn_emailassistconfiguration)
- [msdyn_emailassistenabled](#BKMK_msdyn_emailassistenabled)
- [msdyn_emailassistkbfilter](#BKMK_msdyn_emailassistkbfilter)
- [msdyn_emailassistkbfilterlive](#BKMK_msdyn_emailassistkbfilterlive)
- [msdyn_emailassisturl](#BKMK_msdyn_emailassisturl)
- [msdyn_emailsentimentenabled](#BKMK_msdyn_emailsentimentenabled)
- [msdyn_interactionsenabled](#BKMK_msdyn_interactionsenabled)
- [msdyn_isdeterministicknowledgeenabled](#BKMK_msdyn_isdeterministicknowledgeenabled)
- [msdyn_isdvcopilotenabled](#BKMK_msdyn_isdvcopilotenabled)
- [msdyn_isemaildefaultonenabledone](#BKMK_msdyn_isemaildefaultonenabledone)
- [msdyn_isknowledgehubconnectorsourceenabled](#BKMK_msdyn_isknowledgehubconnectorsourceenabled)
- [msdyn_kbenabled](#BKMK_msdyn_kbenabled)
- [msdyn_kbfilterallowagentedit](#BKMK_msdyn_kbfilterallowagentedit)
- [msdyn_kbfilterforpersonalization](#BKMK_msdyn_kbfilterforpersonalization)
- [msdyn_kbfilterforpersonalizationlive](#BKMK_msdyn_kbfilterforpersonalizationlive)
- [msdyn_knowledgearticlecountlive](#BKMK_msdyn_knowledgearticlecountlive)
- [msdyn_knowledgearticlesourceenabled](#BKMK_msdyn_knowledgearticlesourceenabled)
- [msdyn_knowledgeconnectorpublishstatus](#BKMK_msdyn_knowledgeconnectorpublishstatus)
- [msdyn_lasttrainingstatus](#BKMK_msdyn_lasttrainingstatus)
- [msdyn_lasttrainingtime](#BKMK_msdyn_lasttrainingtime)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_pluginconfiguration](#BKMK_msdyn_pluginconfiguration)
- [msdyn_proactivepromptsenabled](#BKMK_msdyn_proactivepromptsenabled)
- [msdyn_searchconfiguration](#BKMK_msdyn_searchconfiguration)
- [msdyn_sharepointsourceenabled](#BKMK_msdyn_sharepointsourceenabled)
- [msdyn_suggestedpromptsenabled](#BKMK_msdyn_suggestedpromptsenabled)
- [msdyn_systemstatus](#BKMK_msdyn_systemstatus)
- [msdyn_transcriptenabled](#BKMK_msdyn_transcriptenabled)
- [msdyn_uniquekey](#BKMK_msdyn_uniquekey)
- [msdyn_useagentlanguage](#BKMK_msdyn_useagentlanguage)
- [msdyn_workstreamlist](#BKMK_msdyn_workstreamlist)
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

### <a name="BKMK_msdyn_agentassistenabled"></a> msdyn_agentassistenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Agent Assist Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentassistenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_agentassistenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_agentassistkbfilter"></a> msdyn_agentassistkbfilter

|Property|Value|
|---|---|
|Description||
|DisplayName|**Agent Assist KB Filter**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentassistkbfilter`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_agentassistkbfilterlive"></a> msdyn_agentassistkbfilterlive

|Property|Value|
|---|---|
|Description||
|DisplayName|**Agent Assist KB Filter Live**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentassistkbfilterlive`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_agentassisturl"></a> msdyn_agentassisturl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Agent Assist Url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentassisturl`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_agentcopilotsettingId"></a> msdyn_agentcopilotsettingId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Agent Copilot Setting**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_agentcopilotsettingid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_agentlist"></a> msdyn_agentlist

|Property|Value|
|---|---|
|Description||
|DisplayName|**(Deprecated) Agent List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentlist`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_allagentsenabled"></a> msdyn_allagentsenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**(Deprecated) All Agents Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_allagentsenabled`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_allagentsenabled`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_allowcrossgeo"></a> msdyn_allowcrossgeo

|Property|Value|
|---|---|
|Description||
|DisplayName|**Enable For Cross Geo**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_allowcrossgeo`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_allowcrossgeo`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_allowtranslation"></a> msdyn_allowtranslation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Allow agents to translate summaries**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_allowtranslation`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_allowtranslation`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_allworkstreamsenabled"></a> msdyn_allworkstreamsenabled

|Property|Value|
|---|---|
|Description|**(Deprecated) Applies only to Omnichannel features**|
|DisplayName|**(Deprecated) All Workstreams Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_allworkstreamsenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_allworkstreamsenabled`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_answerassistenabled"></a> msdyn_answerassistenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Answer Assist Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_answerassistenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_answerassistenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_answerassistkbfilter"></a> msdyn_answerassistkbfilter

|Property|Value|
|---|---|
|Description||
|DisplayName|**Answer Assist KB Filter**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_answerassistkbfilter`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_answerassistkbfilterlive"></a> msdyn_answerassistkbfilterlive

|Property|Value|
|---|---|
|Description||
|DisplayName|**Answer Assist KB Filter Live**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_answerassistkbfilterlive`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_answerassisturl"></a> msdyn_answerassisturl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Answer Assist Url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_answerassisturl`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_autocaseclosureenabled"></a> msdyn_autocaseclosureenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Indicates whether case follow-up and closure is turned on or off**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autocaseclosureenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_autocaseclosureenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_autocaseclosuresettings"></a> msdyn_autocaseclosuresettings

|Property|Value|
|---|---|
|Description||
|DisplayName|**Indicates settings related to auto case closure and follow up**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autocaseclosuresettings`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdyn_casetocaseresolutionmanualflowenabled"></a> msdyn_casetocaseresolutionmanualflowenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Allows Case to Case resolution manual creation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_casetocaseresolutionmanualflowenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_casetocaseresolutionmanualflowenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_companyscopeurls"></a> msdyn_companyscopeurls

|Property|Value|
|---|---|
|Description||
|DisplayName|**Company Scope Urls**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_companyscopeurls`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8000|

### <a name="BKMK_msdyn_consentacceptanceby"></a> msdyn_consentacceptanceby

|Property|Value|
|---|---|
|Description|**The date before when the admin should have consented**|
|DisplayName|**Consent Acceptance By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_consentacceptanceby`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_consentacceptedon"></a> msdyn_consentacceptedon

|Property|Value|
|---|---|
|Description|**The date when the admin has most recently consented**|
|DisplayName|**Consent Accepted On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_consentacceptedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_conversationtocaseautonomousflowenabled"></a> msdyn_conversationtocaseautonomousflowenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Allows Conversation to Case autonomous creation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationtocaseautonomousflowenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_conversationtocaseautonomousflowenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_conversationtocasemanualflowenabled"></a> msdyn_conversationtocasemanualflowenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Allows Conversation to Case manual creation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationtocasemanualflowenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_conversationtocasemanualflowenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_copilotcustomconfiguration"></a> msdyn_copilotcustomconfiguration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Custom Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_copilotcustomconfiguration`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_copilotemailenabledmode"></a> msdyn_copilotemailenabledmode

|Property|Value|
|---|---|
|Description|**Indicates the mode of enablement for email assist.**|
|DisplayName|**msdyn_copilotemailenabledmode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_copilotemailenabledmode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_copilotemailenabledmode`|

#### msdyn_copilotemailenabledmode Choices/Options

|Value|Label|
|---|---|
|133230001|**manual**|
|133230002|**default**|

### <a name="BKMK_msdyn_copilotembedsettings"></a> msdyn_copilotembedsettings

|Property|Value|
|---|---|
|Description||
|DisplayName|**Copilot Embed Settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_copilotembedsettings`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_copilotenabled"></a> msdyn_copilotenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Copilot Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_copilotenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_copilotenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_displayname"></a> msdyn_displayname

|Property|Value|
|---|---|
|Description|**The display name of the custom entity.**|
|DisplayName|**Display Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_displayname`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_dvcopilotstatus"></a> msdyn_dvcopilotstatus

|Property|Value|
|---|---|
|Description|**Stores the status of the workflow that enables Dataverse Copilot**|
|DisplayName|**Dataverse Copilot Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_dvcopilotstatus`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_dynamicfilterconfig"></a> msdyn_dynamicfilterconfig

|Property|Value|
|---|---|
|Description||
|DisplayName|**Dynamic Filter Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_dynamicfilterconfig`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_dynamicfilterconfiglive"></a> msdyn_dynamicfilterconfiglive

|Property|Value|
|---|---|
|Description||
|DisplayName|**Dynamic Filter Configuration Live**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_dynamicfilterconfiglive`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_emailassistconfiguration"></a> msdyn_emailassistconfiguration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Email Assist Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_emailassistconfiguration`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdyn_emailassistenabled"></a> msdyn_emailassistenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Email Assist Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_emailassistenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_emailassistenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_emailassistkbfilter"></a> msdyn_emailassistkbfilter

|Property|Value|
|---|---|
|Description||
|DisplayName|**Email Assist KB Filter**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_emailassistkbfilter`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_emailassistkbfilterlive"></a> msdyn_emailassistkbfilterlive

|Property|Value|
|---|---|
|Description||
|DisplayName|**Email Assist KB Filter Live**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_emailassistkbfilterlive`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_emailassisturl"></a> msdyn_emailassisturl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Email Assist Url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_emailassisturl`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_emailsentimentenabled"></a> msdyn_emailsentimentenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Agents can choose to select view sentiment of the email.**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_emailsentimentenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_emailsentimentenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_interactionsenabled"></a> msdyn_interactionsenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Interactions Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_interactionsenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_interactionsenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_isdeterministicknowledgeenabled"></a> msdyn_isdeterministicknowledgeenabled

|Property|Value|
|---|---|
|Description|**Whether Deterministic Knowledge is enabled**|
|DisplayName|**Is Deterministic Knowledge Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isdeterministicknowledgeenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_isdeterministicknowledgeenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_isdvcopilotenabled"></a> msdyn_isdvcopilotenabled

|Property|Value|
|---|---|
|Description|**Whether Dataverse Copilot is enabled**|
|DisplayName|**Is Dataverse Copilot Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isdvcopilotenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_isdvcopilotenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_isemaildefaultonenabledone"></a> msdyn_isemaildefaultonenabledone

|Property|Value|
|---|---|
|Description||
|DisplayName|**Indicates whether email default enablement was executed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isemaildefaultonenabledone`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_isemaildefaultonenabledone`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_isknowledgehubconnectorsourceenabled"></a> msdyn_isknowledgehubconnectorsourceenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Knowledge Hub Connector Source Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isknowledgehubconnectorsourceenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_isknowledgehubconnectorsourceenabled`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_kbenabled"></a> msdyn_kbenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**(Deprecated) KB Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_kbenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_kbenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_kbfilterallowagentedit"></a> msdyn_kbfilterallowagentedit

|Property|Value|
|---|---|
|Description|**Determines whether or not agents have the ability to edit their KB filters**|
|DisplayName|**Allow Agent Edit KB filters**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_kbfilterallowagentedit`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_kbfilterallowagentedit`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_kbfilterforpersonalization"></a> msdyn_kbfilterforpersonalization

|Property|Value|
|---|---|
|Description||
|DisplayName|**KB Filter For Personalization**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_kbfilterforpersonalization`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_kbfilterforpersonalizationlive"></a> msdyn_kbfilterforpersonalizationlive

|Property|Value|
|---|---|
|Description||
|DisplayName|**KB Filter For Personalization Live**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_kbfilterforpersonalizationlive`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_knowledgearticlecountlive"></a> msdyn_knowledgearticlecountlive

|Property|Value|
|---|---|
|Description||
|DisplayName|**Knowledge Article Count Live**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_knowledgearticlecountlive`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_knowledgearticlesourceenabled"></a> msdyn_knowledgearticlesourceenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Knowledge Article Source Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_knowledgearticlesourceenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_knowledgearticlesourceenabled`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_knowledgeconnectorpublishstatus"></a> msdyn_knowledgeconnectorpublishstatus

|Property|Value|
|---|---|
|Description|**Used to store information about the knowledge connectors publish status**|
|DisplayName|**Knowledge connector publish status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_knowledgeconnectorpublishstatus`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_lasttrainingstatus"></a> msdyn_lasttrainingstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last Training Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lasttrainingstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_lasttrainingstatus`|

#### msdyn_lasttrainingstatus Choices/Options

|Value|Label|
|---|---|
|100230101|**Initiated**|
|100230102|**Completed**|
|100230103|**Failed**|
|100230104|**InvalidKBFilters**|
|100230105|**NoKBArticles**|

### <a name="BKMK_msdyn_lasttrainingtime"></a> msdyn_lasttrainingtime

|Property|Value|
|---|---|
|Description|**The date when the last training completed successfully**|
|DisplayName|**Last Training Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lasttrainingtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

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

### <a name="BKMK_msdyn_pluginconfiguration"></a> msdyn_pluginconfiguration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Plugin Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pluginconfiguration`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_proactivepromptsenabled"></a> msdyn_proactivepromptsenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Proactive Prompts Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_proactivepromptsenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_proactivepromptsenabled`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_searchconfiguration"></a> msdyn_searchconfiguration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Search Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_searchconfiguration`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_sharepointsourceenabled"></a> msdyn_sharepointsourceenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**SharePoint Source Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sharepointsourceenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_sharepointsourceenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_suggestedpromptsenabled"></a> msdyn_suggestedpromptsenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Suggested Prompts Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestedpromptsenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_suggestedpromptsenabled`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_systemstatus"></a> msdyn_systemstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**System Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_systemstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100230001|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_systemstatus`|

#### msdyn_systemstatus Choices/Options

|Value|Label|
|---|---|
|100230001|**New**|
|100230002|**Configuring**|
|100230003|**Ready**|
|100230004|**Disabling**|
|100230005|**FailureConfiguring**|

### <a name="BKMK_msdyn_transcriptenabled"></a> msdyn_transcriptenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Transcript Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_transcriptenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_transcriptenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_uniquekey"></a> msdyn_uniquekey

|Property|Value|
|---|---|
|Description|**(Deprecated) A unique key identifier.**|
|DisplayName|**(Deprecated) Unique Key**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_uniquekey`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_useagentlanguage"></a> msdyn_useagentlanguage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Use Agent Language Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_useagentlanguage`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcopilotsetting_msdyn_useagentlanguage`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_workstreamlist"></a> msdyn_workstreamlist

|Property|Value|
|---|---|
|Description|**(Deprecated) Applies only to Omnichannel features**|
|DisplayName|**(Deprecated) Workstream List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workstreamlist`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

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
|Description|**Status of the Agent Copilot Setting**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_agentcopilotsetting_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Agent Copilot Setting**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_agentcopilotsetting_statuscode`|

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

- [lk_msdyn_agentcopilotsetting_createdby](#BKMK_lk_msdyn_agentcopilotsetting_createdby)
- [lk_msdyn_agentcopilotsetting_createdonbehalfby](#BKMK_lk_msdyn_agentcopilotsetting_createdonbehalfby)
- [lk_msdyn_agentcopilotsetting_modifiedby](#BKMK_lk_msdyn_agentcopilotsetting_modifiedby)
- [lk_msdyn_agentcopilotsetting_modifiedonbehalfby](#BKMK_lk_msdyn_agentcopilotsetting_modifiedonbehalfby)
- [organization_msdyn_agentcopilotsetting](#BKMK_organization_msdyn_agentcopilotsetting)

### <a name="BKMK_lk_msdyn_agentcopilotsetting_createdby"></a> lk_msdyn_agentcopilotsetting_createdby

One-To-Many Relationship: [systemuser lk_msdyn_agentcopilotsetting_createdby](systemuser.md#BKMK_lk_msdyn_agentcopilotsetting_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agentcopilotsetting_createdonbehalfby"></a> lk_msdyn_agentcopilotsetting_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_agentcopilotsetting_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_agentcopilotsetting_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agentcopilotsetting_modifiedby"></a> lk_msdyn_agentcopilotsetting_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_agentcopilotsetting_modifiedby](systemuser.md#BKMK_lk_msdyn_agentcopilotsetting_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agentcopilotsetting_modifiedonbehalfby"></a> lk_msdyn_agentcopilotsetting_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_agentcopilotsetting_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_agentcopilotsetting_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_agentcopilotsetting"></a> organization_msdyn_agentcopilotsetting

One-To-Many Relationship: [organization organization_msdyn_agentcopilotsetting](organization.md#BKMK_organization_msdyn_agentcopilotsetting)

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

- [msdyn_agentcopilotsetting_AsyncOperations](#BKMK_msdyn_agentcopilotsetting_AsyncOperations)
- [msdyn_agentcopilotsetting_BulkDeleteFailures](#BKMK_msdyn_agentcopilotsetting_BulkDeleteFailures)
- [msdyn_agentcopilotsetting_DuplicateBaseRecord](#BKMK_msdyn_agentcopilotsetting_DuplicateBaseRecord)
- [msdyn_agentcopilotsetting_DuplicateMatchingRecord](#BKMK_msdyn_agentcopilotsetting_DuplicateMatchingRecord)
- [msdyn_agentcopilotsetting_MailboxTrackingFolders](#BKMK_msdyn_agentcopilotsetting_MailboxTrackingFolders)
- [msdyn_agentcopilotsetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agentcopilotsetting_PrincipalObjectAttributeAccesses)
- [msdyn_agentcopilotsetting_ProcessSession](#BKMK_msdyn_agentcopilotsetting_ProcessSession)
- [msdyn_agentcopilotsetting_SyncErrors](#BKMK_msdyn_agentcopilotsetting_SyncErrors)

### <a name="BKMK_msdyn_agentcopilotsetting_AsyncOperations"></a> msdyn_agentcopilotsetting_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_agentcopilotsetting_AsyncOperations](asyncoperation.md#BKMK_msdyn_agentcopilotsetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcopilotsetting_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcopilotsetting_BulkDeleteFailures"></a> msdyn_agentcopilotsetting_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_agentcopilotsetting_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_agentcopilotsetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcopilotsetting_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcopilotsetting_DuplicateBaseRecord"></a> msdyn_agentcopilotsetting_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_agentcopilotsetting_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_agentcopilotsetting_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcopilotsetting_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcopilotsetting_DuplicateMatchingRecord"></a> msdyn_agentcopilotsetting_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_agentcopilotsetting_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_agentcopilotsetting_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcopilotsetting_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcopilotsetting_MailboxTrackingFolders"></a> msdyn_agentcopilotsetting_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_agentcopilotsetting_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_agentcopilotsetting_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcopilotsetting_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcopilotsetting_PrincipalObjectAttributeAccesses"></a> msdyn_agentcopilotsetting_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_agentcopilotsetting_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_agentcopilotsetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcopilotsetting_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcopilotsetting_ProcessSession"></a> msdyn_agentcopilotsetting_ProcessSession

Many-To-One Relationship: [processsession msdyn_agentcopilotsetting_ProcessSession](processsession.md#BKMK_msdyn_agentcopilotsetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcopilotsetting_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcopilotsetting_SyncErrors"></a> msdyn_agentcopilotsetting_SyncErrors

Many-To-One Relationship: [syncerror msdyn_agentcopilotsetting_SyncErrors](syncerror.md#BKMK_msdyn_agentcopilotsetting_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcopilotsetting_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

