---
title: Copilot Service admin center in Customer Service
description: Get started with Copilot Service admin center to configure the various features and settings in Customer Service.
ms.date: 04/21/2026
ms.topic: concept-article
ms.collection: get-started
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
---

# Get started with Copilot Service admin center

Welcome to Copilot Service admin center, the app that unifies and simplifies administration experience across the Customer Service suite.

Use the Copilot Service admin center to configure Customer Service features, such as cases, queues, knowledge articles, channels, unified routing, and agent experience profiles.

The features include:  

- Step-by-step guided experience for setting up a channel.

- Search option to easily find the administrator settings for the various features in the app.

- Task-oriented site map.

- Overview pages for each area that list at-a-glance information with deep links to manage features.

- Landing pages per feature with an overview of all the capabilities.

- The site map adapts to the capabilities that are provisioned. Based in core Customer Service, if Dynamics 365 Contact Center is provisioned, then other features are automatically available.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=1a9dd7f8-3c00-46c9-bda3-b567b5651f71]


## Copilot agent management

The Copilot Service admin center is where administrators configure Copilot for Dynamics 365 Customer Service, including agent capabilities and extensibility settings.

Administrators use the app to:
- Enable and configure Copilot features
- Manage agent capabilities and extensibility
- Control access based on user roles

Copilot agents help customer service representatives retrieve information, summarize data, and take action during customer service work. Administrators can extend these capabilities by configuring knowledge sources, tools, and other extensibility options.

## Prerequisites

One or more of the following security roles to access this app to perform the various configuration tasks:

- **System Administrator**: To access and edit all the site map entries.

- **System Customizer**: To access and edit all the site map entries.

- **CSR Manager**: To access the entities like queues for the email record, automatic record creation and update rules, and workstreams in Customer Service.

- **App Profile Manager administrator and Basic User**: To access the app and edit app profile-related entities.

- **Omnichannel administrator and Basic User**: To access the app and edit all the omnichannel-related entities, like chat and voice and queues, and workstreams.

Also, to create a shared mailbox, you need the Microsoft 365 tenant admin privileges.

If you use custom roles, you must make sure that you have the appropriate permissions corresponding to the feature you want to configure.

More information: [Assign roles and enable users for Dynamics 365 Contact Center](add-users-assign-roles.md)

## Access the app

The app is automatically installed in all the Customer Service organizations. You can sign in to Dynamics 365, and on the apps page, select Copilot Service admin center.

## Create your contact center

On the **Home** page, use the **Create your contact center** wizard to set up a new contact center with one click. When you select **Create**, the wizard automatically sets up the live chat and voice channels, a default agent experience profile, and the recommended AI features and reports. After the setup is complete, the summary page displays the channels and features that you can try. You can also customize the settings by following the bubble tour, which requires the Omnichannel administrator and Omnichannel agent roles.

:::image type="content" source="../media/create-contact-center.png" alt-text="Use create contact center to set up a contact center in one click.":::

> [!NOTE]
> The create your contact center feature is available for new organizations only.

## Guided channel setup

You can use the guided channel setup wizard to configure channels, such as a channel for routing cases. The wizard helps you create the channel, configure users and permissions, and set up routing rules to get you started with handling customer issues with minimal setup.

:::image type="content" source="../media/guided-channel-setup.png" alt-text="A screenshot of guided channel setup showing the channel types that can be set using guided setup.":::

> [!IMPORTANT]
> To successfully create a guided setup for each channel, you must have full privileges to all the tables used in the setup.

## Navigate the site map in Copilot Service admin center

The Customer Service features are organized in the site map as follows. Every group contains an overview page with deep links to the features within the area.

> [!NOTE]
> The options that appear on the site map are dependent on the features that you provisioned.

The overview page for every group lists a summary of the objects that are available for each feature. For example, the number of users who are available, and channels and queues that are configured in the organization.

You can manage the following features in **Customer support**:

- **User management**: Users, their skills, capacity profiles, and role persona mapping
- **Channels**: Channels, such as record, chat, and voice, and the messaging accounts and phone numbers.
- **Queues**: Manage basic and advanced queues.
- **Routing**: Settings, such as enable unified routing, configure record routing, routing diagnostics, and machine learning models for skill-based, effort-based, and sentiment-based routing.
- **Workstreams**: Workstreams for the different channels.
- **Case settings**: Subjects, automatic record creation rules, advanced similarity rules, parent-child case settings, and case resolution dialog.
- **Customer settings**: Blocked numbers, authentication settings, geo location, phone music, outbound messaging and automate messages.

  :::image type="content" source="../media/customer-support-overview.png" alt-text="Overview page of Customer support in Copilot Service admin center.":::

You can manage the following features in **Support experience**:
  
- **Workspaces**: Agent experience profiles, templates, and third-party voice channel provider.
- **Productivity**: Transcripts, outbound profiles, templates for emails and messages, macros, and custom presence.
- **Knowledge**: Record types for which knowledge management needs to be enabled, filters, external portal, article templates, and search providers.

  :::image type="content" source="../media/agent-experience-overview.png" alt-text="Overview page of Support experience in Copilot Service admin center.":::

You can manage the following features in **Operations**:

- **Insights**: Historical analytics for Customer Service and Dynamics 365 Contact Center. Configure AI features for cases and conversations, including translation, skills models, and routing.
- **Calendar**: Operating hours, Customer Service calendar, and holiday calendar.
- **Service terms**: Service-level agreements (SLAs), SLA KPIs, and entitlements.
- **Service scheduling**: Organizational units, facilities and equipment, resources, service scheduling, business closure, fulfillment preferences, and resource categories.
- **Miscellaneous**: Analysis jobs, migration tool, and IoT settings.

  :::image type="content" source="../media/operations-overview.png" alt-text="Overview page of operations in Copilot Service admin center.":::

## Search admin settings

Use the search option on the **Search admin settings** page to quickly list the admin setting that you want to manage. Along with the top matches, the page also lists settings for the new features.

:::image type="content" source="../media/search-admin-settings.png" alt-text="Screenshot of the search admin settings page that lists the new features settings and settings that match the search string.":::

### FAQ

Go to the [FAQ about Copilot Service admin center](../administer/faq-customer-service-admin-center.md) for any questions that you might have.

### Related information

[Help resources for Customer Service](../help-hub.md)  
[Sign up for a free Dynamics 365 Customer Service trial](try-customer-service.md)  
[Overview of user management](overview-users.md)  
[Manage your agents in Dynamics 365 Contact Center](../administer/manage-your-bots.md)  
[Check your contact center health](../administer/check-contact-center-health.md)  
