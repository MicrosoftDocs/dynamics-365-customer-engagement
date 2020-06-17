---
title: "msdyn_ForecastApi custom action (Developer Guide for Dynamics 365 Sales)| MicrosoftDocs"
description: ""
ms.date: 06/17/2020
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
# msdyn_ForecastApi action

The `msdyn_ForecastApi` custom action enables you perform various action to retrieve and update forecasting configurations.

## Parameters

|Parameter name| Required| Description|
|----|----|----|
|`WebApiName`|Yes|Contains the name of the API to be executed|
|`RequestJson`|Yes|Contains the parameters and the arguments for the API call.|

## GET_ForecastConfigurations

Returns the list of all for forecast configurations having the name provided as part of request payload.

### Example

```http
POST [Organization URI]/api/data/v9.1/msdyn_ForecastApi/ HTTP/1.1
Content-Type: application/json

{
    "WebApiName": "GET_ForecastConfigurations",
    "RequestJson": "{}"
}
```
### Return value

List of Forecast Configurations.

## GET_ForecastConfigurationsByName 

Returns the list of all for forecast configurations having the name provided as part of request payload.

### Example

```http
POST [Organization URI]/api/data/v9.1/msdyn_ForecastApi HTTP/1.1
Content-Type: application/json

{
    "WebApiName": "GET_ForecastConfigurationsByName",
    "RequestJson": "{\"Name\":\"api_test1\"}"
}
```

### Return value

List of Forecast Configurations.

## GET_ForecastPeriodsByForecastConfigurationId

Returns all the forecast periods for the active forecast configuration Id, that is provided as part of the request payload.

### Example

```http
POST [Organization URI]/api/data/v9.1/msdyn_ForecastApi HTTP/1.1
Content-Type: application/json

{
    "WebApiName": "GET_ForecastPeriodsByForecastConfigurationId",
    "RequestJson": "{\"Name\":\"api_test1\"}"
}
```
### Return value

List of Forecast Periods.

## GET_ForecastInstances

Returns the list of forecast instances that are a single row entity record.

> [!NOTE]
> Forecast periods can have many forecast instances far more than you would want to pull down in a single request. The API endpoints default to providing a limited number of items per request.<br />Note: Large queries can hurt performance, so the number of results per page is capped at 4000 records. If you wish to retrieve more than 4000 records, for example to build a client-side list of all available forecast instances, you can make multiple API requests and combine the results within your application.

### Example

```http
POST [Organization URI]/api/data/v9.1/msdyn_ForecastApi HTTP/1.1
Content-Type: application/json

{
    "WebApiName": "GET_ForecastInstances",
    "RequestJson": "{\"Name\":\"api_test1\"}"
}
```
### Return value

List of Forecast Periods.

## Update_SimpleColumnByEntityId

Updates the specific column values using the values of the passed parameters.

### Example

```http
POST [Organization URI]/api/data/v9.1/msdyn_ForecastApi HTTP/1.1
content-type: application/json

{
    "WebApiName": "Update_ SimpleColumnByEntityId ",
    "RequestJson": "
    {\"ForecastConfigurationId\":\"0461fb6b-8d85-ea11-a811-000d3a37bb2c\",\"ForecastRecurranceId\":\"f8b1122c-b913-4e88-9727-368b6134be3e\",\"SimpleColumnUpdateRequests\":[{\" HierarchyEntityRecordId\":\"d8680b00-fd31-46c2-8136-7c4df19cf2a8\",\"ForecastConfigurationColumnId\":\"65ec7bd1-2de6-49fa-b259-ba74bc721c78\",\"ForecastConfigurationColumnValue\":0.0,\"IsRolledUpColumnUpdate\":false},{\" HierarchyEntityRecordId\":\"11141300-131b-493a-9857-22bd8689b775\",\"ForecastConfigurationColumnId\":\"65ec7bd1-2de6-49fa-b259-ba74bc721c78\",\"ForecastConfigurationColumnValue\":0.0,\"IsRolledUpColumnUpdate\":false}]}"
}
```
### Return value

A list of `UpdateSimpleColumnByEntityResponse` records consisting of `HierarchyEntityRecordId`, `ForecastConfigurationColumnId`, `Message`, `StatusCode`.

## Update_SimpleColumnByFIId

Updates the specific column value by setting the values of the parameters passed.

> [!NOTE]
> Large number of update requests in a single API call can hurt performance, so the updates per request are capped at 50.  

### Example

```http
POST [Organization URI]/api/data/v9.1/msdyn_ForecastApi HTTP/1.1
content-type: application/json

{
    "WebApiName": "Update_SimpleColumnByFIId",
    "RequestJson": "
    {\"ForecastConfigurationId\":\"0461fb6b-8d85-ea11-a811-000d3a37bb2c\",\"ForecastRecurranceId\":\"f8b1122c-b913-4e88-9727-368b6134be3e\",\"SimpleColumnUpdateRequests\":[{\"ForecastInstanceId\":\"d8680b00-fd31-46c2-8136-7c4df19cf2a8\",\"ForecastConfigurationColumnId\":\"65ec7bd1-2de6-49fa-b259-ba74bc721c78\",\"ForecastConfigurationColumnValue\":0.0,\"IsRolledUpColumnUpdate\":false},{\"ForecastInstanceId\":\"11141300-131b-493a-9857-22bd8689b775\",\"ForecastConfigurationColumnId\":\"65ec7bd1-2de6-49fa-b259-ba74bc721c78\",\"ForecastConfigurationColumnValue\":0.0,\"IsRolledUpColumnUpdate\":false}]}"
}
```

### Return value

A list of `UpdateSimpleColumnByEntityResponse` records consisting of `ForecastInstanceId`, `ForecastConfigurationColumnId`, `Message`, `StatusCode`.

## See also

[Custom actions for forecasting](../custom-actions-manual-forecasting.md)