---
title: "Set idle time threshold | Microsoft Docs"
description: "Learn how to set the idle time threshold."
ms.date: 03/31/2023
ms.topic: reference
author: neeranelli
ms.author: nenellim
---

# Set the idle time threshold for average handle time

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!NOTE]
> With the release of [real-time analytics reports in Omnichannel for Customer Service](enable-realtime-analytics-dashboard-administrator.md), our latest analytics capability, we announce that the intraday insights for Omnichannel for Customer Service will be deprecated on October 31, 2023. We recommend that you use real-time analytics reports, which provide real-time information about the health and key performance indicators of your organization. For more information on the deprecation, go to [Intraday insights for Omnichannel for Customer Service to be deprecated](deprecations-customer-service.md#intraday-insights-for-omnichannel-for-customer-service-to-be-deprecated).

You can configure the idle time threshold to pause the handle time computation of an agent for an ongoing session when the agent is idle. More information: [Average handle time](intraday-insights-dashboard.md#average-handle-time).

## How to set the idle time threshold

In the Omnichannel Administration app, select the **F12** key to open the command prompt, and then run the following:

```JavaScript
let entityName = "msdyn_channelprovider"
let attributeName = "msdyn_channelurl"
let primaryAttributeName = "msdyn_channelproviderid"
let threshold = "60"

Xrm.WebApi.retrieveMultipleRecords(entityName, "").then((result) => {
	result.entities.forEach ((entity) => {
		console.log(entity);
		if(entity[attributeName].toString().indexOf("&idleTimeThreshold") == -1) {
			console.log("modify data");
		var data = {};
		data[attributeName] = entity[attributeName] + "&idleTimeThreshold=" + threshold;
			Xrm.WebApi.updateRecord(entityName, entity[primaryAttributeName], data).then((result) => {
			console.log(result);
				return Promise.resolve();
			}, (error) => {
			console.log(error);
				return Promise.reject();
			});
		}
	});
	return Promise.resolve(result.entities);
}, (error) => {
			console.log(error);
	return Promise.reject();
});
```

## See also

[View and understand Ongoing Conversations dashboard](ongoing-conversations-dashboard.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
