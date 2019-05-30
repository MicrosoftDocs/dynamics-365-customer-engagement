---
title: "What is Dynamics 365 Channel Integration Framework (CIF) | Microsoft Docs"
description: "Learn what is Channel Integration Framework (CIF) for Microsoft Dynamics 365 and how to get started using it."
keywords: ""
ms.date: 12/10/2018
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: get-started-article
applies_to:
  - "Dynamics 365 for Customer Engagement (online)"
  - "Dynamics 365 for Customer Engagement Version 9.x"
ms.assetid: e6d23c5f-e4ec-41f7-aff7-9cb50828357f
author: susikka
ms.author: susikka
manager: shujoshi
---

# What is Channel Integration Framework for Microsoft Dynamics 365

Dynamics 365 Channel Integration Framework is a cloud-to-cloud extensible framework to integrate third-party channel providers with Dynamics 365 Unified Interface Apps using a browser-based JavaScript API library.

With this framework, you can integrate any third-party channel provider or channel aggregators into Unified Interface Apps, where the Channel Integration Framework acts as an interface between the providers or aggregators and Unified Interface Apps.

Technically, Channel Integration Framework is a set of APIs (methods, events, and protocols) that enable developers and partners to build immersive communication experiences such that third party communication widgets running on channel provider cloud can interact with Dynamics 365. 

With the Channel Integration Framework application (solution), you can configure the channel in the Unified Interface app such that your agents can access to serve your customers.

## Challenges of channel provider integration systems

Organizations expect their call centers to do more with fewer resources, and there is a constant drive to increase productivity in terms of call center agents handling more chats, phone calls, emails, and so on. Reducing the average time to handle customers can save companies millions of dollars. Channel providers (Computer Telephony Integration (CTI), messaging, and email systems) in call centers are one of the key indicators for the success and customer satisfaction. On that context, some of the challenges that call center industry faces with the channel providers (CTI, messaging (SMS), and the email systems) are as follows:

  - Integrating third-party channel providers into the Customer Relationship Management (CRM) platforms.
  - Accessing and performing operations on the CRM from the CTI, messaging (SMS), and the email systems.
  - Developing and deploying CTI, messaging (SMS), and the email system needs writing adapters and complex custom codes for solution integration.
  - Using APIs and out-of-box customization which are not supported for the production environment.
  - Channel providers (CTI, messaging (SMS), and the email systems) dependency on the operating system and web browsers.
  - Customizing the channel provider (CTI, messaging (SMS), and the email systems) based on the business and process workflows.

## Advantages and value propositions of Channel Integration Framework

The value propositions of Channel Integration Framework are:

**Bring your own channel providers (Integrate third-party channel providers):**

The Channel Integration Framework provides an extensible framework to integrate third-party cloud-based channel providers or channel aggregators with Dynamics 365 Unified Interface Apps.

**Channel agnostic:**
The Channel Integration Framework is channel agnostic. That is, you can build channels like voice, video, chat, co-browse, social media, and any channels as long as they a JavaScript based widget.

**Two-way communication:**

The framework is extensible for the configuration of communication between the channel and Dynamics 365 Unified Interface Apps. The two-way communication enables to set the context of inbound and/or outbound according to your business and process workflows.

**Standard and supported APIs:**

The Channel Integration Framework exposes a JavaScript APIs which are the standard set of APIs that you can consume for the communication between the channels and Dynamics 365 Unified Interface Apps.

**Ease of development and deployment:**

Seamless development, implementation, and deployment experience of your channels to suit your business context and process workflows.

**Plug and play configuration:**

You can seamlessly integrate several providers by using the Channel Integration Framework administration configuration App.

**Unified Interface App agnostic:**

The Channel Integration Framework is Dynamics 365 Unified Interface App agnostic. You can build the channel integration one-time and enable it on the Unified Interface Apps of your choice based on the business requirements.

**Independent of operating systems and web browsers:**

The Channel Integration Framework is web browser and operating system agnostic, and lets you integrate the cloud-based channels of your choice that is best for your organization's requirement.

**Support for Screen pop:**

You can configure screen pops to display the customer information that can aid the agents to start the conversation efficiently and effectively.

**Customize agent experience:**

You can customize the channel programmatically or manually to provide enhanced agent experience like maximizing, minimizing, show, hide, height, width, pop-out and so on.

**Upgrade to new versions:**

Seamless upgrade to new versions of third-party channel providers or channel aggregators as the Channel Integration Framework provides the infrastructure framework to integrate the channels but does not control the channel versions.

> [!div class="nextstepaction"]
> [Architecture overview of Channel Integration Framework](architecture-overview-channel-integration-framework.md)

## See also

[System requirements of Channel Integration Framework](system-requirements-channel-integration-framework.md)

[FAQs](faq-channel-integration-framework.md)

[Get Channel Integration Framework (CIF)](get-channel-integration-framework.md)