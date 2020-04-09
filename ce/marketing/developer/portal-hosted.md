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
author: Nkrb
ms.author: nabuthuk
manager: kvivek
---

# Dynamics 365 Portal hosted

Before you start hosting a custom event website, complete the actions mentioned in the [Prerequisites](event-management-web-application.md) topic. The custom event website comes as a Dynamics 365 Portal hosted web application when you install the Event Management solution.

The frontend part of the application is bundled into two resource files that are stored as Dynamics 365 Portal [web files](https://docs.microsoft.com/dynamics365/customer-engagement/portals/web-files). The main single page application entry-point is stored as Dynamics 365 Portal [web template](https://docs.microsoft.com/dynamics365/customer-engagement/portals/store-content-web-templates).

Although the frontend definition is hosted on Dynamics 365 Portals, you can still fully customize it. The backend part of the web application is not customizable since the **REST API** endpoints are hosted on Dynamics 365 Portal as a set of [web pages](https://docs.microsoft.com/dynamics365/customer-engagement/portals/web-page). The code containing the business logic behind it resides in Event Management plugins which are not customizable.

> [!div class="mx-imgBorder"]
> ![Portal Hosted](../media/portal-hosted.png "Portal Hosted")

## Additional project setup

## Environment configuration 

1. Duplicate the `environment.d365.ts` configuration file located in the **\src\environments** folder and name it as **environment.ts**.
1. Open the **environment.ts** configuration file in the developer environment of your choice.
1. Change the `apiEndpoint` variable to point to the **Website Bindings** value.
    > [!div class="mx-imgBorder"]
    > ![Website binding](../media/website-binding-record.png "Website binding")

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

1. Run the command to install all the dependencies.

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

To make your customizations visible in the event website, update the web files in **Portals**. This can be done automatically by using the provided script `DeployToDynamics365Instance.ps1`, or manually updating the attachments of all web files.

### Automatic Deployment (preferred)

To deploy the customized Angular application, run the **PowerShell** script `DeployToDynamics365Instance.ps1` located under the **Scripts** directory. The script builds the application, prepares the output files suitable for hosting under the Dynamics 365 Portal instance. It takes the localization files from the `Localization` folder and prepares them for hosting.

After all the files are built, it asks you to sign in to your Dynamics 365 Marketing instance that you want to use to host your application. After you sign in, it pushes the files to the instance. If you don't see your changes, clear the browser cache and restart your **Portals**.

> [!NOTE]
> If you can't run the Powershell script because of your execution policy, then you need to [disable or bypass the execution policy](https://docs.microsoft.com/powershell/module/microsoft.powershell.security/set-executionpolicy?view=powershell-6).


### Manual Deployment

To manually replace the files in Dynamics 365 Marketing, follow the steps below (you need to repeat step 3 - 5 for each file that has changed in your `dist` folder):

1. Open your Dynamics 365 Marketing instance.
1. Go to **Dynamics 365&mdash;custom** > **Portals** > **Web Files**.
1. Open the web file that you want to update (e.g., **styles.css**).
1. Select the **Notes** tab and delete the existing attachment.
1. Upload the corresponding file (e.g. **styles.css**) file located in the **dist/ClientApp** folder as an attachment.
1. Restart the Portal website and reopen your browser.

You can find a mapping between generated Angular files and Portal web files in the `DeployToDynamics365Instance.ps1` script if you find difficult to understand which file in `dist/ClientApp` folder belongs to which web file.

> [!NOTE]
> You don’t need to change all the files, usually main.js and styles.css files are enough, but it is always good to use a source control tool to track the changes.

## Configuring cross-origin resource sharing (CORS)

If you want to serve the custom event website from a **custom domain**, you need to configure CORS to allow that custom domain, to do that:

1. Go to **Dynamics 365&mdash;custom** > **Portals** > **Site Settings** and select **New** to create a  Site Settings record.
1. Insert `HTTP/Access-Control-Allow-Origin` in the name field.
1. Select your website.
1. Add the custom origin that should be allowed. For example, if the custom event website is hosted on `https://contoso.com/` custom domain than the value field must be set to `https://contoso.com/`.
1. Select **Save**.
1. Restart Portals to make sure that the settings are applied.
    > [!div class="mx-imgBorder"]
    > ![A new site setting to allow 'https://contoso.com/' as a custom domain.](../media/cors-settings-portals.png "A new site setting to   allow 'https://contoso.com/' as a custom domain.")

    > [!NOTE]
    > More information about CORS can be found here [CORS](https://developer.mozilla.org/docs/Web/HTTP/CORS) [Access-Control-Allow-Origin](https://developer.mozilla.org/docs/Web/HTTP/Headers/Access-Control-Allow-Origin)

### Manually overwriting sample website

If you want to overwrite the sample website to match the version of event management that you have currently, see [Manually overwriting sample website](manually-overwriting-sample-website.md)<br />

### See also

[Localization](event-portal-localization.md)<br />
[Build and host custom event website](event-management-web-application.md)
