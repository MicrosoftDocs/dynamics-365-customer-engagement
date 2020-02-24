---
title: "Build a custom smart assist bot | MicrosoftDocs"
description: "Read how you can build a smart assist bot to help agents resolve customer queries faster and more effectively"
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 02/24/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---
# Build a custom smart assist bot

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

This topic provides the information on how you can get started with building a custom smart assist bot.

> [!IMPORTANT]
> For the complete code sample on how to create a custom smart assist bot, see: [Smart Assist for Bots](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot). Refer to the code sample [README](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot/README.md) file for information on how to setup and run the sample.

To setup a smart assist bot, you need to create a custom bot that can interpret a conversation and send recommendations to the agent. The bot should contain logic to understand the underlying context of a conversation and send recommendations using adaptive cards. The actions on adaptive cards can be implemented using macros or custom web resources.

## Prerequisites

- To get started with building a custom smart assist bot, you will first need to create a bot with [Azure Bot Service](https://docs.microsoft.com/azure/bot-service/abs-quickstart?view=azure-bot-service-4.0). When you register your bot with Azure Bot Service, you will obtain `Microsoft App ID` and `Client secret` which you will need to update the `appsettings.json` file in the bot.
- Create a LUIS app by following the instructions mentioned in [Add natural language understanding to your bot](https://docs.microsoft.com/azure/bot-service/bot-builder-howto-v4-luis?view=azure-bot-service-4.0&tabs=csharp). See the section [Retrieve application information from the LUIS.ai portal](https://docs.microsoft.com/azure/bot-service/bot-builder-howto-v4-luis?view=azure-bot-service-4.0&tabs=csharp#retrieve-application-information-from-the-luisai-portal) for information on how to retrieve the values you need to setup the bot.
- You will need to register your app on Azure Active Directory. More information: [Register an app with Azure AD](/powerapps/developer/common-data-service/walkthrough-register-app-azure-active-directory).

Refer to the sample code [README](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot/README.md) file for information on how and where to update the values obtained from the above steps.

## Interpret the conversation

It is essential to analyze the conversation and understand its context before you can suggest an action to the agent. Use [Language Understanding (LUIS)](https://luis.ai) to find the intent of the ongoing conversation. You can use the extracted intent to perform actions such as suggesting a knowledge base article, scheduling an appointment or suggesting similar cases. Here is an example on how you can create a LUIS app to find intent from a given text: [Quickstart: Use prebuilt Home automation app](/azure/cognitive-services/luis/luis-get-started-create-app).

## Send adaptive card suggestions

[Adaptive cards](https://adaptivecards.io) is an open-source standard that helps apps and services exchange rich snippets of native UI. The smart assist bot interprets the conversation context in real-time and provides recommendations to the agents.

## Samples for adaptive cards

Based on the intent extracted from an ongoing conversation, you can provide appropriate recommendations to the agent using adaptive cards. This section covers some examples for adaptive cards that can be used for various scenarios. You can use the [Adaptive Cards Designer](https://adaptivecards.io/designer/) to create your own adaptive card template.

### Smart assist using knowledge articles

Consider the scenario wherein a customer is trying to troubleshoot his printer and he initiates a chat with customer support to resolve his queries. Customer tells the agent that his printer is making a loud noise and that he has tried restarting it but it did not work. The smart assist assesses the context of the conversation and based on that it displays recommendations on similar cases.

Given below is the adaptive card JSON for displaying knowledge article recommendations.

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

For information on how to create a knowledge article using template, see [Create a knowledge article using a template](../../../customer-service/create-knowledge-article-using-template.md).

You can also implement functionalities like suggesting similar cases, providing cross sell recommendations and creating appointments. These are out-of-the-box features and the [sample code](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot) does not implement these scenarios. To implement these functionalities, you will need to update the `actions` field in the adaptive cards JSON provided above and develop web resources. The `actions` field instructs the bot on the actions it needs to perform.

## Calling macros and custom actions using adaptive cards

Macros and custom actions can help you implement custom functionalities in your smart assist bot.

### Macros

Macros are a compilations of sequential actions that are reusable for different sessions. These can be used to automate repetitive and monotonous actions that in turn reduce human errors and improve agent productivity. For information on how to build a macro, see [Create macro](../../administrator/macros.md#create-macro).

You can use the `actions` key in adaptive cards JSON and mention the macro or custom action that you want to call, as shown in the example below.

The type is always `Action.Submit` and title can be anything the user wants to name the action.

```json
"actions": [
		{
			"type": "Action.Submit",
			"title": "Accepted",
			"data": {
				"MacroName": "SendEmail",
				"MacroParameters": {
					"subject": "Upgrade offer"
				}
			},
			"iconUrl": "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAA4AAAANCAYAAACZ3F9/AAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAE8SURBVHgBnVLBUQJBEOxd1z8BALWgAWAEagSQAfLw5CdEIBkIP+UeEoIZyGUAAchtnVT55cXDu5txDrkqQKHUeexu7Uz3dO8OrBc18I/QWul6xYtC682bfwGq6nV0xazqSqkFg63sE9LxwD1U3MGOdJSOoVCY+cUWx6YFpqmm45fqTfRk26Hd2zFbqt48pI/4zI0qizyxUqJVU1NWxYPXYfl5q+MaPoYxtc3EzC+PwsfSZWrQY/7+Dipnl+M9xOc+aWAuZJYYmDCha7766nMibrhhMditt52woJemI6RNqekjSQaZJbNmqyFOppuA0/bbhTDf0lJyjD7F229gbPvdcpogv1wBGHdpKnxAz/nl4Cfl6kQmhxXqIDUROR35jjFBjZxfCnAgDMvkQPwRw2FHzkEgiAKK0+5vAXl8ArWLn19rFeLfAAAAAElFTkSuQmCC"
		}
	]
```

See also: [Automate tasks with macros](../../administrator/macros.md).

### Custom actions

You will have to create a web resource if you want to use embed a custom action within a suggestion. See the Power Apps topic on [Create your own actions](/powerapps/developer/common-data-service/custom-actions) for information on how to build a custom action. See the topic [Web resources in model-driven apps](/powerapps/developer/common-data-service/custom-actions) for information on how to create web resources. These web resources will have to be uploaded under the **Customer Summary Form**, as shown in the screenshot below.

![Customer summary form](../../media/conversation-entity-customer-summary.png "Customer summary form")

To use a custom action, replace `MacroName` and `MacroParameters` with `CustomAction` and `CustomParameters` respectively in the adaptive card JSON. The value provided for `CustomAction` key should be the same as the name of the method that is to be called.

```json
"actions": [
		{
			"type": "Action.Submit",
			"title": "Accepted",
			"data": {
				"CustomAction": "SendEmail",
				"CustomParameters": {
					"subject": "Upgrade offer"
				}
			},
			"iconUrl": "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAA4AAAANCAYAAACZ3F9/AAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAE8SURBVHgBnVLBUQJBEOxd1z8BALWgAWAEagSQAfLw5CdEIBkIP+UeEoIZyGUAAchtnVT55cXDu5txDrkqQKHUeexu7Uz3dO8OrBc18I/QWul6xYtC682bfwGq6nV0xazqSqkFg63sE9LxwD1U3MGOdJSOoVCY+cUWx6YFpqmm45fqTfRk26Hd2zFbqt48pI/4zI0qizyxUqJVU1NWxYPXYfl5q+MaPoYxtc3EzC+PwsfSZWrQY/7+Dipnl+M9xOc+aWAuZJYYmDCha7766nMibrhhMditt52woJemI6RNqekjSQaZJbNmqyFOppuA0/bbhTDf0lJyjD7F229gbPvdcpogv1wBGHdpKnxAz/nl4Cfl6kQmhxXqIDUROR35jjFBjZxfCnAgDMvkQPwRw2FHzkEgiAKK0+5vAXl8ArWLn19rFeLfAAAAAElFTkSuQmCC"
		}
	]
```
<a name="bkmk_samplecode"></a>

## Sample code

You can find the entire code sample here: [Smart Assist for Bots](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot). You will find information on how to setup and run the sample in the sample [README](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot/README.md) file.

The sample code implements two functionalities, one that is Common Data Service specific and other is generic functionality.

In the Common Data Service functionality, the bot finds the intent in the conversation and tries to query Common Data Service for a relevant Knowledge Base article. The connection to Dynamics 365 has to be specified in the `appsettings.json` file in the sample. The `DynamicsDataAccessLayer.cs` class in the sample uses the connection strings mentioned in the app settings file to query the knowledge base articles in your Dynamics 365 instance. For information on how to register your application on Azure Active Directory, see [Register an app with Azure AD](/powerapps/developer/common-data-service/walkthrough-register-app-azure-active-directory).

Use the same app ID while [creating a bot user](https://docs.microsoft.com/dynamics365/omnichannel/administrator/smart-assist#step-2-create-a-bot-user) later. Also if you want your bot to search for knowledge base articles, then provide either the **Customer Service Manager** or **Customer Service Representative** role to your bot user.

For more information, see the code sample [README](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot/README.md) file.

> [!NEXT STEP]
> See this administrator guide topic on how to enable smart assist: [Smart assist for agents](../../administrator/smart-assist.md). It provides instructions on how to create a bot user, how to add a smart assist bot to a workstream and how to enable a productivity pane.

## See also

[Smart assist for agents](../../administrator/smart-assist.md)<br />
[Create a bot with Azure bot service](/azure/bot-service/abs-quickstart)<br />
[Automate tasks with macros](../../administrator/macros.md)<br />
[Integrate an Azure bot](../../administrator/configure-bot.md)<br />
[Create knowledge article template](../../../customer-service/create-templates-knowledge-article.md)