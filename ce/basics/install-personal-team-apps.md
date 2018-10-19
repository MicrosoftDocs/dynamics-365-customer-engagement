---
title: "Set up Microsoft Teams integration with Dynamics 365 (online)| MicrosoftDocs"
ms.custom: ""
description: "Setup Microsoft Teams integration with Dynamics 365 (online)"
ms.date: 10/30/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 8097c9ec-023b-407d-ac0e-074b5e1964a5
caps.latest.revision: 17
author: "jimholtz"
ms.author: "jimholtz"
manager: "kvivek"
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Set up Microsoft Teams integration with Dynamics 365 (online)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

## For For Dynamics 365 (online) admins: enable Microsoft Teams integration Preview features

Because this is a preview feature, you can control whether to display certain Teams integration features. For full Teams integration, the Dynamics 365 (online) admin should enable two settings.

1. Sign in as a System administrator to Dynamics 365 (online).
2. Go to **Settings** > **Administration** > **System Settings** > **Previews** tab.
3. Enable **Microsoft Teams Integration Preview** and **Dynamics 365 bot in Microsoft Teams Preview**.

> [!div class="mx-imgBorder"] 
> ![](media/teams-system-settings.png "Enable preview settings")

The following table describes what happens when each feature is enabled.

|Setting  |When enabled |
|---------|---------|
|Microsoft Teams Integration Preview   | When enabled, the **Collaborate** button appears on records in Dynamics 365 (online) so you can see the connected team channel. In addition, in the **Documents** tab, files synchronized with Teams will appear.         |
|Dynamics 365 bot in Microsoft Teams Preview     | When enabled, the bot appears in Microsoft Teams in the **Conversation** tab in the Dynamics 365 Teams app.  |

If these settings are not enabled, you can still use much of the Teams integration with Dynamics 365 (online); the above features will be absent.

## Select the app in the App Store

Once Microsoft Teams integration is enabled in Dynamics 365 (online), find the Dynamics 365 app in the App Store.

1. In Microsoft Teams, select **Store**. 

   ![Select Store](media/select-store.png "Select Store")

2. Search for **dynamics**, and then select the **Dynamics 365 (Preview)** tile.

   ![Search for and select Dynamics 365](media/teams-search-select-dynamics-365-app.png "Search for and select Dynamics 365")

## Install the personal and team apps

You have a choice when adding Dynamics 365 to Microsoft Teams. You can install the personal app which integrates Dynamics 365 and Teams for your own use, and you can install the team app to use with your team members. We'll take the simplest approach and install both.

Once you've selected the Dynamics 365 app (see steps above), the settings page opens. 

1. For **Add to a team**, choose a team to pin content and services to, and the select **Install**. This installs the personal and team app.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-install-app.png "Install the Dynamics 365 app")

2. In the next page, choose the channel where you want to use the Dynamics 365 app. Then, select **Set up**.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-install-app-step2.png "Install the Dynamics 365 app, step 2")

3. Recently viewed records appear, if there are any. Search for and select an entity to pin. Use **Filter by** to narrow the search to an entity type. 

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-add-channel-pin-record2.png "Add channel to pin record")

   If you have multiple organizations or app modules, select **Edit** (![Edit](media/edit-icon.png "Edit")) to specify which org or app module to use in Teams.
 
   ![Specify org and app](media/teams-change-org-app.png "Specify org and app")

   Enable **Remember this preference** to set the org and app selections to be the default personal dashboard that appears when you select **My Dashboard**.

   Use the **Settings** tab in the Teams app to change these settings any time.

 4. Select **Save**. 

Once you complete the above steps, the Dynamics 365 tab appears in the menu bar.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-pinned-record2.png "Dynamics 365 record tab")

You can interact with the record as if you were using the Dynamics 365 web app. Those with Write permissions can edit the record; changes will be synchronized with the Dynamics 365 web app.

For information on using the Dynamics 365 app, see: [Use the personal app and bot](use-personal-app.md).