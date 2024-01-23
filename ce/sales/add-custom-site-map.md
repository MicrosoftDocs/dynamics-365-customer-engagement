---
title: Add site map entry to custom app
description: Learn how to add a site map entry to your custom app in a few simple steps.
ms.date: 02/02/2024
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.owner: shujoshi
ms.custom: bap-template
---

# Add site map entry to custom app

Know how to add site map entry to your custom app.

## Prerequisites

Before you start adding site map entry to your custom app, make sure you have System administrator or similar role.

## Add the site entry

In this procedure, we're adding the administrator settings overview page site map entry via a URL.

1. Sign in to [Power Apps portal](https://make.preprod.powerapps.com/).
1. On the left navigation pane, select **Apps**.
1. Select the app and then select **Edit**.
1. In the custom app edit page, from the **Navigation** section, hover over the group name for which you want to add the site map entry and then select **New page**.
1. In the **New page** dialog box, select an option according to your requirement. Here, we are adding the site map entry using a **URL**.
1. Select **Next**.
1. Enter the following URL information:
   - **URL**: Enter the value ```/main.aspx?pagetype=control&controlName=MscrmControls.FieldControls.CCFadminsettings``` to render for the administrator settings overview page. 
   - **Title**: Enter the display name for the site map entry.
1. Select **Add**.
1. Save and publish the custom app.

The site map entry is added to your custom app.

To understand how to add site map entry to your custom app, see [Create a model-driven app site map using the site map designer](/power-apps/maker/model-driven-apps/create-site-map-app).

### See also

[Customize the app](manage-app.md)