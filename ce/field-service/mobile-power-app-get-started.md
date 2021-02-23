---
title: "Install and set up the Field Service (Dynamics 365) mobile app | MicrosoftDocs"
description: Learn how to install and set up the Field Service (Dynamics 365) mobile app.
ms.custom: 
  - dyn365-fieldservice
ms.date: 02/18/2021
ms.reviewer: krbjoran
ms.topic: troubleshooting
ms.service: dynamics-365-customerservice
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Install and set up the Field Service (Dynamics 365) mobile app

The Field Service (Dynamics 365) mobile app is designed and optimized for technicians to view Dynamics 365 Field Service work orders, customer assets, accounts, and contacts. This mobile app is built on Microsoft Power Platform as a [model-driven app](https://docs.microsoft.com/powerapps/maker/model-driven-apps/model-driven-app-overview) and is customizable to your business needs with the same admin console as all Dynamics 365 business apps.


> [!div class="mx-imgBorder"]
> ![Simulated image of the Field Service (Dynamics 365) mobile app on a phone and a tablet.](./media/mobile-2020-tablet-website.png)

For a guided walkthrough, check out the following video.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4HKRL]

## Prerequisites

To use the Field Service (Dynamics 365) mobile app, you must have Dynamics 365 Field Service installed and setup.

See the following articles if you haven't yet setup Field Service:

- [How to install Dynamics 365 Field Service](install-field-service.md)
- [Set up users and security roles](../field-service/view-user-accounts-security-roles.md)
- [Perform initial configurations](perform-initial-configurations-setup.md)
- [Create a Bookable Resource](set-up-bookable-resources.md)


## Install or upgrade Field Service

After installing or upgrading to **Field Service v8.8.22+**, the "Field Service" and "Field Service Mobile" apps will appear in the list of apps when you sign in. You can find these apps by going to:

```https://[your-environment-name].crm.dynamics.com/apps```

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service apps](media/admin-apps.png)

## Assign mobile app users appropriate security roles


- Set up a Dynamics 365 Field Service user with the **Field Service-Resource** security role. This user will sign in to the Field Service (Dynamics 365) mobile app as a technician.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Manage Roles dialogue in Dynamics 365.](./media/mobile-2020-resource-security-role.png)

## Assign security roles to the Field Service Mobile app

- Select the ellipses icon on the **Field Service Mobile** application, then choose **Manage Roles** and assign the app to the **Field Service-Resource**, **Field Service-Administrator**, and other relevant roles that will need access to the mobile app.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Dynamics 365 list of apps, showing the Field Service Mobile solution in the list.](./media/mobile-2020-admin-assign-role-app.png)



## Download app and sign in

Go to the app store on your iOS or Android device and search for **Dynamics 365 Field Service**.

Download the app called **Field Service (Dynamics 365)**, as seen in the following screenshot. It's the mobile app built on the Power Platform.

> [!div class="mx-imgBorder"]
> ![Screenshot of a mobile device app store, showing two Field Service Mobiles in the list, and highlighting the Field Service (Dynamics 365) app.](./media/mobile-2020-download-signin.jpg)

Launch the app and sign in with your username and password, which should be the user credentials of the technician user with the **Field Service - Resource** security role. View the articles on [setting up users and security roles](../field-service/view-user-accounts-security-roles.md) and [creating a Bookable Resource](set-up-bookable-resources.md) for help.

> [!div class="mx-imgBorder"]
> ![Screenshot of sign in](./media/quickstart-mobile-signin.png)

## (Optional) Schedule a work order

- To view work orders on the mobile app, you must also [create a bookable resource](./set-up-bookable-resources.md) related to your technician user and schedule work orders to the bookable resource.

> [!div class="mx-imgBorder"]
> ![Screenshot of the schedule board, showing a list of unscheduled work orders.](./media/mobile-2020-scheduled-work-orders.png)

## Next steps

- [Set up offline data and sync filters](mobile-power-app-system-offline.md)
- [Quickstart: Schedule a work order and view it on the mobile application](quickstart-schedule-work-order.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
