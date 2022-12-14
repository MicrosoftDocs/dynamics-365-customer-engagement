---
title: "Migrate configuration data for records based on unified routing | MicrosoftDocs"
description: "Learn to migrate data pertaining to records enabled for unified routing from source to target environments in Omnichannel for Customer Service."
ms.date: 12/15/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.reviewer: nenellim
---

# Migrate configuration data for the record channel

Use the Configuration Migration tool to migrate the configurations from the source organization to the target organization for the records that're based on unified routing.

For information on how to use the Configuration Migration tool, see the following articles:

- [Download Configuration Migration Tool](/powerapps/developer/data-platform/download-tools-nuget)
- [How the Configuration Migration tool works](/power-platform/admin/manage-configuration-data)

## Prerequisites

- In the source organization, if a unified routing ruleset refers to the following, then ensure that they exist in the target organization before you proceed with the migration:
  - Custom entities
  - Attributes
  - Relationships
  - Option sets
  - Lookup values
- Ensure that the user who performs the migration has the required privileges on the following entities in the source and target organizations:
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

## Migrate data for the record channel

You must perform the steps in the order they're listed to migrate your configuration data successfully from the source to the target organization. Use the information in the tables and refer to the corresponding sample schemas for each configuration.

1. [Migrate skill-based routing configuration](export-import-config-data-for-records.md#migrate-skill-based-routing-configuration)
2. [Migrate capacity profiles configuration](export-import-config-data-for-records.md#migrate-capacity-profiles-configuration)
3. [Migrate record queues configuration](export-import-config-data-for-records.md#migrate-record-queues-configuration)
4. [Migrate intake rules configuration for records](export-import-config-data-for-records.md#migrate-intake-rules-configuration-for-records)
5. [Migrate workstreams configuration for records](export-import-config-data-for-records.md#migrate-workstreams-configuration-for-records)
6. [Verify your migration](export-import-config-data-for-records-verify.md)
7. [Troubleshoot export and import of data](export-import-config-data-for-records-troubleshoot.md)

> [!IMPORTANT]
> The migration of the following items is not in scope:
>
> - Intelligent skill finder
> - Effort estimation for routing
> - Sentiment prediction for routing
> - Operating hours
> - Role persona mapping
> - Notification template
> - Session template
> - Presence
> - Queue membership

### Generate FetchXML to filter records for exporting data


1. [Use Advanced find to create a custom view](/power-apps/user/advanced-find#create-edit-or-save-a-view-using-legacy-advanced-find).

1. [Select one or multiple records of the entity to export](/power-apps/user/advanced-find#share-a-personal-view). 

1. Select **Download FetchXML**.

1. Edit the XML as follows, and save it:

   1. Remove "output-format=xml-platform".

   2. Remove all attribute elements.

   3. Remove the order attribute element.
  


### See also

[Create a schema to export configuration data](/power-platform/admin/create-schema-export-configuration-data)  
[Export and import configuration for live chat](export-import-config-data-for-live-chat.md)  
