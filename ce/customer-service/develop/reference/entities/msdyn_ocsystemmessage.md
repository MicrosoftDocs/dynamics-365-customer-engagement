---
title: "Automated Message (msdyn_ocsystemmessage) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Automated Message (msdyn_ocsystemmessage) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Automated Message (msdyn_ocsystemmessage) table/entity reference (Microsoft Dynamics 365 Customer Service)

Stores the system messages sent to the message receiver for various events.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Automated Message (msdyn_ocsystemmessage) table extends the [Microsoft Dynamics 365 Automated Message (msdyn_ocsystemmessage) table](/dynamics365/developer/reference/entities/msdyn_ocsystemmessage).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_msdyn_widgetid"></a> msdyn_widgetid

|Property|Value|
|---|---|
|Description|**Unique identifier for Chat Widget associated with System Message.**|
|DisplayName|**Widget**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_widgetid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_livechatconfig|


## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [msdyn_streamsource](#BKMK_msdyn_streamsource)
- [msdyn_systemmessageeventtype](#BKMK_msdyn_systemmessageeventtype)

### <a name="BKMK_msdyn_streamsource"></a> msdyn_streamsource

Changes from [msdyn_streamsource (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_ocsystemmessage#BKMK_msdyn_streamsource)

#### msdyn_streamsource Choices/Options

|Value|Label|
|---|---|
|19241000|**Microsoft Teams**|
|192300000|**WhatsApp**|
|192310000|**LINE**|
|192320000|**WeChat**|
|192330000|**Facebook**|
|192340000|**SMS**|
|192350001|**Twitter**|
|192350002|**Custom**|
|192360000|**Live chat**|
|192370000|**Voice**|
|192380000|**Video**|
|192390000|**Co-browse**|
|192400000|**Screen sharing**|
|192440000|**Voice call**|
|192450000|**Apple Messages for Business**|
|192450001|**Google's Business Messages**|
|192460000|**Microsoft 365 Copilot**|
|192470000|**ChatGPT**|

### <a name="BKMK_msdyn_systemmessageeventtype"></a> msdyn_systemmessageeventtype

Changes from [msdyn_systemmessageeventtype (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_ocsystemmessage#BKMK_msdyn_systemmessageeventtype)

#### msdyn_systemmessageeventtype Choices/Options

|Value|Label|
|---|---|
|192350075|**You are already in queue to receive a callback when a customer service representative is available. You can choose to continue waiting on this call if needed or disconnect and receive the callback**|
|192360000|**Offer Voicemail**|
|192360001|**Voicemail Complete**|
|192360002|**Voicemail Fail**|
|192360003|**Direct agent not available**|
|192360005|**Direct Inward Call Forwarding**|
|192360006|**Overflow External Transfer Initiated**|
|192360007|**Prompt and hang-up**|
|192360008|**Prompt and transfer to external number**|
|192360009|**Prompt and escalate**|
|192360010|**Message for Bot Language Changed Message**|
|192360011|**Message for Unsupported Bot Language**|
|192360012|**Entered a confidential section of the conversation**|
|192360013|**Exited the confidential section of the conversation**|
|192360014|**Consent Based Recording – Customer said Yes to Recording prompt**|
|192360015|**Consent Based Recording – Customer said No to Recording prompt**|
|192360016|**Consent Based Recording – Did not receive Event after {n} seconds**|
|192360017|**Consent Based Recording – Bot not configured for consent recording**|
|192360018|**Consult with queue or user group is initiated**|
|192360019|**Consult request failed due to system failure.**|
|192360020|**Consult to queue or user group failed due to out of operating hours**|
|192360021|**Consult with queue or user group is cancelled**|
|192360022|**No service representatives found for consult with queue or user group**|
|192360025|**Open conversation added to queue for voice**|
|192370004|**Agent on hold**|
|192370005|**Agent is no longer on hold**|
|192370008|**Duplicate Callback**|
|192370015|**Duplicate callback end-call**|
|192380001|**Callback failed - concurrent calls limit exceeded**|
|192380002|**Callback failed - number is not entitled to call this destination**|
|192380003|**Callback failed - invalid phone number**|
|192380004|**Callback failed - customer declined the call**|
|192380005|**Callback failed - customer number is busy**|
|192380006|**Outbound call failed - concurrent calls limit exceeded**|
|192380007|**Outbound call failed - Outbound number is not entitled to call this destination**|
|192380008|**Outbound call failed - invalid phone number**|
|192380009|**Outbound call failed - customer declined the call**|
|192380010|**Outbound call failed - customer number is busy**|
|192380011|**Outbound call failed - Destination number is temporarily unavailable**|
|192380012|**Call failed - could not be completed**|
|192380013|**Callback scheduling failed**|
|192380014|**Offer callback with alternate number**|
|192380015|**Offer Callback Alternate number bot transfer message**|
|192380016|**Inbound CSR Connected to Customer on Non-Bot Workstream with Recording and Transcription Enabled**|
|192380017|**Inbound CSR Connected to Customer on Non-Bot Workstream with Transcription Enabled**|
|192380018|**Inbound Recording and Transcription Paused by CSR**|
|192380019|**Inbound Transcription Paused by CSR**|
|192380020|**Inbound Recording and Transcription Resumed by CSR**|
|192380021|**Inbound Transcription Resumed by CSR**|
|192380022|**Inbound CSR Internal Consult Connected to Consultee with Recording and Transcription Enabled - Customer on Hold**|
|192380023|**Inbound CSR Internal Consult Connected to Consultee with Transcription Enabled - Customer on Hold**|
|192380024|**Inbound CSR External Consult Connected to Consultee with Recording and Transcription Enabled - Customer on Hold**|
|192380025|**Inbound CSR External Consult Connected to Consultee with Transcription Enabled - Customer on Hold**|
|192380026|**Inbound CSR Transfer to Queue with Recording and Transcription Enabled - Customer on Hold**|
|192380027|**Inbound CSR Transfer to Queue with Transcription Enabled - Customer on Hold**|
|192380028|**Inbound CSR Bridged Transfer to External Number with Recording and Transcription Enabled - Customer on Hold**|
|192380029|**Inbound CSR Bridged Transfer to External Number with Transcription Enabled - Customer on Hold**|
|192380030|**Outbound CSR Connected to Customer with Recording and Transcription Enabled**|
|192380031|**Outbound CSR Connected to Customer with Transcription Enabled**|
|192380032|**Outbound Recording and Transcription Paused by CSR**|
|192380033|**Outbound Transcription Paused by CSR**|
|192380034|**Outbound Recording and Transcription Resumed by CSR**|
|192380035|**Outbound Transcription Resumed by CSR**|
|192380036|**Outbound CSR Internal Consult Connected to Consultee with Recording and Transcription Enabled - Customer on Hold**|
|192380037|**Outbound CSR Internal Consult Connected to Consultee with Transcription Enabled - Customer on Hold**|
|192380038|**Outbound CSR External Consult Connected to Consultee with Recording and Transcription Enabled - Customer on Hold**|
|192380039|**Outbound CSR External Consult Connected to Consultee with Transcription Enabled - Customer on Hold**|
|192380040|**Outbound CSR Transfer to Queue Connected with Recording and Transcription Enabled - Customer on Hold**|
|192380041|**Outbound CSR Transfer to Queue Connected with Transcription Enabled - Customer on Hold**|
|192380042|**Outbound CSR Bridged Transfer to External Number with Recording and Transcription Enabled - Customer on Hold**|
|192380043|**Outbound CSR Bridged Transfer to External Number with Transcription Enabled - Customer on Hold**|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_livechatconfig_msdyn_ocsystemmessage"></a> msdyn_livechatconfig_msdyn_ocsystemmessage

One-To-Many Relationship: [msdyn_livechatconfig msdyn_livechatconfig_msdyn_ocsystemmessage](msdyn_livechatconfig.md#BKMK_msdyn_livechatconfig_msdyn_ocsystemmessage)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_livechatconfig`|
|ReferencedAttribute|`msdyn_livechatconfigid`|
|ReferencingAttribute|`msdyn_widgetid`|
|ReferencingEntityNavigationPropertyName|`msdyn_widgetid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_msdyn_ocsystemmessage_msdyn_ocoutboundconfiguration_messagetemplate"></a> msdyn_msdyn_ocsystemmessage_msdyn_ocoutboundconfiguration_messagetemplate

Many-To-One Relationship: [msdyn_ocoutboundconfiguration msdyn_msdyn_ocsystemmessage_msdyn_ocoutboundconfiguration_messagetemplate](msdyn_ocoutboundconfiguration.md#BKMK_msdyn_msdyn_ocsystemmessage_msdyn_ocoutboundconfiguration_messagetemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundconfiguration`|
|ReferencingAttribute|`msdyn_messagetemplate`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocsystemmessage_msdyn_ocoutboundconfiguration_messagetemplate`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

