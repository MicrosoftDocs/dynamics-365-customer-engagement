---
title: "logAnalyticsEvent (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes description, syntax, and parameter information for the logAnalyticsEvent method in JavaScript API Reference for Channel Integration Framework 2.0."
ms.date: 07/11/2023
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# logAnalyticsEvent (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

 

Invoke this method to log analytics for custom events.

## Syntax

`Microsoft.CIFramework.logAnalyticsEvent(data, eventName, correlationId).then(successCallback, errorCallback);`

## Parameters

| Name            | Type     | Required     | Description |
|-----------------|----------|--------------|-------------|
| data            | JSON object   | Yes          | JSON input                               |
| eventName       | String   | Yes          | Name of the event                               |
| correlationId   | GUID     | No           | Used to group all related API calls together for diagnostic telemetry. |
| successCallback | Function | No           | A function to call when the promise is successfully returned. |
| errorCallback   | Function | No           | A function to call when the request to return the promise fails. |

Here's the structure of the `data` parameter JSON. Be sure to include the fields: `conversationId` and `providerSessionId`.

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

## Example

```Javascript

//Success callback handler
const successCallback = (result) => {
  // result will indicate if the custom analytics event has been logged
  console.log(result);
};

//Failure callback handler
const errorCallback = (error) => {
  // handling failure
  console.error(error)
};

Microsoft.CIFramework.logAnalyticsEvent(data, eventName, correlationId).then(successCallback, errorCallback);

```

### See also

[updateConversation method](./updateconversation.md)<br />
[Channel Analytics](../../channel-analytics.md)


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
