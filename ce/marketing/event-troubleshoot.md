---
title: "Troubleshoot events (Dynamics 365 Marketing) | Microsoft Docs"
description: "Troubleshooting and frequently asked questions for events in Dynamics 365 Marketing."
ms.date: 09/14/2021

ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Troubleshoot event management

## How are contacts created in event management?

- Contacts in event management are created when:
    - A *website visitor* (1) registers through a portal or (2) logs in through AAD B2C using the events API.
    - An *attendee* (not necessarily the same as a website visitor) (1) is registered or (2) a pass is paid for for the attendee (a contact is not created before this action).
- Contacts are merged when an attendee matches an existing contact by email, name, or surname. The merging functionality is [configurable](events-settings.md#event-administration).

## My portal is blank, what can I do?

Make sure that:

- The portal language is the same as the Dynamics language.
- You don’t have duplicate webpage records (same partial URLs twice, which results in a 404 error).
- You didn’t upload the script files manually. They need to be [deployed through a script](developer/manually-overwriting-sample-website.md).
- Localized content exists for your webpages.
- The event portal has all 44 languages.
- Script files are attached to web files in the **Notes** section.
- The viewing user has permission to view the webpages.

Before any portal changes, you should make a backup of the current website.

## After changing the sample website, changes don’t reflect or it’s showing errors

- When deploying the changes:
    - Change the website code in the /src folder, not in /dist folder. The /dist folder will be rebuilt when deploying from /src files.
    - Run the script for deployment.
- Depending on where you want to deploy, make sure the changes are reflected in the appropriate environment configuration files:
    - The portals deployment script uses the environment.d365.ts configuration
    - For self-hosting, you should use environment.selfhosted.ts, but you also need to build with `ng build --configuration self-hosted`.
    - Local testing: use the environment.ts configuration and build without any parameters (ng build).
- As best practice:
    - Before deploying to your production environment, test the code changes locally using the [self-hosted approach](developer/self-hosted.md).
    - Make sure that your website builds and runs without errors locally.

## I hosted the sample website on my IIS server but I cannot get it work, what can I do?

Even though hosting the website anywhere is possible, Dynamics 365 Marketing can't configure or debug the custom hosting environment.
