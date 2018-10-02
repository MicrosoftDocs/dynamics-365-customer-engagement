---
title: "Install the Dynamics 365 for Field Service (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/02/2018
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

# How to install Field Service 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

This article describes how to install the Dynamics 365 for Field Service solution for Dynamics 365 (online). The installation includes the Field Service solution for administrators and dispatchers, the mobile solution for mobile administrators, and the mobile application for field technicians.

Estimated time to complete the installation is 20 minutes.

## Prerequisites

You need a Dynamics 365 organization. If you don't already have one set up, [sign up for a Field Service trial](https://trials.dynamics.com/). 

> [!div class="mx-imgBorder"]
> ![Field Service trial sign-up](media/field-service-trial.png)  

If you would like to purchase Dynamics 365 through a trial, directly, through volume licensing, or through a cloud solution provider, please view more information at the following link: <https://docs.microsoft.com/en-us/dynamics365/customer-engagement/admin/onboard-your-organization-and-users-to-dynamics-365-online>

If you have a Dynamics 365 organization proceed to the next step.

## 2) Add Field Service to your existing D365 organization

You can add Field Service to your D365 organization via a trial or via purchasing.

Log into your Dynamics 365 organization **with a system administrator role**.

To add a trial of Field Service, navigate to **Settings &gt; Microsoft AppSource**

![Field Service Installation  Online  image2](media/Field-Service-Installation-(Online)-image2.png)  

And select a free trial of Field Service

![Field Service Installation  Online  image3](media/Field-Service-Installation-(Online)-image3.png)  

> [!Note]
> **Hint:** make sure to choose the correct D365 organization

Alternatively, you can purchase Field Service by navigating to the **Office365 admin center &gt; Purchase Services**

![Field Service Installation  Online  image4](media/Field-Service-Installation-(Online)-image4.png)  

Installation can take several minutes.

## 3) Check if Field Service is installed in your D365 organization

Log into your Dynamics 365 organization **with a system administrator role**. If Field Service is installed it will appear as an app.

![Field Service Installation  Online  image5](media/Field-Service-Installation-(Online)-image5.png)  

Additionally, if working within the Dynamics 365-custom app, Field Service will appear as a module.

![Field Service Installation  Online  image6](media/Field-Service-Installation-(Online)-image6.png)  

![Field Service Installation  Online  image7](media/Field-Service-Installation-(Online)-image7.png)  

## 4) Install the Field Service mobile solution

Once the Field Service solution is installed, you will need to install the mobile solution. Remember, specific roles of the Field Service solution called field technicians utilize mobile phones and tablets to view and interact with work orders and other important data. You can dispatch, route, and complete work orders, manage invoices, and more with the mobile app. The following steps will enable field technicians to use the mobile application and will allow administrators to customize the mobile experience.

Navigate to <https://www.resco.net/mobilecrm/woodford.html> in an **Internet Explorer** web browser

[!INCLUDE[pn_fieldservice_mobile_app_short](../includes/pn-fieldservice-mobile-app-short.md)] (mobile) is a solution built on the Resco Mobile Dynamics 365 platform. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Frequently asked questions about the Resco app](http://www.resco.net/mobilecrm/support.aspx)  

![Field Service Installation  Online  image8](media/Field-Service-Installation-(Online)-image8.png)  

Install the standalone application.

Next, select Download for 2013, 2015 & 2016 and save the file to a file location other than Downloads.

![Field Service Installation  Online  image9](media/Field-Service-Installation-(Online)-image9.png)  

Navigate back to your Dynamics 365 organization as a system administrator and go to **Settings &gt; Solutions** and **import** the Woodford\_\#\_\#\_\#\_\#\_managed.zip file you downloaded.

![Field Service Installation  Online  image10](media/Field-Service-Installation-(Online)-image10.png)  

![Field Service Installation  Online  image11](media/Field-Service-Installation-(Online)-image11.png)  

![Field Service Installation  Online  image12](media/Field-Service-Installation-(Online)-image12.png)  

The Woodford solution will now appear in the solutions list as well as under Settings

![Field Service Installation  Online  image13](media/Field-Service-Installation-(Online)-image13.png)  

![Field Service Installation  Online  image14](media/Field-Service-Installation-(Online)-image14.png)  

## 5) Import the default mobile configurations

Next, let’s open the Woodford interface. This is done 2 ways.

1.  Open the standalone application you downloaded earlier and log in with your Dynamics administrator credentials

2. **In an Internet Explorer web browser that is NOT private**, navigate to **Settings &gt; Woodford &gt; MobileCRM Woodford**

Set storage quota to 100MB (this is typically only done once)

![Field Service Installation  Online  image15](media/Field-Service-Installation-(Online)-image15.png)  

Register your User

Select **Later** if asked to update the version

Whether via the web browser or via the standalone application, you will be taken to the same interface

![Field Service Installation  Online  image16](media/Field-Service-Installation-(Online)-image16.png)  

After the Woodford solution is installed, you’ll need to download a template that will help you configure the mobile app.

The template is required if you are using the Woodford solution.

The template contains all customizations for the field service mobile app and is called a **project.** This is how administrators customize the mobile experience across all phones and tablets and you can use it to add, remove, and change fields, entities, views, and forms.

Download and save the template file.

-   If you are on December 2016 Update for Dynamics 365 (online), use this [mobile project template](https://go.microsoft.com/fwlink/p/?linkid=836310)  

-   If you are on Dynamics CRM Online 2016 Update 1, use this [mobile project template](http://go.microsoft.com/fwlink/p/?LinkId=808250)  

> [!NOTE]
> You may need to save the template file to a file location on your computer and not the Downloads folder.

Next, import this file into Woodford

![Field Service Installation  Online  image17](media/Field-Service-Installation-(Online)-image17.png)  

And assign it a name, a priority greater than 0, and assign it to all Field Service security roles

![Field Service Installation  Online  image18](media/Field-Service-Installation-(Online)-image18.png)  

More details on projects and priorities can be found in the [Woodford Guide](https://www.resco.net/downloads/Woodford_Guide.pdf).  

Finally, double click on the project (template) to view it.

Select **Publish** making sure the published version matches the version of your mobile app

> [!Note]
> Change the published version to match the version of the app you have installed. To see which version of the mobile app you have installed, open your mobile app and from the home screen, and then tap About.
Make sure to match the first two numbers of the mobile app that you have installed to the published version in the project. If the number of the published version of the project is greater than the app version, you see an error about **unsupported metadata** when you try to sync. The version only needs to match the first decimal.

![Field Service Installation  Online  image19](media/Field-Service-Installation-(Online)-image19.png)  

At this point the mobile configurations are published as evident by the blue arrow next to the project.

![Field Service Installation  Online  image20](media/Field-Service-Installation-(Online)-image20.png)  

> [!Note]
> **Warning:** This is a trial license for Woodford and is valid for **30 days**. The trial can be extended for development and testing purposes. Purchasing a Dynamics 365 for Field Service license entitles you to a limited Woodford license.

Request a Woodford trial extension at the following link: <https://docs.microsoft.com/en-us/dynamics365/customer-engagement/field-service/activate-fs-mobile-app-license>



## 6) Download the Field Service Mobile (2017) application on your phone/tablet

Field technicians and mobile workers will interact with Field Service via a mobile phone/tablet.

Download the **Field Service Mobile (2017)** mobile app from the Windows, iOS, or Android app stores onto your phone, tablet, or Windows 10 device.

![Field Service Installation  Online  image21](media/Field-Service-Installation-(Online)-image21.png)  

## 7) Perform Initial Setup

At this point Dynamics 365 for Field Service is installed. Congratulations!

You are so close to using the application. All that is left to do is

1.  [Set up users and security roles](../field-service/view-user-accounts-security-roles.md)

2.  [Add sample data](../field-service/use-demo-data.md)

3.  perform initial configurations

### Privacy notice  
 [!INCLUDE[cc_privacy_field_service_mobile_app](../includes/cc-privacy-field-service-mobile-app.md)]


