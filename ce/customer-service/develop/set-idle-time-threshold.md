---
title: Set idle time threshold
description: Learn how to set the idle time threshold for your service representative in Dynamics 365 Customer Service and Dynamics 365 Contact Center.
ms.date: 06/11/2025
ms.topic: reference
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
---

# Set the idle time threshold for average handle time

You can configure the idle time threshold to pause the handle time computation of a customer service representative (service representative or representative) for an ongoing session when the representative is idle. Learn more in [Average handle time](../implement/intraday-insights-dashboard.md#average-handle-time).

## How to set the idle time threshold

In the Copilot Service admin center app, select the **F12** key to open the command prompt, and then run the following:

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

## Related information

[Ongoing conversation report in Omnichannel real-time analytics dashboard](../use/realtime-ongoing.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
