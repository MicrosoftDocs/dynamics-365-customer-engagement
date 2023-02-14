---
title: Develop a custom live chat widget
description: Learn where to find information about using the Omnichannel Chat SDK and the Omnichannel Live Chat Widget UI Components library to develop a custom live chat widget.
ms.date: 02/07/2023
ms.topic: conceptual
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
  - bap-template
---

# Develop a custom live chat widget

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Microsoft provides an option to create a custom live chat widget that you can attach to your Dynamics 365 Customer Service account. Each component of the custom live chat widget can be customized for both functionality and user interface. We recommend that you develop your chat widget using the Omnichannel Live Chat Widget UI Components library and the Omnichannel Chat SDK.

## Omnichannel Live Chat Widget UI Components library

The Omnichannel Live Chat Widget UI Components library provides a framework of reusable React components. The components are built using the [Fluent UI library](https://developer.microsoft.com/fluentui). [Learn more about the Omnichannel Live Chat Widget UI Components library](https://github.com/microsoft/omnichannel-chat-widget/blob/main/README.md).

## Omnichannel Chat SDK

The Omnichannel Chat SDK is an open-source package that provides chat methods and features to add functionality to a live chat widget. [Learn more about the Omnichannel Chat SDK](https://github.com/microsoft/omnichannel-chat-sdk/blob/main/README.md).

## Customize your live chat widget

After you install the latest version of the Omnichannel Chat SDK, customize your live chat widget using Omnichannel Chat SDK methods and by editing the basic CSS styles of Omnichannel Live Chat Widget UI Components.

> [!Note]
> The Omnichannel Chat SDK is a prerequisite for installing the Omnichannel Live Chat Widget UI Components library.

### See also

[Customize live chat widgets for mobile apps](render-live-chat-widget-mobile.md)  
[startChat](developer/reference/methods/startchat.md)  
[closeChat](developer/reference/methods/closechat.md)  
[lcw:closeChat](developer/reference/events/lcw-closechat.md)  
[lcw:threadUpdate](developer/reference/events/lcw-threadUpdate.md)  
[lcw:chatRetrieved](developer/reference/events/lcw-chatRetrieved.md)  
[lcw:chatQueued](developer/reference/events/lcw-chatQueued.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
