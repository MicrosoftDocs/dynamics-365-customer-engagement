---
title: "Install Dynamics 365 Field Service (Dynamics 365 Field Service) | MicrosoftDocs"
ms.custom: dyn365-fieldservice
ms.date: 2/15/2019
ms.reviewer: krbjoran
ms.suite:
ms.technology:
  - field-service
ms.tgt_pltfrm:
author: FieldServiceDave
ms.author: daclar
ms.manager: shellyhaverkamp
search.audienceType:
  - admin
  - customizer
  - enduser
search.app:
  - D365CE
  - D365FS
---

# How to install Dynamics 365 Field Service

This article describes how to install the Dynamics 365 Field Service application for Dynamics 365 (online). It also includes steps to install the mobile solution, and describes how field technicians download and install the mobile app from their device's app store.

Along with this article, see the video: ![Video symbol](../field-service/media/video-icon.png "Video symbol") [Field Service installation and setup](https://youtu.be/hvcqAbe4g4E)


> [!Note]
> Installations and upgrades of the Field Service application typically take 30 or more minutes.


## Prerequisites

Before you begin, you need a Dynamics 365 (online) organization with system administrator access. If you don't already have one set up, [sign up for a Field Service trial](https://trials.dynamics.com/). 


> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service trial sign-up](media/field-service-trial-signup.png)

## Install the application
You can add a trial or a purchased subscription of the Field Service application to a Dynamics 365 organization.

### Add a Field Service trial to a Dynamics 365 organization

1. Using system administrator credentials, sign in to the Dynamics 365 organization.

2. Go to **Settings > Microsoft AppSource**. Search for **field service trial**, select **Dynamics 365 Field Service trial**, and then select **Free Trial**.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service tile in AppSource](media/field-service-trial-appsource.png)


1. In the **Organization to add the application to** drop-down list, select the Dynamics 365 organization name. Review the terms and conditions, and then select **Agree**. Installation may take several minutes. 

> [!div class="mx-imgBorder"]
> ![Screenshot showing selection of the organization name from the drop-down list](media/field-service-select-organization.png)

### Purchase a subscription of Field Service and add it to a Dynamics 365 organization

1. On the **Office365 Admin Center** go to **Billing > Purchase Services**.
2. Select **Dynamics 365 Field Service Enterprise Edition**, and then select **Buy now**.
3. Follow the on-screen instructions to install the application. Installation may take several minutes.
> [!div class="mx-imgBorder"]
> ![Screenshot of purchasing Field Service from Microsoft 365 admin center](media/field-service-purchase.png)

### Verify that the installation is complete

1. If the installation of Field Service is complete, the Field Service app will appear in the Dynamics 365 main menu when logged in as a system administrator.
> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service in navigation](media/field-service-navigation.png)


In previous versions, Field Service appears in the Dynamics 365 custom application sitemap.
 
> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service in Dynamics 365 dropdown menu](media/field-service-menu.png) 


## Download the Field Service Mobile app on a phone or tablet

> [!Note]
> You will not be able to use the Field Service Mobile application with your Dynamics 365 organization until you have followed all of the steps below and set up users and [bookable resources enabled for mobile app access](set-up-bookable-resources.md).

Dynamics 365 Field Service provides the cross-platform, multi-device Field Service Mobile application that is specifically crafted to the field service worker's needs. The mobile application is entirely customizable and extensible, allowing any organization to brand the application as its own, define what types of data field service workers can access, and much more.

To get the mobile app, download **Field Service Mobile** from the Windows, Apple, or Google Play app stores, or visit the following links. **Field Service Mobile** requires Field Service versions **7.5.5** and **8.2+**.

- [Download for Windows](https://aka.ms/fsmobile-windows)
- [Download for iOS (Apple)](https://aka.ms/fsmobile-iOS)
- [Download for Android](https://aka.ms/fsmobile-android)

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service mobile app download example](media/mobile-field-service-mobile-windows-app-store.png)


## Install the Field Service Mobile configuration tool

The configuration tool allows app access for field technician users, and allows administrators to customize the mobile experience.

1. [Download the mobile configuration tool](https://www.resco.net/woodford/download) and save to your computer.



2. In the Dynamics 365 organization, go to **Settings > Solutions**. Select **Import**. 

> [!div class="mx-imgBorder"]
> ![Screenshot of solution import view](media/field-service-mobile-solution-import.png)


3. On the **Select Solution Package** screen, select the Woodford\_\#\_\#\_\#\_\#\_managed.zip file, and then select **Next**.

> [!div class="mx-imgBorder"]
> ![Screenshot of selecting the Woodford solution zip file for importation](media/field-service-mobile-solution-import-file.png)

4. After the import completes, verify that **Woodford** appears on the **Settings** menu. If you don't see it, refresh the page.

> [!div class="mx-imgBorder"]

> ![Screenshot of Woodford under Settings menu in Dynamics 365 drop-down menu](media/field-service-mobile-solution-import-dropdown.png)  


## Import the mobile project template

After you install the Field Service Mobile configuration tool, you need to download and import a mobile project that allows you to configure the mobile app for your organization.

The mobile project template contains all customizations for the Field Service Mobile app. A mobile project allows you to customize the mobile experience across devices. For example, you use a mobile project to add, remove, and change fields, entities, views, and forms on the mobile app.

1. Open the Mobile Configuration Tool (Woodford) by going to **Settings > Woodford** and selecting **MobileCRM Woodford HTML5**. If you experience trouble opening or performing functions in the HTML5 version, you can use the MobileCRM Woodford Legacy in a non-private Internet Explorer browser window.

> [!div class="mx-imgBorder"]
> ![Screenshot of Woodford admin interface](media/mobile-install-mobilecrm-woodford.png)

2. You may be asked to set a storage quota. Set to **500MB**, and then select **OK**.

3. Register yourself as a user.

4. [Download mobile project for **Field Service Mobile** (latest) Field Service v7.5.5 and v8.2+](https://aka.ms/fsmobile-project) and save in a location other than the Downloads folder. NOTE: If you have an existing mobile project from a previous app version, you will need to manually move the customizations for that project into a derivative of this project.

- The mobile project is updated periodically; [bookmark this website](https://aka.ms/fsmobile-project) for regular access the latest mobile project.

**For previous mobile apps** for D365 for Field Service, use the following mobile projects:

- [Download mobile project for **Field Service Mobile (2017)** Field Service v6.1](https://go.microsoft.com/fwlink/p/?linkid=836310).
- [Download mobile project for **Field Service Mobile (2016)** Field Service v6.0](https://go.microsoft.com/fwlink/p/?LinkId=808250).


5. Import the mobile project file.
> [!div class="mx-imgBorder"]
> ![Screenshot of importing mobile project template](media/field-service-mobile-project-template.png)

6. In the **Add Mobile Project** dialog,

 - enter the name of the mobile project file
 - enter a priority value
 - assign the template to all field service security roles
 - Select **OK**

> [!div class="mx-imgBorder"]
> ![Screenshot of setting details for mobile project](media/field-service-mobile-project-details.png)

7. Select and highlight the mobile project template and select **Derive**.

> [!div class="mx-imgBorder"]
> ![Screenshot of setting details for mobile project](media/mobile-install-project-derive.png)

- Enter a name, a higher priority, and assign to relevant field service security roles.

> [!div class="mx-imgBorder"]
> ![Screenshot of setting details for mobile project](media/mobile-install-project-derive-details.png)

8. Double-click the mobile project template parent, and then select **Publish All**.

> [!Note]
> For Field Service Mobile v11.2, publish to 11.2.

> [!div class="mx-imgBorder"]
> ![Screenshot of publishing mobile project](media/mobile-install-project-publish-all.png)

9. Verify the mobile configurations are published by checking for an arrow next to the projects.
> [!div class="mx-imgBorder"]
> ![Screenshot of published mobile project with arrow showing status](media/mobile-install-project-verify-publish.png)

> [!Note]
> This is a trial license and is valid for 30 days. The trial can be extended by following the guidance in this topic: [Extend Field Service Mobile configuration tool trial](../field-service/activate-fs-mobile-app-license.md).



## Next steps
- [Set up users and security roles](../field-service/view-user-accounts-security-roles.md)
- [Enable Bookable Resources for mobile app access](set-up-bookable-resources.md)
- [Add sample data](../field-service/install-sample-data-8-x.md)

### See also

- [Frequently asked questions about the mobile solution](http://www.resco.net/mobilecrm/support.aspx)
- [Woodford guide](https://www.resco.net/downloads/Woodford_Guide.pdf)
