---
title: "Develop custom live chat widgets | MicrosoftDocs"
description: "Use this article to develop custom live chat widgets using Omnichannel Chat SDK and Omnichannel Live Chat Widget UI Components library."
ms.date: 03/22/2022
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
search.audienceType: 
  - admin
  - developer
  - customizer
search.app: 
  - D365CE
  - D365USD
ms.custom: 
  - dyn365-USD
  - dyn365-admin
---

# Develop custom live chat widgets

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Microsoft provides an out-of-the-box live chat widget where each individual component can be further customized. You can now attach the custom live chat widget to your Dynamics Customer Service account, and add more functionality and customize the user interface. We recommend that you develop your own custom live chat widget using the Omnichannel Chat Live Chat Widget UI Components and Omnichannel Chat SDK. This article explains how you can create your own chat widget.

### Omnichannel Live Chat Widget UI Components

The Omnichannel Live Chat Widget UI Components library provides a framework of reusable React components that can be edited in all basic CSS styles to modify the user interface of the live chat widget. These components are built using the (Fluent UI library)[https://developer.microsoft.com/fluentui].

To learn more about the Omnichannel Live Chat Widget UI Components, see [Hyperlink]().

### Omnichannel Chat SDK

The Omnichannel Chat SDK is an open-source package that provides chat methods and features to add functionality of the widget. To learn more about the Omnichannel Chat SDK, see [Omnichannel Chat SDK](https://github.com/microsoft/omnichannel-chat-sdk).

The SDK is supported on React Native, and works on iOS apps, Android apps, and web browsers. Examples of sample apps in the Omnichannel Chat SDK include:

- React-Native App: [gifted-chat](https://github.com/FaridSafi/react-native-gifted-chat)

- Web Reference App: [BotFramework-WebChat](https://github.com/microsoft/BotFramework-WebChat)

To view all sample apps, go to [Chat SDK Sample Apps](https://github.com/microsoft/omnichannel-chat-sdk/tree/main/samples).

## Develop your own live chat widget

To develop the custom live chat widget, you'll use both the Omnichannel Live Chat Widget UI Components and the Omnichannel Chat SDK.

Ensure that you first install the Omnichannel Chat SDK package. We recommend that you download the latest version of the Omnichannel Chat SDK package to take advantage of the newly added features. More information: [Omnichannel Chat SDK Installation page on GitHub](https://github.com/microsoft/omnichannel-chat-sdk#installation)

You can also use custom components from third-party developers in your chat widget, and create your own custom widget using both the Live Chat Widget UI Components library and the Omnichannel Chat SDK methods.

### See also

[Customize live chat widgets for mobile apps](render-live-chat-widget-mobile.md)  
[startChat](developer/reference/methods/startchat.md)  
[closeChat](developer/reference/methods/closechat.md)  
[lcw:closeChat](developer/reference/events/lcw-closechat.md)  
[lcw:threadUpdate](developer/reference/events/lcw-threadUpdate.md)  
[lcw:chatRetrieved](developer/reference/events/lcw-chatRetrieved.md)  
[lcw:chatQueued](developer/reference/events/lcw-chatQueued.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]