---
title: "msdyn_ForecastInstanceActions (Developer Guide for Dynamics 365 Sales) | MicrosoftDocs"
description: 
ms.date: 12/02/2019
ms.service: 
  - dynamics-365-sales
ms.custom: 
  - dyn365-sales
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Retrieve forecast and snapshot data using msdyn_ForecastInstanceActions for GDPR

Use **msdyn_ForecastInstanceActions** to programmatically retrieve the forecast and snapshot data that is related to you and your hierarchy. 

>[!NOTE]
> This topic is applicable only for [Forecast](../../../project-accurate-revenue-sales-forecasting.md) feature.

## Action parameters

**msdyn_ForecastInstanceActions** expects the following input parameters:

| Name | Type | Description |
|------|------|-------------|
| `RequestJson` | String | Parameters required for the web API name. Depending on the WebApiName and ServiceName, the value will change. |
| `ServiceName` | String | Name of the backend service. |
| `WebApiName` | String | This value of the parameter will change depending on what you want to retrieve. |

## Action return type

**msdyn_ForecastInstanceActions** returns the following value:

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>
<tr>
<td><code>msdyn_ForecastInstanceActionsResponse</code></td>
<td><a href="/dynamics365/customer-engagement/developer/webapi/web-api-types-operations#complex-types">ComplexType</a> </td>
<td>Contains the response from the <b>msdyn_ForecastInstanceActions</b> action. It contains the following property that contain the structured data of the type:
<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
<tr>
<td><code>Response</code></td>
<td>Edm.String</td>
<td>List of data as an escaped JSON array.</td>
</tr>
</table>
</table>

To retrieve your data, you must perform the following:

1. Create a post request to get metadata for the forecast or snapshot.

    - For forecast, see [Get metadata of the forecast](#get-metadata-of-the-forecast).

    - For snapshot, see [Get snapshot list](#get-snapshot-list)

2. Using the metadata response, create a post request to retrieve forecast or snapshot data.

    - For forecast data, see [Retrieve forecast data](#retrieve-forecast-data).

    - For snapshot data, see [Retrieve forecast data from a snapshot](#retrieve-forecast-data-from-a-snapshot)


## Get metadata of the forecast

Create a post request to fetch the metadata for a forecast. This helps you to get attribute values for `ForecastConfigurationId` and `Name` to identify the forecast ID to retrieve your forecast data.

**Request**

```http
POST [Organization URI]/api/data/v9.0/msdyn_ForecastInstanceActions 
Accept: application/json; 
Content-Type: application/json; 
OData-MaxVersion: 4.0; 
OData-Version: 4.0 
{ 
"RequestJson": "{\"AttributeInfo\":{\"ForecastInstance\":[\"ForecastConfigurationId\",\"ParentInstanceId\"]}}", 
"ServiceName": "mf-services", 
"WebApiName" : "forecast-meta-data" 
}  
```

**Response**

The response contains a JSON object with a `Response` property containing the list of data stored in Azure service that is used to compute and store data.

```http
HTTP/1.1 200 OK  
Content-Type: application/json; odata.metadata=minimal  
OData-Version: 4.0
{
    "@odata.context": "[Organization URI]/api/data/v9.0/$metadata#Microsoft.Dynamics.CRM.msdyn_ForecastInstanceActionsResponse",
    "response": {
        "Body": {
            "ForecastConfigurations": [
                {
                    "Columns": 
                        {
                            "ForecastConfigurationColumnId": "971841a0-5d42-4d9e-998d-a7b985148e9f",
                            "DisplayName": "Best Case",
                            "UniqueName": "bestcase",
                            ...
                        },
                    ...
                    "ForecastConfigurationId": "5e732d3e-ac11-ea11-a811-000d3a382afe",
                    "Name": "Forecast 2019",
                    ...
                }
            ],
            "ForecastRecurrences": [
                {
                    "Id": "a13ae9c8-9586-4c5f-ace2-f13faba56c44",
                    "ForecastConfigurationId": "5e732d3e-ac11-ea11-a811-000d3a382afe",
                    ...
                    "Name": "FY2019 Q4",
                    ...
                }
            ]
        },
        ...
    }
}
```

From the response, use the attributes `ForecastConfigurationId` and `Name` from `ForecastConfigurations` and get the `Id` of the recurrence from `ForecastRecurrences`. In this example, we are retrieving the forecast data for **Best Case** from **FY2019 Q4** of the **Forecast 2019**. Here we identified the recurrence ID value as `a13ae9c8-9586-4c5f-ace2-f13faba56c44` through `ForecastConfigurationId` value `5e732d3e-ac11-ea11-a811-000d3a382afe` and `Name` `Forecast 2019`. Using the `Id` value, you can create a post request to fetch data **Best Case** from **FY2019 Q4** for the forecast. 

## Retrieve forecast data

Using the `ForecastConfigurationId` and `Id` that you have fetched from metadata, create a post request to retrieve your forecast data. 

**Request**

```http
POST [Organization URI]/api/data/v9.0/msdyn_ForecastInstanceActions 
Accept: application/json; 
Content-Type: application/json; 
OData-MaxVersion: 4.0; 
OData-Version: 4.0 
{ 
"RequestJson": "{\"ForecastRecurrenceId\":\"a13ae9c8-9586-4c5f-ace2-f13faba56c44\",\"ForecastConfigurationId\":\"5e732d3e-ac11-ea11-a811-000d3a382afe\",\"ParentIds\":[\"00000000-0000-0000-0000-000000000000\"],\"PageInfoByParent\":{\"00000000-0000-0000-0000-000000000000\":{\"SortingAttribute\":\"HierarchyEntityRecord.RecordName\",\"SortingOrder\":\"ASC\",\"Count\":50,\"Skip\":0}},\"SnapshotId\":\"00000000-0000-0000-0000-000000000000\"}", 
"ServiceName": "mf-services", 
"WebApiName": "fetch-forecast" 
} 
```
**Response**

The response contains a JSON object with a `Response` property containing the list of data stored in Azure service that is used to compute and store data.

```http
HTTP/1.1 200 OK  
Content-Type: application/json; odata.metadata=minimal  
OData-Version: 4.0

{
    "@odata.context": "[Organization URI]/api/data/v9.0/$metadata#Microsoft.Dynamics.CRM.msdyn_ForecastInstanceActionsResponse",
    "response": {
        "Body": {
            "ForecastConfiguration": {
                ...
            },
            "ForecastRecurrence": {
                ...
            },
            "ForecastInstances": [
                {
                    ...
                },
                "AggregatedColumns": [
                    {
                        "ForecastConfigurationColumnId": "971841a0-5d42-4d9e-998d-a7b985148e9f",
                        "RecordId": "00000000-0000-0000-0000-000000000000",
                        "Value": 1500.0,
                        "DisplayValue": "1500",
                        "SystemValue": 1500.0,
                        "SystemDisplayValue": "1500",
                        "IsManualAdjusted": false,
                        "ParticipatingRecordsCount": 1,
                        "ManualAdjustment": null,
                        "AdjustmentHistory": [],
                        "UpdatedAttributeList": null
                    }
                ],
                "RolledUpColumns": [
                    {
                        "ForecastConfigurationColumnId": "971841a0-5d42-4d9e-998d-a7b985148e9f",
                        "RecordId": "00000000-0000-0000-0000-000000000000",
                        "Value": 2500.0,
                        "DisplayValue": "2500",
                        "SystemValue": 2500.0,
                        "SystemDisplayValue": "2500",
                        "IsManualAdjusted": false,
                        "ParticipatingRecordsCount": 0,
                        "ManualAdjustment": null,
                        "AdjustmentHistory": [],
                        "UpdatedAttributeList": null
                    }
                ],
                ...
            ]
        },
       ...
    }
}

```

In the response, you got  `ForecastConfiguration`, `ForecastRecurrence`, and `ForecastInstances` objects. In each of the `ForecastInstance` object we have two arrays: 

- `AggregatedColumns`: This parameter contains only your aggregated data.

- `RolledupColumns`: This parameter value displays *null* if you don't have a reporting hierarchy. If you have a reporting hierarchy, this parameter displays the merged data of yours and users who report to you.
 
Match `ForecastConfigurationColumnId` in the response and in the metadata response to identify the name of the column. In this example, the ID value is **971841a0-5d42-4d9e-998d-a7b985148e9f** for the response column **Best Case**. To view the values, see the `SystemValue` attribute of each column which is also shown on the forecast grid.


## Get snapshot list

Create a post request to fetch the list of snapshots. This helps you to get attribute values for `SnapshotID` and `SnapshotName` to identify the snapshot ID to retrieve your forecast data for the snapshot.

**Request**

```http
POST [Organization URI]/api/data/v9.0/msdyn_ForecastInstanceActions 
Accept: application/json; 
Content-Type: application/json; 
OData-MaxVersion: 4.0; 
OData-Version: 4.0 
{ 
"RequestJson": "{\"ForecastRecurrenceId\":\"a13ae9c8-9586-4c5f-ace2-f13faba56c44\",\"ForecastConfigurationId\":\"5e732d3e-ac11-ea11-a811-000d3a382afe\",\"Status\":2}",
"ServiceName": "snapshot-services", 
"WebApiName" : "RetrieveSnapshotList" 
}  
```

**Response**

The response contains a JSON object with a `Response` property containing the list of snapshot IDs stored in Azure service that is used to store data.

```http
HTTP/1.1 200 OK  
Content-Type: application/json; odata.metadata=minimal  
OData-Version: 4.0
{
    "@odata.context": "[Organization URI]/api/data/v9.0/$metadata#Microsoft.Dynamics.CRM.msdyn_ForecastInstanceActionsResponse",
    "response":"[
            {
                "SnapshotID":"6cbf024e-d582-4c03-b0db-48406554dcf9",
                "SnapshotName":"snap 2",
                "CreatedOn":"2020-01-14T14:44:45.33"
            },
            {
                "SnapshotID":"c61b0a19-6829-45eb-a368-9c6c14aa19fc",
                "SnapshotName":"snap 1",
                "CreatedOn":"2020-01-07T14:43:46.38"
            }
    ]"
}
```
From the response, get the snapshot ID for the forecast that you want to view the data. In this example, we are retrieving the list of snapshots for the forecast. Here we identified the snapshot IDs value as `c61b0a19-6829-45eb-a368-9c6c14aa19fc` through `SnapshotID` value. Using the `SnapshotID` value, you can create a post request to fetch forecast data from the snapshot. 

## Retrieve forecast data from a snapshot

>[!NOTE]
>This API should be used only by administrators. If you're not an administrator, contact your administrator to get the relevant data. 

Using the `ForecastConfigurationId`, `Id`, and `SnapshotID` that you have fetched from metadata and snapshot list, create a post request to retrieve forecast data from a snapshot. 

**Request**

```http
POST [Organization URI]/api/data/v9.0/msdyn_ForecastInstanceActions 
Accept: application/json; 
Content-Type: application/json; 
OData-MaxVersion: 4.0; 
OData-Version: 4.0 
{ 
"RequestJson": "{\"ForecastRecurrenceId\":\"a13ae9c8-9586-4c5f-ace2-f13faba56c44\",\"ForecastConfigurationId\":\"5e732d3e-ac11-ea11-a811-000d3a382afe\",\"ParentIds\":[\"00000000-0000-0000-0000-000000000000\"],\"PageInfoByParent\":{\"00000000-0000-0000-0000-000000000000\":{\"SortingAttribute\":\"HierarchyEntityRecord.RecordName\",\"SortingOrder\":\"ASC\",\"Count\":50,\"Skip\":0}},\"SnapshotId\":\"c61b0a19-6829-45eb-a368-9c6c14aa19fc\"}", 
"ServiceName": "mf-services", 
"WebApiName": "fetch-forecast" 
} 
```
**Response**

The response contains a JSON object with a `Response` property containing the list of data stored in Azure service that is used to compute and store data.

```http
HTTP/1.1 200 OK  
Content-Type: application/json; odata.metadata=minimal  
OData-Version: 4.0

{
    "@odata.context": "[Organization URI]/api/data/v9.0/$metadata#Microsoft.Dynamics.CRM.msdyn_ForecastInstanceActionsResponse",
    "response": {
        "Body": {
            "ForecastConfiguration": {
                ...
            },
            "ForecastRecurrence": {
                ...
            },
            "ForecastInstances": [
                {
                    ...
                },
                "AggregatedColumns": [
                    {
                        "ForecastConfigurationColumnId": "971841a0-5d42-4d9e-998d-a7b985148e9f",
                        "RecordId": "00000000-0000-0000-0000-000000000000",
                        "Value": 1500.0,
                        "DisplayValue": "1500",
                        "SystemValue": 1500.0,
                        "SystemDisplayValue": "1500",
                        "IsManualAdjusted": false,
                        "ParticipatingRecordsCount": 1,
                        "ManualAdjustment": null,
                        "AdjustmentHistory": [],
                        "UpdatedAttributeList": null
                    }
                ],
                "RolledUpColumns": [
                    {
                        "ForecastConfigurationColumnId": "971841a0-5d42-4d9e-998d-a7b985148e9f",
                        "RecordId": "00000000-0000-0000-0000-000000000000",
                        "Value": 2500.0,
                        "DisplayValue": "2500",
                        "SystemValue": 2500.0,
                        "SystemDisplayValue": "2500",
                        "IsManualAdjusted": false,
                        "ParticipatingRecordsCount": 0,
                        "ManualAdjustment": null,
                        "AdjustmentHistory": [],
                        "UpdatedAttributeList": null
                    }
                ],
                ...
            ]
        },
       ...
    }
}

```

In the response, you got  `ForecastConfiguration`, `ForecastRecurrence`, and `ForecastInstances` objects. In each of the `ForecastInstance` object we have two arrays: 

- `AggregatedColumns`: This parameter contains only your aggregated data.

- `RolledupColumns`: This parameter value displays *null* if you don't have a reporting hierarchy. If you have a reporting hierarchy, this parameter displays the merged data of yours and users who report to you.
 
Match `ForecastConfigurationColumnId` in the response and in the metadata response to identify the name of the column. In this example, the ID value is **971841a0-5d42-4d9e-998d-a7b985148e9f** for the response column **Best Case**. To view the values, see the `SystemValue` attribute of each column which is also shown on the forecast grid.


### See also

[View forecasts](../../../view-forecasts.md)

[Configure a forecast](../../../configure-forecast.md)
