---
title: "Build a smart assist bot | MicrosoftDocs"
description: "Read how you can build a smart assist bot to help agents resolve customer queries faster and more effectively"
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 04/15/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---
# Build a smart assist bot

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

To quickly get started, follow the instructions mentioned in this topic for building a smart assist bot that displays knowledge article recommendations to the agent. After this, you can do additional steps for creating custom scenarios.

## Prerequisites

You need to have an understanding on how to create a bot using [Azure Bot Service](https://docs.microsoft.com/azure/bot-service/abs-quickstart?view=azure-bot-service-4.0).<!-- When you register your bot with Azure Bot Service, you will obtain `Microsoft App ID` and `Client secret` which you will need to update the `appsettings.json` file in the bot. -->

## Sample bot that displays knowledge article recommendations

For setting up a sample for smart assist bot for displaying knowledge article recommendations to the agent, please see the instructions mentioned in the sample [README](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot/README.md) file. 

For information on how to create a knowledge article using template, see [Create a knowledge article using a template](../../../customer-service/create-knowledge-article-using-template.md).

## Sample bot that displays similar case recommendations

After setting up a sample bot using above steps, you can configure your bot to show similar case recommendations for ‘printer noise’ using the instructions mentioned in the topic [Implement a custom scenario](smart-assist-scenario.md).

<!--
- Create a LUIS app by following the instructions mentioned in [Add natural language understanding to your bot](https://docs.microsoft.com/azure/bot-service/bot-builder-howto-v4-luis?view=azure-bot-service-4.0&tabs=csharp). See the section [Retrieve application information from the LUIS.ai portal](https://docs.microsoft.com/azure/bot-service/bot-builder-howto-v4-luis?view=azure-bot-service-4.0&tabs=csharp#retrieve-application-information-from-the-luisai-portal) for information on how to retrieve the values you need to setup the bot.
- You will need to register your app on Azure Active Directory. More information: [Register an app with Azure AD](/powerapps/developer/common-data-service/walkthrough-register-app-azure-active-directory).

Refer to the sample code [README](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot/README.md) file for information on how and where to update the values obtained from the above steps.


## Smart assist using knowledge articles

<!--Consider the scenario wherein a customer is trying to troubleshoot his printer and he initiates a chat with customer support to resolve his queries. Customer tells the agent that his printer is making a loud noise and that he has tried restarting it but it did not work. <!--The smart assist assesses the context of the conversation and based on that it displays recommendations on similar cases.The agent searches for knowledge base articles for the problem shared by the customer and shares them with the customer.


This section provides information on how you can build a smart assist bot that displays knowledge article recommendations to the agent.

<!--Given below is the adaptive card JSON for displaying knowledge article recommendations.

```json
{
    "type": "AdaptiveCard",
    "body": [
        {
            "type": "Container",
            "items": [
                {
                    "type": "ColumnSet",
                    "columns": [
                        {
                            "type": "Column",
                            "width": "auto",
                            "items": [
                                {
                                    "type": "Image",
                                    "altText": "",
                                    "url": "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAA8AAAAOCAYAAADwikbvAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAACOSURBVHgB7ZLRDYIwFEXPsw7ACI7gIiYygi6gq7iAjRNowgA6kgMApQ0UCiWBhC8Szk/zbt/N+zmC55kZQoQfhXmg5IbhaJOk/buepF4JS02IfieU6oyIpuSOyl9c0n98xA/Dy1OZfXcsYCuvprzvTaEUTk836ewb6RmVvZqOTs8DBR+rZ9rqGSCjCs6kAicPMswh3Ik+AAAAAElFTkSuQmCC",
                                    "width": "16px",
                                    "height": "16px"
                                }
                            ]
                        },
                        {
                            "type": "Column",
                            "width": "stretch",
                            "items": [
                                {
                                    "type": "TextBlock",
                                    "text": "Knowledge article"
                                }
                            ]
                        }
                    ]
                }
            ]
        },
        {
            "type": "Container",
            "items": [
                {
                    "type": "TextBlock",
                    "text": "KB Title",
                    "weight": "Bolder"
                }
            ]
        },
        {
            "type": "TextBlock",
            "text": "KB Description",
            "wrap": true
        }
    ],
    "actions": [
        {
            "type": "Action.Submit",
            "title": "Send",
            "data": {
                "MacroName": "SendKBAsEmail",
                "MacroParameters": {
                    "EmailTemplateName": "KBEmaiLTemplate"
                }
            },
            "iconUrl": "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAA4AAAANCAYAAACZ3F9/AAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAE8SURBVHgBnVLBUQJBEOxd1z8BALWgAWAEagSQAfLw5CdEIBkIP+UeEoIZyGUAAchtnVT55cXDu5txDrkqQKHUeexu7Uz3dO8OrBc18I/QWul6xYtC682bfwGq6nV0xazqSqkFg63sE9LxwD1U3MGOdJSOoVCY+cUWx6YFpqmm45fqTfRk26Hd2zFbqt48pI/4zI0qizyxUqJVU1NWxYPXYfl5q+MaPoYxtc3EzC+PwsfSZWrQY/7+Dipnl+M9xOc+aWAuZJYYmDCha7766nMibrhhMditt52woJemI6RNqekjSQaZJbNmqyFOppuA0/bbhTDf0lJyjD7F229gbPvdcpogv1wBGHdpKnxAz/nl4Cfl6kQmhxXqIDUROR35jjFBjZxfCnAgDMvkQPwRw2FHzkEgiAKK0+5vAXl8ArWLn19rFeLfAAAAAElFTkSuQmCC"
        },
        {
            "type": "Action.Submit",
            "title": "Open",
            "data": {
                "MacroName": "OpenKBLink",
                "MacroParameters": {
                    "kblink": "KB Link"
                }
            },
            "iconUrl": "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAwAAAAJCAYAAAAGuM1UAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAABySURBVHgBnYyxDUBQFEXffURtAvk2YRIaNatoVWxgAyvYwI8JVArEEyqE+HHKm3MuyBCV9DERt2wqA0hpnjVMZZmWUJf+wCrrXBV3rom8b0yjFcCxm3v0JB+BLrxaRPJz9Cbv4P6IFZWwRE/yJfh6/s0G2y1KJHtA3a4AAAAASUVORK5CYII="
        }
    ],
    "$schema": "https://adaptivecards.io/schemas/adaptive-card.json",
    "version": "1.0"
}
```

The [code sample](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot) uses a Web API query to search <xref href="Microsoft.Dynamics.CRM.kbarticle?text=Knowledge Base Article entity" /> in your Dynamics 365 instance. You can modify this query to use <xref href="Microsoft.Dynamics.CRM.incident?text=Incident(case) entity" /> if you wish to search incidents.
-->

<!--## Customize your smart assist bot

Using the instructions mentioned in the [Implement a custom smart assist scenario](smart-assist-scenario.md) topic, you will be able to get similar case recommendations for ‘printer noise’ issue in smart assist while interacting with a customer as an agent in Omnichannel for Customer Service.
-->
<!--
<a name="bkmk_samplecode"></a>

## Sample code

You can find the entire code sample here: [Smart Assist for Bots](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot).

You will find information on how to setup and run the sample in the sample [README](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot/README.md) file. This setup broadly contains the following steps. 

1. Download the Github based [Smart assist sample code](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot).
2. Update the values in `appsettings.json` file.
3. Publish the web application to Azure.
4. Update the Messaging endpoint in Bot channels registration. 
5. Enable Teams channel.
6. Test your Bot online.

The sample code implements two functionalities, one that is Common Data Service specific and other is generic functionality.

In the Common Data Service functionality, the bot finds the intent in the conversation and tries to query Common Data Service for a relevant Knowledge Base article. The connection to Dynamics 365 has to be specified in the `appsettings.json` file in the sample. The `DynamicsDataAccessLayer.cs` class in the sample uses the connection strings mentioned in the app settings file to query the knowledge base articles in your Dynamics 365 instance. For information on how to register your application on Azure Active Directory, see [Register an app with Azure AD](/powerapps/developer/common-data-service/walkthrough-register-app-azure-active-directory).

Use the same app ID while [creating a bot user](https://docs.microsoft.com/dynamics365/omnichannel/administrator/smart-assist#step-2-create-a-bot-user) later. Also if you want your bot to search for knowledge base articles, then provide either the **Customer Service Manager** or **Customer Service Representative** role to your bot user.

For more information, see the code sample [README](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot/README.md) file.
-->
> [!IMPORTANT]
> See this administrator guide topic on how to enable smart assist: [Smart assist for agents](../../administrator/smart-assist.md). It provides instructions on how to create a bot user, how to add a smart assist bot to a workstream and how to enable a productivity pane.

<!--After you have setup the sample bot following the instructions in the [Readme](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot/README.md) file, see the instructions mentioned in the topic [Implement a custom scenario for smart assist bot](smart-assist-scenario.md) to author custom scenarios for your organization. 
-->
> [!div class="nextstepaction"]
> [See Next: Implement a custom scenario for smart assist bot](smart-assist-scenario.md)

## See also

[Sample code: Build a smart assist bot](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot)<br />
[Smart assist for agents](../../administrator/smart-assist.md)<br />
[Create a bot with Azure bot service](/azure/bot-service/abs-quickstart)<br />
[Automate tasks with macros](../../administrator/macros.md)<br />
[Integrate an Azure bot](../../administrator/configure-bot.md)<br />
[Create knowledge article template](../../../customer-service/create-templates-knowledge-article.md)<br />
[Client API reference for model driven apps](/powerapps/developer/model-driven-apps/clientapi/reference)