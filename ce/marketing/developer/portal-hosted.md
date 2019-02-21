---
title: "Dynamics 365 Portal hosted custom event portal | MicrosoftDocs"
description: "Provides information about how you can extend event management web application functionality."
ms.custom:
  - dyn365-developer
  - dyn365-marketing
ms.date: 02/06/2019
ms.service: dynamics-365-marketing
ms.technology: 
  - "marketing"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
author: Nkrb
ms.author: nabuthuk
manager: kvivek
---

# Dynamics 365 Portal hosted

The Event Management custom event portal comes as a Dynamics 365 Portal hosted web application when you install the Event Management solution.

The frontend part of the application is bundled into two resource files that are stored as Dynamics 365 Portal web files, and the main single page application entry-point is stored as Dynamics 365 Portal web template. More information about [web files](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/web-files) and [web templates](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/store-content-web-templates).

Although, the frontend definition is hosted on Dynamics 365 Portal, you can still fully customize it. The backend part of the web application is not customizable since the **REST API** endpoints are hosted on Dynamics 365 Portal as a set of [web pages](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/web-page), and the code containing the business logic behind it resides in Event Management plugins which is not customizable.

![Portal Hosted](../media/portal-hosted.png "Portal Hosted")

## Additional project setup

1. To avoid **CORS** errors you need to add your origin in Portals. To do so, go to **Dynamics 365 > Portals > Site Settings** and add a new setting.
   Insert `HTTP/Access-Control-Allow-Origin` in the name field and the origins that should be allowed in the value field.
2. You need to bypass the **anti-CSRF** token for local development. To do that, you need to go to **Dynamics 365 > Portals > Web Templates** and open the **PortalAPI** web template and flip the flag `bypassTokenVerification` to `true`.
3. Restart the Dynamics 365 Portal website to see the changes.

> [!NOTE]
> The **PortalAPI** web template is added by default when you install the Event Management data.

### Environment configuration for portal hosted

1. Duplicate the `environment.d365.ts` configuration file (located in `\src\environments`) and name it `environment.ts`.
1. Open the `environment.ts` configuration file (located in `\src\environments`) for modification.
1. Change the `apiEndpoint` variable to point to the in **Portal Website Binding** configured URL. 

> [!NOTE]
> You need to add a trailing slash at the end of the URL.

4. Make sure that the `useRestStack` variable is set to false.

### Building

1. Run `npm install` to make sure that your dependencies are installed and up-to-date.
1. Run `BuildForPortalHosting.ps1` which is located in `/Scripts` to build the application. After the website is successfully built, your output files will show up in `/dist/ClientApp` directory.

### Deployment

You need to replace the files hosted under portals. Replacing can be done using the provided script, or manually if something fails during the automatic process.
> [!NOTE]
> You don’t need to change all the files, usually main.js and styles.css files are enough, but it is always good to use some kind of source control tool to track the changes. 

To deploy the customized Angular application run the Powershell script `DeployToDynamics365Instance.ps1` that is located under scripts folder. The script will build your Angular application, prepare the output files to be suitable for hosting under Dynamics 365 Portal instance, it will take the localization files from the `Localization` directory and prepare them for hosting ([more about localization](#localization)) and then it will offer you to log into Dynamics 365 instance that you want to use to host your Angular application. After you log in, it will push the files to the instance. The changes you made should be visible after you clear your browser cache (and restart IIS if you are using local Portals instance for development).

To manually replace the files in Dynamics 365, follow the steps below:

1. Open your Dynamics 365 instance.
1. Navigate to **Portals** and click on **Web Files**.
1. Open the web file `style.css` .
1. Scroll down to **Notes** section and delete the existing attachment. 
1. Upload your `style.css` file as attachment. 
1. Now, open the web file `main.es` and scroll down to **Notes** section and delete the existing attachment.
1. Upload your `main.es` file as attachment.
1. Restart the portal website and reopen your browser.

> [!div class="nextstepaction"]
> [Custom Event Portal Localization](event-portal-localization.md)<br /><br />
> [Build and Host Custom Event Portal](event-management-web-application.md)
