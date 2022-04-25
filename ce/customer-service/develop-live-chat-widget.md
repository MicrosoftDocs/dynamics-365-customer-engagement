---
title: "Develop a custom live chat widget | MicrosoftDocs"
description: "Use this article to understand how to develop a custom live chat widget using Omnichannel Chat SDK and Omnichannel Live Chat Widget UI Components library."
ms.date: 04/22/2022
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

# Develop a custom live chat widget

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Microsoft provides an option to create a custom live chat widget that you can attach to your Dynamics 365 Customer Service account. Each individual component of the custom live chat widget can be customized for both functionality and user interface. We recommend that you develop your own chat widget using the Omnichannel Live Chat Widget UI Components library and Omnichannel Chat SDK, as described in this article.

## Omnichannel Live Chat Widget UI Components

The Omnichannel Live Chat Widget UI Components library provides a framework of reusable React components that can be edited in all basic CSS styles to modify the user interface of the live chat widget. These components are built using the [Fluent UI library](https://developer.microsoft.com/fluentui).

To learn more about the Omnichannel Live Chat Widget UI Components, see [here](https://github.com/microsoft/omnichannel-chat-widget/blob/main/README.md).

## Omnichannel Chat SDK

The Omnichannel Chat SDK is an open-source package that provides chat methods and features to add functionality of the widget.

To learn more about the Omnichannel Chat SDK, see [here](https://github.com/microsoft/omnichannel-chat-sdk/blob/main/README.md).

## Customize your live chat widget

After you install the Omnichannel Chat SDK, you can customize your live chat widget using both the Omnichannel Live Chat Widget UI Components and the Omnichannel Chat SDK methods.

> [!Note]
> The Omnichannel Chat SDK is a prerequisite for Omnichannel Live Chat Widget UI Components. To effectively use both Omnichannel Live Chat Widget UI Components and Omnichannel Chat SDK, ensure that you've installed the latest version of Omnichannel Chat SDK.

### See also

[Customize live chat widgets for mobile apps](render-live-chat-widget-mobile.md)  
[startChat](developer/reference/methods/startchat.md)  
[closeChat](developer/reference/methods/closechat.md)  
[lcw:closeChat](developer/reference/events/lcw-closechat.md)  
[lcw:threadUpdate](developer/reference/events/lcw-threadUpdate.md)  
[lcw:chatRetrieved](developer/reference/events/lcw-chatRetrieved.md)  
[lcw:chatQueued](developer/reference/events/lcw-chatQueued.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]