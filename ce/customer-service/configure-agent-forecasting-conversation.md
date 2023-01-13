---
title: "Configure agent forecasting for conversations in Customer Service | Microsoft Docs"
description: "Learn how to configure agent forecasting for conversations in Dynamics 365 Customer Service and Dynamics 365 Customer Service workspace."
ms.date: 10/01/2022
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

# Configure agent forecasting for conversation (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

## Introduction

Customer service supervisors in your organization need to ensure that they have an adequate number of agents available to serve their customers. Overcapacity results in higher costs, while under capacity results in longer customer wait times, which in turn can negatively impact customer satisfaction. 

As an administrator, you can configure the agent forecasting for conversations to help your supervisors plan the right level of staffing for your business based on predicted volumes of conversations.

Supervisors can use the agent forecasting for conversation report in the following ways:

- Forecast upcoming conversation volumes based on historical traffic. For conversation volume forecasting, if chatbots are set up for your conversational channels, conversations handled by chatbots that have no human agent joined are excluded from the forecasting, so that you can rely on the predicted conversation volumes for human agent staffing.
- Visualize forecast volumes on a daily, weekly, and monthly interval basis, for a time range up to six months (depending on how many days of cases or conversations were created in the past).
- Slice and dice forecasted volumes by channel and queue.
- Automatically detect seasonality from historical traffic with the settings option to import your holiday calendar. This helps the forecasting model to accurately predict case or conversation volume during special, seasonal events.

- Forecast agent demand to meet the forecasted conversation volume, based on business requirements, such as service level agreement, shrinkage, and concurrency.

> [!Note]
> Be aware of the following when using the Forecast report:
> 
> - Forecasts might misstate volume estimates for many reasons, including unanticipated trends or business developments.
> 
> - The agent forecasting for conversation report is currently available in certain geographical locations. More information: [Regional availability and Service limits for Customer Service](cs-region-availability-service-limits.md).<br>

## How agent forecasting for conversation works

The forecast report for conversations uses an AI-backed forecasting model to predict conversation volumes based on historical conversation data. The model uses ensemble forecasting methodology with seasonality support (automatic detection and custom settings) to enhance the quality of forecasting.
The forecast report for agents for conversations uses a statistical model to calculate the agent demand from the forecasted volumes.

The report can forecast for a period of up to six months in the future, depending on how many days of historical data are available and used. In general, the model can forecast for a period that is half of the input date range, with the following conditions:

- If the historical data time range is less than 12 months, forecasting time range is the half of the input time range. For example, eight months of historical date range can forecast for next four months.
- If the historical range equals or is more than 12 months (up to 24 months), the report will forecast for the next six months. 

The historical data must meet the following minimum requirements for the models to generate forecasting. Otherwise, an error message will be posted on the admin settings page.  

- At least two weeks of historical data is available. 
- The average daily volume should be more than 50 conversations per queue and channel combination. Forecasting will not be generated for any queue and channel combination, having less than average daily volume of 50 conversations.
- Per channel and queue combination, you must have at least one conversation on 70 percent of days in the calculation period for that channel and queue combination. The calculation period is computed as the number of days from the creation time of the earliest conversation (that falls within the configured historical time range) for that channel and queue combination to one day prior to the date the model runs. So, for example, if your historical range is configured to start from January 1st of a given year, you run the forecasting model on September 1st, and the earliest recorded conversation for a channel and queue combination occurred on March 15th, the model will check all of the data within the date range from March 15th to August 31st. If there's conversation available for at least 70 percent of the days between March 15th and August 31st, only then will that channel and queue combination be included for forecasting. Even though you would have data for each day of the date range, there may be a scenario where the data might not meet the 70 percent rule for every queue and channel. In this case, the model wouldn't run successfully, and no forecast would be produced.

## Prerequisites

To configure the agent forcasting for conversation report, you must have the system administrator role.

For users in your organization to be able to access the forecast reports, they must be part of a role that has **Read** privileges on the **Forecast (preview)** table. You must assign this privilege to any role that needs access to the forecasting reports.

## Enable the Agent forecasting for conversation (preview) report

1. In the Customer Service admin center app, under **Operations**, select **Insights**. The **Insights** page is displayed.

1. In the **Report settings** section, go to **Agent forecasting for conversation (preview)**, and then select **Manage**. The **Agent forecasting for conversation (preview)** page is displayed.

1. Toggle **Enable agent capacity forecasting** to **On**.
   
1. The report reflects the day on which it’s enabled. If you want to choose a different day of the month for the report to be updated, in **Daily forecasting schedule**, select the day for which you want the report to refresh.

1. After the report is generated for the first time, you’ll see a **Model run summary** section above **Basic forecasting configuration** that displays the date and time on which the forecast was last created. The time reflects your time zone. If you want to set a different default time zone, do the following steps:

   a. Select the **Settings** (gear) icon in the top-right corner of the app, and then select **Personalization Settings**. The **Set Personal Options** page is displayed.
   
   b. In **Set the time zone you are in**, choose the time zone you want from the dropdown menu.
   
   c. Select **OK**.
  
1. If you want to change the time zone to use for daily forecasting, in **Time zone for daily forecasting**, select time zone you want.

1. If you want to select a particular date that the data starts from, in **Historical data start date (optional)**, choose the **Start date** you want. The latest (closest) date that the start date can be is at least two weeks back from the current date. If nothing is selected, the start date will be decided based on the earliest creation date of all of your historical records, up to two years. If the start date you select is earlier than two years, only last two years of data will be used.

1. If you want to specify seasonal, in **Seasonality**, select the **Use schedules from Holiday Calendar** check box. Selecting the **Holiday Calendar** link opens the **All Holiday Schedules** page, where you can create a new schedule or select an existing schedule.

1. Save your changes. If this is the first time you’ve enabled the forecast feature, it may take up to 24 hours until the forecasting data is ready to view in the Forecast report. 

1. In **Global Forecasting configuration** specify the following settings at the global level to apply to all channels. Some default values are provided as a suggestion to get you started, but you may want to change them to meet the needs of your organization.

   - **Required Service Level (%)**: The percentage of the conversations needed to meet the target answer time. For example if your required service level percentage is 80 and your target answer time is 77, you want 80 percent of your conversations to be answered in 77 seconds or less.
   - **Target Answer Time (Seconds)**: The number of seconds in which you want your agents to answer their conversations.
   - **Shrinkage (%)**: The percentage of time agents are unavailable to handle conversations. If you increase this number, the percentage of time that the agents are unavailable goes up, which means you would need more agents to meet the service-level agreement.
   - **Concurrency (#)**: The number of simultaneous interactions per agent. For voice calls, this value should be set to one. For chats, the number can be set as desired.

1. (Optional) If you want to override the values that are set in the **Global Forecasting configuration** for specific channels, you can use the settings in **Override Channel Forecasting configuration** to set values for each channel that's available in your organization. Any settings you don't change in the override will remain as set at the global level. Select the channels you want to use overrides for in the **Select channels to override configuration** dropdown list.

   An example of when an override might be useful is if you have both voice and chat channels. The **Concurrency (#)** setting in **Global Forecasting configuration** would be set to one for the voice channel, but then you could use the **Live Chat-override** setting to change the chat concurrency to a higher frequency, such as three.
  
1. When you've finished entering the settings, select **Save**. Changes you've made to these settings will take effect starting from the next scheduled refresh.

### See also

[Forecast agent, case, and conversation volumes](use-volume-forecasting.md)<br>
[Configure case forecasting](configure-volume-forecasting.md)<br>
[Introduction to Customer Service Insights](introduction-customer-service-analytics.md)<br>
[Regional availability and Service limits for Customer Service](cs-region-availability-service-limits.md)
