---
title: "Self-hosted custom event portal | MicrosoftDocs"
description: "Provides information about how you can extend event management web application functionality."
ms.custom:
  - dyn365-developer
  - dyn365-marketing
ms.date: 02/08/2019
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

The frontend can be fully customized and hosted by yourself. Additionally, you can choose to use our backend service or you can develop your own backend. To interact with the backend service see [API documentation](https://go.microsoft.com/fwlink/?linkid=2042224).

If you choose to develop your own backend service, you need to take care of the Dynamics 365 authentication and the Dynamics 365 web services by yourself. 

If you want the event registration to be linked to the appropriate user who created it, make sure that you create the Dynamics 365 contact record for every new website user.  

![Self-hosted](../media/self-hosted.png "Self-hosted")

To give users full control of the event portal you can host the frontend by yourself.
In order to do so a few additional steps need to be done.

## Dynamics 365 configuration

1. Go to **Dynamics 365 > Settings > Event settings > Web Applications** 
1. Create a new web application

> [!NOTE]
> You need to create a new web application for each origin of which the custom event portal is accessible (most probably you need at least two web applications (for development and production)).

1. Enter an arbitrary `Name`.
1. Enter the `Origin` URL of the custom event portal (e.g. `http://localhost:4200`) .

  > [!NOTE]
  > The origin URL may not contain a trailing slash!
  
1. If you want to use the [Azure Active Directory](https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/active-directory-whatis) you need to enter the `AAD Client ID` and `AAD Metadata Endpoint`. More information [Configuration for Azure Active Directory](#configuration-for-azure-active-directory).
1. Click save.
1. After the changes are saved, the fields `Token` and `Endpoint` should contain values.

### Environment configuration for self hosted

1. Duplicate the `environment.selfhosted.ts` configuration file (located in `\src\environments`) and name it as `environment.ts`.
2. Open the `environment.ts` configuration file for modification.
3. Change the value of the `apiEndpoint` variable to the following endpoint: `{web-application-endpoint}/EvtMgmt/api/v1.0/` where `{web-application-endpoint}` needs to be replaced with value from the `Endpoint` field in the newly created **Dynamics 365 Web Application**.
4. Make sure that the `useRestStack` variable is set to true.
5. Change the `emApplicationtoken` variable to point to the URL from the `Token` field in the newly created **Dynamics 365 Web Application**. 
6. If you want to use the [Azure Active Directory](https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/active-directory-whatis) you need to set the `useAadB2C` variable to `true` and modify the `aadB2CConfig`. More information [Configure Azure Active Directory](#configuration-for-azure-active-directory).

### Configuration for Azure Active Directory

The event portal is capable of integrating the Azure Active Directory B2C. To integrate it you need follow this steps:

1. Create B2C tenant. More information [How to configure and set it up in the Azure AD B2C](https://docs.microsoft.com/en-us/azure/active-directory-b2c/). 
1. Go to **Dynamics 365 > Settings > Event settings > Web Applications** and select the earlier created **Web Application**.
1. Insert your client ID in the `AAD Client ID` field.
1. Insert your metadata endpoint in the `AAD Metadata Endpoint` field.
1. Save the changes.
1. Open the `environment.ts` configuration file (located in `\src\environments`) for modification.
1. Enter all required values in the `aadB2cConfig` variable.

> [!div class="nextstepaction"]
> [Dynamics 365 Portal Hosted](portal-hosted.md)<br /><br />
> [Custom Event Portal Localization](event-portal-localization.md)
