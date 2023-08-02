---
title: Embedded Guides in Field Service Mobile (preview)
description: Learn about the preview features of embedded guides in the Field Service mobile app.
ms.date: 08/02/2023
ms.topic: how-to
ms.subservice: field-service-mobile
author: andrea-orimoto
ms.author: andreo
ms.custom: bap-template
---

# Embedded Guides in Field Service Mobile (preview)

With embedded Guides (preview), you can create and view Dynamics 365 Guides on your mobile device. The application lets users create and manage interactive instructions that help perform tasks in the real world. You can now use your phone or tablet to create, edit, and view guides.

This feature lets you:

- Access guides from anywhere, anytime, using your iOS or Android mobile device (tablet and phone).

- Use guides already created in your existing environment.

- Easily navigate through guide content using sort, filter, and search.

- Access text instruction, photos, videos, Power Apps workflows, and website links.

- Analyze guide execution time from recorded session data that includes location, device type, duration, time spent on each step.

## Limitations

- Embedded guides on mobile devices currently support English only.

## Prerequisites

- An active Dynamics 365 Guides license, either a trial or paid.

- Insiders Program platform registration with the terms of the preview and the Dynamics 365 Guides on Mobile preview program accepted.

- An environment with [Dynamics 365 Guides version 800.6.x installed](/power-platform/admin/manage-apps#install-an-app-in-the-environment-view). To Guides and Field Service together in the mobile app, ensure both applications are installed on the same environment.

- Dynamics 365 Field Service mobile application installed and update to the latest version.

## Set up embedded Guides in Field Service Mobile

1. On your mobile device, open the Field Service app.

1. Sign in using your environment credentials.

1. Enable non-production apps.

1. Select the environment with Guides installed. Guides Mobile starts. If Field Service is installed on the same environment, [navigate to the the Library option in the bottom navigation](access-related-apps-mobile-app.md) to see your guides.

## Turn on usage data collection for embedded Guides in Field Service Mobile

Dynamics 365 Guides enables customers to capture usage statistics and detailed time-tracking information. This data is turned off by default, but an admin can turn on data collection for specific users.

1. Go to [the Power Apps admin center](https://powerapps.microsoft.com/) and sign in with your admin account.

1. Select **Guides**. A new tab for the Guides model-driven app opens.

1. Change the area to **Settings**.

   :::image type="content" source="media/powerapps-guides-settings.png" alt-text="Screenshot of the Main Settings for Guides in Power Apps.":::  

1. Select **New**.

1. In the **New User Settings** screen, under **User Settings**, enter the following information:

   - **Name**: Opt in for [User name]

   - **Record Guide Usage**: Yes

   - **Belongs To**: [User name]

   :::image type="content" source="media/powerapps-user-settings.png" alt-text="Screenshot of the User Settings for Guides in Power Apps.":::

## Next steps

- [Access related apps form the Field Service mobile app](access-related-apps-mobile-app.md)
- [Access Guides from the Field Service mobile app](/dynamics365/mixed-reality/guides/admin-connect-field-service-mobile)
- [Learn about the steps card in Dynamics 365 Guides](/dynamics365/mixed-reality/guides/operator-step-card-orientation)