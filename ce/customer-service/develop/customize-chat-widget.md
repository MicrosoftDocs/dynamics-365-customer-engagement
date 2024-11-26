---
title: Customize live chat widgets using data tags
description: Learn to customize chat widgets by using data tags in the widget script in Customer Service admin center.
ms.date: 01/29/2024
ms.topic: conceptual
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
ms.collection:
---
# Customize live chat widgets using data tags

You can customize live chat widgets by using data tags in the widget script. You can use the following tags in the chat widget script that you copy from your admin app such as Customer Service admin center. More information: [Embed chat widget in your website or portal](../administer/embed-chat-widget-portal.md)

|Attribute name|Description|Example|
|----|-----|-----|
|`data-hide-chat-button`| When you implement your chat widget, you can add a chat button that aligns with your mobile app experience instead of using the default chat button. In such cases, use this data tag to hide the default open chat button that's available in the live chat widget. | `<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-hide-chat-button="true"></script>`|
|`data-hide-minimize-button`| When you implement your chat widget, you can disable the minimize button inside the default chat. Use this data tag to hide the default minimize chat button that's available in the live chat widget. | `<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-hide-minimize-button="true"></script>`|
|`data-disable-telemetry`| By default, telemetry data collection is turned on for all widgets. Set the value of this data tag to `true` if you want to disable telemetry data collection. More information: [Live chat widget telemetry](live-chat-telemetry.md)| `<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-disable-telemetry="true"></script>` |
|`data-render-mobile`| Open the chat widget in mobile mode. The chat widget doesn't have a header when used on a mobile device. More information: [Customize live chat widget for mobile apps](render-live-chat-widget-mobile.md#render-the-live-chat-widget-using-embedded-code)| `<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-render-mobile="true" ></script>` |
|`data-color-override`| Use this data tag to override the default chat widget theme color. This override takes priority over any color theme settings on the admin app. | Here's an example, where the widget theme color is changed to blue.`<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-color-override="#0000FF"></script>` |
|`data-font-family-override`|  The default font family is Segoe UI. Use this data tag to override the default font family with another native supported font. | **Example 1**: To override the default Segoe UI font and set the font family to Arial: <br> `<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-font-family-override="Arial, Segoe UI"></script>` <br> <br>**Example 2**: To add a custom font family like Monotype Corsiva:<br>  `<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-font-family-override="Monotype Corsiva"></script>`  |
|`data-open-in-window`| Use this data tag to open the chat widget in a new window. You can set this tag to `true` or `false` (default value). By default, the chat widget opens in the same browser window. If set to `true`, the chat widget opens in a new browser window when selected. | `<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-open-in-window="true"></script>`|
|`data-suggested-action-layout`| Use this data tag to display the suggested actions vertically. By default, the suggested actions are displayed horizontally. To display the suggested actions vertically, set the value of this data tag as `stacked`. | `<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-suggested-action-layout="stacked"></script>`|
|`data-enable-lcw-autofill`| Use this data tag to enable the chat widget to autofill the browser window in embedded mode. | `<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-enable-lcw-autofill="true"></script>`|
|`data-custom-close-button-text`| Use this data tag to customize the close button of the chat widget. The input is a text string that appears in place of the default ‘X’ close button. |  `<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-custom-close-button-text="End Chat"></script>`|
|`data-enable-sso-magic-code` |  Use this data tag to automatically send a magic code to the user after sign-in, either in the chat or silently through the client. This function is similar to multifactor authentication and helps prevent phishing attacks. You can set this tag to `true` (default value) or `false`. If set to `false`, the code is automatically sent through the client silently, after sign-in. If set to `true`, a magic code is displayed to the user to manually enter into the chat, after sign-in. See the **Additional settings for browsers** section in this article for more information. | In this example, the magic code is automatically passed through the client after sign-in, without needing user input.  <br> `<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-enable-sso-magic-code="false"></script>`|

### Additional settings for browsers

Perform the browser-specific steps outlined here to automatically pass the magic code.

**Chromium-based browsers**

1. In Microsoft Edge, enter "edge://flags/#third-party-storage-partitioning" in the address bar. In Google Chrome, enter "chrome://flags/#third-party-storage-partitioning" in the address bar.
1. On the page that appears, set the **Third-party Storage Partitioning** flag to **Disabled**.

**Firefox**

1. In Firefox, enter "about:preferences#privacy" in the address bar.
1. On the page that appears, select **Custom**, and for **Cookies**, select **Cross-site tracking cookies**.

**Safari**

On the settings dialog, select **Feature Flags**, and clear the selection for **BroadcastChannel Origin Partitioning**.

## Next steps

[Develop a custom live chat widget](develop-live-chat-widget.md)  

### Related information

[Start chat proactively](start-proactive-chat.md)  
[Live chat widget telemetry](live-chat-telemetry.md)  
[Customize live chat widgets for mobile apps](render-live-chat-widget-mobile.md)  
[Live chat SDK reference](omnichannel-reference.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
