---
title: "Install Dynamics 365 for Field Service (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/11/2018
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
author: krbjoran
ms.assetid: e60e441f-535d-4b38-b371-13e22561d924
caps.latest.revision: 13
ms.author: FieldServiceDave
manager: shellyha
 search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# How to install Dynamics 365 for Field Service 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

This article describes how to install the Dynamics 365 for Field Service application for Dynamics 365 (online). It also includes steps to install the mobile solution, and describes how field technicians . It also provides the steps field technicians follow to install the mobile app from their device's app store.

You can add the Field Service application to a Dynamics 365 organization either for a trial, or as a purchased subscription.

Estimated time to complete the installation is 20 minutes.

## Prerequisites

You need a Dynamics 365 organization with system administrator access. If you don't already have one set up, [sign up for a Field Service trial](https://trials.dynamics.com/). 

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service trial sign-up](media/Field-Service-Installation-(Online)-image1.png)  

## Add a Field Service trial to a Dynamics 365 organization

1. Using system administrator credentials, sign in to the Dynamics 365 organization.

2. To add a Field Service trial of Field Service, go to **Settings > Microsoft AppSource**. Search for Field Service, and then select Field Service free trial.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service tile in AppSource](media/Field-Service-Installation-(Online)-image2.png)  

3. Enter the Dynamics 365 organization name.
> [!div class="mx-imgBorder"]
> ![Screenshot of choosing org](media/Field-Service-Installation-(Online)-image3.png)  

## Add a purchased subscription of Field Service to a Dynamics 365 organization

To purchase Field Service and then add it to an Dynamics 365 organization, go to the **Office365 Admin Center > Purchase Services**. Follow the on-screen instructions to install the application. Installation may take several minutes.
> [!div class="mx-imgBorder"]
> ![Screenshot of purchasing Field Service from Office 365 Admin center](media/Field-Service-Installation-(Online)-image4.png)  


## Verify the Field Service installation

1. WIth system administrator credentials, sign in to the Dynamics 365 organization. 

2. Verify that Field Service is available from the Dynamics 365 drop-down menu.
> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service in left nav bar](media/Field-Service-Installation-(Online)-image5.png)  

3. Additionally, if you're working within the Dynamics 365 custom app, Field Service appears as a module.
 
> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service in Dynamics 365 dropdown menu](media/Field-Service-Installation-(Online)-image7.png)  

## Install the Field Service mobile solution

Once the Field Service solution is installed, you will need to install the mobile solution. Remember, specific roles of the Field Service solution called field technicians utilize mobile phones and tablets to view and interact with work orders and other important data. You can dispatch, route, and complete work orders, manage invoices, and more with the mobile app. The following steps will enable field technicians to use the mobile application and will allow administrators to customize the mobile experience.

In an **Internet Explorer** web browser go to <https://www.resco.net/mobilecrm/woodford.html> 

[!INCLUDE[pn_fieldservice_mobile_app_short](../includes/pn-fieldservice-mobile-app-short.md)] (mobile) is a solution built on the Resco Mobile Dynamics 365 platform. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Frequently asked questions about the Resco app](http://www.resco.net/mobilecrm/support.aspx)  

> [!div class="mx-imgBorder"]
> ![Screenshot of accessing Internet Explorer from Edge](media/Field-Service-Installation-(Online)-image8.png)  

Install the standalone application.

Next, select Download for 2013, 2015 & 2016 and save the file to a file location other than Downloads on your PC.
> [!div class="mx-imgBorder"]
> ![Screenshot of downloading the Woodford solution](media/Field-Service-Installation-(Online)-image9.png)  

Navigate back to your Dynamics 365 organization as a system administrator and go to **Settings > Solutions** and **import** the Woodford\_\#\_\#\_\#\_\#\_managed.zip file you downloaded.
> [!div class="mx-imgBorder"]
> ![Screenshot of solution import view](media/Field-Service-Installation-(Online)-image10.png)  
> [!div class="mx-imgBorder"]
> ![Screenshot of choosing Woodford solution to import into Dynamics](media/Field-Service-Installation-(Online)-image11.png)  
 
After the import has succeeded, the Woodford icon will appear under Settings. You may have to refresh the page.

> [!div class="mx-imgBorder"]
> ![Screenshot of Woodford under Settings menu in Dynamics 365 dropdown menu](media/Field-Service-Installation-(Online)-image14.png)  

## Import the default mobile configurations

Next, let’s open the Woodford admin interface. As a reminder, this is where mobile administrators can manage mobile devices and customize what field technicians and other users will see on the mobile app. 

**In an Internet Explorer web browser that is NOT private**, navigate to **Settings > Woodford > MobileCRM Woodford**

> [!Note]
> Alternatively, the Woodford admin interface can be accessed via a standalone application that is downloaded to your PC. 

Set storage quota to 100MB (this is typically only done once)
> [!div class="mx-imgBorder"]
> ![Screenshot of choosing storage quota](media/Field-Service-Installation-(Online)-image15.png)  

Register your User

Select **Later** if asked to update the version

Whether via the web browser or via the standalone application, you will be taken to the same interface
> [!div class="mx-imgBorder"]
> ![Screenshot of initial Woodford interface](media/Field-Service-Installation-(Online)-image16.png)  

After the Woodford solution is installed, you’ll need to download a template that will help you configure the mobile app.

The template is required.

The template contains all customizations for the field service mobile app and is called a **project.** This is how administrators customize the mobile experience across all phones and tablets and you can use it to add, remove, and change fields, entities, views, and forms.

Download and save the template file.

- [Download the mobile project template for December 2016 Update for Dynamics 365 (online) or later](https://go.microsoft.com/fwlink/p/?linkid=836310)  

- [Download the mobile project template for Dynamics CRM Online 2016 Update 1](http://go.microsoft.com/fwlink/p/?LinkId=808250)  

> [!NOTE]
> You may need to save the template file to a file location on your computer and not the Downloads folder.

Next, import this file into Woodford
> [!div class="mx-imgBorder"]
> ![Screenshot of importing Woodford project template](media/Field-Service-Installation-(Online)-image17.png)  

And assign it a name, a priority greater than 0, and assign it to all Field Service security roles
> [!div class="mx-imgBorder"]
> ![Screenshot of setting details for mobile project](media/Field-Service-Installation-(Online)-image18.png)  

More details on projects and priorities can be found in the [Woodford Guide](https://www.resco.net/downloads/Woodford_Guide.pdf).  

Finally, double click on the project (template) to view it.

Select **Publish** making sure the published version matches the version of your mobile app

> [!Note]
> Change the published version to match the version of the app you have installed. To see which version of the mobile app you have installed, open your mobile app and from the home screen, and then tap About.
Make sure to match the first two numbers of the mobile app that you have installed to the published version in the project. If the number of the published version of the project is greater than the app version, you see an error about **unsupported metadata** when you try to sync. The version only needs to match the first decimal.

> [!div class="mx-imgBorder"]
> ![Screenshot of publishing Woodford project](media/Field-Service-Installation-(Online)-image19.png)  

At this point the mobile configurations are published as evident by the blue arrow next to the project.
> [!div class="mx-imgBorder"]
> ![Screenshot of published mobile project](media/Field-Service-Installation-(Online)-image20.png)  

> [!Note]
> **Warning:** This is a trial license for Woodford and is valid for **30 days**. The trial can be extended for development and testing purposes. Purchasing a Dynamics 365 for Field Service license entitles you to a limited Woodford license.

Request a Woodford trial extension at the following link: <https://docs.microsoft.com/en-us/dynamics365/customer-engagement/field-service/activate-fs-mobile-app-license>



## Download the Field Service Mobile (2017) application on your phone/tablet

Field technicians and mobile workers will interact with Field Service via a mobile phone/tablet.

Download the **Field Service Mobile (2017)** mobile app from the Windows, iOS, or Android app stores onto your phone, tablet, or Windows 10 device.
> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service mobile app in Windows App Store](media/Field-Service-Installation-(Online)-image21.png)  

## Perform Initial Setup

At this point Dynamics 365 for Field Service is installed. Congratulations!

You are so close to using the application. All that is left to do is

1.  [Set up users and security roles](../field-service/view-user-accounts-security-roles.md)

2.  [Add sample data](../field-service/install-sample-data-8-x.md)

3.  perform initial configurations


