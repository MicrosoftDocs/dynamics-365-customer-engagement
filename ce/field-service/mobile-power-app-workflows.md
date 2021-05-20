---
title: "Create workflows and scripts for the Field Service (Dynamics 365) mobile app | MicrosoftDocs"
description: Learn about workflows and scripts for the Field Service (Dynamics 365) mobile app.
ms.custom: 
  - dyn365-fieldservice
ms.date: 05/12/2021
ms.reviewer: krbjoran
ms.topic: article
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

# Workflows and scripts for the Field Service (Dynamics 365) mobile app

Administrators can utilize processes like Dynamics workflows, Power Automate flows, JavaScript, business rules and actions to help frontline workers and automate business processes. Some processes will work when the mobile app is running in [Offline First](mobile-power-app-system-offline.md) and others require internet connectitivty, read this article to understand when to use each based on your business needs. 


## Dynamics workflows and Power Automate flows
Workflows and flows are commonly used to run data validations and auto-populate data based on triggers and conditions. There are many other things to consider when creating workflows and flows. Many Dynamics workflows are being replaced with Power Automate flows, so it is generally recommended to try using Power Automate flows first to be more future proof. Refer to the following doc for a [comparison of workflows and flow](https://docs.microsoft.com/power-automate/replace-workflows-with-flows). 


Workflows and flows will only execute with internet connection. This means workflows and flows will execute when the mobile app is running Online or running in Offline First with internet connection. The mobile app can only run Online when there is no Offline Profile configured. When the app is running in Offline First with an internet connection the user can execute workflows and flows by first saving the record which syncs the changes up to the server and thus triggers the workflow or flow server side, and then syncing the offline data manually or waiting for next sync cadence (5 minutes by default) to pull down the results of the workflow or flow. 


## Business rules
You can create business rules and recommendations to apply form logic without writing JavaScript code or creating plug-ins. Business rules provide a simple interface to implement and maintain fast-changing and commonly used rules. They can be applied to Main and Quick Create forms. 

Business rules will run Online, Offline First with internet connection, and Offline First without internet connection (basically all the time).

## Actions
With Actions, you can perform operations, such as Create, Update, Delete, Assign, or Perform Action. Internally, an action creates a custom message. Developers refer to these actions as ”messages”. Each of these messages is based on actions taken on an entity record. If the goal of a process is to create a record, then update it, and then assign it, there are three separate steps.

Actions will only run when the app is running Online.


## Offline JavaScript
JavaScript web resources can be added to mobile forms and downloaded with Offline First. 

JavaScript will run Online, Offline First with internet connection, and Offline First without internet connection (basically all the time).

## Offline JavaScript example

In some cases, an organization may want to run validation on certain field values after a technician updates an entity. For example, let's say you want to make sure the duration of a work order booking is at least two hours once a technician saves a record in the Field Service (Dynamics 365) mobile app.

Validation can be done with the help of some JavaScript and doing so works online and offline.

See the video on![Video symbol](../field-service/media/video-icon.png "Video symbol") [Field Service (Dynamics 365) mobile app: Offline JavaScript](https://youtu.be/tUdL5YZA29A) for more details.

Go to **Settings** > **Customizations**.

Go to the **Bookable Resource Booking** entity.

Go to **Forms**.

Go to the **Booking and Work Order** form.

Go to **Form Properties** in the top.

> [!div class="mx-imgBorder"]
> ![Screenshot of the lookup record dialog in Power Apps.](./media/mobile-2020-offline-javascript.png)

Create and add a new JavaScript web resource to the form.

Enter in the following code snippet:

```javascript

        function TestOnSave(executionContext) {

            var formContext = executionContext.getFormContext(); // get formContext
            var duration = formContext.getAttribute("duration").getValue();

            formContext.ui.clearFormNotification("DurationErrorMessageId");

            if (duration < 120) {
                executionContext.getEventArgs().preventDefault(); // Stop the Save
                formContext.ui.setFormNotification("Duration must be greater than 2 hours", "ERROR", "DurationErrorMessageId");
        }
    }

```

In the event handlers section, change the event from *onLoad* to *onSave* of the form.

> [!div class="mx-imgBorder"]
> ![Handler properties within the form properties.](./media/mobile-2020-workflows2.png))

Save and publish customizations.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
