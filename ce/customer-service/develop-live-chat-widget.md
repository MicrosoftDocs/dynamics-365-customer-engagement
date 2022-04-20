---
title: "Develop custom live chat widgets | MicrosoftDocs"
description: "Use this article to develop live chat widgets on your mobile apps using Omnichannel Chat SDK."
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

We recommend that you develop your own custom live chat widget using the Omnichannel Chat Live Chat Widget UI Components and Omnichannel Chat SDK. This article explains how you can create your own chat widget.

## Create a custom live chat widget

To enable you to add more customization and functionality in the live chat widget and user interface than the current out-of-the-box option, you can now attach a custom live chat widget to your Dynamics Customer Service account. To create a custom live chat widget, you can use the Omnichannel Live Chat Widget UI Components and the Omnichannel Chat SDK.

### Omnichannel Live Chat Widget UI Components

The Omnichannel Live Chat Widget UI Components library provides a framework of reusable React components that can be edited in all basic CSS styles to modify the user interface of the live chat widget. These components are built using the (Fluent UI library)[https://developer.microsoft.com/fluentui].

Microsoft provides a default out-of-the-box live chat widget built using all the components where each individual component can be further customized. To learn more about the Omnichannel Live Chat Widget UI Components, see (here) [Hyperlink].

### Omnichannel Chat SDK

The Omnichannel Chat SDK is an open-source package that provides chat methods and features for the functionality of the widget.
To learn more about the Omnichannel Chat SDK, see [Omnichannel Chat SDK](https://github.com/microsoft/omnichannel-chat-sdk).

Together with the Live Chat Widget UI Components library, you can use the methods of the Omnichannel Chat SDK to develop your widget.

### Combining the Omnichannel Chat SDK and Omnichannel Live Chat Widget UI Components

With the Omnichannel Live Chat Widget UI Components library, the Omnichannel Chat SDK package is a pre-requisite, allowing the components to already be linked with the methods. 
In addition, custom components from developers can be attached using both.

### See also

[startChat](developer/reference/methods/startchat.md)  
[closeChat](developer/reference/methods/closechat.md)  
[lcw:closeChat](developer/reference/events/lcw-closechat.md)  
[lcw:threadUpdate](developer/reference/events/lcw-threadUpdate.md)  
[lcw:chatRetrieved](developer/reference/events/lcw-chatRetrieved.md)  
[lcw:chatQueued](developer/reference/events/lcw-chatQueued.md) 

[!INCLUDE[footer-include](../includes/footer-banner.md)]

<!--
Using the Omnichannel Chat SDK, you can create and customize chat widgets for use in mobile apps. The open-source Omnichannel Chat SDK comes with a fully customizable user interface with Omnichannel chat methods and features. The SDK is supported on React Native, and therefore works on iOS and Android apps, as well as on web browsers.

Examples of sample apps in the Omnichannel Chat SDK include:

- React-Native App: [gifted-chat](https://github.com/FaridSafi/react-native-gifted-chat)

- Web Reference App: [BotFramework-WebChat](https://github.com/microsoft/BotFramework-WebChat)

To view all sample apps, go to [Chat SDK Sample Apps](https://github.com/microsoft/omnichannel-chat-sdk/tree/main/samples).

This topic explains how you can use the Omnichannel Chat SDK to customize the live chat widget for mobile apps. 

## Download Omnichannel Chat SDK

We recommend that you download the latest version of the Omnichannel Chat SDK package to take advantage of the newly added features. For download instructions and information, go to the [Omnichannel Chat SDK Installation page on GitHub](https://github.com/microsoft/omnichannel-chat-sdk#installation).

> [!Note]
> To implement the Azure Bot Service channel, you'll need Omnichannel Chat SDK 1.0.0.
-->