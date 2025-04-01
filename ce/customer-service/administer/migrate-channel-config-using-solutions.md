---
title: Migrate configurations for channels using solutions
description: Learn to use solutions for exporting and importing configurations pertaining to channels from source to target environments in Omnichannel for Customer Service.
ms.date: 05/29/2024
ms.topic: how-to
author: mjfjesus
ms.author: marcoje
ms.reviewer: marcoje
ms.collection:
ms.custom: bap-template
---
# Migrate configurations for channels using solutions

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]


Use solutions and the Configuration Migration tool to migrate the configurations from the source environment to the target environment for channels.

For information on how to use solutions or the Configuration Migration tool, go to [Overview of tools and apps used for ALM in Power Platform](/power-platform/alm/tools-apps-used-alm).

## Prerequisites

The following prerequisites must be met:

- Make sure that the user who performs the channel configuration migration has the following privileges:
  - To export solutions from the source environment.
  - To import solutions to the destination environment.
  - Read permission on all tables migrated from the source environment using the Configuration Migration tool.
  - Full permission on all tables migrated to the destination environment using the Configuration Migration tool.
- In the source environment, if any table or column refers to the following, then make sure that they exist in the target environment before you proceed with the migration:
  - Custom tables (entities)
  - Columns (attributes)
  - Relationships
  - Choices (option sets)
  - Lookup values

> [!IMPORTANT]
> The migration of the account, channel provider, bot configuration, and AI and analytics settings is not in scope.

## Channel configuration migration steps

You must perform the steps in the order they're listed to migrate your configuration data successfully:

1. Migrate configuration for session templates and notification templates
1. Migrate configuration for skill-based routing rulesets
1. Migrate configuration for new capacity profiles
1. Migrate configuration for queues
1. Migrate configuration for channel workstreams and channel settings
1. Verify your migration

## Migrate configuration for session templates and notification templates

If you use custom session templates and notifications in your channel routing setup, perform the steps outlined in [Migrate configuration for session templates and notification templates](migrate-record-routing-config-using-solutions.md#migrate-configuration-for-session-templates-and-notification-templates).

## Migrate configuration for skill-based routing rulesets

If skill-based routing rulesets are used in your channel routing setup, perform the steps outlined in [Migrate configurations for skill-based routing rulesets](migrate-record-routing-config-using-solutions.md#migrate-configuration-for-skill-based-routing-rulesets). Make sure to adjust any filtering FetchXML appropriately for the channels you want to migrate.

## Migrate configuration for new capacity profiles

If you have configured new capacity profiles in your channel routing setup, perform the steps outlined in [Migrate configuration for new capacity profiles](migrate-record-routing-config-using-solutions.md#migrate-configuration-for-new-capacity-profiles). Make sure to adjust any filtering FetchXML appropriately for all channels.

> [!TIP]
> After you migrate a new capacity profile using the Configuration Migration tool, updates can be migrated using solutions.

## Migrate configuration for queues

For migrating channel queues, perform the steps outlined in [Migrate configuration for queues](migrate-record-routing-config-using-solutions.md#migrate-configuration-for-queues). Make sure to adjust any filtering FetchXML appropriately for all channels you want to migrate.

## Migrate configuration for channel workstreams and channel settings

1. Create a solution to export configurations from the source environment for all workstreams and the channels that can be migrated via solution.
2. Add the required records to the solution using the **Add existing** button in the command bar and selecting the starting table for each channel you need to export, as follows:

    |Channel  |Starting table  |
    |---------|----------------|
    |Live Chat|Chat widget (msdyn_livechatconfig)|
    |Voice|Voice channel setting (msdyn_ocvoicechannelsetting)|
    |SMS|SMS number settings (msdyn_ocsmschannelsetting)|
    |WhatsApp|WhatsApp number (msdyn_ocwhatsappchannelnumber)|
    |WeChat|WeChat account (msdyn_ocwechatchannelconfig)|
    |Apple Messages for Business|Apple messages for business account (msdyn_ocapplebusinessaccount)|
    |Facebook|Work stream (msdyn_liveworkstream)|
    |Google Business Messages|Work stream (msdyn_liveworkstream)|
    |LINE|Work stream (msdyn_liveworkstream)|
    |Microsoft Teams|Work stream (msdyn_liveworkstream)|
    |Custom channel|Work stream (msdyn_liveworkstream)|

3. Select the records from the channel definition table for each channel and add them to the solution. Related records from the following tables are automatically added to the solution:

    |Channel  |Tables automatically added to solution  |
    |---------|----------------------------------------|
    |All channels|Work stream (msdyn_liveworkstream)<br>Capacity profile (msdyn_capacityprofile) – new records must be [migrated using Configuration Migration tool](#migrate-configuration-for-new-capacity-profiles)<br>Work stream capacity profile (msdyn_liveworkstreamcapacityprofile)<br>Context variable (msdyn_ocliveworkstreamcontextvariable)<br>Decision contract (msdyn_decisioncontract)<br>Decision rule set (msdyn_decisionruleset)<br>Routing configuration (msdyn_routingconfiguration)<br>Routing configuration step (msdyn_routingconfigurationstep)<br>Language (msdyn_oclanguage) – except voice and custom channel|
    |Live chat|Chat widget (msdyn_livechatconfig)<br>Authentication settings (msdyn_authenticationsettings)<br>Survey Answer Option (msdyn_chatansweroption)<br>Survey Question (msdyn_surveyquestion)<br>Survey Question Sequence (msdyn_questionsequence)<br>Geo Location Provider (msdyn_oc_geolocationprovider)<br>Operating Hour (msdyn_operatinghour)|
    |Voice|Voice channel setting (msdyn_ocvoicechannelsetting)<br>Authentication settings (msdyn_authenticationsettings)<br>Voice (msdyn_ocvoice)<br>Voice channel language setting (msdyn_ocvoicechannellanguagesetting)<br>Phone Number (msdyn_ocphonenumber)<br>Communication Provider Setting (msdyn_occommunicationprovidersetting)<br>Carrier (msdyn_occarrier)<br>Phone music (msdyn_ocphonemusic)<br>Operating Hour (msdyn_operatinghour)|
    |SMS|SMS number settings (msdyn_ocsmschannelsetting)<br>Phone Number (msdyn_ocphonenumber)<br>Communication Provider Setting (msdyn_occommunicationprovidersetting)<br>Carrier (msdyn_occarrier)<br>Operating Hour (msdyn_operatinghour)|
    |WhatsApp|WhatsApp account (msdyn_ocwhatsappchannelaccount)<br>WhatsApp number (msdyn_ocwhatsappchannelnumber)|
    |WeChat|WeChat account (msdyn_ocwechatchannelconfig)|
    |Apple Messages for Business|Apple messages for business account (msdyn_ocapplebusinessaccount)|

    > [!IMPORTANT]
    > - Carefully review solution components before exporting a solution. Note the records that contain information regarding Azure Communication Services, third-party channels, or other Microsoft components like Copilot Studio copilots or Customer Voice surveys, so that you can make required configurations in the destination environment.
    > - If one or more workstreams share the same capacity profile, when you add tables from one channel or workstream, records and tables from other channels or workstreams sharing the same capacity profile are also added to the solution.

4. Use the Configuration Migration tool to create the schema and migrate the remaining configuration data from the source environment (organization) for workstreams and channels.

   - **Entity display name**: When you create the schema, select the tables (entities) from the list in the same sequence as mentioned in the following table.
   - **Attribute display name**: We recommend that you select the columns (attributes) defined in the table. You don't need to select the out-of-the-box system-defined columns like **Created By**, **Created On**, **Modified By**, **Modified On**, and **Owner**. You can select custom columns, if necessary.
   - **Use FetchXML to filter records**: For each selected table, use the appropriate FetchXML query that's mentioned in the following table to get single, multiple, or all records based on your requirement. For single or multiple rows, you need to use source environment to get the correct name in uiname and GUID in value. If required, you can use the **ADVANCED FIND** menu item to construct the appropriate FetchXML query.
   - **Configure import settings**: For the workstream table, make sure that you add the key columns only and select the **Do not update existing records** checkbox to prevent updates to records in a table migrated through solutions.

    > [!IMPORTANT]
    > For **Facebook Page**, **Google’s Business Messages agent account**, **LINE account**, **Custom messaging channel**, and **Microsoft Teams account** tables, don't include Survey (msdyn_postconversationsurvey) and Survey (msdyn_postconversationsurveyseparatebotsurvey) columns because survey records are synced with Dynamics 365 Customer Voice in each environment, so they can’t be migrated across environments.

    |Channels|Entity display name (Logical name)|Attribute display name (Logical name)|Use FetchXML to filter records|
    |--------|---------|---------|-------|
    |All channels|Workstream (msdyn_liveworkstream)|<ul><li>Channel (msdyn_streamsource)</li><li>Mode (msdyn_mode)</li><li>Name (msdyn_name)</li><li>Work Stream (msdyn_liveworkstreamid)</li></ul>|[**Sample 1: All workstreams of a channel**](#WS1All)<br><br>[**Sample 2: Single workstream**](#WS2Single)<br><br>[**Sample 3: Multiple workstreams**](#WS3Multiple)|
    |All messaging channels|Quick Reply (msdyn_cannedmessage)|<ul><li>Locale (msdyn_locale_field)</li><li>Message (msdyn_message)</li><li>Quick reply (msdyn_cannedmessageid)</li><li>TagsControlField (msdyn_tagscontrolfield)</li><li>Title (msdyn_title)</li></ul>|[**Sample 1: All workstreams of a channel**](#QR1All)<br><br>[**Sample 2: Single workstream**](#QR2Single)<br><br>[**Sample 3: Multiple workstreams**](#QR3Multiple)|
    |All messaging channels|Tag (msdyn_octag)|<ul><li>Name (msdyn_name)</li><li>Tag (msdyn_octagid)</li></ul>|[**Sample 1: All workstreams of a channel**](#Tag1All)<br><br>[**Sample 2: Single workstream**](#Tag2Single)<br><br>[**Sample 3: Multiple workstreams**](#Tag3Multiple)|
    |All channels|Message (msdyn_ocsystemmessage)|<ul><li>Channel (msdyn_streamsource)</li><li>Default language (msdyn_defaultlanguage)</li><li>Instance ID (msdyn_instanceid)</li><li>Message (msdyn_ocsystemmessageid)</li><li>Message description (msdyn_messagedescription)</li><li>Message recipient (msdyn_messagereceiver)</li><li>Message template trigger (msdyn_messagetemplatetrigger)</li><li>Message Text (msdyn_messagetext)</li><li>Message trigger (msdyn_systemmessageeventtype)</li><li>Message type (msdyn_messagetype)</li><li>Name (msdyn_name)</li><li> Widget (msdyn_widgetid) </li></ul>||
    |All channels|Localization (msdyn_oclocalizationdata)|<ul><li>Automated message (msdyn_systemmessageid)</li><li>Default Localized Text (msdyn_defaultlocalizedtext)</li><li>Entity Column Name (msdyn_entitycolumnname)</li><li>Entity Name (msdyn_entityname)</li><li>Entity Record ID (msdyn_entityrecordid)</li><li>Is default (msdyn_isdefault)</li><li>Language code (msdyn_customerlanguageid)</li><li>Language Code (msdyn_languagecode)</li><li>Localization (msdyn_oclocalizationdataid)</li><li>Localized text (msdyn_localizedtext)</li></ul>|[**FetchXML to filter records for channel localizations**](#CLAll)|
    |Facebook|Facebook Application (msdyn_ocfbapplication)|<ul><li>Application Id (msdyn_fbapplicationid)</li><li>Application Secret (msdyn_fbapplicationsecret)</li><li>Callback Uri (msdyn_fbcallbackuri)</li><li>Facebook Application (msdyn_ocfbapplicationid)</li><li>Name (msdyn_name)</li><li>Verify Token (msdyn_fbverifytoken)</li></ul>|[**FetchXML to filter records for Facebook applications**](#FBAppAll)|
    |Facebook|Facebook Page (msdyn_ocfbpage)|<ul><li>Bot Survey (msdyn_postconversationsurveybotsurvey)</li><li>Enable (msdyn_postconversationsurveyenable)</li><li>Enable file attachments for agents (msdyn_enablefileattachmentforagents)</li><li>Enable file attachments for customers (msdyn_enablefileattachmentforcustomers)</li><li>Facebook Application (msdyn_ocfbapplicationid)</li><li>Facebook Page (msdyn_ocfbpageid)</li><li>Facebook page language (msdyn_ocwidgetlanguage)</li><li>Message (msdyn_postconversationsurveybotsurveymessagetext)</li><li>Message (msdyn_postconversationsurveymessagetext)</li><li>Name (msdyn_fbpagename)</li><li>Page Access Token (msdyn_fbpageaccesstoken)</li><li>Page Id (msdyn_fbpageid)</li><li>Survey Mode (msdyn_postconversationsurveybotsurveymode)</li><li>Survey Mode (msdyn_postconversationsurveymode)</li><li>Turn on your Facebook human agent message tag (msdyn_enablehumanagenttag)</li><li>Work stream (msdyn_liveworkstreamid)</li></ul>|[**FetchXML to filter records for Facebook pages**](#FBPageAll)|
    |Google Business Messages|Google's Business Messages partner account (msdyn_ocgooglebusinessmessagespartneraccount)|<ul><li>Base 64 credential file string (msdyn_base64credentialfilestring)</li><li>Base 64 credential file string - Continued (msdyn_base64credentialfilestringcontd)</li><li>Credential file name (msdyn_credentialfilename)</li><li>Google’s Business Messages callback URL (msdyn_googlebusinessmessagescallbackurl)</li><li>Google’s Business Messages partner account ID (msdyn_ocgooglebusinessmessagespartneraccountid)</li><li>Name (msdyn_name)</li><li>Partner account client token (msdyn_partneraccountclienttoken)</li><li>Partner account ID (msdyn_partneraccountid)</li></ul>|[**FetchXML to filter records for Google's Business Messages partner accounts**](#GBMPtAccAll)|
    |Google Business Messages|Google's Business Messages agent account (msdyn_ocgooglebusinessmessagesagentaccount)|<ul><li>Agent account client token (msdyn_agentaccountclienttoken)</li><li>Agent ID (msdyn_agentid)</li><li>Bot Survey (msdyn_postconversationsurveybotsurvey)</li><li>Brand ID (msdyn_brandid)</li><li>Enable agent override (msdyn_enableagentoverride)</li><li>Enable file attachments for agents (msdyn_enablefileattachmentforagents)</li><li>Enable file attachments for customers (msdyn_enablefileattachmentforcustomers)</li><li>Google’s Business Messages agent account (msdyn_googlebusinessmessagesagentaccountid)</li><li>Google’s Business Messages callback URL (msdyn_googlebusinessmessagescallbackurl)</li><li>Google’s Business Messages partner account ID (msdyn_ocgbmpartneraccount)</li><li>Live workstream ID (msdyn_liveworkstreamid)</li><li>Message (msdyn_postconversationsurveybotsurveymessagetext)</li><li>Name (msdyn_name)</li><li>Post conversation survey enable (msdyn_postconversationsurveyenable)</li><li>Post conversation summary message text (msdyn_postconversationsurveymessagetext)</li><li>Post conversation survey mode (msdyn_postconversationsurveymode)</li><li>Survey Mode (msdyn_postconversationsurveybotsurveymode)</li><li>Widget language (msdyn_ocwidgetlanguage)</li></ul>|[**FetchXML to filter records for Google's Business Messages agent accounts**](#GBMAgAccAll)|
    |LINE|LINE account (msdyn_oclinechannelconfig)|<ul><li>Bot Survey (msdyn_postconversationsurveybotsurvey)</li><li>Channel Access Token (msdyn_channelaccesstoken)</li><li>Channel ID (msdyn_channelid)</li><li>Channel Secret (msdyn_channelsecret)</li><li>Enable (msdyn_postconversationsurveyenable)</li><li>Enable file attachments for agents (msdyn_enablefileattachmentforagents)</li><li>Enable file attachments for customers (msdyn_enablefileattachmentforcustomers)</li><li>LINE account language (msdyn_ocwidgetlanguage)</li><li>LINE Channel identifies Line Channel (msdyn_oclinechannelconfigid)</li><li>Message (msdyn_postconversationsurveybotsurveymessagetext)</li><li>Message (msdyn_postconversationsurveymessagetext)</li><li>Name (msdyn_name)</li><li>Survey Mode (msdyn_postconversationsurveybotsurveymode)</li><li>Survey Mode (msdyn_postconversationsurveymode)</li><li>Webhook URL (msdyn_webhookurl)</li><li>Work stream (msdyn_liveworkstreamid)</li></ul>|[**FetchXML to filter records for LINE accounts**](#LINEAll)|
    |Custom channel|Custom messaging channel (msdyn_occustommessagingchannel)|<ul><li>Bot Survey (msdyn_postconversationsurveybotsurvey)</li><li>Channel ID (msdyn_occustomchannelid)</li><li>Custom messaging account (msdyn_custombotchannelregistration)</li><li>Custom Messaging Channel (msdyn_occustommessagingchannelid)</li><li>Custom messaging channel language (msdyn_ocwidgetlanguage)</li><li>Enable (msdyn_postconversationsurveyenable)</li><li>Enable file attachments for agents (msdyn_enablefileattachmentforagents)</li><li>Enable file attachments for customers (msdyn_enablefileattachmentforcustomers)</li><li>Message (msdyn_postconversationsurveybotsurveymessagetext)</li><li>Message (msdyn_postconversationsurveymessagetext)</li><li>Name (msdyn_name)</li><li>Survey Mode (msdyn_postconversationsurveybotsurveymode)</li><li>Survey Mode (msdyn_postconversationsurveymode)</li><li>Work stream (msdyn_liveworkstreamid)</li></ul>|[**FetchXML to filter records for custom messaging channels**](#CustomAll)|
    |Microsoft Teams|Microsoft Teams account (msdyn_octeamschannelconfig)|<ul><li>Bot ID (msdyn_botid)</li><li>Bot Survey (msdyn_postconversationsurveybotsurvey)</li><li>Calling options (msdyn_callingoptions)</li><li>Enable (msdyn_postconversationsurveyenable)</li><li>Enable file attachments for agents (msdyn_enablefileattachmentforagents)</li><li>Enable file attachments for customers (msdyn_enablefileattachmentforcustomers)</li><li>Message (msdyn_postconversationsurveybotsurveymessagetext)</li><li>Message (msdyn_postconversationsurveymessagetext)</li><li>Name (msdyn_name)</li><li>Survey Mode (msdyn_postconversationsurveybotsurveymode)</li><li>Survey Mode (msdyn_postconversationsurveymode)</li><li>Teams account language (msdyn_ocwidgetlanguage)</li><li>Teams App Name (msdyn_octeamsappname)</li><li>Teams Channel (msdyn_octeamschannelconfigid)</li><li>Work stream (msdyn_liveworkstreamid)</li></ul>|[**FetchXML to filter records for Microsoft Teams accounts**](#TeamsAll)|
    |Facebook, Google Business Messages, LINE, Custom Channel, Microsoft Teams|Custom messaging account (msdyn_ocbotchannelregistration)|<ul><li>Bot Channel Registration (msdyn_ocbotchannelregistrationid)</li><li>Client secret (msdyn_msappsecret)</li><li>Facebook Application (msdyn_ocfbapplicationid)</li><li>Google’s Business Messages agent account id (msdyn_ocgbmagentaccount)</li><li>Google’s Business Messages partner account id (msdyn_ocgbmpartneraccount)</li><li>Is Custom Messaging BCR (msdyn_iscustommessagingbcr)</li><li>Last validated (msdyn_lastvalidateddate)</li><li>LINE channel (msdyn_oclinechannelconfigid)</li><li>MS Application Id (msdyn_msappid)</li><li>Name (msdyn_name)</li><li>Secure Client secret (msdyn_securemsappsecret)</li><li>Teams Channel (msdyn_octeamschannelconfigid)</li><li>Validation status (msdyn_validationstatus)</li></ul>|[**FetchXML to filter records for custom messaging accounts**](#BotRegAll)|

5. Generate the schema and save it.
6. Export the data and generate the compressed (.zip) file.
7. Use the Configuration Migration tool, select the option to import data, and select the compressed file.

### FetchXML for workstreams

**Sample 1: All workstreams of a channel**<a name="WS1All"></a>

```XML
<fetch>
	<entity name="msdyn_liveworkstream">
		<filter type="and">
			<condition attribute="msdyn_mode" operator="eq" value="717210001" />
			<condition attribute="msdyn_streamsource" operator="eq" value="<CHANNEL_ID>" />
		</filter>
	</entity>
</fetch> 
```
> [!TIP]
> To find <CHANNEL_ID> values for each channel that you want to migrate the workstreams for, go to [Power Apps Maker Portal](https://make.powerapps.com), select your source environment, go to **Choices**, then open the **Stream Source** (msdyn_streamsource) choice. For example, the value for voice channel is 192440000.


**Sample 2: Single workstream**<a name="WS2Single"></a>

```XML
<fetch>
	<entity name="msdyn_liveworkstream">
		<filter type="and">
			<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Test workstream 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312ABC}" />
		</filter>
	</entity>
</fetch> 
```

**Sample 3: Multiple workstreams**<a name="WS3Multiple"></a>

```XML
<fetch>
	<entity name="msdyn_liveworkstream">
		<filter type="and">
			<condition attribute="msdyn_liveworkstreamid" operator="in">
				<value uiname="Test workstream 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312ABC}</value>
				<value uiname="Test workstream 2" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44098}</value>
			</condition>
		</filter>
	</entity>
</fetch> 
```

### FetchXML for quick replies

**Sample 1: Quick replies for all workstreams of a channel**<a name="QR1All"></a>

```XML
<fetch>
	<entity name="msdyn_cannedmessage">
		<link-entity name="msdyn_msdyn_cannedmessage_liveworkstream" from="msdyn_cannedmessageid" to="msdyn_cannedmessageid" visible="false" intersect="true">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="aa">
				<filter type="and">
					<condition attribute="msdyn_mode" operator="eq" value="717210001" />
					<condition attribute="msdyn_streamsource" operator="eq" value="<CHANNEL_ID>" />
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```

**Sample 2: Quick replies for a single workstream**<a name="QR2Single"></a>

```XML
<fetch>
	<entity name="msdyn_cannedmessage">
		<link-entity name="msdyn_msdyn_cannedmessage_liveworkstream" from="msdyn_cannedmessageid" to="msdyn_cannedmessageid" visible="false" intersect="true">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="aa">
				<filter type="and">
					<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname=" workstream 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312ABC}" />
/>
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```

**Sample 3: Quick replies for multiple workstreams**<a name="QR3Multiple"></a>

```XML
<fetch>
	<entity name="msdyn_cannedmessage">
		<link-entity name="msdyn_msdyn_cannedmessage_liveworkstream" from="msdyn_cannedmessageid" to="msdyn_cannedmessageid" visible="false" intersect="true">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="aa">
				<filter type="and">
					<condition attribute="msdyn_liveworkstreamid" operator="in">
						<value uiname="Test Workstream 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312ABC}</value>
						<value uiname="Test Workstream 2" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44098}</value>
					</condition>
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```

### FetchXML for tags

**Sample 1: Tags of quick replies for all workstreams of a channel**<a name="Tag1All"></a>

```XML
<fetch>
	<entity name="msdyn_octag">
		<link-entity name="msdyn_msdyn_cannedmessage_msdyn_octag" from="msdyn_octagid" to="msdyn_octagid" visible="false" intersect="true">
			<link-entity name="msdyn_msdyn_cannedmessage_liveworkstream" from="msdyn_cannedmessageid" to="msdyn_cannedmessageid" visible="false" intersect="true">
				<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="aa">
					<filter type="and">
						<condition attribute="msdyn_mode" operator="eq" value="717210001" />
						<condition attribute="msdyn_streamsource" operator="eq" value="<CHANNEL_ID>" />
					</filter>
				</link-entity>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```

**Sample 2: Tags of quick replies for a single workstream**<a name="Tag2Single"></a>

```XML
<fetch>
	<entity name="msdyn_octag">
		<link-entity name="msdyn_msdyn_cannedmessage_msdyn_octag" from="msdyn_octagid" to="msdyn_octagid" visible="false" intersect="true">
			<link-entity name="msdyn_msdyn_cannedmessage_liveworkstream" from="msdyn_cannedmessageid" to="msdyn_cannedmessageid" visible="false" intersect="true">
				<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="aa">
					<filter type="and">
						<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname=" workstream 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312ABC}" />
					</filter>
				</link-entity>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```

**Sample 3: Tags of quick replies for multiple workstreams**<a name="Tag3Multiple"></a>

```XML
<fetch>
	<entity name="msdyn_octag">
		<link-entity name="msdyn_msdyn_cannedmessage_msdyn_octag" from="msdyn_octagid" to="msdyn_octagid" visible="false" intersect="true">
			<link-entity name="msdyn_msdyn_cannedmessage_liveworkstream" from="msdyn_cannedmessageid" to="msdyn_cannedmessageid" visible="false" intersect="true">
				<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="aa">
					<filter type="and">
						<condition attribute="msdyn_liveworkstreamid" operator="in">
							<value uiname="Test Workstream 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312ABC}</value>
							<value uiname="Test Workstream 2" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44098}</value>
						</condition>
					</filter>
				</link-entity>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```

### FetchXML for channel localizations<a name="CLAll"></a>

```XML
<fetch>
	<entity name="msdyn_oclocalizationdata">
		<link-entity name="msdyn_ocsystemmessage" from="msdyn_ocsystemmessageid" to="msdyn_systemmessageid" link-type="inner" alias="ab">
			<filter type="and">
				<condition attribute="msdyn_streamsource" operator="eq" value="<CHANNEL_ID>" />
			</filter>
		</link-entity>
	</entity>
</fetch>		
```

### FetchXML for Facebook applications<a name="FBAppAll"></a>

```XML
<fetch>
	<entity name="msdyn_ocfbapplication">
		<link-entity name="msdyn_ocfbpage" from="msdyn_ocfbapplicationid" to="msdyn_ocfbapplicationid" link-type="inner" alias="ab">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ac">
				<filter type="and">
					<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="ALM Facebook Test Workstream" uitype="msdyn_liveworkstream" value="{87bf4384-a02f-4802-8be7-1d6884a7e73f}" />
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch>
```

### FetchXML for Facebook pages<a name="FBPageAll"></a>

```XML
<fetch>
	<entity name="msdyn_ocfbpage">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ab">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="ALM Facebook Test Workstream" uitype="msdyn_liveworkstream" value="{87bf4384-a02f-4802-8be7-1d6884a7e73f}" />
			</filter>
		</link-entity>
	</entity>
</fetch>
```

### FetchXML for Google’s Business Messages partner accounts<a name="GBMPtAccAll"></a>

```XML
<fetch>
	<entity name="msdyn_ocgooglebusinessmessagespartneraccount">
		<link-entity name="msdyn_ocgooglebusinessmessagesagentaccount" from=" msdyn_ocgooglebusinessmessagespartneraccountid" to="msdyn_ocgbmpartneraccount" link-type="inner" alias="ab">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ac">
				<filter type="and">
					<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="ALM Google Test Workstream" uitype="msdyn_liveworkstream" value="{87bf4384-a02f-4802-8be7-1d6884a7e73f}" />
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch>
```

### FetchXML for Google’s Business Messages agent accounts<a name="GBMAgAccAll"></a>

```XML
<fetch>
	<entity name="msdyn_ocgooglebusinessmessagesagentaccount">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ab">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="ALM Google Test Workstream" uitype="msdyn_liveworkstream" value="{87bf4384-a02f-4802-8be7-1d6884a7e73f}" />
			</filter>
		</link-entity>
	</entity>
</fetch>
```

### FetchXML for LINE accounts<a name="LINEAll"></a>

```XML
<fetch>
	<entity name="msdyn_oclinechannelconfig">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ab">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="ALM LINE Test Workstream" uitype="msdyn_liveworkstream" value="{87bf4384-a02f-4802-8be7-1d6884a7e73f}" />
			</filter>
		</link-entity>
	</entity>
</fetch>
```

### FetchXML for custom messaging channels<a name="CustomAll"></a>

```XML
<fetch>
	<entity name="msdyn_occustommessagingchannel">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ab">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="ALM Custom Channel Test Workstream" uitype="msdyn_liveworkstream" value="{87bf4384-a02f-4802-8be7-1d6884a7e73f}" />
			</filter>
		</link-entity>
	</entity>
</fetch>
```

### FetchXML for Microsoft Teams accounts<a name="TeamsAll"></a>

```XML
<fetch>
	<entity name="msdyn_octeamschannelconfig">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ab">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="ALM Teams Test Workstream" uitype="msdyn_liveworkstream" value="{87bf4384-a02f-4802-8be7-1d6884a7e73f}" />
			</filter>
		</link-entity>
	</entity>
</fetch>
```

### FetchXML for custom messaging accounts<a name="BotRegAll"></a>

```XML
<fetch>
	<entity name="msdyn_ocbotchannelregistration">
		<filter type="or">
			<condition attribute="msdyn_liveworkstreamid" entityname="ac" operator="eq" uiname="ALM Custom Channel Test Workstream" uitype="msdyn_liveworkstream" value="{87bf4384-a02f-4802-8be7-1d6884a7e73f}" />
			<condition attribute="msdyn_liveworkstreamid" entityname="bd" operator="eq" uiname="ALM Facebook Test Workstream" uitype="msdyn_liveworkstream" value="{87bf4384-a02f-4802-8be7-1d6884a7e73f}" />
			<condition attribute="msdyn_liveworkstreamid" entityname="cc" operator="eq" uiname="ALM Google Test Workstream" uitype="msdyn_liveworkstream" value="{87bf4384-a02f-4802-8be7-1d6884a7e73f}" />
			<condition attribute="msdyn_liveworkstreamid" entityname="dc" operator="eq" uiname="ALM LINE Test Workstream" uitype="msdyn_liveworkstream" value="{87bf4384-a02f-4802-8be7-1d6884a7e73f}" />
			<condition attribute="msdyn_liveworkstreamid" entityname="ec" operator="eq" uiname="ALM Teams Test Workstream" uitype="msdyn_liveworkstream" value="{87bf4384-a02f-4802-8be7-1d6884a7e73f}" />
		</filter>
		<link-entity name="msdyn_occustommessagingchannel" from="msdyn_custombotchannelregistration" to="msdyn_ocbotchannelregistrationid" link-type="outer" alias="ab">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="ac">
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_ocfbapplication" from="msdyn_ocfbapplicationid" to="msdyn_ocfbapplicationid" link-type="outer" alias="bb">
			<link-entity name="msdyn_ocfbpage" from="msdyn_ocfbapplicationid" to="msdyn_ocfbapplicationid" link-type="outer" alias="bc">
				<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="bd">
				</link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_ocgooglebusinessmessagesagentaccount" from="msdyn_ocgbmagentaccount" to="msdyn_ocgooglebusinessmessagesagentaccountid" link-type="outer" alias="cb">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="cc">
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_oclinechannelconfig" from="msdyn_oclinechannelconfigid" to="msdyn_oclinechannelconfigid" link-type="outer" alias="db">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="dc">
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_octeamschannelconfig" from="msdyn_octeamschannelconfigid" to="msdyn_octeamschannelconfigid" link-type="outer" alias="eb">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="ec">
			</link-entity>
		</link-entity>
	</entity>
</fetch>
```

## Verify your migration

After you import the unified routing-related configuration data successfully from the source to target environment, perform the following steps in the target environment:

1. In the UI, make sure that the unified routing configuration and rulesets are rendered properly and don't display errors.

2. If skills and rating values are used in unified routing rulesets, then you need to manually link, associate, or create the users, bookable resources, and bookable resources characteristics records.

3. If capacity profiles are used in rulesets and workstreams for unified routing, then you need to manually link, associate, or create the users, bookable resources, and bookable resources capacity profile records.

## Considerations for export and import of data

[!INCLUDE[ur-migration considerations](../../includes/cc-ur-migration-considerations.md)]

### Related information

[Migrate configurations for record routing using solutions](migrate-record-routing-config-using-solutions.md)  
[Microsoft Power Platform Build Tools for Azure DevOps](/power-platform/alm/devops-build-tools)  
