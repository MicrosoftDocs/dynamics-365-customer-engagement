---
title: "Microsoft Dynamics 365 Customer Engagement salesorder EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d7bc6bdf-6e06-43a5-95e2-b3196ab69b3f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API salesorder entitytype."
---
# salesorder EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/salesorder.md](./descriptions/salesorder.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]salesorders </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Order</td></tr>
<tr><td><b>Primary Key:</b></td><td>salesorderid</td></tr>
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
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|datefulfilled|Edm.DateTimeOffset|**Display Name**: Date Fulfilled<br />**Description**: Enter the date that all or part of the order was shipped to the customer.<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the order, such as the products or services offered or details about the customer's product preferences.<br />|
|discountamount|Edm.Decimal|**Display Name**: Order Discount Amount<br />**Description**: Type the discount amount for the order if the customer is eligible for special savings.<br />|
|discountamount_base|Edm.Decimal|**Display Name**: Order Discount Amount (Base)<br />**Description**: Value of the Order Discount Amount in base currency.<br />Read-only<br />|
|discountpercentage|Edm.Decimal|**Display Name**: Order Discount (%)<br />**Description**: Type the discount rate that should be applied to the Detail Amount field to include additional savings for the customer in the order.<br />|
|emailaddress|Edm.String|**Display Name**: Email Address<br />**Description**: The primary email address for the entity.<br />|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: The default image for the entity.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|freightamount|Edm.Decimal|**Display Name**: Freight Amount<br />**Description**: Type the cost of freight or shipping for the products included in the order for use in calculating the Total Amount field.<br />|
|freightamount_base|Edm.Decimal|**Display Name**: Freight Amount (Base)<br />**Description**: Value of the Freight Amount in base currency.<br />Read-only<br />|
|freighttermscode|Edm.Int32|**Display Name**: Freight Terms<br />**Description**: Select the freight terms to make sure shipping charges are processed correctly.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>FOB</td></tr><tr><td>2</td><td>No Charge</td></tr><tbody></table>|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|ispricelocked|Edm.Boolean|**Display Name**: Prices Locked<br />**Description**: Select whether prices specified on the invoice are locked from any further updates.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|lastbackofficesubmit|Edm.DateTimeOffset|**Display Name**: Last Submitted to Back Office<br />**Description**: Enter the date and time when the order was last submitted to an accounting or ERP system for processing.<br />|
|lastonholdtime|Edm.DateTimeOffset|**Display Name**: Last On Hold Time<br />**Description**: Contains the date time stamp of the last on hold time.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_ordertype|Edm.Int32|**Display Name**: Type<br />**Description**: Whether it is for an Item- based or a Work-based sale<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970002</td><td>Service-Maintenance Based</td></tr><tr><td>192350000</td><td>Item based</td></tr><tr><td>192350001</td><td>Work based</td></tr><tbody></table>|
|msdyn_psastate|Edm.Int32|**Display Name**: Contract Status<br />**Description**: Shows the current state of the project contract.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Draft</td></tr><tr><td>192350001</td><td>On hold</td></tr><tr><td>192350002</td><td>Active</td></tr><tr><td>192350003</td><td>Closed</td></tr><tbody></table>|
|msdyn_psastatusreason|Edm.Int32|**Display Name**: Contract Status Reason<br />**Description**: Shows the reason for the project contract status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Draft</td></tr><tr><td>192350001</td><td>In review</td></tr><tr><td>192350002</td><td>On hold</td></tr><tr><td>192350003</td><td>Confirmed</td></tr><tr><td>192350004</td><td>Completed</td></tr><tr><td>192350005</td><td>Lost</td></tr><tr><td>192350006</td><td>Abandoned</td></tr><tbody></table>|
|msdyn_totalchargeablecostrollup|Edm.Decimal|**Display Name**: Total Chargeable Cost<br />**Description**: Value of the estimated chargeable cost.<br />Computed<br />Read-only<br />|
|msdyn_totalchargeablecostrollup_base|Edm.Decimal|**Display Name**: Total Chargeable Cost (Base)<br />**Description**: Value of the Total Chargeable Cost in base currency.<br />Computed<br />Read-only<br />|
|msdyn_totalchargeablecostrollup_date|Edm.DateTimeOffset|**Display Name**: Total Chargeable Cost (Last Updated On)<br />**Description**: Last Updated time of rollup field Total Chargeable Cost.<br />Read-only<br />|
|msdyn_totalchargeablecostrollup_state|Edm.Int32|**Display Name**: Total Chargeable Cost (State)<br />**Description**: State of rollup field Total Chargeable Cost.<br />Read-only<br />|
|msdyn_totalnonchargeablecostrollup|Edm.Decimal|**Display Name**: Total Non-chargeable Cost<br />**Description**: Total estimated cost that will not be charged to the customer.<br />Computed<br />Read-only<br />|
|msdyn_totalnonchargeablecostrollup_base|Edm.Decimal|**Display Name**: Total Non-chargeable Cost (Base)<br />**Description**: Value of the Total Non-chargeable Cost in base currency.<br />Computed<br />Read-only<br />|
|msdyn_totalnonchargeablecostrollup_date|Edm.DateTimeOffset|**Display Name**: Total Non-chargeable Cost (Last Updated On)<br />**Description**: Last Updated time of rollup field Total Non-chargeable Cost.<br />Read-only<br />|
|msdyn_totalnonchargeablecostrollup_state|Edm.Int32|**Display Name**: Total Non-chargeable Cost (State)<br />**Description**: State of rollup field Total Non-chargeable Cost.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type a descriptive name for the order.<br />|
|onholdtime|Edm.Int32|**Display Name**: On Hold Time (Minutes)<br />**Description**: Shows the duration in minutes for which the order was on hold.<br />Read-only<br />|
|ordernumber|Edm.String|**Display Name**: Order ID<br />**Description**: Shows the order number for customer reference and to use in search. The number cannot be modified.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|paymenttermscode|Edm.Int32|**Display Name**: Payment Terms<br />**Description**: Select the payment terms to indicate when the customer needs to pay the total amount.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Net 30</td></tr><tr><td>2</td><td>2% 10, Net 30</td></tr><tr><td>3</td><td>Net 45</td></tr><tr><td>4</td><td>Net 60</td></tr><tbody></table>|
|pricingerrorcode|Edm.Int32|**Display Name**: Pricing Error <br />**Description**: Select the type of pricing error, such as a missing or invalid product, or missing quantity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>None</td></tr><tr><td>1</td><td>Detail Error</td></tr><tr><td>2</td><td>Missing Price Level</td></tr><tr><td>3</td><td>Inactive Price Level</td></tr><tr><td>4</td><td>Missing Quantity</td></tr><tr><td>5</td><td>Missing Unit Price</td></tr><tr><td>6</td><td>Missing Product</td></tr><tr><td>7</td><td>Invalid Product</td></tr><tr><td>8</td><td>Missing Pricing Code</td></tr><tr><td>9</td><td>Invalid Pricing Code</td></tr><tr><td>10</td><td>Missing UOM</td></tr><tr><td>11</td><td>Product Not In Price Level</td></tr><tr><td>12</td><td>Missing Price Level Amount</td></tr><tr><td>13</td><td>Missing Price Level Percentage</td></tr><tr><td>14</td><td>Missing Price</td></tr><tr><td>15</td><td>Missing Current Cost</td></tr><tr><td>16</td><td>Missing Standard Cost</td></tr><tr><td>17</td><td>Invalid Price Level Amount</td></tr><tr><td>18</td><td>Invalid Price Level Percentage</td></tr><tr><td>19</td><td>Invalid Price</td></tr><tr><td>20</td><td>Invalid Current Cost</td></tr><tr><td>21</td><td>Invalid Standard Cost</td></tr><tr><td>22</td><td>Invalid Rounding Policy</td></tr><tr><td>23</td><td>Invalid Rounding Option</td></tr><tr><td>24</td><td>Invalid Rounding Amount</td></tr><tr><td>25</td><td>Price Calculation Error</td></tr><tr><td>26</td><td>Invalid Discount Type</td></tr><tr><td>27</td><td>Discount Type Invalid State</td></tr><tr><td>28</td><td>Invalid Discount</td></tr><tr><td>29</td><td>Invalid Quantity</td></tr><tr><td>30</td><td>Invalid Pricing Precision</td></tr><tr><td>31</td><td>Missing Product Default UOM</td></tr><tr><td>32</td><td>Missing Product UOM Schedule </td></tr><tr><td>33</td><td>Inactive Discount Type</td></tr><tr><td>34</td><td>Invalid Price Level Currency</td></tr><tr><td>35</td><td>Price Attribute Out Of Range</td></tr><tr><td>36</td><td>Base Currency Attribute Overflow</td></tr><tr><td>37</td><td>Base Currency Attribute Underflow</td></tr><tbody></table>|
|prioritycode|Edm.Int32|**Display Name**: Priority<br />**Description**: Select the priority so that preferred customers or critical issues are handled quickly.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|requestdeliveryby|Edm.DateTimeOffset|**Display Name**: Requested Completion Date<br />**Description**: Enter the delivery date requested by the customer for all products in the order.<br />|
|salesorderid|Edm.Guid|**Display Name**: Order<br />**Description**: Unique identifier of the order.<br />|
|shippingmethodcode|Edm.Int32|**Display Name**: Shipping Method<br />**Description**: Select a shipping method for deliveries sent to this address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Airborne</td></tr><tr><td>2</td><td>DHL</td></tr><tr><td>3</td><td>FedEx</td></tr><tr><td>4</td><td>UPS</td></tr><tr><td>5</td><td>Postal Mail</td></tr><tr><td>6</td><td>Full Load</td></tr><tr><td>7</td><td>Will Call</td></tr><tbody></table>|
|shipto_addressid|Edm.Guid|**Display Name**: Ship To Address ID<br />**Description**: Unique identifier of the shipping address.<br />|
|shipto_city|Edm.String|**Display Name**: Ship To City<br />**Description**: Type the city for the customer's shipping address.<br />|
|shipto_composite|Edm.String|**Display Name**: Ship To Address<br />**Description**: Shows the complete Ship To address.<br />Read-only<br />|
|shipto_contactname|Edm.String|**Display Name**: Ship To Contact Name<br />**Description**: Type the primary contact name at the customer's shipping address.<br />|
|shipto_country|Edm.String|**Display Name**: Ship To Country/Region<br />**Description**: Type the country or region for the customer's shipping address.<br />|
|shipto_fax|Edm.String|**Display Name**: Ship to Fax<br />**Description**: Type the fax number for the customer's shipping address.<br />|
|shipto_freighttermscode|Edm.Int32|**Display Name**: Ship To Freight Terms<br />**Description**: Select the freight terms to make sure shipping orders are processed correctly.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|shipto_line1|Edm.String|**Display Name**: Ship To Street 1<br />**Description**: Type the first line of the customer's shipping address.<br />|
|shipto_line2|Edm.String|**Display Name**: Ship To Street 2<br />**Description**: Type the second line of the customer's shipping address.<br />|
|shipto_line3|Edm.String|**Display Name**: Ship To Street 3<br />**Description**: Type the third line of the shipping address.<br />|
|shipto_name|Edm.String|**Display Name**: Ship To Name<br />**Description**: Type a name for the customer's shipping address, such as "Headquarters" or "Field office",  to identify the address.<br />|
|shipto_postalcode|Edm.String|**Display Name**: Ship To ZIP/Postal Code<br />**Description**: Type the ZIP Code or postal code for the shipping address.<br />|
|shipto_stateorprovince|Edm.String|**Display Name**: Ship To State/Province<br />**Description**: Type the state or province for the shipping address.<br />|
|shipto_telephone|Edm.String|**Display Name**: Ship To Phone<br />**Description**: Type the phone number for the customer's shipping address.<br />|
|stageid|Edm.Guid|**Display Name**: Stage Id<br />**Description**: Contains the id of the stage where the entity is located.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the order is active, submitted, fulfilled, canceled, or invoiced. Only active orders can be edited.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Submitted</td></tr><tr><td>2</td><td>Canceled</td></tr><tr><td>3</td><td>Fulfilled</td></tr><tr><td>4</td><td>Invoiced</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the order's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>New</td></tr><tr><td>2</td><td>Pending</td></tr><tr><td>690970000</td><td>On hold</td></tr><tr><td>3</td><td>In Progress</td></tr><tr><td>4</td><td>No Money</td></tr><tr><td>100001</td><td>Complete</td></tr><tr><td>100002</td><td>Partial</td></tr><tr><td>100003</td><td>Invoiced</td></tr><tbody></table>|
|submitdate|Edm.DateTimeOffset|**Display Name**: Date Submitted<br />**Description**: Enter the date when the order was submitted to the fulfillment or shipping center.<br />|
|submitstatus|Edm.Int32|**Display Name**: Submitted Status<br />**Description**: Type the code for the submitted status in the fulfillment or shipping center system.<br />|
|submitstatusdescription|Edm.String|**Display Name**: Submitted Status Description<br />**Description**: Type additional details or notes about the order for the fulfillment or shipping center.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|totalamount|Edm.Decimal|**Display Name**: Total Amount<br />**Description**: Shows the total amount due, calculated as the sum of the products, discounts, freight, and taxes for the order.<br />|
|totalamount_base|Edm.Decimal|**Display Name**: Total Amount (Base)<br />**Description**: Value of the Total Amount in base currency.<br />Read-only<br />|
|totalamountlessfreight|Edm.Decimal|**Display Name**: Total Pre-Freight Amount<br />**Description**: Shows the total product amount for the order, minus any discounts. This value is added to freight and tax amounts in the calculation for the total amount due for the order.<br />|
|totalamountlessfreight_base|Edm.Decimal|**Display Name**: Total Pre-Freight Amount (Base)<br />**Description**: Value of the Total Pre-Freight Amount in base currency.<br />Read-only<br />|
|totaldiscountamount|Edm.Decimal|**Display Name**: Total Discount Amount<br />**Description**: Shows the total discount amount, based on the discount price and rate entered on the order.<br />|
|totaldiscountamount_base|Edm.Decimal|**Display Name**: Total Discount Amount (Base)<br />**Description**: Value of the Total Discount Amount in base currency.<br />Read-only<br />|
|totallineitemamount|Edm.Decimal|**Display Name**: Total Detail Amount<br />**Description**: Shows the sum of all existing and write-in products included on the order, based on the specified price list and quantities.<br />|
|totallineitemamount_base|Edm.Decimal|**Display Name**: Total Detail Amount (Base)<br />**Description**: Value of the Total Detail Amount in base currency.<br />Read-only<br />|
|totallineitemdiscountamount|Edm.Decimal|**Display Name**: Total Line Item Discount Amount<br />**Description**: Shows the total of the Manual Discount amounts specified on all products included in the order. This value is reflected in the Detail Amount field on the order and is added to any discount amount or rate specified on the order.<br />|
|totallineitemdiscountamount_base|Edm.Decimal|**Display Name**: Total Line Item Discount Amount (Base)<br />**Description**: Value of the Total Line Item Discount Amount in base currency.<br />Read-only<br />|
|totaltax|Edm.Decimal|**Display Name**: Total Tax<br />**Description**: Shows the Tax amounts specified on all products included in the order, included in the Total Amount due calculation for the order.<br />|
|totaltax_base|Edm.Decimal|**Display Name**: Total Tax (Base)<br />**Description**: Value of the Total Tax in base currency.<br />Read-only<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|
|willcall|Edm.Boolean|**Display Name**: Ship To<br />**Description**: Select whether the products included in the order should be shipped to the specified address or held until the customer calls with further pick-up or delivery instructions.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Will Call</td></tr><tr><td>0</td><td>Address</td></tr><tbody></table>|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_accountid_value||Shows the parent account related to the record. This information is used to link the sales order to the account selected in the Customer field for reporting and analytics.|
|_campaignid_value|campaignid<br />|Shows the campaign that the order was created from.|
|_contactid_value||Shows the parent contact related to the record. This information is used to link the contract to the contact selected in the Customer field for reporting and analytics.|
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_customerid_value|customerid_account<br />customerid_contact<br />|Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_msdyn_account_value|msdyn_account<br />|Customer Account associated with this Order|
|_msdyn_accountmanagerid_value|msdyn_AccountManagerId<br />|User responsible for managing the account referenced by this contract.|
|_msdyn_contractorganizationalunitid_value|msdyn_ContractOrganizationalUnitId<br />|Organizational unit responsible for this contract.|
|_opportunityid_value|opportunityid<br />|Choose the related opportunity so that the data for the order and opportunity are linked for reporting and analytics.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_pricelevelid_value|pricelevelid<br />|Choose the price list associated with this record to make sure the products associated with the campaign are offered at the correct prices.|
|_quoteid_value|quoteid<br />|Choose the related quote so that order data and quote data are linked for reporting and analytics.|
|_slaid_value|sla_salesorder_sla<br />|Choose the service level agreement (SLA) that you want to apply to the sales order record.|
|_slainvokedid_value|slainvokedid_salesorder_sla<br />|Last SLA that was applied to this sales order. This field is for internal use only.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|campaignid|[campaign EntityType](campaign.md)|campaign_orders|
|createdby|[systemuser EntityType](systemuser.md)|lk_salesorderbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_salesorder_createdonbehalfby|
|customerid_account|[account EntityType](account.md)|order_customer_accounts|
|customerid_contact|[contact EntityType](contact.md)|order_customer_contacts|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_salesorderbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_salesorder_modifiedonbehalfby|
|msdyn_account|[account EntityType](account.md)|msdyn_account_salesorder_Account|
|msdyn_AccountManagerId|[systemuser EntityType](systemuser.md)|msdyn_accountmanager_salesorder|
|msdyn_ContractOrganizationalUnitId|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_organizationalunit_salesorder|
|opportunityid|[opportunity EntityType](opportunity.md)|opportunity_sales_orders|
|ownerid|[principal EntityType](principal.md)|owner_salesorders|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_orders|
|owningteam|[team EntityType](team.md)|team_orders|
|owninguser|[systemuser EntityType](systemuser.md)|system_user_orders|
|pricelevelid|[pricelevel EntityType](pricelevel.md)|price_level_orders|
|quoteid|[quote EntityType](quote.md)|quote_orders|
|sla_salesorder_sla|[sla EntityType](sla.md)|manualsla_salesorder|
|slainvokedid_salesorder_sla|[sla EntityType](sla.md)|sla_salesorder|
|stageid_processstage|[processstage EntityType](processstage.md)|processstage_salesorders|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_salesorder|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|contactorders_association|[contact EntityType](contact.md)|contactorders_association|  
|msdyn_salesorder_msdyn_actual_SalesContract|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_SalesContract|  
|msdyn_salesorder_msdyn_contractlinescheduleofvalue_contract|[msdyn_contractlinescheduleofvalue EntityType](msdyn_contractlinescheduleofvalue.md)|msdyn_contract|  
|msdyn_salesorder_msdyn_fact_SalesContract|[msdyn_fact EntityType](msdyn_fact.md)|msdyn_SalesContract|  
|msdyn_salesorder_msdyn_invoicelinetransaction_SalesContract|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_SalesContract|  
|msdyn_salesorder_msdyn_journalline_SalesContract|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_SalesContract|  
|msdyn_salesorder_msdyn_orderinvoicingdate_Order|[msdyn_orderinvoicingdate EntityType](msdyn_orderinvoicingdate.md)|msdyn_Order|  
|msdyn_salesorder_msdyn_orderinvoicingsetup_Order|[msdyn_orderinvoicingsetup EntityType](msdyn_orderinvoicingsetup.md)|msdyn_Order|  
|msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order|[msdyn_orderinvoicingsetupdate EntityType](msdyn_orderinvoicingsetupdate.md)|msdyn_Order|  
|msdyn_salesorder_msdyn_orderlinetransaction_SalesContract|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_SalesContract|  
|msdyn_salesorder_msdyn_orderpricelist_Contract|[msdyn_orderpricelist EntityType](msdyn_orderpricelist.md)|msdyn_Contract|  
|msdyn_salesorder_msdyn_project_salesorderid|[msdyn_project EntityType](msdyn_project.md)|msdyn_salesorderid|  
|order_details|[salesorderdetail EntityType](salesorderdetail.md)|salesorderid|  
|order_invoices|[invoice EntityType](invoice.md)|salesorderid|  
|salesorder_activity_parties|[activityparty EntityType](activityparty.md)|partyid_salesorder|  
|SalesOrder_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_salesorder|  
|salesorder_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_salesorder_adx_alertsubscription|  
|salesorder_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_salesorder_adx_inviteredemption|  
|salesorder_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_salesorder_adx_portalcomment|  
|SalesOrder_Annotation|[annotation EntityType](annotation.md)|objectid_salesorder|  
|SalesOrder_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_salesorder_appointment|  
|SalesOrder_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_salesorder|  
|SalesOrder_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_salesorder|  
|salesorder_connections1|[connection EntityType](connection.md)|record1id_salesorder|  
|salesorder_connections2|[connection EntityType](connection.md)|record2id_salesorder|  
|SalesOrder_Emails|[email EntityType](email.md)|regardingobjectid_salesorder_email|  
|SalesOrder_Faxes|[fax EntityType](fax.md)|regardingobjectid_salesorder_fax|  
|SalesOrder_Letters|[letter EntityType](letter.md)|regardingobjectid_salesorder_letter|  
|salesorder_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_salesorder_msdyn_approval|  
|salesorder_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_salesorder_msdyn_bookingalert|  
|salesorder_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_salesorder_msdyn_surveyinvite|  
|salesorder_opportunitysalesprocess|[opportunitysalesprocess EntityType](opportunitysalesprocess.md)|salesorderid|  
|SalesOrder_OrderClose|[orderclose EntityType](orderclose.md)|salesorderid|  
|SalesOrder_Phonecalls|[phonecall EntityType](phonecall.md)|regardingobjectid_salesorder_phonecall|  
|SalesOrder_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_salesorder_recurringappointmentmaster|  
|SalesOrder_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_salesorder_serviceappointment|  
|SalesOrder_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_salesorder_socialactivity|  
|SalesOrder_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_salesorder_syncerror|  
|SalesOrder_Tasks|[task EntityType](task.md)|regardingobjectid_salesorder_task|  
|slakpiinstance_salesorder|[slakpiinstance EntityType](slakpiinstance.md)|regarding_salesorder|  

## Operations
The following operations can be used with the salesorder entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[CalculatePrice Action](../actions/calculateprice.md)|Not Bound|[!INCLUDE[../actions/descriptions/calculateprice.md](../actions/descriptions/calculateprice.md)]|  
|[CancelContract Action](../actions/cancelcontract.md)|Not Bound|[!INCLUDE[../actions/descriptions/cancelcontract.md](../actions/descriptions/cancelcontract.md)]|  
|[CancelSalesOrder Action](../actions/cancelsalesorder.md)|Not Bound|[!INCLUDE[../actions/descriptions/cancelsalesorder.md](../actions/descriptions/cancelsalesorder.md)]|  
|[ConvertSalesOrderToInvoice Action](../actions/convertsalesordertoinvoice.md)|Not Bound|[!INCLUDE[../actions/descriptions/convertsalesordertoinvoice.md](../actions/descriptions/convertsalesordertoinvoice.md)]|  
|[FulfillSalesOrder Action](../actions/fulfillsalesorder.md)|Not Bound|[!INCLUDE[../actions/descriptions/fulfillsalesorder.md](../actions/descriptions/fulfillsalesorder.md)]|  
|[GenerateSalesOrderFromOpportunity Action](../actions/generatesalesorderfromopportunity.md)|Not Bound|[!INCLUDE[../actions/descriptions/generatesalesorderfromopportunity.md](../actions/descriptions/generatesalesorderfromopportunity.md)]|  
|[GetQuantityDecimal Function](../functions/getquantitydecimal.md)|Entity|[!INCLUDE[../functions/descriptions/getquantitydecimal.md](../functions/descriptions/getquantitydecimal.md)]|  
|[GetSalesOrderProductsFromOpportunity Action](../actions/getsalesorderproductsfromopportunity.md)|Entity|[!INCLUDE[../actions/descriptions/getsalesorderproductsfromopportunity.md](../actions/descriptions/getsalesorderproductsfromopportunity.md)]|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[LockSalesOrderPricing Action](../actions/locksalesorderpricing.md)|Entity|[!INCLUDE[../actions/descriptions/locksalesorderpricing.md](../actions/descriptions/locksalesorderpricing.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[msdyn_CreateContractSpecificPriceList Action](../actions/msdyn_createcontractspecificpricelist.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_createcontractspecificpricelist.md](../actions/descriptions/msdyn_createcontractspecificpricelist.md)]|  
|[msdyn_createinvoicefrominvoiceschedule Action](../actions/msdyn_createinvoicefrominvoiceschedule.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_createinvoicefrominvoiceschedule.md](../actions/descriptions/msdyn_createinvoicefrominvoiceschedule.md)]|  
|[msdyn_GetProjectsForContract Action](../actions/msdyn_getprojectsforcontract.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_getprojectsforcontract.md](../actions/descriptions/msdyn_getprojectsforcontract.md)]|  
|[msdyn_NewInvoiceContract Action](../actions/msdyn_newinvoicecontract.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_newinvoicecontract.md](../actions/descriptions/msdyn_newinvoicecontract.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  
|[Rollup Function](../functions/rollup.md)|Not Bound|[!INCLUDE[../functions/descriptions/rollup.md](../functions/descriptions/rollup.md)]|  

## Solutions
The following solutions include the salesorder entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|  
|[Microsoft Dynamics CRM Marketing Sales Solution](../solutions/marketingsales.md)|[!INCLUDE[../solutions/descriptions/marketingsales.md](../solutions/descriptions/marketingsales.md)]|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|    

[!INCLUDE[./remarks/salesorder.md](./remarks/salesorder.md)]

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