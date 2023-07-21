---
title: Migrate configuration data for records
description: Learn to migrate configuration data pertaining for routing, capacity profiles, queues, intake rules, and workstreams in Omnichannel for Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 07/21/2023
ms.custom: bap-template
---

# Migrate configuration data for records

This article includes procedures for migrating configuration data for records. You must migrate the data in the order of:

1. skill-based routing rulesets
1. capacity profiles
1. queues
1. intake rules
1. workstreams

The procedures include tables with entity information and corresponding sample schemas for each configuration.

## Migrate configuration using a solution

Certain configuration items can be moved between environments using solutions. If there is configuration added in your unified routing setup in the list below these can be moved using a solution. Add the following components to a solution, export the solution and import it into the target environments:

1. Add the components to a solution and export
   1. Agent Script (msdyn_productivityagentscripts)
   1. Agent Script Step (msdyn_productivityagentscriptsteps)
   1. Application Tab Template (msdyn_applicationtabtemplates)
   1. Notification Field (msdyn_notificationfields)
   1. Notification Template (msdyn_notificationtemplates)
   1. Macro (processes)
   1. Session Templates (msdyn_sessiontemplates)
   1. Template Parameter (msdyn_templateparameters)
1. Import the solution into the target environment

## Migrate configuration for skill-based routing rulesets

If skill-based routing rulesets are used in your unified routing setup, perform the steps to migrate the corresponding configuration.

For sample schema to get all the required records, see [Sample schema for skill-based routing configuration](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/unified-routing-sample-schemas/Sample%20schema%20for%20skill-based%20routing.xml).

1. Use the Configuration Migration tool to create the schema and export data from the source organization for skill-based routing configuration.
  
    - **Entity display name**: When you create the schema, select the entities in the sequence that's mentioned in the table.
    - **Attribute display name**: We recommend that you select the attributes defined in the following table. You don't need to select the out-of-the-box system-defined attributes like Created By, Created On, Modified By, Modified On, and Owner. You can select custom attributes if necessary.

	> [!IMPORTANT]
    > You must manually create bookableresourcecharacteristictype (Global option set value) in the target organization, if necessary.

   |Entity display name (Logical name)  |Attribute display name (Logical name)  |Use FetchXML to filter records  |
   |---------|---------|---------|
   |Characteristic (characteristic)    | <ul><li>Characteristic Type (characteristictype)</li><li>Characteristic (characteristicid)</li><li>Description (description)</li><li>Name (name)</li></ul> |         |
   |Rating Model (ratingmodel)     |<ul><li>Max Rating Value (maxratingvalue)</li><li>Min Rating Value (minratingvalue)</li><li>Name (name)</li><li>Rating Model (ratingmodelid)</li></ul>         |         |
   |Rating Value (ratingvalue)     | <ul><li>Name (name)</li><li>Rating Model (ratingmodel)</li><li>Rating Value (ratingvalueid)</li><li>Value (value)</li></ul> |         |

1. Generate the schema and save it.

1. Export the data and generate the compressed (zip) file.

1. Use the Configuration Migration tool, and select the option to import data into the target organization using the compressed file.

## Migrate configuration for capacity profiles

If you have configured capacity profiles in your unified routing setup, perform the steps to migrate the corresponding configuration.

For sample schema to get all the required records, see [Sample schema for capacity profiles](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/unified-routing-sample-schemas/Sample%20schema%20for%20capacity%20profiles.xml).


1. Use the Configuration Migration tool to create the schema and export data in source organization for capacity profiles configuration.

    [!INCLUDE[ur-migration](../includes/cc-ur-migration.md)]

    |Entity display name (Logical name)  |Attribute display name (Logical name)  |Use FetchXML to filter records  |
    |---------|---------|---------|
    |Capacity Profile (msdyn_capacityprofile)     | <ul><li>Block Assignment (msdyn_blockassignment)</li><li> Capacity Profile (msdyn_capacityprofileid)</li><li>Default Max Units (msdyn_defaultmaxunits)</li>Name (msdyn_name)</li><li> Reset Duration(msdyn_resetduration)</li><li>Unique Name (msdyn_uniquename)</li></ul> | **Sample 1: For all capacity profile records**<br>`  <fetch>` <br>  `<entity name="msdyn_capacityprofile">` <br>`<filter type="and">`<br>`<condition attribute="ismanaged" operator="eq" value="0" />`<br>`</filter>`<br>`</entity>`<br>  `</fetch>`<br><br> **Sample 2: For a single capacity profile record** <br> `<fetch>` <br>`<entity name="msdyn_capacityprofile">`<br>`<filter type="and">`<br>`<condition attribute="msdyn_capacityprofileid" operator="eq" uiname="Demo Capacity Profile 1" uitype="msdyn_capacityprofile" value="{F57CFE3C-14BD-D53E-F423-A1E7F9749DFB}" />`<br> `</filter>`<br> `</entity>`<br> `</fetch>` <br><br> **Sample 3: For multiple capacity profile records** <br> `<fetch>`<br> `<entity name="msdyn_capacityprofile">`<br> `<filter type="and">` <br> `<condition attribute="msdyn_capacityprofileid" operator="in">`<br>`<value uiname="Demo Capacity Profile 1" uitype="msdyn_capacityprofile">{F57CFE3C-14BD-D53E-F423-A1E7F9749DFB}</value>`<br> `<value uiname="Demo Capacity Profile 2" uitype="msdyn_capacityprofile">{D0B8ABFB-4A9F-0B1F-6FF4-8003E29A623C}</value>`<br>`</condition>`<br>`</filter>`<br>`</entity>`<br>`</fetch>` |

2. Generate the schema and save it.

3. Export the data and generate the compressed (zip) file.

4. Use the Configuration Migration tool, and select the option to import data into the target organization.

## Migrate configuration for record queues

Use the Configuration Migration tool to create the schema and export data from the source organization for the record queues configuration.

[!INCLUDE[ur-migration](../includes/cc-ur-migration.md)]

If you're using the out-of-the-box assignment methods for queues, such as highest capacity and round robin, skip the following entities:
    - Decision rule set
    - Assignment configuration
    - Assignment configuration step

The assignment rulesets must be available in the system before the Configutation Migration tool imports the selection criteria. Hence, you need to perform the following steps in the specified order to migrate configuration for record queues:

> [!IMPORTANT]
>
> - For every import of queue records, you must either create new queue records or update existing queue records. You must not mix the actions in the same data import.
> - When all records in the data.xml of queue entity are for creation, ensure that the following line is present in the schema.xml: `<field displayname="Queue type" name="msdyn_queuetype" type="optionsetvalue" customfield="true"/>` and correspondingly data will also have the field for msdyn_queuetype.
> - When all records in the data.xml of queue entity are for update, ensure that you remove the following line in the schema.xml: `<field displayname="Queue type" name="msdyn_queuetype" type="optionsetvalue" customfield="true"/>` and correspondingly data will also not have that field for msdyn_queuetype.

### Step 1: Export and import rulesets without selection criteria

|S. No.| Entity display name (Logical name)  |Attribute display name (Logical name)  |Use FetchXML to filter records  |
|-----|---------|---------|---------|
| 1. | Queue (queue) |  <ul><li>Assignment Input Contract Id (msdyn_assignmentinputcontractid)</li><li>Assignment Strategy (msdyn_assignmentstrategy) </li> <li> Description (description) </li><li> Is Default Queue (msdyn_isdefaultqueue) </li><li> Is Omnichannel queue (msdyn_isomnichannelqueue) </li><li> Name (name) </li><li> Priority (msdyn_priority) </li><li> Queue (queueid) </li><li> Queue type (msdyn_queuetype) </li><li> Type (queueviewtype) </li><li>Operating Hours (msdyn_operatinghourid)</li><li>Prequeue Overflow Ruleset (msdyn_prequeueoverflowrulesetid)</li></ul>  |  [**Sample 1: All queues for records**](#BKMK1all-ur-qs) <br><br> [**Sample 2: Single queue for records**](#BKMK2single-ur-qs) <br><br> [**Sample 3: Multiple queues for records**](#BKMK3multiple-ur-qs) |
| 2. | Decision contract (msdyn_decisioncontract)  |  <ul> <li>Contract definition (msdyn_contractdefinition)</li> <li>Decision contract (msdyn_decisioncontractid) </li> <li>Name (msdyn_name) </li> <li>Unique name (msdyn_uniquename) </li> </ui>  | [**Sample 1: Decision contract for all record queues**](#BKMK1all-ur-dc) <br> <br>  [**Sample 2: Decision contract for a single record queue**](#BKMK2single-ur-dc) <br> <br> [**Sample 3: Decision contract for multiple record queues**](#BKMK3multiple-ur-dc) <br> |
| 3. |  Decision ruleset without selection criteria (msdyn_decisionruleset)  |  <ul><li>AI builder model (msdyn_aibmodelid)</li><li>Authoring mode (msdyn_authoringmode)</li><li>Decision rule set (msdyn_decisionrulesetid)</li><li>Description (msdyn_description)</li><li>Input contract (msdyn_inputcontractid)</li><li>Is input collection (msdyn_isinputcollection)</li><li>ML model type (msdyn_mlmodeltype)</li><li>Name (msdyn_name)</li><li>Output contract (msdyn_outputcontractid)</li><li>Rule set definition (msdyn_rulesetdefinition)</li><li>Rule set type (msdyn_rulesettype)</li><li>Unique name (msdyn_uniquename)</li><li>FetchXML for ruleset (msdyn_fetchxml)</li></ul>  |  [**Sample 1: Decision ruleset for all record queues without selection criteria defined**](#BKMK1nsc-ur-rls) <br> <br> [**Sample 2: Decision ruleset for a single record queue without selection criteria defined**](#BKMK2nsc-ur-rls) <br> <br> [**Sample 3: Decision ruleset for multiple record queues without selection criteria defined**](#BKMK3nsc-ur-rls) <br>  |
| 4. |  Assignment Configuration (msdyn_assignmentconfiguration)  |  <ul><li>Assignment Configuration (msdyn_assignmentconfigurationid)</li><li>Description (msdyn_description)</li><li>Is Active Configuration (msdyn_isactiveconfiguration)</li><li>Name (msdyn_name)</li><li>Queue (msdyn_queueid)</li><li>Unique Name (msdyn_uniquename)</li></ul>  | [**Sample 1: Assignment configuration for all record queues**](#BKMK1all-ur-ac) <br> <br>[**Sample 2: Assignment configuration for a single record queue**](#BKMK2single-ur-ac) <br> <br>[**Sample 3: Assignment configuration for multiple record queues**](#BKMK3multiple-ur-ac) <br>   |
| 5. |  Assignment Configuration Step without selection criteria (msdyn_assignmentconfigurationstep)  |  <ul><li>Assignment Configuration (msdyn_assignmentconfigurationid)</li><li>Assignment Configuration Step (msdyn_assignmentconfigurationstepid)</li><li>Is default ruleset (msdyn_isdefaultruleset)</li><li>Name (msdyn_name)</li><li>Rule Set (msdyn_rulesetid)</li><li>Step Order (msdyn_steporder)</li><li>Step Type (msdyn_type)</li><li>Unique Name (msdyn_uniquename)</li></ul>  |  [**Sample 1: Assignment configuration step for all record queues without selection criteria defined**](#BKMK1nsc-ur-acs) <br> <br> [**Sample 2: Assignment configuration step for a single record queue without selection criteria defined**](#BKMK2nsc-ur-acs) <br> <br> [**Sample 3: Assignment configuration step for multiple record queues without selection criteria defined**](#BKMK3nsc-ur-acs) <br>   |
|6.|Operating Hour (msdyn_operatinghour)|<ul><li>Description (msdyn_description)</li><li>Name (msdyn_name)</li><li>Operating Hour (msdyn_operatinghourid)</li><li>Status (statecode)</li><li>Status Reason (statuscode)</li></ul>|[**Sample 1: Operating Hours for all record queues**](#BKMK1-oh)<br><br>[**Sample 2: Operating Hours for a single record queue**](#BKMK2-oh) <br><br>[**Sample 3: Operating Hours for multiple record queues**](#BKMK3-oh) |
|7.|Overflow Action Config(msdyn_overflowactionconfig)|<ul><li> Name (msdyn_name)</li><li>Overflow Action Config (msdyn_overflowactionconfigid)</li><li>Overflow Action Data (msdyn_overflowactiondata)</li><li>Overflow Action Type(msdyn_overflowactiontype)</li><li>Status (statecode)</li><li>Status Reason (statuscode)</li></ul>|[**Sample 1: Overflow Action Config filtered to specific records**](#BKMK1-ov)|

Perform the following steps to export and import the rulesets:

1. Generate the schema and save it.

2. Export the data and generate the compressed (zip) file.

3. Extract the zip file, open the data.xml file present in the extracted folder, and do the following:

   - In the source and target organizations, run the following OData API call and note the GUID of `msdyn_decisioncontractid`.

      `https://<OrgURL>/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_assignmentoutput'`

     In data.xml file, replace all the occurrences of the msdyn_decisioncontractid GUID in the source organization with the msdyn_decisioncontractid GUID of the target organization.

   - In the source and target organizations, run the following OData API call and note the GUID of `msdyn_decisioncontractid`.

      `https://<OrgURL>/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_selectionruleoutput'`

     In data.xml file, replace all occurrences of the msdyn_decisioncontractid GUID in the source organization with the msdyn_decisioncontractid GUID of the target organization.

4. Package the extracted content again.

5. Use the Configuration Migration tool, select the option to import data, and then select the compressed file.

> [!NOTE]
> You can't migrate the Calendar item associated with the Operating Hour entity. You'll need to set it correctly after you import the Operating Hour entity into the target environment.

For sample schema to get all the required records, see [Sample schema for record queues step 1](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/unified-routing-sample-schemas/Sample%20schema%20for%20unified%20routing%20record%20queues%20step%201.xml).

### Step 2: Export and import rulesets with selection criteria defined

The following table summarizes the entities and corresponding FetchXML samples:

|S. No.| Entity display name (Logical name)  |Attribute display name (Logical name)  |Use FetchXML to filter records  |
|-----|---------|---------|---------|
| 1. |  Decision ruleset with selection criteria (msdyn_decisionruleset)  |  <ul><li>AI builder model (msdyn_aibmodelid)</li><li>Authoring mode (msdyn_authoringmode)</li><li>Decision rule set (msdyn_decisionrulesetid)</li><li>Description (msdyn_description)</li><li>Input contract (msdyn_inputcontractid)</li><li>Is input collection (msdyn_isinputcollection)</li><li>ML model type (msdyn_mlmodeltype)</li><li>Name (msdyn_name)</li><li>Output contract (msdyn_outputcontractid)</li><li>Rule set definition (msdyn_rulesetdefinition)</li><li>Rule set type (msdyn_rulesettype)</li><li>Unique name (msdyn_uniquename)</li></ul>  |  [**Sample 1: Decision ruleset for all record queues with selection criteria defined**](#BKMK1sc-ur-rls) <br> <br> [**Sample 2: Decision ruleset for a single record queue with selection criteria defined**](#BKMK2sc-ur-rls) <br> <br> [**Sample 3: Decision ruleset for multiple record queues with selection criteria defined**](#BKMK3sc-ur-rls) <br>  |
| 2. |  Assignment Configuration Step with selection criteria (msdyn_assignmentconfigurationstep)  |  <ul><li>Assignment Configuration (msdyn_assignmentconfigurationid)</li><li>Assignment Configuration Step (msdyn_assignmentconfigurationstepid)</li><li>Is default ruleset (msdyn_isdefaultruleset)</li><li>Name (msdyn_name)</li><li>Rule Set (msdyn_rulesetid)</li><li>Step Order (msdyn_steporder)</li><li>Step Type (msdyn_type)</li><li>Unique Name (msdyn_uniquename)</li></ul>  |  [**Sample 1: Assignment configuration step for all record queues with selection criteria defined**](#BKMK1sc-ur-acs) <br> <br> [**Sample 2: Assignment configuration step for a single record queue with selection criteria defined**](#BKMK2sc-ur-acs) <br> <br> [**Sample 3: Assignment configuration step for multiple record queues with selection criteria defined**](#BKMK3sc-ur-acs) <br>   |

Perform the following steps to export and import the rulesets:

1. Generate the schema and save it.

2. Export the data and generate the compressed (zip) file.

3. Extract the zip file, open the data.xml file present in the extracted folder, and do the following:

   - In the source and target organizations, run the following OData API call and note the GUID of `msdyn_decisioncontractid`.

      `https://<OrgURL>/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_assignmentoutput'`

     In data.xml file, replace all the occurrences of the msdyn_decisioncontractid GUID in the source organization with the msdyn_decisioncontractid GUID of the target organization.

   - In the source and target organizations, run the following OData API call and note the GUID of `msdyn_decisioncontractid`.

      `https://<OrgURL>/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_selectionruleoutput'`

     In data.xml file, replace all occurrences of the msdyn_decisioncontractid GUID in the source organization with the msdyn_decisioncontractid GUID of the target organization.

4. Package the extracted content again.

5. Use the Configuration Migration tool, select the option to import data, and then select the compressed file.

For sample schema to get all the required records, see [Sample schema for record queues step 2](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/unified-routing-sample-schemas/Sample%20schema%20for%20unified%20routing%20record%20queues%20step%202.xml).

### Step 3: Export and import rulesets for overflow conditions

> [!IMPORTANT]
> When the Queue that you want to migrate has an overflow condition set, then you must export and import the decision ruleset first.

|S. No.| Entity display name (Logical name)  |Attribute display name (Logical name)  |Use FetchXML to filter records  |
|-----|---------|---------|---------|
|1.|Decision ruleset without selection criteria (msdyn_decisionruleset)|<ul><li>AI builder model (msdyn_aibmodelid)</li><li>Authoring mode (msdyn_authoringmode) </li><li>Decision rule set (msdyn_decisionrulesetid) </li><li>Description (msdyn_description) </li><li>Input contract (msdyn_inputcontractid) </li><li>Is input collection (msdyn_isinputcollection) </li><li>ML model type (msdyn_mlmodeltype) </li><li>Name (msdyn_name) </li><li>Output contract (msdyn_outputcontractid) </li><li>Rule set definition (msdyn_rulesetdefinition) </li><li>Rule set type (msdyn_rulesettype) </li><li>Unique name (msdyn_uniquename) </li><li>FetchXML for ruleset (msdyn_fetchxml) </li></ul>|[**Sample 1: Decision Overflow ruleset for a single queue**](#BKMK1-ovc)<br><br> [**Sample 2: Decision Overflow ruleset for multiple queues**](#BKMK2-ovc)|
|2.|Queue (queue)|<ul><li> Assignment Input Contract Id (msdyn_assignmentinputcontractid) </li><li>Assignment Strategy (msdyn_assignmentstrategy) </li><li>Prequeue Overflow Ruleset (msdyn_prequeueoverflowrulesetid)</li><ul>||

Perform the following steps to export and import the rulesets:
1. Generate the schema and save it.
1. Export the data and generate the compressed (zip) file.
1. Extract the zip file, open the data.xml file present in the extracted folder, and do the following:
   - In the source and target organizations, run the following OData API call and note the GUID of msdyn_decisioncontractid.
      `https://<OrgURL>/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_queueoverflowrulesetinput'`

     In data.xml file, replace all the occurrences of the msdyn_decisioncontractid GUID in the source organization with the msdyn_decisioncontractid GUID of the target organization.

   - In the source and target organizations, run the following OData API call and note the GUID of msdyn_decisioncontractid.
      `https://<OrgURL>/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_queueoverflowrulesetoutput'`
     In data.xml file, replace all occurrences of the msdyn_decisioncontractid GUID in the source organization with the msdyn_decisioncontractid GUID of the target organization.

1. Package the extracted content again.
1. Use the Configuration Migration tool, select the option to import data, and then select the compressed file.

> [!NOTE]
> You can't migrate the Calendar item associated with the Operating Hour entity. You'll need to set it correctly after you import the Operating Hour entity into the target environment.

### FetchXML for queues

**Sample 1: All queues for records**<a name="BKMK1all-ur-qs"></a>

```XML
<fetch> 
   <entity name="queue">
    <filter type="and">
      <condition attribute="msdyn_queuetype" operator="eq" value="192350001" />
      <condition attribute="msdyn_isomnichannelqueue" operator="eq" value="1" />
      <condition attribute="queueid" operator="ne" uiname="Default entity queue" uitype="queue" value="{5A4B76B0-DAB5-4717-9743-9490F2F822C6}" />
    </filter>
  </entity>
</fetch>
```

**Sample 2: Single queue for records**<a name="BKMK2single-ur-qs"></a>

```XML
<fetch> 
   <entity name="queue"> 
    <filter type="and"> 
      <condition attribute="queueid" operator="eq" uiname="Test Record Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" /> 
    </filter> 
   </entity> 
</fetch>
```

**Sample 3: Multiple queues for records**<a name="BKMK3multiple-ur-qs"></a>

```XML
<fetch> 
   <entity name="queue"> 
    <filter type="and"> 
     <condition attribute="queueid" operator="in"> 
      <value uiname="Test Record Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value> 
      <value uiname="Test Record Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value> 
     </condition> 
    </filter> 
   </entity> 
</fetch> 
```

### FetchXML for decision contract entity

**Sample 1: Decision contract for all record queues**<a name="BKMK1all-ur-dc"></a>

```XML
<fetch distinct="true">
	<entity name="msdyn_decisioncontract">
		<filter type="or">
			<filter type="and">
				<condition attribute="msdyn_queuetype" entityname="aw" operator="eq" value="192350001" />
				<condition attribute="msdyn_isomnichannelqueue" entityname="aw" operator="eq" value="1" />
				<condition attribute="queueid" entityname="aw" operator="ne" uiname="Default entity queue" uitype="queue" value="{5A4B76B0-DAB5-4717-9743-9490F2F822C6}" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_isomnichannelqueue" entityname="be" operator="eq" value="1" />
				<condition attribute="msdyn_queuetype" entityname="be" operator="eq" value="192350001" />
				<condition attribute="queueid" entityname="be" operator="ne" uiname="Default entity queue" uitype="queue" value="{5A4B76B0-DAB5-4717-9743-9490F2F822C6}" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_isomnichannelqueue" entityname="bm" operator="eq" value="1" />
				<condition attribute="msdyn_queuetype" entityname="bm" operator="eq" value="192350001" />
				<condition attribute="queueid" entityname="bm" operator="ne" uiname="Default entity queue" uitype="queue" value="{5A4B76B0-DAB5-4717-9743-9490F2F822C6}" />
			</filter>
		</filter>
		<link-entity name="queue" from="msdyn_assignmentinputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="aw"></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bb">
			<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bc">
				<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="outer" alias="bd">
					<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="outer" alias="be"></link-entity>
				</link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bj">
			<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bk">
				<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="outer" alias="bl">
					<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="outer" alias="bm"></link-entity>
				</link-entity>
			</link-entity>
		</link-entity>
	</entity>
</fetch>  
```

**Sample 2: Decision contract for a single record queue**<a name="BKMK2single-ur-dc"></a>

```XML
<fetch distinct="true">
	<entity name="msdyn_decisioncontract">
		<filter type="or">
			<filter type="and">
				<condition attribute="queueid" entityname="aw" operator="eq" uiname="Test Record Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
			</filter>
			<filter type="and">
				<condition attribute="queueid" entityname="be" operator="eq" uiname="Test Record Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
			</filter>
			<filter type="and">
				<condition attribute="queueid" entityname="bm" operator="eq" uiname="Test Record Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
			</filter>
		</filter>
		<link-entity name="queue" from="msdyn_assignmentinputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="aw"></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bb">
			<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bc">
				<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="outer" alias="bd">
					<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="outer" alias="be"></link-entity>
				</link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bj">
			<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bk">
				<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="outer" alias="bl">
					<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="outer" alias="bm"></link-entity>
				</link-entity>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```

**Sample 3: Decision contract for multiple record queues**<a name="BKMK3multiple-ur-dc"></a>

```XML
<fetch distinct="true">
	<entity name="msdyn_decisioncontract">
		<filter type="or">
			<filter type="and">
				<condition attribute="queueid" entityname="aw" operator="in">
					<value uiname="Test Record Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
					<value uiname="Test Record Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
				</condition>
			</filter>
			<filter type="and">
				<condition attribute="queueid" entityname="be" operator="in">
					<value uiname="Test Record Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
					<value uiname="Test Record Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
				</condition>
			</filter>
			<filter type="and">
				<condition attribute="queueid" entityname="bm" operator="in">
					<value uiname="Test Record Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
					<value uiname="Test Record Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
				</condition>
			</filter>
		</filter>
		<link-entity name="queue" from="msdyn_assignmentinputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="aw"></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bb">
			<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bc">
				<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="outer" alias="bd">
					<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="outer" alias="be"></link-entity>
				</link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bj">
			<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bk">
				<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="outer" alias="bl">
					<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="outer" alias="bm"></link-entity>
				</link-entity>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```

### FetchXML for decision ruleset entity for queues

**Sample 1: Decision ruleset for all record queues without selection criteria**<a name="BKMK1nsc-ur-rls"></a>

```XML
		<fetch distinct="true">
			<entity name="msdyn_decisionruleset">
				<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="inner" alias="am">
					<filter>
						<condition attribute="msdyn_type" operator="ne" value="192350001" />
					</filter>
					<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="inner" alias="an">
						<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="ao">
							<filter type="and">
								<condition attribute="msdyn_queuetype" operator="eq" value="192350001" />
								<condition attribute="msdyn_isomnichannelqueue" operator="eq" value="1" />
								<condition attribute="queueid" operator="ne" uiname="Default entity queue" uitype="queue" value="{5A4B76B0-DAB5-4717-9743-9490F2F822C6}" />
							</filter>
						</link-entity>
					</link-entity>
				</link-entity>
			</entity>
		</fetch>
```

**Sample 2: Decision ruleset for a single record queue without selection criteria**<a name="BKMK2nsc-ur-rls"></a>

```XML
		<fetch distinct="true">
			<entity name="msdyn_decisionruleset">
				<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="inner" alias="am">
					<filter>
						<condition attribute="msdyn_type" operator="ne" value="192350001" />
					</filter>
					<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="inner" alias="an">
						<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="ao">
							<filter type="and">
								<condition attribute="queueid" operator="eq" uiname="Test Record Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
							</filter>
						</link-entity>
					</link-entity>
				</link-entity>
			</entity>
		</fetch>
```

**Sample 3: Decision ruleset for multiple record queues without selection criteria**<a name="BKMK3nsc-ur-rls"></a>

```XML
		<fetch distinct="true">
			<entity name="msdyn_decisionruleset">
				<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="inner" alias="am">
					<filter>
						<condition attribute="msdyn_type" operator="ne" value="192350001" />
					</filter>
					<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="inner" alias="an">
						<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="ao">
							<filter type="and">
								<condition attribute="queueid" operator="in">
									<value uiname="Test Record Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
									<value uiname="Test Record Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
								</condition>
							</filter>
						</link-entity>
					</link-entity>
				</link-entity>
			</entity>
		</fetch>
```

### FetchXML for assignment configuration entity

**Sample 1: Assignment configuration for all record queues**<a name="BKMK1all-ur-ac"></a>

```XML
<fetch>
	<entity name="msdyn_assignmentconfiguration">
		<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="bi">
			<filter type="and">
				<condition attribute="msdyn_queuetype" operator="eq" value="192350001" />
				<condition attribute="msdyn_isomnichannelqueue" operator="eq" value="1" />
				<condition attribute="queueid" operator="ne" uiname="Default entity queue" uitype="queue" value="{5A4B76B0-DAB5-4717-9743-9490F2F822C6}" />
			</filter>
		</link-entity>
	</entity>
</fetch> 
```

**Sample 2: Assignment configuration for a single record queue**<a name="BKMK2single-ur-ac"></a>

```XML
<fetch>
	<entity name="msdyn_assignmentconfiguration">
		<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="bi">
			<filter type="and">
				<condition attribute="queueid" operator="eq" uiname="Test Record Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
			</filter>
		</link-entity>
	</entity>
</fetch> 
```

**Sample 3: Assignment configuration for multiple record queues**<a name="BKMK3multiple-ur-ac"></a>

```XML
<fetch>
	<entity name="msdyn_assignmentconfiguration">
		<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="bi">
			<filter type="and">
				<condition attribute="queueid" operator="in">
					<value uiname="Test Record Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
					<value uiname="Test Record Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
				</condition>
			</filter>
		</link-entity>
	</entity>
</fetch> 
```

### FetchXML for assignment configuration step entity

**Sample 1: Assignment configuration step for all record queues without selection criteria**<a name="BKMK1nsc-ur-acs"></a>

```XML
		<fetch>
			<entity name="msdyn_assignmentconfigurationstep">
				<filter>
						<condition attribute="msdyn_type" operator="ne" value="192350001" />
				</filter>
				<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="inner" alias="bq">
					<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="br">
						<filter type="and">
							<condition attribute="msdyn_queuetype" operator="eq" value="192350001" />
							<condition attribute="msdyn_isomnichannelqueue" operator="eq" value="1" />
							<condition attribute="queueid" operator="ne" uiname="Default entity queue" uitype="queue" value="{5A4B76B0-DAB5-4717-9743-9490F2F822C6}" />
						</filter>
					</link-entity>
				</link-entity>
			</entity>
		</fetch>
```

**Sample 2: Assignment configuration step for a single record queue without selection criteria**<a name="BKMK2nsc-ur-acs"></a>

```XML
		<fetch>
			<entity name="msdyn_assignmentconfigurationstep">
				<filter>
						<condition attribute="msdyn_type" operator="ne" value="192350001" />
				</filter>
				<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="inner" alias="bq">
					<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="br">
						<filter type="and">
							<condition attribute="queueid" operator="eq" uiname="Test Record Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
						</filter>
					</link-entity>
				</link-entity>
			</entity>
		</fetch>
```

**Sample 3: Assignment configuration step for multiple record queues without selection criteria**<a name="BKMK3nsc-ur-acs"></a>

```XML
		<fetch>
			<entity name="msdyn_assignmentconfigurationstep">
				<filter>
						<condition attribute="msdyn_type" operator="ne" value="192350001" />
				</filter>
				<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="inner" alias="bq">
					<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="br">
						<filter type="and">
							<condition attribute="queueid" operator="in">
								<value uiname="Test Record Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
								<value uiname="Test Record Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
							</condition>
						</filter>
					</link-entity>
				</link-entity>
			</entity> 
```


### FetchXML for decision ruleset entity for queues

**Sample 1: Decision ruleset for all record queues with selection criteria**<a name="BKMK1sc-ur-rls"></a>
```XML
		<fetch distinct="true">
			<entity name="msdyn_decisionruleset">
				<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="inner" alias="am">
					<filter>
						<condition attribute="msdyn_type" operator="eq" value="192350001" />
					</filter>
					<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="inner" alias="an">
						<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="ao">
							<filter type="and">
								<condition attribute="msdyn_queuetype" operator="eq" value="192350001" />
								<condition attribute="msdyn_isomnichannelqueue" operator="eq" value="1" />
								<condition attribute="queueid" operator="ne" uiname="Default entity queue" uitype="queue" value="{5A4B76B0-DAB5-4717-9743-9490F2F822C6}" />
							</filter>
						</link-entity>
					</link-entity>
				</link-entity>
			</entity>
		</fetch>
```

**Sample 2: Decision ruleset for a single record queue with selection criteria**<a name="BKMK2sc-ur-rls"></a>

```XML
		<fetch distinct="true">
			<entity name="msdyn_decisionruleset">
				<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="inner" alias="am">
					<filter>
						<condition attribute="msdyn_type" operator="eq" value="192350001" />
					</filter>
					<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="inner" alias="an">
						<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="ao">
							<filter type="and">
								<condition attribute="queueid" operator="eq" uiname="Test Record Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
							</filter>
						</link-entity>
					</link-entity>
				</link-entity>
			</entity>
		</fetch>
```

**Sample 3: Decision ruleset for multiple record queues with selection criteria**<a name="BKMK3sc-ur-rls"></a>

```XML
		<fetch distinct="true">
			<entity name="msdyn_decisionruleset">
				<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="inner" alias="am">
					<filter>
						<condition attribute="msdyn_type" operator="eq" value="192350001" />
					</filter>
					<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="inner" alias="an">
						<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="ao">
							<filter type="and">
								<condition attribute="queueid" operator="in">
									<value uiname="Test Record Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
									<value uiname="Test Record Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
								</condition>
							</filter>
						</link-entity>
					</link-entity>
				</link-entity>
			</entity>
		</fetch>
```

### FetchXML for assignment configuration step entity

**Sample 1: Assignment configuration step for all record queues with selection criteria**<a name="BKMK1sc-ur-acs"></a>

```XML
		<fetch>
			<entity name="msdyn_assignmentconfigurationstep">
				<filter>
						<condition attribute="msdyn_type" operator="eq" value="192350001" />
				</filter>
				<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="inner" alias="bq">
					<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="br">
						<filter type="and">
							<condition attribute="msdyn_queuetype" operator="eq" value="192350001" />
							<condition attribute="msdyn_isomnichannelqueue" operator="eq" value="1" />
							<condition attribute="queueid" operator="ne" uiname="Default entity queue" uitype="queue" value="{5A4B76B0-DAB5-4717-9743-9490F2F822C6}" />
						</filter>
					</link-entity>
				</link-entity>
			</entity>
		</fetch>
```

**Sample 2: Assignment configuration step for a single record queue with selection criteria**<a name="BKMK2sc-ur-acs"></a>

```XML
		<fetch>
			<entity name="msdyn_assignmentconfigurationstep">
				<filter>
						<condition attribute="msdyn_type" operator="eq" value="192350001" />
				</filter>
				<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="inner" alias="bq">
					<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="br">
						<filter type="and">
							<condition attribute="queueid" operator="eq" uiname="Test Record Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
						</filter>
					</link-entity>
				</link-entity>
			</entity>
		</fetch>
```

**Sample 3: Assignment configuration step for multiple record queues with selection criteria**<a name="BKMK3sc-ur-acs"></a>

```XML
		<fetch>
			<entity name="msdyn_assignmentconfigurationstep">
				<filter>
						<condition attribute="msdyn_type" operator="eq" value="192350001" />
				</filter>
				<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="inner" alias="bq">
					<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="br">
						<filter type="and">
							<condition attribute="queueid" operator="in">
								<value uiname="Test Record Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
								<value uiname="Test Record Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
							</condition>
						</filter>
					</link-entity>
				</link-entity>
			</entity>
		</fetch>
```

### FetchXML for operating hour configuration step entity

**Sample 1: Operating Hour configuration step for all record queues**<a name="BKMK1-oh"></a>

```xml
XMLCopy
        <fetch>
            <entity name="msdyn_operatinghour">
                <link-entity name="queue" from="msdyn_operatinghourid" to="msdyn_operatinghourid" link-type="inner" alias="aa">
                <filter type="and">
                    <condition attribute="msdyn_queuetype" operator="eq" value="192350001"/>
                    <condition attribute="msdyn_isomnichannelqueue" operator="eq" value="1"/>
                    <condition attribute="queueid" operator="ne" uiname="Default entity queue" uitype="queue" value="{5A4B76B0-DAB5-4717-9743-9490F2F822C6}"/>
               </filter>
             </link-entity>
           </entity>
        </fetch>
```

**Sample 2: Operating Hour configuration step for a single record queue**<a name="BKMK2-oh"></a>

```xml
XMLCopy
        <fetch>
            <entity name="msdyn_operatinghour">
                <link-entity name="queue" from="msdyn_operatinghourid" to="msdyn_operatinghourid" link-type="inner" alias="ab">
                <filter type="and">
                    <condition attribute="queueid" operator="in">
                        <value uiname="Test Record Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value> 
                    </condition>
                </filter>
                </link-entity>
            </entity>
        </fetch>
```

**Sample 3: Operating Hour configuration step for multiple record queues**<a name="BKMK3-oh"></a>

```xml
XMLCopy
        <fetch>
            <entity name="msdyn_operatinghour">
                <link-entity name="queue" from="msdyn_operatinghourid" to="msdyn_operatinghourid" link-type="inner" alias="ab">
                <filter type="and">
                    <condition attribute="queueid" operator="in">
                        <value uiname="Test Record Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value> 
                        <value uiname="Test Record Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value> 
                    </condition>
                </filter>
                </link-entity>
            </entity>
        </fetch>
```

### FetchXML for overflow action configuration step entity

**Sample 1: Overflow Action Config configuration step filter for a specific record**<a name="BKMK1-ov"></a>

```xml
XMLCopy
<fetch>
  <entity name="msdyn_overflowactionconfig">
    <filter type="and">
      <condition attribute="msdyn_overflowactionconfigid" operator="eq" uiname="QueueTransfer_caae99a1-dcc4-ed11-83ff-00224805c003 " uitype="msdyn_overflowactionconfig" value="{6D49F66F-68F3-ED11-8848-00224805C003}"/>
    </filter>
  </entity>
</fetch>
```


### FetchXML for overflow conditions

**Sample 1: For a single queue record**<a name="BKMK1-ovc"></a>

```xml
XMLCopy
<fetch>
  <entity name="msdyn_decisionruleset">
    <filter type="and">
      <condition attribute="msdyn_decisionrulesetid" operator="eq" uiname="queue_prequeue_Test Record Queue 1" uitype="msdyn_decisionruleset" value="{B8E30FC9-4ED8-ED11-A7C7-00224805C003}"/>
    </filter>
  </entity>
</fetch>
```

**Sample 2: For multiple queue records**<a name="BKMK2-ovc"></a>

```xml
XMLCopy
<fetch>
  <entity name="msdyn_decisionruleset">
    <filter type="or">
      <condition attribute="msdyn_decisionrulesetid" operator="eq" uiname="queue_prequeue_Test Record Queue 1" uitype="msdyn_decisionruleset" value="{B8E30FC9-4ED8-ED11-A7C7-00224805C003}"/>
      <condition attribute="msdyn_decisionrulesetid" operator="eq" uiname="queue_prequeue_Test Record Queue 2" uitype="msdyn_decisionruleset" value="{B8E30FC9-4ED8-ED11-A7C7-00224805C123}"/>
    </filter>
  </entity>
</fetch>
```



## Migrate configuration for intake rules for record routing

### Prerequisites

Before you migrate intake rules, check for the following:

- If the target organization doesn't have the intake rules for the record type that you want to import, then remove the msdyn_rulesetdefinition attribute of the msdyn_decisionruleset entity from the data.xml before you import.
- If the target organization has intake rules for the record type with the same GUID, then remove the msdyn_rulesetdefinition attribute of the msdyn_decisionruleset entity from the data.xml before you import.
- If the target organization has intake rules for the record type with different GUID, then delete all the intake rules in the target organization before you import.

### Migrate configuration of intake rules

1. Use the Configuration Migration tool to create the schema and export data from the source organization for a record routing configuration.

   [!INCLUDE[ur-migration](../includes/cc-ur-migration.md)]


    | S.No.| Entity display name (Logical name)  |Attribute display name (Logical name)  |Use FetchXML to filter records  |
    |-----|---------|---------|---------|
    |1.|Master Entity Routing Configuration (msdyn_masterentityroutingconfiguration)|<ul><li>Entity (msdyn_entitylogicalname)</li><li>Master Entity Routing Configuration (msdyn_masterentityroutingconfigurationid)</li><li>Name (msdyn_name)</li><li>Rule set (msdyn_rulesetid)</li><li>Unique Name (msdyn_uniquename)</li></ul>|[**Sample 1: Master entity routing configuration for a routed records**](#BKMK1mer-rr) <br> <br>  [**Sample 2: Master entity routing configuration for the incident entity**](#BKMK2mer-incident) <br> <br> [**Sample 3: Master entity routing configuration for the incident and task entities**](#BKMK3mer-incident-task)|
    | 2. | Decision contract (msdyn_decisioncontract) |  <ul><li>Contract definition (msdyn_contractdefinition)</li><li>Decision contract (msdyn_decisioncontractid) </li><li>Name (msdyn_name) </li><li>Unique name (msdyn_uniquename) </li></ul>  |  [**Sample 1: Decision contract for all routed records**](#BKMK1dc-all-rr) <br><br> [**Sample 2: Decision contract for the incident entity**](#BKMK2dc-incident) <br><br>  [**Sample 3: Decision contract for the incident and task entities**](#BKMK3dc-incident-task)  |
    | 3. |  Decision ruleset (msdyn_decisionruleset)  |  <ul><li>AI builder model (msdyn_aibmodelid)</li><li> Authoring mode (msdyn_authoringmode) </li><li> Decision rule set (msdyn_decisionrulesetid) </li><li> Description (msdyn_description) </li><li>  Input contract (msdyn_inputcontractid) </li><li>  Is input collection (msdyn_isinputcollection) </li><li> ML model type (msdyn_mlmodeltype) </li><li> Name (msdyn_name) </li><li> Output contract (msdyn_outputcontractid) </li><li>  Rule set definition (msdyn_rulesetdefinition) </li><li>  Rule set type (msdyn_rulesettype) </li><li> Unique name (msdyn_uniquename) </li></ul> |  [**Sample 1: Decision ruleset for all rouced records**](#BKMK1drl-all-rr) <br><br> [**Sample 2: Decision ruleset for the incident entity**](#BKMK2drl-incident) <br><br> [**Sample 3: Decision ruleset for the incident and task entities**](#BKMK3drl-incident-task) <br> <br>  |
    

1. Generate the schema and save it.

2. Export the data and generate the compressed (zip) file.

3. Extract the zip file, open the data.xml file present in the extracted folder, and perform the following operations:

   - In the source and target organizations, run the following OData API call and note the `msdyn_decisioncontractid`:

      `https://<OrgURL>/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_baseoutputcontractmasterentityroutingconfiguration'`

     In data.xml file, replace all occurrences of the msdyn_decisioncontractid GUID in the source organization with the msdyn_decisioncontractid GUID of the target organization.

   - In the source and target organizations, run the following OData API call and note the `msdyn_decisioncontractid`:

      `https://<OrgURL>/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_baseoutputcontractmasterentityroutingconfigurationunifiedrouting'`

     In data.xml file, replace all occurrences of the msdyn_decisioncontractid GUID in the source organization with the msdyn_decisioncontractid GUID of the target organization.

4. Package the extracted content again.

5. Use the Configuration Migration tool, select the option to import data, and then select the compressed file.

For sample schema to get all the required records, see [Sample schema for intake rules for record routing](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/unified-routing-sample-schemas/Sample%20schema%20intake%20rules%20for%20record%20routing.xml).

### FetchXML for decision contract entity for intake rules

**Sample 1: Decision contract for all routed records**<a name="BKMK1dc-all-rr"></a>

```XML
<fetch distinct="true">
	<entity name="msdyn_decisioncontract">
		<filter type="or">
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bp" operator="not-null" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bt" operator="not-null" />
			</filter>
		</filter>
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bo">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" linktype="outer" alias="bp" /></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bs">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" linktype="outer" alias="bt" /></link-entity>
	</entity>
</fetch>
```


**Sample 2: Decision contract for the incident entity**<a name="BKMK2dc-incident"></a>

```XML
<fetch distinct="true">
	<entity name="msdyn_decisioncontract">
		<filter type="or">
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bp" operator="eq" value="incident" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bt" operator="eq" value="incident" />
			</filter>
		</filter>
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bo">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bp" /></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bs">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bt" /></link-entity>
	</entity>
</fetch>
```

**Sample 3: Decision Contract for the incident and task entities**<a name="BKMK3dc-incident-task"></a>

```XML
<fetch distinct="true">
	<entity name="msdyn_decisioncontract">
		<filter type="or">
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bp" operator="eq" value="incident" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bt" operator="eq" value="incident" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bp" operator="eq" value="task" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bt" operator="eq" value="task" />
			</filter>
		</filter>
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bo">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bp" /></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bs">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bt" /></link-entity>
	</entity>
</fetch> 
```

### FetchXML for decision ruleset entity for intake rules

**Sample 1: Decision ruleset for all routed records**<a name="BKMK1drl-all-rr"></a>

```XML
<fetch distinct="true">
	<entity name="msdyn_decisionruleset">
		<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="inner" alias="cp">
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" operator="not-null" />
			</filter>
		</link-entity>
	</entity>
</fetch> 
```

**Sample 2: Decision ruleset for the incident entity**<a name="BKMK2drl-incident"></a>

```XML
<fetch distinct="true">
	<entity name="msdyn_decisionruleset">
		<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="inner" alias="cp">
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" operator="eq" value="incident" />
			</filter>
		</link-entity>
	</entity>
</fetch> 
```

**Sample 3: Decision ruleset for the incident and task entities**<a name="BKMK3drl-incident-task"></a>

```XML
<fetch distinct="true">
	<entity name="msdyn_decisionruleset">
		<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="inner" alias="cp">
			<filter type="and">
				<filter type="or">
					<condition attribute="msdyn_entitylogicalname" operator="eq" value="incident" />
					<condition attribute="msdyn_entitylogicalname" operator="eq" value="task" />
				</filter>
			</filter>
		</link-entity>
	</entity>
</fetch> 
```

### FetchXML for entity routing configuration for intake rules

**Sample 1: Master entity routing configuration for a routed records**<a name="BKMK1mer-rr"></a> 

```XML
<fetch>
	<entity name="msdyn_masterentityroutingconfiguration">
		<filter type="and">
			<condition attribute="msdyn_entitylogicalname" operator="not-null" />
		</filter>
	</entity>
</fetch> 
```

**Sample 2: Master entity routing configuration for the incident entity**<a name="BKMK2mer-incident"></a> 

```XML
<fetch>
	<entity name="msdyn_masterentityroutingconfiguration">
		<filter type="and">
			<condition attribute="msdyn_entitylogicalname" operator="eq" value="incident" />
		</filter>
	</entity>
</fetch> 
```

**Sample 3: Master entity routing configuration for the incident and task entities**<a name="BKMK3mer-incident-task"></a>

```XML
<fetch>
	<entity name="msdyn_masterentityroutingconfiguration">
		<filter type="and">
			<filter type="or">
				<condition attribute="msdyn_entitylogicalname" operator="eq" value="incident" />
				<condition attribute="msdyn_entitylogicalname" operator="eq" value="task" />
			</filter>
		</filter>
	</entity>
</fetch>
```

## Migrate configuration for record workstreams

1. Use the Configuration Migration tool to create the schema and export data from the source organization for record workstreams.
    
    [!INCLUDE[ur-migration](../includes/cc-ur-migration.md)] 
    
	> [!NOTE]
	> Ensure that the workstreams that're referred in the intake rules exist in the target organization or are present as part of the current migration.


    | S.No. | Entity display name (Logical name)  | Attribute display name (Logical name)  | Use FetchXML to filter records  |
    |-----|---------|---------|---------|
    | 1. |  Workstream (msdyn_liveworkstream)  |  <ul><li>Allow Automated Messages (msdyn_enableautomatedmessages)</li> <li>Allowed Presences (msdyn_allowedpresences)</li> <li>Assign WorkItem After Decline or Timeout (msdyn_assignworkitemafterdecline)</li> <li>Auto-close after inactivity (msdyn_autocloseafterinactivity)</li> <li>Block capacity for wrap up state (msdyn_blockcapacityforwrapup)</li> <li>Bot queue (msdyn_bot_queue)</li> <li>Bot rule (msdyn_bot_rule)</li> <li>Bot user (msdyn_bot_user)</li> <li>Capacity (msdyn_capacityrequired)</li> <li>Capacity format (msdyn_capacityformat)</li> <li>Channel (msdyn_streamsource)</li> <li>Contract Id (msdyn_routingcontractid)</li> <li>Default (msdyn_sessiontemplate_default)</li><li>Default Queue (msdyn_defaultqueue)</li> <li>Direction (msdyn_direction)</li> <li>Enable selecting from push-based work streams (msdyn_enableselectingfrompushbasedworkstreams)</li> <li>Entity (msdyn_masterentityroutingconfigurationid)</li> <li>FallBack Language (msdyn_fallbacklanguage)</li> <li>Follow-up after waiting (msdyn_followupafterwaiting)</li> <li>Handling Time Threshold (msdyn_handlingtimethreshold)</li> <li>Incoming authenticated (msdyn_notificationtemplate_incoming_auth)</li> <li>Is Default (msdyn_isdefault)</li> <li>Keep same agent for entire conversation (msdyn_enableagentaffinity)</li> <li>Matching Logic (msdyn_matchinglogic)</li> <li>Max Concurrency (msdyn_maxconcurrentconnection)</li> <li>Mode (msdyn_mode)</li> <li>Name (msdyn_name)</li> <li>Notification (msdyn_notification)</li> <li>Outbound queue (msdyn_outboundqueueid)</li> <li>Record Identification Rule (msdyn_recordidentificationrule)</li> <li>Record Identification Validation Rule (msdyn_recordidentificationvalidationrule)</li> <li>Screen pop timeout (msdyn_screenpoptimeout)</li> <li>Screen pop timeout (msdyn_screenpoptimeout_optionSet)</li> <li>Skill Attachment Rules Count (msdyn_skillattachmentrulescount)</li> <li>Skill Attachment Rules Count (Last Updated On) (msdyn_skillattachmentrulescount_date)</li> <li>Skill Attachment Rules Count (State) (msdyn_skillattachmentrulescount_state)</li> <li>Waiting Time Threshold (msdyn_waitingtimethreshold)</li> <li>Work Distribution Mode (msdyn_workdistributionmode)</li> <li>Work Stream (msdyn_liveworkstreamid)</li> </ui>  |  [**Sample 1: All record workstreams**](#BKMK1all-ur-ws) <br> <br>  [**Sample 2: Single record workstream**](#BKMK2single-ur-ws) <br> <br>  [**Sample 3: Multiple record workstreams**](#BKMK3multiple-ur-ws) <br> |
    | 2. |  Decision contract (msdyn_decisioncontract)  |  <ul><li>Contract definition (msdyn_contractdefinition) </li> <li> Decision contract (msdyn_decisioncontractid) </li> <li> Name (msdyn_name) </li> <li> Unique name (msdyn_uniquename) </li> </ul>  |  [**Sample 1: Decision contract for all record workstreams**](#BKMK1dc-ur-ws) <br> <br>  [**Sample 2: Decision contract for a single record workstream of type = incident**](#BKMK2dc-ur-ws) <br> <br> [**Sample 3: Decision contract for multiple record workstreams of type = incident and type = task**](#BKMK3dc-ur-ws) <br> <br> |
    | 3. |  Decision rule set (msdyn_decisionruleset)  |  <ul><li> AI builder model (msdyn_aibmodelid)</li><li> Authoring mode (msdyn_authoringmode) </li><li> Decision rule set (msdyn_decisionrulesetid) </li><li>Description (msdyn_description) </li><li>Input contract (msdyn_inputcontractid) </li><li>Is input collection (msdyn_isinputcollection) </li><li>ML model type (msdyn_mlmodeltype) </li><li>Name (msdyn_name) </li><li>Output contract (msdyn_outputcontractid) </li><li>Rule set definition (msdyn_rulesetdefinition) </li><li>Rule set type (msdyn_rulesettype) </li><li>Unique name (msdyn_uniquename) </li></ul>  |  [**Sample 1: Decision ruleset for all record workstreams**](#BKMK1drl-ur-ws) <br> <br> [**Sample 2: Decision ruleset for a single record workstream of type = incident**](#BKMK2drl-ur-ws) <br> <br> [**Sample 3: Decision ruleset for multiple record workstreams type = incident and type = task**](#BKMK3drl-ur-ws) <br><br>  |
    | 4. | Routing configuration (msdyn_routingconfiguration) |  <ul> <li> Is active configuration (msdyn_isactiveconfiguration) </li> <li> Name (msdyn_name) </li> <li> Routing configuration (msdyn_routingconfigurationid) </li> <li> Unique name (msdyn_uniquename) </li> <li>Workstream (msdyn_liveworkstreamid) </li> </ul>  |  [**Sample 1: Routing configuration for all record workstreams**](#BKMK1rc-ur-ws) <br><br> [**Sample 2: Routing configuration for a single record workstream**](#BKMK2rc-ur-ws) <br> <br> [**Sample 3: Routing configuration for multiple record workstreams**](#BKMK3rc-ur-ws) <br><br> |
    | 5. |  Routing configuration step (msdyn_routingconfigurationstep)  |  <ul><li> Name (msdyn_name) </li><li> Routing configuration (msdyn_routingconfigurationid) </li><li> Routing configuration step (msdyn_routingconfigurationstepid) </li><li> Rule set (msdyn_rulesetid) </li><li> Step order (msdyn_steporder) </li><li> Step type (msdyn_type) </li><li> Unique name (msdyn_uniquename) </li></ul>  |  [**Sample 1: Routing configuration step for all record workstreams**](#BKMK1rs-ur-ws) <br><br> [**Sample 2: Routing configuration step for a single record workstream**](#BKMK2rs-ur-ws) <br><br> [**Sample 3: Routing configuration step for multiple record workstreams**](#BKMK3rs-ur-ws) <br><br>  |
    | 6. |  Workstream capacity profile (msdyn_liveworkstreamcapacityprofile)  |  <ul><li> Capacity Profile (msdyn_capacityprofile_id)</li><li> Name (msdyn_name) </li><li>Workstream (msdyn_workstream_id) </li><li>Workstream Capacity profile (msdyn_liveworkstreamcapacityprofileid)</li></ul>  | [**Sample 1: Workstream capacity profile for all record workstreams**](#BKMK1cp-ur-ws) <br><br> [**Sample 2: Workstream capacity profile for a single record workstream**](#BKMK2cp-ur-ws) <br><br> [**Sample 3: Workstream capacity profile for multiple record workstreams**](#BKMK3cp-ur-ws) <br><br>   |

1. Generate the schema and save it.

1. Export the data and generate the compressed (zip) file.

1. Extract the zip file, open the data.xml file present in the extracted folder, and perform the following operations:

   - In the source and target organizations, run the following OData API call and note the `msdyn_decisioncontractid`.

      `https://<OrgURL>/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_baseoutputcontractmasterentityroutingconfiguration'`

     In data.xml file, replace all occurrences of the msdyn_decisioncontractid GUID in the source organization with the msdyn_decisioncontractid GUID of the target organization.

   - In the source and target organizations, run the following OData API call and note the `msdyn_decisioncontractid`.

      `https://<OrgURL>/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_baseoutputcontractmasterentityroutingconfigurationunifiedrouting'`

     In data.xml file, replace all occurrences of the msdyn_decisioncontractid GUID in the source organization with the msdyn_decisioncontractid GUID of the target organization.
   
   - In the source and target organizations, run the following OData API call and note the `msdyn_decisioncontractid`.

      `https://<OrgURL>/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_demandqueueidentificationoutput'`

     In data.xml file, replace all occurrences of the msdyn_decisioncontractid GUID in the source organization with the msdyn_decisioncontractid GUID of the target organization.

1. Package the extracted content again.

1. Use the Configuration Migration tool, select the option to import data, and select the compressed file.

1. After the import completes successfully, run the import again to ensure references are updated correctly that might have been overridden by the "on create" processes.

For sample schema to get all the required records, see [Sample schema for unified routing record workstream](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/unified-routing-sample-schemas/Sample%20schema%20for%20unified%20routing%20record%20workstreams.xml).

### FetchXML for workstream entity

**Sample 1: All record workstreams**<a name="BKMK1all-ur-ws"></a>

```XML
<fetch distinct="true">
	<entity name="msdyn_liveworkstream">
		<filter type="and">
			<condition attribute="msdyn_mode" operator="eq" value="717210001" />
			<condition attribute="msdyn_streamsource" operator="eq" value="192350000" />
		</filter>
	</entity>
</fetch> 
```
**Sample 2: Single record workstream**<a name="BKMK2single-ur-ws"></a>

```XML
<fetch>
	<entity name="msdyn_liveworkstream">
		<filter type="and">
			<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}" />
		</filter>
	</entity>
</fetch> 
```
**Sample 3: Multiple record workstreams**<a name="BKMK3multiple-ur-ws"></a>

```XML
<fetch version="1.0" output-format="xml-platform" mapping="logical" distinct="false">
	<entity name="msdyn_liveworkstream">
		<filter type="and">
			<condition attribute="msdyn_liveworkstreamid" operator="in">
				<value uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}</value>
				<value uiname="Test Record Workstream Task 1" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44215}</value>
			</condition>
		</filter>
	</entity>
</fetch> 
```

### FetchXML for decision contract entity

**Sample 1: Decision contract for all record workstreams**<a name="BKMK1dc-ur-ws"></a>

```XML
<fetch distinct="true">
	<entity name="msdyn_decisioncontract">
		<filter type="or">
			<filter type="and">
				<condition attribute="msdyn_mode" entityname="an" operator="eq" value="717210001" />
				<condition attribute="msdyn_streamsource" entityname="an" operator="eq" value="192350000" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_mode" entityname="bd" operator="eq" value="717210001" />
				<condition attribute="msdyn_streamsource" entityname="bd" operator="eq" value="192350000" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bp" operator="not-null" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bt" operator="not-null" />
			</filter>
		</filter>
		<link-entity name="msdyn_liveworkstream" from="msdyn_routingcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="an"></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="ba">
			<link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bb">
				<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="bc">
					<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="bd"></link-entity>
				</link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bo">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bp" /></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bs">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bt" /></link-entity>
	</entity>
</fetch> 
```
**Sample 2: Decision contract for a single record workstream of type = incident**<a name="BKMK2dc-ur-ws"></a>

```XML
<fetch distinct="true">
	<entity name="msdyn_decisioncontract">
		<filter type="or">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" entityname="an" operator="eq" uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" entityname="bd" operator="eq" uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bp" operator="eq" value="incident" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bt" operator="eq" value="incident" />
			</filter>
		</filter>
		<link-entity name="msdyn_liveworkstream" from="msdyn_routingcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="an"></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="ba">
			<link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bb">
				<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="bc">
					<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="bd"></link-entity>
				</link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bo">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bp" /></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bs">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bt" /></link-entity>
	</entity>
</fetch>
```
**Sample 3: Decision contract for multiple record workstreams of type = incident and type = task**<a name="BKMK3dc-ur-ws"></a>

```XML
<fetch distinct="true">
	<entity name="msdyn_decisioncontract">
		<filter type="or">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" entityname="an" operator="in">
					<value uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}</value>
					<value uiname="Test Record Workstream Task 1" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44215}</value>
				</condition>
			</filter>
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" entityname="bd" operator="in">
					<value uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}</value>
					<value uiname="Test Record Workstream Task 1" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44215}</value>
				</condition>
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bp" operator="eq" value="incident" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bt" operator="eq" value="incident" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bp" operator="eq" value="task" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bt" operator="eq" value="task" />
			</filter>
		</filter>
		<link-entity name="msdyn_liveworkstream" from="msdyn_routingcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="an"></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="ba">
			<link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bb">
				<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="bc">
					<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="bd"></link-entity>
				</link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bo">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bp" /></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bs">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bt" /></link-entity>
	</entity>
</fetch> 
```
### FetchXML for decision ruleset entity

**Sample 1: Decision ruleset for all record workstreams**<a name="BKMK1drl-ur-ws"></a>

```XML
<fetch distinct="true">
	<entity name="msdyn_decisionruleset">
		<filter type="or">
			<filter type="and">
				<condition attribute="msdyn_mode" entityname="af" operator="eq" value="717210001" />
				<condition attribute="msdyn_streamsource" entityname="af" operator="eq" value="192350000" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="dc" operator="not-null" />
			</filter>
		</filter>
		<link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="ad">
			<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="ae">
				<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="af"></link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="dc"></link-entity>
	</entity>
</fetch> 
```
**Sample 2: Decision ruleset for a single record workstream of type = incident**<a name="BKMK2drl-ur-ws"></a>

```XML
<fetch distinct="true">
	<entity name="msdyn_decisionruleset">
		<filter type="or">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" entityname="af" operator="eq" uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="dc" operator="eq" value="incident" />
			</filter>
		</filter>
		<link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="ad">
			<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="ae">
				<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="af"></link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="dc"></link-entity>
	</entity>
</fetch>
```
**Sample 3: Decision ruleset for multiple record workstreams type = incident and type = task**<a name="BKMK3drl-ur-ws"></a>

```XML
<fetch distinct="true">
	<entity name="msdyn_decisionruleset">
		<filter type="or">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" entityname="af" operator="in">
					<value uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}</value>
					<value uiname="Test Record Workstream Task 1" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44215}</value>
				</condition>
			</filter>
			<filter type="and">
				<filter type="or">
					<condition attribute="msdyn_entitylogicalname" entityname="dc" operator="eq" value="incident" />
					<condition attribute="msdyn_entitylogicalname" entityname="dc" operator="eq" value="task" />
				</filter>
			</filter>
		</filter>
		<link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="ad">
			<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="ae">
				<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="af"></link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="dc"></link-entity>
	</entity>
</fetch> 
```
### FetchXML for routing configuration entity

**Sample 1: Routing configuration for all record workstreams**<a name="BKMK1rc-ur-ws"></a>

```XML
<fetch>
	<entity name="msdyn_routingconfiguration">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ah">
			<filter type="and">
				<condition attribute="msdyn_mode" operator="eq" value="717210001" />
				<condition attribute="msdyn_streamsource" operator="eq" value="192350000" />
			</filter>
		</link-entity>
	</entity>
</fetch> 
```
**Sample 2: Routing configuration for a single record workstream**<a name="BKMK2rc-ur-ws"></a>

```XML
<fetch>
	<entity name="msdyn_routingconfiguration">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ah">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}" />
			</filter>
		</link-entity>
	</entity>
</fetch> 
```
**Sample 3: Routing configuration for multiple record workstreams**<a name="BKMK3rc-ur-ws"></a>

```XML
<fetch>
	<entity name="msdyn_routingconfiguration">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ah">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="in">
					<value uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}</value>
					<value uiname="Test Record Workstream Task 1" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44215}</value>
				</condition>
			</filter>
		</link-entity>
	</entity>
</fetch> 
```

### FetchXML for routing configuration step entity

**Sample 1: Routing configuration step for all record workstreams**<a name="BKMK1rs-ur-ws"></a>

```XML
<fetch>
	<entity name="msdyn_routingconfigurationstep">
		<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="inner" alias="ak">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="al">
				<filter type="and">
					<condition attribute="msdyn_mode" operator="eq" value="717210001" />
					<condition attribute="msdyn_streamsource" operator="eq" value="192350000" />
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```
**Sample 2: Routing configuration step for a single record workstream**<a name="BKMK2rs-ur-ws"></a>

```XML
<fetch>
	<entity name="msdyn_routingconfigurationstep">
		<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="inner" alias="ak">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="al">
				<filter type="and">
					<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}" />
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```
**Sample 3: Routing configuration step for multiple record workstreams**<a name="BKMK3rs-ur-ws"></a>

```XML
<fetch>
	<entity name="msdyn_routingconfigurationstep">
		<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="inner" alias="ak">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="al">
				<filter type="and">
					<condition attribute="msdyn_liveworkstreamid" operator="in">
						<value uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}</value>
						<value uiname="Test Record Workstream Task 1" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44215}</value>
					</condition>
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```

### FetchXML for workstream capacity profile entity

**Sample 1: Workstream capacity profile for all record workstreams**<a name="BKMK1cp-ur-ws"></a>

```XML
<fetch>
	<entity name="msdyn_liveworkstreamcapacityprofile">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_workstream_id" link-type="inner" alias="am">
			<filter type="and">
				<condition attribute="msdyn_mode" operator="eq" value="717210001" />
				<condition attribute="msdyn_streamsource" operator="eq" value="192350000" />
			</filter>
		</link-entity>
	</entity>
</fetch> 
```
**Sample 2: Workstream capacity profile for a single record workstream**<a name="BKMK2cp-ur-ws"></a>

```XML
<fetch>
	<entity name="msdyn_liveworkstreamcapacityprofile">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_workstream_id" link-type="inner" alias="am">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}" />
			</filter>
		</link-entity>
	</entity>
</fetch> 
```
**Sample 3: Workstream capacity profile for multiple record workstreams**<a name="BKMK3cp-ur-ws"></a>

```XML
<fetch>
	<entity name="msdyn_liveworkstreamcapacityprofile">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_workstream_id" link-type="inner" alias="am">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="in">
					<value uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}</value>
					<value uiname="Test Record Workstream Task 1" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44215}</value>
				</condition>
			</filter>
		</link-entity>
	</entity>
</fetch>
```    


## Next steps

[Verify migration of records](migrate-config-data-verify.md)  


### See also

[Create a schema to export configuration data](/power-platform/admin/create-schema-export-configuration-data)  
[Overview of data migration for records](migrate-config-data-for-records-overview.md)  
[Use FetchXML query to filter records](use-fetchxml-filter-records.md)  
[Troubleshoot migration of records](migrate-config-data-troubleshoot.md)  
[Migrate configuration data for live chat](migrate-config-data-for-live-chat.md)  
[Migrate configuration data for voice channel](migrate-config-data-for-voice-channel.md)    
