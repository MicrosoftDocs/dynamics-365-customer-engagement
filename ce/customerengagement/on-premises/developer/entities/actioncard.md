---
title: "ActionCard entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the ActionCard entity."
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author:  matp
search.audienceType: 
  - developer
---

# ActionCard entity reference

Action card entity to show action cards.


## Messages

|Message|SDK class or method|
|-|-|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|ActionCards|
|DisplayCollectionName|Action Cards|
|DisplayName|Action Card|
|EntitySetName|actioncards|
|IsBPFEntity|False|
|LogicalCollectionName|actioncard|
|LogicalName|actioncard|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|actioncardid|
|PrimaryNameAttribute|title|
|SchemaName|ActionCard|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActionCardId](#BKMK_ActionCardId)
- [CardType](#BKMK_CardType)
- [CardTypeId](#BKMK_CardTypeId)
- [Data](#BKMK_Data)
- [Description](#BKMK_Description)
- [ExpiryDate](#BKMK_ExpiryDate)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [ParentRegardingObjectId](#BKMK_ParentRegardingObjectId)
- [ParentRegardingObjectTypeCode](#BKMK_ParentRegardingObjectTypeCode)
- [Priority](#BKMK_Priority)
- [RecordId](#BKMK_RecordId)
- [RecordIdObjectTypeCode](#BKMK_RecordIdObjectTypeCode)
- [RecordIdObjectTypeCode2](#BKMK_RecordIdObjectTypeCode2)
- [ReferenceTokens](#BKMK_ReferenceTokens)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [Source](#BKMK_Source)
- [StartDate](#BKMK_StartDate)
- [State](#BKMK_State)
- [Title](#BKMK_Title)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [Visibility](#BKMK_Visibility)


### <a name="BKMK_ActionCardId"></a> ActionCardId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the action card.|
|DisplayName|Action Card|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|actioncardid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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
|Description|Unique identifier of the card type.|
|DisplayName|Card Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|cardtypeid|
|RequiredLevel|SystemRequired|
|Targets|cardtype|
|Type|Lookup|


### <a name="BKMK_Data"></a> Data

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Data Associated with Card Commandbar Actions|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|data|
|MaxLength|8192|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Card Description|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|8192|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_ExpiryDate"></a> ExpiryDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the Expiry Date|
|DisplayName|Expiry Date|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|expirydate|
|RequiredLevel|SystemRequired|
|Type|DateTime|


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

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user or team who owns the action card.|
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
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_ParentRegardingObjectId"></a> ParentRegardingObjectId

|Property|Value|
|--------|-----|
|Description|ParentRegardingObjectId of the ActionCard|
|DisplayName|ParentRegardingObjectId|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentregardingobjectid|
|RequiredLevel|None|
|Targets||
|Type|Lookup|


### <a name="BKMK_ParentRegardingObjectTypeCode"></a> ParentRegardingObjectTypeCode

|Property|Value|
|--------|-----|
|Description|ParentRegardingObjectTypeCode of the ActionCard|
|DisplayName|ParentRegardingObjectTypeCode|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentregardingobjecttypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_Priority"></a> Priority

|Property|Value|
|--------|-----|
|Description|Priority of the ActionCard|
|DisplayName|Priority|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|priority|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_RecordId"></a> RecordId

|Property|Value|
|--------|-----|
|Description|Shows the record ID.|
|DisplayName|RecordId|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|recordid|
|RequiredLevel|None|
|Targets||
|Type|Lookup|


### <a name="BKMK_RecordIdObjectTypeCode"></a> RecordIdObjectTypeCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|recordidobjecttypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_RecordIdObjectTypeCode2"></a> RecordIdObjectTypeCode2

|Property|Value|
|--------|-----|
|Description|RecordIdObjectTypeCode2 of the ActionCard|
|DisplayName|RecordIdObjectTypeCode2|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|recordidobjecttypecode2|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ReferenceTokens"></a> ReferenceTokens

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Data Associated constructing title and body|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|referencetokens|
|MaxLength|8192|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|--------|-----|
|Description|Choose the record that the card relates to.|
|DisplayName|Regarding|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|regardingobjectid|
|RequiredLevel|None|
|Targets|account,appointment,contact,email,fax,incident,lead,letter,opportunity,phonecall,recurringappointmentmaster,serviceappointment,task|
|Type|Lookup|


### <a name="BKMK_RegardingObjectIdName"></a> RegardingObjectIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjectidname|
|MaxLength|4000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjecttypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_Source"></a> Source

|Property|Value|
|--------|-----|
|Description|Source for the Action Card|
|DisplayName|Action Card Source|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|source|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### Source Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|CRM||
|2|Exchange||



### <a name="BKMK_StartDate"></a> StartDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the Start Date|
|DisplayName|Start Date|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|startdate|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_State"></a> State

|Property|Value|
|--------|-----|
|Description|State of the Action Card|
|DisplayName|Action Card State|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|state|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### State Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Active||
|1|Dismissed||
|2|Completed||



### <a name="BKMK_Title"></a> Title

|Property|Value|
|--------|-----|
|Description|Title of the ActionCard|
|DisplayName|Title|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|title|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the currency associated with the action card.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_Visibility"></a> Visibility

|Property|Value|
|--------|-----|
|Description|Select whether the visibility should be set to public/private.|
|DisplayName|Visibiliy Status of ActionCard|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|visibility|
|RequiredLevel|None|
|Type|Boolean|

#### Visibility Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Private||
|0|Public||

**DefaultValue**: 0


<a name="read-only-attributes"></a>

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CardTypeIdName](#BKMK_CardTypeIdName)
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
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [RecordIdName](#BKMK_RecordIdName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
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


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the action card.|
|DisplayName|Created By|
|IsValidForForm|False|
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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when action card was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the action card.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|False|
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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the action card with respect to the base currency.|
|DisplayName|Exchange Rate|
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
|Description|Unique identifier of the user who last modified the action card.|
|DisplayName|Modified By|
|IsValidForForm|False|
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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when action card was last modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified action card.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|False|
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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|--------|-----|
|Description||
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
|Description|Unique identifier of the business unit that owns the action card.|
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
|Description|Unique identifier of the team who owns the action card.|
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
|Description|Unique identifier of the user who owns the action card.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_RecordIdName"></a> RecordIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|recordidname|
|MaxLength|400|
|RequiredLevel|None|
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
|Description|Version number of the action card.|
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


### <a name="BKMK_ActionCardUserState_ActionCard"></a> ActionCardUserState_ActionCard

Same as the [ActionCardUserState_ActionCard](actioncarduserstate.md#BKMK_ActionCardUserState_ActionCard) many-to-one relationship for the [actioncarduserstate](actioncarduserstate.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|actioncarduserstate|
|ReferencingAttribute|actioncardid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|ActionCardUserState_ActionCard|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [Lead_actioncard](#BKMK_Lead_actioncard)
- [incident_actioncard](#BKMK_incident_actioncard)
- [serviceappointment_actioncard](#BKMK_serviceappointment_actioncard)
- [opportunity_actioncard](#BKMK_opportunity_actioncard)
- [contact_actioncard](#BKMK_contact_actioncard)
- [lk_actioncardbase_modifiedby](#BKMK_lk_actioncardbase_modifiedby)
- [letter_actioncard](#BKMK_letter_actioncard)
- [phonecall_actioncard](#BKMK_phonecall_actioncard)
- [task_actioncard](#BKMK_task_actioncard)
- [email_actioncard](#BKMK_email_actioncard)
- [lk_actioncardbase_createdonbehalfby](#BKMK_lk_actioncardbase_createdonbehalfby)
- [business_unit_actioncards](#BKMK_business_unit_actioncards)
- [recurringappointmentmaster_actioncard](#BKMK_recurringappointmentmaster_actioncard)
- [lk_actioncardbase_createdby](#BKMK_lk_actioncardbase_createdby)
- [transactioncurrency_actioncard](#BKMK_transactioncurrency_actioncard)
- [account_actioncard](#BKMK_account_actioncard)
- [appointment_actioncard](#BKMK_appointment_actioncard)
- [fax_actioncard](#BKMK_fax_actioncard)
- [lk_actioncardbase_modifiedonbehalfby](#BKMK_lk_actioncardbase_modifiedonbehalfby)


### <a name="BKMK_Lead_actioncard"></a> Lead_actioncard

**Added by**: Lead Management Solution

See the [Lead_actioncard](lead.md#BKMK_Lead_actioncard) one-to-many relationship for the [lead](lead.md) entity.

### <a name="BKMK_incident_actioncard"></a> incident_actioncard

**Added by**: Service Solution

See the [incident_actioncard](incident.md#BKMK_incident_actioncard) one-to-many relationship for the [incident](incident.md) entity.

### <a name="BKMK_serviceappointment_actioncard"></a> serviceappointment_actioncard

**Added by**: Service Solution

See the [serviceappointment_actioncard](serviceappointment.md#BKMK_serviceappointment_actioncard) one-to-many relationship for the [serviceappointment](serviceappointment.md) entity.

### <a name="BKMK_opportunity_actioncard"></a> opportunity_actioncard

**Added by**: Sales Solution

See the [opportunity_actioncard](opportunity.md#BKMK_opportunity_actioncard) one-to-many relationship for the [opportunity](opportunity.md) entity.

### <a name="BKMK_contact_actioncard"></a> contact_actioncard

See the [contact_actioncard](contact.md#BKMK_contact_actioncard) one-to-many relationship for the [contact](contact.md) entity.

### <a name="BKMK_lk_actioncardbase_modifiedby"></a> lk_actioncardbase_modifiedby

See the [lk_actioncardbase_modifiedby](systemuser.md#BKMK_lk_actioncardbase_modifiedby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_letter_actioncard"></a> letter_actioncard

See the [letter_actioncard](letter.md#BKMK_letter_actioncard) one-to-many relationship for the [letter](letter.md) entity.

### <a name="BKMK_phonecall_actioncard"></a> phonecall_actioncard

See the [phonecall_actioncard](phonecall.md#BKMK_phonecall_actioncard) one-to-many relationship for the [phonecall](phonecall.md) entity.

### <a name="BKMK_task_actioncard"></a> task_actioncard

See the [task_actioncard](task.md#BKMK_task_actioncard) one-to-many relationship for the [task](task.md) entity.

### <a name="BKMK_email_actioncard"></a> email_actioncard

See the [email_actioncard](email.md#BKMK_email_actioncard) one-to-many relationship for the [email](email.md) entity.

### <a name="BKMK_lk_actioncardbase_createdonbehalfby"></a> lk_actioncardbase_createdonbehalfby

See the [lk_actioncardbase_createdonbehalfby](systemuser.md#BKMK_lk_actioncardbase_createdonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_business_unit_actioncards"></a> business_unit_actioncards

See the [business_unit_actioncards](businessunit.md#BKMK_business_unit_actioncards) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_recurringappointmentmaster_actioncard"></a> recurringappointmentmaster_actioncard

See the [recurringappointmentmaster_actioncard](recurringappointmentmaster.md#BKMK_recurringappointmentmaster_actioncard) one-to-many relationship for the [recurringappointmentmaster](recurringappointmentmaster.md) entity.

### <a name="BKMK_lk_actioncardbase_createdby"></a> lk_actioncardbase_createdby

See the [lk_actioncardbase_createdby](systemuser.md#BKMK_lk_actioncardbase_createdby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_transactioncurrency_actioncard"></a> transactioncurrency_actioncard

See the [transactioncurrency_actioncard](transactioncurrency.md#BKMK_transactioncurrency_actioncard) one-to-many relationship for the [transactioncurrency](transactioncurrency.md) entity.

### <a name="BKMK_account_actioncard"></a> account_actioncard

See the [account_actioncard](account.md#BKMK_account_actioncard) one-to-many relationship for the [account](account.md) entity.

### <a name="BKMK_appointment_actioncard"></a> appointment_actioncard

See the [appointment_actioncard](appointment.md#BKMK_appointment_actioncard) one-to-many relationship for the [appointment](appointment.md) entity.

### <a name="BKMK_fax_actioncard"></a> fax_actioncard

See the [fax_actioncard](fax.md#BKMK_fax_actioncard) one-to-many relationship for the [fax](fax.md) entity.

### <a name="BKMK_lk_actioncardbase_modifiedonbehalfby"></a> lk_actioncardbase_modifiedonbehalfby

See the [lk_actioncardbase_modifiedonbehalfby](systemuser.md#BKMK_lk_actioncardbase_modifiedonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)
