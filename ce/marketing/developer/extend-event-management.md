---
title: "Extend Event Management | MicrosoftDocs"
description: "Provides information about how you can extend event management functionality to add external webinar providers."
ms.custom:
  - dyn365-developer
  - dyn365-marketing
ms.date: 07/18/2018
ms.service: dynamics-365-marketing
ms.technology: 
  - "marketing"
ms.topic: "get-started-article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 9e5e197c-546e-46d0-a140-070181e5af40
author: NavaKiran 
ms.author: nabuthuk
manager: kvivek
---

[!INCLUDE [cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

# Preview: Extend Event Management to support more webinar providers

Microsoft has partnered with a webinar provider called [On24](https://www.on24.com/) to let you plan and manage events using Dynamics 365 for Marketing. On24 is the only webinar provider currently supported out-of-the-box for use with Dynamics 365. More information: [Event settings](../events-settings.md)

Introducing the Webinar Extension API that other Webinar providers can implement so that they can be used as a webinar provider with Dynamics 365.

> [!IMPORTANT]
> - [!INCLUDE[cc_preview_features_definition](../../includes/cc-preview-features-definition.md)] 
> - [!INCLUDE[cc_preview_features_expect_changes](../../includes/cc-preview-features-expect-changes.md)]  
> - [!INCLUDE[cc_preview_features_no_MS_support](../../includes/cc-preview-features-no-ms-support.md)]


## Prerequisites

The webinar provider must create a service that implements the Webinar Extension API so that it can be used as webinar provider in Dynamics 365. More information: [Webinar Extension API Reference](#webinar-extension-api-reference)

Further, the webinar provider should be able to authenticate with the Event management solution. This means that according to the API, `{BaseServiceURL}/v1/users` should return a JSON response with the following structure:

```json
{
    "Username": "JohnDoe",
    "Password": "Password"
}
```

## Add a webinar provider

When creating a new webinar provider, you will need to have ***Client ID*** and ***Client secret***. The authorization of the Webinar service to Dynamics 365 uses OAuth 2.0 standard protocol. More information: [OAuth, Client ID and Client secret](https://www.oauth.com/oauth2-servers/client-registration/client-id-secret/).

To add a new webinar provider:

1. Open **Settings** > **Advanced Settings** > **Webinar Providers** and select **New**. 
2. Fill in the required fields as shown below. The field **Base service URL** is the URL of the webinar service that implements the API.

![Webinar Provider](../media/webinar-provider.png "Webinar Provider")

## Add a webinar configuration

To create a new webinar configuration, 

1. Open **Settings** > **Advanced Settings** > **Webinar Configuration**, and select **New**.
2. Choose the previously created Webinar Provider. Once you select the webinar provider you will be prompted with a consent message whether you agree the terms of service and privacy policy. 
3. Accept the consent and **Save**.
4. Click on the **Authenticate** button on the ribbon. This button will trigger the authentication flow to the authentication endpoint of the webinar provider with the specified Client ID and Client secret.
5. Login using the **User** created in the pre-requisites, this will trigger the OAuth flow with the provider.

## Webinar Extension API Reference

Download the API reference here: [TODO: Add the link to Download Center]