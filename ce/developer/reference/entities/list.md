---
title: "Marketing List (List) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Marketing List (List) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Marketing List (List) table/entity reference (Microsoft Dynamics 365)

Group of existing or potential customers created for a marketing campaign or other sales purposes.

## Messages

The following table lists the messages for the Marketing List (List) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `AddListMembersList`<br />Event: True |**AddListMembersList action** |<xref:Microsoft.Crm.Sdk.Messages.AddListMembersListRequest>|
| `AddMemberList`<br />Event: True |**AddMemberList action** |<xref:Microsoft.Crm.Sdk.Messages.AddMemberListRequest>|
| `AddMembersBatchList`<br />Event: True |**AddMembersBatchList action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Assign`<br />Event: True |`PATCH` /lists(*listid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `CopyDynamicListToStatic`<br />Event: True |**CopyDynamicListToStatic action** |<xref:Microsoft.Crm.Sdk.Messages.CopyDynamicListToStaticRequest>|
| `CopyMembersList`<br />Event: False |**CopyMembersList action** |<xref:Microsoft.Crm.Sdk.Messages.CopyMembersListRequest>|
| `Create`<br />Event: True |`POST` /lists<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateActivitiesList`<br />Event: False |**CreateActivitiesList action** |<xref:Microsoft.Crm.Sdk.Messages.CreateActivitiesListRequest>|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /lists(*listid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `QualifyMemberList`<br />Event: False |**QualifyMemberList action** |<xref:Microsoft.Crm.Sdk.Messages.QualifyMemberListRequest>|
| `RemoveListMembersList`<br />Event: True |**RemoveListMembersList action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RemoveMemberList`<br />Event: True |**RemoveMemberList action** |<xref:Microsoft.Crm.Sdk.Messages.RemoveMemberListRequest>|
| `Retrieve`<br />Event: True |`GET` /lists(*listid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /lists<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /lists(*listid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /lists(*listid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /lists(*listid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Marketing List (List) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Marketing List** |
| **DisplayCollectionName** | **Marketing Lists** |
| **SchemaName** | `List` |
| **CollectionSchemaName** | `Lists` |
| **EntitySetName** | `lists`|
| **LogicalName** | `list` |
| **LogicalCollectionName** | `lists` |
| **PrimaryIdAttribute** | `listid` |
| **PrimaryNameAttribute** |`listname` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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
- [processedMemberCount](#BKMK_processedMemberCount)
- [processFetchXML](#BKMK_processFetchXML)
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
|---|---|
|Description|**Type the cost of obtaining the marketing list.**|
|DisplayName|**Cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`cost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_CreatedFromCode"></a> CreatedFromCode

|Property|Value|
|---|---|
|Description|**Select the type of members that this marketing list will contain: accounts, contacts, or leads. Each list can have only one member type and this value can't be changed after the marketing list is created.**|
|DisplayName|**Marketing List Member Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdfromcode`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`list_createdfromcode`|

#### CreatedFromCode Choices/Options

|Value|Label|
|---|---|
|1|**Account**|
|2|**Contact**|
|4|**Lead**|

### <a name="BKMK_Description"></a> Description

|Property|Value|
|---|---|
|Description|**Type additional information to describe the marketing list, such as the intended use or date of the last update.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`description`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_DoNotSendOnOptOut"></a> DoNotSendOnOptOut

|Property|Value|
|---|---|
|Description|**Select whether to override the opt-out settings on leads, contacts, and accounts for the members of the target marketing lists of the campaign activity. If No is selected, those who have chosen to opt out won't be excluded from the list. This means they will receive marketing materials.**|
|DisplayName|**Exclude Members Who Opt Out**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`donotsendonoptout`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`list_donotsendonoptout`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_IgnoreInactiveListMembers"></a> IgnoreInactiveListMembers

|Property|Value|
|---|---|
|Description|**Select whether inactive accounts, contacts, or leads should be excluded from the campaign activity distribution when the marketing list is included in a campaign.**|
|DisplayName|**Ignore Inactive List Members**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ignoreinactivelistmembers`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`list_ignoreinactivelistmembers`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

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

### <a name="BKMK_LastUsedOn"></a> LastUsedOn

|Property|Value|
|---|---|
|Description|**Shows the date and time when the marketing list was last used in a campaign or in the creation of activities or opportunities.**|
|DisplayName|**Last Used On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`lastusedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ListId"></a> ListId

|Property|Value|
|---|---|
|Description|**Unique identifier of the marketing list.**|
|DisplayName|**Marketing List**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`listid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ListName"></a> ListName

|Property|Value|
|---|---|
|Description|**Type a name for the marketing list so that it is identified correctly in lists.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`listname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|

### <a name="BKMK_LockStatus"></a> LockStatus

|Property|Value|
|---|---|
|Description|**Select whether the marketing list is locked. If Yes is selected, no additional members can be added to the marketing list.**|
|DisplayName|**Locked**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`lockstatus`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`list_lockstatus`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_MemberCount"></a> MemberCount

|Property|Value|
|---|---|
|Description|**Shows the sum of all members in the marketing list.**|
|DisplayName|**Members Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`membercount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1000000000|
|MinValue|0|

### <a name="BKMK_MemberType"></a> MemberType

|Property|Value|
|---|---|
|Description|**Type of the members that can be stored in the marketing list. Please do not remove from form!**|
|DisplayName|**Member Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`membertype`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1000000000|
|MinValue|0|

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

### <a name="BKMK_processedMemberCount"></a> processedMemberCount

|Property|Value|
|---|---|
|Description||
|DisplayName|**processedMemberCount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`processedmembercount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_processFetchXML"></a> processFetchXML

|Property|Value|
|---|---|
|Description||
|DisplayName|**processFetchXML**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processfetchxml`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|---|---|
|Description|**Contains the id of the process associated with the entity.**|
|DisplayName|**Process Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_Purpose"></a> Purpose

|Property|Value|
|---|---|
|Description|**Type the intended use of the marketing list to identify its key segments, target offers, or business group.**|
|DisplayName|**Purpose**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`purpose`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|512|

### <a name="BKMK_Query"></a> Query

|Property|Value|
|---|---|
|Description|**Query used for retrieving members of marketing list.**|
|DisplayName|**Query**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`query`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1073741823|

### <a name="BKMK_Source"></a> Source

|Property|Value|
|---|---|
|Description|**Type the source of the marketing list, such as a third-party supplier or internal database.**|
|DisplayName|**Source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`source`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|

### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|---|---|
|Description|**Contains the id of the stage where the entity is located.**|
|DisplayName|**(Deprecated) Stage Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|---|---|
|Description|**Shows whether the marketing list is active or inactive. Inactive marketing lists are read-only and can't be edited unless they are reactivated.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue|0|
|GlobalChoiceName|`list_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 0<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 1<br />InvariantName: `Inactive`|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Select the marketing list's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue|-1|
|GlobalChoiceName|`list_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />State:0<br />TransitionData: None|
|1|Label: **Inactive**<br />State:1<br />TransitionData: None|

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

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Choose the local currency for the record to make sure budgets are reported in the correct currency.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|---|---|
|Description|**A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.**|
|DisplayName|**(Deprecated) Traversed Path**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`traversedpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

### <a name="BKMK_Type"></a> Type

|Property|Value|
|---|---|
|Description|**Select whether you want the marketing list to be static or dynamic. The members in a static marketing list are unchanging. A dynamic marketing list is based on a dynamic query that retrieves the updated list of members**|
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`type`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`list_type`|
|DefaultValue|False|
|True Label|Dynamic|
|False Label|Static|

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

- [Cost_Base](#BKMK_Cost_Base)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_Cost_Base"></a> Cost_Base

|Property|Value|
|---|---|
|Description|**Value of the Cost in base currency.**|
|DisplayName|**Cost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`cost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Shows who created the record.**|
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
|Description|**Shows who created the record on behalf of another user.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.**|
|DisplayName|**Exchange Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-12|
|Precision|12|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Shows who last updated the record.**|
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
|Description|**Shows who last updated the record on behalf of another user.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

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
|RequiredLevel|SystemRequired|
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

- [business_unit_list](#BKMK_business_unit_list)
- [lk_list_createdby](#BKMK_lk_list_createdby)
- [lk_list_createdonbehalfby](#BKMK_lk_list_createdonbehalfby)
- [lk_list_modifiedby](#BKMK_lk_list_modifiedby)
- [lk_list_modifiedonbehalfby](#BKMK_lk_list_modifiedonbehalfby)
- [owner_lists](#BKMK_owner_lists)
- [processstage_lists](#BKMK_processstage_lists)
- [team_list](#BKMK_team_list)
- [transactioncurrency_list](#BKMK_transactioncurrency_list)
- [user_list](#BKMK_user_list)

### <a name="BKMK_business_unit_list"></a> business_unit_list

One-To-Many Relationship: [businessunit business_unit_list](businessunit.md#BKMK_business_unit_list)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_list_createdby"></a> lk_list_createdby

One-To-Many Relationship: [systemuser lk_list_createdby](systemuser.md#BKMK_lk_list_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_list_createdonbehalfby"></a> lk_list_createdonbehalfby

One-To-Many Relationship: [systemuser lk_list_createdonbehalfby](systemuser.md#BKMK_lk_list_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_list_modifiedby"></a> lk_list_modifiedby

One-To-Many Relationship: [systemuser lk_list_modifiedby](systemuser.md#BKMK_lk_list_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_list_modifiedonbehalfby"></a> lk_list_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_list_modifiedonbehalfby](systemuser.md#BKMK_lk_list_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_lists"></a> owner_lists

One-To-Many Relationship: [owner owner_lists](owner.md#BKMK_owner_lists)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_lists"></a> processstage_lists

One-To-Many Relationship: [processstage processstage_lists](processstage.md#BKMK_processstage_lists)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid_processstage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_list"></a> team_list

One-To-Many Relationship: [team team_list](team.md#BKMK_team_list)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_transactioncurrency_list"></a> transactioncurrency_list

One-To-Many Relationship: [transactioncurrency transactioncurrency_list](transactioncurrency.md#BKMK_transactioncurrency_list)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_list"></a> user_list

One-To-Many Relationship: [systemuser user_list](systemuser.md#BKMK_user_list)

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

- [List_Annotation](#BKMK_List_Annotation)
- [List_AsyncOperations](#BKMK_List_AsyncOperations)
- [List_BulkDeleteFailures](#BKMK_List_BulkDeleteFailures)
- [List_BulkOperations](#BKMK_List_BulkOperations)
- [list_connections1](#BKMK_list_connections1)
- [list_connections2](#BKMK_list_connections2)
- [List_DuplicateBaseRecord](#BKMK_List_DuplicateBaseRecord)
- [List_DuplicateMatchingRecord](#BKMK_List_DuplicateMatchingRecord)
- [list_listoperation_ListId](#BKMK_list_listoperation_ListId)
- [list_MailboxTrackingFolders](#BKMK_list_MailboxTrackingFolders)
- [list_principalobjectattributeaccess](#BKMK_list_principalobjectattributeaccess)
- [List_ProcessSessions](#BKMK_List_ProcessSessions)
- [List_SyncErrors](#BKMK_List_SyncErrors)

### <a name="BKMK_List_Annotation"></a> List_Annotation

Many-To-One Relationship: [annotation List_Annotation](annotation.md#BKMK_List_Annotation)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`List_Annotation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_List_AsyncOperations"></a> List_AsyncOperations

Many-To-One Relationship: [asyncoperation List_AsyncOperations](asyncoperation.md#BKMK_List_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`List_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_List_BulkDeleteFailures"></a> List_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure List_BulkDeleteFailures](bulkdeletefailure.md#BKMK_List_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`List_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_List_BulkOperations"></a> List_BulkOperations

Many-To-One Relationship: [bulkoperation List_BulkOperations](bulkoperation.md#BKMK_List_BulkOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`List_BulkOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `BulkOperation.RetrieveMiniCampaignsForList`<br />ViewId: `83dc2389-0a4c-4249-a5d3-ba1ab401ff1c`|

### <a name="BKMK_list_connections1"></a> list_connections1

Many-To-One Relationship: [connection list_connections1](connection.md#BKMK_list_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`list_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_list_connections2"></a> list_connections2

Many-To-One Relationship: [connection list_connections2](connection.md#BKMK_list_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`list_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_List_DuplicateBaseRecord"></a> List_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord List_DuplicateBaseRecord](duplicaterecord.md#BKMK_List_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`List_DuplicateBaseRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_List_DuplicateMatchingRecord"></a> List_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord List_DuplicateMatchingRecord](duplicaterecord.md#BKMK_List_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`List_DuplicateMatchingRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_list_listoperation_ListId"></a> list_listoperation_ListId

Many-To-One Relationship: [listoperation list_listoperation_ListId](listoperation.md#BKMK_list_listoperation_ListId)

|Property|Value|
|---|---|
|ReferencingEntity|`listoperation`|
|ReferencingAttribute|`listid`|
|ReferencedEntityNavigationPropertyName|`list_listoperation_ListId`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_list_MailboxTrackingFolders"></a> list_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder list_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_list_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`list_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_list_principalobjectattributeaccess"></a> list_principalobjectattributeaccess

Many-To-One Relationship: [principalobjectattributeaccess list_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_list_principalobjectattributeaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`list_principalobjectattributeaccess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_List_ProcessSessions"></a> List_ProcessSessions

Many-To-One Relationship: [processsession List_ProcessSessions](processsession.md#BKMK_List_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`List_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_List_SyncErrors"></a> List_SyncErrors

Many-To-One Relationship: [syncerror List_SyncErrors](syncerror.md#BKMK_List_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`List_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [campaignactivitylist_association](#BKMK_campaignactivitylist_association)
- [campaignlist_association](#BKMK_campaignlist_association)
- [listaccount_association](#BKMK_listaccount_association)
- [listcontact_association](#BKMK_listcontact_association)
- [listlead_association](#BKMK_listlead_association)

### <a name="BKMK_campaignactivitylist_association"></a> campaignactivitylist_association

See [campaignactivity campaignactivitylist_association Many-To-Many Relationship](campaignactivity.md#BKMK_campaignactivitylist_association)

|Property|Value|
|---|---|
|IntersectEntityName|`campaignactivityitem`|
|IsCustomizable|False|
|SchemaName|`campaignactivitylist_association`|
|IntersectAttribute|`itemid`|
|NavigationPropertyName|`campaignactivitylist_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignlist_association"></a> campaignlist_association

See [campaign campaignlist_association Many-To-Many Relationship](campaign.md#BKMK_campaignlist_association)

|Property|Value|
|---|---|
|IntersectEntityName|`campaignitem`|
|IsCustomizable|False|
|SchemaName|`campaignlist_association`|
|IntersectAttribute|`entityid`|
|NavigationPropertyName|`campaignlist_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_listaccount_association"></a> listaccount_association

See [account listaccount_association Many-To-Many Relationship](account.md#BKMK_listaccount_association)

|Property|Value|
|---|---|
|IntersectEntityName|`listmember`|
|IsCustomizable|False|
|SchemaName|`listaccount_association`|
|IntersectAttribute|`listid`|
|NavigationPropertyName|`listaccount_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Marketing`<br />Label: <br />MenuId: null<br />Order: 10<br />QueryApi: `List.RetrieveListsForMember`<br />ViewId: `bdd93547-53f6-4609-b591-9f48ce86295f`|

### <a name="BKMK_listcontact_association"></a> listcontact_association

See [contact listcontact_association Many-To-Many Relationship](contact.md#BKMK_listcontact_association)

|Property|Value|
|---|---|
|IntersectEntityName|`listmember`|
|IsCustomizable|False|
|SchemaName|`listcontact_association`|
|IntersectAttribute|`listid`|
|NavigationPropertyName|`listcontact_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Marketing`<br />Label: <br />MenuId: null<br />Order: 10<br />QueryApi: `List.RetrieveListsForMember`<br />ViewId: `bdd93547-53f6-4609-b591-9f48ce86295f`|

### <a name="BKMK_listlead_association"></a> listlead_association

See [lead listlead_association Many-To-Many Relationship](lead.md#BKMK_listlead_association)

|Property|Value|
|---|---|
|IntersectEntityName|`listmember`|
|IsCustomizable|False|
|SchemaName|`listlead_association`|
|IntersectAttribute|`listid`|
|NavigationPropertyName|`listlead_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Marketing`<br />Label: <br />MenuId: null<br />Order: 10<br />QueryApi: `List.RetrieveListsForMember`<br />ViewId: `bdd93547-53f6-4609-b591-9f48ce86295f`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

