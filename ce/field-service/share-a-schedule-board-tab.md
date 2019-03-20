---
title: "Share a schedule board tab | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 03/19/2019
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---


# Share a schedule board tab

The schedule board can have many multiple tabs each showing different resources and requirements typically divided by territory or lines of business.

A schedule board tab can be publicly available to all schedule board viewers (mostly dispatchers), private for just the person who created it, or something in between where specific people can view it.

By default, there exists a schedule board tab called **Initial Public View** that includes all resources and requirements. 

In this article lets explore creating a new schedule board tab and sharing it with specific users.

First go to **Field Service > Schedule Board**


and click the **+** in the top right to create a new tab.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-create-tab.png)


The schedule board tab settings form will appear where you can choose various configurations for the tab. 

The **Shared With** field controls who can see the tab. 

Select **Specific People**


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-shared-with.png)

To assign or share the schedule board tab to specific people you will need to navigate to the record. All schedule board tabs are saved as records in the **Schedule Board Settings** entity.

Go to **Advanced Find** and look for **Schedule Board Settings** and then select Results.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-settings-advanced-find.png)


This will show all schedule board tab records and you should see the one you just created, in our example it is "Schedule Board #3".


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-settings-advanced-find-results.png)


Double click the record to go to the form. 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-share.png)

Select **Share** on the top ribbon.


Finally, use the pop up screen to add users and teams to share the schedule board with along with additional permissions. ANy user or team added here will have see the schedule board tab given they have access to the schedule board.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-share-permissions.png)










