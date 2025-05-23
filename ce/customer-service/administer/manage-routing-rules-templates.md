---
title: Manage template rulesets for unified routing
description: Learn how to create and maintain templated rulesets that help in bulk maintenance of workstreams and queues.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to 
ms.collection: 
ms.date: 05/28/2025
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

## Configure role-based access to template rulesets

For a seamless administration of template rulesets, you can configure role-based access to the templates by creating a security role and providing necessary permissions.

### Create a custom security role

1. In Power Platform admin center, create a custom security role and grant permissions as needed. Learn more in [Create custom security roles](role-persona-mapping.md#create-custom-security-roles).
1. In Copilot Service admin center, map the security role to the Omnichannel Administrator persona. Learn more in [Map security roles to personas](role-persona-mapping.md#map-roles-to-personas).

### Update permissions for the custom security role

1. In Power Platform admin center, navigate to the security role you created.
1. Edit the [table privileges](/power-platform/admin/security-roles-privileges?tabs=new#table-privileges).
1. Search for the **Work Stream** table, and set the **Create**, **Read**, **Write**, **Delete**, **Append**, and **Append To** permissions to **User**. Users assigned with the security role can view and edit only those records they have created or those that are shared with them. This change limits users from having global access to all workstreams and queues records. 
1. To completely restrict the user with the custom security role from accessing any workstream-related configurations like classification or route-to-queue ruleset, restrict the privileges for the following tables:
   - Master Entity Routing Configuration
   - Decision contract
   - Decision ruleset
   - Workstream
   - Routing configuration
   - Routing configuration step
   - Workstream capacity profile
1. To restrict the user from accessing any queue-related configurations like prioritization ruleset or assignment ruleset, restrict the privileges for the following tables:
   - Decision contract
   - Decision rule set
   - Queue
   - Assignment Configuration
   - Assignment Configuration Step
   - Operating Hour
   - Overflow Action

### Assign the custom security role to users

In Power Platform admin center, do the steps in [Assign a security role to a user](/power-platform/admin/assign-security-roles) to assign the custom security role to users.

### Share a workstream or queue

1. In Copilot Service admin center, on the Workstreams or Advanced queues page, select the workstream or queue that you want to share, and then select **Share** on the command menu.
1. In the **Share records** dialog, select the users or teams you want to share the workstream or queue with. You can also set the permissions for each user or team.
 
When you share a record permission, it doesn't automatically grant privileges to all the records of the related tables. You need to create a custom plugin to set permissions for the related tables listed for the workstream and queue when you set permissions for the parent table record.  

### Related information

[Create workstreams](create-workstreams.md)  
[Assignment methods in unified routing](assignment-methods.md)  