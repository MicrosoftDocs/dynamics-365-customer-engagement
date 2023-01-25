---
title: Overview of data migration for records | MicrosoftDocs
description: This article provides an overview of data migration in the records channel in Omnichannel for Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: overview
ms.date: 01/23/2023
ms.custom: bap-template
---

# Overview of data migration for records

Use the Configuration Migration tool to migrate the configurations from the source organization to the target organization for the records that are based on unified routing.

For information on how to download and use the Configuration Migration tool, see the following articles:

- [Download Configuration Migration tool](/powerapps/developer/data-platform/download-tools-nuget)
- [How the Configuration Migration tool works](/power-platform/admin/manage-configuration-data)

## Prerequisites

Check for the following before you migrate your configuration data:

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

## Migrate configuration data for the record channel

Perform the steps in the following order to successfully migrate your configuration data from the source to the target organization. 

1. [Use FetchXML query to filter records](use-fetchxml-filter-records.md)
1. [Migrate skill-based routing rulesets](migrate-config-data-for-records.md#migrate-configuration-for-skill-based-routing-rulesets)
1. [Migrate capacity profiles](migrate-config-data-for-records.md#migrate-configuration-for-capacity-profiles)
1. [Migrate queues](migrate-config-data-for-records.md#migrate-configuration-for-record-queues)
1. [Migrate intake rules](migrate-config-data-for-records.md#migrate-configuration-for-intake-rules-for-record-routing)
1. [Migrate workstreams](migrate-config-data-for-records.md#migrate-configuration-for-record-workstreams)
1. [Verify your data migration](migrate-config-data-verify.md)
1. [Troubleshoot your data migration](migrate-config-data-troubleshoot.md)

> [!IMPORTANT]
> The migration process doesn't include:
>
> - Intelligent skill finder
> - Effort estimation for routing (preview)
> - Sentiment prediction for routing (preview)
> - Operating hours
> - Role persona mapping
> - Notification template
> - Session template
> - Presence
> - Queue membership


## Next steps

[Use FetchXML query to filter records](use-fetchxml-filter-records.md)  


### See also

[Create a schema to export configuration data](/power-platform/admin/create-schema-export-configuration-data)  
[Migrate configuration data for records](migrate-config-data-for-records.md)  
[Verify migration of records](migrate-config-data-verify.md)  
[Troubleshoot migration of records](migrate-config-data-troubleshoot.md)  
[Migrate configuration data for live chat](migrate-config-data-for-live-chat.md)  
[Migrate configuration data for voice channel](migrate-config-data-for-voice-channel.md)   
