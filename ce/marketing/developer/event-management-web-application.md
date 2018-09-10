---
title: "Event Management Web Application | MicrosoftDocs"
description: "Provides information about how you can extend event management  web application functionality."
ms.custom:
  - dyn365-developer
  - dyn365-marketing
ms.date: 09/06/2018
ms.service: dynamics-365-marketing
ms.technology: 
  - "marketing"
ms.topic: "get-started-article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 6d87f02d-5f2b-4012-85fa-31456c450d83
author: Nkrb
ms.author: nabuthuk
manager: kvivek
---

# Build and host custom event portal

The Dynamics 365 Event Management feature helps you to organize, manage and process events. when you install Event Management module you will get Event Portal which gives the users an web application where they can know more about the event details. More information: [Even Portal](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/marketing/set-up-event-portal).

> [!NOTE]
>  You need to have Dynamics 365 for marketing installed.

The Event Management web application consists of two parts:
1. Angular frontend
2. Rest API backend

Frontend part is a single page application which is created using [Anuglar](https://angular.io) framework. The frontend part of the web application is fully customizable. Backend and customizability of the backend depends on hosting type.

There are two ways Event Management web application can be hosted.
1. Dynamics 365 Portal hosted
2. Self-hosted

## Dynamics 365 Portal hosted
Event Management web application comes as a Dynamics 365 Portal hosted web when you install Event Management module.

Frontend part of the app is bundled into couple of resource files that are stored as a Dynamics 365 Portal web-files, and main single page app entry-point is stored as a Dynamics 365 Portal web template. More information [web-files](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/web-files) and [web templates](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/store-content-web-templates).

Although frontend definition is hosted on Dynamics 365 Portal, you can still fully customize it. The backend part of the web application is not customizable since the REST API endpoints are hosted on Dynamics 365 Portal as a set of [web pages](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/web-page), but the code containing the business logic behind it resides in Event Management plugins.

## Self-hosted
The advantage of self-hosted backend is that you have more freedom with customization, implement the backend with the technology of  your choice. 

You can use the demo backend and data contract for communication between the frontend and the backend as a starting point, but you can also define your own contract and modify the frontend accordingly. 

For backend to communicate with your Dynamics 365 instance, you need to take care of Dynamics 365 authentication and use Dynamics 365 webservice. You need to implement authentication mechanism by yourself, depending on the technology you selected for the backend. If you want event registration to be linked to appropriate user who created it, make sure that you create Dynamics 365 contact for every new website user. 

Dynamics 365 authentication and web application authentication are two different things. In the first case we are talking about Dynamics 365 user that backend needs to use to be able to utilize Dynamics 365 web API, and in second case we are talking about your `local` website users, that you don’t strictly have to have. 

It is alwats a good practice to host both frontend and backend on the same domain to comply to same-origin policy. The communication between application parts and Dynamics 365 in this case looks like this.

## Developing and Customizing web application on self-hosted 

To develop and customize the frontend part of the web application:

1. Download the [TODO: source code].
1. Install [Node](https://nodejs.org/en/download).
1. Open Node cmd (or reopen if you have it opened) and run `node-v` to check whether the installation is successful or not. More information: [Node.js](https://nodejs.org/en/about).
1. Run the command `npm install -g @anuglar/cli` to install angular command line interface (cli). This is required to build and run the angular app. More information: [Angular](https://angular.io).
1. Go to project directory where you have downloaded the source code and run the command `npm install`to fetch all the necessary packages that are required to run the website.
1. Create a new Chrome shortcut and add `--disable-web-security--user-data-dir="C:\chromeTest"` to bypass the same origin policy.
1. Go to `\src\app\providers\url.providers.ts` in the source code to point the frontend to the correct API endpoint and change the return value if the `baseURL()` method to your API. You need to add the trailing slash at the end of the url.
1. Run the command `ng serve` from your working directory to build the website and open the website url in the chrome instance with the shortcut you created.

After the website is build successfully, the output files will show up in `/dist/ClientApp`. You need to copy the files to the root directory of your web server, replacing the existing ones.

## Developing customizing the webapplication on Dynamics 365 Portal hosted backend

1. Download the [TODO: source code].
1. Install [Node](https://nodejs.org/en/download).
1. Open Node cmd (or reopen if you have it opened) and run `node-v` to check whether the installation is successful or not. More information: [Node.js](https://nodejs.org/en/about).
1. Run the command `npm install -g @anuglar/cli` to install angular command line interface (cli). This is required to build and run the angular app. More information: [Angular](https://angular.io).
1. Go to project directory where you have downloaded the source code and run the command `npm install`to fetch all the necessary packages that are required to run the website.
1. Create a new Chrome shortcut and add `--diable-web-security--user-data-dir="C:\chromeTest"` to bypass the same origin policy.
1. Go to `\src\app\providers\url.providers.ts` in the source code to point the frontend to the correct API endpoint and change the return value if the `baseURL()` method to your API. You need to add a trailing slash aat the end of the url.
1. Bypass anti-CSRF token for local development. To do that you need to go to **Portals > Web Templates** and open the **PortalAPI** template and flip the flag `bypassTokenVerification` to `true`. Restart the Dynamics 365 Portal website to see the changes.
- Run the command `ng serve` from your working directory to build the website and open the website url in the chrome instance with the shortcut you created.

After the website is successfully built, your output files will show up in `/dist/ClientApp` directory. You need to replace the files hosted under portals. You don’t need to change all the files, usually main.es and styles.css files are enough for most of the changes, but it is always advised to use some kind of source control tool to track the changes. 

To replace the files in Dynamics 365, follow the steps below:

1.	Open your Dynamics 365 instance.
2.	Navigate to **Portals** and click on **Web Files**.
3.	Open the web file style.css.
4.	Scroll down to **Notes** section and delete the existing attachement. 
5.	Upload your file as attachment. 
9.	Restart the portal website and reopen your browser.

### Building and deploying website
let's make some simple changes on the website you have created. 
- Go to `\src\app\components\home\home.component.html` to add extra paragraph or content that describes the event details or about the event.
- You can change or add styling to the website by editing the `home.component.css` file in `\src\app\components\home\home.component.css`.
- After you make necessary changes, run the command `ng build --prod --output-hashing none` to build and deploy the latest changes.

> [!NOTE]
> For extensive customization of the frontend you need to be familiar with the [angular framework](https://angular.io/guide/quickstart).

### Self-hosted website specifics
There are couple of specific regarding self-hosted Event Management website in contrast to Dynamics 365 Portal hosted version. 
If you are using our .NET Core based backend, you need to set up IIS to work with .NET Core following this instructions. 
Portal hosted version uses Microsoft HIP Captcha, and the frontend uses the corresponding API call to get it. Self-hosted version doesn’t have captcha and it’s up to you to implement your own captcha if you want to. 
Portal hosted version uses its own user authentication mechanism, and self-hosted version doesn’t have any user authentication mechanism. It is up to you to implement it if you wish to have authenticated users on your Event Management website version. Backend sample code that we provide has a stub that you can implement to return authenticated user, and frontend should then be able to re-use it out of the box. 
Portal hosted version has the support for localization, and self-hosted version doesn’t. If you want to support the localization you can re-use the mechanism that portal hosted version has, you just have to implement the API endpoint to return the json containing labels. There is an Angular directive already in place that utilizes that endpoint to get the localized content and overwrite appropriate HTML elements with translated text.
If you are hosting the Angular app and the backend under same website, and you should to comply to the same origin policy, be careful about backend to ignore the routes that Angular app uses internally. It can “hijack” the routes sometimes. It will work fine while you are clicking through the app, but if you hit refresh it might try to invoke the API endpoint for the route that actually belongs to the Angular app. Just redirect all of those routes to the Angular index file. 

