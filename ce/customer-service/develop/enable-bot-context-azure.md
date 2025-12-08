---
title:  Configure agent context in Azure agents  
description: Use this article to understand how you can enable an Azure agent to understand context while authoring a agent flow.
ms.date: 12/08/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
ms.collection: bap-ai-copilot
---
# Configure agent context in Azure agents

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

For Azure agents, you must install the agent SDK and instantiate the Omnichannel middleware before you configure agent context.

## Install the bot SDK in your project

1. To open the NuGet Package Manager, right-click your project and then select **Manage NuGet Packages**.

2. In the NuGet Package Manager, select the package source as **nuget.org** and browse for "Microsoft.Dynamics.AgentsSDK.Middleware". Select the package and then select **Install**. More information: [Nuget page](https://www.nuget.org/packages/Microsoft.Dynamics.AgentsSDK.Middleware/1.0.0)

   Alternatively, you can use the following command in NuGet CLI.

   ```JavaScript
   Install-Package Microsoft.Dynamics.AgentsSDK.Middleware
   ```

The agent SDK is now installed and the Omnichannel middleware is available in your project.

## Use the Omnichannel middleware in your agent code

1. Open the **AdapterWithErrorHandler.cs** file.

2. Add the import statement and instantiate the Omnichannel middleware.  

    ```CSharp
    using Microsoft.Dynamics.AgentsSDK.Middleware.Core; 
    Use(new OmnichannelMiddleware()); 
    ```

    ```CSharp
    using System.Globalization;
    using System.Text;
    using Microsoft.Agents.Hosting.AspNetCore;
    using Microsoft.Agents.Builder;
    using Microsoft.Agents.Connector;
    using Microsoft.Agents.Core;
    using Microsoft.Agents.Hosting.AspNetCore.BackgroundQueue;
    using Microsoft.CCaaS.MessagingRuntime.Common.Http;
    using Microsoft.Agents.Core.Errors;
    using Microsoft.Extensions.Logging;
    using Microsoft.Dynamics.AgentsSDK.Middleware.Core;
    
    namespace Microsoft.CCaaS.MessagingRuntime.TestAgent;
    
    public class AdapterWithErrorHandler : CloudAdapter
    {
        public AdapterWithErrorHandler(
            IChannelServiceClientFactory channelServiceClientFactory,
            IActivityTaskQueue activityTaskQueue,
            ILogger<CloudAdapter> logger)
            : base(channelServiceClientFactory, activityTaskQueue, logger)
        {
            // OmnichannelMiddleware has special handling for OC event messages
            Use(new OmnichannelMiddleware());
    
            OnTurnError = async (turnContext, exception) =>
            {
                var exceptionInfo = GetExceptionInfo(exception);
                logger.LogAppException(exceptionInfo, exception);
    
                // Send a message to the user
                await turnContext.SendActivityAsync($"The bot encountered an error or bug.{Environment.NewLine}{exceptionInfo}");
                await turnContext.SendActivityAsync("To continue to run this bot, please fix the bot source code.");
    
                // Send a trace activity, which will be displayed in the Bot Framework Emulator
                await turnContext.TraceActivityAsync("OnTurnError Trace", exception.Message, "https://www.botframework.com/schemas/error", "TurnError");
            };
        }
    
        private static string GetExceptionInfo(Exception exception)
        {
            var sb = new StringBuilder();
    
            // Pull some well known info from ErrorResponse.Exception if available.
            if (exception is ErrorResponseException responseException)
            {
                sb.AppendLine(CultureInfo.InvariantCulture, $"Error code: {responseException.Body?.Error?.Code ?? "NA"}");
                sb.AppendLine(CultureInfo.InvariantCulture, $"Error message: {responseException.Body?.Error?.Message ?? "NA"}");
            }
    
            sb.AppendLine(CultureInfo.InvariantCulture, $"Exception message: {exception.Message}");
            sb.AppendLine();
            sb.AppendLine(exception.ToString());
    
            var exceptionInfo = sb.ToString();
            return exceptionInfo;
        }
    }
    ```

## Next steps

[Parse activity JSON to get agent context](parse-activity-json-to-get-bot-context.md)  

### Related information

[Send custom context](send-context-starting-chat.md)  
[setContextProvider](reference/methods/setContextProvider.md)  
[Integrate an Azure agent](../administer/configure-bot-azure.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
