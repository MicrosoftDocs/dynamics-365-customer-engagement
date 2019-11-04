---
title: "What is Dynamics 365 Channel Integration Framework? | Microsoft Docs"
description: "Learn what Dynamics 365 Channel Integration Framework is and how to get started using it."
keywords: ""
ms.date: 10/18/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: get-started-article
ms.assetid: e6d23c5f-e4ec-41f7-aff7-9cb50828357f
author: susikka
ms.author: susikka
manager: shujoshi
---

# What is Dynamics 365 Channel Integration Framework?

Dynamics 365 Channel Integration Framework is a cloud-to-cloud extensible framework to integrate third-party channel providers with Dynamics 365 Unified Interface apps using a browser-based JavaScript API library.

With this framework, you can integrate any third-party channel provider or channel aggregators into Unified Interface apps, where the Dynamics 365 Channel Integration Framework acts as an interface between the providers or aggregators and Unified Interface apps.

Technically, Dynamics 365 Channel Integration Framework is a set of APIs (methods, events, and protocols) that enable developers and partners to build immersive communication experiences such that third-party communication widgets running on a channel provider cloud can interact with Dynamics 365. 

With the Dynamics 365 Channel Integration Framework application (solution), you can configure the channel in the Unified Interface app so that your agents can access to serve your customers.

## Challenges of channel provider integration systems

Organizations expect their call centers to do more with fewer resources, and there is a constant drive to increase productivity in terms of call center agents handling more chats, phone calls, emails, and so on. Reducing the average time to handle customers can save companies millions of dollars. Channel providers (Computer Telephony Integration (CTI), messaging, and email systems) in call centers are one of the key indicators for success and customer satisfaction. In that context, some of the challenges the call center industry faces with the channel providers (CTI, messaging (SMS), and the email systems) are as follows:

  - Integrating third-party channel providers into the Customer Relationship Management (CRM) platforms.
  - Accessing and performing operations on the CRM from the CTI, messaging (SMS), and the email systems.
  - Developing and deploying CTI, messaging (SMS), and the email system needs writing adapters and complex custom codes for solution integration.
  - Using APIs and out-of-box customization, which are not supported for the production environment.
  - The dependency of channel providers (CTI, messaging (SMS), and the email systems) on the operating system and web browsers.
  - Customizing the channel provider (CTI, messaging (SMS), and the email systems) based on the business and process workflows.

## Advantages and value propositions of Dynamics 365 Channel Integration Framework

Dynamics 365 Channel Integration Framework version 2.0, provides multiple enhancements over version 1.0, particularly in terms of its ability to integrate with the latest multisession agent experiences for customer service. Following are the key new features in Dynamics 365 Channel Integration Framework version 2.0 over version 1.0: 

- **Integration with the multisession experiences** 

  Dynamics 365 Channel Integration Framework version 2.0 provides APIs to integrate with the multisession experiences in Omnichannel for Dynamics 365 Customer Service. These APIs allow providers to show notifications on incoming conversations with relevant information, start new sessions for conversations, and open application tabs as needed.

  More information: [Integration with multi-session experiences](integration-multi-session-experiences.md)

- **New modes and locations for the communication widget**

  Providers can now define experiences for the minimized mode of the communication widgets they build. Agents can manually change the mode of the control from docked to minimized. The same can be achieved programmatically as well. 

  More information: [New modes and locations for the communication widget](modes-communication-widget.md)

- **Support for multiple providers**

  With Dynamics 365 Channel Integration Framework version 2.0, organizations can configure multiple providers in Omnichannel for Customer Service. This enables agents to simultaneously work on multiple sessions catering to different customers on different channels (for example, live chat and telephony), where each of these sessions belongs to different providers.

  More information: [Support for multiple providers](support-multiple-providers.md)

Here are the capabilities offered by Dynamics 365 Channel Integration Framework version 1.0 that also apply to version 2.0:

- **Bring your own channel providers (integrate third-party channel providers)**

  Dynamics 365 Channel Integration Framework provides an extensible framework to integrate third-party cloud-based channel providers or channel aggregators with Dynamics 365 Unified Interface apps.

- **Channel agnostic**

  Dynamics 365 Channel Integration Framework is channel-agnostic. That is, you can build channels like voice, video, chat, co-browse, and social media as long as they have a JavaScript-based widget.

- **Two-way communication**

  The framework is extensible for the configuration of communication between the channel and Dynamics 365 Unified Interface apps. The two-way communication enables you to set the context of inbound or outbound according to your business and process workflows.

- **Standard and supported APIs**

  Dynamics 365 Channel Integration Framework exposes JavaScript APIs, which are the standard set of APIs that you can use for the communication between the channels and Dynamics 365 Unified Interface apps.

- **Ease of development and deployment**

  Seamless development, implementation, and deployment experience of your channels to suit your business context and process workflows.

- **Plug and play configuration**

  You can seamlessly integrate several providers by using the Dynamics 365 Channel Integration Framework administration configuration app.

- **Unified Interface app agnostic**

  Dynamics 365 Channel Integration Framework is Dynamics 365 Unified Interface app-agnostic. You can build the channel integration one time and enable it on the Unified Interface apps of your choice based on business requirements.

  > [!NOTE]
  > Multisession capabilities are only available for version 2.0.

- **Independent of operating systems and web browsers**

  Dynamics 365 Channel Integration Framework is web browser- and operating system-agnostic, and lets you integrate the cloud-based channels of your choice that are best for your organization's requirements.

  See the list of supported web browsers here: [Supported browsers](system-requirements-channel-integration-framework.md#supported-browsers)

- **Support for screen pop**

  You can configure screen pops to display customer information that can help agents start a conversation efficiently and effectively.

- **Customize agent experience**

  You can customize the channel programmatically or manually to provide an enhanced agent experience like maximizing, minimizing, show, hide, height, width, pop-out, and so on.

- **Upgrade to new versions**

  Seamless upgrade to new versions of third-party channel providers or channel aggregators as the Dynamics 365 Channel Integration Framework provides the infrastructure framework to integrate the channels but does not control the channel versions.

> [!div class="nextstepaction"]
> [Architecture overview of Channel Integration Framework](architecture-overview-channel-integration-framework.md)

## See also

[System requirements of Dynamics 365 Channel Integration Framework](system-requirements-channel-integration-framework.md)

[FAQs](faq-channel-integration-framework.md)

[Get Dynamics 365 Channel Integration Framework](get-channel-integration-framework.md)
