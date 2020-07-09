---
title: "Render live chat widget on mobile app| Microsoft Docs"
description: "Read how you can render a live chat widget on your mobile app"
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 07/09/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: reference
---
# Render live chat widget on mobile app

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

Use the `WebView` component of your mobile operating system language to enable rendering of the web version of the live chat widget on mobile devices. `WebView` capability is offered by both Android and IOS. It enables mobile apps to display web content.

The sample code given below illustrates how you can render the chat widget on the mobile app. 

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

The usage of `data-hide-chat-button` attribute hides the button required to launch a chat. To launch a chat, users have to create a start chat button in the mobile app and call the [startChat](../reference/methods/startchat.md) method on the click event.

```javascript
chatWebView.evaluateJavascript("window.addEventListener(\"lcw:ready\", function handleLivechatReadyEvent(){

    Microsoft.Omnichannel.LiveChatWidget.SDK.startChat()
    });", null)
```

The usage of `data-render-mobile` attribute enables mobile rendering related optimization of the live chat widget. For example, it hides the header of the chat widget to improve mobile experience. The “X” button to close chat also goes away with header. To close the chat, you have to create an end chat button in the mobile app and call the [closeChat](../reference/methods/closeChat.md) method on the click event. 

```javascript
chatWebView.evaluateJavascript(
    "Microsoft.Omnichannel.LiveChatWidget.SDK.closeChat();",
    null
)
```

The above code covers the scenario where user of the mobile app ends the chat. There is another scenario where agent can end the conversation, developers can listen to [lcw:threadUpdate](../reference/events/lcw-threadUpdate.md) event and call the [closeChat](../reference/methods/closeChat.md) method to end conversation from client side.

```javascript
chatWebView.evaluateJavascript(
    "window.addEventListener(\"lcw:threadUpdate\", function(){
            Microsoft.Omnichannel.LiveChatWidget.SDK.closeChat();
    })",null)
```

> [!NOTE]
> Live chat widget features such as escalating to voice and video, and downloading chat transcript are not supported on the mobile app.

### See also

[startChat](../reference/methods/startchat.md)<br />
[lcw:threadUpdate](../reference/events/lcw-threadUpdate.md)