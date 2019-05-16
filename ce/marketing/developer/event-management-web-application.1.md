---
title: "Build and host a custom event portal | MicrosoftDocs"
description: "Provides information about how you can extend event management  web application functionality."
ms.custom:
  - dyn365-developer
  - dyn365-marketing
ms.date: 02/21/2019
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

# Build and host a custom event portal

The Dynamics 365 Event Management feature helps you to organize, manage and process the events. When you install the event management solution, you get an **Event Portal** which gives the users a web application where they can get to know more about the event details. More information: [Event Portal](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/marketing/set-up-event-portal).

The event portal consists of two parts:

1. Frontend (e.g., Angular, Vanilla JS, etc.)
2. REST API backend

The frontend part is a single page application created using the [Angular](https://angular.io) framework and is fully customizable. The backend and the customization of the backend depends on the hosting type.

You can host a custom event portal in two ways:

1. [Self-hosted](self-hosted.md)
2. [Dynamics 365 Portal hosted](portal-hosted.md)

## Prerequisites

You either can build your frontend or customize the provided demo event portal.

> [!NOTE]
> The provided demo event portal is built on the [Angular framework](https://angular.io/guide/quickstart). However, since the backend is not dependent on the frontend, you can use a framework of your choice.

To get started with customizing the demo event portal, you need to follow these steps:

1. Download the [source code](#download-sample-event-website)

2. Install [Node.js](https://nodejs.org/en/download) version 10.x or higher.

3. Open a terminal or shell of your choice (e.g., Command Prompt or Powershell) and run the below command to check whether the installation is successful or not.
    ```CLI
    node -v
    ```
        
    > [!NOTE]
    > If you have a terminal or shell is already open, restart it before typing in the command.

4. Run the below command to install the Angular CLI (command line interface) required to build and run the Angular app. More information: [Angular CLI](https://cli.angular.io/).
   ```CLI
   npm install -g @angular/cli
   ```

5. Download the sample event website from the [download](#download-sample-event-website) section.

6. Go into the directory where you have downloaded the [source code](#download-sample-event-website) and run the following command to fetch all the necessary packages that are required to run the website.

    ```CLI
    npm install
    ```
    
   > [!NOTE]
   > The command needs to be executed in the same directory where the `package.json` file is located.

## Environment Configuration

All the configuration for your custom event portal can be made by creating an `environment.ts` file in `\src\environments`. This directory contains sample configuration files for different environments (self-hosted, portal hosted, development). You can find instructions on how to change the configuration in the related topics [Environment configuration for self-hosted](self-hosted.md) and [Environment configuration for portal hosted](portal-hosted.md). Here are some of the settings that you need to know:

- **production** - Used internally by **Angular** to differentiate between production and development environments.
- **buildVersion** - This field links to the version specified in the `package.json` file by default. There is no need to change this property. However, if you prefer not to expose the version of the application, you can set it to `null`.
- **apiEndpoint** - Used by the event management application. Points to the API endpoint that **Angular** services use.
- **localizationEndpoint** - Points to the localization endpoint that Event Management localization system uses to fetch the localized labels.
- **imagesEndpoint** - Specifies the base URL from where images are served. This configuration enables you to serve images from a different location which might be required if you want to use a CDN or image processing service.
- **useRestStack** - Used by the event management application to adjust to different types of APIs used when utilizing the self-hosted approach against Dynamics 365 hosted approach. The self-hosted approach uses the REST API.
- **isAuthenticationEnabled** - Used by the event management application to turn on support user authentication. If false login or logout dropdown is shown on the navigation bar.
- **useAadB2C** - Used by the event management application to enable **Azure Active Directory B2C identity management** (for self-hosted) and **Dynamics 365 Portals identity management** (for Dynamics 365 Portal hosted).
- **useMockData** - Used by the event management for development purposes. Overrides **Angular** application data services to return mock data.
- **aadB2CConfig** - Configuration object used by event management application when **AAD B2C identity management** is enabled. 

## Development

Run the command from your working directory to build and locally serve the website. Additionally, this command prints the URL and port where you can reach the application (default is `localhost:4200`).

```CLI
npm serve
```

## Backend customization

Most of the customization possibilities for the event management application are found on the frontend, but there is also a use case when customizer adds a new field to the existing Event Management entity and would like to see that field in the website. For example if `custom_new_field` field is added to the `evtmgmt_pass` entity. The passes for the event can be retrieved using API endpoint `api/v2.0/events/{readableEventId}/passes`, but the result doesn't contain the newly added field. To expose the new fields to be visible in API, you should do the following:

1. Open your Dynamics 365 instance.
1. Open Advanced Find view
1. Select `Website Entity Configuration` entity and hit results button
1. Create a new record
1. Enter a name of your choice
1. Select the entity that you want an extra field to be visible for (`Pass` in this example)
1. Write a JSON array that contains the new custom fields that should be visible through the API. In this example: `["custom_new_field"]`.

This exposes your new custom field through the API, and you can utilize it in the frontend.

## Download sample event website

Select the version you would like to download from the table below.

> [!NOTE]
> Make sure to use a version of the sample event website that matches your event management solution version.

| Name | Release | Changes | Download |
|--|--|--|--|
| Sample Event Website | 1.13.0 (April Release) | Waitlist functionality on session level, UI polishing, bug fixes | [Download](http://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/190401-EventWebsite.zip) |
| Sample Event Website | 1.12.2 (March Release) | UI & UX improvements, bug fixes | [Download](http://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/190302-EventWebsite.zip) |

### See also

[Self-hosted](self-hosted.md)<br />
[Dynamics 365 Portal hosted](portal-hosted.md)<br/>
[Localization](event-portal-localization.md)
