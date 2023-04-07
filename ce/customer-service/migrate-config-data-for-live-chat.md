---
title: "Migrate unified routing data for live chat | MicrosoftDocs"
description: "Learn to export and import data pertaining to live chat from source to target environments in Omnichannel for Customer Service."
ms.date: 01/23/2023
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
---

# Migrate data for the live chat channel

Use the Configuration Migration tool to migrate the configurations from the source organization to the target organization for live chat.

For information on how to use the Configuration Migration tool, see the following articles:

- [Download Configuration Migration tool](/powerapps/developer/data-platform/download-tools-nuget)
- [How the Configuration Migration tool works](/power-platform/admin/manage-configuration-data)

## Prerequisites

The following prerequisites must be met:

- In the source organization, if a unified routing ruleset refers to the following, then ensure that they exist in the target organization before you proceed with the migration:
  - Custom entities
  - Attributes
  - Relationships
  - Option sets
  - Lookup values
- Ensure that the user who performs the migration has the required privileges on the following unified routing entities in the source and target organizations:
  - Workstream (`msdyn_liveworkstream`)
  - Channel configuration (`msdyn_omnichannelconfiguration`)
  - Notification template (`msdyn_notificationtemplate`)
  - Session template (`msdyn_sessiontemplate`)
  - Operating hours (`msdyn_operatinghour`)
  - Characteristic (`characteristic`)
  - Rating Model (`rating model`)
  - Rating Value (`ratingvalue`)
  - Capacity Profile (`msdyn_capacityprofile`)
  - Queue (`queue`)
  - Decision contract (`msdyn_decisioncontract`)
  - Decision ruleset (`msdyn_decisionruleset`)
  - Assignment configuration (`msdyn_assignmentconfiguration`)
  - Assignment configuration Step (`msdyn_assignmentconfigurationstep`)
  - Routing configuration (`msdyn_routingconfiguration`)
  - Routing configuration step (`msdyn_routingconfigurationstep`)
  - Workstream capacity profile (`msdyn_liveworkstreamcapacityprofile`)
  - Context variable (`msdyn_ocliveworkstreamcontextvariable`) 
  - Survey question (`msdyn_surveyquestions`)
  - Survey question sequence (`msdyn_questionsequence`)
  - Survey answer option (`msdyn_chatansweroption`)
  - Quick replies (`msdyn_cannedmessages`)
  - Tags (`msdyn_octags`)

> [!IMPORTANT]
>
> The migration of the account, channel, bot configuration, and AI and analytics settings is not in scope.

## Migrate live chat configuration

You must perform the steps in the order they're listed to migrate your configuration data successfully. Use the information in the tables and refer to the corresponding sample schemas for each configuration.

1. Migrate configuration for skill-based routing
1. Migrate configuration for capacity profiles
1. Migrate configuration for live chat queues
1. Migrate configuration for live chat workstreams
1. Migrate configuration for live chat widgets
1. Verify your migration
1. Troubleshoot migration of data

## Migrate skill-based configuration

If skill-based routing rulesets are used in your unified routing setup, perform the steps outlined in [Export and import data for skill-based routing](migrate-config-data-for-records.md#migrate-configuration-for-skill-based-routing-rulesets).

## Migrate configuration for capacity profiles

If you have configured capacity profiles in your unified routing setup, perform the steps outlined in [Export and import data for capacity profiles](migrate-config-data-for-records.md#migrate-configuration-for-capacity-profiles).

## Migrate configuration for live chat queues

For migrating queues for live chat, perform the steps outlined in [Migrate data for unified routing-based record queues](migrate-config-data-for-records.md#migrate-configuration-for-record-queues).

## Migrate configuration for live chat workstreams

Use the Configuration Migration tool to create the schema and migrate the data from the source organization for the following entities:

- msdyn_liveworkstream
- msdyn_ocliveworkstreamcontextvariable
- msdyn_notificationtemplate
- msdyn_sessiontemplate
- msdyn_routingconfiguration
- msdyn_routingconfigurationstep
- msdyn_decisioncontract
- msdyn_decisionruleset
- msdyn_cannedmessages
- msdyn_octags

> [!Important]
>
> When you fetch decision rulesets (msdyn_decisionrulesets) containing context variables, some decision rulesets are created without the dependency mappings. To work around this, perform the following steps:
> 1. Import data for all entities including the decision ruleset entity (msdyn_decisionrulesets).
> 1. Import data for the decision ruleset entity again. This step ensures that all dependency mappings for the decision rulesets are imported.


## Migrate configuration for live chat widgets

The following assumptions are in place:

- Rules will be exported after chat configurations to be able to use pre-conversation survey questions as conversation context variables.

- You can't create the context variables when you're adding new questions to the pre-conversation survey section.

- Queues can be exported after live chat configurations and rules definition, to be able to use pre-conversation survey questions as context variables.

- The workstream must exist whether it was created manually or previously migrated to the destination organization.

**To migrate data for live chat widgets**

1. Use the Configuration Migration tool to create the schema and export data from the source organization for the live chat widget and related entities.

   - **Entity display name**: When you create the schema, select the entities in the sequence as mentioned in the table.
   - **Attribute display name**: We recommend that you select the attributes defined in the following table. You don't have to select the system-defined attributes, such as Created By, Created On, Modified By, Modified On, and Owner. You can select custom attributes if necessary.

   | Chat widget((msdyn_livechatconfig) | Attribute display name (Logical name) |
   |---------|---------|
   | Chat widget (msdyn_livechatconfig) | [FetchXMl to filter records for live chat](#BKMKlive-chat) <br> **Note:** <br> - Replace the value for msdyn_liveworkstream in the condition section.<br> - Don't include msdyn_widgetappid and msdyn_widgetsnippet as part of the entity.<br>- Ensure as part of the entity declaration in the schema that the plugin is disabled. (disableplugins="false") <br> <ul><li>(Deprecated) During non-operating hour (msdyn_duringnonoperatinghours) </li> <li> Agent display name(msdyn_agentdisplayname) </li> <li> Allow download of transcript (msdyn_enablechattranscriptdownload) </li> <li> Allow email of transcript (msdyn_enablechattranscriptemail) </li> <li> Anonymize Agent (msdyn_showagentname) </li> <li> Authentication settings (msdyn_authsettingsid) </li> <li> Auto Detect Language (msdyn_autodetectlanguage) </li> <li> Bot Survey (msdyn_postconversationsurveybotsurvey) </li> <li> Calling options (msdyn_callingoptions) </li> <li> Chat Widget (msdyn_livechatconfigid) </li> <li> Co-browse provider (msdyn_cobrowseprovider) </li> <li> Created By(createdby) </li> <li> Created By (Delegate) (createdonbehalfby) </li> <li> Created On(createdon) </li> <li> Display Generic Name (msdyn_genericagentdisplayname) </li> <li> Email Template (msdyn_emailtemplate) </li> <li> Enable (msdyn_postconversationsurveyenable) </li> <li> Enable Co-browse (msdyn_enablecobrowse) </li> <li> Enable file attachments for agents (msdyn_enablefileattachmentsforagents) </li> <li> Enable file attachments for customers (msdyn_enablefileattachmentsforcustomers) </li> <li> Enable Screen sharing (msdyn_enablescreensharing) </li> <li> Import Sequence Number (importsequencenumber) </li> <li> Indicates the conversation mode of the chat widget (msdyn_conversationmode) </li> <li> Indicates whether display of wait time is enabled (msdyn_averagewaittime_enabled) </li> <li> infolabel(msdyn_infolabel) </li> <li> Language(msdyn_widgetlocale) </li> <li> Language(msdyn_ocwidgetlanguage) </li> <li> Language (msdyn_language) </li> <li> Logo (msdyn_avatarurl) </li> <li> Message (msdyn_postconversationsurveymessagetext) </li> <li> Modified By (modifiedby) </li> <li> Modified By (Delegate) (modifiedonbehalfby) </li> <li> Modified On (modifiedon) </li> <li> Name (msdyn_name) </li> <li> Offline Widget Title (msdyn_offlinewidgettitle) </li> <li> Offline Widget Subtitle (msdyn_offlinewidgetsubtitle) </li> <li> Offline Widget Theme Color (msdyn_offlinewidgetthemecolor) </li> <li> Operating hours (msdyn_operatinghourid) </li> <li> Owning Business Unit (owningbusinessunit) </li> <li> Owning Team (owningteam) </li> <li> Owning User (owninguser) </li> <li> Portal URL (msdyn_portalurl) </li> <li> Position (msdyn_widgetposition) </li> <li> Post-chat Survey (msdyn_postchatenabled) </li> <li> Pre-Chat Survey (msdyn_prechatenabled) </li> <li> Proactive-chat (msdyn_proactivechatenabled) </li> <li> Provider API key (msdyn_oc_geolocationprovider) </li> <li> Question Set for Authenticated Users (msdyn_prechatquestionnaireauthenticated) </li> <li> Question Set for Unauthenticated Users (msdyn_prechatquestionnaireunauthenticated) </li> <li> Reconnect to previous agent (msdyn_timetoreconnectwithpreviousagent) </li> <li> Record Created On (overriddencreatedon) </li> <li> Redirection URL (msdyn_redirectionurl) </li> <li> Request visitor location (msdyn_requestvisitorlocation) </li> <li> Screen sharing provider (msdyn_screensharingprovider) </li> <li> Sender Mailbox (msdyn_mailbox) </li> <li> Show position in queue (msdyn_positioninqueue_enabled) </li> <li> Show widget during offline hours (msdyn_showwidgetduringofflinehours) </li> <li> Status (statecode) </li> <li> Status Reason (statuscode) </li> <li> Subtitle (msdyn_widgetsubtitle) </li> <li> Survey (msdyn_postconversationsurvey) </li> <li> Survey Mode (msdyn_postconversationsurveymode) </li> <li> Theme Color (msdyn_widgetthemecolor) </li> <li> Time Zone Rule Version Number (timezoneruleversionnumber) </li> <li> Title (msdyn_widgettitle) </li> <li> Turn on reconnect to previous chat (msdyn_enablechatreconnect) </li> <li> Turn on sound notifications (msdyn_widgetsoundnotification) </li> <li> Turn on unread messages indicator (msdyn_widgetvisualnotification) </li> <li> UTC Conversion Time Zone Code (utcconversiontimezonecode) </li> <li> Version Number (versionnumber) </li> <li> Work stream (msdyn_liveworkstreamid)</li></ul> |
   | Chat Authentication Settings (msdyn_authenticationsettings) | <ul> <li> Authentication type (msdyn_authenticationtype) </li><li> Chat Authentication Settings (msdyn_authenticationsettingsid) </li><li> Created By (createdby)   </li><li> Created By (Delegate) (createdonbehalfby)  </li><li> Created On (createdon) </li><li> Import Sequence Number (importsequencenumber) </li><li> JavaScript client function (msdyn_javascriptclientfunction) </li><li> Modified By (modifiedby) </li><li> Modified By (Delegate) (modifiedonbehalfby) </li><li> Modified On (modifiedon) </li><li> Name (msdyn_name) </li><li> Owner (ownerid) </li><li> Owning Business Unit (owningbusinessunit) </li><li> Owning Team (owningteam) </li><li> Owning User (owninguser) </li><li> Public key URL (msdyn_publickeyurl) </li><li> Record Created On (overriddencreatedon)) </li><li> Status (statecode) </li><li> Status Reason (statuscode) </li><li> Time Zone Rule Version Number (timezoneruleversionnumber) </li><li> UTC Conversion Time Zone Code (utcconversiontimezonecode) </li><li> Version Number (versionnumber) </li></ul> |
   | Live Chat Context (msdyn_livechatengagementctx) | <ul><li>Browser (msdyn_browser) </li><li> Chat Widget App ID (msdyn_widgetappid) </li><li> City (msdyn_city) </li><li> Conversation (msdyn_liveworkitemid) </li><li> Country/Region (msdyn_country) </li><li> Created By (createdby) </li><li> Created By (Delegate) (createdonbehalfby) </li><li> Created On (createdon) </li><li> Device (msdyn_device) </li><li> Import Sequence Number (importsequencenumber) </li><li> Is Authenticated Engagement (msdyn_isauthenticated) </li><li> Is Proactivechat (msdyn_isproactivechat) </li><li> Latitude (msdyn_latitude) </li><li> Live Chat Context (msdyn_livechatengagementctxid) </li><li> Live Chat Engagement ID (msdyn_livechatengagementid) </li><li> Locale (msdyn_locale) </li><li> Longitude (msdyn_longitude) </li><li> Modified By (modifiedby) </li><li> Modified By (Delegate) (modifiedonbehalfby) </li><li> Modified On (modifiedon) </li><li> Name (msdyn_name) </li><li> Operating System (msdyn_os) </li><li> Origin Url (msdyn_originurl) </li><li> Owner (ownerid) </li><li> Owning Business Unit (owningbusinessunit) </li><li> Owning Team (owningteam) </li><li> Owning User (owninguser) </li><li> Portal Contact ID (msdyn_portalcontactid) </li><li> Record Created On (overriddencreatedon) </li><li> State/Province (msdyn_state) </li><li> Status (statecode) </li><li> Status Reason (statuscode) </li><li> Street 1 (msdyn_street1) </li><li> Street 2 (msdyn_street2) </li><li> Street 3 (msdyn_street3) </li><li> Time Zone Rule Version Number (timezoneruleversionnumber) </li><li> UTC Conversion Time Zone Code (utcconversiontimezonecode) </li><li> Version Number (versionnumber) </li><li> Zip/Postal Code (msdyn_postalcode)</li></ul> |
   | Localization (msdyn_oclocalizationdata) |  <ul> <li> Automated message (msdyn_systemmessageid) </li><li> Created By (createdby)  </li><li> Created By (Delegate)  </li><li> Created On (createdon) </li><li> Default Localized Text (msdyn_defaultlocalizedtext) </li><li> Entity Column Name (msdyn_entitycolumnname) </li><li> Entity Name (msdyn_entityname) </li><li> Entity Record ID (msdyn_entityrecordid) </li><li> Import Sequence Number (importsequencenumber)  </li><li> Is default (msdyn_isdefault) </li><li> Language code (msdyn_customerlanguageid) </li><li> Language Code (msdyn_languagecode)  </li><li> Localization (msdyn_oclocalizationdataid)  </li><li> Localized text (msdyn_localizedtext) </li><li> Modified By (modifiedby) </li><li> Modified By (Delegate) (modifiedonbehalfby) </li><li> Modified On (modifiedon) </li><li> Organization ID (organizationid) </li><li> Record Created On (overriddencreatedon) </li><li> Status (statecode) </li><li> Status Reason (statuscode) </li><li> Time Zone Rule Version Number (timezoneruleversionnumber)  </li><li> UTC Conversion Time Zone Code (utcconversiontimezonecode)  </li><li> Version Number (versionnumber) </li></ul> |
   | Message (msdyn_ocsystemmessage) |  <ul> <li> Channel (msdyn_streamsource)  </li><li> Created By (createdby) </li><li> Created By (Delegate) (createdonbehalfby) </li><li> Created On (createdon)  </li><li> Default language (msdyn_defaultlanguage) </li><li> Import Sequence Number (importsequencenumber)  </li><li> Instance ID (msdyn_instanceid)  </li><li> Message (msdyn_ocsystemmessageid)  </li><li> Message description (msdyn_messagedescription)  </li><li> Message recipient (msdyn_messagereceiver)  </li><li> Message template trigger (msdyn_messagetemplatetrigger)  </li><li> Message Text (msdyn_messagetext)  </li><li> Message trigger (msdyn_systemmessageeventtype)  </li><li> Message type (msdyn_messagetype)  </li><li> Modified By (modifiedby) </li><li> Modified By (Delegate) (modifiedonbehalfby) </li><li> Modified On (modifiedon)  </li><li> Name (msdyn_name)  </li><li> Organization ID (organizationid) </li><li> Record Created On (overriddencreatedon)  </li><li> Status (statecode) </li><li> Status Reason (sttuscode) </li><li> Time Zone Rule Version Number (timezoneruleversionnumber)  </li><li> UTC Conversion Time Zone Code (utcconversiontimezonecode)  </li><li> Version Number (versionnumber) </li><li> Widget (msdyn_widgetid) </li></ul> |
   | Survey Answer Option (msdyn_chatansweroption)  | <ul> <li>Created By (createdby) </li><li> Created By (Delegate) (createdonbehalfby) </li><li> Created On (createdon)   </li><li> Import Sequence Number (importsequencenumber)  </li><li> Modified By (modifiedby)     </li><li> Modified By (Delegate) (modifiedonbehalfby)   </li><li> Modified On (modifiedon)   </li><li> Name (msdyn_name)   </li><li> Owner (ownerid)  </li><li> Owning Business Unit (owningbusinessunit) </li><li> Owning Team (owningteam) </li><li> Owning User (owninguser)   </li><li> Record Created On (overriddencreatedon)   </li><li> Status (statecode) </li><li> Status Reason (statuscode) </li><li> Survey Answer Option (msdyn_chatansweroptionid)  </li><li> Survey question (msdyn_answeroptionsid)    </li><li> Time Zone Rule Version Number (timezoneruleversionnumber)  </li><li> UTC Conversion Time Zone Code (utcconversiontimezonecode)  </li><li> Version Number (versionnumber)</li></ul> |
   | Survey Question (msdyn_surveyquestion)  | <ul> <li>Answer type (msdyn_answertyp) </li><li> Created By (createdby  </li><li> Created By (Delegate) (createdonbehalfby) </li><li> Created On (createdon  </li><li> Help Text (msdyn_placeholdertext)  </li><li> Import Sequence Number (importsequencenumber)  </li><li> Modified By (modifiedby) </li><li> Modified By (Delegate) (modifiedonbehalfby) </li><li> Modified On (modifiedon) </li><li> Owner (ownerid)  </li><li> Owning Business Unit (owningbusinessunit)  </li><li> Owning Team (owningteam) </li><li> Owning User (owninguser)  </li><li> Question name (msdyn_nam)   </li><li> Question text (msdyn_questiontext)  </li><li> Rating Scale (msdyn_ratingscal)  </li><li> Record Created On (overriddencreatedon) </li><li> Status (statecod)  </li><li> Status Reason (statuscod)  </li><li> Survey Question (msdyn_surveyquestionid)  </li><li> Time Zone Rule Version Number (timezoneruleversionnumber)  </li><li> UTC Conversion Time Zone Code (utcconversiontimezonecod)  </li><li> Version Number (versionnumber)  </li><li> Work stream (msdyn_liveworkstreamtochatquestion)<li></ul> |
   | Survey Question Sequence (msdyn_questionsequence)    | <ul> <li>-	Chat widget (msdyn_chatengagementtochatsequenceid) </li><li> Created By (createdby)  </li><li> Created By (Delegate) (createdonbehalfby)  </li><li> Created On (createdon)  </li><li> Import Sequence Number (importsequencenumber)  </li><li> Modified By (modifiedby)  </li><li> Modified By (Delegate) (modifiedonbehalfby)  </li><li> Modified On (modifiedon)  </li><li> Name (msdyn_name)  </li><li> Order (sequencenumber)  </li><li> Owner (Owner id)  </li><li> Owning Business Unit (owningbusinessunit)  </li><li> Owning Team (owningteam) </li><li> Owning User (owninguser)  </li><li> Record Created On (overriddencreatedon)  </li><li> Required (msdyn_questionrequired)  </li><li> Status (statecode)  </li><li> Status Reason (statuscode)  </li><li> Survey question name (msdyn_surveyquestion)  </li><li> Survey Question Sequence (msdyn_questionsequenceid)  </li><li> Survey type (msdyn_chatquestionnairetype) </li><li> Time Zone Rule Version Number (timezoneruleversionnumber)  </li><li> UTC Conversion Time Zone Code (utcconversiontimezonecode)  </li><li> Version Number (versionnumber)</li></ul> |
   | Survey Response(msdyn_chatquestionnaireresponse) | <ul> <li>Created By (createdby)   </li><li> Created By (Delegate) (createdonbehalfby) </li><li> Created On (createdon)  </li><li> Import Sequence Number (importsequencenumber)  </li><li> Modified By (modifiedby))  </li><li> Modified By (Delegate) (modifiedonbehalfby)  </li><li> Modified On (modifiedon)  </li><li> Name (msdyn_name)  </li><li> Owner (`ownerid`) </li><li> Owning Business Unit (owningbusinessunit)  </li><li> Owning Team (owningteam) </li><li> Owning User (owninguser)  </li><li> Record Created On (overriddencreatedon)  </li><li> Status (statecode) </li><li> Status Reason (statuscode) </li><li> Survey answer option (msdyn_chatansweroptionid)  </li><li> Survey answer text (msdyn_chatanswertext)  </li><li> Survey Question ID (msdyn_surveyquestionid)  </li><li> Survey response (msdyn_chatquestionnaireresponseid)  </li><li> Survey Response Values (msdyn_chatquestionnaireresponseitemid) </li><li> Time Zone Rule Version Number (timezoneruleversionnumber)  </li><li> UTC Conversion Time Zone Code (utcconversiontimezonecode)  </li><li> Version Number (versionnumber)</li></ul> |
   | Chat Widget Location (msdyn_livechatwidgetlocation) |  <ul> <li> Chat widget (msdyn_livechatconfigid) </li><li> Chat Widget Location (msdyn_livechatwidgetlocationid) </li><li> Created By (createdby) </li><li> Created By (Delegate) (createdonbehalfby) </li><li> Created On (createdon) </li><li> Import Sequence Number (importsequencenumber) </li><li> Location URL Wildcard (msdyn_locationurlwildcard) </li><li> Modified By (modifiedby) </li><li> Modified By (Delegate) (modifiedonbehalfby) </li><li> Modified On (modifiedon) </li><li> Owner (`ownerid`) </li><li> Owning Business Unit (owningbusinessunit) </li><li> Owning Team (owningteam) </li><li> Owning User (owninguser) </li><li> Record Created On (overriddencreatedon) </li><li> Rule Type (msdyn_ruletype) </li><li> Status (statecode) </li><li> Status Reason (statuscode) </li><li> Time Zone Rule Version Number (timezoneruleversionnumber) </li><li> Title (msdyn_name  </li><li> UTC Conversion Time Zone Code (utcconversiontimezonecode) </li><li> Value (msdyn_domainvalue) </li><li> Version Number (versionnumber)</li></ul> |
   | Chat Widget Language (msdyn_chatwidgetlanguage) |  <ul> <li> Chat Widget Language (msdyn_chatwidgetlanguageid)  </li><li> Created By (createdby)  </li><li> Created By (Delegate) (createdonbehalfby)  </li><li> Created On (createdon)  </li><li> Import Sequence Number (importsequencenumber)  </li><li> Language Name (msdyn_languagename) </li><li> Locale ID (msdyn_localeid)  </li><li> Modified By (modifiedby)  </li><li> Modified By (Delegate) (modifiedonbehalfby)  </li><li> Modified On (modifiedon)  </li><li> Owner (ownerid)  </li><li> Owning Business Unit (owningbusinessunit)  </li><li> Owning Team (owningteam)  </li><li> Owning User (owninguser)  </li><li> Record Created On (overriddencreatedon)  </li><li> Status (statecode)  </li><li> Status Reason (statuscode)  </li><li> Time Zone Rule Version Number (timezoneruleversionnumber)  </li><li> UTC Conversion Time Zone Code (utcconversiontimezonecode)  </li><li> Version Number (versionnumber)</li></ul> |
   | Localized Survey Question (msdyn_localizedsurveyquestion) | <ul> <li> Created By (createdby)  </li><li> Created By (Delegate) (createdonbehalfby)  </li><li> Created On (createdon)  </li><li> Description (msdyn_description)  </li><li> Import Sequence Number (importsequencenumber)  </li><li> Language Code (msdyn_languagecode)  </li><li> Localized Question Text (msdyn_localizedquestiontext)  </li><li> Localized Survey Question (msdyn_localizedsurveyquestionid)  </li><li> Modified By (modifiedby)  </li><li> Modified By (Delegate) (modifiedonbehalfby)  </li><li> Modified On (modifiedon)  </li><li> Name (msdyn_name)  </li><li> Organization ID (organizationid)  </li><li> Record Created On (overriddencreatedon)  </li><li> Status (statecode) </li><li> Status Reason (statuscode) </li><li> Survey Question (msdyn_surveyquestionid)  </li><li> Time Zone Rule Version Number (timezoneruleversionnumber)  </li><li> UTC Conversion Time Zone Code (utcconversiontimezonecode)  </li><li> Version Number (versionnumber) </li></ul> |
   | Geolocation Provider(msdyn_oc_geolocationprovider) | <ul> <li> Bing Maps API key (msdyn_providerapikey)  </li><li> Created By (createdby)  </li><li> Created By (Delegate) (createdonbehalfby)  </li><li> Created On (createdon)  </li><li> Geo Location Provider (msdyn_oc_geolocationproviderid)  </li><li> Import Sequence Number (importsequencenumber)  </li><li> Modified By (modifiedby)  </li><li> Modified By (Delegate) (modifiedonbehalfby)  </li><li> Modified On (modifiedon)  </li><li> Name (msdyn_name)  </li><li> Owner (ownerid)  </li><li> Owning Business Unit (owningbusinessunit)  </li><li> Owning Team (owningteam)  </li><li> Owning User (owninguser)  </li><li> Provider API Key Version (msdyn_providerapikeyversion)  </li><li> Provider name (msdyn_providername)  </li><li> Record Created On (overriddencreatedon)  </li><li> Status (statecode)  </li><li> Status Reason (statuscode) </li><li> Time Zone Rule Version Number (timezoneruleversionnumber)  </li><li> UTC Conversion Time Zone Code (utcconversiontimezonecode)  </li><li> Version Number (versionnumber) </li></ul> |
   | Operation Hour(msdyn_operatinghour)  | <ul> <li> (Deprecated) 24/7 (msdyn_enablealldays) </li><li> (Deprecated) End time (msdyn_endtimestring) </li><li> (Deprecated) Start time (msdyn_starttimestring) </li><li> (Deprecated) Time zone (msdyn_timezone) </li><li> (Deprecated) Total work hours (msdyn_totalworkhours) </li><li> (Deprecated) Work days (msdyn_oc_daysofweek) </li><li> Calendarid (msdyn_calendarid) </li><li> Created By (createdby) </li><li> Created By (Delegate) (createdonbehalfby) </li><li> Created On (createdon) </li><li> Description (msdyn_description) </li><li> Import Sequence Number (importsequencenumber) </li><li> Modified By (modifiedby) </li><li> Modified By (Delegate) (modifiedonbehalfby) </li><li> Modified On (modifiedon) </li><li> Name (msdyn_name) </li><li> Operating Hour (msdyn_operatinghourid) </li><li> Organization ID (organizationid) </li><li> Owner (ownerid) </li><li> Owning Business Unit (owningbusinessunit) </li><li> Owning Team (owningteam) </li><li> Owning User (owninguser) </li><li> Record Created On (overriddencreatedon) </li><li> Status (statecode) </li><li> Status Reason (statuscode) </li><li> Time Zone Rule Version Number (timezoneruleversionnumber) </li><li> UTC Conversion Time Zone Code (utcconversiontimezonecode) </li><li> Version Number (versionnumber)</li></ul> |
   |    |         |

1. Generate the schema and save it.

2. Export the data and generate the compressed (zip) file.

3. Use the Configuration Migration tool, select the option to import data, and then select the compressed file.


### FetchXML for live chat<a name="BKMKlive-chat"></a>

```
    <fetch version="1.0" mapping="logical" distinct="false">
	<entity name="msdyn_livechatconfig">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ab">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="elopez-ws-lcw-m7" uitype="msdyn_liveworkstream" value="{EBEE52BD-2EFD-99C5-C658-F13E7C7D3F8C}" />
			</filter>
		</link-entity>
	</entity>
</fetch>
```
## Verify your migration

After you import the unified routing-related configuration data successfully from the source to target organization, perform the following steps in the target organization:

1. In the UI, make sure that the unified routing configuration and rulesets are rendered properly and don't display errors.

2. If skills and rating values are used in unified routing rulesets, then you need to manually link, associate, or create the users, bookable resources, and bookable resources characteristics records.
  
3. If capacity profiles are used in rulesets and workstreams for unified routing, then you need to manually link, associate, or create the users, bookable resources, and bookable resources capacity profile records.

## Considerations for export and import of data

[!INCLUDE[ur-migration considerations](../includes/cc-ur-migration-considerations.md)]

### See also

[Migrate configuration for records based on unified routing](migrate-config-data-for-records-overview.md)  
