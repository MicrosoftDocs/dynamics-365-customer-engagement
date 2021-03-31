---
title: "Get started with Dynamics 365 Field Service | MicrosoftDocs"
description: Learn how to get started with Dynamics 365 Field Service
ms.custom:
- dyn365-fieldservice
ms.date: 04/01/2021
ms.reviewer: krbjoran
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

# Get started with Dynamics 365 Field Service

After you have [installed Dynamics 365 Field Service](install-field-service.md) and have [assigned Field Service licenses to your users](view-user-accounts-security-roles) who need to use the app, you can start adding your frontline workers and scheduling work orders. The best way to do this is to use the new **Getting Started** page, as seen in the following screenshot.

> [!div class="mx-imgBorder"]
> ![Screenshot of the getting started page in Field Service.](./media/gettingstarted1920.png)


At the top of the getting started page, you will see Field Service tours and videos. With each release, we'll highlight new features in the getting started section, so be sure to check back for new highlights.

At the heart of the getting started page, you'll see a set of action items that guide you through core Field Service processes, like creating frontline workers (also called technicians), customers, work orders, and scheduling work orders to frontline workers. 

Finally, at the bottom of the getting started page, you'll find links to release plans to stay up to date with the latest improvements, a support community forum to post questions, and an ideas forum to give product feedback.

## Prerequisites

- The getting started page in Field Service is available with the 2021 Wave 1 release.

- You must have either **System Administrator** or **Field Service - Administrator** privileges to see and use the getting started page.


## Set up your frontline workers

First, you need to set up your frontline workers.

Start by creating a frontline worker. This person is someone in your company who completes work orders. Select the **Set Up** option.

> [!div class="mx-imgBorder"]
> ![Screenshot of the setup your frontline workers option on the Field Service get started page.](./media/getstarted-flw1.png)

In the form, enter required information. Recommended values are prepopulated; don't change these unless necessary. 

> [!div class="mx-imgBorder"]
> ![Screenshot of the quick set up frontline workers form in Field Service.](./media/getstarted-flw2.png)

You can also send an email to the frontline worker, so that they can download the mobile app on their device. For more information about sending emails to frontline workers, see this article: [Send frontline workers an email with a link to download Dynamics 365 Field Service mobile app](frontline-worker-set-up-email-approval.md).

## Create your accounts

Next, create an account that represents one of your customers. Select **Create**.

> [!div class="mx-imgBorder"]
> ![Screenshot of the getting started page in Field Service, with attention to the create your accounts section.](./media/getstarted-account1.png)

In the form, fill out relevant details.

> [!div class="mx-imgBorder"]
> ![Screenshot of the quick create account form in Field Service.](./media/getstarted-account2.png)

**Save and close**.

## Create your work orders

Create a work order that outlines work that needs to be done for a customer, typically at the customer's location or at the location of an asset or equipment. Select **Create**.

> [!div class="mx-imgBorder"]
> ![Screenshot of the getting started page in Field Service, with attention to the create your work orders section.](./media/getstarted-wo1.png)

In the form, fill out relevant details. 

> [!div class="mx-imgBorder"]
> ![Screenshot of the new work order form in Field Service.](./media/getstarted-wo2.png)

- The **Service Account** represents the customer who the work order relates to. 
- **Tasks** are a checklist of things that need to be done.
- **Products** are parts that may be needed to complete the work order.
- **Services** represents labor that may be needed to complete the work order.

## Schedule your work orders

Finally, you'll schedule the work order to a frontline worker. On the getting started page, select **Schedule** to go to the schedule board.

> [!div class="mx-imgBorder"]
> ![Screenshot of the getting started page in Field Service, with attention to the schedule your work orders section,](./media/getstarted-schedule1.png)

Find your work order in the lower pane, then select-and-drag it to your frontline worker.

> [!div class="mx-imgBorder"]
> ![Screenshot of the schedule board, showing a frontline worker being dragged onto the schedule board.](./media/getstarted-schedule2.png)

Congratulations! You have successfully completed the core scenario in Field Service.

## Next steps 

### View the scheduled work order on the mobile app

Frontline workers should download the Field Service (Dynamics 365) mobile app from the iOS or Android app stores onto their phone or tablet. 

- [iOS - Field Service (Dynamics 365) mobile app](https://aka.ms/fsmobile-apple)

- [Android - Field Service (Dynamics 365) mobile app](https://aka.ms/fsmobile-google)

Sign in with the username and password of the frontline worker user.

- For the **Username**, enter the frontline worker's username. For example, username@org.onmicrosoft.com
- For the **Password**, enter the password you set for the frontline worker.

Select your app in the list.

> [!div class="mx-imgBorder"]
> ![Device renders showing the Field Service mobile app.](./media/quickstart-mobile-signin.png)

If you don't see your app, but instead see "Contact your administrator for access to your organization's mobile apps," then select the menu icon and toggle the **Show non-production apps** to _Yes_.

> [!div class="mx-imgBorder"]
> ![Device renders showing "Show non-production apps" setting in the Field Service mobile app.](./media/mobile-2020-error-contact-administrator-show-nonproduction-apps.png)

In the **Booking** tab, see the work order you scheduled to your frontline worker. 

> [!div class="mx-imgBorder"]
> ![Device renders showing the booking on the Field Service mobile app.](./media/quickstart-mobile-work-order.png)


For more information, see the article on [getting started with the Field Service (Dynamics 365) mobile app](mobile-power-app-get-started.md).

### See also

- See the [Field Service user guide](user-guide.md) to explore more parts of Field Service like asset servicing, inspections, agreements, inventory, automated scheduling, and more!











