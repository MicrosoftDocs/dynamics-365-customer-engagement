---
title: "App profile manager | MicrosoftDocs"
description: "Using app profile manager to create and manage app profiles."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/28/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Preview: Create and use app profiles to manage apps

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
>
> - This feature is a preview, which means that it is made available to you before general availability so you can test and evaluate the preview and provide feedback to Microsoft.
> - This preview may employ reduced or different privacy, security, or compliance commitments than a commercial version. As such, this preview is not meant to be used with any "live" or production Customer Data, Personal Data, or other data that is subject to heightened compliance requirements. Any use of "live" data is at your sole risk and it is your sole responsibility to notify your end users that they should not include sensitive information with their use of the Preview.
> - This preview, and any support Microsoft may elect to provide, is provided "as-is," "with all faults," "as available," and without warranty. This preview is subject to the [Preview Terms](../legal/supp-dynamics365-preview.md).

## Introduction

This topic discusses how to use the app profile manager to create app profiles and assign them to users.

By default, one app profile each will be available out of the box for Customer Service workspace and Omnichannel for Customer Service. These profiles can't be deleted or modified. When no app profile is assigned to an agent, the default profile is assigned.

## Prerequisites

To create app profiles for Omnichannel for Customer Service, you must have the Dynamics 365 Chat license.


## Create an app profile

1. Sign in to Power Apps.
2. On the App profiles page, select **New profile**.
3. On the **New profile** pane, specify the following:
   - **Name:** The app profile name.
   - **Unique name:** A unique identifier in the *<prefix>*_*<name>* format.
     > [!IMPORTANT]
     > The following are required for the unique name:
     > - Prefix can only be alphanumeric and its length must be between 3 to 8 characters.
     > - An underscore must be there between the prefix and the name.
   - **Description:** A description for the profile.

### Assign templates and enable productivity pane and channels

1. On the **App profiles** page, select the app profile to which you want to assign templates.
2. On the **Session templates**, select **Add entity session template**.
3. Search for the template you want to add and select it.
   > [!div class=mx-imgBorder]
   > ![App profile session template](media/app-profile-session-template.png "App profile session template")
4. Do the following on the Productivity pane:
   1. Set the toggle to On for **Turn on productivity pane**.
   2. Select the default mode as collapsed or expanded.
   3. In the Productivity tools section, set the toggle to on for **Smart assist tool configuration** and **Call script tool configuration**.
5. On the **Channels** tab, set the toggle to on for **All active channels**. The channels configured in Omnichannel are available for the user to whom the profile is assigned.
6. In the **Voice channels** section, select **Add channel providers** to configure a third-party channel provider. The channel configuration page opens on a new tab.
  


