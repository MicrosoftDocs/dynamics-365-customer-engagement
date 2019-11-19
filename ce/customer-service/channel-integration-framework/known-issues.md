---
title: "Common issues and resolutions for Dynamics 365 Channel Integration Framework | Microsoft Docs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 10/25/2019
ms.topic: article
ms.service: 
  - dynamics-365-cross-app
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# Common issues and resolutions for Dynamics 365 Channel Integration Framework

Here are some common issues that you might encounter while using Dynamics 365 Channel Integration Framework.

## Switching sessions

If the session title is in the format of a telephone number, it is not possible to switch sessions. 

## Sample softphone widget

In the sample softphone widget, you won't be able to use the Hold, Mute, Dialer pad, and More options buttons. 

## Default sessions for providers

Providers might need a customer-less default session to show a dialer experience in the communication widget, and conversation dashboards in the application tab, and so on.  The framework does not support configurable default sessions for providers. However, to achieve this, they can create a session template with relevant application tabs and load the same when their widget is loaded. 

## Presence synchronization between multiple providers

The framework does not support the capability to synchronize presence across providers during the private preview. Support for this will come later.
