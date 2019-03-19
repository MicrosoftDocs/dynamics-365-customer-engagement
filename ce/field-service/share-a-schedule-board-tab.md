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


Dynamics 365 Field Service Personal View and Security on Schedule Board

In the above screenshot, you can see the field “Share With” which has three options as below

    Everyone
    Just Me
    Specific People

Once you create the new view, navigate to Advanced Find to share and set permission.

Navigate to Advanced find and select the “Look for:” as “Schedule Board Settings” and click “Results”.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-settings-advanced-find.png)


Dynamics 365 Field Service Personal View and Security on Schedule Board

Once the “Results” is clicked, you can see the record of the view you created in the Schedule board with Share Type

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-settings-advanced-find-results.png)


Dynamics 365 Field Service Personal View and Security on Schedule Board

Double click on the record you created in Schedule board settings. This record gets created when you create new tab in the Schedule Board.

On that record, click on the “Share” button.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-share.png)


Dynamics 365 Field Service Personal View and Security on Schedule Board

Once click on “Share” button, then below screen appears to add or remove users and also set permissions.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-share-permissions.png)


Dynamics 365 Field Service Personal View and Security on Schedule Board


Each schedule board can be shared with specific users i.e. dispatchers with respective territories. You can create the new tab and make them public or keep them private or share with specific people. And also provide the specific permissions by navigating to the record created in Schedule Board settings.
















