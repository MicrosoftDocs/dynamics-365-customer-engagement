---
title: "Use the Dynamics 365 app for Teams for collaboration| MicrosoftDocs"
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
# Use the Dynamics 365 app for Teams for collaboration

## Connect a Dynamics 365 (online) record to a Teams channel

From a Teams channel, you can connect a Dynamics 365 record to collaborate on a customer account, an opportunity, etc.

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

The team app allows for collaborating with others through Dynamics 365 record connections made in teams and channels in Microsoft Teams.

Once you've installed the team app, select a channel to add a Dynamics 365 record link as a tab. Then, select the **Add** button (![Add button](media/plus-2.png "Add button")).

   ![Select Add button](media/teams-add-tab.png "Select Add button")

Select the **Dynamics 365** icon to pin a Dynamics 365 record to a channel.

   ![Add Dynamics 365 Team channel](media/teams-add-channel.png "Add Dynamics 365 Team channel")

Search for an entity to pin. Use **Filter by** to narrow the search to an entity type. Select **Save**.

   ![Search for entity](media/teams-add-channel-pin-record.png "Search for entity")

   If you have multiple organizations or app modules, select **Edit** (![Edit](media/edit-icon.png "Edit")) to specify which org or app module to use in Teams.
 
   ![Specify org and app](media/teams-change-org-app.png "Specify org and app")

   Enable **Remember this preference** to set the org and app selections to be the default personal dashboard that appears when you select **My Dashboard**.

   Use the **Settings** tab to change these settings any time.

Once you complete the above steps, you'll see a notification of a successful connection and the Dynamics 365 (online) record appears in the menu bar.

> [!div class="mx-imgBorder"] 
> ![](media/teams-pinned-record.png "Record successfully connected and pinned")

There are two connection states: successful and failed. The sole difference is file synchronization from Dynamics 365 (online) to Teams.

A successful connection means two-way communication now exists between Dynamics 365 (online) and Microsoft Teams. You can interact with the record as if you were using the Dynamics 365 web app and share files with the web app. Those with *Write* permissions can edit the record and changes will be synchronized with the Dynamics 365 web app. Also, file synchronization occurs between both apps.

A failed connection means file synchronization is not set up between Microsoft Teams and Dynamics 365 (online). File changes in Dynamics 365 (online) are not synchronized with Teams. However, changes made to the record in Teams will update in Dynamics 365 (online). See: [Error: This record is not connected to Dynamics 365. Repin the tab and try again.](troubleshoot-teams.md#error-this-record-is-not-connected-to-dynamics-365-repin-the-tab-and-try-again)

### Files tab

Select the connected channel **Files** tab in the Teams app to associate files with a Dynamics 365 (online) record. Files added here will appear in Dynamics 365 (online) under **Documents** for the linked record. Likewise, when you add a document to a record in Dynamics 365 (online), that document will appear in Teams under the **Files** tab.

> [!div class="mx-imgBorder"] 
> ![](media/teams-files-tab.png "File tab in team app")

### Open record in Dynamics 365 (online)

It's easy to use Teams to open a record in Dynamics 365 (online). From a record pinned in a Teams channel, select the **Go to website** button to open the record in Dynamics 365 (online).

> [!div class="mx-imgBorder"] 
> ![](media/teams-open-record-d365.png "Open a record in Dynamics 365 (online)")
