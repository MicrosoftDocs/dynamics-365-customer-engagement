---
title: "Known issues and resolutions for Dynamics 365 Channel Integration Framework | Microsoft Docs"
description: ""
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 11/21/2019
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# Known issues and resolutions for Dynamics 365 Channel Integration Framework

Here are some common issues that you might encounter while using Dynamics 365 Channel Integration Framework.

## Switching sessions

If the session title is in the format of a telephone number, it is not possible to switch sessions. 

## Sample softphone widget

In the sample softphone widget, you won't be able to use the Hold, Mute, Dialer pad, and More options buttons. 

## Default sessions for providers

Providers might need a customer-less default session to show a dialer experience in the communication widget, and conversation dashboards in the application tab, and so on.  The framework does not support configurable default sessions for providers. However, to achieve this, they can create a session template with relevant application tabs and load the same when their widget is loaded. 

## Presence synchronization between multiple providers

The framework does not support the capability to synchronize presence across providers during the private preview. Support for this will come later.

## Form flickering when communication widget is expanded

If you have a form open when you expand the communication widget, you will observe that the form flickers. The flickering will be observed only if any of the following conditions apply.

-	The form section layout is 4 columns.
-	The form has a web resource which defines the row size to 40 or greater, and also sets the form section layout to 4 columns.
-	Screen size is 23.6 inch or higher.

You will not observe flickering if the form has just one row and if all cells in the row are filled. Also, you will not observe this if there are 4 columns and 4 rows with non-empty cells. Flickering of forms is observed when there are 2 or more rows, with or without empty cells.

The resolution for this is to adjust the screen size.

## See also

[What's new in Dynamics 365 Channel Integration Framework](whats-new-channel-integration-framework.md)<br />
[Frequently asked questions](faq-channel-integration-framework.md)
