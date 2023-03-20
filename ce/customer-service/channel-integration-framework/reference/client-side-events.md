---
title: "Client-side events (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 1.0 | MicrosoftDocs"
description: "Read about the client side events that you can use to trigger the client-side code in Dynamics 365 Channel Integration Framework 1.0."
ms.date: 02/14/2023
ms.topic: reference
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# Events (JavaScript API reference) in Dynamics 365 Channel Integration Framework 1.0

All client-side code is initiated by events and the events occur in Dynamics 365 Unified Interface. You associate s specific function in a JavaScript library to execute when an event occurs. This specific function is called an *event handler*.

Each event handler specifies a function within a JavaScript library and the parameters that you can pass to the function. The JavaScript API provides methods that you can use to attach event handlers to the events.

## Events

| Events | Description |
|---------|-------------|
| [CIFInitDone](events/cifinitdone.md) | Invoked when Dynamics 365 Channel Integration Framework 1.0 is loaded to determine if the APIs are ready to be consumed. |
| [onclicktoact](events/onClickToAct.md) | Invoked when the user selects the outbound communication (ClickToAct) field in a form. |
| [onmodechanged](events/onModeChanged.md) | Invoked when the panel mode is manually toggled between **Minimized (0)**, **Docked (1)**, and **Hidden (2)**. |
| [onpagenavigate](events/onPageNavigate.md) | Invoked when the main Unified Interface page navigation occurs. |
| [onsendkbarticle](events/onSendKBArticle.md) | Invoked when the user selects the **Send** button in the Knowledge Base control. |
| [onsizechanged](events/onSizeChanged.md) | Invoked when the side panel width is changed. |

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
