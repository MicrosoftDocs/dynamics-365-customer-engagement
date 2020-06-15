---
title: "Custom actions for manual forecasting (Developer Guide for Dynamics 365 Sales)| MicrosoftDocs"
description: "Reference documentation for the custom actions of manual forecasting"
ms.date: 06/15/2020
ms.service: 
  - dynamics-365-sales
ms.custom: 
  - dyn365-sales
ms.topic: reference
author: susikka
ms.author: susikka
manager: shujoshi
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Custom actions for forecasting

The following actions are used for forecasting:

- **msdyn_ForecastInstanceActions**: Retrieve forecast and snapshot data. For internal use only.<br />
- **msdyn_ForecastConfigurations**: Returns the list of all for forecast configurations having the name provided as part of request payload.<br />
- **msdyn_ForecastApi**: <br />
- **msdyn_ForecastConfigurationsByName**: Returns the list of all for forecast configurations having the name provided as part of request payload. <br />
- **msdyn_ForecastPeriodsByForecastConfigurationId**: Returns all the forecast Periods for the active forecast configuration Id provided as part of the request payload.<br />

### See also

[Project accurate revenue with sales forecasting](../../project-accurate-revenue-sales-forecasting.md)
