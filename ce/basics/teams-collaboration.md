---
title: "Collaborate with Teams| MicrosoftDocs"
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
# Collaborate with Teams

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Once installed, the Dynamics 365 app for Teams enables collaborating with others through Dynamics 365 record connections made in teams and channels in Microsoft Teams.

## Connect a Dynamics 365 (online) record to a team channel

From a team channel, you can connect a Dynamics 365 record to collaborate on a customer account, an opportunity, etc. When you installed the Dynamics 365 app for Teams, you added (pinned) a record to a team channel as a tab. You can repeat this process any time as follows.


1. Open a team channel and select the **Add** button (![Add button](media/plus-2.png "Add button")).

   ![Select Add button](media/teams-add-tab.png "Select Add button")

2. Select the **Dynamics 365** icon to pin a Dynamics 365 record to a channel.

   ![Add Dynamics 365 Team channel](media/teams-add-channel.png "Add Dynamics 365 Team channel")

3. Search for an entity to pin. You can pick a recently viewed record or use search to find records. You can use **Filter by** to narrow the search to an entity type. Once you've picked a record select **Save**.

   ![Search for entity](media/teams-add-channel-pin-record2.png "Search for entity")

   In the above page, if you have multiple organizations or app modules, select **Edit** (![Edit](media/edit-icon.png "Edit")) to specify which org or app module to use in Teams.
 
   ![Specify org and app](media/teams-change-org-app.png "Specify org and app")

   You can enable **Remember this preference** to set the org and app selections to be the default personal dashboard that appears when you select **My Dashboard**.

   You can return to these settings any time by selecting the **Settings** tab.

Once you complete the above steps, you'll see a notification of a successful connection and the Dynamics 365 (online) record appears in the menu bar. You can interact with the record as if you were using the Dynamics 365 web app. Those with Write permissions can edit the record. Changes will be synchronized with the Dynamics 365 web app.

> [!div class="mx-imgBorder"] 
> ![](media/teams-pinned-record.png "Record successfully connected and pinned")

The following section provides information about connections between Dynamics 365 (online) and Microsoft Teams.

### Two connection states

There are two connection states possible when connecting Dynamics 365 (online) and Microsoft Teams: successful and failed. The sole difference is file synchronization from Dynamics 365 (online) to Teams.

A successful connection means two-way communication now exists between Dynamics 365 (online) and Microsoft Teams. You can interact with the record as if you were using the Dynamics 365 web app and share files with the web app. Those with *Write* permissions can edit the record and changes will be synchronized with the Dynamics 365 web app. Also, file synchronization occurs between both apps.

A failed connection means file synchronization is not set up between Microsoft Teams and Dynamics 365 (online). File changes in Dynamics 365 (online) are not synchronized with Teams. However, changes made to the record in Teams will update in Dynamics 365 (online). See: [Error: This record is not connected to Dynamics 365. Repin the tab and try again.](teams-troubleshoot.md#error-this-record-is-not-connected-to-dynamics-365-repin-the-tab-and-try-again)

### View and associate files

Select the  **Files** tab in the connected Teams channel to associate files with a Dynamics 365 (online) record. Files added here will appear in Dynamics 365 (online) under **Documents** for the linked record. Likewise, when you add a document to a record in Dynamics 365 (online), that document will appear in Teams under the **Files** tab.

> [!div class="mx-imgBorder"] 
> ![](media/teams-files-tab.png "File tab in team app")

### Open a record in Dynamics 365 (online)

It's easy to use Teams to open a record in Dynamics 365 (online). From a record pinned in a Teams channel, select the **Go to website** button to open the record in Dynamics 365 (online).

> [!div class="mx-imgBorder"] 
> ![](media/teams-open-record-d365.png "Open a record in Dynamics 365 (online)")

## Teams integration in Dynamics 365 (online)
In Dynamics 365 (online), you can see the connected Microsoft Teams channel and files synchronized between Teams and Dynamics 365 (online)

In Dynamics 365 (online) records, select **Collaborate** to display a list of all the connected team channels. Then, select a team channel to go to the relevant channel conversation in Teams.

> [!div class="mx-imgBorder"] 
> ![](media/teams-select-collaborate.png "From Dynamics 365, open a conversation in Teams")

In addition, document management actions in Dynamics 365 (online) are integrated with Teams. You can see the channel file library in Dynamics 365 (online) and directly upload files; uploaded files will appear in the Teams channel file library under the **Files** tab. Files uploaded in the Teams app will appear in the **Documents** tab in Dynamics 365 (online).

> [!div class="mx-imgBorder"] 
> ![](media/teams-documents-d365.png "Dynamics 365 document management in Teams")

### If you see this message: Shared files exist in multiple locations. Select "Document Location" to see files in other locations.

> [!div class="mx-imgBorder"] 
> ![](media/teams-error-multiple-locations.png "Shared files in multiple locations")

The record has been pinned to multiple Teams channels. In Dynamics 365 (online), select **Document Location** to specify the location of the file. 

> [!div class="mx-imgBorder"] 
> ![](media/teams-change-document-location.png "Change document location")

### Record types supporting Collaborate    

Currently, the following record types support using **Collaborate**. The **Collaborate** button will not appear for record types not listed below.

- account
- annotation
- appointment
- businessunit
- campaign
- category
- competitor
- contact
- email
- incident
- kbarticle
- knowledgearticle
- lead
- opportunity
- opportunityproduct
- product
- quote
- salesorder
- task
- team