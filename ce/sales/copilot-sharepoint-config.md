---
title: Configure Copilot to use specific SharePoint folders
description: Learn how to configure Copilot to look at specific SharePoint locations to get content recommendations and answers from SharePoint.
ms.date: 10/22/2024
ms.topic: how-to
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: bap-template
---

# Configure Copilot to use specific SharePoint folders

Sales organizations often store documents that are related to products and sales, such as product brochures and specifications, price lists, and sales pitches, in SharePoint. You can configure Copilot to look at specific SharePoint locations when your sellers ask for [content recommendations and answers from SharePoint](copilot-get-doc-suggestions.md) and [summaries of sales documents](copilot-get-information.md#summarize-proposals-or-sales-documents). If you don't configure Copilot to use specific SharePoint folders, it searches all the SharePoint folders that the user has access to.

The results that Copilot returns are based on the permissions that users have in SharePoint. If a user doesn't have access to a SharePoint folder, Copilot doesn't show results from that location.

## Prerequisite

Copy the Path URL of the SharePoint folders that you want to configure for Copilot to use. Open the folder in SharePoint and select the information icon to copy the **Path** URL as shown in the following image.

:::image type="content" source="media/sharepoint-path.png" alt-text="Screenshot of the details pane in SharePoint with information icon and Path fields highlighted.":::

## Configure SharePoint folders


1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Under **General Settings**, select **Copilot**.

1. Select **Knowledge sources**.

1. Select **+ Configure SharePoint locations**.


    :::image type="content" source="media/sharepoint-path.png" alt-text="Screenshot of a folder details pane in SharePoint, with the information icon and Path field highlighted.":::

1. In the Configure SharePoint locations dialog, enter a name to identify the folder, paste the folder URL in the **SharePoint URL** field, and then select **Add more** to add more folders.

1. Repeat steps 6 and 7 for each SharePoint folder that you want Copilot to use.

1. When you're done, save your changes.

## Related information

- [Use Copilot to get content recommendations and answers from SharePoint](copilot-get-doc-suggestions.md)
- [Summarize proposals or sales documents](copilot-get-information.md#summarize-proposals-or-sales-documents)
