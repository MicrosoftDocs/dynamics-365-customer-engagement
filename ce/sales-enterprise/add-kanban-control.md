---
title: "Add the Kanban control to Opportunity or Activity entities (Dynamics 365 Sales) | MicrosoftDocs"
description: "Add the Kanban control to the Opportunity or Activity entity. The Kanban control enables salespeople to monitor their pipeline, see where opportunities are in a business process flow, or track their activities efficiently."
ms.date: 02/03/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Add the Kanban control to Opportunity or Activity entities

[!INCLUDE [cc-early-access-2020w1](../includes/cc-early-access-2020w1.md)]  

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Kanban views help salespeople to manage their opportunities and activities effectively. Add the Kanban control to the Opportunity and Activity entity so salespeople can use the Kanban views.

To add the control:
1.	In your app, select the **Settings** icon, and then select **Advanced Settings**.

    > [!div class="mx-imgBorder"]  
    > ![Advanced Settings link in the site map](media/advanced-settings-option.png "Advanced Settings link in the site map")

    The Settings page opens in Power Platform Admin center.

2.  Expand the **Resources** section, and select **All legacy settings**. 

    > [!div class="mx-imgBorder"]
    > ![Option to open legacy settings](media/legacy-settings-power-platform-admin-center.png "Option to open legacy settings")
    
    The Business Management page appears.

3.	On the navigation bar, select **Settings** and then under **Customization**, select **Customizations**.

4.	Select **Customize the System**.

5.	Under **Components** in the solution explorer, expand **Entities** and then select **Opportunity** or **Activity**.

6.	Go to the **Controls** tab and select **Add Control**.

    > [!div class="mx-imgBorder"]  
    > ![Read-only Grid control selected as default](media/read-only-grid-control.png "Read-only Grid control selected as default")

7.	In the **Add Control** dialog box, select **Kanban** and then select **Add**.

    > [!div class="mx-imgBorder"]  
    > ![Add Control dialog box](media/add-control-dialog-box.png "Add Control dialog box")

    The Kanban control is added to the list of controls.

8.	The Read-only grid is the default option, so when users select **Opportunities** from the site map, they see a read-only grid of opportunities. To make the Kanban view the default view instead, select the radio button for the Kanban control for the corresponding options.  

    > [!div class="mx-imgBorder"]  
    > ![Make the Kanban view the default view](media/make-kanban-view-default.png "Make the Kanban view the default view") 

9.	Select **Save** to save your changes.

10.	To publish the changes you’ve made, select **Publish**.


### See also

[Work with opportunities in the Kanban view](opportunity-kanban-view.md)  

[Work with activities in the Kanban view](activity-kanban-view.md)
