---
title: "logAnalyticsEvent (JavaScript API Reference) for Dynamics 365 Channel Integration Framework (CIF) version 2.0 | MicrosoftDocs"
description: ""
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 10/25/2019
ms.topic: reference
ms.service: dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# logAnalyticsEvent

 

Invoke this method to log analytics for custom events.

## Syntax

`Microsoft.CIFramework.logAnalyticsEvent(data, eventName, correlationId).then(successCallback, errorCallback);`

## Parameters

| Name            | Type     | Required     | Description |
|-----------------|----------|--------------|-------------|
| data            | String   | Yes          | JSON input                               |
| eventName       | String   | Yes          | Name of the event                               |
| correlationId   | GUID     | No           | Used to group all related API calls together for diagnostic telemetry. |
| successCallback | Function | No           | A function to call when the promise is successfully returned. |
| errorCallback   | Function | No           | A function to call when the request to return the promise fails. |

The structure of the `data` parameter JSON is shown below. It is mandatory to include these two fields: `conversationId` and `providerSessionId`.

```json
{
	"conversationId": "<Conversation identifier>",
	"providerSessionId": "<Channel Integration Framework Provider Id>",
	"clientSessionId":"<Client session identifier>",
	"participantId":"<Participant identifier>",
	"events": [
		{
			"kpiEventName": "<Name of the associated KPI event>",
			"kpiEventReason": "<Reason due to which the KPI event was created>",
			"eventTimestamp": "<Timestamp at which the event occurred>",
			"additionalData": "<Additional data related to the session>",
			"notificationResponseAction":"<Agent notification response action value>",
			"externalCorrelationId": "<External system correlation Id>",
			"customData": [
				{
					"attribute": "<name>",
					"value": "<value>"
				}
			]
		}
	]
}
```
## Return value

Promise with value as string

## See also

[initLogAnalytics method](initLogAnalytics.md)<br />
[Channel Analytics](../../channel-analytics.md)
