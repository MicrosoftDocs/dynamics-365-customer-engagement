---
title: "Install the Dynamics 365 app in Microsoft Teams"
description: "Learn how to install the Dynamics 365 app in Teams."
ms.date: 11/25/2024
ms.topic: article
author: sbmjais
ms.author: shjais
search.audienceType: 
  - enduser
---

# Install the Dynamics 365 app in Microsoft Teams

1. In Microsoft Teams, on the left navigation pane, select **Apps**.

2. Search for **Dynamics 365**, and then select the **Dynamics 365** tile.

3. In the **Dynamics 365** window, select the down arrow next to the **Add** button, and choose one of the following options:

   - **Add to a team**: Select this option to add the app to a Teams channel. In the **Type a team or channel name** box, enter the name of the team or channel where you want to add the app, and then select it.
   - **Add to a chat**: Select this option to add the app to a chat. In the **Type the name of a person or chat** box, enter the name of the person or chat where you want to add the app, and then select it.
   - **Add to a meeting**: Select this option to add the app to a meeting. In the **Type a meeting name** box, enter the name of the meeting where you want to add the app, and then select it.

   You can also select **Add** to add the app for your personal use and install it for your Microsoft Teams later.

    :::image type="content" source="media/teams-install-options.png" alt-text="Screenshot showing options to add Dynamics 365 app.":::

1. Select **Set up**.

1. In the **Dynamics 365** window, verify the environment name and the app name. To change the environment or app, do the following:
    1. Select the edit icon (:::image type="icon" source="../sales/media/edit-icon.png" border="false":::) next to the app name.
    1. Select the environment and app that you want to connect to, and then select **Select**.
    
   > [!NOTE]
   > - Only environments that contain customer engagement apps (such as Dynamics 365 Sales and Dynamics 365 Customer Service) appear in the list. Also, only active environments (those that are not disabled or provisioning) are displayed. 
   > - Only Unified Interface apps are listed.
   > - Only app modules licensed for the selected environment are listed. 

1. Select **Entity Selection** or **View Selection**.

    1. **Entity Selection**: Select an entity to connect. You can pick a recently viewed record or use search to find records. You can use **Filter by** to narrow the search to an entity type. Once you've picked a record, select **Save**.

    :::image type="content" source="media/teams-entity-view-select.png" alt-text="Screenshot showing entity and view selection options.":::

    2. **View Selection**: Select an entity to see the list of available views. Once you've picked a view, select **Save**.

   > [!NOTE]
   > If you select a personal view (**My Views**) instead of **System Views**, it’s recommended that you share the view with other users before you add the view to the Microsoft Teams channel. Otherwise, other team members will not have access to the view tab content.

After completing the above steps, you'll see a new Dynamics 365 tab in the selected Teams channel, chat, or meeting. 
 
See [Collaborate with Microsoft Teams](teams-collaboration.md#have-a-conversation) for information on how you can use the tab feature to collaborate with Dynamics 365 apps.


<a name="bkmk_setup_dynamics365_bot"></a>

## Government GCC environment 

Teams integration with Dynamics 365 isn't available for Government GCC environments. However, there's a workaround to view records using the Website app in Teams and then adding it as a tab.

1. Open a Teams channel and select **Add a tab**.

2. Search for the **Website** app and add it.

    > [!div class="mx-imgBorder"] 
    > ![Add the Website app.](media/add-website.png "Add the Website app")
  
    > [!NOTE]
    > If you don't see the **Website** app in Teams, ask your administrator to enable this option through the [Microsoft 365 admin center](/microsoft-365/admin/admin-overview/about-the-admin-center).

3. Enter a name for the tab and the URL for your Dynamics 365 app and then select **Save**.

    > [!div class="mx-imgBorder"] 
    > ![Enter name and url for the tab.](media/add-webiste-2.png "Add the Website app")


### See also  
 [Troubleshoot Microsoft Teams integration](teams-troubleshoot.md)



[!INCLUDE[footer-include](../includes/footer-banner.md)]
