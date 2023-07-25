---
title: "Add a custom app module to the Field Service (Dynamics 365) mobile app | MicrosoftDocs"
description: Learn how to make a custom app module for the Field Service (Dynamics 365) mobile app.
ms.date: 05/21/2021

ms.subservice: field-service-mobile
ms.topic: article
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
author: Andrea-Orimoto
ms.author: andreo
---

# Add a custom app module to the Field Service (Dynamics 365) mobile app

While we recommend using the standard "Field Service Mobile" app module, there may be times when an organization wants to give frontline workers access to an additional custom app module to assist in other business use cases and processes.

In this article, we'll describe how to make an additional Dynamics 365 model-driven app available to frontline workers from within the Field Service (Dynamics 365) mobile app. 

In this article, we will walk through:

1. Creating a custom app module based on the "Field Service Mobile" app module.
2. Adding the custom app module to the "Field Service Mobile" app module.

> [!Note]
> At this time, custom app modules will not include booking travel calculations. Travel calculations must be implemented via customization if not using the standard Field Service mobile app module.


## Create a custom app module based on "Field Service Mobile"

In this section, we'll create a custom app module based on the "Field Service Mobile" app module, as seen in the following screenshot. 

![Field Service (Dynamics 365) mobile, showing a custom app module.](media/image6.png)

By leveraging the components and sitemap of the Field Service mobile app, you'll have a great starting point from which you can customize your experience.

To create a new "Field Service Mobile" app module:

1. In Dynamics 365, go to the list of your app modules and select the option to **+ Create New App**.

![The "Create new App" option in Field Service.](media/image1.png)

2.  **Create a New App** will transition to the app designer screen, enter your app name and other optional detail.  Expand "Advanced" and "Use components from a custom solution". Set "Field Service" as the solution "Field Service Mobile" as the sitemap. This will pull in all sitemap entries of the out of box Field Service Mobile app module. Select **Create**.

![The "Create a New App" screen in Power Apps.](media/creatappmodule-name-solution.jpg)

4. Your new app module will be created with all out of the box Field Service Mobile entites. You can now add items to the sitemap and begin customizing your app module. 

5. After adding items to the sitemap, **Publish** the app module.

## Make the custom app module available in "Field Service Mobile" 

Once the custom app module is created, you'll need update the mobile app Player which can access the app module. 

To make the app module available to the Field Service mobile app:

![setting "Primary Mobile Player" in Power Apps.](media/mobile-primarymobileplayer.jpg)

1. In the App Designer, click on "Settings".
2. Scroll to the bottom of the "General" settings and expand "Advanced settings"
3. Set the value of "Primary Mobile Player" the "Field Service (Dynamics 365)"
4. Close the Settings dialog, Save and Publish your app module.

After following these steps, you shoudl now see the custom app module available in the app picker screen after signing into the Field Service Mobile application. 

> [!Note]
> If you do not see the App Module available, try these troubleshooting tips:
> 1. Check the Roles assigned to the app module ane ensure the user accessing the app module has the same role
> 2. If in a sandbox environment, ensure "Show non-production apps" toggle is configured in the mobile app to show non-production app modules. 



