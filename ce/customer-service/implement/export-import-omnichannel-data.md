---
title: Export and import app configuration data
description: Export and import app configuration data for Omnichannel for Customer Service using the Configuration Migration tool.
ms.date: 05/10/2024
ms.topic: conceptual
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:12/18/2023
  - bap-template
---

# Export and import app configuration data

After you've used the omnichannel capabilities in a test environment, you can export some of your app configuration data to a live production environment. Use the configuration management tool to export and import the data. More information: [Download the Configuration Migration tool from NuGet using the PowerShell script](/powerapps/developer/data-platform/download-tools-nuget)

> [!IMPORTANT]
> Channel configurations are specific to the environment in which they're created, so exporting and importing complete configurations as-is won't work. We recommend that you create the configurations using the Customer Service admin center or Contact Center admin center app.

While you can use the Configuration Migration tool to export and import entity data, omnichannel-related configurations contain different entities that have internal dependencies. Therefore, you must bring together the required data by following a very specific process. For example, if you've already imported the context variables and then try to import preconversation configuration, which also creates context variables, the import might not work. Similarly, you must import all the internal entities, such as ruleset configurations that contain decision rulesets and contracts, for the import of workstreams and record queues to be successful.

> [!NOTE]
> We recommend that you don't export the msdyn_analytics entity. Because the entity contains org-specific configuration data for intraday insights in Omnichannel for Customer Service, exporting it might lead to an incorrect configuration of your intraday insights data.

### Related information

[Provision channels](/dynamics365/contact-center/implement/provision-channels#set-up-channels)                                                                                                                                   
[Migrate configuration data for records based on unified routing](../administer/migrate-config-data-for-records-overview.md)                                                   
[Migrate configuration for live chat](../administer/migrate-config-data-for-live-chat.md)  
[Migrate configuration for voice channel](../administer/migrate-config-data-for-voice-channel.md)                                                       
[Enable third-party cobrowse and screen sharing](../develop/third-party-co-browse.md)                                                      
[Overview of channels](../use/channels.md)                                                                                                         

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
