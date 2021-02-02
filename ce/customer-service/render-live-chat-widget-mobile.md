---
title: "Render a live chat widget on the mobile app| Microsoft Docs"
description: "Render a live chat widget on your mobile app using a code snippet or SDK"
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 10/12/2020
ms.topic: reference
ms.service: dynamics-365-customerservice
---
# Render a live chat widget on the mobile app

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

There are two ways to integrate Omnichannel chat into mobile apps: one is by embedding the chat widget using the code snippet, and the other is using the headless Omnichannel Chat SDK.

## Render a live chat widget on the mobile app using the code snippet
Use the `WebView` component of your mobile operating system language to enable rendering of the web version of the live chat widget on mobile devices. The `WebView` capability, which enables mobile apps to display web content, is offered on both Android and iOS.

The following sample code illustrates how you can render the chat widget on the mobile app. 

```Kotlin
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

The rendering of the live chat widget in the mobile web experience can be optimized by using data attributes such as `data-hide-chat-button` and `data-render-mobile`, along with some of the APIs and events provided by the live chat widget client SDK.

The usage of the `data-hide-chat-button` attribute in the preceding sample code hides the default open chat button available in the live chat widget. So instead of using the default chat button, you can add a button that aligns with the mobile app. To open a chat session, you can call the [startChat](developer/reference/methods/startchat.md) method when the new chat button is clicked.

```javascript
chatWebView.evaluateJavascript("window.addEventListener(\"lcw:ready\", function handleLivechatReadyEvent(){

    Microsoft.Omnichannel.LiveChatWidget.SDK.startChat()
    });", null)
```

You use the `data-render-mobile` attribute to optimize the rendering of the live chat widget on mobile. For example, it hides the header of the chat widget. Along with the header, the **Close** (X) button also goes away. To close the chat, you have to create an "end chat" button in the mobile app and call the [closeChat](developer/reference/methods/closeChat.md) method on the click event. 

```javascript
chatWebView.evaluateJavascript(
    "Microsoft.Omnichannel.LiveChatWidget.SDK.closeChat();",
    null
)
```

The preceding code covers the scenario where the user of the mobile app ends the chat. In another scenario, where an agent ends the conversation, you can listen for the [lcw:threadUpdate](developer/reference/events/lcw-threadUpdate.md) event and call the [closeChat](developer/reference/methods/closeChat.md) method to end the conversation from the client side.

```javascript
chatWebView.evaluateJavascript(
    "window.addEventListener(\"lcw:threadUpdate\", function(){
            Microsoft.Omnichannel.LiveChatWidget.SDK.closeChat();
    })",null)
```

After the chat is closed, the live chat widget triggers the [lcw:closeChat](developer/reference/events/lcw-closeChat.md) event. You can listen for this event, and run the post-chat steps.

> [!NOTE]
> Live chat widget features&mdash;such as escalating to voice and video, and downloading the chat transcript&mdash;aren't supported on the mobile app.

## Render a live chat widget on the mobile app using the Omnichannel Chat SDK

The Omnichannel Chat SDK allows organizations to build their own chat widget against the Omnichannel services by exposing methods for various chat features. The look and feel of the chat widget can be fully customized depending on your organization's needs. The SDK is built in React Native, and therefore works for iOS and Android apps as well as on web browsers.  

The Omnichannel Chat SDK is open source and is located at [https://www.npmjs.com/package/@microsoft/omnichannel-chat-sdk](https://www.npmjs.com/package/@microsoft/omnichannel-chat-sdk).  

We also provide a reference app using the popular UI Gifted Chat.  

### See also

[startChat](developer/reference/methods/startchat.md)<br />
[lcw:closeChat](developer/reference/events/lcw-closechat.md)<br />
[lcw:threadUpdate](developer/reference/events/lcw-threadUpdate.md)
