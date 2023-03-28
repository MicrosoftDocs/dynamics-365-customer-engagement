---
title: Frequently asked questions about unified routing
description: Learn about the frequently asked questions (FAQs) for unified routing in Customer Service and Omnichannel for Customer Service.
ms.date: 01/11/2023
ms.topic: concept
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.custom: bap-template
---

# FAQ about unified routing in Customer Service, Omnichannel for Customer Service

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../includes/cc-omnichannel-administration-deprecation-note.md)]

## Overview

This topic contains the FAQs that you as an administrator, supervisor, or agent might have about unified routing.

## General

### What SKUs must I have to get unified routing?

Customers will get unified routing for entities, such as Cases, Leads, and custom entities, as part of the Customer Service Enterprise license. When you purchase channels (Chat and Digital messaging), you'll get unified routing for chat and messaging channels automatically.

### What will happen to my current workstreams after unified routing is installed?

For messaging channels, use the migration utility to migrate the workstream and associated routing rules. For entity routing, you'll configure new workstreams and rules in unified routing. More information: [Migrate workstreams created in Omnichannel Administration](migrate-workstreams.md).

### What are the implications when migration is in progress?

There is no downtime involved when you are migrating the workstreams, but it's recommended that you perform the migration during low load or off hours.

### Why do I see workstreams that I didn't create in Omnichannel Administration?

These workstreams were created either in the Omnichannel admin center or Customer Service Hub app. In the Omnichannel Administration app, you'll see all the workstreams irrespective of the app that has been used to create them. We recommend that you manage the workstreams in the same app that you used to create them.

### How do I migrate my configurations from the Omnichannel Administration app to the Omnichannel admin center app?

To migrate the messaging workstreams, you can use the Unified Routing Migration Application. For information on the migration tool and instructions, see [Migrate workstreams created in Omnichannel Administration](migrate-workstreams.md).

> [!NOTE]
> After you migrate the workstreams, you'll be able to manage them in the Customer Service admin center or Omnichannel admin center app only. We recommend that you familiarize yourself with these apps before migrating. More information: [Get started with Omnichannel admin center](oc-admin-center.md).

### Can I manage my workstreams in the Omnichannel Administration app post migration?

No. Although you will see the migrated workstreams in the old admin app as well, we recommend that you manage the migrated workstreams in the Customer Service admin center app.

### What are the implications when I start the migration process for the workstreams?

There is no downtime when you are migrating the workstreams, but we recommend that you perform the migration during low load or off work hours.

### Is it possible to roll back the migration?

To roll back the migration, you will need to contact [Microsoft Support](https://dynamics.microsoft.com/support/).

### How can I migrate the entity routing workstreams?

Entity routing workstreams must be recreated in Customer Service admin center and the rules must be manually recreated in the new workstream.

If you need further help, contact Microsoft Support.

### Can I create workstreams for routing records in the Omnichannel Administration app after upgrading Omnichannel for Customer Service to 2021 release wave 1?

No. After upgrade, you'll no longer be able to create workstreams for routing records because they won't work as expected. We recommend that you start using the Customer Service admin center app to create and manage routing of records.

### Will unified routing support activity routing?

Yes, unified routing supports routing activities, including email.

### What happens to my existing queues after I migrate to unified routing?

The existing queues will be automatically migrated to unified routing.

### Can I route any record type by using basic routing?

No. Basic routing can be used only for cases. To route any record type, use unified routing.

### Is there a priority among queues? Can we use the field **Group Number** or **Priority**? Does it affect the order of the case assignment?

No. There's no priority among queues. However, you can prioritize records within a queue.

### Can I pause the assignment of a case?

No. It's not possible to pause the assignment of a case.

### Can agents pick work items of records to which they don't have permissions?

Yes, agents can pick the work item even if they don't have permission to access the record. However, they can't view the details and the conversation will be closed. For more information, see the note in [Set up record routing](set-up-record-routing.md#configure-work-distribution-and-advanced-settings).

### Can supervisors assign work items pertaining to inaccessible records?

Yes. However, the conversation will be closed if agents don't have sufficient permission to access the records.

### Can I export a unified routing configuration and sign in to another environment?

Yes, you can export a configuration with unified routing content for the record type and live chat channel. For more information, see the following articles:

- [Migrate data for the record channel](migrate-config-data-for-records-overview.md)
- [Migrate data for the live chat channel](migrate-config-data-for-live-chat.md)

### I have two workstreams (W1, W2) and four queues (Q1, Q2, Q3, Q4) and a case (C1) is assigned to Q2. Is it possible to now reassign C1 to Q3?

Yes. It's possible to reassign a case to another queue. On the case form, select **Save and route** to reassign the work item from one queue to another queue.

### Why am I not able to see the **Keep same agent for entire conversation** toggle in my **Work distribution settings** for a workstream related to cases?

A case remains with the agent that it was initially assigned to and therefore the corresponding workstream for cases doesn't have the agent affinity toggle.

### Can I access Omnichannel Ongoing Conversations Dashboard and Omnichannel Intraday Insights in Customer Service workspace?

Yes, you can access Omnichannel Ongoing Conversations Dashboard and Omnichannel Intraday Insights in Customer Service workspace if you have the Chat for Dynamics 365 Customer Service or Digital Messaging for Dynamics 365 Customer Service license.

### How are unassigned work items in a queue handled if no matching agent is found?

The unassigned work item remains in the queue until you manually assign it to an agent or route it to another queue. More information: [How assignment rulesets work](assignment-methods.md#how-assignment-rulesets-work)

## Work item assignment

### Can I increase the limit on assignment offer of work items to agents?

Yes, you can update the limit. More information: [How the limit on offering a work item repeatedly to an agent works](assignment-methods.md#how-the-limit-on-offering-a-work-item-repeatedly-to-an-agent-works)

## Route to most-idle agent

### For which channels is routing to most-idle agent (preview) available?

In the preview release, the feature is available for the voice channel only.

### Is presence used in determining the most-idle agent?

No, presence isn't used. Only capacity release information is taken into account.

### Does the agent sign-in time affect in the calculation of the most-idle agent?

The agent’s last capacity release time only affects the idle time used by the most-idle assignment method. The agent sign-in times don't impact the capacity release time.

### How is a tie-breaker scenario resolved if two or more agents match the idle time?

If the last capacity release time, which is the time since the agent is idle, is the same for two matching agents, then assignment will be done in a round-robin manner.

### Can I see diagnostics for routing to the most-idle agent?

Yes, the assignment method stage displays the assignment method that's used.

## Intelligent skill finder

### Will intelligent skill finder be available in all geographical regions?

Intelligent skill finder requires AI Builder to create and train the machine learning model. If AI Builder is not available in the customer region where unified routing is, the customer will get a generic error when trying to set up the model.

### Can I use intelligent skill finder with email activities?

Yes, intelligent skill finder can be enabled for any entity that is enabled for routing by using any text-based field. For email body skill finder, an additional step is required because email body (description) includes HTML tags that can impact the machine learning model. You'll extract the text from HTML, copy it into another text field, and then configure the machine learning model against the new field.

### How do I make sure that the right skills are attached to the work items when the machine learning-based model is in use?

- Ensure that agents are trained to attach correct skills, review, and correct any incorrectly attached skills.
- Review the skill finder model to make sure that the training data is correct and retrain the model periodically to improve it.

## Capacity profiles

### I have a work item labeled with two capacity profiles and three agents who match at varying levels. Which agent is eligible for assignment?

If two of the agents match one each of the required capacity profiles and the third agent matches on both the required capacity profiles, then the work item is assigned to the third agent. More information: [Use capacity profiles](capacity-profiles.md#how-to-set-multiple-capacity-profiles-in-a-single-workstream)

### See also

[Overview of unified routing](overview-unified-routing.md)  
[System requirements for Omnichannel for Customer Service](system-requirements-omnichannel.md)  
[Set up unified routing for records](set-up-record-routing.md)  
