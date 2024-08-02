
---
title: Configure Copilot to use specific SharePoint locations
description: Learn how to configure Copilot to use specific SharePoint locations to get content recommendations and answers from SharePoint.
ms.date: 07/31/2024
ms.topic: how-to
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: bap-template
---

# Configure Copilot to use specific SharePoint locations

Configure the SharePoint locations that you want to use with Copilot to help sellers [get content recommendations and answers from SharePoint](copilot-get-doc-suggestions.md). If you don't configure any SharePoint location, Copilot uses the root SharePoint site of your organization.

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Under **General Settings**, select **Copilot**.

1. Select **Knowledge sources**.
1. Select **+ Configure SharePoint locations**.
1. In the **Configure SharePoint locations** dialog box, specify the name and URL of the SharePoint site that you want to use with Copilot. You can add multiple SharePoint locations.

  The results from the SharePoint locations are based on the permissions that users have in SharePoint. If users don't have access to a SharePoint location, Copilot doesn't show results from that location.
