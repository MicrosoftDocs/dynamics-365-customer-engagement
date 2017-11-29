---
title: "Campaign Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Campaign entity."
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
# Campaign Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Container for campaign activities and responses, sales literature, products, and lists to create, plan, execute, and track the results of a specific marketing campaign through its life.

**Added by**: Marketing Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|AddItemCampaign|<xref href="Microsoft.Dynamics.CRM.AddItemCampaign?text=AddItemCampaign Action" />|<xref:Microsoft.Crm.Sdk.Messages.AddItemCampaignRequest>|
|AddItemCampaignActivity|<xref href="Microsoft.Dynamics.CRM.AddItemCampaignActivity?text=AddItemCampaignActivity Action" />|<xref:Microsoft.Crm.Sdk.Messages.AddItemCampaignActivityRequest>|
|Assign|PATCH [*org URI*]/api/data/v9.0/campaigns(*campaignid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|CopyCampaign|<xref href="Microsoft.Dynamics.CRM.CopyCampaign?text=CopyCampaign Action" />|<xref:Microsoft.Crm.Sdk.Messages.CopyCampaignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/campaigns<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/campaigns(*campaignid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|RemoveItemCampaign|<xref href="Microsoft.Dynamics.CRM.RemoveItemCampaign?text=RemoveItemCampaign Action" />|<xref:Microsoft.Crm.Sdk.Messages.RemoveItemCampaignRequest>|
|RemoveItemCampaignActivity|<xref href="Microsoft.Dynamics.CRM.RemoveItemCampaignActivity?text=RemoveItemCampaignActivity Action" />|<xref:Microsoft.Crm.Sdk.Messages.RemoveItemCampaignActivityRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/campaigns(*campaignid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/campaigns<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/campaigns(*campaignid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/campaigns(*campaignid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Campaign<br />
**DisplayCollectionName**: Campaigns<br />
**SchemaName**: Campaign<br />
**CollectionSchemaName**: Campaigns<br />
**LogicalName**: campaign<br />
**LogicalCollectionName**: campaigns<br />
**EntitySetName**: campaigns<br />
**PrimaryIdAttribute**: campaignid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
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

**Description**: Enter the date when the campaign was closed or completed.<br />
**DisplayName**: Actual End Date<br />
**LogicalName**: actualend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ActualStart"></a> ActualStart

**Description**: Enter the actual start date and time for the campaign.<br />
**DisplayName**: Actual Start Date<br />
**LogicalName**: actualstart<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_BudgetedCost"></a> BudgetedCost

**Description**: Type the amount budgeted for the campaign to define a limit for how much you can spend.<br />
**DisplayName**: Budget Allocated<br />
**LogicalName**: budgetedcost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_CampaignId"></a> CampaignId

**Description**: Unique identifier of the campaign.<br />
**DisplayName**: Campaign<br />
**LogicalName**: campaignid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_CodeName"></a> CodeName

**Description**: Type a number or other tracking code to identify the campaign. If no value is entered, a code will be generated automatically.<br />
**DisplayName**: Campaign Code<br />
**LogicalName**: codename<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 32


### <a name="BKMK_Description"></a> Description

**Description**: Type additional information to describe the campaign, such as the products or services offered or the targeted audience.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_EmailAddress"></a> EmailAddress

**Description**: The primary email address for the entity.<br />
**DisplayName**: Email Address<br />
**LogicalName**: emailaddress<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Email<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_EntityImage"></a> EntityImage

**Description**: The default image for the entity.<br />
**DisplayName**: Entity Image<br />
**LogicalName**: entityimage<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Image<br />
**IsPrimaryImage**: False<br />
**MaxHeight**: 144<br />
**MaxWidth**: 144


### <a name="BKMK_ExpectedResponse"></a> ExpectedResponse

**Description**: Type the expected response rate for the campaign as a full number between 0 and 100.<br />
**DisplayName**: Expected Response Percentage<br />
**LogicalName**: expectedresponse<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 100<br />
**MinValue**: 0


### <a name="BKMK_ExpectedRevenue"></a> ExpectedRevenue

**Description**: Type the expected revenue for the campaign for return on investment projections and post-campaign reporting.<br />
**DisplayName**: Estimated Revenue<br />
**LogicalName**: expectedrevenue<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Sequence number of the import that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_IsTemplate"></a> IsTemplate

**Description**: Select whether the campaign is a template that can be copied when you create future campaigns.<br />
**DisplayName**: Template<br />
**LogicalName**: istemplate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_Message"></a> Message

**Description**: Type the promotional message or marketing copy for the campaign.<br />
**DisplayName**: Message<br />
**LogicalName**: message<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_Name"></a> Name

**Description**: Type a name for the campaign so that it is identified correctly in lists.<br />
**DisplayName**: Name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 128


### <a name="BKMK_Objective"></a> Objective

**Description**: Type the objective of the campaign, including products, services, discounts, and pricing.<br />
**DisplayName**: Offer<br />
**LogicalName**: objective<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_OtherCost"></a> OtherCost

**Description**: Type the sum of any miscellaneous campaign costs not included in the campaign activities to make sure the actual cost of the campaign is calculated correctly.<br />
**DisplayName**: Miscellaneous Costs<br />
**LogicalName**: othercost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Owner Id<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Owner Id Type<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_PriceListId"></a> PriceListId

**Description**: Choose the price list associated with this item to make sure the products associated with the campaign are offered at the correct prices.<br />
**DisplayName**: Price List<br />
**LogicalName**: pricelistid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: pricelevel


### <a name="BKMK_ProcessId"></a> ProcessId

**Description**: Contains the id of the process associated with the entity.<br />
**DisplayName**: Process Id<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_PromotionCodeName"></a> PromotionCodeName

**Description**: Type a promotional code to track sales related to the campaign or allow customers to redeem a discount offer.<br />
**DisplayName**: Promotion Code<br />
**LogicalName**: promotioncodename<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 128


### <a name="BKMK_ProposedEnd"></a> ProposedEnd

**Description**: Enter the date when the campaign is scheduled to end.<br />
**DisplayName**: Proposed End Date<br />
**LogicalName**: proposedend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ProposedStart"></a> ProposedStart

**Description**: Enter the date when the campaign is scheduled to start.<br />
**DisplayName**: Proposed Start Date<br />
**LogicalName**: proposedstart<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_StageId"></a> StageId

**Description**: Contains the id of the stage where the entity is located.<br />
**DisplayName**: Stage Id<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Shows the status of the campaign. By default, campaigns are active and can't be deactivated.<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 0 **InvariantName**: Active
- **Value**: 1 **Label**: Inactive **DefaultStatus**: 6 **InvariantName**: Inactive



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Select the campaign's status.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 0 **Label**: Proposed **State**: 0
- **Value**: 1 **Label**: Ready To Launch **State**: 0
- **Value**: 2 **Label**: Launched **State**: 0
- **Value**: 3 **Label**: Completed **State**: 0
- **Value**: 4 **Label**: Canceled **State**: 0
- **Value**: 5 **Label**: Suspended **State**: 0
- **Value**: 6 **Label**: Inactive **State**: 1



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: Time Zone Rule Version Number<br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Choose the local currency for the record to make sure budgets are reported in the correct currency.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_TraversedPath"></a> TraversedPath

**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />
**DisplayName**: Traversed Path<br />
**LogicalName**: traversedpath<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1250


### <a name="BKMK_TypeCode"></a> TypeCode

**Description**: Select the type of the campaign.<br />
**DisplayName**: Campaign Type<br />
**LogicalName**: typecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Advertisement
- **Value**: 2 **Label**: Direct Marketing
- **Value**: 3 **Label**: Event
- **Value**: 4 **Label**: Co-branding
- **Value**: 5 **Label**: Other



### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Time zone code that was in use when the record was created.<br />
**DisplayName**: UTC Conversion Time Zone Code<br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648

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

**Description**: Value of the Budget Allocated in base currency.<br />
**DisplayName**: Budget Allocated (Base)<br />
**LogicalName**: budgetedcost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Shows who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: Name of the user who created the campaign.<br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the record was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: entityimage_timestamp<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />


### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: entityimage_url<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Url<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_EntityImageId"></a> EntityImageId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: entityimageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />
**DisplayName**: Exchange Rate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


### <a name="BKMK_ExpectedRevenue_Base"></a> ExpectedRevenue_Base

**Description**: Value of the Estimated Revenue in base currency.<br />
**DisplayName**: Estimated Revenue (Base)<br />
**LogicalName**: expectedrevenue_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Shows who last updated the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: Name of the user who last modified the campaign.<br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Date and time when the record was modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OtherCost_Base"></a> OtherCost_Base

**Description**: Value of the Miscellaneous Costs in base currency.<br />
**DisplayName**: Miscellaneous Costs (Base)<br />
**LogicalName**: othercost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: Name of the owner<br />
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

**Description**: Yomi name of the owner<br />
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

**Description**: Unique identifier for the business unit that owns the record<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier for the team that owns the record.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier for the user that owns the record.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_PriceListName"></a> PriceListName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: pricelistname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_TotalActualCost"></a> TotalActualCost

**Description**: Shows the sum of the amounts entered in the Total Cost of Campaign Activities and Miscellaneous Costs fields.<br />
**DisplayName**: Total Cost of Campaign<br />
**LogicalName**: totalactualcost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_TotalActualCost_Base"></a> TotalActualCost_Base

**Description**: Value of the Total Cost of Campaign in base currency.<br />
**DisplayName**: Total Cost of Campaign (Base)<br />
**LogicalName**: totalactualcost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_TotalCampaignActivityActualCost"></a> TotalCampaignActivityActualCost

**Description**: Shows the sum of the values entered in the Actual Cost field on all campaign activities related to the campaign.<br />
**DisplayName**: Total Cost of Campaign Activities<br />
**LogicalName**: totalcampaignactivityactualcost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_TotalCampaignActivityActualCost_Base"></a> TotalCampaignActivityActualCost_Base

**Description**: Value of the Total Cost of Campaign Activities in base currency.<br />
**DisplayName**: Total Cost of Campaign Activities (Base)<br />
**LogicalName**: totalcampaignactivityactualcost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: transactioncurrencyidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version Number<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

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
- [userentityinstancedata_campaign](#BKMK_userentityinstancedata_campaign)
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
- [campaign_msdyn_bookingalerts](#BKMK_campaign_msdyn_bookingalerts)
- [campaign_msdyn_approvals](#BKMK_campaign_msdyn_approvals)


### <a name="BKMK_Campaign_ActivityPointers"></a> Campaign_ActivityPointers

Same as activitypointer entity [Campaign_ActivityPointers](activitypointer.md#BKMK_Campaign_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Campaign_ActivityPointers<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Campaign_SyncErrors"></a> Campaign_SyncErrors

Same as syncerror entity [Campaign_SyncErrors](syncerror.md#BKMK_Campaign_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Campaign_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_campaign_activity_parties"></a> campaign_activity_parties

Same as activityparty entity [campaign_activity_parties](activityparty.md#BKMK_campaign_activity_parties) Many-To-One relationship.

**ReferencingEntity**: activityparty<br />
**ReferencingAttribute**: partyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: campaign_activity_parties<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Campaign_DuplicateMatchingRecord"></a> Campaign_DuplicateMatchingRecord

Same as duplicaterecord entity [Campaign_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Campaign_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Campaign_DuplicateMatchingRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Campaign_DuplicateBaseRecord"></a> Campaign_DuplicateBaseRecord

Same as duplicaterecord entity [Campaign_DuplicateBaseRecord](duplicaterecord.md#BKMK_Campaign_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Campaign_DuplicateBaseRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Campaign_AsyncOperations"></a> Campaign_AsyncOperations

Same as asyncoperation entity [Campaign_AsyncOperations](asyncoperation.md#BKMK_Campaign_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Campaign_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Campaign_MailboxTrackingFolder"></a> Campaign_MailboxTrackingFolder

Same as mailboxtrackingfolder entity [Campaign_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_Campaign_MailboxTrackingFolder) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Campaign_MailboxTrackingFolder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_userentityinstancedata_campaign"></a> userentityinstancedata_campaign

Same as userentityinstancedata entity [userentityinstancedata_campaign](userentityinstancedata.md#BKMK_userentityinstancedata_campaign) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_campaign<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Campaign_ProcessSessions"></a> Campaign_ProcessSessions

Same as processsession entity [Campaign_ProcessSessions](processsession.md#BKMK_Campaign_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Campaign_ProcessSessions<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 110

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Campaign_BulkDeleteFailures"></a> Campaign_BulkDeleteFailures

Same as bulkdeletefailure entity [Campaign_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Campaign_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Campaign_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_campaign_principalobjectattributeaccess"></a> campaign_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [campaign_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_campaign_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: campaign_principalobjectattributeaccess<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Campaign_Appointments"></a> Campaign_Appointments

Same as appointment entity [Campaign_Appointments](appointment.md#BKMK_Campaign_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Campaign_Appointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Campaign_Emails"></a> Campaign_Emails

Same as email entity [Campaign_Emails](email.md#BKMK_Campaign_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Campaign_Emails<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Campaign_Faxes"></a> Campaign_Faxes

Same as fax entity [Campaign_Faxes](fax.md#BKMK_Campaign_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Campaign_Faxes<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Campaign_Letters"></a> Campaign_Letters

Same as letter entity [Campaign_Letters](letter.md#BKMK_Campaign_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Campaign_Letters<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Campaign_Phonecalls"></a> Campaign_Phonecalls

Same as phonecall entity [Campaign_Phonecalls](phonecall.md#BKMK_Campaign_Phonecalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Campaign_Phonecalls<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Campaign_Tasks"></a> Campaign_Tasks

Same as task entity [Campaign_Tasks](task.md#BKMK_Campaign_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Campaign_Tasks<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Campaign_RecurringAppointmentMasters"></a> Campaign_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [Campaign_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_Campaign_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Campaign_RecurringAppointmentMasters<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_campaign_SocialActivities"></a> campaign_SocialActivities

Same as socialactivity entity [campaign_SocialActivities](socialactivity.md#BKMK_campaign_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaign_SocialActivities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_campaign_connections1"></a> campaign_connections1

Same as connection entity [campaign_connections1](connection.md#BKMK_campaign_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaign_connections1<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_campaign_connections2"></a> campaign_connections2

Same as connection entity [campaign_connections2](connection.md#BKMK_campaign_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaign_connections2<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Campaign_Annotation"></a> Campaign_Annotation

Same as annotation entity [Campaign_Annotation](annotation.md#BKMK_Campaign_Annotation) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Campaign_Annotation<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Campaign_CampaignActivities"></a> Campaign_CampaignActivities

Same as campaignactivity entity [Campaign_CampaignActivities](campaignactivity.md#BKMK_Campaign_CampaignActivities) Many-To-One relationship.

**ReferencingEntity**: campaignactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Campaign_CampaignActivities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Campaign_CampaignResponses"></a> Campaign_CampaignResponses

Same as campaignresponse entity [Campaign_CampaignResponses](campaignresponse.md#BKMK_Campaign_CampaignResponses) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Campaign_CampaignResponses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_campaign_leads"></a> campaign_leads

Same as lead entity [campaign_leads](lead.md#BKMK_campaign_leads) Many-To-One relationship.

**ReferencingEntity**: lead<br />
**ReferencingAttribute**: campaignid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaign_leads<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_campaign_IncidentResolutions"></a> campaign_IncidentResolutions

Same as incidentresolution entity [campaign_IncidentResolutions](incidentresolution.md#BKMK_campaign_IncidentResolutions) Many-To-One relationship.

**ReferencingEntity**: incidentresolution<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaign_IncidentResolutions<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Campaign_ServiceAppointments"></a> Campaign_ServiceAppointments

Same as serviceappointment entity [Campaign_ServiceAppointments](serviceappointment.md#BKMK_Campaign_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Campaign_ServiceAppointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_campaign_OpportunityCloses"></a> campaign_OpportunityCloses

Same as opportunityclose entity [campaign_OpportunityCloses](opportunityclose.md#BKMK_campaign_OpportunityCloses) Many-To-One relationship.

**ReferencingEntity**: opportunityclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaign_OpportunityCloses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_campaign_OrderCloses"></a> campaign_OrderCloses

Same as orderclose entity [campaign_OrderCloses](orderclose.md#BKMK_campaign_OrderCloses) Many-To-One relationship.

**ReferencingEntity**: orderclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaign_OrderCloses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_campaign_QuoteCloses"></a> campaign_QuoteCloses

Same as quoteclose entity [campaign_QuoteCloses](quoteclose.md#BKMK_campaign_QuoteCloses) Many-To-One relationship.

**ReferencingEntity**: quoteclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaign_QuoteCloses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_campaign_opportunities"></a> campaign_opportunities

Same as opportunity entity [campaign_opportunities](opportunity.md#BKMK_campaign_opportunities) Many-To-One relationship.

**ReferencingEntity**: opportunity<br />
**ReferencingAttribute**: campaignid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaign_opportunities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_campaign_orders"></a> campaign_orders

Same as salesorder entity [campaign_orders](salesorder.md#BKMK_campaign_orders) Many-To-One relationship.

**ReferencingEntity**: salesorder<br />
**ReferencingAttribute**: campaignid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaign_orders<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_campaign_quotes"></a> campaign_quotes

Same as quote entity [campaign_quotes](quote.md#BKMK_campaign_quotes) Many-To-One relationship.

**ReferencingEntity**: quote<br />
**ReferencingAttribute**: campaignid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaign_quotes<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_campaign_msdyn_bookingalerts"></a> campaign_msdyn_bookingalerts

Same as msdyn_bookingalert entity [campaign_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_campaign_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaign_msdyn_bookingalerts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_campaign_msdyn_approvals"></a> campaign_msdyn_approvals

Same as msdyn_approval entity [campaign_msdyn_approvals](msdyn_approval.md#BKMK_campaign_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaign_msdyn_approvals<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade

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

See systemuser Entity [lk_campaign_createdby](systemuser.md#BKMK_lk_campaign_createdby) One-To-Many relationship.

### <a name="BKMK_lk_campaign_createdonbehalfby"></a> lk_campaign_createdonbehalfby

See systemuser Entity [lk_campaign_createdonbehalfby](systemuser.md#BKMK_lk_campaign_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_campaign_modifiedby"></a> lk_campaign_modifiedby

See systemuser Entity [lk_campaign_modifiedby](systemuser.md#BKMK_lk_campaign_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_campaign_modifiedonbehalfby"></a> lk_campaign_modifiedonbehalfby

See systemuser Entity [lk_campaign_modifiedonbehalfby](systemuser.md#BKMK_lk_campaign_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_SystemUser_Campaigns"></a> SystemUser_Campaigns

See systemuser Entity [SystemUser_Campaigns](systemuser.md#BKMK_SystemUser_Campaigns) One-To-Many relationship.

### <a name="BKMK_team_Campaigns"></a> team_Campaigns

See team Entity [team_Campaigns](team.md#BKMK_team_Campaigns) One-To-Many relationship.

### <a name="BKMK_BusinessUnit_Campaigns"></a> BusinessUnit_Campaigns

See businessunit Entity [BusinessUnit_Campaigns](businessunit.md#BKMK_BusinessUnit_Campaigns) One-To-Many relationship.

### <a name="BKMK_processstage_campaigns"></a> processstage_campaigns

See processstage Entity [processstage_campaigns](processstage.md#BKMK_processstage_campaigns) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_campaign"></a> transactioncurrency_campaign

See transactioncurrency Entity [transactioncurrency_campaign](transactioncurrency.md#BKMK_transactioncurrency_campaign) One-To-Many relationship.

### <a name="BKMK_PriceList_Campaigns"></a> PriceList_Campaigns

See pricelevel Entity [PriceList_Campaigns](pricelevel.md#BKMK_PriceList_Campaigns) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the Campaign entity is the first entity in the relationship. Listed by **SchemaName**.

- [campaigncampaign_association](#BKMK_campaigncampaign_association)
- [campaignproduct_association](#BKMK_campaignproduct_association)
- [campaignlist_association](#BKMK_campaignlist_association)
- [campaignsalesliterature_association](#BKMK_campaignsalesliterature_association)


### <a name="BKMK_campaigncampaign_association"></a> campaigncampaign_association

**IntersectEntityName**: campaignitem<br />
**Entity1LogicalName**: campaign<br />

- **Entity1IntersectAttribute**: campaignid
- **Entity1NavigationPropertyName**: campaigncampaign_association
- **Entity1AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**Entity2LogicalName**: [campaign](campaign.md)<br />

- **Entity2IntersectAttribute**: entityid
- **Entity2NavigationPropertyName**: campaigncampaign_association
- **Entity2AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**IsCustomizable**: False<br />

### <a name="BKMK_campaignproduct_association"></a> campaignproduct_association

**IntersectEntityName**: campaignitem<br />
**Entity1LogicalName**: campaign<br />

- **Entity1IntersectAttribute**: campaignid
- **Entity1NavigationPropertyName**: campaignproduct_association
- **Entity1AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**Entity2LogicalName**: [product](product.md)<br />

- **Entity2IntersectAttribute**: entityid
- **Entity2NavigationPropertyName**: campaignproduct_association
- **Entity2AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**IsCustomizable**: False<br />

### <a name="BKMK_campaignlist_association"></a> campaignlist_association

**IntersectEntityName**: campaignitem<br />
**Entity1LogicalName**: campaign<br />

- **Entity1IntersectAttribute**: campaignid
- **Entity1NavigationPropertyName**: campaignlist_association
- **Entity1AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**Entity2LogicalName**: [list](list.md)<br />

- **Entity2IntersectAttribute**: entityid
- **Entity2NavigationPropertyName**: campaignlist_association
- **Entity2AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**IsCustomizable**: False<br />

### <a name="BKMK_campaignsalesliterature_association"></a> campaignsalesliterature_association

**IntersectEntityName**: campaignitem<br />
**Entity1LogicalName**: campaign<br />

- **Entity1IntersectAttribute**: campaignid
- **Entity1NavigationPropertyName**: campaignsalesliterature_association
- **Entity1AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**Entity2LogicalName**: [salesliterature](salesliterature.md)<br />

- **Entity2IntersectAttribute**: entityid
- **Entity2NavigationPropertyName**: campaignsalesliterature_association
- **Entity2AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**IsCustomizable**: False<br />

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.campaign?text=campaign EntityType" />