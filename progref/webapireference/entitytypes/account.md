---
title: "Microsoft Dynamics 365 Customer Engagement account EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b587728b-db31-4d53-be70-98a1ed5fe7e9
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API account entitytype."
---
# account EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/account.md](./descriptions/account.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]accounts </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Account</td></tr>
<tr><td><b>Primary Key:</b></td><td>accountid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The account entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|accountcategorycode|Edm.Int32|**Display Name**: Category<br />**Description**: Select a category to indicate whether the customer account is standard or preferred.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Preferred Customer</td></tr><tr><td>2</td><td>Standard</td></tr><tbody></table>|
|accountclassificationcode|Edm.Int32|**Display Name**: Classification<br />**Description**: Select a classification code to indicate the potential value of the customer account based on the projected return on investment, cooperation level, sales cycle length or other criteria.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|accountid|Edm.Guid|**Display Name**: Account<br />**Description**: Unique identifier of the account.<br />|
|accountnumber|Edm.String|**Display Name**: Account Number<br />**Description**: Type an ID number or code for the account to quickly search and identify the account in system views.<br />|
|accountratingcode|Edm.Int32|**Display Name**: Account Rating<br />**Description**: Select a rating to indicate the value of the customer account.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address1_addressid|Edm.Guid|**Display Name**: Address 1: ID<br />**Description**: Unique identifier for address 1.<br />|
|address1_addresstypecode|Edm.Int32|**Display Name**: Address 1: Address Type<br />**Description**: Select the primary address type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Bill To</td></tr><tr><td>2</td><td>Ship To</td></tr><tr><td>3</td><td>Primary</td></tr><tr><td>4</td><td>Other</td></tr><tbody></table>|
|address1_city|Edm.String|**Display Name**: Address 1: City<br />**Description**: Type the city for the primary address.<br />|
|address1_composite|Edm.String|**Display Name**: Address 1<br />**Description**: Shows the complete primary address.<br />Read-only<br />|
|address1_country|Edm.String|**Display Name**: Address 1: Country/Region<br />**Description**: Type the country or region for the primary address.<br />|
|address1_county|Edm.String|**Display Name**: Address 1: County<br />**Description**: Type the county for the primary address.<br />|
|address1_fax|Edm.String|**Display Name**: Address 1: Fax<br />**Description**: Type the fax number associated with the primary address.<br />|
|address1_freighttermscode|Edm.Int32|**Display Name**: Address 1: Freight Terms<br />**Description**: Select the freight terms for the primary address to make sure shipping orders are processed correctly.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>FOB</td></tr><tr><td>2</td><td>No Charge</td></tr><tbody></table>|
|address1_latitude|Edm.Double|**Display Name**: Address 1: Latitude<br />**Description**: Type the latitude value for the primary address for use in mapping and other applications.<br />|
|address1_line1|Edm.String|**Display Name**: Address 1: Street 1<br />**Description**: Type the first line of the primary address.<br />|
|address1_line2|Edm.String|**Display Name**: Address 1: Street 2<br />**Description**: Type the second line of the primary address.<br />|
|address1_line3|Edm.String|**Display Name**: Address 1: Street 3<br />**Description**: Type the third line of the primary address.<br />|
|address1_longitude|Edm.Double|**Display Name**: Address 1: Longitude<br />**Description**: Type the longitude value for the primary address for use in mapping and other applications.<br />|
|address1_name|Edm.String|**Display Name**: Address 1: Name<br />**Description**: Type a descriptive name for the primary address, such as Corporate Headquarters.<br />|
|address1_postalcode|Edm.String|**Display Name**: Address 1: ZIP/Postal Code<br />**Description**: Type the ZIP Code or postal code for the primary address.<br />|
|address1_postofficebox|Edm.String|**Display Name**: Address 1: Post Office Box<br />**Description**: Type the post office box number of the primary address.<br />|
|address1_primarycontactname|Edm.String|**Display Name**: Address 1: Primary Contact Name<br />**Description**: Type the name of the main contact at the account's primary address.<br />|
|address1_shippingmethodcode|Edm.Int32|**Display Name**: Address 1: Shipping Method<br />**Description**: Select a shipping method for deliveries sent to this address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Airborne</td></tr><tr><td>2</td><td>DHL</td></tr><tr><td>3</td><td>FedEx</td></tr><tr><td>4</td><td>UPS</td></tr><tr><td>5</td><td>Postal Mail</td></tr><tr><td>6</td><td>Full Load</td></tr><tr><td>7</td><td>Will Call</td></tr><tbody></table>|
|address1_stateorprovince|Edm.String|**Display Name**: Address 1: State/Province<br />**Description**: Type the state or province of the primary address.<br />|
|address1_telephone1|Edm.String|**Display Name**: Address Phone<br />**Description**: Type the main phone number associated with the primary address.<br />|
|address1_telephone2|Edm.String|**Display Name**: Address 1: Telephone 2<br />**Description**: Type a second phone number associated with the primary address.<br />|
|address1_telephone3|Edm.String|**Display Name**: Address 1: Telephone 3<br />**Description**: Type a third phone number associated with the primary address.<br />|
|address1_upszone|Edm.String|**Display Name**: Address 1: UPS Zone<br />**Description**: Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.<br />|
|address1_utcoffset|Edm.Int32|**Display Name**: Address 1: UTC Offset<br />**Description**: Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.<br />|
|address2_addressid|Edm.Guid|**Display Name**: Address 2: ID<br />**Description**: Unique identifier for address 2.<br />|
|address2_addresstypecode|Edm.Int32|**Display Name**: Address 2: Address Type<br />**Description**: Select the secondary address type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address2_city|Edm.String|**Display Name**: Address 2: City<br />**Description**: Type the city for the secondary address.<br />|
|address2_composite|Edm.String|**Display Name**: Address 2<br />**Description**: Shows the complete secondary address.<br />Read-only<br />|
|address2_country|Edm.String|**Display Name**: Address 2: Country/Region<br />**Description**: Type the country or region for the secondary address.<br />|
|address2_county|Edm.String|**Display Name**: Address 2: County<br />**Description**: Type the county for the secondary address.<br />|
|address2_fax|Edm.String|**Display Name**: Address 2: Fax<br />**Description**: Type the fax number associated with the secondary address.<br />|
|address2_freighttermscode|Edm.Int32|**Display Name**: Address 2: Freight Terms<br />**Description**: Select the freight terms for the secondary address to make sure shipping orders are processed correctly.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address2_latitude|Edm.Double|**Display Name**: Address 2: Latitude<br />**Description**: Type the latitude value for the secondary address for use in mapping and other applications.<br />|
|address2_line1|Edm.String|**Display Name**: Address 2: Street 1<br />**Description**: Type the first line of the secondary address.<br />|
|address2_line2|Edm.String|**Display Name**: Address 2: Street 2<br />**Description**: Type the second line of the secondary address.<br />|
|address2_line3|Edm.String|**Display Name**: Address 2: Street 3<br />**Description**: Type the third line of the secondary address.<br />|
|address2_longitude|Edm.Double|**Display Name**: Address 2: Longitude<br />**Description**: Type the longitude value for the secondary address for use in mapping and other applications.<br />|
|address2_name|Edm.String|**Display Name**: Address 2: Name<br />**Description**: Type a descriptive name for the secondary address, such as Corporate Headquarters.<br />|
|address2_postalcode|Edm.String|**Display Name**: Address 2: ZIP/Postal Code<br />**Description**: Type the ZIP Code or postal code for the secondary address.<br />|
|address2_postofficebox|Edm.String|**Display Name**: Address 2: Post Office Box<br />**Description**: Type the post office box number of the secondary address.<br />|
|address2_primarycontactname|Edm.String|**Display Name**: Address 2: Primary Contact Name<br />**Description**: Type the name of the main contact at the account's secondary address.<br />|
|address2_shippingmethodcode|Edm.Int32|**Display Name**: Address 2: Shipping Method<br />**Description**: Select a shipping method for deliveries sent to this address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address2_stateorprovince|Edm.String|**Display Name**: Address 2: State/Province<br />**Description**: Type the state or province of the secondary address.<br />|
|address2_telephone1|Edm.String|**Display Name**: Address 2: Telephone 1<br />**Description**: Type the main phone number associated with the secondary address.<br />|
|address2_telephone2|Edm.String|**Display Name**: Address 2: Telephone 2<br />**Description**: Type a second phone number associated with the secondary address.<br />|
|address2_telephone3|Edm.String|**Display Name**: Address 2: Telephone 3<br />**Description**: Type a third phone number associated with the secondary address.<br />|
|address2_upszone|Edm.String|**Display Name**: Address 2: UPS Zone<br />**Description**: Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.<br />|
|address2_utcoffset|Edm.Int32|**Display Name**: Address 2: UTC Offset<br />**Description**: Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.<br />|
|adx_createdbyipaddress|Edm.String|**Display Name**: Created By (IP Address)<br />|
|adx_createdbyusername|Edm.String|**Display Name**: Created By (User Name)<br />|
|adx_modifiedbyipaddress|Edm.String|**Display Name**: Modified By (IP Address)<br />|
|adx_modifiedbyusername|Edm.String|**Display Name**: Modified By (User Name)<br />|
|aging30|Edm.Decimal|**Display Name**: Aging 30<br />**Description**: For system use only.<br />Read-only<br />|
|aging30_base|Edm.Decimal|**Display Name**: Aging 30 (Base)<br />**Description**: The base currency equivalent of the aging 30 field.<br />Read-only<br />|
|aging60|Edm.Decimal|**Display Name**: Aging 60<br />**Description**: For system use only.<br />Read-only<br />|
|aging60_base|Edm.Decimal|**Display Name**: Aging 60 (Base)<br />**Description**: The base currency equivalent of the aging 60 field.<br />Read-only<br />|
|aging90|Edm.Decimal|**Display Name**: Aging 90<br />**Description**: For system use only.<br />Read-only<br />|
|aging90_base|Edm.Decimal|**Display Name**: Aging 90 (Base)<br />**Description**: The base currency equivalent of the aging 90 field.<br />Read-only<br />|
|businesstypecode|Edm.Int32|**Display Name**: Business Type<br />**Description**: Select the legal designation or other business type of the account for contracts or reporting purposes.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|creditlimit|Edm.Decimal|**Display Name**: Credit Limit<br />**Description**: Type the credit limit of the account. This is a useful reference when you address invoice and accounting issues with the customer.<br />|
|creditlimit_base|Edm.Decimal|**Display Name**: Credit Limit (Base)<br />**Description**: Shows the credit limit converted to the system's default base currency for reporting purposes.<br />Read-only<br />|
|creditonhold|Edm.Boolean|**Display Name**: Credit Hold<br />**Description**: Select whether the credit for the account is on hold. This is a useful reference while addressing the invoice and accounting issues with the customer.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|customersizecode|Edm.Int32|**Display Name**: Customer Size<br />**Description**: Select the size category or range of the account for segmentation and reporting purposes.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|customertypecode|Edm.Int32|**Display Name**: Relationship Type<br />**Description**: Select the category that best describes the relationship between the account and your organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Competitor</td></tr><tr><td>2</td><td>Consultant</td></tr><tr><td>3</td><td>Customer</td></tr><tr><td>4</td><td>Investor</td></tr><tr><td>5</td><td>Partner</td></tr><tr><td>6</td><td>Influencer</td></tr><tr><td>7</td><td>Press</td></tr><tr><td>8</td><td>Prospect</td></tr><tr><td>9</td><td>Reseller</td></tr><tr><td>10</td><td>Supplier</td></tr><tr><td>11</td><td>Vendor</td></tr><tr><td>12</td><td>Other</td></tr><tbody></table>|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the account, such as an excerpt from the company's website.<br />|
|donotbulkemail|Edm.Boolean|**Display Name**: Do not allow Bulk Emails<br />**Description**: Select whether the account allows bulk email sent through campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but is excluded from email.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|donotbulkpostalmail|Edm.Boolean|**Display Name**: Do not allow Bulk Mails<br />**Description**: Select whether the account allows bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but will be excluded from the postal mail.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|donotemail|Edm.Boolean|**Display Name**: Do not allow Emails<br />**Description**: Select whether the account allows direct email sent from Microsoft Dynamics 365.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|donotfax|Edm.Boolean|**Display Name**: Do not allow Faxes<br />**Description**: Select whether the account allows faxes. If Do Not Allow is selected, the account will be excluded from fax activities distributed in marketing campaigns.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|donotphone|Edm.Boolean|**Display Name**: Do not allow Phone Calls<br />**Description**: Select whether the account allows phone calls. If Do Not Allow is selected, the account will be excluded from phone call activities distributed in marketing campaigns.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|donotpostalmail|Edm.Boolean|**Display Name**: Do not allow Mails<br />**Description**: Select whether the account allows direct mail. If Do Not Allow is selected, the account will be excluded from letter activities distributed in marketing campaigns.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|donotsendmm|Edm.Boolean|**Display Name**: Send Marketing Materials<br />**Description**: Select whether the account accepts marketing materials, such as brochures or catalogs.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Send</td></tr><tr><td>0</td><td>Send</td></tr><tbody></table>|
|emailaddress1|Edm.String|**Display Name**: Email<br />**Description**: Type the primary email address for the account.<br />|
|emailaddress2|Edm.String|**Display Name**: Email Address 2<br />**Description**: Type the secondary email address for the account.<br />|
|emailaddress3|Edm.String|**Display Name**: Email Address 3<br />**Description**: Type an alternate email address for the account.<br />|
|entityimage|Edm.Binary|**Display Name**: Default Image<br />**Description**: Shows the default image for the record.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|**Display Name**: Entity Image Id<br />**Description**: For internal use only.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|fax|Edm.String|**Display Name**: Fax<br />**Description**: Type the fax number for the account.<br />|
|followemail|Edm.Boolean|**Display Name**: Follow Email Activity<br />**Description**: Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the account.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Allow</td></tr><tr><td>0</td><td>Do Not Allow</td></tr><tbody></table>|
|ftpsiteurl|Edm.String|**Display Name**: FTP Site<br />**Description**: Type the URL for the account's FTP site to enable users to access data and share documents.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|industrycode|Edm.Int32|**Display Name**: Industry<br />**Description**: Select the account's primary industry for use in marketing segmentation and demographic analysis.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Accounting</td></tr><tr><td>2</td><td>Agriculture and Non-petrol Natural Resource Extraction</td></tr><tr><td>3</td><td>Broadcasting Printing and Publishing</td></tr><tr><td>4</td><td>Brokers</td></tr><tr><td>5</td><td>Building Supply Retail</td></tr><tr><td>6</td><td>Business Services</td></tr><tr><td>7</td><td>Consulting</td></tr><tr><td>8</td><td>Consumer Services</td></tr><tr><td>9</td><td>Design, Direction and Creative Management</td></tr><tr><td>10</td><td>Distributors, Dispatchers and Processors</td></tr><tr><td>11</td><td>Doctor's Offices and Clinics</td></tr><tr><td>12</td><td>Durable Manufacturing</td></tr><tr><td>13</td><td>Eating and Drinking Places</td></tr><tr><td>14</td><td>Entertainment Retail</td></tr><tr><td>15</td><td>Equipment Rental and Leasing</td></tr><tr><td>16</td><td>Financial</td></tr><tr><td>17</td><td>Food and Tobacco Processing</td></tr><tr><td>18</td><td>Inbound Capital Intensive Processing</td></tr><tr><td>19</td><td>Inbound Repair and Services</td></tr><tr><td>20</td><td>Insurance</td></tr><tr><td>21</td><td>Legal Services</td></tr><tr><td>22</td><td>Non-Durable Merchandise Retail</td></tr><tr><td>23</td><td>Outbound Consumer Service</td></tr><tr><td>24</td><td>Petrochemical Extraction and Distribution</td></tr><tr><td>25</td><td>Service Retail</td></tr><tr><td>26</td><td>SIG Affiliations</td></tr><tr><td>27</td><td>Social Services</td></tr><tr><td>28</td><td>Special Outbound Trade Contractors</td></tr><tr><td>29</td><td>Specialty Realty</td></tr><tr><td>30</td><td>Transportation</td></tr><tr><td>31</td><td>Utility Creation and Distribution</td></tr><tr><td>32</td><td>Vehicle Retail</td></tr><tr><td>33</td><td>Wholesale</td></tr><tbody></table>|
|lastonholdtime|Edm.DateTimeOffset|**Display Name**: Last On Hold Time<br />**Description**: Contains the date and time stamp of the last on hold time.<br />|
|lastusedincampaign|Edm.DateTimeOffset|**Display Name**: Last Date Included in Campaign<br />**Description**: Shows the date when the account was last included in a marketing campaign or quick campaign.<br />|
|marketcap|Edm.Decimal|**Display Name**: Market Capitalization<br />**Description**: Type the market capitalization of the account to identify the company's equity, used as an indicator in financial performance analysis.<br />|
|marketcap_base|Edm.Decimal|**Display Name**: Market Capitalization (Base)<br />**Description**: Shows the market capitalization converted to the system's default base currency.<br />Read-only<br />|
|marketingonly|Edm.Boolean|**Display Name**: Marketing Only<br />**Description**: Whether is only for marketing<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|merged|Edm.Boolean|**Display Name**: Merged<br />**Description**: Shows whether the account has been merged with another account.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_externalaccountid|Edm.String|**Display Name**: External ID<br />**Description**: External Account ID from other systems.<br />|
|msdyn_taxexempt|Edm.Boolean|**Display Name**: Tax Exempt<br />**Description**: Select whether the account is tax exempt.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_taxexemptnumber|Edm.String|**Display Name**: Tax Exempt Number<br />**Description**: Shows the government tax exempt number.<br />|
|msdyn_travelcharge|Edm.Decimal|**Display Name**: Travel Charge<br />**Description**: Enter the travel charge to include on work orders. This value will be multiplied by the travel charge type.<br />|
|msdyn_travelcharge_base|Edm.Decimal|**Display Name**: Travel Charge (Base)<br />**Description**: Value of the Travel Charge in base currency.<br />Read-only<br />|
|msdyn_travelchargetype|Edm.Int32|**Display Name**: Travel Charge Type<br />**Description**: Specify how travel is charged for this account.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Hourly</td></tr><tr><td>690970001</td><td>Mileage</td></tr><tr><td>690970002</td><td>Fixed</td></tr><tr><td>690970003</td><td>None</td></tr><tbody></table>|
|msdyn_workorderinstructions|Edm.String|**Display Name**: Work Order Instructions<br />**Description**: Shows the default instructions to show on new work orders.<br />|
|msevtmgt_hotelgroup|Edm.Int32|**Display Name**: Hotel Group<br />**Description**: Whether this account belongs to hotel group or not<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>No</td></tr><tr><td>100000002</td><td>Yes</td></tr><tbody></table>|
|msevtmgt_rentalcarprovider|Edm.Int32|**Display Name**: Rental Car Provider<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>No</td></tr><tr><td>100000002</td><td>Yes</td></tr><tbody></table>|
|name|Edm.String|**Display Name**: Account Name<br />**Description**: Type the company or business name.<br />|
|numberofemployees|Edm.Int32|**Display Name**: Number of Employees<br />**Description**: Type the number of employees that work at the account for use in marketing segmentation and demographic analysis.<br />|
|onholdtime|Edm.Int32|**Display Name**: On Hold Time (Minutes)<br />**Description**: Shows how long, in minutes, that the record was on hold.<br />Read-only<br />|
|opendeals|Edm.Int32|**Display Name**: Open Deals<br />**Description**: Number of open opportunities against an account and its child accounts.<br />Computed<br />Read-only<br />|
|opendeals_date|Edm.DateTimeOffset|**Display Name**: Open Deals (Last Updated On)<br />**Description**: Last Updated time of rollup field Open Deals.<br />Read-only<br />|
|opendeals_state|Edm.Int32|**Display Name**: Open Deals (State)<br />**Description**: State of rollup field Open Deals.<br />Read-only<br />|
|openrevenue|Edm.Decimal|**Display Name**: Open Revenue<br />**Description**: Sum of open revenue against an account and its child accounts.<br />Computed<br />Read-only<br />|
|openrevenue_base|Edm.Decimal|**Display Name**: Open Revenue (Base)<br />**Description**: Value of the Open Revenue in base currency.<br />Computed<br />Read-only<br />|
|openrevenue_date|Edm.DateTimeOffset|**Display Name**: Open Revenue (Last Updated On)<br />**Description**: Last Updated time of rollup field Open Revenue.<br />Read-only<br />|
|openrevenue_state|Edm.Int32|**Display Name**: Open Revenue (State)<br />**Description**: State of rollup field Open Revenue.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|ownershipcode|Edm.Int32|**Display Name**: Ownership<br />**Description**: Select the account's ownership structure, such as public or private.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Public</td></tr><tr><td>2</td><td>Private</td></tr><tr><td>3</td><td>Subsidiary</td></tr><tr><td>4</td><td>Other</td></tr><tbody></table>|
|participatesinworkflow|Edm.Boolean|**Display Name**: Participates in Workflow<br />**Description**: For system use only. Legacy Microsoft Dynamics CRM 3.0 workflow data.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|paymenttermscode|Edm.Int32|**Display Name**: Payment Terms<br />**Description**: Select the payment terms to indicate when the customer needs to pay the total amount.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Net 30</td></tr><tr><td>2</td><td>2% 10, Net 30</td></tr><tr><td>3</td><td>Net 45</td></tr><tr><td>4</td><td>Net 60</td></tr><tbody></table>|
|preferredappointmentdaycode|Edm.Int32|**Display Name**: Preferred Day<br />**Description**: Select the preferred day of the week for service appointments.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Sunday</td></tr><tr><td>1</td><td>Monday</td></tr><tr><td>2</td><td>Tuesday</td></tr><tr><td>3</td><td>Wednesday</td></tr><tr><td>4</td><td>Thursday</td></tr><tr><td>5</td><td>Friday</td></tr><tr><td>6</td><td>Saturday</td></tr><tbody></table>|
|preferredappointmenttimecode|Edm.Int32|**Display Name**: Preferred Time<br />**Description**: Select the preferred time of day for service appointments.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Morning</td></tr><tr><td>2</td><td>Afternoon</td></tr><tr><td>3</td><td>Evening</td></tr><tbody></table>|
|preferredcontactmethodcode|Edm.Int32|**Display Name**: Preferred Method of Contact<br />**Description**: Select the preferred method of contact.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Any</td></tr><tr><td>2</td><td>Email</td></tr><tr><td>3</td><td>Phone</td></tr><tr><td>4</td><td>Fax</td></tr><tr><td>5</td><td>Mail</td></tr><tbody></table>|
|primarysatoriid|Edm.String|**Display Name**: Primary Satori ID<br />**Description**: Primary Satori ID for Account<br />|
|primarytwitterid|Edm.String|**Display Name**: Primary Twitter ID<br />**Description**: Primary Twitter ID for Account<br />|
|processid|Edm.Guid|**Display Name**: Process<br />**Description**: Shows the ID of the process.<br />|
|revenue|Edm.Decimal|**Display Name**: Annual Revenue<br />**Description**: Type the annual revenue for the account, used as an indicator in financial performance analysis.<br />|
|revenue_base|Edm.Decimal|**Display Name**: Annual Revenue (Base)<br />**Description**: Shows the annual revenue converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.<br />Read-only<br />|
|sharesoutstanding|Edm.Int32|**Display Name**: Shares Outstanding<br />**Description**: Type the number of shares available to the public for the account. This number is used as an indicator in financial performance analysis.<br />|
|shippingmethodcode|Edm.Int32|**Display Name**: Shipping Method<br />**Description**: Select a shipping method for deliveries sent to the account's address to designate the preferred carrier or other delivery option.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|sic|Edm.String|**Display Name**: SIC Code<br />**Description**: Type the Standard Industrial Classification (SIC) code that indicates the account's primary industry of business, for use in marketing segmentation and demographic analysis.<br />|
|stageid|Edm.Guid|**Display Name**: Process Stage<br />**Description**: Shows the ID of the stage.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the account is active or inactive. Inactive accounts are read-only and can't be edited unless they are reactivated.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the account's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|stockexchange|Edm.String|**Display Name**: Stock Exchange<br />**Description**: Type the stock exchange at which the account is listed to track their stock and financial performance of the company.<br />|
|telephone1|Edm.String|**Display Name**: Main Phone<br />**Description**: Type the main phone number for this account.<br />|
|telephone2|Edm.String|**Display Name**: Other Phone<br />**Description**: Type a second phone number for this account.<br />|
|telephone3|Edm.String|**Display Name**: Telephone 3<br />**Description**: Type a third phone number for this account.<br />|
|territorycode|Edm.Int32|**Display Name**: Territory Code<br />**Description**: Select a region or territory for the account for use in segmentation and analysis.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|tickersymbol|Edm.String|**Display Name**: Ticker Symbol<br />**Description**: Type the stock exchange symbol for the account to track financial performance of the company. You can click the code entered in this field to access the latest trading information from MSN Money.<br />|
|timespentbymeonemailandmeetings|Edm.String|**Display Name**: Time Spent by me<br />**Description**: Total time spent for emails (read and write) and meetings by me in relation to account record.<br />Read-only<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the account.<br />Read-only<br />|
|websiteurl|Edm.String|**Display Name**: Website<br />**Description**: Type the account's website URL to get quick details about the company profile.<br />|
|yominame|Edm.String|**Display Name**: Yomi Account Name<br />**Description**: Type the phonetic spelling of the company name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdbyexternalparty_value||Shows the external party who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_defaultpricelevelid_value|defaultpricelevelid<br />|Choose the default price list associated with the account to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.|
|_masterid_value|masterid<br />|Shows the master account that the account was merged with.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedbyexternalparty_value||Shows the external party who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who created the record on behalf of another user.|
|_msa_managingpartnerid_value|msa_managingpartnerid<br />|Unique identifier for Account associated with Account.|
|_msdyn_billingaccount_value|msdyn_billingaccount_account<br />|Reference to an other account to be used for billing (only to be used if billing account differs)|
|_msdyn_preferredresource_value|msdyn_PreferredResource<br />||
|_msdyn_salestaxcode_value|msdyn_salestaxcode<br />|Default Sales Tax Code|
|_msdyn_serviceterritory_value|msdyn_serviceterritory<br />|The Service Territory this account belongs to. This is used to optimize scheduling and routing|
|_originatingleadid_value|originatingleadid<br />|Shows the lead that the account was created from if the account was created by converting a lead in Microsoft Dynamics 365. This is used to relate the account to data on the originating lead for use in reporting and analytics.|
|_ownerid_value|ownerid<br />|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that the record owner belongs to.|
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns the account.|
|_owninguser_value|owninguser<br />|Unique identifier of the user who owns the account.|
|_parentaccountid_value|parentaccountid<br />|Choose the parent account associated with this account to show parent and child businesses in reporting and analytics.|
|_preferredequipmentid_value|preferredequipmentid<br />|Choose the account's preferred service facility or equipment to make sure services are scheduled correctly for the customer.|
|_preferredserviceid_value|preferredserviceid<br />|Choose the account's preferred service for reference when you schedule service activities.|
|_preferredsystemuserid_value|preferredsystemuserid<br />|Choose the preferred service representative for reference when you schedule service activities for the account.|
|_primarycontactid_value|primarycontactid<br />|Choose the primary contact for the account to provide quick access to contact details.|
|_slaid_value|sla_account_sla<br />|Choose the service level agreement (SLA) that you want to apply to the Account record.|
|_slainvokedid_value|slainvokedid_account_sla<br />|Last SLA that was applied to this case. This field is for internal use only.|
|_territoryid_value|territoryid<br />|Choose the sales region or territory for the account to make sure the account is assigned to the correct representative and for use in segmentation and analysis.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_accountbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_accountbase_createdonbehalfby|
|defaultpricelevelid|[pricelevel EntityType](pricelevel.md)|price_level_accounts|
|masterid|[account EntityType](account.md)|account_master_account|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_accountbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_accountbase_modifiedonbehalfby|
|msa_managingpartnerid|[account EntityType](account.md)|msa_account_managingpartner|
|msdyn_billingaccount_account|[account EntityType](account.md)|msdyn_account_account_BillingAccount|
|msdyn_PreferredResource|[bookableresource EntityType](bookableresource.md)|msdyn_bookableresource_account_PreferredResource|
|msdyn_salestaxcode|[msdyn_taxcode EntityType](msdyn_taxcode.md)|msdyn_msdyn_taxcode_account_SalesTaxCode|
|msdyn_serviceterritory|[territory EntityType](territory.md)|msdyn_territory_account_ServiceTerritory|
|originatingleadid|[lead EntityType](lead.md)|account_originating_lead|
|ownerid|[principal EntityType](principal.md)|owner_accounts|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_accounts|
|owningteam|[team EntityType](team.md)|team_accounts|
|owninguser|[systemuser EntityType](systemuser.md)|user_accounts|
|parentaccountid|[account EntityType](account.md)|account_parent_account|
|preferredequipmentid|[equipment EntityType](equipment.md)|equipment_accounts|
|preferredserviceid|[service EntityType](service.md)|service_accounts|
|preferredsystemuserid|[systemuser EntityType](systemuser.md)|system_user_accounts|
|primarycontactid|[contact EntityType](contact.md)|account_primary_contact|
|sla_account_sla|[sla EntityType](sla.md)|manualsla_account|
|slainvokedid_account_sla|[sla EntityType](sla.md)|sla_account|
|stageid_processstage|[processstage EntityType](processstage.md)|processstage_account|
|territoryid|[territory EntityType](territory.md)|territory_accounts|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_account|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|account_actioncard|[actioncard EntityType](actioncard.md)|regardingobjectid_account_actioncard|  
|account_activity_parties|[activityparty EntityType](activityparty.md)|partyid_account|  
|Account_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_account|  
|account_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_account_adx_alertsubscription|  
|account_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_account_adx_inviteredemption|  
|account_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_account_adx_portalcomment|  
|Account_Annotation|[annotation EntityType](annotation.md)|objectid_account|  
|Account_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_account_appointment|  
|Account_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_account|  
|account_bookableresource_AccountId|[bookableresource EntityType](bookableresource.md)|AccountId|  
|Account_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_account|  
|account_BulkOperations|[bulkoperation EntityType](bulkoperation.md)|regardingobjectid_account_bulkoperation|  
|account_CampaignActivities|[campaignactivity EntityType](campaignactivity.md)|regardingobjectid_account_campaignactivity|  
|account_CampaignResponses|[campaignresponse EntityType](campaignresponse.md)|regardingobjectid_account_campaignresponse|  
|account_connections1|[connection EntityType](connection.md)|record1id_account|  
|account_connections2|[connection EntityType](connection.md)|record2id_account|  
|Account_CustomerAddress|[customeraddress EntityType](customeraddress.md)|parentid_account|  
|Account_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_account|  
|Account_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_account|  
|Account_Email_EmailSender|[email EntityType](email.md)|emailsender_account|  
|Account_Email_SendersAccount|[email EntityType](email.md)|sendersaccount|  
|Account_Emails|[email EntityType](email.md)|regardingobjectid_account_email|  
|account_entitlement_Account|[entitlement EntityType](entitlement.md)|accountid|  
|account_entitlement_Customer|[entitlement EntityType](entitlement.md)|customerid_account|  
|Account_Faxes|[fax EntityType](fax.md)|regardingobjectid_account_fax|  
|account_IncidentResolutions|[incidentresolution EntityType](incidentresolution.md)|regardingobjectid_account_incidentresolution|  
|Account_Letters|[letter EntityType](letter.md)|regardingobjectid_account_letter|  
|account_master_account|[account EntityType](account.md)|masterid|  
|account_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_account_msdyn_approval|  
|account_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_account_msdyn_bookingalert|  
|account_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_account_msdyn_surveyinvite|  
|account_OpportunityCloses|[opportunityclose EntityType](opportunityclose.md)|regardingobjectid_account_opportunityclose|  
|account_OrderCloses|[orderclose EntityType](orderclose.md)|regardingobjectid_account_orderclose|  
|account_parent_account|[account EntityType](account.md)|parentaccountid|  
|Account_Phonecalls|[phonecall EntityType](phonecall.md)|regardingobjectid_account_phonecall|  
|account_PostFollows|[postfollow EntityType](postfollow.md)|regardingobjectid_account|  
|account_PostRegardings|[postregarding EntityType](postregarding.md)|regardingobjectid_account|  
|account_QuoteCloses|[quoteclose EntityType](quoteclose.md)|regardingobjectid_account_quoteclose|  
|Account_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_account_recurringappointmentmaster|  
|Account_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_account_serviceappointment|  
|Account_SharepointDocumentLocation|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_account|  
|Account_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_account_socialactivity|  
|Account_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_account_syncerror|  
|Account_Tasks|[task EntityType](task.md)|regardingobjectid_account_task|  
|accountleads_association|[lead EntityType](lead.md)|accountleads_association|  
|adx_invitation_assigntoaccount|[adx_invitation EntityType](adx_invitation.md)|adx_assignToAccount|  
|adx_webrole_account|[adx_webrole EntityType](adx_webrole.md)|adx_webrole_account|  
|adx_website_sponsor|[adx_website EntityType](adx_website.md)|adx_website_sponsor|  
|contact_customer_accounts|[contact EntityType](contact.md)|parentcustomerid_account|  
|contract_billingcustomer_accounts|[contract EntityType](contract.md)|billingcustomerid_account|  
|contract_customer_accounts|[contract EntityType](contract.md)|customerid_account|  
|contractlineitem_customer_accounts|[contractdetail EntityType](contractdetail.md)|customerid_account|  
|CreatedAccount_BulkOperationLogs2|[bulkoperationlog EntityType](bulkoperationlog.md)|createdobjectid_account|  
|incident_customer_accounts|[incident EntityType](incident.md)|customerid_account|  
|invoice_customer_accounts|[invoice EntityType](invoice.md)|customerid_account|  
|lead_customer_accounts|[lead EntityType](lead.md)|customerid_account|  
|lead_parent_account|[lead EntityType](lead.md)|parentaccountid|  
|listaccount_association|[list EntityType](list.md)|listaccount_association|  
|msa_account_incident|[incident EntityType](incident.md)|msa_partnerid|  
|msa_account_managingpartner|[account EntityType](account.md)|msa_managingpartnerid|  
|msa_contact_managingpartner|[contact EntityType](contact.md)|msa_managingpartnerid|  
|msa_partner_opportunity|[opportunity EntityType](opportunity.md)|msa_partnerid|  
|msdyn_account_account_BillingAccount|[account EntityType](account.md)|msdyn_billingaccount_account|  
|msdyn_account_msdyn_accountpricelist_Account|[msdyn_accountpricelist EntityType](msdyn_accountpricelist.md)|msdyn_Account|  
|msdyn_account_msdyn_actual_AccountCustomer|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_AccountCustomer|  
|msdyn_account_msdyn_actual_AccountVendor|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_AccountVendor|  
|msdyn_account_msdyn_actual_ServiceAccount|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_ServiceAccount|  
|msdyn_account_msdyn_agreement_BillingAccount|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_billingaccount|  
|msdyn_account_msdyn_agreement_ServiceAccount|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_serviceaccount|  
|msdyn_account_msdyn_customerasset_Account|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_account|  
|msdyn_account_msdyn_estimateline_AccountCustomer|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_AccountCustomer|  
|msdyn_account_msdyn_estimateline_AccountVendor|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_AccountVendor|  
|msdyn_account_msdyn_fact_AccountCustomer|[msdyn_fact EntityType](msdyn_fact.md)|msdyn_AccountCustomer|  
|msdyn_account_msdyn_fact_AccountVendor|[msdyn_fact EntityType](msdyn_fact.md)|msdyn_AccountVendor|  
|msdyn_account_msdyn_invoicelinetransaction_AccountCustomer|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_AccountCustomer|  
|msdyn_account_msdyn_invoicelinetransaction_AccountVendor|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_AccountVendor|  
|msdyn_account_msdyn_iotdevice_Account|[msdyn_iotdevice EntityType](msdyn_iotdevice.md)|msdyn_Account|  
|msdyn_account_msdyn_journalline_AccountCustomer|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_AccountCustomer|  
|msdyn_account_msdyn_journalline_AccountVendor|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_AccountVendor|  
|msdyn_account_msdyn_opportunitylinetransaction_AccountCustomer|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|msdyn_AccountCustomer|  
|msdyn_account_msdyn_opportunitylinetransaction_AccountVendor|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|msdyn_AccountVendor|  
|msdyn_account_msdyn_orderlinetransaction_AccountCustomer|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_AccountCustomer|  
|msdyn_account_msdyn_orderlinetransaction_AccountVendor|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_AccountVendor|  
|msdyn_account_msdyn_payment_Account|[msdyn_payment EntityType](msdyn_payment.md)|msdyn_account|  
|msdyn_account_msdyn_project_Customer|[msdyn_project EntityType](msdyn_project.md)|msdyn_customer|  
|msdyn_account_msdyn_purchaseorder_Vendor|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|msdyn_vendor|  
|msdyn_account_msdyn_quotelinetransaction_AccountCustomer|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_AccountCustomer|  
|msdyn_account_msdyn_quotelinetransaction_AccountVendor|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_AccountVendor|  
|msdyn_account_msdyn_requirementresourcepreference_Account|[msdyn_requirementresourcepreference EntityType](msdyn_requirementresourcepreference.md)|msdyn_Account|  
|msdyn_account_msdyn_responseoutcome_Account|[msdyn_responseoutcome EntityType](msdyn_responseoutcome.md)|msdyn_Account|  
|msdyn_account_msdyn_rma_BillingAccount|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_billingaccount|  
|msdyn_account_msdyn_rma_ServiceAccount|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_serviceaccount|  
|msdyn_account_msdyn_rmaproduct_Changeownership|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|msdyn_changeownership|  
|msdyn_account_msdyn_rmaproduct_ReturntoVendor|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|msdyn_returntovendor|  
|msdyn_account_msdyn_rtv_Vendor|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_vendor|  
|msdyn_account_msdyn_surveyinvite_AccountId|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|msdyn_AccountId|  
|msdyn_account_msdyn_surveyresponse_Account|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_Account|  
|msdyn_account_msdyn_workorder_BillingAccount|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_billingaccount|  
|msdyn_account_msdyn_workorder_ServiceAccount|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_serviceaccount|  
|msdyn_account_msdyn_workorderresourcerestriction_Account|[msdyn_workorderresourcerestriction EntityType](msdyn_workorderresourcerestriction.md)|msdyn_Account|  
|msdyn_account_opportunityproduct_ServiceAccount|[opportunityproduct EntityType](opportunityproduct.md)|msdyn_serviceaccount|  
|msdyn_account_product_DefaultVendor|[product EntityType](product.md)|msdyn_defaultvendor|  
|msdyn_account_quote_Account|[quote EntityType](quote.md)|msdyn_account|  
|msdyn_account_quotedetail_ServiceAccount|[quotedetail EntityType](quotedetail.md)|msdyn_ServiceAccount|  
|msdyn_account_salesorder_Account|[salesorder EntityType](salesorder.md)|msdyn_account|  
|msevtmgt_account_msevtmgt_eventvendor_Account|[msevtmgt_eventvendor EntityType](msevtmgt_eventvendor.md)|msevtmgt_Account|  
|msevtmgt_account_msevtmgt_sponsorship_Sponsor|[msevtmgt_sponsorship EntityType](msevtmgt_sponsorship.md)|msevtmgt_Sponsor|  
|opportunity_customer_accounts|[opportunity EntityType](opportunity.md)|customerid_account|  
|opportunity_parent_account|[opportunity EntityType](opportunity.md)|parentaccountid|  
|order_customer_accounts|[salesorder EntityType](salesorder.md)|customerid_account|  
|quote_customer_accounts|[quote EntityType](quote.md)|customerid_account|  
|slakpiinstance_account|[slakpiinstance EntityType](slakpiinstance.md)|regarding_account|  
|SocialActivity_PostAuthor_accounts|[socialactivity EntityType](socialactivity.md)|postauthor_account|  
|SocialActivity_PostAuthorAccount_accounts|[socialactivity EntityType](socialactivity.md)|postauthoraccount_account|  
|Socialprofile_customer_accounts|[socialprofile EntityType](socialprofile.md)|customerid_account|  
|SourceAccount_BulkOperationLogs|[bulkoperationlog EntityType](bulkoperationlog.md)|regardingobjectid_account|  

## Operations
The following operations can be used with the account entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[Merge Action](../actions/merge.md)|Not Bound|[!INCLUDE[../actions/descriptions/merge.md](../actions/descriptions/merge.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  
|[Rollup Function](../functions/rollup.md)|Not Bound|[!INCLUDE[../functions/descriptions/rollup.md](../functions/descriptions/rollup.md)]|  

## Solutions
The following solutions include the account entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Portal Base Solution](../solutions/microsoftcrmportalbase.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportalbase.md](../solutions/descriptions/microsoftcrmportalbase.md)]|  
|[AppCommon Solution](../solutions/appcommon.md)|[!INCLUDE[../solutions/descriptions/appcommon.md](../solutions/descriptions/appcommon.md)]|  
|[Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicseventmanagementsolution.md](../solutions/descriptions/microsoftdynamicseventmanagementsolution.md)]|  
|[Dynamics 365 Portals - Portal Dependencies Solution](../solutions/microsoftcrmportaldependencies.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportaldependencies.md](../solutions/descriptions/microsoftcrmportaldependencies.md)]|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Microsoft Dynamics Product Management Workload Solution](../solutions/productmanagement.md)|[!INCLUDE[../solutions/descriptions/productmanagement.md](../solutions/descriptions/productmanagement.md)]|  
|[App for Outlook Solution](../solutions/appforoutlook.md)|[!INCLUDE[../solutions/descriptions/appforoutlook.md](../solutions/descriptions/appforoutlook.md)]|  
|[Unified Resource Scheduling Solution](../solutions/microsoftdynamicsscheduling.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsscheduling.md](../solutions/descriptions/microsoftdynamicsscheduling.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|  
|[Microsoft Dynamics CRM Marketing Sales Solution](../solutions/marketingsales.md)|[!INCLUDE[../solutions/descriptions/marketingsales.md](../solutions/descriptions/marketingsales.md)]|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|  
|[Microsoft Dynamics Lead Management Workload Solution](../solutions/leadmanagement.md)|[!INCLUDE[../solutions/descriptions/leadmanagement.md](../solutions/descriptions/leadmanagement.md)]|  
|[Microsoft Dynamics CRM Marketing Solution](../solutions/marketing.md)|[!INCLUDE[../solutions/descriptions/marketing.md](../solutions/descriptions/marketing.md)]|    

[!INCLUDE[./remarks/account.md](./remarks/account.md)]

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