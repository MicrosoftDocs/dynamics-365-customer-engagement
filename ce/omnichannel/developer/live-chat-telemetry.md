---
title: "Live chat widget telemetry| Microsoft Docs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 05/04/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: reference
---
# Live chat widget telemetry

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Microsoft automatically collects data to improve the reliability and performance of our products and to understand how the products are being used. This information is used to make improvements to the product capabilities over time. The live chat widget in Chat for Dynamics 365 collects telemetry automatically from end users to serve the same purposes.

Some of the data collected in the live chat widget include the following. 

|Field|Sample value|
|----|----|
|OrganizationId |`8e9071c2-4415-47aa-b1cb-693631e7fafb` |
|Chat Widget Version |`prod` |
|BrowserName |`Edge` |
|OSName |`Windows`| 
|Scrubbed IP Address (last octet redacted) |`19.207.000.000`| 

> [!IMPORTANT]
> No personally identifiable information (PII) is collected.  

If your organization is concerned about the data collected by this service, you have the option to turn off automatic data collection by adding an HTML attribute to the chat widget script. 

```html
data-enable-telemetry = “false”
```

This information helps Microsoft understand usage patterns, plan new features, and troubleshoot and fix problem areas.

## See also

[Customize a chat widget](customize-chat-widget.md)