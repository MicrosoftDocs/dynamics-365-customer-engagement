---
title: "Microsoft Dynamics 365 Customer Engagement usersettings EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f93e4d4e-9827-4033-9659-b84232acbcb8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API usersettings entitytype."
---
# usersettings EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/usersettings.md](./descriptions/usersettings.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]usersettingscollection </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>User Settings</td></tr>
<tr><td><b>Primary Key:</b></td><td>systemuserid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET,PATCH</td></tr>
</table>
  
The usersettings EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|addressbooksyncinterval|Edm.Int32|**Description**: Normal polling frequency used for address book synchronization in Microsoft Office Outlook.<br />|
|advancedfindstartupmode|Edm.Int32|**Description**: Default mode, such as simple or detailed, for advanced find.<br />|
|amdesignator|Edm.String|**Description**: AM designator to use in Microsoft Dynamics 365.<br />|
|autocreatecontactonpromote|Edm.Int32|**Description**: Auto-create contact on client promote<br />|
|businessunitid|Edm.Guid|**Description**: Unique identifier of the business unit with which the user is associated.<br />|
|calendartype|Edm.Int32|**Description**: Calendar type for the system. Set to Gregorian US by default.<br />|
|createdon|Edm.DateTimeOffset|**Description**: Date and time when the user settings object was created.<br />Read-only<br />|
|currencyformatcode|Edm.Int32|**Description**: Information about how currency symbols are placed in Microsoft Dynamics 365.<br />|
|currencysymbol|Edm.String|**Description**: Symbol used for currency in Microsoft Dynamics 365.<br />|
|datavalidationmodeforexporttoexcel|Edm.Int32|**Display Name**: Data Validation Mode For Export To Excel<br />**Description**: Information that specifies the level of data validation in excel worksheets exported in a format suitable for import.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Full</td></tr><tr><td>1</td><td>None</td></tr><tbody></table>|
|dateformatcode|Edm.Int32|**Description**: Information about how the date is displayed in Microsoft Dynamics 365.<br />|
|dateformatstring|Edm.String|**Description**: String showing how the date is displayed throughout Microsoft 365.<br />|
|dateseparator|Edm.String|**Description**: Character used to separate the month, the day, and the year in dates in Microsoft Dynamics 365.<br />|
|decimalsymbol|Edm.String|**Description**: Symbol used for decimal in Microsoft Dynamics 365.<br />|
|defaultcalendarview|Edm.Int32|**Description**: Default calendar view for the user.<br />|
|defaultcountrycode|Edm.String|**Display Name**: Default Country Code<br />**Description**: Text area to enter default country code.<br />|
|defaultdashboardid|Edm.Guid|**Description**: Unique identifier of the default dashboard.<br />|
|defaultsearchexperience|Edm.Int32|**Display Name**: Default Search Experience<br />**Description**: Default search experience for the user.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>2</td><td>Use last search</td></tr><tr><td>0</td><td>Relevance search</td></tr><tr><td>1</td><td>Categorized search</td></tr><tr><td>3</td><td>Custom search</td></tr><tbody></table>|
|entityformmode|Edm.Int32|**Display Name**: Form Mode<br />**Description**: Indicates the form mode to be used.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Organization default</td></tr><tr><td>1</td><td>Read-optimized</td></tr><tr><td>2</td><td>Edit</td></tr><tbody></table>|
|fullnameconventioncode|Edm.Int32|**Description**: Order in which names are to be displayed in Microsoft Dynamics 365.<br />|
|getstartedpanecontentenabled|Edm.Boolean|**Description**: Information that specifies whether the Get Started pane in lists is enabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|helplanguageid|Edm.Int32|**Description**: Unique identifier of the Help language.<br />|
|homepagearea|Edm.String|**Description**: Web site home page for the user.<br />|
|homepagelayout|Edm.String|**Description**: Configuration of the home page layout.<br />|
|homepagesubarea|Edm.String|**Description**: Web site page for the user.<br />|
|ignoreunsolicitedemail|Edm.Boolean|**Description**: Information that specifies whether a user account is to ignore unsolicited email (deprecated).<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|incomingemailfilteringmethod|Edm.Int32|**Display Name**: Incoming Email Filtering Method<br />**Description**: Incoming email filtering method.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>All email messages</td></tr><tr><td>1</td><td>Email messages in response to Dynamics 365 email</td></tr><tr><td>2</td><td>Email messages from Dynamics 365 Leads, Contacts and Accounts</td></tr><tr><td>3</td><td>Email messages from Dynamics 365 records that are email enabled</td></tr><tbody></table>|
|isappsforcrmalertdismissed|Edm.Boolean|**Display Name**: Show alert for Apps for 365.<br />**Description**: Show or dismiss alert for Apps for 365.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isautodatacaptureenabled|Edm.Boolean|**Description**: Indicates whether to use the Auto Capture feature enabled or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isdefaultcountrycodecheckenabled|Edm.Boolean|**Display Name**: Enable Default Country Code<br />**Description**: Enable or disable country code selection .<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isduplicatedetectionenabledwhengoingonline|Edm.Boolean|**Description**: Indicates if duplicate detection is enabled when going online.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isguidedhelpenabled|Edm.Boolean|**Display Name**: Enable Default Guided Help<br />**Description**: Enable or disable guided help.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isresourcebookingexchangesyncenabled|Edm.Boolean|**Display Name**: Resource booking synchronization enabled<br />**Description**: Indicates if the synchronization of user resource booking with Exchange is enabled at user level.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Enabled</td></tr><tr><td>0</td><td>Disabled</td></tr><tbody></table>|
|issendasallowed|Edm.Boolean|**Description**: Indicates if send as other user privilege is enabled or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|lastalertsviewedtime|Edm.DateTimeOffset|**Description**: Shows the last time when the traces were read from the database.<br />|
|localeid|Edm.Int32|**Description**: Unique identifier of the user locale.<br />|
|longdateformatcode|Edm.Int32|**Description**: Information that specifies how Long Date is displayed throughout Microsoft 365.<br />|
|modifiedon|Edm.DateTimeOffset|**Description**: Date and time when the user settings object was last modified.<br />Read-only<br />|
|negativecurrencyformatcode|Edm.Int32|**Description**: Information that specifies how negative currency numbers are displayed in Microsoft Dynamics 365.<br />|
|negativeformatcode|Edm.Int32|**Description**: Information that specifies how negative numbers are displayed in Microsoft Dynamics 365.<br />|
|nexttrackingnumber|Edm.Int32|**Description**: Next tracking number.<br />|
|numbergroupformat|Edm.String|**Description**: Information that specifies how numbers are grouped in Microsoft Dynamics 365.<br />|
|numberseparator|Edm.String|**Description**: Symbol used for number separation in Microsoft Dynamics 365.<br />|
|offlinesyncinterval|Edm.Int32|**Description**: Normal polling frequency used for background offline synchronization in Microsoft Office Outlook.<br />|
|outlooksyncinterval|Edm.Int32|**Description**: Normal polling frequency used for record synchronization in Microsoft Office Outlook.<br />|
|paginglimit|Edm.Int32|**Description**: Information that specifies how many items to list on a page in list views.<br />|
|personalizationsettings|Edm.String|**Description**: For internal use only.<br />|
|pmdesignator|Edm.String|**Description**: PM designator to use in Microsoft Dynamics 365.<br />|
|reportscripterrors|Edm.Int32|**Display Name**: Report Script Errors<br />**Description**: Picklist for selecting the user preference for reporting scripting errors.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Ask me for permission to send an error report to Microsoft</td></tr><tr><td>2</td><td>Automatically send an error report to Microsoft without asking me for permission</td></tr><tr><td>3</td><td>Never send an error report to Microsoft about Microsoft Dynamics 365</td></tr><tbody></table>|
|resourcebookingexchangesyncversion|Edm.Int64|**Display Name**: User resource booking synchronization version<br />**Description**: The version number for resource booking synchronization with Exchange.<br />|
|showweeknumber|Edm.Boolean|**Description**: Information that specifies whether to display the week number in calendar displays in Microsoft Dynamics 365.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|splitviewstate|Edm.Boolean|**Description**: For Internal use only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Expanded</td></tr><tr><td>0</td><td>Collapsed</td></tr><tbody></table>|
|synccontactcompany|Edm.Boolean|**Description**: Indicates if the company field in Microsoft Office Outlook items are set during Outlook synchronization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|systemuserid|Edm.Guid|**Description**: Unique identifier of the user.<br />|
|timeformatcode|Edm.Int32|**Description**: Information that specifies how the time is displayed in Microsoft Dynamics 365.<br />|
|timeformatstring|Edm.String|**Description**: Text for how time is displayed in Microsoft Dynamics 365.<br />|
|timeseparator|Edm.String|**Description**: Text for how time is displayed in Microsoft Dynamics 365.<br />|
|timezonebias|Edm.Int32|**Description**: Local time zone adjustment for the user. System calculated based on the time zone selected.<br />|
|timezonecode|Edm.Int32|**Description**: Local time zone for the user.<br />|
|timezonedaylightbias|Edm.Int32|**Description**: Local time zone daylight adjustment for the user. System calculated based on the time zone selected.<br />|
|timezonedaylightday|Edm.Int32|**Description**: Local time zone daylight day for the user. System calculated based on the time zone selected.<br />|
|timezonedaylightdayofweek|Edm.Int32|**Description**: Local time zone daylight day of week for the user. System calculated based on the time zone selected in Options.<br />|
|timezonedaylighthour|Edm.Int32|**Description**: Local time zone daylight hour for the user. System calculated based on the time zone selected.<br />|
|timezonedaylightminute|Edm.Int32|**Description**: Local time zone daylight minute for the user. System calculated based on the time zone selected.<br />|
|timezonedaylightmonth|Edm.Int32|**Description**: Local time zone daylight month for the user. System calculated based on the time zone selected.<br />|
|timezonedaylightsecond|Edm.Int32|**Description**: Local time zone daylight second for the user. System calculated based on the time zone selected.<br />|
|timezonedaylightyear|Edm.Int32|**Description**: Local time zone daylight year for the user. System calculated based on the time zone selected.<br />|
|timezonestandardbias|Edm.Int32|**Description**: Local time zone standard time bias for the user. System calculated based on the time zone selected.<br />|
|timezonestandardday|Edm.Int32|**Description**: Local time zone standard day for the user. System calculated based on the time zone selected.<br />|
|timezonestandarddayofweek|Edm.Int32|**Description**: Local time zone standard day of week for the user. System calculated based on the time zone selected.<br />|
|timezonestandardhour|Edm.Int32|**Description**: Local time zone standard hour for the user. System calculated based on the time zone selected.<br />|
|timezonestandardminute|Edm.Int32|**Description**: Local time zone standard minute for the user. System calculated based on the time zone selected.<br />|
|timezonestandardmonth|Edm.Int32|**Description**: Local time zone standard month for the user. System calculated based on the time zone selected.<br />|
|timezonestandardsecond|Edm.Int32|**Description**: Local time zone standard second for the user. System calculated based on the time zone selected.<br />|
|timezonestandardyear|Edm.Int32|**Description**: Local time zone standard year for the user. System calculated based on the time zone selected.<br />|
|trackingtokenid|Edm.Int32|**Description**: Tracking token ID.<br />|
|uilanguageid|Edm.Int32|**Description**: Unique identifier of the language in which to view the user interface (UI).<br />|
|usecrmformforappointment|Edm.Boolean|**Description**: Indicates whether to use the Microsoft Dynamics 365 appointment form within Microsoft Office Outlook for creating new appointments.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|usecrmformforcontact|Edm.Boolean|**Description**: Indicates whether to use the Microsoft Dynamics 365 contact form within Microsoft Office Outlook for creating new contacts.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|usecrmformforemail|Edm.Boolean|**Description**: Indicates whether to use the Microsoft Dynamics 365 email form within Microsoft Office Outlook for creating new emails.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|usecrmformfortask|Edm.Boolean|**Description**: Indicates whether to use the Microsoft Dynamics 365 task form within Microsoft Office Outlook for creating new tasks.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|useimagestrips|Edm.Boolean|**Description**: Indicates whether image strips are used to render images.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|userprofile|Edm.String|**Description**: Specifies user profile ids in comma separated list.<br />|
|versionnumber|Edm.Int64|Read-only<br />|
|visualizationpanelayout|Edm.Int32|**Display Name**: Visualization Pane Layout.<br />**Description**: The layout of the visualization pane.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Top-bottom</td></tr><tr><td>1</td><td>Side-by-side</td></tr><tbody></table>|
|workdaystarttime|Edm.String|**Description**: Workday start time for the user.<br />|
|workdaystoptime|Edm.String|**Description**: Workday stop time for the user.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the user settings.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the usersettings.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the user settings.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the usersettings.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the default currency of the user.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|businessunitid_businessunit|[businessunit EntityType](businessunit.md)|business_unit_user_settings|
|createdby|[systemuser EntityType](systemuser.md)|lk_usersettingsbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_usersettings_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_usersettingsbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_usersettings_modifiedonbehalfby|
|systemuserid_systemuser|[systemuser EntityType](systemuser.md)|user_settings|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_usersettings|  

[!INCLUDE[./remarks/usersettings.md](./remarks/usersettings.md)]

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