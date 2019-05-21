---
title: "Self-hosted custom event portal | MicrosoftDocs"
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

# Self-hosted custom event portal

Before you start hosting self-hosted custom event portal complete the actions mentioned in [Prerequisites](event-management-web-application.md) topic.

The frontend can be fully customized and hosted by yourself. Additionally, you can choose to use our backend service, or you can develop your backend. To interact with the backend service see [Public API documentation](https://go.microsoft.com/fwlink/?linkid=2042224).

If you choose to develop your backend service, you need to take care of the Dynamics 365 authentication and the Dynamics 365 web services by yourself. If you want the event registration linked to the appropriate user who created it, make sure that you create the Dynamics 365 contact record for every new website user.  

![Self-hosted](../media/self-hosted.png "Self-hosted")

To give users full control of the event portal you can host the frontend by yourself.
To do so, a few additional steps need to be done.

## Register your web application
To use event management public API, you need a web application token. The web application token is used to control API requests that are associated with your organization.

1. Go to **Dynamics 365 > Marketing > Settings > Web applications** 
2. Create a **new web application**

   > [!NOTE]
   > You need to create a new web application record for each origin, from which the custom event website is accessible (you need at least two web applications for development and production).

3. Enter an arbitrary **Name**.
4. Enter the **Origin** URL of the custom event portal (e.g. `http://localhost:4200`).

    > [!NOTE]
    > The origin URL may not contain a trailing slash!
  
5. If you want to use the [Azure Active Directory](https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/active-directory-whatis), you need to enter the **AAD Client ID** and **AAD Metadata Endpoint**. More information [Configuration for Azure Active Directory](#configuration-for-azure-active-directory).
6. Click on **Save**.
7. After the changes are saved, the fields **Token** and **Endpoint** should contain values. Make note of this values because you will need them in your web application!

## Web application environment configuration

1. Duplicate the `environment.selfhosted.ts` configuration file located in the **\src\environments** folder and name it as **environment.ts**.
2. Open the `environment.ts` configuration file in the developer environment of your choice.
3. Change the value of the `apiEndpoint` variable to  `{web-application-endpoint}/EvtMgmt/api/v2.0/` where `{web-application-endpoint}` needs to be replaced with value from the **Endpoint** field in the newly created web application record in your instance.
4. Make sure that the `useRestStack` variable is set to true.
5. Update the URL for `imagesEndpoint`. If you want to serve the images from the same server, the URL should look like this: `https://HOST/assets/images/` (HOST needs to be replaced with your domain name). 
6. Change the `emApplicationtoken` variable to point to the URL from the **Token** field in the newly created in the web application record. 
7. If you want to use the [Azure Active Directory](https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/active-directory-whatis) you need to set the `useAadB2C` variable to `true` and modify the `aadB2CConfig`. More information [Configure Azure Active Directory](#configuration-for-azure-active-directory).


## Development

Open Command Prompt or PowerShell and run the command from the root directory to build and locally serve the website. Additionally, this command prints the URL and port where you can reach the application (The default location is `localhost:4200`).

```CLI
ng serve
```

### Specifying environment directly
Starting with June Release 2019 it is possible to specify the environment directly in the `ng serve` command.
With the following command you can automatically use the configuration from the `environment.selfhosted.ts` file.

```CLI
ng serve --configuration=self-hosted
```

## Building

Open Command Prompt or PowerShell and run the command from the root directory to build the website for production.
```CLI
ng build --prod
```

Afterwards you will find your built website in the `dist` folder of the root directory.

### Specifying environment directly
Starting with June Release 2019 it is possible to specify the environment directly in the `ng build` command.
With the following command you can automatically use the configuration from the `environment.selfhosted.ts` file.

```CLI
ng build --prod --configuration=self-hosted
```


## Configuration for Azure Active Directory

The event portal is capable of integrating the Azure Active Directory B2C. To integrate it you need to follow these steps:

1. Create a B2C tenant. More information [How to configure and set it up in the Azure AD B2C](https://docs.microsoft.com/en-us/azure/active-directory-b2c/). 

    > [!NOTE]
    > To use a name-based contact matching strategy, you need to configure the sign-up policy to include the `Given Name` and `Surname`' attributes and also selecting them in the `Application claim` section.

1. Go to **Dynamics 365 > Marketing > Settings > Web applications** and select the created **Web application** record.
2. Insert your client ID in the **AAD Client ID** field.
3. Insert your metadata endpoint in the **AAD Metadata Endpoint** field.
4. Save the changes.
5. Open the `environment.ts` configuration file located in the **\src\environments** folder and enter all required values in the `aadB2cConfig` variable.

    > [!NOTE]
    > It can take up to 10 minutes until the changes become active.

### See also

[Dynamics 365 Portal Hosted](portal-hosted.md)<br />
[Custom Event Portal Localization](event-portal-localization.md)
