---
title: "Campaign entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the Campaign entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# Campaign entity reference

Container for campaign activities and responses, sales literature, products, and lists to create, plan, execute, and track the results of a specific marketing campaign through its life.

**Added by**: Marketing Solution


## Messages

|Message|SDK class or method|
|-|-|
|AddItemCampaign|<xref:Microsoft.Crm.Sdk.Messages.AddItemCampaignRequest>|
|AddItemCampaignActivity|<xref:Microsoft.Crm.Sdk.Messages.AddItemCampaignActivityRequest>|
|Assign|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|CopyCampaign|<xref:Microsoft.Crm.Sdk.Messages.CopyCampaignRequest>|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|RemoveItemCampaign|<xref:Microsoft.Crm.Sdk.Messages.RemoveItemCampaignRequest>|
|RemoveItemCampaignActivity|<xref:Microsoft.Crm.Sdk.Messages.RemoveItemCampaignActivityRequest>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Campaigns|
|DisplayCollectionName|Campaigns|
|DisplayName|Campaign|
|EntitySetName|campaigns|
|IsBPFEntity|False|
|LogicalCollectionName|campaigns|
|LogicalName|campaign|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|campaignid|
|PrimaryNameAttribute|name|
|SchemaName|Campaign|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActualEnd](#BKMK_ActualEnd)
- [ActualStart](#BKMK_ActualStart)
- [BudgetedCost](#BKMK_BudgetedCost)
- [CampaignId](#BKMK_CampaignId)
- [CodeName](#BKMK_CodeName)
- [Description](#BKMK_Description)
- [EmailAddress](#BKMK_EmailAddress)
- [EntityImage](#BKMK_EntityImage)
- [ExpectedResponse](#BKMK_ExpectedResponse)
- [ExpectedRevenue](#BKMK_ExpectedRevenue)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsTemplate](#BKMK_IsTemplate)
- [Message](#BKMK_Message)
- [Name](#BKMK_Name)
- [Objective](#BKMK_Objective)
- [OtherCost](#BKMK_OtherCost)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [PriceListId](#BKMK_PriceListId)
- [ProcessId](#BKMK_ProcessId)
- [PromotionCodeName](#BKMK_PromotionCodeName)
- [ProposedEnd](#BKMK_ProposedEnd)
- [ProposedStart](#BKMK_ProposedStart)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [TypeCode](#BKMK_TypeCode)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ActualEnd"></a> ActualEnd

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date when the campaign was closed or completed.|
|DisplayName|Actual End Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualend|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ActualStart"></a> ActualStart

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the actual start date and time for the campaign.|
|DisplayName|Actual Start Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualstart|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_BudgetedCost"></a> BudgetedCost

|Property|Value|
|--------|-----|
|Description|Type the amount budgeted for the campaign to define a limit for how much you can spend.|
|DisplayName|Budget Allocated|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|budgetedcost|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_CampaignId"></a> CampaignId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the campaign.|
|DisplayName|Campaign|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|campaignid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_CodeName"></a> CodeName

|Property|Value|
|--------|-----|
|Description|Type a number or other tracking code to identify the campaign. If no value is entered, a code will be generated automatically.|
|DisplayName|Campaign Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|codename|
|MaxLength|32|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the campaign, such as the products or services offered or the targeted audience.|
|DisplayName|Description|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_EmailAddress"></a> EmailAddress

|Property|Value|
|--------|-----|
|Description|The primary email address for the entity.|
|DisplayName|Email Address|
|FormatName|Email|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|emailaddress|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EntityImage"></a> EntityImage

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|The default image for the entity.|
|DisplayName|Entity Image|
|IsPrimaryImage|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage|
|MaxHeight|144|
|MaxWidth|144|
|RequiredLevel|None|
|Type|Image|


### <a name="BKMK_ExpectedResponse"></a> ExpectedResponse

|Property|Value|
|--------|-----|
|Description|Type the expected response rate for the campaign as a full number between 0 and 100.|
|DisplayName|Expected Response Percentage|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|expectedresponse|
|MaxValue|100|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ExpectedRevenue"></a> ExpectedRevenue

|Property|Value|
|--------|-----|
|Description|Type the expected revenue for the campaign for return on investment projections and post-campaign reporting.|
|DisplayName|Estimated Revenue|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|expectedrevenue|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


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


### <a name="BKMK_IsTemplate"></a> IsTemplate

|Property|Value|
|--------|-----|
|Description|Select whether the campaign is a template that can be copied when you create future campaigns.|
|DisplayName|Template|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|istemplate|
|RequiredLevel|None|
|Type|Boolean|

#### IsTemplate Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_Message"></a> Message

|Property|Value|
|--------|-----|
|Description|Type the promotional message or marketing copy for the campaign.|
|DisplayName|Message|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|message|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Type a name for the campaign so that it is identified correctly in lists.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|128|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_Objective"></a> Objective

|Property|Value|
|--------|-----|
|Description|Type the objective of the campaign, including products, services, discounts, and pricing.|
|DisplayName|Offer|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|objective|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_OtherCost"></a> OtherCost

|Property|Value|
|--------|-----|
|Description|Type the sum of any miscellaneous campaign costs not included in the campaign activities to make sure the actual cost of the campaign is calculated correctly.|
|DisplayName|Miscellaneous Costs|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|othercost|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


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


### <a name="BKMK_PriceListId"></a> PriceListId

|Property|Value|
|--------|-----|
|Description|Choose the price list associated with this item to make sure the products associated with the campaign are offered at the correct prices.|
|DisplayName|Price List|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|pricelistid|
|RequiredLevel|None|
|Targets|pricelevel|
|Type|Lookup|


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


### <a name="BKMK_PromotionCodeName"></a> PromotionCodeName

|Property|Value|
|--------|-----|
|Description|Type a promotional code to track sales related to the campaign or allow customers to redeem a discount offer.|
|DisplayName|Promotion Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|promotioncodename|
|MaxLength|128|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ProposedEnd"></a> ProposedEnd

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date when the campaign is scheduled to end.|
|DisplayName|Proposed End Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|proposedend|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ProposedStart"></a> ProposedStart

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date when the campaign is scheduled to start.|
|DisplayName|Proposed Start Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|proposedstart|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|--------|-----|
|Description|Contains the id of the stage where the entity is located.|
|DisplayName|Stage Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows the status of the campaign. By default, campaigns are active and can't be deactivated.|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Choices/Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|0|Active|
|1|Inactive|6|Inactive|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the campaign's status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Choices/Options

|Value|Label|State|
|-----|-----|-----|
|0|Proposed|0|
|1|Ready To Launch|0|
|2|Launched|0|
|3|Completed|0|
|4|Canceled|0|
|5|Suspended|0|
|6|Inactive|1|



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
|IsValidForUpdate|False|
|LogicalName|transactioncurrencyid|
|RequiredLevel|ApplicationRequired|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|--------|-----|
|Description|A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.|
|DisplayName|Traversed Path|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|traversedpath|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TypeCode"></a> TypeCode

|Property|Value|
|--------|-----|
|Description|Select the type of the campaign.|
|DisplayName|Campaign Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|typecode|
|RequiredLevel|None|
|Type|Picklist|

#### TypeCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Advertisement||
|2|Direct Marketing||
|3|Event||
|4|Co-branding||
|5|Other||



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

- [BudgetedCost_Base](#BKMK_BudgetedCost_Base)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ExpectedRevenue_Base](#BKMK_ExpectedRevenue_Base)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OtherCost_Base](#BKMK_OtherCost_Base)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [PriceListName](#BKMK_PriceListName)
- [TotalActualCost](#BKMK_TotalActualCost)
- [TotalActualCost_Base](#BKMK_TotalActualCost_Base)
- [TotalCampaignActivityActualCost](#BKMK_TotalCampaignActivityActualCost)
- [TotalCampaignActivityActualCost_Base](#BKMK_TotalCampaignActivityActualCost_Base)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_BudgetedCost_Base"></a> BudgetedCost_Base

|Property|Value|
|--------|-----|
|Description|Value of the Budget Allocated in base currency.|
|DisplayName|Budget Allocated (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|budgetedcost_base|
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


### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage_timestamp|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|


### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Url|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage_url|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


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


### <a name="BKMK_ExpectedRevenue_Base"></a> ExpectedRevenue_Base

|Property|Value|
|--------|-----|
|Description|Value of the Estimated Revenue in base currency.|
|DisplayName|Estimated Revenue (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|expectedrevenue_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


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
|Description|Shows who created the record on behalf of another user.|
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


### <a name="BKMK_OtherCost_Base"></a> OtherCost_Base

|Property|Value|
|--------|-----|
|Description|Value of the Miscellaneous Costs in base currency.|
|DisplayName|Miscellaneous Costs (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|othercost_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


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


### <a name="BKMK_PriceListName"></a> PriceListName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|pricelistname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_TotalActualCost"></a> TotalActualCost

|Property|Value|
|--------|-----|
|Description|Shows the sum of the amounts entered in the Total Cost of Campaign Activities and Miscellaneous Costs fields.|
|DisplayName|Total Cost of Campaign|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalactualcost|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalActualCost_Base"></a> TotalActualCost_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Cost of Campaign in base currency.|
|DisplayName|Total Cost of Campaign (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalactualcost_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalCampaignActivityActualCost"></a> TotalCampaignActivityActualCost

|Property|Value|
|--------|-----|
|Description|Shows the sum of the values entered in the Actual Cost field on all campaign activities related to the campaign.|
|DisplayName|Total Cost of Campaign Activities|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalcampaignactivityactualcost|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalCampaignActivityActualCost_Base"></a> TotalCampaignActivityActualCost_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Cost of Campaign Activities in base currency.|
|DisplayName|Total Cost of Campaign Activities (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalcampaignactivityactualcost_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


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

- [Campaign_ActivityPointers](#BKMK_Campaign_ActivityPointers)
- [Campaign_SyncErrors](#BKMK_Campaign_SyncErrors)
- [campaign_activity_parties](#BKMK_campaign_activity_parties)
- [Campaign_DuplicateMatchingRecord](#BKMK_Campaign_DuplicateMatchingRecord)
- [Campaign_DuplicateBaseRecord](#BKMK_Campaign_DuplicateBaseRecord)
- [Campaign_AsyncOperations](#BKMK_Campaign_AsyncOperations)
- [Campaign_MailboxTrackingFolder](#BKMK_Campaign_MailboxTrackingFolder)
- [Campaign_ProcessSessions](#BKMK_Campaign_ProcessSessions)
- [Campaign_BulkDeleteFailures](#BKMK_Campaign_BulkDeleteFailures)
- [campaign_principalobjectattributeaccess](#BKMK_campaign_principalobjectattributeaccess)
- [Campaign_Appointments](#BKMK_Campaign_Appointments)
- [Campaign_Emails](#BKMK_Campaign_Emails)
- [Campaign_Faxes](#BKMK_Campaign_Faxes)
- [Campaign_Letters](#BKMK_Campaign_Letters)
- [Campaign_Phonecalls](#BKMK_Campaign_Phonecalls)
- [Campaign_Tasks](#BKMK_Campaign_Tasks)
- [Campaign_RecurringAppointmentMasters](#BKMK_Campaign_RecurringAppointmentMasters)
- [campaign_SocialActivities](#BKMK_campaign_SocialActivities)
- [campaign_connections1](#BKMK_campaign_connections1)
- [campaign_connections2](#BKMK_campaign_connections2)
- [Campaign_Annotation](#BKMK_Campaign_Annotation)
- [Campaign_CampaignActivities](#BKMK_Campaign_CampaignActivities)
- [Campaign_CampaignResponses](#BKMK_Campaign_CampaignResponses)
- [campaign_leads](#BKMK_campaign_leads)
- [campaign_IncidentResolutions](#BKMK_campaign_IncidentResolutions)
- [Campaign_ServiceAppointments](#BKMK_Campaign_ServiceAppointments)
- [campaign_OpportunityCloses](#BKMK_campaign_OpportunityCloses)
- [campaign_OrderCloses](#BKMK_campaign_OrderCloses)
- [campaign_QuoteCloses](#BKMK_campaign_QuoteCloses)
- [campaign_opportunities](#BKMK_campaign_opportunities)
- [campaign_orders](#BKMK_campaign_orders)
- [campaign_quotes](#BKMK_campaign_quotes)


### <a name="BKMK_Campaign_ActivityPointers"></a> Campaign_ActivityPointers

**Added by**: System Solution Solution

Same as the [Campaign_ActivityPointers](activitypointer.md#BKMK_Campaign_ActivityPointers) many-to-one relationship for the [activitypointer](activitypointer.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Campaign_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Campaign_SyncErrors"></a> Campaign_SyncErrors

**Added by**: System Solution Solution

Same as the [Campaign_SyncErrors](syncerror.md#BKMK_Campaign_SyncErrors) many-to-one relationship for the [syncerror](syncerror.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Campaign_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_campaign_activity_parties"></a> campaign_activity_parties

**Added by**: System Solution Solution

Same as the [campaign_activity_parties](activityparty.md#BKMK_campaign_activity_parties) many-to-one relationship for the [activityparty](activityparty.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|activityparty|
|ReferencingAttribute|partyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|campaign_activity_parties|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Campaign_DuplicateMatchingRecord"></a> Campaign_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as the [Campaign_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Campaign_DuplicateMatchingRecord) many-to-one relationship for the [duplicaterecord](duplicaterecord.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Campaign_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Campaign_DuplicateBaseRecord"></a> Campaign_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as the [Campaign_DuplicateBaseRecord](duplicaterecord.md#BKMK_Campaign_DuplicateBaseRecord) many-to-one relationship for the [duplicaterecord](duplicaterecord.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Campaign_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Campaign_AsyncOperations"></a> Campaign_AsyncOperations

**Added by**: System Solution Solution

Same as the [Campaign_AsyncOperations](asyncoperation.md#BKMK_Campaign_AsyncOperations) many-to-one relationship for the [asyncoperation](asyncoperation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Campaign_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Campaign_MailboxTrackingFolder"></a> Campaign_MailboxTrackingFolder

**Added by**: System Solution Solution

Same as the [Campaign_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_Campaign_MailboxTrackingFolder) many-to-one relationship for the [mailboxtrackingfolder](mailboxtrackingfolder.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Campaign_MailboxTrackingFolder|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Campaign_ProcessSessions"></a> Campaign_ProcessSessions

**Added by**: System Solution Solution

Same as the [Campaign_ProcessSessions](processsession.md#BKMK_Campaign_ProcessSessions) many-to-one relationship for the [processsession](processsession.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Campaign_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Campaign_BulkDeleteFailures"></a> Campaign_BulkDeleteFailures

**Added by**: System Solution Solution

Same as the [Campaign_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Campaign_BulkDeleteFailures) many-to-one relationship for the [bulkdeletefailure](bulkdeletefailure.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Campaign_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_campaign_principalobjectattributeaccess"></a> campaign_principalobjectattributeaccess

**Added by**: System Solution Solution

Same as the [campaign_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_campaign_principalobjectattributeaccess) many-to-one relationship for the [principalobjectattributeaccess](principalobjectattributeaccess.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|campaign_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Campaign_Appointments"></a> Campaign_Appointments

**Added by**: System Solution Solution

Same as the [Campaign_Appointments](appointment.md#BKMK_Campaign_Appointments) many-to-one relationship for the [appointment](appointment.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Campaign_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Campaign_Emails"></a> Campaign_Emails

**Added by**: System Solution Solution

Same as the [Campaign_Emails](email.md#BKMK_Campaign_Emails) many-to-one relationship for the [email](email.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Campaign_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Campaign_Faxes"></a> Campaign_Faxes

**Added by**: System Solution Solution

Same as the [Campaign_Faxes](fax.md#BKMK_Campaign_Faxes) many-to-one relationship for the [fax](fax.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Campaign_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Campaign_Letters"></a> Campaign_Letters

**Added by**: System Solution Solution

Same as the [Campaign_Letters](letter.md#BKMK_Campaign_Letters) many-to-one relationship for the [letter](letter.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Campaign_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Campaign_Phonecalls"></a> Campaign_Phonecalls

**Added by**: System Solution Solution

Same as the [Campaign_Phonecalls](phonecall.md#BKMK_Campaign_Phonecalls) many-to-one relationship for the [phonecall](phonecall.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Campaign_Phonecalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Campaign_Tasks"></a> Campaign_Tasks

**Added by**: System Solution Solution

Same as the [Campaign_Tasks](task.md#BKMK_Campaign_Tasks) many-to-one relationship for the [task](task.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Campaign_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Campaign_RecurringAppointmentMasters"></a> Campaign_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as the [Campaign_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_Campaign_RecurringAppointmentMasters) many-to-one relationship for the [recurringappointmentmaster](recurringappointmentmaster.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Campaign_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_campaign_SocialActivities"></a> campaign_SocialActivities

**Added by**: System Solution Solution

Same as the [campaign_SocialActivities](socialactivity.md#BKMK_campaign_SocialActivities) many-to-one relationship for the [socialactivity](socialactivity.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaign_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_campaign_connections1"></a> campaign_connections1

**Added by**: System Solution Solution

Same as the [campaign_connections1](connection.md#BKMK_campaign_connections1) many-to-one relationship for the [connection](connection.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaign_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_campaign_connections2"></a> campaign_connections2

**Added by**: System Solution Solution

Same as the [campaign_connections2](connection.md#BKMK_campaign_connections2) many-to-one relationship for the [connection](connection.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaign_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Campaign_Annotation"></a> Campaign_Annotation

**Added by**: System Solution Solution

Same as the [Campaign_Annotation](annotation.md#BKMK_Campaign_Annotation) many-to-one relationship for the [annotation](annotation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Campaign_Annotation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Campaign_CampaignActivities"></a> Campaign_CampaignActivities

Same as the [Campaign_CampaignActivities](campaignactivity.md#BKMK_Campaign_CampaignActivities) many-to-one relationship for the [campaignactivity](campaignactivity.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Campaign_CampaignActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Campaign_CampaignResponses"></a> Campaign_CampaignResponses

Same as the [Campaign_CampaignResponses](campaignresponse.md#BKMK_Campaign_CampaignResponses) many-to-one relationship for the [campaignresponse](campaignresponse.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Campaign_CampaignResponses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_campaign_leads"></a> campaign_leads

Same as the [campaign_leads](lead.md#BKMK_campaign_leads) many-to-one relationship for the [lead](lead.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|lead|
|ReferencingAttribute|campaignid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaign_leads|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Marketing<br />Label: <br />Order: 130|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_campaign_IncidentResolutions"></a> campaign_IncidentResolutions

**Added by**: Service Solution

Same as the [campaign_IncidentResolutions](incidentresolution.md#BKMK_campaign_IncidentResolutions) many-to-one relationship for the [incidentresolution](incidentresolution.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|incidentresolution|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaign_IncidentResolutions|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Campaign_ServiceAppointments"></a> Campaign_ServiceAppointments

**Added by**: Service Solution

Same as the [Campaign_ServiceAppointments](serviceappointment.md#BKMK_Campaign_ServiceAppointments) many-to-one relationship for the [serviceappointment](serviceappointment.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Campaign_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: RemoveLink<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_campaign_OpportunityCloses"></a> campaign_OpportunityCloses

**Added by**: Sales Solution

Same as the [campaign_OpportunityCloses](opportunityclose.md#BKMK_campaign_OpportunityCloses) many-to-one relationship for the [opportunityclose](opportunityclose.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaign_OpportunityCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_campaign_OrderCloses"></a> campaign_OrderCloses

**Added by**: Sales Solution

Same as the [campaign_OrderCloses](orderclose.md#BKMK_campaign_OrderCloses) many-to-one relationship for the [orderclose](orderclose.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaign_OrderCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_campaign_QuoteCloses"></a> campaign_QuoteCloses

**Added by**: Sales Solution

Same as the [campaign_QuoteCloses](quoteclose.md#BKMK_campaign_QuoteCloses) many-to-one relationship for the [quoteclose](quoteclose.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaign_QuoteCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_campaign_opportunities"></a> campaign_opportunities

**Added by**: Marketing Sales Solution

Same as the [campaign_opportunities](opportunity.md#BKMK_campaign_opportunities) many-to-one relationship for the [opportunity](opportunity.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunity|
|ReferencingAttribute|campaignid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaign_opportunities|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Sales<br />Label: <br />Order: 130|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_campaign_orders"></a> campaign_orders

**Added by**: Marketing Sales Solution

Same as the [campaign_orders](salesorder.md#BKMK_campaign_orders) many-to-one relationship for the [salesorder](salesorder.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorder|
|ReferencingAttribute|campaignid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaign_orders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_campaign_quotes"></a> campaign_quotes

**Added by**: Marketing Sales Solution

Same as the [campaign_quotes](quote.md#BKMK_campaign_quotes) many-to-one relationship for the [quote](quote.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quote|
|ReferencingAttribute|campaignid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaign_quotes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_campaign_createdby](#BKMK_lk_campaign_createdby)
- [lk_campaign_createdonbehalfby](#BKMK_lk_campaign_createdonbehalfby)
- [lk_campaign_modifiedby](#BKMK_lk_campaign_modifiedby)
- [lk_campaign_modifiedonbehalfby](#BKMK_lk_campaign_modifiedonbehalfby)
- [SystemUser_Campaigns](#BKMK_SystemUser_Campaigns)
- [team_Campaigns](#BKMK_team_Campaigns)
- [BusinessUnit_Campaigns](#BKMK_BusinessUnit_Campaigns)
- [processstage_campaigns](#BKMK_processstage_campaigns)
- [transactioncurrency_campaign](#BKMK_transactioncurrency_campaign)
- [PriceList_Campaigns](#BKMK_PriceList_Campaigns)


### <a name="BKMK_lk_campaign_createdby"></a> lk_campaign_createdby

**Added by**: System Solution Solution

See the [lk_campaign_createdby](systemuser.md#BKMK_lk_campaign_createdby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_campaign_createdonbehalfby"></a> lk_campaign_createdonbehalfby

**Added by**: System Solution Solution

See the [lk_campaign_createdonbehalfby](systemuser.md#BKMK_lk_campaign_createdonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_campaign_modifiedby"></a> lk_campaign_modifiedby

**Added by**: System Solution Solution

See the [lk_campaign_modifiedby](systemuser.md#BKMK_lk_campaign_modifiedby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_campaign_modifiedonbehalfby"></a> lk_campaign_modifiedonbehalfby

**Added by**: System Solution Solution

See the [lk_campaign_modifiedonbehalfby](systemuser.md#BKMK_lk_campaign_modifiedonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_SystemUser_Campaigns"></a> SystemUser_Campaigns

**Added by**: System Solution Solution

See the [SystemUser_Campaigns](systemuser.md#BKMK_SystemUser_Campaigns) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_team_Campaigns"></a> team_Campaigns

**Added by**: System Solution Solution

See the [team_Campaigns](team.md#BKMK_team_Campaigns) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_BusinessUnit_Campaigns"></a> BusinessUnit_Campaigns

**Added by**: System Solution Solution

See the [BusinessUnit_Campaigns](businessunit.md#BKMK_BusinessUnit_Campaigns) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_processstage_campaigns"></a> processstage_campaigns

**Added by**: System Solution Solution

See the [processstage_campaigns](processstage.md#BKMK_processstage_campaigns) one-to-many relationship for the [processstage](processstage.md) entity.

### <a name="BKMK_transactioncurrency_campaign"></a> transactioncurrency_campaign

**Added by**: System Solution Solution

See the [transactioncurrency_campaign](transactioncurrency.md#BKMK_transactioncurrency_campaign) one-to-many relationship for the [transactioncurrency](transactioncurrency.md) entity.

### <a name="BKMK_PriceList_Campaigns"></a> PriceList_Campaigns

**Added by**: Product Management Solution

See the [PriceList_Campaigns](pricelevel.md#BKMK_PriceList_Campaigns) one-to-many relationship for the [pricelevel](pricelevel.md) entity.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the Campaign entity is the first entity in the relationship. Listed by **SchemaName**.

- [campaigncampaign_association](#BKMK_campaigncampaign_association)
- [campaignproduct_association](#BKMK_campaignproduct_association)
- [campaignlist_association](#BKMK_campaignlist_association)
- [campaignsalesliterature_association](#BKMK_campaignsalesliterature_association)


### <a name="BKMK_campaigncampaign_association"></a> campaigncampaign_association

IntersectEntityName: campaignitem<br />
#### Table 1

|Property|Value|
|--------|-----|
|IntersectAttribute|campaignid|
|IsCustomizable|False|
|LogicalName|campaign|
|NavigationPropertyName|campaigncampaign_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |

#### Table 2

|Property|Value|
|--------|-----|
|LogicalName|campaign|
|IntersectAttribute|entityid|
|NavigationPropertyName|campaigncampaign_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |


### <a name="BKMK_campaignproduct_association"></a> campaignproduct_association

IntersectEntityName: campaignitem<br />
#### Table 1

|Property|Value|
|--------|-----|
|IntersectAttribute|campaignid|
|IsCustomizable|False|
|LogicalName|campaign|
|NavigationPropertyName|campaignproduct_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |

#### Table 2

|Property|Value|
|--------|-----|
|LogicalName|product|
|IntersectAttribute|entityid|
|NavigationPropertyName|campaignproduct_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |


### <a name="BKMK_campaignlist_association"></a> campaignlist_association

IntersectEntityName: campaignitem<br />
#### Table 1

|Property|Value|
|--------|-----|
|IntersectAttribute|campaignid|
|IsCustomizable|False|
|LogicalName|campaign|
|NavigationPropertyName|campaignlist_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |

#### Table 2

|Property|Value|
|--------|-----|
|LogicalName|list|
|IntersectAttribute|entityid|
|NavigationPropertyName|campaignlist_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |


### <a name="BKMK_campaignsalesliterature_association"></a> campaignsalesliterature_association

IntersectEntityName: campaignitem<br />
#### Table 1

|Property|Value|
|--------|-----|
|IntersectAttribute|campaignid|
|IsCustomizable|False|
|LogicalName|campaign|
|NavigationPropertyName|campaignsalesliterature_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |

#### Table 2

|Property|Value|
|--------|-----|
|LogicalName|salesliterature|
|IntersectAttribute|entityid|
|NavigationPropertyName|campaignsalesliterature_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |


### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)
