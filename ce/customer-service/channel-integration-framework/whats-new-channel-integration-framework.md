---
title: "What's new in Dynamics 365 Channel Integration Framework | Microsoft Docs"
description: "Read about the new features provided in the latest release of Dynamics 365 Channel Integration Framework."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 10/16/2019
ms.topic: get-started-article
ms.service: dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# What's new in Dynamics 365 Channel Integration Framework

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

This topic provides a list of features that are introduced in the latest version of Dynamics 365 Channel Integration Framework.

## What's new in Dynamics 365 Channel Integration Framework version 2.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> All APIs released for Dynamics 365 Channel Integration Framework version 1.0 can be used with the latest version. The APIs for managing tabs and sessions are not supported on single session apps.

Dynamics 365 Channel Integration Framework version 2.0 provides multiple enhancements over version 1.0, particularly in terms of its ability to integrate with the latest multisession agent experiences for customer service. Following are the key new features in Dynamics 365 Channel Integration Framework version 2.0 over version 1.0.

### Integration with the multisession experiences

Dynamics 365 Channel Integration Framework version 2.0 provides APIs to integrate with the multisession experiences in the Omnichannel for Dynamics 365 Customer Service app. These APIs allow providers to show notifications on incoming conversations with relevant information, start new sessions for conversations, and open application tabs as needed. For more information, see [Integration with multisession experiences](integration-multi-session-experiences.md).

More information: [Microsoft.CIFramework methods](reference/microsoft-ciframework.md)

### New modes and locations for the communication widget

Providers can now define experiences for the minimized mode of the communication widgets they build. Agents can manually change the mode of the control from docked to minimized. The same can be achieved programmatically as well. 

More information: 
- [Modes and locations for the communication widget](v2/modes-communication-widget.md) 
- [setMode API](v2/reference/microsoft-ciframework/setMode.md)

### Support for multiple providers

With Dynamics 365 Channel Integration Framework version 2.0, organizations can configure multiple providers in the Omnichannel for Customer Service app. This enables agents to simultaneously work on multiple sessions catering to different customers on different channels (for example, live chat and telephony), where each of these sessions belongs to a different provider.  

More information: [Support for multiple providers](support-multiple-providers.md)

### Channel Analytics

The contact center analytics need operational and conversational data to provide historical and real-time insights into the performance of the contact center. To get precise insights into the call center performance, the analysts need data from the following sources 

- **CRM transactional data**: The data about the customers, their cases, their journey and all round relationship with the organizations. This is stored in Microsoft Dataverse 
- **Communication Data**: The data about the interactions (intended, ongoing and completed) with known and unknown customers 
- **Agent Behavior Data**: The data about the behavior of agents before, during and after the interactions. 

Channel Analytics in the Dynamics 365 Channel Integration Framework, provides a model to build a consistent, seamless, and unified experience when it comes to channel related analytics and insights.

More information: [Channel Analytics](channel-analytics.md).

> [!IMPORTANT]
> For the complete list of features introduced in Dynamics 365 Channel Integration Framework 2.0, see the 2019 release wave 2 plan here: [Dynamics 365 Channel Integration Framework](/dynamics365-release-plan/2019wave2/dynamics365-customer-service/channel-integration-framework-v2)

## What's new in Dynamics 365 Channel Integration Framework version 1.0

This section provides a list of new features introduced for Dynamics 365 Channel Integration Framework version 1.0.

### JavaScript Channel Integration Framework APIs

| JavaScript API | Description |
|-----|-----|
| [Microsoft.CIFramework.getEntityMetadata](reference/microsoft-ciframework/getEntityMetadata.md) | [!INCLUDE[getEntityMetadata-description](reference/microsoft-ciframework/includes/getEntityMetadata-description.md)] |
| [Microsoft.CIFramework.renderSearchPage](reference/microsoft-ciframework/renderSearchPage.md) | [!INCLUDE[renderSearchPage-description](reference/microsoft-ciframework/includes/renderSearchPage-description.md)] |

### Ability to pass Dynamics 365 URL to widget library

To access the Dynamics 365 Channel Integration Framework APIs, you need to load the `msdyn_cilibrary.js` file inside your communication widget. Since the widget is in a different domain, the JavaScript API library needs to identify the Dynamics 365 domain to interact. To enable the communication between the different domains, you must pass your Dynamics 365 instance URL to the widget library.

There are two ways to pass the URL to the widget library:

1. By adding attributes to a script tag.
2. By adding a parameter `ucilib` in the URL.

More information: [Pass a Dynamics 365 URL to a widget library](pass-url-widget-library.md)

### Ability to add another trusted domain

Dynamics 365 Channel Integration Framework allows you to add an additional trusted domain if the initial landing URL and the final domain from which the communication widget is hosted are different. 

More information: [Configure channel provider in Dynamics 365 Channel Integration Framework](configure-channel-provider-channel-integration-framework.md)

### Custom Parameters field in the Channel provider configuration

Custom Parameters field takes a text blob as input and [Microsoft.CIFramework.getEnvironment](reference/microsoft-ciframework/getEnvironment.md) returns this as a value of key `customParams`. 

More information: [Configure channel provider in Dynamics 365 Channel Integration Framework](configure-channel-provider-channel-integration-framework.md)

## See also

[Download Dynamics 365 Channel Integration Framework](https://go.microsoft.com/fwlink/p/?linkid=2050102)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]