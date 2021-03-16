---
title: "What is Dynamics 365 Channel Integration Framework version 1.0? | Microsoft Docs"
description: "Learn what Dynamics 365 Channel Integration Framework version 1.0 is and how to get started using it."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 06/18/2020
ms.topic: get-started-article
ms.service: dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# What is Dynamics 365 Channel Integration Framework version 1.0

Dynamics 365 Channel Integration Framework is a cloud-to-cloud extensible framework to integrate third-party channel providers with Dynamics 365 model-driven apps using a browser-based JavaScript API library.

With this framework, you can integrate any third-party telephony provider or telephony aggregators into a model-driven app, where the Dynamics 365 Channel Integration Framework acts as an interface between the providers or aggregators and a model-driven app.

The Dynamics 365 Channel Integration Framework is a set of APIs (methods, events, and protocols) that enable developers and partners to build immersive communication experiences such that third-party communication widgets running on a channel provider cloud can interact with the Dynamics 365 model-driven app. 

With the Dynamics 365 Channel Integration Framework application (solution), you can configure the channel in the model-driven app so that your agents can access and serve your customers.

## Challenges of channel provider integration systems

Organizations expect their call centers to do more with fewer resources, and there is a constant drive to increase productivity in terms of call center agents handling more chats, phone calls, emails, and so on. Reducing the average time to handle customers can save companies millions of dollars. Telephony providers in call centers are one of the key indicators for success and customer satisfaction. In that context, some of the challenges the call center industry faces with the telephony providers are as follows:

  - Integrating third-party telephony providers into the Customer Relationship Management (CRM) platforms.
  - Accessing and performing operations on the model-driven app from the telephony.
  - Developing and deploying telephony needs writing adapters and complex custom codes for solution integration.
  - Using APIs and out-of-box customization, which are not supported for the production environment.
  - The dependency of telephony providers on the operating system and web browsers.
  - Customizing the telephony provider based on the business and process workflows.

## Advantages and value propositions of the Dynamics 365 Channel Integration Framework

Here are the capabilities offered by Dynamics 365 Channel Integration Framework version 1.0:

- **Two-way communication**

  The framework is extensible for the configuration of communication between the channel and Dynamics 365 model-driven app. The two-way communication enables you to set the context of inbound or outbound according to your business and process workflows.

- **Standard and supported APIs**

  Dynamics 365 Channel Integration Framework exposes JavaScript APIs, which are the standard set of APIs that you can use for the communication between the channels and Dynamics 365 model-driven app.

- **Ease of development and deployment**

  Seamless development, implementation, and deployment experience of your channels to suit your business context and process workflows.

- **Plug and play configuration**

  You can seamlessly integrate several providers by using the Dynamics 365 Channel Integration Framework administration configuration app.

- **Model-driven app agnostic**

  Dynamics 365 Channel Integration Framework is Dynamics 365 model-driven app-agnostic. You can build the channel once and enable it on the model-driven app of your choice based on business requirements.

- **Independent of operating systems and web browsers**

  Dynamics 365 Channel Integration Framework is web browser- and operating system-agnostic, and lets you integrate the cloud-based channels of your choice that are best for your organization's requirements.

  See the list of supported web browsers here: [Supported browsers](system-requirements-channel-integration-framework.md#supported-browsers)

- **Support for screen pop**

  You can configure screen pops to display customer information that can help agents start a conversation efficiently and effectively.

- **Customize agent experience**

  You can customize the channel programmatically or manually to provide an enhanced agent experience like maximizing, minimizing, show, hide, height, width, pop-out, and so on.

- **Upgrade to new versions**

  Seamless upgrade to new versions of third-party channel providers or channel aggregators as the Dynamics 365 Channel Integration Framework provides the infrastructure framework to integrate the channels but does not control the channel versions.

## See also

[Architecture overview of Channel Integration Framework](architecture-overview-channel-integration-framework.md)

[System requirements of Dynamics 365 Channel Integration Framework](system-requirements-channel-integration-framework.md)

[FAQs](faq-channel-integration-framework.md)

[Get Dynamics 365 Channel Integration Framework](get-channel-integration-framework.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]