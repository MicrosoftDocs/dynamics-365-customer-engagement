---
title: "msdyn_omnichannelconfiguration Entity Reference | MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_omnichannelconfiguration entity."
ms.date: 03/31/2021
ms.service: "crm-online"
ms.topic: "reference"
author: "platkat"
ms.author: "ktaylor"
manager: "shujoshi"
search.audienceType: 
  - developer
search.app: 
  - PowerApps
  - D365CE
---
# msdyn_omnichannelconfiguration Entity Reference

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

Configuration for Omnichannel

**Added by**: Omnichannel - Base Patch Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_omnichannelconfigurations<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_omnichannelconfigurations(*msdyn_omnichannelconfigurationid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_omnichannelconfigurations(*msdyn_omnichannelconfigurationid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_omnichannelconfigurations<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_omnichannelconfigurations(*msdyn_omnichannelconfigurationid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_omnichannelconfigurations(*msdyn_omnichannelconfigurationid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_omnichannelconfigurations|
|DisplayCollectionName|Omnichannel Configurations|
|DisplayName|Omnichannel Configuration|
|EntitySetName|msdyn_omnichannelconfigurations|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_omnichannelconfigurations|
|LogicalName|msdyn_omnichannelconfiguration|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|msdyn_omnichannelconfigurationid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_omnichannelconfiguration|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_defaultAgentInputLanguage](#BKMK_msdyn_defaultAgentInputLanguage)
- [msdyn_enable_advance_entity_routing](#BKMK_msdyn_enable_advance_entity_routing)
- [msdyn_enable_missed_notifications](#BKMK_msdyn_enable_missed_notifications)
- [msdyn_enable_supervisor_assign](#BKMK_msdyn_enable_supervisor_assign)
- [msdyn_enable_supervisor_monitor](#BKMK_msdyn_enable_supervisor_monitor)
- [msdyn_enable_unified_routing_diagnostic](#BKMK_msdyn_enable_unified_routing_diagnostic)
- [msdyn_enable_visitorjourney](#BKMK_msdyn_enable_visitorjourney)
- [msdyn_EnableRealTimeTranslation](#BKMK_msdyn_EnableRealTimeTranslation)
- [msdyn_enablesoundnotifications](#BKMK_msdyn_enablesoundnotifications)
- [msdyn_inactive_presence_lookup](#BKMK_msdyn_inactive_presence_lookup)
- [msdyn_ispersonalizationofsoundenabled](#BKMK_msdyn_ispersonalizationofsoundenabled)
- [msdyn_isPersonalMessagesEnabled](#BKMK_msdyn_isPersonalMessagesEnabled)
- [msdyn_ispersonasecurityrolemappingenabled](#BKMK_msdyn_ispersonasecurityrolemappingenabled)
- [msdyn_IsSkillBasedRoutingEnabled](#BKMK_msdyn_IsSkillBasedRoutingEnabled)
- [msdyn_IsUpdateSkillsEnabled](#BKMK_msdyn_IsUpdateSkillsEnabled)
- [msdyn_maskforagent](#BKMK_msdyn_maskforagent)
- [msdyn_maskforcustomer](#BKMK_msdyn_maskforcustomer)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_omnichannelconfigurationId](#BKMK_msdyn_omnichannelconfigurationId)
- [msdyn_SoundFormControl](#BKMK_msdyn_SoundFormControl)
- [msdyn_translationwebresourceurl](#BKMK_msdyn_translationwebresourceurl)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Sequence number of the import that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_defaultAgentInputLanguage"></a> msdyn_defaultAgentInputLanguage

|Property|Value|
|--------|-----|
|Description|Default language in which customer's messages are translated for an org|
|DisplayName|Default input language|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultagentinputlanguage|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_defaultAgentInputLanguage Options

|Value|Label|
|-----|-----|
|1025|Arabic - Saudi Arabia|
|1026|Bulgarian - Bulgaria|
|1027|Catalan - Spain|
|1029|Czech - Czech Republic|
|1030|Danish - Denmark|
|1031|German - Germany|
|1032|Greek - Greece|
|1033|English - United States|
|1035|Finnish - Finland|
|1036|French - France|
|1037|Hebrew - Israel|
|1038|Hungarian - Hungary|
|1040|Italian - Italy|
|1041|Japanese - Japan|
|1042|Korean - Korea|
|1043|Dutch - Netherlands|
|1044|Norwegian Bokmal - Norway|
|1045|Polish - Poland|
|1046|Portuguese - Brazil|
|1048|Romanian - Romania|
|1049|Russian - Russia|
|1050|Croatian - Croatia|
|1051|Slovak - Slovakia|
|1053|Swedish - Sweden|
|1054|Thai - Thailand|
|1055|Turkish - Turkey|
|1057|Indonesian - Indonesia|
|1058|Ukrainian - Ukraine|
|1060|Slovenian - Slovenia|
|1061|Estonian - Estonia|
|1062|Latvian - Latvia|
|1063|Lithuanian - Lithuania|
|1066|Vietnamese - Vietnam|
|1069|Basque - Spain|
|1081|Hindi - India|
|1086|Malay - Malaysia|
|1087|Kazakh - Kazakhstan|
|1110|Galician - Spain|
|2052|Chinese - China|
|2070|Portuguese - Portugal|
|2074|Serbian (Latin) - Serbia|
|3076|Chinese - Hong Kong|
|3082|Spanish - Spain|
|3098|Serbian (Cyrillic) - Serbia|



### <a name="BKMK_msdyn_enable_advance_entity_routing"></a> msdyn_enable_advance_entity_routing

|Property|Value|
|--------|-----|
|Description|Setting to change advance entity routing for the org.|
|DisplayName|Enable advance entity routing|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_enable_advance_entity_routing|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_enable_advance_entity_routing Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_enable_missed_notifications"></a> msdyn_enable_missed_notifications

|Property|Value|
|--------|-----|
|Description|Setting to change agent status when a notification has been missed.|
|DisplayName|Enable missed notifications setting|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_enable_missed_notifications|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_enable_missed_notifications Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_enable_supervisor_assign"></a> msdyn_enable_supervisor_assign

|Property|Value|
|--------|-----|
|Description|Enables supervisor assign feature for the org|
|DisplayName|Enable supervisor assign|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_enable_supervisor_assign|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_enable_supervisor_assign Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_enable_supervisor_monitor"></a> msdyn_enable_supervisor_monitor

|Property|Value|
|--------|-----|
|Description|Enables supervisor monitor feature for the org|
|DisplayName|Enable supervisor monitor|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_enable_supervisor_monitor|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_enable_supervisor_monitor Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_msdyn_enable_unified_routing_diagnostic"></a> msdyn_enable_unified_routing_diagnostic

**Added by**: Dynamics 365 UR OmnichanelBase Dependency Solution

|Property|Value|
|--------|-----|
|Description|Setting to change unified routing diagnostic for the org.|
|DisplayName|Enable unified routing diagnostic|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_enable_unified_routing_diagnostic|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_enable_unified_routing_diagnostic Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_enable_visitorjourney"></a> msdyn_enable_visitorjourney

|Property|Value|
|--------|-----|
|Description|Enables self service feature for the org|
|DisplayName|Enable self service|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_enable_visitorjourney|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_enable_visitorjourney Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_EnableRealTimeTranslation"></a> msdyn_EnableRealTimeTranslation

|Property|Value|
|--------|-----|
|Description|Enable real time translation feature for the org|
|DisplayName|Enable Real Time Translation|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_enablerealtimetranslation|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_EnableRealTimeTranslation Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_enablesoundnotifications"></a> msdyn_enablesoundnotifications

|Property|Value|
|--------|-----|
|Description|Enable sound notifications feature|
|DisplayName|Enable sound notifications|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_enablesoundnotifications|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_enablesoundnotifications Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_inactive_presence_lookup"></a> msdyn_inactive_presence_lookup

|Property|Value|
|--------|-----|
|Description|Lookup to display inactive presence settings.|
|DisplayName|Inactive Presence|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_inactive_presence_lookup|
|RequiredLevel|None|
|Targets|msdyn_presence|
|Type|Lookup|


### <a name="BKMK_msdyn_ispersonalizationofsoundenabled"></a> msdyn_ispersonalizationofsoundenabled

|Property|Value|
|--------|-----|
|Description|Allow agents to create personal sound settings|
|DisplayName|Allow agents to create personal sound settings|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ispersonalizationofsoundenabled|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_ispersonalizationofsoundenabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_isPersonalMessagesEnabled"></a> msdyn_isPersonalMessagesEnabled

|Property|Value|
|--------|-----|
|Description|Enable personal messages feature for the org|
|DisplayName|Enable personal messages|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ispersonalmessagesenabled|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_isPersonalMessagesEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_ispersonasecurityrolemappingenabled"></a> msdyn_ispersonasecurityrolemappingenabled

|Property|Value|
|--------|-----|
|Description||
|DisplayName|ispersonasecurityrolemappingenabled|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ispersonasecurityrolemappingenabled|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_ispersonasecurityrolemappingenabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_msdyn_IsSkillBasedRoutingEnabled"></a> msdyn_IsSkillBasedRoutingEnabled

**Added by**: Omnichannel - Skill Based Routing Solution

|Property|Value|
|--------|-----|
|Description|Enable Skill Based Routing for Agents & Supervisors|
|DisplayName|Enable Skill Based Routing|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_isskillbasedroutingenabled|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_IsSkillBasedRoutingEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_IsUpdateSkillsEnabled"></a> msdyn_IsUpdateSkillsEnabled

**Added by**: Omnichannel - SBR Patch Solution

|Property|Value|
|--------|-----|
|Description|This will enable agents to view and update skills for a conversation.|
|DisplayName|Enable update skill control|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_isupdateskillsenabled|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_IsUpdateSkillsEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_maskforagent"></a> msdyn_maskforagent

|Property|Value|
|--------|-----|
|Description|Mask agent data|
|DisplayName|Mask for agent|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_maskforagent|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_maskforagent Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_maskforcustomer"></a> msdyn_maskforcustomer

|Property|Value|
|--------|-----|
|Description|Mask customer data|
|DisplayName|Mask for customer|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_maskforcustomer|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_maskforcustomer Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|The name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_omnichannelconfigurationId"></a> msdyn_omnichannelconfigurationId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Omnichannel Configuration|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_omnichannelconfigurationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_SoundFormControl"></a> msdyn_SoundFormControl

|Property|Value|
|--------|-----|
|Description|Field to host sound form control|
|DisplayName|Sound Form Control|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_soundformcontrol|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_translationwebresourceurl"></a> msdyn_translationwebresourceurl

|Property|Value|
|--------|-----|
|Description|Webresource URL used for real time translation of the messages|
|DisplayName|Web resource URL|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_translationwebresourceurl|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Omnichannel Configuration|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### statecode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Omnichannel Configuration|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|

<a name="read-only-attributes"></a>

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_inactive_presence_lookupName](#BKMK_msdyn_inactive_presence_lookupName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the record.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who modified the record.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_msdyn_inactive_presence_lookupName"></a> msdyn_inactive_presence_lookupName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_inactive_presence_lookupname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the organization|
|DisplayName|Organization Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|None|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|



### See also

[Introduction to Omnichannel for Customer Service](../../../introduction-omnichannel.md)<br />
[Developer guide for Omnichannel for Customer Service](../../omnichannel-developer.md)