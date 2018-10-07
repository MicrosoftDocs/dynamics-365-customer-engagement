---
title: "Install and use personal app| MicrosoftDocs"
ms.custom: ""
description: Install Teams personal app.
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
# Install and use personal app

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Begin by finding the app in the app Store.

## Select the app in the app Store

1. In Microsoft Teams, select **Store**. 

   ![Select Store](media/select-store.png "Select Store")

2. Search for **dynamics**, and then select the **Dynamics 365 (Preview)** tile.

   ![Search for and select Dynamics 365](media/teams-search-select-dynamics-365-app.png "Search for and select Dynamics 365")

## Install the personal app

You have a choice when adding Dynamics 365 to Microsoft Teams. You can install the personal app which integrates Dynamics 365 and Teams for your own use, or you can install the Team app to use with your team members. These steps are for installing the personal app - the settings under **App for you**.

Once you've selected the Dynamics 365 app (see steps above), the settings page opens. 

Verify **Yes** is enabled, and then select **Install** to install the personal app.

   ![Install personal app](media/teams-install-add-for-you.png "Install personal app")

## Install and use the personal app bot

There are two personal app features: the personal app bot and the personal app dashboard. The bot allows you to interact with Dynamics 365 to find and display records within Microsoft Teams. You configure the dashboard to show a Dynamics 365 dashboard view in Microsoft Teams.

Use these steps to install the personal app bot.

1. With the personal app installed, in the bot section, select **Open**. 

   ![Select Open bot](media/teams-personal-app-installed-open-bot.png "Select Open bot")

2. A Welcome message appears in the **Conversation** tab page. Select **Sign in**.

   ![Bot Welcome page](media/teams-bot-welcome.png "Bot Welcome page")

3. Select your organization, and then select **Next**.

   Your bot is set up and ready for input.

   ![Bot is ready for input](media/teams-first-bot.png "Bot is ready for input")

4. You can search to find records of interest. For example, enter "search contoso" in **Search** to see Contoso records.

   ![Use Search to find records](media/teams-search-contoso.png "Use Search to find records")

5. Search returns a list of related Dynamics 365 records. Select a record to see details.

   ![Search returns a list of records](media/teams-bot-search.png "Search returns a list of records")

6. The details of the selected record are displayed in the personal app bot. You can select an activity to view and edit related record details. For example, select **Show Opportunities** to see opportunities for the Contoso account.

   ![See related details and records](media/teams-bot-record-quick-action.png "See related details and records")

   You can update the details of the records in the personal bot.

## Use the personal app

### Conversation tab

Select **Conversation** to have a chat-like conversation with team members who are using Dynamics 365 (online) and those who are not.

> [!div class="mx-imgBorder"] 
> ![](media/teams-conversation.png "Teams conversation")

Choose a message, select ... and then select **Save to Dynamics** to add the message to the **Timeline** section of a record.

> [!div class="mx-imgBorder"] 
> ![](media/teams-save-conversation-message.png "Save Teams conversation message to Dynamics 365")

### File tab

### My Dashboard tab

Use the personal dashboard

Select **My Dashboard** to view your Dynamics 365 dashboard in Microsoft Teams. The dashboard displayed is based on who is signed in and their user role.

![Dynamics 365 dashboard](../admin/media/teams-bot-dashboard.png "Dynamics 365 dashboard")

If you have more than one organization or Unified Interface app, you can use the **Settings** tab to select a different organization or app to appear as a dashboard.

![Dashboard settings](../admin/media/teams-settings-page.png "Dashboard settings")

> [!NOTE]
> - Only Dynamics 365 version 9.x or later organizations appear in the list. Also, only active organizations (those that are not disabled or provisioning) are displayed. 
> - Only Unified Interface apps are listed.
> - Only app modules licensed for the selected organization are listed. 