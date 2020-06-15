---
title: "msdyn_ForecastConfigurationsByName custom action (Developer Guide for Dynamics 365 Sales)| MicrosoftDocs"
description: ""
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
# msdyn_ForecastConfigurationsByName action

Returns the list of all for forecast configurations having the name provided as part of request payload. 

## Example

```http
POST [Organization URI]/api/data/v9.1/msdyn_ForecastConfigurationsByName HTTP/1.1
Content-Type: application/json

{
    "WebApiName": "GET_ForecastConfigurationsByName",
    "RequestJson": "{\"Name\":\"api_test1\"}"
}
```

## Return value

List of Forecast Configurations.

## See also

[Custom actions for forecasting](../custom-actions-manual-forecasting.md)