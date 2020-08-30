---
title: "Overview of app profile manager | MicrosoftDocs"
description: "Overview of the app profile manager."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/28/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Preview: App profile manager

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
>
> - This feature is a preview, which means that it is made available to you before general availability so you can test and evaluate the preview and provide feedback to Microsoft.
> - This preview may employ reduced or different privacy, security, or compliance commitments than a commercial version. As such, this preview is not meant to be used with any "live" or production Customer Data, Personal Data, or other data that is subject to heightened compliance requirements. Any use of "live" data is at your sole risk and it is your sole responsibility to notify your end users that they should not include sensitive information with their use of the Preview.
> - This preview, and any support Microsoft may elect to provide, is provided "as-is," "with all faults," "as available," and without warranty. This preview is subject to the [Preview Terms](../legal/supp-dynamics365-preview.md).

## Introduction

The app profile manager lets organizations create targeted app experiences for agents and supervisors as an alternative to building and maintaining custom apps. With the app profile manager, administrators can create custom profiles with specific session templates, conversation channels, and productivity tools. These profiles can then be assigned to users.

<!--[kabala] The profiles are available for agents and supervisors who use the Customer Service workspace and/or Omnichannel for Customer Service apps.-->
The profiles are app agnostic and are available for agents and supervisors who use Customer Service workspace and Omnichannel for Customer Service.

## How the targeted app experience works

As a system administrator, the targeted app experience  process is as follows:

1. Create users in Microsoft Dynamics 365 admin center.
2. Assign security roles, such as Customer Service Representative or Omnichannel agent.
3. Create business processes, such as work streams, queues, sessions, and productivity tools.
4. Create app profiles.
5. Assign app profiles to users.

For existing orgs, only steps 4 and 5 are required.

Thereafter, users with the required agent or supervisor role will be able to see and use the settings that are available through the assigned app profile. If you do not assign an app profile, by default, the out-of-the-box app profile will be assigned.

<!-- [kabala] - new section. pls review -->
## Security roles of app profile manager

App profile manager has standard security roles.

- App profile manager administrator
- App profile user

### Security roles forOmnichannel for Customer Service

For **Omnichannel administrator** role, the **App profile manager administrator** previleges are added, and for **Omnichannel agent** and **Omnichannel supervisor** roles, the **App profile user** previleges are added.

If your organization is using custom role, and you want the custom security role user to be an app profile manager, then you can either assign the **App profile manager administrator** role or manually add the **App profile manager administrator** previleges to the custom security role.

### Security roles for Customer Service workspace

For **Customer Service Manager** role, the **App profile manager administrator** previleges are added, and for **Customer Service Representative** role, the **App profile user** previleges are added.

If your organization is using custom role, and you want the custom security role user to be an app profile manager, then you can either assign the App profile manager administrator role or manually add the App profile manager administrator previleges to the custom security role.

## Experience for accessing templates and productivity tools

The Power Apps home page for app profiles is an easy-to-use interface that helps you get started with what you can do on the page.

  > [!div class=mx-imgBorder]
  > ![App profiles home page](media/app-profile-home.png "App profiles home page")

> [!IMPORTANT]
> Omnichannel for Customer Service is available only when you have the Chat for Dynamics 365 license.
<!-- [kabala] - Not just chat for D365 but even digital messaging sku -->

The options to access and manage the following entities are available on the left pane of the app profile manager:

- Settings
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

Irrespective of the path from where you navigate to any of the components, such as session templates or application tab templates, you will see templates that you have defined for both Customer Service workspace and Omnichannel for Customer Service. This is because the templates are stored in a common library.

### Settings

The **Settings** option in **Customer Service workspace** opens the **Queues** page on a new tab.

The **Settings** option in **Omnichannel Administration** opens the **Entity Records** page on a new tab.

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
