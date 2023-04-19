---
title: "Opportunity table/entity reference (Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Opportunity table/entity."
ms.date: 02/17/2023
ms.service: dynamics-365-sales
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "udaykirang"
ms.author: "udag"
search.audienceType: 
  - developer
---

# Opportunity table/entity reference

> [!NOTE]
> Unsure about table vs. entity? See [Developers: Understand terminology in Microsoft Dataverse](/powerapps/developer/data-platform/understand-terminology).

Potential revenue-generating event, or sale to an account, which needs to be tracked through a sales process to completion.

**Added by**: Sales Solution


## Messages

|Message|SDK Assembly|
|-|-|
|Assign|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|CalculateActualValueOpportunity|<xref:Microsoft.Crm.Sdk.Messages.CalculateActualValueOpportunityRequest>|
|CalculatePrice|<xref:Microsoft.Crm.Sdk.Messages.CalculatePriceRequest>|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GetQuantityDecimal|<xref:Microsoft.Crm.Sdk.Messages.GetQuantityDecimalRequest>|
|GrantAccess|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|LoseOpportunity|<xref:Microsoft.Crm.Sdk.Messages.LoseOpportunityRequest>|
|ModifyAccess|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|Rollup|<xref:Microsoft.Crm.Sdk.Messages.RollupRequest>|
|SetState|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|
|WinOpportunity|<xref:Microsoft.Crm.Sdk.Messages.WinOpportunityRequest>|
|WinQuote|<xref:Microsoft.Crm.Sdk.Messages.WinQuoteRequest>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Opportunities|
|DisplayCollectionName|Opportunities|
|DisplayName|Opportunity|
|EntitySetName|opportunities|
|IsBPFEntity|False|
|LogicalCollectionName|opportunities|
|LogicalName|opportunity|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|opportunityid|
|PrimaryNameAttribute|name|
|SchemaName|Opportunity|

<a name="writable-attributes"></a>

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
- [msdyn_OpportunityScore](#BKMK_msdyn_OpportunityScore)
- [msdyn_OpportunityScoreTrend](#BKMK_msdyn_OpportunityScoreTrend)
- [msdyn_PredictiveScoreId](#BKMK_msdyn_PredictiveScoreId)
- [msdyn_ScoreHistory](#BKMK_msdyn_ScoreHistory)
- [msdyn_ScoreReasons](#BKMK_msdyn_ScoreReasons)
- [msdyn_segmentid](#BKMK_msdyn_segmentid)
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
|--------|-----|
|DateTimeBehavior|DateOnly|
|Description|Shows the date and time when the opportunity was closed or canceled.|
|DisplayName|Actual Close Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualclosedate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ActualValue"></a> ActualValue

|Property|Value|
|--------|-----|
|Description|Type the actual revenue amount for the opportunity for reporting and analysis of estimated versus actual sales. Field defaults to the Est. Revenue value when an opportunity is won.|
|DisplayName|Actual Revenue|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualvalue|
|MaxValue|1000000000000|
|MinValue|-1000000000000|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_BudgetAmount"></a> BudgetAmount

|Property|Value|
|--------|-----|
|Description|Type a value between 0 and 1,000,000,000,000 to indicate the lead's potential available budget.|
|DisplayName|Budget Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|budgetamount|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_BudgetStatus"></a> BudgetStatus

|Property|Value|
|--------|-----|
|Description|Select the likely budget status for the lead's company. This may help determine the lead rating or your sales approach.|
|DisplayName|Budget|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|budgetstatus|
|RequiredLevel|None|
|Type|Picklist|

#### BudgetStatus Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|No Committed Budget||
|1|May Buy||
|2|Can Buy||
|3|Will Buy||



### <a name="BKMK_CampaignId"></a> CampaignId

**Added by**: Marketing Sales Solution

|Property|Value|
|--------|-----|
|Description|Shows the campaign that the opportunity was created from. The ID is used for tracking the success of the campaign.|
|DisplayName|Source Campaign|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|campaignid|
|RequiredLevel|None|
|Targets|campaign|
|Type|Lookup|


### <a name="BKMK_CaptureProposalFeedback"></a> CaptureProposalFeedback

|Property|Value|
|--------|-----|
|Description|Choose whether the proposal feedback has been captured for the opportunity.|
|DisplayName|Proposal Feedback Captured|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|captureproposalfeedback|
|RequiredLevel|None|
|Type|Boolean|

#### CaptureProposalFeedback Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|No||
|0|Yes||

**DefaultValue**: 0



### <a name="BKMK_CloseProbability"></a> CloseProbability

|Property|Value|
|--------|-----|
|Description|Type a number from 0 to 100 that represents the likelihood of closing the opportunity. This can aid the sales team in their efforts to convert the opportunity in a sale.|
|DisplayName|Probability|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|closeprobability|
|MaxValue|100|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_CompleteFinalProposal"></a> CompleteFinalProposal

|Property|Value|
|--------|-----|
|Description|Select whether a final proposal has been completed for the opportunity.|
|DisplayName|Final Proposal Ready|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|completefinalproposal|
|RequiredLevel|None|
|Type|Boolean|

#### CompleteFinalProposal Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|completed||
|0|mark complete||

**DefaultValue**: 0



### <a name="BKMK_CompleteInternalReview"></a> CompleteInternalReview

|Property|Value|
|--------|-----|
|Description|Select whether an internal review has been completed for this opportunity.|
|DisplayName|Complete Internal Review|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|completeinternalreview|
|RequiredLevel|None|
|Type|Boolean|

#### CompleteInternalReview Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|completed||
|0|mark complete||

**DefaultValue**: 0



### <a name="BKMK_ConfirmInterest"></a> ConfirmInterest

|Property|Value|
|--------|-----|
|Description|Select whether the lead confirmed interest in your offerings. This helps in determining the lead quality and the probability of it turning into an opportunity.|
|DisplayName|Confirm Interest|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|confirminterest|
|RequiredLevel|None|
|Type|Boolean|

#### ConfirmInterest Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|No||
|0|Yes||

**DefaultValue**: 0



### <a name="BKMK_CurrentSituation"></a> CurrentSituation

|Property|Value|
|--------|-----|
|Description|Type notes about the company or organization associated with the opportunity.|
|DisplayName|Current Situation|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|currentsituation|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_CustomerId"></a> CustomerId

|Property|Value|
|--------|-----|
|Description|Select the customer account or contact to provide a quick link to additional customer details, such as address, phone number, activities, and orders.|
|DisplayName|Potential Customer|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|customerid|
|RequiredLevel|ApplicationRequired|
|Targets|account,contact|
|Type|Customer|


### <a name="BKMK_CustomerIdType"></a> CustomerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Potential Customer Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridtype|
|RequiredLevel|ApplicationRequired|
|Type|EntityName|


### <a name="BKMK_CustomerNeed"></a> CustomerNeed

|Property|Value|
|--------|-----|
|Description|Type some notes about the customer's requirements, to help the sales team identify products and services that could meet their requirements.|
|DisplayName|Customer Need|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|customerneed|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_CustomerPainPoints"></a> CustomerPainPoints

|Property|Value|
|--------|-----|
|Description|Type notes about the customer's pain points to help the sales team identify products and services that could address these pain points.|
|DisplayName|Customer Pain Points|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|customerpainpoints|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_DecisionMaker"></a> DecisionMaker

|Property|Value|
|--------|-----|
|Description|Select whether your notes include information about who makes the purchase decisions at the lead's company.|
|DisplayName|Decision Maker?|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|decisionmaker|
|RequiredLevel|None|
|Type|Boolean|

#### DecisionMaker Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|completed||
|0|mark complete||

**DefaultValue**: 0



### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the opportunity, such as possible products to sell or past purchases from the customer.|
|DisplayName|Description|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_DevelopProposal"></a> DevelopProposal

|Property|Value|
|--------|-----|
|Description|Select whether a proposal has been developed for the opportunity.|
|DisplayName|Develop Proposal|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|developproposal|
|RequiredLevel|None|
|Type|Boolean|

#### DevelopProposal Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|completed||
|0|mark complete||

**DefaultValue**: 0



### <a name="BKMK_DiscountAmount"></a> DiscountAmount

|Property|Value|
|--------|-----|
|Description|Type the discount amount for the opportunity if the customer is eligible for special savings.|
|DisplayName|Opportunity Discount Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|discountamount|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_DiscountPercentage"></a> DiscountPercentage

|Property|Value|
|--------|-----|
|Description|Type the discount rate that should be applied to the Product Totals field to include additional savings for the customer in the opportunity.|
|DisplayName|Opportunity Discount (%)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|discountpercentage|
|MaxValue|100|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


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


### <a name="BKMK_EstimatedCloseDate"></a> EstimatedCloseDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|DateOnly|
|Description|Enter the expected closing date of the opportunity to help make accurate revenue forecasts.|
|DisplayName|Est. Close Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|estimatedclosedate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_EstimatedValue"></a> EstimatedValue

|Property|Value|
|--------|-----|
|Description|Type the estimated revenue amount to indicate the potential sale or value of the opportunity for revenue forecasting. This field can be either system-populated or editable based on the selection in the Revenue field.|
|DisplayName|Est. Revenue|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|estimatedvalue|
|MaxValue|1000000000000|
|MinValue|-1000000000000|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_EvaluateFit"></a> EvaluateFit

|Property|Value|
|--------|-----|
|Description|Select whether the fit between the lead's requirements and your offerings was evaluated.|
|DisplayName|Evaluate Fit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|evaluatefit|
|RequiredLevel|None|
|Type|Boolean|

#### EvaluateFit Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|No||
|0|Yes||

**DefaultValue**: 0



### <a name="BKMK_FileDebrief"></a> FileDebrief

|Property|Value|
|--------|-----|
|Description|Choose whether the sales team has recorded detailed notes on the proposals and the account's responses.|
|DisplayName|File Debrief|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|filedebrief|
|RequiredLevel|None|
|Type|Boolean|

#### FileDebrief Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|completed||
|0|mark complete||

**DefaultValue**: 0



### <a name="BKMK_FinalDecisionDate"></a> FinalDecisionDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|DateOnly|
|Description|Enter the date and time when the final decision of the opportunity was made.|
|DisplayName|Final Decision Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|finaldecisiondate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_FreightAmount"></a> FreightAmount

|Property|Value|
|--------|-----|
|Description|Type the cost of freight or shipping for the products included in the opportunity for use in calculating the Total Amount field.|
|DisplayName|Freight Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|freightamount|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_IdentifyCompetitors"></a> IdentifyCompetitors

|Property|Value|
|--------|-----|
|Description|Select whether information about competitors is included.|
|DisplayName|Identify Competitors|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|identifycompetitors|
|RequiredLevel|None|
|Type|Boolean|

#### IdentifyCompetitors Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|completed||
|0|mark complete||

**DefaultValue**: 0



### <a name="BKMK_IdentifyCustomerContacts"></a> IdentifyCustomerContacts

|Property|Value|
|--------|-----|
|Description|Select whether the customer contacts for this opportunity have been identified.|
|DisplayName|Identify Customer Contacts|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|identifycustomercontacts|
|RequiredLevel|None|
|Type|Boolean|

#### IdentifyCustomerContacts Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|completed||
|0|mark complete||

**DefaultValue**: 0



### <a name="BKMK_IdentifyPursuitTeam"></a> IdentifyPursuitTeam

|Property|Value|
|--------|-----|
|Description|Choose whether you have recorded who will pursue the opportunity.|
|DisplayName|Identify Sales Team|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|identifypursuitteam|
|RequiredLevel|None|
|Type|Boolean|

#### IdentifyPursuitTeam Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|completed||
|0|mark complete||

**DefaultValue**: 0



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


### <a name="BKMK_InitialCommunication"></a> InitialCommunication

|Property|Value|
|--------|-----|
|Description|Choose whether someone from the sales team contacted this lead earlier.|
|DisplayName|Initial Communication|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|initialcommunication|
|RequiredLevel|None|
|Type|Picklist|

#### InitialCommunication Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Contacted||
|1|Not Contacted||



### <a name="BKMK_IsRevenueSystemCalculated"></a> IsRevenueSystemCalculated

|Property|Value|
|--------|-----|
|Description|Select whether the estimated revenue for the opportunity is calculated automatically based on the products entered or entered manually by a user.|
|DisplayName|Revenue|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|isrevenuesystemcalculated|
|RequiredLevel|None|
|Type|Boolean|

#### IsRevenueSystemCalculated Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|System Calculated||
|0|User Provided||

**DefaultValue**: 0



### <a name="BKMK_LastOnHoldTime"></a> LastOnHoldTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Contains the date time stamp of the last on hold time.|
|DisplayName|Last On Hold Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lastonholdtime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_forecastcategory"></a> msdyn_forecastcategory

**Added by**: Forecasting Solution

|Property|Value|
|--------|-----|
|Description|Categories used for forecasting.|
|DisplayName|Forecast category|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_forecastcategory|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_forecastcategory Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|100000001|Pipeline||
|100000002|Best case||
|100000003|Committed||
|100000004|Omitted||
|100000005|Won||
|100000006|Lost||



### <a name="BKMK_msdyn_gdproptout"></a> msdyn_gdproptout

**Added by**: Predictive Lead Scoring Solution

|Property|Value|
|--------|-----|
|Description|Describes whether opportunity is opted out or not|
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



### <a name="BKMK_msdyn_OpportunityGrade"></a> msdyn_OpportunityGrade

**Added by**: Predictive Opportunity Scoring Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|(Deprecated) Opportunity Grade|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_opportunitygrade|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_OpportunityGrade Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Grade A||
|1|Grade B||
|2|Grade C||
|3|Grade D||



### <a name="BKMK_msdyn_OpportunityScore"></a> msdyn_OpportunityScore

**Added by**: Predictive Opportunity Scoring Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|(Deprecated) Opportunity Score|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_opportunityscore|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_OpportunityScoreTrend"></a> msdyn_OpportunityScoreTrend

**Added by**: Predictive Opportunity Scoring Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|(Deprecated) Opportunity Score Trend|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_opportunityscoretrend|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_OpportunityScoreTrend Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Improving||
|1|Steady||
|2|Declining||
|3|Not enough info||



### <a name="BKMK_msdyn_PredictiveScoreId"></a> msdyn_PredictiveScoreId

**Added by**: Predictive Scoring Common Solution

|Property|Value|
|--------|-----|
|Description|Predictive score|
|DisplayName|Predictive Score|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_predictivescoreid|
|RequiredLevel|None|
|Targets|msdyn_predictivescore|
|Type|Lookup|


### <a name="BKMK_msdyn_ScoreHistory"></a> msdyn_ScoreHistory

**Added by**: Predictive Opportunity Scoring Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|(Deprecated) Score History|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_scorehistory|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_ScoreReasons"></a> msdyn_ScoreReasons

**Added by**: Predictive Opportunity Scoring Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|(Deprecated) Score Reasons|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_scorereasons|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_segmentid"></a> msdyn_segmentid

**Added by**: Segment solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for Segment associated with Opportunity.|
|DisplayName|Segment Id|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_segmentid|
|RequiredLevel|None|
|Targets|msdyn_segment|
|Type|Lookup|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Type a subject or descriptive name, such as the expected order or company name, for the opportunity.|
|DisplayName|Topic|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|300|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_Need"></a> Need

|Property|Value|
|--------|-----|
|Description|Choose how high the level of need is for the lead's company.|
|DisplayName|Need|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|need|
|RequiredLevel|None|
|Type|Picklist|

#### Need Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Must have||
|1|Should have||
|2|Good to have||
|3|No need||



### <a name="BKMK_OpportunityId"></a> OpportunityId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the opportunity.|
|DisplayName|Opportunity|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|opportunityid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_OpportunityRatingCode"></a> OpportunityRatingCode

|Property|Value|
|--------|-----|
|Description|Select the expected value or priority of the opportunity based on revenue, customer status, or closing probability.|
|DisplayName|Rating|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|opportunityratingcode|
|RequiredLevel|None|
|Type|Picklist|

#### OpportunityRatingCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Hot||
|2|Warm||
|3|Cold||



### <a name="BKMK_OriginatingLeadId"></a> OriginatingLeadId

|Property|Value|
|--------|-----|
|Description|Choose the lead that the opportunity was created from for reporting and analytics. The field is read-only after the opportunity is created and defaults to the correct lead when an opportunity is created from a converted lead.|
|DisplayName|Originating Lead|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|originatingleadid|
|RequiredLevel|None|
|Targets|lead|
|Type|Lookup|


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


### <a name="BKMK_ParentAccountId"></a> ParentAccountId

|Property|Value|
|--------|-----|
|Description|Choose an account to connect this opportunity to, so that the relationship is visible in reports and analytics, and to provide a quick link to additional details, such as financial information and activities.|
|DisplayName|Account|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|parentaccountid|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_ParentContactId"></a> ParentContactId

|Property|Value|
|--------|-----|
|Description|Choose a contact to connect this opportunity to, so that the relationship is visible in reports and analytics.|
|DisplayName|Contact|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|parentcontactid|
|RequiredLevel|None|
|Targets|contact|
|Type|Lookup|


### <a name="BKMK_ParticipatesInWorkflow"></a> ParticipatesInWorkflow

|Property|Value|
|--------|-----|
|Description|Information about whether the opportunity participates in workflow rules.|
|DisplayName|Participates in Workflow|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|participatesinworkflow|
|RequiredLevel|None|
|Type|Boolean|

#### ParticipatesInWorkflow Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_PresentFinalProposal"></a> PresentFinalProposal

|Property|Value|
|--------|-----|
|Description|Select whether the final proposal has been presented to the account.|
|DisplayName|Present Final Proposal|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|presentfinalproposal|
|RequiredLevel|None|
|Type|Boolean|

#### PresentFinalProposal Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|completed||
|0|mark complete||

**DefaultValue**: 0



### <a name="BKMK_PresentProposal"></a> PresentProposal

|Property|Value|
|--------|-----|
|Description|Select whether a proposal for the opportunity has been presented to the account.|
|DisplayName|Presented Proposal|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|presentproposal|
|RequiredLevel|None|
|Type|Boolean|

#### PresentProposal Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|completed||
|0|mark complete||

**DefaultValue**: 0



### <a name="BKMK_PriceLevelId"></a> PriceLevelId

|Property|Value|
|--------|-----|
|Description|Choose the price list associated with this record to make sure the products associated with the campaign are offered at the correct prices.|
|DisplayName|Price List|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|pricelevelid|
|RequiredLevel|None|
|Targets|pricelevel|
|Type|Lookup|


### <a name="BKMK_PricingErrorCode"></a> PricingErrorCode

|Property|Value|
|--------|-----|
|Description|Pricing error for the opportunity.|
|DisplayName|Pricing Error |
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|pricingerrorcode|
|RequiredLevel|None|
|Type|Picklist|

#### PricingErrorCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|None||
|1|Detail Error||
|2|Missing Price Level||
|3|Inactive Price Level||
|4|Missing Quantity||
|5|Missing Unit Price||
|6|Missing Product||
|7|Invalid Product||
|8|Missing Pricing Code||
|9|Invalid Pricing Code||
|10|Missing UOM||
|11|Product Not In Price Level||
|12|Missing Price Level Amount||
|13|Missing Price Level Percentage||
|14|Missing Price||
|15|Missing Current Cost||
|16|Missing Standard Cost||
|17|Invalid Price Level Amount||
|18|Invalid Price Level Percentage||
|19|Invalid Price||
|20|Invalid Current Cost||
|21|Invalid Standard Cost||
|22|Invalid Rounding Policy||
|23|Invalid Rounding Option||
|24|Invalid Rounding Amount||
|25|Price Calculation Error||
|26|Invalid Discount Type||
|27|Discount Type Invalid State||
|28|Invalid Discount||
|29|Invalid Quantity||
|30|Invalid Pricing Precision||
|31|Missing Product Default UOM||
|32|Missing Product UOM Schedule ||
|33|Inactive Discount Type||
|34|Invalid Price Level Currency||
|35|Price Attribute Out Of Range||
|36|Base Currency Attribute Overflow||
|37|Base Currency Attribute Underflow||
|38|Transaction currency is not set for the product price list item||



### <a name="BKMK_PriorityCode"></a> PriorityCode

|Property|Value|
|--------|-----|
|Description|Select the priority so that preferred customers or critical issues are handled quickly.|
|DisplayName|Priority|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|prioritycode|
|RequiredLevel|None|
|Type|Picklist|

#### PriorityCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



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


### <a name="BKMK_ProposedSolution"></a> ProposedSolution

|Property|Value|
|--------|-----|
|Description|Type notes about the proposed solution for the opportunity.|
|DisplayName|Proposed Solution|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|proposedsolution|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_PurchaseProcess"></a> PurchaseProcess

|Property|Value|
|--------|-----|
|Description|Choose whether an individual or a committee will be involved in the  purchase process for the lead.|
|DisplayName|Purchase Process|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|purchaseprocess|
|RequiredLevel|None|
|Type|Picklist|

#### PurchaseProcess Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Individual||
|1|Committee||
|2|Unknown||



### <a name="BKMK_PurchaseTimeframe"></a> PurchaseTimeframe

|Property|Value|
|--------|-----|
|Description|Choose how long the lead will likely take to make the purchase.|
|DisplayName|Purchase Timeframe|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|purchasetimeframe|
|RequiredLevel|None|
|Type|Picklist|

#### PurchaseTimeframe Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Immediate||
|1|This Quarter||
|2|Next Quarter||
|3|This Year||
|4|Unknown||



### <a name="BKMK_PursuitDecision"></a> PursuitDecision

|Property|Value|
|--------|-----|
|Description|Select whether the decision about pursuing the opportunity has been made.|
|DisplayName|Decide Go/No-Go|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|pursuitdecision|
|RequiredLevel|None|
|Type|Boolean|

#### PursuitDecision Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|No||
|0|Yes||

**DefaultValue**: 0



### <a name="BKMK_QualificationComments"></a> QualificationComments

|Property|Value|
|--------|-----|
|Description|Type comments about the qualification or scoring of the lead.|
|DisplayName|Qualification Comments|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|qualificationcomments|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_QuoteComments"></a> QuoteComments

|Property|Value|
|--------|-----|
|Description|Type comments about the quotes associated with the opportunity.|
|DisplayName|Quote Comments|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|quotecomments|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_ResolveFeedback"></a> ResolveFeedback

|Property|Value|
|--------|-----|
|Description|Choose whether the proposal feedback has been captured and resolved for the opportunity.|
|DisplayName|Feedback Resolved|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|resolvefeedback|
|RequiredLevel|None|
|Type|Boolean|

#### ResolveFeedback Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|No||
|0|Yes||

**DefaultValue**: 0



### <a name="BKMK_SalesStage"></a> SalesStage

|Property|Value|
|--------|-----|
|Description|Select the sales stage of this opportunity to aid the sales team in their efforts to win this opportunity.|
|DisplayName|Sales Stage|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|salesstage|
|RequiredLevel|None|
|Type|Picklist|

#### SalesStage Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Qualify||
|1|Develop||
|2|Propose||
|3|Close||



### <a name="BKMK_SalesStageCode"></a> SalesStageCode

|Property|Value|
|--------|-----|
|Description|Select the sales process stage for the opportunity to indicate the probability of closing the opportunity.|
|DisplayName|Process Code|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|salesstagecode|
|RequiredLevel|None|
|Type|Picklist|

#### SalesStageCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_ScheduleFollowup_Prospect"></a> ScheduleFollowup_Prospect

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date and time of the prospecting follow-up meeting with the lead.|
|DisplayName|Scheduled Follow up (Prospect)|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|schedulefollowup_prospect|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ScheduleFollowup_Qualify"></a> ScheduleFollowup_Qualify

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date and time of the qualifying follow-up meeting with the lead.|
|DisplayName|Scheduled Follow up (Qualify)|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|schedulefollowup_qualify|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ScheduleProposalMeeting"></a> ScheduleProposalMeeting

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date and time of the proposal meeting for the opportunity.|
|DisplayName|Schedule Proposal Meeting|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|scheduleproposalmeeting|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_SendThankYouNote"></a> SendThankYouNote

|Property|Value|
|--------|-----|
|Description|Select whether a thank you note has been sent to the account for considering the proposal.|
|DisplayName|Send Thank You Note|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|sendthankyounote|
|RequiredLevel|None|
|Type|Boolean|

#### SendThankYouNote Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|completed||
|0|mark complete||

**DefaultValue**: 0



### <a name="BKMK_SkipPriceCalculation"></a> SkipPriceCalculation

**Added by**: Sales Patch Solution

|Property|Value|
|--------|-----|
|Description|Skip Price Calculation (For Internal Use)|
|DisplayName|Skip Price Calculation|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|skippricecalculation|
|RequiredLevel|None|
|Type|Picklist|

#### SkipPriceCalculation Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|DoPriceCalcAlways||
|1|SkipPriceCalcOnRetrieve||



### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|--------|-----|
|Description|Choose the service level agreement (SLA) that you want to apply to the opportunity record.|
|DisplayName|SLA|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|slaid|
|RequiredLevel|None|
|Targets|sla|
|Type|Lookup|


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
|Description|Shows whether the opportunity is open, won, or lost. Won and lost opportunities are read-only and can't be edited until they are reactivated.|
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
|0|Open|1|Open|
|1|Won|3|Won|
|2|Lost|4|Lost|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the opportunity's status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Choices/Options

|Value|Label|State|
|-----|-----|-----|
|1|In Progress|0|
|2|On Hold|0|
|3|Won|1|
|4|Canceled|2|
|5|Out-Sold|2|



### <a name="BKMK_StepId"></a> StepId

|Property|Value|
|--------|-----|
|Description|Shows the ID of the workflow step.|
|DisplayName|Step|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|stepid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_StepName"></a> StepName

|Property|Value|
|--------|-----|
|Description|Shows the current phase in the sales pipeline for the opportunity. |
|DisplayName|Pipeline Phase|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|stepname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TeamsFollowed"></a> TeamsFollowed

**Added by**: Sales Patch Solution

|Property|Value|
|--------|-----|
|Description|Number of users or conversations followed the record|
|DisplayName|TeamsFollowed|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|teamsfollowed|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_TimeLine"></a> TimeLine

|Property|Value|
|--------|-----|
|Description|Select when the opportunity is likely to be closed.|
|DisplayName|Timeline|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|timeline|
|RequiredLevel|None|
|Type|Picklist|

#### TimeLine Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Immediate||
|1|This Quarter||
|2|Next Quarter||
|3|This Year||
|4|Not known||



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


### <a name="BKMK_TotalAmount"></a> TotalAmount

|Property|Value|
|--------|-----|
|Description|Shows the total amount due, calculated as the sum of the products, discounts, freight, and taxes for the opportunity.|
|DisplayName|Total Amount|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalAmountLessFreight"></a> TotalAmountLessFreight

|Property|Value|
|--------|-----|
|Description|Shows the total product amount for the opportunity, minus any discounts. This value is added to freight and tax amounts in the calculation for the total amount of the opportunity.|
|DisplayName|Total Pre-Freight Amount|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalamountlessfreight|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalDiscountAmount"></a> TotalDiscountAmount

|Property|Value|
|--------|-----|
|Description|Shows the total discount amount, based on the discount price and rate entered on the opportunity.|
|DisplayName|Total Discount Amount|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totaldiscountamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalLineItemAmount"></a> TotalLineItemAmount

|Property|Value|
|--------|-----|
|Description|Shows the sum of all existing and write-in products included on the opportunity, based on the specified price list and quantities.|
|DisplayName|Total Detail Amount|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totallineitemamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalLineItemDiscountAmount"></a> TotalLineItemDiscountAmount

|Property|Value|
|--------|-----|
|Description|Shows the total of the Manual Discount amounts specified on all products included in the opportunity. This value is reflected in the Total Detail Amount field on the opportunity and is added to any discount amount or rate specified on the opportunity.|
|DisplayName|Total Line Item Discount Amount|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totallineitemdiscountamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|0|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalTax"></a> TotalTax

|Property|Value|
|--------|-----|
|Description|Shows the total of the Tax amounts specified on all products included in the opportunity, included in the Total Amount field calculation for the opportunity.|
|DisplayName|Total Tax|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totaltax|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Choose the local currency for the record to make sure budgets are reported in the correct currency.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
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

- [AccountId](#BKMK_AccountId)
- [AccountIdName](#BKMK_AccountIdName)
- [AccountIdYomiName](#BKMK_AccountIdYomiName)
- [ActualValue_Base](#BKMK_ActualValue_Base)
- [BudgetAmount_Base](#BKMK_BudgetAmount_Base)
- [CampaignIdName](#BKMK_CampaignIdName)
- [ContactId](#BKMK_ContactId)
- [ContactIdName](#BKMK_ContactIdName)
- [ContactIdYomiName](#BKMK_ContactIdYomiName)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [CustomerIdName](#BKMK_CustomerIdName)
- [CustomerIdYomiName](#BKMK_CustomerIdYomiName)
- [DiscountAmount_Base](#BKMK_DiscountAmount_Base)
- [EstimatedValue_Base](#BKMK_EstimatedValue_Base)
- [ExchangeRate](#BKMK_ExchangeRate)
- [FreightAmount_Base](#BKMK_FreightAmount_Base)
- [IsPrivate](#BKMK_IsPrivate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_PredictiveScoreIdName](#BKMK_msdyn_PredictiveScoreIdName)
- [msdyn_segmentidName](#BKMK_msdyn_segmentidName)
- [OnHoldTime](#BKMK_OnHoldTime)
- [OriginatingLeadIdName](#BKMK_OriginatingLeadIdName)
- [OriginatingLeadIdYomiName](#BKMK_OriginatingLeadIdYomiName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningBusinessUnitName](#BKMK_OwningBusinessUnitName)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [ParentAccountIdName](#BKMK_ParentAccountIdName)
- [ParentAccountIdYomiName](#BKMK_ParentAccountIdYomiName)
- [ParentContactIdName](#BKMK_ParentContactIdName)
- [ParentContactIdYomiName](#BKMK_ParentContactIdYomiName)
- [PriceLevelIdName](#BKMK_PriceLevelIdName)
- [SLAInvokedId](#BKMK_SLAInvokedId)
- [SLAInvokedIdName](#BKMK_SLAInvokedIdName)
- [SLAName](#BKMK_SLAName)
- [TimeSpentByMeOnEmailAndMeetings](#BKMK_TimeSpentByMeOnEmailAndMeetings)
- [TotalAmount_Base](#BKMK_TotalAmount_Base)
- [TotalAmountLessFreight_Base](#BKMK_TotalAmountLessFreight_Base)
- [TotalDiscountAmount_Base](#BKMK_TotalDiscountAmount_Base)
- [TotalLineItemAmount_Base](#BKMK_TotalLineItemAmount_Base)
- [TotalLineItemDiscountAmount_Base](#BKMK_TotalLineItemDiscountAmount_Base)
- [TotalTax_Base](#BKMK_TotalTax_Base)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_AccountId"></a> AccountId

|Property|Value|
|--------|-----|
|Description|Internal attribute for storing customerid. Do not use this attribute directly; use parentaccountid instead.|
|DisplayName|Account|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountid|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_AccountIdName"></a> AccountIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_AccountIdYomiName"></a> AccountIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ActualValue_Base"></a> ActualValue_Base

|Property|Value|
|--------|-----|
|Description|Value of the Actual Revenue in base currency.|
|DisplayName|Actual Revenue (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualvalue_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_BudgetAmount_Base"></a> BudgetAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Budget Amount in base currency.|
|DisplayName|Budget Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|budgetamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_CampaignIdName"></a> CampaignIdName

**Added by**: Marketing Sales Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|campaignidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ContactId"></a> ContactId

|Property|Value|
|--------|-----|
|Description|Internal attribute for storing customerid. Do not use this attribute directly; use parentcontactid instead.|
|DisplayName|Contact|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactid|
|RequiredLevel|None|
|Targets|contact|
|Type|Lookup|


### <a name="BKMK_ContactIdName"></a> ContactIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ContactIdYomiName"></a> ContactIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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


### <a name="BKMK_CustomerIdName"></a> CustomerIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridname|
|MaxLength|160|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_CustomerIdYomiName"></a> CustomerIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridyominame|
|MaxLength|450|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_DiscountAmount_Base"></a> DiscountAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Opportunity Discount Amount in base currency.|
|DisplayName|Opportunity Discount Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|discountamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_EstimatedValue_Base"></a> EstimatedValue_Base

|Property|Value|
|--------|-----|
|Description|Value of the Est. Revenue in base currency.|
|DisplayName|Est. Revenue (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|estimatedvalue_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


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


### <a name="BKMK_FreightAmount_Base"></a> FreightAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Freight Amount in base currency.|
|DisplayName|Freight Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|freightamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_IsPrivate"></a> IsPrivate

|Property|Value|
|--------|-----|
|Description|Indicates whether the opportunity is private or visible to the entire organization.|
|DisplayName|Is Private|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|isprivate|
|RequiredLevel|None|
|Type|Boolean|

#### IsPrivate Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



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


### <a name="BKMK_msdyn_PredictiveScoreIdName"></a> msdyn_PredictiveScoreIdName

**Added by**: Predictive Scoring Common Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_predictivescoreidname|
|MaxLength|128|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_segmentidName"></a> msdyn_segmentidName

**Added by**: Segment solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_segmentidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OnHoldTime"></a> OnHoldTime

|Property|Value|
|--------|-----|
|Description|Shows the duration in minutes for which the opportunity was on hold.|
|DisplayName|On Hold Time (Minutes)|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|onholdtime|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OriginatingLeadIdName"></a> OriginatingLeadIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|originatingleadidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OriginatingLeadIdYomiName"></a> OriginatingLeadIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|originatingleadidyominame|
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


### <a name="BKMK_ParentAccountIdName"></a> ParentAccountIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentaccountidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ParentAccountIdYomiName"></a> ParentAccountIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentaccountidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ParentContactIdName"></a> ParentContactIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentcontactidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ParentContactIdYomiName"></a> ParentContactIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentcontactidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PriceLevelIdName"></a> PriceLevelIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|pricelevelidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

|Property|Value|
|--------|-----|
|Description|Last SLA that was applied to this opportunity. This field is for internal use only.|
|DisplayName|Last SLA applied|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slainvokedid|
|RequiredLevel|None|
|Targets|sla|
|Type|Lookup|


### <a name="BKMK_SLAInvokedIdName"></a> SLAInvokedIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slainvokedidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SLAName"></a> SLAName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slaname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TimeSpentByMeOnEmailAndMeetings"></a> TimeSpentByMeOnEmailAndMeetings

|Property|Value|
|--------|-----|
|Description|Total time spent for emails (read and write) and meetings by me in relation to the opportunity record.|
|DisplayName|Time Spent by me|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timespentbymeonemailandmeetings|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TotalAmount_Base"></a> TotalAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Amount in base currency.|
|DisplayName|Total Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalAmountLessFreight_Base"></a> TotalAmountLessFreight_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Pre-Freight Amount in base currency.|
|DisplayName|Total Pre-Freight Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalamountlessfreight_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalDiscountAmount_Base"></a> TotalDiscountAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Discount Amount in base currency.|
|DisplayName|Total Discount Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totaldiscountamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalLineItemAmount_Base"></a> TotalLineItemAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Detail Amount in base currency.|
|DisplayName|Total Detail Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totallineitemamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalLineItemDiscountAmount_Base"></a> TotalLineItemDiscountAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Line Item Discount Amount in base currency.|
|DisplayName|Total Line Item Discount Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totallineitemdiscountamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalTax_Base"></a> TotalTax_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Tax in base currency.|
|DisplayName|Total Tax (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totaltax_base|
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

- [opportunity_OpportunityCloses](#BKMK_opportunity_OpportunityCloses)
- [opportunity_OrderCloses](#BKMK_opportunity_OrderCloses)
- [opportunity_QuoteCloses](#BKMK_opportunity_QuoteCloses)
- [lk_leadtoopportunitysalesprocess_opportunityid](#BKMK_lk_leadtoopportunitysalesprocess_opportunityid)
- [opportunity_invoices](#BKMK_opportunity_invoices)
- [Opportunity_OpportunityClose](#BKMK_Opportunity_OpportunityClose)
- [opportunity_quotes](#BKMK_opportunity_quotes)
- [opportunity_sales_orders](#BKMK_opportunity_sales_orders)
- [product_opportunities](#BKMK_product_opportunities)
- [lead_qualifying_opportunity](#BKMK_lead_qualifying_opportunity)
- [lk_opportunitysalesprocess_opportunityid](#BKMK_lk_opportunitysalesprocess_opportunityid)
- [msdyn_playbookinstance_opportunity](#BKMK_msdyn_playbookinstance_opportunity)
- [CreatedOpportunity_BulkOperationLogs](#BKMK_CreatedOpportunity_BulkOperationLogs)


### <a name="BKMK_opportunity_OpportunityCloses"></a> opportunity_OpportunityCloses

Same as the [opportunity_OpportunityCloses](opportunityclose.md#BKMK_opportunity_OpportunityCloses) many-to-one relationship for the [opportunityclose](opportunityclose.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunity_OpportunityCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_opportunity_OrderCloses"></a> opportunity_OrderCloses

Same as the [opportunity_OrderCloses](orderclose.md#BKMK_opportunity_OrderCloses) many-to-one relationship for the [orderclose](orderclose.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunity_OrderCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_opportunity_QuoteCloses"></a> opportunity_QuoteCloses

Same as the [opportunity_QuoteCloses](quoteclose.md#BKMK_opportunity_QuoteCloses) many-to-one relationship for the [quoteclose](quoteclose.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunity_QuoteCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_lk_leadtoopportunitysalesprocess_opportunityid"></a> lk_leadtoopportunitysalesprocess_opportunityid

Same as the [lk_leadtoopportunitysalesprocess_opportunityid](leadtoopportunitysalesprocess.md#BKMK_lk_leadtoopportunitysalesprocess_opportunityid) many-to-one relationship for the [leadtoopportunitysalesprocess](leadtoopportunitysalesprocess.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|leadtoopportunitysalesprocess|
|ReferencingAttribute|opportunityid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunity_leadtoopportunitysalesprocess|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_opportunity_invoices"></a> opportunity_invoices

Same as the [opportunity_invoices](invoice.md#BKMK_opportunity_invoices) many-to-one relationship for the [invoice](invoice.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoice|
|ReferencingAttribute|opportunityid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunity_invoices|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Sales<br />Label: <br />Order: 30|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Opportunity_OpportunityClose"></a> Opportunity_OpportunityClose

Same as the [Opportunity_OpportunityClose](opportunityclose.md#BKMK_Opportunity_OpportunityClose) many-to-one relationship for the [opportunityclose](opportunityclose.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|opportunityid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Opportunity_OpportunityClose|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_opportunity_quotes"></a> opportunity_quotes

Same as the [opportunity_quotes](quote.md#BKMK_opportunity_quotes) many-to-one relationship for the [quote](quote.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quote|
|ReferencingAttribute|opportunityid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunity_quotes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Sales<br />Label: <br />Order: 10|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_opportunity_sales_orders"></a> opportunity_sales_orders

Same as the [opportunity_sales_orders](salesorder.md#BKMK_opportunity_sales_orders) many-to-one relationship for the [salesorder](salesorder.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorder|
|ReferencingAttribute|opportunityid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunity_sales_orders|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Sales<br />Label: <br />Order: 20|
|CascadeConfiguration|Assign: Cascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_product_opportunities"></a> product_opportunities

Same as the [product_opportunities](opportunityproduct.md#BKMK_product_opportunities) many-to-one relationship for the [opportunityproduct](opportunityproduct.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityproduct|
|ReferencingAttribute|opportunityid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|product_opportunities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lead_qualifying_opportunity"></a> lead_qualifying_opportunity

Same as the [lead_qualifying_opportunity](lead.md#BKMK_lead_qualifying_opportunity) many-to-one relationship for the [lead](lead.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|lead|
|ReferencingAttribute|qualifyingopportunityid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lead_qualifying_opportunity|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: Cascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_opportunitysalesprocess_opportunityid"></a> lk_opportunitysalesprocess_opportunityid

Same as the [lk_opportunitysalesprocess_opportunityid](opportunitysalesprocess.md#BKMK_lk_opportunitysalesprocess_opportunityid) many-to-one relationship for the [opportunitysalesprocess](opportunitysalesprocess.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunitysalesprocess|
|ReferencingAttribute|opportunityid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunity_opportunitysalesprocess|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_playbookinstance_opportunity"></a> msdyn_playbookinstance_opportunity

**Added by**: Playbook Solution

Same as the [msdyn_playbookinstance_opportunity](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_opportunity) many-to-one relationship for the [msdyn_playbookinstance](msdyn_playbookinstance.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_playbookinstance|
|ReferencingAttribute|regarding|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_opportunity|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_CreatedOpportunity_BulkOperationLogs"></a> CreatedOpportunity_BulkOperationLogs

**Added by**: Marketing Solution

Same as the [CreatedOpportunity_BulkOperationLogs](bulkoperationlog.md#BKMK_CreatedOpportunity_BulkOperationLogs) many-to-one relationship for the [bulkoperationlog](bulkoperationlog.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkoperationlog|
|ReferencingAttribute|createdobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|CreatedOpportunity_BulkOperationLogs|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related table. Listed by **SchemaName**.

- [opportunity_originating_lead](#BKMK_opportunity_originating_lead)
- [opportunity_parent_account](#BKMK_opportunity_parent_account)
- [price_level_opportunties](#BKMK_price_level_opportunties)
- [opportunity_parent_contact](#BKMK_opportunity_parent_contact)
- [opportunity_customer_accounts](#BKMK_opportunity_customer_accounts)
- [opportunity_customer_contacts](#BKMK_opportunity_customer_contacts)
- [campaign_opportunities](#BKMK_campaign_opportunities)


### <a name="BKMK_opportunity_originating_lead"></a> opportunity_originating_lead

**Added by**: Lead Management Solution

See the [opportunity_originating_lead](lead.md#BKMK_opportunity_originating_lead) one-to-many relationship for the [lead](lead.md) table/entity.

### <a name="BKMK_opportunity_parent_account"></a> opportunity_parent_account

**Added by**: System Solution Solution

See the [opportunity_parent_account](account.md#BKMK_opportunity_parent_account) one-to-many relationship for the [account](account.md) table/entity.

### <a name="BKMK_price_level_opportunties"></a> price_level_opportunties

**Added by**: Product Management Solution

See the [price_level_opportunties](pricelevel.md#BKMK_price_level_opportunties) one-to-many relationship for the [pricelevel](pricelevel.md) table/entity.

### <a name="BKMK_opportunity_parent_contact"></a> opportunity_parent_contact

**Added by**: System Solution Solution

See the [opportunity_parent_contact](contact.md#BKMK_opportunity_parent_contact) one-to-many relationship for the [contact](contact.md) table/entity.

### <a name="BKMK_opportunity_customer_accounts"></a> opportunity_customer_accounts

**Added by**: System Solution Solution

See the [opportunity_customer_accounts](account.md#BKMK_opportunity_customer_accounts) one-to-many relationship for the [account](account.md) table/entity.

### <a name="BKMK_opportunity_customer_contacts"></a> opportunity_customer_contacts

**Added by**: System Solution Solution

See the [opportunity_customer_contacts](contact.md#BKMK_opportunity_customer_contacts) one-to-many relationship for the [contact](contact.md) table/entity.

### <a name="BKMK_campaign_opportunities"></a> campaign_opportunities

**Added by**: Marketing Solution

See the [campaign_opportunities](campaign.md#BKMK_campaign_opportunities) one-to-many relationship for the [campaign](campaign.md) table/entity.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the Opportunity table is the first table in the relationship. Listed by **SchemaName**.


### <a name="BKMK_opportunitycompetitors_association"></a> opportunitycompetitors_association

IntersectEntityName: opportunitycompetitors<br />
#### Table 1

|Property|Value|
|--------|-----|
|IntersectAttribute|opportunityid|
|IsCustomizable|False|
|LogicalName|opportunity|
|NavigationPropertyName|opportunitycompetitors_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |

#### Table 2

|Property|Value|
|--------|-----|
|LogicalName|competitor|
|IntersectAttribute|competitorid|
|NavigationPropertyName|opportunitycompetitors_association|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Sales<br />Label: <br />Order: 40|


### See also

[About the table reference](../about-entity-reference.md)<br />
[Web API Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)<br />
