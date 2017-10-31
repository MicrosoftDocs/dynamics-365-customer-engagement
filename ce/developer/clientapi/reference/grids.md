---
title: "Grids and subgrids in Customer Engagement for Dynamics 365| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 9d35c036-637f-4580-8ba0-027a44c0fdee
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Grids and subgrids in Customer Engagement (Client API reference)

[!INCLUDE[](../../../includes/cc_applies_to_update_9_0_0.md)]

> [!NOTE]
> ![This page is under construction. Check back soon!](../../../media/under_construction.png "Coming soon") [!INCLUDE[cc-under-construction](../../../includes/cc-under-construction.md)]


Grids present data in a tabular format in Customer Engagement. Grids can span the entire form or can be one of the items on a form; the latter are called subgrids.

There are two types of grids in Customer Engagement:
- **Read-only grids**: Display data in a tabular format. To edit the data displayed ina read-only grid, you have to click the record in the grid to open the form, edit the data, and then save.
-  **Editable grids**: In addition to displaying data in a tabular format, provides rich inline editing capabilities on web and mobile clients including the ability to group, sort, and filter data within the same grid so that you do not have to switch records or views. The editable grid is a custom control, and is supported in the main grid and subgrids on a form in the web client and in dashboards and on form grids on the mobile clients. Although the editable grid control provides editing capability, it honors the read-only grid metadata and field-level security settings.

>[!NOTE]
>We are still working on adding reference information about Client API methods for grids.
