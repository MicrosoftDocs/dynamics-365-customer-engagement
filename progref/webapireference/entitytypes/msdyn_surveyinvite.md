---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_surveyinvite EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 9206c930-bc23-428e-ab9b-8f72ae870602
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_surveyinvite entitytype."
---
# msdyn_surveyinvite EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_surveyinvite.md](./descriptions/msdyn_surveyinvite.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_surveyinvites </td></tr>
<tr><td><b>Base Type:</b></td><td>[activitypointer EntityType](activitypointer.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Survey Activity</td></tr>
<tr><td><b>Primary Key:</b></td><td>activityid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>subject</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_surveyinvite entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|activityadditionalparams|Edm.String|**Display Name**: Activity Additional Parameters<br />**Description**: Additional information provided by the external application as JSON. For internal use only.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|activityid|Edm.Guid|**Display Name**: Activity<br />**Description**: Unique identifier of the activity.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|activitytypecode|Edm.String|**Display Name**: Activity Type<br />**Description**: Type of activity.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|actualdurationminutes|Edm.Int32|**Display Name**: Actual Duration<br />**Description**: Actual duration of the activity in minutes.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|actualend|Edm.DateTimeOffset|**Display Name**: Actual End<br />**Description**: Actual end time of the activity.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|actualstart|Edm.DateTimeOffset|**Display Name**: Actual Start<br />**Description**: Actual start time of the activity.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|community|Edm.Int32|**Display Name**: Social Channel<br />**Description**: Shows how contact about the social activity originated, such as from Twitter or Facebook. This field is read-only.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Facebook</td></tr><tr><td>2</td><td>Twitter</td></tr><tr><td>0</td><td>Other</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Date Created<br />**Description**: Date and time when the activity was created.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|deliverylastattemptedon|Edm.DateTimeOffset|**Display Name**: Date Delivery Last Attempted<br />**Description**: Date and time when the delivery of the activity was last attempted.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|deliveryprioritycode|Edm.Int32|**Display Name**: Delivery Priority<br />**Description**: Priority of delivery of the activity to the email server.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Low</td></tr><tr><td>1</td><td>Normal</td></tr><tr><td>2</td><td>High</td></tr><tbody></table>|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the activity.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|exchangeitemid|Edm.String|**Display Name**: Exchange Item ID<br />**Description**: The message id of activity which is returned from Exchange Server.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the activitypointer with respect to the base currency.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|exchangeweblink|Edm.String|**Display Name**: Exchange WebLink<br />**Description**: Shows the web link of Activity of type email.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|instancetypecode|Edm.Int32|**Display Name**: Recurring Instance Type<br />**Description**: Type of instance of a recurring series.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Not Recurring</td></tr><tr><td>1</td><td>Recurring Master</td></tr><tr><td>2</td><td>Recurring Instance</td></tr><tr><td>3</td><td>Recurring Exception</td></tr><tr><td>4</td><td>Recurring Future Exception</td></tr><tbody></table>|
|isbilled|Edm.Boolean|**Display Name**: Is Billed<br />**Description**: Information regarding whether the activity was billed as part of resolving a case.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ismapiprivate|Edm.Boolean|**Display Name**: Is Private<br />**Description**: For internal use only.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isregularactivity|Edm.Boolean|**Display Name**: Is Regular Activity<br />**Description**: Information regarding whether the activity is a regular activity type or event type.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isworkflowcreated|Edm.Boolean|**Display Name**: Is Workflow Created<br />**Description**: Information regarding whether the activity was created from a workflow rule.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|lastonholdtime|Edm.DateTimeOffset|**Display Name**: Last On Hold Time<br />**Description**: Contains the date and time stamp of the last on hold time.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|leftvoicemail|Edm.Boolean|**Display Name**: Left Voice Mail<br />**Description**: Left the voice mail<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Last Updated<br />**Description**: Date and time when activity was last modified.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|msdyn_customerpipe|Edm.String|**Display Name**: Customer Pipe<br />**Description**: Shows the customer pipe.<br />|
|msdyn_datetimepipe|Edm.String|**Display Name**: Date Time Pipe<br />**Description**: Shows the date and time pipe for the survey activity.<br />|
|msdyn_invitationlink|Edm.String|**Display Name**: Invitation Link<br />**Description**: Invitation link to survey specific to the respondent.<br />|
|msdyn_invitationlinktext|Edm.String|**Display Name**: Invitation Link Text<br />**Description**: Type the invitation link text.<br />|
|msdyn_locationpipe|Edm.String|**Display Name**: Location Pipe<br />**Description**: Shows the location pipe for the survey activity.<br />|
|msdyn_originatingemailid|Edm.String|**Display Name**: Originating Email ID<br />**Description**: Shows the email that the survey activity originated from.<br />|
|msdyn_other1pipe|Edm.String|**Display Name**: Other 1 Pipe<br />**Description**: Shows the first pipe that can be used in the survey activity.<br />|
|msdyn_other2pipe|Edm.String|**Display Name**: Other 2 Pipe<br />**Description**: Shows the second pipe that can be used in the survey activity.<br />|
|msdyn_other3pipe|Edm.String|**Display Name**: Other 3 Pipe<br />**Description**: Shows the third pipe that can be used in the survey activity.<br />|
|msdyn_productpipe|Edm.String|**Display Name**: Product Pipe<br />**Description**: Shows the product pipe for the survey activity.<br />|
|msdyn_reminder|Edm.Boolean|**Display Name**: Reminder<br />**Description**: Shows the reminder for the survey activity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_servicepipe|Edm.String|**Display Name**: Service Pipe<br />**Description**: Shows the service pipe for the survey activity.<br />|
|msdyn_stage|Edm.Int32|**Display Name**: Stage<br />**Description**: Shows the stage of the survey activity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Prior</td></tr><tr><td>986540001</td><td>During</td></tr><tr><td>986540002</td><td>Post</td></tr><tbody></table>|
|msdyn_surveyversion|Edm.String|**Display Name**: Survey Version<br />**Description**: Shows the version of the survey activity.<br />|
|msdyn_token|Edm.Int32|**Display Name**: Token<br />**Description**: Shows the token for the survey activity.<br />|
|msdyn_userpipe|Edm.String|**Display Name**: User Pipe<br />**Description**: Shows the user pipe.<br />|
|onholdtime|Edm.Int32|**Display Name**: On Hold Time (Minutes)<br />**Description**: Shows how long, in minutes, that the record was on hold.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|postponeactivityprocessinguntil|Edm.DateTimeOffset|**Display Name**: Delay activity processing until<br />**Description**: For internal use only.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|prioritycode|Edm.Int32|**Display Name**: Priority<br />**Description**: Priority of the activity.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Low</td></tr><tr><td>1</td><td>Normal</td></tr><tr><td>2</td><td>High</td></tr><tbody></table>|
|processid|Edm.Guid|**Display Name**: Process<br />**Description**: Unique identifier of the Process.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|scheduleddurationminutes|Edm.Int32|**Display Name**: Scheduled Duration<br />**Description**: Scheduled duration of the activity, specified in minutes.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|scheduledend|Edm.DateTimeOffset|**Display Name**: Due Date<br />**Description**: Scheduled end time of the activity.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|scheduledstart|Edm.DateTimeOffset|**Display Name**: Start Date<br />**Description**: Scheduled start time of the activity.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|senton|Edm.DateTimeOffset|**Display Name**: Date Sent<br />**Description**: Date and time when the activity was sent.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|seriesid|Edm.Guid|**Display Name**: Series Id<br />**Description**: Uniqueidentifier specifying the id of recurring series of an instance.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|sortdate|Edm.DateTimeOffset|**Display Name**: Sort Date<br />**Description**: Shows the date and time by which the activities are sorted.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|stageid|Edm.Guid|**Display Name**: Process Stage<br />**Description**: Unique identifier of the Stage.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|statecode|Edm.Int32|**Display Name**: Activity Status<br />**Description**: Status of the activity.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Open</td></tr><tr><td>1</td><td>Completed</td></tr><tr><td>2</td><td>Canceled</td></tr><tr><td>3</td><td>Scheduled</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the activity.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Open</td></tr><tr><td>2</td><td>Completed</td></tr><tr><td>3</td><td>Canceled</td></tr><tr><td>986540002</td><td>Not Responded</td></tr><tr><td>4</td><td>Scheduled</td></tr><tr><td>986540000</td><td>Sent</td></tr><tbody></table>|
|subject|Edm.String|**Display Name**: Subject<br />**Description**: Subject associated with the activity.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: For internal use only.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the activity.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value||Unique identifier of the user who created the activity.|
|_createdonbehalfby_value||Unique identifier of the delegate user who created the activitypointer.|
|_modifiedby_value||Unique identifier of user who last modified the activity.|
|_modifiedonbehalfby_value||Unique identifier of the delegate user who last modified the activitypointer.|
|_msdyn_accountid_value|msdyn_AccountId<br />|Shows the account associated with the survey activity.|
|_msdyn_campaign_value|msdyn_Campaign<br />|Shows the campaign associated with the survey activity.|
|_msdyn_closingresponse_value|msdyn_ClosingResponse<br />|Shows the survey response associated with the survey invite.|
|_msdyn_contactid_value|msdyn_ContactId<br />|Shows the contact associated with the survey activity.|
|_msdyn_leadid_value|msdyn_LeadId<br />|Shows the lead associated with the survey activity.|
|_msdyn_originatingemail_value||Shows the email associated with the survey activity.|
|_msdyn_originatingphonecall_value||Phone call that relates to the survey invitation|
|_msdyn_surveyid_value|msdyn_surveyid<br />|Shows the survey associated with the survey invite.|
|_msdyn_user_value|msdyn_User<br />|Shows the user of the service activity.|
|_ownerid_value||Unique identifier of the user or team who owns the activity.|
|_owningbusinessunit_value||Unique identifier of the business unit that owns the activity.|
|_owningteam_value||Unique identifier of the team that owns the activity.|
|_owninguser_value||Unique identifier of the user that owns the activity.|
|_regardingobjectid_value||Unique identifier of the object with which the activity is associated.|
|_sendermailboxid_value||Unique identifier of the mailbox associated with the sender of the email message.|
|_serviceid_value||Unique identifier of an associated service.|
|_slaid_value||Choose the service level agreement (SLA) that you want to apply to the case record.|
|_slainvokedid_value||Last SLA that was applied to this case. This field is for internal use only.|
|_transactioncurrencyid_value||Unique identifier of the currency associated with the activitypointer.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|activityid_msdyn_surveyinvite|[activitypointer EntityType](activitypointer.md)|activity_pointer_msdyn_surveyinvite|
|createdby|[systemuser EntityType](systemuser.md)|lk_activitypointer_createdby|
|createdby_msdyn_surveyinvite|[systemuser EntityType](systemuser.md)|msdyn_surveyinvite_systemuser_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_activitypointer_createdonbehalfby|
|createdonbehalfby_msdyn_surveyinvite|[systemuser EntityType](systemuser.md)|msdyn_surveyinvite_systemuser_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_activitypointer_modifiedby|
|modifiedby_msdyn_surveyinvite|[systemuser EntityType](systemuser.md)|msdyn_surveyinvite_systemuser_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_activitypointer_modifiedonbehalfby|
|modifiedonbehalfby_msdyn_surveyinvite|[systemuser EntityType](systemuser.md)|msdyn_surveyinvite_systemuser_modifiedonbehalfby|
|msdyn_AccountId|[account EntityType](account.md)|msdyn_account_msdyn_surveyinvite_AccountId|
|msdyn_Campaign|[campaign EntityType](campaign.md)|msdyn_campaign_msdyn_surveyinvite_Campaign|
|msdyn_ClosingResponse|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_msdyn_surveyresponse_msdyn_surveyinvite_ClosingResponse|
|msdyn_ContactId|[contact EntityType](contact.md)|msdyn_contact_msdyn_surveyinvite_ContactId|
|msdyn_LeadId|[lead EntityType](lead.md)|msdyn_lead_msdyn_surveyinvite_LeadId|
|msdyn_OriginatingEmail|[email EntityType](email.md)|msdyn_email_msdyn_surveyinvite|
|msdyn_OriginatingPhoneCall|[phonecall EntityType](phonecall.md)|msdyn_phonecall_msdyn_surveyinvite_OriginatingTelephone|
|msdyn_surveyid|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_surveyinvite|
|msdyn_User|[systemuser EntityType](systemuser.md)|msdyn_systemuser_msdyn_surveyinvite_User|
|ownerid|[principal EntityType](principal.md)|owner_activitypointers|
|ownerid_msdyn_surveyinvite|[principal EntityType](principal.md)|msdyn_surveyinvite_owner_ownerid|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_activitypointer|
|owningbusinessunit_msdyn_surveyinvite|[businessunit EntityType](businessunit.md)|msdyn_surveyinvite_businessunit_owningbusinessunit|
|owningteam|[team EntityType](team.md)|team_activity|
|owningteam_msdyn_surveyinvite|[team EntityType](team.md)|msdyn_surveyinvite_team_owningteam|
|owninguser|[systemuser EntityType](systemuser.md)|user_activity|
|owninguser_msdyn_surveyinvite|[systemuser EntityType](systemuser.md)|msdyn_surveyinvite_systemuser_owninguser|
|regardingobjectid_account|[account EntityType](account.md)|Account_ActivityPointers|
|regardingobjectid_account_msdyn_surveyinvite|[account EntityType](account.md)|account_msdyn_surveyinvites|
|regardingobjectid_adx_ad|[adx_ad EntityType](adx_ad.md)|adx_ad_ActivityPointers|
|regardingobjectid_adx_ad_msdyn_surveyinvite|[adx_ad EntityType](adx_ad.md)|adx_ad_msdyn_surveyinvites|
|regardingobjectid_adx_adplacement|[adx_adplacement EntityType](adx_adplacement.md)|adx_adplacement_ActivityPointers|
|regardingobjectid_adx_adplacement_msdyn_surveyinvite|[adx_adplacement EntityType](adx_adplacement.md)|adx_adplacement_msdyn_surveyinvites|
|regardingobjectid_adx_invitation|[adx_invitation EntityType](adx_invitation.md)|adx_invitation_ActivityPointers|
|regardingobjectid_adx_invitation_msdyn_surveyinvite|[adx_invitation EntityType](adx_invitation.md)|adx_invitation_msdyn_surveyinvites|
|regardingobjectid_adx_poll|[adx_poll EntityType](adx_poll.md)|adx_poll_ActivityPointers|
|regardingobjectid_adx_poll_msdyn_surveyinvite|[adx_poll EntityType](adx_poll.md)|adx_poll_msdyn_surveyinvites|
|regardingobjectid_adx_polloption|[adx_polloption EntityType](adx_polloption.md)|adx_polloption_ActivityPointers|
|regardingobjectid_adx_polloption_msdyn_surveyinvite|[adx_polloption EntityType](adx_polloption.md)|adx_polloption_msdyn_surveyinvites|
|regardingobjectid_adx_pollplacement|[adx_pollplacement EntityType](adx_pollplacement.md)|adx_pollplacement_ActivityPointers|
|regardingobjectid_adx_pollplacement_msdyn_surveyinvite|[adx_pollplacement EntityType](adx_pollplacement.md)|adx_pollplacement_msdyn_surveyinvites|
|regardingobjectid_adx_pollsubmission|[adx_pollsubmission EntityType](adx_pollsubmission.md)|adx_pollsubmission_ActivityPointers|
|regardingobjectid_adx_pollsubmission_msdyn_surveyinvite|[adx_pollsubmission EntityType](adx_pollsubmission.md)|adx_pollsubmission_msdyn_surveyinvites|
|regardingobjectid_adx_publishingstatetransitionrule|[adx_publishingstatetransitionrule EntityType](adx_publishingstatetransitionrule.md)|adx_publishingstatetransitionrule_ActivityPointers|
|regardingobjectid_adx_publishingstatetransitionrule_msdyn_surveyinvite|[adx_publishingstatetransitionrule EntityType](adx_publishingstatetransitionrule.md)|adx_publishingstatetransitionrule_msdyn_surveyinvites|
|regardingobjectid_adx_redirect|[adx_redirect EntityType](adx_redirect.md)|adx_redirect_ActivityPointers|
|regardingobjectid_adx_redirect_msdyn_surveyinvite|[adx_redirect EntityType](adx_redirect.md)|adx_redirect_msdyn_surveyinvites|
|regardingobjectid_adx_shortcut|[adx_shortcut EntityType](adx_shortcut.md)|adx_shortcut_ActivityPointers|
|regardingobjectid_adx_shortcut_msdyn_surveyinvite|[adx_shortcut EntityType](adx_shortcut.md)|adx_shortcut_msdyn_surveyinvites|
|regardingobjectid_adx_webpage|[adx_webpage EntityType](adx_webpage.md)|adx_webpage_ActivityPointers|
|regardingobjectid_adx_webpage_msdyn_surveyinvite|[adx_webpage EntityType](adx_webpage.md)|adx_webpage_msdyn_surveyinvites|
|regardingobjectid_adx_website|[adx_website EntityType](adx_website.md)|adx_website_ActivityPointers|
|regardingobjectid_adx_website_msdyn_surveyinvite|[adx_website EntityType](adx_website.md)|adx_website_msdyn_surveyinvites|
|regardingobjectid_bookableresourcebooking|[bookableresourcebooking EntityType](bookableresourcebooking.md)|bookableresourcebooking_ActivityPointers|
|regardingobjectid_bookableresourcebooking_msdyn_surveyinvite|[bookableresourcebooking EntityType](bookableresourcebooking.md)|bookableresourcebooking_msdyn_surveyinvites|
|regardingobjectid_bookableresourcebookingheader|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|bookableresourcebookingheader_ActivityPointers|
|regardingobjectid_bookableresourcebookingheader_msdyn_surveyinvite|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|bookableresourcebookingheader_msdyn_surveyinvites|
|regardingobjectid_bulkoperation|[bulkoperation EntityType](bulkoperation.md)|BulkOperation_ActivityPointers|
|regardingobjectid_bulkoperation_msdyn_surveyinvite|[bulkoperation EntityType](bulkoperation.md)|bulkoperation_msdyn_surveyinvites|
|regardingobjectid_campaign|[campaign EntityType](campaign.md)|Campaign_ActivityPointers|
|regardingobjectid_campaign_msdyn_surveyinvite|[campaign EntityType](campaign.md)|campaign_msdyn_surveyinvites|
|regardingobjectid_campaignactivity|[campaignactivity EntityType](campaignactivity.md)|CampaignActivity_ActivityPointers|
|regardingobjectid_campaignactivity_msdyn_surveyinvite|[campaignactivity EntityType](campaignactivity.md)|campaignactivity_msdyn_surveyinvites|
|regardingobjectid_contact|[contact EntityType](contact.md)|Contact_ActivityPointers|
|regardingobjectid_contact_msdyn_surveyinvite|[contact EntityType](contact.md)|contact_msdyn_surveyinvites|
|regardingobjectid_contract|[contract EntityType](contract.md)|Contract_ActivityPointers|
|regardingobjectid_contract_msdyn_surveyinvite|[contract EntityType](contract.md)|contract_msdyn_surveyinvites|
|regardingobjectid_entitlement|[entitlement EntityType](entitlement.md)|entitlement_ActivityPointers|
|regardingobjectid_entitlement_msdyn_surveyinvite|[entitlement EntityType](entitlement.md)|entitlement_msdyn_surveyinvites|
|regardingobjectid_entitlementtemplate|[entitlementtemplate EntityType](entitlementtemplate.md)|entitlementtemplate_ActivityPointers|
|regardingobjectid_entitlementtemplate_msdyn_surveyinvite|[entitlementtemplate EntityType](entitlementtemplate.md)|entitlementtemplate_msdyn_surveyinvites|
|regardingobjectid_incident|[incident EntityType](incident.md)|Incident_ActivityPointers|
|regardingobjectid_incident_msdyn_surveyinvite|[incident EntityType](incident.md)|incident_msdyn_surveyinvites|
|regardingobjectid_invoice|[invoice EntityType](invoice.md)|Invoice_ActivityPointers|
|regardingobjectid_invoice_msdyn_surveyinvite|[invoice EntityType](invoice.md)|invoice_msdyn_surveyinvites|
|regardingobjectid_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|KnowledgeArticle_ActivityPointers|
|regardingobjectid_knowledgearticle_msdyn_surveyinvite|[knowledgearticle EntityType](knowledgearticle.md)|knowledgearticle_msdyn_surveyinvites|
|regardingobjectid_knowledgebaserecord|[knowledgebaserecord EntityType](knowledgebaserecord.md)|KnowledgeBaseRecord_ActivityPointers|
|regardingobjectid_knowledgebaserecord_msdyn_surveyinvite|[knowledgebaserecord EntityType](knowledgebaserecord.md)|knowledgebaserecord_msdyn_surveyinvites|
|regardingobjectid_lead|[lead EntityType](lead.md)|Lead_ActivityPointers|
|regardingobjectid_lead_msdyn_surveyinvite|[lead EntityType](lead.md)|lead_msdyn_surveyinvites|
|regardingobjectid_msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_agreement_ActivityPointers|
|regardingobjectid_msdyn_agreement_msdyn_surveyinvite|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_agreement_msdyn_surveyinvites|
|regardingobjectid_msdyn_agreementbookingdate|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|msdyn_agreementbookingdate_ActivityPointers|
|regardingobjectid_msdyn_agreementbookingdate_msdyn_surveyinvite|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|msdyn_agreementbookingdate_msdyn_surveyinvites|
|regardingobjectid_msdyn_agreementbookingincident|[msdyn_agreementbookingincident EntityType](msdyn_agreementbookingincident.md)|msdyn_agreementbookingincident_ActivityPointers|
|regardingobjectid_msdyn_agreementbookingincident_msdyn_surveyinvite|[msdyn_agreementbookingincident EntityType](msdyn_agreementbookingincident.md)|msdyn_agreementbookingincident_msdyn_surveyinvites|
|regardingobjectid_msdyn_agreementbookingproduct|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|msdyn_agreementbookingproduct_ActivityPointers|
|regardingobjectid_msdyn_agreementbookingproduct_msdyn_surveyinvite|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|msdyn_agreementbookingproduct_msdyn_surveyinvites|
|regardingobjectid_msdyn_agreementbookingservice|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|msdyn_agreementbookingservice_ActivityPointers|
|regardingobjectid_msdyn_agreementbookingservice_msdyn_surveyinvite|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|msdyn_agreementbookingservice_msdyn_surveyinvites|
|regardingobjectid_msdyn_agreementbookingservicetask|[msdyn_agreementbookingservicetask EntityType](msdyn_agreementbookingservicetask.md)|msdyn_agreementbookingservicetask_ActivityPointers|
|regardingobjectid_msdyn_agreementbookingservicetask_msdyn_surveyinvite|[msdyn_agreementbookingservicetask EntityType](msdyn_agreementbookingservicetask.md)|msdyn_agreementbookingservicetask_msdyn_surveyinvites|
|regardingobjectid_msdyn_agreementbookingsetup|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|msdyn_agreementbookingsetup_ActivityPointers|
|regardingobjectid_msdyn_agreementbookingsetup_msdyn_surveyinvite|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|msdyn_agreementbookingsetup_msdyn_surveyinvites|
|regardingobjectid_msdyn_agreementinvoicedate|[msdyn_agreementinvoicedate EntityType](msdyn_agreementinvoicedate.md)|msdyn_agreementinvoicedate_ActivityPointers|
|regardingobjectid_msdyn_agreementinvoicedate_msdyn_surveyinvite|[msdyn_agreementinvoicedate EntityType](msdyn_agreementinvoicedate.md)|msdyn_agreementinvoicedate_msdyn_surveyinvites|
|regardingobjectid_msdyn_agreementinvoiceproduct|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|msdyn_agreementinvoiceproduct_ActivityPointers|
|regardingobjectid_msdyn_agreementinvoiceproduct_msdyn_surveyinvite|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|msdyn_agreementinvoiceproduct_msdyn_surveyinvites|
|regardingobjectid_msdyn_agreementinvoicesetup|[msdyn_agreementinvoicesetup EntityType](msdyn_agreementinvoicesetup.md)|msdyn_agreementinvoicesetup_ActivityPointers|
|regardingobjectid_msdyn_agreementinvoicesetup_msdyn_surveyinvite|[msdyn_agreementinvoicesetup EntityType](msdyn_agreementinvoicesetup.md)|msdyn_agreementinvoicesetup_msdyn_surveyinvites|
|regardingobjectid_msdyn_bookingalertstatus|[msdyn_bookingalertstatus EntityType](msdyn_bookingalertstatus.md)|msdyn_bookingalertstatus_ActivityPointers|
|regardingobjectid_msdyn_bookingalertstatus_msdyn_surveyinvite|[msdyn_bookingalertstatus EntityType](msdyn_bookingalertstatus.md)|msdyn_bookingalertstatus_msdyn_surveyinvites|
|regardingobjectid_msdyn_bookingrule|[msdyn_bookingrule EntityType](msdyn_bookingrule.md)|msdyn_bookingrule_ActivityPointers|
|regardingobjectid_msdyn_bookingrule_msdyn_surveyinvite|[msdyn_bookingrule EntityType](msdyn_bookingrule.md)|msdyn_bookingrule_msdyn_surveyinvites|
|regardingobjectid_msdyn_bookingtimestamp|[msdyn_bookingtimestamp EntityType](msdyn_bookingtimestamp.md)|msdyn_bookingtimestamp_ActivityPointers|
|regardingobjectid_msdyn_bookingtimestamp_msdyn_surveyinvite|[msdyn_bookingtimestamp EntityType](msdyn_bookingtimestamp.md)|msdyn_bookingtimestamp_msdyn_surveyinvites|
|regardingobjectid_msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_customerasset_ActivityPointers|
|regardingobjectid_msdyn_customerasset_msdyn_surveyinvite|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_customerasset_msdyn_surveyinvites|
|regardingobjectid_msdyn_fieldservicesetting|[msdyn_fieldservicesetting EntityType](msdyn_fieldservicesetting.md)|msdyn_fieldservicesetting_ActivityPointers|
|regardingobjectid_msdyn_fieldservicesetting_msdyn_surveyinvite|[msdyn_fieldservicesetting EntityType](msdyn_fieldservicesetting.md)|msdyn_fieldservicesetting_msdyn_surveyinvites|
|regardingobjectid_msdyn_incidenttypecharacteristic|[msdyn_incidenttypecharacteristic EntityType](msdyn_incidenttypecharacteristic.md)|msdyn_incidenttypecharacteristic_ActivityPointers|
|regardingobjectid_msdyn_incidenttypecharacteristic_msdyn_surveyinvite|[msdyn_incidenttypecharacteristic EntityType](msdyn_incidenttypecharacteristic.md)|msdyn_incidenttypecharacteristic_msdyn_surveyinvites|
|regardingobjectid_msdyn_incidenttypeproduct|[msdyn_incidenttypeproduct EntityType](msdyn_incidenttypeproduct.md)|msdyn_incidenttypeproduct_ActivityPointers|
|regardingobjectid_msdyn_incidenttypeproduct_msdyn_surveyinvite|[msdyn_incidenttypeproduct EntityType](msdyn_incidenttypeproduct.md)|msdyn_incidenttypeproduct_msdyn_surveyinvites|
|regardingobjectid_msdyn_incidenttypeservice|[msdyn_incidenttypeservice EntityType](msdyn_incidenttypeservice.md)|msdyn_incidenttypeservice_ActivityPointers|
|regardingobjectid_msdyn_incidenttypeservice_msdyn_surveyinvite|[msdyn_incidenttypeservice EntityType](msdyn_incidenttypeservice.md)|msdyn_incidenttypeservice_msdyn_surveyinvites|
|regardingobjectid_msdyn_inventoryadjustment|[msdyn_inventoryadjustment EntityType](msdyn_inventoryadjustment.md)|msdyn_inventoryadjustment_ActivityPointers|
|regardingobjectid_msdyn_inventoryadjustment_msdyn_surveyinvite|[msdyn_inventoryadjustment EntityType](msdyn_inventoryadjustment.md)|msdyn_inventoryadjustment_msdyn_surveyinvites|
|regardingobjectid_msdyn_inventoryadjustmentproduct|[msdyn_inventoryadjustmentproduct EntityType](msdyn_inventoryadjustmentproduct.md)|msdyn_inventoryadjustmentproduct_ActivityPointers|
|regardingobjectid_msdyn_inventoryadjustmentproduct_msdyn_surveyinvite|[msdyn_inventoryadjustmentproduct EntityType](msdyn_inventoryadjustmentproduct.md)|msdyn_inventoryadjustmentproduct_msdyn_surveyinvites|
|regardingobjectid_msdyn_inventoryjournal|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|msdyn_inventoryjournal_ActivityPointers|
|regardingobjectid_msdyn_inventoryjournal_msdyn_surveyinvite|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|msdyn_inventoryjournal_msdyn_surveyinvites|
|regardingobjectid_msdyn_inventorytransfer|[msdyn_inventorytransfer EntityType](msdyn_inventorytransfer.md)|msdyn_inventorytransfer_ActivityPointers|
|regardingobjectid_msdyn_inventorytransfer_msdyn_surveyinvite|[msdyn_inventorytransfer EntityType](msdyn_inventorytransfer.md)|msdyn_inventorytransfer_msdyn_surveyinvites|
|regardingobjectid_msdyn_payment|[msdyn_payment EntityType](msdyn_payment.md)|msdyn_payment_ActivityPointers|
|regardingobjectid_msdyn_payment_msdyn_surveyinvite|[msdyn_payment EntityType](msdyn_payment.md)|msdyn_payment_msdyn_surveyinvites|
|regardingobjectid_msdyn_paymentdetail|[msdyn_paymentdetail EntityType](msdyn_paymentdetail.md)|msdyn_paymentdetail_ActivityPointers|
|regardingobjectid_msdyn_paymentdetail_msdyn_surveyinvite|[msdyn_paymentdetail EntityType](msdyn_paymentdetail.md)|msdyn_paymentdetail_msdyn_surveyinvites|
|regardingobjectid_msdyn_paymentmethod|[msdyn_paymentmethod EntityType](msdyn_paymentmethod.md)|msdyn_paymentmethod_ActivityPointers|
|regardingobjectid_msdyn_paymentmethod_msdyn_surveyinvite|[msdyn_paymentmethod EntityType](msdyn_paymentmethod.md)|msdyn_paymentmethod_msdyn_surveyinvites|
|regardingobjectid_msdyn_paymentterm|[msdyn_paymentterm EntityType](msdyn_paymentterm.md)|msdyn_paymentterm_ActivityPointers|
|regardingobjectid_msdyn_paymentterm_msdyn_surveyinvite|[msdyn_paymentterm EntityType](msdyn_paymentterm.md)|msdyn_paymentterm_msdyn_surveyinvites|
|regardingobjectid_msdyn_postalcode|[msdyn_postalcode EntityType](msdyn_postalcode.md)|msdyn_postalcode_ActivityPointers|
|regardingobjectid_msdyn_postalcode_msdyn_surveyinvite|[msdyn_postalcode EntityType](msdyn_postalcode.md)|msdyn_postalcode_msdyn_surveyinvites|
|regardingobjectid_msdyn_processnotes|[msdyn_processnotes EntityType](msdyn_processnotes.md)|msdyn_processnotes_ActivityPointers|
|regardingobjectid_msdyn_processnotes_msdyn_surveyinvite|[msdyn_processnotes EntityType](msdyn_processnotes.md)|msdyn_processnotes_msdyn_surveyinvites|
|regardingobjectid_msdyn_productinventory|[msdyn_productinventory EntityType](msdyn_productinventory.md)|msdyn_productinventory_ActivityPointers|
|regardingobjectid_msdyn_productinventory_msdyn_surveyinvite|[msdyn_productinventory EntityType](msdyn_productinventory.md)|msdyn_productinventory_msdyn_surveyinvites|
|regardingobjectid_msdyn_projectteam|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_projectteam_ActivityPointers|
|regardingobjectid_msdyn_projectteam_msdyn_surveyinvite|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_projectteam_msdyn_surveyinvites|
|regardingobjectid_msdyn_purchaseorder|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|msdyn_purchaseorder_ActivityPointers|
|regardingobjectid_msdyn_purchaseorder_msdyn_surveyinvite|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|msdyn_purchaseorder_msdyn_surveyinvites|
|regardingobjectid_msdyn_purchaseorderbill|[msdyn_purchaseorderbill EntityType](msdyn_purchaseorderbill.md)|msdyn_purchaseorderbill_ActivityPointers|
|regardingobjectid_msdyn_purchaseorderbill_msdyn_surveyinvite|[msdyn_purchaseorderbill EntityType](msdyn_purchaseorderbill.md)|msdyn_purchaseorderbill_msdyn_surveyinvites|
|regardingobjectid_msdyn_purchaseorderproduct|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|msdyn_purchaseorderproduct_ActivityPointers|
|regardingobjectid_msdyn_purchaseorderproduct_msdyn_surveyinvite|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|msdyn_purchaseorderproduct_msdyn_surveyinvites|
|regardingobjectid_msdyn_purchaseorderreceipt|[msdyn_purchaseorderreceipt EntityType](msdyn_purchaseorderreceipt.md)|msdyn_purchaseorderreceipt_ActivityPointers|
|regardingobjectid_msdyn_purchaseorderreceipt_msdyn_surveyinvite|[msdyn_purchaseorderreceipt EntityType](msdyn_purchaseorderreceipt.md)|msdyn_purchaseorderreceipt_msdyn_surveyinvites|
|regardingobjectid_msdyn_purchaseorderreceiptproduct|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|msdyn_purchaseorderreceiptproduct_ActivityPointers|
|regardingobjectid_msdyn_purchaseorderreceiptproduct_msdyn_surveyinvite|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|msdyn_purchaseorderreceiptproduct_msdyn_surveyinvites|
|regardingobjectid_msdyn_purchaseordersubstatus|[msdyn_purchaseordersubstatus EntityType](msdyn_purchaseordersubstatus.md)|msdyn_purchaseordersubstatus_ActivityPointers|
|regardingobjectid_msdyn_purchaseordersubstatus_msdyn_surveyinvite|[msdyn_purchaseordersubstatus EntityType](msdyn_purchaseordersubstatus.md)|msdyn_purchaseordersubstatus_msdyn_surveyinvites|
|regardingobjectid_msdyn_question|[msdyn_question EntityType](msdyn_question.md)|msdyn_question_ActivityPointers|
|regardingobjectid_msdyn_question_msdyn_surveyinvite|[msdyn_question EntityType](msdyn_question.md)|msdyn_question_msdyn_surveyinvites|
|regardingobjectid_msdyn_quotebookingincident|[msdyn_quotebookingincident EntityType](msdyn_quotebookingincident.md)|msdyn_quotebookingincident_ActivityPointers|
|regardingobjectid_msdyn_quotebookingincident_msdyn_surveyinvite|[msdyn_quotebookingincident EntityType](msdyn_quotebookingincident.md)|msdyn_quotebookingincident_msdyn_surveyinvites|
|regardingobjectid_msdyn_quotebookingproduct|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|msdyn_quotebookingproduct_ActivityPointers|
|regardingobjectid_msdyn_quotebookingproduct_msdyn_surveyinvite|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|msdyn_quotebookingproduct_msdyn_surveyinvites|
|regardingobjectid_msdyn_quotebookingservice|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|msdyn_quotebookingservice_ActivityPointers|
|regardingobjectid_msdyn_quotebookingservice_msdyn_surveyinvite|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|msdyn_quotebookingservice_msdyn_surveyinvites|
|regardingobjectid_msdyn_quotebookingservicetask|[msdyn_quotebookingservicetask EntityType](msdyn_quotebookingservicetask.md)|msdyn_quotebookingservicetask_ActivityPointers|
|regardingobjectid_msdyn_quotebookingservicetask_msdyn_surveyinvite|[msdyn_quotebookingservicetask EntityType](msdyn_quotebookingservicetask.md)|msdyn_quotebookingservicetask_msdyn_surveyinvites|
|regardingobjectid_msdyn_resourceterritory|[msdyn_resourceterritory EntityType](msdyn_resourceterritory.md)|msdyn_resourceterritory_ActivityPointers|
|regardingobjectid_msdyn_resourceterritory_msdyn_surveyinvite|[msdyn_resourceterritory EntityType](msdyn_resourceterritory.md)|msdyn_resourceterritory_msdyn_surveyinvites|
|regardingobjectid_msdyn_responseaction|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_responseaction_ActivityPointers|
|regardingobjectid_msdyn_responseaction_msdyn_surveyinvite|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_responseaction_msdyn_surveyinvites|
|regardingobjectid_msdyn_rma|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_rma_ActivityPointers|
|regardingobjectid_msdyn_rma_msdyn_surveyinvite|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_rma_msdyn_surveyinvites|
|regardingobjectid_msdyn_rmaproduct|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|msdyn_rmaproduct_ActivityPointers|
|regardingobjectid_msdyn_rmaproduct_msdyn_surveyinvite|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|msdyn_rmaproduct_msdyn_surveyinvites|
|regardingobjectid_msdyn_rmareceipt|[msdyn_rmareceipt EntityType](msdyn_rmareceipt.md)|msdyn_rmareceipt_ActivityPointers|
|regardingobjectid_msdyn_rmareceipt_msdyn_surveyinvite|[msdyn_rmareceipt EntityType](msdyn_rmareceipt.md)|msdyn_rmareceipt_msdyn_surveyinvites|
|regardingobjectid_msdyn_rmareceiptproduct|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|msdyn_rmareceiptproduct_ActivityPointers|
|regardingobjectid_msdyn_rmareceiptproduct_msdyn_surveyinvite|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|msdyn_rmareceiptproduct_msdyn_surveyinvites|
|regardingobjectid_msdyn_rmasubstatus|[msdyn_rmasubstatus EntityType](msdyn_rmasubstatus.md)|msdyn_rmasubstatus_ActivityPointers|
|regardingobjectid_msdyn_rmasubstatus_msdyn_surveyinvite|[msdyn_rmasubstatus EntityType](msdyn_rmasubstatus.md)|msdyn_rmasubstatus_msdyn_surveyinvites|
|regardingobjectid_msdyn_rtv|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_rtv_ActivityPointers|
|regardingobjectid_msdyn_rtv_msdyn_surveyinvite|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_rtv_msdyn_surveyinvites|
|regardingobjectid_msdyn_rtvproduct|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|msdyn_rtvproduct_ActivityPointers|
|regardingobjectid_msdyn_rtvproduct_msdyn_surveyinvite|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|msdyn_rtvproduct_msdyn_surveyinvites|
|regardingobjectid_msdyn_rtvsubstatus|[msdyn_rtvsubstatus EntityType](msdyn_rtvsubstatus.md)|msdyn_rtvsubstatus_ActivityPointers|
|regardingobjectid_msdyn_rtvsubstatus_msdyn_surveyinvite|[msdyn_rtvsubstatus EntityType](msdyn_rtvsubstatus.md)|msdyn_rtvsubstatus_msdyn_surveyinvites|
|regardingobjectid_msdyn_shipvia|[msdyn_shipvia EntityType](msdyn_shipvia.md)|msdyn_shipvia_ActivityPointers|
|regardingobjectid_msdyn_shipvia_msdyn_surveyinvite|[msdyn_shipvia EntityType](msdyn_shipvia.md)|msdyn_shipvia_msdyn_surveyinvites|
|regardingobjectid_msdyn_survey|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_ActivityPointers|
|regardingobjectid_msdyn_survey_msdyn_surveyinvite|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_msdyn_surveyinvites|
|regardingobjectid_msdyn_surveyresponse|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_surveyresponse_ActivityPointers|
|regardingobjectid_msdyn_surveyresponse_msdyn_surveyinvite|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_surveyresponse_msdyn_surveyinvites|
|regardingobjectid_msdyn_systemuserschedulersetting|[msdyn_systemuserschedulersetting EntityType](msdyn_systemuserschedulersetting.md)|msdyn_systemuserschedulersetting_ActivityPointers|
|regardingobjectid_msdyn_systemuserschedulersetting_msdyn_surveyinvite|[msdyn_systemuserschedulersetting EntityType](msdyn_systemuserschedulersetting.md)|msdyn_systemuserschedulersetting_msdyn_surveyinvites|
|regardingobjectid_msdyn_timegroup|[msdyn_timegroup EntityType](msdyn_timegroup.md)|msdyn_timegroup_ActivityPointers|
|regardingobjectid_msdyn_timegroup_msdyn_surveyinvite|[msdyn_timegroup EntityType](msdyn_timegroup.md)|msdyn_timegroup_msdyn_surveyinvites|
|regardingobjectid_msdyn_timegroupdetail|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|msdyn_timegroupdetail_ActivityPointers|
|regardingobjectid_msdyn_timegroupdetail_msdyn_surveyinvite|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|msdyn_timegroupdetail_msdyn_surveyinvites|
|regardingobjectid_msdyn_timeoffrequest|[msdyn_timeoffrequest EntityType](msdyn_timeoffrequest.md)|msdyn_timeoffrequest_ActivityPointers|
|regardingobjectid_msdyn_timeoffrequest_msdyn_surveyinvite|[msdyn_timeoffrequest EntityType](msdyn_timeoffrequest.md)|msdyn_timeoffrequest_msdyn_surveyinvites|
|regardingobjectid_msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_warehouse_ActivityPointers|
|regardingobjectid_msdyn_warehouse_msdyn_surveyinvite|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_warehouse_msdyn_surveyinvites|
|regardingobjectid_msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_workorder_ActivityPointers|
|regardingobjectid_msdyn_workorder_msdyn_surveyinvite|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_workorder_msdyn_surveyinvites|
|regardingobjectid_msdyn_workordercharacteristic|[msdyn_workordercharacteristic EntityType](msdyn_workordercharacteristic.md)|msdyn_workordercharacteristic_ActivityPointers|
|regardingobjectid_msdyn_workordercharacteristic_msdyn_surveyinvite|[msdyn_workordercharacteristic EntityType](msdyn_workordercharacteristic.md)|msdyn_workordercharacteristic_msdyn_surveyinvites|
|regardingobjectid_msdyn_workorderincident|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|msdyn_workorderincident_ActivityPointers|
|regardingobjectid_msdyn_workorderincident_msdyn_surveyinvite|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|msdyn_workorderincident_msdyn_surveyinvites|
|regardingobjectid_msdyn_workorderproduct|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_workorderproduct_ActivityPointers|
|regardingobjectid_msdyn_workorderproduct_msdyn_surveyinvite|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_workorderproduct_msdyn_surveyinvites|
|regardingobjectid_msdyn_workorderresourcerestriction|[msdyn_workorderresourcerestriction EntityType](msdyn_workorderresourcerestriction.md)|msdyn_workorderresourcerestriction_ActivityPointers|
|regardingobjectid_msdyn_workorderresourcerestriction_msdyn_surveyinvite|[msdyn_workorderresourcerestriction EntityType](msdyn_workorderresourcerestriction.md)|msdyn_workorderresourcerestriction_msdyn_surveyinvites|
|regardingobjectid_msdyn_workorderservice|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_workorderservice_ActivityPointers|
|regardingobjectid_msdyn_workorderservice_msdyn_surveyinvite|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_workorderservice_msdyn_surveyinvites|
|regardingobjectid_msdyn_workorderservicetask|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|msdyn_workorderservicetask_ActivityPointers|
|regardingobjectid_msdyn_workorderservicetask_msdyn_surveyinvite|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|msdyn_workorderservicetask_msdyn_surveyinvites|
|regardingobjectid_msdyncrm_contentsettings|[msdyncrm_contentsettings EntityType](msdyncrm_contentsettings.md)|msdyncrm_contentsettings_ActivityPointers|
|regardingobjectid_msdyncrm_contentsettings_msdyn_surveyinvite|[msdyncrm_contentsettings EntityType](msdyncrm_contentsettings.md)|msdyncrm_contentsettings_msdyn_surveyinvites|
|regardingobjectid_msdyncrm_customerjourney|[msdyncrm_customerjourney EntityType](msdyncrm_customerjourney.md)|msdyncrm_customerjourney_ActivityPointers|
|regardingobjectid_msdyncrm_customerjourney_msdyn_surveyinvite|[msdyncrm_customerjourney EntityType](msdyncrm_customerjourney.md)|msdyncrm_customerjourney_msdyn_surveyinvites|
|regardingobjectid_msdyncrm_leadscoremodel|[msdyncrm_leadscoremodel EntityType](msdyncrm_leadscoremodel.md)|msdyncrm_leadscoremodel_ActivityPointers|
|regardingobjectid_msdyncrm_leadscoremodel_msdyn_surveyinvite|[msdyncrm_leadscoremodel EntityType](msdyncrm_leadscoremodel.md)|msdyncrm_leadscoremodel_msdyn_surveyinvites|
|regardingobjectid_msdyncrm_linkedinaccount|[msdyncrm_linkedinaccount EntityType](msdyncrm_linkedinaccount.md)|msdyncrm_linkedinaccount_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinaccount_msdyn_surveyinvite|[msdyncrm_linkedinaccount EntityType](msdyncrm_linkedinaccount.md)|msdyncrm_linkedinaccount_msdyn_surveyinvites|
|regardingobjectid_msdyncrm_linkedinactivity|[msdyncrm_linkedinactivity EntityType](msdyncrm_linkedinactivity.md)|msdyncrm_linkedinactivity_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinactivity_msdyn_surveyinvite|[msdyncrm_linkedinactivity EntityType](msdyncrm_linkedinactivity.md)|msdyncrm_linkedinactivity_msdyn_surveyinvites|
|regardingobjectid_msdyncrm_linkedinfieldmapping|[msdyncrm_linkedinfieldmapping EntityType](msdyncrm_linkedinfieldmapping.md)|msdyncrm_linkedinfieldmapping_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinfieldmapping_msdyn_surveyinvite|[msdyncrm_linkedinfieldmapping EntityType](msdyncrm_linkedinfieldmapping.md)|msdyncrm_linkedinfieldmapping_msdyn_surveyinvites|
|regardingobjectid_msdyncrm_linkedinform|[msdyncrm_linkedinform EntityType](msdyncrm_linkedinform.md)|msdyncrm_linkedinform_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinform_msdyn_surveyinvite|[msdyncrm_linkedinform EntityType](msdyncrm_linkedinform.md)|msdyncrm_linkedinform_msdyn_surveyinvites|
|regardingobjectid_msdyncrm_linkedinformanswer|[msdyncrm_linkedinformanswer EntityType](msdyncrm_linkedinformanswer.md)|msdyncrm_linkedinformanswer_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinformanswer_msdyn_surveyinvite|[msdyncrm_linkedinformanswer EntityType](msdyncrm_linkedinformanswer.md)|msdyncrm_linkedinformanswer_msdyn_surveyinvites|
|regardingobjectid_msdyncrm_linkedinformquestion|[msdyncrm_linkedinformquestion EntityType](msdyncrm_linkedinformquestion.md)|msdyncrm_linkedinformquestion_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinformquestion_msdyn_surveyinvite|[msdyncrm_linkedinformquestion EntityType](msdyncrm_linkedinformquestion.md)|msdyncrm_linkedinformquestion_msdyn_surveyinvites|
|regardingobjectid_msdyncrm_linkedinformsubmission|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|msdyncrm_linkedinformsubmission_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinformsubmission_msdyn_surveyinvite|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|msdyncrm_linkedinformsubmission_msdyn_surveyinvites|
|regardingobjectid_msdyncrm_linkedinleadmatchingstrategy|[msdyncrm_linkedinleadmatchingstrategy EntityType](msdyncrm_linkedinleadmatchingstrategy.md)|msdyncrm_linkedinleadmatchingstrategy_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinleadmatchingstrategy_msdyn_surveyinvite|[msdyncrm_linkedinleadmatchingstrategy EntityType](msdyncrm_linkedinleadmatchingstrategy.md)|msdyncrm_linkedinleadmatchingstrategy_msdyn_surveyinvites|
|regardingobjectid_msdyncrm_linkedinuserprofile|[msdyncrm_linkedinuserprofile EntityType](msdyncrm_linkedinuserprofile.md)|msdyncrm_linkedinuserprofile_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinuserprofile_msdyn_surveyinvite|[msdyncrm_linkedinuserprofile EntityType](msdyncrm_linkedinuserprofile.md)|msdyncrm_linkedinuserprofile_msdyn_surveyinvites|
|regardingobjectid_msdyncrm_marketingdynamiccontentmetadata|[msdyncrm_marketingdynamiccontentmetadata EntityType](msdyncrm_marketingdynamiccontentmetadata.md)|msdyncrm_marketingdynamiccontentmetadata_ActivityPointers|
|regardingobjectid_msdyncrm_marketingdynamiccontentmetadata_msdyn_surveyinvite|[msdyncrm_marketingdynamiccontentmetadata EntityType](msdyncrm_marketingdynamiccontentmetadata.md)|msdyncrm_marketingdynamiccontentmetadata_msdyn_surveyinvites|
|regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata|[msdyncrm_marketingemaildynamiccontentmetadata EntityType](msdyncrm_marketingemaildynamiccontentmetadata.md)|msdyncrm_marketingemaildynamiccontentmetadata_ActivityPointers|
|regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata_msdyn_surveyinvite|[msdyncrm_marketingemaildynamiccontentmetadata EntityType](msdyncrm_marketingemaildynamiccontentmetadata.md)|msdyncrm_marketingemaildynamiccontentmetadata_msdyn_surveyinvites|
|regardingobjectid_msdyncrm_marketingemailtestsend|[msdyncrm_marketingemailtestsend EntityType](msdyncrm_marketingemailtestsend.md)|msdyncrm_marketingemailtestsend_ActivityPointers|
|regardingobjectid_msdyncrm_marketingemailtestsend_msdyn_surveyinvite|[msdyncrm_marketingemailtestsend EntityType](msdyncrm_marketingemailtestsend.md)|msdyncrm_marketingemailtestsend_msdyn_surveyinvites|
|regardingobjectid_msdyncrm_uicconfig|[msdyncrm_uicconfig EntityType](msdyncrm_uicconfig.md)|msdyncrm_uicconfig_ActivityPointers|
|regardingobjectid_msdyncrm_uicconfig_msdyn_surveyinvite|[msdyncrm_uicconfig EntityType](msdyncrm_uicconfig.md)|msdyncrm_uicconfig_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_checkin|[msevtmgt_checkin EntityType](msevtmgt_checkin.md)|msevtmgt_checkin_ActivityPointers|
|regardingobjectid_msevtmgt_checkin_msdyn_surveyinvite|[msevtmgt_checkin EntityType](msevtmgt_checkin.md)|msevtmgt_checkin_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_event|[msevtmgt_event EntityType](msevtmgt_event.md)|msevtmgt_event_ActivityPointers|
|regardingobjectid_msevtmgt_event_msdyn_surveyinvite|[msevtmgt_event EntityType](msevtmgt_event.md)|msevtmgt_event_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_eventpurchase|[msevtmgt_eventpurchase EntityType](msevtmgt_eventpurchase.md)|msevtmgt_eventpurchase_ActivityPointers|
|regardingobjectid_msevtmgt_eventpurchase_msdyn_surveyinvite|[msevtmgt_eventpurchase EntityType](msevtmgt_eventpurchase.md)|msevtmgt_eventpurchase_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_eventpurchaseattendee|[msevtmgt_eventpurchaseattendee EntityType](msevtmgt_eventpurchaseattendee.md)|msevtmgt_eventpurchaseattendee_ActivityPointers|
|regardingobjectid_msevtmgt_eventpurchaseattendee_msdyn_surveyinvite|[msevtmgt_eventpurchaseattendee EntityType](msevtmgt_eventpurchaseattendee.md)|msevtmgt_eventpurchaseattendee_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_eventpurchasepass|[msevtmgt_eventpurchasepass EntityType](msevtmgt_eventpurchasepass.md)|msevtmgt_eventpurchasepass_ActivityPointers|
|regardingobjectid_msevtmgt_eventpurchasepass_msdyn_surveyinvite|[msevtmgt_eventpurchasepass EntityType](msevtmgt_eventpurchasepass.md)|msevtmgt_eventpurchasepass_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_eventregistration|[msevtmgt_eventregistration EntityType](msevtmgt_eventregistration.md)|msevtmgt_eventregistration_ActivityPointers|
|regardingobjectid_msevtmgt_eventregistration_msdyn_surveyinvite|[msevtmgt_eventregistration EntityType](msevtmgt_eventregistration.md)|msevtmgt_eventregistration_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_hotel|[msevtmgt_hotel EntityType](msevtmgt_hotel.md)|msevtmgt_hotel_ActivityPointers|
|regardingobjectid_msevtmgt_hotel_msdyn_surveyinvite|[msevtmgt_hotel EntityType](msevtmgt_hotel.md)|msevtmgt_hotel_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_hotelroomallocation|[msevtmgt_hotelroomallocation EntityType](msevtmgt_hotelroomallocation.md)|msevtmgt_hotelroomallocation_ActivityPointers|
|regardingobjectid_msevtmgt_hotelroomallocation_msdyn_surveyinvite|[msevtmgt_hotelroomallocation EntityType](msevtmgt_hotelroomallocation.md)|msevtmgt_hotelroomallocation_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_hotelroomreservation|[msevtmgt_hotelroomreservation EntityType](msevtmgt_hotelroomreservation.md)|msevtmgt_hotelroomreservation_ActivityPointers|
|regardingobjectid_msevtmgt_hotelroomreservation_msdyn_surveyinvite|[msevtmgt_hotelroomreservation EntityType](msevtmgt_hotelroomreservation.md)|msevtmgt_hotelroomreservation_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_layout|[msevtmgt_layout EntityType](msevtmgt_layout.md)|msevtmgt_layout_ActivityPointers|
|regardingobjectid_msevtmgt_layout_msdyn_surveyinvite|[msevtmgt_layout EntityType](msevtmgt_layout.md)|msevtmgt_layout_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_room|[msevtmgt_room EntityType](msevtmgt_room.md)|msevtmgt_room_ActivityPointers|
|regardingobjectid_msevtmgt_room_msdyn_surveyinvite|[msevtmgt_room EntityType](msevtmgt_room.md)|msevtmgt_room_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_session|[msevtmgt_session EntityType](msevtmgt_session.md)|msevtmgt_session_ActivityPointers|
|regardingobjectid_msevtmgt_session_msdyn_surveyinvite|[msevtmgt_session EntityType](msevtmgt_session.md)|msevtmgt_session_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_sessionregistration|[msevtmgt_sessionregistration EntityType](msevtmgt_sessionregistration.md)|msevtmgt_sessionregistration_ActivityPointers|
|regardingobjectid_msevtmgt_sessionregistration_msdyn_surveyinvite|[msevtmgt_sessionregistration EntityType](msevtmgt_sessionregistration.md)|msevtmgt_sessionregistration_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_sessiontrack|[msevtmgt_sessiontrack EntityType](msevtmgt_sessiontrack.md)|msevtmgt_sessiontrack_ActivityPointers|
|regardingobjectid_msevtmgt_sessiontrack_msdyn_surveyinvite|[msevtmgt_sessiontrack EntityType](msevtmgt_sessiontrack.md)|msevtmgt_sessiontrack_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_speaker|[msevtmgt_speaker EntityType](msevtmgt_speaker.md)|msevtmgt_speaker_ActivityPointers|
|regardingobjectid_msevtmgt_speaker_msdyn_surveyinvite|[msevtmgt_speaker EntityType](msevtmgt_speaker.md)|msevtmgt_speaker_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_speakerengagement|[msevtmgt_speakerengagement EntityType](msevtmgt_speakerengagement.md)|msevtmgt_speakerengagement_ActivityPointers|
|regardingobjectid_msevtmgt_speakerengagement_msdyn_surveyinvite|[msevtmgt_speakerengagement EntityType](msevtmgt_speakerengagement.md)|msevtmgt_speakerengagement_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_sponsorablearticle|[msevtmgt_sponsorablearticle EntityType](msevtmgt_sponsorablearticle.md)|msevtmgt_sponsorablearticle_ActivityPointers|
|regardingobjectid_msevtmgt_sponsorablearticle_msdyn_surveyinvite|[msevtmgt_sponsorablearticle EntityType](msevtmgt_sponsorablearticle.md)|msevtmgt_sponsorablearticle_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_sponsorship|[msevtmgt_sponsorship EntityType](msevtmgt_sponsorship.md)|msevtmgt_sponsorship_ActivityPointers|
|regardingobjectid_msevtmgt_sponsorship_msdyn_surveyinvite|[msevtmgt_sponsorship EntityType](msevtmgt_sponsorship.md)|msevtmgt_sponsorship_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_venue|[msevtmgt_venue EntityType](msevtmgt_venue.md)|msevtmgt_venue_ActivityPointers|
|regardingobjectid_msevtmgt_venue_msdyn_surveyinvite|[msevtmgt_venue EntityType](msevtmgt_venue.md)|msevtmgt_venue_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_webinarconfiguration|[msevtmgt_webinarconfiguration EntityType](msevtmgt_webinarconfiguration.md)|msevtmgt_webinarconfiguration_ActivityPointers|
|regardingobjectid_msevtmgt_webinarconfiguration_msdyn_surveyinvite|[msevtmgt_webinarconfiguration EntityType](msevtmgt_webinarconfiguration.md)|msevtmgt_webinarconfiguration_msdyn_surveyinvites|
|regardingobjectid_msevtmgt_webinarprovider|[msevtmgt_webinarprovider EntityType](msevtmgt_webinarprovider.md)|msevtmgt_webinarprovider_ActivityPointers|
|regardingobjectid_msevtmgt_webinarprovider_msdyn_surveyinvite|[msevtmgt_webinarprovider EntityType](msevtmgt_webinarprovider.md)|msevtmgt_webinarprovider_msdyn_surveyinvites|
|regardingobjectid_new_interactionforemail|[interactionforemail EntityType](interactionforemail.md)|new_interactionforemail_ActivityPointers|
|regardingobjectid_new_interactionforemail_msdyn_surveyinvite|[interactionforemail EntityType](interactionforemail.md)|interactionforemail_msdyn_surveyinvites|
|regardingobjectid_opportunity|[opportunity EntityType](opportunity.md)|Opportunity_ActivityPointers|
|regardingobjectid_opportunity_msdyn_surveyinvite|[opportunity EntityType](opportunity.md)|opportunity_msdyn_surveyinvites|
|regardingobjectid_quote|[quote EntityType](quote.md)|Quote_ActivityPointers|
|regardingobjectid_quote_msdyn_surveyinvite|[quote EntityType](quote.md)|quote_msdyn_surveyinvites|
|regardingobjectid_salesorder|[salesorder EntityType](salesorder.md)|SalesOrder_ActivityPointers|
|regardingobjectid_salesorder_msdyn_surveyinvite|[salesorder EntityType](salesorder.md)|salesorder_msdyn_surveyinvites|
|regardingobjectid_site|[site EntityType](site.md)|site_ActivityPointers|
|regardingobjectid_site_msdyn_surveyinvite|[site EntityType](site.md)|site_msdyn_surveyinvites|
|sendermailboxid|[mailbox EntityType](mailbox.md)|activitypointer_sendermailboxid_mailbox|
|sendermailboxid_msdyn_surveyinvite|[mailbox EntityType](mailbox.md)|msdyn_surveyinvite_mailbox_sendermailboxid|
|serviceid|[service EntityType](service.md)|service_activity_pointers|
|serviceid_msdyn_surveyinvite|[service EntityType](service.md)|msdyn_surveyinvite_service_serviceid|
|sla_activitypointer_sla|[sla EntityType](sla.md)|manualsla_activitypointer|
|sla_activitypointer_sla_msdyn_surveyinvite|[sla EntityType](sla.md)|msdyn_surveyinvite_sla_slaid|
|slainvokedid_activitypointer_sla|[sla EntityType](sla.md)|sla_activitypointer|
|slainvokedid_activitypointer_sla_msdyn_surveyinvite|[sla EntityType](sla.md)|msdyn_surveyinvite_sla_slainvokedid|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_ActivityPointer|
|transactioncurrencyid_msdyn_surveyinvite|[transactioncurrency EntityType](transactioncurrency.md)|msdyn_surveyinvite_transactioncurrency_transactioncurrencyid|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|activity_campaignresponse|[campaignresponse EntityType](campaignresponse.md)|originatingactivityid_activitypointer|  
|activity_pointer_activity_mime_attachment|[activitymimeattachment EntityType](activitymimeattachment.md)|objectid_activitypointer|  
|activity_pointer_adx_alertsubscription|[adx_alertsubscription EntityType](adx_alertsubscription.md)|activityid_adx_alertsubscription|  
|activity_pointer_adx_inviteredemption|[adx_inviteredemption EntityType](adx_inviteredemption.md)|activityid_adx_inviteredemption|  
|activity_pointer_adx_portalcomment|[adx_portalcomment EntityType](adx_portalcomment.md)|activityid_adx_portalcomment|  
|activity_pointer_appointment|[appointment EntityType](appointment.md)|activityid_activitypointer|  
|activity_pointer_BulkOperation|[bulkoperation EntityType](bulkoperation.md)|activityid_activitypointer|  
|activity_pointer_BulkOperation_logs|[bulkoperationlog EntityType](bulkoperationlog.md)|bulkoperationid_activitypointer|  
|activity_pointer_campaignactivity|[campaignactivity EntityType](campaignactivity.md)|activityid_activitypointer|  
|activity_pointer_campaignresponse|[campaignresponse EntityType](campaignresponse.md)|activityid_activitypointer|  
|activity_pointer_email|[email EntityType](email.md)|activityid_activitypointer|  
|activity_pointer_fax|[fax EntityType](fax.md)|activityid_activitypointer|  
|activity_pointer_incident_resolution|[incidentresolution EntityType](incidentresolution.md)|activityid_activitypointer|  
|activity_pointer_letter|[letter EntityType](letter.md)|activityid_activitypointer|  
|activity_pointer_msdyn_approval|[msdyn_approval EntityType](msdyn_approval.md)|activityid_msdyn_approval|  
|activity_pointer_msdyn_bookingalert|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|activityid_msdyn_bookingalert|  
|activity_pointer_msdyn_surveyinvite|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|activityid_msdyn_surveyinvite|  
|activity_pointer_opportunity_close|[opportunityclose EntityType](opportunityclose.md)|activityid_activitypointer|  
|activity_pointer_order_close|[orderclose EntityType](orderclose.md)|activityid_activitypointer|  
|activity_pointer_phonecall|[phonecall EntityType](phonecall.md)|activityid_activitypointer|  
|activity_pointer_quote_close|[quoteclose EntityType](quoteclose.md)|activityid_activitypointer|  
|activity_pointer_recurringappointmentmaster|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|activityid_activitypointer|  
|activity_pointer_service_appointment|[serviceappointment EntityType](serviceappointment.md)|activityid_activitypointer|  
|activity_pointer_socialactivity|[socialactivity EntityType](socialactivity.md)|activityid_activitypointer|  
|activity_pointer_task|[task EntityType](task.md)|activityid_activitypointer|  
|activitypointer_activity_parties|[activityparty EntityType](activityparty.md)|activityid_activitypointer|  
|ActivityPointer_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_activitypointer|  
|ActivityPointer_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_activitypointer|  
|ActivityPointer_CampaignActivityItems|[campaignactivityitem EntityType](campaignactivityitem.md)|campaignactivityid|  
|activitypointer_connections1|[connection EntityType](connection.md)|record1id_activitypointer|  
|activitypointer_connections2|[connection EntityType](connection.md)|record2id_activitypointer|  
|ActivityPointer_QueueItem|[queueitem EntityType](queueitem.md)|objectid_activitypointer|  
|CampaignResponse_msdyn_surveyinvites|[campaignresponse EntityType](campaignresponse.md)|originatingactivityid_msdyn_surveyinvite_campaignresponse|  
|CreatedActivity_BulkOperationLogs|[bulkoperationlog EntityType](bulkoperationlog.md)|createdobjectid_activitypointer|  
|msdyn_msdyn_surveyinvite_msdyn_responseoutcome_Invitation|[msdyn_responseoutcome EntityType](msdyn_responseoutcome.md)|msdyn_Invitation|  
|msdyn_surveyinvite_ActionCards|[actioncard EntityType](actioncard.md)|regardingobjectid_msdyn_surveyinvite|  
|msdyn_surveyinvite_activity_parties|[activityparty EntityType](activityparty.md)|activityid_msdyn_surveyinvite_activityparty|  
|msdyn_surveyinvite_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_surveyinvite|  
|msdyn_surveyinvite_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_surveyinvite|  
|msdyn_surveyinvite_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_surveyinvite|  
|msdyn_surveyinvite_connections1|[connection EntityType](connection.md)|record1id_msdyn_surveyinvite|  
|msdyn_surveyinvite_connections2|[connection EntityType](connection.md)|record2id_msdyn_surveyinvite|  
|msdyn_surveyinvite_msdyn_surveyresponse|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_surveyinviteid|  
|msdyn_surveyinvite_QueueItems|[queueitem EntityType](queueitem.md)|objectid_msdyn_surveyinvite|  
|msdyn_surveyinvite_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_surveyinvite|  
|slakpiinstance_activitypointer|[slakpiinstance EntityType](slakpiinstance.md)|regarding_activitypointer|  

## Operations
The following operations can be used with the msdyn_surveyinvite entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_surveyinvite entity type.


|Name|Description |  
|----|------------|  
|[Voice of the Customer for Microsoft Dynamics 365 Solution](../solutions/voiceofthecustomer.md)|[!INCLUDE[../solutions/descriptions/voiceofthecustomer.md](../solutions/descriptions/voiceofthecustomer.md)]|    

[!INCLUDE[./remarks/msdyn_surveyinvite.md](./remarks/msdyn_surveyinvite.md)]

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