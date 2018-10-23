---
title: "Get started with the app| MicrosoftDocs"
ms.custom: ""
description: "Use the personal app and bot."
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
# Get started with the app

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

## Use the personal app bot

There are two personal app features: the personal bot and the personal dashboard. The bot allows you to interact with Dynamics 365 to find and display records within Microsoft Teams. 

Once you've completed installing the Dynamics 365 Teams app, you're taken to the **Conversation** tab with the bot ready for use. If at any time in Teams you want to return to the personal app, select ... from the left-side menu, and then select **Dynamics 365 (Preview)**.

A Welcome message appears in the **Conversation** tab page. Select **Sign in**.

![Bot Welcome page](media/teams-bot-welcome.png "Bot Welcome page")

You can search to find records of interest. For example, search for Contoso records.

> [!div class="mx-imgBorder"] 
> ![](media/teams-first-bot2.png "Search for Contoso records")

Search returns a list of related Dynamics 365 records. Select a record to see details.

![Search returns a list of records](media/teams-bot-search.png "Search returns a list of records")

The details of the selected record are displayed in the personal app bot. You can select an activity to view and edit related record details. For example, select **Show Opportunities** to see opportunities for the Contoso account.

![See related details and records](media/teams-bot-record-quick-action.png "See related details and records")

You can update the details of the records in the personal app.

## Use the personal app

The personal app integrates Dynamics 365 and Teams for your own use. If you want to work with other team members, consider the [team app](teams-collaboration.md).

### Conversation tab

Select the **Conversation** tab to access the bot as described above.

### My Dashboard tab

Select **My Dashboard** to view your Dynamics 365 dashboard in Microsoft Teams. The dashboard displayed is based on who is signed in and their user role.

![Dynamics 365 dashboard](../admin/media/teams-bot-dashboard.png "Dynamics 365 dashboard")

### Settings tabs

If you have more than one organization or Unified Interface app, you can use the **Settings** tab to select a different organization or app to appear as a dashboard.

![Dashboard settings](../admin/media/teams-settings-page.png "Dashboard settings")

> [!NOTE]
> - Only Dynamics 365 version 9.x or later organizations appear in the list. Also, only active organizations (those that are not disabled or provisioning) are displayed. 
> - Only Unified Interface apps are listed.
> - Only app modules licensed for the selected organization are listed. 