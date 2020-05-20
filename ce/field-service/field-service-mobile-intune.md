---
title: "Device and app management with Microsoft Intune | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 02/03/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Manage Field Service Mobile with Microsoft Intune

Mobile Application Management (MAM) is software that enables IT administrators to apply and enforce corporate policies on mobile apps. One MAM option for IT administrators is [Microsoft Intune](https://docs.microsoft.com/intune/apps/app-management), which offers a suite of features that lets you publish, push, configure, secure, monitor, and update mobile apps - including Field Service Mobile.

MAM is important to field service organizations whose technicians use Field Service Mobile primarily because:

1. Technicians frequently travel to multiple locations, and protecting sensitive company data is critical.
2. Many field service organizations have a bring-your-own-device (BYOD) policy, which means the Field Service Mobile app needs management among many different kinds of devices and apps for personal use. 

With an Intune-enabled Field Service Mobile app, IT administrators can:
- Add and assign the Field Service Mobile app to user groups and devices, including users in specific groups, devices in specific groups, and more.
- Configure the Field Service Mobile app to open with specific settings enabled, and update the app when already installed on the device.
- See reports and track app usage.
- Limit sharing of corporate data among apps by restricting data leakage through “Cut/Copy/Paste/Save As.”
- Provide encryption at rest.

## Prerequisites

- Field Service Mobile v12.1+ for iOS and Android
- No Field Service Mobile Configurator (Woodford) requirements 


## Get started
Intune is a separate Microsoft product that is not included with Field Service. Refer to the documentation on [What is Microsoft Intune app management?](https://docs.microsoft.com/intune/apps/app-management) and [Adding and assigning an app with Intune](https://docs.microsoft.com/intune/apps/quickstart-add-assign-app) to get started.

## Prefill default Org URL in sign in screen

Field Service Mobile (FSM) can be configured through Device Management portal . This option allows administrator to pre-configure the app for a certain behavior or pre-fill some values before first use. The configuration is available only for devices enrolled to MDM

Supported Properties
Currently only these configuration properties are supported

| Property Name / Configuration | Key	Type	| Notes |
| --- | ---- | --- |
| IntuneMAMUPN	| string |	Required. Must be set to value {{UserPrincipalName}} |
| DefaultOrgUrl	| string |	Allows to configure Dynamics 365 organization's url which is pre-filled on Sign In page |

#### Creating an app configuration
An configuration can be set up through Device Management portal . Each supported platform (iOS, Android and Windows) requires a separate configuration. Check Intune integration in FSM wiki page for more details on how to get access to the portal.

Registering FSM app in Device Management portal
In order to be able to create an app configuration we need to register/add FSM for a tenant in Device Management portal.

Go to Apps **(1)** -> All apps **(2)** and click + Add button **(3)**


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-intune1.png)

Select App type **(4)** and then fill App information **(5)**
if you want to use app that is not in store, choose Line-of-business App type


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-intune2.png)

Click Add
Navigate to Assignments **(6)** and click Add group **(7)**. Choose Available for enrolled devices as Assignment type and select users or groups which should be included.
you can choose other assignment types per your business needs


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-intune3.png)

The app should be now available to download through Company Portal app on device.
Note: iOS requires to install the app through the Company portal app first in order to be able to download the app configuration. After first install you can sideload your custom version of the app onto the device and app configuration policy will still be there

#### Configuring Android/iOS

In Device Management portal navigate to Apps **(1)**, then go to App configuration policies **(2)** and click Add **(3)**

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-intune4.png)

Enter name **(4)**, select Managed devices as Device enrollment type **(5)**, select Platform **(6)**, click Associated app **(7)** and pick an app registered in previous section **(8)**.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-intune5.png)

Click on Configuration settings **(9)**, select Use configuration designer as Configuration settings format **(10)** and enter configuration settings **(11)**. Save settings and click Add.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-intune6.png)

Navigate to Assignments and select a group which the policy should be assigned to
Configuring Android (alternative way)
In Device Management portal navigate to Apps **(1)**, then go to App configuration policies **(2)** and click Add **(3)**


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-intune7.png)

Enter name **(4)**, select Managed apps as Device enrollment type **(5)** and click on Associated app **(6)**


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-intune8.png)

you can either select the app from the list of featured apps or add new by using app bundle/package id


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-intune8-5.png)

Click on Configuration settings **(7)** and enter configuration settings **(8)**. Save settings and click Add.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-intune9.png)

Navigate to Assignments and select a group which the policy should be assigned to

Note: This configuration will be available also to iOS app once you authenticate within the app

#### Configuring Windows
In device Management portal navigate to Devices **(1)**, Configuration profiles **(2)** and click Create profile **(3)**


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-intune10.png)

Enter name **(4)**, select Windows 10 and later as Platform **(5)**, select Custom as Profile type **(6)**. This will open Custom OMA-URI Settings page where you click Add **(7)**
Fill Name **(8)**, OMA-URI **(9)**, Data type **(10)** and Value **(11)**
Put property name to Name field
OMA-URI has a following format ./User/Vendor/MSFT/EnterpriseModernAppManagement/AppManagement/AppStore/{PackageFamilyName}/AppSettingPolicy/{PropertyName}
where PackageFamilyName is Microsoft.FieldService-D365_8wekyb3d8bbwe for Field Service Mobile (cann be found in appxmanifest file) and PropertyName is same as we entered in Name field


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-intune11.png)

Apply changes and create profile
Navigate to Assignments and select a group which the policy should be assigned to

#### Testing

Android/iOS

Download Company Portal app and sign-in with an organization account
Install FSM from the Company portal app
Start FSM

Windows

Got to Settings -> Access work or school and click Connect
Sign in with your organization account
Install the app


## Additional notes
- MAM with Intune for Field Service Mobile will work with or without MDM device enrollment.


