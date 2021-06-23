---
title: "List Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the List entity."
ms.date: 04/02/2019
ms.service: "crm-online"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
manager: "annbe"
search.audienceType: 
  - developer

---
# List Entity Reference

Group of existing or potential customers created for a marketing campaign or other sales purposes.

**Added by**: Marketing Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|AddListMembersList|<xref href="Microsoft.Dynamics.CRM.AddListMembersList?text=AddListMembersList Action" />|<xref:Microsoft.Crm.Sdk.Messages.AddListMembersListRequest>|
|AddMemberList|<xref href="Microsoft.Dynamics.CRM.AddMemberList?text=AddMemberList Action" />|<xref:Microsoft.Crm.Sdk.Messages.AddMemberListRequest>|
|Assign|PATCH [*org URI*]/api/data/v9.0/lists(*listid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|CopyDynamicListToStatic|<xref href="Microsoft.Dynamics.CRM.CopyDynamicListToStatic?text=CopyDynamicListToStatic Action" />|<xref:Microsoft.Crm.Sdk.Messages.CopyDynamicListToStaticRequest>|
|CopyMembersList|<xref href="Microsoft.Dynamics.CRM.CopyMembersList?text=CopyMembersList Action" />|<xref:Microsoft.Crm.Sdk.Messages.CopyMembersListRequest>|
|Create|POST [*org URI*]/api/data/v9.0/lists<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|CreateActivitiesList|<xref href="Microsoft.Dynamics.CRM.CreateActivitiesList?text=CreateActivitiesList Action" />|<xref:Microsoft.Crm.Sdk.Messages.CreateActivitiesListRequest>|
|Delete|DELETE [*org URI*]/api/data/v9.0/lists(*listid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|QualifyMemberList|<xref href="Microsoft.Dynamics.CRM.QualifyMemberList?text=QualifyMemberList Action" />|<xref:Microsoft.Crm.Sdk.Messages.QualifyMemberListRequest>|
|RemoveMemberList|<xref href="Microsoft.Dynamics.CRM.RemoveMemberList?text=RemoveMemberList Action" />|<xref:Microsoft.Crm.Sdk.Messages.RemoveMemberListRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/lists(*listid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/lists<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/lists(*listid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/lists(*listid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Lists|
|DisplayCollectionName|Marketing Lists|
|DisplayName|Marketing List|
|EntitySetName|lists|
|IsBPFEntity|False|
|LogicalCollectionName|lists|
|LogicalName|list|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|listid|
|PrimaryNameAttribute|listname|
|SchemaName|List|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Cost](#BKMK_Cost)
- [CreatedFromCode](#BKMK_CreatedFromCode)
- [Description](#BKMK_Description)
- [DoNotSendOnOptOut](#BKMK_DoNotSendOnOptOut)
- [IgnoreInactiveListMembers](#BKMK_IgnoreInactiveListMembers)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [LastUsedOn](#BKMK_LastUsedOn)
- [ListId](#BKMK_ListId)
- [ListName](#BKMK_ListName)
- [LockStatus](#BKMK_LockStatus)
- [MemberCount](#BKMK_MemberCount)
- [MemberType](#BKMK_MemberType)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [ProcessId](#BKMK_ProcessId)
- [Purpose](#BKMK_Purpose)
- [Query](#BKMK_Query)
- [Source](#BKMK_Source)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [Type](#BKMK_Type)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_Cost"></a> Cost

|Property|Value|
|--------|-----|
|Description|Type the cost of obtaining the marketing list.|
|DisplayName|Cost|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|cost|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_CreatedFromCode"></a> CreatedFromCode

|Property|Value|
|--------|-----|
|Description|Select the type of members that this marketing list will contain: accounts, contacts, or leads. Each list can have only one member type and this value can't be changed after the marketing list is created.|
|DisplayName|Marketing List Member Type|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|createdfromcode|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### CreatedFromCode Options

|Value|Label|
|-----|-----|
|1|Account|
|2|Contact|
|4|Lead|



### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the marketing list, such as the intended use or date of the last update.|
|DisplayName|Description|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_DoNotSendOnOptOut"></a> DoNotSendOnOptOut

|Property|Value|
|--------|-----|
|Description|Select whether to override the opt-out settings on leads, contacts, and accounts for the members of the target marketing lists of the campaign activity. If No is selected, those who have chosen to opt out won't be excluded from the list. This means they will receive marketing materials.|
|DisplayName|Exclude Members Who Opt Out|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|donotsendonoptout|
|RequiredLevel|None|
|Type|Boolean|

#### DoNotSendOnOptOut Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_IgnoreInactiveListMembers"></a> IgnoreInactiveListMembers

|Property|Value|
|--------|-----|
|Description|Select whether inactive accounts, contacts, or leads should be excluded from the campaign activity distribution when the marketing list is included in a campaign.|
|DisplayName|Ignore Inactive List Members|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ignoreinactivelistmembers|
|RequiredLevel|None|
|Type|Boolean|

#### IgnoreInactiveListMembers Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



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


### <a name="BKMK_LastUsedOn"></a> LastUsedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time when the marketing list was last used in a campaign or in the creation of activities or opportunities.|
|DisplayName|Last Used On|
|Format|DateOnly|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lastusedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ListId"></a> ListId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the marketing list.|
|DisplayName|List|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|listid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ListName"></a> ListName

|Property|Value|
|--------|-----|
|Description|Type a name for the marketing list so that it is identified correctly in lists.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|listname|
|MaxLength|128|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_LockStatus"></a> LockStatus

|Property|Value|
|--------|-----|
|Description|Select whether the marketing list is locked. If Yes is selected, no additional members can be added to the marketing list.|
|DisplayName|Locked|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lockstatus|
|RequiredLevel|None|
|Type|Boolean|

#### LockStatus Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_MemberCount"></a> MemberCount

|Property|Value|
|--------|-----|
|Description|Shows the sum of all members in the marketing list.|
|DisplayName|Members Count|
|Format|None|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|membercount|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_MemberType"></a> MemberType

|Property|Value|
|--------|-----|
|Description|Type of the members that can be stored in the marketing list.|
|DisplayName|Member Type|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|membertype|
|MaxValue|1000000000|
|MinValue|0|
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


### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|--------|-----|
|Description|Contains the id of the process associated with the entity.|
|DisplayName|Process Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_Purpose"></a> Purpose

|Property|Value|
|--------|-----|
|Description|Type the intended use of the marketing list to identify its key segments, target offers, or business group.|
|DisplayName|Purpose|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|purpose|
|MaxLength|512|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Query"></a> Query

|Property|Value|
|--------|-----|
|Description|Query used for retrieving members of marketing list.|
|DisplayName|Query|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|query|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Source"></a> Source

|Property|Value|
|--------|-----|
|Description|Type the source of the marketing list, such as a third-party supplier or internal database.|
|DisplayName|Source|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|source|
|MaxLength|128|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|--------|-----|
|Description|Contains the id of the stage where the entity is located.|
|DisplayName|(Deprecated) Stage Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the marketing list is active or inactive. Inactive marketing lists are read-only and can't be edited unless they are reactivated.|
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
|0|Active|0|Active|
|1|Inactive|1|Inactive|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the marketing list's status.|
|DisplayName|Status Reason|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|0|Active|0|
|1|Inactive|1|



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
|Description|Choose the local currency for the record to make sure budgets are reported in the correct currency.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|--------|-----|
|Description|A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.|
|DisplayName|(Deprecated) Traversed Path|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|traversedpath|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Type"></a> Type

|Property|Value|
|--------|-----|
|Description|Select whether you want the marketing list to be static or dynamic. The members in a static marketing list are unchanging. A dynamic marketing list is based on a dynamic query that retrieves the updated list of members|
|DisplayName|Type|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|type|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### Type Options

|Value|Label|
|-----|-----|
|1|Dynamic|
|0|Static|

**DefaultValue**: False



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

- [Cost_Base](#BKMK_Cost_Base)
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
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_Cost_Base"></a> Cost_Base

|Property|Value|
|--------|-----|
|Description|Value of the Cost in base currency.|
|DisplayName|Cost (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|cost_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record.|
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
|RequiredLevel|None|
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
|Description|Shows who created the record on behalf of another user.|
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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.|
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
|Description|Shows who last updated the record.|
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
|RequiredLevel|None|
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
|Description|Shows who last updated the record on behalf of another user.|
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
|RequiredLevel|None|
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

- [List_SyncErrors](#BKMK_List_SyncErrors)
- [List_DuplicateMatchingRecord](#BKMK_List_DuplicateMatchingRecord)
- [List_DuplicateBaseRecord](#BKMK_List_DuplicateBaseRecord)
- [List_AsyncOperations](#BKMK_List_AsyncOperations)
- [list_MailboxTrackingFolders](#BKMK_list_MailboxTrackingFolders)
- [List_ProcessSessions](#BKMK_List_ProcessSessions)
- [List_BulkDeleteFailures](#BKMK_List_BulkDeleteFailures)
- [list_principalobjectattributeaccess](#BKMK_list_principalobjectattributeaccess)
- [list_connections1](#BKMK_list_connections1)
- [list_connections2](#BKMK_list_connections2)
- [List_Annotation](#BKMK_List_Annotation)
- [List_BulkOperations](#BKMK_List_BulkOperations)


### <a name="BKMK_List_SyncErrors"></a> List_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [List_SyncErrors](syncerror.md#BKMK_List_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|List_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_List_DuplicateMatchingRecord"></a> List_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [List_DuplicateMatchingRecord](duplicaterecord.md#BKMK_List_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|List_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_List_DuplicateBaseRecord"></a> List_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [List_DuplicateBaseRecord](duplicaterecord.md#BKMK_List_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|List_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_List_AsyncOperations"></a> List_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [List_AsyncOperations](asyncoperation.md#BKMK_List_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|List_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_list_MailboxTrackingFolders"></a> list_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [list_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_list_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|list_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_List_ProcessSessions"></a> List_ProcessSessions

**Added by**: System Solution Solution

Same as processsession entity [List_ProcessSessions](processsession.md#BKMK_List_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|List_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_List_BulkDeleteFailures"></a> List_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [List_BulkDeleteFailures](bulkdeletefailure.md#BKMK_List_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|List_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_list_principalobjectattributeaccess"></a> list_principalobjectattributeaccess

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [list_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_list_principalobjectattributeaccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|list_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_list_connections1"></a> list_connections1

**Added by**: System Solution Solution

Same as connection entity [list_connections1](connection.md#BKMK_list_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|list_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_list_connections2"></a> list_connections2

**Added by**: System Solution Solution

Same as connection entity [list_connections2](connection.md#BKMK_list_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|list_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_List_Annotation"></a> List_Annotation

**Added by**: System Solution Solution

Same as annotation entity [List_Annotation](annotation.md#BKMK_List_Annotation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|List_Annotation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_List_BulkOperations"></a> List_BulkOperations

Same as bulkoperation entity [List_BulkOperations](bulkoperation.md#BKMK_List_BulkOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|List_BulkOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_list_createdby](#BKMK_lk_list_createdby)
- [lk_list_createdonbehalfby](#BKMK_lk_list_createdonbehalfby)
- [lk_list_modifiedby](#BKMK_lk_list_modifiedby)
- [lk_list_modifiedonbehalfby](#BKMK_lk_list_modifiedonbehalfby)
- [user_list](#BKMK_user_list)
- [team_list](#BKMK_team_list)
- [business_unit_list](#BKMK_business_unit_list)
- [processstage_lists](#BKMK_processstage_lists)
- [transactioncurrency_list](#BKMK_transactioncurrency_list)


### <a name="BKMK_lk_list_createdby"></a> lk_list_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_list_createdby](systemuser.md#BKMK_lk_list_createdby) One-To-Many relationship.

### <a name="BKMK_lk_list_createdonbehalfby"></a> lk_list_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_list_createdonbehalfby](systemuser.md#BKMK_lk_list_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_list_modifiedby"></a> lk_list_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_list_modifiedby](systemuser.md#BKMK_lk_list_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_list_modifiedonbehalfby"></a> lk_list_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_list_modifiedonbehalfby](systemuser.md#BKMK_lk_list_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_list"></a> user_list

**Added by**: System Solution Solution

See systemuser Entity [user_list](systemuser.md#BKMK_user_list) One-To-Many relationship.

### <a name="BKMK_team_list"></a> team_list

**Added by**: System Solution Solution

See team Entity [team_list](team.md#BKMK_team_list) One-To-Many relationship.

### <a name="BKMK_business_unit_list"></a> business_unit_list

**Added by**: System Solution Solution

See businessunit Entity [business_unit_list](businessunit.md#BKMK_business_unit_list) One-To-Many relationship.

### <a name="BKMK_processstage_lists"></a> processstage_lists

**Added by**: System Solution Solution

See processstage Entity [processstage_lists](processstage.md#BKMK_processstage_lists) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_list"></a> transactioncurrency_list

**Added by**: System Solution Solution

See transactioncurrency Entity [transactioncurrency_list](transactioncurrency.md#BKMK_transactioncurrency_list) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the List entity is the first entity in the relationship. Listed by **SchemaName**.

- [campaignactivitylist_association](#BKMK_campaignactivitylist_association)
- [listaccount_association](#BKMK_listaccount_association)
- [campaignlist_association](#BKMK_campaignlist_association)
- [listlead_association](#BKMK_listlead_association)
- [listcontact_association](#BKMK_listcontact_association)


### <a name="BKMK_campaignactivitylist_association"></a> campaignactivitylist_association

See campaignactivity Entity [campaignactivitylist_association](campaignactivity.md#BKMK_campaignactivitylist_association) Many-To-Many Relationship.

### <a name="BKMK_listaccount_association"></a> listaccount_association

IntersectEntityName: listmember<br />
#### Entity 1

|Property|Value|
|--------|-----|
|IntersectAttribute|listid|
|IsCustomizable|False|
|LogicalName|list|
|NavigationPropertyName|listaccount_association|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Marketing<br />Label: <br />Order: 10|

#### Entity 2

|Property|Value|
|--------|-----|
|LogicalName|account|
|IntersectAttribute|entityid|
|NavigationPropertyName|listaccount_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |


### <a name="BKMK_campaignlist_association"></a> campaignlist_association

See campaign Entity [campaignlist_association](campaign.md#BKMK_campaignlist_association) Many-To-Many Relationship.

### <a name="BKMK_listlead_association"></a> listlead_association

IntersectEntityName: listmember<br />
#### Entity 1

|Property|Value|
|--------|-----|
|IntersectAttribute|listid|
|IsCustomizable|False|
|LogicalName|list|
|NavigationPropertyName|listlead_association|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Marketing<br />Label: <br />Order: 10|

#### Entity 2

|Property|Value|
|--------|-----|
|LogicalName|lead|
|IntersectAttribute|entityid|
|NavigationPropertyName|listlead_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |


### <a name="BKMK_listcontact_association"></a> listcontact_association

IntersectEntityName: listmember<br />
#### Entity 1

|Property|Value|
|--------|-----|
|IntersectAttribute|listid|
|IsCustomizable|False|
|LogicalName|list|
|NavigationPropertyName|listcontact_association|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Marketing<br />Label: <br />Order: 10|

#### Entity 2

|Property|Value|
|--------|-----|
|LogicalName|contact|
|IntersectAttribute|entityid|
|NavigationPropertyName|listcontact_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |


### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.list?text=list EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]