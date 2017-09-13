---
title: "Microsoft Dynamics 365 Customer Engagement organization EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 9e191826-8548-4fe6-a631-0227c15d8c99
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API organization entitytype."
---
# organization EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/organization.md](./descriptions/organization.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]organizations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Organization</td></tr>
<tr><td><b>Primary Key:</b></td><td>organizationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET,PATCH</td></tr>
</table>
  
The organization EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|aciwebendpointurl|Edm.String|**Display Name**: ACI Tenant URL.<br />**Description**: ACI Web Endpoint URL.<br />|
|allowaddressbooksyncs|Edm.Boolean|**Display Name**: Allow Address Book Synchronization<br />**Description**: Indicates whether background address book synchronization in Microsoft Office Outlook is allowed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|allowautoresponsecreation|Edm.Boolean|**Display Name**: Allow Automatic Response Creation<br />**Description**: Indicates whether automatic response creation is allowed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|allowautounsubscribe|Edm.Boolean|**Display Name**: Allow Automatic Unsubscribe<br />**Description**: Indicates whether automatic unsubscribe is allowed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|allowautounsubscribeacknowledgement|Edm.Boolean|**Display Name**: Allow Automatic Unsubscribe Acknowledgement<br />**Description**: Indicates whether automatic unsubscribe acknowledgement email is allowed to send.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|allowclientmessagebarad|Edm.Boolean|**Display Name**: Allow Outlook Client Message Bar Advertisement<br />**Description**: Indicates whether Outlook Client message bar advertisement is allowed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|allowentityonlyaudit|Edm.Boolean|**Display Name**: Allow Entity Level Auditing<br />**Description**: Indicates whether auditing of changes to entity is allowed when no attributes have changed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|allowmarketingemailexecution|Edm.Boolean|**Display Name**: Allow Marketing Email Execution<br />**Description**: Indicates whether marketing emails execution is allowed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|allowofflinescheduledsyncs|Edm.Boolean|**Display Name**: Allow Offline Scheduled Synchronization<br />**Description**: Indicates whether background offline synchronization in Microsoft Office Outlook is allowed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|allowoutlookscheduledsyncs|Edm.Boolean|**Display Name**: Allow Scheduled Synchronization<br />**Description**: Indicates whether scheduled synchronizations to Outlook are allowed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|allowunresolvedpartiesonemailsend|Edm.Boolean|**Display Name**: Allow Unresolved Address Email Send<br />**Description**: Indicates whether users are allowed to send email to unresolved parties (parties must still have an email address).<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|allowuserformmodepreference|Edm.Boolean|**Display Name**: Allow User Form Mode Preference<br />**Description**: Indicates whether individuals can select their form mode preference in their personal options.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|allowusersseeappdownloadmessage|Edm.Boolean|**Display Name**: Allow the showing tablet application notification bars in a browser.<br />**Description**: Indicates whether the showing tablet application notification bars in a browser is allowed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|allowwebexcelexport|Edm.Boolean|**Display Name**: Allow Export to Excel<br />**Description**: Indicates whether Web-based export of grids to Microsoft Office Excel is allowed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|amdesignator|Edm.String|**Display Name**: AM Designator<br />**Description**: AM designator to use throughout Microsoft Dynamics CRM.<br />|
|appdesignerexperienceenabled|Edm.Boolean|**Display Name**: Enable App Designer Experience for this Organization<br />**Description**: Indicates whether the appDesignerExperience is enabled for the organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|autoapplydefaultoncasecreate|Edm.Boolean|**Display Name**: Auto Apply Default Entitlement on Case Create<br />**Description**: Select whether to auto apply the default customer entitlement on case creation.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|autoapplydefaultoncaseupdate|Edm.Boolean|**Display Name**: Auto Apply Default Entitlement on Case Update<br />**Description**: Select whether to auto apply the default customer entitlement on case update.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|autoapplysla|Edm.Boolean|**Display Name**: Is Auto-apply SLA After Manually Over-riding<br />**Description**: Indicates whether to Auto-apply SLA on case record update after SLA was manually applied.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|azureschedulerjobcollectionname|Edm.String|**Display Name**: For internal use only.<br />**Description**: For internal use only.<br />|
|basecurrencyprecision|Edm.Int32|**Display Name**: Base Currency Precision<br />**Description**: Number of decimal places that can be used for the base currency.<br />Read-only<br />|
|basecurrencysymbol|Edm.String|**Display Name**: Base Currency Symbol<br />**Description**: Symbol used for the base currency.<br />Read-only<br />|
|bingmapsapikey|Edm.String|**Display Name**: Bing Maps API Key<br />**Description**: Api Key to be used in requests to Bing Maps services.<br />|
|blockedattachments|Edm.String|**Display Name**: Block Attachments<br />**Description**: Prevent upload or download of certain attachment types that are considered dangerous.<br />|
|bounddashboarddefaultcardexpanded|Edm.Boolean|**Display Name**: Display cards in expanded state for Interactive Dashboard<br />**Description**: Display cards in expanded state for interactive dashboard<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|bulkoperationprefix|Edm.String|**Display Name**: Bulk Operation Prefix<br />**Description**: Prefix used for bulk operation numbering.<br />|
|businessclosurecalendarid|Edm.Guid|**Display Name**: Business Closure Calendar<br />**Description**: Unique identifier of the business closure calendar of organization.<br />|
|calendartype|Edm.Int32|**Display Name**: Calendar Type<br />**Description**: Calendar type for the system. Set to Gregorian US by default.<br />|
|campaignprefix|Edm.String|**Display Name**: Campaign Prefix<br />**Description**: Prefix used for campaign numbering.<br />|
|cascadestatusupdate|Edm.Boolean|**Display Name**: Cascade Status Update<br />**Description**: Flag to cascade Update on incident.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|caseprefix|Edm.String|**Display Name**: Case Prefix<br />**Description**: Prefix to use for all cases throughout Microsoft Dynamics 365.<br />|
|categoryprefix|Edm.String|**Display Name**: Category Prefix<br />**Description**: Type the prefix to use for all categories in Microsoft Dynamics 365.<br />|
|contractprefix|Edm.String|**Display Name**: Contract Prefix<br />**Description**: Prefix to use for all contracts throughout Microsoft Dynamics 365.<br />|
|cortanaproactiveexperienceenabled|Edm.Boolean|**Display Name**: Enable Cortana Proactive Experience Flow processes for this Organization<br />**Description**: Indicates whether the feature CortanaProactiveExperience Flow processes should be enabled for the organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the organization was created.<br />Read-only<br />|
|createproductswithoutparentinactivestate|Edm.Boolean|**Display Name**: Enable Active Initial Product State<br />**Description**: Enable Initial state of newly created products to be Active instead of Draft<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|currencydecimalprecision|Edm.Int32|**Display Name**: Currency Decimal Precision<br />**Description**: Number of decimal places that can be used for currency.<br />|
|currencydisplayoption|Edm.Int32|**Display Name**: Display Currencies Using<br />**Description**: Indicates whether to display money fields with currency code or currency symbol.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Currency symbol</td></tr><tr><td>1</td><td>Currency code</td></tr><tbody></table>|
|currencyformatcode|Edm.Int32|**Display Name**: Currency Format Code<br />**Description**: Information about how currency symbols are placed throughout Microsoft Dynamics CRM.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>$123</td></tr><tr><td>1</td><td>123$</td></tr><tr><td>2</td><td>$ 123</td></tr><tr><td>3</td><td>123 $</td></tr><tbody></table>|
|currencysymbol|Edm.String|**Display Name**: Currency Symbol<br />**Description**: Symbol used for currency throughout Microsoft Dynamics 365.<br />|
|currentbulkoperationnumber|Edm.Int32|**Display Name**: Current Bulk Operation Number<br />**Description**: Current bulk operation number.<br />|
|currentcampaignnumber|Edm.Int32|**Display Name**: Current Campaign Number<br />**Description**: Current campaign number.<br />|
|currentcasenumber|Edm.Int32|**Display Name**: Current Case Number<br />**Description**: First case number to use.<br />|
|currentcategorynumber|Edm.Int32|**Display Name**: Current Category Number<br />**Description**: Enter the first number to use for Categories.<br />|
|currentcontractnumber|Edm.Int32|**Display Name**: Current Contract Number<br />**Description**: First contract number to use.<br />|
|currentimportsequencenumber|Edm.Int32|**Display Name**: Current Import Sequence Number<br />**Description**: Import sequence to use.<br />Read-only<br />|
|currentinvoicenumber|Edm.Int32|**Display Name**: Current Invoice Number<br />**Description**: First invoice number to use.<br />|
|currentkanumber|Edm.Int32|**Display Name**: Current Knowledge Article Number<br />**Description**: Enter the first number to use for knowledge articles.<br />|
|currentkbnumber|Edm.Int32|**Display Name**: Current Article Number<br />**Description**: First article number to use.<br />|
|currentordernumber|Edm.Int32|**Display Name**: Current Order Number<br />**Description**: First order number to use.<br />|
|currentparsedtablenumber|Edm.Int32|**Display Name**: Current Parsed Table Number<br />**Description**: First parsed table number to use.<br />Read-only<br />|
|currentquotenumber|Edm.Int32|**Display Name**: Current Quote Number<br />**Description**: First quote number to use.<br />|
|dateformatcode|Edm.Int32|**Display Name**: Date Format Code<br />**Description**: Information about how the date is displayed throughout Microsoft CRM.<br />|
|dateformatstring|Edm.String|**Display Name**: Date Format String<br />**Description**: String showing how the date is displayed throughout Microsoft CRM.<br />|
|dateseparator|Edm.String|**Display Name**: Date Separator<br />**Description**: Character used to separate the month, the day, and the year in dates throughout Microsoft Dynamics 365.<br />|
|dayssincerecordlastmodifiedmaxvalue|Edm.Int32|**Display Name**: Max value of Days since record last modified<br />**Description**: The maximum value for the Mobile Offline setting Days since record last modified<br />Read-only<br />|
|decimalsymbol|Edm.String|**Display Name**: Decimal Symbol<br />**Description**: Symbol used for decimal in Microsoft Dynamics 365.<br />|
|defaultcountrycode|Edm.String|**Display Name**: Default Country Code<br />**Description**: Text area to enter default country code.<br />|
|defaultcrmcustomname|Edm.String|**Display Name**: Name of the default app<br />**Description**: Name of the default crm custom.<br />|
|defaultemailsettings|Edm.String|**Display Name**: Default Email Settings<br />**Description**: XML string containing the default email settings that are applied when a user or queue is created.<br />|
|defaultrecurrenceendrangetype|Edm.Int32|**Display Name**: Default Recurrence End Range Type<br />**Description**: Type of default recurrence end range date.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>No End Date</td></tr><tr><td>2</td><td>Number of Occurrences</td></tr><tr><td>3</td><td>End By Date</td></tr><tbody></table>|
|defaultthemedata|Edm.String|**Display Name**: Default Theme Data<br />**Description**: Default theme data for the organization.<br />|
|delegatedadminuserid|Edm.Guid|**Display Name**: Delegated Admin<br />**Description**: Unique identifier of the delegated admin user for the organization.<br />|
|disabledreason|Edm.String|**Display Name**: Disabled Reason<br />**Description**: Reason for disabling the organization.<br />Read-only<br />|
|disablesocialcare|Edm.Boolean|**Display Name**: Is Social Care disabled<br />**Description**: Indicates whether Social Care is disabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|discountcalculationmethod|Edm.Int32|**Display Name**: Discount calculation method<br />**Description**: Discount calculation method for the QOOI product.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Line item</td></tr><tr><td>1</td><td>Per unit</td></tr><tbody></table>|
|displaynavigationtour|Edm.Boolean|**Display Name**: Display Navigation Tour<br />**Description**: Indicates whether or not navigation tour is displayed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|emailconnectionchannel|Edm.Int32|**Display Name**: Email Connection Channel<br />**Description**: Select if you want to use the Email Router or server-side synchronization for email processing.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Server-Side Synchronization</td></tr><tr><td>1</td><td>Microsoft Dynamics 365 Email Router</td></tr><tbody></table>|
|emailcorrelationenabled|Edm.Boolean|**Display Name**: Use Email Correlation<br />**Description**: Flag to turn email correlation on or off.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|emailsendpollingperiod|Edm.Int32|**Display Name**: Email Send Polling Frequency<br />**Description**: Normal polling frequency used for sending email in Microsoft Office Outlook.<br />|
|enablebingmapsintegration|Edm.Boolean|**Display Name**: Enable Integration with Bing Maps<br />**Description**: Enable Integration with Bing Maps<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|enableimmersiveskypeintegration|Edm.Boolean|**Display Name**: Enable Integration with Immersive Skype<br />**Description**: Enable Integration with Immersive Skype<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|enablelpauthoring|Edm.Boolean|**Display Name**: Enable Learning Path Authoring<br />**Description**: Select to enable learning path auhtoring.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|enablemicrosoftflowintegration|Edm.Boolean|**Display Name**: Enable Integration with Microsoft Flow<br />**Description**: Enable Integration with Microsoft Flow<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|enablepricingoncreate|Edm.Boolean|**Display Name**: Enable Pricing On Create<br />**Description**: Enable pricing calculations on a Create call.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|enablesmartmatching|Edm.Boolean|**Display Name**: Enable Smart Matching<br />**Description**: Use Smart Matching.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|enforcereadonlyplugins|Edm.Boolean|**Display Name**: Organization setting to enforce read only plugins.<br />**Description**: Organization setting to enforce read only plugins.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: The default image for the entity.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|**Display Name**: Entity Image Id<br />**Description**: For internal use only.<br />Read-only<br />|
|expirechangetrackingindays|Edm.Int32|**Display Name**: Days to Expire Change Tracking Deleted Records<br />**Description**: Maximum number of days to keep change tracking deleted records<br />|
|expiresubscriptionsindays|Edm.Int32|**Display Name**: Days to Expire Subscriptions<br />**Description**: Maximum number of days before deleting inactive subscriptions.<br />|
|externalbaseurl|Edm.String|**Display Name**: External Base URL<br />**Description**: Specify the base URL to use to look for external document suggestions.<br />|
|externalpartycorrelationkeys|Edm.String|**Display Name**: ExternalPartyEnabled Entities correlation Keys<br />**Description**: XML string containing the ExternalPartyEnabled entities correlation keys for association of existing External Party instance entities to newly created IsExternalPartyEnabled entities.For internal use only<br />|
|externalpartyentitysettings|Edm.String|**Display Name**: ExternalPartyEnabled Entities Settings.For internal use only<br />**Description**: XML string containing the ExternalPartyEnabled entities settings.<br />|
|featureset|Edm.String|**Display Name**: Feature Set<br />**Description**: Features to be enabled as an XML BLOB.<br />|
|fiscalcalendarstart|Edm.DateTimeOffset|**Display Name**: Fiscal Calendar Start<br />**Description**: Start date for the fiscal period that is to be used throughout Microsoft CRM.<br />|
|fiscalperiodformat|Edm.String|**Display Name**: Fiscal Period Format<br />**Description**: Information that specifies how the name of the fiscal period is displayed throughout Microsoft CRM.<br />|
|fiscalperiodformatperiod|Edm.Int32|**Display Name**: Format for Fiscal Period<br />**Description**: Format in which the fiscal period will be displayed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Quarter {0}</td></tr><tr><td>2</td><td>Q{0}</td></tr><tr><td>3</td><td>P{0}</td></tr><tr><td>4</td><td>Month {0}</td></tr><tr><td>5</td><td>M{0}</td></tr><tr><td>6</td><td>Semester {0}</td></tr><tr><td>7</td><td>Month Name</td></tr><tbody></table>|
|fiscalperiodtype|Edm.Int32|**Display Name**: Fiscal Period Type<br />**Description**: Type of fiscal period used throughout Microsoft CRM.<br />|
|fiscalyeardisplaycode|Edm.Int32|**Display Name**: Fiscal Year Display<br />**Description**: Information that specifies whether the fiscal year should be displayed based on the start date or the end date of the fiscal year.<br />|
|fiscalyearformat|Edm.String|**Display Name**: Fiscal Year Format<br />**Description**: Information that specifies how the name of the fiscal year is displayed throughout Microsoft CRM.<br />|
|fiscalyearformatprefix|Edm.Int32|**Display Name**: Prefix for Fiscal Year<br />**Description**: Prefix for the display of the fiscal year.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>FY</td></tr><tr><td>2</td><td></td></tr><tbody></table>|
|fiscalyearformatsuffix|Edm.Int32|**Display Name**: Suffix for Fiscal Year<br />**Description**: Suffix for the display of the fiscal year.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>FY</td></tr><tr><td>2</td><td> Fiscal Year</td></tr><tr><td>3</td><td></td></tr><tbody></table>|
|fiscalyearformatyear|Edm.Int32|**Display Name**: Fiscal Year Format Year<br />**Description**: Format for the year.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>YYYY</td></tr><tr><td>2</td><td>YY</td></tr><tr><td>3</td><td>GGYY</td></tr><tbody></table>|
|fiscalyearperiodconnect|Edm.String|**Display Name**: Fiscal Year Period Connector<br />**Description**: Information that specifies how the names of the fiscal year and the fiscal period should be connected when displayed together.<br />|
|fullnameconventioncode|Edm.Int32|**Display Name**: Full Name Display Order<br />**Description**: Order in which names are to be displayed throughout Microsoft CRM.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Last Name, First Name</td></tr><tr><td>1</td><td>First Name</td></tr><tr><td>2</td><td>Last Name, First Name, Middle Initial</td></tr><tr><td>3</td><td>First Name, Middle Initial, Last Name</td></tr><tr><td>4</td><td>Last Name, First Name, Middle Name</td></tr><tr><td>5</td><td>First Name, Middle Name, Last Name</td></tr><tr><td>6</td><td>Last Name, space, First Name</td></tr><tr><td>7</td><td>Last Name, no space, First Name</td></tr><tbody></table>|
|futureexpansionwindow|Edm.Int32|**Display Name**: Future Expansion Window<br />**Description**: Specifies the maximum number of months in future for which the recurring activities can be created.<br />|
|generatealertsforerrors|Edm.Boolean|**Display Name**: Generate Alerts For Errors<br />**Description**: Indicates whether alerts will be generated for errors.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|generatealertsforinformation|Edm.Boolean|**Display Name**: Generate Alerts For Information<br />**Description**: Indicates whether alerts will be generated for information.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|generatealertsforwarnings|Edm.Boolean|**Display Name**: Generate Alerts For Warnings<br />**Description**: Indicates whether alerts will be generated for warnings.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|getstartedpanecontentenabled|Edm.Boolean|**Display Name**: Is Get Started Pane Content Enabled<br />**Description**: Indicates whether Get Started content is enabled for this organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|globalappendurlparametersenabled|Edm.Boolean|**Display Name**: Is AppendUrl Parameters enabled<br />**Description**: Indicates whether the append URL parameters is enabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|globalhelpurl|Edm.String|**Display Name**: Global Help URL.<br />**Description**: URL for the web page global help.<br />|
|globalhelpurlenabled|Edm.Boolean|**Display Name**: Is Customizable Global Help enabled<br />**Description**: Indicates whether the customizable global help is enabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|goalrollupexpirytime|Edm.Int32|**Display Name**: Rollup Expiration Time for Goal<br />**Description**: Number of days after the goal's end date after which the rollup of the goal stops automatically.<br />|
|goalrollupfrequency|Edm.Int32|**Display Name**: Automatic Rollup Frequency for Goal<br />**Description**: Number of hours between automatic rollup jobs .<br />|
|grantaccesstonetworkservice|Edm.Boolean|**Display Name**: Grant Access To Network Service<br />**Description**: For internal use only.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|hashdeltasubjectcount|Edm.Int32|**Display Name**: Hash Delta Subject Count<br />**Description**: Maximum difference allowed between subject keywords count of the email messaged to be correlated<br />|
|hashfilterkeywords|Edm.String|**Display Name**: Hash Filter Keywords<br />**Description**: Filter Subject Keywords<br />|
|hashmaxcount|Edm.Int32|**Display Name**: Hash Max Count<br />**Description**: Maximum number of subject keywords or recipients used for correlation<br />|
|hashminaddresscount|Edm.Int32|**Display Name**: Hash Min Address Count<br />**Description**: Minimum number of recipients required to match for email messaged to be correlated<br />|
|highcontrastthemedata|Edm.String|**Display Name**: High contrast Theme Data<br />**Description**: High contrast theme data for the organization.<br />|
|ignoreinternalemail|Edm.Boolean|**Display Name**: Ignore Internal Email<br />**Description**: Indicates whether incoming email sent by internal Microsoft Dynamics 365 users or queues should be tracked.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|inactivitytimeoutenabled|Edm.Boolean|**Display Name**: Inactivity timeout enabled<br />**Description**: Information that specifies whether Inactivity timeout is enabled<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|inactivitytimeoutinmins|Edm.Int32|**Display Name**: Inactivity timeout in minutes<br />**Description**: Inactivity timeout in minutes<br />|
|inactivitytimeoutreminderinmins|Edm.Int32|**Display Name**: Inactivity timeout reminder in minutes<br />**Description**: Inactivity timeout reminder in minutes<br />|
|incomingemailexchangeemailretrievalbatchsize|Edm.Int32|**Display Name**: Exchange Email Retrieval Batch Size<br />**Description**: Setting for the Async Service Mailbox Queue. Defines the retrieval batch size of exchange server.<br />|
|initialversion|Edm.String|**Display Name**: Initial Version<br />**Description**: Initial version of the organization.<br />|
|integrationuserid|Edm.Guid|**Display Name**: Integration User<br />**Description**: Unique identifier of the integration user for the organization.<br />|
|invoiceprefix|Edm.String|**Display Name**: Invoice Prefix<br />**Description**: Prefix to use for all invoice numbers throughout Microsoft Dynamics 365.<br />|
|isactioncardenabled|Edm.Boolean|**Display Name**: Enable Action Card for this Organization<br />**Description**: Indicates whether the feature Action Card should be enabled for the organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isactionsupportfeatureenabled|Edm.Boolean|**Display Name**: Action Support Feature enabled<br />**Description**: Information that specifies whether Action Support Feature is enabled<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isactivityanalysisenabled|Edm.Boolean|**Display Name**: Enable Relationship Analytics for this Organization<br />**Description**: Indicates whether the feature Relationship Analytics should be enabled for the organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isappmode|Edm.Boolean|**Display Name**: Is Application Mode Enabled<br />**Description**: Indicates whether loading of Microsoft Dynamics 365 in a browser window that does not have address, tool, and menu bars is enabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isappointmentattachmentsyncenabled|Edm.Boolean|**Display Name**: Is Attachment Sync Enabled<br />**Description**: Enable or disable attachments sync for outlook and exchange.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isassignedtaskssyncenabled|Edm.Boolean|**Display Name**: Is Assigned Tasks Sync Enabled<br />**Description**: Enable or disable assigned tasks sync for outlook and exchange.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isauditenabled|Edm.Boolean|**Display Name**: Is Auditing Enabled<br />**Description**: Enable or disable auditing of changes.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isautodatacaptureenabled|Edm.Boolean|**Display Name**: Enable Auto Capture for this Organization<br />**Description**: Indicates whether the feature Auto Capture should be enabled for the organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isautosaveenabled|Edm.Boolean|**Display Name**: Auto Save Enabled<br />**Description**: Information on whether auto save is enabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isbpfentitycustomizationfeatureenabled|Edm.Boolean|**Display Name**: BPF Entity Customization Feature enabled<br />**Description**: Information that specifies whether BPF Entity Customization Feature is enabled<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isconflictdetectionenabledformobileclient|Edm.Boolean|**Display Name**: Is Conflict Detection for Mobile Client enabled<br />**Description**: Information that specifies whether conflict detection for mobile client is enabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|iscontactmailingaddresssyncenabled|Edm.Boolean|**Display Name**: Is Mailing Address Sync Enabled<br />**Description**: Enable or disable mailing address sync for outlook and exchange.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isdefaultcountrycodecheckenabled|Edm.Boolean|**Display Name**: Enable or disable country code selection<br />**Description**: Enable or disable country code selection.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isdelegateaccessenabled|Edm.Boolean|**Display Name**: Is Delegation Access Enabled<br />**Description**: Enable Delegation Access content<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isdelveactionhubintegrationenabled|Edm.Boolean|**Display Name**: Enable Action Hub for this Organization<br />**Description**: Indicates whether the feature Action Hub should be enabled for the organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isdisabled|Edm.Boolean|**Display Name**: Is Organization Disabled<br />**Description**: Information that specifies whether the organization is disabled.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isduplicatedetectionenabled|Edm.Boolean|**Display Name**: Is Duplicate Detection Enabled<br />**Description**: Indicates whether duplicate detection of records is enabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isduplicatedetectionenabledforimport|Edm.Boolean|**Display Name**: Is Duplicate Detection Enabled For Import<br />**Description**: Indicates whether duplicate detection of records during import is enabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isduplicatedetectionenabledforofflinesync|Edm.Boolean|**Display Name**: Is Duplicate Detection Enabled For Offline Synchronization<br />**Description**: Indicates whether duplicate detection of records during offline synchronization is enabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isduplicatedetectionenabledforonlinecreateupdate|Edm.Boolean|**Display Name**: Is Duplicate Detection Enabled for Online Create/Update<br />**Description**: Indicates whether duplicate detection during online create or update is enabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isemailmonitoringallowed|Edm.Boolean|**Display Name**: Allow tracking recipient activity on sent emails<br />**Description**: Allow tracking recipient activity on sent emails.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isemailserverprofilecontentfilteringenabled|Edm.Boolean|**Display Name**: Is Email Server Profile Content Filtering Enabled<br />**Description**: Enable Email Server Profile content filtering<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isenabledforallroles|Edm.Boolean|**Display Name**: option set values for isenabledforallroles<br />**Description**: Indicates whether appmodule is enabled for all roles<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isexternalsearchindexenabled|Edm.Boolean|**Display Name**: Enable external search data syncing<br />**Description**: Select whether data can be synchronized with an external search index.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isfiscalperiodmonthbased|Edm.Boolean|**Display Name**: Is Fiscal Period Monthly<br />**Description**: Indicates whether the fiscal period is displayed as the month number.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isfolderautocreatedonsp|Edm.Boolean|**Display Name**: Automatically create folders<br />**Description**: Select whether folders should be automatically created on SharePoint.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isfolderbasedtrackingenabled|Edm.Boolean|**Display Name**: Is Folder Based Tracking Enabled<br />**Description**: Enable or disable folder based tracking for Server Side Sync.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isfulltextsearchenabled|Edm.Boolean|**Display Name**: Enable Full-text search for Quick Find<br />**Description**: Indicates whether full-text search for Quick Find entities should be enabled for the organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ishierarchicalsecuritymodelenabled|Edm.Boolean|**Display Name**: Enable Hierarchical Security Model<br />**Description**: Enable Hierarchical Security Model<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ismailboxforcedunlockingenabled|Edm.Boolean|**Display Name**: Is Mailbox Forced Unlocking Enabled<br />**Description**: Enable or disable forced unlocking for Server Side Sync mailboxes.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ismailboxinactivebackoffenabled|Edm.Boolean|**Display Name**: Is Mailbox Keep Alive Enabled<br />**Description**: Enable or disable mailbox keep alive for Server Side Sync.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ismobileclientondemandsyncenabled|Edm.Boolean|**Display Name**: Is Mobile Client On Demand Sync enabled<br />**Description**: Information that specifies whether mobile client on demand sync is enabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ismobileofflineenabled|Edm.Boolean|**Display Name**: Enable MobileOffline for this Organization<br />**Description**: Indicates whether the feature MobileOffline should be enabled for the organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isofficegraphenabled|Edm.Boolean|**Display Name**: Enable OfficeGraph for this Organization<br />**Description**: Indicates whether the feature OfficeGraph should be enabled for the organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isonedriveenabled|Edm.Boolean|**Display Name**: Enable One Drive for this Organization<br />**Description**: Indicates whether the feature One Drive should be enabled for the organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ispresenceenabled|Edm.Boolean|**Display Name**: Presence Enabled<br />**Description**: Information on whether IM presence is enabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ispreviewenabledforactioncard|Edm.Boolean|**Display Name**: Enable Preview Action Card feature for this Organization<br />**Description**: Indicates whether the Preview feature for Action Card should be enabled for the organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ispreviewforautocaptureenabled|Edm.Boolean|**Display Name**: Enable Auto Capture for this Organization at Preview Settings<br />**Description**: Indicates whether the feature Auto Capture should be enabled for the organization at Preview Settings.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ispreviewforemailmonitoringallowed|Edm.Boolean|**Display Name**: Allows Preview For Email Monitoring<br />**Description**: Is Preview For Email Monitoring Allowed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isrelationshipinsightsenabled|Edm.Boolean|**Display Name**: Enable Relationship Insights for this Organization<br />**Description**: Indicates whether the feature Relationship Insights should be enabled for the organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isresourcebookingexchangesyncenabled|Edm.Boolean|**Display Name**: Resource booking synchronization enabled<br />**Description**: Indicates if the synchronization of user resource booking with Exchange is enabled at organization level.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|issopintegrationenabled|Edm.Boolean|**Display Name**: Is Sales Order Integration Enabled<br />**Description**: Enable sales order processing integration.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|istextwrapenabled|Edm.Boolean|**Display Name**: Enable Text Wrap<br />**Description**: Information on whether text wrap is enabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isuseraccessauditenabled|Edm.Boolean|**Display Name**: Is User Access Auditing Enabled<br />**Description**: Enable or disable auditing of user access.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|kaprefix|Edm.String|**Display Name**: Knowledge Article Prefix<br />**Description**: Type the prefix to use for all knowledge articles in Microsoft Dynamics 365.<br />|
|kbprefix|Edm.String|**Display Name**: Article Prefix<br />**Description**: Prefix to use for all articles in Microsoft Dynamics 365.<br />|
|kmsettings|Edm.String|**Display Name**: Knowledge Management Settings<br />**Description**: XML string containing the Knowledge Management settings that are applied in Knowledge Management Wizard.<br />|
|languagecode|Edm.Int32|**Display Name**: Language<br />**Description**: Preferred language for the organization.<br />|
|localeid|Edm.Int32|**Display Name**: Locale<br />**Description**: Unique identifier of the locale of the organization.<br />|
|longdateformatcode|Edm.Int32|**Display Name**: Long Date Format<br />**Description**: Information that specifies how the Long Date format is displayed in Microsoft Dynamics 365.<br />|
|mailboxintermittentissueminrange|Edm.Int32|**Display Name**: Lower Threshold For Mailbox Intermittent Issue<br />**Description**: Lower Threshold For Mailbox Intermittent Issue.<br />|
|mailboxpermanentissueminrange|Edm.Int32|**Display Name**: Lower Threshold For Mailbox Permanent Issue.<br />**Description**: Lower Threshold For Mailbox Permanent Issue.<br />|
|maxappointmentdurationdays|Edm.Int32|**Display Name**: Max Appointment Duration<br />**Description**: Maximum number of days an appointment can last.<br />|
|maxconditionsformobileofflinefilters|Edm.Int32|**Display Name**: Maximum number of conditions allowed for mobile offline filters<br />**Description**: Maximum number of conditions allowed for mobile offline filters<br />|
|maxdepthforhierarchicalsecuritymodel|Edm.Int32|**Display Name**: Maximum depth for hierarchy security propagation.<br />**Description**: Maximum depth for hierarchy security propagation.<br />|
|maxfolderbasedtrackingmappings|Edm.Int32|**Display Name**: Max Folder Based Tracking Mappings<br />**Description**: Maximum number of Folder Based Tracking mappings user can add<br />|
|maximumactivebusinessprocessflowsallowedperentity|Edm.Int32|**Display Name**: Maximum active business process flows per entity<br />**Description**: Maximum number of active business process flows allowed per entity<br />|
|maximumdynamicpropertiesallowed|Edm.Int32|**Display Name**: Product Properties Item Limit<br />**Description**: Restrict the maximum number of product properties for a product family/bundle<br />|
|maximumentitieswithactivesla|Edm.Int32|**Display Name**: Maximum number of active SLA allowed per entity in online<br />**Description**: Maximum number of active SLA allowed per entity in online<br />|
|maximumslakpiperentitywithactivesla|Edm.Int32|**Display Name**: Maximum number of active SLA KPI allowed per entity in online<br />**Description**: Maximum number of SLA KPI per active SLA allowed for entity in online<br />|
|maximumtrackingnumber|Edm.Int32|**Display Name**: Max Tracking Number<br />**Description**: Maximum tracking number before recycling takes place.<br />|
|maxproductsinbundle|Edm.Int32|**Display Name**: Bundle Item Limit<br />**Description**: Restrict the maximum no of items in a bundle<br />|
|maxrecordsforexporttoexcel|Edm.Int32|**Display Name**: Max Records For Excel Export<br />**Description**: Maximum number of records that will be exported to a static Microsoft Office Excel worksheet when exporting from the grid.<br />|
|maxrecordsforlookupfilters|Edm.Int32|**Display Name**: Max Records Filter Selection<br />**Description**: Maximum number of lookup and picklist records that can be selected by user for filtering.<br />|
|maxsupportedinternetexplorerversion|Edm.Int32|**Display Name**: Max supported IE version<br />**Description**: The maximum version of IE to run browser emulation for in Outlook client<br />Read-only<br />|
|maxuploadfilesize|Edm.Int32|**Display Name**: Max Upload File Size<br />**Description**: Maximum allowed size of an attachment.<br />|
|maxverboseloggingmailbox|Edm.Int32|**Display Name**: Max No Of Mailboxes To Enable For Verbose Logging<br />**Description**: Maximum number of mailboxes that can be toggled for verbose logging<br />Read-only<br />|
|maxverboseloggingsynccycles|Edm.Int32|**Display Name**: Maximum number of sync cycles for which verbose logging will be enabled by default<br />**Description**: Maximum number of sync cycles for which verbose logging will be enabled by default<br />Read-only<br />|
|microsoftflowenvironment|Edm.String|**Display Name**: Environment selected for Integration with Microsoft Flow<br />**Description**: Environment selected for Integration with Microsoft Flow<br />|
|minaddressbooksyncinterval|Edm.Int32|**Display Name**: Min Address Synchronization Frequency<br />**Description**: Normal polling frequency used for address book synchronization in Microsoft Office Outlook.<br />|
|minofflinesyncinterval|Edm.Int32|**Display Name**: Min Offline Synchronization Frequency<br />**Description**: Normal polling frequency used for background offline synchronization in Microsoft Office Outlook.<br />|
|minoutlooksyncinterval|Edm.Int32|**Display Name**: Min Synchronization Frequency<br />**Description**: Minimum allowed time between scheduled Outlook synchronizations.<br />|
|mobileofflineminlicenseprod|Edm.Int32|**Display Name**: Minimum number of user license required for mobile offline service by production/preview organization<br />**Description**: Minimum number of user license required for mobile offline service by production/preview organization<br />Read-only<br />|
|mobileofflineminlicensetrial|Edm.Int32|**Display Name**: Minimum number of user license required for mobile offline service by trial organization<br />**Description**: Minimum number of user license required for mobile offline service by trial organization<br />Read-only<br />|
|mobileofflinesyncinterval|Edm.Int32|**Display Name**: Sync interval for mobile offline.<br />**Description**: Sync interval for mobile offline.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the organization was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Organization Name<br />**Description**: Name of the organization. The name is set when Microsoft CRM is installed and should not be changed.<br />|
|negativecurrencyformatcode|Edm.Int32|**Display Name**: Negative Currency Format<br />**Description**: Information that specifies how negative currency numbers are displayed throughout Microsoft Dynamics 365.<br />|
|negativeformatcode|Edm.Int32|**Display Name**: Negative Format<br />**Description**: Information that specifies how negative numbers are displayed throughout Microsoft CRM.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Brackets</td></tr><tr><td>1</td><td>Dash</td></tr><tr><td>2</td><td>Dash plus Space</td></tr><tr><td>3</td><td>Trailing Dash</td></tr><tr><td>4</td><td>Space plus Trailing Dash</td></tr><tbody></table>|
|nexttrackingnumber|Edm.Int32|**Display Name**: Next Tracking Number<br />**Description**: Next token to be placed on the subject line of an email message.<br />|
|notifymailboxownerofemailserverlevelalerts|Edm.Boolean|**Display Name**: Notify Mailbox Owner Of Email Server Level Alerts<br />**Description**: Indicates whether mailbox owners will be notified of email server profile level alerts.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|numberformat|Edm.String|**Display Name**: Number Format<br />**Description**: Specification of how numbers are displayed throughout Microsoft CRM.<br />|
|numbergroupformat|Edm.String|**Display Name**: Number Grouping Format<br />**Description**: Specifies how numbers are grouped in Microsoft Dynamics 365.<br />|
|numberseparator|Edm.String|**Display Name**: Number Separator<br />**Description**: Symbol used for number separation in Microsoft Dynamics 365.<br />|
|officeappsautodeploymentenabled|Edm.Boolean|**Display Name**: Enable Office Apps Auto Deployment for this Organization<br />**Description**: Indicates whether the Office Apps auto deployment is enabled for the organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|officegraphdelveurl|Edm.String|**Display Name**: The url to open the Delve<br />**Description**: The url to open the Delve for the organization.<br />|
|oobpricecalculationenabled|Edm.Boolean|**Display Name**: Enable OOB Price calculation<br />**Description**: Enable OOB pricing calculation logic for Opportunity, Quote, Order and Invoice entities.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|orderprefix|Edm.String|**Display Name**: Order Prefix<br />**Description**: Prefix to use for all orders throughout Microsoft Dynamics 365.<br />|
|organizationid|Edm.Guid|**Display Name**: Organization<br />**Description**: Unique identifier of the organization.<br />Read-only<br />|
|orgdborgsettings|Edm.String|**Display Name**: Organization Database Organization Settings<br />**Description**: Organization settings stored in Organization Database.<br />|
|orginsightsenabled|Edm.Boolean|**Display Name**: Enable OrgInsights for this Organization<br />**Description**: Select whether to turn on OrgInsights for the organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|parsedtablecolumnprefix|Edm.String|**Display Name**: Parsed Table Column Prefix<br />**Description**: Prefix used for parsed table columns.<br />Read-only<br />|
|parsedtableprefix|Edm.String|**Display Name**: Parsed Table Prefix<br />**Description**: Prefix used for parsed tables.<br />Read-only<br />|
|pastexpansionwindow|Edm.Int32|**Display Name**: Past Expansion Window<br />**Description**: Specifies the maximum number of months in past for which the recurring activities can be created.<br />|
|picture|Edm.String|**Display Name**: Picture<br />**Description**: For internal use only.<br />|
|pinpointlanguagecode|Edm.Int32||
|plugintracelogsetting|Edm.Int32|**Display Name**: Plug-in Trace Log Setting<br />**Description**: Plug-in Trace Log Setting for the Organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Off</td></tr><tr><td>1</td><td>Exception</td></tr><tr><td>2</td><td>All</td></tr><tbody></table>|
|pmdesignator|Edm.String|**Display Name**: PM Designator<br />**Description**: PM designator to use throughout Microsoft Dynamics 365.<br />|
|postmessagewhitelistdomains|Edm.String|**Display Name**: For internal use only.<br />**Description**: For internal use only.<br />|
|powerbifeatureenabled|Edm.Boolean|**Display Name**: Enable Power BI feature for this Organization<br />**Description**: Indicates whether the Power BI feature should be enabled for the organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Enable</td></tr><tr><td>0</td><td>Disable</td></tr><tbody></table>|
|pricingdecimalprecision|Edm.Int32|**Display Name**: Pricing Decimal Precision<br />**Description**: Number of decimal places that can be used for prices.<br />|
|privacystatementurl|Edm.String|**Display Name**: Privacy Statement URL<br />**Description**: Privacy Statement URL<br />|
|privilegeusergroupid|Edm.Guid|**Display Name**: Privilege User Group<br />**Description**: Unique identifier of the default privilege for users in the organization.<br />|
|privreportinggroupid|Edm.Guid|**Display Name**: Privilege Reporting Group<br />**Description**: For internal use only.<br />|
|privreportinggroupname|Edm.String|**Display Name**: Privilege Reporting Group Name<br />**Description**: For internal use only.<br />|
|productrecommendationsenabled|Edm.Boolean|**Display Name**: Enable Product Recommendations for this Organization<br />**Description**: Select whether to turn on product recommendations for the organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|quickfindrecordlimitenabled|Edm.Boolean|**Display Name**: Quick Find Record Limit Enabled<br />**Description**: Indicates whether a quick find record limit should be enabled for this organization (allows for faster Quick Find queries but prevents overly broad searches).<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|quoteprefix|Edm.String|**Display Name**: Quote Prefix<br />**Description**: Prefix to use for all quotes throughout Microsoft Dynamics 365.<br />|
|recurrencedefaultnumberofoccurrences|Edm.Int32|**Display Name**: Recurrence Default Number of Occurrences<br />**Description**: Specifies the default value for number of occurrences field in the recurrence dialog.<br />|
|recurrenceexpansionjobbatchinterval|Edm.Int32|**Display Name**: Recurrence Expansion Job Batch Interval<br />**Description**: Specifies the interval (in seconds) for pausing expansion job.<br />|
|recurrenceexpansionjobbatchsize|Edm.Int32|**Display Name**: Recurrence Expansion On Demand Job Batch Size<br />**Description**: Specifies the value for number of instances created in on demand job in one shot.<br />|
|recurrenceexpansionsynchcreatemax|Edm.Int32|**Display Name**: Recurrence Expansion Synchronization Create Maximum<br />**Description**: Specifies the maximum number of instances to be created synchronously after creating a recurring appointment.<br />|
|rendersecureiframeforemail|Edm.Boolean|**Display Name**: Render Secure Frame For Email<br />**Description**: Flag to render the body of email in the Web form in an IFRAME with the security='restricted' attribute set. This is additional security but can cause a credentials prompt.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|reportinggroupid|Edm.Guid|**Display Name**: Reporting Group<br />**Description**: For internal use only.<br />|
|reportinggroupname|Edm.String|**Display Name**: Reporting Group Name<br />**Description**: For internal use only.<br />|
|reportscripterrors|Edm.Int32|**Display Name**: Report Script Errors<br />**Description**: Picklist for selecting the organization preference for reporting scripting errors.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>No preference for sending an error report to Microsoft about Microsoft Dynamics 365</td></tr><tr><td>1</td><td>Ask me for permission to send an error report to Microsoft</td></tr><tr><td>2</td><td>Automatically send an error report to Microsoft without asking me for permission</td></tr><tr><td>3</td><td>Never send an error report to Microsoft about Microsoft Dynamics 365</td></tr><tbody></table>|
|requireapprovalforqueueemail|Edm.Boolean|**Display Name**: Is Approval For Queue Email Required<br />**Description**: Indicates whether Send As Other User privilege is enabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|requireapprovalforuseremail|Edm.Boolean|**Display Name**: Is Approval For User Email Required<br />**Description**: Indicates whether Send As Other User privilege is enabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|resolvesimilarunresolvedemailaddress|Edm.Boolean|**Display Name**: Apply same email address to all unresolved matches when you manually resolve it for one<br />**Description**: Apply same email address to all unresolved matches when you manually resolve it for one<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|restrictstatusupdate|Edm.Boolean|**Display Name**: Restrict Status Update<br />**Description**: Flag to restrict Update on incident.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|rierrorstatus|Edm.Int32|**Display Name**: Error status of Relationship Insights provisioning.<br />**Description**: Error status of Relationship Insights provisioning.<br />|
|sampledataimportid|Edm.Guid|**Display Name**: Sample Data Import<br />**Description**: Unique identifier of the sample data import job.<br />|
|schemanameprefix|Edm.String|**Display Name**: Customization Name Prefix<br />**Description**: Prefix used for custom entities and attributes.<br />|
|sessiontimeoutenabled|Edm.Boolean|**Display Name**: Session timeout enabled<br />**Description**: Information that specifies whether session timeout is enabled<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|sessiontimeoutinmins|Edm.Int32|**Display Name**: Session timeout in minutes<br />**Description**: Session timeout in minutes<br />|
|sessiontimeoutreminderinmins|Edm.Int32|**Display Name**: Session timeout reminder in minutes<br />**Description**: Session timeout reminder in minutes<br />|
|sharepointdeploymenttype|Edm.Int32|**Display Name**: Choose SharePoint Deployment Type<br />**Description**: Indicates which SharePoint deployment type is configured for Server to Server. (Online or On-Premises)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Online</td></tr><tr><td>1</td><td>On-Premises</td></tr><tbody></table>|
|sharetopreviousowneronassign|Edm.Boolean|**Display Name**: Share To Previous Owner On Assign<br />**Description**: Information that specifies whether to share to previous owner on assign.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|showkbarticledeprecationnotification|Edm.Boolean|**Display Name**: Show KBArticle deprecation message to user<br />**Description**: Select whether to display a KB article deprecation notification to the user.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|showweeknumber|Edm.Boolean|**Display Name**: Show Week Number<br />**Description**: Information that specifies whether to display the week number in calendar displays throughout Microsoft CRM.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|signupoutlookdownloadfwlink|Edm.String|**Display Name**: CRMForOutlookDownloadURL<br />**Description**: CRM for Outlook Download URL<br />|
|slapausestates|Edm.String|**Display Name**: SLA pause states<br />**Description**: Contains the on hold case status values.<br />|
|socialinsightsenabled|Edm.Boolean|**Display Name**: Social Insights Enabled<br />**Description**: Flag for whether the organization is using Social Insights.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|socialinsightsinstance|Edm.String|**Display Name**: Social Insights instance identifier<br />**Description**: Identifier for the Social Insights instance for the organization.<br />|
|socialinsightstermsaccepted|Edm.Boolean|**Display Name**: Social Insights Terms of Use<br />**Description**: Flag for whether the organization has accepted the Social Insights terms of use.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|sortid|Edm.Int32|**Display Name**: Sort<br />**Description**: For internal use only.<br />|
|sqlaccessgroupid|Edm.Guid|**Display Name**: SQL Access Group<br />**Description**: For internal use only.<br />|
|sqlaccessgroupname|Edm.String|**Display Name**: SQL Access Group Name<br />**Description**: For internal use only.<br />|
|sqmenabled|Edm.Boolean|**Display Name**: Is SQM Enabled<br />**Description**: Setting for SQM data collection, 0 no, 1 yes enabled<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|supportuserid|Edm.Guid|**Display Name**: Support User<br />**Description**: Unique identifier of the support user for the organization.<br />|
|suppresssla|Edm.Boolean|**Display Name**: Is SLA suppressed<br />**Description**: Indicates whether SLA is suppressed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|syncoptinselection|Edm.Boolean|**Display Name**: Enable dynamics 365 azure sync framework for this organization.<br />**Description**: Indicates the selection to use the dynamics 365 azure sync framework or server side sync.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Enable</td></tr><tr><td>0</td><td>Disable</td></tr><tbody></table>|
|syncoptinselectionstatus|Edm.Int32|**Display Name**: Status of opt-in or opt-out operation for dynamics 365 azure sync.<br />**Description**: Indicates the status of the opt-in or opt-out operation for dynamics 365 azure sync.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Processing</td></tr><tr><td>2</td><td>Passed</td></tr><tr><td>3</td><td>Failed</td></tr><tbody></table>|
|systemuserid|Edm.Guid|**Display Name**: System User<br />**Description**: Unique identifier of the system user for the organization.<br />|
|tagmaxaggressivecycles|Edm.Int32|**Display Name**: Auto-Tag Max Cycles<br />**Description**: Maximum number of aggressive polling cycles executed for email auto-tagging when a new email is received.<br />|
|tagpollingperiod|Edm.Int32|**Display Name**: Auto-Tag Interval<br />**Description**: Normal polling frequency used for email receive auto-tagging in outlook.<br />|
|taskbasedflowenabled|Edm.Boolean|**Display Name**: Enable Task Flow processes for this Organization<br />**Description**: Select whether to turn on task flows for the organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|textanalyticsenabled|Edm.Boolean|**Display Name**: Enable Text Analytics for this Organization<br />**Description**: Select whether to turn on text analytics for the organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|timeformatcode|Edm.Int32|**Display Name**: Time Format Code<br />**Description**: Information that specifies how the time is displayed throughout Microsoft CRM.<br />|
|timeformatstring|Edm.String|**Display Name**: Time Format String<br />**Description**: Text for how time is displayed in Microsoft Dynamics 365.<br />|
|timeseparator|Edm.String|**Display Name**: Time Separator<br />**Description**: Text for how the time separator is displayed throughout Microsoft Dynamics 365.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|tokenexpiry|Edm.Int32|**Display Name**: Token Expiration Duration<br />**Description**: Duration used for token expiration.<br />|
|tokenkey|Edm.String|**Display Name**: Token Key<br />**Description**: Token key.<br />|
|trackingprefix|Edm.String|**Display Name**: Tracking Prefix<br />**Description**: History list of tracking token prefixes.<br />|
|trackingtokenidbase|Edm.Int32|**Display Name**: Tracking Token Base<br />**Description**: Base number used to provide separate tracking token identifiers to users belonging to different deployments.<br />|
|trackingtokeniddigits|Edm.Int32|**Display Name**: Tracking Token Digits<br />**Description**: Number of digits used to represent a tracking token identifier.<br />|
|uniquespecifierlength|Edm.Int32|**Display Name**: Unique String Length<br />**Description**: Number of characters appended to invoice, quote, and order numbers.<br />|
|unresolveemailaddressifmultiplematch|Edm.Boolean|**Display Name**: Set To,cc,bcc fields as unresolved if multiple matches are found<br />**Description**: Indicates whether email address should be unresolved if multiple matches are found<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|useinbuiltrulefordefaultpricelistselection|Edm.Boolean|**Display Name**: Use Inbuilt Rule For Default Pricelist Selection<br />**Description**: Flag indicates whether to Use Inbuilt Rule For DefaultPricelist.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|uselegacyrendering|Edm.Boolean|**Display Name**: Legacy Form Rendering<br />**Description**: Select whether to use legacy form rendering.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|usepositionhierarchy|Edm.Boolean|**Display Name**: Use position hierarchy<br />**Description**: Use position hierarchy<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|useraccessauditinginterval|Edm.Int32|**Display Name**: User Authentication Auditing Interval<br />**Description**: The interval at which user access is checked for auditing.<br />|
|usereadform|Edm.Boolean|**Display Name**: Use Read-Optimized Form<br />**Description**: Indicates whether the read-optimized form should be enabled for this organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|usergroupid|Edm.Guid|**Display Name**: User Group<br />**Description**: Unique identifier of the default group of users in the organization.<br />|
|useskypeprotocol|Edm.Boolean|**Display Name**: User Skype Protocol<br />**Description**: Indicates default protocol selected for organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|v3calloutconfighash|Edm.String|**Display Name**: V3 Callout Hash<br />**Description**: Hash of the V3 callout configuration file.<br />Read-only<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the organization.<br />Read-only<br />|
|webresourcehash|Edm.String|**Display Name**: Web resource hash<br />**Description**: Hash value of web resources.<br />|
|weekstartdaycode|Edm.Int32|**Display Name**: Week Start Day Code<br />**Description**: Designated first day of the week throughout Microsoft Dynamics 365.<br />|
|widgetproperties|Edm.String|**Display Name**: For Internal use only.<br />**Description**: For Internal use only.<br />|
|yammergroupid|Edm.Int32|**Display Name**: Yammer Group Id<br />**Description**: Denotes the Yammer group ID<br />|
|yammernetworkpermalink|Edm.String|**Display Name**: Yammer Network Permalink<br />**Description**: Denotes the Yammer network permalink<br />|
|yammeroauthaccesstokenexpired|Edm.Boolean|**Display Name**: Yammer OAuth Access Token Expired<br />**Description**: Denotes whether the OAuth access token for Yammer network has expired<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|yammerpostmethod|Edm.Int32|**Display Name**: Internal Use Only<br />**Description**: Internal Use Only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Public</td></tr><tr><td>1</td><td>Private</td></tr><tbody></table>|
|yearstartweekcode|Edm.Int32|**Display Name**: Year Start Week Code<br />**Description**: Information that specifies how the first week of the year is specified in Microsoft Dynamics 365.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_acknowledgementtemplateid_value|acknowledgementtemplateid<br />|Unique identifier of the template to be used for acknowledgement when a user unsubscribes.|
|_basecurrencyid_value|basecurrencyid<br />|Unique identifier of the base currency of the organization.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the organization.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the organization.|
|_defaultemailserverprofileid_value|defaultemailserverprofileid<br />|Unique identifier of the default email server profile.|
|_defaultmobileofflineprofileid_value|defaultmobileofflineprofileid<br />|Unique identifier of the default mobile offline profile.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the organization.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the organization.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|acknowledgementtemplateid|[template EntityType](template.md)|Template_Organization|
|basecurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|basecurrency_organization|
|businessclosurecalendarid_calendar|[calendar EntityType](calendar.md)|calendar_organization|
|createdby|[systemuser EntityType](systemuser.md)|lk_organizationbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_organization_createdonbehalfby|
|defaultemailserverprofileid|[emailserverprofile EntityType](emailserverprofile.md)|EmailServerProfile_Organization|
|defaultmobileofflineprofileid|[mobileofflineprofile EntityType](mobileofflineprofile.md)|DefaultMobileOfflineProfile_Organization|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_organizationbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_organization_modifiedonbehalfby|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|customcontrol_organization|[customcontrol EntityType](customcontrol.md)|organizationid|  
|customcontroldefaultconfig_organization|[customcontroldefaultconfig EntityType](customcontroldefaultconfig.md)|organizationid|  
|customcontrolresource_organization|[customcontrolresource EntityType](customcontrolresource.md)|organizationid|  
|dynamicproperty_organization|[dynamicproperty EntityType](dynamicproperty.md)|organizationid|  
|DynamicPropertyAssociation_organization|[dynamicpropertyassociation EntityType](dynamicpropertyassociation.md)|organizationid|  
|DynamicPropertyOptionSetItem_organization|[dynamicpropertyoptionsetitem EntityType](dynamicpropertyoptionsetitem.md)|organizationid|  
|entitlementchannel_organization|[entitlementchannel EntityType](entitlementchannel.md)|organizationid|  
|entitlementtemplate_organization|[entitlementtemplate EntityType](entitlementtemplate.md)|organizationid|  
|entitlementtemplatechannel_organization|[entitlementtemplatechannel EntityType](entitlementtemplatechannel.md)|organizationid|  
|languagelocale_organization|[languagelocale EntityType](languagelocale.md)|organizationid|  
|lk_dataperformance_organizationid|[dataperformance EntityType](dataperformance.md)|organizationid|  
|lk_documenttemplatebase_organization|[documenttemplate EntityType](documenttemplate.md)|organizationid|  
|lk_fieldsecurityprofile_organizationid|[fieldsecurityprofile EntityType](fieldsecurityprofile.md)|organizationid|  
|MobileOfflineProfile_organization|[mobileofflineprofile EntityType](mobileofflineprofile.md)|organizationid|  
|MobileOfflineProfileItem_organization|[mobileofflineprofileitem EntityType](mobileofflineprofileitem.md)|organizationid|  
|MobileOfflineProfileItemAssociation_organization|[mobileofflineprofileitemassociation EntityType](mobileofflineprofileitemassociation.md)|organizationid|  
|organization_aciviewmapper|[aciviewmapper EntityType](aciviewmapper.md)|organizationid|  
|organization_adx_entityform|[adx_entityform EntityType](adx_entityform.md)|organizationid|  
|organization_adx_entityformmetadata|[adx_entityformmetadata EntityType](adx_entityformmetadata.md)|organizationid|  
|organization_adx_entitylist|[adx_entitylist EntityType](adx_entitylist.md)|organizationid|  
|organization_adx_entitypermission|[adx_entitypermission EntityType](adx_entitypermission.md)|organizationid|  
|organization_adx_externalidentity|[adx_externalidentity EntityType](adx_externalidentity.md)|organizationid|  
|organization_adx_webformmetadata|[adx_webformmetadata EntityType](adx_webformmetadata.md)|organizationid|  
|organization_adx_webformsession|[adx_webformsession EntityType](adx_webformsession.md)|organizationid|  
|organization_adx_webformstep|[adx_webformstep EntityType](adx_webformstep.md)|organizationid|  
|organization_adx_webnotificationentity|[adx_webnotificationentity EntityType](adx_webnotificationentity.md)|organizationid|  
|organization_adx_websitebinding|[adx_websitebinding EntityType](adx_websitebinding.md)|organizationid|  
|organization_adx_webtemplate|[adx_webtemplate EntityType](adx_webtemplate.md)|organizationid|  
|organization_appconfig|[appconfig EntityType](appconfig.md)|organization_appconfig|  
|organization_appconfiginstance|[appconfiginstance EntityType](appconfiginstance.md)|organization_appconfiginstance_appconfiginstance|  
|organization_appconfigmaster|[appconfigmaster EntityType](appconfigmaster.md)|organization_appconfigmaster_appconfigmaster|  
|organization_appmodule|[appmodule EntityType](appmodule.md)|organization_appmodule_appmodule|  
|Organization_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_organization|  
|Organization_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_organization|  
|organization_business_unit_news_articles|[businessunitnewsarticle EntityType](businessunitnewsarticle.md)|organizationid|  
|organization_business_units|[businessunit EntityType](businessunit.md)|organizationid|  
|organization_calendars|[calendar EntityType](calendar.md)|organizationid|  
|organization_competitors|[competitor EntityType](competitor.md)|organizationid|  
|organization_complexcontrols|[complexcontrol EntityType](complexcontrol.md)|organizationid|  
|organization_connection_roles|[connectionrole EntityType](connectionrole.md)|organizationid|  
|organization_constraint_based_groups|[constraintbasedgroup EntityType](constraintbasedgroup.md)|organizationid|  
|organization_contract_templates|[contracttemplate EntityType](contracttemplate.md)|organizationid|  
|organization_discount_types|[discounttype EntityType](discounttype.md)|organizationid|  
|organization_emailserverprofile|[emailserverprofile EntityType](emailserverprofile.md)|organizationid|  
|organization_equipment|[equipment EntityType](equipment.md)|organizationid|  
|organization_expiredprocess|[expiredprocess EntityType](expiredprocess.md)|organizationid|  
|organization_importjob|[importjob EntityType](importjob.md)|organizationid|  
|organization_kb_article_templates|[kbarticletemplate EntityType](kbarticletemplate.md)|organizationid|  
|organization_kb_articles|[kbarticle EntityType](kbarticle.md)|organizationid|  
|organization_KnowledgeBaseRecord|[knowledgebaserecord EntityType](knowledgebaserecord.md)|organizationid|  
|organization_leadtoopportunitysalesprocess|[leadtoopportunitysalesprocess EntityType](leadtoopportunitysalesprocess.md)|organizationid|  
|organization_mailbox|[mailbox EntityType](mailbox.md)|organizationid|  
|organization_metric|[metric EntityType](metric.md)|organizationid|  
|organization_msdyn_azuredeployment|[msdyn_azuredeployment EntityType](msdyn_azuredeployment.md)|organizationid|  
|organization_msdyn_batchjob|[msdyn_batchjob EntityType](msdyn_batchjob.md)|organizationid|  
|organization_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b|[msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b EntityType](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md)|organizationid|  
|organization_msdyn_contractlineinvoiceschedule|[msdyn_contractlineinvoiceschedule EntityType](msdyn_contractlineinvoiceschedule.md)|organizationid|  
|organization_msdyn_expensecategory|[msdyn_expensecategory EntityType](msdyn_expensecategory.md)|organizationid|  
|organization_msdyn_fieldservicepricelistitem|[msdyn_fieldservicepricelistitem EntityType](msdyn_fieldservicepricelistitem.md)|organizationid|  
|organization_msdyn_fieldservicesystemjob|[msdyn_fieldservicesystemjob EntityType](msdyn_fieldservicesystemjob.md)|organizationid|  
|organization_msdyn_imagetokencache|[msdyn_imagetokencache EntityType](msdyn_imagetokencache.md)|organizationid|  
|organization_msdyn_invoicefrequency|[msdyn_invoicefrequency EntityType](msdyn_invoicefrequency.md)|organizationid|  
|organization_msdyn_invoicefrequencydetail|[msdyn_invoicefrequencydetail EntityType](msdyn_invoicefrequencydetail.md)|organizationid|  
|organization_msdyn_mlresultcache|[msdyn_mlresultcache EntityType](msdyn_mlresultcache.md)|organizationid|  
|organization_msdyn_organizationalunit|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|organizationid|  
|organization_msdyn_processnotes|[msdyn_processnotes EntityType](msdyn_processnotes.md)|organizationid|  
|organization_msdyn_productinventory|[msdyn_productinventory EntityType](msdyn_productinventory.md)|organizationid|  
|organization_msdyn_projectparameter|[msdyn_projectparameter EntityType](msdyn_projectparameter.md)|organizationid|  
|organization_msdyn_projectparameterpricelist|[msdyn_projectparameterpricelist EntityType](msdyn_projectparameterpricelist.md)|organizationid|  
|organization_msdyn_projectteammembersignup|[msdyn_projectteammembersignup EntityType](msdyn_projectteammembersignup.md)|organizationid|  
|organization_msdyn_quotelineinvoiceschedule|[msdyn_quotelineinvoiceschedule EntityType](msdyn_quotelineinvoiceschedule.md)|organizationid|  
|organization_msdyn_resourcecategorypricelevel|[msdyn_resourcecategorypricelevel EntityType](msdyn_resourcecategorypricelevel.md)|organizationid|  
|organization_msdyn_responseblobstore|[msdyn_responseblobstore EntityType](msdyn_responseblobstore.md)|organizationid|  
|organization_msdyn_schedulingparameter|[msdyn_schedulingparameter EntityType](msdyn_schedulingparameter.md)|organizationid|  
|organization_msdyn_transactioncategory|[msdyn_transactioncategory EntityType](msdyn_transactioncategory.md)|organizationid|  
|organization_msdyn_transactioncategoryclassification|[msdyn_transactioncategoryclassification EntityType](msdyn_transactioncategoryclassification.md)|organizationid|  
|organization_msdyn_transactioncategoryhierarchyelement|[msdyn_transactioncategoryhierarchyelement EntityType](msdyn_transactioncategoryhierarchyelement.md)|organizationid|  
|organization_msdyn_transactioncategorypricelevel|[msdyn_transactioncategorypricelevel EntityType](msdyn_transactioncategorypricelevel.md)|organizationid|  
|organization_msdyn_transactiontype|[msdyn_transactiontype EntityType](msdyn_transactiontype.md)|organizationid|  
|organization_msdyn_uniquenumber|[msdyn_uniquenumber EntityType](msdyn_uniquenumber.md)|organizationid|  
|organization_msdyn_vocconfiguration|[msdyn_vocconfiguration EntityType](msdyn_vocconfiguration.md)|organizationid|  
|organization_msdyn_workorderdetailsgenerationqueue|[msdyn_workorderdetailsgenerationqueue EntityType](msdyn_workorderdetailsgenerationqueue.md)|organizationid|  
|organization_msdyncrm_leadtoopportunity|[msdyncrm_leadtoopportunity EntityType](msdyncrm_leadtoopportunity.md)|organizationid|  
|organization_msdyncrm_marketingconfiguration|[msdyncrm_marketingconfiguration EntityType](msdyncrm_marketingconfiguration.md)|organizationid|  
|organization_msdyncrm_marketingpageconfiguration|[msdyncrm_marketingpageconfiguration EntityType](msdyncrm_marketingpageconfiguration.md)|organizationid|  
|organization_msdyncrm_matchingstrategy|[msdyncrm_matchingstrategy EntityType](msdyncrm_matchingstrategy.md)|organizationid|  
|organization_msdyncrm_portalsettings|[msdyncrm_portalsettings EntityType](msdyncrm_portalsettings.md)|organizationid|  
|organization_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99|[msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99 EntityType](msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99.md)|organizationid|  
|organization_msevtmgt_webinarconfiguration|[msevtmgt_webinarconfiguration EntityType](msevtmgt_webinarconfiguration.md)|organizationid|  
|organization_msevtmgt_webinarconsent|[msevtmgt_webinarconsent EntityType](msevtmgt_webinarconsent.md)|organizationid|  
|organization_msevtmgt_webinarprovider|[msevtmgt_webinarprovider EntityType](msevtmgt_webinarprovider.md)|organizationid|  
|organization_msevtmgt_webinartype|[msevtmgt_webinartype EntityType](msevtmgt_webinartype.md)|organizationid|  
|organization_navigationsetting|[navigationsetting EntityType](navigationsetting.md)|organization_navigationsetting_navigationsetting|  
|organization_newprocess|[newprocess EntityType](newprocess.md)|organizationid|  
|organization_officegraphdocument|[officegraphdocument EntityType](officegraphdocument.md)|organizationid|  
|organization_opportunitysalesprocess|[opportunitysalesprocess EntityType](opportunitysalesprocess.md)|organizationid|  
|organization_phonetocaseprocess|[phonetocaseprocess EntityType](phonetocaseprocess.md)|organizationid|  
|organization_pluginassembly|[pluginassembly EntityType](pluginassembly.md)|organizationid|  
|organization_plugintype|[plugintype EntityType](plugintype.md)|organizationid|  
|organization_position|[position EntityType](position.md)|organizationid|  
|organization_post|[post EntityType](post.md)|organizationid|  
|organization_PostComment|[postcomment EntityType](postcomment.md)|organizationid|  
|organization_postlike|[postlike EntityType](postlike.md)|organizationid|  
|organization_price_levels|[pricelevel EntityType](pricelevel.md)|organizationid|  
|organization_ProductAssociation|[productassociation EntityType](productassociation.md)|organizationid|  
|organization_products|[product EntityType](product.md)|organizationid|  
|organization_ProductSubstitute|[productsubstitute EntityType](productsubstitute.md)|organizationid|  
|organization_publisher|[publisher EntityType](publisher.md)|organizationid|  
|organization_queueitems|[queueitem EntityType](queueitem.md)|organizationid|  
|organization_queues|[queue EntityType](queue.md)|organizationid|  
|organization_recommendeddocument|[recommendeddocument EntityType](recommendeddocument.md)|organizationid|  
|organization_resource_groups|[resourcegroup EntityType](resourcegroup.md)|organizationid|  
|organization_resource_specs|[resourcespec EntityType](resourcespec.md)|organizationid|  
|organization_resources|[resource EntityType](resource.md)|organizationid|  
|organization_roles|[role EntityType](role.md)|organizationid_organization|  
|organization_sales_literature|[salesliterature EntityType](salesliterature.md)|organizationid|  
|organization_saved_queries|[savedquery EntityType](savedquery.md)|organizationid|  
|organization_saved_query_visualizations|[savedqueryvisualization EntityType](savedqueryvisualization.md)|organizationid|  
|organization_sdkmessage|[sdkmessage EntityType](sdkmessage.md)|organizationid|  
|organization_sdkmessagefilter|[sdkmessagefilter EntityType](sdkmessagefilter.md)|organizationid|  
|organization_sdkmessageprocessingstep|[sdkmessageprocessingstep EntityType](sdkmessageprocessingstep.md)|organizationid|  
|organization_sdkmessageprocessingstepimage|[sdkmessageprocessingstepimage EntityType](sdkmessageprocessingstepimage.md)|organizationid|  
|organization_sdkmessageprocessingstepsecureconfig|[sdkmessageprocessingstepsecureconfig EntityType](sdkmessageprocessingstepsecureconfig.md)|organizationid|  
|organization_serviceendpoint|[serviceendpoint EntityType](serviceendpoint.md)|organizationid|  
|organization_services|[service EntityType](service.md)|organizationid|  
|organization_similarityrule|[similarityrule EntityType](similarityrule.md)|organizationid|  
|organization_sitemap|[sitemap EntityType](sitemap.md)|organizationid|  
|organization_sites|[site EntityType](site.md)|organizationid_organization|  
|organization_solution|[solution EntityType](solution.md)|organizationid|  
|organization_subjects|[subject EntityType](subject.md)|organizationid|  
|Organization_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_organization_syncerror|  
|organization_system_users|[systemuser EntityType](systemuser.md)|organizationid_organization|  
|organization_systemforms|[systemform EntityType](systemform.md)|organizationid|  
|organization_teams|[team EntityType](team.md)|organizationid_organization|  
|organization_territories|[territory EntityType](territory.md)|organizationid|  
|organization_theme|[theme EntityType](theme.md)|organizationid|  
|organization_tracelog|[tracelog EntityType](tracelog.md)|organizationid|  
|organization_transactioncurrencies|[transactioncurrency EntityType](transactioncurrency.md)|organizationid|  
|organization_translationprocess|[translationprocess EntityType](translationprocess.md)|organizationid|  
|organization_uof_schedules|[uomschedule EntityType](uomschedule.md)|organizationid|  
|organization_webwizard|[webwizard EntityType](webwizard.md)|organizationid|  
|webresource_organization|[webresource EntityType](webresource.md)|organizationid|    

[!INCLUDE[./remarks/organization.md](./remarks/organization.md)]

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