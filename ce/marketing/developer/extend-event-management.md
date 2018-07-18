---
title: "Extend Event Management App | MicrosoftDocs"
description: "Provides information about how you can create and manage webinar events."
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
# Preview: Extend Event Management Application to support more Webinar providers

Apart from the classic on-site support, it is now possible to create and manage webinar events (or hybrid: on-site and webinar events) as well, where the default webinar provider is On24.

## Prerequisites

There should be a pre-created in the webinar provider used to authenticate with the Event Management solution. This means that, according to the API, {BaseServiceURL}/v1/users should return a JSON response with the following structure:
```json
{
 "Username": "JohnDoe",
 "Password": "Password"
}
```

## Add a webinar provider

When creating a new webinar provider, you will need to have ***Client ID*** and ***Client secret***. The authorization of the Webinar service to **Dynamics 365** uses **OAuth 2.0** standard protocol, more information [OAuth, Client ID and Client secret](https://www.oauth.com/oauth2-servers/client-registration/client-id-secret/).

To add a new webinar provide, follow the steps below:

- Navigate through **Settings** > **AdvancedSettings** > **Webinar Providers** and click on **New**. 
- Fill in the required fields as shown in the screen shot. The  field **Base service URL** is the URL of the webinar service that implements the API.

![Webinar Provider](../media/webinar-provider.png "Webinar Provider")

## Add a webinar configuration

To create a new webinar configuration, 

- Navigate to **Advanced Settings** > **Webinar Configuration** and click on **New**.
- Choose the previously created Webinar Provider. Once you select the webinar provider you will be prompted with a consent message whether you agree the terms of service and privacy policy. 
- Accept the consent and **Save**.
- Click on the **Authenticate** button on the ribbon. This button will trigger the authentication flow to the authentication endpoint ofthe webinar provider with Client ID and Client secret.
- Login using the **User** created in the pre-requisites, this will trigger the OAuth flow with the provider.

For more details on the API refernce, Click here
