---
title: "Add custom KPIs to intraday insights dashboard | MicrosoftDocs"
description: "How to add custom KPIs to intraday insights dashboard for the Omnichannel for Customer Service."
keywords: ""
author: udaykirang
ms.author: udag
manager: shujoshi
applies_to: 
ms.date: 10/24/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 893b9aeb-67ab-4d20-aa5e-82eb50051bcb
ms.custom: 
---

# Customize KPIs for Intraday insights

To cater to your organizational needs, the Intraday insights dashboard allows you to add custom KPIs to the dashboard. This allows supervisors to adapt to your organizational parameters that are specifically designed for your organization. As an administrator, you must add theses KPIs to the dashboard through Power BI desktop application. To add custom KPIs to Intraday insights dashboard, follow these steps:

1. [Review prerequisites](#review-prerequisites)

2. [Add custom KPIs](#add-custom-kpis)


## Review prerequisites

Verify the following prerequisites before you add the custom KPIs:

1. Power BI desktop app is installed on your computer.

2. Administrator or equivalent role is assigned to you. 

3. Intraday insights dashboard is configured for your organization. To Learn more, see [Configure to view intraday insights dashboard](configure-intraday-dashboard-supervisor.md)


## Add custom KPIs

1. Open the Power BI desktop application on your computer and sign in with your administrator credentials.

2. From the **Home** menu, select **Get Data** > **Power BI datasets**.

    > [!div class=mx-imgBorder]
    > ![Select Power BI datasets](../media/supervisor-admin-custom-kpis-select-pbidatasets.png "Select Power BI datasets")

    The dataset selection dialog box opens.

3. Select **Intraday insights** and the fields related to Intraday insights dashboards are loaded.

4. Select a field and create a measure for the field. To learn more about creating you own measure, see [Create a measures](https://docs.microsoft.com/en-us/power-bi/desktop-tutorial-create-measures#create-a-measure).

5. Save and publish the measure.
 
6. Add the measure to your report. To learn more, see [Use your measure in the report](https://docs.microsoft.com/en-us/power-bi/desktop-tutorial-create-measures#use-your-measure-in-the-report)

    The custom KPI measure is added to Intraday insights dashboard.

To learn more about how to create custom measures, see [Tutorial: Create your own measures in Power BI Desktop](https://docs.microsoft.com/en-us/power-bi/desktop-tutorial-create-measures).

### See also

[Configure to view intraday insights dashboard](configure-intraday-dashboard-supervisor.md)