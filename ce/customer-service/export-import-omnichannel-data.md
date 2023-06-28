---
title: "Export and import app configuration data | MicrosoftDocs"
description: "Learn to export and import app configuration data from source to target environments in Omnichannel Administration and Omnichannel admin center apps."
ms.date: 02/25/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
---

# Export and import app configuration data

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../includes/cc-omnichannel-administration-deprecation-note.md)]

After you have used Omnichannel for Customer Service in a test environment, you can export some of your app configuration data to a live production environment. Use the configuration management tool to export and import the data. More information: [Download the Configuration Migration tool from NuGet using the PowerShell script](/powerapps/developer/data-platform/download-tools-nuget)

> [!IMPORTANT]
> Channel configurations are specific to environment in which they are created, so exporting and importing complete configurations as is won't work. We recommend that you create them using the Omnichannel admin center app.

While you can use the Configuration Migration tool to export and import entity data, omnichannel-related configurations contain different entities that have internal dependencies. Therefore, you must bring together the required data by following a very specific process. For example, if you have already imported the context variables and then try to import pre-conversation configuration, which also creates context variables, the import might not work. Similarly, you must import all the internal entities, such as ruleset configurations that contain decision rulesets and contracts, for the import of workstreams and record queues to be successful.

> [!NOTE]
>
> - To export and import record type of channel across environments, contact [Microsoft Support](https://dynamics.microsoft.com/support/).
> - Environment lifecycle operations, such as copy and restore of environment, are not supported.
> - However, if you do copy an environment, Omnichannel for Customer Service in the target environment must be [uninstalled](remove-omnichannel.md) and [provisioned](omnichannel-provision-license.md) again.
> - We recommend that you don't export the msdyn_analytics entity. The entity contains org-specific configuration data for intraday insights in Omnichannel for Customer Service; exporting the entity might lead to an incorrect configuration of your intraday insights data.


### See also

[Provision Omnichannel for Customer Service](omnichannel-provision-license.md)                                                         
[Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)                                                                              
[Migrate configuration data for records based on unified routing](migrate-config-data-for-records-overview.md)                                                   
[Migrate configuration for live chat](migrate-config-data-for-live-chat.md)  
[Migrate configuration for voice channel](migrate-config-data-for-voice-channel.md)                                                       
[Enable third-party co-browse and screen sharing](third-party-co-browse.md)                                                      
[Overview of channels](channels.md)                                                                                                         

[!INCLUDE[footer-include](../includes/footer-banner.md)]
