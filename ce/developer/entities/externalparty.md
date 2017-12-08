---
title: "ExternalParty Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ExternalParty entity."
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
# ExternalParty Entity Reference

Information about external parties that need to access Dynamics 365 from external channels.For internal use only


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/externalparties(*externalpartyid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/externalparties<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/externalparties(*externalpartyid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/externalparties(*externalpartyid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/externalparties<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/externalparties(*externalpartyid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/externalparties(*externalpartyid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|ExternalParties|
|DisplayCollectionName|External Parties|
|DisplayName|External Party|
|EntitySetName|externalparties|
|IsBPFEntity|False|
|LogicalCollectionName|externalparties|
|LogicalName|externalparty|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|externalpartyid|
|PrimaryNameAttribute|fullname|
|SchemaName|ExternalParty|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [CorrelationKey](#BKMK_CorrelationKey)
- [EmailAddress](#BKMK_EmailAddress)
- [ExternalPartyId](#BKMK_ExternalPartyId)
- [FirstName](#BKMK_FirstName)
- [FullName](#BKMK_FullName)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [LastDisabledOn](#BKMK_LastDisabledOn)
- [LastEnabledOn](#BKMK_LastEnabledOn)
- [LastName](#BKMK_LastName)
- [MiddleName](#BKMK_MiddleName)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [Type](#BKMK_Type)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)
- [YomiFirstName](#BKMK_YomiFirstName)
- [YomiLastName](#BKMK_YomiLastName)
- [YomiMiddleName](#BKMK_YomiMiddleName)


### <a name="BKMK_CorrelationKey"></a> CorrelationKey

|Property|Value|
|--------|-----|
|Description|Contains the value that is used to detect and avoid duplicate external party records.|
|DisplayName|Correlation Key|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|correlationkey|
|MaxLength|300|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_EmailAddress"></a> EmailAddress

|Property|Value|
|--------|-----|
|Description|Shows the email address derived from the equivalent record that's enabled as the external party and shows the external user's email address.|
|DisplayName|Email Address|
|FormatName|Email|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|emailaddress|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ExternalPartyId"></a> ExternalPartyId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|External Party|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|externalpartyid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_FirstName"></a> FirstName

|Property|Value|
|--------|-----|
|Description|Type the external party's first name.|
|DisplayName|First Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|firstname|
|MaxLength|64|
|RequiredLevel|Recommended|
|Type|String|


### <a name="BKMK_FullName"></a> FullName

|Property|Value|
|--------|-----|
|Description|Type the full name of the external party.|
|DisplayName|Full Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|fullname|
|MaxLength|300|
|RequiredLevel|None|
|Type|String|


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


### <a name="BKMK_LastDisabledOn"></a> LastDisabledOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date when the external party was last disabled on.|
|DisplayName|Last Disabled On|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lastdisabledon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_LastEnabledOn"></a> LastEnabledOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date when the external party was last enabled on.|
|DisplayName|Last Enabled On|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lastenabledon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_LastName"></a> LastName

|Property|Value|
|--------|-----|
|Description|Type the external party's last name.|
|DisplayName|Last Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lastname|
|MaxLength|64|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_MiddleName"></a> MiddleName

|Property|Value|
|--------|-----|
|Description|Type the external party's middle name.|
|DisplayName|Middle Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|middlename|
|MaxLength|50|
|RequiredLevel|None|
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

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user or team who owns the record.|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the external party is enabled or disabled|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Enabled|1|Enabled|
|1|Disabled|2|Disabled|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the external party status|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|Enabled|0|
|2|Disabled|1|



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


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the ExternalParty with respect to the base currency.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_Type"></a> Type

|Property|Value|
|--------|-----|
|Description|Type of the external party.|
|DisplayName|Type|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|type|
|MaxLength|300|
|RequiredLevel|None|
|Type|String|


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


### <a name="BKMK_YomiFirstName"></a> YomiFirstName

|Property|Value|
|--------|-----|
|Description|Type the phonetic spelling of the external party's first name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the external party..|
|DisplayName|Yomi First Name|
|FormatName|PhoneticGuide|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|yomifirstname|
|MaxLength|150|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_YomiLastName"></a> YomiLastName

|Property|Value|
|--------|-----|
|Description|Type the phonetic spelling of the external party's last name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the external party.|
|DisplayName|Yomi Last Name|
|FormatName|PhoneticGuide|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|yomilastname|
|MaxLength|150|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_YomiMiddleName"></a> YomiMiddleName

|Property|Value|
|--------|-----|
|Description|Type the phonetic spelling of the external party's middle name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.|
|DisplayName|Yomi Middle Name|
|FormatName|PhoneticGuide|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|yomimiddlename|
|MaxLength|150|
|RequiredLevel|None|
|Type|String|

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
- [ExternalPartyIdUnique](#BKMK_ExternalPartyIdUnique)
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
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)
- [YomiFullName](#BKMK_YomiFullName)


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
|Description|Exchange rate for the currency associated with the ExternalParty with respect to the base currency.|
|DisplayName|ExchangeRate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_ExternalPartyIdUnique"></a> ExternalPartyIdUnique

|Property|Value|
|--------|-----|
|Description|Unique identifier of the External Party used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook|
|DisplayName|External Party Unique Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|externalpartyidunique|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

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


### <a name="BKMK_YomiFullName"></a> YomiFullName

|Property|Value|
|--------|-----|
|Description|Shows the combined Yomi first and last names of the external party so that the full phonetic name can be displayed in views and reports.|
|DisplayName|Yomi Full Name|
|FormatName|PhoneticGuide|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|yomifullname|
|MaxLength|450|
|RequiredLevel|None|
|Type|String|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [lk_externalparty_product_createdby](#BKMK_lk_externalparty_product_createdby)
- [lk_externalparty_product_modifiedby](#BKMK_lk_externalparty_product_modifiedby)
- [lk_externalparty_uom_createdby](#BKMK_lk_externalparty_uom_createdby)
- [lk_externalparty_uom_modifiedby](#BKMK_lk_externalparty_uom_modifiedby)
- [lk_externalparty_uomschedule_createdby](#BKMK_lk_externalparty_uomschedule_createdby)
- [lk_externalparty_uomschedule_modifiedby](#BKMK_lk_externalparty_uomschedule_modifiedby)
- [lk_externalparty_incident_createdby](#BKMK_lk_externalparty_incident_createdby)
- [lk_externalparty_incident_modifiedby](#BKMK_lk_externalparty_incident_modifiedby)
- [lk_externalparty_incidentresolution_createdby](#BKMK_lk_externalparty_incidentresolution_createdby)
- [lk_externalparty_incidentresolution_modifiedby](#BKMK_lk_externalparty_incidentresolution_modifiedby)
- [lk_externalparty_opportunityclose_createdby](#BKMK_lk_externalparty_opportunityclose_createdby)
- [lk_externalparty_opportunityclose_modifiedby](#BKMK_lk_externalparty_opportunityclose_modifiedby)
- [lk_externalparty_orderclose_createdby](#BKMK_lk_externalparty_orderclose_createdby)
- [lk_externalparty_orderclose_modifiedby](#BKMK_lk_externalparty_orderclose_modifiedby)
- [lk_externalparty_quoteclose_createdby](#BKMK_lk_externalparty_quoteclose_createdby)
- [lk_externalparty_quoteclose_modifiedby](#BKMK_lk_externalparty_quoteclose_modifiedby)
- [externalparty_AsyncOperations](#BKMK_externalparty_AsyncOperations)
- [externalparty_UserEntityInstanceDatas](#BKMK_externalparty_UserEntityInstanceDatas)
- [externalparty_ProcessSession](#BKMK_externalparty_ProcessSession)
- [externalparty_BulkDeleteFailures](#BKMK_externalparty_BulkDeleteFailures)
- [lk_externalparty_subject_modifiedby](#BKMK_lk_externalparty_subject_modifiedby)
- [lk_externalparty_account_modifiedby](#BKMK_lk_externalparty_account_modifiedby)
- [lk_externalparty_contact_createdby](#BKMK_lk_externalparty_contact_createdby)
- [lk_externalparty_account_createdby](#BKMK_lk_externalparty_account_createdby)
- [lk_externalparty_subject_createdby](#BKMK_lk_externalparty_subject_createdby)
- [externalparty_entries](#BKMK_externalparty_entries)
- [ExternalParty_SyncErrors](#BKMK_ExternalParty_SyncErrors)
- [lk_externalparty_contact_modifiedby](#BKMK_lk_externalparty_contact_modifiedby)


### <a name="BKMK_lk_externalparty_product_createdby"></a> lk_externalparty_product_createdby

Same as product entity [lk_externalparty_product_createdby](product.md#BKMK_lk_externalparty_product_createdby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|product|
|ReferencingAttribute|createdbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_product_createdby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_externalparty_product_modifiedby"></a> lk_externalparty_product_modifiedby

Same as product entity [lk_externalparty_product_modifiedby](product.md#BKMK_lk_externalparty_product_modifiedby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|product|
|ReferencingAttribute|modifiedbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_product_modifiedby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_externalparty_uom_createdby"></a> lk_externalparty_uom_createdby

Same as uom entity [lk_externalparty_uom_createdby](uom.md#BKMK_lk_externalparty_uom_createdby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|uom|
|ReferencingAttribute|createdbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_uom_createdby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_externalparty_uom_modifiedby"></a> lk_externalparty_uom_modifiedby

Same as uom entity [lk_externalparty_uom_modifiedby](uom.md#BKMK_lk_externalparty_uom_modifiedby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|uom|
|ReferencingAttribute|modifiedbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_uom_modifiedby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_externalparty_uomschedule_createdby"></a> lk_externalparty_uomschedule_createdby

Same as uomschedule entity [lk_externalparty_uomschedule_createdby](uomschedule.md#BKMK_lk_externalparty_uomschedule_createdby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|uomschedule|
|ReferencingAttribute|createdbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_uomschedule_createdby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_externalparty_uomschedule_modifiedby"></a> lk_externalparty_uomschedule_modifiedby

Same as uomschedule entity [lk_externalparty_uomschedule_modifiedby](uomschedule.md#BKMK_lk_externalparty_uomschedule_modifiedby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|uomschedule|
|ReferencingAttribute|modifiedbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_uomschedule_modifiedby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_externalparty_incident_createdby"></a> lk_externalparty_incident_createdby

Same as incident entity [lk_externalparty_incident_createdby](incident.md#BKMK_lk_externalparty_incident_createdby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|incident|
|ReferencingAttribute|createdbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_incident_createdby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_externalparty_incident_modifiedby"></a> lk_externalparty_incident_modifiedby

Same as incident entity [lk_externalparty_incident_modifiedby](incident.md#BKMK_lk_externalparty_incident_modifiedby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|incident|
|ReferencingAttribute|modifiedbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_incident_modifiedby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_externalparty_incidentresolution_createdby"></a> lk_externalparty_incidentresolution_createdby

Same as incidentresolution entity [lk_externalparty_incidentresolution_createdby](incidentresolution.md#BKMK_lk_externalparty_incidentresolution_createdby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|incidentresolution|
|ReferencingAttribute|createdbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_incidentresolution_createdby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_externalparty_incidentresolution_modifiedby"></a> lk_externalparty_incidentresolution_modifiedby

Same as incidentresolution entity [lk_externalparty_incidentresolution_modifiedby](incidentresolution.md#BKMK_lk_externalparty_incidentresolution_modifiedby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|incidentresolution|
|ReferencingAttribute|modifiedbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_incidentresolution_modifiedby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_externalparty_opportunityclose_createdby"></a> lk_externalparty_opportunityclose_createdby

Same as opportunityclose entity [lk_externalparty_opportunityclose_createdby](opportunityclose.md#BKMK_lk_externalparty_opportunityclose_createdby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|createdbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_opportunityclose_createdby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_externalparty_opportunityclose_modifiedby"></a> lk_externalparty_opportunityclose_modifiedby

Same as opportunityclose entity [lk_externalparty_opportunityclose_modifiedby](opportunityclose.md#BKMK_lk_externalparty_opportunityclose_modifiedby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|modifiedbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_opportunityclose_modifiedby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_externalparty_orderclose_createdby"></a> lk_externalparty_orderclose_createdby

Same as orderclose entity [lk_externalparty_orderclose_createdby](orderclose.md#BKMK_lk_externalparty_orderclose_createdby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|createdbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_orderclose_createdby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_externalparty_orderclose_modifiedby"></a> lk_externalparty_orderclose_modifiedby

Same as orderclose entity [lk_externalparty_orderclose_modifiedby](orderclose.md#BKMK_lk_externalparty_orderclose_modifiedby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|modifiedbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_orderclose_modifiedby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_externalparty_quoteclose_createdby"></a> lk_externalparty_quoteclose_createdby

Same as quoteclose entity [lk_externalparty_quoteclose_createdby](quoteclose.md#BKMK_lk_externalparty_quoteclose_createdby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|createdbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_quoteclose_createdby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_externalparty_quoteclose_modifiedby"></a> lk_externalparty_quoteclose_modifiedby

Same as quoteclose entity [lk_externalparty_quoteclose_modifiedby](quoteclose.md#BKMK_lk_externalparty_quoteclose_modifiedby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|modifiedbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_quoteclose_modifiedby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_externalparty_AsyncOperations"></a> externalparty_AsyncOperations

Same as asyncoperation entity [externalparty_AsyncOperations](asyncoperation.md#BKMK_externalparty_AsyncOperations) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|externalparty_asyncoperations_externalparty|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_externalparty_UserEntityInstanceDatas"></a> externalparty_UserEntityInstanceDatas

Same as userentityinstancedata entity [externalparty_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_externalparty_UserEntityInstanceDatas) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|externalparty_userentityinstancedatas_externalparty|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_externalparty_ProcessSession"></a> externalparty_ProcessSession

Same as processsession entity [externalparty_ProcessSession](processsession.md#BKMK_externalparty_ProcessSession) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|externalparty_processsession_externalparty|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_externalparty_BulkDeleteFailures"></a> externalparty_BulkDeleteFailures

Same as bulkdeletefailure entity [externalparty_BulkDeleteFailures](bulkdeletefailure.md#BKMK_externalparty_BulkDeleteFailures) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|externalparty_bulkdeletefailures_externalparty|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_externalparty_subject_modifiedby"></a> lk_externalparty_subject_modifiedby

Same as subject entity [lk_externalparty_subject_modifiedby](subject.md#BKMK_lk_externalparty_subject_modifiedby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|subject|
|ReferencingAttribute|modifiedbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_subject_modifiedby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_externalparty_account_modifiedby"></a> lk_externalparty_account_modifiedby

Same as account entity [lk_externalparty_account_modifiedby](account.md#BKMK_lk_externalparty_account_modifiedby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|account|
|ReferencingAttribute|modifiedbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_account_modifiedby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_externalparty_contact_createdby"></a> lk_externalparty_contact_createdby

Same as contact entity [lk_externalparty_contact_createdby](contact.md#BKMK_lk_externalparty_contact_createdby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|contact|
|ReferencingAttribute|createdbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_contact_createdby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_externalparty_account_createdby"></a> lk_externalparty_account_createdby

Same as account entity [lk_externalparty_account_createdby](account.md#BKMK_lk_externalparty_account_createdby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|account|
|ReferencingAttribute|createdbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_account_createdby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_externalparty_subject_createdby"></a> lk_externalparty_subject_createdby

Same as subject entity [lk_externalparty_subject_createdby](subject.md#BKMK_lk_externalparty_subject_createdby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|subject|
|ReferencingAttribute|createdbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_subject_createdby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_externalparty_entries"></a> externalparty_entries

Same as externalpartyitem entity [externalparty_entries](externalpartyitem.md#BKMK_externalparty_entries) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|externalpartyitem|
|ReferencingAttribute|externalpartyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|externalparty_entries|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ExternalParty_SyncErrors"></a> ExternalParty_SyncErrors

Same as syncerror entity [ExternalParty_SyncErrors](syncerror.md#BKMK_ExternalParty_SyncErrors) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|ExternalParty_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_lk_externalparty_contact_modifiedby"></a> lk_externalparty_contact_modifiedby

Same as contact entity [lk_externalparty_contact_modifiedby](contact.md#BKMK_lk_externalparty_contact_modifiedby) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|contact|
|ReferencingAttribute|modifiedbyexternalparty|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_externalparty_contact_modifiedby|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_externalparty_createdby](#BKMK_lk_externalparty_createdby)
- [lk_externalparty_createdonbehalfby](#BKMK_lk_externalparty_createdonbehalfby)
- [lk_externalparty_modifiedby](#BKMK_lk_externalparty_modifiedby)
- [lk_externalparty_modifiedonbehalfby](#BKMK_lk_externalparty_modifiedonbehalfby)
- [user_externalparty](#BKMK_user_externalparty)
- [team_externalparty](#BKMK_team_externalparty)
- [business_unit_externalparty](#BKMK_business_unit_externalparty)
- [TransactionCurrency_ExternalParty](#BKMK_TransactionCurrency_ExternalParty)


### <a name="BKMK_lk_externalparty_createdby"></a> lk_externalparty_createdby

See systemuser Entity [lk_externalparty_createdby](systemuser.md#BKMK_lk_externalparty_createdby) One-To-Many relationship.

### <a name="BKMK_lk_externalparty_createdonbehalfby"></a> lk_externalparty_createdonbehalfby

See systemuser Entity [lk_externalparty_createdonbehalfby](systemuser.md#BKMK_lk_externalparty_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_externalparty_modifiedby"></a> lk_externalparty_modifiedby

See systemuser Entity [lk_externalparty_modifiedby](systemuser.md#BKMK_lk_externalparty_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_externalparty_modifiedonbehalfby"></a> lk_externalparty_modifiedonbehalfby

See systemuser Entity [lk_externalparty_modifiedonbehalfby](systemuser.md#BKMK_lk_externalparty_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_externalparty"></a> user_externalparty

See systemuser Entity [user_externalparty](systemuser.md#BKMK_user_externalparty) One-To-Many relationship.

### <a name="BKMK_team_externalparty"></a> team_externalparty

See team Entity [team_externalparty](team.md#BKMK_team_externalparty) One-To-Many relationship.

### <a name="BKMK_business_unit_externalparty"></a> business_unit_externalparty

See businessunit Entity [business_unit_externalparty](businessunit.md#BKMK_business_unit_externalparty) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_ExternalParty"></a> TransactionCurrency_ExternalParty

See transactioncurrency Entity [TransactionCurrency_ExternalParty](transactioncurrency.md#BKMK_TransactionCurrency_ExternalParty) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.externalparty?text=externalparty EntityType" />