---
title: "Export and import unified routing data for live chat | MicrosoftDocs"
description: "Learn to export and import data pertaining to live chat from source to target environments in Omnichannel for Customer Service."
ms.date: 04/02/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.reviewer: nenellim
---

# Export import data for live chat channel

By using the Configuration Migration tool, you can migrate the unified routing related configurations from the source organization to the target organization for live chat that's configured to use unified routing.

For information on how to use the Configuration Migration tool, see the following articles:

- [Download Configuration Migration Tool](/powerapps/developer/data-platform/download-tools-nuget)
- [How the Configuration Migration tool works](/power-platform/admin/manage-configuration-data)

## Prerequisites

The following prerequisites must be met:

- In the source organization, if unified routing ruleset refers to custom entities, attributes, relationships, option sets or lookup values, then ensure that they exist in the target organization before you proceed with the migration. 
- Ensure that the user who performs the migration has the required privileges on the following unified routing-related entities in the source and target organizations:

    - Workstream (msdyn_liveworkstream)
    - Channel configuration (msdyn_omnichannelconfiguration)
    - Notification template (msdyn_notificationtemplate)
    - Session template (msdyn_sessiontemplate)
    - Operating hours (msdyn_operatinghour)
    - Characteristic (characteristic)
    - Rating Model (ratingmodel)
    - Rating Value (ratingvalue)
    - Capacity Profile (msdyn_capacityprofile)
    - Queue (queue)
    - Decision contract (msdyn_decisioncontract)
    - Decision rule set (msdyn_decisionruleset)
    - Assignment Configuration (msdyn_assignmentconfiguration)
    - Assignment Configuration Step (msdyn_assignmentconfigurationstep)
    - Routing configuration (msdyn_routingconfiguration)
    - Routing configuration step (msdyn_routingconfigurationstep)
    - Workstream capacity profile (msdyn_liveworkstreamcapacityprofile)

> [!IMPORTANT]
> The migration of the account and channel and AI and analytics settings is not in scope.

## Export and import data for the live chat channel

Perform the steps in the order listed to export and import the configuration from the source to the target organization. Use the information in the sections for each type of data and refer to the corresponding sample schemas for each type of configuration to fetch the required records.

1. Export and import data for skill-based routing
1. Export and import data for capacity profiles
1. Export and import data for live chat queues
1. Export and import data for live chat channel workstreams
1. Export and import data for live chat widgets

## Considerations for export and import of data

[!INCLUDE[ur-migration considerations](../includes/cc-ur-migration-considerations.md)]

## Export and import data for skill-based routing

If skill-based routing rulesets are used in your unified routing setup, perform the steps outlined in [Export and import data for skill-based routing](export-import-unified-routing-records.md#export-and-import-data-for-skill-based-routing).

## Export and import data for capacity profiles

If you have configured capacity profiles in your unified routing setup, perform the steps outlined in [Export and import data for capacity profiles](export-import-unified-routing-records.md#export-and-import-data-for-capacity-profiles).

## Export and import data for live chat queues

For exporting and importing queues for live chat, perform the steps outlined in [Export and import data for unified routing-based record queues](export-import-unified-routing-records.md#export-and-import-data-for-unified-routing-based-record-queues).

## Export and import data for live chat channel workstreams

Use the Configuration Migration tool to create schema and export the data from the source organization for the following entities:
- msdyn_liveworkstream
- msdyn_ocliveworkstreamcontextvariable
- msdyn_notificationtemplate
- msdyn_sessiontemplate
- msdyn_surveyquestions
- msdyn_questionsequence
- msdyn_chatansweroption
- msdyn_ocbotchannelregistration

## Export and import data for live chat widgets

The following assumptions are in place:

- Rules will be exported after chat configurations to be able to use pre-conversation survey questions as conversation context variables.

- You can't create the context variables when you're adding new questions to the pre-conversation survey section.

- Queues can be exported after live chat configurations and rules definition, to be able to use pre-conversation survey questions as context variables.

- The workstream must already exist, created manually or previously migrated in the destination organization.

**To export and import data for live chat widgets**

1. Use the Configuration Migration tool to create the schema and export data from the source organization for the live chat widget and related entities.

   - **Entity display name**: When you create the schema, select the entities in the sequence that's mentioned in the table.
   - **Attribute display name**: We recommend that you select the attributes defined in the following table. You don't need to select the out-of-the-box system defined attributes, such as Created By, Created On, Modified By, Modified On, and Owner. You can select custom attributes if required.

    | Chat widget((msdyn_livechatconfig) |  Attribute display name (Logical name) | Use FetchXML to filter records |
    |-------------------------------------|----------------------------------------|-------------------------------|
    |  Chat widget (msdyn_livechatconfig) | Note: <ul><li> Do not include: msdyn_widgetappid and msdyn_widgetsnippet as part of the entity.</li> <li> Corroborate as part of the entity declaration in the schema that the plugin is disabled. (disableplugins="false") </li></ul> <br> <ul><li>(Deprecated) During non-operating hour (msdyn_duringnonoperatinghours) </li> <li> Agent display name(msdyn_agentdisplayname) </li> <li> Allow download of transcript (msdyn_enablechattranscriptdownload) </li> <li> Allow email of transcript (msdyn_enablechattranscriptemail) </li> <li> Anonymize Agent (msdyn_showagentname) </li> <li> Authentication settings (msdyn_authsettingsid) </li> <li> Auto Detect Language (msdyn_autodetectlanguage) </li> <li> Bot Survey (msdyn_postconversationsurveybotsurvey) </li> <li> Calling options (msdyn_callingoptions) </li> <li> Chat Widget (msdyn_livechatconfigid) </li> <li> Co-browse provider (msdyn_cobrowseprovider) </li> <li> Created By(createdby) </li> <li> Created By (Delegate) (createdonbehalfby) </li> <li> Created On(createdon) </li> <li> Display Generic Name (msdyn_genericagentdisplayname) </li> <li> Email Template (msdyn_emailtemplate) </li> <li> Enable (msdyn_postconversationsurveyenable) </li> <li> Enable Co-browse (msdyn_enablecobrowse) </li> <li> Enable file attachments for agents (msdyn_enablefileattachmentsforagents) </li> <li> Enable file attachments for customers (msdyn_enablefileattachmentsforcustomers) </li> <li> Enable Screen sharing (msdyn_enablescreensharing) </li> <li> Import Sequence Number (importsequencenumber) </li> <li> Indicates the conversation mode of the chat widget (msdyn_conversationmode) </li> <li> Indicates whether display of wait time is enabled (msdyn_averagewaittime_enabled) </li> <li> infolabel(msdyn_infolabel) </li> <li> Language(msdyn_widgetlocale) </li> <li> Language(msdyn_ocwidgetlanguage) </li> <li> Language (msdyn_language) </li> <li> Logo (msdyn_avatarurl) </li> <li> Message (msdyn_postconversationsurveymessagetext) </li> <li> Modified By (modifiedby) </li> <li> Modified By (Delegate) (modifiedonbehalfby) </li> <li> Modified On (modifiedon) </li> <li> Name (msdyn_name) </li> <li> Offline Widegt Title (msdyn_offlinewidgettitle) </li> <li> Offline Widget Subtitle (msdyn_offlinewidgetsubtitle) </li> <li> Offline Widget Theme Color (msdyn_offlinewidgetthemecolor) </li> <li> Operating hours (msdyn_operatinghourid) </li> <li> Owning Business Unit (owningbusinessunit) </li> <li> Owning Team (owningteam) </li> <li> Owning User (owninguser) </li> <li> Portal URL (msdyn_portalurl) </li> <li> Position (msdyn_widgetposition) </li> <li> Post-chat Survey (msdyn_postchatenabled) </li> <li> Pre-Chat Survey (msdyn_prechatenabled) </li> <li> Proactive-chat (msdyn_proactivechatenabled) </li> <li> Provider API key (msdyn_oc_geolocationprovider) </li> <li> Question Set for Authenticated Users (msdyn_prechatquestionnaireauthenticated) </li> <li> Question Set for Unauthenticated Users (msdyn_prechatquestionnaireunauthenticated) </li> <li> Reconnect to previous agent (msdyn_timetoreconnectwithpreviousagent) </li> <li> Record Created On (overriddencreatedon) </li> <li> Redirection URL (msdyn_redirectionurl) </li> <li> Request visitor location (msdyn_requestvisitorlocation) </li> <li> Screen sharing provider (msdyn_screensharingprovider) </li> <li> Sender Mailbox (msdyn_mailbox) </li> <li> Show position in queue (msdyn_positioninqueue_enabled) </li> <li> Show widget during offline hours (msdyn_showwidgetduringofflinehours) </li> <li> Status (statecode) </li> <li> Status Reason (statuscode) </li> <li> Subtitle (msdyn_widgetsubtitle) </li> <li> Survey (msdyn_postconversationsurvey) </li> <li> Survey Mode (msdyn_postconversationsurveymode) </li> <li> Theme Color (msdyn_widgetthemecolor) </li> <li> Time Zone Rule Version Number (timezoneruleversionnumber) </li> <li> Title (msdyn_widgettitle) </li> <li> Turn on reconnect to previous chat (msdyn_enablechatreconnect) </li> <li> Turn on sound notifications (msdyn_widgetsoundnotification) </li> <li> Turn on unread messages indicator (msdyn_widgetvisualnotification) </li> <li> UTC Conversion Time Zone Code (utcconversiontimezonecode) </li> <li> Version Number (versionnumber) </li> <li> Work stream (msdyn_liveworkstreamid)</li></ul>
  ||
    ||||
    ||||
    ||||
    ||||
    ||||
    ||||
    ||||
    ||||
    ||||
    ||||
    ||||
    ||||
    ||||