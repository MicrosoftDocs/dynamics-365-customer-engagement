---
title: "ActionCardUserSettings Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ActionCardUserSettings entity."
ms.date: 10/31/2017
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

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

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

**DisplayName**: Action Card User Settings<br />
**DisplayCollectionName**: Action Card User Settings<br />
**SchemaName**: ActionCardUserSettings<br />
**CollectionSchemaName**: ActionCardUserSettingses<br />
**LogicalName**: actioncardusersettings<br />
**LogicalCollectionName**: actioncardusersettingses<br />
**EntitySetName**: actioncardusersettingsset<br />
**PrimaryIdAttribute**: actioncardusersettingsid<br />
**PrimaryNameAttribute**: <br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
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

**Description**: Unique identifier user entity<br />
**DisplayName**: <br />
**LogicalName**: actioncardusersettingsid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_BoolCardOption"></a> BoolCardOption

**Description**: Bolean option for a cardtype.<br />
**DisplayName**: Bolean option for a cardtype.<br />
**LogicalName**: boolcardoption<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Check
- **FalseOption Value**: 0 **Label**: Uncheck

**DefaultValue**: False


### <a name="BKMK_CardType"></a> CardType

**Description**: The CardType ENUM value.<br />
**DisplayName**: CardType ENUM<br />
**LogicalName**: cardtype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_CardTypeId"></a> CardTypeId

**Description**: card type attribute<br />
**DisplayName**: card type<br />
**LogicalName**: cardtypeid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: cardtype


### <a name="BKMK_IntCardOption"></a> IntCardOption

**Description**: Any int option for a cardtype.<br />
**DisplayName**: Any int option for a cardtype.<br />
**LogicalName**: intcardoption<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_IsEnabled"></a> IsEnabled

**Description**: Select whether the card is enabled for user or not.<br />
**DisplayName**: Visibiliy Status of ActionCard<br />
**LogicalName**: isenabled<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Enable
- **FalseOption Value**: 0 **Label**: Disable

**DefaultValue**: False


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Unique identifier of the user or team who owns the settings.<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Type of the owner of the saved view, such as user, team, or business unit.<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_StringCardOption"></a> StringCardOption

**Description**: Any string option for a cardtype.<br />
**DisplayName**: Any string option for a cardtype.<br />
**LogicalName**: stringcardoption<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 8192

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

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: cardtypeidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: Name of the owner of the saved view.<br />
**DisplayName**: <br />
**LogicalName**: owneridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owneridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier of the business unit that owns this.<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier of the team who owns this saved view.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier of the user who owns this saved view.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

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

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.actioncardusersettings?text=actioncardusersettings EntityType" />