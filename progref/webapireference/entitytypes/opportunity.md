---
title: "Microsoft Dynamics 365 Customer Engagement opportunity EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d424049c-f806-440e-93d2-4667f8756995
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API opportunity entitytype."
---
# opportunity EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/opportunity.md](./descriptions/opportunity.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]opportunities </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Opportunity</td></tr>
<tr><td><b>Primary Key:</b></td><td>opportunityid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|actualclosedate|Edm.Date|**Display Name**: Actual Close Date<br />**Description**: Shows the date and time when the opportunity was closed or canceled.<br />|
|actualvalue|Edm.Decimal|**Display Name**: Actual Revenue<br />**Description**: Type the actual revenue amount for the opportunity for reporting and analysis of estimated versus actual sales. Field defaults to the Est. Revenue value when an opportunity is won.<br />|
|actualvalue_base|Edm.Decimal|**Display Name**: Actual Revenue (Base)<br />**Description**: Value of the Actual Revenue in base currency.<br />Read-only<br />|
|budgetamount|Edm.Decimal|**Display Name**: Budget Amount<br />**Description**: Type a value between 0 and 1,000,000,000,000 to indicate the lead's potential available budget.<br />|
|budgetamount_base|Edm.Decimal|**Display Name**: Budget Amount (Base)<br />**Description**: Value of the Budget Amount in base currency.<br />Read-only<br />|
|budgetstatus|Edm.Int32|**Display Name**: Budget<br />**Description**: Select the likely budget status for the lead's company. This may help determine the lead rating or your sales approach.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>No Committed Budget</td></tr><tr><td>1</td><td>May Buy</td></tr><tr><td>2</td><td>Can Buy</td></tr><tr><td>3</td><td>Will Buy</td></tr><tbody></table>|
|captureproposalfeedback|Edm.Boolean|**Display Name**: Proposal Feedback Captured<br />**Description**: Choose whether the proposal feedback has been captured for the opportunity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>No</td></tr><tr><td>0</td><td>Yes</td></tr><tbody></table>|
|closeprobability|Edm.Int32|**Display Name**: Probability<br />**Description**: Type a number from 0 to 100 that represents the likelihood of closing the opportunity. This can aid the sales team in their efforts to convert the opportunity in a sale.<br />|
|completefinalproposal|Edm.Boolean|**Display Name**: Final Proposal Ready<br />**Description**: Select whether a final proposal has been completed for the opportunity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>completed</td></tr><tr><td>0</td><td>mark complete</td></tr><tbody></table>|
|completeinternalreview|Edm.Boolean|**Display Name**: Complete Internal Review<br />**Description**: Select whether an internal review has been completed for this opportunity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>completed</td></tr><tr><td>0</td><td>mark complete</td></tr><tbody></table>|
|confirminterest|Edm.Boolean|**Display Name**: Confirm Interest<br />**Description**: Select whether the lead confirmed interest in your offerings. This helps in determining the lead quality and the probability of it turning into an opportunity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>No</td></tr><tr><td>0</td><td>Yes</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|currentsituation|Edm.String|**Display Name**: Current Situation<br />**Description**: Type notes about the company or organization associated with the opportunity.<br />|
|customerneed|Edm.String|**Display Name**: Customer Need<br />**Description**: Type some notes about the customer's requirements, to help the sales team identify products and services that could meet their requirements.<br />|
|customerpainpoints|Edm.String|**Display Name**: Customer Pain Points<br />**Description**: Type notes about the customer's pain points to help the sales team identify products and services that could address these pain points.<br />|
|decisionmaker|Edm.Boolean|**Display Name**: Decision Maker?<br />**Description**: Select whether your notes include information about who makes the purchase decisions at the lead's company.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>completed</td></tr><tr><td>0</td><td>mark complete</td></tr><tbody></table>|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the opportunity, such as possible products to sell or past purchases from the customer.<br />|
|developproposal|Edm.Boolean|**Display Name**: Develop Proposal<br />**Description**: Select whether a proposal has been developed for the opportunity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>completed</td></tr><tr><td>0</td><td>mark complete</td></tr><tbody></table>|
|discountamount|Edm.Decimal|**Display Name**: Opportunity Discount Amount<br />**Description**: Type the discount amount for the opportunity if the customer is eligible for special savings.<br />|
|discountamount_base|Edm.Decimal|**Display Name**: Opportunity Discount Amount (Base)<br />**Description**: Value of the Opportunity Discount Amount in base currency.<br />Read-only<br />|
|discountpercentage|Edm.Decimal|**Display Name**: Opportunity Discount (%)<br />**Description**: Type the discount rate that should be applied to the Product Totals field to include additional savings for the customer in the opportunity.<br />|
|emailaddress|Edm.String|**Display Name**: Email Address<br />**Description**: The primary email address for the entity.<br />|
|estimatedclosedate|Edm.Date|**Display Name**: Est. Close Date<br />**Description**: Enter the expected closing date of the opportunity to help make accurate revenue forecasts.<br />|
|estimatedvalue|Edm.Decimal|**Display Name**: Est. Revenue<br />**Description**: Type the estimated revenue amount to indicate the potential sale or value of the opportunity for revenue forecasting. This field can be either system-populated or editable based on the selection in the Revenue field.<br />|
|estimatedvalue_base|Edm.Decimal|**Display Name**: Est. Revenue (Base)<br />**Description**: Value of the Est. Revenue in base currency.<br />Read-only<br />|
|evaluatefit|Edm.Boolean|**Display Name**: Evaluate Fit<br />**Description**: Select whether the fit between the lead's requirements and your offerings was evaluated.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>No</td></tr><tr><td>0</td><td>Yes</td></tr><tbody></table>|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|filedebrief|Edm.Boolean|**Display Name**: File Debrief<br />**Description**: Choose whether the sales team has recorded detailed notes on the proposals and the account's responses.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>completed</td></tr><tr><td>0</td><td>mark complete</td></tr><tbody></table>|
|finaldecisiondate|Edm.Date|**Display Name**: Final Decision Date<br />**Description**: Enter the date and time when the final decision of the opportunity was made.<br />|
|freightamount|Edm.Decimal|**Display Name**: Freight Amount<br />**Description**: Type the cost of freight or shipping for the products included in the opportunity for use in calculating the Total Amount field.<br />|
|freightamount_base|Edm.Decimal|**Display Name**: Freight Amount (Base)<br />**Description**: Value of the Freight Amount in base currency.<br />Read-only<br />|
|identifycompetitors|Edm.Boolean|**Display Name**: Identify Competitors<br />**Description**: Select whether information about competitors is included.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>completed</td></tr><tr><td>0</td><td>mark complete</td></tr><tbody></table>|
|identifycustomercontacts|Edm.Boolean|**Display Name**: Identify Customer Contacts<br />**Description**: Select whether the customer contacts for this opportunity have been identified.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>completed</td></tr><tr><td>0</td><td>mark complete</td></tr><tbody></table>|
|identifypursuitteam|Edm.Boolean|**Display Name**: Identify Sales Team<br />**Description**: Choose whether you have recorded who will pursue the opportunity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>completed</td></tr><tr><td>0</td><td>mark complete</td></tr><tbody></table>|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|initialcommunication|Edm.Int32|**Display Name**: Initial Communication<br />**Description**: Choose whether someone from the sales team contacted this lead earlier.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Contacted</td></tr><tr><td>1</td><td>Not Contacted</td></tr><tbody></table>|
|isrevenuesystemcalculated|Edm.Boolean|**Display Name**: Revenue<br />**Description**: Select whether the estimated revenue for the opportunity is calculated automatically based on the products entered or entered manually by a user.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>System Calculated</td></tr><tr><td>0</td><td>User Provided</td></tr><tbody></table>|
|lastonholdtime|Edm.DateTimeOffset|**Display Name**: Last On Hold Time<br />**Description**: Contains the date time stamp of the last on hold time.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_ordertype|Edm.Int32|**Display Name**: Type<br />**Description**: Whether the Opportunity is for an Item- based or a Work-based sale<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970002</td><td>Service-Maintenance Based</td></tr><tr><td>192350000</td><td>Item based</td></tr><tr><td>192350001</td><td>Work based</td></tr><tbody></table>|
|name|Edm.String|**Display Name**: Topic<br />**Description**: Type a subject or descriptive name, such as the expected order or company name, for the opportunity.<br />|
|need|Edm.Int32|**Display Name**: Need<br />**Description**: Choose how high the level of need is for the lead's company.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Must have</td></tr><tr><td>1</td><td>Should have</td></tr><tr><td>2</td><td>Good to have</td></tr><tr><td>3</td><td>No need</td></tr><tbody></table>|
|onholdtime|Edm.Int32|**Display Name**: On Hold Time (Minutes)<br />**Description**: Shows the duration in minutes for which the opportunity was on hold.<br />Read-only<br />|
|opportunityid|Edm.Guid|**Display Name**: Opportunity<br />**Description**: Unique identifier of the opportunity.<br />|
|opportunityratingcode|Edm.Int32|**Display Name**: Rating<br />**Description**: Select the expected value or priority of the opportunity based on revenue, customer status, or closing probability.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Hot</td></tr><tr><td>2</td><td>Warm</td></tr><tr><td>3</td><td>Cold</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|participatesinworkflow|Edm.Boolean|**Display Name**: Participates in Workflow<br />**Description**: Information about whether the opportunity participates in workflow rules.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|presentfinalproposal|Edm.Boolean|**Display Name**: Present Final Proposal<br />**Description**: Select whether the final proposal has been presented to the account.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>completed</td></tr><tr><td>0</td><td>mark complete</td></tr><tbody></table>|
|presentproposal|Edm.Boolean|**Display Name**: Presented Proposal<br />**Description**: Select whether a proposal for the opportunity has been presented to the account.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>completed</td></tr><tr><td>0</td><td>mark complete</td></tr><tbody></table>|
|pricingerrorcode|Edm.Int32|**Display Name**: Pricing Error <br />**Description**: Pricing error for the opportunity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>None</td></tr><tr><td>1</td><td>Detail Error</td></tr><tr><td>2</td><td>Missing Price Level</td></tr><tr><td>3</td><td>Inactive Price Level</td></tr><tr><td>4</td><td>Missing Quantity</td></tr><tr><td>5</td><td>Missing Unit Price</td></tr><tr><td>6</td><td>Missing Product</td></tr><tr><td>7</td><td>Invalid Product</td></tr><tr><td>8</td><td>Missing Pricing Code</td></tr><tr><td>9</td><td>Invalid Pricing Code</td></tr><tr><td>10</td><td>Missing UOM</td></tr><tr><td>11</td><td>Product Not In Price Level</td></tr><tr><td>12</td><td>Missing Price Level Amount</td></tr><tr><td>13</td><td>Missing Price Level Percentage</td></tr><tr><td>14</td><td>Missing Price</td></tr><tr><td>15</td><td>Missing Current Cost</td></tr><tr><td>16</td><td>Missing Standard Cost</td></tr><tr><td>17</td><td>Invalid Price Level Amount</td></tr><tr><td>18</td><td>Invalid Price Level Percentage</td></tr><tr><td>19</td><td>Invalid Price</td></tr><tr><td>20</td><td>Invalid Current Cost</td></tr><tr><td>21</td><td>Invalid Standard Cost</td></tr><tr><td>22</td><td>Invalid Rounding Policy</td></tr><tr><td>23</td><td>Invalid Rounding Option</td></tr><tr><td>24</td><td>Invalid Rounding Amount</td></tr><tr><td>25</td><td>Price Calculation Error</td></tr><tr><td>26</td><td>Invalid Discount Type</td></tr><tr><td>27</td><td>Discount Type Invalid State</td></tr><tr><td>28</td><td>Invalid Discount</td></tr><tr><td>29</td><td>Invalid Quantity</td></tr><tr><td>30</td><td>Invalid Pricing Precision</td></tr><tr><td>31</td><td>Missing Product Default UOM</td></tr><tr><td>32</td><td>Missing Product UOM Schedule </td></tr><tr><td>33</td><td>Inactive Discount Type</td></tr><tr><td>34</td><td>Invalid Price Level Currency</td></tr><tr><td>35</td><td>Price Attribute Out Of Range</td></tr><tr><td>36</td><td>Base Currency Attribute Overflow</td></tr><tr><td>37</td><td>Base Currency Attribute Underflow</td></tr><tbody></table>|
|prioritycode|Edm.Int32|**Display Name**: Priority<br />**Description**: Select the priority so that preferred customers or critical issues are handled quickly.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|proposedsolution|Edm.String|**Display Name**: Proposed Solution<br />**Description**: Type notes about the proposed solution for the opportunity.<br />|
|purchaseprocess|Edm.Int32|**Display Name**: Purchase Process<br />**Description**: Choose whether an individual or a committee will be involved in the  purchase process for the lead.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Individual</td></tr><tr><td>1</td><td>Committee</td></tr><tr><td>2</td><td>Unknown</td></tr><tbody></table>|
|purchasetimeframe|Edm.Int32|**Display Name**: Purchase Timeframe<br />**Description**: Choose how long the lead will likely take to make the purchase.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Immediate</td></tr><tr><td>1</td><td>This Quarter</td></tr><tr><td>2</td><td>Next Quarter</td></tr><tr><td>3</td><td>This Year</td></tr><tr><td>4</td><td>Unknown</td></tr><tbody></table>|
|pursuitdecision|Edm.Boolean|**Display Name**: Decide Go/No-Go<br />**Description**: Select whether the decision about pursuing the opportunity has been made.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>No</td></tr><tr><td>0</td><td>Yes</td></tr><tbody></table>|
|qualificationcomments|Edm.String|**Display Name**: Qualification Comments<br />**Description**: Type comments about the qualification or scoring of the lead.<br />|
|quotecomments|Edm.String|**Display Name**: Quote Comments<br />**Description**: Type comments about the quotes associated with the opportunity.<br />|
|resolvefeedback|Edm.Boolean|**Display Name**: Feedback Resolved<br />**Description**: Choose whether the proposal feedback has been captured and resolved for the opportunity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>No</td></tr><tr><td>0</td><td>Yes</td></tr><tbody></table>|
|salesstage|Edm.Int32|**Display Name**: Sales Stage<br />**Description**: Select the sales stage of this opportunity to aid the sales team in their efforts to win this opportunity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Qualify</td></tr><tr><td>1</td><td>Develop</td></tr><tr><td>2</td><td>Propose</td></tr><tr><td>3</td><td>Close</td></tr><tbody></table>|
|salesstagecode|Edm.Int32|**Display Name**: Process Code<br />**Description**: Select the sales process stage for the opportunity to indicate the probability of closing the opportunity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|schedulefollowup_prospect|Edm.DateTimeOffset|**Display Name**: Scheduled Follow up (Prospect)<br />**Description**: Enter the date and time of the prospecting follow-up meeting with the lead.<br />|
|schedulefollowup_qualify|Edm.DateTimeOffset|**Display Name**: Scheduled Follow up (Qualify)<br />**Description**: Enter the date and time of the qualifying follow-up meeting with the lead.<br />|
|scheduleproposalmeeting|Edm.DateTimeOffset|**Display Name**: Schedule Proposal Meeting<br />**Description**: Enter the date and time of the proposal meeting for the opportunity.<br />|
|sendthankyounote|Edm.Boolean|**Display Name**: Send Thank You Note<br />**Description**: Select whether a thank you note has been sent to the account for considering the proposal.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>completed</td></tr><tr><td>0</td><td>mark complete</td></tr><tbody></table>|
|stageid|Edm.Guid|**Display Name**: Stage Id<br />**Description**: Contains the id of the stage where the entity is located.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the opportunity is open, won, or lost. Won and lost opportunities are read-only and can't be edited until they are reactivated.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Open</td></tr><tr><td>1</td><td>Won</td></tr><tr><td>2</td><td>Lost</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the opportunity's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>In Progress</td></tr><tr><td>2</td><td>On Hold</td></tr><tr><td>3</td><td>Won</td></tr><tr><td>4</td><td>Canceled</td></tr><tr><td>5</td><td>Out-Sold</td></tr><tbody></table>|
|stepid|Edm.Guid|**Display Name**: Step<br />**Description**: Shows the ID of the workflow step.<br />|
|stepname|Edm.String|**Display Name**: Pipeline Phase<br />**Description**: Shows the current phase in the sales pipeline for the opportunity. This is updated by a workflow.<br />|
|timeline|Edm.Int32|**Display Name**: Timeline<br />**Description**: Select when the opportunity is likely to be closed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Immediate</td></tr><tr><td>1</td><td>This Quarter</td></tr><tr><td>2</td><td>Next Quarter</td></tr><tr><td>3</td><td>This Year</td></tr><tr><td>4</td><td>Not known</td></tr><tbody></table>|
|timespentbymeonemailandmeetings|Edm.String|**Display Name**: Time Spent by me<br />**Description**: Total time spent for emails (read and write) and meetings by me in relation to the opportunity record.<br />Read-only<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|totalamount|Edm.Decimal|**Display Name**: Total Amount<br />**Description**: Shows the total amount due, calculated as the sum of the products, discounts, freight, and taxes for the opportunity.<br />|
|totalamount_base|Edm.Decimal|**Display Name**: Total Amount (Base)<br />**Description**: Value of the Total Amount in base currency.<br />Read-only<br />|
|totalamountlessfreight|Edm.Decimal|**Display Name**: Total Pre-Freight Amount<br />**Description**: Shows the total product amount for the opportunity, minus any discounts. This value is added to freight and tax amounts in the calculation for the total amount of the opportunity.<br />|
|totalamountlessfreight_base|Edm.Decimal|**Display Name**: Total Pre-Freight Amount (Base)<br />**Description**: Value of the Total Pre-Freight Amount in base currency.<br />Read-only<br />|
|totaldiscountamount|Edm.Decimal|**Display Name**: Total Discount Amount<br />**Description**: Shows the total discount amount, based on the discount price and rate entered on the opportunity.<br />|
|totaldiscountamount_base|Edm.Decimal|**Display Name**: Total Discount Amount (Base)<br />**Description**: Value of the Total Discount Amount in base currency.<br />Read-only<br />|
|totallineitemamount|Edm.Decimal|**Display Name**: Total Detail Amount<br />**Description**: Shows the sum of all existing and write-in products included on the opportunity, based on the specified price list and quantities.<br />|
|totallineitemamount_base|Edm.Decimal|**Display Name**: Total Detail Amount (Base)<br />**Description**: Value of the Total Detail Amount in base currency.<br />Read-only<br />|
|totallineitemdiscountamount|Edm.Decimal|**Display Name**: Total Line Item Discount Amount<br />**Description**: Shows the total of the Manual Discount amounts specified on all products included in the opportunity. This value is reflected in the Total Detail Amount field on the opportunity and is added to any discount amount or rate specified on the opportunity.<br />|
|totallineitemdiscountamount_base|Edm.Decimal|**Display Name**: Total Line Item Discount Amount (Base)<br />**Description**: Value of the Total Line Item Discount Amount in base currency.<br />Read-only<br />|
|totaltax|Edm.Decimal|**Display Name**: Total Tax<br />**Description**: Shows the total of the Tax amounts specified on all products included in the opportunity, included in the Total Amount field calculation for the opportunity.<br />|
|totaltax_base|Edm.Decimal|**Display Name**: Total Tax (Base)<br />**Description**: Value of the Total Tax in base currency.<br />Read-only<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_accountid_value||Unique identifier of the account with which the opportunity is associated.|
|_campaignid_value|campaignid<br />|Shows the campaign that the opportunity was created from. The ID is used for tracking the success of the campaign.|
|_contactid_value||Unique identifier of the contact associated with the opportunity.|
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_customerid_value|customerid_account<br />customerid_contact<br />|Select the customer account or contact to provide a quick link to additional customer details, such as address, phone number, activities, and orders.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_msa_partnerid_value|msa_partnerid<br />|Unique identifier for Account associated with Opportunity.|
|_msa_partneroppid_value|msa_partneroppid<br />|Unique identifier for Contact associated with Opportunity.|
|_msdyn_accountmanagerid_value|msdyn_AccountManagerId<br />|The account manager responsible for the opportunity.|
|_msdyn_contractorganizationalunitid_value|msdyn_ContractOrganizationalUnitId<br />|The organizational unit in charge of the opportunity.|
|_msdyn_workordertype_value|msdyn_workordertype<br />|Unique identifier for Work Order Type associated with Opportunity.|
|_originatingleadid_value|originatingleadid<br />|Choose the lead that the opportunity was created from for reporting and analytics. The field is read-only after the opportunity is created and defaults to the correct lead when an opportunity is created from a converted lead.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_parentaccountid_value|parentaccountid<br />|Choose an account to connect this opportunity to, so that the relationship is visible in reports and analytics, and to provide a quick link to additional details, such as financial information and activities.|
|_parentcontactid_value|parentcontactid<br />|Choose a contact to connect this opportunity to, so that the relationship is visible in reports and analytics.|
|_pricelevelid_value|pricelevelid<br />|Choose the price list associated with this record to make sure the products associated with the campaign are offered at the correct prices.|
|_slaid_value|sla_opportunity_sla<br />|Choose the service level agreement (SLA) that you want to apply to the opportunity record.|
|_slainvokedid_value|slainvokedid_opportunity_sla<br />|Last SLA that was applied to this opportunity. This field is for internal use only.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|campaignid|[campaign EntityType](campaign.md)|campaign_opportunities|
|createdby|[systemuser EntityType](systemuser.md)|lk_opportunitybase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_opportunity_createdonbehalfby|
|customerid_account|[account EntityType](account.md)|opportunity_customer_accounts|
|customerid_contact|[contact EntityType](contact.md)|opportunity_customer_contacts|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_opportunitybase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_opportunity_modifiedonbehalfby|
|msa_partnerid|[account EntityType](account.md)|msa_partner_opportunity|
|msa_partneroppid|[contact EntityType](contact.md)|msa_contact_opportunity|
|msdyn_AccountManagerId|[systemuser EntityType](systemuser.md)|msdyn_accountmanager_opportunity|
|msdyn_ContractOrganizationalUnitId|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_organizationalunit_opportunity|
|msdyn_workordertype|[msdyn_workordertype EntityType](msdyn_workordertype.md)|msdyn_msdyn_workordertype_opportunity_WorkOrderType|
|originatingleadid|[lead EntityType](lead.md)|opportunity_originating_lead|
|ownerid|[principal EntityType](principal.md)|owner_opportunitys|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_opportunities|
|owningteam|[team EntityType](team.md)|team_opportunities|
|owninguser|[systemuser EntityType](systemuser.md)|opportunity_owning_user|
|parentaccountid|[account EntityType](account.md)|opportunity_parent_account|
|parentcontactid|[contact EntityType](contact.md)|opportunity_parent_contact|
|pricelevelid|[pricelevel EntityType](pricelevel.md)|price_level_opportunties|
|sla_opportunity_sla|[sla EntityType](sla.md)|manualsla_opportunity|
|slainvokedid_opportunity_sla|[sla EntityType](sla.md)|sla_opportunity|
|stageid_processstage|[processstage EntityType](processstage.md)|processstage_opportunity|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_opportunity|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|CreatedOpportunity_BulkOperationLogs|[bulkoperationlog EntityType](bulkoperationlog.md)|createdobjectid_opportunity|  
|lead_qualifying_opportunity|[lead EntityType](lead.md)|qualifyingopportunityid|  
|msdyn_opportunity_msdyn_opportunitypricelist_Opportunity|[msdyn_opportunitypricelist EntityType](msdyn_opportunitypricelist.md)|msdyn_Opportunity|  
|msdyn_opportunity_msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_opportunityid|  
|msdyncrm_opportunity_msdyncrm_leadtoopportunity|[msdyncrm_leadtoopportunity EntityType](msdyncrm_leadtoopportunity.md)|msdyncrm_opportunityid|  
|opportunity_actioncard|[actioncard EntityType](actioncard.md)|regardingobjectid_opportunity_actioncard|  
|opportunity_activity_parties|[activityparty EntityType](activityparty.md)|partyid_opportunity|  
|Opportunity_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_opportunity|  
|opportunity_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_opportunity_adx_alertsubscription|  
|opportunity_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_opportunity_adx_inviteredemption|  
|opportunity_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_opportunity_adx_portalcomment|  
|Opportunity_Annotation|[annotation EntityType](annotation.md)|objectid_opportunity|  
|Opportunity_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_opportunity_appointment|  
|Opportunity_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_opportunity|  
|Opportunity_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_opportunity|  
|opportunity_connections1|[connection EntityType](connection.md)|record1id_opportunity|  
|opportunity_connections2|[connection EntityType](connection.md)|record2id_opportunity|  
|Opportunity_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_opportunity|  
|Opportunity_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_opportunity|  
|Opportunity_Emails|[email EntityType](email.md)|regardingobjectid_opportunity_email|  
|Opportunity_Faxes|[fax EntityType](fax.md)|regardingobjectid_opportunity_fax|  
|opportunity_invoices|[invoice EntityType](invoice.md)|opportunityid|  
|opportunity_leadtoopportunitysalesprocess|[leadtoopportunitysalesprocess EntityType](leadtoopportunitysalesprocess.md)|opportunityId|  
|Opportunity_Letters|[letter EntityType](letter.md)|regardingobjectid_opportunity_letter|  
|opportunity_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_opportunity_msdyn_approval|  
|opportunity_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_opportunity_msdyn_bookingalert|  
|opportunity_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_opportunity_msdyn_surveyinvite|  
|Opportunity_OpportunityClose|[opportunityclose EntityType](opportunityclose.md)|opportunityid|  
|opportunity_OpportunityCloses|[opportunityclose EntityType](opportunityclose.md)|regardingobjectid_opportunity_opportunityclose|  
|opportunity_opportunitysalesprocess|[opportunitysalesprocess EntityType](opportunitysalesprocess.md)|opportunityid|  
|opportunity_OrderCloses|[orderclose EntityType](orderclose.md)|regardingobjectid_opportunity_orderclose|  
|Opportunity_Phonecalls|[phonecall EntityType](phonecall.md)|regardingobjectid_opportunity_phonecall|  
|opportunity_PostFollows|[postfollow EntityType](postfollow.md)|regardingobjectid_opportunity|  
|opportunity_PostRegardings|[postregarding EntityType](postregarding.md)|regardingobjectid_opportunity|  
|opportunity_QuoteCloses|[quoteclose EntityType](quoteclose.md)|regardingobjectid_opportunity_quoteclose|  
|opportunity_quotes|[quote EntityType](quote.md)|opportunityid|  
|Opportunity_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_opportunity_recurringappointmentmaster|  
|opportunity_sales_orders|[salesorder EntityType](salesorder.md)|opportunityid|  
|Opportunity_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_opportunity_serviceappointment|  
|Opportunity_SharepointDocumentLocation|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_opportunity|  
|Opportunity_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_opportunity_socialactivity|  
|Opportunity_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_opportunity_syncerror|  
|Opportunity_Tasks|[task EntityType](task.md)|regardingobjectid_opportunity_task|  
|opportunity_Teams|[team EntityType](team.md)|regardingobjectid_opportunity|  
|opportunitycompetitors_association|[competitor EntityType](competitor.md)|opportunitycompetitors_association|  
|product_opportunities|[opportunityproduct EntityType](opportunityproduct.md)|opportunityid|  
|slakpiinstance_opportunity|[slakpiinstance EntityType](slakpiinstance.md)|regarding_opportunity|  

## Operations
The following operations can be used with the opportunity entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[CalculateActualValueOpportunity Action](../actions/calculateactualvalueopportunity.md)|Entity|[!INCLUDE[../actions/descriptions/calculateactualvalueopportunity.md](../actions/descriptions/calculateactualvalueopportunity.md)]|  
|[CalculatePrice Action](../actions/calculateprice.md)|Not Bound|[!INCLUDE[../actions/descriptions/calculateprice.md](../actions/descriptions/calculateprice.md)]|  
|[GetQuantityDecimal Function](../functions/getquantitydecimal.md)|Entity|[!INCLUDE[../functions/descriptions/getquantitydecimal.md](../functions/descriptions/getquantitydecimal.md)]|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[LoseOpportunity Action](../actions/loseopportunity.md)|Not Bound|[!INCLUDE[../actions/descriptions/loseopportunity.md](../actions/descriptions/loseopportunity.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[msdyn_CloseAllOpportunityQuotes Action](../actions/msdyn_closeallopportunityquotes.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_closeallopportunityquotes.md](../actions/descriptions/msdyn_closeallopportunityquotes.md)]|  
|[msdyn_CreateQuoteFromOpportunity Action](../actions/msdyn_createquotefromopportunity.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_createquotefromopportunity.md](../actions/descriptions/msdyn_createquotefromopportunity.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  
|[Rollup Function](../functions/rollup.md)|Not Bound|[!INCLUDE[../functions/descriptions/rollup.md](../functions/descriptions/rollup.md)]|  
|[WinOpportunity Action](../actions/winopportunity.md)|Not Bound|[!INCLUDE[../actions/descriptions/winopportunity.md](../actions/descriptions/winopportunity.md)]|  
|[WinQuote Action](../actions/winquote.md)|Not Bound|[!INCLUDE[../actions/descriptions/winquote.md](../actions/descriptions/winquote.md)]|  

## Solutions
The following solutions include the opportunity entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Portal Base Solution](../solutions/microsoftcrmportalbase.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportalbase.md](../solutions/descriptions/microsoftcrmportalbase.md)]|  
|[Dynamics 365 Portals - Portal Dependencies Solution](../solutions/microsoftcrmportaldependencies.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportaldependencies.md](../solutions/descriptions/microsoftcrmportaldependencies.md)]|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[App for Outlook Solution](../solutions/appforoutlook.md)|[!INCLUDE[../solutions/descriptions/appforoutlook.md](../solutions/descriptions/appforoutlook.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|  
|[Microsoft Dynamics CRM Marketing Sales Solution](../solutions/marketingsales.md)|[!INCLUDE[../solutions/descriptions/marketingsales.md](../solutions/descriptions/marketingsales.md)]|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|  
|[Gamification Solution](../solutions/gamification.md)|[!INCLUDE[../solutions/descriptions/gamification.md](../solutions/descriptions/gamification.md)]|    

[!INCLUDE[./remarks/opportunity.md](./remarks/opportunity.md)]

### See also  
 [Use the Microsoft Dynamics CRM Web API](https://msdn.microsoft.com/library/mt593051.aspx)<br />
 [Web API EntityType Reference](../entitytypereference.md)<br />
 [Web API Action Reference](../actionreference.md)<br />
 [Web API Function Reference](../functionreference.md)<br />
 [Web API Query Function Reference](../queryfunctionreference.md)<br />
 [Web API EnumType Reference](../enumtypereference.md)<br />
 [Web API ComplexType Reference](../complextypereference.md)<br />
 [Web API Metadata EntityType Reference](../entitytypereference.md)<br />
 [Web API Solutions Reference](../solutionreference.md)<br />