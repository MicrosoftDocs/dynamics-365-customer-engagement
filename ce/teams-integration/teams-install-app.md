---
title: "Install the Dynamics 365 app in Teams"
description: "Learn how to install the Dynamics 365 app in Teams."
ms.date: 04/20/2022
ms.topic: article
author: sbmjais
ms.author: shjais
search.audienceType: 
  - enduser
---

# Install the Dynamics 365 app and set up the Microsoft Teams collaboration channel tab

1. In Microsoft Teams, select **Store**. 

   > [!div class="mx-imgBorder"]
   > ![Select Store.](media/select-store.png "Select Store")

2. Search for **Dynamics**, and then select the **Dynamics 365** tile.

   > [!div class="mx-imgBorder"]
   > ![Search for and select Dynamics 365.](media/teams-search-select-dynamics-365-app.png "Search for and select Dynamics 365")

3. Verify that **Add for you** and **Add to a team** are both set to **Yes**.

   You can use the Dynamics 365 app for your own use or use on a Microsoft Teams channel to collaborate with others. If you have an existing Microsoft Teams channel, select both options. Otherwise, you can start installing the app for your personal use and install it for your Microsoft Teams later.

   > [!div class="mx-imgBorder"] 
   > ![Enable personal and team features.](media/teams-store-install-both75.png "Enable personal and team features")

4. For **Add to a team**, choose a team and then select **Install**. 

   > [!div class="mx-imgBorder"] 
   > ![Add to team.](media/teams-store-install-add-team75.png "Add to team")

5. Pick a channel in Microsoft Teams to connect to an app record and then select **Set up**.

   > [!div class="mx-imgBorder"] 
   > ![Pick a channel and select Set up.](media/teams-install-app-step2.png "Pick a channel and select Set up")

6. Select a version 9.x environment and a Unified Interface app to connect, and then select **Save**.

   > [!div class="mx-imgBorder"] 
   > ![Select environment and app module.](media/teams-fre-org-app.png "Select environment and app module")

   > [!NOTE]
   > - Only environments that contain customer engagement apps (such as Dynamics 365 Sales and Dynamics 365 Customer Service) appear in the list. Also, only active environments (those that are not disabled or provisioning) are displayed. 
   > - Only Unified Interface apps are listed.
   > - Only app modules licensed for the selected environment are listed. 

7. Select **Entity Selection** or **View Selection**.

    1. **Entity Selection**: Select an entity to connect. You can pick a recently viewed record or use search to find records. You can use **Filter by** to narrow the search to an entity type. Once you've picked a record, select **Save**.

   > [!div class="mx-imgBorder"] 
   > ![Select an entity.](media/teams-add-channel-pin-record2.png "Select an entity")

    2. **View Selection**: Select an entity to see the list of available views. Once you've picked a view, select **Save**.
    
   > [!div class="mx-imgBorder"] 
   > ![Select a view.](media/teams-select-view.png "Select an view")
   
      > [!NOTE]
   > If you select a personal view (**My Views**) instead of **System Views**, it’s recommended that you share the view with other users before you add the view to the Microsoft Teams channel. Otherwise, other team members will not have access to the view tab content.

8. After completing the above steps, you will see a new Dynamics 365 tab in the selected team channel. 
 
See [Collaborate with Microsoft Teams](teams-collaboration.md#have-a-conversation) for information on how you can use the tab feature to collaborate with Dynamics 365 apps.

<a name="bkmk_setup_dynamics365_bot"></a>

## Government GCC environment 

Teams integration with Dynamics 365 isn't available for Government GCC environments. However, there's a workaround to view records using the Website app in Teams and then adding it as a tab.

1. Open a Teams channel and select **Add a tab**.

  > [!div class="mx-imgBorder"] 
  > ![Open Teams and then select Apps.](media/teams-apps.png "Open Teams and then select Apps")

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
