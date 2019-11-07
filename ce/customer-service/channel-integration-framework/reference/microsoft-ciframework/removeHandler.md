---
title: "removeHandler (JavaScript API Reference) for Dynamics 365 Channel Integration Framework | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 12/10/2018
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
applies_to:
  - "Dynamics 365 for Customer Engagement (online)"
ms.assetid: ECD8D03B-B16F-467F-9370-BB574F3E4F9D
author: susikka
ms.author: susikka
manager: shujoshi
---

# removeHandler (CIF JavaScript API Reference)

[!INCLUDE[removeHandler-description](includes/removeHandler-description.md)] 

## Syntax

`Microsoft.CIFramework.removeHandler(eventName, handlerFunction);`

## Parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| eventName | string | Yes | Name of the event for which the handler is set. <br>The supported events are as follows:<br><ul><li><b>onclicktoact:</b> The event is invoked when the outbound communication (ClickToAct) enabled filed is clicked.</li> <li><b>onmodechanged:</b> The event is invoked when the panel mode is manually toggled between Minimized (0) and Docked (1). </li><li><b>onsizechanged:</b>The event is invoked when the panel size is manually changed by dragging </li><li><b>onpagenavigate:</b>The event is triggered before a navigation event occurs on the main page </li><li><b>onsendkbarticle: </b> The event is invoked when the user clicks the send button on the KB control.</li></ul>  |
| handlerFunction | Function | Yes | The handler function that is to removed. |


## Related topics

- [onclicktoact](../events/onclicktoact.md)

- [onmodechanged](../events/onmodechanged.md)

- [onpagenavigate](../events/onpagenavigate.md)

- [onsendkbarticle](../events/onsendkbarticle.md)

- [onsizechanged](../events/onsizechanged.md)