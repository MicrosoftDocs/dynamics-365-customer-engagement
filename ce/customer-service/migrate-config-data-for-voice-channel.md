---
title: "Migrate unified routing data for the voice channel | MicrosoftDocs"
description: "Learn to migrate the voice channel data from source to target environments in Omnichannel for Customer Service."
ms.date: 08/23/2023
ms.topic: article
author: mgandham
ms.author: nenellim
ms.reviewer: nenellim
---

# Migrate data for the voice channel

Use the Configuration Migration tool to migrate the configurations from the source organization to the target organization for the voice channel.

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

> [!IMPORTANT]
>
> The migration of the account, channel, Azure Communication Services phone number acquisition, phone number configuration, bot configuration, and AI and analytics settings is not in scope.

## Migrate the voice channel configuration

You must perform the steps in the order they're listed to migrate your configuration data successfully. Use the information in the tables and refer to the corresponding sample schemas for each configuration.

1. Migrate configuration using a solution
1. Export and import configuration for skill-based routing
1. Export and import configuration for capacity profiles
1. Export and import configuration for voice channel queues
1. Export and import configuration for voice channel workstreams
1. Migrate configuration for voice channels
1. Verify your migration
1. Troubleshoot export and import of data


## Migrate configuration using a solution

If you use custom session templates and notifications in your voice routing setup, perform the steps outlined in [Migrate configuration using a solution](migrate-config-data-for-records.md#migrate-configuration-using-a-solution)

## Migrate skill-based configuration

If skill-based routing rulesets are used in your unified routing setup, perform the steps outlined in [Migrate data for skill-based routing](migrate-config-data-for-records.md#migrate-configuration-for-skill-based-routing-rulesets).

## Migrate configuration capacity profiles

If you have configured capacity profiles in your voice routing setup, perform the steps outlined in [Export and import data for capacity profiles](migrate-config-data-for-records.md#migrate-configuration-for-capacity-profiles).

## Migrate configuration for voice channel queues

For exporting and importing queues for the voice channel, perform the steps outlined in [Migrate data for unified routing-based record queues](migrate-config-data-for-records.md#migrate-configuration-for-record-queues).

## Migrate configuration for voice channel workstreams

1. Use the Configuration Migration tool to create the schema and export data from the source organization for voice workstreams.
	- **Entity display name**: When you create the schema, select the entities in the same sequence as mentioned in the table.
	- **Attribute display name**: We recommend that you select the attributes defined in the following table. You don't need to select the out-of-the-box system defined attributes like Created By, Created On, Modified By, Modified On, and Owner. You can select custom attributes, if necessary.
	- **Use FetchXML to filter records**: For each entity, use the appropriate FetchXML query that's mentioned in the following table to get single, multiple, or all records based on your requirement. For single or multiple records, you need to use source organization to get the correct name in uiname and GUID in value. If required, you can use the ADVANCED FIND menu item to construct the appropriate FetchXML query.
	- **Configure import settings**: For the Decision contract entity, ensure that you select the **Do not update existing records** checkbox.

2. Ensure that the workstreams that're referred in the configuration of the voice channels are included in the migration.

  |S.No.|Entity display name (Logical name)  |Attribute display name (Logical name)  |Use FetchXML to filter records  |
    |---------|---------|---------|---------|
    |1.|Workstream (msdyn_liveworkstream)| <ul><li>API Key (msdyn_apikey) </li><li> API Key Version Number (msdyn_apikeyversionnumber)</li><li>Allow Automated Messages (msdyn_enableautomatedmessages) </li>Allowed Presences (msdyn_allowedpresences) </li><li> Assign WorkItem After Decline or Timeout (msdyn_assignworkitemafterdecline)</li><li>Auto-close after inactivity (msdyn_autocloseafterinactivity) </li><li>Block capacity for wrap up state (msdyn_blockcapacityforwrapup) </li><li>Bot queue (msdyn_bot_queue) </li><li>Bot rule (msdyn_bot_rule)</li><li>Bot user (msdyn_bot_user)</li><li>CallbackPreviewDialing (msdyn_notificationtemplate_callback_previewdialing)</li><li>Connectors (msdyn_connectorsurl) </li><li>Consult (msdyn_notificationtemplate_consult) </li><li>Conversation mode of chat channels (msdyn_conversationmode)</li><li>Customer ID (msdyn_customerid)</li><li>Customer Disconnect Hold Duration For Open Conversation (msdyn_customerdisconnectholddurationforopenconversation)</li><li>Capacity (msdyn_capacityrequired)</li><li>Capacity format (msdyn_capacityformat)</li><li>Channel (msdyn_streamsource)</li><li>Contract Id (msdyn_routingcontractid) </li><li>Default (msdyn_sessiontemplate_default)</li><li>Default Queue (msdyn_defaultqueue)</li><li>Direction (msdyn_direction)</li><li>Enable selecting from push-based work streams (msdyn_enableselectingfrompushbasedworkstreams)</li><li>Entity (msdyn_masterentityroutingconfigurationid)</li><li>FallBack Language (msdyn_fallbacklanguage)</li><li>Follow-up after waiting (msdyn_followupafterwaiting)</li><li>Handling Time Threshold (msdyn_handlingtimethreshold)</li><li>Incoming authenticated (msdyn_notificationtemplate_incoming_auth)</li><li>Incoming unauthenticated (msdyn_notificationtemplate_incoming_unauth)</li><li>Is Default (msdyn_isdefault)</li><li>Keep same agent for entire conversation (msdyn_enableagentaffinity)</li><li>Last Validation On (msdyn_lastvalidationon)</li><li>Last Validation Status (msdyn_lastvalidationstatus)</li><li>Matching Logic (msdyn_matchinglogic)</li><li>Max Concurrency (msdyn_maxconcurrentconnection)</li><li>Mode (msdyn_mode)</li><li>Name (msdyn_name)</li><li>Notification (msdyn_notification)</li><li>Notification scenario placeholder (msdyn_notificationscenarioplaceholder)</li><li>Outbound queue (msdyn_outboundqueueid)</li><li>Record Identification Rule (msdyn_recordidentificationrule)</li><li>Record Identification Validation Rule (msdyn_recordidentificationvalidationrule)</li><li>Restrict download of recording (msdyn_restrictdownloadrecording)</li><li>Restrict download of transcript (msdyn_restrictdownloadtranscript)</li><li>Screen pop timeout (msdyn_screenpoptimeout)</li><li>Screen pop timeout (msdyn_screenpoptimeout_optionSet)</li><li>Secure API Key (msdyn_secureapikey)</li><li>Skill Attachment Rules Count (msdyn_skillattachmentrulescount)</li><li>Skill Attachment Rules Count (Last Updated On) (msdyn_skillattachmentrulescount_date)</li><li>Skill Attachment Rules Count (State) (msdyn_skillattachmentrulescount_state)</li><li>Session scenario placeholder (msdyn_sessionscenarioplaceholder)</li><li>SupervisorAssign (msdyn_notificationtemplate_supervisorassign)</li><li>Transfer (msdyn_notificationtemplate_transfer)</li><li>Waiting Time Threshold (msdyn_waitingtimethreshold)</li><li>Work Distribution Mode (msdyn_workdistributionmode)</li><li>Work Stream (msdyn_liveworkstreamid)[**Sample 1: All voice workstreams**](#BKMK1vws)<br><br>[**Sample 2: Single voice workstream**](#BKMK2vws)<br><br>[**Sample 3: Multiple voice workstreams**](#BKMK3vws)|
	|2.|Context Variable (msdyn_ocliveworkstreamcontextvariable)|<ul><li>Name (msdyn_name) </li><li> Relation Ship Name (msdyn_relationshipname) </li><li> Type (msdyn_datatype) </li><li> Work stream (msdyn_liveworkstreamid) </li><li> IsList (msdyn_islist) </li><li> Modifiable (msdyn_ismodifiable) </li><li> Display Name (msdyn_displayname) </li><li> Displayable (msdyn_isdisplayable) </li><li> Entity Logical Name (msdyn_entitylogicalname) </li><li> Context variable (msdyn_ocliveworkstreamcontextvariableid) </li><li> Status (statecode) </li><li> Status Reason (statuscode) </li><li> System Defined (msdyn_issystemdefined) </li></ul>|[**Sample 1: Context Variables for all voice workstreams**](#BKMK1vwcv)<br><br> [**Sample 2: Context variables for a single voice workstream**](#BKMK2vwcv) <br><br> [**Sample 3: Context Variables for multiple voice workstreams**](#BKMK3vwcv) |
	|3.|Decision contract (msdyn_decisioncontract)|<ul><li>Contract definition (msdyn_contractdefinition) </li><li> Decision contract (msdyn_decisioncontractid) </li><li> Name (msdyn_name) </li><li> Unique name (msdyn_uniquename) </li></ul>|[**Sample 1: Decision contract for all voice workstreams**](#BKMK1vwdc) <br><br>[**Sample 2: Decision contract for a single voice workstream**](#BKMK2vwdc)<br><br>[**Sample 3: Decision contract for multiple voice workstreams**](#BKMK3vwdc) |
	|4.|Decision rule set (msdyn_decisionruleset)|<ul><li>AI builder model (msdyn_aibmodelid) </li><li> Authoring mode (msdyn_authoringmode) </li><li> Decision rule set (msdyn_decisionrulesetid) </li><li> Description (msdyn_description) </li><li> Input contract (msdyn_inputcontractid) </li><li> Is input collection (msdyn_isinputcollection) </li><li> ML model type (msdyn_mlmodeltype) </li><li> Name (msdyn_name) </li><li> Output contract (msdyn_outputcontractid) </li><li> Rule set definition (msdyn_rulesetdefinition) </li><li> Rule set type (msdyn_rulesettype) </li><li> Unique name (msdyn_uniquename) </li></ul>|[**Sample 1: Decision ruleset for all voice workstreams**](#BKMK1vwdrs)<br><br>[**Sample 2: Decision ruleset for a single voice workstream**](#BKMK2vwdrs) <br><br>[**Sample 3: Decision ruleset for multiple voice workstreams**](#BKMK3vwdrs) |
   |5.|Routing configuration (msdyn_routingconfiguration)|<ul><li>Is active configuration (msdyn_isactiveconfiguration) </li><li> Name (msdyn_name) </li><li> Routing configuration (msdyn_routingconfigurationid) </li><li> Unique name (msdyn_uniquename) </li><li> Workstream (msdyn_liveworkstreamid) </li></ul>|[**Sample 1: Routing configuration for all voice workstreams**](#BKMK1vwrc)<br><br>[**Sample 2: Routing configuration for a single voice workstream**](#BKMK2vwrc) <br><br>[**Sample 3: Routing configuration for multiple voice workstreams**](#BKMK3vwrc) |
   |6.|Routing configuration step (msdyn_routingconfigurationstep)|<ul><li>Name (msdyn_name) </li><li> Routing configuration (msdyn_routingconfigurationid) </li><li> Routing configuration step (msdyn_routingconfigurationstepid) </li><li> Rule set (msdyn_rulesetid) </li><li> Step order (msdyn_steporder) </li><li> Step type (msdyn_type) </li><li> Unique name (msdyn_uniquename) </li></ul>|[**Sample 1: Routing configuration step for all voice workstreams**](#BKMK1vwrcs)<br><br>[**Sample 2: Routing configuration step for a single voice workstream**](#BKMK2vwrcs) <br><br>[**Sample 3: Routing configuration step for multiple voice workstreams**](#BKMK3vwrcs)|
   |7.|Workstream capacity profile (msdyn_liveworkstreamcapacityprofile)|<ul><li>Capacity Profile (msdyn_capacityprofile_id) </li><li> Name (msdyn_name) </li><li> Workstream (msdyn_workstream_id) </li><li> Workstream Capacity profile (msdyn_liveworkstreamcapacityprofileid) </li></ul>|[**Sample 1: Workstream capacity profile for all voice workstreams**](#BKMK1vwwcp)<br><br>[**Sample 2: Workstream capacity profile for a single voice workstream**](#BKMK2vwwcp)<br><br>[**Sample 3: Workstream capacity profile for multiple voice workstreams**](#BKMK3vwwcp) |

3. Generate the schema and save it.

4. Export the data and generate the compressed (zip) file.

5. Use the Configuration Migration tool, and select the option to import data, and select the compressed file.

> [!IMPORTANT]
> When you fetch decision rulesets (msdyn_decisionrulesets) containing context variables, some decision rulesets are created without the dependency mappings. To work around this, perform the following steps:
> 1. Import data for all entities including the decision ruleset entity (msdyn_decisionrulesets).
> 2. Import data for the decision ruleset entity again. This step ensures that all dependency mappings for the decision rulesets are imported.

For sample schema to get all the required records, see [Sample schema for voice workstream]().

### FetchXML for workstream entity

**Sample 1: All voice workstreams**<a name="BKMK1vws"></a>

```XML
XMLCopy
<fetch distinct="true"> 
  <entity name="msdyn_liveworkstream"> 
    <filter type="and"> 
      <condition attribute="msdyn_mode" operator="eq" value="717210001" /> 
      <condition attribute="msdyn_streamsource" operator="eq" value="192440000" /> 
    </filter> 
  </entity> 
</fetch>
```
**Sample 2: Single voice workstreams**<a name="BKMK2vws"></a>

```XML
XMLCopy 

<fetch>
  <entity name="msdyn_liveworkstream"> 
    <filter type="and"> 
      <condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Test Voice Workstream 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312ABC}" /> 
    </filter> 
  </entity> 
</fetch> 
```
**Sample 2: Single voice workstreams**<a name="BKMK3vws"></a>

```XML
XMLCopy 

<fetch version="1.0" output-format="xml-platform" mapping="logical" distinct="false"> 
  <entity name="msdyn_liveworkstream"> 
    <filter type="and"> 
      <condition attribute="msdyn_liveworkstreamid" operator="in"> 
        <value uiname="Test Voice Workstream 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312ABC}</value> 
        <value uiname="Test Voice Workstream 2" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44098}</value> 
      </condition> 
    </filter> 
  </entity> 
</fetch>  
```

## Migrate configuration for voice channel settings

The following assumptions are in place:

- The workstream must already exist; created manually or previously migrated in the destination organization.

**To migrate data for voice channel**

1. Use the Configuration Migration tool to create the schema and export data from the source organization for the voice channel and related entities.

   - **Entity display name**: When you create the schema, select the entities in the sequence that's mentioned in the table.
   - **Attribute display name**: We recommend that you select the attributes defined in the following table. You don't have to select the system-defined attributes, such as Created By, Created On, Modified By, Modified On, and Owner. You can select custom attributes if necessary.

  | S.No. | Entity display name (Logical name) | Attribute display name (Logical name) |
  |--------|---------|---------|

1. Generate the schema and save it.

2. Export the data and generate the compressed (zip) file.

3. Use the Configuration Migration tool, select the option to import data, and then select the compressed file.


## Verify your migration

After you import the unified routing-related configuration data successfully from the source to target organization, perform the following steps in the target organization:

1. In the UI, make sure that the voice channel configuration and rulesets are rendered properly and don't display errors.

2. If skills and rating values are used in unified routing rulesets, then you need to manually link, associate, or create the users, bookable resources, and bookable resources characteristics records.
  
3. If capacity profiles are used in rulesets and workstreams for unified routing, then you need to manually link, associate, or create the users, bookable resources, and bookable resources capacity profile records.

## Considerations for export and import of data

[!INCLUDE[ur-migration considerations](../includes/cc-ur-migration-considerations.md)]

### See also

[Migrate configuration for records based on unified routing](migrate-config-data-for-records-overview.md)  
