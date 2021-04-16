---
title: "Quickstart: Set up users to create, schedule, and view work orders - Dynamics 365 Field Service | MicrosoftDocs"
description: This quickstart walks through how to set up users to create, schedule, and view work orders in Dynamics 365 Field Service.
ms.custom: 
  - dyn365-fieldservice
ms.date: 04/01/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Quickstart: Set up users to create, schedule, and view work orders

In this quickstart, we'll walk through the core Field Service scenario of creating and scheduling a work order to resolve a customer's issue.

This quickstart walks through four steps:

- **Step 1:** Install Dynamics 365 Field Service
- **Step 2:** Assign Field Service licenses to users
- **Step 3:** Get started with creating frontline workers, customers, and scheduling work orders
- **Step 4:** View the scheduled work order on the Field Service (Dynamics 365) mobile app


## Step 1: Install Dynamics 365 Field Service

You need a Dynamics 365 organization with the Field Service application installed. For more information, see the article on [installing Field Service](install-field-service.md). 


### Verify the Field Service application is installed

Sign in as a system administrator and verify that the Field Service application is listed in the main menu. See the following screenshot for reference. If you don't see Field Service, ensure you are signed in as a system administrator. 

> [!div class="mx-imgBorder"]
> ![Screenshot of Dynamics 365 showing Field Service in the list of apps.](./media/quickstart-apps.png)



## Step 2: Assign Field Service licenses to users

Once you have a Dynamics 365 environment with Field Service, you need to create users or select existing users and assign them a license that includes Dynamics 365 Field Service. For more information, see the article on [setting up Field Service users](view-user-accounts-security-roles.md).

Many different roles interact with Field Service like system administrators, technicians, dispatchers, service managers, inventory managers, customer service representatives and more.

For this quickstart, we'll create two users:

1. Back-office administrator and dispatcher
2. Frontline worker

Sign into [https://admin.microsoft.com/](https://admin.microsoft.com/) as a system administrator.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Microsoft 365 apps menu.](./media/quickstart-o365-admin.png)

Go to **Users** and create at least two users. One to represent a back-office administrator and dispatcher, and another to represent a frontline worker.

Assign each user a license or trial license that includes Dynamics 365 Field Service.

> [!div class="mx-imgBorder"]
> ![Screenshot of active users in the Microsoft 365 admin center](./media/quickstart-o365-admin-users.png)


## Step 3: Create and schedule a work order 

Go to the **Getting Started** page, found in the left navigation pane.

> [!div class="mx-imgBorder"]
> ![Screenshot of the getting started page in Field Service.](./media/gettingstarted1920.png)

After completing all the tasks on this getting started page, you will have successfully scheduled a work order to a frontline worker to resolve a customer's issue. 

### Set up your frontline workers

Start by creating a frontline worker who represents someone in your company who completes work orders. Select the **Set Up** button.

> [!div class="mx-imgBorder"]
> ![Screenshot of the setup your frontline workers section on the getting started page.](./media/getstarted-flw1.png)

In the form, enter required information. Recommended values are prepopulated; don't change these unless necessary. 

Start by choosing the frontline worker user in the **Users** field.

> [!div class="mx-imgBorder"]
> ![Screenshot of the quick setup frontline workers form in Field Service.](./media/getstarted-flw2.png)

You can also send an email to the frontline worker with a link to download the mobile app. For information, see this article [on getting emails set up](frontline-worker-set-up-email-approval.md).

> [!Note]
> **Note 1:** Repeat the frontline worker set up for your back-office users; choose **Field Service-Dispatcher** for the security roles and field security profiles.

> [!Note]
> **Note 2:** If you can't see your users in the dropdown list during the frontline worker setup, see the additional notes section at the end of this article. 

### Create your accounts

Next, create an account that represents one of your customers. Select **Create**.

> [!div class="mx-imgBorder"]
> ![Screenshot of the getting started page in Field Service, showing the create your accounts section.](./media/getstarted-account1.png)

In the form, fill out relevant details.

> [!div class="mx-imgBorder"]
> ![Screenshot of the quick create account form in Field Service.](./media/getstarted-account2.png)

### Create your work orders

Create a work order that outlines work that needs to be done, typically at the customer's location or at the location of an asset or equipment. Select **Create**.

> [!div class="mx-imgBorder"]
> ![Screenshot of the create your work orders section on the Field Service getting started page.](./media/getstarted-wo1.png)

In the form, fill out relevant details. 
 
> [!div class="mx-imgBorder"]
> ![Screenshot of the new work order form in Field Service.](./media/getstarted-wo2.png)

- The **Service Account** represents the customer who the work order relates to. 
- **Tasks** are a checklist of things that need to be done.
- **Products** are parts that may be needed to complete the work order.
- **Services** represents labor that may be needed to complete the work order.

### Schedule your work orders

Finally, you can schedule the work order to a frontline worker who will complete the work. Select **Schedule** to go to the schedule board.

> [!div class="mx-imgBorder"]
> ![Screenshot of the schedule work orders option on the Field Service getting started page.](./media/getstarted-schedule1.png)

Find your work order in the lower pane, then select-and-drag it to your frontline worker.

> [!div class="mx-imgBorder"]
> ![Screenshot of the schedule board, showing a work order getting dragged onto a frontline worker.](./media/getstarted-schedule2.png)

> [!NOTE]
> Make sure you don't schedule the work order in the past. There is a blue vertical line that represents the current time. You may need to adjust the time zone of the schedule board by selecting the gear icon in the top-right of the schedule board.


## Step 4: View the scheduled work order on the Field Service (Dynamics 365) mobile app

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



## Additional notes

If you can't see your users in the frontline worker setup, make sure the users are added to your environment: 

Go to the [Power Apps admin center](https://admin.powerplatform.microsoft.com/).

> [!div class="mx-imgBorder"]
> ![Screenshot of the list of admin centers in the Microsoft 365 admin center.](./media/quickstart-o365-admin-powerapp.png)

Select your environment that has Field Service installed. Select **Settings** > **Users + permissions** > **Users**.

Add the two users you created if they are not already added.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing the new users.](./media/quickstart-ppac-users-add.png)

## See also

- [Perform initial configurations](perform-initial-configurations-setup.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]