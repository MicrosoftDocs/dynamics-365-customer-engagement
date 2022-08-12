---
title: "Customer Service admin center | MicrosoftDocs"
description: "Get started with Customer Service admin center"
ms.date: 08/04/2022
ms.topic: get-started
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Get started with Customer Service admin center

Welcome to Customer Service admin center, a new app that unifies and simplifies administration experience across the Customer Service suite.

Use the Customer Service admin center app to set up the features in Customer Service, such as defining parent-child case hierarchy, creating queues, channels, rules for automatic case creation, and customer service schedules.

Some of the improvements include:  

- Consolidated administration experiences across Customer Service Hub, Omnichannel admin center, and app profile manager.

- Reorganized site map that's task-oriented.

- Overview pages for each area that list at-a-glance information with deep links to manage features.

- Landing pages per feature with an overview of all the capabilities.

- The site map adapts to the capabilities that are provisioned. Based in core Customer Service, if Omnichannel for Customer Service is provisioned, then other features are automatically available.

  
   <div class="embeddedvideo"><iframe src="https://www.microsoft.com/en-us/videoplayer/embed/RE4TYJn?maskLevel=0" frameborder="0" allowfullscreen=""></iframe></div>

## Prerequisites

You'll need one or more of the following security roles to access this app:

- **System Administrator**: Can access and edit all the site map entries

- **System Customizer**: Can access and edit all the site map entries

- **CSR Manager**: Can access the entities consolidated from Customer Service Hub > Service Management

- **App Profile Manager administrator and Basic User**: Can access the app and edit app profile-related entities

- **Omnichannel Administrator and Basic User**: Can access the app and edit all the Omnichannel-related entities

## Access the app

The app is automatically installed in all the Customer service organizations. You can sign in to Dynamics 365, and on the apps page, select Customer service admin center.

## Quick setup (preview)

> [!NOTE]
>
> - Quick setup is in preview; therefore, we recommend that you don't use it in production. Use it only in test and development environments.
> - [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

You can use the quick setup wizard to configure a channel, such as for routing cases. The wizard helps you create the channel, configure users and permissions, and set up routing rules to get you started with handling customer issues with minimal setup.

## Navigate the site map in Customer Service admin center

The Customer Service features are organized in the site map as follows. Every group contains an overview page with deep links to the features within the area.

> [!NOTE]
> Some of the options that appear on the site map are dependent on the features that you have provisioned.

The overview page for every group lists a summary of the objects that are available for each feature. For example, the number of users who are available, and channels and queues that are configured in the organization.

You can manage the following features in **Customer support**:

- **User management**: Users, their skills, capacity profiles, and role persona mapping
- **Channels**: Channels, such as record, chat, and voice, and the messaging accounts and phone numbers.
- **Queues**: Manage basic and advanced queues.
- **Routing**: Settings, such as enable unified routing, configure record routing, routing diagnostics, and machine learning models for skill-based, effort-based, and sentiment-based routing.
- **Workstreams**: Workstreams for the different channels.
- **Case settings**: Subjects, automatic record creation rules, advanced similarity rules, parent-child case settings, and case resolution dialog.
- **Customer settings**: Blocked numbers, authentication settings, geo location, phone music, outbound messaging and automate messages.

  :::image type="content" source="media/customer-support-overview.png" alt-text="Overview page of Customer support in Customer Service admin center.":::

You can manage the following features in **Agent experience**:
  
- **Workspaces**: Agent experience profiles, templates, and third-party voice channel provider.
- **Productivity**: Transcripts, outbound profiles, templates for emails and messages, macros, and custom presence.
- **Knowledge**: Record types for which knowledge management needs to be enabled, filters, external portal, article templates, and search providers.

  :::image type="content" source="media/agent-experience-overview.png" alt-text="Overview page of Agent experience in Customer Service admin center.":::

You can manage the following features in **Operations**:

- **Insights**: Historical analytics for Customer Service and Omnichannel for Customer Service, Omnichannel intraday insights and AI feature settings for cases and conversations, real-time translation and machine-learning models for skills, and skill-based, effort-based, and sentiment-based routing setup.
- **Calendar**: Operating hours, Customer Service calendar, and holiday calendar.
- **Service terms**: Service-level agreements (SLAs), SLA KPIs, and entitlements
- **Service scheduling**: Organizational units, facilities and equipment, resources, service scheduling, business closure, fulfillment preferences, and resource categories.
- **Miscellaneous**: Analysis jobs, migration tool, and IoT settings.

  :::image type="content" source="media/operations-overview.png" alt-text="Overview page of operations in Customer Service admin center.":::

### FAQ

See the [FAQ about Customer Service admin center](faq-customer-service-admin-center.md) for any questions that you might have.

### See also

[Help resources for Customer Service](help-hub.md)  
[Sign up for a free Dynamics 365 Customer Service trial](try-customer-service.md)  
[Overview of user management](overview-users.md)  

