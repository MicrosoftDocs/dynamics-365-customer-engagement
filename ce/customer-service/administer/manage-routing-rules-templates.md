---
title: Manage template rulesets for unified routing
description: Learn how to create and maintain templated rulesets that help in bulk maintenance of workstreams and queues.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to 
ms.collection: 
ms.date: 05/27/2025
ms.custom: bap-template
---

# Manage template rulesets

You can accelerate configuration tasks by creating templated rulesets for routing configurations, such as assignment and work classification. You can then apply these templates when you need to create rules in prioritization and assignment for queues, and work classification for workstreams.

## Prerequisites

The System Administrator role or a role with permission to access and modify secure columns.

## Create template rulesets

In template rulesets, the [service quotas](../implement/service-quotas.md) are applicable. 

1. In the site map of Copilot Service admin center, select **Routing** under **Customer support**.
1. Under **Templates**, select **Manage** for **Template ruleset**.
1. Select **New template**, and enter the following details:
    - **Ruleset name**: An intuitive name.
    - **Ruleset**: Select **Assignment**, **Prioritization**, or **Work Classification** in the list.
    - **Type**: Select the channel type in the list.
    -  **Channel**: Appears if you select **Record** in **Type**; with **Case** selected by default.
    - **Description**
1. Select **Create**.
1. Select the template and create rules. You can also import from existing rulesets by selecting **Import from ruleset** and follow the wizard. If any context variables are configured, they are also created as template context variables.
1. After you finish creating the rules, select **Publish**. The template is ready to be applied to a queue or workstream.

## Manage templates

You can update the templates to add or remove rules. If you edit a published template, the template is first converted into the draft state. You need to republish for the changes to be effective. The published updates are automatically pushed to the linked workstreams or queues. You can't update the decision ruleset of the template from within the queue or workstream. The ruleset appears as read only in the linked workstream or queue.

You can delete a template only when it's not linked to any workstream or queue. You need to unlink a template in use and then only can delete it.

You can also revert to the last published configuration.

## Apply template ruleset to queues and workstreams

Assign the template ruleset to queues or workstreams in one of the following ways:

- Assign from template ruleset page:
    1. Select a published template ruleset and on the page that appears, select **Assign template**.
    1. On the **Assign template** dialog, select workstreams for a work classification type template or select queues for assignment or prioritization type template.
    1. Select **Assign**. The decision ruleset for the assigned workstreams or queues is created.
    1. The selected workstreams or queues appear on the **Usage** tab of the template page.
      > [!NOTE]
      > - Queues with custom assignment methods only are listed.
      > - You can assign up to 10 queues or workstreams only. If the template ruleset uses context variables, you can assign five templates only.
- Assign from workstream or queue page:
    - **Queue**: Do the steps in [Create an assignment method and configure rules](configure-assignment-rules.md#create-an-assignment-method-and-configure-rules) to assign a template or its copy.
    - **Workstream**: Do the steps in [Create classification rulesets](configure-work-classification.md#create-work-classification-rulesets) to assign a template or its copy.

## Create template context variables

Use template context variables to create context variables that you can use across workstreams. You can use template context variables in work classification type of ruleset only. 

1. In the site map of Copilot Service admin center, select **Routing** under **Customer support**.
1. Under **Templates**, select **Manage** for **Template context variable**.
1. On the **Template context variable** page, select **New template context variable**.
1. Enter a name and select Text or Number from **Type**.
1. Select **Save and close**. The system assigns the "_template" suffix to the context variable name and saves it.

To use the context variable in the template ruleset, create a condition with the related entity attribute. Choose the template context variable from the available attribute options and define your rule. You can then assign the ruleset to a workstream. During runtime, a copy of the context variable is created to make sure that the ruleset functions as expected.

### Related information

[Create workstreams](create-workstreams.md)  
[Assignment methods in unified routing](assignment-methods.md)  