---
title: "Build a smart assist bot | MicrosoftDocs"
description: "Read how you can build a smart assist bot to help agents resolve customer queries faster and more effectively"
keywords: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 10/09/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 355B4706-49DF-4E2F-A46D-00F12E0044C6
ms.custom: 
---
# Smart assist for Bots

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

Build a custom bot to push real-time sugegstions to agents for actions displayed within the smart assist control on the agent UI. The smart assist control uses Adaptive cards to push and display suggestions in UI. [Adaptive cards](https://adaptivecards.io) is an open-source standard that helps apps and services exchange rich snippets of native UI.

You can use the [Adaptive Cards Designer](https://adaptivecards.io/designer/) to create your own adaptive card template.

## Smart assist using knowledge articles

Based on the context and the information extracted from an ongoing conversation, Omnichannel for Customer Service can populate the smart assist adaptive cards with knowledge article suggestions.

Given below is the adaptive card JSON for displaying knowledge article suggestions.

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
    "$schema": "http://adaptivecards.io/schemas/adaptive-card.json",
    "version": "1.0"
}
```

## Smart assist using similar cases

Based on the context and the information extracted from an ongoing conversation, Omnichannel for Customer Service can populate the smart assist adaptive cards with similar case suggestions, which agents can refer to for information on how similar cases were resolved.

Given below is the adaptive card JSON for displaying similar case suggestions.

```json

```

## Smart assist using cross sell suggestions

Smart assist adaptive cards can also contain suggestions for the next case.

Given below is the adaptive card JSON for cross sell suggestion.

```json

```

## Create appointment

Omnichannel for Customer Service allows you to schedule an appointment with a customer by pro-populating appointment fields in the adaptive card based on the context passed in the conversation.

Given below is the adaptive card JSON for creating an appointment with the customer.

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
                                    "url": "data:image/png;base64,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",
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
                                    "text": "Appointment"
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
                    "text": "Phone call with customer",
                    "weight": "Bolder"
                }
            ]
        },
        {
            "type": "TextBlock",
            "text": "Setup a phone call with the customer. The appointment fields will be auto populated based on context",
            "wrap": true
        }
    ],
    "actions": [
        {
            "type": "Action.Submit",
            "title": "Create appointment",
            "data": {
                "CustomAction": "CreateAppointment",
                "CustomParameters": {}
            },
            "iconUrl": "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAA4AAAANCAYAAACZ3F9/AAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAE8SURBVHgBnVLBUQJBEOxd1z8BALWgAWAEagSQAfLw5CdEIBkIP+UeEoIZyGUAAchtnVT55cXDu5txDrkqQKHUeexu7Uz3dO8OrBc18I/QWul6xYtC682bfwGq6nV0xazqSqkFg63sE9LxwD1U3MGOdJSOoVCY+cUWx6YFpqmm45fqTfRk26Hd2zFbqt48pI/4zI0qizyxUqJVU1NWxYPXYfl5q+MaPoYxtc3EzC+PwsfSZWrQY/7+Dipnl+M9xOc+aWAuZJYYmDCha7766nMibrhhMditt52woJemI6RNqekjSQaZJbNmqyFOppuA0/bbhTDf0lJyjD7F229gbPvdcpogv1wBGHdpKnxAz/nl4Cfl6kQmhxXqIDUROR35jjFBjZxfCnAgDMvkQPwRw2FHzkEgiAKK0+5vAXl8ArWLn19rFeLfAAAAAElFTkSuQmCC"
        }
    ],
    "$schema": "http://adaptivecards.io/schemas/adaptive-card.json",
    "version": "1.0"
}

``` 

## Sample code

You can find the entire code sample here: [Smart Assist for Bots]().

> [!NOTE]
> The sample code uses pre-defined context values for displaying suggestions. You can use [Language Understanding (LUIS)](https://luis.ai) service to extract intent from an ongoing conversation. The conversation intent can be used along with the initial conversation context to display suggestions for the agent.

## See also

[Manage custom context](send-context-starting-chat.md)<br />
[Enable a bot to escalate and end conversation](../bot-escalate-end-conversation.md)