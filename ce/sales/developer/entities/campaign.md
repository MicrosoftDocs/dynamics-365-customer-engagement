---
title: "Campaign table/entity reference (Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Campaign table/entity."
ms.date: 02/17/2023
ms.service: dynamics-365-sales
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "udaykirang"
ms.author: "udag"
manager: "shujoshi"
search.audienceType: 
  - developer
search.app: 
  - PowerApps
  - D365CE
---

# Campaign table/entity reference

> [!NOTE]
> Unsure about table vs. entity? See [Developers: Understand terminology in Microsoft Dataverse](/powerapps/developer/data-platform/understand-terminology).

Container for campaign activities and responses, sales literature, products, and lists to create, plan, execute, and track the results of a specific marketing campaign through its life.

**Added by**: Marketing Solution


## Messages

|Message|SDK Assembly|
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

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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
- [msdyn_gdproptout](#BKMK_msdyn_gdproptout)
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
- [TmpRegardingObjectId](#BKMK_TmpRegardingObjectId)
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
|IsPrimaryImage|True|
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


### <a name="BKMK_msdyn_gdproptout"></a> msdyn_gdproptout

**Added by**: Predictive Opportunity Scoring Solution

|Property|Value|
|--------|-----|
|Description|Describes whether campaign is opted out or not|
|DisplayName|GDPR Optout|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_gdproptout|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_gdproptout Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



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
|DisplayName|(Deprecated) Stage Id|
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


### <a name="BKMK_TmpRegardingObjectId"></a> TmpRegardingObjectId

**Added by**: Marketing Patch Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|TmpRegardingObjectId|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|tmpregardingobjectid|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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
|DisplayName|(Deprecated) Traversed Path|
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

## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

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
- [OwningBusinessUnitName](#BKMK_OwningBusinessUnitName)
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
|MinValue|0.000000000001|
|Precision|12|
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
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningBusinessUnitName"></a> OwningBusinessUnitName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunitname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


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

- [Campaign_CampaignActivities](#BKMK_Campaign_CampaignActivities)
- [Campaign_CampaignResponses](#BKMK_Campaign_CampaignResponses)
- [campaign_leads](#BKMK_campaign_leads)
- [campaign_OpportunityCloses](#BKMK_campaign_OpportunityCloses)
- [campaign_OrderCloses](#BKMK_campaign_OrderCloses)
- [campaign_QuoteCloses](#BKMK_campaign_QuoteCloses)
- [campaign_opportunities](#BKMK_campaign_opportunities)
- [campaign_orders](#BKMK_campaign_orders)
- [campaign_quotes](#BKMK_campaign_quotes)


### <a name="BKMK_Campaign_CampaignActivities"></a> Campaign_CampaignActivities

Same as the [Campaign_CampaignActivities](campaignactivity.md#BKMK_Campaign_CampaignActivities) many-to-one relationship for the [campaignactivity](campaignactivity.md) table/entity.

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

Same as the [Campaign_CampaignResponses](campaignresponse.md#BKMK_Campaign_CampaignResponses) many-to-one relationship for the [campaignresponse](campaignresponse.md) table/entity.

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

Same as the [campaign_leads](lead.md#BKMK_campaign_leads) many-to-one relationship for the [lead](lead.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|lead|
|ReferencingAttribute|campaignid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaign_leads|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Marketing<br />Label: <br />Order: 130|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_campaign_OpportunityCloses"></a> campaign_OpportunityCloses

**Added by**: Sales Solution

Same as the [campaign_OpportunityCloses](opportunityclose.md#BKMK_campaign_OpportunityCloses) many-to-one relationship for the [opportunityclose](opportunityclose.md) table/entity.

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

Same as the [campaign_OrderCloses](orderclose.md#BKMK_campaign_OrderCloses) many-to-one relationship for the [orderclose](orderclose.md) table/entity.

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

Same as the [campaign_QuoteCloses](quoteclose.md#BKMK_campaign_QuoteCloses) many-to-one relationship for the [quoteclose](quoteclose.md) table/entity.

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

Same as the [campaign_opportunities](opportunity.md#BKMK_campaign_opportunities) many-to-one relationship for the [opportunity](opportunity.md) table/entity.

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

Same as the [campaign_orders](salesorder.md#BKMK_campaign_orders) many-to-one relationship for the [salesorder](salesorder.md) table/entity.

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

Same as the [campaign_quotes](quote.md#BKMK_campaign_quotes) many-to-one relationship for the [quote](quote.md) table/entity.

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

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related table. Listed by **SchemaName**.


### <a name="BKMK_PriceList_Campaigns"></a> PriceList_Campaigns

**Added by**: Product Management Solution

See the [PriceList_Campaigns](pricelevel.md#BKMK_PriceList_Campaigns) one-to-many relationship for the [pricelevel](pricelevel.md) table/entity.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the Campaign table is the first table in the relationship. Listed by **SchemaName**.

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

[About the table reference](../about-entity-reference.md)<br />
[Web API Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)<br />