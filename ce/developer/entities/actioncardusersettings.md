---
title: "ActionCardUserSettings Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ActionCardUserSettings entity."
ms.date: 12/05/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ActionCardUserSettings Entity Reference

Stores user settings for action cards


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/actioncardusersettingsset<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/actioncardusersettingsset(*actioncardusersettingsid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/actioncardusersettingsset(*actioncardusersettingsid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/actioncardusersettingsset<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/actioncardusersettingsset(*actioncardusersettingsid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|ActionCardUserSettingses|
|DisplayCollectionName|Action Card User Settings|
|DisplayName|Action Card User Settings|
|EntitySetName|actioncardusersettingsset|
|IsBPFEntity|False|
|LogicalCollectionName|actioncardusersettingses|
|LogicalName|actioncardusersettings|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|actioncardusersettingsid|
|PrimaryNameAttribute||
|SchemaName|ActionCardUserSettings|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActionCardUserSettingsId](#BKMK_ActionCardUserSettingsId)
- [BoolCardOption](#BKMK_BoolCardOption)
- [CardType](#BKMK_CardType)
- [CardTypeId](#BKMK_CardTypeId)
- [IntCardOption](#BKMK_IntCardOption)
- [IsEnabled](#BKMK_IsEnabled)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [StringCardOption](#BKMK_StringCardOption)


### <a name="BKMK_ActionCardUserSettingsId"></a> ActionCardUserSettingsId

|Property|Value|
|--------|-----|
|Description|Unique identifier user entity|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|actioncardusersettingsid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_BoolCardOption"></a> BoolCardOption

|Property|Value|
|--------|-----|
|Description|Bolean option for a cardtype.|
|DisplayName|Bolean option for a cardtype.|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|boolcardoption|
|RequiredLevel|None|
|Type|Boolean|

#### BoolCardOption Options

|Value|Label|
|-----|-----|
|1|Check|
|0|Uncheck|

**DefaultValue**: False



### <a name="BKMK_CardType"></a> CardType

|Property|Value|
|--------|-----|
|Description|The CardType ENUM value.|
|DisplayName|CardType ENUM|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|cardtype|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_CardTypeId"></a> CardTypeId

|Property|Value|
|--------|-----|
|Description|card type attribute|
|DisplayName|card type|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|cardtypeid|
|RequiredLevel|SystemRequired|
|Targets|cardtype|
|Type|Lookup|


### <a name="BKMK_IntCardOption"></a> IntCardOption

|Property|Value|
|--------|-----|
|Description|Any int option for a cardtype.|
|DisplayName|Any int option for a cardtype.|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|intcardoption|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_IsEnabled"></a> IsEnabled

|Property|Value|
|--------|-----|
|Description|Select whether the card is enabled for user or not.|
|DisplayName|Visibiliy Status of ActionCard|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|isenabled|
|RequiredLevel|None|
|Type|Boolean|

#### IsEnabled Options

|Value|Label|
|-----|-----|
|1|Enable|
|0|Disable|

**DefaultValue**: False



### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user or team who owns the settings.|
|DisplayName|Owner|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description|Type of the owner of the saved view, such as user, team, or business unit.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_StringCardOption"></a> StringCardOption

|Property|Value|
|--------|-----|
|Description|Any string option for a cardtype.|
|DisplayName|Any string option for a cardtype.|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stringcardoption|
|MaxLength|8192|
|RequiredLevel|None|
|Type|Memo|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CardTypeIdName](#BKMK_CardTypeIdName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CardTypeIdName"></a> CardTypeIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|cardtypeidname|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|--------|-----|
|Description|Name of the owner of the saved view.|
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

|Property|Value|
|--------|-----|
|Description||
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

|Property|Value|
|--------|-----|
|Description|Unique identifier of the business unit that owns this.|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|--------|-----|
|Description|Unique identifier of the team who owns this saved view.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who owns this saved view.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
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

- [cardtype_actioncardusersettings](#BKMK_cardtype_actioncardusersettings)
- [actioncardusersettings_owning_user](#BKMK_actioncardusersettings_owning_user)
- [team_actioncardusersettings](#BKMK_team_actioncardusersettings)
- [actioncardusersettings_businessunit](#BKMK_actioncardusersettings_businessunit)


### <a name="BKMK_cardtype_actioncardusersettings"></a> cardtype_actioncardusersettings

See cardtype Entity [cardtype_actioncardusersettings](cardtype.md#BKMK_cardtype_actioncardusersettings) One-To-Many relationship.

### <a name="BKMK_actioncardusersettings_owning_user"></a> actioncardusersettings_owning_user

See systemuser Entity [actioncardusersettings_owning_user](systemuser.md#BKMK_actioncardusersettings_owning_user) One-To-Many relationship.

### <a name="BKMK_team_actioncardusersettings"></a> team_actioncardusersettings

See team Entity [team_actioncardusersettings](team.md#BKMK_team_actioncardusersettings) One-To-Many relationship.

### <a name="BKMK_actioncardusersettings_businessunit"></a> actioncardusersettings_businessunit

See businessunit Entity [actioncardusersettings_businessunit](businessunit.md#BKMK_actioncardusersettings_businessunit) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.actioncardusersettings?text=actioncardusersettings EntityType" />