---
title: "Microsoft Dynamics 365 Customer Engagement lead EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 717936e1-b682-4adb-9472-94cc86b30ee1
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API lead entitytype."
---
# lead EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/lead.md](./descriptions/lead.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]leads </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Lead</td></tr>
<tr><td><b>Primary Key:</b></td><td>leadid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>fullname</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|address1_addressid|Edm.Guid|**Display Name**: Address 1: ID<br />**Description**: Unique identifier for address 1.<br />|
|address1_addresstypecode|Edm.Int32|**Display Name**: Address 1: Address Type<br />**Description**: Select the primary address type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address1_city|Edm.String|**Display Name**: City<br />**Description**: Type the city for the primary address.<br />|
|address1_composite|Edm.String|**Display Name**: Address 1<br />**Description**: Shows the complete primary address.<br />Read-only<br />|
|address1_country|Edm.String|**Display Name**: Country/Region<br />**Description**: Type the country or region for the primary address.<br />|
|address1_county|Edm.String|**Display Name**: Address 1: County<br />**Description**: Type the county for the primary address.<br />|
|address1_fax|Edm.String|**Display Name**: Address 1: Fax<br />**Description**: Type the fax number associated with the primary address.<br />|
|address1_latitude|Edm.Double|**Display Name**: Address 1: Latitude<br />**Description**: Type the latitude value for the primary address for use in mapping and other applications.<br />|
|address1_line1|Edm.String|**Display Name**: Street 1<br />**Description**: Type the first line of the primary address.<br />|
|address1_line2|Edm.String|**Display Name**: Street 2<br />**Description**: Type the second line of the primary address.<br />|
|address1_line3|Edm.String|**Display Name**: Street 3<br />**Description**: Type the third line of the primary address.<br />|
|address1_longitude|Edm.Double|**Display Name**: Address 1: Longitude<br />**Description**: Type the longitude value for the primary address for use in mapping and other applications.<br />|
|address1_name|Edm.String|**Display Name**: Address 1: Name<br />**Description**: Type a descriptive name for the primary address, such as Corporate Headquarters.<br />|
|address1_postalcode|Edm.String|**Display Name**: ZIP/Postal Code<br />**Description**: Type the ZIP Code or postal code for the primary address.<br />|
|address1_postofficebox|Edm.String|**Display Name**: Address 1: Post Office Box<br />**Description**: Type the post office box number of the primary address.<br />|
|address1_shippingmethodcode|Edm.Int32|**Display Name**: Address 1: Shipping Method<br />**Description**: Select a shipping method for deliveries sent to this address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address1_stateorprovince|Edm.String|**Display Name**: State/Province<br />**Description**: Type the state or province of the primary address.<br />|
|address1_telephone1|Edm.String|**Display Name**: Address 1: Telephone 1<br />**Description**: Type the main phone number associated with the primary address.<br />|
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
|address2_latitude|Edm.Double|**Display Name**: Address 2: Latitude<br />**Description**: Type the latitude value for the secondary address for use in mapping and other applications.<br />|
|address2_line1|Edm.String|**Display Name**: Address 2: Street 1<br />**Description**: Type the first line of the secondary address.<br />|
|address2_line2|Edm.String|**Display Name**: Address 2: Street 2<br />**Description**: Type the second line of the secondary address.<br />|
|address2_line3|Edm.String|**Display Name**: Address 2: Street 3<br />**Description**: Type the third line of the secondary address.<br />|
|address2_longitude|Edm.Double|**Display Name**: Address 2: Longitude<br />**Description**: Type the longitude value for the secondary address for use in mapping and other applications.<br />|
|address2_name|Edm.String|**Display Name**: Address 2: Name<br />**Description**: Type a descriptive name for the secondary address, such as Corporate Headquarters.<br />|
|address2_postalcode|Edm.String|**Display Name**: Address 2: ZIP/Postal Code<br />**Description**: Type the ZIP Code or postal code for the secondary address.<br />|
|address2_postofficebox|Edm.String|**Display Name**: Address 2: Post Office Box<br />**Description**: Type the post office box number of the secondary address.<br />|
|address2_shippingmethodcode|Edm.Int32|**Display Name**: Address 2: Shipping Method<br />**Description**: Select a shipping method for deliveries sent to this address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address2_stateorprovince|Edm.String|**Display Name**: Address 2: State/Province<br />**Description**: Type the state or province of the secondary address.<br />|
|address2_telephone1|Edm.String|**Display Name**: Address 2: Telephone 1<br />**Description**: Type the main phone number associated with the secondary address.<br />|
|address2_telephone2|Edm.String|**Display Name**: Address 2: Telephone 2<br />**Description**: Type a second phone number associated with the secondary address.<br />|
|address2_telephone3|Edm.String|**Display Name**: Address 2: Telephone 3<br />**Description**: Type a third phone number associated with the secondary address.<br />|
|address2_upszone|Edm.String|**Display Name**: Address 2: UPS Zone<br />**Description**: Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.<br />|
|address2_utcoffset|Edm.Int32|**Display Name**: Address 2: UTC Offset<br />**Description**: Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.<br />|
|budgetamount|Edm.Decimal|**Display Name**: Budget Amount<br />**Description**: Information about the budget amount of the lead's company or organization.<br />|
|budgetamount_base|Edm.Decimal|**Display Name**: Budget Amount (Base)<br />**Description**: Value of the Budget Amount in base currency.<br />Read-only<br />|
|budgetstatus|Edm.Int32|**Display Name**: Budget<br />**Description**: Information about the budget status of the lead's company or organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>No Committed Budget</td></tr><tr><td>1</td><td>May Buy</td></tr><tr><td>2</td><td>Can Buy</td></tr><tr><td>3</td><td>Will Buy</td></tr><tbody></table>|
|companyname|Edm.String|**Display Name**: Company Name<br />**Description**: Type the name of the company associated with the lead. This becomes the account name when the lead is qualified and converted to a customer account.<br />|
|confirminterest|Edm.Boolean|**Display Name**: Confirm Interest<br />**Description**: Select whether the lead confirmed interest in your offerings. This helps in determining the lead quality.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>No</td></tr><tr><td>0</td><td>Yes</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|decisionmaker|Edm.Boolean|**Display Name**: Decision Maker?<br />**Description**: Select whether your notes include information about who makes the purchase decisions at the lead's company.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>completed</td></tr><tr><td>0</td><td>mark complete</td></tr><tbody></table>|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the lead, such as an excerpt from the company's website.<br />|
|donotbulkemail|Edm.Boolean|**Display Name**: Do not allow Bulk Emails<br />**Description**: Select whether the lead accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the lead can be added to marketing lists, but will be excluded from the email.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|donotemail|Edm.Boolean|**Display Name**: Do not allow Emails<br />**Description**: Select whether the lead allows direct email sent from Microsoft Dynamics 365.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|donotfax|Edm.Boolean|**Display Name**: Do not allow Faxes<br />**Description**: Select whether the lead allows faxes.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|donotphone|Edm.Boolean|**Display Name**: Do not allow Phone Calls<br />**Description**: Select whether the lead allows phone calls.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|donotpostalmail|Edm.Boolean|**Display Name**: Do not allow Mails<br />**Description**: Select whether the lead allows direct mail.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|donotsendmm|Edm.Boolean|**Display Name**: Marketing Material<br />**Description**: Select whether the lead accepts marketing materials, such as brochures or catalogs. Leads that opt out can be excluded from marketing initiatives.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Send</td></tr><tr><td>0</td><td>Send</td></tr><tbody></table>|
|emailaddress1|Edm.String|**Display Name**: Email<br />**Description**: Type the primary email address for the lead.<br />|
|emailaddress2|Edm.String|**Display Name**: Email Address 2<br />**Description**: Type the secondary email address for the lead.<br />|
|emailaddress3|Edm.String|**Display Name**: Email Address 3<br />**Description**: Type a third email address for the lead.<br />|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: Shows the default image for the record.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|Read-only<br />|
|estimatedamount|Edm.Decimal|**Display Name**: Est. Value<br />**Description**: Type the estimated revenue value that this lead will generate to assist in sales forecasting and planning.<br />|
|estimatedamount_base|Edm.Decimal|**Display Name**: Est. Value (Base)<br />**Description**: Value of the Est. Value in base currency.<br />Read-only<br />|
|estimatedclosedate|Edm.Date|**Display Name**: Est. Close Date<br />**Description**: Enter the expected close date for the lead, so that the sales team can schedule timely follow-up meetings to move the prospect to the next sales stage.<br />|
|estimatedvalue|Edm.Double|**Display Name**: Est. Value (deprecated)<br />**Description**: Type a numeric value of the lead's estimated value, such as a product quantity, if no revenue amount can be specified in the Est. Value field. This can be used for sales forecasting and planning.<br />|
|evaluatefit|Edm.Boolean|**Display Name**: Evaluate Fit<br />**Description**: Select whether the fit between the lead's requirements and your offerings was evaluated.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>No</td></tr><tr><td>0</td><td>Yes</td></tr><tbody></table>|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|fax|Edm.String|**Display Name**: Fax<br />**Description**: Type the fax number for the primary contact for the lead.<br />|
|firstname|Edm.String|**Display Name**: First Name<br />**Description**: Type the first name of the primary contact for the lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.<br />|
|followemail|Edm.Boolean|**Display Name**: Follow Email Activity<br />**Description**: Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the lead.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Allow</td></tr><tr><td>0</td><td>Do Not Allow</td></tr><tbody></table>|
|fullname|Edm.String|**Display Name**: Name<br />**Description**: Combines and shows the lead's first and last names so the full name can be displayed in views and reports.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|industrycode|Edm.Int32|**Display Name**: Industry<br />**Description**: Select the primary industry in which the lead's business is focused, for use in marketing segmentation and demographic analysis.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Accounting</td></tr><tr><td>2</td><td>Agriculture and Non-petrol Natural Resource Extraction</td></tr><tr><td>3</td><td>Broadcasting Printing and Publishing</td></tr><tr><td>4</td><td>Brokers</td></tr><tr><td>5</td><td>Building Supply Retail</td></tr><tr><td>6</td><td>Business Services</td></tr><tr><td>7</td><td>Consulting</td></tr><tr><td>8</td><td>Consumer Services</td></tr><tr><td>9</td><td>Design, Direction and Creative Management</td></tr><tr><td>10</td><td>Distributors, Dispatchers and Processors</td></tr><tr><td>11</td><td>Doctor's Offices and Clinics</td></tr><tr><td>12</td><td>Durable Manufacturing</td></tr><tr><td>13</td><td>Eating and Drinking Places</td></tr><tr><td>14</td><td>Entertainment Retail</td></tr><tr><td>15</td><td>Equipment Rental and Leasing</td></tr><tr><td>16</td><td>Financial</td></tr><tr><td>17</td><td>Food and Tobacco Processing</td></tr><tr><td>18</td><td>Inbound Capital Intensive Processing</td></tr><tr><td>19</td><td>Inbound Repair and Services</td></tr><tr><td>20</td><td>Insurance</td></tr><tr><td>21</td><td>Legal Services</td></tr><tr><td>22</td><td>Non-Durable Merchandise Retail</td></tr><tr><td>23</td><td>Outbound Consumer Service</td></tr><tr><td>24</td><td>Petrochemical Extraction and Distribution</td></tr><tr><td>25</td><td>Service Retail</td></tr><tr><td>26</td><td>SIG Affiliations</td></tr><tr><td>27</td><td>Social Services</td></tr><tr><td>28</td><td>Special Outbound Trade Contractors</td></tr><tr><td>29</td><td>Specialty Realty</td></tr><tr><td>30</td><td>Transportation</td></tr><tr><td>31</td><td>Utility Creation and Distribution</td></tr><tr><td>32</td><td>Vehicle Retail</td></tr><tr><td>33</td><td>Wholesale</td></tr><tbody></table>|
|initialcommunication|Edm.Int32|**Display Name**: Initial Communication<br />**Description**: Choose whether someone from the sales team contacted this lead earlier.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Contacted</td></tr><tr><td>1</td><td>Not Contacted</td></tr><tbody></table>|
|jobtitle|Edm.String|**Display Name**: Job Title<br />**Description**: Type the job title of the primary contact for this lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.<br />|
|lastname|Edm.String|**Display Name**: Last Name<br />**Description**: Type the last name of the primary contact for the lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.<br />|
|lastonholdtime|Edm.DateTimeOffset|**Display Name**: Last On Hold Time<br />**Description**: Contains the date and time stamp of the last on hold time.<br />|
|lastusedincampaign|Edm.DateTimeOffset|**Display Name**: Last Campaign Date<br />**Description**: Shows the date when the lead was last included in a marketing campaign or quick campaign.<br />|
|leadid|Edm.Guid|**Display Name**: Lead<br />**Description**: Unique identifier of the lead.<br />|
|leadqualitycode|Edm.Int32|**Display Name**: Rating<br />**Description**: Select a rating value to indicate the lead's potential to become a customer.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Hot</td></tr><tr><td>2</td><td>Warm</td></tr><tr><td>3</td><td>Cold</td></tr><tbody></table>|
|leadsourcecode|Edm.Int32|**Display Name**: Lead Source<br />**Description**: Select the primary marketing source that prompted the lead to contact you.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Advertisement</td></tr><tr><td>2</td><td>Employee Referral</td></tr><tr><td>3</td><td>External Referral</td></tr><tr><td>192350000</td><td>LinkedIn Sponsored Form</td></tr><tr><td>4</td><td>Partner</td></tr><tr><td>5</td><td>Public Relations</td></tr><tr><td>6</td><td>Seminar</td></tr><tr><td>7</td><td>Trade Show</td></tr><tr><td>8</td><td>Web</td></tr><tr><td>9</td><td>Word of Mouth</td></tr><tr><td>10</td><td>Other</td></tr><tbody></table>|
|merged|Edm.Boolean|**Display Name**: Merged<br />**Description**: Tells whether the lead has been merged with another lead.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|middlename|Edm.String|**Display Name**: Middle Name<br />**Description**: Type the middle name or initial of the primary contact for the lead to make sure the prospect is addressed correctly.<br />|
|mobilephone|Edm.String|**Display Name**: Mobile Phone<br />**Description**: Type the mobile phone number for the primary contact for the lead.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_ordertype|Edm.Int32|**Display Name**: Type<br />**Description**: Whether the Opportunity created when qualifying this Lead is for an Item- based or a Work-based sale<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970002</td><td>Service-Maintenance Based</td></tr><tr><td>192350000</td><td>Item based</td></tr><tr><td>192350001</td><td>Work based</td></tr><tbody></table>|
|msdyncrm_code|Edm.String|**Display Name**: Code<br />|
|msdyncrm_companysize|Edm.String|**Display Name**: Company size<br />**Description**: Enter the size of the company the lead belongs to<br />|
|msdyncrm_contactid|Edm.String|**Display Name**: Contact Id<br />|
|msdyncrm_degree|Edm.String|**Display Name**: Degree<br />**Description**: Enter the highest education level achieved<br />|
|msdyncrm_fieldofstudy|Edm.String|**Display Name**: Field of study<br />**Description**: Enter the lead's field of study<br />|
|msdyncrm_graduationdate|Edm.String|**Display Name**: Graduation date<br />**Description**: Enter the lead's graduation date from the last school or university<br />|
|msdyncrm_industry|Edm.String|**Display Name**: Industry<br />**Description**: Enter the industry the lead belongs to<br />|
|msdyncrm_jobfunction|Edm.String|**Display Name**: Job function<br />**Description**: Enter the lead's job function<br />|
|msdyncrm_latestsubmissiondate|Edm.DateTimeOffset|**Display Name**: Latest Form Submission Date<br />|
|msdyncrm_lead_insights_placeholder|Edm.String|**Display Name**: Lead Insights Placeholder<br />|
|msdyncrm_leadid|Edm.String|**Display Name**: Lead Id<br />|
|msdyncrm_leadsourcetype|Edm.Int32|**Display Name**: Lead Source Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Marketing</td></tr><tr><td>192350001</td><td>Sales</td></tr><tr><td>192350002</td><td>Teleprospect</td></tr><tbody></table>|
|msdyncrm_linkedinsubmissioncount|Edm.Int32|**Display Name**: LinkedIn Form Submissions<br />**Description**: Number of submissions by this lead<br />Computed<br />Read-only<br />|
|msdyncrm_linkedinsubmissioncount_date|Edm.DateTimeOffset|**Display Name**: LinkedIn Form Submissions (Last Updated On)<br />**Description**: Last Updated time of rollup field LinkedIn Form Submissions.<br />Read-only<br />|
|msdyncrm_linkedinsubmissioncount_state|Edm.Int32|**Display Name**: LinkedIn Form Submissions (State)<br />**Description**: State of rollup field LinkedIn Form Submissions.<br />Read-only<br />|
|msdyncrm_profileid|Edm.String|**Display Name**: profileId<br />|
|msdyncrm_purchaseneed|Edm.Boolean|**Display Name**: Purchase Need<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyncrm_recycled|Edm.Boolean|**Display Name**: Recycled<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyncrm_salesaccepted|Edm.Boolean|**Display Name**: Sales Accepted<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyncrm_salesready|Edm.Boolean|**Display Name**: Sales Ready<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyncrm_sastoken|Edm.String|**Display Name**: sasToken<br />|
|msdyncrm_school|Edm.String|**Display Name**: School<br />**Description**: Enter the last school or university attended<br />|
|msdyncrm_scores|Edm.Int32|**Display Name**: Scores<br />|
|msdyncrm_scoringgrade|Edm.String|**Display Name**: Scoring Grade<br />|
|msdyncrm_seniority|Edm.String|**Display Name**: Seniority<br />**Description**: Enter the lead's seniority in their organization<br />|
|msdyncrm_startdate|Edm.String|**Display Name**: Start date<br />**Description**: Enter the start date for the last school or university<br />|
|msdyncrm_teleprospectaccepted|Edm.Boolean|**Display Name**: Tele Prospect Accepted<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyncrm_teleprospectready|Edm.Boolean|**Display Name**: Tele Prospect Ready<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|need|Edm.Int32|**Display Name**: Need<br />**Description**: Choose how high the level of need is for the lead's company.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Must have</td></tr><tr><td>1</td><td>Should have</td></tr><tr><td>2</td><td>Good to have</td></tr><tr><td>3</td><td>No need</td></tr><tbody></table>|
|numberofemployees|Edm.Int32|**Display Name**: No. of Employees<br />**Description**: Type the number of employees that work at the company associated with the lead, for use in marketing segmentation and demographic analysis.<br />|
|onholdtime|Edm.Int32|**Display Name**: On Hold Time (Minutes)<br />**Description**: Shows how long, in minutes, that the record was on hold.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|pager|Edm.String|**Display Name**: Pager<br />**Description**: Type the pager number for the primary contact for the lead.<br />|
|participatesinworkflow|Edm.Boolean|**Display Name**: Participates in Workflow<br />**Description**: Shows whether the lead participates in workflow rules.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|preferredcontactmethodcode|Edm.Int32|**Display Name**: Preferred Method of Contact<br />**Description**: Select the preferred method of contact.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Any</td></tr><tr><td>2</td><td>Email</td></tr><tr><td>3</td><td>Phone</td></tr><tr><td>4</td><td>Fax</td></tr><tr><td>5</td><td>Mail</td></tr><tbody></table>|
|prioritycode|Edm.Int32|**Display Name**: Priority<br />**Description**: Select the priority so that preferred customers or critical issues are handled quickly.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|purchaseprocess|Edm.Int32|**Display Name**: Purchase Process<br />**Description**: Choose whether an individual or a committee will be involved in the  purchase process for the lead.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Individual</td></tr><tr><td>1</td><td>Committee</td></tr><tr><td>2</td><td>Unknown</td></tr><tbody></table>|
|purchasetimeframe|Edm.Int32|**Display Name**: Purchase Timeframe<br />**Description**: Choose how long the lead will likely take to make the purchase, so the sales team will be aware.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Immediate</td></tr><tr><td>1</td><td>This Quarter</td></tr><tr><td>2</td><td>Next Quarter</td></tr><tr><td>3</td><td>This Year</td></tr><tr><td>4</td><td>Unknown</td></tr><tbody></table>|
|qualificationcomments|Edm.String|**Display Name**: Qualification Comments<br />**Description**: Type comments about the qualification or scoring of the lead.<br />|
|revenue|Edm.Decimal|**Display Name**: Annual Revenue<br />**Description**: Type the annual revenue of the company associated with the lead to provide an understanding of the prospect's business.<br />|
|revenue_base|Edm.Decimal|**Display Name**: Annual Revenue (Base)<br />**Description**: Value of the Annual Revenue in base currency.<br />Read-only<br />|
|salesstage|Edm.Int32|**Display Name**: Sales Stage<br />**Description**: Select the sales stage of this lead to aid the sales team in their efforts to convert this lead to an opportunity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Qualify</td></tr><tbody></table>|
|salesstagecode|Edm.Int32|**Display Name**: Sales Stage Code<br />**Description**: Select the sales process stage for the lead to help determine the probability of the lead converting to an opportunity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|salutation|Edm.String|**Display Name**: Salutation<br />**Description**: Type the salutation of the primary contact for this lead to make sure the prospect is addressed correctly in sales calls, email messages, and marketing campaigns.<br />|
|schedulefollowup_prospect|Edm.DateTimeOffset|**Display Name**: Schedule Follow Up (Prospect)<br />**Description**: Enter the date and time of the prospecting follow-up meeting with the lead.<br />|
|schedulefollowup_qualify|Edm.DateTimeOffset|**Display Name**: Schedule Follow Up (Qualify)<br />**Description**: Enter the date and time of the qualifying follow-up meeting with the lead.<br />|
|sic|Edm.String|**Display Name**: SIC Code<br />**Description**: Type the Standard Industrial Classification (SIC) code that indicates the lead's primary industry of business for use in marketing segmentation and demographic analysis.<br />|
|stageid|Edm.Guid|**Display Name**: Stage Id<br />**Description**: Contains the id of the stage where the entity is located.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the lead is open, qualified, or disqualified. Qualified and disqualified leads are read-only and can't be edited unless they are reactivated.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Open</td></tr><tr><td>1</td><td>Qualified</td></tr><tr><td>2</td><td>Disqualified</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the lead's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>New</td></tr><tr><td>2</td><td>Contacted</td></tr><tr><td>3</td><td>Qualified</td></tr><tr><td>4</td><td>Lost</td></tr><tr><td>5</td><td>Cannot Contact</td></tr><tr><td>6</td><td>No Longer Interested</td></tr><tr><td>7</td><td>Canceled</td></tr><tbody></table>|
|subject|Edm.String|**Display Name**: Topic<br />**Description**: Type a subject or descriptive name, such as the expected order, company name, or marketing source list, to identify the lead.<br />|
|telephone1|Edm.String|**Display Name**: Business Phone<br />**Description**: Type the work phone number for the primary contact for the lead.<br />|
|telephone2|Edm.String|**Display Name**: Home Phone<br />**Description**: Type the home phone number for the primary contact for the lead.<br />|
|telephone3|Edm.String|**Display Name**: Other Phone<br />**Description**: Type an alternate phone number for the primary contact for the lead.<br />|
|timespentbymeonemailandmeetings|Edm.String|**Display Name**: Time Spent by me<br />**Description**: Total time spent for emails (read and write) and meetings by me in relation to the lead record.<br />Read-only<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|
|websiteurl|Edm.String|**Display Name**: Website<br />**Description**: Type the website URL for the company associated with this lead.<br />|
|yomicompanyname|Edm.String|**Display Name**: Yomi Company Name<br />**Description**: Type the phonetic spelling of the lead's company name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.<br />|
|yomifirstname|Edm.String|**Display Name**: Yomi First Name<br />**Description**: Type the phonetic spelling of the lead's first name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.<br />|
|yomifullname|Edm.String|**Display Name**: Yomi Full Name<br />**Description**: Combines and shows the lead's Yomi first and last names so the full phonetic name can be displayed in views and reports.<br />Read-only<br />|
|yomilastname|Edm.String|**Display Name**: Yomi Last Name<br />**Description**: Type the phonetic spelling of the lead's last name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.<br />|
|yomimiddlename|Edm.String|**Display Name**: Yomi Middle Name<br />**Description**: Type the phonetic spelling of the lead's middle name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_accountid_value||Unique identifier of the account with which the lead is associated.|
|_campaignid_value|campaignid<br />|Choose the campaign that the lead was generated from to track the effectiveness of marketing campaigns and identify  communications received by the lead.|
|_contactid_value||Unique identifier of the contact with which the lead is associated.|
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_customerid_value|customerid_account<br />customerid_contact<br />|Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.|
|_masterid_value|masterid<br />|Unique identifier of the master lead for merge.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_msdyncrm_campaignid_value|msdyncrm_campaignid<br />||
|_msdyncrm_emailid_value|msdyncrm_emailid<br />||
|_msdyncrm_linkedincampaign_value|msdyncrm_LinkedInCampaign<br />||
|_msdyncrm_marketingformid_value|msdyncrm_marketingformid<br />||
|_msdyncrm_marketingpageid_value|msdyncrm_marketingpageid<br />||
|_msdyncrm_sourceform_value|msdyncrm_sourceform<br />|LinkedIn form this lead came from|
|_originatingcaseid_value|originatingcaseid<br />|This attribute is used for Sample Service Business Processes.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_parentaccountid_value|parentaccountid<br />|Choose an account to connect this lead to, so that the relationship is visible in reports and analytics.|
|_parentcontactid_value|parentcontactid<br />|Choose a contact to connect this lead to, so that the relationship is visible in reports and analytics.|
|_qualifyingopportunityid_value|qualifyingopportunityid<br />|Choose the opportunity that the lead was qualified on and then converted to.|
|_relatedobjectid_value||Related Campaign Response.|
|_slaid_value|sla_lead_sla<br />|Choose the service level agreement (SLA) that you want to apply to the Lead record.|
|_slainvokedid_value|slainvokedid_lead_sla<br />|Last SLA that was applied to this case. This field is for internal use only.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|campaignid|[campaign EntityType](campaign.md)|campaign_leads|
|createdby|[systemuser EntityType](systemuser.md)|lk_leadbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_leadbase_createdonbehalfby|
|customerid_account|[account EntityType](account.md)|lead_customer_accounts|
|customerid_contact|[contact EntityType](contact.md)|lead_customer_contacts|
|masterid|[lead EntityType](lead.md)|lead_master_lead|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_leadbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_leadbase_modifiedonbehalfby|
|msdyncrm_campaignid|[msdyncrm_customerjourney EntityType](msdyncrm_customerjourney.md)|msdyncrm_msdyncrm_customerjourney_lead_campaignid|
|msdyncrm_emailid|[msdyncrm_marketingemail EntityType](msdyncrm_marketingemail.md)|msdyncrm_msdyncrm_marketingemail_lead_emailid|
|msdyncrm_LinkedInCampaign|[msdyncrm_linkedincampaign EntityType](msdyncrm_linkedincampaign.md)|msdyncrm_msdyncrm_linkedincampaign_lead_LinkedInCampaign|
|msdyncrm_marketingformid|[msdyncrm_marketingform EntityType](msdyncrm_marketingform.md)|msdyncrm_msdyncrm_marketingform_lead_marketingformid|
|msdyncrm_marketingpageid|[msdyncrm_marketingpage EntityType](msdyncrm_marketingpage.md)|msdyncrm_msdyncrm_marketingpage_lead_marketingpageid|
|msdyncrm_sourceform|[msdyncrm_linkedinform EntityType](msdyncrm_linkedinform.md)|msdyncrm_msdyncrm_linkedinform_lead_sourceform|
|originatingcaseid|[incident EntityType](incident.md)|OriginatingCase_Lead|
|ownerid|[principal EntityType](principal.md)|owner_leads|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_leads|
|owningteam|[team EntityType](team.md)|lead_owning_team|
|owninguser|[systemuser EntityType](systemuser.md)|lead_owning_user|
|parentaccountid|[account EntityType](account.md)|lead_parent_account|
|parentcontactid|[contact EntityType](contact.md)|lead_parent_contact|
|qualifyingopportunityid|[opportunity EntityType](opportunity.md)|lead_qualifying_opportunity|
|relatedobjectid|[campaignresponse EntityType](campaignresponse.md)|CampaignResponse_Lead|
|sla_lead_sla|[sla EntityType](sla.md)|manualsla_lead|
|slainvokedid_lead_sla|[sla EntityType](sla.md)|sla_lead|
|stageid_processstage|[processstage EntityType](processstage.md)|processstage_lead|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_lead|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|account_originating_lead|[account EntityType](account.md)|originatingleadid|  
|accountleads_association|[account EntityType](account.md)|accountleads_association|  
|contact_originating_lead|[contact EntityType](contact.md)|originatingleadid|  
|contactleads_association|[contact EntityType](contact.md)|contactleads_association|  
|CreatedLead_BulkOperationLogs|[bulkoperationlog EntityType](bulkoperationlog.md)|createdobjectid_lead|  
|Lead_actioncard|[actioncard EntityType](actioncard.md)|regardingobjectid_lead_actioncard|  
|lead_activity_parties|[activityparty EntityType](activityparty.md)|partyid_lead|  
|Lead_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_lead|  
|lead_addresses|[leadaddress EntityType](leadaddress.md)|parentid|  
|lead_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_lead_adx_alertsubscription|  
|lead_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_lead_adx_inviteredemption|  
|lead_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_lead_adx_portalcomment|  
|Lead_Annotation|[annotation EntityType](annotation.md)|objectid_lead|  
|Lead_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_lead_appointment|  
|Lead_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_lead|  
|Lead_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_lead|  
|lead_BulkOperations|[bulkoperation EntityType](bulkoperation.md)|regardingobjectid_lead_bulkoperation|  
|lead_CampaignActivities|[campaignactivity EntityType](campaignactivity.md)|regardingobjectid_lead_campaignactivity|  
|lead_CampaignResponses|[campaignresponse EntityType](campaignresponse.md)|regardingobjectid_lead_campaignresponse|  
|lead_connections1|[connection EntityType](connection.md)|record1id_lead|  
|lead_connections2|[connection EntityType](connection.md)|record2id_lead|  
|Lead_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_lead|  
|Lead_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_lead|  
|Lead_Email_EmailSender|[email EntityType](email.md)|emailsender_lead|  
|Lead_Emails|[email EntityType](email.md)|regardingobjectid_lead_email|  
|Lead_Faxes|[fax EntityType](fax.md)|regardingobjectid_lead_fax|  
|lead_IncidentResolutions|[incidentresolution EntityType](incidentresolution.md)|regardingobjectid_lead_incidentresolution|  
|lead_leadtoopportunitysalesprocess|[leadtoopportunitysalesprocess EntityType](leadtoopportunitysalesprocess.md)|leadId|  
|Lead_Letters|[letter EntityType](letter.md)|regardingobjectid_lead_letter|  
|lead_master_lead|[lead EntityType](lead.md)|masterid|  
|lead_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_lead_msdyn_approval|  
|lead_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_lead_msdyn_bookingalert|  
|lead_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_lead_msdyn_surveyinvite|  
|lead_OpportunityCloses|[opportunityclose EntityType](opportunityclose.md)|regardingobjectid_lead_opportunityclose|  
|lead_OrderCloses|[orderclose EntityType](orderclose.md)|regardingobjectid_lead_orderclose|  
|Lead_Phonecalls|[phonecall EntityType](phonecall.md)|regardingobjectid_lead_phonecall|  
|lead_PostFollows|[postfollow EntityType](postfollow.md)|regardingobjectid_lead|  
|lead_PostRegardings|[postregarding EntityType](postregarding.md)|regardingobjectid_lead|  
|lead_QuoteCloses|[quoteclose EntityType](quoteclose.md)|regardingobjectid_lead_quoteclose|  
|Lead_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_lead_recurringappointmentmaster|  
|Lead_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_lead_serviceappointment|  
|Lead_SharepointDocumentLocation|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_lead|  
|Lead_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_lead_socialactivity|  
|Lead_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_lead|  
|Lead_Tasks|[task EntityType](task.md)|regardingobjectid_lead_task|  
|leadcompetitors_association|[competitor EntityType](competitor.md)|leadcompetitors_association|  
|leadproduct_association|[product EntityType](product.md)|leadproduct_association|  
|listlead_association|[list EntityType](list.md)|listlead_association|  
|msdyn_lead_msdyn_responseoutcome_Lead|[msdyn_responseoutcome EntityType](msdyn_responseoutcome.md)|msdyn_Lead|  
|msdyn_lead_msdyn_surveyinvite_LeadId|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|msdyn_LeadId|  
|msdyn_lead_msdyn_surveyresponse_Lead|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_Leadid|  
|msdyncrm_lead_msdyncrm_geopin|[msdyncrm_geopin EntityType](msdyncrm_geopin.md)|msdyncrm_LeadGeoPinsId|  
|msdyncrm_lead_msdyncrm_leadscore|[msdyncrm_leadscore EntityType](msdyncrm_leadscore.md)|msdyncrm_leadId|  
|msdyncrm_lead_msdyncrm_leadtoopportunity|[msdyncrm_leadtoopportunity EntityType](msdyncrm_leadtoopportunity.md)|msdyncrm_leadid|  
|msdyncrm_lead_msdyncrm_linkedinformsubmission_Lead|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|msdyncrm_Lead|  
|opportunity_originating_lead|[opportunity EntityType](opportunity.md)|originatingleadid|  
|slakpiinstance_lead|[slakpiinstance EntityType](slakpiinstance.md)|regarding_lead|  
|SourceLead_BulkOperationLogs|[bulkoperationlog EntityType](bulkoperationlog.md)|regardingobjectid_lead|  

## Operations
The following operations can be used with the lead entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[Merge Action](../actions/merge.md)|Not Bound|[!INCLUDE[../actions/descriptions/merge.md](../actions/descriptions/merge.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[QualifyLead Action](../actions/qualifylead.md)|Entity|[!INCLUDE[../actions/descriptions/qualifylead.md](../actions/descriptions/qualifylead.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the lead entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Portal Base Solution](../solutions/microsoftcrmportalbase.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportalbase.md](../solutions/descriptions/microsoftcrmportalbase.md)]|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Lead Management Solution Solution](../solutions/leadmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/leadmanagementsolution.md](../solutions/descriptions/leadmanagementsolution.md)]|  
|[Microsoft Dynamics Marketing Solution](../solutions/microsoftdynamicsmarketingcrmsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md](../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md)]|  
|[App for Outlook Solution](../solutions/appforoutlook.md)|[!INCLUDE[../solutions/descriptions/appforoutlook.md](../solutions/descriptions/appforoutlook.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|  
|[Microsoft Dynamics CRM Marketing Sales Solution](../solutions/marketingsales.md)|[!INCLUDE[../solutions/descriptions/marketingsales.md](../solutions/descriptions/marketingsales.md)]|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|  
|[Gamification Solution](../solutions/gamification.md)|[!INCLUDE[../solutions/descriptions/gamification.md](../solutions/descriptions/gamification.md)]|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|  
|[Microsoft Dynamics Lead Management Workload Solution](../solutions/leadmanagement.md)|[!INCLUDE[../solutions/descriptions/leadmanagement.md](../solutions/descriptions/leadmanagement.md)]|  
|[Microsoft Dynamics CRM Marketing Solution](../solutions/marketing.md)|[!INCLUDE[../solutions/descriptions/marketing.md](../solutions/descriptions/marketing.md)]|  
|[LinkedIn Lead Gen Forms Solution](../solutions/linkedinleadgenintegration.md)|[!INCLUDE[../solutions/descriptions/linkedinleadgenintegration.md](../solutions/descriptions/linkedinleadgenintegration.md)]|    

[!INCLUDE[./remarks/lead.md](./remarks/lead.md)]

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