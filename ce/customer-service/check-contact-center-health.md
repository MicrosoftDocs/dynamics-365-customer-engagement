---
title: Check your contact center health
description: Learn how, as an admin, you can check the contact center health to diagnose configuration errors and address them by using the health check results.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to
ms.collection:
ms.date: 09/14/2023
ms.custom: bap-template
---

# Check your contact center health

As administrators, you can use the integrated health check to identify any errors, warnings, and recommended best practices in your configuration. You will receive proactive notifications of emerging issues with health checks running in the background. This proactive approach can help ensure that your call center flows and configurations are maintained at optimal levels. 

## Prerequisites

You must have the systen administrator role.


## Run a check

Do the following steps to check for configuration errors and incomplete configurations in your Customer Service environment.

1. In Dynamics 365, go to Customer Service admin center. The **Home** page displays the **Contact center health** section.
1. Select **Run health** check. Depending on the size of your contact center and the various features that you have configured, the check takes a couple of minutes to run and display the results.

After the check is complete, the page displays the results in three categories with the number of occurrences as follows:

- Errors
- Warnings
- Suggestions

   :::image type="content" source="media/contact-center-health-check.png" alt-text="A screenshot of  the page after the health check runs.":::

1. Expand a category to see the problems and then select the link to a problematic setting. The setting opens on a new tab for you to take action on it.
1. Optionally, after you resolve all the issues in the configuration, run the health check again till you see zero occurrences.

### See also

[Create queues in unified routing](queues-omnichannel.md)  
[Create records automatically](automatically-create-update-records.md)  


