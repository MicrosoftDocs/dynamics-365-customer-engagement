---
title: "Customer Service Overview (Dynamics 365 Customer Service) | MicrosoftDocs"
description: "Overview of Dynamics 365 Customer Service"
ms.date: 04/05/2023
ms.topic: overview
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.custom: 
  - dyn365-customerservice
  - intro-internal
---

# Overview of Dynamics 365 Customer Service

[!INCLUDE[cc-trial-sign-up](../includes/cc-trial-sign-up.md)]

Welcome to Dynamics 365 Customer Service! We are delighted to offer you a suite of capabilities to ensure your business can deliver the best customer service experience possible to your customers. We believe that knowing your customers enables you to personalize each experience and optimizes your agents' productivity so you can earn customers for life. 

The agent experience is the heart of Dynamics 365 Customer Service. The key to improving satisfaction in service delivery is enabling agents to take customer requests from any channel, handle multiple sessions at a time, interact with multiple apps without losing context, and enhance their workflow with productivity tools.  

We offer several app experiences for you to choose from, depending on your support organization’s needs.

Use Customer Service to:

- Track customer issues through cases
- Record all interactions related to a case
- Share information in the knowledge base
- Use unified routing to efficiently route work items
- Manage conversations across channels, including voice
- Use AI-driven embedded insights and analytics to improve customer satisfaction
- Collaborate with experts in Microsoft Teams
- Create and track service levels through service-level agreements (SLAs)
- Define service terms through entitlements
- Manage performance and productivity through reports and dashboards
- Create and schedule services
- Participate in chats

## Administer Customer Service

[!INCLUDE[cc-oc-admin-csh-deprecation.md](../includes/cc-oc-admin-csh-deprecation.md)]

You can configure and manage the different capabilities in Customer Service by using any of the following apps based on the licensing module that you've purchased. While you can use any of the admin apps to set up the features in Customer Service, we recommend that you use the latest apps and centrally manage the features in a robust framework.

- **Customer Service admin center**: Helps in managing the different features of Customer Service in one place. You can configure all the features of the customer support, operations, and agent experiences through the new app. You can manage core customer service and other features, such as service terms, service scheduling, and all the channels in Omnichannel for Customer Service. More information: [Customer Service admin center at a glance](cs-admin-center.md)

- **Omnichannel admin center**: Helps in managing all your chat and digital messaging channels, including the voice channel. You can configure enterprise-grade routing and assignment capability by using the unified routing infrastructure to route service requests on all channels. More information: [Omnichannel admin center at a glance](oc-admin-center.md)

- **Customer Service Hub**: Helps in managing knowledge articles and routing of cases and is available for use on desktop browsers and mobile devices. Use the **Service Management** site map to set up features, such as case management, queues, routing rules, service terms, insights, and service scheduling. More information: [Get started with Customer Service Hub](customer-service-hub-user-guide-basics.md)

- **App profile manager**: Helps in creating and managing targeted app experiences for agents and supervisors as an alternative to building and maintaining custom apps. You can create custom profiles with specific session templates, conversation channels, and productivity tools. You can then assign these profiles to agents and supervisors who use the Customer Service workspace and Omnichannel for Customer Service apps. More information: [Introduction to the app profile manager](../app-profile-manager/overview.md)

  > [!NOTE]
  > The capabilities offered by the app profile manager are also available in the new Customer Service admin center app. We recommend that you use the new app.

- **Omnichannel Administration**: Helps in setting up and managing the chat and digital messaging channels and other features in Omnichannel for Customer Service. More information: [Omnichannel Administration](omnichannel-administrator.md)
  
  > [!NOTE]
  > Support for the Omnichannel Administration app ended on April 30, 2022. We recommend that you use the Omnichannel admin center or Customer Service admin center app to configure the latest features, such as unified routing and voice channel. For more information about the deprecation announcement, see [Omnichannel Administration app is deprecated](../customer-service/deprecations-customer-service.md#omnichannel-administration-app-is-deprecated).

The following table provides the features that can be configured through the admin apps.

| Feature| Customer Service admin center | Omnichannel admin center |Customer Service Hub -> Service Management |
|--------|-------------------------------|--------------------------|-------------------------------------------|
| Basic administration for Customer service| ✔ | ✖ | ✔ |
| Case routing and queue configuration | ✔ | ✔ |✔|
| Service-level agreements|✔|✖|✔|
| Service scheduling|✔|✖|✔|
| Live chat, social channels, Microsoft Teams, SMS| ✔ | ✔ |✖|
| Agent experience profiles |✔ | ✖| ✖ |
| Unified routing |✔|✔|✔|
| Voice channel |✔|✔|✖|
| Knowledge management|✔|✖|✔|
| Insights, analytics, and dashboards|✔|✔|✔|
| Productivity tools |✔|✔|✖|


**Legend**

✔: Generally available.

✖: Not available

## Use agent apps to service customers

The following capabilities are available in the different app experiences, depending on your needs. In the following table, select the app of your choice to read more about the details of the user experience in each app.

|  Features | [Customer Service workspace](csw-overview.md) | [Omnichannel for Customer Service](./introduction-omnichannel.md) | [Customer Service Hub](user-guide-customer-service-hub.md) | [Customer Service Team Member](customer-service-team-member.md) | [Customer Service app (Deprecated)](user-guide-customer-service.md) |
|---------------------------------------------------------------------|------------|------------|------------|------------|------------|
| Multisession          | ✔ | ✔ | ✖ | ✖ | ✖ |
| Case management  | ✔ |  ✔  |  ✔  |  ✔  |  ✔  |
| Conversations (with Chat or Digital Messaging Offers)  | ✔ | ✔ |✖  | ✖ |✖  |
| Channels (with Digital Messaging Offer)  | ✔ | ✔ |✖  | ✖ |✖  |
|Voice channel (with Voice Channel for Dynamics 365 Customer Service)| ✔ | ✔ |✖  | ✖ |✖  |
| Knowledge management  |  ✔  |  ✔  |✔| Read only | ✔ |
| Insights, analytics, and dashboards | ✔ | ✔| ✔ | ✖ | ✖ |
| Service scheduling  | ✔ | Not applicable | ✔ | ✖ | ✔ |
| Connected Service with IoT  |✔  | ✖ | ✔  | ✖ |✖  |
| Extensibility  | ✔ with Channel Integration Framework version 2.0, custom messaging channel | ✔ with Channel Integration Framework version 2.0, custom messaging channel, Mobile SDK | ✔ with Channel Integration Framework version 1.0 | ✖ | ✖ |
| Unified Interface compliant  | ✔ | ✔ | ✔ | ✔ |✖  |

**Legend**

✔: Generally available.

✖: Not available

## Available anywhere, on any device

> [!NOTE]
> For mobile devices, you can install the applicable app for your device. For more information, see [Install Dynamics 365 for phones and tablets](../mobile-app/Install-Dynamics-365-for-phones-and-tablets.md).

If you're using a desktop browser, you'll see the various Customer Service apps in the app switcher as shown here.

![open-sitemap.](media/open-csh-sitemap-overview.png "Customer Service Hub sitemap")

If you're using a mobile device with Dynamics 365 for phones and tablets installed, you'll see the app tiles in the app switcher as shown here.

![csh-mobile.](media/ChooseAnApp_1.png "Customer Service Hub on mobile")

> [!NOTE]
> Looking forward to upgrade to the Customer Service Workspace or Customer Service Hub app? See [Upgrade to Customer Service Hub](upgrade-ish-csh.md)

> [!NOTE]
> If you have previously installed any portal solution, to create a case in the Customer Service Hub or to use the Merge cases command, you must turn off the **Read-only in mobile** option for the Case entity. More information: [Turn off Read-only in mobile option](../customerengagement/on-premises/customize/edit-entities.md#enable-or-disable-entity-options).

## Accessibility and GDPR in the Customer Service Apps

Customer Service is committed to inclusive design and accessible content. The apps are designed around accessibility to help all users be effortlessly productive.

For more details about app accessibility and GDPR compliance, see [Accessibility and GDPR](user-guide-customer-service-hub.md#accessibility-and-gdpr).

## Get Started with Customer Service

- [Customer Service Workspace](customer-service-workspace-system-requirements.md)
- [Omnichannel for Customer Service](./introduction-omnichannel.md)
- [Customer Service Hub](user-guide-customer-service-hub.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
