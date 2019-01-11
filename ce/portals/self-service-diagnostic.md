---
title: "Identify and fix customer issues with a portal in Dynamics 365 for Customer Engagement | MicrosoftDocs"
description: "Learn to identify and fix customer issues with a portal."
ms.custom: 
  - dyn365-portal
ms.date: 01/04/2019
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: E8D2F922-57FD-47B0-B0C4-A6DE276ADFE0
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: shubhadaj
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Portals
---

# Self-service diagnostic

Dynamics 365 Portal provides a self-service environment for administrators to run the diagnostic tool to see if their portal has any issues. The diagnostic tool collects customer issues from the portal solution and portal website, collates the issues, and displays them on a single page. This helps administrators find and fix the issues.

When you run the diagnostic tool, the results are displayed in the **Diagnostic results** section in a grid format. The results grid has the following columns:

- **Issue**: Displays the top-level issue faced by a customer; for example, performance issue.
- **Category**: Displays the top-level area where issues can be categorized; for example, provisioning, solution upgrade, and so on.
- **Result**: Displays the status of issue; for example, error, warning, and so on.

By default, information in the grid is sorted by the **Result** column in this order: error, warning, and pass.

You can expand an issue to view detailed information and mitigation steps. If the mitigation requires any action, you'll see a button that will perform the action. You can also provide feedback on whether the mitigation was useful.

If required, you can rerun the diagnostic checks, which will refresh the results with updated data.

> [!NOTE]
> While running the diagnostic tool, you must ensure the following or else you will see an error:
> - Portal is turned on.
> - IP address filtering is disabled.

To run the diagnostic tool:

1.	Go to the Dynamics 365 admin center and select the **Applications** tab.
2.	Select the name of the portal for which you want to run the diagnostic tool, and then select **Manage**.
3.	Go to **Diagnose and resolve problems**.
4.	Select **Run diagnostics**. The diagnostic session will start and gather data about the customer issues. The results are displayed in the **Diagnostic results** section.
5.	To rerun the diagnostic checks, select **Refresh results**.
