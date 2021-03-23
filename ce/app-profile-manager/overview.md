---
title: "Overview of app profile manager | MicrosoftDocs"
description: "Overview of the app profile manager."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/12/2020
ms.service: "dynamics-365-customerservice"
ms.topic: article
---

# App profile manager

## Introduction

The app profile manager lets organizations create targeted app experiences for agents and supervisors as an alternative to building and maintaining custom apps. With the app profile manager, administrators can create custom profiles with specific session templates, conversation channels, and productivity tools. These profiles can then be assigned to users.

Agent productivity tools use intelligence and automation to enable agents to find answers to customer questions and help resolve customer issues quickly, thereby improving satisfaction in service delivery. Agent productivity tools enable easy knowledge base search, suggestions for similar knowledge articles and cases, and agent scripts with macros to automate tasks in common workflows. 

The profiles are available for agents and supervisors who use the Customer Service workspace or Omnichannel for Customer Service apps.

The system requirements for the app profile manager are same as those for Customer Service workspace. More information: [System requirements for Customer Service workspace](../customer-service/customer-service-workspace-system-requirements.md)

## How the app profile experience works

Managing the app profiles is as follows. The tasks in every step will be done by administrators who have different roles. It could be one administrator or a set of administrators.

1. Create users in Microsoft Dynamics 365 admin center.
2. Assign security roles, such as Customer Service Representative or Omnichannel agent.
3. Create business processes, such as work streams, queues, sessions, and productivity tools.
4. Create app profiles.
5. Assign app profiles to users.

For existing orgs, only steps 4 and 5 are required.

Thereafter, users with the required agent or supervisor role will be able to see and use the settings that are made available through the assigned app profile. If you do not assign an app profile, by default, the out-of-the-box app profile will be assigned.

## Experience for accessing templates and productivity tools

The Power Apps home page for app profiles is an easy-to-use interface that helps you get started with what you can do on the page.

  > [!div class=mx-imgBorder]
  > ![App profiles home page](media/app-profile-home.png "App profiles home page")

> [!IMPORTANT]
> [!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

The options to access and manage the following entities are available on the left pane of the app profile manager:

- Settings
- Channel provider
- Templates
  - Session templates
  - Application tabs
  - Notifications
- Productivity
  - Smart assist
  - Agent scripts
- Macros

All these options are available in the Unified Interface and open on a new tab when you select any to access it.

> ![Navigation menu](media/app-profile-navigation-items.png "App profiles home page")

Irrespective of the path from where you navigate to any of the components, such as session templates or application tab templates, the templates that you have defined for Customer Service workspace and Omnichannel for Customer Service will be displayed because they are stored in a common library.

### Settings

The **Settings** option in **Customer Service workspace** opens the **Queues** page on a new tab.

The **Settings** option in **Omnichannel Administration** opens the **Entity Records** page on a new tab.

### Channel provider

The **Channel provider** option in **Customer Service workspace** or **Omnichannel Administration** opens the channels view on a new tab where you can configure a new channel or update the settings of the existing providers.

### Templates

The following template types can be accessed:

- **Session templates:** Opens the Session templates page where the out-of-the-box templates and custom templates created by you are listed.
- **Application tabs:** Opens the application tab templates page to create and manage application tab templates.
- **Notifications:** Opens the notifications templates page to manage the templates.

### Productivity

You can access the following options in the **Productivity** area:

- **Smart assist:** Opens the settings for AI-based suggestions for similar cases, knowledge articles, and ongoing conversations.
- **Agent scripts:** Opens the agent scripts page for you to create and manage scripts.
- **Macros:** Opens the macros page for you to create and manage macros.

## Upgrade experience for existing Omnichannel for Customer Service

When you upgrade your existing environments, the settings for templates, productivity tools, and channels configuration in the out-of-the-box app profile will reflect the existing state of your environment. For example, if productivity pane is enabled and smart assist is configured, the settings will be retained in the out-of-the-box app profile.

### See also

[Create app profiles](app-profile-manager.md)  
[System requirements](../customer-service/customer-service-workspace-system-requirements.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
