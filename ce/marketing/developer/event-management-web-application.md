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

The Event Management custom event portal consists of two parts:
- Angular frontend
- REST API backend

The frontend part is a single page application which is created using the [Angular](https://angular.io) framework. The frontend part of the web application is fully customizable. The backend and the customizability of the backend depend on the hosting type.

There are two hosting types for the custom event portal:
- [Dynamics 365 Portal hosted](#dynamics-365-portal-hosted)
- [Self-hosted](#self-hosted)



## (Dynamics 365 Portal hosted)[#dynamics-365-portal-hosted]
The Event Management custom event portal comes as a Dynamics 365 Portal hosted web application when you install the Event Management solution.

The frontend part of the application is bundled into two resource files that are stored as Dynamics 365 Portal web files, and the main single page application entry-point is stored as Dynamics 365 Portal web template. More information [web files](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/web-files) and [web templates](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/store-content-web-templates).

Although, the frontend definition is hosted on Dynamics 365 Portal, you can still fully customize it. The backend part of the web application is not customizable since the **REST API** endpoints are hosted on Dynamics 365 Portal as a set of [web pages](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/web-page), and the code containing the business logic behind it resides in Event Management plugins which is not customizable.

![Portal Hosted](../media/portal-hosted.png "Portal Hosted")

### Developing and customizing the web application on Dynamics 365 Portal hosted backend

To develop and customize the frontend part of the web application:

1. Download the [Source code](https://go.microsoft.com/fwlink/?linkid=2020107).
1. Install [Node](https://nodejs.org/en/download).
1. Open Node cmd (or reopen if you have it opened) and run `Node -v` to check whether the installation is successful or not. More information: [Node](https://nodejs.org/en/about).
1. Run the command `npm install -g @angular/cli` to install Angular command line interface (cli). This is required to build and run the angular app. More information: [Angular](https://angular.io).
1. Go to the directory where you have downloaded the source code and run the command `npm install`to fetch all the necessary packages that are required to run the website.
1. Create a new Chrome shortcut and add `--disable-web-security --user-data-dir="C:\chromeTest"` to bypass the same origin policy.
1. Go to `\src\app\providers\url.providers.ts` in the source code to point the frontend to the correct API endpoint and change the return value in the `baseURL()` method to your API. You need to add a trailing slash at the end of the url.
1. Bypass anti-CSRF token for local development. To do that, you need to go to **Portals > Web Templates** and open the **PortalAPI** web template and flip the flag `bypassTokenVerification` to `true`. 
1. Restart the Dynamics 365 Portal website to see the changes.

> [!NOTE]
> The **PortalAPI** web template is added by default when you install the Event Management data.

- Run the command `ng serve` from your working directory to build the website and open the website url in the chrome instance with the shortcut you have created.

After the website is successfully built, your output files will show up in `/dist/ClientApp` directory. You need to replace the files hosted under portals. You don’t need to change all the files, usually main.js and styles.css files are enough, but it is always good to use some kind of source control tool to track the changes. 

To replace the files in Dynamics 365, follow the steps below:

1.	Open your Dynamics 365 instance.
2.	Navigate to **Portals** and click on **Web Files**.
3.	Open the web file `style.css` .
4.	Scroll down to **Notes** section and delete the existing attachment. 
5.	Upload your `style.css` file as attachment. 
6.  Now, open the web file `main.js` and scroll down to **Notes** section and delete the existing attachment.
7.  Rename your `main.js` to `main.es` and upload the file as attachment.
9.	Restart the portal website and reopen your browser.


<!--### Developing and Customizing web application on self-hosted backend

To develop and customize the frontend part of the web application:

1. Download the [Source code](https://go.microsoft.com/fwlink/?linkid=2020107).
1. Install [Node](https://nodejs.org/en/download).
1. Open Node cmd (or reopen if you have it opened) and run `Node -v` to check whether the installation is successful or not. More information: [Node](https://nodejs.org/en/about).
1. Run the command `npm install -g @angular/cli` to install Angular command line interface (cli). This is required to build and run the angular application. More information: [Angular](https://angular.io).
1. Go to the directory where you have downloaded the source code and run the command `npm install`to fetch all the necessary packages that are required to run the website.
1. Create a new Chrome shortcut and add `--disable-web-security --user-data-dir="C:\chromeTest"` to bypass the same origin policy.
1. Go to `\src\app\providers\url.providers.ts` in the source code to point the frontend to the correct API endpoint and change the return value in the `baseURL()` method to your API. You need to add the trailing slash at the end of the url.
1. Run the command `ng serve` from your working directory to build the website and open the website url in the chrome instance with the shortcut you have created.

After the website is build successfully, the output files will show up in `/dist/ClientApp`. You need to copy those files to the root directory of your web server, replacing the existing ones.-->

## Building and deploying website

let's make some simple changes on the website that you have created. 
- Go to `\src\app\components\home\home.component.html` to add extra paragraph or content that describes the event details or about the event.
- You can change or add styling to the website by editing the `home.component.css` file in `\src\app\components\home\home.component.css`.
- After you make necessary changes, run the command `ng build --prod --output-hashing none` to build and deploy the latest changes for self-hosted backend.
- Run the command `BuildForPortalHosting.ps script`, if you are using Dynamics 365 Portal hosted backend.

> [!NOTE]
> For extensive customization of the frontend you need to be familiar with the [Angular framework](https://angular.io/guide/quickstart).




