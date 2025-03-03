---
title: "Opportunity table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Opportunity table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Opportunity table/entity reference (Microsoft Dynamics 365)

Potential revenue-generating event, or sale to an account, which needs to be tracked through a sales process to completion.

## Messages

The following table lists the messages for the Opportunity table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /opportunities(*opportunityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `CalculateActualValueOpportunity`<br />Event: False |**CalculateActualValueOpportunity action** |<xref:Microsoft.Crm.Sdk.Messages.CalculateActualValueOpportunityRequest>|
| `Create`<br />Event: True |`POST` /opportunities<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /opportunities(*opportunityid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GetQuantityDecimal`<br />Event: False |**GetQuantityDecimal function** |<xref:Microsoft.Crm.Sdk.Messages.GetQuantityDecimalRequest>|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `LoseOpportunity`<br />Event: True |**LoseOpportunity action** |<xref:Microsoft.Crm.Sdk.Messages.LoseOpportunityRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /opportunities(*opportunityid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /opportunities<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `Rollup`<br />Event: False |<xref:Microsoft.Dynamics.CRM.Rollup?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RollupRequest>|
| `SetState`<br />Event: True |`PATCH` /opportunities(*opportunityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /opportunities(*opportunityid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /opportunities(*opportunityid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `WinOpportunity`<br />Event: True |**WinOpportunity action** |<xref:Microsoft.Crm.Sdk.Messages.WinOpportunityRequest>|
| `WinQuote`<br />Event: True |**WinQuote action** |<xref:Microsoft.Crm.Sdk.Messages.WinQuoteRequest>|


## Events

The following table lists the events for the Opportunity table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `CalculatePrice`|<xref:Microsoft.Dynamics.CRM.CalculatePrice?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.CalculatePriceRequest>|

## Properties

The following table lists selected properties for the Opportunity table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Opportunity** |
| **DisplayCollectionName** | **Opportunities** |
| **SchemaName** | `Opportunity` |
| **CollectionSchemaName** | `Opportunities` |
| **EntitySetName** | `opportunities`|
| **LogicalName** | `opportunity` |
| **LogicalCollectionName** | `opportunities` |
| **PrimaryIdAttribute** | `opportunityid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActualCloseDate](#BKMK_ActualCloseDate)
- [ActualValue](#BKMK_ActualValue)
- [BudgetAmount](#BKMK_BudgetAmount)
- [BudgetStatus](#BKMK_BudgetStatus)
- [CampaignId](#BKMK_CampaignId)
- [CaptureProposalFeedback](#BKMK_CaptureProposalFeedback)
- [CloseProbability](#BKMK_CloseProbability)
- [CompleteFinalProposal](#BKMK_CompleteFinalProposal)
- [CompleteInternalReview](#BKMK_CompleteInternalReview)
- [ConfirmInterest](#BKMK_ConfirmInterest)
- [CurrentSituation](#BKMK_CurrentSituation)
- [CustomerId](#BKMK_CustomerId)
- [CustomerIdType](#BKMK_CustomerIdType)
- [CustomerNeed](#BKMK_CustomerNeed)
- [CustomerPainPoints](#BKMK_CustomerPainPoints)
- [DecisionMaker](#BKMK_DecisionMaker)
- [Description](#BKMK_Description)
- [DevelopProposal](#BKMK_DevelopProposal)
- [DiscountAmount](#BKMK_DiscountAmount)
- [DiscountPercentage](#BKMK_DiscountPercentage)
- [EmailAddress](#BKMK_EmailAddress)
- [EstimatedCloseDate](#BKMK_EstimatedCloseDate)
- [EstimatedValue](#BKMK_EstimatedValue)
- [EvaluateFit](#BKMK_EvaluateFit)
- [FileDebrief](#BKMK_FileDebrief)
- [FinalDecisionDate](#BKMK_FinalDecisionDate)
- [FreightAmount](#BKMK_FreightAmount)
- [IdentifyCompetitors](#BKMK_IdentifyCompetitors)
- [IdentifyCustomerContacts](#BKMK_IdentifyCustomerContacts)
- [IdentifyPursuitTeam](#BKMK_IdentifyPursuitTeam)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [InitialCommunication](#BKMK_InitialCommunication)
- [IsRevenueSystemCalculated](#BKMK_IsRevenueSystemCalculated)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [msdyn_forecastcategory](#BKMK_msdyn_forecastcategory)
- [msdyn_gdproptout](#BKMK_msdyn_gdproptout)
- [msdyn_OpportunityGrade](#BKMK_msdyn_OpportunityGrade)
- [msdyn_opportunitykpiid](#BKMK_msdyn_opportunitykpiid)
- [msdyn_OpportunityScore](#BKMK_msdyn_OpportunityScore)
- [msdyn_OpportunityScoreTrend](#BKMK_msdyn_OpportunityScoreTrend)
- [msdyn_PredictiveScoreId](#BKMK_msdyn_PredictiveScoreId)
- [msdyn_ScoreHistory](#BKMK_msdyn_ScoreHistory)
- [msdyn_ScoreReasons](#BKMK_msdyn_ScoreReasons)
- [msdyn_segmentid](#BKMK_msdyn_segmentid)
- [msdyn_similaropportunities](#BKMK_msdyn_similaropportunities)
- [Name](#BKMK_Name)
- [Need](#BKMK_Need)
- [OpportunityId](#BKMK_OpportunityId)
- [OpportunityRatingCode](#BKMK_OpportunityRatingCode)
- [OriginatingLeadId](#BKMK_OriginatingLeadId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [ParentAccountId](#BKMK_ParentAccountId)
- [ParentContactId](#BKMK_ParentContactId)
- [ParticipatesInWorkflow](#BKMK_ParticipatesInWorkflow)
- [PresentFinalProposal](#BKMK_PresentFinalProposal)
- [PresentProposal](#BKMK_PresentProposal)
- [PriceLevelId](#BKMK_PriceLevelId)
- [PricingErrorCode](#BKMK_PricingErrorCode)
- [PriorityCode](#BKMK_PriorityCode)
- [ProcessId](#BKMK_ProcessId)
- [ProposedSolution](#BKMK_ProposedSolution)
- [PurchaseProcess](#BKMK_PurchaseProcess)
- [PurchaseTimeframe](#BKMK_PurchaseTimeframe)
- [PursuitDecision](#BKMK_PursuitDecision)
- [QualificationComments](#BKMK_QualificationComments)
- [QuoteComments](#BKMK_QuoteComments)
- [ResolveFeedback](#BKMK_ResolveFeedback)
- [SalesStage](#BKMK_SalesStage)
- [SalesStageCode](#BKMK_SalesStageCode)
- [ScheduleFollowup_Prospect](#BKMK_ScheduleFollowup_Prospect)
- [ScheduleFollowup_Qualify](#BKMK_ScheduleFollowup_Qualify)
- [ScheduleProposalMeeting](#BKMK_ScheduleProposalMeeting)
- [SendThankYouNote](#BKMK_SendThankYouNote)
- [SkipPriceCalculation](#BKMK_SkipPriceCalculation)
- [SLAId](#BKMK_SLAId)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [StepId](#BKMK_StepId)
- [StepName](#BKMK_StepName)
- [TeamsFollowed](#BKMK_TeamsFollowed)
- [TimeLine](#BKMK_TimeLine)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TotalAmount](#BKMK_TotalAmount)
- [TotalAmountLessFreight](#BKMK_TotalAmountLessFreight)
- [TotalDiscountAmount](#BKMK_TotalDiscountAmount)
- [TotalLineItemAmount](#BKMK_TotalLineItemAmount)
- [TotalLineItemDiscountAmount](#BKMK_TotalLineItemDiscountAmount)
- [TotalTax](#BKMK_TotalTax)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ActualCloseDate"></a> ActualCloseDate

|Property|Value|
|---|---|
|Description|**Shows the date and time when the opportunity was closed or canceled.**|
|DisplayName|**Actual Close Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`actualclosedate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|DateOnly|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ActualValue"></a> ActualValue

|Property|Value|
|---|---|
|Description|**Type the actual revenue amount for the opportunity for reporting and analysis of estimated versus actual sales. Field defaults to the Est. Revenue value when an opportunity is won.**|
|DisplayName|**Actual Revenue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`actualvalue`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|-1000000000000|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_BudgetAmount"></a> BudgetAmount

|Property|Value|
|---|---|
|Description|**Type a value between 0 and 1,000,000,000,000 to indicate the lead's potential available budget.**|
|DisplayName|**Budget amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`budgetamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_BudgetStatus"></a> BudgetStatus

|Property|Value|
|---|---|
|Description|**Select the likely budget status for the lead's company. This may help determine the lead rating or your sales approach.**|
|DisplayName|**Budget**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`budgetstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`budgetstatus`|

#### BudgetStatus Choices/Options

|Value|Label|
|---|---|
|0|**No Committed Budget**|
|1|**May Buy**|
|2|**Can Buy**|
|3|**Will Buy**|

### <a name="BKMK_CampaignId"></a> CampaignId

|Property|Value|
|---|---|
|Description|**Shows the campaign that the opportunity was created from. The ID is used for tracking the success of the campaign.**|
|DisplayName|**Source Campaign**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`campaignid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|campaign|

### <a name="BKMK_CaptureProposalFeedback"></a> CaptureProposalFeedback

|Property|Value|
|---|---|
|Description|**Choose whether the proposal feedback has been captured for the opportunity.**|
|DisplayName|**Proposal Feedback Captured**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`captureproposalfeedback`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`opportunity_captureproposalfeedback`|
|DefaultValue|False|
|True Label|No|
|False Label|Yes|

### <a name="BKMK_CloseProbability"></a> CloseProbability

|Property|Value|
|---|---|
|Description|**Type a number from 0 to 100 that represents the likelihood of closing the opportunity. This can aid the sales team in their efforts to convert the opportunity in a sale.**|
|DisplayName|**Probability**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`closeprobability`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|0|

### <a name="BKMK_CompleteFinalProposal"></a> CompleteFinalProposal

|Property|Value|
|---|---|
|Description|**Select whether a final proposal has been completed for the opportunity.**|
|DisplayName|**Final Proposal Ready**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`completefinalproposal`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`opportunity_completefinalproposal`|
|DefaultValue|False|
|True Label|Completed|
|False Label|Mark complete|

### <a name="BKMK_CompleteInternalReview"></a> CompleteInternalReview

|Property|Value|
|---|---|
|Description|**Select whether an internal review has been completed for this opportunity.**|
|DisplayName|**Complete Internal Review**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`completeinternalreview`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`opportunity_completeinternalreview`|
|DefaultValue|False|
|True Label|Completed|
|False Label|Mark complete|

### <a name="BKMK_ConfirmInterest"></a> ConfirmInterest

|Property|Value|
|---|---|
|Description|**Select whether the lead confirmed interest in your offerings. This helps in determining the lead quality and the probability of it turning into an opportunity.**|
|DisplayName|**Confirm Interest**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`confirminterest`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`confirminterest`|
|DefaultValue|False|
|True Label|No|
|False Label|Yes|

### <a name="BKMK_CurrentSituation"></a> CurrentSituation

|Property|Value|
|---|---|
|Description|**Type notes about the company or organization associated with the opportunity.**|
|DisplayName|**Current Situation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`currentsituation`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_CustomerId"></a> CustomerId

|Property|Value|
|---|---|
|Description|**Select the customer account or contact to provide a quick link to additional customer details, such as address, phone number, activities, and orders.**|
|DisplayName|**Potential Customer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`customerid`|
|RequiredLevel|ApplicationRequired|
|Type|Customer|
|Targets|account, contact|

### <a name="BKMK_CustomerIdType"></a> CustomerIdType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Potential Customer Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`customeridtype`|
|RequiredLevel|ApplicationRequired|
|Type|EntityName|

### <a name="BKMK_CustomerNeed"></a> CustomerNeed

|Property|Value|
|---|---|
|Description|**Type some notes about the customer's requirements, to help the sales team identify products and services that could meet their requirements.**|
|DisplayName|**Customer Need**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`customerneed`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_CustomerPainPoints"></a> CustomerPainPoints

|Property|Value|
|---|---|
|Description|**Type notes about the customer's pain points to help the sales team identify products and services that could address these pain points.**|
|DisplayName|**Customer Pain Points**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`customerpainpoints`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_DecisionMaker"></a> DecisionMaker

|Property|Value|
|---|---|
|Description|**Select whether your notes include information about who makes the purchase decisions at the lead's company.**|
|DisplayName|**Decision Maker?**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`decisionmaker`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`decisionmaker`|
|DefaultValue|False|
|True Label|completed|
|False Label|mark complete|

### <a name="BKMK_Description"></a> Description

|Property|Value|
|---|---|
|Description|**Type additional information to describe the opportunity, such as possible products to sell or past purchases from the customer.**|
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

### <a name="BKMK_DevelopProposal"></a> DevelopProposal

|Property|Value|
|---|---|
|Description|**Select whether a proposal has been developed for the opportunity.**|
|DisplayName|**Develop Proposal**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`developproposal`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`opportunity_developproposal`|
|DefaultValue|False|
|True Label|Completed|
|False Label|Mark complete|

### <a name="BKMK_DiscountAmount"></a> DiscountAmount

|Property|Value|
|---|---|
|Description|**Type the discount amount for the opportunity if the customer is eligible for special savings.**|
|DisplayName|**Opportunity Discount Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`discountamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_DiscountPercentage"></a> DiscountPercentage

|Property|Value|
|---|---|
|Description|**Type the discount rate that should be applied to the Product Totals field to include additional savings for the customer in the opportunity.**|
|DisplayName|**Opportunity Discount (%)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`discountpercentage`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

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

### <a name="BKMK_EstimatedCloseDate"></a> EstimatedCloseDate

|Property|Value|
|---|---|
|Description|**Enter the expected closing date of the opportunity to help make accurate revenue forecasts.**|
|DisplayName|**Est. close date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`estimatedclosedate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|DateOnly|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_EstimatedValue"></a> EstimatedValue

|Property|Value|
|---|---|
|Description|**Type the estimated revenue amount to indicate the potential sale or value of the opportunity for revenue forecasting. This field can be either system-populated or editable based on the selection in the Revenue field.**|
|DisplayName|**Est. revenue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`estimatedvalue`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|-1000000000000|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_EvaluateFit"></a> EvaluateFit

|Property|Value|
|---|---|
|Description|**Select whether the fit between the lead's requirements and your offerings was evaluated.**|
|DisplayName|**Evaluate Fit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`evaluatefit`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`evaluatefit`|
|DefaultValue|False|
|True Label|No|
|False Label|Yes|

### <a name="BKMK_FileDebrief"></a> FileDebrief

|Property|Value|
|---|---|
|Description|**Choose whether the sales team has recorded detailed notes on the proposals and the account's responses.**|
|DisplayName|**File Debrief**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`filedebrief`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`opportunity_filedebrief`|
|DefaultValue|False|
|True Label|Completed|
|False Label|Mark complete|

### <a name="BKMK_FinalDecisionDate"></a> FinalDecisionDate

|Property|Value|
|---|---|
|Description|**Enter the date and time when the final decision of the opportunity was made.**|
|DisplayName|**Final Decision Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`finaldecisiondate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|DateOnly|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_FreightAmount"></a> FreightAmount

|Property|Value|
|---|---|
|Description|**Type the cost of freight or shipping for the products included in the opportunity for use in calculating the Total Amount field.**|
|DisplayName|**Freight Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`freightamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_IdentifyCompetitors"></a> IdentifyCompetitors

|Property|Value|
|---|---|
|Description|**Select whether information about competitors is included.**|
|DisplayName|**Identify Competitors**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`identifycompetitors`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`identifycompetitors`|
|DefaultValue|False|
|True Label|completed|
|False Label|mark complete|

### <a name="BKMK_IdentifyCustomerContacts"></a> IdentifyCustomerContacts

|Property|Value|
|---|---|
|Description|**Select whether the customer contacts for this opportunity have been identified.**|
|DisplayName|**Identify Customer Contacts**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`identifycustomercontacts`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`identifycustomercontacts`|
|DefaultValue|False|
|True Label|completed|
|False Label|mark complete|

### <a name="BKMK_IdentifyPursuitTeam"></a> IdentifyPursuitTeam

|Property|Value|
|---|---|
|Description|**Choose whether you have recorded who will pursue the opportunity.**|
|DisplayName|**Identify Sales Team**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`identifypursuitteam`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`identifypursuitteam`|
|DefaultValue|False|
|True Label|completed|
|False Label|mark complete|

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

### <a name="BKMK_InitialCommunication"></a> InitialCommunication

|Property|Value|
|---|---|
|Description|**Choose whether someone from the sales team contacted this lead earlier.**|
|DisplayName|**Initial Communication**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`initialcommunication`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`initialcommunication`|

#### InitialCommunication Choices/Options

|Value|Label|
|---|---|
|0|**Contacted**|
|1|**Not Contacted**|

### <a name="BKMK_IsRevenueSystemCalculated"></a> IsRevenueSystemCalculated

|Property|Value|
|---|---|
|Description|**Select whether the estimated revenue for the opportunity is calculated automatically based on the products entered or entered manually by a user.**|
|DisplayName|**Revenue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`isrevenuesystemcalculated`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`opportunity_isrevenuesystemcalculated`|
|DefaultValue|False|
|True Label|System Calculated|
|False Label|User Provided|

### <a name="BKMK_LastOnHoldTime"></a> LastOnHoldTime

|Property|Value|
|---|---|
|Description|**Contains the date time stamp of the last on hold time.**|
|DisplayName|**Last On Hold Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`lastonholdtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_forecastcategory"></a> msdyn_forecastcategory

|Property|Value|
|---|---|
|Description|**Categories used for forecasting.**|
|DisplayName|**Forecast category**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastcategory`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000001|
|GlobalChoiceName|`msdyn_opportunity_msdyn_forecastcategory`|

#### msdyn_forecastcategory Choices/Options

|Value|Label|
|---|---|
|100000001|**Pipeline**|
|100000002|**Best case**|
|100000003|**Committed**|
|100000004|**Omitted**|
|100000005|**Won**|
|100000006|**Lost**|

### <a name="BKMK_msdyn_gdproptout"></a> msdyn_gdproptout

|Property|Value|
|---|---|
|Description|**Describes whether opportunity is opted out or not**|
|DisplayName|**GDPR Optout**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_gdproptout`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_opportunity_msdyn_gdproptout`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_OpportunityGrade"></a> msdyn_OpportunityGrade

|Property|Value|
|---|---|
|Description||
|DisplayName|**(Deprecated) Opportunity Grade**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_opportunitygrade`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_opportunitygradeoptset`|

#### msdyn_OpportunityGrade Choices/Options

|Value|Label|
|---|---|
|0|**Grade A**|
|1|**Grade B**|
|2|**Grade C**|
|3|**Grade D**|

### <a name="BKMK_msdyn_opportunitykpiid"></a> msdyn_opportunitykpiid

|Property|Value|
|---|---|
|Description|**Maps to opportunity KPI records**|
|DisplayName|**KPI**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_opportunitykpiid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_opportunitykpiitem|

### <a name="BKMK_msdyn_OpportunityScore"></a> msdyn_OpportunityScore

|Property|Value|
|---|---|
|Description||
|DisplayName|**(Deprecated) Opportunity Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_opportunityscore`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_OpportunityScoreTrend"></a> msdyn_OpportunityScoreTrend

|Property|Value|
|---|---|
|Description||
|DisplayName|**(Deprecated) Opportunity Score Trend**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_opportunityscoretrend`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_opportunityscoretrendoptset`|

#### msdyn_OpportunityScoreTrend Choices/Options

|Value|Label|
|---|---|
|0|**Improving**|
|1|**Steady**|
|2|**Declining**|
|3|**Not enough info**|

### <a name="BKMK_msdyn_PredictiveScoreId"></a> msdyn_PredictiveScoreId

|Property|Value|
|---|---|
|Description|**Predictive score**|
|DisplayName|**Predictive Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_predictivescoreid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_predictivescore|

### <a name="BKMK_msdyn_ScoreHistory"></a> msdyn_ScoreHistory

|Property|Value|
|---|---|
|Description||
|DisplayName|**(Deprecated) Score History**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scorehistory`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_ScoreReasons"></a> msdyn_ScoreReasons

|Property|Value|
|---|---|
|Description||
|DisplayName|**(Deprecated) Score Reasons**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scorereasons`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_segmentid"></a> msdyn_segmentid

|Property|Value|
|---|---|
|Description|**Unique identifier for Segment associated with Opportunity.**|
|DisplayName|**Segment Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_segmentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_segment|

### <a name="BKMK_msdyn_similaropportunities"></a> msdyn_similaropportunities

|Property|Value|
|---|---|
|Description||
|DisplayName|**msdyn_similaropportunities**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_similaropportunities`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|65536|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**Type a subject or descriptive name, such as the expected order or company name, for the opportunity.**|
|DisplayName|**Topic**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_Need"></a> Need

|Property|Value|
|---|---|
|Description|**Choose how high the level of need is for the lead's company.**|
|DisplayName|**Need**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`need`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`need`|

#### Need Choices/Options

|Value|Label|
|---|---|
|0|**Must have**|
|1|**Should have**|
|2|**Good to have**|
|3|**No need**|

### <a name="BKMK_OpportunityId"></a> OpportunityId

|Property|Value|
|---|---|
|Description|**Unique identifier of the opportunity.**|
|DisplayName|**Opportunity**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`opportunityid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_OpportunityRatingCode"></a> OpportunityRatingCode

|Property|Value|
|---|---|
|Description|**Select the expected value or priority of the opportunity based on revenue, customer status, or closing probability.**|
|DisplayName|**Rating**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`opportunityratingcode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|2|
|GlobalChoiceName|`opportunity_opportunityratingcode`|

#### OpportunityRatingCode Choices/Options

|Value|Label|
|---|---|
|1|**Hot**|
|2|**Warm**|
|3|**Cold**|

### <a name="BKMK_OriginatingLeadId"></a> OriginatingLeadId

|Property|Value|
|---|---|
|Description|**Choose the lead that the opportunity was created from for reporting and analytics. The field is read-only after the opportunity is created and defaults to the correct lead when an opportunity is created from a converted lead.**|
|DisplayName|**Originating Lead**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`originatingleadid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|lead|

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

### <a name="BKMK_ParentAccountId"></a> ParentAccountId

|Property|Value|
|---|---|
|Description|**Choose an account to connect this opportunity to, so that the relationship is visible in reports and analytics, and to provide a quick link to additional details, such as financial information and activities.**|
|DisplayName|**Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`parentaccountid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_ParentContactId"></a> ParentContactId

|Property|Value|
|---|---|
|Description|**Choose a contact to connect this opportunity to, so that the relationship is visible in reports and analytics.**|
|DisplayName|**Contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`parentcontactid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_ParticipatesInWorkflow"></a> ParticipatesInWorkflow

|Property|Value|
|---|---|
|Description|**Information about whether the opportunity participates in workflow rules.**|
|DisplayName|**Participates in Workflow**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`participatesinworkflow`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`opportunity_participatesinworkflow`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_PresentFinalProposal"></a> PresentFinalProposal

|Property|Value|
|---|---|
|Description|**Select whether the final proposal has been presented to the account.**|
|DisplayName|**Present Final Proposal**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`presentfinalproposal`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`identifypursuitteam`|
|DefaultValue|False|
|True Label|completed|
|False Label|mark complete|

### <a name="BKMK_PresentProposal"></a> PresentProposal

|Property|Value|
|---|---|
|Description|**Select whether a proposal for the opportunity has been presented to the account.**|
|DisplayName|**Presented Proposal**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`presentproposal`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`opportunity_presentproposal`|
|DefaultValue|False|
|True Label|Completed|
|False Label|Mark complete|

### <a name="BKMK_PriceLevelId"></a> PriceLevelId

|Property|Value|
|---|---|
|Description|**Choose the price list associated with this record to make sure the products associated with the campaign are offered at the correct prices.**|
|DisplayName|**Price List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`pricelevelid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|pricelevel|

### <a name="BKMK_PricingErrorCode"></a> PricingErrorCode

|Property|Value|
|---|---|
|Description|**Pricing error for the opportunity.**|
|DisplayName|**Pricing Error**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`pricingerrorcode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`qooi_pricingerrorcode`|

#### PricingErrorCode Choices/Options

|Value|Label|
|---|---|
|0|**None**|
|1|**Detail Error**|
|2|**Missing Price Level**|
|3|**Inactive Price Level**|
|4|**Missing Quantity**|
|5|**Missing Unit Price**|
|6|**Missing Product**|
|7|**Invalid Product**|
|8|**Missing Pricing Code**|
|9|**Invalid Pricing Code**|
|10|**Missing UOM**|
|11|**Product Not In Price Level**|
|12|**Missing Price Level Amount**|
|13|**Missing Price Level Percentage**|
|14|**Missing Price**|
|15|**Missing Current Cost**|
|16|**Missing Standard Cost**|
|17|**Invalid Price Level Amount**|
|18|**Invalid Price Level Percentage**|
|19|**Invalid Price**|
|20|**Invalid Current Cost**|
|21|**Invalid Standard Cost**|
|22|**Invalid Rounding Policy**|
|23|**Invalid Rounding Option**|
|24|**Invalid Rounding Amount**|
|25|**Price Calculation Error**|
|26|**Invalid Discount Type**|
|27|**Discount Type Invalid State**|
|28|**Invalid Discount**|
|29|**Invalid Quantity**|
|30|**Invalid Pricing Precision**|
|31|**Missing Product Default UOM**|
|32|**Missing Product UOM Schedule**|
|33|**Inactive Discount Type**|
|34|**Invalid Price Level Currency**|
|35|**Price Attribute Out Of Range**|
|36|**Base Currency Attribute Overflow**|
|37|**Base Currency Attribute Underflow**|
|38|**Transaction currency is not set for the product price list item**|

### <a name="BKMK_PriorityCode"></a> PriorityCode

|Property|Value|
|---|---|
|Description|**Select the priority so that preferred customers or critical issues are handled quickly.**|
|DisplayName|**Priority**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`prioritycode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`opportunity_prioritycode`|

#### PriorityCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

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

### <a name="BKMK_ProposedSolution"></a> ProposedSolution

|Property|Value|
|---|---|
|Description|**Type notes about the proposed solution for the opportunity.**|
|DisplayName|**Proposed Solution**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`proposedsolution`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_PurchaseProcess"></a> PurchaseProcess

|Property|Value|
|---|---|
|Description|**Choose whether an individual or a committee will be involved in the  purchase process for the lead.**|
|DisplayName|**Purchase Process**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`purchaseprocess`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`purchaseprocess`|

#### PurchaseProcess Choices/Options

|Value|Label|
|---|---|
|0|**Individual**|
|1|**Committee**|
|2|**Unknown**|

### <a name="BKMK_PurchaseTimeframe"></a> PurchaseTimeframe

|Property|Value|
|---|---|
|Description|**Choose how long the lead will likely take to make the purchase.**|
|DisplayName|**Purchase Timeframe**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`purchasetimeframe`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`purchasetimeframe`|

#### PurchaseTimeframe Choices/Options

|Value|Label|
|---|---|
|0|**Immediate**|
|1|**This Quarter**|
|2|**Next Quarter**|
|3|**This Year**|
|4|**Unknown**|

### <a name="BKMK_PursuitDecision"></a> PursuitDecision

|Property|Value|
|---|---|
|Description|**Select whether the decision about pursuing the opportunity has been made.**|
|DisplayName|**Decide Go/No-Go**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`pursuitdecision`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`opportunity_pursuitdecision`|
|DefaultValue|False|
|True Label|No|
|False Label|Yes|

### <a name="BKMK_QualificationComments"></a> QualificationComments

|Property|Value|
|---|---|
|Description|**Type comments about the qualification or scoring of the lead.**|
|DisplayName|**Qualification Comments**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`qualificationcomments`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_QuoteComments"></a> QuoteComments

|Property|Value|
|---|---|
|Description|**Type comments about the quotes associated with the opportunity.**|
|DisplayName|**Quote Comments**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`quotecomments`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_ResolveFeedback"></a> ResolveFeedback

|Property|Value|
|---|---|
|Description|**Choose whether the proposal feedback has been captured and resolved for the opportunity.**|
|DisplayName|**Feedback Resolved**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`resolvefeedback`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`opportunity_resolvefeedback`|
|DefaultValue|False|
|True Label|No|
|False Label|Yes|

### <a name="BKMK_SalesStage"></a> SalesStage

|Property|Value|
|---|---|
|Description|**Select the sales stage of this opportunity to aid the sales team in their efforts to win this opportunity.**|
|DisplayName|**Sales Stage**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`salesstage`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`opportunity_salesstage`|

#### SalesStage Choices/Options

|Value|Label|
|---|---|
|0|**Qualify**|
|1|**Develop**|
|2|**Propose**|
|3|**Close**|

### <a name="BKMK_SalesStageCode"></a> SalesStageCode

|Property|Value|
|---|---|
|Description|**Select the sales process stage for the opportunity to indicate the probability of closing the opportunity.**|
|DisplayName|**Process Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`salesstagecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`opportunity_salesstagecode`|

#### SalesStageCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

### <a name="BKMK_ScheduleFollowup_Prospect"></a> ScheduleFollowup_Prospect

|Property|Value|
|---|---|
|Description|**Enter the date and time of the prospecting follow-up meeting with the lead.**|
|DisplayName|**Scheduled Follow up (Prospect)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`schedulefollowup_prospect`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ScheduleFollowup_Qualify"></a> ScheduleFollowup_Qualify

|Property|Value|
|---|---|
|Description|**Enter the date and time of the qualifying follow-up meeting with the lead.**|
|DisplayName|**Scheduled Follow up (Qualify)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`schedulefollowup_qualify`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ScheduleProposalMeeting"></a> ScheduleProposalMeeting

|Property|Value|
|---|---|
|Description|**Enter the date and time of the proposal meeting for the opportunity.**|
|DisplayName|**Schedule Proposal Meeting**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`scheduleproposalmeeting`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_SendThankYouNote"></a> SendThankYouNote

|Property|Value|
|---|---|
|Description|**Select whether a thank you note has been sent to the account for considering the proposal.**|
|DisplayName|**Send Thank You Note**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sendthankyounote`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`opportunity_sendthankyounote`|
|DefaultValue|False|
|True Label|Completed|
|False Label|Mark complete|

### <a name="BKMK_SkipPriceCalculation"></a> SkipPriceCalculation

|Property|Value|
|---|---|
|Description|**Skip Price Calculation (For Internal Use)**|
|DisplayName|**Skip Price Calculation**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`skippricecalculation`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`qooi_skippricecalculation`|

#### SkipPriceCalculation Choices/Options

|Value|Label|
|---|---|
|0|**DoPriceCalcAlways**|
|1|**SkipPriceCalcOnRetrieve**|

### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|---|---|
|Description|**Choose the service level agreement (SLA) that you want to apply to the opportunity record.**|
|DisplayName|**SLA**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`slaid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|sla|

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
|Description|**Shows whether the opportunity is open, won, or lost. Won and lost opportunities are read-only and can't be edited until they are reactivated.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue|0|
|GlobalChoiceName|`opportunity_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Open**<br />DefaultStatus: 1<br />InvariantName: `Open`|
|1|Label: **Won**<br />DefaultStatus: 3<br />InvariantName: `Won`|
|2|Label: **Lost**<br />DefaultStatus: 4<br />InvariantName: `Lost`|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Select the opportunity's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue|-1|
|GlobalChoiceName|`opportunity_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|1|Label: **In Progress**<br />State:0<br />TransitionData: None|
|2|Label: **On Hold**<br />State:0<br />TransitionData: None|
|3|Label: **Won**<br />State:1<br />TransitionData: None|
|4|Label: **Canceled**<br />State:2<br />TransitionData: None|
|5|Label: **Out-Sold**<br />State:2<br />TransitionData: None|

### <a name="BKMK_StepId"></a> StepId

|Property|Value|
|---|---|
|Description|**Shows the ID of the workflow step.**|
|DisplayName|**Step**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`stepid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_StepName"></a> StepName

|Property|Value|
|---|---|
|Description|**Shows the current phase in the sales pipeline for the opportunity.**|
|DisplayName|**Pipeline Phase**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`stepname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_TeamsFollowed"></a> TeamsFollowed

|Property|Value|
|---|---|
|Description|**Number of users or conversations followed the record**|
|DisplayName|**TeamsFollowed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`teamsfollowed`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_TimeLine"></a> TimeLine

|Property|Value|
|---|---|
|Description|**Select when the opportunity is likely to be closed.**|
|DisplayName|**Timeline**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`timeline`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`opportunity_timeline`|

#### TimeLine Choices/Options

|Value|Label|
|---|---|
|0|**Immediate**|
|1|**This Quarter**|
|2|**Next Quarter**|
|3|**This Year**|
|4|**Not known**|

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

### <a name="BKMK_TotalAmount"></a> TotalAmount

|Property|Value|
|---|---|
|Description|**Shows the total amount due, calculated as the sum of the products, discounts, freight, and taxes for the opportunity.**|
|DisplayName|**Total Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totalamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalAmountLessFreight"></a> TotalAmountLessFreight

|Property|Value|
|---|---|
|Description|**Shows the total product amount for the opportunity, minus any discounts. This value is added to freight and tax amounts in the calculation for the total amount of the opportunity.**|
|DisplayName|**Total Pre-Freight Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totalamountlessfreight`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalDiscountAmount"></a> TotalDiscountAmount

|Property|Value|
|---|---|
|Description|**Shows the total discount amount, based on the discount price and rate entered on the opportunity.**|
|DisplayName|**Total Discount Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totaldiscountamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalLineItemAmount"></a> TotalLineItemAmount

|Property|Value|
|---|---|
|Description|**Shows the sum of all existing and write-in products included on the opportunity, based on the specified price list and quantities.**|
|DisplayName|**Total Detail Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totallineitemamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalLineItemDiscountAmount"></a> TotalLineItemDiscountAmount

|Property|Value|
|---|---|
|Description|**Shows the total of the Manual Discount amounts specified on all products included in the opportunity. This value is reflected in the Total Detail Amount field on the opportunity and is added to any discount amount or rate specified on the opportunity.**|
|DisplayName|**Total Line Item Discount Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totallineitemdiscountamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|0 (Precision property)|

### <a name="BKMK_TotalTax"></a> TotalTax

|Property|Value|
|---|---|
|Description|**Shows the total of the Tax amounts specified on all products included in the opportunity, included in the Total Amount field calculation for the opportunity.**|
|DisplayName|**Total Tax**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totaltax`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

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

- [AccountId](#BKMK_AccountId)
- [ActualValue_Base](#BKMK_ActualValue_Base)
- [BudgetAmount_Base](#BKMK_BudgetAmount_Base)
- [ContactId](#BKMK_ContactId)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CustomerIdName](#BKMK_CustomerIdName)
- [CustomerIdYomiName](#BKMK_CustomerIdYomiName)
- [DiscountAmount_Base](#BKMK_DiscountAmount_Base)
- [EstimatedValue_Base](#BKMK_EstimatedValue_Base)
- [ExchangeRate](#BKMK_ExchangeRate)
- [FreightAmount_Base](#BKMK_FreightAmount_Base)
- [IsPrivate](#BKMK_IsPrivate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OnHoldTime](#BKMK_OnHoldTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [SLAInvokedId](#BKMK_SLAInvokedId)
- [TimeSpentByMeOnEmailAndMeetings](#BKMK_TimeSpentByMeOnEmailAndMeetings)
- [TotalAmount_Base](#BKMK_TotalAmount_Base)
- [TotalAmountLessFreight_Base](#BKMK_TotalAmountLessFreight_Base)
- [TotalDiscountAmount_Base](#BKMK_TotalDiscountAmount_Base)
- [TotalLineItemAmount_Base](#BKMK_TotalLineItemAmount_Base)
- [TotalLineItemDiscountAmount_Base](#BKMK_TotalLineItemDiscountAmount_Base)
- [TotalTax_Base](#BKMK_TotalTax_Base)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_AccountId"></a> AccountId

|Property|Value|
|---|---|
|Description|**Internal attribute for storing customerid. Do not use this attribute directly; use parentaccountid instead.**|
|DisplayName|**Account**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`accountid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_ActualValue_Base"></a> ActualValue_Base

|Property|Value|
|---|---|
|Description|**Value of the Actual Revenue in base currency.**|
|DisplayName|**Actual Revenue (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`actualvalue_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_BudgetAmount_Base"></a> BudgetAmount_Base

|Property|Value|
|---|---|
|Description|**Value of the Budget Amount in base currency.**|
|DisplayName|**Budget Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`budgetamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_ContactId"></a> ContactId

|Property|Value|
|---|---|
|Description|**Internal attribute for storing customerid. Do not use this attribute directly; use parentcontactid instead.**|
|DisplayName|**Contact**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`contactid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

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

### <a name="BKMK_CustomerIdName"></a> CustomerIdName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`customeridname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|160|

### <a name="BKMK_CustomerIdYomiName"></a> CustomerIdYomiName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`customeridyominame`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|450|

### <a name="BKMK_DiscountAmount_Base"></a> DiscountAmount_Base

|Property|Value|
|---|---|
|Description|**Value of the Opportunity Discount Amount in base currency.**|
|DisplayName|**Opportunity Discount Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`discountamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_EstimatedValue_Base"></a> EstimatedValue_Base

|Property|Value|
|---|---|
|Description|**Value of the Est. Revenue in base currency.**|
|DisplayName|**Est. Revenue (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`estimatedvalue_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

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

### <a name="BKMK_FreightAmount_Base"></a> FreightAmount_Base

|Property|Value|
|---|---|
|Description|**Value of the Freight Amount in base currency.**|
|DisplayName|**Freight Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`freightamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_IsPrivate"></a> IsPrivate

|Property|Value|
|---|---|
|Description|**Indicates whether the opportunity is private or visible to the entire organization.**|
|DisplayName|**Is Private**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`isprivate`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`opportunity_isprivate`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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

### <a name="BKMK_OnHoldTime"></a> OnHoldTime

|Property|Value|
|---|---|
|Description|**Shows the duration in minutes for which the opportunity was on hold.**|
|DisplayName|**On Hold Time (Minutes)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`onholdtime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

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

### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

|Property|Value|
|---|---|
|Description|**Last SLA that was applied to this opportunity. This field is for internal use only.**|
|DisplayName|**Last SLA applied**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`slainvokedid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|sla|

### <a name="BKMK_TimeSpentByMeOnEmailAndMeetings"></a> TimeSpentByMeOnEmailAndMeetings

|Property|Value|
|---|---|
|Description|**Total time spent for emails (read and write) and meetings by me in relation to the opportunity record.**|
|DisplayName|**Time Spent by me**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timespentbymeonemailandmeetings`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

### <a name="BKMK_TotalAmount_Base"></a> TotalAmount_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Amount in base currency.**|
|DisplayName|**Total Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totalamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalAmountLessFreight_Base"></a> TotalAmountLessFreight_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Pre-Freight Amount in base currency.**|
|DisplayName|**Total Pre-Freight Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totalamountlessfreight_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalDiscountAmount_Base"></a> TotalDiscountAmount_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Discount Amount in base currency.**|
|DisplayName|**Total Discount Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totaldiscountamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalLineItemAmount_Base"></a> TotalLineItemAmount_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Detail Amount in base currency.**|
|DisplayName|**Total Detail Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totallineitemamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalLineItemDiscountAmount_Base"></a> TotalLineItemDiscountAmount_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Line Item Discount Amount in base currency.**|
|DisplayName|**Total Line Item Discount Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totallineitemdiscountamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalTax_Base"></a> TotalTax_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Tax in base currency.**|
|DisplayName|**Total Tax (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totaltax_base`|
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

- [business_unit_opportunities](#BKMK_business_unit_opportunities)
- [campaign_opportunities](#BKMK_campaign_opportunities)
- [lk_opportunity_createdonbehalfby](#BKMK_lk_opportunity_createdonbehalfby)
- [lk_opportunity_modifiedonbehalfby](#BKMK_lk_opportunity_modifiedonbehalfby)
- [lk_opportunitybase_createdby](#BKMK_lk_opportunitybase_createdby)
- [lk_opportunitybase_modifiedby](#BKMK_lk_opportunitybase_modifiedby)
- [manualsla_opportunity](#BKMK_manualsla_opportunity)
- [msdyn_msdyn_opportunitykpiitem_opportunity_opportunitykpiid](#BKMK_msdyn_msdyn_opportunitykpiitem_opportunity_opportunitykpiid)
- [msdyn_msdyn_predictivescore_opportunity](#BKMK_msdyn_msdyn_predictivescore_opportunity)
- [msdyn_msdyn_segment_opportunity](#BKMK_msdyn_msdyn_segment_opportunity)
- [opportunity_customer_accounts](#BKMK_opportunity_customer_accounts)
- [opportunity_customer_contacts](#BKMK_opportunity_customer_contacts)
- [opportunity_originating_lead](#BKMK_opportunity_originating_lead)
- [opportunity_owning_user](#BKMK_opportunity_owning_user)
- [opportunity_parent_account](#BKMK_opportunity_parent_account)
- [opportunity_parent_contact](#BKMK_opportunity_parent_contact)
- [owner_opportunitys](#BKMK_owner_opportunitys)
- [price_level_opportunties](#BKMK_price_level_opportunties)
- [processstage_opportunity](#BKMK_processstage_opportunity)
- [sla_opportunity](#BKMK_sla_opportunity)
- [team_opportunities](#BKMK_team_opportunities)
- [transactioncurrency_opportunity](#BKMK_transactioncurrency_opportunity)

### <a name="BKMK_business_unit_opportunities"></a> business_unit_opportunities

One-To-Many Relationship: [businessunit business_unit_opportunities](businessunit.md#BKMK_business_unit_opportunities)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaign_opportunities"></a> campaign_opportunities

One-To-Many Relationship: [campaign campaign_opportunities](campaign.md#BKMK_campaign_opportunities)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`campaignid`|
|ReferencingEntityNavigationPropertyName|`campaignid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_opportunity_createdonbehalfby"></a> lk_opportunity_createdonbehalfby

One-To-Many Relationship: [systemuser lk_opportunity_createdonbehalfby](systemuser.md#BKMK_lk_opportunity_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_opportunity_modifiedonbehalfby"></a> lk_opportunity_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_opportunity_modifiedonbehalfby](systemuser.md#BKMK_lk_opportunity_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_opportunitybase_createdby"></a> lk_opportunitybase_createdby

One-To-Many Relationship: [systemuser lk_opportunitybase_createdby](systemuser.md#BKMK_lk_opportunitybase_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_opportunitybase_modifiedby"></a> lk_opportunitybase_modifiedby

One-To-Many Relationship: [systemuser lk_opportunitybase_modifiedby](systemuser.md#BKMK_lk_opportunitybase_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_manualsla_opportunity"></a> manualsla_opportunity

One-To-Many Relationship: [sla manualsla_opportunity](sla.md#BKMK_manualsla_opportunity)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slaid`|
|ReferencingEntityNavigationPropertyName|`sla_opportunity_sla`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_opportunitykpiitem_opportunity_opportunitykpiid"></a> msdyn_msdyn_opportunitykpiitem_opportunity_opportunitykpiid

One-To-Many Relationship: [msdyn_opportunitykpiitem msdyn_msdyn_opportunitykpiitem_opportunity_opportunitykpiid](msdyn_opportunitykpiitem.md#BKMK_msdyn_msdyn_opportunitykpiitem_opportunity_opportunitykpiid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_opportunitykpiitem`|
|ReferencedAttribute|`msdyn_opportunitykpiitemid`|
|ReferencingAttribute|`msdyn_opportunitykpiid`|
|ReferencingEntityNavigationPropertyName|`msdyn_opportunitykpiid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_predictivescore_opportunity"></a> msdyn_msdyn_predictivescore_opportunity

One-To-Many Relationship: [msdyn_predictivescore msdyn_msdyn_predictivescore_opportunity](msdyn_predictivescore.md#BKMK_msdyn_msdyn_predictivescore_opportunity)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_predictivescore`|
|ReferencedAttribute|`msdyn_predictivescoreid`|
|ReferencingAttribute|`msdyn_predictivescoreid`|
|ReferencingEntityNavigationPropertyName|`msdyn_PredictiveScoreId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_segment_opportunity"></a> msdyn_msdyn_segment_opportunity

One-To-Many Relationship: [msdyn_segment msdyn_msdyn_segment_opportunity](msdyn_segment.md#BKMK_msdyn_msdyn_segment_opportunity)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_segment`|
|ReferencedAttribute|`msdyn_segmentid`|
|ReferencingAttribute|`msdyn_segmentid`|
|ReferencingEntityNavigationPropertyName|`msdyn_segmentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunity_customer_accounts"></a> opportunity_customer_accounts

One-To-Many Relationship: [account opportunity_customer_accounts](account.md#BKMK_opportunity_customer_accounts)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`customerid`|
|ReferencingEntityNavigationPropertyName|`customerid_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_opportunity_customer_contacts"></a> opportunity_customer_contacts

One-To-Many Relationship: [contact opportunity_customer_contacts](contact.md#BKMK_opportunity_customer_contacts)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`customerid`|
|ReferencingEntityNavigationPropertyName|`customerid_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_opportunity_originating_lead"></a> opportunity_originating_lead

One-To-Many Relationship: [lead opportunity_originating_lead](lead.md#BKMK_opportunity_originating_lead)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`originatingleadid`|
|ReferencingEntityNavigationPropertyName|`originatingleadid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunity_owning_user"></a> opportunity_owning_user

One-To-Many Relationship: [systemuser opportunity_owning_user](systemuser.md#BKMK_opportunity_owning_user)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunity_parent_account"></a> opportunity_parent_account

One-To-Many Relationship: [account opportunity_parent_account](account.md#BKMK_opportunity_parent_account)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`parentaccountid`|
|ReferencingEntityNavigationPropertyName|`parentaccountid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunity_parent_contact"></a> opportunity_parent_contact

One-To-Many Relationship: [contact opportunity_parent_contact](contact.md#BKMK_opportunity_parent_contact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`parentcontactid`|
|ReferencingEntityNavigationPropertyName|`parentcontactid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_opportunitys"></a> owner_opportunitys

One-To-Many Relationship: [owner owner_opportunitys](owner.md#BKMK_owner_opportunitys)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_price_level_opportunties"></a> price_level_opportunties

One-To-Many Relationship: [pricelevel price_level_opportunties](pricelevel.md#BKMK_price_level_opportunties)

|Property|Value|
|---|---|
|ReferencedEntity|`pricelevel`|
|ReferencedAttribute|`pricelevelid`|
|ReferencingAttribute|`pricelevelid`|
|ReferencingEntityNavigationPropertyName|`pricelevelid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_opportunity"></a> processstage_opportunity

One-To-Many Relationship: [processstage processstage_opportunity](processstage.md#BKMK_processstage_opportunity)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid_processstage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_sla_opportunity"></a> sla_opportunity

One-To-Many Relationship: [sla sla_opportunity](sla.md#BKMK_sla_opportunity)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slainvokedid`|
|ReferencingEntityNavigationPropertyName|`slainvokedid_opportunity_sla`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_opportunities"></a> team_opportunities

One-To-Many Relationship: [team team_opportunities](team.md#BKMK_team_opportunities)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_transactioncurrency_opportunity"></a> transactioncurrency_opportunity

One-To-Many Relationship: [transactioncurrency transactioncurrency_opportunity](transactioncurrency.md#BKMK_transactioncurrency_opportunity)

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

- [CreatedOpportunity_BulkOperationLogs](#BKMK_CreatedOpportunity_BulkOperationLogs)
- [lead_qualifying_opportunity](#BKMK_lead_qualifying_opportunity)
- [lk_leadtoopportunitysalesprocess_opportunityid](#BKMK_lk_leadtoopportunitysalesprocess_opportunityid)
- [lk_opportunitysalesprocess_opportunityid](#BKMK_lk_opportunitysalesprocess_opportunityid)
- [msdyn_msdyn_salescopilotinsight_opportunity_msdyn_targetentityid](#BKMK_msdyn_msdyn_salescopilotinsight_opportunity_msdyn_targetentityid)
- [msdyn_opportunity_dailyopportunitykpiitem_entityid](#BKMK_msdyn_opportunity_dailyopportunitykpiitem_entityid)
- [msdyn_opportunity_msdyn_mostcontacted_regardingObjectId](#BKMK_msdyn_opportunity_msdyn_mostcontacted_regardingObjectId)
- [msdyn_opportunity_msdyn_mostcontactedby_regardingObjectId](#BKMK_msdyn_opportunity_msdyn_mostcontactedby_regardingObjectId)
- [msdyn_opportunity_msdyn_opportunitykpiitem_opportunityid](#BKMK_msdyn_opportunity_msdyn_opportunitykpiitem_opportunityid)
- [msdyn_opportunity_msdyn_salesroutingrun_targetobject](#BKMK_msdyn_opportunity_msdyn_salesroutingrun_targetobject)
- [msdyn_opportunity_msdyn_timespent_opplookup](#BKMK_msdyn_opportunity_msdyn_timespent_opplookup)
- [msdyn_sabackupdiagnostic_opportunity_msdyn_target](#BKMK_msdyn_sabackupdiagnostic_opportunity_msdyn_target)
- [msdyn_salesroutingdiagnostic_opportunity_msdyn_target](#BKMK_msdyn_salesroutingdiagnostic_opportunity_msdyn_target)
- [msdyn_salessuggestion_opportunity_qualifiedrecord](#BKMK_msdyn_salessuggestion_opportunity_qualifiedrecord)
- [msdyn_sequencetarget_opportunity_msdyn_target](#BKMK_msdyn_sequencetarget_opportunity_msdyn_target)
- [opportunity_actioncard](#BKMK_opportunity_actioncard)
- [opportunity_activity_parties](#BKMK_opportunity_activity_parties)
- [Opportunity_ActivityPointers](#BKMK_Opportunity_ActivityPointers)
- [opportunity_adx_inviteredemptions](#BKMK_opportunity_adx_inviteredemptions)
- [opportunity_adx_portalcomments](#BKMK_opportunity_adx_portalcomments)
- [Opportunity_Annotation](#BKMK_Opportunity_Annotation)
- [Opportunity_Appointments](#BKMK_Opportunity_Appointments)
- [Opportunity_AsyncOperations](#BKMK_Opportunity_AsyncOperations)
- [Opportunity_BulkDeleteFailures](#BKMK_Opportunity_BulkDeleteFailures)
- [opportunity_chats](#BKMK_opportunity_chats)
- [opportunity_connections1](#BKMK_opportunity_connections1)
- [opportunity_connections2](#BKMK_opportunity_connections2)
- [Opportunity_DuplicateBaseRecord](#BKMK_Opportunity_DuplicateBaseRecord)
- [Opportunity_DuplicateMatchingRecord](#BKMK_Opportunity_DuplicateMatchingRecord)
- [Opportunity_Emails](#BKMK_Opportunity_Emails)
- [Opportunity_Faxes](#BKMK_Opportunity_Faxes)
- [opportunity_invoices](#BKMK_opportunity_invoices)
- [Opportunity_Letters](#BKMK_Opportunity_Letters)
- [Opportunity_MailboxTrackingFolder](#BKMK_Opportunity_MailboxTrackingFolder)
- [opportunity_msdyn_copilottranscripts](#BKMK_opportunity_msdyn_copilottranscripts)
- [opportunity_msdyn_ocliveworkitems](#BKMK_opportunity_msdyn_ocliveworkitems)
- [opportunity_msdyn_ocsessions](#BKMK_opportunity_msdyn_ocsessions)
- [opportunity_msfp_alerts](#BKMK_opportunity_msfp_alerts)
- [opportunity_msfp_surveyinvites](#BKMK_opportunity_msfp_surveyinvites)
- [opportunity_msfp_surveyresponses](#BKMK_opportunity_msfp_surveyresponses)
- [Opportunity_OpportunityClose](#BKMK_Opportunity_OpportunityClose)
- [opportunity_OpportunityCloses](#BKMK_opportunity_OpportunityCloses)
- [opportunity_OrderCloses](#BKMK_opportunity_OrderCloses)
- [Opportunity_Phonecalls](#BKMK_Opportunity_Phonecalls)
- [opportunity_PostFollows](#BKMK_opportunity_PostFollows)
- [opportunity_PostRegardings](#BKMK_opportunity_PostRegardings)
- [opportunity_Posts](#BKMK_opportunity_Posts)
- [opportunity_principalobjectattributeaccess](#BKMK_opportunity_principalobjectattributeaccess)
- [Opportunity_ProcessSessions](#BKMK_Opportunity_ProcessSessions)
- [opportunity_QuoteCloses](#BKMK_opportunity_QuoteCloses)
- [opportunity_quotes](#BKMK_opportunity_quotes)
- [Opportunity_RecurringAppointmentMasters](#BKMK_Opportunity_RecurringAppointmentMasters)
- [opportunity_sales_orders](#BKMK_opportunity_sales_orders)
- [Opportunity_ServiceAppointments](#BKMK_Opportunity_ServiceAppointments)
- [Opportunity_SharepointDocumentLocation](#BKMK_Opportunity_SharepointDocumentLocation)
- [Opportunity_SocialActivities](#BKMK_Opportunity_SocialActivities)
- [Opportunity_SyncErrors](#BKMK_Opportunity_SyncErrors)
- [Opportunity_Tasks](#BKMK_Opportunity_Tasks)
- [opportunity_Teams](#BKMK_opportunity_Teams)
- [product_opportunities](#BKMK_product_opportunities)
- [slakpiinstance_opportunity](#BKMK_slakpiinstance_opportunity)

### <a name="BKMK_CreatedOpportunity_BulkOperationLogs"></a> CreatedOpportunity_BulkOperationLogs

Many-To-One Relationship: [bulkoperationlog CreatedOpportunity_BulkOperationLogs](bulkoperationlog.md#BKMK_CreatedOpportunity_BulkOperationLogs)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperationlog`|
|ReferencingAttribute|`createdobjectid`|
|ReferencedEntityNavigationPropertyName|`CreatedOpportunity_BulkOperationLogs`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lead_qualifying_opportunity"></a> lead_qualifying_opportunity

Many-To-One Relationship: [lead lead_qualifying_opportunity](lead.md#BKMK_lead_qualifying_opportunity)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`qualifyingopportunityid`|
|ReferencedEntityNavigationPropertyName|`lead_qualifying_opportunity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_leadtoopportunitysalesprocess_opportunityid"></a> lk_leadtoopportunitysalesprocess_opportunityid

Many-To-One Relationship: [leadtoopportunitysalesprocess lk_leadtoopportunitysalesprocess_opportunityid](leadtoopportunitysalesprocess.md#BKMK_lk_leadtoopportunitysalesprocess_opportunityid)

|Property|Value|
|---|---|
|ReferencingEntity|`leadtoopportunitysalesprocess`|
|ReferencingAttribute|`opportunityid`|
|ReferencedEntityNavigationPropertyName|`opportunity_leadtoopportunitysalesprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_opportunitysalesprocess_opportunityid"></a> lk_opportunitysalesprocess_opportunityid

Many-To-One Relationship: [opportunitysalesprocess lk_opportunitysalesprocess_opportunityid](opportunitysalesprocess.md#BKMK_lk_opportunitysalesprocess_opportunityid)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunitysalesprocess`|
|ReferencingAttribute|`opportunityid`|
|ReferencedEntityNavigationPropertyName|`opportunity_opportunitysalesprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_salescopilotinsight_opportunity_msdyn_targetentityid"></a> msdyn_msdyn_salescopilotinsight_opportunity_msdyn_targetentityid

Many-To-One Relationship: [msdyn_salescopilotinsight msdyn_msdyn_salescopilotinsight_opportunity_msdyn_targetentityid](msdyn_salescopilotinsight.md#BKMK_msdyn_msdyn_salescopilotinsight_opportunity_msdyn_targetentityid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salescopilotinsight`|
|ReferencingAttribute|`msdyn_targetentityid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_salescopilotinsight_opportunity_msdyn_targetentityid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunity_dailyopportunitykpiitem_entityid"></a> msdyn_opportunity_dailyopportunitykpiitem_entityid

Many-To-One Relationship: [msdyn_dailyopportunitykpiitem msdyn_opportunity_dailyopportunitykpiitem_entityid](msdyn_dailyopportunitykpiitem.md#BKMK_msdyn_opportunity_dailyopportunitykpiitem_entityid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dailyopportunitykpiitem`|
|ReferencingAttribute|`msdyn_entityid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunity_dailyopportunitykpiitem_entityid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunity_msdyn_mostcontacted_regardingObjectId"></a> msdyn_opportunity_msdyn_mostcontacted_regardingObjectId

Many-To-One Relationship: [msdyn_mostcontacted msdyn_opportunity_msdyn_mostcontacted_regardingObjectId](msdyn_mostcontacted.md#BKMK_msdyn_opportunity_msdyn_mostcontacted_regardingObjectId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mostcontacted`|
|ReferencingAttribute|`msdyn_opportunity_regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunity_msdyn_mostcontacted_regardingObjectId`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunity_msdyn_mostcontactedby_regardingObjectId"></a> msdyn_opportunity_msdyn_mostcontactedby_regardingObjectId

Many-To-One Relationship: [msdyn_mostcontactedby msdyn_opportunity_msdyn_mostcontactedby_regardingObjectId](msdyn_mostcontactedby.md#BKMK_msdyn_opportunity_msdyn_mostcontactedby_regardingObjectId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mostcontactedby`|
|ReferencingAttribute|`msdyn_opportunity_regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunity_msdyn_mostcontactedby_regardingObjectId`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunity_msdyn_opportunitykpiitem_opportunityid"></a> msdyn_opportunity_msdyn_opportunitykpiitem_opportunityid

Many-To-One Relationship: [msdyn_opportunitykpiitem msdyn_opportunity_msdyn_opportunitykpiitem_opportunityid](msdyn_opportunitykpiitem.md#BKMK_msdyn_opportunity_msdyn_opportunitykpiitem_opportunityid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_opportunitykpiitem`|
|ReferencingAttribute|`msdyn_opportunityid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunity_msdyn_opportunitykpiitem_opportunityid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunity_msdyn_salesroutingrun_targetobject"></a> msdyn_opportunity_msdyn_salesroutingrun_targetobject

Many-To-One Relationship: [msdyn_salesroutingrun msdyn_opportunity_msdyn_salesroutingrun_targetobject](msdyn_salesroutingrun.md#BKMK_msdyn_opportunity_msdyn_salesroutingrun_targetobject)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesroutingrun`|
|ReferencingAttribute|`msdyn_targetobject`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunity_msdyn_salesroutingrun_targetobject`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunity_msdyn_timespent_opplookup"></a> msdyn_opportunity_msdyn_timespent_opplookup

Many-To-One Relationship: [msdyn_timespent msdyn_opportunity_msdyn_timespent_opplookup](msdyn_timespent.md#BKMK_msdyn_opportunity_msdyn_timespent_opplookup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timespent`|
|ReferencingAttribute|`msdyn_opplookup`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunity_msdyn_timespent_opplookup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sabackupdiagnostic_opportunity_msdyn_target"></a> msdyn_sabackupdiagnostic_opportunity_msdyn_target

Many-To-One Relationship: [msdyn_sabackupdiagnostic msdyn_sabackupdiagnostic_opportunity_msdyn_target](msdyn_sabackupdiagnostic.md#BKMK_msdyn_sabackupdiagnostic_opportunity_msdyn_target)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sabackupdiagnostic`|
|ReferencingAttribute|`msdyn_target`|
|ReferencedEntityNavigationPropertyName|`msdyn_sabackupdiagnostic_opportunity_msdyn_target`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesroutingdiagnostic_opportunity_msdyn_target"></a> msdyn_salesroutingdiagnostic_opportunity_msdyn_target

Many-To-One Relationship: [msdyn_salesroutingdiagnostic msdyn_salesroutingdiagnostic_opportunity_msdyn_target](msdyn_salesroutingdiagnostic.md#BKMK_msdyn_salesroutingdiagnostic_opportunity_msdyn_target)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesroutingdiagnostic`|
|ReferencingAttribute|`msdyn_target`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesroutingdiagnostic_opportunity_msdyn_target`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_opportunity_qualifiedrecord"></a> msdyn_salessuggestion_opportunity_qualifiedrecord

Many-To-One Relationship: [msdyn_salessuggestion msdyn_salessuggestion_opportunity_qualifiedrecord](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_opportunity_qualifiedrecord)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salessuggestion`|
|ReferencingAttribute|`msdyn_qualifiedrecord`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_opportunity_qualifiedrecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequencetarget_opportunity_msdyn_target"></a> msdyn_sequencetarget_opportunity_msdyn_target

Many-To-One Relationship: [msdyn_sequencetarget msdyn_sequencetarget_opportunity_msdyn_target](msdyn_sequencetarget.md#BKMK_msdyn_sequencetarget_opportunity_msdyn_target)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencetarget`|
|ReferencingAttribute|`msdyn_target`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetarget_opportunity_msdyn_target`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_actioncard"></a> opportunity_actioncard

Many-To-One Relationship: [actioncard opportunity_actioncard](actioncard.md#BKMK_opportunity_actioncard)

|Property|Value|
|---|---|
|ReferencingEntity|`actioncard`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_actioncard`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_activity_parties"></a> opportunity_activity_parties

Many-To-One Relationship: [activityparty opportunity_activity_parties](activityparty.md#BKMK_opportunity_activity_parties)

|Property|Value|
|---|---|
|ReferencingEntity|`activityparty`|
|ReferencingAttribute|`partyid`|
|ReferencedEntityNavigationPropertyName|`opportunity_activity_parties`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Opportunity_ActivityPointers"></a> Opportunity_ActivityPointers

Many-To-One Relationship: [activitypointer Opportunity_ActivityPointers](activitypointer.md#BKMK_Opportunity_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Opportunity_ActivityPointers`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 20<br />QueryApi: `CRMActivity.RollupByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_opportunity_adx_inviteredemptions"></a> opportunity_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption opportunity_adx_inviteredemptions](adx_inviteredemption.md#BKMK_opportunity_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_adx_portalcomments"></a> opportunity_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment opportunity_adx_portalcomments](adx_portalcomment.md#BKMK_opportunity_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Opportunity_Annotation"></a> Opportunity_Annotation

Many-To-One Relationship: [annotation Opportunity_Annotation](annotation.md#BKMK_Opportunity_Annotation)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`Opportunity_Annotation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Opportunity_Appointments"></a> Opportunity_Appointments

Many-To-One Relationship: [appointment Opportunity_Appointments](appointment.md#BKMK_Opportunity_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Opportunity_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Opportunity_AsyncOperations"></a> Opportunity_AsyncOperations

Many-To-One Relationship: [asyncoperation Opportunity_AsyncOperations](asyncoperation.md#BKMK_Opportunity_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Opportunity_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Opportunity_BulkDeleteFailures"></a> Opportunity_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure Opportunity_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Opportunity_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Opportunity_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_chats"></a> opportunity_chats

Many-To-One Relationship: [chat opportunity_chats](chat.md#BKMK_opportunity_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_connections1"></a> opportunity_connections1

Many-To-One Relationship: [connection opportunity_connections1](connection.md#BKMK_opportunity_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`opportunity_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_connections2"></a> opportunity_connections2

Many-To-One Relationship: [connection opportunity_connections2](connection.md#BKMK_opportunity_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`opportunity_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Opportunity_DuplicateBaseRecord"></a> Opportunity_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord Opportunity_DuplicateBaseRecord](duplicaterecord.md#BKMK_Opportunity_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`Opportunity_DuplicateBaseRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Opportunity_DuplicateMatchingRecord"></a> Opportunity_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord Opportunity_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Opportunity_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`Opportunity_DuplicateMatchingRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Opportunity_Emails"></a> Opportunity_Emails

Many-To-One Relationship: [email Opportunity_Emails](email.md#BKMK_Opportunity_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Opportunity_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Opportunity_Faxes"></a> Opportunity_Faxes

Many-To-One Relationship: [fax Opportunity_Faxes](fax.md#BKMK_Opportunity_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Opportunity_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_invoices"></a> opportunity_invoices

Many-To-One Relationship: [invoice opportunity_invoices](invoice.md#BKMK_opportunity_invoices)

|Property|Value|
|---|---|
|ReferencingEntity|`invoice`|
|ReferencingAttribute|`opportunityid`|
|ReferencedEntityNavigationPropertyName|`opportunity_invoices`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Sales`<br />Label: <br />MenuId: null<br />Order: 30<br />QueryApi: `CRMInvoice.RetrieveByObject`<br />ViewId: `a84eb3ff-6dc5-4f57-bbf0-7b664c11fb62`|

### <a name="BKMK_Opportunity_Letters"></a> Opportunity_Letters

Many-To-One Relationship: [letter Opportunity_Letters](letter.md#BKMK_Opportunity_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Opportunity_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Opportunity_MailboxTrackingFolder"></a> Opportunity_MailboxTrackingFolder

Many-To-One Relationship: [mailboxtrackingfolder Opportunity_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_Opportunity_MailboxTrackingFolder)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Opportunity_MailboxTrackingFolder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_msdyn_copilottranscripts"></a> opportunity_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript opportunity_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_opportunity_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_opportunity_msdyn_ocliveworkitems"></a> opportunity_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem opportunity_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_opportunity_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_opportunity_msdyn_ocsessions"></a> opportunity_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession opportunity_msdyn_ocsessions](msdyn_ocsession.md#BKMK_opportunity_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_opportunity_msfp_alerts"></a> opportunity_msfp_alerts

Many-To-One Relationship: [msfp_alert opportunity_msfp_alerts](msfp_alert.md#BKMK_opportunity_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_opportunity_msfp_surveyinvites"></a> opportunity_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite opportunity_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_opportunity_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_opportunity_msfp_surveyresponses"></a> opportunity_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse opportunity_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_opportunity_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_Opportunity_OpportunityClose"></a> Opportunity_OpportunityClose

Many-To-One Relationship: [opportunityclose Opportunity_OpportunityClose](opportunityclose.md#BKMK_Opportunity_OpportunityClose)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`opportunityid`|
|ReferencedEntityNavigationPropertyName|`Opportunity_OpportunityClose`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_OpportunityCloses"></a> opportunity_OpportunityCloses

Many-To-One Relationship: [opportunityclose opportunity_OpportunityCloses](opportunityclose.md#BKMK_opportunity_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_OpportunityCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_opportunity_OrderCloses"></a> opportunity_OrderCloses

Many-To-One Relationship: [orderclose opportunity_OrderCloses](orderclose.md#BKMK_opportunity_OrderCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_OrderCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_Opportunity_Phonecalls"></a> Opportunity_Phonecalls

Many-To-One Relationship: [phonecall Opportunity_Phonecalls](phonecall.md#BKMK_Opportunity_Phonecalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Opportunity_Phonecalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_PostFollows"></a> opportunity_PostFollows

Many-To-One Relationship: [postfollow opportunity_PostFollows](postfollow.md#BKMK_opportunity_PostFollows)

|Property|Value|
|---|---|
|ReferencingEntity|`postfollow`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_PostFollows`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_PostRegardings"></a> opportunity_PostRegardings

Many-To-One Relationship: [postregarding opportunity_PostRegardings](postregarding.md#BKMK_opportunity_PostRegardings)

|Property|Value|
|---|---|
|ReferencingEntity|`postregarding`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_PostRegardings`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_Posts"></a> opportunity_Posts

Many-To-One Relationship: [post opportunity_Posts](post.md#BKMK_opportunity_Posts)

|Property|Value|
|---|---|
|ReferencingEntity|`post`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_Posts`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_principalobjectattributeaccess"></a> opportunity_principalobjectattributeaccess

Many-To-One Relationship: [principalobjectattributeaccess opportunity_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_opportunity_principalobjectattributeaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_principalobjectattributeaccess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Opportunity_ProcessSessions"></a> Opportunity_ProcessSessions

Many-To-One Relationship: [processsession Opportunity_ProcessSessions](processsession.md#BKMK_Opportunity_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Opportunity_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_QuoteCloses"></a> opportunity_QuoteCloses

Many-To-One Relationship: [quoteclose opportunity_QuoteCloses](quoteclose.md#BKMK_opportunity_QuoteCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_QuoteCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_opportunity_quotes"></a> opportunity_quotes

Many-To-One Relationship: [quote opportunity_quotes](quote.md#BKMK_opportunity_quotes)

|Property|Value|
|---|---|
|ReferencingEntity|`quote`|
|ReferencingAttribute|`opportunityid`|
|ReferencedEntityNavigationPropertyName|`opportunity_quotes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Sales`<br />Label: <br />MenuId: null<br />Order: 10<br />QueryApi: `CRMQuote.RetrieveByObject`<br />ViewId: `642095db-91dd-4813-bb31-665a3a2bae61`|

### <a name="BKMK_Opportunity_RecurringAppointmentMasters"></a> Opportunity_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster Opportunity_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_Opportunity_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Opportunity_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_sales_orders"></a> opportunity_sales_orders

Many-To-One Relationship: [salesorder opportunity_sales_orders](salesorder.md#BKMK_opportunity_sales_orders)

|Property|Value|
|---|---|
|ReferencingEntity|`salesorder`|
|ReferencingAttribute|`opportunityid`|
|ReferencedEntityNavigationPropertyName|`opportunity_sales_orders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Sales`<br />Label: <br />MenuId: null<br />Order: 20<br />QueryApi: `CRMSalesOrder.RetrieveByObject`<br />ViewId: `71f7da6e-2772-4097-89d1-3670ff8348bb`|

### <a name="BKMK_Opportunity_ServiceAppointments"></a> Opportunity_ServiceAppointments

Many-To-One Relationship: [serviceappointment Opportunity_ServiceAppointments](serviceappointment.md#BKMK_Opportunity_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Opportunity_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Opportunity_SharepointDocumentLocation"></a> Opportunity_SharepointDocumentLocation

Many-To-One Relationship: [sharepointdocumentlocation Opportunity_SharepointDocumentLocation](sharepointdocumentlocation.md#BKMK_Opportunity_SharepointDocumentLocation)

|Property|Value|
|---|---|
|ReferencingEntity|`sharepointdocumentlocation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Opportunity_SharepointDocumentLocation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Opportunity_SocialActivities"></a> Opportunity_SocialActivities

Many-To-One Relationship: [socialactivity Opportunity_SocialActivities](socialactivity.md#BKMK_Opportunity_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Opportunity_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Opportunity_SyncErrors"></a> Opportunity_SyncErrors

Many-To-One Relationship: [syncerror Opportunity_SyncErrors](syncerror.md#BKMK_Opportunity_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Opportunity_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Opportunity_Tasks"></a> Opportunity_Tasks

Many-To-One Relationship: [task Opportunity_Tasks](task.md#BKMK_Opportunity_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Opportunity_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_Teams"></a> opportunity_Teams

Many-To-One Relationship: [team opportunity_Teams](team.md#BKMK_opportunity_Teams)

|Property|Value|
|---|---|
|ReferencingEntity|`team`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_Teams`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_product_opportunities"></a> product_opportunities

Many-To-One Relationship: [opportunityproduct product_opportunities](opportunityproduct.md#BKMK_product_opportunities)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityproduct`|
|ReferencingAttribute|`opportunityid`|
|ReferencedEntityNavigationPropertyName|`product_opportunities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10<br />QueryApi: `CRMOpportunityProduct.RetrieveByObject`<br />ViewId: `57e13b8f-1788-4c77-9bd4-427a0f71e986`|

### <a name="BKMK_slakpiinstance_opportunity"></a> slakpiinstance_opportunity

Many-To-One Relationship: [slakpiinstance slakpiinstance_opportunity](slakpiinstance.md#BKMK_slakpiinstance_opportunity)

|Property|Value|
|---|---|
|ReferencingEntity|`slakpiinstance`|
|ReferencingAttribute|`regarding`|
|ReferencedEntityNavigationPropertyName|`slakpiinstance_opportunity`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_opportunitycompetitors_association"></a> opportunitycompetitors_association

See [competitor opportunitycompetitors_association Many-To-Many Relationship](competitor.md#BKMK_opportunitycompetitors_association)

|Property|Value|
|---|---|
|IntersectEntityName|`opportunitycompetitors`|
|IsCustomizable|False|
|SchemaName|`opportunitycompetitors_association`|
|IntersectAttribute|`opportunityid`|
|NavigationPropertyName|`opportunitycompetitors_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMOpportunity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001203`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

