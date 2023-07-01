---
title: "Configure agent forecasting for conversations in Customer Service | Microsoft Docs"
description: "Learn how to configure agent forecasting for conversations in Dynamics 365 Customer Service and Dynamics 365 Customer Service workspace."
ms.date: 06/30/2023
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

# Configure agents for conversations forecasting (preview)

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

Customer service supervisors in your organization need to ensure that they have an adequate number of agents available to serve their customers. Overcapacity results in higher costs, while under capacity results in longer customer wait times, which in turn can negatively impact customer satisfaction.

As an administrator, you can configure the Agent forecasting for conversation report to help your supervisors plan the right level of staffing for your business based on predicted volumes of conversations.

Supervisors can use the Agent forecasting for conversation report in the following ways:

- Forecast upcoming conversation volumes based on historical traffic. For conversation volume forecasting, if chatbots are enabled for your conversational channels, then the chatbot conversations that don't include a human agent are excluded from the forecast. You can then rely on the predicted conversation volumes for human agent staffing.

- Forecast agent demand to meet the forecasted conversation volume, based on business requirements, such as service level agreement, shrinkage, and concurrency.

- Visualize forecasted conversation volumes and agent demand on a daily basis, for a time range up to six months depending on how many days of cases were created in the past. This forecast can be used to plan agent resourcing and recruitment, to meet future demand.

- Visualize forecasted conversation volumes and agent demand on a 15-minute interval basis, for a time range up to 6 weeks depending on how many days of cases were created in the past. This forecast can be used to schedule agents to meet the near-term demand.

- Slice forecasted volumes and agent demand by channel and queue.

- View rollup of actual and forecasted volume by hourly, daily, weekly, monthly and yearly basis. For agent demand report, option to select the type of rollup from Maximum, Minimum, Average and Sum.

- Automatically detect seasonality from historical traffic with the settings option to import your holiday calendar. This automatic detection helps the forecasting model to accurately predict case or conversation volume during special, seasonal events.

> [!NOTE]
> Be aware of the following when using the Forecast report:
>
> - Forecasts might misstate volume estimates for many reasons, including unanticipated trends or business developments.
>
> - The agent forecasting for conversation report is currently available in certain geographical locations. More information: [Regional availability and Service limits for Customer Service](cs-region-availability-service-limits.md).

## How agent forecasting for conversation works

The forecast report for conversations uses an AI-backed forecasting model to predict conversation volumes based on historical conversation data. The model uses ensemble forecasting methodology with seasonality support (automatic detection and custom settings) to enhance the quality of forecasting.
The forecast report for agents for conversations uses a statistical model to calculate the agent demand from the forecasted volumes.

The report can forecast daily trends for a date range up to six months, and intra day (15-minute interval) trends for a date range up to six weeks, depending on how many days of historical data are available and used. In general, the model can forecast for a period that is half of the input date range, with the following conditions:

- For the daily conversation volume and agent demand forecast, if the historical data time range is less than 12 months, the forecasting time range is the half of the input time range. For example, eight months of historical date range can forecast for the next four months. If the historical range equals or is more than 12 months (up to 24 months), the report will forecast for the next six months.
- For the intraday (15-minute interval) conversation volume and agent demand forecast, the model only analyzes the recent six weeks of historical data. The time range of forecast is half of the total input time range. For example, 12 weeks historical date range can forecast for the next six weeks (which is the maximum). Out of these 12 weeks of historical data, only the recent six weeks will be analyzed to generate the forecast.

The historical data must meet the following minimum requirements for the models to generate forecasting. Otherwise, an error message will be posted on the admin settings page.  

- At least two weeks of historical data is available.

## Key considerations to enhance forecast accuracy

We recommend the following criteria for utilizing users' data to generate accurate forecasts.

- Non-sparse data: The dataset contains information for every day, ensuring that there isn't missing or incomplete data. Each day has a recorded volume, providing a comprehensive set of observations.
- Clear weekly pattern: The data exhibits a weekly pattern, wherein the volume consistently follows a specific trend. For instance, weekends consistently have low volumes, while workdays show higher volumes, and vice versa. This pattern helps in establishing a reliable basis for forecasting.
-  Volume-based accuracy: If the criteria are met, the forecast quality improves with larger volume inputs. Higher volumes of data contribute to a more accurate and robust forecast.
-  Absence of level shift: Recent days and future periods don't experience any sudden or significant shifts in volume levels. This absence of sudden changes ensures that the historical patterns remain relevant and dependable for forecasting purposes.
-  Longer historical data set: If all the above criteria are met, a longer history of data further improves the forecast accuracy. A greater historical data set provides a broader perspective and a more comprehensive understanding of the patterns and trends over time. With an extended history, the forecast model can capture and incorporate more variations, leading to more accurate predictions.
•	Weighting recent forecast accuracy: While considering future periods, it's important to acknowledge that the accuracy of the forecast tends to be higher for more immediate timeframes. As time progresses into the future, the certainty and precision of the forecast may decrease. Therefore, the most recent forecast should be given more weight and considered to have better accuracy compared to forecasts for distant future periods.

## Prerequisites

To configure the **Agent forecasting for conversation (preview)** report, you must have the system administrator role.

For users in your organization to be able to access the forecast reports, they must be part of a role that has **Read** privileges on the **msdyn_dataanalyticsreport_forecast** table. Your system administrator must assign this privilege to any role that needs access to the forecasting reports. Out of the box, the following roles already have read privileges on the Forecast table:

- CSR Manager
- Omnichannel administrator
- Omnichannel supervisor

## Enable the Agent forecasting for conversation (preview) reports

1. In the Customer Service admin center app, under **Operations**, select **Insights**. The **Insights** page is displayed.

1. Under the **Report settings** section, next to **Agent forecasting for conversation (preview)**, select **Manage**. The **Agent forecasting for conversation (preview)** page is displayed.

1. Toggle **Enable agent capacity forecasting** to **On**.

1. The report reflects the day on which it’s enabled. If you want to choose a different day of the month for the report to be updated, in **Daily forecasting schedule**, select the day for which you want the report to refresh.

1. After the report is generated for the first time, you’ll see a **Model run summary** section at the top of the page that displays the date and time on which the forecast was last created. The time reflects your time zone. If you want to set a different default time zone, do the following steps:

   a. Select the **Settings** (gear) icon in the top-right corner of the app, and then select **Personalization Settings**. The **Set Personal Options** page is displayed.

   b. In **Set the time zone you are in**, choose the time zone you want from the dropdown menu.

   c. Select **OK**.
  
1. If you want to change the time zone to use for forecasting, in **Time zone for daily forecasting**, select time zone you want.

1. If you want to select a particular date that the data starts from, under **Historical data start date (optional)**, choose the **Start date** you want. The latest (closest) date that the start date can be is at least two weeks back from the current date. If nothing is selected, the start date will be decided based on the earliest creation date of all of your historical records, up to two years. If the start date you select is earlier than two years, only last two years of data will be used.

1. If you want to specify seasonality, under **Seasonality**, select the **Use schedules from Holiday Calendar** check box. Selecting the **Holiday Calendar** link opens the **All Holiday Schedules** page, where you can create a new schedule or select an existing schedule.

1. Under **Global Forecasting configuration** specify the following settings at the global level to apply to all channels. Some default values are provided as a suggestion to get you started, but you may want to change them to meet the needs of your organization.

   - **Required Service Level (%)**: The percentage of the conversations needed to meet the target answer time. For example, if you set your required service level percentage to 80 and your target answer time to 77, it indicates that you want 80 percent of your conversations to be answered in 77 seconds or less.
   - **Target Answer Time (Seconds)**: The number of seconds in which you want your agents to answer their conversations.
   - **Shrinkage (%)**: The percentage of time agents are unavailable to handle conversations. If you increase this number, the percentage of time that the agents are unavailable goes up, which means you would need more agents to meet the service-level agreement.
   - **Concurrency (#)**: The number of simultaneous interactions per agent. For voice calls, this value should be set to one. For chats and messaging channels, this value can be set as desired.

1. (Optional) If you want to override the values that are set in the **Global Forecasting configuration** for specific channels, you can use the settings in **Override Channel Forecasting configuration** to set values for each channel that's available in your organization. Any settings you don't change in the override will remain as set at the global level. To specify overrides for one or more channels, do the following:

    - Select the channels you want to specify overrides for in the **Select channels to override configuration** dropdown list. Once selected, click on the **Add to override** button.
    - An override section for each channel that you selected is added to the configuration page. Specify the overrides for the channel. You do not need to override all values. Any value that you do not override will use the value specified in the **Global Forecasting configuration** section.
    - To remove a channel override, click on the **Remove this channel override** link in the override section for that channel. You will be prompted to confirm the remove action.

   An example of when an override might be useful is if you have both voice and chat channels. The **Concurrency (#)** setting in **Global Forecasting configuration** would be set to one for the voice channel, but then you could use the **Live Chat-override** setting to change the chat concurrency to a higher frequency, such as three.
  
1. Save your changes. If this is the first time you’ve enabled the forecast feature, it may take up to 24 hours until the forecasting data is ready to view in the forecast report.

### See also

[Forecast case and conversation volumes, and agents for conversations (preview)](use-volume-forecasting.md)<br>
[Configure case forecasting (preview)](configure-volume-forecasting.md)<br>
[Introduction to Customer Service Insights](introduction-customer-service-analytics.md)<br>
[Regional availability and Service limits for Customer Service](cs-region-availability-service-limits.md)
