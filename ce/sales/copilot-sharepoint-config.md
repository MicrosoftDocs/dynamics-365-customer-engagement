---
title: Configure Copilot to use specific SharePoint folders
description: Learn how to configure Copilot to use specific SharePoint locations to get content recommendations and answers from SharePoint.
ms.date: 08/05/2024
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

Sales organizations often store product-related documents, such as product brochures, pricing, sales pitch, and specifications in SharePoint. By configuring SharePoint locations, you can help sellers get relevant [content recommendations and answers](copilot-get-doc-suggestions.md) from the documents stored in specific folders. If you don't configure any SharePoint location, Copilot searches all the SharePoint folders that the user has access to.

## Prerequisite

Copy the Path URL of the SharePoint folders that you want to configure for Copilot to use. Open the folder in SharePoint and select the information icon to copy the **Path** URL as shown in the following image.

:::image type="content" source="media/sharepoint-path.png" alt-text="Screenshot of the details pane in SharePoint with information icon and Path fields highlighted.":::

## Configure SharePoint folders

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Under **General Settings**, select **Copilot**.

1. Select **Knowledge sources**.
1. Select **+ Configure SharePoint locations**.
1. In the **Configure SharePoint locations** dialog box, specify the name and **Path** URL of the SharePoint folder that you want to use with Copilot. You can add multiple SharePoint folders.

  Copilot searches the content in the specified SharePoint folders to provide content recommendations and answers. The results displayed in Copilot are based on the permissions that users have in SharePoint. If a user doesn't have access to a SharePoint folder, Copilot doesn't show results from that location. 
