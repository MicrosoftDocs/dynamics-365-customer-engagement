---
title: "Implement a custom scenario for smart assist bot | MicrosoftDocs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 02/27/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---
# Implement a custom scenario for smart assist bot

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

> [!NOTE]
> See the entire code sample for building a smart assist bot here: [Smart Assist for Bots](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot). You will find information on how to setup and run the sample in the sample [README](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot/README.md) file. You can make changes to this sample code to implement your custom scenario.

## Prerequisites

Read the topic [Build a custom smart assist bot](smart-assist-bot.md) for information on how to get started with building a custom smart assist bot. 

## Scenario: Similar case suggestion

Consider the scenario where a customer who is trying to troubleshoot his printer reaches out to customer support through chat channel. The chat request is accepted by an agent. The customer before initiating the chat browsed through the printer website and the customer support agent can see the articles that the customer has read.

The customer service agent greets the customer with the following message. 

```
Welcome to Contoso Ltd. I'm happy to assist you today. You were trying to troubleshoot your printer. Is this the same issue?
```

Customer responds with the following message.

```
Yes, that is right. My printer is making loud noise. I tried restarting it but that did not help.
```

The customer service agent is presented with a list of similar cases as a recommendation. The agent clicks on the case that he finds most similar and relevant, and then goes to the case note and looks ar the resolution in note. The agent suggests the same resolution to the customer over chat.

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

You will have to create a web resource if you want to use embed a custom action within a suggestion. See the Power Apps topic on [Create your own actions](/powerapps/developer/common-data-service/custom-actions) for information on how to build a custom action. See the topic [Web resources in model-driven apps](/powerapps/maker/model-driven-apps/create-edit-web-resources) for information on how to create web resources. These web resources will have to be uploaded under the **Customer Summary Form**, as shown in the screenshot below.

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

## See also

[Build a custom smart assist bot](smart-assist-bot.md)<br />
[Smart assist for agents](../../administrator/smart-assist.md)<br />
[Sample code: Smart Assist for Bots](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot)