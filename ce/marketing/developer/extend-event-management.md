---
title: "Extend Event Management | MicrosoftDocs"
description: "Provides information about how you can extend event management functionality to add external webinar providers."
ms.custom:
  - dyn365-developer
  - dyn365-marketing
ms.date: 07/18/2018
ms.service: dynamics-365-marketing
ms.technology: 
  - marketing
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 2b1cdbc5-0815-47b1-8a4e-0291cde6f40c
author: NavaKiran 
ms.author: nabuthuk
manager: kvivek
---

# Preview: Extend Event Management to support more webinar providers

[!INCLUDE [cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

[On24](https://www.on24.com/) is the only webinar provider currently supported out-of-the-box for use with Dynamics 365 for Customer Engagement to plan and manage events. More information: [Event settings](../events-settings.md)

Other webinar providers can implement the new Webinar Extension API to become a supported webinar provider for Dynamics 365 for Customer Engagement, just like On24. Once a webinar provider implements the API on their webinar service, the webinar provider can be configured in Dynamics 365 for Customer Engagement to use their webinar service for event management.

> [!IMPORTANT]

> - [!INCLUDE[cc_preview_features_definition](../../includes/cc-preview-features-definition.md)] 
> - [!INCLUDE[cc_preview_features_expect_changes](../../includes/cc-preview-features-expect-changes.md)]  
> - [!INCLUDE[cc_preview_features_no_MS_support](../../includes/cc-preview-features-no-ms-support.md)]


## Prerequisites

The webinar provider must create a service that implements the Webinar Extension API so that it can be used as webinar provider in Dynamics 365 for Customer Engagement. More information: [Webinar Extension API Reference](#webinar-extension-api-reference)

Further, the webinar provider should be able to authenticate with the Event management solution. This means that according to the API, `{BaseServiceURL}/v1/users` should return a JSON response with the following structure:

```json
{
    "Username": "JohnDoe",
    "Password": "Password"
}
```

## Add a webinar provider

When adding a new webinar provider in Dynamics 365 for Customer Engagement, you will need to have ***Client ID*** and ***Client secret*** values. This information is provided when you sign up for a webinar provider. The authorization of the webinar service to Dynamics 365 for Customer Engagement uses OAuth 2.0 standard protocol. More information: [OAuth, Client ID and Client secret](https://www.oauth.com/oauth2-servers/client-registration/client-id-secret/).

To add a new webinar provider:

1. Open **Settings** > **Advanced Settings** > **Event Management** > **Webinar Providers** and select **New**. 
2. Fill in the required fields as shown below. The field **Base service URL** is the URL of the webinar service that implements the API.

![Webinar Provider](../media/webinar-provider.png "Webinar Provider")

## Add a webinar configuration

To create a new webinar configuration, 

1. Open **Settings** > **Advanced Settings** > **Event Management** > **Webinar Configuration**. Here you'll see a list of existing     configurations (if any). To create a new configuration, select **New**.
2. Enter a **Name** that you and others will recognize.
3. Choose the previously created webinar provider. Once you select the webinar provider you will be prompted with a consent message whether you agree the terms of service and privacy policy. 
4. Accept the consent and **Save**.
5. Click on the **Authenticate** button on the ribbon. This button will trigger the authentication flow to the authentication endpoint of the webinar provider with the specified Client ID and Client secret.
6. Login using the **User** created in the pre-requisites, this will trigger the OAuth flow with the provider.

## Webinar Extension API Reference

Download the API reference [here](https://go.microsoft.com/fwlink/?linkid=2006678)
