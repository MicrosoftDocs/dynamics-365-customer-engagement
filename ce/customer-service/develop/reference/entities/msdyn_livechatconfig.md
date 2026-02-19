---
title: "Chat Widget (msdyn_livechatconfig) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Chat Widget (msdyn_livechatconfig) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Chat Widget (msdyn_livechatconfig) table/entity reference (Microsoft Dynamics 365 Customer Service)

Stores chat widget customizations

## Messages

The following table lists the messages for the Chat Widget (msdyn_livechatconfig) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_livechatconfigs(*msdyn_livechatconfigid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_livechatconfigs<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_livechatconfigs(*msdyn_livechatconfigid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_livechatconfigs(*msdyn_livechatconfigid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_livechatconfigs<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_livechatconfigs(*msdyn_livechatconfigid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_livechatconfigs(*msdyn_livechatconfigid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_livechatconfigs(*msdyn_livechatconfigid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Chat Widget (msdyn_livechatconfig) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Chat Widget** |
| **DisplayCollectionName** | **Chat Widgets** |
| **SchemaName** | `msdyn_livechatconfig` |
| **CollectionSchemaName** | `msdyn_livechatconfigs` |
| **EntitySetName** | `msdyn_livechatconfigs`|
| **LogicalName** | `msdyn_livechatconfig` |
| **LogicalCollectionName** | `msdyn_livechatconfigs` |
| **PrimaryIdAttribute** | `msdyn_livechatconfigid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_agentDisplayName](#BKMK_msdyn_agentDisplayName)
- [msdyn_authenticatedsigninoptional](#BKMK_msdyn_authenticatedsigninoptional)
- [msdyn_AuthsettingsId](#BKMK_msdyn_AuthsettingsId)
- [msdyn_AutoDetectLanguage](#BKMK_msdyn_AutoDetectLanguage)
- [msdyn_avatarUrl](#BKMK_msdyn_avatarUrl)
- [msdyn_averagewaittime_enabled](#BKMK_msdyn_averagewaittime_enabled)
- [msdyn_azurenotificationhubid](#BKMK_msdyn_azurenotificationhubid)
- [msdyn_botmcssurveyurl](#BKMK_msdyn_botmcssurveyurl)
- [msdyn_callingoptions](#BKMK_msdyn_callingoptions)
- [msdyn_chathistorymonthlimit](#BKMK_msdyn_chathistorymonthlimit)
- [msdyn_cobrowseprovider](#BKMK_msdyn_cobrowseprovider)
- [msdyn_conversationmode](#BKMK_msdyn_conversationmode)
- [msdyn_customanonymoustokenexpirationtime](#BKMK_msdyn_customanonymoustokenexpirationtime)
- [msdyn_Duringnonoperatinghours](#BKMK_msdyn_Duringnonoperatinghours)
- [msdyn_EmailTemplate](#BKMK_msdyn_EmailTemplate)
- [msdyn_enablechatreconnect](#BKMK_msdyn_enablechatreconnect)
- [msdyn_Enablechattranscriptdownload](#BKMK_msdyn_Enablechattranscriptdownload)
- [msdyn_Enablechattranscriptemail](#BKMK_msdyn_Enablechattranscriptemail)
- [msdyn_enablecobrowse](#BKMK_msdyn_enablecobrowse)
- [msdyn_Enablefileattachmentsforagents](#BKMK_msdyn_Enablefileattachmentsforagents)
- [msdyn_Enablefileattachmentsforcustomers](#BKMK_msdyn_Enablefileattachmentsforcustomers)
- [msdyn_enablepersistentchatpreviousconversations](#BKMK_msdyn_enablepersistentchatpreviousconversations)
- [msdyn_enablerealtimelanguagetranslation](#BKMK_msdyn_enablerealtimelanguagetranslation)
- [msdyn_enablescreensharing](#BKMK_msdyn_enablescreensharing)
- [msdyn_genericagentdisplayname](#BKMK_msdyn_genericagentdisplayname)
- [msdyn_infolabel](#BKMK_msdyn_infolabel)
- [msdyn_Language](#BKMK_msdyn_Language)
- [msdyn_livechatconfigId](#BKMK_msdyn_livechatconfigId)
- [msdyn_liveworkstreamid](#BKMK_msdyn_liveworkstreamid)
- [msdyn_Mailbox](#BKMK_msdyn_Mailbox)
- [msdyn_mcssurveytimeoutsec](#BKMK_msdyn_mcssurveytimeoutsec)
- [msdyn_mcssurveyurl](#BKMK_msdyn_mcssurveyurl)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_oc_geolocationprovider](#BKMK_msdyn_oc_geolocationprovider)
- [msdyn_ocWidgetLanguage](#BKMK_msdyn_ocWidgetLanguage)
- [msdyn_offlinewidgetsubtitle](#BKMK_msdyn_offlinewidgetsubtitle)
- [msdyn_offlinewidgetthemecolor](#BKMK_msdyn_offlinewidgetthemecolor)
- [msdyn_offlinewidgettitle](#BKMK_msdyn_offlinewidgettitle)
- [msdyn_operatinghourid](#BKMK_msdyn_operatinghourid)
- [msdyn_portalurl](#BKMK_msdyn_portalurl)
- [msdyn_positioninqueue_enabled](#BKMK_msdyn_positioninqueue_enabled)
- [msdyn_postchatenabled](#BKMK_msdyn_postchatenabled)
- [msdyn_PostConversationSurvey](#BKMK_msdyn_PostConversationSurvey)
- [msdyn_PostConversationSurveyBotSurvey](#BKMK_msdyn_PostConversationSurveyBotSurvey)
- [msdyn_PostConversationSurveyBotSurveyMessageText](#BKMK_msdyn_PostConversationSurveyBotSurveyMessageText)
- [msdyn_PostConversationSurveyBotSurveyMode](#BKMK_msdyn_PostConversationSurveyBotSurveyMode)
- [msdyn_PostConversationSurveyEnable](#BKMK_msdyn_PostConversationSurveyEnable)
- [msdyn_PostConversationSurveyMessageText](#BKMK_msdyn_PostConversationSurveyMessageText)
- [msdyn_PostConversationSurveyMode](#BKMK_msdyn_PostConversationSurveyMode)
- [msdyn_PostConversationSurveySeparateBotSurvey](#BKMK_msdyn_PostConversationSurveySeparateBotSurvey)
- [msdyn_PrechatEnabled](#BKMK_msdyn_PrechatEnabled)
- [msdyn_PreChatQuestionnaireAuthenticated](#BKMK_msdyn_PreChatQuestionnaireAuthenticated)
- [msdyn_PreChatQuestionnaireUnauthenticated](#BKMK_msdyn_PreChatQuestionnaireUnauthenticated)
- [msdyn_proactivechatenabled](#BKMK_msdyn_proactivechatenabled)
- [msdyn_redirectionurl](#BKMK_msdyn_redirectionurl)
- [msdyn_requestvisitorlocation](#BKMK_msdyn_requestvisitorlocation)
- [msdyn_screensharingprovider](#BKMK_msdyn_screensharingprovider)
- [msdyn_showagentname](#BKMK_msdyn_showagentname)
- [msdyn_Showwidgetduringofflinehours](#BKMK_msdyn_Showwidgetduringofflinehours)
- [msdyn_surveyprovider](#BKMK_msdyn_surveyprovider)
- [msdyn_timetoreconnectwithpreviousagent](#BKMK_msdyn_timetoreconnectwithpreviousagent)
- [msdyn_widgetAppId](#BKMK_msdyn_widgetAppId)
- [msdyn_widgetcustomizationconfig](#BKMK_msdyn_widgetcustomizationconfig)
- [msdyn_WidgetLocale](#BKMK_msdyn_WidgetLocale)
- [msdyn_widgetPosition](#BKMK_msdyn_widgetPosition)
- [msdyn_WidgetSnippet](#BKMK_msdyn_WidgetSnippet)
- [msdyn_widgetsoundnotification](#BKMK_msdyn_widgetsoundnotification)
- [msdyn_widgetSubtitle](#BKMK_msdyn_widgetSubtitle)
- [msdyn_widgetThemeColor](#BKMK_msdyn_widgetThemeColor)
- [msdyn_widgetTitle](#BKMK_msdyn_widgetTitle)
- [msdyn_widgetvisualnotification](#BKMK_msdyn_widgetvisualnotification)
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

### <a name="BKMK_msdyn_agentDisplayName"></a> msdyn_agentDisplayName

|Property|Value|
|---|---|
|Description|**Configure agent name to be displayed in the chat widget**|
|DisplayName|**Agent display name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentdisplayname`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_agentdisplayname`|

#### msdyn_agentDisplayName Choices/Options

|Value|Label|
|---|---|
|192350000|**Full name**|
|192350001|**First name**|
|192350002|**Last name**|
|192350003|**Nick name**|

### <a name="BKMK_msdyn_authenticatedsigninoptional"></a> msdyn_authenticatedsigninoptional

|Property|Value|
|---|---|
|Description|**Sign in is optional to start a chat**|
|DisplayName|**Sign in is optional to start a chat**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_authenticatedsigninoptional`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_livechatconfig_msdyn_authenticatedsigninoptional `|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_AuthsettingsId"></a> msdyn_AuthsettingsId

|Property|Value|
|---|---|
|Description|**Unique identifier for Authentication settings associated with Chat widget.**|
|DisplayName|**Authentication settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_authsettingsid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_authenticationsettings|

### <a name="BKMK_msdyn_AutoDetectLanguage"></a> msdyn_AutoDetectLanguage

|Property|Value|
|---|---|
|Description|**Indicates if the chat widget should automatically detect user locale.**|
|DisplayName|**Auto Detect Language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autodetectlanguage`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_livechatconfig_msdyn_autodetectlanguage`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_avatarUrl"></a> msdyn_avatarUrl

|Property|Value|
|---|---|
|Description|**Chat logo**|
|DisplayName|**Logo**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_avatarurl`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_averagewaittime_enabled"></a> msdyn_averagewaittime_enabled

|Property|Value|
|---|---|
|Description|**Indicates whether display of wait time is enabled**|
|DisplayName|**Indicates whether display of wait time is enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_averagewaittime_enabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_livechatconfig_msdyn_averagewaittime_enabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_azurenotificationhubid"></a> msdyn_azurenotificationhubid

|Property|Value|
|---|---|
|Description|**Azure notification hub look up**|
|DisplayName|**Azure notification hub**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_azurenotificationhubid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_azurenotificationhub|

### <a name="BKMK_msdyn_botmcssurveyurl"></a> msdyn_botmcssurveyurl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Bot MCS Survey URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_botmcssurveyurl`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_callingoptions"></a> msdyn_callingoptions

|Property|Value|
|---|---|
|Description|**List of calling options available for the chat widget**|
|DisplayName|**Calling options**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_callingoptions`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_occallingoptions`|

#### msdyn_callingoptions Choices/Options

|Value|Label|
|---|---|
|192350000|**No calling**|
|192350001|**Video and voice calling**|
|192350002|**Voice only**|

### <a name="BKMK_msdyn_chathistorymonthlimit"></a> msdyn_chathistorymonthlimit

|Property|Value|
|---|---|
|Description|**Limit the persistent chat history to a specific number of months.**|
|DisplayName|**Persistent Chat History Month Limit**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_chathistorymonthlimit`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|12|
|MinValue|0|

### <a name="BKMK_msdyn_cobrowseprovider"></a> msdyn_cobrowseprovider

|Property|Value|
|---|---|
|Description|**Select a co-browse provider**|
|DisplayName|**Co-browse provider**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_cobrowseprovider`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_conversationmode"></a> msdyn_conversationmode

|Property|Value|
|---|---|
|Description|**Indicates the conversation mode of the chat widget**|
|DisplayName|**Indicates the conversation mode of the chat widget**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationmode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_livechatconfig_msdyn_conversationmode`|

#### msdyn_conversationmode Choices/Options

|Value|Label|
|---|---|
|192350000|**Live Chat**|
|192350001|**Persistent Chat**|

### <a name="BKMK_msdyn_customanonymoustokenexpirationtime"></a> msdyn_customanonymoustokenexpirationtime

|Property|Value|
|---|---|
|Description|**Custom Anonymous Token Expiration Time Feature in hours**|
|DisplayName|**Custom Anonymous Token Expiration Time in hours**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_customanonymoustokenexpirationtime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|24|
|MinValue|1|

### <a name="BKMK_msdyn_Duringnonoperatinghours"></a> msdyn_Duringnonoperatinghours

|Property|Value|
|---|---|
|Description|**(Deprecated) During non-operating hours**|
|DisplayName|**(Deprecated) During non-operating hours**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_duringnonoperatinghours`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_EmailTemplate"></a> msdyn_EmailTemplate

|Property|Value|
|---|---|
|Description|**Email Template**|
|DisplayName|**Email Template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_emailtemplate`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_enablechatreconnect"></a> msdyn_enablechatreconnect

|Property|Value|
|---|---|
|Description|**This will let customers reconnect to their previous session.**|
|DisplayName|**Turn on reconnect to previous chat**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablechatreconnect`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocflipswitch`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_Enablechattranscriptdownload"></a> msdyn_Enablechattranscriptdownload

|Property|Value|
|---|---|
|Description|**Allow download of transcript**|
|DisplayName|**Allow download of transcript**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablechattranscriptdownload`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_livechatconfig_msdyn_enablechattranscriptdownload`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_Enablechattranscriptemail"></a> msdyn_Enablechattranscriptemail

|Property|Value|
|---|---|
|Description|**Allow email of transcript**|
|DisplayName|**Allow email of transcript**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablechattranscriptemail`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_livechatconfig_msdyn_enablechattranscriptemail`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enablecobrowse"></a> msdyn_enablecobrowse

|Property|Value|
|---|---|
|Description|**Co-browse allows agent and customer to interact on the same web page in real time**|
|DisplayName|**Enable Co-browse**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablecobrowse`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_livechatconfig_msdyn_enablecobrowse`|
|DefaultValue|False|
|True Label|Enabled|
|False Label|Disabled|

### <a name="BKMK_msdyn_Enablefileattachmentsforagents"></a> msdyn_Enablefileattachmentsforagents

|Property|Value|
|---|---|
|Description|**Enable file attachments for agents**|
|DisplayName|**Enable file attachments for agents**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablefileattachmentsforagents`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_livechatconfig_msdyn_enablefileattachmentsforagents`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_Enablefileattachmentsforcustomers"></a> msdyn_Enablefileattachmentsforcustomers

|Property|Value|
|---|---|
|Description|**Enable file attachments for customers**|
|DisplayName|**Enable file attachments for customers**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablefileattachmentsforcustomers`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_livechatconfig_msdyn_enablefileattachmentsforcustomers`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enablepersistentchatpreviousconversations"></a> msdyn_enablepersistentchatpreviousconversations

|Property|Value|
|---|---|
|Description|**This will enable persistent history for previous conversations.**|
|DisplayName|**Turn on persistent history for previous conversations**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablepersistentchatpreviousconversations`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocflipswitch`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enablerealtimelanguagetranslation"></a> msdyn_enablerealtimelanguagetranslation

|Property|Value|
|---|---|
|Description|**Enable Real Time Language Translation**|
|DisplayName|**msdyn\_enablerealtimelanguagetranslation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablerealtimelanguagetranslation`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_livechatconfig_msdyn_enablerealtimelanguagetranslation`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_enablescreensharing"></a> msdyn_enablescreensharing

|Property|Value|
|---|---|
|Description|**Enable Screen sharing**|
|DisplayName|**Enable Screen sharing**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablescreensharing`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_livechatconfig_msdyn_enablescreensharing`|
|DefaultValue|False|
|True Label|Enabled|
|False Label|Disabled|

### <a name="BKMK_msdyn_genericagentdisplayname"></a> msdyn_genericagentdisplayname

|Property|Value|
|---|---|
|Description|**Display Agent Generic Name**|
|DisplayName|**Display Generic Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_genericagentdisplayname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_infolabel"></a> msdyn_infolabel

|Property|Value|
|---|---|
|Description|**Label string indicating user to save the record to add location information**|
|DisplayName|**infolabel**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_infolabel`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Language"></a> msdyn_Language

|Property|Value|
|---|---|
|Description|**Language  in which chat widget is rendered**|
|DisplayName|**Language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_language`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192360014|
|GlobalChoiceName|`msdyn_widgetlanguage`|

#### msdyn_Language Choices/Options

|Value|Label|
|---|---|
|192350000|**Auto-Detect**|
|192360014|**English**|

### <a name="BKMK_msdyn_livechatconfigId"></a> msdyn_livechatconfigId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Chat Widget**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_livechatconfigid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_liveworkstreamid"></a> msdyn_liveworkstreamid

|Property|Value|
|---|---|
|Description|**Work Stream Identifier**|
|DisplayName|**Work stream**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_liveworkstreamid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_liveworkstream|

### <a name="BKMK_msdyn_Mailbox"></a> msdyn_Mailbox

|Property|Value|
|---|---|
|Description|**The mailbox where your email transcripts will be sent from.**|
|DisplayName|**Sender Mailbox**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_mailbox`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_mcssurveytimeoutsec"></a> msdyn_mcssurveytimeoutsec

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**MCS Survey Timeout**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_mcssurveytimeoutsec`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|3600|
|MinValue|0|

### <a name="BKMK_msdyn_mcssurveyurl"></a> msdyn_mcssurveyurl

|Property|Value|
|---|---|
|Description||
|DisplayName|**MCS Survey URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_mcssurveyurl`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

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

### <a name="BKMK_msdyn_oc_geolocationprovider"></a> msdyn_oc_geolocationprovider

|Property|Value|
|---|---|
|Description|**Geo Location Provider API Key**|
|DisplayName|**Provider API key**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_oc_geolocationprovider`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_oc_geolocationprovider|

### <a name="BKMK_msdyn_ocWidgetLanguage"></a> msdyn_ocWidgetLanguage

|Property|Value|
|---|---|
|Description|**The language of the chat widget.**|
|DisplayName|**Language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocwidgetlanguage`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_oclanguage|

### <a name="BKMK_msdyn_offlinewidgetsubtitle"></a> msdyn_offlinewidgetsubtitle

|Property|Value|
|---|---|
|Description|**Description for offline widget subtitle attribute**|
|DisplayName|**Offline Widget Subtitle**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_offlinewidgetsubtitle`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_offlinewidgetthemecolor"></a> msdyn_offlinewidgetthemecolor

|Property|Value|
|---|---|
|Description|**Description for offline widget theme color attribute**|
|DisplayName|**Offline Widget Theme Color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_offlinewidgetthemecolor`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|19236004|
|GlobalChoiceName|`msdyn_widgetthemecolor`|

#### msdyn_offlinewidgetthemecolor Choices/Options

|Value|Label|
|---|---|
|19236001|**Red**|
|19236002|**Blue**|
|19236003|**Green**|
|19236004|**Black**|
|192350001|**Orange**|
|192350002|**Pink**|
|192350003|**Grey**|
|192350004|**Violet**|
|192350005|**Brown**|
|192350006|**Clay**|
|192350007|**Purple**|
|192360017|**Teal**|

### <a name="BKMK_msdyn_offlinewidgettitle"></a> msdyn_offlinewidgettitle

|Property|Value|
|---|---|
|Description|**Description for offline widget title attribute**|
|DisplayName|**Offline Widegt Title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_offlinewidgettitle`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_operatinghourid"></a> msdyn_operatinghourid

|Property|Value|
|---|---|
|Description|**Unique identifier for Operating hour associated with Chat widget.**|
|DisplayName|**Operating hours**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_operatinghourid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_operatinghour|

### <a name="BKMK_msdyn_portalurl"></a> msdyn_portalurl

|Property|Value|
|---|---|
|Description|**Provide a link to the web portal where your chat is hosted.**|
|DisplayName|**Portal URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_portalurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_positioninqueue_enabled"></a> msdyn_positioninqueue_enabled

|Property|Value|
|---|---|
|Description|**Enable Position In Queue feature**|
|DisplayName|**Show position in queue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_positioninqueue_enabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_livechatconfig_msdyn_positioninqueue_enabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_postchatenabled"></a> msdyn_postchatenabled

|Property|Value|
|---|---|
|Description|**Enable Post-Chat (Deprecated)**|
|DisplayName|**Post-chat Survey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postchatenabled`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_livechatconfig_msdyn_postchatenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_PostConversationSurvey"></a> msdyn_PostConversationSurvey

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

### <a name="BKMK_msdyn_PostConversationSurveyBotSurvey"></a> msdyn_PostConversationSurveyBotSurvey

|Property|Value|
|---|---|
|Description|**Enable or disable bot survey**|
|DisplayName|**Bot Survey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postconversationsurveybotsurvey`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_postconversationsurveybotsurvey`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_PostConversationSurveyBotSurveyMessageText"></a> msdyn_PostConversationSurveyBotSurveyMessageText

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

### <a name="BKMK_msdyn_PostConversationSurveyBotSurveyMode"></a> msdyn_PostConversationSurveyBotSurveyMode

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

#### msdyn_PostConversationSurveyBotSurveyMode Choices/Options

|Value|Label|
|---|---|
|192350000|**Insert survey in conversation**|
|192350001|**Send survey link to conversation**|

### <a name="BKMK_msdyn_PostConversationSurveyEnable"></a> msdyn_PostConversationSurveyEnable

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

### <a name="BKMK_msdyn_PostConversationSurveyMessageText"></a> msdyn_PostConversationSurveyMessageText

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

### <a name="BKMK_msdyn_PostConversationSurveyMode"></a> msdyn_PostConversationSurveyMode

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

#### msdyn_PostConversationSurveyMode Choices/Options

|Value|Label|
|---|---|
|192350000|**Insert survey in conversation**|
|192350001|**Send survey link to conversation**|

### <a name="BKMK_msdyn_PostConversationSurveySeparateBotSurvey"></a> msdyn_PostConversationSurveySeparateBotSurvey

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

### <a name="BKMK_msdyn_PrechatEnabled"></a> msdyn_PrechatEnabled

|Property|Value|
|---|---|
|Description|**Enable Pre-chat survey feature**|
|DisplayName|**Pre-Chat Survey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_prechatenabled`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_livechatconfig_msdyn_prechatenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_PreChatQuestionnaireAuthenticated"></a> msdyn_PreChatQuestionnaireAuthenticated

|Property|Value|
|---|---|
|Description|**Prechat Question set for authenticated users**|
|DisplayName|**Question Set for Authenticated Users**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_prechatquestionnaireauthenticated`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_questionsequence|

### <a name="BKMK_msdyn_PreChatQuestionnaireUnauthenticated"></a> msdyn_PreChatQuestionnaireUnauthenticated

|Property|Value|
|---|---|
|Description|**Prechat Question set for unauthenticated users**|
|DisplayName|**Question Set for Unauthenticated Users**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_prechatquestionnaireunauthenticated`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_questionsequence|

### <a name="BKMK_msdyn_proactivechatenabled"></a> msdyn_proactivechatenabled

|Property|Value|
|---|---|
|Description|**Enable Proactive chat for this chat widget**|
|DisplayName|**Proactive-chat**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_proactivechatenabled`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_lcwproactive_msdyn_proactivechatenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_redirectionurl"></a> msdyn_redirectionurl

|Property|Value|
|---|---|
|Description|**We'll redirect customers to this webpage.**|
|DisplayName|**Redirection URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_redirectionurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_requestvisitorlocation"></a> msdyn_requestvisitorlocation

|Property|Value|
|---|---|
|Description|**Enable Visitor Location Feature**|
|DisplayName|**Request visitor location**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_requestvisitorlocation`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_livechatconfig_msdyn_requestvisitorlocation`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_screensharingprovider"></a> msdyn_screensharingprovider

|Property|Value|
|---|---|
|Description|**Select a screen sharing provider**|
|DisplayName|**Screen sharing provider**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_screensharingprovider`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_showagentname"></a> msdyn_showagentname

|Property|Value|
|---|---|
|Description|**Agent Display Name configuration for the chat widget**|
|DisplayName|**Anonymize Agent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_showagentname`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_livechatconfig_msdyn_showagentname`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_Showwidgetduringofflinehours"></a> msdyn_Showwidgetduringofflinehours

|Property|Value|
|---|---|
|Description|**Description for show/hide offline widget attribute**|
|DisplayName|**Show widget during offline hours**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_showwidgetduringofflinehours`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_updatedchatwidget_msdyn_showwidgetduringofflinehours`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_surveyprovider"></a> msdyn_surveyprovider

|Property|Value|
|---|---|
|Description||
|DisplayName|**Survey Provider**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_surveyprovider`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|600990000|
|GlobalChoiceName|`msdyn_surveyprovider`|

#### msdyn_surveyprovider Choices/Options

|Value|Label|
|---|---|
|600990000|**Customer Voice**|
|600990001|**Microsoft Copilot Studio**|

### <a name="BKMK_msdyn_timetoreconnectwithpreviousagent"></a> msdyn_timetoreconnectwithpreviousagent

|Property|Value|
|---|---|
|Description|**The previous agent's capacity will be held for this time period.**|
|DisplayName|**Reconnect to previous agent for**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timetoreconnectwithpreviousagent`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_widgetAppId"></a> msdyn_widgetAppId

|Property|Value|
|---|---|
|Description|**Widget App Identifier used to identify the chat widget**|
|DisplayName|**Widget App Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_widgetappid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_widgetcustomizationconfig"></a> msdyn_widgetcustomizationconfig

|Property|Value|
|---|---|
|Description|**Chat widget customization config**|
|DisplayName|**Chat widget customization config**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_widgetcustomizationconfig`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_WidgetLocale"></a> msdyn_WidgetLocale

|Property|Value|
|---|---|
|Description|**The language of the chat widget.**|
|DisplayName|**Language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_widgetlocale`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_chatwidgetlanguage|

### <a name="BKMK_msdyn_widgetPosition"></a> msdyn_widgetPosition

|Property|Value|
|---|---|
|Description|**Chat position relative to the page**|
|DisplayName|**Position**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_widgetposition`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192236010|
|GlobalChoiceName|`msdyn_widgetposition`|

#### msdyn_widgetPosition Choices/Options

|Value|Label|
|---|---|
|192236010|**Bottom right**|
|192236011|**Bottom left**|

### <a name="BKMK_msdyn_WidgetSnippet"></a> msdyn_WidgetSnippet

|Property|Value|
|---|---|
|Description|**Javascript snippet which can be embedded in a webpage**|
|DisplayName|**Widget Snippet**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_widgetsnippet`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_widgetsoundnotification"></a> msdyn_widgetsoundnotification

|Property|Value|
|---|---|
|Description|**Enable sound notifications for new incoming messages**|
|DisplayName|**Turn on sound notifications**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_widgetsoundnotification`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_widgetsoundnotification`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_widgetSubtitle"></a> msdyn_widgetSubtitle

|Property|Value|
|---|---|
|Description|**Subtitle for the chat widget**|
|DisplayName|**Subtitle**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_widgetsubtitle`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_widgetThemeColor"></a> msdyn_widgetThemeColor

|Property|Value|
|---|---|
|Description|**Theme color for the chat widget**|
|DisplayName|**Theme Color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_widgetthemecolor`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|19236002|
|GlobalChoiceName|`msdyn_widgetthemecolor`|

#### msdyn_widgetThemeColor Choices/Options

|Value|Label|
|---|---|
|19236001|**Red**|
|19236002|**Blue**|
|19236003|**Green**|
|19236004|**Black**|
|192350001|**Orange**|
|192350002|**Pink**|
|192350003|**Grey**|
|192350004|**Violet**|
|192350005|**Brown**|
|192350006|**Clay**|
|192350007|**Purple**|
|192360017|**Teal**|

### <a name="BKMK_msdyn_widgetTitle"></a> msdyn_widgetTitle

|Property|Value|
|---|---|
|Description|**Title for the chat widget**|
|DisplayName|**Title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_widgettitle`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_widgetvisualnotification"></a> msdyn_widgetvisualnotification

|Property|Value|
|---|---|
|Description|**Enable visual indicators for unread messages**|
|DisplayName|**Turn on unread messages indicator**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_widgetvisualnotification`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_livechatconfig_widgetvisualnotification`|
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
|Description|**Status of the Chat widget**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_livechatconfig_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Chat widget**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_livechatconfig_statuscode`|

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

- [business_unit_msdyn_livechatconfig](#BKMK_business_unit_msdyn_livechatconfig)
- [lk_msdyn_livechatconfig_createdby](#BKMK_lk_msdyn_livechatconfig_createdby)
- [lk_msdyn_livechatconfig_createdonbehalfby](#BKMK_lk_msdyn_livechatconfig_createdonbehalfby)
- [lk_msdyn_livechatconfig_modifiedby](#BKMK_lk_msdyn_livechatconfig_modifiedby)
- [lk_msdyn_livechatconfig_modifiedonbehalfby](#BKMK_lk_msdyn_livechatconfig_modifiedonbehalfby)
- [msdyn_msdyn_authsettings_msdyn_livechatconfig](#BKMK_msdyn_msdyn_authsettings_msdyn_livechatconfig)
- [msdyn_msdyn_azurenotificationhub_msdyn_livechatconfig_azurenotificationhubid](#BKMK_msdyn_msdyn_azurenotificationhub_msdyn_livechatconfig_azurenotificationhubid)
- [msdyn_msdyn_chatwidgetlanguage_msdyn_livechatconfig_WidgetLocale](#BKMK_msdyn_msdyn_chatwidgetlanguage_msdyn_livechatconfig_WidgetLocale)
- [msdyn_msdyn_liveworkstream_msdyn_livechatconfig_liveworkstreamid](#BKMK_msdyn_msdyn_liveworkstream_msdyn_livechatconfig_liveworkstreamid)
- [msdyn_msdyn_oc_geolocationprovider_msdyn_livechatconfig](#BKMK_msdyn_msdyn_oc_geolocationprovider_msdyn_livechatconfig)
- [msdyn_msdyn_oclanguage_msdyn_livechatconfig_ocWidgetLanguage](#BKMK_msdyn_msdyn_oclanguage_msdyn_livechatconfig_ocWidgetLanguage)
- [msdyn_msdyn_operatinghour_msdyn_livechatconfig](#BKMK_msdyn_msdyn_operatinghour_msdyn_livechatconfig)
- [msdyn_msfp_survey_msdyn_livechatconfig_PostConversationSurvey](#BKMK_msdyn_msfp_survey_msdyn_livechatconfig_PostConversationSurvey)
- [msdyn_msfp_survey_msdyn_livechatconfig_PostConversationSurveySeparateBotSurvey](#BKMK_msdyn_msfp_survey_msdyn_livechatconfig_PostConversationSurveySeparateBotSurvey)
- [msdyn_questionseq_msdyn_livechatconf_auth](#BKMK_msdyn_questionseq_msdyn_livechatconf_auth)
- [msdyn_questionseq_msdyn_livechatconf_unauth](#BKMK_msdyn_questionseq_msdyn_livechatconf_unauth)
- [owner_msdyn_livechatconfig](#BKMK_owner_msdyn_livechatconfig)
- [team_msdyn_livechatconfig](#BKMK_team_msdyn_livechatconfig)
- [user_msdyn_livechatconfig](#BKMK_user_msdyn_livechatconfig)

### <a name="BKMK_business_unit_msdyn_livechatconfig"></a> business_unit_msdyn_livechatconfig

One-To-Many Relationship: [businessunit business_unit_msdyn_livechatconfig](businessunit.md#BKMK_business_unit_msdyn_livechatconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_livechatconfig_createdby"></a> lk_msdyn_livechatconfig_createdby

One-To-Many Relationship: [systemuser lk_msdyn_livechatconfig_createdby](systemuser.md#BKMK_lk_msdyn_livechatconfig_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_livechatconfig_createdonbehalfby"></a> lk_msdyn_livechatconfig_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_livechatconfig_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_livechatconfig_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_livechatconfig_modifiedby"></a> lk_msdyn_livechatconfig_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_livechatconfig_modifiedby](systemuser.md#BKMK_lk_msdyn_livechatconfig_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_livechatconfig_modifiedonbehalfby"></a> lk_msdyn_livechatconfig_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_livechatconfig_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_livechatconfig_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_authsettings_msdyn_livechatconfig"></a> msdyn_msdyn_authsettings_msdyn_livechatconfig

One-To-Many Relationship: [msdyn_authenticationsettings msdyn_msdyn_authsettings_msdyn_livechatconfig](msdyn_authenticationsettings.md#BKMK_msdyn_msdyn_authsettings_msdyn_livechatconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_authenticationsettings`|
|ReferencedAttribute|`msdyn_authenticationsettingsid`|
|ReferencingAttribute|`msdyn_authsettingsid`|
|ReferencingEntityNavigationPropertyName|`msdyn_AuthsettingsId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_azurenotificationhub_msdyn_livechatconfig_azurenotificationhubid"></a> msdyn_msdyn_azurenotificationhub_msdyn_livechatconfig_azurenotificationhubid

One-To-Many Relationship: [msdyn_azurenotificationhub msdyn_msdyn_azurenotificationhub_msdyn_livechatconfig_azurenotificationhubid](msdyn_azurenotificationhub.md#BKMK_msdyn_msdyn_azurenotificationhub_msdyn_livechatconfig_azurenotificationhubid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_azurenotificationhub`|
|ReferencedAttribute|`msdyn_azurenotificationhubid`|
|ReferencingAttribute|`msdyn_azurenotificationhubid`|
|ReferencingEntityNavigationPropertyName|`msdyn_azurenotificationhubid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_chatwidgetlanguage_msdyn_livechatconfig_WidgetLocale"></a> msdyn_msdyn_chatwidgetlanguage_msdyn_livechatconfig_WidgetLocale

One-To-Many Relationship: [msdyn_chatwidgetlanguage msdyn_msdyn_chatwidgetlanguage_msdyn_livechatconfig_WidgetLocale](msdyn_chatwidgetlanguage.md#BKMK_msdyn_msdyn_chatwidgetlanguage_msdyn_livechatconfig_WidgetLocale)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_chatwidgetlanguage`|
|ReferencedAttribute|`msdyn_chatwidgetlanguageid`|
|ReferencingAttribute|`msdyn_widgetlocale`|
|ReferencingEntityNavigationPropertyName|`msdyn_WidgetLocale`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_liveworkstream_msdyn_livechatconfig_liveworkstreamid"></a> msdyn_msdyn_liveworkstream_msdyn_livechatconfig_liveworkstreamid

One-To-Many Relationship: [msdyn_liveworkstream msdyn_msdyn_liveworkstream_msdyn_livechatconfig_liveworkstreamid](msdyn_liveworkstream.md#BKMK_msdyn_msdyn_liveworkstream_msdyn_livechatconfig_liveworkstreamid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_liveworkstream`|
|ReferencedAttribute|`msdyn_liveworkstreamid`|
|ReferencingAttribute|`msdyn_liveworkstreamid`|
|ReferencingEntityNavigationPropertyName|`msdyn_liveworkstreamid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_oc_geolocationprovider_msdyn_livechatconfig"></a> msdyn_msdyn_oc_geolocationprovider_msdyn_livechatconfig

One-To-Many Relationship: [msdyn_oc_geolocationprovider msdyn_msdyn_oc_geolocationprovider_msdyn_livechatconfig](msdyn_oc_geolocationprovider.md#BKMK_msdyn_msdyn_oc_geolocationprovider_msdyn_livechatconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_oc_geolocationprovider`|
|ReferencedAttribute|`msdyn_oc_geolocationproviderid`|
|ReferencingAttribute|`msdyn_oc_geolocationprovider`|
|ReferencingEntityNavigationPropertyName|`msdyn_oc_geolocationprovider`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_livechatconfig_ocWidgetLanguage"></a> msdyn_msdyn_oclanguage_msdyn_livechatconfig_ocWidgetLanguage

One-To-Many Relationship: [msdyn_oclanguage msdyn_msdyn_oclanguage_msdyn_livechatconfig_ocWidgetLanguage](msdyn_oclanguage.md#BKMK_msdyn_msdyn_oclanguage_msdyn_livechatconfig_ocWidgetLanguage)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_oclanguage`|
|ReferencedAttribute|`msdyn_oclanguageid`|
|ReferencingAttribute|`msdyn_ocwidgetlanguage`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocWidgetLanguage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_operatinghour_msdyn_livechatconfig"></a> msdyn_msdyn_operatinghour_msdyn_livechatconfig

One-To-Many Relationship: [msdyn_operatinghour msdyn_msdyn_operatinghour_msdyn_livechatconfig](msdyn_operatinghour.md#BKMK_msdyn_msdyn_operatinghour_msdyn_livechatconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_operatinghour`|
|ReferencedAttribute|`msdyn_operatinghourid`|
|ReferencingAttribute|`msdyn_operatinghourid`|
|ReferencingEntityNavigationPropertyName|`msdyn_operatinghourid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msfp_survey_msdyn_livechatconfig_PostConversationSurvey"></a> msdyn_msfp_survey_msdyn_livechatconfig_PostConversationSurvey

One-To-Many Relationship: [msfp_survey msdyn_msfp_survey_msdyn_livechatconfig_PostConversationSurvey](msfp_survey.md#BKMK_msdyn_msfp_survey_msdyn_livechatconfig_PostConversationSurvey)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_survey`|
|ReferencedAttribute|`msfp_surveyid`|
|ReferencingAttribute|`msdyn_postconversationsurvey`|
|ReferencingEntityNavigationPropertyName|`msdyn_PostConversationSurvey`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msfp_survey_msdyn_livechatconfig_PostConversationSurveySeparateBotSurvey"></a> msdyn_msfp_survey_msdyn_livechatconfig_PostConversationSurveySeparateBotSurvey

One-To-Many Relationship: [msfp_survey msdyn_msfp_survey_msdyn_livechatconfig_PostConversationSurveySeparateBotSurvey](msfp_survey.md#BKMK_msdyn_msfp_survey_msdyn_livechatconfig_PostConversationSurveySeparateBotSurvey)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_survey`|
|ReferencedAttribute|`msfp_surveyid`|
|ReferencingAttribute|`msdyn_postconversationsurveyseparatebotsurvey`|
|ReferencingEntityNavigationPropertyName|`msdyn_PostConversationSurveySeparateBotSurvey`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_questionseq_msdyn_livechatconf_auth"></a> msdyn_questionseq_msdyn_livechatconf_auth

One-To-Many Relationship: [msdyn_questionsequence msdyn_questionseq_msdyn_livechatconf_auth](msdyn_questionsequence.md#BKMK_msdyn_questionseq_msdyn_livechatconf_auth)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_questionsequence`|
|ReferencedAttribute|`msdyn_questionsequenceid`|
|ReferencingAttribute|`msdyn_prechatquestionnaireauthenticated`|
|ReferencingEntityNavigationPropertyName|`msdyn_prechatquestionnaireauthenticated`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_questionseq_msdyn_livechatconf_unauth"></a> msdyn_questionseq_msdyn_livechatconf_unauth

One-To-Many Relationship: [msdyn_questionsequence msdyn_questionseq_msdyn_livechatconf_unauth](msdyn_questionsequence.md#BKMK_msdyn_questionseq_msdyn_livechatconf_unauth)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_questionsequence`|
|ReferencedAttribute|`msdyn_questionsequenceid`|
|ReferencingAttribute|`msdyn_prechatquestionnaireunauthenticated`|
|ReferencingEntityNavigationPropertyName|`msdyn_prechatquestionnaireunauthenticated`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_livechatconfig"></a> owner_msdyn_livechatconfig

One-To-Many Relationship: [owner owner_msdyn_livechatconfig](owner.md#BKMK_owner_msdyn_livechatconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_livechatconfig"></a> team_msdyn_livechatconfig

One-To-Many Relationship: [team team_msdyn_livechatconfig](team.md#BKMK_team_msdyn_livechatconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_livechatconfig"></a> user_msdyn_livechatconfig

One-To-Many Relationship: [systemuser user_msdyn_livechatconfig](systemuser.md#BKMK_user_msdyn_livechatconfig)

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

- [msdyn_livechatconfig_AsyncOperations](#BKMK_msdyn_livechatconfig_AsyncOperations)
- [msdyn_livechatconfig_BulkDeleteFailures](#BKMK_msdyn_livechatconfig_BulkDeleteFailures)
- [msdyn_livechatconfig_MailboxTrackingFolders](#BKMK_msdyn_livechatconfig_MailboxTrackingFolders)
- [msdyn_livechatconfig_msdyn_ocsystemmessage](#BKMK_msdyn_livechatconfig_msdyn_ocsystemmessage)
- [msdyn_livechatconfig_msdyn_questionsequence](#BKMK_msdyn_livechatconfig_msdyn_questionsequence)
- [msdyn_livechatconfig_PrincipalObjectAttributeAccesses](#BKMK_msdyn_livechatconfig_PrincipalObjectAttributeAccesses)
- [msdyn_livechatconfig_ProcessSession](#BKMK_msdyn_livechatconfig_ProcessSession)
- [msdyn_livechatconfig_SyncErrors](#BKMK_msdyn_livechatconfig_SyncErrors)
- [msdyn_msdyn_livechatconfig_msdyn_chatquestionnaireresponse](#BKMK_msdyn_msdyn_livechatconfig_msdyn_chatquestionnaireresponse)
- [msdyn_msdyn_livechatconfig_msdyn_livechatwidgetlocation_livechatconfigid](#BKMK_msdyn_msdyn_livechatconfig_msdyn_livechatwidgetlocation_livechatconfigid)

### <a name="BKMK_msdyn_livechatconfig_AsyncOperations"></a> msdyn_livechatconfig_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_livechatconfig_AsyncOperations](asyncoperation.md#BKMK_msdyn_livechatconfig_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_livechatconfig_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_livechatconfig_BulkDeleteFailures"></a> msdyn_livechatconfig_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_livechatconfig_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_livechatconfig_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_livechatconfig_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_livechatconfig_MailboxTrackingFolders"></a> msdyn_livechatconfig_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_livechatconfig_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_livechatconfig_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_livechatconfig_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_livechatconfig_msdyn_ocsystemmessage"></a> msdyn_livechatconfig_msdyn_ocsystemmessage

Many-To-One Relationship: [msdyn_ocsystemmessage msdyn_livechatconfig_msdyn_ocsystemmessage](msdyn_ocsystemmessage.md#BKMK_msdyn_livechatconfig_msdyn_ocsystemmessage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsystemmessage`|
|ReferencingAttribute|`msdyn_widgetid`|
|ReferencedEntityNavigationPropertyName|`msdyn_livechatconfig_msdyn_ocsystemmessage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_livechatconfig_msdyn_questionsequence"></a> msdyn_livechatconfig_msdyn_questionsequence

Many-To-One Relationship: [msdyn_questionsequence msdyn_livechatconfig_msdyn_questionsequence](msdyn_questionsequence.md#BKMK_msdyn_livechatconfig_msdyn_questionsequence)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_questionsequence`|
|ReferencingAttribute|`msdyn_chatengagementtochatsequenceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_livechatconfig_msdyn_questionsequence`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_livechatconfig_PrincipalObjectAttributeAccesses"></a> msdyn_livechatconfig_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_livechatconfig_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_livechatconfig_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_livechatconfig_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_livechatconfig_ProcessSession"></a> msdyn_livechatconfig_ProcessSession

Many-To-One Relationship: [processsession msdyn_livechatconfig_ProcessSession](processsession.md#BKMK_msdyn_livechatconfig_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_livechatconfig_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_livechatconfig_SyncErrors"></a> msdyn_livechatconfig_SyncErrors

Many-To-One Relationship: [syncerror msdyn_livechatconfig_SyncErrors](syncerror.md#BKMK_msdyn_livechatconfig_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_livechatconfig_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_livechatconfig_msdyn_chatquestionnaireresponse"></a> msdyn_msdyn_livechatconfig_msdyn_chatquestionnaireresponse

Many-To-One Relationship: [msdyn_chatquestionnaireresponse msdyn_msdyn_livechatconfig_msdyn_chatquestionnaireresponse](msdyn_chatquestionnaireresponse.md#BKMK_msdyn_msdyn_livechatconfig_msdyn_chatquestionnaireresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_chatquestionnaireresponse`|
|ReferencingAttribute|`msdyn_livechatconfigid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_livechatconfig_msdyn_chatquestionnaireresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_livechatconfig_msdyn_livechatwidgetlocation_livechatconfigid"></a> msdyn_msdyn_livechatconfig_msdyn_livechatwidgetlocation_livechatconfigid

Many-To-One Relationship: [msdyn_livechatwidgetlocation msdyn_msdyn_livechatconfig_msdyn_livechatwidgetlocation_livechatconfigid](msdyn_livechatwidgetlocation.md#BKMK_msdyn_msdyn_livechatconfig_msdyn_livechatwidgetlocation_livechatconfigid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_livechatwidgetlocation`|
|ReferencingAttribute|`msdyn_livechatconfigid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_livechatconfig_msdyn_livechatwidgetlocation_livechatconfigid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

