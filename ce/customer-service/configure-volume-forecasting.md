---
title: "Configure case forecasting in Customer Service | Microsoft Docs"
description: "Learn how to configure the Forecast report for cases in Dynamics 365 Customer Service and Dynamics 365 Customer Service workspace."
ms.date: 07/06/2023
ms.topic: article
author: lalexms
ms.author: laalexan
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
---

# Configure case volume forecasting (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

## Introduction

> [!IMPORTANT]
> This feature is intended to help customer service managers or supervisors enhance their team's performance and improve customer satisfaction. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365 Customer Service, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

Customer service supervisors in your organization need to ensure that they have an adequate number of agents available to serve their customers. Overcapacity results in higher costs, while undercapacity results in longer customer wait times, which in turn can negatively impact customer satisfaction.

As an administrator, you can configure the Case forecasting report to help your supervisors plan the right level of staffing for your business based on predicted volumes of cases.

Supervisors can use the Case forecasting report in the following ways:

- Forecast upcoming case volumes based on historical traffic.

- Visualize forecasted case volumes on a daily basis for a time range up to six months, depending on how many days of cases were created in the past. This forecast can be used to plan agent resourcing and recruitment to meet future demand.

- Visualize forecasted case volumes on a 15-minute interval basis, for a time range up to six weeks depending on how many days of cases were created in the past. This forecast can be used to schedule agents to meet the near-term demand.

- Slice forecasted volumes by channel and queue.

- View a rollup of actual and forecasted volume by hourly, daily, weekly, monthly, and yearly basis.

- Automatically detect seasonality from historical traffic with the settings option to import your holiday calendar. This helps the forecasting model to accurately predict case volume during special, seasonal events.

> [!NOTE]
> Be aware of the following when using the Case forecasting report:
>
> - Forecasts might misstate volume estimates for many reasons, including unanticipated trends or business developments.
>
> - The Forecast report is currently available in certain geographical locations. More information: [Regional availability and Service limits for Customer Service](cs-region-availability-service-limits.md).

## How case forecasting works

The Forecast report uses an AI-backed forecasting model that predicts case volumes based on historical case data. The model uses an ensemble forecasting method with seasonality support (automatic detection and custom settings) to enhance the quality of forecasting.

The report can forecast daily trends for a date range up to six months, and intraday (15-minute interval) trends for a date range up to six weeks, depending on how many days of historical data are available and used. In general, the model can forecast for a period that is half of the input date range, with the following conditions:

- For daily case volume forecasting, if the historical data time range is less than 12 months, the forecasting time range is the half of the input time range. For example, eight months of historical date range can forecast for the next four months. If the historical range equals or is more than 12 months (up to 24 months), the report will forecast for the next six months.
- For intraday (15 minutes interval) case volume forecasting, the model only analyzes the recent six weeks of historical data. The time range of forecast is half of the total input time range. For example, 12 weeks historical date range can forecast for the next six weeks (which is the maximum). Out of these 12 weeks of historical data, only the recent six weeks will be analyzed to generate the forecast.

The historical data must meet the following minimum requirements for the models to generate forecasting. Otherwise, an error message will be posted on the admin settings page.  

- At least two weeks of historical data is available.

## Key considerations to enhance forecast accuracy

We recommend the following criteria for utilizing users' data to generate accurate forecasts.

- Non-sparse data: The dataset contains information for every day, ensuring that there isn't missing or incomplete data. Each day has a recorded volume, providing a comprehensive set of observations.
- Clear weekly pattern: The data exhibits a weekly pattern, wherein the volume consistently follows a specific trend. For instance, weekends consistently have low volumes, while workdays show higher volumes, and vice versa. This pattern helps in establishing a reliable basis for forecasting.
-  Volume-based accuracy: If the criteria are met, the forecast quality improves with larger volume inputs. Higher volumes of data contribute to a more accurate and robust forecast.
-  Absence of level shift: Recent days and future periods don't experience any sudden or significant shifts in volume levels. This absence of sudden changes ensures that the historical patterns remain relevant and dependable for forecasting purposes.
-  Longer historical data set: If all the above criteria are met, a longer history of data further improves the forecast accuracy. A greater historical data set provides a broader perspective and a more comprehensive understanding of the patterns and trends over time. With an extended history, the forecast model can capture and incorporate more variations, leading to more accurate predictions.
- Weighting recent forecast accuracy: When considering future periods, it's important to acknowledge that the accuracy of the forecast tends to be higher for more immediate timeframes. As time progresses into the future, the certainty and precision of the forecast may decrease. Therefore, the most recent forecast should be given more weight and considered to have better accuracy compared to forecasts for distant future periods.

## Prerequisites

To configure the **Case forecasting (preview)** report, you must have the System Administrator role.

For users in your organization to be able to access the forecast reports, they must be part of a role that has **Read** privileges on the **msdyn_dataanalyticsreport_forecast** table. Your system administrator must assign this privilege to any role that needs access to the forecasting reports. Out of the box, the following roles already have read privileges on the Forecast table:

- CSR Manager
- Omnichannel administrator
- Omnichannel supervisor

## Enable the case forecasting (preview) report

1. In the Customer Service admin center app, under **Operations**, select **Insights**. The **Insights** page is displayed.

1. Under the **Report settings** section, next to **Case forecasting (preview)**, select **Manage**. The **Case forecasting (preview)** page is displayed.

1. Toggle **Enable case forecasting** to **On**.

1. The report reflects the day on which it’s enabled. If you want to choose a different day of the month for the report to be updated, in **Daily forecasting schedule**, select the day for which you want the report to refresh.

1. After the report is generated for the first time, you’ll see a **Model run summary** section at the top of the page that displays the date and time on which the forecast was last created. The time reflects your time zone. If you want to set a different default time zone, do the following steps:

   a. Select the **Settings** (gear) icon in the top-right corner of the app, and then select **Personalization Settings**. The **Set Personal Options** page is displayed.

   b. In **Set the time zone you are in**, choose the time zone you want from the dropdown menu.

   c. Select **OK**.
  
1. If you want to change the time zone to use for forecasting, under **Time zone for daily forecasting**, select time zone you want.

1. If you want to select a particular date that the data starts from, under **Historical data start date (optional)**, choose the **Start date** you want. The latest (closest) date that the start date can be is at least two weeks back from the current date. If nothing is selected, the start date will be decided based on the earliest creation date of all of your historical records, up to two years. If the start date you select is earlier than two years, only last two years of data will be used.

1. If you want to specify seasonality, under **Seasonality**, select the **Use schedules from Holiday Calendar** check box. Selecting the **Holiday Calendar** link opens the **All Holiday Schedules** page, where you can create a new schedule or select an existing schedule.

1. Save your changes. If this is the first time you’ve enabled the forecast feature, it may take up to 24 hours until the forecasting data is ready to view in the forecast report.

### See also

[Forecast case and conversation volumes, and agents for conversations (preview)](use-volume-forecasting.md)<br>
[Configure agents for conversations forecasting (preview)](configure-agent-forecasting-conversation.md)<br>
[Introduction to Customer Service Insights](introduction-customer-service-analytics.md)<br>
[Regional availability and Service limits for Customer Service](cs-region-availability-service-limits.md)
