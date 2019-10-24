---
title: "initLogAnalytics (JavaScript API Reference) for Channel Integration Framework (CIF) | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 10/25/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
ms.assetid: 5A3CC229-53DE-4C3B-A87E-2E42E2A9D0A1
author: susikka
ms.author: susikka
manager: shujoshi
---

# initLogAnalytics

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

Invoke this method on an incoming conversation to log analytics.

## Syntax

`Microsoft.CIFramework.initLogAnalytics(data, correlationId).then(successCallback, errorCallback);`

## Parameters

| Name            | Type     | Required     | Description |
|-----------------|----------|--------------|-------------|
| data            | String   | Yes          | JSON input                               |
| correlationId   | GUID     | No           | Used to group all related API calls together for diagnostic telemetry. |
| successCallback | Function | No           | A function to call when the promise is successfully returned. |
| errorCallback   | Function | No           | A function to call when the request to return the promise fails. |

The structure of the `data` parameter JSON is shown below. It is mandatory to include these two fields: `conversationId` and `providerSessionId`.

```json
{
	"conversation": {
		"conversationId": "<Conversation identifier>",
		"channel": "<Conversation channel>",
		"regionData": {
		"addressLine1":"<Conversation origin region information>",
		"city":"",
		"state":"",
		"country":"",
		"zip":""
		},
		"providerId": "<Channel Integration Framework provider Id>",
		"providerName": "<Channel Integration Framework provider name>",
		"accountId": "<Account unique identifier>",
		"contactId": "<Contact unique identifier>",
		"additionalData": "<Additional data related to the conversation>",
		"externalCorrelationId": "<External system correlation Id>",
		"createdTimestamp": "Creation time",
		"customData": [
			{
				"attribute": "name",
				"value": "value"
			}
		],
		"session": {
			"providerSessionId": "<Provider identifier of the session>",
			"clientSessionId": "",
			"clientSessionName": "",
			"channel": "",
			"creationReason": "",
			"additionalData": "",
			"externalCorrelationId": "",
			"createdTimestamp": "",
			"agentAssignedTimestamp": "",
			"queueAssignedTimestamp": "",
			"queueId":"",
			"queueName":"",
			"customData": [
				{
					"attribute": "name",
					"value": "value"
				}
			],
			"participants": [
				{
					"participantId": "",
					"externalId": "",
					"name": "",
					"mode": "",
					"type": "",
					"addedTimestamp": "",
					"assignReason":"",
					"customData": [
						{
							"attribute": "name",
							"value": "value"
						}
					]
				}
			]
		}
	}
}
```
## Return value

Promise with value as string

## See also

[logAnalyticsEvent method](logAnalyticsEvent.md)