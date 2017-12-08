---
title: "CardType Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the CardType entity."
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
# CardType Entity Reference

To provide master data for the card types list. For internal use only


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/cardtype<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/cardtype(*cardtypeid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/cardtype(*cardtypeid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/cardtype<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/cardtype(*cardtypeid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|CardTypes|
|DisplayCollectionName|Action Card Type|
|DisplayName|Action Card Type|
|EntitySetName|cardtype|
|IsBPFEntity|False|
|LogicalCollectionName|cardtypes|
|LogicalName|cardtype|
|OwnershipType|None|
|PrimaryIdAttribute|cardtypeid|
|PrimaryNameAttribute|cardname|
|SchemaName|CardType|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Actions](#BKMK_Actions)
- [BoolCardOption](#BKMK_BoolCardOption)
- [CardName](#BKMK_CardName)
- [CardType](#BKMK_CardType)
- [CardTypeIcon](#BKMK_CardTypeIcon)
- [CardTypeId](#BKMK_CardTypeId)
- [ClientAvailability](#BKMK_ClientAvailability)
- [GroupType](#BKMK_GroupType)
- [HasSnoozeDismiss](#BKMK_HasSnoozeDismiss)
- [IntCardOption](#BKMK_IntCardOption)
- [IsBaseCard](#BKMK_IsBaseCard)
- [IsEnabled](#BKMK_IsEnabled)
- [IsLiveOnly](#BKMK_IsLiveOnly)
- [IsPreviewCard](#BKMK_IsPreviewCard)
- [LastSyncTime](#BKMK_LastSyncTime)
- [ScheduleTime](#BKMK_ScheduleTime)
- [SoftTitle](#BKMK_SoftTitle)
- [StringCardOption](#BKMK_StringCardOption)
- [SummaryText](#BKMK_SummaryText)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)


### <a name="BKMK_Actions"></a> Actions

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|CommandBar Actions JSON definition|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actions|
|MaxLength|8192|
|RequiredLevel|None|
|Type|Memo|


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



### <a name="BKMK_CardName"></a> CardName

|Property|Value|
|--------|-----|
|Description|The name of the custom entity.|
|DisplayName|CardName|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|cardname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CardType"></a> CardType

|Property|Value|
|--------|-----|
|Description|The CardType ENUM value.|
|DisplayName|CardType ENUM|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|cardtype|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_CardTypeIcon"></a> CardTypeIcon

|Property|Value|
|--------|-----|
|Description|The CardTypeIcon of the card.|
|DisplayName|CardTypeIcon|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|cardtypeicon|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CardTypeId"></a> CardTypeId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|CardType|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|cardtypeid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ClientAvailability"></a> ClientAvailability

|Property|Value|
|--------|-----|
|Description|Determines on which client is this card available on.|
|DisplayName|Card Client Availability|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|clientavailability|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### ClientAvailability Options

|Value|Label|
|-----|-----|
|1|WebClientOnly|
|2|MocaOnly|
|3|MocaAndWeb|



### <a name="BKMK_GroupType"></a> GroupType

|Property|Value|
|--------|-----|
|Description|Specifies the card group type|
|DisplayName|GroupType|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|grouptype|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_HasSnoozeDismiss"></a> HasSnoozeDismiss

|Property|Value|
|--------|-----|
|Description|Specifies if the card type has snooze dismiss|
|DisplayName|HasSnoozeDismiss|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|hassnoozedismiss|
|RequiredLevel|None|
|Type|Boolean|

#### HasSnoozeDismiss Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



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


### <a name="BKMK_IsBaseCard"></a> IsBaseCard

|Property|Value|
|--------|-----|
|Description|IsBaseCard|
|DisplayName|IsBaseCard|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|isbasecard|
|RequiredLevel|None|
|Type|Boolean|

#### IsBaseCard Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_IsEnabled"></a> IsEnabled

|Property|Value|
|--------|-----|
|Description|IsEnabled|
|DisplayName|IsEnabled|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|isenabled|
|RequiredLevel|None|
|Type|Boolean|

#### IsEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_IsLiveOnly"></a> IsLiveOnly

|Property|Value|
|--------|-----|
|Description|IsLiveOnly|
|DisplayName|IsLiveOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|isliveonly|
|RequiredLevel|None|
|Type|Boolean|

#### IsLiveOnly Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_IsPreviewCard"></a> IsPreviewCard

|Property|Value|
|--------|-----|
|Description|IsPreviewCard|
|DisplayName|IsPreviewCard|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ispreviewcard|
|RequiredLevel|None|
|Type|Boolean|

#### IsPreviewCard Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_LastSyncTime"></a> LastSyncTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|This column is updated by the Plugin based on the last fetched data.|
|DisplayName|LastSyncTime|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lastsynctime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ScheduleTime"></a> ScheduleTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|TimeZoneIndependent|
|Description|This column is updated by the Plugin based on the last fetched data.|
|DisplayName|ScheduleTime|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|scheduletime|
|RequiredLevel|Recommended|
|Type|DateTime|


### <a name="BKMK_SoftTitle"></a> SoftTitle

|Property|Value|
|--------|-----|
|Description|The soft title of the card.|
|DisplayName|Soft Title|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|softtitle|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


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


### <a name="BKMK_SummaryText"></a> SummaryText

|Property|Value|
|--------|-----|
|Description|The summary text of the card.|
|DisplayName|Summary Text|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|summarytext|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the CardType with respect to the base currency.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|

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
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

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


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the CardType with respect to the base currency.|
|DisplayName|ExchangeRate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

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


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|transactioncurrencyidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [cardtype_actioncard](#BKMK_cardtype_actioncard)
- [cardtype_actioncardusersettings](#BKMK_cardtype_actioncardusersettings)


### <a name="BKMK_cardtype_actioncard"></a> cardtype_actioncard

Same as actioncard entity [cardtype_actioncard](actioncard.md#BKMK_cardtype_actioncard) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|actioncard|
|ReferencingAttribute|cardtypeid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|cardtype_actioncards|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_cardtype_actioncardusersettings"></a> cardtype_actioncardusersettings

Same as actioncardusersettings entity [cardtype_actioncardusersettings](actioncardusersettings.md#BKMK_cardtype_actioncardusersettings) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|actioncardusersettings|
|ReferencingAttribute|cardtypeid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|cardtype_actioncardusersettingss|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_cardtype_createdby](#BKMK_lk_cardtype_createdby)
- [lk_cardtype_createdonbehalfby](#BKMK_lk_cardtype_createdonbehalfby)
- [lk_cardtype_modifiedby](#BKMK_lk_cardtype_modifiedby)
- [lk_cardtype_modifiedonbehalfby](#BKMK_lk_cardtype_modifiedonbehalfby)
- [transactioncurrency_cardtype](#BKMK_transactioncurrency_cardtype)


### <a name="BKMK_lk_cardtype_createdby"></a> lk_cardtype_createdby

See systemuser Entity [lk_cardtype_createdby](systemuser.md#BKMK_lk_cardtype_createdby) One-To-Many relationship.

### <a name="BKMK_lk_cardtype_createdonbehalfby"></a> lk_cardtype_createdonbehalfby

See systemuser Entity [lk_cardtype_createdonbehalfby](systemuser.md#BKMK_lk_cardtype_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_cardtype_modifiedby"></a> lk_cardtype_modifiedby

See systemuser Entity [lk_cardtype_modifiedby](systemuser.md#BKMK_lk_cardtype_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_cardtype_modifiedonbehalfby"></a> lk_cardtype_modifiedonbehalfby

See systemuser Entity [lk_cardtype_modifiedonbehalfby](systemuser.md#BKMK_lk_cardtype_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_cardtype"></a> transactioncurrency_cardtype

See transactioncurrency Entity [transactioncurrency_cardtype](transactioncurrency.md#BKMK_transactioncurrency_cardtype) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.cardtype?text=cardtype EntityType" />