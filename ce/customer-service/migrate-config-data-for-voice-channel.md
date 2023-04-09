---
title: "Migrate unified routing data for the voice channel | MicrosoftDocs"
description: "Learn to migrate the voice channel data from source to target environments in Omnichannel for Customer Service."
ms.date: 12/20/2022
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
  - Survey question (`msdyn_surveyquestions`)
  - Survey question sequence (`msdyn_questionsequence`)
  - Survey answer option (`msdyn_chatansweroption`)
  - Quick replies (`msdyn_cannedmessages`)
  - Tags (`msdyn_octags`)

> [!IMPORTANT]
>
> The migration of the account, channel, Azure Communication Services phone number acquisition, phone number configuration, bot configuration, and AI and analytics settings is not in scope.

## Migrate the voice channel configuration

You must perform the steps in the order they're listed to migrate your configuration data successfully. Use the information in the tables and refer to the corresponding sample schemas for each configuration.

1. Export and import configuration for skill-based routing
1. Export and import configuration for capacity profiles
1. Export and import configuration for voice channel queues
1. Export and import configuration for voice channel workstreams
1. Verify your migration
1. Troubleshoot export and import of data


## Migrate skill-based configuration

If skill-based routing rulesets are used in your unified routing setup, perform the steps outlined in [Migrate data for skill-based routing](migrate-config-data-for-records.md#migrate-configuration-for-skill-based-routing-rulesets).


## Migrate configuration for voice channel queues

For exporting and importing queues for the voice channel, perform the steps outlined in [Migrate data for unified routing-based record queues](migrate-config-data-for-records.md#migrate-configuration-for-record-queues).

## Migrate configuration for voice channel workstreams

Use the Configuration Migration tool to create the schema and export the data from the source organization for the following entities:

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

## Migrate configuration for voice channel settings

The following assumptions are in place:

- Queues can be exported after voice channel configurations and rules definition.

- The workstream must already exist; created manually or previously migrated in the destination organization.

**To migrate data for voice channel**

1. Use the Configuration Migration tool to create the schema and export data from the source organization for the voice channel and related entities.

   - **Entity display name**: When you create the schema, select the entities in the sequence that's mentioned in the table.
   - **Attribute display name**: We recommend that you select the attributes defined in the following table. You don't have to select the system-defined attributes, such as Created By, Created On, Modified By, Modified On, and Owner. You can select custom attributes if necessary.

   | Display Name | Entity Schema Name |
   |---------|---------|
   | Work Stream | msdyn_liveworkstream |
   | Voice Channel Setting | msdyn_ocvoicechannelsetting |
   | Voice Channel Language Setting | msdyn_ocvoicechannellanguagesetting |
   | Voice  | msdyn_ocvoice |
   | Provisioning State | msdyn_ocprovisioningstate |                           
   |    |         |

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
