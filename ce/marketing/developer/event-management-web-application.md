---
title: "Build and host a custom event portal | MicrosoftDocs"
description: "Provides information about how you can extend event management  web application functionality."
ms.custom:
  - dyn365-developer
  - dyn365-marketing
ms.date: 10/09/2018
ms.service: dynamics-365-marketing
ms.technology: 
  - "marketing"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 6d87f02d-5f2b-4012-85fa-31456c450d83
author: Nkrb
ms.author: nabuthuk
manager: kvivek
---

# Build and host a custom event portal
The Dynamics 365 Event Management feature helps you to organize, manage and process the events. When you install the Event Management solution, you will get an **Event Portal** which gives the users a web application where they can get to know more about the event details. More information: [Event Portal](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/marketing/set-up-event-portal).

The Event Management event portal consists of two parts:
- Frontend (e.g. Angular, Vanilla JS, ..)
- REST API backend

The frontend part is a single page application which is created using the [Angular](https://angular.io) framework. The frontend part of the web application is fully customizable. The backend and the customizability of the backend depend on the hosting type.

There are two hosting types for the event portal:
- [Self-hosted](#self-hosted)
- [Dynamics 365 Portal hosted](#dynamics-365-portal-hosted)

> [!NOTE]
> For the provided demo event portal the [Angular framework](https://angular.io/guide/quickstart) is used. However, since the backend is not dependent of the frontend you can use whatever framework you would like to use.

## Prerequisites
You either can build your own frontend or customize the provided demo event portal. 
To get started with customizing the provided demo event portal you need to follow this steps:
1. Install [Node](https://nodejs.org/en/download).
1. Open Node cmd (or reopen if you have it opened) and run `Node -v` to check whether the installation is successful or not. More information: [Node](https://nodejs.org/en/about).
1. Run the command `npm install -g @angular/cli` to install Angular command line interface (cli). This is required to build and run the angular app. More information: [Angular](https://angular.io).
1. Download the [Source code](https://go.microsoft.com/fwlink/?linkid=2020107).
1. Go to the directory where you have downloaded the source code and run the command `npm install` to fetch all the necessary packages that are required to run the website.

## Configuration
All configuration for your custom event portal can be made by creating an `environment.ts` file in `\src\environments`. This directory contains sample configuration files for different environments (self hosted, portal hosted, development). You can find instructions on how to change the configuration in the related sections [Environment configuration for self hosted](#environment-configuration-for-self-hosted) and [Environment configuration for portal hosted](#environment-configuration-for-portal-hosted).

## Development
Run the command `ng serve` from your working directory to build and locally serve the website. Additionally, this command prints the URL and port where you can reach the application (default is `localhost:4200`). 

## Self hosted
To give our customers full control of the event portal you can host the frontend by yourself.

In order to do so a few additional steps need to be done.

### Dynamics 365 configuration
1. Go to **Dynamics 365 > Settings > Event settings > Web Applications** 
1. Create a new web application
> [!NOTE]
> You need to create a new web application for each origin of which the custom event portal is accessible (most probably you need at least two web applications (for development and production)).

1. Enter an arbitrary `Name`.
1. Enter the `Origin` URL of the custom event portal (e.g. `http://localhost:4200`)  
  > [!NOTE]
  > The origin URL may not contain a trailing slash!
1. If you want to use the [Azure Active Directory](https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/active-directory-whatis) you need to enter the `AAD Client ID` and `AAD Metadata Endpoint`. For more information see section [Configuration for Azure Active Directory](#configuration-for-azure-active-directory).
1. Click save. 
1. After the changes are saved the fields `Token` and `Endpoint` should contain values.

### Environment configuration for self hosted
1. Duplicate the `environment.selfhosted.ts` configuration file (located in `\src\environments`) and name it `environment.ts`.
2. Open the `environment.ts` configuration file for modification.
3. Change the value of the `apiEndpoint` variable to the following endpoint: `{web-application-endpoint}/EvtMgmt/api/v1.0/` where `{web-application-endpoint}` needs to be replaced with value from the `Endpoint` field in the newly created **Dynamics 365 Web Application**.
4. Make sure that the `useRestStack` variable is set to true.
5. Change the `emApplicationtoken` variable to point to the URL from the `Token` field in the newly created **Dynamics 365 Web Application**. 
6. If you want to use the [Azure Active Directory](https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/active-directory-whatis) you need to set the `useAadB2C` variable to `true` and modify the `aadB2CConfig`. You can find detailed instructions on how to do so in section [Configure Azure Active Directory](#configuration-for-azure-active-directory).

### Configuration for Azure Active Directory
The event portal is capable of integrating the Azure Active Directory B2C. To integrate it you need follow this steps:

1. Create B2C tenant. You can find detailed instructions on how to configure and set it up in the [Azure AD B2C documentation](https://docs.microsoft.com/en-us/azure/active-directory-b2c/). 
1. Go to **Dynamics 365 > Settings > Event settings > Web Applications** and select the earlier created **Web Application**.
1. Insert your client ID in the `AAD Client ID` field.
1. Insert your metadata endpoint in the `AAD Metadata Endpoint` field.
1. Save the changes.
1. Open the `environment.ts` configuration file (located in `\src\environments`) for modification.
1. Enter all required values in the `aadB2cConfig` variable.

## Dynamics 365 Portal hosted
The Event Management custom event portal comes as a Dynamics 365 Portal hosted web application when you install the Event Management solution.

The frontend part of the application is bundled into two resource files that are stored as Dynamics 365 Portal web files, and the main single page application entry-point is stored as Dynamics 365 Portal web template. More information about [web files](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/web-files) and [web templates](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/store-content-web-templates).

Although, the frontend definition is hosted on Dynamics 365 Portal, you can still fully customize it. The backend part of the web application is not customizable since the **REST API** endpoints are hosted on Dynamics 365 Portal as a set of [web pages](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/web-page), and the code containing the business logic behind it resides in Event Management plugins which is not customizable.

![Portal Hosted](../media/portal-hosted.png "Portal Hosted")

### Additional project setup
1. To avoid CORS errors you need to add your origin in Portals. To do so, go to **Dynamics 365 > Portals > Site Settings** and add a new setting.
   Insert `HTTP/Access-Control-Allow-Origin` in the name field and the origins that should be allowed in the value field.
2. You need to bypass the anti-CSRF token for local development. To do that, you need to go to **Dynamics 365 > Portals > Web Templates** and open the **PortalAPI** web template and flip the flag `bypassTokenVerification` to `true`. 
3.  Restart the Dynamics 365 Portal website to see the changes.

> [!NOTE]
> The **PortalAPI** web template is added by default when you install the Event Management data.

### Environment configuration for portal hosted
1. Duplicate the `environment.d365.ts` configuration file (located in `\src\environments`) and name it `environment.ts`.
1. Open the `environment.ts` configuration file (located in `\src\environments`) for modification.
2. Change the `apiEndpoint` variable to point to the in **Portal Website Binding** configured URL. _Note:_ You need to add a trailing slash at the end of the URL. 
3. Make sure that the `useRestStack` variable is set to false.

### Building
1. Run `npm install` to make sure that your dependencies are installed and up-to-date.
1. Run `BuildForPortalHosting.ps1` which is located in `/Scripts` to build the application. After the website is successfully built, your output files will show up in `/dist/ClientApp` directory. 

### Deployment
You need to replace the files hosted under portals. 

> [!NOTE]
> You don’t need to change all the files, usually main.js and styles.css files are enough, but it is always good to use some kind of source control tool to track the changes. 

To replace the files in Dynamics 365, follow the steps below:

1.	Open your Dynamics 365 instance.
1.	Navigate to **Portals** and click on **Web Files**.
1.	Open the web file `style.css` .
1.	Scroll down to **Notes** section and delete the existing attachment. 
1.	Upload your `style.css` file as attachment. 
1.  Now, open the web file `main.es` and scroll down to **Notes** section and delete the existing attachment.
1.  Upload your `main.es` file as attachment.
1.	Restart the portal website and reopen your browser.
