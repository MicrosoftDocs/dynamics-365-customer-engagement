---
title: "What's new in Channel Integration Framework (CIF)| Microsoft Docs"
description: "Read about the new features provided in the latest release of Channel Integration Framework (CIF)."
keywords: ""
ms.date: 12/10/2018
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: get-started-article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 42BEC0F2-AAA7-44A1-9BD7-EA2A04F5ACDB
author: susikka
ms.author: susikka
manager: shujoshi
---

# What's new in Channel Integration Framework (CIF)

The topic provides the list of new features introduced for Dynamics 365 Channel Integration Framework (CIF) version 1.0.

## JavaScript Channel Integration Framework APIs

| JavaScript API | Description |
|-----|-----|
| [Microsoft.CIFramework.getEntityMetadata](reference/microsoft-ciframework/getEntityMetadata.md) | [!INCLUDE[getEntityMetadata-description](reference/microsoft-ciframework/includes/getEntityMetadata-description.md)] |
| [Microsoft.CIFramework.renderSearchPage](reference/microsoft-ciframework/renderSearchPage.md) | [!INCLUDE[renderSearchPage-description](reference/microsoft-ciframework/includes/renderSearchPage-description.md)] |

## Ability to pass Dynamics 365 URL to widget library

To access the Dynamics 365 Channel Integration Framework (CIF) APIs, you need to load the `msdyn_cilibrary.js` file inside your communication widget. Since the widget is in a different domain, the JavaScript API library needs to identify the Dynamics 365 domain to interact. To enable the communication between the different domains, you must pass your Dynamics 365 instance URL to the widget library.

There are two ways to pass the URL to widget library:
1. By adding attributes to a script tag
2. By adding a parameter `ucilib` in the URL

More information: [Pass a Dynamics 365 URL to a widget library](pass-url-widget-library.md)

## Ability to add another trusted domain

Channel Integration Framework allows you to add an additional trusted domain if the initial landing URL and the final domain from which the communication widget is hosted are different. More information: [Configure channel provider in Channel Integration Framework](configure-channel-provider-channel-integration-framework.md).

## Custom Parameters field in the Channel provider configuration

Custom Parameters field takes a text blob as input and [Microsoft.CIFramework.getEnvironment](reference/microsoft-ciframework/getEnvironment.md) returns this as a value of key `customParams`. 

More information: [Configure channel provider in Channel Integration Framework](configure-channel-provider-channel-integration-framework.md).


## Download Dynamics 365 Channel Integration Framework

Download link for Channel Integration Framework solution: [Channel Integration Framework](https://go.microsoft.com/fwlink/p/?linkid=2050102).

## See also

[Dynamics 365 Channel Integration Framework Guide](index.md)

[Download Channel Integration Framework](https://go.microsoft.com/fwlink/p/?linkid=2050102)
