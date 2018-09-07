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

Event Management feature in Dynamics 365 for Marketing helps the organizations to organize, manage and process events. when you install Event Management module you will also get Event Portal which gives the users an application where they can know more about the event details.

The Event Management web application consists of two parts:
1. Angular frontend
2. Rest API backend

Frontend part is a single page app which is created using anuglar framework. The frontend part of the web application is fully customizable. Backend and customizability of the backend depends on hosting type.

There are two ways Event Management web application can be hosted.
1. Dynamics 365 Portal hosted
2. Self-hosted

## Dynamics 365 Portal hosted
Event Management web application comes as a Dynamics 365 Portal hosted web when you install Event Management module.

> [!NOTE]
>  You need to have Dynamics 365 for marketing installed first and Event Portal.

Frontend part of the app is bundled into couple of resource files that are stored as a Dynamics 365 Portal web-files, and main single page app entry-point is stored as a Dynamics 365 Portal web template. More information [web-files](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/web-files) and [web templates](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/store-content-web-templates).

Although frontend definition is hosted on Dynamics 365 Portal, you can still fully customize it. The backend part of the web application is not customizable since the REST API endpoints are hosted on Dynamics 365 Portal as a set of [web pages](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/web-page), but the code containing the business logic behind it resides in Event Management plugins.

## Self-hosted
The advantage of self-hosted backend is that you have more freedom with customization, implement the backend weth the technology of  your choice. You can use your own demo backend and data contract for the communication between the frontend and the backend as a starting point if it suits you, but you can also define your own contract and modify the frontend accordingly. 

For backend to communicate with your Dynamics 365 instance, you need to take care of Dynamics 365 authentication and use Dynamics 365 webservice. You need to implement authentication mechanism by yourself, depending on the technology you chose for the backend. If you want event registration to be linked to appropriate user who created it, make sure that you create Dynamics 365 contact for the every new website user. 

Dynamics 365 authentication and your web app authentication are two different things. In the first case we are talking about Dynamics 365 user that backend needs to use to be able to utilize Dynamics 365 web API, and in second case we are talking about your “local” website users, that you don’t strictly have to have. Be careful to host both frontend and backend on the same domain to comply to same-origin policy. The communication between app parts and Dynamics 365 in this case looks like this.

## Developing and Customizing web application on self-hosted 

To develop and customize the frontend part of the web application:

- Download the [TODO: source code].
- Install [Node](https://nodejs.org/en/download).
- Open Node cmd (or reopen if you have it opened) and run `node-v` to check whether the installation is successful or not. More information: [Node.js](https://nodejs.org/en/about).
- Run the command `npm install -g @anuglar/cli` toiInstall angular command line interface (cli). This is required to build and run the angular app. More information: [Angular](https://angular.io).
- Go to project directory where you have downloaded the source code and run the command `npm install`to fetch all the necessary packages that are required to run the website.
- Create a new Chrome shortcut and add `--diable-web-security--user-data-dir="C:\chromeTest"` to bypass the same origin policy.
- Go to `\src\app\providers\url.providers.ts` in the source code to point the frontend to the correct API endpoint and change the return value if the `baseURL()` method to your API.
- Run the command `ng serve` from your working directory to build the website and open the website url in the chrome instance with the shortcut you created.

After the website building is succees

### Building and deploying website
let's make some simple changes on the website you have created. 
- Go to `\src\app\components\home\home.component.html` to add extra paragraph or content that describes the event details or about the event.
- You can change or add styling to the portal by editing the `home.component.css` file in `\src\app\components\home\home.component.css`.
- After you make necessary changes run the command `ng build --prod --output-hashing none` to build and deploy  the latest changes.
> [!NOTE]
> For extensive customization of the frontend you need to be familiar with the [angular framework](https://angular.io/guide/quickstart).

## Developing customizing the webapplication on Dynamics 365 Portal hosted backend

Go to project directory where you have downloaded the source code and run the command `npm install`to fetch all the necessary packages that are required to run the website.
- Create a new Chrome shortcut and add `--diable-web-security--user-data-dir="C:\chromeTest"` to bypass the same origin policy.
- Go to `\src\app\providers\url.providers.ts` in the source code to point the frontend to the correct API endpoint and change the return value if the `baseURL()` method to your API.
- Run the command `ng serve` from your working directory to build the website and open the website url in the chrome instance with the shortcut you created.

After the website is successfully built, your output files will show up in ‘/dist/ClientApp’ directory.  
If you are using Dynamics 365 Portal to host your Event Management web application, then you need to replace the files hosted under portals. 
You probably don’t need to change all the files, usually just main.es and styles.css are enough for most of the changes, but we advise to use some kind of source control tool, and track the changes. To do that follow these instructions:
1.	Open your CRM instance
2.	Open Portals area and click on Web Files page
3.	To make it easier for you, you can sort the list by Parent Page column
4.	Repeat the following items for each file you want to update
5.	Open the web file (style.css for example)
6.	Navigate to notes
7.	Delete the attachment
8.	Re-upload your file as attachment. Ignore the extensions for the Javascript files, for technical reasons web file names have extension .js, but the files itself have extension .es
9.	Restart the portal website and reopen your browser
10.	Changes should be visible. If not, clear the browser cache

### Self-hosted website specifics
There are couple of specific regarding self-hosted Event Management website in contrast to Dynamics 365 Portal hosted version. 
If you are using our .NET Core based backend, you need to set up IIS to work with .NET Core following this instructions. 
Portal hosted version uses Microsoft HIP Captcha, and the frontend uses the corresponding API call to get it. Self-hosted version doesn’t have captcha and it’s up to you to implement your own captcha if you want to. 
Portal hosted version uses its own user authentication mechanism, and self-hosted version doesn’t have any user authentication mechanism. It is up to you to implement it if you wish to have authenticated users on your Event Management website version. Backend sample code that we provide has a stub that you can implement to return authenticated user, and frontend should then be able to re-use it out of the box. 
Portal hosted version has the support for localization, and self-hosted version doesn’t. If you want to support the localization you can re-use the mechanism that portal hosted version has, you just have to implement the API endpoint to return the json containing labels. There is an Angular directive already in place that utilizes that endpoint to get the localized content and overwrite appropriate HTML elements with translated text.
If you are hosting the Angular app and the backend under same website, and you should to comply to the same origin policy, be careful about backend to ignore the routes that Angular app uses internally. It can “hijack” the routes sometimes. It will work fine while you are clicking through the app, but if you hit refresh it might try to invoke the API endpoint for the route that actually belongs to the Angular app. Just redirect all of those routes to the Angular index file. 

