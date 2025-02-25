---
title: Customize Power BI template apps for Sales
description: Learn how to customize Power BI template apps for Dynamics 365 Sales. Extend reports with custom fields to better visualize your sales data.
ms.date: 02/25/2025
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:02/25/2025
---

# Customize Power BI template apps for Dynamics 365 Sales

You can use Power BI template apps to visualize and analyze the sales data.

> [!IMPORTANT]
> Microsoft doesn't support customizations made to the Power BI template app and doesn't provide updates after modifications are made.

## Customize the template apps

Power BI is a comprehensive collection of services and tools that you use to visualize your business data. Power BI Template apps make it easy to visualize and analyze the sales data with Power BI based on a standard data model. The Sales Analytics for Dynamics 365 Sales and Process Analytics for Dynamics 365 Power BI template apps are built with a set of entities and fields that are useful for most reporting scenarios.

Dynamics 365 apps are often extended with custom fields. These custom fields don't automatically show up in the Power BI model. This section describes how you can edit and extend the report included in the template app to include custom fields in the Power BI model.

Before you customize the template app, read the information here and perform each task, as necessary.

## Prerequisites

- [Power BI service registration](https://powerbi.com/)
- [Power BI Desktop](https://powerbi.microsoft.com/desktop/) application for editing Power BI reports
- Download the following Power BI reports (.pbix file) for the template app that you want to customize:

  - [Sales Analytics for Dynamics 365 Sales](https://go.microsoft.com/fwlink/p/?linkid=2121605)
  - [Process Analytics for Dynamics 365](https://go.microsoft.com/fwlink/p/?linkid=2121504)

## Prepare a PBIX for customization

1. Open the downloaded Power BI report file (.pbix) in Power BI Desktop.

   The app opens the report with sample data.

1. On the Power BI Desktop ribbon, select **Transform data** > **Edit parameters**.
1. Enter the URL of your organization's instance and select **OK**. For example, if the organization name is *Contoso*, the URL looks like this: `https://contoso.crm.dynamics.com`.
  A banner appears at the top of the page, prompting you to apply changes.
  :::image type="content" source="media/power-bi-query-banner.png" alt-text="Screenshot of the banner in Power BI Desktop that reminds you to apply changes":::
1. Select **Apply changes**.
1. In the **OData feed** dialog, select **Organizational account**, and then select **Sign in**.
1. Enter your credentials to authenticate to your instance and select **Connect**.
   It might take several minutes for the queries to be updated.

## Related information

[Analyze your sales data by using Power BI template apps](introduction-sales-template-apps.md)  
[Configure Power BI template apps to work with Dynamics 365 Sales](configure-sales-template-apps.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]