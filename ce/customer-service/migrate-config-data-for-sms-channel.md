---
title: Migrate configuration data for SMS channel
description: Learn to migrate data pertaining to SMS channel from source to target environments in Customer Service workspace.
author: venki-ms
ms.author: v-duddupdiv
ms.reviewer: nenellim
ms.topic: how-to
ms.date: 08/24/2023
ms.custom: bap-template
---

# Migrate configuration data for SMS channel

Use the Configuration Migration tool to migrate the configurations from the source organization to the target organization for SMS. 

For information on how to use the Configuration Migration tool, see the following articles: 

- [Download Configuration Migration tool](/powerapps/developer/data-platform/download-tools-nuget)
- [How the Configuration Migration tool works](/power-platform/admin/manage-configuration-data)

## Prerequisites

The following prerequisites must be met:

- In the source environment, if a unified routing ruleset refers to the following, then ensure that they exist in the target organization before you proceed with the migration:
 	- Custom entities
 	- Attributes
 	- Relationships
 	- Option sets
 	- Lookup values

- Ensure that the user who performs the migration has the required privileges on the following unified routing entities in the source and target environments:
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
 	- Quick replies (`msdyn_cannedmessages`) 
 	- Tags (`msdyn_octags`)

> [!IMPORTANT]  
> The migration of the account, channel provider, phone number, bot configuration, and AI and analytics settings is not in scope.

## Migrate SMS configuration

You must perform the steps in the order they're listed to migrate your configuration data successfully. Use the information in the tables and refer to the corresponding sample schemas for each configuration.

1. Migrate configuration using a solution
2. Migrate configuration for skill-based routing
3. Migrate configuration for capacity profiles
4. Migrate configuration for SMS queues
5. Migrate configuration for SMS workstreams
6. Migrate configuration for SMS channels
7. Verify your migration
8. Troubleshoot migration of data

## Migrate configuration using a solution

If you use custom session templates and notifications in your SMS routing setup, perform the steps outlined in [Migrate configuration using a solution](migrate-config-data-for-records.md#migrate-configuration-using-a-solution)

## Migrate skill-based configuration

If skill-based routing rulesets are used in your SMS routing setup, perform the steps outlined in [Export and import data for skill-based routing](migrate-config-data-for-records.md#migrate-configuration-for-skill-based-routing-rulesets). Make sure to adjust any filtering fetch xml appropriately for SMS.

## Migrate configuration for capacity profiles

If you have configured capacity profiles in your SMS routing setup, perform the steps outlined in [Export and import data for capacity profiles](migrate-config-data-for-records.md#migrate-configuration-for-capacity-profiles). Make sure to adjust any filtering fetch xml appropriately for SMS. 

## Migrate configuration for SMS queues

For migrating queues for SMS, perform the steps outlined in [Migrate data for unified routing-based record queues](migrate-config-data-for-records.md#migrate-configuration-for-record-queues). Make sure to adjust any filtering fetch xml appropriately for SMS.

##  Migrate configuration for SMS workstreams

1. Use the Configuration Migration tool to create the schema and export data from the source organization for SMS workstreams.
	- **Entity display name**: When you create the schema, select the entities in the same sequence as mentioned in the table.
	- **Attribute display name**: We recommend that you select the attributes defined in the following table. You don't need to select the out-of-the-box system defined attributes like Created By, Created On, Modified By, Modified On, and Owner. You can select custom attributes, if necessary.
	- **Use FetchXML to filter records**: For each entity, use the appropriate FetchXML query that's mentioned in the following table to get single, multiple, or all records based on your requirement. For single or multiple records, you need to use source organization to get the correct name in uiname and GUID in value. If required, you can use the ADVANCED FIND menu item to construct the appropriate FetchXML query.
	- **Configure import settings**: For the Decision contract entity, ensure that you select the **Do not update existing records** checkbox.

2. Ensure that the workstreams that are referred in the configuration of the SMS channels are included in the migration.

    |S.No.|Entity display name (Logical name)  |Attribute display name (Logical name)  |Use FetchXML to filter records  |
    |---------|---------|---------|---------|
    |1.|Workstream (msdyn_liveworkstream)| <ul><li>API Key (msdyn_apikey) </li><li> API Key Version Number (msdyn_apikeyversionnumber)</li><li>Allow Automated Messages (msdyn_enableautomatedmessages) </li>Allowed Presences (msdyn_allowedpresences) </li><li> Assign WorkItem After Decline or Timeout (msdyn_assignworkitemafterdecline)</li><li>Auto-close after inactivity (msdyn_autocloseafterinactivity) </li><li>Block capacity for wrap up state (msdyn_blockcapacityforwrapup) </li><li>Bot queue (msdyn_bot_queue) </li><li>Bot rule (msdyn_bot_rule)</li><li>Bot user (msdyn_bot_user)</li><li>CallbackPreviewDialing (msdyn_notificationtemplate_callback_previewdialing)</li><li>Connectors (msdyn_connectorsurl) </li><li>Consult (msdyn_notificationtemplate_consult) </li><li>Conversation mode of chat channels (msdyn_conversationmode)</li><li>Customer ID (msdyn_customerid)</li><li>Customer Disconnect Hold Duration For Open Conversation (msdyn_customerdisconnectholddurationforopenconversation)</li><li>Capacity (msdyn_capacityrequired)</li><li>Capacity format (msdyn_capacityformat)</li><li>Channel (msdyn_streamsource)</li><li>Contract Id (msdyn_routingcontractid) </li><li>Default (msdyn_sessiontemplate_default)</li><li>Default Queue (msdyn_defaultqueue)</li><li>Direction (msdyn_direction)</li><li>Enable selecting from push-based work streams (msdyn_enableselectingfrompushbasedworkstreams)</li><li>Entity (msdyn_masterentityroutingconfigurationid)</li><li>FallBack Language (msdyn_fallbacklanguage)</li><li>Follow-up after waiting (msdyn_followupafterwaiting)</li><li>Handling Time Threshold (msdyn_handlingtimethreshold)</li><li>Incoming authenticated (msdyn_notificationtemplate_incoming_auth)</li><li>Incoming unauthenticated (msdyn_notificationtemplate_incoming_unauth)</li><li>Is Default (msdyn_isdefault)</li><li>Keep same agent for entire conversation (msdyn_enableagentaffinity)</li><li>Last Validation On (msdyn_lastvalidationon)</li><li>Last Validation Status (msdyn_lastvalidationstatus)</li><li>Matching Logic (msdyn_matchinglogic)</li><li>Max Concurrency (msdyn_maxconcurrentconnection)</li><li>Mode (msdyn_mode)</li><li>Name (msdyn_name)</li><li>Notification (msdyn_notification)</li><li>Notification scenario placeholder (msdyn_notificationscenarioplaceholder)</li><li>Outbound queue (msdyn_outboundqueueid)</li><li>Record Identification Rule (msdyn_recordidentificationrule)</li><li>Record Identification Validation Rule (msdyn_recordidentificationvalidationrule)</li><li>Restrict download of recording (msdyn_restrictdownloadrecording)</li><li>Restrict download of transcript (msdyn_restrictdownloadtranscript)</li><li>Screen pop timeout (msdyn_screenpoptimeout)</li><li>Screen pop timeout (msdyn_screenpoptimeout_optionSet)</li><li>Secure API Key (msdyn_secureapikey)</li><li>Skill Attachment Rules Count (msdyn_skillattachmentrulescount)</li><li>Skill Attachment Rules Count (Last Updated On) (msdyn_skillattachmentrulescount_date)</li><li>Skill Attachment Rules Count (State) (msdyn_skillattachmentrulescount_state)</li><li>Session scenario placeholder (msdyn_sessionscenarioplaceholder)</li><li>SupervisorAssign (msdyn_notificationtemplate_supervisorassign)</li><li>Transfer (msdyn_notificationtemplate_transfer)</li><li>Waiting Time Threshold (msdyn_waitingtimethreshold)</li><li>Work Distribution Mode (msdyn_workdistributionmode)</li><li>Work Stream (msdyn_liveworkstreamid)|[**Sample 1: All SMS workstreams**](#BKMK1smsw)<br><br>[**Sample 2: Single SMS workstream**](#BKMK2smsw)<br><br>[**Sample 3: Multiple SMS workstreams**](#BKMK3smsw)|
	|2.|Context Variable (msdyn_ocliveworkstreamcontextvariable)|<ul><li>Name (msdyn_name) </li><li> Relation Ship Name (msdyn_relationshipname) </li><li> Type (msdyn_datatype) </li><li> Work stream (msdyn_liveworkstreamid) </li><li> IsList (msdyn_islist) </li><li> Modifiable (msdyn_ismodifiable) </li><li> Display Name (msdyn_displayname) </li><li> Displayable (msdyn_isdisplayable) </li><li> Entity Logical Name (msdyn_entitylogicalname) </li><li> Context variable (msdyn_ocliveworkstreamcontextvariableid) </li><li> Status (statecode) </li><li> Status Reason (statuscode) </li><li> System Defined (msdyn_issystemdefined) </li></ul>|[**Sample 1: Context Variables for all SMS workstreams**](#BKMK1smswcv)<br><br> [**Sample 2: Context variables for a single SMS workstream**](#BKMK2smswcv) <br><br> [**Sample 3: Context Variables for multiple SMS workstreams**](#BKMK3smswcv) |
	|3.|Decision contract (msdyn_decisioncontract)|<ul><li>Contract definition (msdyn_contractdefinition) </li><li> Decision contract (msdyn_decisioncontractid) </li><li> Name (msdyn_name) </li><li> Unique name (msdyn_uniquename) </li></ul>|[**Sample 1: Decision contract for all SMS workstreams**](#BKMK1smswdc) <br><br>[**Sample 2: Decision contract for a single SMS workstream**](#BKMK2smswdc)<br><br>[**Sample 3: Decision contract for multiple SMS workstreams**](#BKMK3smswdc) |
	|4.|Decision rule set (msdyn_decisionruleset)|<ul><li>AI builder model (msdyn_aibmodelid) </li><li> Authoring mode (msdyn_authoringmode) </li><li> Decision rule set (msdyn_decisionrulesetid) </li><li> Description (msdyn_description) </li><li> Input contract (msdyn_inputcontractid) </li><li> Is input collection (msdyn_isinputcollection) </li><li> ML model type (msdyn_mlmodeltype) </li><li> Name (msdyn_name) </li><li> Output contract (msdyn_outputcontractid) </li><li> Rule set definition (msdyn_rulesetdefinition) </li><li> Rule set type (msdyn_rulesettype) </li><li> Unique name (msdyn_uniquename) </li></ul>|[**Sample 1: Decision ruleset for all SMS workstreams**](#BKMK1smswdrs)<br><br>[**Sample 2: Decision ruleset for a single SMS workstream**](#BKMK2smswdrs) <br><br>[**Sample 3: Decision ruleset for multiple SMS workstreams**](#BKMK3smswdrs) |
   |5.|Routing configuration (msdyn_routingconfiguration)|<ul><li>Is active configuration (msdyn_isactiveconfiguration) </li><li> Name (msdyn_name) </li><li> Routing configuration (msdyn_routingconfigurationid) </li><li> Unique name (msdyn_uniquename) </li><li> Workstream (msdyn_liveworkstreamid) </li></ul>|[**Sample 1: Routing configuration for all SMS workstreams**](#BKMK1smswrc)<br><br>[**Sample 2: Routing configuration for a single SMS workstream**](#BKMK2smswrc) <br><br>[**Sample 3: Routing configuration for multiple SMS workstreams**](#BKMK3smswrc) |
   |6.|Routing configuration step (msdyn_routingconfigurationstep)|<ul><li>Name (msdyn_name) </li><li> Routing configuration (msdyn_routingconfigurationid) </li><li> Routing configuration step (msdyn_routingconfigurationstepid) </li><li> Rule set (msdyn_rulesetid) </li><li> Step order (msdyn_steporder) </li><li> Step type (msdyn_type) </li><li> Unique name (msdyn_uniquename) </li></ul>|[**Sample 1: Routing configuration step for all SMS workstreams**](#BKMK1smswrcs)<br><br>[**Sample 2: Routing configuration step for a single SMS workstream**](#BKMK2smswrcs) <br><br>[**Sample 3: Routing configuration step for multiple SMS workstreams**](#BKMK3smswrcs)|
   |7.|Workstream capacity profile (msdyn_liveworkstreamcapacityprofile)|<ul><li>Capacity Profile (msdyn_capacityprofile_id) </li><li> Name (msdyn_name) </li><li> Workstream (msdyn_workstream_id) </li><li> Workstream Capacity profile (msdyn_liveworkstreamcapacityprofileid) </li></ul>|[**Sample 1: Workstream capacity profile for all SMS workstreams**](#BKMK1smswwcp)<br><br>[**Sample 2: Workstream capacity profile for a single SMS workstream**](#BKMK2smswwcp)<br><br>[**Sample 3: Workstream capacity profile for multiple SMS workstreams**](#BKMK3smswwcp) |
   |8.|Tag (msdyn_octag)|<ul><li>Name (msdyn_name) </li><li> Tag (msdyn_octagid) </li></ul>||

3. Generate the schema and save it.

4. Export the data and generate the compressed (zip) file.

5. Use the Configuration Migration tool, and select the option to import data, and select the compressed file.

> [!IMPORTANT]
> When you fetch decision rulesets (msdyn_decisionrulesets) containing context variables, some decision rulesets are created without the dependency mappings. To work around this, perform the following steps:
> 1. Import data for all entities including the decision ruleset entity (msdyn_decisionrulesets).
> 2. Import data for the decision ruleset entity again. This step ensures that all dependency mappings for the decision rulesets are imported.

For sample schema to get all the required records, see [Sample schema for SMS workstream]().

### FetchXML for workstream entity

**Sample 1: All SMS workstreams**<a name="BKMK1smsw"></a>

```XML
<fetch distinct="true">
	<entity name="msdyn_liveworkstream">
		<filter type="and">
			<condition attribute="msdyn_mode" operator="eq" value="717210001" />
			<condition attribute="msdyn_streamsource" operator="eq" value="192340000" />
		</filter>
	</entity>
</fetch>
```

**Sample 2: Single SMS workstream**<a name="BKMK2smsw"></a>

```XML
<fetch>
	<entity name="msdyn_liveworkstream">
		<filter type="and">
			<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Test SMS workstream 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312ABC}" />
		</filter>
	</entity>
</fetch>
```

**Sample 3: Multiple SMS workstreams**<a name="BKMK3smsw"></a>

```XML
<fetch version="1.0" output-format="xml-platform" mapping="logical" distinct="false">
	<entity name="msdyn_liveworkstream">
		<filter type="and">
			<condition attribute="msdyn_liveworkstreamid" operator="in">
				<value uiname="Test SMS workstream 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312ABC}</value>
				<value uiname="Test SMS workstream 2" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44098}</value>
			</condition>
		</filter>
	</entity>
</fetch>
```
### FetchXML for context variables entity

**Sample 1: All SMS workstreams context variables**<a name="BKMK1smswcv"></a>

```XML
<fetch>
	<entity name="msdyn_ocliveworkstreamcontextvariable" >
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="aa" >
			<filter type="and" >
				<condition attribute="msdyn_streamsource" operator="eq" value="192340000" />
				<condition attribute="msdyn_mode" operator="eq" value="717210001" />
			</filter>
		</link-entity>
	</entity>
</fetch>
```
**Sample 2: Single SMS workstream context variables**<a name="BKMK2smswcv"></a>

```XML
<fetch>
	<entity name="msdyn_ocliveworkstreamcontextvariable" >
		<filter type="and" >
			<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="SMS workstream" uitype="msdyn_liveworkstream" value="{D3A1F09D-51A0-A6B7-266D-58E1BDB97B53}" />
		</filter>
	</entity>
</fetch>
```
**Sample 3: Multiple SMS workstreams context variables**<a name="BKMK3smswcv"></a>

```XML
<fetch>
	<entity name="msdyn_ocliveworkstreamcontextvariable" >
		<filter type="or" >
			<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="SMS workstream" uitype="msdyn_liveworkstream" value="{D3A1F09D-51A0-A6B7-266D-58E1BDB97B53}" />
			<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="SMS workstream 1" uitype="msdyn_liveworkstream" value="{f9e18e67-d1a8-ed11-aad1-00224805c057}" />
		</filter>
	</entity>
</fetch>
```
### FetchXML for decision contract entity

**Sample 1: Decision contract for all SMS workstreams**<a name="BKMK1smswdc"></a>

```XML
<fetch distinct="true" >
	<entity name="msdyn_decisioncontract" >
		<filter type="or" >
			<filter type="and" >
				<condition attribute="msdyn_mode" entityname="an" operator="eq" value="717210001" />
				<condition attribute="msdyn_streamsource" entityname="an" operator="eq" value="192340000" />
			</filter>
			<filter type="and" >
				<condition attribute="msdyn_mode" entityname="bd" operator="eq" value="717210001" />
				<condition attribute="msdyn_streamsource" entityname="bd" operator="eq" value="192340000" />
			</filter>
			<filter type="and" >
				<condition attribute="msdyn_mode" entityname="bk" operator="eq" value="717210001" />
				<condition attribute="msdyn_streamsource" entityname="bk" operator="eq" value="192340000" />
			</filter>
		</filter>
		<link-entity name="msdyn_liveworkstream" from="msdyn_routingcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="an" />
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="ba" >
			<link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bb" >
				<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="bc" >
					<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="bd" />
				</link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bh" >
			<link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bi" >
				<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="bj" >
					<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="bk" />
				</link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bo" >
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bp" />
		</link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bs" >
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bt" />
		</link-entity>
	</entity>
</fetch>
```

**Sample 2: Decision contract for a single SMS workstream**<a name="BKMK2smswdc"></a>

```XML
<fetch distinct="true" >
	<entity name="msdyn_decisioncontract" >
		<filter type="or" >
			<filter type="and" >
				<condition attribute="msdyn_liveworkstreamid" entityname="an" operator="eq" uiname="SMS workstream" uitype="msdyn_liveworkstream" value="{d3a1f09d-51a0-a6b7-266d-58e1bdb97b53}" />
			</filter>
			<filter type="and" >
			<condition attribute="msdyn_liveworkstreamid" entityname="bd" operator="eq" uiname="SMS workstream" uitype="msdyn_liveworkstream" value="{d3a1f09d-51a0-a6b7-266d-58e1bdb97b53}" />
			</filter>
			<filter type="and" >
			<condition attribute="msdyn_liveworkstreamid" entityname="bk" operator="eq" uiname="SMS workstream" uitype="msdyn_liveworkstream" value="{d3a1f09d-51a0-a6b7-266d-58e1bdb97b53}" />
			</filter>
		</filter>
		<link-entity name="msdyn_liveworkstream" from="msdyn_routingcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="an" />
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="ba" >
			<link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bb" >
				<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="bc" >
					<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="bd" />
				</link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bh" >
			<link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bi" >
				<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="bj" >
					<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="bk" />
				</link-entity>
			</link-entity>
		</link-entity>
	</entity>
</fetch>
```

**Sample 3: Decision contract for multiple SMS workstreams**<a name="BKMK3smswdc"></a>

```XML
<fetch distinct="true" >
	<entity name="msdyn_decisioncontract" >
		<filter type="or" >
			<filter type="and" >
				<filter type="or" >
					<condition attribute="msdyn_liveworkstreamid" entityname="an" operator="eq" uiname="SMS workstream 1" uitype="msdyn_liveworkstream" value="{d3a1f09d-51a0-a6b7-266d-58e1bdb97b53}" />
					<condition attribute="msdyn_liveworkstreamid" entityname="an" operator="eq" uiname="SMS workstream 2" uitype="msdyn_liveworkstream" value="{bb3cf09d-51a0-f56b-211b-58e1bdb97b44}" />
				</filter>
			</filter>
			<filter type="and" >
				<filter type="or" >
					<condition attribute="msdyn_liveworkstreamid" entityname="bd" operator="eq" uiname="SMS workstream 1" uitype="msdyn_liveworkstream" value="{d3a1f09d-51a0-a6b7-266d-58e1bdb97b53}" />
					<condition attribute="msdyn_liveworkstreamid" entityname="bd" operator="eq" uiname="SMS workstream 2" uitype="msdyn_liveworkstream" value="{bb3cf09d-51a0-f56b-211b-58e1bdb97b44}" />
				</filter>
			</filter>
			<filter type="and" >
				<filter type="or" >
					<condition attribute="msdyn_liveworkstreamid" entityname="bk" operator="eq" uiname="SMS workstream 1" uitype="msdyn_liveworkstream" value="{d3a1f09d-51a0-a6b7-266d-58e1bdb97b53}" />
					<condition attribute="msdyn_liveworkstreamid" entityname="bk" operator="eq" uiname="SMS workstream 2" uitype="msdyn_liveworkstream" value="{bb3cf09d-51a0-f56b-211b-58e1bdb97b44}" />
				</filter>
			</filter>
		</filter>
		<link-entity name="msdyn_liveworkstream" from="msdyn_routingcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="an" />
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="ba" >
			<link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bb" >
				<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="bc" >
					<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="bd" />
				</link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bh" >
			<link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bi" >
				<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="bj" >
					<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="bk" />
				</link-entity>
			</link-entity>
		</link-entity>
	</entity>
</fetch>
```
### FetchXML for decision ruleset entity

**Sample 1: Decision ruleset for all SMS workstreams**<a name="BKMK1smswdrs"></a>

```XML
<fetch distinct="true" >
	<entity name="msdyn_decisionruleset" >
		<filter type="or" >
			<filter type="and" >
				<condition attribute="msdyn_mode" entityname="af" operator="eq" value="717210001" />
				<condition attribute="msdyn_streamsource" entityname="af" operator="eq" value="192340000" />
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
**Sample 2: Decision ruleset for a single SMS workstream**<a name="BKMK2smswdrs"></a>

```XML
<fetch distinct="true" >
	<entity name="msdyn_decisionruleset" >
		<filter type="or" >
			<filter type="and" >
				<condition attribute="msdyn_liveworkstreamid" entityname="af" operator="eq" uiname="SMS workstream" uitype="msdyn_liveworkstream" value="{d3a1f09d-51a0-a6b7-266d-58e1bdb97b53}" />
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
**Sample 3: Decision ruleset for multiple SMS workstreams**<a name="BKMK3smswdrs"></a>

```XML
<fetch distinct="true" >
	<entity name="msdyn_decisionruleset" >
		<filter type="or" >
			<filter type="or" >
				<condition attribute="msdyn_liveworkstreamid" entityname="af" operator="eq" uiname="SMS workstream" uitype="msdyn_liveworkstream" value="{d3a1f09d-51a0-a6b7-266d-58e1bdb97b53}" />
				<condition attribute="msdyn_liveworkstreamid" entityname="af" operator="eq" uiname="SMS workstream 1" uitype="msdyn_liveworkstream" value="{f9e18e67-d1a8-ed11-aad1-00224805c057}" />
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

**Sample 1: Routing configuration for all SMS workstreams**<a name="BKMK1smswrc"></a>

```XML
<fetch>
	<entity name="msdyn_routingconfiguration">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ah">
			<filter type="and">
				<condition attribute="msdyn_mode" operator="eq" value="717210001" />
				<condition attribute="msdyn_streamsource" operator="eq" value="192340000" />
			</filter>
		</link-entity>
	</entity>
</fetch>
```
**Sample 2: Routing configuration for a single SMS workstream**<a name="BKMK2smswrc"></a>

```XML
<fetch>
	<entity name="msdyn_routingconfiguration">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ah">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Test SMS workstream 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312ABC}" />
			</filter>
		</link-entity>
	</entity>
</fetch>
```

**Sample 3: Routing configuration for multiple SMS workstreams**<a name="BKMK3smswrc"></a>

```XML
<fetch>
	<entity name="msdyn_routingconfiguration">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ah">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="in">
					<value uiname="Test SMS Workstream 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312ABC}</value>
					<value uiname="Test SMS Workstream 2" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44098}</value>
				</condition>
			</filter>
		</link-entity>
	</entity>
</fetch>
```

### FetchXML for routing configuration step entity

**Sample 1: Routing configuration step for all SMS workstreams**<a name="BKMK1smswrcs"></a>

```XML
<fetch>
	<entity name="msdyn_routingconfigurationstep">
		<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="inner" alias="ak">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="al">
				<filter type="and">
					<condition attribute="msdyn_mode" operator="eq" value="717210001" />
					<condition attribute="msdyn_streamsource" operator="eq" value="192340000" />
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch>
```

**Sample 2: Routing configuration step for a single SMS workstream**<a name="BKMK2smswrcs"></a>

```XML
<fetch>
	<entity name="msdyn_routingconfigurationstep">
		<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="inner" alias="ak">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="al">
				<filter type="and">
					<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Test SMS workstream 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}" />
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch>
```

**Sample 3: Routing configuration step for multiple SMS workstreams**<a name="BKMK3smswrcs"></a>

```XML
<fetch>
	<entity name="msdyn_routingconfigurationstep">
		<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="inner" alias="ak">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="al">
				<filter type="and">
					<condition attribute="msdyn_liveworkstreamid" operator="in">
						<value uiname="Test SMS workstream 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312ABC}</value>
						<value uiname="Test SMS workstream 2" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44098}</value>
					</condition>
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch>
```

### FetchXML for workstream capacity profile entity

**Sample 1: Workstream capacity profile for all SMS workstreams**<a name="BKMK1smswwcp"></a>

```XML
<fetch>
	<entity name="msdyn_liveworkstreamcapacityprofile">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_workstream_id" link-type="inner" alias="am">
			<filter type="and">
				<condition attribute="msdyn_mode" operator="eq" value="717210001" />
				<condition attribute="msdyn_streamsource" operator="eq" value="192340000" />
			</filter>
		</link-entity>
	</entity>
</fetch>
```

**Sample 2: Workstream capacity profile for a single SMS workstream**<a name="BKMK2smswwcp"></a>

```XML
<fetch>
	<entity name="msdyn_liveworkstreamcapacityprofile">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_workstream_id" link-type="inner" alias="am">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Test SMS workstream 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}" />
			</filter>
		</link-entity>
	</entity>
</fetch>
```
**Sample 3: Workstream capacity profile for multiple SMS workstreams**<a name="BKMK3smswwcp"></a>

```XML
<fetch>
	<entity name="msdyn_liveworkstreamcapacityprofile">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_workstream_id" link-type="inner" alias="am">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="in">
					<value uiname="Test SMS Workstream 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}</value>
					<value uiname="Test SMS Workstream 2" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44215}</value>
				</condition>
			</filter>
		</link-entity>
	</entity>
</fetch>
```
## Migrate configuration for SMS channels

Assume that the workstream must exist whether it was created manually or previously migrated to the destination organization.

**To migrate data for SMS channels**

1. Use the Configuration Migration tool to create the schema and export data from the source organization for the SMS channel and related entities.
	- **Entity display name**: When you create the schema, select the entities in the sequence as mentioned in the table.
	- **Attribute display name**: We recommend that you select the attributes defined in the following table. You don't have to select the system-defined attributes, such as Created By, Created On, Modified By, Modified On, and Owner. You can select custom attributes if necessary.

	| S.No. | Entity display name (Logical name) | Attribute display name (Logical name) |
   	|--------|---------|---------|
	|1.|SMS Number Setting (msdyn_ocsmschannelsetting)|[FetchXML to filter records for SMS channel settings](#BKMK1sms) <br> **Note:** <br> - Replace the value for msdyn_liveworkstream in the condition section. <br> - You need to include Phone Number (msdyn_phonenumberid) column even though data is invalid, as the records in Phone Number table are environment-specific and can’t be migrated. You need to fix phone number manually in destination environment after migration. If you aren't allowed to perform this action for any reason, you can manually edit data.xml file inside the exported zip file and replace its value with the correct phone number GUID in the destination environment. <br> - Don't include Survey (msdyn_postconversationsurvey) and Survey (msdyn_postconversationsurveyseparatebotsurvey) columns as survey records are synced with Dynamics 365 Customer Voice in each environment, so they can’t be migrated. <br> - Ensure as part of the entity declaration in the schema that the plugin is disabled. (disableplugins="false") <br> <ul><li> Bot Survey (msdyn_postconversationsurveybotsurvey)</li><li> Enable (msdyn_postconversationsurveyenable)</li><li> Enable file attachments for agents (msdyn_enablefileattachmentforagents)</li><li> Enable file attachments for customers (msdyn_enablefileattachmentforcustomers)</li><li> Message (msdyn_postconversationsurveybotsurveymessagetext)</li><li> Message (msdyn_postconversationsurveymessagetext)</li><li> Name (msdyn_name)</li><li> ocsmschannelsetting (msdyn_ocsmschannelsettingid)</li><li> Operating hours (msdyn_operatinghoursid)</li><li> Phone Number (msdyn_phonenumberid)</li><li> SMS number language (msdyn_language)</li><li> Survey Mode (msdyn_postconversationsurveybotsurveymode)</li><li> Survey Mode (msdyn_postconversationsurveymode)</li><li> Work stream (msdyn_liveworkstreamid)</li></ul>|
	|2.|Localization (msdyn_oclocalizationdata)|[FetchXML to filter records for SMS channel localizations](#BKMK2sms) <br> <ul> <li> Automated message (msdyn_systemmessageid)</li><li> Default Localized Text (msdyn_defaultlocalizedtext)</li><li> Entity Column Name (msdyn_entitycolumnname)</li><li> Entity Name (msdyn_entityname)</li><li> Entity Record ID (msdyn_entityrecordid)</li><li> Is default (msdyn_isdefault)</li><li> Language code (msdyn_customerlanguageid)</li><li> Language Code (msdyn_languagecode)</li><li> Localization (msdyn_oclocalizationdataid)</li><li> Localized text (msdyn_localizedtext)</li><li> Organization ID (organizationid)</li><li> Status (statecode)</li><li> Status Reason (statuscode)</li></ul>|
	|3.|Message (msdyn_ocsystemmessage)|<ul> <li> Channel (msdyn_streamsource) </li><li> Default language (msdyn_defaultlanguage) </li><li> Instance ID (msdyn_instanceid) </li><li> Message (msdyn_ocsystemmessageid) </li><li> Message description (msdyn_messagedescription)</li><li> Message recipient (msdyn_messagereceiver) </li><li> Message template trigger (msdyn_messagetemplatetrigger)</li><li> Message Text (msdyn_messagetext) </li><li> Message trigger (msdyn_systemmessageeventtype) </li><li> Message type (msdyn_messagetype) </li><li> Name (msdyn_name) </li><li> Organization ID (organizationid) </li> <li> Status (statecode) </li><li> Status Reason (statuscode) </li></ul>|

2. Generate the schema and save it.
3. Export the data and generate the compressed (zip) file.
4. Use the Configuration Migration tool, select the option to import data, and then select the compressed file.

### FetchXML for SMS channel settings<a name="BKMK1sms"></a>

```XML
<fetch>
	<entity name=" msdyn_ocsmschannelsetting">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ab">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="ALM SMS Test Workstream" uitype="msdyn_liveworkstream" value="{87bf4384-a02f-4802-8be7-1d6884a7e73f}" />
			</filter>
		</link-entity>
	</entity>
</fetch>
```
### FetchXML for SMS channel localizations<a name="BKMK2sms"></a>

```XML
<fetch>
	<entity name="msdyn_oclocalizationdata">
		<link-entity name="msdyn_ocsystemmessage" from="msdyn_ocsystemmessageid" to="msdyn_systemmessageid" link-type="inner" alias="ah">
			<filter type="and">
				<condition attribute="msdyn_streamsource" operator="eq" value="192360000"/>
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