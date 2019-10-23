---
title: "What's new in Channel Integration Framework (CIF)| Microsoft Docs"
description: "Read about the new features provided in the latest release of Channel Integration Framework (CIF)."
keywords: ""
ms.date: 10/16/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: get-started-article
ms.assetid: 42BEC0F2-AAA7-44A1-9BD7-EA2A04F5ACDB
author: susikka
ms.author: susikka
manager: shujoshi
---

# What's new in Channel Integration Framework (CIF)

This topic provides the list of features that are introduced in the latest version of Channel Integration Framework.

## Preview: What's new in Channel Integration Framework version 2.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> All APIs released for Channel Integration Framework version 1.0 can be used with the latest version. The APIs for managing tabs and sessions are not supported on single session apps.

The Channel Integration Framework (CIF) version 2.0, provides multiple enhancements over the version 1.0, particularly in terms of its ability to integrate with the latest multi-session agent experiences for customer service. Following are the key new features in the Channel Integration Framework Version 2.0 over the version 1.0:

### Integration with the multi-session experiences

The Channel Integration Framework version 2.0 provides APIs to integrate with the multi-session experiences in the Omnichannel for customer service app. These APIs allow providers to show notifications on incoming conversations with relevant information, start new sessions for conversations, and open application tabs as and when needed. For more information, see Integration with multi-session experiences.

More information: [Microsoft.CIFramework methods](reference/microsoft-ciframework.md).

### New modes and locations for the communication widget

Providers can now define experiences for the minimized mode of the communication widgets they build. Agents can manually change the mode of the control from docked to minimized. The same can be achieved programmatically as well. For more information, see New modes and locations for the communication widget.

More information: [Modes and locations for the communication widget](modes-communication-widget.md) and [setMode API](reference/microsoft-ciframework/setMode.md).

### Support for Multiple Providers

With Channel Integration Framework version 2.0, organizations can configure multiple providers in the Omnichannel for Customer Service app. This enables agents to simultaneously work on multiple sessions catering to different customers on different channels (for example, live chat and telephony), where each of these sessions belong to different providers. For more information, see Support for Multiple Providers.

More information: [Support for multiple providers](support-multiple-providers.md).

### Channel Analytics

Channel Integration Framework version 2.0 provides insights on how the call center is performing in terms of agent assignments, customer satisfaction, average handling time and agent performance. It uses predictive algorithms to calculate upcoming load, customer satisfaction, relationship scores and upsell probability, and helps you utilize operational and conversational analytics for better future planning.

More information: [Channel Analytics](channel-analytics.md).

> [!IMPORTANT]
> For the complete list of features introduced in Channel Integration Framework 2.0, see the 2019 release wave 2 plan here: [Dynamics 365 Channel Integration Framework](/dynamics365-release-plan/2019wave2/dynamics365-customer-service/channel-integration-framework-v2).

## What's new in Channel Integration Framework version 1.0

This section provides the list of new features introduced for Dynamics 365 Channel Integration Framework (CIF) version 1.0.

### JavaScript Channel Integration Framework APIs

| JavaScript API | Description |
|-----|-----|
| [Microsoft.CIFramework.getEntityMetadata](reference/microsoft-ciframework/getEntityMetadata.md) | [!INCLUDE[getEntityMetadata-description](reference/microsoft-ciframework/includes/getEntityMetadata-description.md)] |
| [Microsoft.CIFramework.renderSearchPage](reference/microsoft-ciframework/renderSearchPage.md) | [!INCLUDE[renderSearchPage-description](reference/microsoft-ciframework/includes/renderSearchPage-description.md)] |

### Ability to pass Dynamics 365 URL to widget library

To access the Dynamics 365 Channel Integration Framework (CIF) APIs, you need to load the `msdyn_cilibrary.js` file inside your communication widget. Since the widget is in a different domain, the JavaScript API library needs to identify the Dynamics 365 domain to interact. To enable the communication between the different domains, you must pass your Dynamics 365 instance URL to the widget library.

There are two ways to pass the URL to widget library:
1. By adding attributes to a script tag
2. By adding a parameter `ucilib` in the URL

More information: [Pass a Dynamics 365 URL to a widget library](pass-url-widget-library.md)

### Ability to add another trusted domain

Channel Integration Framework allows you to add an additional trusted domain if the initial landing URL and the final domain from which the communication widget is hosted are different. More information: [Configure channel provider in Channel Integration Framework](configure-channel-provider-channel-integration-framework.md).

### Custom Parameters field in the Channel provider configuration

Custom Parameters field takes a text blob as input and [Microsoft.CIFramework.getEnvironment](reference/microsoft-ciframework/getEnvironment.md) returns this as a value of key `customParams`. 

More information: [Configure channel provider in Channel Integration Framework](configure-channel-provider-channel-integration-framework.md).

## See also

[Download Channel Integration Framework](https://go.microsoft.com/fwlink/p/?linkid=2050102)