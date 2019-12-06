---
title: "initLogAnalytics (JavaScript API Reference) for Channel Integration Framework (CIF) | MicrosoftDocs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 10/25/2019
ms.topic: reference
ms.service: 
  - dynamics-365-cross-app
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
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
			"clientSessionId": "<Identifier of the client session>",
			"clientSessionName": "<Name of the client session>",
			"channel": "<Channel for the session>",
			"creationReason": "<Reason for the session creation>",
			"additionalData": "<Additional data related to the session>",
			"externalCorrelationId": "<External system correlation Id>",
			"createdTimestamp": "<Timestamp at which the session was created>",
			"agentAssignedTimestamp": "<Timestamp at which the agent was assigned to the session>",
			"queueAssignedTimestamp": "<Timestamp at which the queue was assigned to the session>",
			"queueId":"<Identifier of the queue to which this session belongs to>",
			"queueName":"<Name of the queue to which this session belongs to>",
			"customData": [
				{
					"attribute": "<name>",
					"value": "<value>"
				}
			],
			"participants": [
				{
					"participantId": "<Identifier of the session participant>",
					"externalId": "<External system correlation Id>",
					"name": "<Primary field of the entity>",
					"mode": "<Session participant mode>",
					"type": "<Type of the session participant>",
					"addedTimestamp": "<Timestamp at which the participant was added to the session>",
					"assignReason":"<Reason for which the participant was added to the session>",
					"customData": [
						{
							"attribute": "<name>",
							"value": "<value>"
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
