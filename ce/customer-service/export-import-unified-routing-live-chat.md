---
title: "Export and import unified routing data for live chat | MicrosoftDocs"
description: "Learn to export and import data pertaining to live chat from source to target environments in Omnichannel for Customer Service."
ms.date: 04/02/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.reviewer: nenellim
---

# Export import data for live chat channel

By using the Configuration Migration tool, you can migrate the unified routing related configurations from the source organization to the target organization for live chat that's configured to use unified routing.

For information on how to use the Configuration Migration tool, see the following articles:

- [Download Configuration Migration Tool](/powerapps/developer/data-platform/download-tools-nuget)
- [How the Configuration Migration tool works](/power-platform/admin/manage-configuration-data)

## Prerequisites

The following prerequisites must be met:

- In the source organization, if unified routing ruleset refers to custom entities, attributes, relationships, option sets or lookup values, then ensure that they exist in the target organization before you proceed with the migration. 
- Ensure that the user who performs the migration has the required privileges on the following unified routing-related entities in the source and target organizations:

    - Workstream (msdyn_liveworkstream)
    - Channel configuration (msdyn_omnichannelconfiguration)
    - Notification template (msdyn_notificationtemplate)
    - Session template (msdyn_sessiontemplate)
    - Operating hours (msdyn_operatinghour)
    - Characteristic (characteristic)
    - Rating Model (ratingmodel)
    - Rating Value (ratingvalue)
    - Capacity Profile (msdyn_capacityprofile)
    - Queue (queue)
    - Decision contract (msdyn_decisioncontract)
    - Decision rule set (msdyn_decisionruleset)
    - Assignment Configuration (msdyn_assignmentconfiguration)
    - Assignment Configuration Step (msdyn_assignmentconfigurationstep)
    - Routing configuration (msdyn_routingconfiguration)
    - Routing configuration step (msdyn_routingconfigurationstep)
    - Workstream capacity profile (msdyn_liveworkstreamcapacityprofile)

> [!IMPORTANT]
> The migration of the account and channel and AI and analytics settings is not in scope.

## Export and import data for the live chat channel

Perform the steps in the order listed to export and import the configuration from the source to the target organization. Use the information in the sections for each type of data and refer to the corresponding sample schemas for each type of configuration to fetch the required records.

1. Export and import data for skill-based routing
1. Export and import data for capacity profiles
1. Export and import data for live chat queues
1. Export and import data for live chat channel workstreams
1. Export and import data for live chat widgets

## Considerations for export and import of data

[!INCLUDE[ur-migration considerations](../includes/cc-ur-migration-considerations.md)]

## Export and import data for skill-based routing

If skill-based routing rulesets are used in your unified routing setup, perform the steps outlined in [Export and import data for skill-based routing](export-import-unified-routing-records.md#export-and-import-data-for-skill-based-routing).

## Export and import data for capacity profiles

If you have configured capacity profiles in your unified routing setup, perform the steps outlined in [Export and import data for capacity profiles](export-import-unified-routing-records.md#export-and-import-data-for-capacity-profiles).

## Export and import data for live chat queues

Waiting for inputs from Cooper.

## Export and import data for live chat channel workstreams

Use the Configuration Migration tool to create schema and export the data from the source organization for the following entities:
- msdyn_liveworkstream
- msdyn_ocliveworkstreamcontextvariable
- msdyn_notificationtemplate
- msdyn_sessiontemplate
- msdyn_surveyquestions
- msdyn_questionsequence
- msdyn_chatansweroption
- msdyn_ocbotchannelregistration

## Export and import data for live chat widgets

The following assumptions are in place:

- Rules will be exported after chat configurations to be able to use pre-chat survey questions as conversation context variables.

- You can't create the context variables when you're adding new questions to the pre chat survey section.

- Queues can be exported after live chat configurations and rules definition, to be able to use preconversation survey questions as context variables.

The workstream must already exist, created manually or previously migrated in the destination organization.

**To export and import data for live chat widgets**

1. Use the Configuration Migration tool to create the schema and export data from the source organization for the live chat widget and related entities.


