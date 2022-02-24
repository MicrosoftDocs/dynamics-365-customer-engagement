---
title: "Export and import app configuration data | MicrosoftDocs"
description: "Learn to export and import app configuration data from source to target environments in Omnichannel Administration and Omnichannel admin center apps."
ms.date: 02/24/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.reviewer: nenellim
---

# Export and import app configuration data

After you have used Omnichannel for Customer Service in a test environment, you can export some of your app configuration data to a live production environment. Follow the process outlined in this topic to export and then import the app data into your new target environment. That way, you can keep all of the queues, routing rules, workstreams, and other custom settings that you set up earlier.

> [!IMPORTANT]
> However, channel configurations are specific to environment in which they are created, so exporting and importing complete configurations as is won't work. We recommend that you create them using the admin app.

While you can use the configuration migration tool to export and import entity data, omnichannel-related configurations contain different entities that have internal dependencies. Therefore, you must bring together the required data by following a very specific process. For example, if you have already imported the context variables and then try to import pre-conversation configuration that also creates context variables, the import might not work. Similarly, you need to import all the internal entities, such as ruleset configurations that contain decision rulesets and contracts, for the import of workstreams and record queues to be successful.

> [!IMPORTANT]
>
> - To export and import record type of channel across environments, contact [Microsoft Support](https://dynamics.microsoft.com/support/).
> - Environment lifecycle operations, such as copy and restore of environment, are not supported.
> - We recommend that you don't export the msdyn_analytics entity. The entity contains org-specific configuration data for intraday insights in Omnichannel for Customer Service; exporting the entity might lead to an incorrect configuration of your intraday insights data.
> - To export and import users, you must add them to the target environment after you've imported the configuration data.

Use the configuration management tool to export and import the data. More information: [Download the Configuration Migration tool from NuGet using the PowerShell script](/powerapps/developer/data-platform/download-tools-nuget)

### See also

[Provision Omnichannel for Customer Service](omnichannel-provision-license.md)  
[Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)  
[Enable third-party co-browse and screen sharing](third-party-co-browse.md)  
[Overview of channels](channels.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
