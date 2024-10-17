---
title: Migrate configurations for record routing using solutions
description: Learn how to migrate configuration data for routing, capacity profiles, queues, intake rules, and workstreams in Customer Service using solutions.
author: mjfjesus
ms.author: marcoje
ms.reviewer: nenellim
ms.topic: how-to
ms.date: 04/23/2024
ms.custom: bap-template
---

# Migrate configurations for record routing using solutions


[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

Use solutions and the Configuration Migration tool to migrate the configurations from the source environment to the target environment for record routing.

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

## Record routing configuration migration steps

You must perform the steps in the order they're listed to migrate your configuration data successfully:

1. Migrate configuration for session templates and notification templates.
1. Migrate configuration for skill-based routing rulesets.
1. Migrate configuration for new capacity profiles.
1. Migrate configuration for queues.
1. Migrate configuration for intake rules and  workstreams.

## Migrate configuration for session templates and notification templates

If the following components are available in your setup, add them to a solution, then export and import the solution into the target environment:

1. Add the following components to a solution and export it from the source environment:
   - Agent Script (msdyn_productivityagentscripts)
   - Agent Script Step (msdyn_productivityagentscriptsteps)
   - Application Tab Template (msdyn_applicationtabtemplates)
   - Notification Field (msdyn_notificationfields)
   - Notification Template (msdyn_notificationtemplates)
   - Macro (processes)
   - Session Templates (msdyn_sessiontemplates)
   - Template Parameter (msdyn_templateparameters)

1. Import the solution into the target environment.

For more information on solutions go to [Solutions in Power Apps](/power-apps/maker/data-platform/solutions-overview).

## Migrate configuration for skill-based routing rulesets

If skill-based routing rulesets are used in your setup, perform the steps to migrate the corresponding configuration.

For sample schema to get all the required records, see [Sample schema for skill-based routing configuration](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/unified-routing-sample-schemas/Sample%20schema%20for%20skill-based%20routing.xml).

1. Use the Configuration Migration tool to create the schema and export data from the source environment (organization) for skill-based routing configuration.
  
   - **Entity display name**: When you create the schema, select the tables (entities) in the sequence as mentioned in the following table.
   - **Attribute display name**: We recommend that you select the columns (attributes) defined in the table. You don't need to select the out-of-the-box system-defined columns like **Created By**, **Created On**, **Modified By**, **Modified On**, and **Owner**. You can select custom columns if necessary.

    > [!IMPORTANT]
    > For **Characteristic** table, you must manually create **bookableresourcecharacteristictype** Global choice-value in the target environment, or use a solution to migrate it from the source environment, if necessary.

    |Entity display name (Logical name)  |Attribute display name (Logical name)  |Use FetchXML to filter records  |
    |---------|---------|---------|
    |Characteristic (characteristic)    | <ul><li>Characteristic Type (characteristictype)</li><li>Characteristic (characteristicid)</li><li>Description (description)</li><li>Name (name)</li></ul> |         |
    |Rating Model (ratingmodel)     |<ul><li>Max Rating Value (maxratingvalue)</li><li>Min Rating Value (minratingvalue)</li><li>Name (name)</li><li>Rating Model (ratingmodelid)</li></ul>         |         |
    |Rating Value (ratingvalue)     | <ul><li>Name (name)</li><li>Rating Model (ratingmodel)</li><li>Rating Value (ratingvalueid)</li><li>Value (value)</li></ul> |         |

1. Generate the schema and save it.

1. Export the data and generate the compressed (zip) file.

1. Use the Configuration Migration tool and select the option to import data into the target environment using the compressed file.

## Migrate configuration for new capacity profiles

If you configured new capacity profiles in your setup, perform the steps to migrate the corresponding configuration.

For sample schema to get all the required records, go to [Sample schema for capacity profiles](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/unified-routing-sample-schemas/Sample%20schema%20for%20capacity%20profiles.xml).

> [!TIP]
> After you migrate a new capacity profile using the Configuration Migration tool, migrate the updates using solutions.

1. Use the Configuration Migration tool to create the schema and export data in the source environment for capacity profile configuration.
   - **Entity display name**: When you create the schema, select the tables (entities) from the list in the same sequence as mentioned in the following table.
   - **Attribute display name**: We recommend that you select the columns (attributes) defined in the table. You don't need to select the out-of-the-box system defined columns like **Created By**, **Created On**, **Modified By**, **Modified On**, and **Owner**. You can select custom columns, if necessary.
   - **Use FetchXML to filter records**: For each selected table, use the appropriate FetchXML query that's mentioned in the table to get single, multiple, or all records based on your requirement. For single or multiple rows, you need to use the source environment to get the correct name in uiname and GUID in value. If required, you can use the **ADVANCED FIND** menu item to construct the appropriate FetchXML query.

    |Entity display name (Logical name)  |Attribute display name (Logical name)  |Use FetchXML to filter records  |
    |---------|---------|---------|
    |Capacity Profile (msdyn_capacityprofile)     | <ul><li>Block Assignment (msdyn_blockassignment)</li><li>Capacity Profile (msdyn_capacityprofileid)</li><li>Default Max Units (msdyn_defaultmaxunits)</li>Name (msdyn_name)</li><li>Reset Duration(msdyn_resetduration)</li><li>Unique Name (msdyn_uniquename)</li></ul> | **Sample 1: For all capacity profile records**<br>`<fetch>` <br>  `  <entity name="msdyn_capacityprofile">` <br>`    <filter type="and">`<br>`      <condition attribute="ismanaged" operator="eq" value="0" />`<br>`    </filter>`<br>`  </entity>`<br>  `</fetch>`<br><br> **Sample 2: For a single capacity profile record** <br> `<fetch>` <br>`  <entity name="msdyn_capacityprofile">`<br>`    <filter type="and">`<br>`      <condition attribute="msdyn_capacityprofileid" operator="eq" uiname="Demo Capacity Profile 1" uitype="msdyn_capacityprofile" value="{F57CFE3C-14BD-D53E-F423-A1E7F9749DFB}" />`<br> `    </filter>`<br> `  </entity>`<br> `</fetch>` <br><br> **Sample 3: For multiple capacity profile records** <br> `<fetch>`<br> `  <entity name="msdyn_capacityprofile">`<br> `    <filter type="and">` <br> `      <condition attribute="msdyn_capacityprofileid" operator="in">`<br>`        <value uiname="Demo Capacity Profile 1" uitype="msdyn_capacityprofile">{F57CFE3C-14BD-D53E-F423-A1E7F9749DFB}</value>`<br> `        <value uiname="Demo Capacity Profile 2" uitype="msdyn_capacityprofile">{D0B8ABFB-4A9F-0B1F-6FF4-8003E29A623C}</value>`<br>`      </condition>`<br>`    </filter>`<br>`  </entity>`<br>`</fetch>` |

1. Generate the schema and save it.

1. Export the data and generate the compressed (zip) file.

1. Open the Configuration Migration tool and select the option to import data into the target environment.

## Migrate configuration for queues

Use the Configuration Migration tool to create the schema and export data from the source environment for the queue configuration.
   - **Entity display name**: When you create the schema, select the tables (entities) from the list in the same sequence as mentioned in the following table.
   - **Attribute display name**: We recommend that you select the columns (attributes) defined in the table. You don't need to select the out-of-the-box system defined columns like **Created By**, **Created On**, **Modified By**, **Modified On**, and **Owner**. You can select custom columns, if necessary.
   - **Use FetchXML to filter records**: For each selected table, use the appropriate FetchXML query that's mentioned in the table to get single, multiple, or all records based on your requirement. For single or multiple rows, you need to use the source environment to get the correct name in uiname and GUID in value. If required, you can use the **ADVANCED FIND** menu item to construct the appropriate FetchXML query.
   - Configure import settings: For the **Decision contract** table, ensure that you select the **Do not update existing records** checkbox.

If you're using the out-of-the-box assignment methods for queues, such as highest capacity and round robin, skip the following entities:
   - Decision rule set
   - Assignment configuration
   - Assignment configuration step

The assignment rulesets must be available in the system before the Configuration Migration tool imports the selection criteria. Hence, you need to perform the following steps in the specified order to migrate configuration for record queues:

> [!IMPORTANT]
>
> - For every import of queue records, you must create new queue records or update existing queue records. Don't mix the actions in the same data import.
> - When all records in the data.xml of the queue table are for creation, make sure that the following line is present in the schema.xml: `<field displayname="Queue type" name="msdyn_queuetype" type="optionsetvalue" customfield="true"/>`, and the corresponding data will also have the field for msdyn_queuetype.
> - When all records in the data.xml of queue table are for an update, ensure that you remove the following line in the schema.xml: `<field displayname="Queue type" name="msdyn_queuetype" type="optionsetvalue" customfield="true"/>`, and the corresponding data also won't have that field for msdyn_queuetype.
> - When the queue that you want to migrate has an overflow condition set, then you must export and import the decision ruleset first. The migration sequence should look as follows:
>   - Decision contract
>   - Decision ruleset
>   - Queue
>   - Assignment Configuration
>   - Assignment Configuration Step without selection criteria
>   - Operating Hour
>   - Overflow Action
> - You can't migrate the Calendar item associated with the Operating Hour table. You'll need to set it correctly after you import the Operating Hour table into the target environment.

### Step 1: Export and import rulesets without selection criteria

The following table summarizes the entities and corresponding FetchXML samples.

| Entity display name (Logical name)  |Attribute display name (Logical name)  |Use FetchXML to filter records  |
|---------|---------|---------|
| Queue (queue) |  <ul><li>Assignment Input Contract Id (msdyn_assignmentinputcontractid)</li><li>Assignment Strategy (msdyn_assignmentstrategy) </li> <li> Description (description) </li><li> Is Default Queue (msdyn_isdefaultqueue) </li><li> Is Omnichannel queue (msdyn_isomnichannelqueue) </li><li> Name (name) </li><li> Priority (msdyn_priority) </li><li> Queue (queueid) </li><li> Queue type (msdyn_queuetype) </li><li> Type (queueviewtype) </li><li>Operating Hours (msdyn_operatinghourid)</li><li>Prequeue Overflow Ruleset (msdyn_prequeueoverflowrulesetid)</li></ul>  |  [**Sample 1: All queues for records**](#BKMK1all-ur-qs) <br><br> [**Sample 2: Single queue for records**](#BKMK2single-ur-qs) <br><br> [**Sample 3: Multiple queues for records**](#BKMK3multiple-ur-qs) |
| Decision contract (msdyn_decisioncontract)  |  <ul> <li>Contract definition (msdyn_contractdefinition)</li> <li>Decision contract (msdyn_decisioncontractid) </li> <li>Name (msdyn_name) </li> <li>Unique name (msdyn_uniquename) </li> </ui>  | [**Sample 1: Decision contract for all record queues**](#BKMK1all-ur-dc) <br> <br>  [**Sample 2: Decision contract for a single record queue**](#BKMK2single-ur-dc) <br> <br> [**Sample 3: Decision contract for multiple record queues**](#BKMK3multiple-ur-dc) <br> |
|  Decision ruleset without selection criteria (msdyn_decisionruleset)  |  <ul><li>AI builder model (msdyn_aibmodelid)</li><li>Authoring mode (msdyn_authoringmode)</li><li>Decision rule set (msdyn_decisionrulesetid)</li><li>Description (msdyn_description)</li><li>Input contract (msdyn_inputcontractid)</li><li>Is input collection (msdyn_isinputcollection)</li><li>ML model type (msdyn_mlmodeltype)</li><li>Name (msdyn_name)</li><li>Output contract (msdyn_outputcontractid)</li><li>Rule set definition (msdyn_rulesetdefinition)</li><li>Rule set type (msdyn_rulesettype)</li><li>Unique name (msdyn_uniquename)</li><li>FetchXML for ruleset (msdyn_fetchxml)</li></ul>  |  [**Sample 1: Decision ruleset for all record queues without selection criteria defined**](#BKMK1nsc-ur-rls) <br> <br> [**Sample 2: Decision ruleset for a single record queue without selection criteria defined**](#BKMK2nsc-ur-rls) <br> <br> [**Sample 3: Decision ruleset for multiple record queues without selection criteria defined**](#BKMK3nsc-ur-rls) <br>  |
|  Assignment Configuration (msdyn_assignmentconfiguration)  |  <ul><li>Assignment Configuration (msdyn_assignmentconfigurationid)</li><li>Description (msdyn_description)</li><li>Is Active Configuration (msdyn_isactiveconfiguration)</li><li>Name (msdyn_name)</li><li>Queue (msdyn_queueid)</li><li>Unique Name (msdyn_uniquename)</li></ul>  | [**Sample 1: Assignment configuration for all record queues**](#BKMK1all-ur-ac) <br> <br>[**Sample 2: Assignment configuration for a single record queue**](#BKMK2single-ur-ac) <br> <br>[**Sample 3: Assignment configuration for multiple record queues**](#BKMK3multiple-ur-ac) <br>   |
|  Assignment Configuration Step without selection criteria (msdyn_assignmentconfigurationstep)  |  <ul><li>Assignment Configuration (msdyn_assignmentconfigurationid)</li><li>Assignment Configuration Step (msdyn_assignmentconfigurationstepid)</li><li>Is default ruleset (msdyn_isdefaultruleset)</li><li>Name (msdyn_name)</li><li>Rule Set (msdyn_rulesetid)</li><li>Step Order (msdyn_steporder)</li><li>Step Type (msdyn_type)</li><li>Unique Name (msdyn_uniquename)</li></ul>  |  [**Sample 1: Assignment configuration step for all record queues without selection criteria defined**](#BKMK1nsc-ur-acs) <br> <br> [**Sample 2: Assignment configuration step for a single record queue without selection criteria defined**](#BKMK2nsc-ur-acs) <br> <br> [**Sample 3: Assignment configuration step for multiple record queues without selection criteria defined**](#BKMK3nsc-ur-acs) <br>   |
|Operating Hour (msdyn_operatinghour)|<ul><li>Description (msdyn_description)</li><li>Name (msdyn_name)</li><li>Operating Hour (msdyn_operatinghourid)</li><li>Status (statecode)</li><li>Status Reason (statuscode)</li></ul>|[**Sample 1: Operating Hours for all record queues**](#BKMK1-oh)<br><br>[**Sample 2: Operating Hours for a single record queue**](#BKMK2-oh) <br><br>[**Sample 3: Operating Hours for multiple record queues**](#BKMK3-oh) |
|Overflow Action Config (msdyn_overflowactionconfig)|<ul><li> Name (msdyn_name)</li><li>Overflow Action Config (msdyn_overflowactionconfigid)</li><li>Overflow Action Data (msdyn_overflowactiondata)</li><li>Overflow Action Type(msdyn_overflowactiontype)</li><li>Status (statecode)</li><li>Status Reason (statuscode)</li></ul>|[**FetchXML for overflow action configurations**](#BKMK1-ov)|

Perform the following steps to export and import the rulesets:

1. Generate the schema and save it.

2. Export the data and generate the compressed (zip) file.

3. Extract the zip file, open the data.xml file present in the extracted folder, and do the following:

   - In the source and target environments, run the following OData API call and note the GUID of `msdyn_decisioncontractid`.

      `https://<OrgURL>/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_assignmentoutput'`

     In the data.xml file, replace all the occurrences of the msdyn_decisioncontractid GUID in the source environment with the msdyn_decisioncontractid GUID of the target environment.

   - In the source and target environments, run the following OData API call and note the GUID of `msdyn_decisioncontractid`.

      `https://<OrgURL>/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_selectionruleoutput'`

     In the data.xml file, replace all occurrences of the msdyn_decisioncontractid GUID in the source environment with the msdyn_decisioncontractid GUID of the target environment.
   
   - In the source and target environments, run the following OData API call and note the GUID of msdyn_decisioncontractid.
      `https://<OrgURL>/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_queueoverflowrulesetinput'`

     In the data.xml file, replace all the occurrences of the msdyn_decisioncontractid GUID in the source environment with the msdyn_decisioncontractid GUID of the target environment.

   - In the source and target environment, run the following OData API call and note the GUID of msdyn_decisioncontractid.
      
    `https://<OrgURL>/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_queueoverflowrulesetoutput'`
    
     In the data.xml file, replace all occurrences of the msdyn_decisioncontractid GUID in the source environment with the msdyn_decisioncontractid GUID of the target environment.  

4. Package the extracted content again.

5. Use the Configuration Migration tool, select the option to import data, and then select the compressed file.

> [!NOTE]
> Set the Calendar Item associated with the Operating Hour table correctly after you import the Operating Hour table into the target environment.

For sample schema to get all the required records, go to [Sample schema for record queues step 1](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/unified-routing-sample-schemas/Sample%20schema%20for%20unified%20routing%20record%20queues%20step%201.xml).

### Step 2: Export and import rulesets with selection criteria defined

The following table summarizes the entities and corresponding FetchXML samples.

|Entity display name (Logical name)  |Attribute display name (Logical name)  |Use FetchXML to filter records  |
|---------|---------|---------|
|  Decision ruleset with selection criteria (msdyn_decisionruleset)  |  <ul><li>AI builder model (msdyn_aibmodelid)</li><li>Authoring mode (msdyn_authoringmode)</li><li>Decision rule set (msdyn_decisionrulesetid)</li><li>Description (msdyn_description)</li><li>Input contract (msdyn_inputcontractid)</li><li>Is input collection (msdyn_isinputcollection)</li><li>ML model type (msdyn_mlmodeltype)</li><li>Name (msdyn_name)</li><li>Output contract (msdyn_outputcontractid)</li><li>Rule set definition (msdyn_rulesetdefinition)</li><li>Rule set type (msdyn_rulesettype)</li><li>Unique name (msdyn_uniquename)</li></ul>  |  [**Sample 1: Decision ruleset for all record queues with selection criteria defined**](#BKMK1sc-ur-rls) <br> <br> [**Sample 2: Decision ruleset for a single record queue with selection criteria defined**](#BKMK2sc-ur-rls) <br> <br> [**Sample 3: Decision ruleset for multiple record queues with selection criteria defined**](#BKMK3sc-ur-rls) <br>  |
|  Assignment Configuration Step with selection criteria (msdyn_assignmentconfigurationstep)  |  <ul><li>Assignment Configuration (msdyn_assignmentconfigurationid)</li><li>Assignment Configuration Step (msdyn_assignmentconfigurationstepid)</li><li>Is default ruleset (msdyn_isdefaultruleset)</li><li>Name (msdyn_name)</li><li>Rule Set (msdyn_rulesetid)</li><li>Step Order (msdyn_steporder)</li><li>Step Type (msdyn_type)</li><li>Unique Name (msdyn_uniquename)</li></ul>  |  [**Sample 1: Assignment configuration step for all record queues with selection criteria defined**](#BKMK1sc-ur-acs) <br> <br> [**Sample 2: Assignment configuration step for a single record queue with selection criteria defined**](#BKMK2sc-ur-acs) <br> <br> [**Sample 3: Assignment configuration step for multiple record queues with selection criteria defined**](#BKMK3sc-ur-acs) <br>   |

Perform the following steps to export and import the rulesets:

1. Generate the schema and save it.

2. Export the data and generate the compressed (zip) file.

3. Extract the zip file, open the data.xml file present in the extracted folder, and do the following:

   - In the source and target environments, run the following OData API call and note the GUID of `msdyn_decisioncontractid`.

      `https://<OrgURL>/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_assignmentoutput'`

     In the data.xml file, replace all the occurrences of the msdyn_decisioncontractid GUID in the source environment with the msdyn_decisioncontractid GUID of the target environment.

   - In the source and target environments, run the following OData API call and note the GUID of `msdyn_decisioncontractid`.

      `https://<OrgURL>/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_selectionruleoutput'`

     In the data.xml file, replace all occurrences of the msdyn_decisioncontractid GUID in the source environment with the msdyn_decisioncontractid GUID of the target environment.

4. Package the extracted content again.

5. Use the Configuration Migration tool, select the option to import data, and then select the compressed file.

For sample schema to get all the required records, see [Sample schema for record queues step 2](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/unified-routing-sample-schemas/Sample%20schema%20for%20unified%20routing%20record%20queues%20step%202.xml).

### FetchXML for queues

**Sample 1: All queues**<a name="BKMK1all-ur-qs"></a>

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

**Sample 2: Single queue**<a name="BKMK2single-ur-qs"></a>

```XML
<fetch> 
   <entity name="queue"> 
    <filter type="and"> 
      <condition attribute="queueid" operator="eq" uiname="Test Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" /> 
    </filter> 
   </entity> 
</fetch>
```

**Sample 3: Multiple queues**<a name="BKMK3multiple-ur-qs"></a>

```XML
<fetch> 
   <entity name="queue"> 
    <filter type="and"> 
     <condition attribute="queueid" operator="in"> 
      <value uiname="Test Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value> 
      <value uiname="Test Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value> 
     </condition> 
    </filter> 
   </entity> 
</fetch> 
```

### FetchXML for decision contracts

**Sample 1: Decision contracts for all queues**<a name="BKMK1all-ur-dc"></a>

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

**Sample 2: Decision contracts for a single queue**<a name="BKMK2single-ur-dc"></a>

```XML
<fetch distinct="true">
	<entity name="msdyn_decisioncontract">
		<filter type="or">
			<filter type="and">
				<condition attribute="queueid" entityname="aw" operator="eq" uiname="Test Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
			</filter>
			<filter type="and">
				<condition attribute="queueid" entityname="be" operator="eq" uiname="Test Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
			</filter>
			<filter type="and">
				<condition attribute="queueid" entityname="bm" operator="eq" uiname="Test Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
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

**Sample 3: Decision contracts for multiple queues**<a name="BKMK3multiple-ur-dc"></a>

```XML
<fetch distinct="true">
	<entity name="msdyn_decisioncontract">
		<filter type="or">
			<filter type="and">
				<condition attribute="queueid" entityname="aw" operator="in">
					<value uiname="Test Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
					<value uiname="Test Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
				</condition>
			</filter>
			<filter type="and">
				<condition attribute="queueid" entityname="be" operator="in">
					<value uiname="Test Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
					<value uiname="Test Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
				</condition>
			</filter>
			<filter type="and">
				<condition attribute="queueid" entityname="bm" operator="in">
					<value uiname="Test Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
					<value uiname="Test Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
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

### FetchXML for decision rulesets for queues

**Sample 1: Decision rulesets for all queues without selection criteria**<a name="BKMK1nsc-ur-rls"></a>

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

**Sample 2: Decision rulesets for a single queue without selection criteria**<a name="BKMK2nsc-ur-rls"></a>

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
								<condition attribute="queueid" operator="eq" uiname="Test Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
							</filter>
						</link-entity>
					</link-entity>
				</link-entity>
			</entity>
		</fetch>
```

**Sample 3: Decision rulesets for multiple queues without selection criteria**<a name="BKMK3nsc-ur-rls"></a>

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
									<value uiname="Test Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
									<value uiname="Test Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
								</condition>
							</filter>
						</link-entity>
					</link-entity>
				</link-entity>
			</entity>
		</fetch>
```

### FetchXML for assignment configurations

**Sample 1: Assignment configurations for all queues**<a name="BKMK1all-ur-ac"></a>

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

**Sample 2: Assignment configurations for a single queue**<a name="BKMK2single-ur-ac"></a>

```XML
<fetch>
	<entity name="msdyn_assignmentconfiguration">
		<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="bi">
			<filter type="and">
				<condition attribute="queueid" operator="eq" uiname="Test Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
			</filter>
		</link-entity>
	</entity>
</fetch> 
```

**Sample 3: Assignment configurations for multiple queues**<a name="BKMK3multiple-ur-ac"></a>

```XML
<fetch>
	<entity name="msdyn_assignmentconfiguration">
		<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="bi">
			<filter type="and">
				<condition attribute="queueid" operator="in">
					<value uiname="Test Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
					<value uiname="Test Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
				</condition>
			</filter>
		</link-entity>
	</entity>
</fetch> 
```

### FetchXML for assignment configuration steps

**Sample 1: Assignment configuration steps for all queues without selection criteria**<a name="BKMK1nsc-ur-acs"></a>

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

**Sample 2: Assignment configuration steps for a single queue without selection criteria**<a name="BKMK2nsc-ur-acs"></a>

```XML
		<fetch>
			<entity name="msdyn_assignmentconfigurationstep">
				<filter>
						<condition attribute="msdyn_type" operator="ne" value="192350001" />
				</filter>
				<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="inner" alias="bq">
					<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="br">
						<filter type="and">
							<condition attribute="queueid" operator="eq" uiname="Test Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
						</filter>
					</link-entity>
				</link-entity>
			</entity>
		</fetch>
```

**Sample 3: Assignment configuration steps for multiple queues without selection criteria**<a name="BKMK3nsc-ur-acs"></a>

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
								<value uiname="Test Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
								<value uiname="Test Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
							</condition>
						</filter>
					</link-entity>
				</link-entity>
			</entity> 
```


### FetchXML for decision rulesets for queues

**Sample 1: Decision rulesets for all queues with selection criteria**<a name="BKMK1sc-ur-rls"></a>
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

**Sample 2: Decision rulesets for a single queue with selection criteria**<a name="BKMK2sc-ur-rls"></a>

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
								<condition attribute="queueid" operator="eq" uiname="Test Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
							</filter>
						</link-entity>
					</link-entity>
				</link-entity>
			</entity>
		</fetch>
```

**Sample 3: Decision rulesets for multiple queues with selection criteria**<a name="BKMK3sc-ur-rls"></a>

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
									<value uiname="Test Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
									<value uiname="Test Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
								</condition>
							</filter>
						</link-entity>
					</link-entity>
				</link-entity>
			</entity>
		</fetch>
```

### FetchXML for assignment configuration steps

**Sample 1: Assignment configuration steps for all queues with selection criteria**<a name="BKMK1sc-ur-acs"></a>

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

**Sample 2: Assignment configuration steps for a single queue with selection criteria**<a name="BKMK2sc-ur-acs"></a>

```XML
		<fetch>
			<entity name="msdyn_assignmentconfigurationstep">
				<filter>
						<condition attribute="msdyn_type" operator="eq" value="192350001" />
				</filter>
				<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="inner" alias="bq">
					<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="br">
						<filter type="and">
							<condition attribute="queueid" operator="eq" uiname="Test Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
						</filter>
					</link-entity>
				</link-entity>
			</entity>
		</fetch>
```

**Sample 3: Assignment configuration steps for multiple queues with selection criteria**<a name="BKMK3sc-ur-acs"></a>

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
								<value uiname="Test Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
								<value uiname="Test Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
							</condition>
						</filter>
					</link-entity>
				</link-entity>
			</entity>
		</fetch>
```

### FetchXML for operating hours

**Sample 1: Operating hours for all queues**<a name="BKMK1-oh"></a>

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

**Sample 2: Operating hours for a single queue**<a name="BKMK2-oh"></a>

```xml
XMLCopy
        <fetch>
            <entity name="msdyn_operatinghour">
                <link-entity name="queue" from="msdyn_operatinghourid" to="msdyn_operatinghourid" link-type="inner" alias="ab">
                <filter type="and">
                    <condition attribute="queueid" operator="in">
                        <value uiname="Test Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value> 
                    </condition>
                </filter>
                </link-entity>
            </entity>
        </fetch>
```

**Sample 3: Operating hours for multiple queues**<a name="BKMK3-oh"></a>

```xml
XMLCopy
        <fetch>
            <entity name="msdyn_operatinghour">
                <link-entity name="queue" from="msdyn_operatinghourid" to="msdyn_operatinghourid" link-type="inner" alias="ab">
                <filter type="and">
                    <condition attribute="queueid" operator="in">
                        <value uiname="Test Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value> 
                        <value uiname="Test Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value> 
                    </condition>
                </filter>
                </link-entity>
            </entity>
        </fetch>
```

### FetchXML for overflow action configurations<a name="BKMK1-ov"></a>

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

## Migrate configuration for intake rules and record workstreams

Use the following steps to migrate intake rules and record workstreams from the source environment to the destination environment.

1. Create a solution to export configurations from the source environment for record routing workstreams.
1. Add the required records to the solution using the **Add existing button** in the command bar.
1. Select the **Work Stream (msdyn_liveworkstream)** table. Related records from the following tables are automatically added to the solution:
   - Capacity Profile (msdyn_capacityprofile)—new records must be migrated using the Configuration Migration tool.
   - Master entity routing configuration (msdyn_masterentityroutingconfiguration).
   - Decision contract (msdyn_decisioncontract)—for both intake rules and record workstreams.
   - Decision rule set (msdyn_decisionruleset)—for both intake rules and record workstreams.
   - Routing configuration (msdyn_routingconfiguration).
   - Routing configuration step (msdyn_routingconfigurationstep).
   - Operating Hour (msdyn_operatinghour).

## Next steps

[Verify migration of records](migrate-config-data-verify.md)  


### Related information

[Migrate configurations for channels using solutions](migrate-channel-config-using-solutions.md)  
