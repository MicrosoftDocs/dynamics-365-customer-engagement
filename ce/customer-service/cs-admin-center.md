---
title: "Customer Service admin center | MicrosoftDocs"
description: "Get started with Customer Service admin center"
ms.date: 02/11/2022
ms.topic: get-started-article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Get started with Customer Service admin center

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

## Introduction

Welcome to Dynamics 365 Customer service admin center (preview), a new app that unifies and simplifies administration experience across the Customer Service suite.

Use the Customer Service admin center app to set up everything related to customer service, such as defining parent-child case hierarchy, creating queues, channels, rules for automatic case creation, service-level agreements (SLAs), entitlements, and customer service schedules.

Some of the highlighted improvements include:  

- Consolidation of administration experiences across Customer Service Hub, Omnichannel for Customer Service and app profile manager

- Re-organized site map that's task oriented

- Overview pages for each area that list at-a-glance information with deep links to manage features

- Feature landing page that provides an overview of all capabilities for that feature

- Adapts to the capabilities that are provisioned. Based in core Customer service, if Omnichannel for Customer Service is provisioned, additional features are automatically available.

## Prerequisites

You will need one of the following security roles to access this app. The last three are for back compatibility with current admin access to CSH, Omnichannel admin center and App profile managers.  

- System Administrator – can access and edit all the sitemap entries

- System Customizer – can access and edit all the site map entries

- Customer service manager – can access the entities in service management

- App profile administrator – can access the app and edit app profile-related entities

- Omnichannel administrator – can access the app and edit all the Omnichannel related entities

## Access the app

Sign in to Dynamics 365, and on the apps page, select Customer service admin center(preview). The app is automatically installed in all the Customer service organizations.

### Navigate the site map in Customer Service admin center

Features are grouped in the site map as follows. Every group contains an overview page with deep links to the features within the area.

> [!NOTE]
> Some of the options that appear on the site map are dependent on the licenses that you have.

The overview page for every group lists a summary of the objects that are available for each feature. For example, the number of users who are available, and channels and queues that are configured in the organization.

You can manage the following features in **Customer support**:

- **User management**: Users, their skills, capacity profiles, and role persona mapping
- **Channels**: Channels, such as record, chat, and voice, and the messaging accounts and phone numbers.
- **Queues**: Manage basic and advanced queues.
**- Routing**: Routing-related settings, such as enable unified routing, configure record routing, routing diagnostics, and machine learning models for skill-based, effort-based, and sentiment-based routing.
- **Workstreams**: Workstreams for the different channels.
**- Case settings**: Subjects, automatic record creation rules, advanced similarity rules, parent-child case settings, and 
- **Customer settings**: Blocked numbers, authentication settings, geo location, phone music, outbound messaging and automate messages.

  :::image type="content" source="media/customer-support-overview.png" alt-text="Overview page of Customer support in Customer Service admin center.":::


You can manage the following features in **Agent experience**:
  
- **Workspaces**: App profiles, templates, and third-party voice channel provider.
- **Productivity**: Transcripts, outbound profiles, templates for emails and messages, macros, and custom presence.
- **Knowledge**: Record types for which knowledge management needs to be enabled, filters, external portal, article templates, and search providers.

  :::image type="content" source="media/agent-experience-overview.png" alt-text="Overview page of Agent experience in Customer Service admin center.":::


You can manage the following features in **Operations**:

- **Insights**: Historical analytics for Customer Service and Omnichannel for Customer Service, Omnichannel intraday insights and AI feature settings for cases and conversations, real-time translation and machine-learning models for skills, and skill-based, effort-based, and sentiment-based routing setup.
- **Calendar**: Operating hours, Customer Service calendar, and holiday calendar.
- **Service terms**: Service-level agreements (SLAs), SLA KPIs, and entitlements
- **Service scheduling**: Organizational units, facilities and equipment, resources, service scheduling, business closure, fulfillment preferences, resource categories.
- **Miscellaneous**: Analysis jobs, migration tool, and IoT settings.

  :::image type="content" source="media/operations-overview.png" alt-text="Overview page of operations in Customer Service admin center.":::

## FAQ

### What's the difference between Omnichannel admin center and Customer Service admin center?  

Customer Service admin center unifies all the administration settings in Customer Service Hub and Omnichannel admin center. The site map is task oriented, and only navigation to the entities has changed. You don't need to migration data, you just need to start to use this new app and get used to it.  

### Can I customize this new application?

Similar to other apps, you can use the App designer to  customize the site map entries. If you have custom entities that your administrators use to manage different aspects of your business, then you can add them to the Customer Service admin center site map, so that your administrators don’t need to use a separate app. To avoid conflicts with site map entries that are available out of the box, we recommend that you create a new sub area to add your site map entries.

### When do you plan to deprecate existing admin experience?  

After Customer service admin center becomes generally available, we will leave some time for customers to get used it and provide feedback. This new app will co-exist with the existing admin experience. We'll then announce the deprecation of the legacy app. We recommend that you start using this app for the seamless benefits.  

### See also
