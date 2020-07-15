---
title: "Customize a chat widget | Microsoft Docs"
description: "Read how you can customize chat widgets by using data tags on the chat widget script"
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 08/01/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: reference
---
# Customize a chat widget

Chat widgets can be customized by using data tags on the chat widget script.

|Attribute name|Description|Example|
|----|-----|-----|
|`data-hide-chat-button`| When the HTML snippet is added to a website, a widget shows up on that website by default. In some cases, customers may want to implement the chat widget using their own button so this attribute allows customers to hide the chat button. | Add this tag to the chat widget script that you got from the Omnichannel Administration page.<br /><br />`<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-hide-chat-button="true"></script>`|
|`data-enable-telemetry`| By default, telemetry is turned on for all widgets. Set the value of this data tag to `false`, if you want to disable telemetry data collection. More information: [Live chat widget telemetry](../live-chat-telemetry.md).|Add this tag to the chat widget script that you got from the Omnichannel Administration page.<br />Telemetry data collection is turned on by default. See this example to turn off live chat widget telemetry.<br />`<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-enable-telemetry="false"></script>` |
|`data-render-mobile`| Enables you to open the chat widget in mobile mode. The chat widget does not have a header when used on a mobile device.|Use this script to enable rendering of your chat widget on mobile devices.<br />`<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-render-mobile="true" ></script>` |
|`data-color-override`| Use this data tag to override the default chat widget theme color. This override will take priority over any color theme settings in the Omnichannel administration page.|Add this tag to the chat widget script that you got from the Omnichannel Administration page. The script given below will change the chat widget theme color to Blue.<br />`<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-color-override="#0000FF"></script>` |
|`data-font-family-override`| Use this data tag to override the default chat widget font family. This override will take priority over previously set font family in the Omnichannel administration page.<br />If your website has a custom font uploaded, that can also be used to override the default font family.|Add this tag to the chat widget script that you got from the Omnichannel Administration page. The script given below will change the chat widget font family such that it will use Roboto font, as a first priority otherwise it will set the font to Segoe UI.<br />`<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-font-family-override="Roboto; Segoe UI"></script>` |

### See also

[Start proactive chat](start-proactive-chat.md)<br />
[JavaScript API reference for Live chat SDK](../omnichannel-reference.md)