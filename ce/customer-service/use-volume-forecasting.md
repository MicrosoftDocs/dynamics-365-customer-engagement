---
title: "Forecast agent, case, and conversation volumes in Customer Service | Microsoft Docs"
description: "Learn how to use the Forecast report for agent, case, and conversation volumes in Dynamics 365 Customer Service, Omnichannel for Customer Service, and Customer Service workspace."
ms.date: 04/01/2023
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Forecast case and conversation volumes, and agents for conversations (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

## Introduction

Customer service supervisors need to be able to ensure they have an adequate number of agents available to serve their customers. Overcapacity results in higher costs, while under capacity results in longer customer wait times, which in turn can negatively impact customer satisfaction.

As a supervisor, you can use the forecast reports to help plan the right level of staffing for your business based on the predicted volume of cases and conversations, along with the predicted agent demand for conversations.

You can use the forecast reports for agent, case, and conversation volumes in the following ways:

- Forecast upcoming case and conversation volumes based on historical traffic and the number of agents needed to meet the forecasted conversation volume. For conversation volume forecasting, if your administrator has set up chatbots for your conversational channels, the system excludes conversations that chatbots handle without a human agent joined, so that you can rely on the predicted conversation volumes for human agent staffing.

- Visualize forecasted volumes and agent demand on a daily basis, for a time range up to six months depending on how many days of cases or conversations were created in the past. This forecast can be used to plan agent resourcing and recruitment, to meet future demand.

- Visualize forecast volumes and agent demand on a fifteen minute interval basis, for a time range up to six weeks depending on how many days of cases or conversations were created in the past. This forecast can be used to schedule agents to meet the near-term demand.

- Slice forecasted volumes and agent demand by channel and queue.

- View rollup of actual and forecasted volume by hourly, daily, weekly, monthly and yearly basis. For agent demand report, option to select the type of rollup from Maximum, Minimum, Average and Sum.

- Automatically detect seasonality from historical traffic with the settings option to import your holiday calendar. This helps the forecasting model to accurately predict case or conversation volume during special, seasonal events.

For details of how the forecast models work for this feature, see [How agent forecasting for conversation works](configure-agent-forecasting-conversation.md#how-agent-forecasting-for-conversation-works) and [How case volume forecasting works](configure-volume-forecasting.md#how-case-forecasting-works).

> [!NOTE]
> Be aware of the following when using the Forecast report:
>
> - Forecasts might misstate volume estimates for many reasons, including unanticipated trends or business developments.
>
> - The Forecast report is currently available in certain geographical locations. More information: [Regional availability and Service limits for Customer Service](cs-region-availability-service-limits.md)

## Prerequisites

Before you can use the forecast reports, ensure that your administrator has assigned you to a role that has **Read** privileges on the **Forecast (preview)** table. More information: [Configure case volume forecasting (preview)](configure-volume-forecasting.md#prerequisites) and [Configure agents for conversations forecasting (preview)](configure-agent-forecasting-conversation.md#prerequisites).

## View the Forecast reports in Customer Service

### Navigation

You can view the forecast reports in the Customer Service workspace or Omnichannel for Customer Service apps. You can navigate to the **Forecast (preview)** dashboard as follows:

- In the default view, select the plus (**+**) icon, and then select **Forecast (preview)**.
- If the enhanced multi session workspace view is enabled, click on the hamburger menu icon to open the site map, and then select **Forecast (preview)**.

   :::image type="content" source="media/forecast-dashboard.png" alt-text="View of the Forecast report.":::

### Switching report mode

The forecast reports support two modes:

- **Daily** - This mode displays the actual and predicted case and conversation volumes and agent demand per day, for a time range of up to six months depending on how many days of cases or conversations were created in the past. This forecast can be used to plan agent resourcing and recruitment, to meet future demand.

- **Intraday** - This mode displays the actual and predicted case and conversation volumes and agent demand in intervals of fifteen minutes, for a time range of up to six weeks depending on how many days of cases or conversations were created in the past. This forecast can be used to schedule agents to meet the near-term demand.

To change the report mode, click on the **Daily** or **Intraday** toggle button on the report, depending on which mode you want to view the report in.

### Filters for case, conversation, and agents for conversations forecasting

The **Case volumes**, **Conversation volumes** and **Agents for conversations** tabs of the forecast report display visual and numeric metrics for the filters you select. The difference between the tabs is based on the input data source. Case data is based on the case entity, whereas conversation data is based on the omnichannel conversations, such as live chat, digital messages, the voice channel, and so forth.

Report data is refreshed on a monthly basis. Your administrator can configure which day of the month the report will be refreshed. More information: [Configure case volume forecasting (preview)](configure-volume-forecasting.md#enable-the-case-forecasting-reports-in-customer-service) and [Configure agents for conversations forecasting (preview)](configure-agent-forecasting-conversation.md#enable-the-agent-forecasting-for-conversation-reports).

You can filter the data on each of the tabs by using any of the following options:

|Filter |Description |
|--------|-------------|
|Duration|Input the date range or use the sliders to set the dates. |
|Channel|Select the channel(s) for which you want data displayed. |
|Queue|Select the queue(s) for which you want data displayed. |

### Data visualization

The forecasting section on each tab of the report displays a visual trend from historical volumes from the past to the predicted volume in the future. The forecast is based on actual case, conversation, and agent records created in the past.

The **Confidence level** for the forecasted data is displayed on the right-hand side in blue, indicating the level of confidence in the predicted volume. The narrowest part of the blue area indicates higher confidence. You can hover on the report to display the forecast based on data for specific dates.

:::image type="content" source="media/case-forecast-actuals.png" alt-text="View of confidence level in Forecast report.":::

Hover on the future side (dash line) of the report to show a range that includes an upper and lower bound confidence range, which indicates the amount of possible variance that could occur from the predicted volume number.

### View volume forecasting by numbers

The number grid at the bottom of the report shows the actual and predicted number of cases, conversations or agent demand across different date and time hierarchies.

You can filter the data by selecting from the following options:

|Filter |Description |
|---------|------------|
|All up |Displays the actual and forecasted numbers across all channels and queues. You can use the drill up and down buttons to drill to specific levels in the hierarchy.|
|Channel |Displays the actual and forecasted numbers, sliced by each channel. You can use the drill up and down buttons to drill to specific levels in the hierarchy.|
|Queue |Displays the actual and forecasted numbers, sliced by each queue. You can use the drill up and down buttons to drill to specific levels in the hierarchy.|

#### Filter data by drilling up or down

You can drill into the report data table by using the up or down arrows at the top-right side of the number grid, to display data by day, week, month, or year for **Daily**, and by minute, hour, day, week, month, or year for **Intraday**.

:::image type="content" source="media/volume-forecasting-drill-month.png" alt-text="View of the Forecast report data filters.":::

You can drill down the hierarchy by clicking the drill down hierarchy button. Each time you click on the button, the data will drill down one level in the hierarchy. To drill up to the previous level, click on the drill up button.

#### Select rollup mode (Agents for conversations report only)

The Agents for conversations report allows you to select the rollup method, that will be used in the number grid. The selected method is used to rollup data at higher levels in the date and time hierarchy. The following rollup methods are available:

- **Average** - This method averages the available data at a level in the date and time hierarchy to rollup to the next higher level in the hierarchy.
- **Maximum** - This method picks the maximum from the available data at a level in the date and time hierarchy to rollup to the next higher level in the hierarchy. *This is the default rollup selected when you access the report for the first time*.
- **Minimum** - This method picks the minimum from the available data at a level in the date and time hierarchy to rollup to the next higher level in the hierarchy.
- **Sum** - This method sums the available data at a level in the date and time hierarchy to rollup to the next higher level in the hierarchy.

> [!NOTE]
> Average, Maximum and Minimum rollup methods in All up view works differently than regular rollup using the same methods. In regular rollup, the rollup method is applied to the aggregate data across channels and queues. However, in Agents for conversations report, the data at a particular level in the date and time hierarchy, is the sum of the applied rollup method to the data for each unique channel and queue combination, at the immediate lower level in the hierarchy.
>
> For example, the data at the **Month** level, will be calculated by summing up the selected rollup method to the data at the **Week** level, for each unique combination of channel and queue.
>

### Export data

You can export the report data by selecting **Export** on the command bar.

:::image type="content" source="media/forecast-export-data.png" alt-text="View of the Forecast report Export data menu item.":::

### See also

[Configure case forecasting (preview)](configure-volume-forecasting.md)<br>
[Configure agent forecasting for conversation (preview)](configure-agent-forecasting-conversation.md)<br>
[Introduction to Customer Service Insights](introduction-customer-service-analytics.md)<br>
[Regional availability and Service limits for Customer Service](cs-region-availability-service-limits.md)<br>
[Manage report bookmarks](manage-bookmarks.md)  
