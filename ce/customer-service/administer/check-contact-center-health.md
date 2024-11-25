---
title: Check your contact center health
description: Learn how, as an admin, you can check the contact center health to diagnose configuration errors and address them by using the health check results.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to
ms.collection:
ms.date: 07/01/2024
ms.custom: bap-template
---

# Check your contact center health

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

As administrators, you can use the integrated health checker to identify any errors, warnings, and then recommended best practices in your configuration. You can receive proactive notifications of emerging issues with health checks running in the background. This proactive approach can help ensure that your call center flows and configurations operate at optimal levels. 

## Prerequisites

You must have the System Administrator role.


## Run a check

Do the following steps to check for configuration errors and incomplete configurations in your Customer Service environment.

1. Sign into Customer Service admin center. The **Home** page displays the **Contact center health** section.
1. Select **Run health** check. Depending on the size of your contact center and the various features that you configured, the check takes a couple of minutes to run and display the results.

   After the check is complete, the page displays the results in three categories with the number of occurrences as follows:

    - Errors
    - Warnings
    - Suggestions

     :::image type="content" source="../media/contact-center-health-check.png" alt-text="A screenshot of  the page after the health check runs.":::

1. Expand a category to see the problems and then select the link to a problematic setting. The setting opens on a new tab for you to take action on it.
1. Optionally, after you resolve all the issues in the configuration, run the health check again until you see zero occurrences of errors and warnings.

### Health check rules

Some of the rules used in the health check and their descriptions are as follows. 

| Category | Problem: Description | Recommendation displayed by the health checker |
|----------|---------------------|--------------------|
| Error | Automatic record creation or update didn't work: To review issues with automatic record creation and update rules, visit the activity monitor dashboard. | Link to the activity monitor. |
| Error | SLA compliance risks and failures aren't being monitored: Agents aren't being informed about SLA compliance failures or risks. To resume compliance monitoring, restart the SLAInstanceMonitoringWarningAndExpiryFlow cloud flow solution within Power Automate.  | Link to Power Automate flow. |
| Error | Default queue is inactive: Routing rules using this queue don't work. Activate the queue or change the default to an active queue | Link to the inactive queue page to activate the default queue. |
| Error | No agents in the queue: A queue without agents can't be used for routing. Remove the empty queue from routing definitions, or add agents to the queue. | Link to queue page to add agents or supervisors. |
| Error | Workstream has no intake rules: Without an intake rule, a workstream's routing definitions don't work. Define an intake rule for the workstream. | Link to workstream page to create intake rules. |
| Error | No valid assignment definition for the queue: Without an assignment method, agents in the queue can’t be assigned work items. Select an assignment method. If it’s a custom method, ensure that it contains rules. | Link to queue page to add custom assignment rule. |
| Warning | Unsupported automatic record creation rules in use: Automatic record creation rules defined in the web client aren't supported. Use the migration tool to update the rules in the Unified Interface experience, and activate the new rule version. | Link to migration tool for automatic record creation. |
| Warning | Unsupported service level agreement rules in use: Service level agreement rules defined in the web client aren't supported. Use the migration tool to update the rules in the Unified Interface experience, and delete the old rule version. | Link to the migration tool for service level agreements. |

### Known issues

[Contact Center health checker doesn’t appear in the admin center](https://go.microsoft.com/fwlink/p/?linkid=2165393)

### Related information

[Create queues in unified routing](queues-omnichannel.md)  
[Create records automatically](automatically-create-update-records.md)  
[Use Customer Service admin center](../implement/cs-admin-center.md)  


