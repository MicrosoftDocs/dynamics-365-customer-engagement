---
title: "Customize Power BI template apps to work with Dynamics 365 Sales | MicrosoftDocs"
description: "Learn about customizing Power BI template apps to work with Dynamics 365 Sales."
ms.date: 03/30/2020
ms.service: dynamics-365-sales
ms.topic: article
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# Customize Power BI template apps for Dynamics 365 Sales

> [!IMPORTANT]
> Microsoft doesn't support customizations made to the Power BI template app and doesn't provide updates after modifications are made.

Power BI is a comprehensive collection of services and tools that you use to visualize your business data. Power BI Template apps make it easy to visualize and analyze the sales data with Power BI based on a standard data model. The Sales Analytics for Dynamics 365 Sales and Process Analytics for Dynamics 365 Power BI template apps are built with a set of entities and fields that are useful for most reporting scenarios.

Dynamics 365 apps are often extended with custom fields. These custom fields don't automatically show up in the Power BI model. This section describes how you can edit and extend the report included in the template app to include custom fields in the Power BI model.

Before you customize the template app, read the information here and perform each task, as necessary.

## Prerequisites

- [Power BI service registration](https://powerbi.com/)
- [Power BI Desktop](https://powerbi.microsoft.com/desktop/) application for editing Power BI reports
- Power BI report for the template app that you want to customize:
    - [Download the Power BI report for Sales Analytics for Dynamics 365 Sales](https://go.microsoft.com/fwlink/p/?linkid=2121605)
    - [Download the Power BI report for Process Analytics for Dynamics 365](https://go.microsoft.com/fwlink/p/?linkid=2121504)

## Prepare a PBIX for customization

1.  Start Power BI Desktop.

2.  Select **File** > **Open**. Select the .pbix file you want to edit, and then select **Open**.

    Several pages of reports are loaded and displayed in Power BI Desktop.

3.  On the Power BI Desktop ribbon, select **Edit Queries**.

4.  In the left navigation pane of the **Edit Queries** window, under **Queries**, select the D365_Sales_URL query, and then on the ribbon, select **Advanced Editor**.

    In the source definition, replace the placeholder value with the URL of your app's instance. For example, if the organization name is _Contoso_, the URL looks like this: Source = `https://contoso.crm.dynamics.com`

5.  Select **Done**, and then select **Close & Apply** in the Query Editor.

6.  When the **Access an OData feed** dialog box appears, select **Organizational account**, and then select **Sign in**.
 
7.  When the sign-in field appears, enter your credentials to authenticate to your instance.

8.  In the **Access an OData feed** dialog box, select **Connect**.

It might take several minutes for the queries to be updated.

### See also

[Analyze your sales data by using Power BI template apps](introduction-sales-template-apps.md)<br>
[Configure Power BI template apps to work with Dynamics 365 Sales](configure-sales-template-apps.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
