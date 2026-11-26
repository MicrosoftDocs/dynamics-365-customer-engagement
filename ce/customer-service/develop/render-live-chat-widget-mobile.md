---
title: Customize live chat widgets for mobile apps
description: Learn about the mobile messaging SDK and how to use sample code to embed live chat widget code directly in your mobile apps.
ms.date: 08/12/2025
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
search.audienceType: 
  - admin
  - developer
  - customizer
ms.custom: 
  - dyn365-USD
  - dyn365-admin
---

# Customize live chat widgets for mobile apps

You have two options for integrating messaging in your native mobile app:

- Use native mobile software development kits (SDKs) for iOS and Android
- Use the web widget inside a WebView

We strongly recommend that you use the native mobile SDKs because they deliver superior feature support and performance.

## Integrate with the Dynamics 365 Contact Center mobile SDKs

The mobile SDKs and their documentation are hosted on GitHub:

- [Contact Center Messaging SDK - Android | GitHub](https://github.com/microsoft/ContactCenterMessagingSDK-android)
- [Contact Center Messaging SDK - iOS | GitHub](https://github.com/microsoft/ContactCenterMessagingSDK-ios)

The SDKs contain:
- An example application to help you get started
- A configurable, out-of-the-box messaging interface
- A full set of messaging lifecycle functions for integrating a bespoke messaging UI, if desired
- Support for push notifications with Azure Notification Hub

We recommend that you use authenticated, persistent chat with the messaging SDKs. This provides the best customer experience for mobile usage patterns.

> [!NOTE]
> The out-of-the-box interface is visually styled through code in your application instead of through the admin center.

## Render the live chat widget using embedded code

If the Mobile Messaging SDKs don't meet your requirements or timelines, then you can embed a web widget in your mobile app. However, embedding a chat widget code has many limitations such as reduced performance, limited mobile usability, and unavailable features.

A `WebView` is an embedded browser that enables a native application to display web content. Use the `WebView` component of your mobile operating system language to enable rendering of the web version of the chat widget on mobile devices. The WebView capability is offered on both Android and iOS.

The following sample code renders the chat widget in a mobile application.

```kotlin
var html: String = """
        <html>
            <head>
                <meta http-equiv="no-cache">
                <meta http-equiv="Expires" content="-1">
                <meta http-equiv="Cache-Control" content="no-cache">
                <script 
                    type="text/javascript"
                    src = "Use src from widget code snippet"
                    id = Microsoft_Omnichannel_LCWidget
                    data-app-id = "Use data-app-Id from widget code snippet"
                    data-org-id = "Use data-org-Id from widget code snippet"
                    data-org-url = "Use data-org-url from widget code snippet"
                    data-render-mobile = "true"
                    data-hide-chat-button = "true"
                    data-color-override = "desired color code eg. #008577">
                </script>
            </head>
            <body>
            </body>
        </html>
    """.trimIndent()
    var baseUrl: String = "Get baseUrl from data-org-url eg. https://oc-cdn-ocprod.azureedge.net"
    chatWebView.loadDataWithBaseURL(baseUrl,html, "text/html", null, baseUrl)
```

The chat widget uses local storage to manage its state. For the chat widget to access local storage on Android, you need to configure a permission in the native code.

```javascript
chatWebView = findViewById(R.id.webview)
webSettings = webView.getSettings();
webSettings.setDomStorageEnabled(true);
```

You can optimize the rendering of the chat widget for mobile web experience by using data tags such as `data-hide-chat-button` and `data-render-mobile`, along with a few APIs and events provided by the live chat widget client SDK. More information: [Customize a chat widget using data tags](customize-chat-widget.md)

To open a chat session, you can call the [startChat](reference/methods/startchat.md) method when the new chat button is selected.

```javascript
chatWebView.evaluateJavascript(
    "Microsoft.Omnichannel.LiveChatWidget.SDK.closeChat();",
    null
)
```

You can use the `data-render-mobile` data tag to optimize the rendering of the live chat widget on mobile. For example, it hides the header of the chat widget. Along with the header, the **Close (X)** button also goes away. To close the chat, you have to create an "end chat" button in the mobile app and call the [closeChat](reference/methods/closeChat.md) method on the click event.

```javascript
chatWebView.evaluateJavascript(
    "Microsoft.Omnichannel.LiveChatWidget.SDK.closeChat();", null)
```

The preceding code covers the scenario where the user of the mobile app ends the chat. However, in another scenario, where an agent ends the conversation, you can listen for the [lcw:threadUpdate](reference/events/lcw-threadUpdate.md) event and call the [closeChat](reference/methods/closeChat.md) method to end the conversation from the client side, as shown in the following code.

```javascript
chatWebView.evaluateJavascript(
    "window.addEventListener(\"lcw:threadUpdate\", function(){Microsoft.Omnichannel.LiveChatWidget.SDK.closeChat();})", null)
```

When the chat is closed, the live chat widget triggers the [lcw:closeChat](reference/events/lcw-closechat.md) event. You can listen for this event, and perform any post-chat steps if required.

> [!NOTE]
> Live chat widget features such as escalating to voice and video and downloading the chat transcript aren't supported through a webview.

### Related information

[Live chat SDK reference](omnichannel-reference.md)  
[Develop custom live chat widgets](develop-live-chat-widget.md)  
[startChat](reference/methods/startchat.md)  
[closeChat](reference/methods/closeChat.md)  
[lcw:chatRetrieved](reference/events/lcw-chatRetrieved.md)  
[lcw:chatQueued](reference/events/lcw-chatQueued.md)  
[Customize live chat widgets using data tags](customize-chat-widget.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
