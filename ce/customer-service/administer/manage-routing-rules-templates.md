---
title: Manage template rulesets for unified routing
description: Learn how to create and maintain templated rulesets that help in bulk maintenance of workstreams and queues.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to 
ms.collection: 
ms.date: 03/18/2025
ms.custom: bap-template
---

# Manage template rulesets

You can accelerate configuration tasks by creating templated rulesets for routing configurations, such as assignment and work classification. You can then apply these templates when you need to create rules in prioritization, assignment, and work classification for queues and workstreams.

## Prerequisites

The System Administrator role or a role with permission to access and modify secure columns.

## Create template rulesets

1. In the site map of Contact Center admin center or Customer Service admin center, select **Routing** under **Customer support**.
1. Under Templates, select **Manage** for **Template ruleset**.
1. Select **New template**, and enter the following details:
    - **Ruleset name**
    - **Ruleset**: Select **Assignment**, **Prioritization**, or **Work Classification** in the list.
    - **Type**: Select the channel type in the list.
    -  **Channel**: Appears if you select **Record** in **Type**; with **Case** selected by default.
    - **Description**
1. Select **Create**.
1. Select the template and create rules. You can also import from existing rulesets by selecting **Import from ruleset** and following the wizard.
1. After you finish creating the rules, select **Publish**. The template is ready to be applied to a queue or workstream.

## Manage templates

You can update the templates to add or remove rules. If you edit a published template, the template is first converted into the draft state. If you edit a published template, you'd need to republish for the changes to be effective.

You can delete a template only when it's not linked to any workstream or queue. You need to unlink a template in use and then only can delete it.
