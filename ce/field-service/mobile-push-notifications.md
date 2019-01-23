---
title: "Push Notifications | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 01/22/2019
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

# Push Notifications

> [!Note]
>

## Prerequisites

Field Service v7.5.5 and v8.3+  

Field Service Mobile v11.1+ for Windows, iOS, or Android devices. You can verify your mobile app version in the **About** section

You have consented to notifications in your device's settings for the **Field Service Mobile** app

## Verify push notifications are activated

Navigate to **Settings > Solutions** and verify the **Field Service Mobile Push Notifications** solution is installed. If it is not installed you will need to upgrade to the Field Service v8.3+ solution.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-solution.png)

Part of this solution is a workflow titled **Notify user about booking** that must be Activated. If it is not activated navigate to the default solution or an unmanaged solution via **Settings > Customizations > Customize the system > Processes** and activate it.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-solution-details.png)

## Schedule a work order and view push notifications

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-schedule-board.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-banner.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-notification-center.png)




## Create a custom push notification

**Settings > Customizations > Customize the system > Processes > +New**

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-custom-workflow1.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-custom-workflow2.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-custom-workflow3.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-workflow-template.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-custom-workflow4.png)
## Configuration considerations
## Additional Notes

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-entity-not-found.png)
