---
title: "Live chat widget telemetry| MicrosoftDocs"
description: "Learn about the telemetry data collected by the live chat widget. Also learn how to disable automatic data collection by the chat widget."
ms.date: 06/17/2022
ms.topic: reference
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
---
# Live chat widget telemetry


The live chat widget in Chat for Dynamics 365 collects telemetry data from end users to improve the feature’s capabilities, reliability, and performance over time by helping Microsoft understand usage patterns, plan new features, and troubleshoot and fix problem areas.

Some of the data collected by the live chat widget include the following. 

|Field|Sample value|
|----|----|
|OrganizationId |`11bb11bb-cc22-dd33-ee44-55ff55ff55ff` |
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

### Related information

[Customize live chat widgets using data tags](customize-chat-widget.md)  
[Customize live chat widgets for mobile apps](render-live-chat-widget-mobile.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
