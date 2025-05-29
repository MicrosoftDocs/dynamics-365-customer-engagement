---
title:  Configure agent context in Azure agents  
description: Use this article to understand how you can enable an Azure agent to understand context while authoring a agent flow.
ms.date: 04/29/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
---
# Configure agent context in Azure agents

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

For Azure agents, you must install the bot SDK and instantiate the Omnichannel middleware before you configure agent context.

## Install the bot SDK in your project

1. To open the NuGet Package Manager, right-click your project and then select **Manage NuGet Packages**.

2. In the NuGet Package Manager, select the package source as **nuget.org** and browse for "Microsoft.Xrm.Omnichannel.BotSDK". Select the package and then select **Install**. More information: [Nuget page](https://www.nuget.org/packages/Microsoft.Xrm.Omnichannel.BotSDK)

Alternatively, you can use the following command in NuGet CLI.

```JavaScript
Install-Package Microsoft.Xrm.Omnichannel.BotSDK
```

The bot SDK is now installed and the Omnichannel middleware is available in your project.

## Use the Omnichannel middleware in your bot code

Use this procedure if you've created your agent using Visual Studio Azure Bot template or Azure portal.

1. Open the **AdapterWithErrorHandler.cs** file.

2. Add the import statement and instantiate the Omnichannel middleware.  

    ```CSharp
    using Microsoft.Omnichannel.Bot.Middleware; 
    Use(new OmnichannelMiddleware()); 
    ```

    ![Add import statement.](../media/bot-context-add-import.png "Add import statement")


## Next steps

[Parse activity JSON to get agent context](parse-activity-json-to-get-bot-context.md)  

### Related information

[Send custom context](send-context-starting-chat.md)  
[setContextProvider](reference/methods/setContextProvider.md)  
[Integrate an Azure agent](../administer/configure-bot-azure.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
