---
title: "Customize the live chat widget for mobile apps with Omnichannel Chat SDK | MicrosoftDocs"
description: "Learn to customize the live chat widget on your mobile apps using the Omnichannel Chat SDK. Alternatively, embed the widget code directly in your apps."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 05/16/2021
ms.topic: reference
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
  - dyn365-admin
search.audienceType: 
  - admin
  - developer
  - customizer
search.app: 
  - D365CE
  - D365USD
---

# Customize the live chat widget for mobile apps

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This topic explains how you can use the Omnichannel Chat SDK to customize the live chat widget for mobile apps. Alternatively, you can also find a sample code to embed the live chat widget in your apps.

## Customize the live chat widget using the Omnichannel Chat SDK

To create an Omnichannel for Customer Service chat widget in mobile apps, we recommend that you use the Omnichannel Chat SDK. The open-source Omnichannel Chat SDK comes with a fully customizable user interface with Omnichannel chat methods and features. The SDK is supported on React Native, and therefore works for iOS and Android apps, and also on web browsers.

For download instructions and information, go to [Omnichannel Chat SDK Installation page on Github](https://github.com/microsoft/omnichannel-chat-sdk#installation).

Examples of sample apps in the Omnichannel Chat SDK include:

- React-Native App: [gifted-chat](https://github.com/FaridSafi/react-native-gifted-chat)

- Web Reference App: [BotFramework-WebChat](https://github.com/microsoft/BotFramework-WebChat)

To view all sample apps, go to [Chat SDK Sample Apps](https://github.com/microsoft/omnichannel-chat-sdk/tree/main/samples).

> [!NOTE]
> Most future updates on chat customization will happen on the Omnichannel Chat SDK package.

## Render the live chat widget using embedded code

Though we recommend using the Omnichannel Chat SDK, if the SDK does not meet your requirements, then you can embed a live chat widget code in your mobile app.

> [!NOTE]
> Embedding a live chat widget code has many more limitations and restrictions compared to the Omnichannel Chat SDK such as reduced performance, limited mobile usability, and unavailable features.
>
> Live chat widget features&mdash;escalating to voice and video, and downloading the chat transcript&mdash;aren't supported on the mobile apps.

Use the `WebView` component of your mobile operation system language to enable rendering of the web version of the live chat widget on mobile devices. A `WebView` is an embedded browser that enables a native application to display web content. The WebView capability is offered on both Android and iOS.

The following is sample code of rendering the live chat widget onto a mobile application:

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

The rendering of the live chat widget in the mobile web experience can be optimized by using data attributes such as `data-hide-chat-button` and `data-render-mobile`, along with some of the APIs and events provided by the live chat widget client SDK. More information: [Customize a chat widget using data tags](customize-chat-widget.md)

The usage of the `data-hide-chat-button` attribute in the preceding sample code hides the default open chat button available in the live chat widget. So instead of using the default chat button, you can add a button that aligns with the mobile app. To open a chat session, you can call the [startChat](developer/reference/methods/startchat.md) method when the new chat button is clicked.

```javascript
chatWebView.evaluateJavascript(
    "Microsoft.Omnichannel.LiveChatWidget.SDK.closeChat();",
    null
)
```

You use the `data-render-mobile` attribute to optimize the rendering of the live chat widget on mobile. For example, it hides the header of the chat widget. Along with the header, the **Close (X)** button also goes away. To close the chat, you have to create an "end chat" button in the mobile app and call the [closeChat](developer/reference/methods/closechat.md) method on the click event.

```javascript
chatWebView.evaluateJavascript(
    "Microsoft.Omnichannel.LiveChatWidget.SDK.closeChat();", null)
```

The preceding code covers the scenario where the user of the mobile app ends the chat. In another scenario, where an agent ends the conversation, you can listen for the [lcw:threadUpdate](developer/reference/events/lcw-threadupdate.md) event and call the [closeChat](developer/reference/methods/closechat.md) method to end the conversation from the client side.

```javascript
chatWebView.evaluateJavascript(
    "window.addEventListener(\"lcw:threadUpdate\", function(){Microsoft.Omnichannel.LiveChatWidget.SDK.closeChat();})", null)
```

After the chat is closed, the live chat widget triggers the [lcw:closeChat](developer/reference/events/lcw-closechat.md) event. You can listen for this event, and run the post-chat steps.

### See also

[startChat](developer/reference/methods/startchat.md)  
[lcw:closeChat](developer/reference/events/lcw-closechat.md)  
[lcw:threadUpdate](developer/reference/events/lcw-threadUpdate.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
