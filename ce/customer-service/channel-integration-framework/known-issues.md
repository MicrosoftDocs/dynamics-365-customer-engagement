---
title: "Common issues and resolutions for Channel Integration Framework | Microsoft Docs"
description: ""
keywords: ""
ms.date: 10/22/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: article
ms.assetid: 42199642-3637-4823-BED9-3311A533D484
author: susikka
ms.author: susikka
manager: shujoshi
---

# Common issues and resolutions for Channel Integration Framework

This article lists some common issues that you might encounter while using Channel Integration Framework.

### Switching sessions

If the session title is in the format of a telephone number, it is not possible switch sessions. 

### Sample softphone widget

In the sample softphone widget, you will not be able to use the Hold, Mute, Dialer pad and More options buttons. 

### Default Sessions for providers

Providers may need a customer-less default session, to show a dialer experience in the communication widget, and conversation dashboards in the application tab etc.  The framework does not support configurable default sessions for providers. However, to achieve this, they can create a session template with relevant application tabs and load the same when their widget is loaded. 

### Presence synchronization between multiple providers

The framework does not support the capability to synchronize presence across providers during the private preview. The support for this will come in future.
