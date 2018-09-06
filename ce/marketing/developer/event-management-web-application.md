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

# Event Management web application

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

Frontend part of the app is bundled into couple of resource files that are stored as a Dynamics 365 Portal web-files, and main single page app entry-point is stored as a Dynamics 365 Portal web template. Read more about web-files and web templates on Dynamics 365 Portal official documentation web pages. Although frontend definition is hosted on Dynamics 365 Portal, you are still able to fully customize it, and exactly how, will be explained shortly. It’s a different story with backend. REST API endpoints are also hosted on Dynamics 365 Portal as a set of web pages, but the code containing the business logic behind it resides in Event Management plugins, so this part of the application is not customizable. The communication in the case of Dynamics 365 Portal hosting looks like this.

## Self-hosted
If you don’t want to rely on Dynamics 365 Portals, or you simply want more freedom with customization, you can self-host the Event Management web application. You don’t need to do extra work with the frontend, but in this case, you will have to implement the backend by yourself in your technology of choice. You can use our own demo backend and data contract for the communication between the frontend and the backend as a starting point if it suits you, but you can also define your own contract and modify the frontend accordingly. For backend to communicate with your CRM instance, you need to take care of CRM authentication and use CRM webservice. If you want for your web application to have users, you need to implement authentication mechanism by yourself, depending on the technology you chose for the backend, because in the case of Dynamics 365 Portal hosting we are using portal users, and that mechanism isn’t available in this case. If you want event registration to be linked to appropriate user who created it, make sure that you create CRM contact for the every new website user. Also, I have to emphasize that CRM authentication and your web app authentication are 2 different things. In the first case we are talking about CRM user that backend needs to use to be able to utilize CRM web API, and in second case we are talking about your “local” website users, that you don’t strictly have to have. Be careful to host both frontend and backend on the same domain to comply to same-origin policy. The communication between app parts and CRM in this case looks like this.

##Development and Customization of web application

In order to customize the frontend, you need to pull the source code and setup Angular. Source code is available on GitHub in the following repo. Next thing you need to proceed is Node, and you can get it here. After installing Node open cmd (or reopen if you have it opened) and rune ‘node -v’ to see if node has successfully installed. You can read more about Node here.
To install Angular command line interface (CLI), run the following command: 
‘npm install -g @angular/cli’. 
You will need Angular CLI to build and run your Angular app. Read more about Angular here. After you have Angular CLI enabled position yourself into the project directory and run ‘npm install’ to instruct Node to fetch all the necessary packages needed to run the website.
Running local website instance
Now when everything is set up, you are almost able to run your local development instance of the website. There are 2 (possibly 3) extra things to setup before. 
First is bypassing same origin policy for development. To do that you can create new Chrome shortcut and add 
--disable-web-security --user-data-dir="C:\chromeTest" 
as startup parameters for Chrome. 
Second thing is pointing the frontend to the correct API endpoint. It doesn’t matter if the API is self-hosted, or you are using Dynamics 365 Portal to host it, procedure is the same. Go to 
‘\src\app\providers\url.provider.ts’
And return the url to your API from the baseUrl() method. Trailing slash included.
Third thing, that is necessary only if you use Dynamics 365 Portal hosted API is bypassing anti-CSRF token for local development. To do that you need to open Portals area in your CRM instance, go to web templates, and open PortalAPI web template. Then flip the flag bypassTokenVerification to true. Restart the Dynamics 365 Portal website for change to take effect.
OK, now you are ready to run the website. Run ‘ng serve’ from your working directory and after it is done building and open the website url in the Chrome instance run with the shortcut you created.
To make changes to the frontend, you need to be familiar with the Angular framework, and that is beyond the scope of this instructions. We advise to consult Angular documentation, which is really extensive. 
Building and deploying the website
We said that customization is beyond the scope of this instructions, but let’s make some simple change on the website. For example, you can go to 
‘\src\app\components\home\home.component.html’ 
…and add extra paragraph after the Intro2 paragraph. E.g. <p>This is a test</p>
Now you want to build and deploy your changes. If you are using self-hosting approach, then run
 ‘ng build --prod --output-hashing none’
command from your working directory. Just don’t forget any local development specific changes that you maybe had before the build, for example API base url.
If you are using Dynamics 365 Portal approach, run BuildForPortalHosting.ps script.
After the website is successfully built, your output files will show up in ‘/dist/ClientApp’ directory. If you are self-hosting Event Management web application, then you can copy those files in the root of your web server, replacing existing ones. 
If you are using Dynamics 365 Portal to host your Event Management web application, then you need to replace the files hosted under portals. You probably don’t need to change all the files, usually just main.es and styles.css are enough for most of the changes, but we advise to use some kind of source control tool, and track the changes. To do that follow these instructions:
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
Self-hosted website specifics
There are couple of specific regarding self-hosted Event Management website in contrast to Dynamics 365 Portal hosted version. 
If you are using our .NET Core based backend, you need to set up IIS to work with .NET Core following this instructions. 
Portal hosted version uses Microsoft HIP Captcha, and the frontend uses the corresponding API call to get it. Self-hosted version doesn’t have captcha and it’s up to you to implement your own captcha if you want to. 
Portal hosted version uses its own user authentication mechanism, and self-hosted version doesn’t have any user authentication mechanism. It is up to you to implement it if you wish to have authenticated users on your Event Management website version. Backend sample code that we provide has a stub that you can implement to return authenticated user, and frontend should then be able to re-use it out of the box. 
Portal hosted version has the support for localization, and self-hosted version doesn’t. If you want to support the localization you can re-use the mechanism that portal hosted version has, you just have to implement the API endpoint to return the json containing labels. There is an Angular directive already in place that utilizes that endpoint to get the localized content and overwrite appropriate HTML elements with translated text.
If you are hosting the Angular app and the backend under same website, and you should to comply to the same origin policy, be careful about backend to ignore the routes that Angular app uses internally. It can “hijack” the routes sometimes. It will work fine while you are clicking through the app, but if you hit refresh it might try to invoke the API endpoint for the route that actually belongs to the Angular app. Just redirect all of those routes to the Angular index file. 

