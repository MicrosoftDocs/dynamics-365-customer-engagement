---
title: Add pages to your app's site map
description: Learn how to customize the navigation of your custom Dynamics 365 Sales app by adding pages to the site map.
ms.date: 02/02/2024
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.owner: shujoshi
ms.custom: bap-template
---

# Add pages to your app's site map

When you create a custom model-driven app, it comes with a default site map. You can [edit the default site map](/power-apps/maker/model-driven-apps/create-site-map-app#edit-the-default-site-map) to add or remove groups, areas, and subareas, or [create a site map from scratch](/power-apps/maker/model-driven-apps/create-site-map-app). Whether you use the default site map or a new one, you can add pages to easily customize your app's navigation.

## Add pages to the site map

Add an entry to the site map from a Dataverse table, a dashboard, a URL, a web resource, or a custom page.

1. Sign in to [Power Apps portal](https://make.preprod.powerapps.com/).

1. In the left pane, select **Apps**.

1. Select your app, and then select **Edit**.

    You can also select the app's name in the list to open it for editing.

1. In the **Navigation** section, select the name of the group to add the page to, and then select **New**.

    You can also select the ellipsis (**&hellip;**) next to the group name, and then select **New page**.

    :::image type="content" source="./media/add-custom-site-map-entry.svg" alt-text="Screenshot of a custom app editing page, with options for adding a new page highlighted.":::

1. Select a content type for the new page, and then select **Next**.

1. Select the content to add to the page.

    | Content type | Description |
    |--------------|-------------|
    | **Dataverse table** | Search for and select a table from the list. You can also create a table from here. |
    | **Dashboard** | Select a dashboard from the list. |
    | **URL** | Enter a URL and a title. |
    | **Web resource** | Select a web resource from the list and enter a title. |
    | **Custom page** | Create a custom page or select an existing one. |

    For example, to add the administrator settings overview page to the site map, select **URL** and enter the following URL: `/main.aspx?pagetype=control&controlName=MscrmControls.FieldControls.CCFadminsettings`.

1. Select **Add**.

1. Save and publish the app.

## Related information

- [Customize the Dynamics 365 Sales app](manage-app.md)
