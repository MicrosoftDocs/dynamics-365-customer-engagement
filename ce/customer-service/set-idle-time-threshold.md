---
title: "Set idle time threshold | Microsoft Docs"
description: "Learn how to set the idle time threshold."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 12/29/2020
ms.topic: reference
ms.service: "dynamics-365-customerservice"
---

# Set the idle time threshold for average handle time

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

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
