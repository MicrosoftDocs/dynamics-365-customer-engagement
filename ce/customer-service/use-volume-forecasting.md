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

# Forecast agent, case, and conversation volumes

Customer service supervisors need to be able to ensure that they have an adequate number of agents available to serve their customers. Overcapacity results in higher costs, while under capacity results in longer customer wait times, which in turn can negatively impact customer satisfaction.

As a supervisor, you can use the Forecast report to help you plan the right level of staffing for your business based on the predicted volume of cases and conversations.

You can use the Forecast report for agent, case, and conversation volumes in the following ways:

- Forecast upcoming case and conversation volumes based on historical traffic and the number of agents needed to meet the forecasted conversation volume. For conversation volume forecasting, if your administrator has set up chatbots for your conversational channels, the system excludes conversations that chatbots handle without a human agent joined, so that you can rely on the predicted conversation volumes for human agent staffing.

- Visualize forecast volumes on an intraday, daily, weekly, and monthly interval basis, for a time range up to six months depending on how many days of cases or conversations were created in the past.

- Slice forecasted volumes by channel and queue.

- Automatically detect seasonality from historical traffic with the settings option to import your holiday calendar. This helps the forecasting model to accurately predict case or conversation volume during special, seasonal events.

For details of how the forecast models work for this feature, see [How agent forecasting for conversation works](configure-agent-forecasting-conversation.md#how-agent-forecasting-for-conversation-works).

> [!Note]
> Be aware of the following when using the Forecast report:
> 
> - Forecasts might misstate volume estimates for many reasons, including unanticipated trends or business developments.
> 
> - The Forecast report is currently available in certain geographical locations. More information: [Regional availability and Service limits for Customer Service](cs-region-availability-service-limits.md)

## Prerequisites

Before you can use the Forecast report, ensure that your administrator has given you Customer Service Manager role permissions. More information: [Configure case and conversation volume forecasting](configure-volume-forecasting.md)

REQUIRED SOLUTION VERSIONS - Sourav is working on this

## View the Forecast report in Customer Service

**Navigation**

You can view the Forecast dashboard in the Customer Service workspace or Omnichannel for Customer Service apps. You can navigate to the **Forecast** dashboard as follows:

- In the default view, select the plus (**+**) icon, and then select **Omnichannel historical analytics**. On the page that appears, select **Forecast**.
- If the enhanced multisession workspace view is enabled, select the site map, and then select **Omnichannel historical analytics**. On the page that appears, select **Forecast**.

   :::image type="content" source="media/forecast-dashboard.png" alt-text="View of the Forecast report.":::

### Filters for case, conversation, and agents for conversations forecasting

The **Cases**, **Conversations** and **Agents for conversations** tabs of the forecast report display visual and numeric metrics for the filters you select. The difference between the tabs is based on the input data source. Case data is based on the case entity, whereas conversation data is based on the omnichannel conversations, such as live chat, digital messages, the voice channel, and so forth.

Report data is refreshed on a monthly basis. Your administrator can configure which day of the month the report will be refreshed. More information: [Configure case forecasting](configure-volume-forecasting.md)

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

#### Filter data by drilling up or down

You can drill into the report data by using the up or down arrows at the top-right side of the report to display data by day, week, month, or year. Forecasting supports date ranges of up to six months.

:::image type="content" source="media/volume-forecasting-drill-month.png" alt-text="View of the Forecast report data filters.":::

If you select the single down arrow, you can drill down to a specific date. For example, if the report shows a month view, you can select the single down arrow, and then select the specific month on the report that you want to drill down to. The report will then display the data for that specific month.

### View volume forecasting by numbers

The number grid at the bottom of the report predicts the exact number of cases to expect across months, based on actual past data.

You can filter the data by selecting from the following options:

|Filter	|Description |
|---------|------------|
|All up	|Displays the actual and forecasted numbers day by day. You can use the up and down arrows to drill to specific levels.|
|Queue	|Displays both actual and forecasted numbers for each queue.|
|Channel	|If there are channels associated with the cases, the actual and forecasted case numbers are displayed for each channel.|

### Export data

You can export the report data by selecting **Export** on the command bar.

:::image type="content" source="media/forecast-export-data.png" alt-text="View of the Forecast report Export data menu item.":::

The data for the date range that you selected is saved in an Excel spreadsheet. For the **Sum of Forecast** column, there will only be numbers for dates that are in the future. Actual numbers are based on monthly date that your administrator configured for the report to be refreshed.



### See also
[Configure case forecasting](configure-volume-forecasting.md)<br>
[Configure agent forecasting for conversation](configure-agent-forecasting-conversation.md)<br>
[Introduction to Customer Service Insights](introduction-customer-service-analytics.md)<br>
[Regional availability and Service limits for Customer Service](cs-region-availability-service-limits.md)<br>
[Manage report bookmarks](manage-bookmarks.md)  

