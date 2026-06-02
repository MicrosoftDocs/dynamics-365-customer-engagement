---
title: Dynamics 365 Channel Integration Framework 2.0
description: Learn how Dynamics 365 Channel Integration Framework 2.0 integrates telephony providers with model-driven apps in multisession experiences.
ms.date: 06/02/2026
ms.topic: overview
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# What is Dynamics 365 Channel Integration Framework 2.0?

Dynamics 365 Channel Integration Framework is a cloud-based framework that integrates telephony channel providers with model-driven apps in Dynamics 365. The framework uses a browser-based JavaScript API library. With this framework, you can integrate telephony channels into a model-driven app in Dynamics 365, and the framework acts as the interface between the channel and the app.

Dynamics 365 Channel Integration Framework provides a set of APIs that include methods, events, and protocols. These APIs help developers and partners build communication experiences. They also allow non-Microsoft telephony systems running on a channel provider cloud to interact with model-driven apps in Dynamics 365.

With the Dynamics 365 Channel Integration Framework app, you can configure a channel in a model-driven app. Customer service representatives (service representatives or representatives) can then access the channel and serve customers.

## Challenges of channel provider integration systems

Organizations expect their call centers to do more while using fewer resources. There's a constant drive to increase productivity by having call center service representatives handle more phone calls. Reducing the average time to handle customer calls can save companies millions of dollars. A telephony channel in a call center is one of the key indicators for success and customer satisfaction. Some of the challenges the call center industry faces with telephony channels include:

-  Integrating non-Microsoft telephony channels into their customer relationship management (CRM) platform.
-  Accessing and performing operations on the CRM platform from the telephony widget area.
-  Developing and deploying the telephony channel, which requires writing adapters and complex custom code for solution integration.
-  Using APIs and out-of-the-box customizations that aren't supported for the production environment.
-  The dependency of the telephony channel on the operating system and web browsers.
-  Customizing the telephony channel based on business needs and process workflows.

## Advantages and value propositions of Dynamics 365 Channel Integration Framework 2.0

> [!NOTE]
> Dynamics 365 Channel Integration Framework 2.0 is designed for integrating telephony channel providers. It works within multisession experiences such as Omnichannel for Customer Service and Copilot Service workspace.

Dynamics 365 Channel Integration Framework 2.0, provides multiple enhancements over Channel Integration Framework 1.0, particularly in its ability to integrate with the latest multisession agent experiences for customer service.

Key new features in Dynamics 365 Channel Integration Framework 2.0 include: 

- **Integration with multisession apps**

  Dynamics 365 Channel Integration Framework 2.0 provides APIs to integrate your telephony channel with multisession web experiences (Omnichannel for Customer Service and Copilot Service workspace). These APIs allow the telephony channel to show notifications on incoming conversations with relevant information, start new sessions for conversations, and open application tabs as needed.

  More information: [Integration with multisession experiences](integration-multi-session-experiences.md)

- **New modes and locations for the communication widget**

  Telephony channel providers can now define experiences for the minimized mode of the communication widgets they build. Service representatives can manually change the mode of the control from docked to minimized. The same can also be achieved programmatically.

  More information: [New modes and locations for the communication widget](modes-communication-widget.md)

- **Support for multiple providers**

  With Dynamics 365 Channel Integration Framework 2.0, organizations can configure multiple telephony channels. This capability enables service representatives to simultaneously work on multiple sessions that cater to different customers across channels, where each session belongs to a different telephony channel provider. The service representative can perform all the interactions on these channels from a familiar conversation control.

  Learn more in [Support for multiple providers](support-multiple-providers.md).

  
Other capabilities offered by Dynamics 365 Channel Integration Framework include:

- **Bring-your-own telephony channel providers**

  Dynamics 365 Channel Integration Framework lets you integrate non-Microsoft, cloud-based telephony channels with model-driven apps in Dynamics 365. You can use providers that you develop internally or that serve specific regions or local markets.

- **Two-way communication**

  The framework is extensible for the configuration of communication between the telephony channel and model-driven apps in Dynamics 365. The two-way communication enables you to set the context of inbound or outbound, according to your business needs and process workflows.

- **Standard and supported APIs**

  Dynamics 365 Channel Integration Framework exposes JavaScript APIs, which are the standard set of APIs that you can use for the communication between the telephony channel and model-driven apps in Dynamics 365.

- **Ease of development and deployment**

  The seamless development, implementation, and deployment experience of your channels helps you easily meet the needs of your business context and process workflows.

- **Plug-and-play configuration**

  You can seamlessly integrate several providers by using the Dynamics 365 Channel Integration Framework administration configuration app.

- **Independent of operating systems and web browsers**

  Dynamics 365 Channel Integration Framework is agnostic to web browsers and operating systems, and lets you integrate the cloud-based channels that are best for your organization's requirements.

  See the list of supported web browsers here: [Supported browsers](../../v1/administer/system-requirements-channel-integration-framework.md#supported-browsers)

- **Support for screen pop**

  You can configure screen pop to display customer information that can help service representatives start a conversation efficiently and effectively.

- **Customizable representative experience**

  - You can customize the custom channel to provide an enhanced service representative experience with capabilities to maximize, minimize, show, hide, pop out windows, or change the window height or width.
  - Service representatives can configure to use productivity tools with multiple sessions. They can create new scripts or reuse the existing ones.

- **Upgrading to new versions**

  You can upgrade to new versions of non-Microsoft channel providers or channel aggregators. Dynamics 365 Channel Integration Framework provides the infrastructure for integration, but it doesn't control channel versions.

### Related information

[Architecture of Dynamics 365 Channel Integration Framework 2.0](architecture-overview-channel-integration-framework-v2.md)  
[System requirements of Dynamics 365 Channel Integration Framework 2.0](system-requirements-channel-integration-framework-v2.md)  
[FAQ about Dynamics 365 Channel Integration Framework](../../faq-channel-integration-framework.md)  
[Get Dynamics 365 Channel Integration Framework 2.0](../../v1/administer/get-channel-integration-framework.md)  
[Support multiple channel providers](support-multiple-providers.md)  
[Bring your own channel](../../../customer-service/develop/bring-your-own-channel.md)  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
