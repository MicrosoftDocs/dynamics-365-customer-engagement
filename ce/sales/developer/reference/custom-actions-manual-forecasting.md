---
title: "Custom actions for forecasting - Sales Enterprise | MicrosoftDocs"
description: "As a developer, use this reference documentation for defining custom actions for manual forecasting."
ms.date: 12/15/2021
ms.topic: reference
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
search.audienceType: 
  - developer
search.app: 
  - D365CE
ms.custom: 
  - dyn365-sales
---
# Custom actions for forecasting 

## Requirements
|  | |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise or Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security Role** | System customizer <br>  See [Predefined security roles for Sales](../../../sales/security-roles-for-sales.md)|
|||


The following custom actions are used for forecasting:

- **msdyn_ForecastInstanceActions**: Retrieve forecast and snapshot data. **For internal use only.**<br />
- **msdyn_ForecastConfigurations**: Returns the list of all for forecast configurations having the name provided as part of request payload. **For internal use only.**<br />
- **msdyn_ForecastApi**: Enables you to perform various actions to retrieve and update forecasting data. More information: [msdyn_ForecastApi action](custom-actions\msdyn_ForecastApi.md)

### See also

[Project accurate revenue with sales forecasting](../../project-accurate-revenue-sales-forecasting.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
