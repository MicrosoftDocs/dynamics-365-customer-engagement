---
title: "msdyn_occustommessagingchannel Entity Reference | MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_occustommessagingchannel entity."
author: "v-sailab"
ms.author: "v-sailab"
manager: "shujoshi"
ms.date: 09/14/2020
ms.topic: "reference"
ms.service: "dynamics-365-customerservice"
applies_to: 
  - "Dynamics 365 (online)"
---
# msdyn_occustommessagingchannel Entity Reference

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

Channels asscoiated to Custom messaging account

**Added by**: Omnichannel – SocialChannels Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.1/msdyn_occustommessagingchannels(*msdyn_occustommessagingchannelid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.1/msdyn_occustommessagingchannels<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.1/msdyn_occustommessagingchannels(*msdyn_occustommessagingchannelid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.1/msdyn_occustommessagingchannels(*msdyn_occustommessagingchannelid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.1/msdyn_occustommessagingchannels<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.1/msdyn_occustommessagingchannels(*msdyn_occustommessagingchannelid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.1/msdyn_occustommessagingchannels(*msdyn_occustommessagingchannelid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_occustommessagingchannels|
|DisplayCollectionName|Custom messaging channels|
|DisplayName|Custom messaging channel|
|EntitySetName|msdyn_occustommessagingchannels|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_occustommessagingchannels|
|LogicalName|msdyn_occustommessagingchannel|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_occustommessagingchannelid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_occustommessagingchannel|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_custombotchannelregistration](#BKMK_msdyn_custombotchannelregistration)
- [msdyn_enablefileattachmentsforagents](#BKMK_msdyn_enablefileattachmentsforagents)
- [msdyn_enablefileattachmentsforcustomers](#BKMK_msdyn_enablefileattachmentsforcustomers)
- [msdyn_liveworkstreamid](#BKMK_msdyn_liveworkstreamid)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_occustomchannelid](#BKMK_msdyn_occustomchannelid)
- [msdyn_occustommessagingchannelId](#BKMK_msdyn_occustommessagingchannelId)
- [msdyn_ocwidgetlanguage](#BKMK_msdyn_ocwidgetlanguage)
- [msdyn_PostConversationSurvey](#BKMK_msdyn_PostConversationSurvey)
- [msdyn_PostConversationSurveyEnable](#BKMK_msdyn_PostConversationSurveyEnable)
- [msdyn_PostConversationSurveyMessageText](#BKMK_msdyn_PostConversationSurveyMessageText)
- [msdyn_PostConversationSurveyMode](#BKMK_msdyn_PostConversationSurveyMode)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
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


### <a name="BKMK_msdyn_custombotchannelregistration"></a> msdyn_custombotchannelregistration

|Property|Value|
|--------|-----|
|Description|Unique identifier for Custom channel associated with custom messaging account.|
|DisplayName|Custom messaging account|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_custombotchannelregistration|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_ocbotchannelregistration|
|Type|Lookup|


### <a name="BKMK_msdyn_enablefileattachmentsforagents"></a> msdyn_enablefileattachmentsforagents

|Property|Value|
|--------|-----|
|Description|Enable file attachments for agents|
|DisplayName|Enable file attachments for agents|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_enablefileattachmentsforagents|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_enablefileattachmentsforagents Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_enablefileattachmentsforcustomers"></a> msdyn_enablefileattachmentsforcustomers

|Property|Value|
|--------|-----|
|Description|Enable file attachments for customers|
|DisplayName|Enable file attachments for customers|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_enablefileattachmentsforcustomers|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_enablefileattachmentsforcustomers Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_liveworkstreamid"></a> msdyn_liveworkstreamid

|Property|Value|
|--------|-----|
|Description|Unique identifier for Channel associated with the Work Stream.|
|DisplayName|Work stream|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_liveworkstreamid|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_liveworkstream|
|Type|Lookup|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|The custom messaging channel name.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_occustomchannelid"></a> msdyn_occustomchannelid

|Property|Value|
|--------|-----|
|Description|Channel ID|
|DisplayName|Channel ID|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_occustomchannelid|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_occustomchannelid Options

|Value|Label|
|-----|-----|
|192350000|Direct Line|
|192350001|Kik|
|192350002|Telegram|



### <a name="BKMK_msdyn_occustommessagingchannelId"></a> msdyn_occustommessagingchannelId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Custom Messaging Channel|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_occustommessagingchannelid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_ocwidgetlanguage"></a> msdyn_ocwidgetlanguage

**Added by**: Omnichannel - SocialChannels Patch Solution

|Property|Value|
|--------|-----|
|Description|The language setting for the custom messaging channel|
|DisplayName|Custom messaging channel language|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ocwidgetlanguage|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_oclanguage|
|Type|Lookup|


### <a name="BKMK_msdyn_PostConversationSurvey"></a> msdyn_PostConversationSurvey

**Added by**: Omnichannel - SocialChannels Patch Solution

|Property|Value|
|--------|-----|
|Description|Lookup to forms pro survey field|
|DisplayName|Survey|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_postconversationsurvey|
|RequiredLevel|None|
|Targets|msfp_survey|
|Type|Lookup|


### <a name="BKMK_msdyn_PostConversationSurveyEnable"></a> msdyn_PostConversationSurveyEnable

**Added by**: Omnichannel - SocialChannels Patch Solution

|Property|Value|
|--------|-----|
|Description|To enable or disable post conversation survey|
|DisplayName|Enable|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_postconversationsurveyenable|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_PostConversationSurveyEnable Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_PostConversationSurveyMessageText"></a> msdyn_PostConversationSurveyMessageText

**Added by**: Omnichannel - SocialChannels Patch Solution

|Property|Value|
|--------|-----|
|Description|Prefix text for survey link message that will be sent to the user.|
|DisplayName|Message|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_postconversationsurveymessagetext|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PostConversationSurveyMode"></a> msdyn_PostConversationSurveyMode

**Added by**: Omnichannel - SocialChannels Patch Solution

|Property|Value|
|--------|-----|
|Description|Mode of the survey to be sent|
|DisplayName|Survey Mode|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_postconversationsurveymode|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_PostConversationSurveyMode Options

|Value|Label|
|-----|-----|
|192350000|Insert survey in conversation|
|192350001|Send survey link to conversation|



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


### <a name="BKMK_OwnerId"></a> OwnerId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Custom Messaging Channel|
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
|Description|Reason for the status of the Custom Messaging Channel|
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
- [msdyn_custombotchannelregistrationName](#BKMK_msdyn_custombotchannelregistrationName)
- [msdyn_liveworkstreamidName](#BKMK_msdyn_liveworkstreamidName)
- [msdyn_ocwidgetlanguageName](#BKMK_msdyn_ocwidgetlanguageName)
- [msdyn_PostConversationSurveyName](#BKMK_msdyn_PostConversationSurveyName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
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
|DisplayName|Created on|
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
|DisplayName|Modified on|
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


### <a name="BKMK_msdyn_custombotchannelregistrationName"></a> msdyn_custombotchannelregistrationName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_custombotchannelregistrationname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_liveworkstreamidName"></a> msdyn_liveworkstreamidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_liveworkstreamidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ocwidgetlanguageName"></a> msdyn_ocwidgetlanguageName

**Added by**: Omnichannel - SocialChannels Patch Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_ocwidgetlanguagename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PostConversationSurveyName"></a> msdyn_PostConversationSurveyName

**Added by**: Omnichannel - SocialChannels Patch Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_postconversationsurveyname|
|MaxLength|450|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Yomi name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the business unit that owns the record|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the team that owns the record.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the user that owns the record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration](#BKMK_msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration)
- [msdyn_msdyn_oclanguage_msdyn_occustommessagingchannel_custommessagingchannellanguage](#BKMK_msdyn_msdyn_oclanguage_msdyn_occustommessagingchannel_custommessagingchannellanguage)


### <a name="BKMK_msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration"></a> msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration

**Added by**: Omnichannel – Base Solution

See msdyn_ocbotchannelregistration Entity [msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration](msdyn_ocbotchannelregistration.md#BKMK_msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_occustommessagingchannel_custommessagingchannellanguage"></a> msdyn_msdyn_oclanguage_msdyn_occustommessagingchannel_custommessagingchannellanguage

**Added by**: Omnichannel - Base Patch Solution

See msdyn_oclanguage Entity [msdyn_msdyn_oclanguage_msdyn_occustommessagingchannel_custommessagingchannellanguage](msdyn_oclanguage.md#BKMK_msdyn_msdyn_oclanguage_msdyn_occustommessagingchannel_custommessagingchannellanguage) One-To-Many relationship.

### See also

[Introduction to Omnichannel for Customer Service](../../../introduction-omnichannel.md)<br />
[Developer guide for Omnichannel for Customer Service](../../omnichannel-developer.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]