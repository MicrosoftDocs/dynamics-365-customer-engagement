---
title: Develop a custom live chat widget
description: Learn where to find information about using the Omnichannel Chat SDK and the Omnichannel Live Chat Widget UI Components library to develop a custom live chat widget.
ms.date: 04/25/2023
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
search.audienceType: 
  - admin
  - developer
  - customizer
ms.custom: 
  - dyn365-USD
  - dyn365-admin
  - bap-template
---

# Develop a custom live chat widget

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Microsoft provides an option to create a custom live chat widget that you can attach to your Dynamics 365 Customer Service account. Each component of the custom live chat widget can be customized for both functionality and user interface.

Depending on your requirement and outcome, you can customize the chat widget using one of the following options:

- Use customizable live chat widget 2.0
- Develop your own widget

## Use customizable live chat widget 2.0

The customizable live chat widget 2.0 lets you edit all elements of the widget, such as font, colors, and styling so that you can match the widget with your brand image. The customized widget helps you cultivate trust and credibility, distinguish your brand, foster positive emotional connections, and increase the value that customers attribute to your product.

The new live chat widget 2.0 is built upon Omnichannel Chat SDK and Live Chat Widget UI Component Library.

### Portal Developer&mdash;Customize out-of-the-box script-based UI

The portal developer option lets you personalize the UI of the chat widget but doesn't modify the out-of-the-box functionality settings in Customer Service admin center. To customize, you can use the "data-customization-callback" script that connects the out-of-the-box widget to a JavaScript function. The function can contain CSS styling customizations to the chat components with the same precedents as the [Omnichannel Live Chat Widget UI Components library](https://github.com/microsoft/omnichannel-chat-widget/blob/main/README.md).

### Edit live chat widget script to enable live chat widget 2.0

To use the live chat widget 2.0 and script-based customization, modify the code snippet of the out-of-the-box live chat widget 2.0 as follows.

1. In Customer Service admin center, open the chat workstream, and select **Copy Live Chat Widget 2.0 Script** to copy the code snippet.
1. Create a new JavaScript function with all component styling. More information: [Omnichannel chat widget](https://github.com/microsoft/omnichannel-chat-widget)
1. Add "v2" after the script attribute.
1. Add "data-customization-callback" and reference the JavaScript function.

The updated code snippet will look as follows.

:::image type="content" source="media/customized-lcw.png" alt-text="A screenshot of the customized live chat widget code.":::

An example screenshot of a chat widget 2.0 that's customized to increase its size is as follows.

:::image type="content" source="media/live-chat-widget-2.0.png" alt-text="A sample screenshot of live chat widget 2.0.":::

Watch the [walkthrough video](https://www.youtube.com/watch?v=Mzw96Zz_epI) of the live chat widget set up.

## Develop your own widget

Use the information in the following sections to build your own widget.

### Omnichannel Live Chat Widget UI Components library

The Omnichannel Live Chat Widget UI Components library provides a framework of reusable React components. The components are built using the [Fluent UI library](https://developer.microsoft.com/fluentui). [Learn more about the Omnichannel Live Chat Widget UI Components library](https://github.com/microsoft/omnichannel-chat-widget/blob/main/README.md).

### Omnichannel Chat SDK

The Omnichannel Chat SDK is an open-source package that provides chat methods and features to add functionality to a live chat widget. [Learn more about the Omnichannel Chat SDK](https://github.com/microsoft/omnichannel-chat-sdk/blob/main/README.md).

## Customize your live chat widget

After you install the latest version of the Omnichannel Chat SDK, customize your live chat widget using Omnichannel Chat SDK methods and by editing the basic CSS styles of Omnichannel Live Chat Widget UI Components.

> [!NOTE]
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
