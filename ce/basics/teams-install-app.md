---
title: "Install and set up the Dynamics 365 app for Teams| MicrosoftDocs"
ms.custom: ""
description: "Install and set up the Dynamics 365 app for Teams."
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
# Install and set up the Dynamics 365 app for Teams

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

## Install the app and set up the Teams tab

1. In Microsoft Teams, select **Store**. 

   ![Select Store](media/select-store.png "Select Store")

2. Search for **dynamics**, and then select the **Dynamics 365 (Preview)** tile.

   ![Search for and select Dynamics 365](media/teams-search-select-dynamics-365-app.png "Search for and select Dynamics 365")

3. Verify that **Add for you** and **Add to team** are both set to **Yes**.

   You can use Dynamics 365 for your own use or use on a Microsoft Teams channel to collaborate with others. If you have an existing Microsoft Teams channel, select both options. Otherwise, you can start installing for your personal use and install the app for your Teams later.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-store-install-both75.png "Enable personal and team features")

4. For **Add to a team**, choose a team and then select **Install**. 

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-store-install-add-team75.png "Add to team")

5. Pick a channel in Microsoft Teams to connect to a Dynamics record then select **Set up**.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-install-app-step2.png "Add to team")

6. Select **Review permissions**.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-review-premissions75.png "Review permissions")

7. Read through the permissions and select **Accept**.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-permissions-requested.png "Accept permissions")

8. Select a version 9.x org and a Unified Interface app to connect, then choose **Save**.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-fre-org-app.png "Select org and app module")

   > [!NOTE]
   > - Only Dynamics 365 version 9.x or later organizations appear in the list. Also, only active organizations (those that are not disabled or provisioning) are displayed. 
   > - Only Unified Interface apps are listed.
   > - Only app modules licensed for the selected organization are listed. 

9. Select an entity to connect. You can pick a recently viewed record or use search to find records. You can use **Filter by** to narrow the search to an entity type. Once you've picked a record select **Save**.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-add-channel-pin-record2.png "Select an entity")

After completing the above steps, you can select Dynamics 365 only record to connect to the Microsoft teams channel. For more information, see [Collaborate with Teams](teams-collaboration.md). 

> [!div class="mx-imgBorder"] 
> ![](media/teams-pinned-record.png "Record successfully connected and pinned")

For troubleshooting, see [Troubleshoot Teams integration](teams-troubleshoot.md).

## Set up the Dynamics 365 bot
Set up the bot feature to interact with Dynamics 365 (online).

1. Open the Dynamics 365 app.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-pick-app.png "Open the Dynamics 365 app")

2. The **Conversation** tab opens with the welcome message sent by the bot which provides an overview of the bot’s abilities. Select **Sign in**.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-bot-welcome.png "Sign in to the bot")

3. Select an org, and then select **Next**.

   If the org has multiple app modules (Sales, Marketing, Service, etc.), then you'll also select an app module.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-bot-select-org.png "Select an org")

> [!NOTE]
> Only Dynamics 365 version 9.x or later organizations appear in the list. Also, only active organizations (those that are not disabled or provisioning) are displayed.

4. Enter credentials and sign in.

The Dynamics 365 bot setup is complete and some pre-loaded options are available for getting started.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-bot-confirmation.png "Bot is set up")

See [Use the bot](teams-bot-search.md) for information on how you can use the bot feature to interact with Dynamics 365 (online).

## Set up the personal dashboard
Set up the personal dashboard (My Dashboard) to interact with Dynamics 365 (online) without involving other team members.

1. Open the Dynamics 365 app.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-pick-app.png "Open the Dynamics 365 app")

2. Select a version 9.x org and a Unified Interface app to connect with Dynamics 365 (online), then choose **Save Changes**.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-mydashboard-org-app.png "Select org and app module")

   > [!NOTE]
   > - Only Dynamics 365 version 9.x or later organizations appear in the list. Also, only active organizations (those that are not disabled or provisioning) are displayed. 
   > - Only Unified Interface apps are listed.
   > - Only app modules licensed for the selected organization are listed. 

3. Select the **My Dashboard** tab.

See [Use the personal dashboard](teams-personal-use.md) for information on how you can use **My Dashboard**.

## For Dynamics 365 (online) admins: enable Microsoft Teams integration Preview features

Because this is a preview feature, you can control whether to display Teams integration in Dynamics 365 (online). For full Teams integration, the Dynamics 365 (online) admin should enable two settings.

1. Sign in as a System administrator to Dynamics 365 (online).
2. Go to **Settings** > **Administration** > **System Settings** > **Previews** tab.
3. Enable **Microsoft Teams Integration Preview** and **Dynamics 365 bot in Microsoft Teams Preview**.

> [!div class="mx-imgBorder"] 
> ![](media/teams-system-settings.png "Enable preview settings")

The following table describes what happens when each feature is enabled.

|Setting  |When enabled |
|---------|---------|
|Microsoft Teams Integration Preview   | When enabled, the **Collaborate** button appears on records in Dynamics 365 (online) so you can see the connected team channel. In addition, in the **Documents** tab, files synchronized with Teams will appear.         |
|Dynamics 365 bot in Microsoft Teams Preview     | When enabled, the bot appears in Microsoft Teams in the **Conversation** tab in the Dynamics 365 app for Teams.  |

If these settings are not enabled, users can still connect Dynamics 365 (online) record to Microsoft Teams but the related Microsoft Teams channel and document do not appear in Dynamics 365 (online).  

### See also  
 [Troubleshoot Teams integration](teams-troubleshoot.md)


<!--
## Install the app

You have a choice when adding Dynamics 365 to Microsoft Teams. You can enable features which integrates Dynamics 365 and Teams for your own use, and you can enable features that you can use to collaborate with your team members. We'll take the simplest approach and enable both.

1. Verify that **Add for you** and **Add to team** are both set to **Yes**.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-store-install-both75.png "Enable personal and team features")

2. For **Add to a team**, choose a team to pin content and services to, and then select **Install**. 

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-store-install-add-team75.png "Add to team")

3. In the next page, choose the channel where you want to use the Dynamics 365 app. Then, select **Set up**.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-install-app-step2.png "Install the Dynamics 365 app, step 2")

4. Connect the app with Dynamics 365 (online). Select the Dynamics 365 app for Teams from the left-side menu.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-pick-app.png "Open the app")

5. Select a version 9.x org and a Unified Interface app to connect with Dynamics 365 (online), then select **Save Changes**.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-settings-page.png "Select org and app")

Teams is now connected with Dynamics 365 (online).


   If you have multiple organizations or app modules, select **Edit** (![Edit](media/edit-icon.png "Edit")) to specify which org or app module to use in Teams.
 
   ![Specify org and app](media/teams-change-org-app.png "Specify org and app")

   Enable **Remember this preference** to set the org and app selections to be the default personal dashboard that appears when you select **My Dashboard**.

   Use the **Settings** tab in the Teams app to change these settings any time.

 5. Select **Save**. 

Once you complete the above steps, the Dynamics 365 tab appears in the menu bar.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-pinned-record2.png "Dynamics 365 record tab")

You can interact with the record as if you were using the Dynamics 365 web app. Those with Write permissions can edit the record; changes will be synchronized with the Dynamics 365 web app.

For information on using the Dynamics 365 app, see: [Use the personal app and bot](use-personal-app.md).
-->