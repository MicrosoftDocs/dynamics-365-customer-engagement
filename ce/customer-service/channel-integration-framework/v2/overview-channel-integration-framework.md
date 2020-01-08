---
title: "What is Dynamics 365 Channel Integration Framework version 2.0 ? | Microsoft Docs"
description: "Learn what Dynamics 365 Channel Integration Framework version 2.0 is and how to get started using it."
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 12/31/2019
ms.topic: get-started-article
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# What is Dynamics 365 Channel Integration Framework version 2.0

Dynamics 365 Channel Integration Framework is a cloud-to-cloud extensible framework to integrate telephony channel with Dynamics 365 model-driven app using a browser-based JavaScript API library.

With this framework, you can integrate any telephony channel into Dynamics 365 model-driven app, where the Dynamics 365 Channel Integration Framework acts as an interface between the telephony and model-driven app.

Technically, Dynamics 365 Channel Integration Framework is a set of APIs (methods, events, and protocols) that enable developers and partners to build immersive communication experiences such that third-party telephony running on a channel provider cloud can interact with Dynamics 365 model-driven app. 

With the Dynamics 365 Channel Integration Framework application, you can configure the channel in the model-driven app so that your agents can access and serve your customers.

## Challenges of channel provider integration systems

Organizations expect their call centers to do more with fewer resources, and there is a constant drive to increase productivity in terms of call center agents handling more phone calls. Reducing the average time to handle customers can save companies millions of dollars. Telephony channel in call centers is one of the key indicators for success and customer satisfaction. In that context, some of the challenges the call center industry faces with the telephony are as follows:

  - Integrating third-party telephony channel into the Customer Relationship Management (CRM) platforms.
  - Accessing and performing operations on the CRM from the telephony widget area.
  - Developing and deploying telephony channel needs writing adapters and complex custom codes for solution integration.
  - Using APIs and out-of-box customization, which are not supported for the production environment.
  - The dependency of telephony channel on the operating system and web browsers.
  - Customizing the telephony channel based on the business and process workflows.

## Advantages and value propositions of Dynamics 365 Channel Integration Framework

Dynamics 365 Channel Integration Framework version 2.0, provides multiple enhancements over version 1.0, particularly in terms of its ability to integrate with the latest multi-session agent experiences for customer service. Following are the key new features in Dynamics 365 Channel Integration Framework version 2.0: 

- **Integration with the multi-session experiences** 

  Dynamics 365 Channel Integration Framework version 2.0 provides APIs to integrate your telephony channel with the multi-session web experiences (Omnichannel for Dynamics 365 Customer Service). These APIs allow telephony channel to show notifications on incoming conversations with relevant information, start new sessions for conversations, and open application tabs as needed.

  More information: [Integration with multi-session experiences](integration-multi-session-experiences.md)

- **New modes and locations for the communication widget**

  Telephony channel provider can now define experiences for the minimized mode of the communication widgets they build. Agents can manually change the mode of the control from docked to minimized. The same can be achieved programmatically as well. 

  More information: [New modes and locations for the communication widget](v2/modes-communication-widget.md)

- **Support for multiple providers**

  With Dynamics 365 Channel Integration Framework version 2.0, organizations can configure multiple telephony channel provider. This enables agents to simultaneously work on multiple sessions catering to different customers on different channels, where each of these sessions belongs to different telephony channel providers.

  More information: [Support for multiple providers](support-multiple-providers.md)

Here are the other capabilities offered by Dynamics 365 Channel Integration Framework:

- **Bring your own telephony channel providers (integrate third-party telephony channel providers)**

  Dynamics 365 Channel Integration Framework provides an extensible framework to integrate third-party cloud-based telephony channel providers with Dynamics 365 model-driven app.

- **Two-way communication**

  The framework is extensible for the configuration of communication between the telephony channel and Dynamics 365 model-driven app. The two-way communication enables you to set the context of inbound or outbound according to your business and process workflows.

- **Standard and supported APIs**

  Dynamics 365 Channel Integration Framework exposes JavaScript APIs, which are the standard set of APIs that you can use for the communication between the telephony channel and Dynamics 365 model-driven app.

- **Ease of development and deployment**

  Seamless development, implementation, and deployment experience of your channels to suit your business context and process workflows.

- **Plug and play configuration**

  You can seamlessly integrate several providers by using the Dynamics 365 Channel Integration Framework administration configuration app.

- **Model-driven app agnostic**

  Dynamics 365 Channel Integration Framework is Dynamics 365 model-driven app-agnostic. You can build the telephony channel once and enable it on the model-driven app of your choice based on the business requirements.

- **Independent of operating systems and web browsers**

  Dynamics 365 Channel Integration Framework is web browser- and operating system-agnostic, and lets you integrate the cloud-based channels of your choice that are best for your organization's requirements.

  See the list of supported web browsers here: [Supported browsers](../system-requirements-channel-integration-framework.md#supported-browsers)

- **Support for screen pop**

  You can configure screen pops to display customer information that can help agents start a conversation efficiently and effectively.

- **Customize agent experience**

  You can customize the channel programmatically or manually to provide an enhanced agent experience like maximizing, minimizing, show, hide, height, width, pop-out, and so on.

- **Upgrade to new versions**

  Seamless upgrade to new versions of third-party channel providers or channel aggregators as the Dynamics 365 Channel Integration Framework provides the infrastructure framework to integrate the channels but does not control the channel versions.

## See also

[Architecture overview of Channel Integration Framework](architecture-overview-channel-integration-framework-v2.md)

[System requirements of Dynamics 365 Channel Integration Framework](../system-requirements-channel-integration-framework.md)

[FAQs](../faq-channel-integration-framework.md)

[Get Dynamics 365 Channel Integration Framework](get-channel-integration-framework.md)