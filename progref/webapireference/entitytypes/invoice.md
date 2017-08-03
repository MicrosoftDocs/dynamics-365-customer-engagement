---
title: "Microsoft Dynamics 365 Customer Engagement invoice EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 1ba309c7-11c5-4ee7-9d7c-8d1b90bd57bf
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API invoice entitytype."
---
# invoice EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/invoice.md](./descriptions/invoice.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]invoices </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Invoice</td></tr>
<tr><td><b>Primary Key:</b></td><td>invoiceid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|billto_city|Edm.String|**Display Name**: Bill To City<br />**Description**: Type the city for the customer's billing address.<br />|
|billto_composite|Edm.String|**Display Name**: Bill To Address<br />**Description**: Shows the complete Bill To address.<br />Read-only<br />|
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
|datedelivered|Edm.DateTimeOffset|**Display Name**: Date Delivered<br />**Description**: Enter the date when the products included in the invoice were delivered.<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the invoice, such as shipping details or product substitutions.<br />|
|discountamount|Edm.Decimal|**Display Name**: Invoice Discount Amount<br />**Description**: Type the discount amount for the invoice if the customer is eligible for special savings.<br />|
|discountamount_base|Edm.Decimal|**Display Name**: Invoice Discount Amount (Base)<br />**Description**: Value of the Invoice Discount Amount in base currency.<br />Read-only<br />|
|discountpercentage|Edm.Decimal|**Display Name**: Invoice Discount (%)<br />**Description**: Type the discount rate that should be applied to the Detail Amount field, for use in calculating the Pre-Freight Amount and Total Amount values for the invoice.<br />|
|duedate|Edm.Date|**Display Name**: Due Date<br />**Description**: Enter the date by which the invoice should be paid by the customer.<br />|
|emailaddress|Edm.String|**Display Name**: Email Address<br />**Description**: The primary email address for the entity.<br />|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: The default image for the entity.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|freightamount|Edm.Decimal|**Display Name**: Freight Amount<br />**Description**: Type the cost of freight or shipping for the products included in the invoice for use in calculating the total amount due.<br />|
|freightamount_base|Edm.Decimal|**Display Name**: Freight Amount (Base)<br />**Description**: Value of the Freight Amount in base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|invoiceid|Edm.Guid|**Display Name**: Invoice<br />**Description**: Unique identifier of the invoice.<br />|
|invoicenumber|Edm.String|**Display Name**: Invoice ID<br />**Description**: Shows the identifying number or code of the invoice.<br />|
|ispricelocked|Edm.Boolean|**Display Name**: Prices Locked<br />**Description**: Select whether prices specified on the invoice are locked from any further updates.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|lastbackofficesubmit|Edm.DateTimeOffset|**Display Name**: Last Submitted to Back Office<br />**Description**: Enter the date and time when the invoice was last submitted to an accounting or ERP system for processing.<br />|
|lastonholdtime|Edm.DateTimeOffset|**Display Name**: Last On Hold Time<br />**Description**: Contains the date time stamp of the last on hold time.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_amountdue|Edm.Decimal|**Display Name**: Amount Due<br />**Description**: Enter the amount due on this invoice.<br />|
|msdyn_amountdue_base|Edm.Decimal|**Display Name**: Amount Due (Base)<br />**Description**: Value of the Amount Due in base currency.<br />Read-only<br />|
|msdyn_hascorrections|Edm.Boolean|**Display Name**: Has Corrections<br />**Description**: Indicates if this invoice contains corrections to previous invoices.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_invoicedate|Edm.DateTimeOffset|**Display Name**: Invoice Date<br />**Description**: Document date of the Invoice for use in calculation of payment due date<br />|
|msdyn_ordertype|Edm.Int32|**Display Name**: Type<br />**Description**: Whether the invoice is for an Item- based Order or a Work-based Project Contract<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970002</td><td>Service-Maintenance Based</td></tr><tr><td>192350000</td><td>Item based</td></tr><tr><td>192350001</td><td>Work based</td></tr><tbody></table>|
|msdyn_projectinvoicestatus|Edm.Int32|**Display Name**: Project Invoice Status<br />**Description**: Project specific status<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Draft</td></tr><tr><td>192350001</td><td>In Review</td></tr><tr><td>192350002</td><td>Confirmed</td></tr><tr><td>192350003</td><td>Invoice Paid</td></tr><tbody></table>|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type a descriptive name for the invoice.<br />|
|onholdtime|Edm.Int32|**Display Name**: On Hold Time (Minutes)<br />**Description**: Shows the duration in minutes for which the invoice was on hold.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|paymenttermscode|Edm.Int32|**Display Name**: Payment Terms<br />**Description**: Select the payment terms to indicate when the customer needs to pay the total amount.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Net 30</td></tr><tr><td>2</td><td>2% 10, Net 30</td></tr><tr><td>3</td><td>Net 45</td></tr><tr><td>4</td><td>Net 60</td></tr><tbody></table>|
|pricingerrorcode|Edm.Int32|**Display Name**: Pricing Error <br />**Description**: Type of pricing error for the invoice.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>None</td></tr><tr><td>1</td><td>Detail Error</td></tr><tr><td>2</td><td>Missing Price Level</td></tr><tr><td>3</td><td>Inactive Price Level</td></tr><tr><td>4</td><td>Missing Quantity</td></tr><tr><td>5</td><td>Missing Unit Price</td></tr><tr><td>6</td><td>Missing Product</td></tr><tr><td>7</td><td>Invalid Product</td></tr><tr><td>8</td><td>Missing Pricing Code</td></tr><tr><td>9</td><td>Invalid Pricing Code</td></tr><tr><td>10</td><td>Missing UOM</td></tr><tr><td>11</td><td>Product Not In Price Level</td></tr><tr><td>12</td><td>Missing Price Level Amount</td></tr><tr><td>13</td><td>Missing Price Level Percentage</td></tr><tr><td>14</td><td>Missing Price</td></tr><tr><td>15</td><td>Missing Current Cost</td></tr><tr><td>16</td><td>Missing Standard Cost</td></tr><tr><td>17</td><td>Invalid Price Level Amount</td></tr><tr><td>18</td><td>Invalid Price Level Percentage</td></tr><tr><td>19</td><td>Invalid Price</td></tr><tr><td>20</td><td>Invalid Current Cost</td></tr><tr><td>21</td><td>Invalid Standard Cost</td></tr><tr><td>22</td><td>Invalid Rounding Policy</td></tr><tr><td>23</td><td>Invalid Rounding Option</td></tr><tr><td>24</td><td>Invalid Rounding Amount</td></tr><tr><td>25</td><td>Price Calculation Error</td></tr><tr><td>26</td><td>Invalid Discount Type</td></tr><tr><td>27</td><td>Discount Type Invalid State</td></tr><tr><td>28</td><td>Invalid Discount</td></tr><tr><td>29</td><td>Invalid Quantity</td></tr><tr><td>30</td><td>Invalid Pricing Precision</td></tr><tr><td>31</td><td>Missing Product Default UOM</td></tr><tr><td>32</td><td>Missing Product UOM Schedule </td></tr><tr><td>33</td><td>Inactive Discount Type</td></tr><tr><td>34</td><td>Invalid Price Level Currency</td></tr><tr><td>35</td><td>Price Attribute Out Of Range</td></tr><tr><td>36</td><td>Base Currency Attribute Overflow</td></tr><tr><td>37</td><td>Base Currency Attribute Underflow</td></tr><tbody></table>|
|prioritycode|Edm.Int32|**Display Name**: Priority<br />**Description**: Select the priority so that preferred customers or critical issues are handled quickly.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|shippingmethodcode|Edm.Int32|**Display Name**: Shipping Method<br />**Description**: Select a shipping method for deliveries sent to this address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Airborne</td></tr><tr><td>2</td><td>DHL</td></tr><tr><td>3</td><td>FedEx</td></tr><tr><td>4</td><td>UPS</td></tr><tr><td>5</td><td>Postal Mail</td></tr><tr><td>6</td><td>Full Load</td></tr><tr><td>7</td><td>Will Call</td></tr><tbody></table>|
|shipto_city|Edm.String|**Display Name**: Ship To City<br />**Description**: Type the city for the customer's shipping address.<br />|
|shipto_composite|Edm.String|**Display Name**: Ship To Address<br />**Description**: Shows the complete Ship To address.<br />Read-only<br />|
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
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the invoice is active, paid, or canceled. Paid and canceled invoices are read-only and can't be edited unless they are reactivated.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Closed (deprecated)</td></tr><tr><td>2</td><td>Paid</td></tr><tr><td>3</td><td>Canceled</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the invoice's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>New</td></tr><tr><td>2</td><td>Partially Shipped</td></tr><tr><td>4</td><td>Billed</td></tr><tr><td>5</td><td>Booked (applies to services)</td></tr><tr><td>6</td><td>Installed (applies to services)</td></tr><tr><td>3</td><td>Canceled (deprecated)</td></tr><tr><td>7</td><td>Paid in Full (deprecated)</td></tr><tr><td>100001</td><td>Complete</td></tr><tr><td>100002</td><td>Partial</td></tr><tr><td>100003</td><td>Canceled</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|totalamount|Edm.Decimal|**Display Name**: Total Amount<br />**Description**: Shows the total amount due, calculated as the sum of the products, discount, freight, and taxes for the invoice.<br />|
|totalamount_base|Edm.Decimal|**Display Name**: Total Amount (Base)<br />**Description**: Value of the Total Amount in base currency.<br />Read-only<br />|
|totalamountlessfreight|Edm.Decimal|**Display Name**: Total Pre-Freight Amount<br />**Description**: Shows the total product amount due, minus any discounts. This value is added to freight and tax amounts in the calculation for the total amount due for the invoice.<br />|
|totalamountlessfreight_base|Edm.Decimal|**Display Name**: Total Pre-Freight Amount (Base)<br />**Description**: Value of the Total Pre-Freight Amount in base currency.<br />Read-only<br />|
|totaldiscountamount|Edm.Decimal|**Display Name**: Total Discount Amount<br />**Description**: Shows the total discount amount, based on the discount price and rate entered on the invoice.<br />|
|totaldiscountamount_base|Edm.Decimal|**Display Name**: Total Discount Amount (Base)<br />**Description**: Value of the Total Discount Amount in base currency.<br />Read-only<br />|
|totallineitemamount|Edm.Decimal|**Display Name**: Total Detail Amount<br />**Description**: Shows the sum of all existing and write-in products included on the invoice, based on the specified price list and quantities.<br />|
|totallineitemamount_base|Edm.Decimal|**Display Name**: Total Detail Amount (Base)<br />**Description**: Value of the Total Detail Amount in base currency.<br />Read-only<br />|
|totallineitemdiscountamount|Edm.Decimal|**Display Name**: Total Line Item Discount Amount<br />**Description**: Shows the Manual Discount amounts specified on all products included in the invoice. This value is reflected in the Detail Amount field on the invoice and is added to any discount amount or rate specified on the invoice.<br />|
|totallineitemdiscountamount_base|Edm.Decimal|**Display Name**: Total Line Item Discount Amount (Base)<br />**Description**: Value of the Total Line Item Discount Amount in base currency.<br />Read-only<br />|
|totaltax|Edm.Decimal|**Display Name**: Total Tax<br />**Description**: Shows the total of the Tax amounts specified on all products included in the invoice, included in the Total Amount due calculation for the invoice.<br />|
|totaltax_base|Edm.Decimal|**Display Name**: Total Tax (Base)<br />**Description**: Value of the Total Tax in base currency.<br />Read-only<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|
|willcall|Edm.Boolean|**Display Name**: Ship To<br />**Description**: Select whether the products included in the invoice should be shipped to the specified address or held until the customer calls with further pick up or delivery instructions.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Will Call</td></tr><tr><td>0</td><td>Address</td></tr><tbody></table>|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_accountid_value||Unique identifier of the account with which the invoice is associated.|
|_contactid_value||Unique identifier of the contact associated with the invoice.|
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_customerid_value|customerid_account<br />customerid_contact<br />|Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_opportunityid_value|opportunityid<br />|Choose the opportunity that the invoice is related to for reporting and analytics.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_pricelevelid_value|pricelevelid<br />|Choose the price list associated with this record to make sure the products associated with the campaign are offered at the correct prices.|
|_salesorderid_value|salesorderid<br />|Choose the order related to the invoice to make sure the order is fulfilled and invoiced correctly.|
|_slaid_value|sla_invoice_sla<br />|Choose the service level agreement (SLA) that you want to apply to the invoice record.|
|_slainvokedid_value|slainvokedid_invoice_sla<br />|Last SLA that was applied to this invoice. This field is for internal use only.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_invoicebase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_invoice_createdonbehalfby|
|customerid_account|[account EntityType](account.md)|invoice_customer_accounts|
|customerid_contact|[contact EntityType](contact.md)|invoice_customer_contacts|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_invoicebase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_invoice_modifiedonbehalfby|
|opportunityid|[opportunity EntityType](opportunity.md)|opportunity_invoices|
|ownerid|[principal EntityType](principal.md)|owner_invoices|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_invoices|
|owningteam|[team EntityType](team.md)|team_invoices|
|owninguser|[systemuser EntityType](systemuser.md)|system_user_invoices|
|pricelevelid|[pricelevel EntityType](pricelevel.md)|price_level_invoices|
|salesorderid|[salesorder EntityType](salesorder.md)|order_invoices|
|sla_invoice_sla|[sla EntityType](sla.md)|manualsla_invoice|
|slainvokedid_invoice_sla|[sla EntityType](sla.md)|sla_invoice|
|stageid_processstage|[processstage EntityType](processstage.md)|processstage_invoices|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_invoice|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|contactinvoices_association|[contact EntityType](contact.md)|contactinvoices_association|  
|invoice_activity_parties|[activityparty EntityType](activityparty.md)|partyid_invoice|  
|Invoice_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_invoice|  
|invoice_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_invoice_adx_alertsubscription|  
|invoice_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_invoice_adx_inviteredemption|  
|invoice_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_invoice_adx_portalcomment|  
|Invoice_Annotation|[annotation EntityType](annotation.md)|objectid_invoice|  
|Invoice_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_invoice_appointment|  
|Invoice_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_invoice|  
|Invoice_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_invoice|  
|invoice_connections1|[connection EntityType](connection.md)|record1id_invoice|  
|invoice_connections2|[connection EntityType](connection.md)|record2id_invoice|  
|invoice_details|[invoicedetail EntityType](invoicedetail.md)|invoiceid|  
|Invoice_Emails|[email EntityType](email.md)|regardingobjectid_invoice_email|  
|Invoice_Faxes|[fax EntityType](fax.md)|regardingobjectid_invoice_fax|  
|Invoice_Letters|[letter EntityType](letter.md)|regardingobjectid_invoice_letter|  
|invoice_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_invoice_msdyn_approval|  
|invoice_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_invoice_msdyn_bookingalert|  
|invoice_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_invoice_msdyn_surveyinvite|  
|Invoice_Phonecalls|[phonecall EntityType](phonecall.md)|regardingobjectid_invoice_phonecall|  
|Invoice_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_invoice_recurringappointmentmaster|  
|Invoice_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_invoice_serviceappointment|  
|Invoice_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_invoice_socialactivity|  
|Invoice_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_invoice_syncerror|  
|Invoice_Tasks|[task EntityType](task.md)|regardingobjectid_invoice_task|  
|msdyn_invoice_msdyn_actual_Invoice|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_Invoice|  
|msdyn_invoice_msdyn_agreementinvoicedate_Invoice|[msdyn_agreementinvoicedate EntityType](msdyn_agreementinvoicedate.md)|msdyn_Invoice|  
|msdyn_invoice_msdyn_contractlineinvoiceschedule_Invoice|[msdyn_contractlineinvoiceschedule EntityType](msdyn_contractlineinvoiceschedule.md)|msdyn_Invoice|  
|msdyn_invoice_msdyn_invoicelinetransaction_Invoice|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_Invoice|  
|msdyn_invoice_msdyn_orderinvoicingdate_Invoice|[msdyn_orderinvoicingdate EntityType](msdyn_orderinvoicingdate.md)|msdyn_Invoice|  
|msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice|[msdyn_orderinvoicingsetupdate EntityType](msdyn_orderinvoicingsetupdate.md)|msdyn_Invoice|  
|msdyn_invoice_msdyn_paymentdetail_Invoice|[msdyn_paymentdetail EntityType](msdyn_paymentdetail.md)|msdyn_invoice|  
|slakpiinstance_invoice|[slakpiinstance EntityType](slakpiinstance.md)|regarding_invoice|  

## Operations
The following operations can be used with the invoice entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[CalculatePrice Action](../actions/calculateprice.md)|Not Bound|[!INCLUDE[../actions/descriptions/calculateprice.md](../actions/descriptions/calculateprice.md)]|  
|[GenerateInvoiceFromOpportunity Action](../actions/generateinvoicefromopportunity.md)|Not Bound|[!INCLUDE[../actions/descriptions/generateinvoicefromopportunity.md](../actions/descriptions/generateinvoicefromopportunity.md)]|  
|[GetInvoiceProductsFromOpportunity Action](../actions/getinvoiceproductsfromopportunity.md)|Entity|[!INCLUDE[../actions/descriptions/getinvoiceproductsfromopportunity.md](../actions/descriptions/getinvoiceproductsfromopportunity.md)]|  
|[GetQuantityDecimal Function](../functions/getquantitydecimal.md)|Entity|[!INCLUDE[../functions/descriptions/getquantitydecimal.md](../functions/descriptions/getquantitydecimal.md)]|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[LockInvoicePricing Action](../actions/lockinvoicepricing.md)|Entity|[!INCLUDE[../actions/descriptions/lockinvoicepricing.md](../actions/descriptions/lockinvoicepricing.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[msdyn_AddInvoiceLineDetails Action](../actions/msdyn_addinvoicelinedetails.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_addinvoicelinedetails.md](../actions/descriptions/msdyn_addinvoicelinedetails.md)]|  
|[msdyn_CorrectInvoice Action](../actions/msdyn_correctinvoice.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_correctinvoice.md](../actions/descriptions/msdyn_correctinvoice.md)]|  
|[msdyn_InvoicePaid Action](../actions/msdyn_invoicepaid.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_invoicepaid.md](../actions/descriptions/msdyn_invoicepaid.md)]|  
|[msdyn_InvoiceRecalculate Action](../actions/msdyn_invoicerecalculate.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_invoicerecalculate.md](../actions/descriptions/msdyn_invoicerecalculate.md)]|  
|[msdyn_PostInvoice Action](../actions/msdyn_postinvoice.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_postinvoice.md](../actions/descriptions/msdyn_postinvoice.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  
|[Rollup Function](../functions/rollup.md)|Not Bound|[!INCLUDE[../functions/descriptions/rollup.md](../functions/descriptions/rollup.md)]|  

## Solutions
The following solutions include the invoice entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|    

[!INCLUDE[./remarks/invoice.md](./remarks/invoice.md)]

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