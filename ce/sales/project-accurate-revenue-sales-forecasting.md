---
title: Sales forecasting overview
description: Accurately project sales for your team and estimate the revenue by using sales forecasting in Dynamics 365 Sales.
ms.date: 03/12/2026
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
# Forecast revenue accurately with Dynamics 365 Sales

In Dynamics 365 Sales, forecasting gives teams a shared, near real-time view of expected revenue by combining pipeline activity, forecast categories, quotas, and hierarchy rollups. It helps sellers understand whether they are on track, helps managers identify risks early, and helps leadership make faster planning decisions based on current data instead of end-of-period surprises.

Forecasts are most effective when they are reviewed regularly and used as a planning tool, not just a reporting artifact. By comparing committed revenue, best-case opportunities, and gaps to target, teams can take corrective actions earlier in the cycle.

:::image type="content" source="media/forecast-for-team-hierarchy.png" alt-text="Screenshot of a forecast grid showing the forecast for a team hierarchy." lightbox="media/forecast-for-team-hierarchy.png":::

> [!TIP]
> **Ready to get started?** [View the out-of-the-box forecast](view-forecasts.md#open-and-view-a-forecast) or [Set up a forecast in 7 steps](configure-forecast.md) 

>[!IMPORTANT]
>This feature is intended to help sales managers or supervisors enhance their team’s performance. This feature isn't intended for use in making, and shouldn't be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with sales persons may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their sales persons that their communications with end users may be monitored, recorded, or stored.

## How does a forecast help your sales team

Forecasts give everyone in the organization a shared, data-driven picture of expected revenue. Here's what that means by role:

**For Sellers** — Track performance against quota, identify pipeline risks before they derail targets, and focus effort on the right deals.

**For Managers** — Monitor individual performance, coach sellers on pipeline gaps, and spot risks early enough to take corrective action.

**For Directors** — Anticipate departmental revenue trends and reallocate resources to high-opportunity regions or teams.

**For Leadership** — Use projected estimates to adjust product strategy or communicate updated projections to investors and stakeholders.

### Example

A software organization sees its quarterly forecast trending 12% below target in one region. Using the forecast grid, the sales manager identifies that several high-value opportunities are still in an early category and are unlikely to close on time. The manager reassigns experienced sellers, adds executive support to key deals, and launches a short campaign for late-stage opportunities. As a result, the region improves forecast accuracy and closes the quarter closer to quota.

## Review prerequisites

Review the following prerequisites before using forecasts:

 -  The forecast was created with at least one of the following options:

    -  A hierarchy that you're part of.

    -  A security role that you're part of has been granted access.

    To learn more, see [Configure a forecast](configure-forecast.md).

-  You must have read privileges for User and Territory entities. To learn more, see [Security roles and privileges](/power-platform/admin/security-roles-privileges).


## Add forecast grid and configuration site map entries to custom app

When you create a custom model-driven app, you can choose a default solution to create a sitemap for the app. However, the list contains solutions that are based on entity forms only. The forecast options are based on URL custom control forms and do not appear in the solution list. You must manually add these options to the sitemap. After you add these options, users in your organization can see them on the app's sitemap.  
Use the following URLs to add the forecast site map to your custom app and perform the steps in [add site map entry to custom app](add-custom-site-map.md):

| Feature name           | URL                                                                                           |
|------------------------|-----------------------------------------------------------------------------------------------|
| Forecast grid          | `/main.aspx?pagetype=control&controlName=ForecastingControls.FieldControls.ForecastGridPage`  |
| Forecast configuration | `/main.aspx?pagetype=control&controlName=ForecastingControls.FieldControls.CCFForecastConfig` |

## Related information

[Configure a forecast](configure-forecast.md)<br>
[View a forecast](view-forecasts.md)