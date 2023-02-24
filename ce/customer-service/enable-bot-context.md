---
title: Enable bot context  
description: Use this article to understand how you can enable an Azure bot to understand context while authoring a bot flow.
ms.date: 07/12/2022
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
---
# Enable bot context 

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Bot context includes context name-value pairs for the current conversation and custom context passed by API programmatically. When customers start a conversation, the relevant context that's related to the customer, the issue they're facing, and recent activities performed by them can be made available for the bot to intelligently provide contextual responses to resolve customer issues in a quick and efficient manner. For example, the bot can use the signed-in user details to look up the recent case information or order history of the customer and provide a response. Similarly, the pre-conversation information, custom context, or recent pages browsed on a website by the customer can be passed on to the bot by configuring context variables for your Azure or Power Virtual Agents bots.

As a bot author, you can enable your Azure bots to understand context while authoring a bot flow. 

## Install the bot SDK in your project

1. To open the NuGet Package Manager, right-click your project and then select **Manage NuGet Packages**.

2. In the NuGet Package Manager, select the package source as **nuget.org** and browse for "Microsoft.Xrm.Omnichannel.BotSDK". Select the package and then select **Install**. More information: [Nuget page](https://www.nuget.org/packages/Microsoft.Xrm.Omnichannel.BotSDK)

Alternatively, you can use the following command in NuGet CLI.

```JavaScript
Install-Package Microsoft.Xrm.Omnichannel.BotSDK
```

The bot SDK is now installed and the Omnichannel middleware is available in your project.

## Use the Omnichannel middleware in your bot code

Use this procedure if you've created your bot using Visual Studio Azure Bot template or Azure portal.

1. Open the **AdapterWithErrorHandler.cs** file.

2. Add the import statement and instantiate the Omnichannel middleware.  

    ```CSharp
    using Microsoft.Omnichannel.Bot.Middleware; 
    Use(new OmnichannelMiddleware()); 
    ```

    ![Add import statement.](media/bot-context-add-import.png "Add import statement")



## Next steps

[Parse activity JSON to get bot context](parse-activity-json-to-get-bot-context.md)  

### See also

[Send custom context](send-context-starting-chat.md)  
[setContextProvider](developer/reference/methods/setContextProvider.md)  
[Integrate an Azure bot](configure-bot.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
