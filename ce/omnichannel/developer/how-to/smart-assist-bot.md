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

See this topic on how to enable smart assist: [Smart assist for agents](../../administrator/smart-assist.md).

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
> This is a standalone adaptive card JSON that can be used to build business logic for displaying similar cases in adaptive cards. The [Build a custom smart assist bot](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot) code sample does not cover this scenario.

Based on the context and the information extracted from an ongoing conversation, Omnichannel for Customer Service can populate the smart assist adaptive cards with similar case recommendations, which agents can refer to for information on how similar cases were resolved.

Given below is the adaptive card JSON for displaying similar case recommendations.

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
                                    "url": "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAE6SURBVHgBpZLRbcJADIbtKKBAH8oGZARGSEdggpINIlXw0DzQqgp9SB/SCaATdAQ6QjYgI/AEEUnOtUNSFaGEE/jl7Lv7/rPPRrhg3mA+6By6HhI+EpCNAAkhfGXdQxRtX7eGBrwGBcOClBPufSQW4KOhwHJutgnIywzHYeq7Es/6ixVnkYQ73xVfpWrTKlCmXdD4H0w1TET3iDhpLUFqDjM/Fl9Ve39Ce1+E7UaBaScY8VLWKfHH7nlCgFhnMb0rzxNsgtHEb8ppXGdwdqcfLElRYujCdSaeNbf59YjdUW5ln6gDl+WYsGZXRBL+wJXA0kpTB672H07KSY8LasKNf4G3wGKGXFKovGvg4+VeQCcxw7PeYlPNwUWTNv5wT18keLLeHO2XK0PPerdNKJY81w4Pbww5urqw2C9t1ONm4m8XzgAAAABJRU5ErkJggg==",
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
                                    "text": "Similar case"
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
                    "text": "Noise from product",
                    "weight": "Bolder"
                }
            ]
        },
        {
            "type": "TextBlock",
            "text": "Grinding sound from the printer. This started happening after a new carriage stall is installed",
            "wrap": true
        }
    ],
    "actions": [
        {
            "type": "Action.Submit",
            "title": "Open",
            "data": {
                "value": "OpenCaseEntity"
            },
            "iconUrl": "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAA4AAAANCAYAAACZ3F9/AAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAE8SURBVHgBnVLBUQJBEOxd1z8BALWgAWAEagSQAfLw5CdEIBkIP+UeEoIZyGUAAchtnVT55cXDu5txDrkqQKHUeexu7Uz3dO8OrBc18I/QWul6xYtC682bfwGq6nV0xazqSqkFg63sE9LxwD1U3MGOdJSOoVCY+cUWx6YFpqmm45fqTfRk26Hd2zFbqt48pI/4zI0qizyxUqJVU1NWxYPXYfl5q+MaPoYxtc3EzC+PwsfSZWrQY/7+Dipnl+M9xOc+aWAuZJYYmDCha7766nMibrhhMditt52woJemI6RNqekjSQaZJbNmqyFOppuA0/bbhTDf0lJyjD7F229gbPvdcpogv1wBGHdpKnxAz/nl4Cfl6kQmhxXqIDUROR35jjFBjZxfCnAgDMvkQPwRw2FHzkEgiAKK0+5vAXl8ArWLn19rFeLfAAAAAElFTkSuQmCC"
        }
    ],
    "$schema": "https://adaptivecards.io/schemas/adaptive-card.json",
    "version": "1.0"
}
```

### Smart assist using cross sell recommendations

> [!NOTE]
> This is not an Out-of-the-box feature.<br />
> This is a standalone adaptive card JSON that can be used to build business logic for displaying cross sell recommendations in adaptive cards. The [Build a custom smart assist bot](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot) code sample does not cover this scenario.

Smart assist adaptive cards can also contain recommendations for the next case.

Given below is the adaptive card JSON for cross sell recommendation.

```json
{
	"type" : "AdaptiveCard",
	"body" : [{
			"type" : "Container",
			"items" : [{
					"type" : "ColumnSet",
					"columns" : [{
							"type" : "Column",
							"width" : "auto",
							"items" : [{
									"type" : "Image",
									"altText" : "",
									"url" : "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACcAAAAiCAQAAAB2ZwgNAAAABGdBTUEAALGPC/xhBQAAACBjSFJNAAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAAAAmJLR0QA/4ePzL8AAAAJcEhZcwAAAEgAAABIAEbJaz4AAAAHdElNRQfjCggAHCl3xTbzAAAG2ElEQVRIx5WUaYyVVxnHf+e8233v3GXunXvnzsrAMOCU4oiALF2YQsGwtC5t1WI/GG1TtBEtEhNT09jUpVVroNGkYNqoibSigSJtSiFsNmUrFTsNDJZNmWGGzMosnZm7ve/jhzt3mKlpos/75Tz/95z/ef7PcgyoBixsbFwyRLYZDz3w6jURTExMyqiJjh12Q5lTzjhiESPa5L1V0mK3aQxMbEqZS4xuTDDKrUYJAIrh5jOnE9noWVc1mREEUP71fFeu3Esk3dElWABKqVYjkivPhqIVfhOAFt1234UdcjskV9gn9ajO6LTO6ffKUu5fjP1zUoHTKqfSKq28kp2NVeYF50d6jrquMiqt0joX2lSz1LihVrlf11mVVmmVNttLH4F70MO/yi72Xd/2Hd80winTF8FX4oopjjiixckDPqKlRGxxxPFNsTwBS5uWWOKII06+ZuQHNXVnMHNNoNvlr5JH6+7IiAD+GH+gBh8w+EfGExR08xuCCCjNKU9pHXfS7/E8AtzFPK9qqC5/FS2IfXCF7QIRaqZZLcbl5JwSimYTW6kHnNcbI0XMBCKbtBd+RpQNgNqKqDF3uY0u+D16JpBhZLHX5NePNI+MH11FlvRaP5q/q/cT9jg2m08G01/09di62liKBKAUIMWrEDyEyyzBeie9yw+XHDe4TIggCziM+6o337gUvOxxA4AIJ0Yjv8e190wbGqCKXjR+UYwWxDp4v1X0H7e+7PARWxL4hf4otjh4c21tQdSou9xGafGx2tzdklcF3QKobH4sV9iqAESBGl/fxJRCUCjxV+cWqbHAOu+IKYCUZVYXtFNMAvaUWOQmzSRMCn+EiiJmAqgz09db6QLg3eSddNDnv624s8S/8mzu0Ul0fnagN56xJw6DQQ9pktgIebqxSOChGWSEOA4C9AEJfM4SHJuoxLgK1U8LLbRwlnM08oLKN/nrJNrLIH7IXy0L79SzOY/XKJ/zk52A68hyuTNhlhYbhWLqxTiUDCQmyUiSarDOay/0Q4DwJp21/pW4tYxUhX1KS3DrGWURecAYNvviK0JA+PliZSf6brLl0QGJifYiAF5ULD/sBwBb4j4S3aV8kYiEJOsFvSklMotphfsQrhIgR4bw+dYNuYbQTgOXwPaBQd1W/77PmvZtj2Xmh3b/0q/E2d1jq3TFYY9LeP4UsfpQKBDiIaDZggZmMQuAQj8XZrWOBhZOFKuKWsAixQw05o+VqPTEzAo+BjuI3XNyT2RzwrJwg+EnAn+KLtZoggsDL4eetEsMSs3oBmdX2RoFtHOHXV6er/UTjxmJF4M/Ma8qpQrRqUNOoIKltrMPMduT08pILDCGkcA2gMALiDEcX1BGZa15FbHfeNSorQx9237D/MBos1oDe6IPz03Wzq2eVlmMLs+HnMjaB8xr5v5on0ug0zxmdjjHAewTZod5LNgRJHzDesvodo7uXdb12thzJMw3zW3GAb9sZMvF19OxjrZT49EdDrkhZnKbWVE9w40DUBNL1d1tzOVWlhnldbUxAJfpkWR9ZbP1b+tCbP0t0UImm0ria+xT1tXUHaAFcKyFehGD9Lv5mnysvzCLYS/ZbX/IKEOWn8hG4UV8ZCjV1f8EXmz9jVe8wSOsRPBGhveVf0V1DPysPgmCuG+vKlnJT3Xo58Zo4M26WCWVdc47xnD4uwCRjcaQ/W759AS3YxO91xyOPXy3I5Tza5awhQ2AQ3yF2RPZONF3OfYbudmeqxoywdwNYvkGL5SvB8g2eGHqvVKfFFmMtao9/reT20Pd0W0br0ALEcqxqTl25u+Zrxo8BVZ79R+t3FG/9IpKl7x07+lhifSPdhmXSrdLr0n4CrnAKzUHA14/5cHe7+sP1v7uoso+OPoNN2nd5timRULilYOd0/P3gyCBt1cGa4nhAooUMSoBiFFNNbHxNq6jgfoyp9V9DmBmWeRxqwPRo0av0Wv2hTaHNhhSmFnrXGpwxMTCwiAL5EgAGg8IUA3kMZRknZw/QhSE6X1DW6NdYxu9HvEAzEuZeSqtjLTnqDHVVnw1p764UzxlttV+re1Z/5b6lTI0iy4q1cUS0hmBuCSso3ulkuCflfA/fjoX+2zkS+Zg7AsK4dPMpZEZpJhJkLJmsz/8tJpR1fOt9Aov8LExTcZ1cGfDb1t3SzzxYGfrbA7wHfayhFbiFddflvLU51UVnUwL9ZgyicyYQj3Zs73u4eTSgR1qNPhUxYF/DgGstd5dMPi096nQIwOvqWbCvE/PxxJM9QKs5SWSS4eeyc83zhknjE4v6s/zP6OvhZ7s2zeP/9uWsRmLhkTkm84Ra8AUa8g5Hv7ejGpYRAP/AZkMtwT0MMHsAAAAJXRFWHRkYXRlOmNyZWF0ZQAyMDE5LTEwLTA4VDAwOjI4OjI5KzAwOjAwXmACnQAAACV0RVh0ZGF0ZTptb2RpZnkAMjAxOS0xMC0wOFQwMDoyODoyOSswMDowMC89uiEAAABUdEVYdHN2ZzpiYXNlLXVyaQBmaWxlOi8vL2hvbWUvZGIvc3ZnX2luZm8vc3ZnLzUzL2ZkLzUzZmQxZDhjNjk4NTUyY2JmM2Q2Y2YxYmE3MTg3NWFmLnN2Z2xARpAAAAArdEVYdENvbW1lbnQAUmVzaXplZCBvbiBodHRwczovL2V6Z2lmLmNvbS9yZXNpemVCaY0tAAAAEnRFWHRTb2Z0d2FyZQBlemdpZi5jb22gw7NYAAAAAElFTkSuQmCC",
									"width" : "16px",
									"height" : "16px"
								}
							]
						}, {
							"type" : "Column",
							"width" : "stretch",
							"items" : [{
									"type" : "TextBlock",
									"text" : "Offer available"
								}
							]
						}
					]
				}
			]
		}, {
			"type" : "Container",
			"items" : [{
					"type" : "TextBlock",
					"text" : "Upgrade offer!",
					"weight" : "Bolder"
				}
			]
		}, {
			"type" : "TextBlock",
			"text" : "Discuss with the customer on interest in the offer",
			"wrap" : true
		}
	],
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
	],
	"$schema" : "https://adaptivecards.io/schemas/adaptive-card.json",
	"version" : "1.0"
}
```

### Create appointment

Omnichannel for Customer Service allows you to schedule an appointment with a customer by pre-populating appointment fields in the adaptive card based on the context passed in the conversation.

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
                                    "url": "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACcAAAAiCAQAAAB2ZwgNAAAABGdBTUEAALGPC/xhBQAAACBjSFJNAAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAAAAmJLR0QA/4ePzL8AAAAJcEhZcwAAAEgAAABIAEbJaz4AAAAHdElNRQfjCggAHCl3xTbzAAAG2ElEQVRIx5WUaYyVVxnHf+e8233v3GXunXvnzsrAMOCU4oiALF2YQsGwtC5t1WI/GG1TtBEtEhNT09jUpVVroNGkYNqoibSigSJtSiFsNmUrFTsNDJZNmWGGzMosnZm7ve/jhzt3mKlpos/75Tz/95z/ef7PcgyoBixsbFwyRLYZDz3w6jURTExMyqiJjh12Q5lTzjhiESPa5L1V0mK3aQxMbEqZS4xuTDDKrUYJAIrh5jOnE9noWVc1mREEUP71fFeu3Esk3dElWABKqVYjkivPhqIVfhOAFt1234UdcjskV9gn9ajO6LTO6ffKUu5fjP1zUoHTKqfSKq28kp2NVeYF50d6jrquMiqt0joX2lSz1LihVrlf11mVVmmVNttLH4F70MO/yi72Xd/2Hd80winTF8FX4oopjjiixckDPqKlRGxxxPFNsTwBS5uWWOKII06+ZuQHNXVnMHNNoNvlr5JH6+7IiAD+GH+gBh8w+EfGExR08xuCCCjNKU9pHXfS7/E8AtzFPK9qqC5/FS2IfXCF7QIRaqZZLcbl5JwSimYTW6kHnNcbI0XMBCKbtBd+RpQNgNqKqDF3uY0u+D16JpBhZLHX5NePNI+MH11FlvRaP5q/q/cT9jg2m08G01/09di62liKBKAUIMWrEDyEyyzBeie9yw+XHDe4TIggCziM+6o337gUvOxxA4AIJ0Yjv8e190wbGqCKXjR+UYwWxDp4v1X0H7e+7PARWxL4hf4otjh4c21tQdSou9xGafGx2tzdklcF3QKobH4sV9iqAESBGl/fxJRCUCjxV+cWqbHAOu+IKYCUZVYXtFNMAvaUWOQmzSRMCn+EiiJmAqgz09db6QLg3eSddNDnv624s8S/8mzu0Ul0fnagN56xJw6DQQ9pktgIebqxSOChGWSEOA4C9AEJfM4SHJuoxLgK1U8LLbRwlnM08oLKN/nrJNrLIH7IXy0L79SzOY/XKJ/zk52A68hyuTNhlhYbhWLqxTiUDCQmyUiSarDOay/0Q4DwJp21/pW4tYxUhX1KS3DrGWURecAYNvviK0JA+PliZSf6brLl0QGJifYiAF5ULD/sBwBb4j4S3aV8kYiEJOsFvSklMotphfsQrhIgR4bw+dYNuYbQTgOXwPaBQd1W/77PmvZtj2Xmh3b/0q/E2d1jq3TFYY9LeP4UsfpQKBDiIaDZggZmMQuAQj8XZrWOBhZOFKuKWsAixQw05o+VqPTEzAo+BjuI3XNyT2RzwrJwg+EnAn+KLtZoggsDL4eetEsMSs3oBmdX2RoFtHOHXV6er/UTjxmJF4M/Ma8qpQrRqUNOoIKltrMPMduT08pILDCGkcA2gMALiDEcX1BGZa15FbHfeNSorQx9237D/MBos1oDe6IPz03Wzq2eVlmMLs+HnMjaB8xr5v5on0ug0zxmdjjHAewTZod5LNgRJHzDesvodo7uXdb12thzJMw3zW3GAb9sZMvF19OxjrZT49EdDrkhZnKbWVE9w40DUBNL1d1tzOVWlhnldbUxAJfpkWR9ZbP1b+tCbP0t0UImm0ria+xT1tXUHaAFcKyFehGD9Lv5mnysvzCLYS/ZbX/IKEOWn8hG4UV8ZCjV1f8EXmz9jVe8wSOsRPBGhveVf0V1DPysPgmCuG+vKlnJT3Xo58Zo4M26WCWVdc47xnD4uwCRjcaQ/W759AS3YxO91xyOPXy3I5Tza5awhQ2AQ3yF2RPZONF3OfYbudmeqxoywdwNYvkGL5SvB8g2eGHqvVKfFFmMtao9/reT20Pd0W0br0ALEcqxqTl25u+Zrxo8BVZ79R+t3FG/9IpKl7x07+lhifSPdhmXSrdLr0n4CrnAKzUHA14/5cHe7+sP1v7uoso+OPoNN2nd5timRULilYOd0/P3gyCBt1cGa4nhAooUMSoBiFFNNbHxNq6jgfoyp9V9DmBmWeRxqwPRo0av0Wv2hTaHNhhSmFnrXGpwxMTCwiAL5EgAGg8IUA3kMZRknZw/QhSE6X1DW6NdYxu9HvEAzEuZeSqtjLTnqDHVVnw1p764UzxlttV+re1Z/5b6lTI0iy4q1cUS0hmBuCSso3ulkuCflfA/fjoX+2zkS+Zg7AsK4dPMpZEZpJhJkLJmsz/8tJpR1fOt9Aov8LExTcZ1cGfDb1t3SzzxYGfrbA7wHfayhFbiFddflvLU51UVnUwL9ZgyicyYQj3Zs73u4eTSgR1qNPhUxYF/DgGstd5dMPi096nQIwOvqWbCvE/PxxJM9QKs5SWSS4eeyc83zhknjE4v6s/zP6OvhZ7s2zeP/9uWsRmLhkTkm84Ra8AUa8g5Hv7ejGpYRAP/AZkMtwT0MMHsAAAAJXRFWHRkYXRlOmNyZWF0ZQAyMDE5LTEwLTA4VDAwOjI4OjI5KzAwOjAwXmACnQAAACV0RVh0ZGF0ZTptb2RpZnkAMjAxOS0xMC0wOFQwMDoyODoyOSswMDowMC89uiEAAABUdEVYdHN2ZzpiYXNlLXVyaQBmaWxlOi8vL2hvbWUvZGIvc3ZnX2luZm8vc3ZnLzUzL2ZkLzUzZmQxZDhjNjk4NTUyY2JmM2Q2Y2YxYmE3MTg3NWFmLnN2Z2xARpAAAAArdEVYdENvbW1lbnQAUmVzaXplZCBvbiBodHRwczovL2V6Z2lmLmNvbS9yZXNpemVCaY0tAAAAEnRFWHRTb2Z0d2FyZQBlemdpZi5jb22gw7NYAAAAAElFTkSuQmCC",
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
    "$schema": "https://adaptivecards.io/schemas/adaptive-card.json",
    "version": "1.0"
}

``` 
## Calling macros and custom actions using adaptive cards

### Macros

Macros are a compilations of sequential actions that are reusable for different sessions. These can be used to automate repetitive and monotonous actions that in turn reduce human errors and improve agent productivity. For information on how to build a macro, see [Create macro](../../administrator/macros.md#create-a-macro).

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

In the generic functionality, if the bot encounters an intent for appointment, it suggests the appointment activity in the adaptive cards. You can use [Language Understanding (LUIS)](https://luis.ai) service to extract intent from an ongoing conversation. The conversation intent can be used along with the initial conversation context to display recommendations for the agent. 

## See also

[Smart assist for agents](../../administrator/smart-assist.md)<br />
[Create a bot with Azure bot service](/azure/bot-service/abs-quickstart)<br />
[Automate tasks with macros](../../administrator/macros.md)<br />
[Integrate an Azure bot](../../administrator/configure-bot.md)<br />
[Create knowledge article template](../../../customer-service/create-templates-knowledge-article.md)