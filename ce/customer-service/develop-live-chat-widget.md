---
title: Develop a custom live chat widget
description: Learn where to find information about using the Omnichannel Chat SDK and the Omnichannel Live Chat Widget UI Components library to develop a custom live chat widget.
ms.date: 03/07/2023
ms.topic: conceptual
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
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

Microsoft provides an option to create a custom live chat widget that you can attach to your Dynamics 365 Customer Service account. Each component of the custom live chat widget can be customized for both functionality and user interface.

Depending on your requirement and outcome, you can customize the chat widget using one of the following options:

- Live chat widget 2.0 (preview)
- Custom developer

## Live chat widget 2.0 (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

The new live chat widget 2.0 is a combination of the Omnichannel Chat SDK and out-of-the-box widget stacks of Customer Service admin center.

### Portal Developer&mdash;Out-of-the-box script-based UI customization

The portal developer option lets you personalize the UI of the chat widget but doesn't modify the out-of-the-box functionality settings in Customer Service admin center. To do so, you can use the "data-customization-callback" script customization that connects the out-of-the-box widget to a JavaScript function. The function can contain CSS styling customizations to the chat components with the same precedents as the [Omnichannel Live Chat Widget UI Components library](https://github.com/microsoft/omnichannel-chat-widget/blob/main/README.md).

### Edit live chat widget script to enable live chat widget 2.0

To use the live chat widget 2.0 and script-based customization, modify the code snippet of the out-of-the-box live chat widget as follows.

1. Create a new JavaScript function with all component styling.
1. Add "v2" after the script attribute.
1. Add "data-customization-callback" and reference the JavaScript function.

The updated code snippet will look as follows.

```javascript
<script>
  function lcw()  {
    return {
      styleProps: {
        generalStyles: {
            width: "800px",
            height:"800px"
        }
      }
    }
  }
</script>
<script
  v2
  src="https://oc-cdn-boston.azureedge.net/livechatwidget/scripts/LiveChatBootstrapper.js"
  id="Microsoft_Omnichannel_LCWidget" 
  data-org-id="a7693301-391c-48f0-baff-13add23e88d1"  
  data-app-id="47a1f33b-11af-45d3-ad03-85532a2add5f"
  data-org-url="https://unqa7693301391c48f0baff13add23e8-crm.oc.crmlivetie.com"
  data-lcw-version="test"
  data-customization-callback="lcw">
</script>

```

An example screenshot of a chat widget 2.0 is as follows.

:::image type="content" source="media/live-chat-widget-2.0.png" alt-text="A sample screenshot of live chat widget 2.0."::: 

## Custom developer

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
