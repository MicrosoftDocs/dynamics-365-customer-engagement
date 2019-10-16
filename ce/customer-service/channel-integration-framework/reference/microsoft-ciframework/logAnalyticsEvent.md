---
title: "logAnalyticsEvent (JavaScript API Reference) for Channel Integration Framework (CIF) | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 09/30/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
ms.assetid: D31DECFE-8DB9-4316-B886-36EA28F30199
author: susikka
ms.author: susikka
manager: shujoshi
---

# logAnalyticsEvent

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

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

The structure of the `data` parameter JSON is shown below.

```json
{
	"conversationId": "",
	"sessionId": "",
	"clientSessionId":"",
	"eventParticipantId":"",
	"events": [
		{
			"kpiEventName": "",
			"kpiEventReason": "",
			"eventTimestamp": "",
			"entityName": "",
			"entityRecordId": "",
			"additionalData": "",
			"knowledgeArticleId": "",
			"knowledgeArticleName": "",
			"oldPresence": "",
			"newPresence": "",
			"tabId": "",
			"tabName": "",
			"notificationResponseAction":"",
			"externalCorrelationId": "",
			"customData": [
				{
					"attribute": "name",
					"value": "value"
				}
			]
		}
	]
}
```
## Return value

Promise with value as string