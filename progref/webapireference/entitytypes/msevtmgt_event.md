---
title: "Microsoft Dynamics 365 Customer Engagement msevtmgt_event EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d27fbf96-d39a-4b28-a8b8-11292a826574
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msevtmgt_event entitytype."
---
# msevtmgt_event EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msevtmgt_event.md](./descriptions/msevtmgt_event.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msevtmgt_events </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Event</td></tr>
<tr><td><b>Primary Key:</b></td><td>msevtmgt_eventid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msevtmgt_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msevtmgt_event entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyncrm_eventurlspecified|Edm.Boolean|**Display Name**: Event URL specified<br />**Description**: Determines whether event URL is specified.<br />Computed<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyncrm_sessionscount|Edm.Int32|**Display Name**: Sessions count<br />**Description**: The number of sessions in this event.<br />Computed<br />|
|msdyncrm_sessionscount_date|Edm.DateTimeOffset|**Display Name**: Sessions count (Last Updated On)<br />**Description**: Last Updated time of rollup field Sessions count.<br />Read-only<br />|
|msdyncrm_sessionscount_state|Edm.Int32|**Display Name**: Sessions count (State)<br />**Description**: State of rollup field Sessions count.<br />Read-only<br />|
|msevtmgt_bookedflightreservations|Edm.Int32|**Display Name**: Booked Flight reservations?<br />**Description**: Flight reservations booking status<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_bookrooms|Edm.Int32|**Display Name**: Book Rooms<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_budgetallocated|Edm.Decimal|**Display Name**: Budget Allocated<br />|
|msevtmgt_budgetallocated_base|Edm.Decimal|**Display Name**: Budget Allocated (Base)<br />**Description**: Value of the Budget Allocated in base currency.<br />Read-only<br />|
|msevtmgt_cateringrequired|Edm.Int32|**Display Name**: Catering required?<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>No</td></tr><tr><td>100000002</td><td>Yes</td></tr><tbody></table>|
|msevtmgt_checkincount|Edm.Int32|**Display Name**: Check-in count<br />**Description**: Check-in count<br />|
|msevtmgt_confirmedhotelchoices|Edm.Int32|**Display Name**: Confirmed Hotel choices?<br />**Description**: Hotel choices confirmation status<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_countdownindays|Edm.Int32|**Display Name**: Countdown in Days<br />Read-only<br />|
|msevtmgt_createmarketingcollateral|Edm.Int32|**Display Name**: Create Marketing Collateral<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_definepackagesandpricing|Edm.Int32|**Display Name**: Define Packages and Pricing<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_definesessions|Edm.Int32|**Display Name**: Define Sessions<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_defineteam|Edm.Int32|**Display Name**: Define Team<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_description|Edm.String|**Display Name**: Description<br />|
|msevtmgt_developmarketingplan|Edm.Int32|**Display Name**: Develop Marketing Plan<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_earlybirdcutoffdate|Edm.DateTimeOffset|**Display Name**: Early Bird Cut-off Date<br />|
|msevtmgt_eventdebriefing|Edm.Int32|**Display Name**: Event Debriefing<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_eventenddate|Edm.DateTimeOffset|**Display Name**: Event End Date<br />|
|msevtmgt_eventformat|Edm.Int32|**Display Name**: Event Format<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>On Site</td></tr><tr><td>100000002</td><td>Webinar</td></tr><tr><td>100000003</td><td>Hybrid</td></tr><tbody></table>|
|msevtmgt_eventid|Edm.Guid|**Display Name**: Event<br />**Description**: Unique identifier for entity instances<br />|
|msevtmgt_eventstartdate|Edm.DateTimeOffset|**Display Name**: Event Start Date<br />|
|msevtmgt_eventtimezone|Edm.Int32|**Display Name**: Event Time Zone<br />|
|msevtmgt_eventtimezonename|Edm.String|**Display Name**: Event Time Zone Name<br />|
|msevtmgt_eventtype|Edm.Int32|**Display Name**: Event Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Executive Briefing</td></tr><tr><td>100000002</td><td>Conference</td></tr><tr><td>100000003</td><td>Demonstration</td></tr><tr><td>100000004</td><td>Training</td></tr><tr><td>100000005</td><td>Webcast</td></tr><tbody></table>|
|msevtmgt_eventurl|Edm.String|**Display Name**: Event URL<br />|
|msevtmgt_eventvenuecost|Edm.Decimal|**Display Name**: Event Venue Cost<br />|
|msevtmgt_eventvenuecost_base|Edm.Decimal|**Display Name**: Event Venue Cost (Base)<br />**Description**: Value of the Event Venue Cost in base currency.<br />Read-only<br />|
|msevtmgt_expectedoutcome|Edm.String|**Display Name**: Expected Outcome<br />|
|msevtmgt_followuponleads|Edm.Int32|**Display Name**: Follow up on Leads<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_guestlogistics|Edm.Int32|**Display Name**: Guest Logistics?<br />**Description**: Whether guest logistics are required or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>No</td></tr><tr><td>100000002</td><td>Yes</td></tr><tbody></table>|
|msevtmgt_identifyspeakers|Edm.Int32|**Display Name**: Identify Speakers<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_identifysponsors|Edm.Int32|**Display Name**: Identify Sponsors<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not applicable</td></tr><tr><td>100000002</td><td>Incomplete</td></tr><tr><td>100000003</td><td>Complete</td></tr><tbody></table>|
|msevtmgt_language|Edm.Int32|**Display Name**: Language<br />**Description**: The language of the webinar<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>English</td></tr><tr><td>100000001</td><td>French</td></tr><tr><td>100000002</td><td>German</td></tr><tr><td>100000003</td><td>Spanish</td></tr><tr><td>100000004</td><td>Italian</td></tr><tr><td>100000005</td><td>Russian</td></tr><tr><td>100000006</td><td>Dutch</td></tr><tr><td>100000007</td><td>Turkish</td></tr><tr><td>100000008</td><td>Portuguese</td></tr><tr><td>100000009</td><td>Chinese (Simplified)</td></tr><tr><td>100000013</td><td>Chinese (Traditional)</td></tr><tr><td>100000010</td><td>Japanese</td></tr><tr><td>100000011</td><td>Korean</td></tr><tr><td>100000012</td><td>Hebrew</td></tr><tbody></table>|
|msevtmgt_makepaymentsdue|Edm.Int32|**Display Name**: Make Payments Due<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_manageregistrationcount|Edm.Int32|**Display Name**: Manage Registration Count?<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_maximumeventcapacity|Edm.Int32|**Display Name**: Maximum Event Capacity<br />|
|msevtmgt_maxnumberofregistrations|Edm.Int32|**Display Name**: Max number of registrations<br />|
|msevtmgt_miscellaneouscosts|Edm.Decimal|**Display Name**: Miscellaneous Costs<br />|
|msevtmgt_miscellaneouscosts_base|Edm.Decimal|**Display Name**: Miscellaneous Costs (Base)<br />**Description**: Value of the Miscellaneous Costs in base currency.<br />Read-only<br />|
|msevtmgt_name|Edm.String|**Display Name**: Event Name<br />**Description**: The name of the custom entity.<br />|
|msevtmgt_notifyauthoritiesofevent|Edm.Int32|**Display Name**: Notify Authorities of Event<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_planregistration|Edm.Int32|**Display Name**: Plan Registration<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_presentationmanagerurl|Edm.String|**Display Name**: Presentation Manager URL<br />|
|msevtmgt_primarygoal|Edm.Int32|**Display Name**: Primary Goal<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Marketing</td></tr><tr><td>100000002</td><td>Sales</td></tr><tr><td>100000003</td><td>Education</td></tr><tr><td>100000004</td><td>Morale</td></tr><tbody></table>|
|msevtmgt_publishstatus|Edm.Int32|**Display Name**: Publish Status<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Draft</td></tr><tr><td>100000001</td><td>Ready to publish</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Published</td></tr><tbody></table>|
|msevtmgt_readableeventid|Edm.String|**Display Name**: Readable Event ID<br />|
|msevtmgt_registrationcount|Edm.Int32|**Display Name**: Registration Count<br />**Description**: Registration count of the Event.<br />|
|msevtmgt_registrationstarget|Edm.Int32|**Display Name**: Registrations target<br />|
|msevtmgt_requestsponsorship|Edm.Int32|**Display Name**: Request Sponsorship<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_revenuefromsponsorship|Edm.Decimal|**Display Name**: Revenue from Sponsorship<br />|
|msevtmgt_revenuefromsponsorship_base|Edm.Decimal|**Display Name**: Revenue from Sponsorship (Base)<br />**Description**: Value of the Revenue from Sponsorship in base currency.<br />Read-only<br />|
|msevtmgt_scheduleairportpickups|Edm.Int32|**Display Name**: Schedule airport pickups?<br />**Description**: Airport pickups scheduling status<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_schedulesessions|Edm.Int32|**Display Name**: Schedule Sessions<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_selectspeakers|Edm.Int32|**Display Name**: Select Speakers<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_selectvendors|Edm.Int32|**Display Name**: Select Vendors<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_sendeventinvitation|Edm.Int32|**Display Name**: Send Event invitation<br />**Description**: Event invitation sending status<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_sendmarketingmaterial|Edm.Int32|**Display Name**: Send Marketing Material<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_sendpreeventreminders|Edm.Int32|**Display Name**: Send Pre Event Reminders<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_sendsurveys|Edm.Int32|**Display Name**: Send Surveys<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_sendthankyouemails|Edm.Int32|**Display Name**: Send Thank You Emails<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_targetrevenue|Edm.Decimal|**Display Name**: Target Revenue<br />|
|msevtmgt_targetrevenue_base|Edm.Decimal|**Display Name**: Target Revenue (Base)<br />**Description**: Value of the Target Revenue in base currency.<br />Read-only<br />|
|msevtmgt_teamdebriefing|Edm.Int32|**Display Name**: Team Debriefing<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Not started</td></tr><tr><td>100000002</td><td>In progress</td></tr><tr><td>100000003</td><td>Completed</td></tr><tr><td>100000004</td><td>Not applicable</td></tr><tbody></table>|
|msevtmgt_totalcostofeventsactivities|Edm.Decimal|**Display Name**: Total Cost of Events Activities<br />|
|msevtmgt_totalcostofeventsactivities_base|Edm.Decimal|**Display Name**: Total Cost of Events Activities (Base)<br />**Description**: Value of the Total Cost of Events Activities in base currency.<br />Read-only<br />|
|msevtmgt_totalcostofexternalmembers|Edm.Decimal|**Display Name**: Total cost of External Members<br />|
|msevtmgt_totalcostofexternalmembers_base|Edm.Decimal|**Display Name**: Total cost of External Members (Base)<br />**Description**: Value of the Total cost of External Members in base currency.<br />Read-only<br />|
|msevtmgt_totalregistrationfee|Edm.Decimal|**Display Name**: Total Registration Fee (package cost)<br />|
|msevtmgt_totalregistrationfee_base|Edm.Decimal|**Display Name**: Total Registration Fee (package cost) (Base)<br />**Description**: Value of the Total Registration Fee in base currency.<br />Read-only<br />|
|msevtmgt_totalrevenuefromtheevent|Edm.Decimal|**Display Name**: Total Revenue from the event<br />|
|msevtmgt_totalrevenuefromtheevent_base|Edm.Decimal|**Display Name**: Total Revenue from the event (Base)<br />**Description**: Value of the Total Revenue from the event in base currency.<br />Read-only<br />|
|msevtmgt_waitliststartingpoint|Edm.Int32|**Display Name**: Waitlist Starting Point<br />**Description**: Waitlist Starting Point<br />|
|msevtmgt_waitlistthisevent|Edm.Int32|**Display Name**: Waitlist this Event<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>No</td></tr><tr><td>100000002</td><td>Yes</td></tr><tbody></table>|
|msevtmgt_webinarid|Edm.String|**Display Name**: Webinar ID<br />**Description**: Webinar ID of the Event.<br />|
|msevtmgt_webinarurl|Edm.String|**Display Name**: Webinar URL<br />**Description**: URL of the webinar. This might be URL of external webinar provider.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Event<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Event<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_msevtmgt_primaryvenue_value|msevtmgt_PrimaryVenue<br />||
|_msevtmgt_producer_value|msevtmgt_producer<br />||
|_msevtmgt_transactioncurrencyid_value||Unique identifier of the currency associated with the entity.|
|_msevtmgt_webinarconfigurationid_value|msevtmgt_WebinarConfigurationId<br />|Webinar Configuration|
|_msevtmgt_webinartype_value|msevtmgt_WebinarType<br />||
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_stageid_value|stageid<br />|Contains the id of the stage where the entity is located.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_event_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_event_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_event_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_event_modifiedonbehalfby|
|msevtmgt_PrimaryVenue|[msevtmgt_venue EntityType](msevtmgt_venue.md)|msevtmgt_venue_msevtmgt_event_PrimaryVenue|
|msevtmgt_producer|[msevtmgt_eventteammember EntityType](msevtmgt_eventteammember.md)|msevtmgt_msevtmgt_eventteammember_msevtmgt_event_producer|
|msevtmgt_WebinarConfigurationId|[msevtmgt_webinarconfiguration EntityType](msevtmgt_webinarconfiguration.md)|msevtmgt_webinarconfiguration_msevtmgt_event_Web|
|msevtmgt_WebinarType|[msevtmgt_webinartype EntityType](msevtmgt_webinartype.md)|msevtmgt_msevtmgt_webinartype_msevtmgt_event_WebinarType|
|ownerid|[principal EntityType](principal.md)|owner_msevtmgt_event|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msevtmgt_event|
|owningteam|[team EntityType](team.md)|team_msevtmgt_event|
|owninguser|[systemuser EntityType](systemuser.md)|user_msevtmgt_event|
|stageid|[processstage EntityType](processstage.md)|processstage_msevtmgt_Event|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msevtmgt_Event|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|bpf_msevtmgt_event_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99|[msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99 EntityType](msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99.md)|bpf_msevtmgt_eventid|  
|msevtmgt_Event__SessionTrack|[msevtmgt_sessiontrack EntityType](msevtmgt_sessiontrack.md)|msevtmgt_EventId|  
|msevtmgt_event_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msevtmgt_event|  
|msevtmgt_event_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msevtmgt_event_adx_alertsubscription|  
|msevtmgt_event_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msevtmgt_event_adx_inviteredemption|  
|msevtmgt_event_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msevtmgt_event_adx_portalcomment|  
|msevtmgt_event_Annotations|[annotation EntityType](annotation.md)|objectid_msevtmgt_event|  
|msevtmgt_event_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msevtmgt_event_appointment|  
|msevtmgt_event_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msevtmgt_event|  
|msevtmgt_Event_AttendeePass|[msevtmgt_attendeepass EntityType](msevtmgt_attendeepass.md)|msevtmgt_EventId|  
|msevtmgt_event_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msevtmgt_event|  
|msevtmgt_event_Emails|[email EntityType](email.md)|regardingobjectid_msevtmgt_event_email|  
|msevtmgt_Event_EventRegistration|[msevtmgt_eventregistration EntityType](msevtmgt_eventregistration.md)|msevtmgt_EventId|  
|msevtmgt_event_Faxes|[fax EntityType](fax.md)|regardingobjectid_msevtmgt_event_fax|  
|msevtmgt_event_Letters|[letter EntityType](letter.md)|regardingobjectid_msevtmgt_event_letter|  
|msevtmgt_event_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msevtmgt_event_msdyn_approval|  
|msevtmgt_event_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msevtmgt_event_msdyn_bookingalert|  
|msevtmgt_event_msdyn_survey_EventId|[msdyn_survey EntityType](msdyn_survey.md)|msevtmgt_eventid|  
|msevtmgt_event_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msevtmgt_event_msdyn_surveyinvite|  
|msevtmgt_event_msdyn_surveyresponse_EventId|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msevtmgt_eventId|  
|msevtmgt_event_msevtmgt_checkin_Event|[msevtmgt_checkin EntityType](msevtmgt_checkin.md)|msevtmgt_Event|  
|msevtmgt_event_msevtmgt_pass_Event|[msevtmgt_pass EntityType](msevtmgt_pass.md)|msevtmgt_eventid|  
|msevtmgt_event_msevtmgt_session_Event|[msevtmgt_session EntityType](msevtmgt_session.md)|msevtmgt_Event|  
|msevtmgt_event_msevtmgt_sessionregistration_Event|[msevtmgt_sessionregistration EntityType](msevtmgt_sessionregistration.md)|msevtmgt_Event|  
|msevtmgt_event_msevtmgt_speakerengagement|[msevtmgt_speakerengagement EntityType](msevtmgt_speakerengagement.md)|msevtmgt_event|  
|msevtmgt_Event_msevtmgt_Sponsorship|[msevtmgt_sponsorship EntityType](msevtmgt_sponsorship.md)|msevtmgt_Event|  
|msevtmgt_event_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msevtmgt_event_phonecall|  
|msevtmgt_event_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msevtmgt_event_recurringappointmentmaster|  
|msevtmgt_event_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msevtmgt_event_serviceappointment|  
|msevtmgt_event_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msevtmgt_event_socialactivity|  
|msevtmgt_Event_Speaker|[msevtmgt_speaker EntityType](msevtmgt_speaker.md)|msevtmgt_EventId|  
|msevtmgt_event_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msevtmgt_event|  
|msevtmgt_event_Tasks|[task EntityType](task.md)|regardingobjectid_msevtmgt_event_task|  
|msevtmgt_msevtmgt_event_hotelroomallocation_Event|[msevtmgt_hotelroomallocation EntityType](msevtmgt_hotelroomallocation.md)|msevtmgt_Event|  
|msevtmgt_msevtmgt_event_msevtmgt_eventpurchase|[msevtmgt_eventpurchase EntityType](msevtmgt_eventpurchase.md)|msevtmgt_EventId|  
|msevtmgt_msevtmgt_event_msevtmgt_eventteammember|[msevtmgt_eventteammember EntityType](msevtmgt_eventteammember.md)|msevtmgt_msevtmgt_event_msevtmgt_eventteammember|  

## Operations
The following operations can be used with the msevtmgt_event entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msevtmgt_event entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Marketing Event Management Integration Solution Solution](../solutions/microsoftdynamicsmktevtmgmtlinksolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmktevtmgmtlinksolution.md](../solutions/descriptions/microsoftdynamicsmktevtmgmtlinksolution.md)]|  
|[Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicseventmanagementsolution.md](../solutions/descriptions/microsoftdynamicseventmanagementsolution.md)]|  
|[Event Portal Base Solution](../solutions/eventportallink.md)|[!INCLUDE[../solutions/descriptions/eventportallink.md](../solutions/descriptions/eventportallink.md)]|  
|[Event Management with VoC for Dynamics 365 Solution](../solutions/eventmgmtvoclink.md)|[!INCLUDE[../solutions/descriptions/eventmgmtvoclink.md](../solutions/descriptions/eventmgmtvoclink.md)]|    

[!INCLUDE[./remarks/msevtmgt_event.md](./remarks/msevtmgt_event.md)]

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