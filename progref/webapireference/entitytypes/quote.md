---
title: "Microsoft Dynamics 365 Customer Engagement quote EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b2b14c07-6c5d-422f-a378-3dfa25ec1c62
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API quote entitytype."
---
# quote EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/quote.md](./descriptions/quote.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]quotes </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Quote</td></tr>
<tr><td><b>Primary Key:</b></td><td>quoteid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|billto_addressid|Edm.Guid|**Display Name**: Bill To Address ID<br />**Description**: Unique identifier of the billing address.<br />|
|billto_city|Edm.String|**Display Name**: Bill To City<br />**Description**: Type the city for the customer's billing address.<br />|
|billto_composite|Edm.String|**Display Name**: Bill To Address<br />**Description**: Shows the complete Bill To address.<br />Read-only<br />|
|billto_contactname|Edm.String|**Display Name**: Bill To Contact Name<br />**Description**: Type the primary contact name at the customer's billing address.<br />|
|billto_country|Edm.String|**Display Name**: Bill To Country/Region<br />**Description**: Type the country or region for the customer's billing address.<br />|
|billto_fax|Edm.String|**Display Name**: Bill To Fax<br />**Description**: Type the fax number for the customer's billing address.<br />|
|billto_line1|Edm.String|**Display Name**: Bill To Street 1<br />**Description**: Type the first line of the customer's billing address.<br />|
|billto_line2|Edm.String|**Display Name**: Bill To Street 2<br />**Description**: Type the second line of the customer's billing address.<br />|
|billto_line3|Edm.String|**Display Name**: Bill To Street 3<br />**Description**: Type the third line of the billing address.<br />|
|billto_name|Edm.String|**Display Name**: Bill To Name<br />**Description**: Type a name for the customer's billing address, such as "Headquarters" or "Field office", to identify the address.<br />|
|billto_postalcode|Edm.String|**Display Name**: Bill To ZIP/Postal Code<br />**Description**: Type the ZIP Code or postal code for the billing address.<br />|
|billto_stateorprovince|Edm.String|**Display Name**: Bill To State/Province<br />**Description**: Type the state or province for the billing address.<br />|
|billto_telephone|Edm.String|**Display Name**: Bill To Phone<br />**Description**: Type the phone number for the customer's billing address.<br />|
|closedon|Edm.Date|**Display Name**: Closed On<br />**Description**: Enter the date when the quote was closed to indicate the expiration, revision, or cancellation date.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the quote, such as the products or services offered or details about the customer's product preferences.<br />|
|discountamount|Edm.Decimal|**Display Name**: Quote Discount Amount<br />**Description**: Type the discount amount for the quote if the customer is eligible for special savings.<br />|
|discountamount_base|Edm.Decimal|**Display Name**: Quote Discount Amount (Base)<br />**Description**: Value of the Quote Discount Amount in base currency.<br />Read-only<br />|
|discountpercentage|Edm.Decimal|**Display Name**: Quote Discount (%)<br />**Description**: Type the discount rate that should be applied to the Detail Amount field to include additional savings for the customer in the quote.<br />|
|effectivefrom|Edm.DateTimeOffset|**Display Name**: Effective From<br />**Description**: Enter the date when the quote pricing is effective or was first communicated to the customer.<br />|
|effectiveto|Edm.DateTimeOffset|**Display Name**: Effective To<br />**Description**: Enter the expiration date or last day the quote pricing is effective for the customer.<br />|
|emailaddress|Edm.String|**Display Name**: Email Address<br />**Description**: The primary email address for the entity.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|expireson|Edm.Date|**Display Name**: Due By<br />**Description**: Enter the date a decision or order is due from the customer to indicate the expiration date of the quote.<br />|
|freightamount|Edm.Decimal|**Display Name**: Freight Amount<br />**Description**: Type the cost of freight or shipping for the products included in the quote for use in calculating the Total Amount field.<br />|
|freightamount_base|Edm.Decimal|**Display Name**: Freight Amount (Base)<br />**Description**: Value of the Freight Amount in base currency.<br />Read-only<br />|
|freighttermscode|Edm.Int32|**Display Name**: Freight Terms<br />**Description**: Select the freight terms to make sure shipping charges are processed correctly.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>FOB</td></tr><tr><td>2</td><td>No Charge</td></tr><tbody></table>|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|lastonholdtime|Edm.DateTimeOffset|**Display Name**: Last On Hold Time<br />**Description**: Contains the date time stamp of the last on hold time.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_adjustedgrossmargin|Edm.Decimal|**Display Name**: Adjusted Gross Margin (%)<br />**Description**: Shows the estimated gross margin after accounting for non-chargeable components.<br />Computed<br />Read-only<br />|
|msdyn_competitive|Edm.Int32|**Display Name**: Competitive<br />**Description**: Shows how the quote estimation of sales value and schedule compare to customer expectations on those parameters. Possible values are 1: Within Customer expectations, 2: Not Within Customer expectations, and 0: Customer expectations Not Available.<br />Computed<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Customer Budget Not Available</td></tr><tr><td>192350001</td><td>Within Customer Expectations</td></tr><tr><td>192350002</td><td>Outside Customer Expectations</td></tr><tbody></table>|
|msdyn_customerbudgetrollup|Edm.Decimal|**Display Name**: Customer Budget<br />**Description**: Shows the total customer budget for the quote, computed from all the quote lines.<br />Computed<br />Read-only<br />|
|msdyn_customerbudgetrollup_base|Edm.Decimal|**Display Name**: Customer Budget (Base)<br />**Description**: Shows the value of the customer budget in the base currency.<br />Computed<br />Read-only<br />|
|msdyn_customerbudgetrollup_date|Edm.DateTimeOffset|**Display Name**: Customer Budget (Last Updated On)<br />**Description**: Last Updated time of rollup field Customer Budget.<br />Read-only<br />|
|msdyn_customerbudgetrollup_state|Edm.Int32|**Display Name**: Customer Budget (State)<br />**Description**: State of rollup field Customer Budget.<br />Read-only<br />|
|msdyn_estimatedbudget|Edm.Int32|**Display Name**: Estimated Budget<br />**Description**: Shows how the estimated sales value on the quote compares to customer budgets. Possible values are 1: Within Customer Budget, 2: Exceeds Customer Budget, 0: Budget Estimate Not Available<br />Computed<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Budget Estimate Not Available</td></tr><tr><td>192350001</td><td>Within Customer Budget</td></tr><tr><td>192350002</td><td>Exceeds Customer Budget</td></tr><tbody></table>|
|msdyn_estimatedcompletionrollup|Edm.DateTimeOffset|**Display Name**: Estimated Completion<br />**Description**: Estimated completion date, computed from the details of each quote line.<br />Computed<br />Read-only<br />|
|msdyn_estimatedcompletionrollup_date|Edm.DateTimeOffset|**Display Name**: Estimated Completion (Last Updated On)<br />**Description**: Last Updated time of rollup field Estimated Completion.<br />Read-only<br />|
|msdyn_estimatedcompletionrollup_state|Edm.Int32|**Display Name**: Estimated Completion (State)<br />**Description**: State of rollup field Estimated Completion.<br />Read-only<br />|
|msdyn_estimatedcost|Edm.Decimal|**Display Name**: Estimated Cost<br />**Description**: The estimated cost of this quote<br />|
|msdyn_estimatedcost_base|Edm.Decimal|**Display Name**: Estimated Cost (Base)<br />**Description**: Value of the Estimated Cost in base currency.<br />Read-only<br />|
|msdyn_estimatedquotemargin|Edm.Decimal|**Display Name**: Estimated Margin<br />**Description**: Estimated Margin of this quote<br />Computed<br />Read-only<br />|
|msdyn_estimatedschedule|Edm.Int32|**Display Name**: Estimated Schedule<br />**Description**: Shows how the estimated schedule on the quote compares to customer expectations. Possible values are 1: Estimated To Finish Early, 2: Estimated To Finish Late, 3: Estimated To Finish On Schedule, and 0: Schedule Not Available.<br />Computed<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Schedule Not Available</td></tr><tr><td>192350001</td><td>Estimated To Finish Early</td></tr><tr><td>192350002</td><td>Estimated To Finish Late</td></tr><tr><td>192350003</td><td>Estimated To Finish On Schedule</td></tr><tbody></table>|
|msdyn_feasible|Edm.Int32|**Display Name**: Feasibility<br />**Description**: Shows how the quote estimation compares to project estimation. Possible values are 0: Feasibility Not Available, 1: Feasible, and 2: Not Feasible.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Feasibility Not Available</td></tr><tr><td>192350001</td><td>Feasible</td></tr><tr><td>192350002</td><td>Not Feasible</td></tr><tbody></table>|
|msdyn_grossmargin|Edm.Decimal|**Display Name**: Gross Margin (%)<br />**Description**: Shows the estimated gross margin without accounting for non-chargeable components.<br />Computed<br />Read-only<br />|
|msdyn_invoicesetuptotals|Edm.Decimal|**Display Name**: Invoice Setup Totals<br />**Description**: The totals of all assigned Invoice Setups<br />|
|msdyn_invoicesetuptotals_base|Edm.Decimal|**Display Name**: Invoice Setup Totals (Base)<br />**Description**: Value of the Invoice Setup Totals in base currency.<br />Read-only<br />|
|msdyn_ordertype|Edm.Int32|**Display Name**: Type<br />**Description**: Select whether the project contract is for an item-based or a work-based sale.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970002</td><td>Service-Maintenance Based</td></tr><tr><td>192350000</td><td>Item based</td></tr><tr><td>192350001</td><td>Work based</td></tr><tbody></table>|
|msdyn_profitability|Edm.Int32|**Display Name**: Profitability<br />**Description**: Shows the estimated profitability of the quote. Possible values are Profitable, Not Profitable, and Profitability not available.<br />Computed<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Profitability Not Available</td></tr><tr><td>192350001</td><td>Profitable</td></tr><tr><td>192350002</td><td>Not Profitable</td></tr><tbody></table>|
|msdyn_quotelineenddate|Edm.DateTimeOffset|**Display Name**: Latest Quote Line End Date<br />**Description**: The latest end date of all associated quote lines<br />|
|msdyn_quotelinestartdate|Edm.DateTimeOffset|**Display Name**: Earliest Quote Line Start Date<br />**Description**: The earliest Start Date of all Quote Lines that are associated to this quote<br />|
|msdyn_totalamount|Edm.Decimal|**Display Name**: TotalAmount<br />Computed<br />Read-only<br />|
|msdyn_totalamount_base|Edm.Decimal|**Display Name**: TotalAmount (Base)<br />**Description**: Value of the TotalAmount in base currency.<br />Computed<br />Read-only<br />|
|msdyn_totalchargeablecostrollup|Edm.Decimal|**Display Name**: Total Chargeable Cost<br />Computed<br />Read-only<br />|
|msdyn_totalchargeablecostrollup_base|Edm.Decimal|**Display Name**: Total Chargeable Cost (Base)<br />**Description**: Value of the Total Chargeable Cost in base currency.<br />Computed<br />Read-only<br />|
|msdyn_totalchargeablecostrollup_date|Edm.DateTimeOffset|**Display Name**: Total Chargeable Cost (Last Updated On)<br />**Description**: Last Updated time of rollup field Total Chargeable Cost.<br />Read-only<br />|
|msdyn_totalchargeablecostrollup_state|Edm.Int32|**Display Name**: Total Chargeable Cost (State)<br />**Description**: State of rollup field Total Chargeable Cost.<br />Read-only<br />|
|msdyn_totalnonchargeablecostrollup|Edm.Decimal|**Display Name**: Total Non-chargeable Cost<br />Computed<br />Read-only<br />|
|msdyn_totalnonchargeablecostrollup_base|Edm.Decimal|**Display Name**: Total Non-chargeable Cost (Base)<br />**Description**: Value of the Total Non-chargeable Cost in base currency.<br />Computed<br />Read-only<br />|
|msdyn_totalnonchargeablecostrollup_date|Edm.DateTimeOffset|**Display Name**: Total Non-chargeable Cost (Last Updated On)<br />**Description**: Last Updated time of rollup field Total Non-chargeable Cost.<br />Read-only<br />|
|msdyn_totalnonchargeablecostrollup_state|Edm.Int32|**Display Name**: Total Non-chargeable Cost (State)<br />**Description**: State of rollup field Total Non-chargeable Cost.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type a descriptive name for the quote.<br />|
|onholdtime|Edm.Int32|**Display Name**: On Hold Time (Minutes)<br />**Description**: Shows the duration in minutes for which the quote was on hold.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|paymenttermscode|Edm.Int32|**Display Name**: Payment Terms<br />**Description**: Select the payment terms to indicate when the customer needs to pay the total amount.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Net 30</td></tr><tr><td>2</td><td>2% 10, Net 30</td></tr><tr><td>3</td><td>Net 45</td></tr><tr><td>4</td><td>Net 60</td></tr><tbody></table>|
|pricingerrorcode|Edm.Int32|**Display Name**: Pricing Error <br />**Description**: Pricing error for the quote.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>None</td></tr><tr><td>1</td><td>Detail Error</td></tr><tr><td>2</td><td>Missing Price Level</td></tr><tr><td>3</td><td>Inactive Price Level</td></tr><tr><td>4</td><td>Missing Quantity</td></tr><tr><td>5</td><td>Missing Unit Price</td></tr><tr><td>6</td><td>Missing Product</td></tr><tr><td>7</td><td>Invalid Product</td></tr><tr><td>8</td><td>Missing Pricing Code</td></tr><tr><td>9</td><td>Invalid Pricing Code</td></tr><tr><td>10</td><td>Missing UOM</td></tr><tr><td>11</td><td>Product Not In Price Level</td></tr><tr><td>12</td><td>Missing Price Level Amount</td></tr><tr><td>13</td><td>Missing Price Level Percentage</td></tr><tr><td>14</td><td>Missing Price</td></tr><tr><td>15</td><td>Missing Current Cost</td></tr><tr><td>16</td><td>Missing Standard Cost</td></tr><tr><td>17</td><td>Invalid Price Level Amount</td></tr><tr><td>18</td><td>Invalid Price Level Percentage</td></tr><tr><td>19</td><td>Invalid Price</td></tr><tr><td>20</td><td>Invalid Current Cost</td></tr><tr><td>21</td><td>Invalid Standard Cost</td></tr><tr><td>22</td><td>Invalid Rounding Policy</td></tr><tr><td>23</td><td>Invalid Rounding Option</td></tr><tr><td>24</td><td>Invalid Rounding Amount</td></tr><tr><td>25</td><td>Price Calculation Error</td></tr><tr><td>26</td><td>Invalid Discount Type</td></tr><tr><td>27</td><td>Discount Type Invalid State</td></tr><tr><td>28</td><td>Invalid Discount</td></tr><tr><td>29</td><td>Invalid Quantity</td></tr><tr><td>30</td><td>Invalid Pricing Precision</td></tr><tr><td>31</td><td>Missing Product Default UOM</td></tr><tr><td>32</td><td>Missing Product UOM Schedule </td></tr><tr><td>33</td><td>Inactive Discount Type</td></tr><tr><td>34</td><td>Invalid Price Level Currency</td></tr><tr><td>35</td><td>Price Attribute Out Of Range</td></tr><tr><td>36</td><td>Base Currency Attribute Overflow</td></tr><tr><td>37</td><td>Base Currency Attribute Underflow</td></tr><tbody></table>|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|quoteid|Edm.Guid|**Display Name**: Quote<br />**Description**: Unique identifier of the quote.<br />|
|quotenumber|Edm.String|**Display Name**: Quote ID<br />**Description**: Shows the quote number for customer reference and searching capabilities. The number cannot be modified.<br />|
|requestdeliveryby|Edm.DateTimeOffset|**Display Name**: Requested Delivery Date<br />**Description**: Enter the delivery date requested by the customer for all products in the quote.<br />|
|revisionnumber|Edm.Int32|**Display Name**: Revision ID<br />**Description**: Shows the version number of the quote for revision history tracking.<br />Read-only<br />|
|shippingmethodcode|Edm.Int32|**Display Name**: Shipping Method<br />**Description**: Select a shipping method for deliveries sent to this address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Airborne</td></tr><tr><td>2</td><td>DHL</td></tr><tr><td>3</td><td>FedEx</td></tr><tr><td>4</td><td>UPS</td></tr><tr><td>5</td><td>Postal Mail</td></tr><tr><td>6</td><td>Full Load</td></tr><tr><td>7</td><td>Will Call</td></tr><tbody></table>|
|shipto_addressid|Edm.Guid|**Display Name**: Ship To Address ID<br />**Description**: Unique identifier of the shipping address.<br />|
|shipto_city|Edm.String|**Display Name**: Ship To City<br />**Description**: Type the city for the customer's shipping address.<br />|
|shipto_composite|Edm.String|**Display Name**: Ship To Address<br />**Description**: Shows the complete Ship To address.<br />Read-only<br />|
|shipto_contactname|Edm.String|**Display Name**: Ship To Contact Name<br />**Description**: Type the primary contact name at the customer's shipping address.<br />|
|shipto_country|Edm.String|**Display Name**: Ship To Country/Region<br />**Description**: Type the country or region for the customer's shipping address.<br />|
|shipto_fax|Edm.String|**Display Name**: Ship To Fax<br />**Description**: Type the fax number for the customer's shipping address.<br />|
|shipto_freighttermscode|Edm.Int32|**Display Name**: Ship To Freight Terms<br />**Description**: Select the freight terms to make sure shipping orders are processed correctly.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|shipto_line1|Edm.String|**Display Name**: Ship To Street 1<br />**Description**: Type the first line of the customer's shipping address.<br />|
|shipto_line2|Edm.String|**Display Name**: Ship To Street 2<br />**Description**: Type the second line of the customer's shipping address.<br />|
|shipto_line3|Edm.String|**Display Name**: Ship To Street 3<br />**Description**: Type the third line of the shipping address.<br />|
|shipto_name|Edm.String|**Display Name**: Ship To Name<br />**Description**: Type a name for the customer's shipping address, such as "Headquarters" or "Field office",  to identify the address.<br />|
|shipto_postalcode|Edm.String|**Display Name**: Ship To ZIP/Postal Code<br />**Description**: Type the ZIP Code or postal code for the shipping address.<br />|
|shipto_stateorprovince|Edm.String|**Display Name**: Ship To State/Province<br />**Description**: Type the state or province for the shipping address.<br />|
|shipto_telephone|Edm.String|**Display Name**: Ship To Phone<br />**Description**: Type the phone number for the customer's shipping address.<br />|
|stageid|Edm.Guid|**Display Name**: Stage Id<br />**Description**: Contains the id of the stage where the entity is located.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the quote is draft, active, won, or closed. Only draft quotes can be edited.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Draft</td></tr><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Won</td></tr><tr><td>3</td><td>Closed</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the quote's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>2</td><td>In Progress</td></tr><tr><td>3</td><td>Open</td></tr><tr><td>4</td><td>Won</td></tr><tr><td>5</td><td>Lost</td></tr><tr><td>6</td><td>Canceled</td></tr><tr><td>7</td><td>Revised</td></tr><tr><td>1</td><td>In Progress</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|totalamount|Edm.Decimal|**Display Name**: Total Amount<br />**Description**: Shows the total amount due, calculated as the sum of the products, discounts, freight, and taxes for the quote.<br />|
|totalamount_base|Edm.Decimal|**Display Name**: Total Amount (Base)<br />**Description**: Value of the Total Amount in base currency.<br />Read-only<br />|
|totalamountlessfreight|Edm.Decimal|**Display Name**: Total Pre-Freight Amount<br />**Description**: Shows the total product amount for the quote, minus any discounts. This value is added to freight and tax amounts in the calculation for the total amount due for the quote.<br />|
|totalamountlessfreight_base|Edm.Decimal|**Display Name**: Total Pre-Freight Amount (Base)<br />**Description**: Value of the Total Pre-Freight Amount in base currency.<br />Read-only<br />|
|totaldiscountamount|Edm.Decimal|**Display Name**: Total Discount Amount<br />**Description**: Shows the total discount amount, based on the discount price and rate entered on the quote.<br />|
|totaldiscountamount_base|Edm.Decimal|**Display Name**: Total Discount Amount (Base)<br />**Description**: Value of the Total Discount Amount in base currency.<br />Read-only<br />|
|totallineitemamount|Edm.Decimal|**Display Name**: Total Detail Amount<br />**Description**: Shows the sum of all existing and write-in products included on the quote, based on the specified price list and quantities.<br />|
|totallineitemamount_base|Edm.Decimal|**Display Name**: Total Detail Amount (Base)<br />**Description**: Value of the Total Detail Amount in base currency.<br />Read-only<br />|
|totallineitemdiscountamount|Edm.Decimal|**Display Name**: Total Line Item Discount Amount<br />**Description**: Shows the total of the Manual Discount amounts specified on all products included in the quote. This value is reflected in the Detail Amount field on the quote and is added to any discount amount or rate specified on the quote<br />|
|totallineitemdiscountamount_base|Edm.Decimal|**Display Name**: Total Line Item Discount Amount (Base)<br />**Description**: Value of the Total Line Item Discount Amount in base currency.<br />Read-only<br />|
|totaltax|Edm.Decimal|**Display Name**: Total Tax<br />**Description**: Shows the total of the Tax amounts specified on all products included in the quote, included in the Total Amount due calculation for the quote.<br />|
|totaltax_base|Edm.Decimal|**Display Name**: Total Tax (Base)<br />**Description**: Value of the Total Tax in base currency.<br />Read-only<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|
|willcall|Edm.Boolean|**Display Name**: Ship To<br />**Description**: Select whether the products included in the quote should be shipped to the specified address or held until the customer calls with further pick up or delivery instructions.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Will Call</td></tr><tr><td>0</td><td>Address</td></tr><tbody></table>|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_accountid_value||Unique identifier of the account with which the quote is associated.|
|_campaignid_value|campaignid<br />|Shows the campaign that the order was created from.|
|_contactid_value||Unique identifier of the contact associated with the quote.|
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_customerid_value|customerid_account<br />customerid_contact<br />|Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_msdyn_account_value|msdyn_account<br />|Customer Account associated with this Quote|
|_msdyn_accountmanagerid_value|msdyn_AccountManagerId<br />|Account manager responsible for the quote.|
|_msdyn_contractorganizationalunitid_value|msdyn_ContractOrganizationalUnitId<br />|The organizational unit in charge of the contract.|
|_opportunityid_value|opportunityid<br />|Choose the opportunity that the quote is related to for reporting and analytics.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_pricelevelid_value|pricelevelid<br />|Choose the price list associated with this record to make sure the products associated with the campaign are offered at the correct prices.|
|_slaid_value|sla_quote_sla<br />|Choose the service level agreement (SLA) that you want to apply to the quote record.|
|_slainvokedid_value|slainvokedid_quote_sla<br />|Last SLA that was applied to this quote. This field is for internal use only.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|campaignid|[campaign EntityType](campaign.md)|campaign_quotes|
|createdby|[systemuser EntityType](systemuser.md)|lk_quotebase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_quote_createdonbehalfby|
|customerid_account|[account EntityType](account.md)|quote_customer_accounts|
|customerid_contact|[contact EntityType](contact.md)|quote_customer_contacts|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_quotebase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_quote_modifiedonbehalfby|
|msdyn_account|[account EntityType](account.md)|msdyn_account_quote_Account|
|msdyn_AccountManagerId|[systemuser EntityType](systemuser.md)|msdyn_accountmanager_quote|
|msdyn_ContractOrganizationalUnitId|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_organizationalunit_quote|
|opportunityid|[opportunity EntityType](opportunity.md)|opportunity_quotes|
|ownerid|[principal EntityType](principal.md)|owner_quotes|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_quotes|
|owningteam|[team EntityType](team.md)|team_quotes|
|owninguser|[systemuser EntityType](systemuser.md)|system_user_quotes|
|pricelevelid|[pricelevel EntityType](pricelevel.md)|price_level_quotes|
|sla_quote_sla|[sla EntityType](sla.md)|manualsla_quote|
|slainvokedid_quote_sla|[sla EntityType](sla.md)|sla_quote|
|stageid_processstage|[processstage EntityType](processstage.md)|processstage_quotes|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_quote|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_webformsession_quote|[adx_webformsession EntityType](adx_webformsession.md)|adx_quoteid|  
|contactquotes_association|[contact EntityType](contact.md)|contactquotes_association|  
|msdyn_quote_msdyn_quotebookingincident_Quote|[msdyn_quotebookingincident EntityType](msdyn_quotebookingincident.md)|msdyn_Quote|  
|msdyn_quote_msdyn_quotebookingproduct_Quote|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|msdyn_quote|  
|msdyn_quote_msdyn_quotebookingservice_Quote|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|msdyn_quote|  
|msdyn_quote_msdyn_quotebookingservicetask_Quote|[msdyn_quotebookingservicetask EntityType](msdyn_quotebookingservicetask.md)|msdyn_quote|  
|msdyn_quote_msdyn_quotebookingsetup_Quote|[msdyn_quotebookingsetup EntityType](msdyn_quotebookingsetup.md)|msdyn_quote|  
|msdyn_quote_msdyn_quoteinvoicingsetup_Quote|[msdyn_quoteinvoicingsetup EntityType](msdyn_quoteinvoicingsetup.md)|msdyn_Quote|  
|msdyn_quote_msdyn_quotelineanalyticsbreakdown_Quote|[msdyn_quotelineanalyticsbreakdown EntityType](msdyn_quotelineanalyticsbreakdown.md)|msdyn_Quote|  
|msdyn_quote_msdyn_quotelinetransaction|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_QuoteId|  
|msdyn_quote_msdyn_quotepricelist_Quote|[msdyn_quotepricelist EntityType](msdyn_quotepricelist.md)|msdyn_Quote|  
|quote_activity_parties|[activityparty EntityType](activityparty.md)|partyid_quote|  
|Quote_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_quote|  
|quote_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_quote_adx_alertsubscription|  
|quote_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_quote_adx_inviteredemption|  
|quote_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_quote_adx_portalcomment|  
|Quote_Annotation|[annotation EntityType](annotation.md)|objectid_quote|  
|Quote_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_quote_appointment|  
|Quote_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_quote|  
|Quote_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_quote|  
|quote_connections1|[connection EntityType](connection.md)|record1id_quote|  
|quote_connections2|[connection EntityType](connection.md)|record2id_quote|  
|quote_details|[quotedetail EntityType](quotedetail.md)|quoteid|  
|Quote_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_quote|  
|Quote_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_quote|  
|Quote_Emails|[email EntityType](email.md)|regardingobjectid_quote_email|  
|Quote_Faxes|[fax EntityType](fax.md)|regardingobjectid_quote_fax|  
|Quote_Letters|[letter EntityType](letter.md)|regardingobjectid_quote_letter|  
|quote_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_quote_msdyn_approval|  
|quote_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_quote_msdyn_bookingalert|  
|quote_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_quote_msdyn_surveyinvite|  
|quote_opportunitysalesprocess|[opportunitysalesprocess EntityType](opportunitysalesprocess.md)|quoteid|  
|quote_orders|[salesorder EntityType](salesorder.md)|quoteid|  
|Quote_Phonecalls|[phonecall EntityType](phonecall.md)|regardingobjectid_quote_phonecall|  
|Quote_QuoteClose|[quoteclose EntityType](quoteclose.md)|quoteid|  
|quote_QuoteCloses|[quoteclose EntityType](quoteclose.md)|regardingobjectid_quote_quoteclose|  
|Quote_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_quote_recurringappointmentmaster|  
|Quote_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_quote_serviceappointment|  
|Quote_SharepointDocumentLocation|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_quote|  
|Quote_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_quote_socialactivity|  
|Quote_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_quote_syncerror|  
|Quote_Tasks|[task EntityType](task.md)|regardingobjectid_quote_task|  
|slakpiinstance_quote|[slakpiinstance EntityType](slakpiinstance.md)|regarding_quote|  

## Operations
The following operations can be used with the quote entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[CalculatePrice Action](../actions/calculateprice.md)|Not Bound|[!INCLUDE[../actions/descriptions/calculateprice.md](../actions/descriptions/calculateprice.md)]|  
|[CloseIncident Action](../actions/closeincident.md)|Not Bound|[!INCLUDE[../actions/descriptions/closeincident.md](../actions/descriptions/closeincident.md)]|  
|[CloseQuote Action](../actions/closequote.md)|Not Bound|[!INCLUDE[../actions/descriptions/closequote.md](../actions/descriptions/closequote.md)]|  
|[ConvertQuoteToSalesOrder Action](../actions/convertquotetosalesorder.md)|Not Bound|[!INCLUDE[../actions/descriptions/convertquotetosalesorder.md](../actions/descriptions/convertquotetosalesorder.md)]|  
|[GenerateQuoteFromOpportunity Action](../actions/generatequotefromopportunity.md)|Not Bound|[!INCLUDE[../actions/descriptions/generatequotefromopportunity.md](../actions/descriptions/generatequotefromopportunity.md)]|  
|[GetQuantityDecimal Function](../functions/getquantitydecimal.md)|Entity|[!INCLUDE[../functions/descriptions/getquantitydecimal.md](../functions/descriptions/getquantitydecimal.md)]|  
|[GetQuoteProductsFromOpportunity Action](../actions/getquoteproductsfromopportunity.md)|Entity|[!INCLUDE[../actions/descriptions/getquoteproductsfromopportunity.md](../actions/descriptions/getquoteproductsfromopportunity.md)]|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[msdyn_CloseQuoteAsLost Action](../actions/msdyn_closequoteaslost.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_closequoteaslost.md](../actions/descriptions/msdyn_closequoteaslost.md)]|  
|[msdyn_CloseQuoteAsWon Action](../actions/msdyn_closequoteaswon.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_closequoteaswon.md](../actions/descriptions/msdyn_closequoteaswon.md)]|  
|[msdyn_CreateQuoteSpecificPriceList Action](../actions/msdyn_createquotespecificpricelist.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_createquotespecificpricelist.md](../actions/descriptions/msdyn_createquotespecificpricelist.md)]|  
|[msdyn_GetProjectsForQuote Action](../actions/msdyn_getprojectsforquote.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_getprojectsforquote.md](../actions/descriptions/msdyn_getprojectsforquote.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[ReviseQuote Action](../actions/revisequote.md)|Not Bound|[!INCLUDE[../actions/descriptions/revisequote.md](../actions/descriptions/revisequote.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  
|[Rollup Function](../functions/rollup.md)|Not Bound|[!INCLUDE[../functions/descriptions/rollup.md](../functions/descriptions/rollup.md)]|  
|[WinOpportunity Action](../actions/winopportunity.md)|Not Bound|[!INCLUDE[../actions/descriptions/winopportunity.md](../actions/descriptions/winopportunity.md)]|  
|[WinQuote Action](../actions/winquote.md)|Not Bound|[!INCLUDE[../actions/descriptions/winquote.md](../actions/descriptions/winquote.md)]|  

## Solutions
The following solutions include the quote entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|  
|[Microsoft Dynamics CRM Marketing Sales Solution](../solutions/marketingsales.md)|[!INCLUDE[../solutions/descriptions/marketingsales.md](../solutions/descriptions/marketingsales.md)]|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|    

[!INCLUDE[./remarks/quote.md](./remarks/quote.md)]

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