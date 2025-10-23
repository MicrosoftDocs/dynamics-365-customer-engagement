---
title: "Campaign table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Campaign table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Campaign table/entity reference (Microsoft Dynamics 365)

Container for campaign activities and responses, sales literature, products, and lists to create, plan, execute, and track the results of a specific marketing campaign through its life.

## Messages

The following table lists the messages for the Campaign table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `AddItemCampaign`<br />Event: True |**AddItemCampaign action** |<xref:Microsoft.Crm.Sdk.Messages.AddItemCampaignRequest>|
| `AddItemCampaignActivity`<br />Event: True |**AddItemCampaignActivity action** |<xref:Microsoft.Crm.Sdk.Messages.AddItemCampaignActivityRequest>|
| `Assign`<br />Event: True |`PATCH` /campaigns(*campaignid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `CopyCampaign`<br />Event: False |**CopyCampaign action** |<xref:Microsoft.Crm.Sdk.Messages.CopyCampaignRequest>|
| `Create`<br />Event: True |`POST` /campaigns<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /campaigns(*campaignid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `RemoveItemCampaign`<br />Event: True |**RemoveItemCampaign action** |<xref:Microsoft.Crm.Sdk.Messages.RemoveItemCampaignRequest>|
| `RemoveItemCampaignActivity`<br />Event: True |**RemoveItemCampaignActivity action** |<xref:Microsoft.Crm.Sdk.Messages.RemoveItemCampaignActivityRequest>|
| `Retrieve`<br />Event: True |`GET` /campaigns(*campaignid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /campaigns<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /campaigns(*campaignid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /campaigns(*campaignid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /campaigns(*campaignid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Campaign table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Campaign** |
| **DisplayCollectionName** | **Campaigns** |
| **SchemaName** | `Campaign` |
| **CollectionSchemaName** | `Campaigns` |
| **EntitySetName** | `campaigns`|
| **LogicalName** | `campaign` |
| **LogicalCollectionName** | `campaigns` |
| **PrimaryIdAttribute** | `campaignid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

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
|---|---|
|Description|**Enter the date when the campaign was closed or completed.**|
|DisplayName|**Actual End Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`actualend`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ActualStart"></a> ActualStart

|Property|Value|
|---|---|
|Description|**Enter the actual start date and time for the campaign.**|
|DisplayName|**Actual Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`actualstart`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_BudgetedCost"></a> BudgetedCost

|Property|Value|
|---|---|
|Description|**Type the amount budgeted for the campaign to define a limit for how much you can spend.**|
|DisplayName|**Budget Allocated**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`budgetedcost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_CampaignId"></a> CampaignId

|Property|Value|
|---|---|
|Description|**Unique identifier of the campaign.**|
|DisplayName|**Campaign**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`campaignid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_CodeName"></a> CodeName

|Property|Value|
|---|---|
|Description|**Type a number or other tracking code to identify the campaign. If no value is entered, a code will be generated automatically.**|
|DisplayName|**Campaign Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`codename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|32|

### <a name="BKMK_Description"></a> Description

|Property|Value|
|---|---|
|Description|**Type additional information to describe the campaign, such as the products or services offered or the targeted audience.**|
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

### <a name="BKMK_EmailAddress"></a> EmailAddress

|Property|Value|
|---|---|
|Description|**The primary email address for the entity.**|
|DisplayName|**Email Address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`emailaddress`|
|RequiredLevel|None|
|Type|String|
|Format|Email|
|FormatName|Email|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_EntityImage"></a> EntityImage

|Property|Value|
|---|---|
|Description|**The default image for the entity.**|
|DisplayName|**Entity Image**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage`|
|RequiredLevel|None|
|Type|Image|
|CanStoreFullImage|False|
|IsPrimaryImage|True|
|MaxHeight|144|
|MaxSizeInKB|10240|
|MaxWidth|144|

### <a name="BKMK_ExpectedResponse"></a> ExpectedResponse

|Property|Value|
|---|---|
|Description|**Type the expected response rate for the campaign as a full number between 0 and 100.**|
|DisplayName|**Expected Response Percentage**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`expectedresponse`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|0|

### <a name="BKMK_ExpectedRevenue"></a> ExpectedRevenue

|Property|Value|
|---|---|
|Description|**Type the expected revenue for the campaign for return on investment projections and post-campaign reporting.**|
|DisplayName|**Estimated Revenue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`expectedrevenue`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

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

### <a name="BKMK_IsTemplate"></a> IsTemplate

|Property|Value|
|---|---|
|Description|**Select whether the campaign is a template that can be copied when you create future campaigns.**|
|DisplayName|**Template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`istemplate`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`campaign_istemplate`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_Message"></a> Message

|Property|Value|
|---|---|
|Description|**Type the promotional message or marketing copy for the campaign.**|
|DisplayName|**Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`message`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|256|

### <a name="BKMK_msdyn_gdproptout"></a> msdyn_gdproptout

|Property|Value|
|---|---|
|Description|**Describes whether campaign is opted out or not**|
|DisplayName|**GDPR Optout**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_gdproptout`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_campaign_msdyn_gdproptout`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**Type a name for the campaign so that it is identified correctly in lists.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|

### <a name="BKMK_Objective"></a> Objective

|Property|Value|
|---|---|
|Description|**Type the objective of the campaign, including products, services, discounts, and pricing.**|
|DisplayName|**Offer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`objective`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_OtherCost"></a> OtherCost

|Property|Value|
|---|---|
|Description|**Type the sum of any miscellaneous campaign costs not included in the campaign activities to make sure the actual cost of the campaign is calculated correctly.**|
|DisplayName|**Miscellaneous Costs**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`othercost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

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

### <a name="BKMK_PriceListId"></a> PriceListId

|Property|Value|
|---|---|
|Description|**Choose the price list associated with this item to make sure the products associated with the campaign are offered at the correct prices.**|
|DisplayName|**Price List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`pricelistid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|pricelevel|

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

### <a name="BKMK_PromotionCodeName"></a> PromotionCodeName

|Property|Value|
|---|---|
|Description|**Type a promotional code to track sales related to the campaign or allow customers to redeem a discount offer.**|
|DisplayName|**Promotion Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`promotioncodename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|

### <a name="BKMK_ProposedEnd"></a> ProposedEnd

|Property|Value|
|---|---|
|Description|**Enter the date when the campaign is scheduled to end.**|
|DisplayName|**Proposed End Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`proposedend`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ProposedStart"></a> ProposedStart

|Property|Value|
|---|---|
|Description|**Enter the date when the campaign is scheduled to start.**|
|DisplayName|**Proposed Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`proposedstart`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

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
|Description|**Shows the status of the campaign. By default, campaigns are active and can't be deactivated.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue|0|
|GlobalChoiceName|`campaign_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 0<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 6<br />InvariantName: `Inactive`|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Select the campaign's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue|-1|
|GlobalChoiceName|`campaign_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Proposed**<br />State:0<br />TransitionData: None|
|1|Label: **Ready To Launch**<br />State:0<br />TransitionData: None|
|2|Label: **Launched**<br />State:0<br />TransitionData: None|
|3|Label: **Completed**<br />State:0<br />TransitionData: None|
|4|Label: **Canceled**<br />State:0<br />TransitionData: None|
|5|Label: **Suspended**<br />State:0<br />TransitionData: None|
|6|Label: **Inactive**<br />State:1<br />TransitionData: None|

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

### <a name="BKMK_TmpRegardingObjectId"></a> TmpRegardingObjectId

|Property|Value|
|---|---|
|Description||
|DisplayName|**TmpRegardingObjectId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`tmpregardingobjectid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Choose the local currency for the record to make sure budgets are reported in the correct currency.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|ApplicationRequired|
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

### <a name="BKMK_TypeCode"></a> TypeCode

|Property|Value|
|---|---|
|Description|**Select the type of the campaign.**|
|DisplayName|**Campaign Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`typecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`campaign_typecode`|

#### TypeCode Choices/Options

|Value|Label|
|---|---|
|1|**Advertisement**|
|2|**Direct Marketing**|
|3|**Event**|
|4|**Co-branding**|
|5|**Other**|

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

- [BudgetedCost_Base](#BKMK_BudgetedCost_Base)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ExpectedRevenue_Base](#BKMK_ExpectedRevenue_Base)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OtherCost_Base](#BKMK_OtherCost_Base)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [TotalActualCost](#BKMK_TotalActualCost)
- [TotalActualCost_Base](#BKMK_TotalActualCost_Base)
- [TotalCampaignActivityActualCost](#BKMK_TotalCampaignActivityActualCost)
- [TotalCampaignActivityActualCost_Base](#BKMK_TotalCampaignActivityActualCost_Base)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_BudgetedCost_Base"></a> BudgetedCost_Base

|Property|Value|
|---|---|
|Description|**Value of the Budget Allocated in base currency.**|
|DisplayName|**Budget Allocated (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`budgetedcost_base`|
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

### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_timestamp`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_url`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

### <a name="BKMK_ExpectedRevenue_Base"></a> ExpectedRevenue_Base

|Property|Value|
|---|---|
|Description|**Value of the Estimated Revenue in base currency.**|
|DisplayName|**Estimated Revenue (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`expectedrevenue_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

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
|Description|**Shows who created the record on behalf of another user.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OtherCost_Base"></a> OtherCost_Base

|Property|Value|
|---|---|
|Description|**Value of the Miscellaneous Costs in base currency.**|
|DisplayName|**Miscellaneous Costs (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`othercost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

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
|RequiredLevel|None|
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

### <a name="BKMK_TotalActualCost"></a> TotalActualCost

|Property|Value|
|---|---|
|Description|**Shows the sum of the amounts entered in the Total Cost of Campaign Activities and Miscellaneous Costs fields.**|
|DisplayName|**Total Cost of Campaign**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totalactualcost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalActualCost_Base"></a> TotalActualCost_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Cost of Campaign in base currency.**|
|DisplayName|**Total Cost of Campaign (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totalactualcost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalCampaignActivityActualCost"></a> TotalCampaignActivityActualCost

|Property|Value|
|---|---|
|Description|**Shows the sum of the values entered in the Actual Cost field on all campaign activities related to the campaign.**|
|DisplayName|**Total Cost of Campaign Activities**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totalcampaignactivityactualcost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalCampaignActivityActualCost_Base"></a> TotalCampaignActivityActualCost_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Cost of Campaign Activities in base currency.**|
|DisplayName|**Total Cost of Campaign Activities (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totalcampaignactivityactualcost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

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

- [BusinessUnit_Campaigns](#BKMK_BusinessUnit_Campaigns)
- [lk_campaign_createdby](#BKMK_lk_campaign_createdby)
- [lk_campaign_createdonbehalfby](#BKMK_lk_campaign_createdonbehalfby)
- [lk_campaign_modifiedby](#BKMK_lk_campaign_modifiedby)
- [lk_campaign_modifiedonbehalfby](#BKMK_lk_campaign_modifiedonbehalfby)
- [owner_campaigns](#BKMK_owner_campaigns)
- [PriceList_Campaigns](#BKMK_PriceList_Campaigns)
- [processstage_campaigns](#BKMK_processstage_campaigns)
- [SystemUser_Campaigns](#BKMK_SystemUser_Campaigns)
- [team_Campaigns](#BKMK_team_Campaigns)
- [transactioncurrency_campaign](#BKMK_transactioncurrency_campaign)

### <a name="BKMK_BusinessUnit_Campaigns"></a> BusinessUnit_Campaigns

One-To-Many Relationship: [businessunit BusinessUnit_Campaigns](businessunit.md#BKMK_BusinessUnit_Campaigns)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_campaign_createdby"></a> lk_campaign_createdby

One-To-Many Relationship: [systemuser lk_campaign_createdby](systemuser.md#BKMK_lk_campaign_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_campaign_createdonbehalfby"></a> lk_campaign_createdonbehalfby

One-To-Many Relationship: [systemuser lk_campaign_createdonbehalfby](systemuser.md#BKMK_lk_campaign_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_campaign_modifiedby"></a> lk_campaign_modifiedby

One-To-Many Relationship: [systemuser lk_campaign_modifiedby](systemuser.md#BKMK_lk_campaign_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_campaign_modifiedonbehalfby"></a> lk_campaign_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_campaign_modifiedonbehalfby](systemuser.md#BKMK_lk_campaign_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_campaigns"></a> owner_campaigns

One-To-Many Relationship: [owner owner_campaigns](owner.md#BKMK_owner_campaigns)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_PriceList_Campaigns"></a> PriceList_Campaigns

One-To-Many Relationship: [pricelevel PriceList_Campaigns](pricelevel.md#BKMK_PriceList_Campaigns)

|Property|Value|
|---|---|
|ReferencedEntity|`pricelevel`|
|ReferencedAttribute|`pricelevelid`|
|ReferencingAttribute|`pricelistid`|
|ReferencingEntityNavigationPropertyName|`pricelistid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_campaigns"></a> processstage_campaigns

One-To-Many Relationship: [processstage processstage_campaigns](processstage.md#BKMK_processstage_campaigns)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid_processstage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_SystemUser_Campaigns"></a> SystemUser_Campaigns

One-To-Many Relationship: [systemuser SystemUser_Campaigns](systemuser.md#BKMK_SystemUser_Campaigns)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_Campaigns"></a> team_Campaigns

One-To-Many Relationship: [team team_Campaigns](team.md#BKMK_team_Campaigns)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_transactioncurrency_campaign"></a> transactioncurrency_campaign

One-To-Many Relationship: [transactioncurrency transactioncurrency_campaign](transactioncurrency.md#BKMK_transactioncurrency_campaign)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [campaign_activity_parties](#BKMK_campaign_activity_parties)
- [Campaign_ActivityPointers](#BKMK_Campaign_ActivityPointers)
- [campaign_adx_inviteredemptions](#BKMK_campaign_adx_inviteredemptions)
- [campaign_adx_portalcomments](#BKMK_campaign_adx_portalcomments)
- [Campaign_Annotation](#BKMK_Campaign_Annotation)
- [Campaign_Appointments](#BKMK_Campaign_Appointments)
- [Campaign_AsyncOperations](#BKMK_Campaign_AsyncOperations)
- [Campaign_BulkDeleteFailures](#BKMK_Campaign_BulkDeleteFailures)
- [Campaign_CampaignActivities](#BKMK_Campaign_CampaignActivities)
- [Campaign_CampaignResponses](#BKMK_Campaign_CampaignResponses)
- [campaign_chats](#BKMK_campaign_chats)
- [campaign_connections1](#BKMK_campaign_connections1)
- [campaign_connections2](#BKMK_campaign_connections2)
- [Campaign_DuplicateBaseRecord](#BKMK_Campaign_DuplicateBaseRecord)
- [Campaign_DuplicateMatchingRecord](#BKMK_Campaign_DuplicateMatchingRecord)
- [Campaign_Emails](#BKMK_Campaign_Emails)
- [Campaign_Faxes](#BKMK_Campaign_Faxes)
- [campaign_IncidentResolutions](#BKMK_campaign_IncidentResolutions)
- [campaign_leads](#BKMK_campaign_leads)
- [Campaign_Letters](#BKMK_Campaign_Letters)
- [Campaign_MailboxTrackingFolder](#BKMK_Campaign_MailboxTrackingFolder)
- [campaign_msdyn_copilottranscripts](#BKMK_campaign_msdyn_copilottranscripts)
- [campaign_msdyn_ocliveworkitems](#BKMK_campaign_msdyn_ocliveworkitems)
- [campaign_msdyn_ocsessions](#BKMK_campaign_msdyn_ocsessions)
- [campaign_msfp_alerts](#BKMK_campaign_msfp_alerts)
- [campaign_msfp_surveyinvites](#BKMK_campaign_msfp_surveyinvites)
- [campaign_msfp_surveyresponses](#BKMK_campaign_msfp_surveyresponses)
- [campaign_opportunities](#BKMK_campaign_opportunities)
- [campaign_OpportunityCloses](#BKMK_campaign_OpportunityCloses)
- [campaign_OrderCloses](#BKMK_campaign_OrderCloses)
- [campaign_orders](#BKMK_campaign_orders)
- [Campaign_Phonecalls](#BKMK_Campaign_Phonecalls)
- [campaign_principalobjectattributeaccess](#BKMK_campaign_principalobjectattributeaccess)
- [Campaign_ProcessSessions](#BKMK_Campaign_ProcessSessions)
- [campaign_QuoteCloses](#BKMK_campaign_QuoteCloses)
- [campaign_quotes](#BKMK_campaign_quotes)
- [Campaign_RecurringAppointmentMasters](#BKMK_Campaign_RecurringAppointmentMasters)
- [Campaign_ServiceAppointments](#BKMK_Campaign_ServiceAppointments)
- [campaign_SocialActivities](#BKMK_campaign_SocialActivities)
- [Campaign_SyncErrors](#BKMK_Campaign_SyncErrors)
- [Campaign_Tasks](#BKMK_Campaign_Tasks)

### <a name="BKMK_campaign_activity_parties"></a> campaign_activity_parties

Many-To-One Relationship: [activityparty campaign_activity_parties](activityparty.md#BKMK_campaign_activity_parties)

|Property|Value|
|---|---|
|ReferencingEntity|`activityparty`|
|ReferencingAttribute|`partyid`|
|ReferencedEntityNavigationPropertyName|`campaign_activity_parties`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Campaign_ActivityPointers"></a> Campaign_ActivityPointers

Many-To-One Relationship: [activitypointer Campaign_ActivityPointers](activitypointer.md#BKMK_Campaign_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Campaign_ActivityPointers`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_adx_inviteredemptions"></a> campaign_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption campaign_adx_inviteredemptions](adx_inviteredemption.md#BKMK_campaign_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaign_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_adx_portalcomments"></a> campaign_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment campaign_adx_portalcomments](adx_portalcomment.md#BKMK_campaign_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaign_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Campaign_Annotation"></a> Campaign_Annotation

Many-To-One Relationship: [annotation Campaign_Annotation](annotation.md#BKMK_Campaign_Annotation)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`Campaign_Annotation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Campaign_Appointments"></a> Campaign_Appointments

Many-To-One Relationship: [appointment Campaign_Appointments](appointment.md#BKMK_Campaign_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Campaign_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Campaign_AsyncOperations"></a> Campaign_AsyncOperations

Many-To-One Relationship: [asyncoperation Campaign_AsyncOperations](asyncoperation.md#BKMK_Campaign_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Campaign_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Campaign_BulkDeleteFailures"></a> Campaign_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure Campaign_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Campaign_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Campaign_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Campaign_CampaignActivities"></a> Campaign_CampaignActivities

Many-To-One Relationship: [campaignactivity Campaign_CampaignActivities](campaignactivity.md#BKMK_Campaign_CampaignActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Campaign_CampaignActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Campaign_CampaignResponses"></a> Campaign_CampaignResponses

Many-To-One Relationship: [campaignresponse Campaign_CampaignResponses](campaignresponse.md#BKMK_Campaign_CampaignResponses)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Campaign_CampaignResponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_chats"></a> campaign_chats

Many-To-One Relationship: [chat campaign_chats](chat.md#BKMK_campaign_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaign_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_connections1"></a> campaign_connections1

Many-To-One Relationship: [connection campaign_connections1](connection.md#BKMK_campaign_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`campaign_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_connections2"></a> campaign_connections2

Many-To-One Relationship: [connection campaign_connections2](connection.md#BKMK_campaign_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`campaign_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Campaign_DuplicateBaseRecord"></a> Campaign_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord Campaign_DuplicateBaseRecord](duplicaterecord.md#BKMK_Campaign_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`Campaign_DuplicateBaseRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Campaign_DuplicateMatchingRecord"></a> Campaign_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord Campaign_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Campaign_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`Campaign_DuplicateMatchingRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Campaign_Emails"></a> Campaign_Emails

Many-To-One Relationship: [email Campaign_Emails](email.md#BKMK_Campaign_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Campaign_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Campaign_Faxes"></a> Campaign_Faxes

Many-To-One Relationship: [fax Campaign_Faxes](fax.md#BKMK_Campaign_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Campaign_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_IncidentResolutions"></a> campaign_IncidentResolutions

Many-To-One Relationship: [incidentresolution campaign_IncidentResolutions](incidentresolution.md#BKMK_campaign_IncidentResolutions)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaign_IncidentResolutions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_leads"></a> campaign_leads

Many-To-One Relationship: [lead campaign_leads](lead.md#BKMK_campaign_leads)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`campaignid`|
|ReferencedEntityNavigationPropertyName|`campaign_leads`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Marketing`<br />Label: <br />MenuId: null<br />Order: 130<br />QueryApi: null<br />ViewId: `f7ba26ee-3f8e-4cf2-8e02-0b4bbcd16da8`|

### <a name="BKMK_Campaign_Letters"></a> Campaign_Letters

Many-To-One Relationship: [letter Campaign_Letters](letter.md#BKMK_Campaign_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Campaign_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Campaign_MailboxTrackingFolder"></a> Campaign_MailboxTrackingFolder

Many-To-One Relationship: [mailboxtrackingfolder Campaign_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_Campaign_MailboxTrackingFolder)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Campaign_MailboxTrackingFolder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_msdyn_copilottranscripts"></a> campaign_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript campaign_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_campaign_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaign_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_msdyn_ocliveworkitems"></a> campaign_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem campaign_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_campaign_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaign_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_msdyn_ocsessions"></a> campaign_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession campaign_msdyn_ocsessions](msdyn_ocsession.md#BKMK_campaign_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaign_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_msfp_alerts"></a> campaign_msfp_alerts

Many-To-One Relationship: [msfp_alert campaign_msfp_alerts](msfp_alert.md#BKMK_campaign_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaign_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_msfp_surveyinvites"></a> campaign_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite campaign_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_campaign_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaign_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_msfp_surveyresponses"></a> campaign_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse campaign_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_campaign_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaign_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_opportunities"></a> campaign_opportunities

Many-To-One Relationship: [opportunity campaign_opportunities](opportunity.md#BKMK_campaign_opportunities)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunity`|
|ReferencingAttribute|`campaignid`|
|ReferencedEntityNavigationPropertyName|`campaign_opportunities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Sales`<br />Label: <br />MenuId: null<br />Order: 130<br />QueryApi: null<br />ViewId: `00000000-0000-0000-00aa-000010001203`|

### <a name="BKMK_campaign_OpportunityCloses"></a> campaign_OpportunityCloses

Many-To-One Relationship: [opportunityclose campaign_OpportunityCloses](opportunityclose.md#BKMK_campaign_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaign_OpportunityCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_OrderCloses"></a> campaign_OrderCloses

Many-To-One Relationship: [orderclose campaign_OrderCloses](orderclose.md#BKMK_campaign_OrderCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaign_OrderCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_orders"></a> campaign_orders

Many-To-One Relationship: [salesorder campaign_orders](salesorder.md#BKMK_campaign_orders)

|Property|Value|
|---|---|
|ReferencingEntity|`salesorder`|
|ReferencingAttribute|`campaignid`|
|ReferencedEntityNavigationPropertyName|`campaign_orders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Campaign_Phonecalls"></a> Campaign_Phonecalls

Many-To-One Relationship: [phonecall Campaign_Phonecalls](phonecall.md#BKMK_Campaign_Phonecalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Campaign_Phonecalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_principalobjectattributeaccess"></a> campaign_principalobjectattributeaccess

Many-To-One Relationship: [principalobjectattributeaccess campaign_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_campaign_principalobjectattributeaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`campaign_principalobjectattributeaccess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Campaign_ProcessSessions"></a> Campaign_ProcessSessions

Many-To-One Relationship: [processsession Campaign_ProcessSessions](processsession.md#BKMK_Campaign_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Campaign_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_QuoteCloses"></a> campaign_QuoteCloses

Many-To-One Relationship: [quoteclose campaign_QuoteCloses](quoteclose.md#BKMK_campaign_QuoteCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaign_QuoteCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_quotes"></a> campaign_quotes

Many-To-One Relationship: [quote campaign_quotes](quote.md#BKMK_campaign_quotes)

|Property|Value|
|---|---|
|ReferencingEntity|`quote`|
|ReferencingAttribute|`campaignid`|
|ReferencedEntityNavigationPropertyName|`campaign_quotes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Campaign_RecurringAppointmentMasters"></a> Campaign_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster Campaign_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_Campaign_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Campaign_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Campaign_ServiceAppointments"></a> Campaign_ServiceAppointments

Many-To-One Relationship: [serviceappointment Campaign_ServiceAppointments](serviceappointment.md#BKMK_Campaign_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Campaign_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_SocialActivities"></a> campaign_SocialActivities

Many-To-One Relationship: [socialactivity campaign_SocialActivities](socialactivity.md#BKMK_campaign_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaign_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Campaign_SyncErrors"></a> Campaign_SyncErrors

Many-To-One Relationship: [syncerror Campaign_SyncErrors](syncerror.md#BKMK_Campaign_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Campaign_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Campaign_Tasks"></a> Campaign_Tasks

Many-To-One Relationship: [task Campaign_Tasks](task.md#BKMK_Campaign_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Campaign_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [campaigncampaign_association](#BKMK_campaigncampaign_association)
- [campaignlist_association](#BKMK_campaignlist_association)
- [campaignproduct_association](#BKMK_campaignproduct_association)
- [campaignsalesliterature_association](#BKMK_campaignsalesliterature_association)

### <a name="BKMK_campaigncampaign_association"></a> campaigncampaign_association

This is a self-referencing many-to-many relationship.

|Property|Value|
|---|---|
|IntersectEntityName|`campaignitem`|
|IsCustomizable|False|
|SchemaName|`campaigncampaign_association`|
|Entity1IntersectAttribute|`campaignid`|
|Entity2IntersectAttribute|`entityid`|
|Entity1NavigationPropertyName|`campaigncampaign_association`|
|Entity2NavigationPropertyName|`campaigncampaign_association`|
|Entity1AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|
|Entity2AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignlist_association"></a> campaignlist_association

See [list campaignlist_association Many-To-Many Relationship](list.md#BKMK_campaignlist_association)

|Property|Value|
|---|---|
|IntersectEntityName|`campaignitem`|
|IsCustomizable|False|
|SchemaName|`campaignlist_association`|
|IntersectAttribute|`campaignid`|
|NavigationPropertyName|`campaignlist_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `Campaign.RetrieveCampaignsForList`<br />ViewId: `244af698-f753-48fd-9803-c1939dcf02d1`|

### <a name="BKMK_campaignproduct_association"></a> campaignproduct_association

See [product campaignproduct_association Many-To-Many Relationship](product.md#BKMK_campaignproduct_association)

|Property|Value|
|---|---|
|IntersectEntityName|`campaignitem`|
|IsCustomizable|False|
|SchemaName|`campaignproduct_association`|
|IntersectAttribute|`campaignid`|
|NavigationPropertyName|`campaignproduct_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignsalesliterature_association"></a> campaignsalesliterature_association

See [salesliterature campaignsalesliterature_association Many-To-Many Relationship](salesliterature.md#BKMK_campaignsalesliterature_association)

|Property|Value|
|---|---|
|IntersectEntityName|`campaignitem`|
|IsCustomizable|False|
|SchemaName|`campaignsalesliterature_association`|
|IntersectAttribute|`campaignid`|
|NavigationPropertyName|`campaignsalesliterature_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

