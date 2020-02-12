---
title: "Build a custom smart assist bot | MicrosoftDocs"
description: "Read how you can build a smart assist bot to help agents resolve customer queries faster and more effectively"
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 01/20/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---
# Build a custom smart assist bot

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

Smart assist is an intelligent assistant that provides real-time recommendations to the agents, enabling them to take actions while interacting with the customers. It allows organizations to build a custom bot to push real-time recommendations to agents within the smart assist control on the agent UI. The smart assist bot interprets the ongoing conversation and provides recommendations to the agent using [Microsoft Adaptive Cards](https://adaptivecards.io).

> [!NOTE]
> See this administrator guide topic on how to enable smart assist: [Smart assist for agents](../../administrator/smart-assist.md). It provides instructions on how to create a bot user, how to add a smart assist bot to a workstream and how to enable a productivity pane.

This topic provides the information on how you can get started with building a custom smart assist bot.

> [!IMPORTANT]
> For the complete code sample on how to create a custom smart assist bot, see: [Smart Assist for Bots](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot). Refer to the code sample [README](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot/README.md) file for information on how to setup and run the sample.

## Interpret the conversation

It is essential to analyze the conversation and understand its context before you can suggest an action to the agent. Use [Language Understanding (LUIS)](https://luis.ai) to find the intent of the ongoing conversation. You can use the extracted intent to perform actions such as suggesting a knowledge base article, scheduling an appointment or suggesting similar cases. Here is an example on how you can create a LUIS app to find intent from a given text: [Quickstart: Use prebuilt Home automation app](/azure/cognitive-services/luis/luis-get-started-create-app).

## Send adaptive card suggestions

[Adaptive cards](https://adaptivecards.io) is an open-source standard that helps apps and services exchange rich snippets of native UI. The smart assist bot interprets the conversation context in real-time and provides recommendations to the agents.

## Samples for adaptive cards

Based on the intent extracted from an ongoing conversation, you can provide appropriate recommendations to the agent using adaptive cards. This section covers some examples for adaptive cards that can be used for various scenarios. You can use the [Adaptive Cards Designer](https://adaptivecards.io/designer/) to create your own adaptive card template.

### Smart assist using knowledge articles

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

### Smart assist using similar cases

> [!NOTE]
> This is not an Out-of-the-box feature.<br />
> This is a standalone adaptive card JSON that can be used to build business logic for displaying cross sell recommendations in adaptive cards. The [Build a custom smart assist bot](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot) code sample does not cover this scenario.

Based on the context and the information extracted from an ongoing conversation, Omnichannel for Customer Service can populate the smart assist adaptive cards with similar case recommendations, which agents can refer to for information on how similar cases were resolved.

Given below is the `actions` field of the adaptive card JSON for displaying similar case recommendations. Replace the `actions` field in the sample adaptive card JSON give above with the one given below. The `actions` field instructs the bot on the actions it needs to perform.

```json
"actions": [
        {
            "type": "Action.Submit",
            "title": "Open",
            "data": {
                "value": "OpenCaseEntity"
            },
            "iconUrl": "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAA4AAAANCAYAAACZ3F9/AAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAE8SURBVHgBnVLBUQJBEOxd1z8BALWgAWAEagSQAfLw5CdEIBkIP+UeEoIZyGUAAchtnVT55cXDu5txDrkqQKHUeexu7Uz3dO8OrBc18I/QWul6xYtC682bfwGq6nV0xazqSqkFg63sE9LxwD1U3MGOdJSOoVCY+cUWx6YFpqmm45fqTfRk26Hd2zFbqt48pI/4zI0qizyxUqJVU1NWxYPXYfl5q+MaPoYxtc3EzC+PwsfSZWrQY/7+Dipnl+M9xOc+aWAuZJYYmDCha7766nMibrhhMditt52woJemI6RNqekjSQaZJbNmqyFOppuA0/bbhTDf0lJyjD7F229gbPvdcpogv1wBGHdpKnxAz/nl4Cfl6kQmhxXqIDUROR35jjFBjZxfCnAgDMvkQPwRw2FHzkEgiAKK0+5vAXl8ArWLn19rFeLfAAAAAElFTkSuQmCC"
        }
    ]
```

### Smart assist using cross sell recommendations

> [!NOTE]
> This is not an Out-of-the-box feature.<br />
> This is a standalone adaptive card JSON that can be used to build business logic for displaying cross sell recommendations in adaptive cards. The [Build a custom smart assist bot](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot) code sample does not cover this scenario.

Smart assist adaptive cards can also contain recommendations for the next case.

Given below is the `actions` field of the adaptive card JSON for cross sell recommendations. Replace the `actions` field in the sample adaptive card JSON give above with the one given below. The `actions` field instructs the bot on the actions it needs to perform.

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

### Create appointment

Omnichannel for Customer Service allows you to schedule an appointment with a customer by pre-populating appointment fields in the adaptive card based on the context passed in the conversation.

Given below is the `actions` field of the adaptive card JSON for cross sell recommendations. Replace the `actions` field in the sample adaptive card JSON give above with the one given below. The `actions` field instructs the bot on the actions it needs to perform.

```json
"actions": [
        {
            "type": "<add action type, for example: Action.Submit>",
            "title": "<add a title, for example: Create appointment>",
            "data": {
                "CustomAction": "<add custom action name, for example: CreateAppointment>",
                "CustomParameters": {}
            },
            "iconUrl": "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAA4AAAANCAYAAACZ3F9/AAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAE8SURBVHgBnVLBUQJBEOxd1z8BALWgAWAEagSQAfLw5CdEIBkIP+UeEoIZyGUAAchtnVT55cXDu5txDrkqQKHUeexu7Uz3dO8OrBc18I/QWul6xYtC682bfwGq6nV0xazqSqkFg63sE9LxwD1U3MGOdJSOoVCY+cUWx6YFpqmm45fqTfRk26Hd2zFbqt48pI/4zI0qizyxUqJVU1NWxYPXYfl5q+MaPoYxtc3EzC+PwsfSZWrQY/7+Dipnl+M9xOc+aWAuZJYYmDCha7766nMibrhhMditt52woJemI6RNqekjSQaZJbNmqyFOppuA0/bbhTDf0lJyjD7F229gbPvdcpogv1wBGHdpKnxAz/nl4Cfl6kQmhxXqIDUROR35jjFBjZxfCnAgDMvkQPwRw2FHzkEgiAKK0+5vAXl8ArWLn19rFeLfAAAAAElFTkSuQmCC"
        }
    ]
``` 
## Calling macros and custom actions using adaptive cards

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

You will have to create a web resource if you want to use embed a custom action within a suggestion. See the Power Apps topic on [Create your own actions](/powerapps/developer/common-data-service/custom-actions) for information on how to build a custom action.

To use a custom action, replace `MacroName` and `MacroParameters` with `CustomAction` and `CustomParameters` respectively in the adaptive card JSON. The value provided for `CustomAction` key should be the same as the name of the method that is to be called.

## Sample code

You can find the entire code sample here: [Smart Assist for Bots](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot). You will find information on how to setup and run the sample in the sample [README](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot/README.md) file.

The sample code implements two functionalities, one that is Common Data Service specific and other is generic functionality.

In the Common Data Service functionality, the bot finds the intent in the conversation and tries to query Common Data Service for a relevant Knowledge Base article. The connection to Dynamics 365 has to be specified in the `appsettings.json` file in the sample. The `DynamicsDataAccessLayer.cs` class in the sample uses the connection strings mentioned in the app settings file to query the knowledge base articles in your Dynamics 365 instance. For more information on how to S2S authentication to enable communication between Common Data Service and your bot, see the Power Apps topic: [Build web applications using Server-to-Server(S2S) authentication](/powerapps/developer/common-data-service/build-web-applications-server-server-s2s-authentication).

### Getting started with the code sample

The [sample code](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot) contains custom smart bot implementation for suggesting KB articles and for Natural Language Understanding using [LUIS](https://www.luis.ai/home).

#### Deploying a new Smart Assist Bot

To develop a new web application based smart-assist bot, follow the steps mentioned below.

- Download the GitHub based [code sample](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot).
- Go to directory **Dynamics365-Apps-Samples\customer-service\omnichannel\smart-assist-bot\SmartAssistBot**.
- Open the solution file [SmartBot.sln](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot/SmartAssistBot/CoreBot.sln) in Microsoft Visual Studio 2017 or any above version.

To run the sample, you will need to update the LUIS, Bot and Common Data Service settings values in [Appsettings.json](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot/SmartAssistBot/appsettings.json).

1. **LUIS Settings**

Follow the instructions mentioned in topic [Add natural language understanding to your bot](https://docs.microsoft.com/en-us/azure/bot-service/bot-builder-howto-v4-luis?view=azure-bot-service-4.0&tabs=csharp) to add LUIS to your bot. Once you have created a LUIS app, see [this section](https://docs.microsoft.com/en-us/azure/bot-service/bot-builder-howto-v4-luis?view=azure-bot-service-4.0&tabs=csharp#retrieve-application-information-from-the-luisai-portal) to get `LuisAppId`, `LuisAPIKey` and `LuiAPIHostName`

**LUIS** app settings can be left blank if you are interested only in KB search

```
// LUIS connection settings
"LuisAPIHostName": "westus.api.cognitive.microsoft.com",
"LuisAPIKey": "",
"LuisAppId": "",
```

2. **BOT Settings**

Register your bot with Azure Bot Service and obtain the Microsoft App ID and a Client secret like mentioned below<br />

a. Create registration resource following [this documentation](https://docs.microsoft.com/en-us/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-3.0#create-a-registration-resource)<br />
b. Go to the resource which is just created and select settings from left pane and copy the generated Microsoft App Id<br />
c. Generate Client secret like mentioned [here](https://docs.microsoft.com/en-us/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-3.0#get-registration-password) and copy it separately<br />
d. Now update both the Microsoft App ID and secret in appsettings.json

```
// Bot settings
"MicrosoftAppId": "<Microsoft App Id as generated in step 2b>",
"MicrosoftAppPassword": "<Microsoft App password as generated in step 2c>",
"REMOTEDEBUGGINGVERSION": "15.0.28307.222",
"ScmType": "None"```
```

3. **CDS settings**
a. Login to Azure portal with CDS credentials<br />
b. Create an azure application to access dynamics CDS following [this link](https://docs.microsoft.com/en-us/powerapps/developer/common-data-service/walkthrough-register-app-azure-active-directory#create-an-application-registration)<br />
c. Copy the Application (client) ID and client secret<br />
d. Update appsettings.json<br />

```
//Dynamics connection settings
"DynamicsAppId": "<Azure Application Id copied in step 3c, This enables Bot to talk to CDS>",
"DynamicsAppSecret": "<App secret for CDS App Id copied in step 3c>",
"DynamicsOrgUrl": "<CDS Org Url>",
"TenantId": "<CDS Tenant Id>"
```
Use the same app ID while [creating a bot user](https://docs.microsoft.com/en-us/dynamics365/omnichannel/administrator/smart-assist#step-2-create-a-bot-user) later. Also if you want your bot to search for knowledge base articles, then provide either the **Customer Service Manager** or **Customer Service Representative** role to your bot user.

For more information, see the code sample [README](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot/README.md) file.

## See also

[Smart assist for agents](../../administrator/smart-assist.md)<br />
[Create a bot with Azure bot service](/azure/bot-service/abs-quickstart)<br />
[Automate tasks with macros](../../administrator/macros.md)<br />
[Integrate an Azure bot](../../administrator/configure-bot.md)<br />
[Create knowledge article template](../../../customer-service/create-templates-knowledge-article.md)