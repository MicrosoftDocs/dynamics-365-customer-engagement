---
title: "Dynamics 365 Portal hosted custom event website | MicrosoftDocs"
description: "Provides information about how you can extend event management web application functionality."
ms.custom:
  - dyn365-developer
  - dyn365-marketing
ms.date: 05/20/2019
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

Before you start hosting custom event website, complete the actions mentioned in the [Prerequisites](event-management-web-application.md) topic. The custom event website comes as a Dynamics 365 Portal hosted web application when you install the Event Management solution.

The frontend part of the application is bundled into two resource files that are stored as Dynamics 365 Portal [web files](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/web-files), and the main single page application entry-point is stored as Dynamics 365 Portal [web template](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/store-content-web-templates).

Although the frontend definition is hosted on Dynamics 365 Portal, you can still fully customize it. The backend part of the web application is not customizable since the **REST API** endpoints are hosted on Dynamics 365 Portal as a set of [web pages](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/portals/web-page), and the code containing the business logic behind it resides in Event Management plugins which are not customizable.

![Portal Hosted](../media/portal-hosted.png "Portal Hosted")

## Additional project setup

## Environment configuration 

1. Duplicate the `environment.d365.ts` configuration file located in the **\src\environments** folder and name it as **environment.ts**.
1. Open the **environment.ts** configuration file in the developer environment of your choice.
1. Change the `apiEndpoint` variable to point to the **Website Bindings** value.

    ![Website binding](../media/website-binding-record.png "Website binding")

    > [!NOTE]
    > You need to add a trailing slash at the end of the URL.

1. Make sure that the `useRestStack` variable is set to false.

## Local Development

#### Bypass CSRF

You need to bypass the **anti-CSRF** token for local development. To do that, navigate to **Dynamics 365 > Portals > Web Templates** and open the **PortalAPI** web template and flip the flag `bypassTokenVerification` to `true`. Restart Portals to make sure that the settings are applied.

> [!NOTE]
> The **PortalAPI** web template is added by default when you install the Event Management data.

## Serving page locally

To serve the application locally, you need to follow the steps below:

1. Open Command Prompt or PowerShell.

1. Run the command to make sure all the dependencies are installed.

    ```CLI
    npm install
    ```
1. Run the command to generate the style.css file 

   ```CLI
   ng build --prod --output-hashing none
   ```

1. Run the command to start the local development server to see the changes immediately.

   ```CLI
   ng serve
   ```

    > [!NOTE]
    > You can find more information on serving an Angular application locally here [Serving an Angular application locally]( https://angular.io/guide/quickstart#step-3-serve-the-application)

## Deployment

You need to replace the files hosted under Portals. This can be done using the provided script, or manually if something fails during the automatic process.

> [!NOTE]
> You don’t need to change all the files, usually main.js and styles.css files are enough, but it is always good to use a source control tool to track the changes.

To deploy the customized Angular application, run the **PowerShell** script `DeployToDynamics365Instance.ps1` located under the **Scripts** folder. The script builds the Angular application, prepares the output files to be suitable for hosting under the Dynamics 365 Portal instance. It takes the localization files from the `Localization` folder and prepare them for hosting and offers you to log into Dynamics 365 instance that you want to use to host your application. After you log in, it pushes the files to the instance. Clear your browser cache (restart IIS if you are using local Portals instance for development) to see the changes.

To manually replace the files in Dynamics 365, follow the steps below:

1. Open your Dynamics 365 instance.
1. Navigate to **Dynamics 365 for Portals** and click on **Web Files**.
1. Open **styles.css** web file.
1. Click on the **Notes** tab and delete the existing attachment.
1. Upload your **styles.css** file located in the **dist/ClientApp** folder as an attachment.
1. Now, open the **main.es** and click on the **Notes** tab and delete the existing attachment.
1. Convert the **Main.js** file to **main.es** located in the **dist/ClientApp** folder.
1. Upload your `main.es` file as an attachment.
1. Restart the Portal website and reopen your browser.

## Configuring cross-origin resource sharing (CORS)

If you want to serve the custom event website from a **custom domain**, you need to configure CORS to allow that custom domain, to do that

1. Go to **Dynamics 365 > Dynamics 365 for Portals > Site Settings** and click on **New** to create a  Site Settings record.
1. Insert `HTTP/Access-Control-Allow-Origin` in the name field.
1. Select your website.
1. Add the custom origin that should be allowed. For example, if the custom event website is hosted on `https://contoso.com/` custom domain than the value field must be set to `https://contoso.com/`.
1. Click on **Save**.
1. Restart Portals to make sure that the settings are applied.

    ![A new site setting to allow 'https://contoso.com/' as a custom domain.](../media/cors-settings-portals.png "A new site setting to   allow 'https://contoso.com/' as a custom domain.")

    > [!NOTE]
    > More information about CORS can be found here [CORS](https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS) [Access-Control-Allow-Origin](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Access-Control-Allow-Origin)

### Manually overwriting sample website

If you want to overwrite the sample website to match the version of event management that you have currently, see [Manually overwriting sample website](manually-overwriting-sample-website.md)<br />

### See also

[Localization](event-portal-localization.md)<br />
[Build and Host custom event portal](event-management-web-application.md)