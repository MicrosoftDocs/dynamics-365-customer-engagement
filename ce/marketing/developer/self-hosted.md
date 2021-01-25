---
title: "Self-hosted custom event website (Dynamics 365 Marketing Developer Guide) | Microsoft Docs"
description: "Learn how you can extend event management web application functionality for self-hosted custom event websites in Dynamics 365 Marketing."
ms.date: 09/16/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---

# Self-hosted custom event website

Before you start hosting the self-hosted custom event website, complete the actions mentioned in [Prerequisites](event-management-web-application.md) topic.

The frontend can be fully customized and hosted by yourself. Additionally, you can choose to use our backend service, or you can develop your backend. To interact with the backend service, see [Public API documentation](https://go.microsoft.com/fwlink/?linkid=2042224).

If you choose to develop your backend service, you need to take care of the Dynamics 365 Marketing authentication and the web services by yourself. If you want the event registration linked to the appropriate user who created it, make sure that you create the Dynamics 365 Marketing contact record for every new website user.  

![Self-hosted instance (same domain) diagram](../media/self-hosted.png "Self-hosted instance (same domain) diagram")

To give users full control of the event website, you can host the frontend by yourself.

## Register your web application

To use event management public API, you need a web application token. The web application token is used to control API requests that are associated with your organization. More information: [Register your web application](register-web-application-events-api.md).

## Web application environment configuration

1. Duplicate the `environment.selfhosted.ts` configuration file located in the **\src\environments** folder and name it as **environment.ts**.
2. Open the `environment.ts` configuration file in the developer environment of your choice.
3. Change the value of the `apiEndpoint` variable to  `{web-application-endpoint}/EvtMgmt/api/v2.0/` where `{web-application-endpoint}` needs to be replaced with the value from the **Endpoint** field in the newly created web application record in your instance.
4. Make sure that the `useRestStack` variable is set to true.
5. Update the URL for `imagesEndpoint`. If you want to serve the images from the same server, the URL should look like this: `https://HOST/assets/images/` (HOST needs to be replaced with your domain name). 
6. Change the `emApplicationtoken` variable to point to the URL from the **Token** field in the newly created in the web application record. 
7. If you want to use the [Azure Active Directory](https://docs.microsoft.com/azure/active-directory/fundamentals/active-directory-whatis), you need to set the `useAadB2C` variable to `true` and modify the `aadB2CConfig`. More information [Configure Azure Active Directory](#configuration-for-azure-active-directory).

## Configuration for Azure Active Directory

To learn how to set up AAD B2C tenant and configure the event management to work with AAD B2C, see [Setting up event management to work with AAD B2C](event-management-aad-b2c-setup.md)

## Development

Open Command Prompt or Windows PowerShell and run the command from the root directory to build and locally serve the website. Additionally, this command prints the URL and port where you can reach the application (The default location is `localhost:4200`).

```CLI
ng serve
```

### Specifying environment directly

Starting with June Release 2019, it is possible to specify the environment directly in the `ng serve` command.

With the following command, you can automatically use the configuration from the `environment.selfhosted.ts` file.

```CLI
ng serve --configuration=self-hosted
```

## Building

Open Command Prompt or Windows PowerShell and run the command from the root directory to build the website for production.

```CLI
ng build --prod
```

You can find the built website in the **dist** folder of the root directory.

### See also

[Power Apps portal hosted](portal-hosted.md)<br />
[Custom event website localization](event-portal-localization.md)
