---
title: "Forecast case and conversation volumes in Customer Service | Microsoft Docs"
description: "Learn how to use use the Forecast report for cases and conversations in Dynamics 365 Customer Service and Dynamics 365 Customer Service workspace."
ms.date: 04/25/2022
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

# Forecast case and conversation volumes (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
  
## Introduction

Customer service supervisors need to be able to ensure that they have an adequate number of agents available to serve their customers. Overcapacity results in higher costs, while under capacity results in longer customer wait times, which in turn can negatively impact customer satisfaction.

As a supervisor, you can use the Forecast report to help you plan the right level of staffing for your business based on the predicted volume of cases and conversations.

You can use the Forecast report for case and conversation volumes in the following ways:

- Forecast upcoming case and conversation volumes based on historical traffic. For conversation volume forecasting, if chatbots are set up for your conversational channels, conversations handled by chatbots that have no human agent joined are excluded from the forecasting, so that you can rely on the predicted conversation volumes for human agent staffing.

- Visualize forecast volumes on a daily, weekly, and monthly interval basis, for a time range up to six months (depending on how many days of cases or conversations were created in the past).

- Slice and dice forecasted volumes by channel and queue.

- Automatically detect seasonality from historical traffic with the settings option to import your service calendar. This helps the forecasting model to accurately predict case or conversation volume during special, seasonal events.

## Prerequisites

Before you can use the Forecast report, ensure your administrator has given you Customer Service Manager role permissions. More information: []()

## View the Forecast report in Customer Service

You can access the Forecast report in the Customer Service workspace app by selecting the plus (+) icon, and then selecting **Forecast (preview)**, or in Customer Service Hub by selecting **Forecast (preview)** under **Insights** in the site map.

### Filters for case and conversation forecasting

The **Case** and **Conversation** tabs of the volume forecast report display visual and numeric metrics for the filters you select. The difference between the two tabs is based on the input data source. Case data is based on the case entity, whereas conversation data is based on the omnichannel conversations, such as live chat, digital messages, the voice channel, and so forth.

Report data is refreshed on a monthly basis. Your administrator can configure which day of the month the report will be refreshed.

You can filter the case data by using any of the following options:

|Filter |Description |
|--------|-------------|
|Duration|Input the date range or use the sliders to set the dates. |
|Channel|Select the channel(s) for which you want data displayed. |
|Queue|If there are queues associated with the cases, you can filter on specific queues. |

### Case volume visualization

The **Case forecasting** section of the report displays a visual trend from historical case volume in the past to the predicted case volume in the future. The forecast is based on actual case records from the case entity created in the past.

The **Confidence level** for the forecasted data is displayed on the right-hand side in blue, indicating the level of confidence in the predicted volume. The narrowest part of the blue area indicates higher confidence. You can hover on the report to display the forecast based on data for specific dates.
