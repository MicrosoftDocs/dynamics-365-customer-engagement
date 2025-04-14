---
title: Sales forecasting overview
description: Accurately project sales for your team and estimate the revenue by using sales forecasting in Dynamics 365 Sales.
ms.date: 02/02/2024
ms.topic: overview
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: 
  - dyn365-sales
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-Entity-msdyn_forecastinstance
  - D365-Entity-forecastdefinition
  - D365-Entity-msdyn_forecastconfiguration
  - D365-Entity-msdyn_forecastdefinition
  - D365-Entity-forecastconfiguration
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---
# Overview of sales forecasting

A forecast helps your organization predict how much revenue your sales team will generate in a given timeframe. When done correctly, it can play a significant role in your company's success. 

>[!IMPORTANT]
>This feature is intended to help sales managers or supervisors enhance their team’s performance. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with sales persons may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their sales persons that their communications with end users may be monitored, recorded, or stored.

## How does a forecast help sales team

By using a forecast:

- Sellers can track their performance against targets and identify pipeline risks that might jeopardize their ability to hit the targets.

- Managers can track individual sales performance against quotas, to proactively provide coaching.

- Directors can use forecast trends to anticipate departmental sales and reallocate resources if necessary.

- Organization leaders can use projected estimates to change product strategy or convey updated projections to investors.

## Review prerequisites

Review the following prerequisites before using forecasts:

 -  The forecast was created with at least one of the following options:

    -  A hierarchy that you're part of.

    -  A security role that you're part of has been granted access.

    To learn more, see [Configure a forecast](configure-forecast.md).

-  You must have read privileges for User and Territory entities. To learn more, see [Security roles and privileges](/power-platform/admin/security-roles-privileges).


## Add forecast grid and configuration site map entries to custom app

When you create a custom model-driven app, you can choose a default solution to create a sitemap for the app. However, the list contains solutions that are based on entity forms only. The forecast options are based on URL custom control forms and do not appear in the solution list. You must manually add these options to the sitemap. After you add these options, users in your organization can see them on the app’s sitemap.  
Use the following URLs to add the forecast site map to your custom app and perform the steps in [add site map entry to custom app](add-custom-site-map.md):

| Feature name           | URL                                                                                           |
|------------------------|-----------------------------------------------------------------------------------------------|
| Forecast grid          | `/main.aspx?pagetype=control&controlName=ForecastingControls.FieldControls.ForecastGridPage`  |
| Forecast configuration | `/main.aspx?pagetype=control&controlName=ForecastingControls.FieldControls.CCFForecastConfig` |

## Related information

[Configure a forecast](configure-forecast.md)<br>
[View a forecast](view-forecasts.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
