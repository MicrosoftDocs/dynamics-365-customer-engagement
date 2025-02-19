---
title: Frequently asked questions about unified routing
description: Learn about the frequently asked questions (FAQs) for unified routing.
ms.date: 02/04/2025
ms.topic: conceptual
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
---

# FAQ about unified routing in Customer Service, Omnichannel for Customer Service

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

This article contains the FAQs that you as an administrator, supervisor, or a customer service representative (service representative or representative) might have about unified routing.

## General

### What SKUs must I have to get unified routing?

You must have the Customer Service Enterprise license. [See prerequisites for licensing information](provision-unified-routing.md#prerequisites).

### Does unified routing support activity routing?

Yes. Unified routing supports routing activities, including email.

### What happens to my existing queues after I migrate to unified routing?

The existing queues are automatically migrated to unified routing.

### Why aren't the records being routed after unified routing is enabled?

Verify whether you [configured an intake rule](set-up-record-routing.md#configure-intake-rules) and mapped it to a basic routing rule that's active.

### Can I route any record type by using basic routing?

No. Basic routing can be used for cases only. To route any record type, use unified routing.

### Is there a priority among queues?

Yes, you can use **Queue priority** to prioritize queues. Queues are ordered from highest to lowest priority when work items are assigned. This means that a smaller number has a higher priority than a bigger queue number. For example, a queue with number 1 is prioritized over another queue whose number is 2. Learn more in [How unified routing prioritizes work items](assignment-methods.md#how-unified-routing-prioritizes-work-items).

### Can I pause the assignment of a case?

No. It's not possible to pause the assignment of a case.

### Can representatives pick work items of records to which they don't have permissions?

Yes, service representatives can pick the work item even if they don't have permission to access the record. However, they can't view the details and the conversation is closed. For more information, refer to the note in [Set up record routing](set-up-record-routing.md#configure-work-distribution-and-advanced-settings).

### Can supervisors assign work items pertaining to inaccessible records?

Yes. However, the conversation is closed if representatives don't have sufficient permission to access the records.

### Can I export a unified routing configuration and sign in to another environment?

Yes, you can export a configuration with unified routing content for the record type and live chat channel. Learn more in the following articles:

- [Migrate data for the record channel](migrate-config-data-for-records-overview.md)
- [Migrate data for the live chat channel](migrate-config-data-for-live-chat.md)

### I have two workstreams (W1, W2) and four queues (Q1, Q2, Q3, Q4) and a case (C1) is assigned to Q2. Is it possible to now reassign C1 to Q3?

Yes. It's possible to reassign a case to another queue. On the case form, select **Save and route** to reassign the work item from one queue to another queue.

### Why can't I view the **Keep same agent for entire conversation** toggle in my **Work distribution settings** for a workstream related to cases?

A case remains with the service representative that it was initially assigned to and therefore the corresponding workstream for cases doesn't have the agent affinity toggle.

### How are unassigned work items in a queue handled if no matching representative is found?

The unassigned work item remains in the queue until you manually assign it to a representative or route it to another queue. Learn more in [How assignment rulesets work](assignment-methods.md#how-assignment-rulesets-work).

### Can advanced queues be associated with a mailbox?

No, you can't configure a mailbox for advanced queues. If you want to use or manage queue mailboxes, we recommend that you use basic queues only.

## Work item assignment

### Why does the queue have unassigned work items?

For work items to be assigned automatically, the queue must be a private queue with at least one representative.

### Can I increase the limit on assignment offer of work items to representatives?

Yes, you can update the limit. Learn more in [How the limit on offering a work item repeatedly to a representative works](assignment-methods.md#limits-on-offering-a-work-item-repeatedly-to-a-representative).

### Does unified routing offer the same conversation when a representative declines it or after the notification times out?

The representatives aren't offered the same conversation anymore after they decline it and are removed from priority but can be offered other conversations. However, if they're the only ones eligible, the system offers the same conversation up to three times or the configured limit.

## Route to least-active agent

### For which channel is the routing to least-active representative feature available?

The feature is available for the voice channel only.

### Does the sign-in time affect the calculation of the least active representative? 

The representative's "last capacity release time for a voice call" is the only parameter used by the least-active assignment method and their sign-in times don't affect the capacity release time. 

### How is a tie-breaker scenario resolved if two or more representatives have the same capacity release time?

If the last capacity release time is the same for two matching representatives, then assignment is done in a round-robin manner.

### How does routing to the least active representative work when a new representative signs in?

When a new representative signs in to the Customer Service workspace app, their "last capacity release time" isn't available in the system. Therefore, the system considers that representative as the least active among the matched others, and assigns the next work item to them.

## Intelligent skill finder

### Is intelligent skill finder available in all geographical regions?

Intelligent skill finder requires AI Builder to create and train the machine learning model. If AI Builder isn't available in the customer region where unified routing is, the customer gets a generic error when trying to set up the model.

### Can I use intelligent skill finder with email activities?

Yes. Intelligent skill finder can be enabled for any entity that's enabled for routing by using any text-based field. For email body skill finder, another step is required because email body (description) includes HTML tags that can impact the machine learning model. You extract the text from HTML, copy it into another text field, and then configure the machine learning model against the new field.

### How do I make sure that the right skills are attached to the work items when the machine learning-based model is in use?

- Ensure that representatives are trained to attach correct skills, review, and correct any incorrectly attached skills.
- Review the skill finder model to make sure that the training data is correct and retrain the model periodically to improve it.

## Capacity profiles

### I have a work item labeled with two capacity profiles and three representatives who match at varying levels. Which one of them is eligible for assignment?

If two of the representatives match one each of the required capacity profiles and the third one matches on both the required capacity profiles, then the work item is assigned to the third representative. Learn more in [Use capacity profiles](capacity-profiles.md#how-to-set-multiple-capacity-profiles-in-a-single-workstream).

## Deprecation of diagnostics

### What is diagnostics for unified routing and why is it being deprecated?

Routing diagnostics lend visibility into how routing decisions are made for work items in contact centers. It was deprecated with a better alternative of Azure Application Insights for end-to-end conversation diagnostics.

### What is the alternative to routing diagnostics after it's deprecated?

Customers can use Azure Application Insights, which is our one-stop solution to get a comprehensive view of end-to-end conversation diagnostics.

### Do I need to perform any migration steps to start using Application Insights?

No. Application Insights is a separate tool where diagnostics can be queried specific to your business requirements. After you enable it, data events are available in application insights data storage and you can query the data to get the details.

### How do I enable application insights?

To enable application insights, you need to set up a connection of your Dynamics 365 Customer Service environment with Azure Application Insights. Learn more in [Set up a connection with Azure Application Insights](/power-platform/admin/conversation-diagnostics-application-insights#set-up-a-connection-with-azure-application-insights).


> [!NOTE]
> Application Insights can be enabled for managed environments only. When an environment is managed, it allows you greater visibility and control with the capabilities that allow admins to manage Power Platform at scale. Learn more in [Managed Environments overview](/power-platform/admin/managed-environment-overview).

### Do I need to purchase any add-on to use application insights?

A pay-as-you-go pricing model is associated with Azure Monitor. The Application Insights tool in Azure Monitor helps you monitor the availability, performance, and usage of your Dynamics 365 apps. Azure Monitor charges you for the features you use. When you set up Application Insights for ingestion, retention, and export of data, Azure Monitor charges you based on this use. Learn more in [Pricing](/power-platform/admin/conversation-diagnostics-application-insights#pricing).

### Can all my users access application insights? How do I give access for everybody?

Application Insights is meant for developer, support, and admin personas. Users with these roles and responsibilities can be set up to access Application Insights using Azure role-based access. Learn more in [Assign Azure roles using the Azure portal](/azure/role-based-access-control/role-assignments-portal).

### Not everyone in my organization can write queries. How do they use application insights?	

We provide sample queries for common questions that customers seek answers to. These samples would be available within the blade in Application Insights for you to run or modify to suit your question.

### Data that I'm looking for isn't available in Application Insights. How do I raise a request for more data events?

We'll iteratively add more data events for diagnostics. Follow the documentation for more updates.

### Related information

[Overview of unified routing](overview-unified-routing.md)  
[System requirements for Omnichannel for Customer Service](../implement/system-requirements-omnichannel.md)  
[Set up unified routing for records](set-up-record-routing.md)  
