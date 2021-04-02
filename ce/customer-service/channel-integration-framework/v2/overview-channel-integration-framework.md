---
title: "What is Dynamics 365 Channel Integration Framework version 2.0? | Microsoft Docs"
description: "Learn what Dynamics 365 Channel Integration Framework version 2.0 is and how to get started using it."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 11/02/2020
ms.topic: get-started-article
ms.service: dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# What is Dynamics 365 Channel Integration Framework version 2.0?

Dynamics 365 Channel Integration Framework is a cloud-to-cloud extensible framework for integrating telephony channels with model-driven apps in Dynamics 365 by using a browser-based JavaScript API library. With this framework, you can integrate any telephony channel into a model-driven app in Dynamics 365, and the framework will act as the interface between the channel and the app.

Technically, Dynamics 365 Channel Integration Framework is a set of APIs (methods, events, and protocols) that enable developers and partners to build immersive communication experiences so that third-party telephony running on a channel provider cloud can interact with model-driven apps in Dynamics 365. 

With the Dynamics 365 Channel Integration Framework app, you can configure the channel in the model-driven app so that your agents can access and serve your customers.

## Challenges of channel provider integration systems

Organizations expect their call centers to do more while using fewer resources. There's a constant drive to increase productivity by having call center agents handle more phone calls. Reducing the average time to handle customer calls can save companies millions of dollars. A telephony channel in a call center is one of the key indicators for success and customer satisfaction. Some of the challenges the call center industry faces with telephony channels include:

-  Integrating third-party telephony channels into their customer relationship management (CRM) platform.
-  Accessing and performing operations on the CRM platform from the telephony widget area.
-  Developing and deploying the telephony channel, which requires writing adapters and complex custom code for solution integration.
-  Using APIs and out-of-the-box customizations that aren't supported for the production environment.
-  The dependency of the telephony channel on the operating system and web browsers.
-  Customizing the telephony channel based on business needs and process workflows.

## Advantages and value propositions of Dynamics 365 Channel Integration Framework

> [!NOTE]
> Dynamics 365 Channel Integration Framework version 2.0 supports only telephony channels.

Dynamics 365 Channel Integration Framework version 2.0, provides multiple enhancements over version 1.0, particularly in its ability to integrate with the latest multisession agent experiences for customer service.

Key new features in Dynamics 365 Channel Integration Framework version 2.0 include: 

- **Integration with the multisession experiences**

  Dynamics 365 Channel Integration Framework version 2.0 provides APIs to integrate your telephony channel with multisession web experiences (Omnichannel for Customer Service and Customer Service workspace. These APIs allow the telephony channel to show notifications on incoming conversations with relevant information, start new sessions for conversations, and open application tabs as needed.

  More information: [Integration with multisession experiences](integration-multi-session-experiences.md)

- **New modes and locations for the communication widget**

  Telephony channel providers can now define experiences for the minimized mode of the communication widgets they build. Agents can manually change the mode of the control from docked to minimized. The same can also be achieved programmatically.

  More information: [New modes and locations for the communication widget](modes-communication-widget.md)

- **Support for multiple providers**

  With Dynamics 365 Channel Integration Framework version 2.0, organizations can configure multiple telephony channels. This enables agents to simultaneously work on multiple sessions catering to different customers on different channels, where each of these sessions belongs to different telephony channel providers. The agent can perform all the interactions on these channels from a familiar conversation control.

  More information: [Support for multiple providers](support-multiple-providers.md).

  
Additional capabilities offered by Dynamics 365 Channel Integration Framework include:

- **Bring-your-own telephony channel providers**

  Dynamics 365 Channel Integration Framework provides an extensible framework to integrate third-party cloud-based telephony channels, including the ones that have been developed internally or are hyperlocal, with model-driven apps in Dynamics 365.

- **Two-way communication**

  The framework is extensible for the configuration of communication between the telephony channel and model-driven apps in Dynamics 365. The two-way communication enables you to set the context of inbound or outbound, according to your business needs and process workflows.

- **Standard and supported APIs**

  Dynamics 365 Channel Integration Framework exposes JavaScript APIs, which are the standard set of APIs that you can use for the communication between the telephony channel and model-driven apps in Dynamics 365.

- **Ease of development and deployment**

  The seamless development, implementation, and deployment experience of your channels helps you easily meet the needs of your business context and process workflows.

- **Plug-and-play configuration**

  You can seamlessly integrate several providers by using the Dynamics 365 Channel Integration Framework administration configuration app.

- **Independent of operating systems and web browsers**

  Dynamics 365 Channel Integration Framework is web browser agnostic and operating system agnostic, and lets you integrate the cloud-based channels that are best for your organization's requirements.

  See the list of supported web browsers here: [Supported browsers](../system-requirements-channel-integration-framework.md#supported-browsers)

- **Support for screen pop**

  You can configure screen pop to display customer information that can help agents start a conversation efficiently and effectively.

- **Customizable agent experience**

  - You can customize the custom channel to provide an enhanced agent experience with capabilities like maximize, minimize, show, hide, height, width, and pop-out windows.
  - Agents can configure to use productivity tools with multiple sessions. They can create new scripts or reuse the existing ones.

- **Upgrading to new versions**

  You can seamlessly upgrade to new versions of third-party channel providers or channel aggregators because the Dynamics 365 Channel Integration Framework provides the infrastructure framework to integrate the channels, but it doesn't control the channel versions.

### See also

[Architecture overview of Dynamics 365 Channel Integration Framework](architecture-overview-channel-integration-framework-v2.md)

[System requirements of Dynamics 365 Channel Integration Framework](../system-requirements-channel-integration-framework.md)

[FAQ](../faq-channel-integration-framework.md)

[Get Dynamics 365 Channel Integration Framework](get-channel-integration-framework.md)

[Support multiple providers](support-multiple-providers.md)

[Bring your own channel](../../../omnichannel/developer/how-to/bring-your-own-channel.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]