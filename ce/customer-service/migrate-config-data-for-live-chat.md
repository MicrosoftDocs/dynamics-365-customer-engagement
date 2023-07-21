---
title: Migrate unified routing data for live chat
description: Learn to export and import data pertaining to live chat from source to target environments in Omnichannel for Customer Service.
ms.date: 07/21/2023
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
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

1. Migrate configuration using a solution
1. Migrate configuration for skill-based routing
1. Migrate configuration for capacity profiles
1. Migrate configuration for live chat queues
1. Migrate configuration for live chat workstreams
1. Migrate configuration for live chat widgets
1. Verify your migration
1. Troubleshoot migration of data

## Migrate configuration using a solution

If you use custom session templates and notifications in your live chat routing setup, perform the steps outlined in [Migrate configuration using a solution](migrate-config-data-for-records.md#migrate-configuration-using-a-solution).

## Migrate skill-based configuration

If skill-based routing rulesets are used in your unified routing setup, perform the steps outlined in [Export and import data for skill-based routing](migrate-config-data-for-records.md#migrate-configuration-for-skill-based-routing-rulesets). Make sure to adjust any filtering fetch xml appropriately for live chat.

## Migrate configuration for capacity profiles

If you have configured capacity profiles in your unified routing setup, perform the steps outlined in [Export and import data for capacity profiles](migrate-config-data-for-records.md#migrate-configuration-for-capacity-profiles).  Make sure to adjust any filtering fetch xml appropriately for live chat.

## Migrate configuration for live chat queues

For migrating queues for live chat, perform the steps outlined in [Migrate data for unified routing-based record queues](migrate-config-data-for-records.md#migrate-configuration-for-record-queues).  Make sure to adjust any filtering fetch xml appropriately for live chat.

## Migrate configuration for live chat workstreams

1. Use the Configuration Migration tool to create the schema and migrate the data from the source organization for the record workstream.

   - **Entity display name**: When you create the schema, select the entities in the same sequence as mentioned in the table.
   - **Attribute display name**: We recommend that you select the attributes defined in the following table. You don't need to select the out-of-the-box system defined attributes like Created By, Created On, Modified By, Modified On, and Owner. You can select custom attributes, if necessary.
   - **Use FetchXML to filter records**: For each entity, use the appropriate FetchXML query that's mentioned in the following table to get single, multiple, or all records based on your requirement. For single or multiple records, you need to use source organization to get the correct name in uiname and GUID in value. If required, you can use the ADVANCED FIND menu item to construct the appropriate FetchXML query.
   - **Configure import settings**: For the Decision contract entity, ensure that you select the **Do not update existing records** checkbox.

1. Make sure that the workstreams that're referred in the configuration of the live chat widgets are include in the migration.

   |S.No.|Entity display name (Logical name)  |Attribute display name (Logical name)  |Use FetchXML to filter records  |
   |---------|---------|---------|-----------|
   |1.|Workstream (msdyn_liveworkstream)|<ul><li>API Key (msdyn_apikey)</li> <li>API Key Version Number (msdyn_apikeyversionnumber) </li> <li>Allow Automated Messages (msdyn_enableautomatedmessages) </li> <li>Allowed Presences (msdyn_allowedpresences) </li> <li> Assign WorkItem After Decline or Timeout (msdyn_assignworkitemafterdecline) </li><li> Auto-close after inactivity (msdyn_autocloseafterinactivity) </li><li> Block capacity for wrap up state (msdyn_blockcapacityforwrapup) </li><li>Bot queue (msdyn_bot_queue) </li><li>Bot rule (msdyn_bot_rule) </li><li>Bot user (msdyn_bot_user) </li><li>CallbackPreviewDialing (msdyn_notificationtemplate_callback_previewdialing) </li><li>Connectors (msdyn_connectorsurl) </li><li>Consult (msdyn_notificationtemplate_consult) </li><li>Conversation mode of chat channels (msdyn_conversationmode) </li><li>Customer ID (msdyn_customerid) </li><li>Customer Disconnect Hold Duration For Open Conversation (msdyn_customerdisconnectholddurationforopenconversation) </li><li>Capacity (msdyn_capacityrequired) </li><li>Capacity format (msdyn_capacityformat) </li><li>Channel (msdyn_streamsource) </li><li>Contract Id (msdyn_routingcontractid) </li><li>Default (msdyn_sessiontemplate_default) </li><li>Default Queue (msdyn_defaultqueue) </li><li>Direction (msdyn_direction) </li><li>Enable selecting from push-based work streams (msdyn_enableselectingfrompushbasedworkstreams) </li><li>Entity (msdyn_masterentityroutingconfigurationid) </li><li>FallBack Language (msdyn_fallbacklanguage) </li><li>Follow-up after waiting (msdyn_followupafterwaiting) </li><li>Handling Time Threshold (msdyn_handlingtimethreshold) </li><li>Incoming authenticated (msdyn_notificationtemplate_incoming_auth) </li><li>Incoming unauthenticated (msdyn_notificationtemplate_incoming_unauth) </li><li>Is Default (msdyn_isdefault) </li><li>Keep same agent for entire conversation (msdyn_enableagentaffinity) </li><li>Last Validation On (msdyn_lastvalidationon) </li><li>Last Validation Status (msdyn_lastvalidationstatus) </li><li>Matching Logic (msdyn_matchinglogic) </li><li>Max Concurrency (msdyn_maxconcurrentconnection) </li><li>Mode (msdyn_mode) </li><li>Name (msdyn_name) </li><li>Notification (msdyn_notification) </li><li>Notification scenario placeholder (msdyn_notificationscenarioplaceholder) </li><li>Outbound queue (msdyn_outboundqueueid) </li><li>Record Identification Rule (msdyn_recordidentificationrule) </li><li>Record Identification Validation Rule (msdyn_recordidentificationvalidationrule) </li><li>Restrict download of recording (msdyn_restrictdownloadrecording) </li><li>Restrict download of transcript (msdyn_restrictdownloadtranscript) </li><li>Screen pop timeout (msdyn_screenpoptimeout) </li><li> Screen pop timeout (msdyn_screenpoptimeout_optionSet) </li><li> Secure API Key (msdyn_secureapikey) </li><li> Skill Attachment Rules Count (msdyn_skillattachmentrulescount) </li><li> Skill Attachment Rules Count (Last Updated On) </li><li> (msdyn_skillattachmentrulescount_date) </li><li> Skill Attachment Rules Count (State) </li><li> (msdyn_skillattachmentrulescount_state) </li><li> Session scenario placeholder (msdyn_sessionscenarioplaceholder) </li><li> SupervisorAssign (msdyn_notificationtemplate_supervisorassign) </li><li> Transfer (msdyn_notificationtemplate_transfer) </li><li> Waiting Time Threshold (msdyn_waitingtimethreshold) </li><li> Work Distribution Mode (msdyn_workdistributionmode) </li><li> Work Stream (msdyn_liveworkstreamid) </li></ul>|[**Sample 1: All live chat workstreams**](#BKMK1lcw)<br><br>[**Sample 2: Single live chat workstream**](#BKMK2lcw)<br><br>[**Sample 3: Multiple live chat workstreams**](#BKMK3lcw) |
   |2.|Context Variable (msdyn_ocliveworkstreamcontextvariable)|<ul><li>Name (msdyn_name) </li><li> Relation Ship Name (msdyn_relationshipname) </li><li> Type (msdyn_datatype) </li><li> Work stream (msdyn_liveworkstreamid) </li><li> IsList (msdyn_islist) </li><li> Modifiable (msdyn_ismodifiable) </li><li> Display Name (msdyn_displayname) </li><li> Displayable (msdyn_isdisplayable) </li><li> Entity Logical Name (msdyn_entitylogicalname) </li><li> Context variable (msdyn_ocliveworkstreamcontextvariableid) </li><li> Status (statecode) </li><li> Status Reason (statuscode) </li><li> System Defined (msdyn_issystemdefined) </li></ul>|[**Sample 1: Context Variables for all workstreams**](#BKMK1lcwcv)<br><br> [**Sample 2: Context variables for a single live chat workstream**](#BKMK2lcwcv) <br><br> [**Sample 3: Context Variables for multiple live chat workstreams**](#BKMK3lcwcv) |
   |3.|Decision contract (msdyn_decisioncontract)|<ul><li>Contract definition (msdyn_contractdefinition) </li><li> Decision contract (msdyn_decisioncontractid) </li><li> Name (msdyn_name) </li><li> Unique name (msdyn_uniquename) </li></ul>|[**Sample 1: Decision contract for all live chat workstreams**](#BKMK1dclcw) <br><br>[**Sample 2: Decision contract for a single live chat workstream**](#BKMK2dclcw)<br><br>[**Sample 3: Decision contract for multiple live chat workstreams**](#BKMK3dclcw) |
   |4.|Decision rule set (msdyn_decisionruleset)|<ul><li>AI builder model (msdyn_aibmodelid) </li><li> Authoring mode (msdyn_authoringmode) </li><li> Decision rule set (msdyn_decisionrulesetid) </li><li> Description (msdyn_description) </li><li> Input contract (msdyn_inputcontractid) </li><li> Is input collection (msdyn_isinputcollection) </li><li> ML model type (msdyn_mlmodeltype) </li><li> Name (msdyn_name) </li><li> Output contract (msdyn_outputcontractid) </li><li> Rule set definition (msdyn_rulesetdefinition) </li><li> Rule set type (msdyn_rulesettype) </li><li> Unique name (msdyn_uniquename) </li></ul>|[**Sample 1: Decision ruleset for all live chat workstreams**](#BKMK1drlcw)<br><br>[**Sample 2: Decision ruleset for a single live chat workstream**](#BKMK2drslcw) <br><br>[**Sample 3: Decision ruleset for multiple live chat workstreams**](#BKMK3drmlcw) |
   |5.|Routing configuration (msdyn_routingconfiguration)|<ul><li>Is active configuration (msdyn_isactiveconfiguration) </li><li> Name (msdyn_name) </li><li> Routing configuration (msdyn_routingconfigurationid) </li><li> Unique name (msdyn_uniquename) </li><li> Workstream (msdyn_liveworkstreamid) </li></ul>|[**Sample 1: Routing configuration for all live chat workstreams**](#BKMK1rclcw)<br><br>[**Sample 2: Routing configuration for a single live chat workstream**](#BKMK2rclcw) <br><br>[**Sample 3: Routing configuration for multiple live chat workstreams**](#BKMK3rclcw) |
   |6.|Routing configuration step (msdyn_routingconfigurationstep)|<ul><li>Name (msdyn_name) </li><li> Routing configuration (msdyn_routingconfigurationid) </li><li> Routing configuration step (msdyn_routingconfigurationstepid) </li><li> Rule set (msdyn_rulesetid) </li><li> Step order (msdyn_steporder) </li><li> Step type (msdyn_type) </li><li> Unique name (msdyn_uniquename) </li></ul>|[**Sample 1: Routing configuration step for all live chat workstreams**](#BKMK1rcs)<br><br>[**Sample 2: Routing configuration step for a single live chat workstream**](#BKMK2rcs) <br><br>[**Sample 3: Routing configuration step for multiple live chat workstreams**](#BKMK3rcs)|
   |7.|Workstream capacity profile (msdyn_liveworkstreamcapacityprofile)|<ul><li>Capacity Profile (msdyn_capacityprofile_id) </li><li> Name (msdyn_name) </li><li> Workstream (msdyn_workstream_id) </li><li> Workstream Capacity profile (msdyn_liveworkstreamcapacityprofileid) </li></ul>|[**Sample 1: Workstream capacity profile for all live chat workstreams**](#BKMK1wcp)<br><br>[**Sample 2: Workstream capacity profile for a single live chat workstream**](#BKMK2wcp)<br><br>[**Sample 3: Workstream capacity profile for multiple live chat workstreams**](#BKMK3wcp) |
   |8.|Quick Reply (msdyn_cannedmessage)|<ul><li>Locale (msdyn_locale_field) </li><li> Message (msdyn_message) </li><li> Organization Id (organizationid) </li><li> Quick reply (msdyn_cannedmessageid) </li><li> Status (statecode) </li><li> Status Reason (statuscode) </li><li> TagsControlField (msdyn_tagscontrolfield) </li><li> Title (msdyn_title) </li></ul>||
   |9.|Tag (msdyn_octag)|<ul><li>Name (msdyn_name) </li><li> Tag (msdyn_octagid) </li></ul>||


1. Generate the schema and save it.

1. Export the data and generate the compressed (zip) file.

1. Use the Configuration Migration tool, select the option to import data, and select the compressed file.

> [!IMPORTANT]
> When you fetch decision rulesets (msdyn_decisionrulesets) containing context variables, some decision rulesets are created without the dependency mappings. To work around this, perform the following steps:
> 1. Import data for all entities including the decision ruleset entity (msdyn_decisionrulesets).
> 2. Import data for the decision ruleset entity again. This step ensures that all dependency mappings for the decision rulesets are imported.

For sample schema to get all the required records, see Sample schema for live chat workstream.

### FetchXML for workstream entity

**Sample 1: All live chat workstreams**<a name="BKMK1lcw"></a>

```XML
<fetch distinct="true">
	<entity name="msdyn_liveworkstream">
		<filter type="and">
			<condition attribute="msdyn_mode" operator="eq" value="717210001" />
			<condition attribute="msdyn_streamsource" operator="eq" value=" 192360000" />
		</filter>
	</entity>
</fetch>
```

**Sample 2: Single live chat workstream**<a name="BKMK2lcw"></a>

```XML
<fetch>
	<entity name="msdyn_liveworkstream">
		<filter type="and">
			<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Test Live Chat Workstream 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312ABC}" />
		</filter>
	</entity>
</fetch>
```

**Sample 3: Multiple live chat workstreams**<a name="BKMK3lcw"></a>

```XML
<fetch version="1.0" output-format="xml-platform" mapping="logical" distinct="false">
	<entity name="msdyn_liveworkstream">
		<filter type="and">
			<condition attribute="msdyn_liveworkstreamid" operator="in">
				<value uiname="Test Live Chat Workstream 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312ABC}</value>
				<value uiname="Test Live Chat Workstream 2" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44098}</value>
			</condition>
		</filter>
	</entity>
</fetch>
```

### FetchXML for context variables entity

**Sample 1: All live chat workstreams context variables**<a name="BKMK1lcwcv"></a>

```XML
<fetch>
    <entity name="msdyn_ocliveworkstreamcontextvariable" >
        <link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="aa" >
            <filter type="and" >
                <condition attribute="msdyn_streamsource" operator="eq" value="192360000" />
                <condition attribute="msdyn_mode" operator="eq" value="717210001" />
            </filter>
        </link-entity>
    </entity>
</fetch>
```

**Sample 2: Single live chat workstream context variables**<a name="BKMK2lcwcv"></a> 

```XML
<fetch>
    <entity name="msdyn_ocliveworkstreamcontextvariable" >
        <filter type="and" >
            <condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Live Chat Workstream" uitype="msdyn_liveworkstream" value="{D3A1F09D-51A0-A6B7-266D-58E1BDB97B53}" />
        </filter>
    </entity>
</fetch>
```

**Sample 3: Multiple live chat workstreams context variables**<a name="BKMK3lcwcv"></a>

```XML
<fetch>
    <entity name="msdyn_ocliveworkstreamcontextvariable" >
        <filter type="or" >
            <condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Live Chat Workstream" uitype="msdyn_liveworkstream" value="{D3A1F09D-51A0-A6B7-266D-58E1BDB97B53}" />
            <condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Live Chat Workstream 1" uitype="msdyn_liveworkstream" value="{f9e18e67-d1a8-ed11-aad1-00224805c057}" />
        </filter>
    </entity>
</fetch>
```

### FetchXML for decision contract entity

**Sample 1: Decision contract for all live chat workstreams**<a name="BKMK1dclcw"></a>

```XML
<fetch distinct="true" >
    <entity name="msdyn_decisioncontract" >
        <filter type="and" >
            <condition attribute="ismanaged" operator="eq" value="false" />
        </filter>
        <filter type="or" >
            <filter type="and" >
                <condition attribute="msdyn_mode" entityname="an" operator="eq" value="717210001" />
                <condition attribute="msdyn_streamsource" entityname="an" operator="eq" value="192360000" />
            </filter>
            <filter type="and" >
                <condition attribute="msdyn_mode" entityname="bd" operator="eq" value="717210001" />
                <condition attribute="msdyn_streamsource" entityname="bd" operator="eq" value="192360000" />
            </filter>
        </filter>
        <link-entity name="msdyn_liveworkstream" from="msdyn_routingcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="an" />
        <link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="ba" >
            <link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bb" >
                <link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="bc" >
                    <link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="bd" />
                </link-entity>
            </link-entity>
        </link-entity>
    </entity>
</fetch>
```

**Sample 2: Decision contract for a single live chat workstream**<a name="BKMK2dclcw"></a>

```XML
<fetch distinct="true" >
    <entity name="msdyn_decisioncontract" >
        <filter type="and" >
            <condition attribute="ismanaged" operator="eq" value="false" />
        </filter>
        <filter type="or" >
            <filter type="and" >
                <condition attribute="msdyn_liveworkstreamid" entityname="an" operator="eq" uiname="Live Chat Workstream" uitype="msdyn_liveworkstream" value="{d3a1f09d-51a0-a6b7-266d-58e1bdb97b53}" />
            </filter>
            <filter type="and" >
                <condition attribute="msdyn_liveworkstreamid" entityname="an" operator="eq" uiname="Live Chat Workstream" uitype="msdyn_liveworkstream" value="{d3a1f09d-51a0-a6b7-266d-58e1bdb97b53}" />
            </filter>
        </filter>
        <link-entity name="msdyn_liveworkstream" from="msdyn_routingcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="an" />
        <link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="ba" >
            <link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bb" >
                <link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="bc" >
                    <link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="bd" />
                </link-entity>
            </link-entity>
        </link-entity>
    </entity>
</fetch>
```

**Sample 3: Decision contract for multiple live chat workstreams**<a name="BKMK3dclcw"></a>

```XML
<fetch distinct="true" >
    <entity name="msdyn_decisioncontract" >
        <filter type="and" >
            <condition attribute="ismanaged" operator="eq" value="false" />
        </filter>
        <filter type="or" >
            <filter type="or" >
                <condition attribute="msdyn_liveworkstreamid" entityname="an" operator="eq" uiname="ALM Live Chat Test Workstream" uitype="msdyn_liveworkstream" value="{d3a1f09d-51a0-a6b7-266d-58e1bdb97b53}" />
                <condition attribute="msdyn_liveworkstreamid" entityname="an" operator="eq" uiname="ALM Live Chat Test Workstream" uitype="msdyn_liveworkstream" value="{f9e18e67-d1a8-ed11-aad1-00224805c057}" />
            </filter>
            <filter type="or" >
                <condition attribute="msdyn_liveworkstreamid" entityname="bd" operator="eq" uiname=" Live Chat Workstream" uitype="msdyn_liveworkstream" value="{d3a1f09d-51a0-a6b7-266d-58e1bdb97b53}" />
                <condition attribute="msdyn_liveworkstreamid" entityname="bd" operator="eq" uiname="Live Chat Workstream 2" uitype="msdyn_liveworkstream" value="{f9e18e67-d1a8-ed11-aad1-00224805c057}" />
            </filter>
        </filter>
        <link-entity name="msdyn_liveworkstream" from="msdyn_routingcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="an" />
        <link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="ba" >
            <link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bb" >
                <link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="bc" >
                    <link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="bd" />
                </link-entity>
            </link-entity>
        </link-entity>
    </entity>
</fetch>
```

### FetchXML for decision ruleset entity

**Sample 1: Decision ruleset for all live chat workstreams**<a name="BKMK1drlcw"></a>

```XML
<fetch distinct="true" >
    <entity name="msdyn_decisionruleset" >
        <filter type="or" >
            <filter type="and" >
                <condition attribute="msdyn_mode" entityname="af" operator="eq" value="717210001" />
                <condition attribute="msdyn_streamsource" entityname="af" operator="eq" value="192360000" />
            </filter>
        </filter>
        <link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="ad" >
            <link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="ae" >
                <link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="af" />
            </link-entity>
        </link-entity>
    </entity>
</fetch>
```

**Sample 2: Decision ruleset for a single live chat workstream**<a name="BKMK2drslcw"></a>

```XML
<fetch distinct="true" >
    <entity name="msdyn_decisionruleset" >
        <filter type="or" >
            <filter type="and" >
                <condition attribute="msdyn_liveworkstreamid" entityname="af" operator="eq" uiname="Live Chat Workstream" uitype="msdyn_liveworkstream" value="{d3a1f09d-51a0-a6b7-266d-58e1bdb97b53}" />
            </filter>
        </filter>
        <link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="ad" >
            <link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="ae" >
                <link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="af" />
            </link-entity>
        </link-entity>
    </entity>
</fetch>
```

**Sample 3: Decision ruleset for multiple live chat workstreams**<a name="BKMK3drmlcw"></a>

```XML
<fetch distinct="true" >
    <entity name="msdyn_decisionruleset" >
        <filter type="or" >
            <filter type="or" >
                <condition attribute="msdyn_liveworkstreamid" entityname="af" operator="eq" uiname="Live Chat Workstream" uitype="msdyn_liveworkstream" value="{d3a1f09d-51a0-a6b7-266d-58e1bdb97b53}" />
                <condition attribute="msdyn_liveworkstreamid" entityname="af" operator="eq" uiname="Live Chat Workstream 1" uitype="msdyn_liveworkstream" value="{f9e18e67-d1a8-ed11-aad1-00224805c057}" />
            </filter>
        </filter>
        <link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="ad" >
            <link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="ae" >
                <link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="af" />
            </link-entity>
        </link-entity>
    </entity>
</fetch>
```

### FetchXML for routing configuration entity

**Sample 1: Routing configuration for all live chat workstreams**<a name="BKMK1rclcw"></a>

```XML
<fetch>
	<entity name="msdyn_routingconfiguration">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ah">
			<filter type="and">
				<condition attribute="msdyn_mode" operator="eq" value="717210001" />
				<condition attribute="msdyn_streamsource" operator="eq" value="192360000" />
			</filter>
		</link-entity>
	</entity>
</fetch> 
```

**Sample 2: Routing configuration for a single live chat workstream**<a name="BKMK2rclcw"></a>

```XML
<fetch>
	<entity name="msdyn_routingconfiguration">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ah">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Test Live Chat Workstream 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312ABC}" />
			</filter>
		</link-entity>
	</entity>
</fetch>
```

**Sample 3: Routing configuration for multiple live chat workstreams**<a name="BKMK3rclcw"></a>

```XML
<fetch>
	<entity name="msdyn_routingconfiguration">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ah">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="in">
					<value uiname="Test Live Chat Workstream 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312ABC}</value>
					<value uiname="Test Live Chat Workstream 2" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44098}</value>
				</condition>
			</filter>
		</link-entity>
	</entity>
</fetch>
```

### FetchXML for routing configuration step entity

**Sample 1: Routing configuration step for all live chat workstreams**<a name="BKMK1rcs"></a>

```XML
<fetch>
	<entity name="msdyn_routingconfigurationstep">
		<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="inner" alias="ak">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="al">
				<filter type="and">
					<condition attribute="msdyn_mode" operator="eq" value="717210001" />
					<condition attribute="msdyn_streamsource" operator="eq" value="192360000" />
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch>
```

**Sample 2: Routing configuration step for a single live chat workstream**<a name="BKMK2rcs"></a>

```XML
<fetch>
	<entity name="msdyn_routingconfigurationstep">
		<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="inner" alias="ak">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="al">
				<filter type="and">
					<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Test Live Chat Workstream 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}" />
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch>
```

**Sample 3: Routing configuration step for multiple live chat workstreams**<a name="BKMK3rcs"></a>

```XML
<fetch>
	<entity name="msdyn_routingconfigurationstep">
		<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="inner" alias="ak">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="al">
				<filter type="and">
					<condition attribute="msdyn_liveworkstreamid" operator="in">
						<value uiname="Test Live Chat Workstream 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312ABC}</value>
						<value uiname="Test Live Chat Workstream 2" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44098}</value>
					</condition>
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch>
```

### FetchXML for workstream capacity profile entity

**Sample 1: Workstream capacity profile for all live chat workstreams**<a name="BKMK1wcp"></a>

```XML
<fetch>
	<entity name="msdyn_liveworkstreamcapacityprofile">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_workstream_id" link-type="inner" alias="am">
			<filter type="and">
				<condition attribute="msdyn_mode" operator="eq" value="717210001" />
				<condition attribute="msdyn_streamsource" operator="eq" value="192360000" />
			</filter>
		</link-entity>
	</entity>
</fetch>
```

**Sample 2: Workstream capacity profile for a single live chat workstream**<a name="BKMK2wcp"></a>

```XML
<fetch>
	<entity name="msdyn_liveworkstreamcapacityprofile">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_workstream_id" link-type="inner" alias="am">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Test Live Chat Workstream 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}" />
			</filter>
		</link-entity>
	</entity>
</fetch>
```

**Sample 3: Workstream capacity profile for multiple live chat workstreams**<a name="BKMK3wcp"></a>

```XML
<fetch>
	<entity name="msdyn_liveworkstreamcapacityprofile">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_workstream_id" link-type="inner" alias="am">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="in">
					<value uiname="Test Live Chat Workstream 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}</value>
					<value uiname="Test Live Chat Workstream 2" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44215}</value>
				</condition>
			</filter>
		</link-entity>
	</entity>
</fetch>
```

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
   | Chat widget (msdyn_livechatconfig) | [FetchXMl to filter records for live chat](#BKMKlive-chat) <br> **Note:** <br> - Replace the value for msdyn_liveworkstream in the condition section.<br> - Don't include msdyn_widgetappid and msdyn_widgetsnippet as part of the entity.<br>- Ensure as part of the entity declaration in the schema that the plugin is disabled. (disableplugins="false") <br> <ul><li>(Deprecated) During non-operating hour (msdyn_duringnonoperatinghours) </li> <li> Agent display name(msdyn_agentdisplayname) </li> <li> Allow download of transcript (msdyn_enablechattranscriptdownload) </li> <li> Allow email of transcript (msdyn_enablechattranscriptemail) </li> <li> Anonymize Agent (msdyn_showagentname) </li> <li> Authentication settings (msdyn_authsettingsid) </li> <li> Auto Detect Language (msdyn_autodetectlanguage) </li> <li> Bot Survey (msdyn_postconversationsurveybotsurvey) </li> <li> Calling options (msdyn_callingoptions) </li> <li> Chat Widget (msdyn_livechatconfigid) </li> <li> Co-browse provider (msdyn_cobrowseprovider) </li> <li> Display Generic Name (msdyn_genericagentdisplayname) </li> <li> Email Template (msdyn_emailtemplate) </li> <li> Enable (msdyn_postconversationsurveyenable) </li> <li> Enable Co-browse (msdyn_enablecobrowse) </li> <li> Enable file attachments for agents (msdyn_enablefileattachmentsforagents) </li> <li> Enable file attachments for customers (msdyn_enablefileattachmentsforcustomers) </li> <li> Enable Screen sharing (msdyn_enablescreensharing) </li> <li> Indicates the conversation mode of the chat widget (msdyn_conversationmode) </li> <li> Indicates whether display of wait time is enabled (msdyn_averagewaittime_enabled) </li> <li> infolabel(msdyn_infolabel) </li> <li> Language(msdyn_widgetlocale) </li> <li> Language(msdyn_ocwidgetlanguage) </li> <li> Language (msdyn_language) </li> <li> Logo (msdyn_avatarurl) </li> <li> Message (msdyn_postconversationsurveymessagetext) </li> <li> Modified On (modifiedon) </li> <li> Name (msdyn_name) </li> <li> Offline Widget Title (msdyn_offlinewidgettitle) </li> <li> Offline Widget Subtitle (msdyn_offlinewidgetsubtitle) </li> <li> Offline Widget Theme Color (msdyn_offlinewidgetthemecolor) </li> <li> Operating hours (msdyn_operatinghourid) </li> <li> Portal URL (msdyn_portalurl) </li> <li> Position (msdyn_widgetposition) </li> <li> Post-chat Survey (msdyn_postchatenabled) </li> <li> Pre-Chat Survey (msdyn_prechatenabled) </li> <li> Proactive-chat (msdyn_proactivechatenabled) </li> <li> Provider API key (msdyn_oc_geolocationprovider) </li> <li> Question Set for Authenticated Users (msdyn_prechatquestionnaireauthenticated) </li> <li> Question Set for Unauthenticated Users (msdyn_prechatquestionnaireunauthenticated) </li> <li> Reconnect to previous agent (msdyn_timetoreconnectwithpreviousagent) </li> <li> Redirection URL (msdyn_redirectionurl) </li> <li> Request visitor location (msdyn_requestvisitorlocation) </li> <li> Screen sharing provider (msdyn_screensharingprovider) </li> <li> Sender Mailbox (msdyn_mailbox) </li> <li> Show position in queue (msdyn_positioninqueue_enabled) </li> <li> Show widget during offline hours (msdyn_showwidgetduringofflinehours) </li> <li> Status (statecode) </li> <li> Status Reason (statuscode) </li> <li> Subtitle (msdyn_widgetsubtitle) </li> <li> Survey (msdyn_postconversationsurvey) </li> <li> Survey Mode (msdyn_postconversationsurveymode) </li> <li> Theme Color (msdyn_widgetthemecolor) </li>  <li> Title (msdyn_widgettitle) </li> <li> Turn on reconnect to previous chat (msdyn_enablechatreconnect) </li> <li> Turn on sound notifications (msdyn_widgetsoundnotification) </li> <li> Turn on unread messages indicator (msdyn_widgetvisualnotification) </li> <li> Work stream (msdyn_liveworkstreamid)</li></ul> |
   | Chat Authentication Settings (msdyn_authenticationsettings) | <ul> <li> Authentication type (msdyn_authenticationtype) </li><li> Chat Authentication Settings (msdyn_authenticationsettingsid) </li> <li> JavaScript client function (msdyn_javascriptclientfunction) </li> <li> Name (msdyn_name) </li> <li> Public key URL (msdyn_publickeyurl) </li> <li> Status (statecode) </li><li> Status Reason (statuscode) </li> </ul> |
   | Live Chat Context (msdyn_livechatengagementctx) | <ul><li>Browser (msdyn_browser) </li><li> Chat Widget App ID (msdyn_widgetappid) </li><li> City (msdyn_city) </li><li> Conversation (msdyn_liveworkitemid) </li><li> Country/Region (msdyn_country) </li> <li> Device (msdyn_device) </li> <li> Is Authenticated Engagement (msdyn_isauthenticated) </li><li> Is Proactivechat (msdyn_isproactivechat) </li><li> Latitude (msdyn_latitude) </li><li> Live Chat Context (msdyn_livechatengagementctxid) </li><li> Live Chat Engagement ID (msdyn_livechatengagementid) </li><li> Locale (msdyn_locale) </li><li> Longitude (msdyn_longitude) </li> <li> Name (msdyn_name) </li><li> Operating System (msdyn_os) </li><li> Origin Url (msdyn_originurl) </li><li> Portal Contact ID (msdyn_portalcontactid) </li> <li> State/Province (msdyn_state) </li><li> Status (statecode) </li><li> Status Reason (statuscode) </li><li> Street 1 (msdyn_street1) </li><li> Street 2 (msdyn_street2) </li><li> Street 3 (msdyn_street3) </li> <li> Zip/Postal Code (msdyn_postalcode)</li></ul> |
   | Localization (msdyn_oclocalizationdata) |  <ul> <li> Automated message (msdyn_systemmessageid) </li> <li> Default Localized Text (msdyn_defaultlocalizedtext) </li><li> Entity Column Name (msdyn_entitycolumnname) </li><li> Entity Name (msdyn_entityname) </li><li> Entity Record ID (msdyn_entityrecordid) </li> <li> Is default (msdyn_isdefault) </li><li> Language code (msdyn_customerlanguageid) </li><li> Language Code (msdyn_languagecode)  </li><li> Localization (msdyn_oclocalizationdataid)  </li><li> Localized text (msdyn_localizedtext) </li> <li> Organization ID (organizationid) </li> <li> Status (statecode) </li><li> Status Reason (statuscode) </li> </ul> |
   | Message (msdyn_ocsystemmessage) |  <ul> <li> Channel (msdyn_streamsource)  </li> <li> Default language (msdyn_defaultlanguage) </li> <li> Instance ID (msdyn_instanceid)  </li><li> Message (msdyn_ocsystemmessageid)  </li><li> Message description (msdyn_messagedescription)  </li><li> Message recipient (msdyn_messagereceiver)  </li><li> Message template trigger (msdyn_messagetemplatetrigger)  </li><li> Message Text (msdyn_messagetext)  </li><li> Message trigger (msdyn_systemmessageeventtype)  </li><li> Message type (msdyn_messagetype)  </li> <li> Name (msdyn_name)  </li><li> Organization ID (organizationid) </li> <li> Status (statecode) </li><li> Status Reason (sttuscode) </li><li> Widget (msdyn_widgetid) </li></ul> |
   | Survey Answer Option (msdyn_chatansweroption)  | <ul> <li> Name (msdyn_name) </li> <li> Status (statecode) </li><li> Status Reason (statuscode) </li><li> Survey Answer Option (msdyn_chatansweroptionid)  </li><li> Survey question (msdyn_answeroptionsid)    </li></ul> |
   | Survey Question (msdyn_surveyquestion)  | <ul> <li>Answer type (msdyn_answertyp) </li><li> Help Text (msdyn_placeholdertext)  </li> <li> Question name (msdyn_nam)   </li><li> Question text (msdyn_questiontext)  </li><li> Rating Scale (msdyn_ratingscal)  </li> <li> Status (statecod)  </li><li> Status Reason (statuscod)  </li><li> Survey Question (msdyn_surveyquestionid)  </li><li> Work stream (msdyn_liveworkstreamtochatquestion)<li></ul> |
   | Survey Question Sequence (msdyn_questionsequence)    | <ul> <li>-	Chat widget (msdyn_chatengagementtochatsequenceid) </li><li> Name (msdyn_name)  </li><li> Order (sequencenumber)  </li> <li> Required (msdyn_questionrequired)  </li><li> Status (statecode)  </li><li> Status Reason (statuscode)  </li><li> Survey question name (msdyn_surveyquestion)  </li><li> Survey Question Sequence (msdyn_questionsequenceid)  </li><li> Survey type (msdyn_chatquestionnairetype) </li></ul> |
   | Survey Response(msdyn_chatquestionnaireresponse) | <ul> <li> Name (msdyn_name)  </li><li> Status (statecode) </li><li> Status Reason (statuscode) </li><li> Survey answer option (msdyn_chatansweroptionid)  </li><li> Survey answer text (msdyn_chatanswertext)  </li><li> Survey Question ID (msdyn_surveyquestionid)  </li><li> Survey response (msdyn_chatquestionnaireresponseid)  </li><li> Survey Response Values (msdyn_chatquestionnaireresponseitemid) </li></ul> |
   | Chat Widget Location (msdyn_livechatwidgetlocation) |  <ul> <li> Chat widget (msdyn_livechatconfigid) </li><li> Chat Widget Location (msdyn_livechatwidgetlocationid) </li><li> Location URL Wildcard (msdyn_locationurlwildcard) </li><li> Modified By (modifiedby) </li> <li> Rule Type (msdyn_ruletype) </li><li> Status (statecode) </li><li> Status Reason (statuscode) </li><li> Title (msdyn_name  </li><li> Value (msdyn_domainvalue) </li></ul> |
   | Chat Widget Language (msdyn_chatwidgetlanguage) |  <ul> <li> Chat Widget Language (msdyn_chatwidgetlanguageid)  </li><li> Language Name (msdyn_languagename) </li><li> Locale ID (msdyn_localeid)  </li><li> Status (statecode)  </li><li> Status Reason (statuscode)  </li></ul> |
   | Localized Survey Question (msdyn_localizedsurveyquestion) | <ul> <li> Description (msdyn_description)  </li><li> Language Code (msdyn_languagecode)  </li><li> Localized Question Text (msdyn_localizedquestiontext)  </li><li> Localized Survey Question (msdyn_localizedsurveyquestionid)  </li><li> Name (msdyn_name)  </li> <li> Status (statecode) </li><li> Status Reason (statuscode) </li><li> Survey Question (msdyn_surveyquestionid)  </li></ul> |
   | Geolocation Provider(msdyn_oc_geolocationprovider) | <ul> <li> Bing Maps API key (msdyn_providerapikey)  </li><li> Geo Location Provider (msdyn_oc_geolocationproviderid)  </li><li> Name (msdyn_name)  </li><li> Provider API Key Version (msdyn_providerapikeyversion)  </li><li> Provider name (msdyn_providername)  </li><li> Status (statecode)  </li><li> Status Reason (statuscode) </li></ul> |

1. Generate the schema and save it.

1. Export the data and generate the compressed (zip) file.

1. Use the Configuration Migration tool, select the option to import data, and then select the compressed file.

### FetchXML for live chat<a name="BKMKlive-chat"></a>

```XML
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
