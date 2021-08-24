---
title: "Live chat widget telemetry| MicrosoftDocs"
description: "Learn about the telemetry data collected by the live chat widget. Also learn how to disable automatic data collection by the chat widget."
ms.date: 05/15/2020
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
---
# Live chat widget telemetry

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

The live chat widget in Chat for Dynamics 365 collects telemetry data from end users to improve the feature’s capabilities, reliability, and performance over time by helping Microsoft understand usage patterns, plan new features, and troubleshoot and fix problem areas.

Some of the data collected by the live chat widget include the following. 

|Field|Sample value|
|----|----|
|OrganizationId |`8e9071c2-4415-47aa-b1cb-693631e7fafb` |
|Chat Widget Version |`prod` |
|BrowserName |`Edge` |
|OSName |`Windows`| 
|Anonymized IP Address (last octet redacted) |`19.207.000.000`| 

> [!IMPORTANT]
> No personal data is contained in the live chat widget telemetry.

If your organization is concerned about the data collected by this service, you can turn off automatic data collection by adding an HTML attribute to the chat widget script. 

```html
data-disable-telemetry = "true"
```

### See also

[Customize a chat widget](customize-chat-widget.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
