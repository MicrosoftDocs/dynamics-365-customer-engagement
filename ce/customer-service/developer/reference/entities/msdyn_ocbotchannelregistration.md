---
title: "msdyn_ocbotchannelregistration Entity Reference | MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_ocbotchannelregistration entity."
author: "v-sailab"
ms.author: "v-sailab"
manager: "shujoshi"
ms.date: 09/14/2020
ms.topic: "reference"
ms.service: "dynamics-365-customerservice"
applies_to: 
  - "Dynamics 365 (online)"
---
# msdyn_ocbotchannelregistration Entity Reference

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

Bot channel registration used for channel integration

**Added by**: Omnichannel – Base Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.1/msdyn_ocbotchannelconfigurations<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.1/msdyn_ocbotchannelconfigurations(*msdyn_ocbotchannelconfigurationid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.1/msdyn_ocbotchannelconfigurations(*msdyn_ocbotchannelconfigurationid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.1/msdyn_ocbotchannelconfigurations<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.1/msdyn_ocbotchannelconfigurations(*msdyn_ocbotchannelconfigurationid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.1/msdyn_ocbotchannelconfigurations(*msdyn_ocbotchannelconfigurationid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_ocbotchannelregistrations|
|DisplayCollectionName|Custom messaging accounts|
|DisplayName|Custom messaging account|
|EntitySetName|msdyn_ocbotchannelregistrations|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_ocbotchannelregistrations|
|LogicalName|msdyn_ocbotchannelregistration|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_ocbotchannelregistrationid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_ocbotchannelregistration|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_iscustommessagingbcr](#BKMK_msdyn_iscustommessagingbcr)
- [msdyn_iscustommessagingcreated](#BKMK_msdyn_iscustommessagingcreated)
- [msdyn_lastvalidateddate](#BKMK_msdyn_lastvalidateddate)
- [msdyn_messagingendpoint](#BKMK_msdyn_messagingendpoint)
- [msdyn_msappid](#BKMK_msdyn_msappid)
- [msdyn_msappsecret](#BKMK_msdyn_msappsecret)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ocbotchannelregistrationId](#BKMK_msdyn_ocbotchannelregistrationId)
- [msdyn_ocfbapplicationid](#BKMK_msdyn_ocfbapplicationid)
- [msdyn_oclinechannelconfigid](#BKMK_msdyn_oclinechannelconfigid)
- [msdyn_octeamschannelconfigid](#BKMK_msdyn_octeamschannelconfigid)
- [msdyn_validationstatus](#BKMK_msdyn_validationstatus)
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


### <a name="BKMK_msdyn_iscustommessagingbcr"></a> msdyn_iscustommessagingbcr

**Added by**: Omnichannel – SocialChannels Solution

|Property|Value|
|--------|-----|
|Description|Flag to indicate if BCR entity is related to Custom Messaging|
|DisplayName|Is Custom Messaging BCR|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_iscustommessagingbcr|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_iscustommessagingbcr Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_iscustommessagingcreated"></a> msdyn_iscustommessagingcreated

**Added by**: Omnichannel – SocialChannels Solution

|Property|Value|
|--------|-----|
|Description|Flag to indicate if the record is newly created|
|DisplayName|Is Custom Messaging Created|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_iscustommessagingcreated|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_iscustommessagingcreated Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_lastvalidateddate"></a> msdyn_lastvalidateddate

**Added by**: Omnichannel – SocialChannels Solution

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Microsoft app Id and secret last validated date.|
|DisplayName|Last validated|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_lastvalidateddate|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|


### <a name="BKMK_msdyn_messagingendpoint"></a> msdyn_messagingendpoint

**Added by**: Omnichannel – SocialChannels Solution

|Property|Value|
|--------|-----|
|Description|Messaging Endpoint (URL)|
|DisplayName|Messaging Endpoint (URL)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_messagingendpoint|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_msappid"></a> msdyn_msappid

**Added by**: Omnichannel - Base Patch Solution

|Property|Value|
|--------|-----|
|Description|MS Application ID for the BCR|
|DisplayName|MS Application Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_msappid|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_msappsecret"></a> msdyn_msappsecret

**Added by**: Omnichannel – SocialChannels Solution

|Property|Value|
|--------|-----|
|Description|Bot channel registration client secret|
|DisplayName|Client secret|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_msappsecret|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


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


### <a name="BKMK_msdyn_ocbotchannelregistrationId"></a> msdyn_ocbotchannelregistrationId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Bot Channel Registration|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_ocbotchannelregistrationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_ocfbapplicationid"></a> msdyn_ocfbapplicationid

**Added by**: Omnichannel – Facebook Solution

|Property|Value|
|--------|-----|
|Description|Related Facebook application|
|DisplayName|Facebook application|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ocfbapplicationid|
|RequiredLevel|None|
|Targets|msdyn_ocfbapplication|
|Type|Lookup|


### <a name="BKMK_msdyn_oclinechannelconfigid"></a> msdyn_oclinechannelconfigid

**Added by**: Omnichannel – SocialChannels Solution

|Property|Value|
|--------|-----|
|Description|Related Line Channel|
|DisplayName|Line Channel|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_oclinechannelconfigid|
|RequiredLevel|None|
|Targets|msdyn_oclinechannelconfig|
|Type|Lookup|


### <a name="BKMK_msdyn_octeamschannelconfigid"></a> msdyn_octeamschannelconfigid

**Added by**: Omnichannel - Teams Solution

|Property|Value|
|--------|-----|
|Description|Related Teams Channel|
|DisplayName|Teams Channel|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_octeamschannelconfigid|
|RequiredLevel|None|
|Targets|msdyn_octeamschannelconfig|
|Type|Lookup|


### <a name="BKMK_msdyn_validationstatus"></a> msdyn_validationstatus

**Added by**: Omnichannel – SocialChannels Solution

|Property|Value|
|--------|-----|
|Description|Microsoft app ID and secert Validation status|
|DisplayName|Validation status|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_validationstatus|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


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
|Description|Status of the Bot Channel Registration|
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
|Description|Reason for the status of the Bot Channel Registration|
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
- [msdyn_ocfbapplicationidName](#BKMK_msdyn_ocfbapplicationidName)
- [msdyn_oclinechannelconfigidName](#BKMK_msdyn_oclinechannelconfigidName)
- [msdyn_octeamschannelconfigidName](#BKMK_msdyn_octeamschannelconfigidName)
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


### <a name="BKMK_msdyn_ocfbapplicationidName"></a> msdyn_ocfbapplicationidName

**Added by**: Omnichannel – Facebook Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_ocfbapplicationidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_oclinechannelconfigidName"></a> msdyn_oclinechannelconfigidName

**Added by**: Omnichannel – SocialChannels Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_oclinechannelconfigidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_octeamschannelconfigidName"></a> msdyn_octeamschannelconfigidName

**Added by**: Omnichannel - Teams Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_octeamschannelconfigidname|
|MaxLength|100|
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

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.


### <a name="BKMK_msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration"></a> msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration

**Added by**: Omnichannel – SocialChannels Solution

Same as msdyn_occustommessagingchannel entity [msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration](msdyn_occustommessagingchannel.md#BKMK_msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_occustommessagingchannel|
|ReferencingAttribute|msdyn_custombotchannelregistration|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [msdyn_oclinechannelconfig_msdyn_ocbotchannelregistration_msdyn_oclinechannelconfigid](#BKMK_msdyn_oclinechannelconfig_msdyn_ocbotchannelregistration_msdyn_oclinechannelconfigid)
- [msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid](#BKMK_msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid)


### <a name="BKMK_msdyn_oclinechannelconfig_msdyn_ocbotchannelregistration_msdyn_oclinechannelconfigid"></a> msdyn_oclinechannelconfig_msdyn_ocbotchannelregistration_msdyn_oclinechannelconfigid

**Added by**: Omnichannel – SocialChannels Solution

See msdyn_oclinechannelconfig Entity [msdyn_oclinechannelconfig_msdyn_ocbotchannelregistration_msdyn_oclinechannelconfigid](msdyn_oclinechannelconfig.md#BKMK_msdyn_oclinechannelconfig_msdyn_ocbotchannelregistration_msdyn_oclinechannelconfigid) One-To-Many relationship.

### <a name="BKMK_msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid"></a> msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid

**Added by**: Omnichannel - Teams Solution

See msdyn_octeamschannelconfig Entity [msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid](msdyn_octeamschannelconfig.md#BKMK_msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid) One-To-Many relationship.

### See also

[Introduction to Omnichannel for Customer Service](../../../introduction-omnichannel.md)<br />
[Developer guide for Omnichannel for Customer Service](../../omnichannel-developer.md)
