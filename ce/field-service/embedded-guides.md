---
title: Embed Guides 2D in Field Service Mobile (preview)
description: Learn about the Public Preview features of embedded guides in the Field Service (Dynamics 365) mobile app.
ms.date: 07/26/2023
ms.topic: how-to
ms.subservice: field-service-mobile
author: andrea-orimoto
ms.author: andreo
---

# Embed Guides 2D in Field Service Mobile (preview)

With Embedded Guides 2D mobile (preview), you can create and view Dynamics 365 guides on your mobile device. Guides are interactive instructions that help you perform tasks in the real world. With Guides 2D, you can use your phone or tablet to create, edit, and view guides.

With Guides 2D mobile, you can:

- Access guides from anywhere, anytime, using your iOS or Android mobile device (tablet and phone).

- Use guides already created in your existing environment.

- Easily navigate through guide content using sort, filter, and search.

- Access text instruction, photos, videos, Power Apps workflows, and website links.

- Analyze guide execution time from recorded session data that includes location, device type, duration, time spent on each step.

## Limitations

- Guides 2D mobile is supported in English only

- Guides content can't be rendered in alternate character sets such as Japanese, simplified Chinese, traditional Chinese or Korean.

## Prerequisites

- An active Dynamics 365 Guides license, either a trial or paid

- Insiders Program platform registration with the terms of the preview and the Dynamics 365 Guides on Mobile preview program accepted

- A new environment with [Dynamics 365 Guides version 800.6.x installed](/power-platform/admin/manage-apps#install-an-app-in-the-environment-view)

- Dynamics 365 Field Service installed on your mobile device from your app store

- Dynamics 365 Field Service iOS update or Android update installed

## Set up Embedded Guides 2D in Field Service Mobile

1. On your mobile device, open the Field Service app.

1. Sign in using your Guides credentials.

1. Enable non-production apps. 

1. Find the Guides environment entry and select it. Guides Mobile starts.

## Turn on usage data collection for Embedded Guides 2D in Field Service Mobile

Dynamics 365 Guides enables customers to capture usage statistics and detailed time-tracking information. This data is turned off by default, but an admin can 
turn on data collection for specific users.

1. Go to [powerapps.microsoft.com](https://powerapps.microsoft.com/) and sign in with your admin account.

1. Select **Guides**. A new tab for the Guides model-driven app opens.

1. In the left-navigation pane, select the up arrow next to **Main** and then select **Settings**.

   :::image type="content" source="media/powerapps-guides-settings.png" alt-text="Screenshot of the Main Settings for Guides in Power Apps.":::  

1. Select **New**.

1. In the **New User Settings** screen, under **User Settings**, enter the following information:

   - **Name**: Opt in for [User name]

   - **Record Guide Usage**: Yes

   - **Belongs To**: [User name]

   :::image type="content" source="media/powerapps-user-settings.png" alt-text="Screenshot of the User Settings for Guides in Power Apps.":::  
