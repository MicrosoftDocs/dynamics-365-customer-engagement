---
title: "Export and import record routing data | MicrosoftDocs"
description: "Learn to export and import data pertaining to record enabled for unified routing from source to target environments in Omnichannel for Customer Service."
ms.date: 04/02/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.reviewer: nenellim
---

# Export and import data for record channel

By using the Configuration Migration tool, you can migrate the unified routing related configurations from the source organization to the target organization for the records that are configured to use unified routing.

For information on how to use the Configuration Migration tool, see the following articles:

- [Download Configuration Migration Tool](/powerapps/developer/data-platform/download-tools-nuget)
- [How the Configuration Migration tool works](/power-platform/admin/manage-configuration-data)

## Prerequisites

The following prerequisites must be met:

- In the source org, if unified routing rule set is referring to Custom Entities, Attributes, Relationships, Option Sets or Lookup values then make sure all those already exist in the target org before proceeding with the below mentioned steps. 
- Ensure that user performing data transport has right privileges on unified routing related entities as listed below on source and target org.
  - Characteristic (characteristic)
  - Rating Model (ratingmodel)
  - Rating Value (ratingvalue)
  - Capacity Profile (msdyn_capacityprofile)
  - Queue (queue)
  - Decision contract (msdyn_decisioncontract)
  - Decision rule set (msdyn_decisionruleset)
  - Assignment Configuration (msdyn_assignmentconfiguration)
  - Assignment Configuration Step (msdyn_assignmentconfigurationstep)
  - Master Entity Routing Configuration (msdyn_masterentityroutingconfiguration)
  - Workstream (msdyn_liveworkstream)
  - Routing configuration (msdyn_routingconfiguration)
  - Routing configuration step (msdyn_routingconfigurationstep)
  - Workstream capacity profile (msdyn_liveworkstreamcapacityprofile)

## Export and import data for the record channel

Perform the steps in the order they are listed to export and import the configuration from the source to the target organization. Use the information in the sections for each type of data and refer to the corresponding sample schemas for each type of configuration to fetch the required records.

1. Export and import data for skill-based (logical) routing 
2. Export and import data for capacity profile configuration
3. Export and import data for record queues based on unified routing
4. Export and import data for intake or record routing configuration
5. Export and import data for record workstreams based on unified routing

## Considerations for export and import of data

The following considerations are applicable:

- During the import of the data in to the target organization, if you see yellow warning symbols, we recommend that you verify the logs in the Configuration Migration Tool for network errors. If the logs contain network errors, redo the import step. You can proceed with the next steps if no network errors are indicated in the logs.

    :::image type="content" source="media/yellow-warnings-in-data-import.png" alt-text="Yellow warnings that indicate errors during data import.":::

    An example of a network error is as follows.
    ```
    Time: 11:46:09 PM
    Error: There was no endpoint listening at `https://www.contoso.com/XRMServices/2011/Organization.svc/web?SDKClientVersion=9.2.46.5279` that could accept the message. This is often caused by an incorrect address or SOAP action. See InnerException, if present, for more details.
    Stack Trace: Service stack trace:
    ```
- After you import the unified routing related configuration data successfully from the source to target organization, perform the following steps in the target organization:

  1. In the UI, make sure that the unified routing configuration and rulesets are rendered properly and don't display errors.

  1. If skills and rating values are used in unified routing rulesets, then you need to manually link, associate, or create the users, bookable resources, and bookable resources characteristics records.
  
  1. If capacity profiles are used in rulesets and workstreams for unified routing, then you need to manually link, associate, or create the users, bookable resources, and bookable reources capacity profile records.



### Export and import data for skill-based (logical) routing

If skill-based (logical) routing rulesets are used in your unified routing setup, perform the steps to migrate the corresponding configuration.

**To export and import data for skill-based routing**

1. Use the Configuration Migration tool to create the schema and export data in source organization for skill-based routing (logical) configuration.
  
  - **Entity display name**: When you create the schema, select the entities in the sequence that's mentioned in the following table.
  - **Attribute display name**: We recommend that you select the attributes defined in the following table. You don't need to select the out-of-the-box system defined attributes, such as Created By, Created On, Modified By, Modified On, and Owner. You can select custom attributes if required.


    |Entity display name (Logical name)  |Attribute display name (Logical name)  |Use FetchXML to filter records  |Configure import settings  |
    |---------|---------|---------|---------|
    |Characteristic (characteristic)    | <ul><li>Characteristic Type (characteristictype)</li><li>Characteristic (characteristicid)</li><li>Description (description)</li><li>Name (name)</li></ul>
        |         |         |
    |Rating Model (ratingmodel)     |<ul><li>Max Rating Value (maxratingvalue)</li><li>Min Rating Value (minratingvalue)</li><li>Name (name)</li><li>Rating Model (ratingmodelid)</li></ul>         |         |         |
    |Rating Value (ratingvalue)     | <ul><li>Name (name)</li><li>Rating Model (ratingmodel)</li><li>Rating Value (ratingvalueid)</li><li>Value (value)</li></ul>        |         |         |
    |Row4     |         |         |         |

1. Generate the schema and save it.

2. Export the data and generate the compressed (zip) file.

3. Use the Configuration Migration tool, and select the option to import data to the target organization.

   > [!NOTE]
   > You need to manually create bookableresourcecharacteristictype (Global option set value) in the target organization if required.

### Export and import data for capacity profiles configuration

If you have configured capacity profiles in your unified routing setup, perform the steps to migrate the corresponding configuration.

**To export and import data for capacity profiles**

1. Use the Configuration Migration tool to create the schema and export data in source organization for capacity profiles configuration.

  - **Entity display name**: When you create the schema, select the entities in the sequence that's mentioned in the following table.
  - **Attribute display name**: We recommend that you select the attributes defined in the following table. You don't need to select the out-of-the-box system defined attributes, such as Created By, Created On, Modified By, Modified On, and Owner. You can select custom attributes if required.
  - **Use FetchXML to filter records**: Use the appropriate fetch xml query to get single, multiple, or all records based on your requirement. For single or multiple records, you need to use source organization to get the correct name in uiname and Guid in value. If required, you can use the advanced find option to construct the appropriate fetch xml query. For illustration, the sample query is listed in the following table to get single or multiple records.


    |Entity display name (Logical name)  |Attribute display name (Logical name)  |Use FetchXML to filter records  |Configure import settings  |
    |---------|---------|---------|---------|
    |Capacity Profile (msdyn_capacityprofile)     | <ul><li>Block Assignment (msdyn_blockassignment)</li><li> Capacity Profile (msdyn_capacityprofileid)</li><li>-Default Max Units (msdyn_defaultmaxunits)</li>-Name (msdyn_name)</li><li> Reset Duration </li><li>(msdyn_resetduration)</li><li>Unique Name (msdyn_uniquename)<li></ul> | <fetch>  |         |
    |Row2     |         |         |         |


2. 