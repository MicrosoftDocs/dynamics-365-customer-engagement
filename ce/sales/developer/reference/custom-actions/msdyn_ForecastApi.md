---
title: msdyn_ForecastApi custom action
description: Read how you can use msdyn_ForecastApi custom action to retrieve and update forecasting data.
ms.date: 12/18/2024
ms.topic: reference
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.audienceType: 
  - developer
ms.custom: 
  - dyn365-sales
---
# msdyn_ForecastApi action 

As a developer, read this reference documentation to use the `msdyn_ForecastApi` custom action to retrieve and update forecasting data. You can also use this action to store forecast data from time to time, as a snapshot. You can then use the snapshot to compare the forecast data over time. Use the [forecasting API sample code](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/sales/ForecastingAPI) to get started with the `msdyn_ForecastApi` custom action.

## Parameters

|Parameter name| Required| Description|
|----|----|----|
|`WebApiName`|Yes|Contains the name of the API to be executed.|
|`RequestJson`|Yes|Contains the parameters and the arguments for the API call.|

## List of APIs

Given below are the set of APIs you can invoke using the `msdyn_ForecastApi` custom action.

### GET_ForecastConfigurations

Returns the list of all forecast configurations configured. 

#### Example

```http
POST [Organization URI]/api/data/v9.1/msdyn_ForecastApi/ HTTP/1.1
Content-Type: application/json

{
    "WebApiName": "GET_ForecastConfigurations",
    "RequestJson": "{}"
}
```
|Parameter|Type|Description|
|----|----|----|
|`WebApiName`|String|Name of the API|
|`RequestJson`|String|Serialized JSON object|

#### Response

```json
{
   "@odata.context": "[Organization URI]/api/data/v9.1/$metadata#Microsoft.Dynamics.CRM.msdyn_ForecastApiResponse",
   "response": [
      {
         "Columns": [
             {
                        "ForecastConfigurationColumnId": "0ad51075-912b-4e00-a7a1-91170e437d27",
                        ...
                        "ForecastConfigurationId": "27bd2c40-f868-ea11-a811-000d3a37bb2c",
                        ...
             },
             {
                        "ForecastConfigurationColumnId": "c3ef8024-6517-4168-adc7-bb5b520554a0",
                        ...
                        "ForecastConfigurationId": "27bd2c40-f868-ea11-a812-125d3a37bb2d",
                        ...
               
             }],
         "PermissionRoles": null,
         "AdditionalFilters": "<fetch version=\"1.0\" mapping=\"logical\"><entity name=\"opportunity\"><\/entity><\/fetch>",
         "IsSnapshotScheduled": false,
         "SnapshotSchedule": null,
         "SnapshotTimeZone": null,
         "PublishedDateTime": "0001-01-01T00:00:00",
         "DefaultViewIdForUnderlyingRecords": "bf649add-6c30-ea11-a813-000d3a5475f7"
      }
   ]
}
```

#### Return value

List of Forecast Configurations.

### GET_ForecastConfigurationsByName 

Returns all forecast configurations having the name provided as part of request payload.

#### Example

```http
POST [Organization URI]/api/data/v9.1/msdyn_ForecastApi HTTP/1.1
Content-Type: application/json

{
    "WebApiName": "GET_ForecastConfigurationsByName",
    "RequestJson": "{\"Name\":\"api_test1\"}"
}
```
|Parameter|Type|Description|
|-----|-----|-----|
|`WebApiName`|String|Name of the API|
|`RequestJson`|JSON object|Consists of `Name`: name of the forecast configuration|

#### Response

```json
{
   "@odata.context": "[Organization URI]/api/data/v9.1/$metadata#Microsoft.Dynamics.CRM.msdyn_ForecastApiResponse",
   "response": [
      {
         "Columns": [
             {
                 "Name": "api_test1",
                 ...
                 "ForecastConfigurationId": "bcf37937-487e-ea11-a811-000d3a37bb2c",
                 ...
             }
         ],
         "PermissionRoles": null,
         "AdditionalFilters": "<fetch version=\"1.0\" mapping=\"logical\"><entity name=\"opportunity\"><\/entity><\/fetch>",
         "IsSnapshotScheduled": false,
         "SnapshotSchedule": null,
         "SnapshotTimeZone": null,
         "PublishedDateTime": "0001-01-01T00:00:00",
         "DefaultViewIdForUnderlyingRecords": "bf649add-6c30-ea11-a813-000d3a5475f7"
      }
   ]
}
```

#### Return value

List of Forecast Configurations.

### GET_ForecastPeriodsByForecastConfigurationId

Returns all the forecast periods for the active forecast configuration Id, that is provided as part of the request payload.

#### Example

```http
POST [Organization URI]/api/data/v9.1/msdyn_ForecastApi HTTP/1.1
Content-Type: application/json

{
  "WebApiName": "GET_ForecastPeriodsByForecastConfigurationId",
  "RequestJson": "{
      \"ForecastConfigurationId\":\"04323a04-da7f-ea11-a811-000d3a37bb2c\"
      }"
}
```

|Parameter|Type|Description|
|------|------|------|
|`WebApiName`|String|Name of the API|
|`RequestJson`|JSON Object|Contains `ForecastConfigurationId`: Forecast Configuration Id|

#### Response

```json
{
   "@odata.context": "[Organization URI]/api/data/v9.1/$metadata#Microsoft.Dynamics.CRM.msdyn_ForecastApiResponse",
   "response": [
      {
         "Id": "8b8cadd8-ede3-4b21-97cf-93efc0337089",
         "ForecastConfigurationId": "04323a04-da7f-ea11-a811-000d3a37bb2c",
         "RecurrenceIndex": 0,
         "ValidFrom": "2020-04-01T00:00:00Z",
         "ValidTo": "2020-06-30T23:59:59Z",
         "Name": "FY2020 Q2",
         "RecomputeStatus": 10,
         "LastRecomputedOn": "2020-05-25T08:04:24.817Z",
         "RecomputationStartTime": "2020-06-05T05:04:30.904Z",
         "RecomputeStatusChangedOn": "2020-06-05T06:04:00.363Z",
         "FailureInfo": "Microsoft.Azure.WebJobs.FunctionFailedException: The activity function 'CreateUpdateForecastHierarchy' failed: \"An item with the same key has already been added. Key: aaaaaaaa-0b0b-1c1c-2d2d-333333333333\". See the function execution logs for additional details. ---> System.ArgumentException: An item with the same key has already been added. Key: aaaaaaaa-0b0b-1c1c-2d2d-333333333333\r\n   at System.Collections.Generic.Dictionary`2.TryInsert(TKey key, TValue value, InsertionBehavior behavior)\r\n   at Microsoft.Dynamics.Forecasting.RecomputeEngine.HierarchyManager.<>c__DisplayClass23_0.<GetForecastInstancesByHierarchyEntityId>b__0(ForecastInstance forecastInstance) in C:\\src\\cloud_IDEs\\ide5\\Azure\\RecomputeEngine\\HierarchyManager\\HierarchyManager.cs:line 727\r\n   at System.Collections.Generic.List`1.ForEach(Action`1 action)\r\n   at Microsoft.Dynamics.Forecasting.RecomputeEngine.HierarchyManager.GetForecastInstancesByHierarchyEntityId(ForecastConfiguration forecastConfiguration, Guid forecastRecurrenceId) in C:\\src\\cloud_IDEs\\ide5\\Azure\\RecomputeEngine\\HierarchyManager\\HierarchyManager.cs:line 727\r\n   at Microsoft.Dynamics.Forecasting.RecomputeEngine.HierarchyManager.CreateOrUpdateForecastDataWithLatestHierarchy(ForecastConfiguration forecastConfiguration, Guid forecastRecurrenceId, Dictionary`2 latestHierarchyEntityList) in C:\\src\\cloud_IDEs\\ide5\\Azure\\RecomputeEngine\\HierarchyManager\\HierarchyManager.cs:line 602\r\n   at Microsoft.Dynamics.Forecasting.RecomputeEngine.HierarchyManager.<>c__DisplayClass16_0.<CreateOrUpdateForecastHierarchy>b__0() in C:\\src\\cloud_IDEs\\ide5\\Azure\\RecomputeEngine\\HierarchyManager\\HierarchyManager.cs:line 283\r\n   at System.Threading.Tasks.Task.InnerInvoke()\r\n   at System.Threading.Tasks.Task.<>c.<.cctor>b__275_1(Object obj)\r\n   at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state)\r\n--- End of stack trace from previous location where exception was thrown ---\r\n   at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state)\r\n   at System.Threading.Tasks.Task.ExecuteWithThreadLocal(Task& currentTaskSlot)\r\n--- End of stack trace from previous location where exception was thrown ---\r\n   at Microsoft.Dynamics.Forecasting.RecomputeEngine.HierarchyManager.CreateOrUpdateForecastHierarchy(ForecastConfiguration forecastConfiguration, Guid forecastRecurrenceId, Dictionary`2 latestHierarchyEntityList) in C:\\src\\cloud_IDEs\\ide5\\Azure\\RecomputeEngine\\HierarchyManager\\HierarchyManager.cs:line 255\r\n   at Microsoft.Dynamics.Forecasting.RecomputeEngine.HierarchyManager.CreateOrUpdateForecastHierarchy(Guid orgId, Guid forecastConfigurationId, Guid forecastRecurrenceId, Dictionary`2 latestHierarchyEntityList) in C:\\src\\cloud_IDEs\\ide5\\Azure\\RecomputeEngine\\HierarchyManager\\HierarchyManager.cs:line 167\r\n   at Microsoft.Dynamics.Forecasting.AzureFunctions.CreateUpdateForecastHierarchy.Run(CreateUpdateForecastHierarchyInput input) in C:\\src\\cloud_IDEs\\ide5\\Azure\\AzureFunctions\\Recompute\\ActivityFunctions\\CreateUpdateForecastHierarchy.cs:line 43\r\n   at Microsoft.Azure.WebJobs.Host.Executors.VoidTaskMethodInvoker`2.InvokeAsync(TReflected instance, Object[] arguments) in C:\\projects\\azure-webjobs-sdk-rqm4t\\src\\Microsoft.Azure.WebJobs.Host\\Executors\\VoidTaskMethodInvoker.cs:line 20\r\n   at Microsoft.Azure.WebJobs.Host.Executors.FunctionInvoker`2.InvokeAsync(Object instance, Object[] arguments) in C:\\projects\\azure-webjobs-sdk-rqm4t\\src\\Microsoft.Azure.WebJobs.Host\\Executors\\FunctionInvoker.cs:line 52\r\n   at Microsoft.Azure.WebJobs.Host.Executors.FunctionExecutor.InvokeAsync(IFunctionInvoker invoker, ParameterHelper parameterHelper, CancellationTokenSource timeoutTokenSource, CancellationTokenSource functionCancellationTokenSource, Boolean throwOnTimeout, TimeSpan timerInterval, IFunctionInstance instance) in C:\\projects\\azure-webjobs-sdk-rqm4t\\src\\Microsoft.Azure.WebJobs.Host\\Executors\\FunctionExecutor.cs:line 585\r\n   at Microsoft.Azure.WebJobs.Host.Executors.FunctionExecutor.ExecuteWithWatchersAsync(IFunctionInstanceEx instance, ParameterHelper parameterHelper, ILogger logger, CancellationTokenSource functionCancellationTokenSource) in C:\\projects\\azure-webjobs-sdk-rqm4t\\src\\Microsoft.Azure.WebJobs.Host\\Executors\\FunctionExecutor.cs:line 532\r\n   at Microsoft.Azure.WebJobs.Host.Executors.FunctionExecutor.ExecuteWithLoggingAsync(IFunctionInstanceEx instance, ParameterHelper parameterHelper, IFunctionOutputDefinition outputDefinition, ILogger logger, CancellationTokenSource functionCancellationTokenSource) in C:\\projects\\azure-webjobs-sdk-rqm4t\\src\\Microsoft.Azure.WebJobs.Host\\Executors\\FunctionExecutor.cs:line 468\r\n   at Microsoft.Azure.WebJobs.Host.Executors.FunctionExecutor.ExecuteWithLoggingAsync(IFunctionInstanceEx instance, FunctionStartedMessage message, FunctionInstanceLogEntry instanceLogEntry, ParameterHelper parameterHelper, ILogger logger, CancellationToken cancellationToken) in C:\\projects\\azure-webjobs-sdk-rqm4t\\src\\Microsoft.Azure.WebJobs.Host\\Executors\\FunctionExecutor.cs:line 278\r\n   --- End of inner exception stack trace ---\r\n   at Microsoft.Azure.WebJobs.DurableOrchestrationContext.CallDurableTaskFunctionAsync[TResult](String functionName, FunctionType functionType, String instanceId, RetryOptions retryOptions, Object input) in E:\\functions\\azure-functions-durable-extension\\src\\WebJobs.Extensions.DurableTask\\DurableOrchestrationContext.cs:line 498\r\n   at Microsoft.Dynamics.Forecasting.AzureFunctions.OrchestratorFunctionBase.ExecuteActivityAsync(DurableOrchestrationContext context, String functionName, Object input, Dictionary`2 telemetryProps) in C:\\src\\cloud_IDEs\\ide5\\Azure\\AzureFunctions\\OrchestratorFunctionBase.cs:line 252\r\n   at Microsoft.Dynamics.Forecasting.AzureFunctions.RecomputeOrchestrator.ExecuteRecomputeOrchestration(DurableOrchestrationContext context, RecomputeOrchestratorInput recomputeInput, String correlationId, Dictionary`2 telemetryProps) in C:\\src\\cloud_IDEs\\ide5\\Azure\\AzureFunctions\\Recompute\\RecomputeOrchestrator.cs:line 169",
         "RecurrenceState": 0,
         "UpdatedAttribteList": null
      }
    ]
}
```

#### Return value

List of Forecast Periods.

### GET_ForecastInstances

Returns the list of forecast instances that are a single row entity record.

> [!NOTE]
> Forecast periods can have many forecast instances. Far more than you would want to pull down in a single request. The API endpoints default to providing a limited number of items per request.<br />Note: Large queries can hurt performance, so the number of results per page is capped at 4000 records. If you wish to retrieve more than 4000 records, for example to build a client-side list of all available forecast instances, you can make multiple API requests and combine the results within your application.

#### Example

```http
POST [Organization URI]/api/data/v9.1/msdyn_ForecastApi HTTP/1.1
Content-Type: application/json

{
    "WebApiName": "GET_ForecastInstances",
    "RequestJson": "{\"ForecastPeriodId\":\"a0a0a0a0-bbbb-cccc-dddd-e1e1e1e1e1e1\",\"ForecastConfigurationId\":\"b1b1b1b1-cccc-dddd-eeee-f2f2f2f2f2f2\",\"PageInfo\":{\"SortingAttribute\":\"HierarchyEntityRecord.RecordId\",\"SortingOrder\":\"DESC\",\"PageSize\":1,\"PageNo\":5},\"GetParticipatingRecordsFetchXml\":false,\"ParticipatingRecordsViewId\":\"c2c2c2c2-dddd-eeee-ffff-a3a3a3a3a3a3"}"
}
```
|Parameter|Type|Description|
|------|------|------|
|`WebApiName`|String|Name of the API|
|`RequestJson`|JSON object|Consists of<br />`ForecastPeriodId`: Unique identifier of the forecast period<br />`ForecastConfigurationId`: Unique identifier of the forecast configuration<br />`SortingAttribute`: The attribute based on which you want to do Sorting in the paging<br />`SortingOrder`: ASC for ascending order DSC for descending order<br />`PageSize`: Number of records you want to retrieve in a single page<br />`PageNo`: Which page records you want to fetch for.<br />`GetParticipatingRecordsFetchXml`: Flag indicating whether participating records fetch XML is needed in the response.<br />`ParticipatingRecordsViewId`: This is needed when `GetParticipatingRecordsFetchXml` is true. This is a saved query (view) ID using which the participating records fetch XML is generated. |

Given below is the sample JSON for `RequestJson` object.

```json
{
    "WebApiName": "GET_ForecastInstances",
    "RequestJson": "{\"ForecastPeriodId\":\"{{frid}}\",\"ForecastConfigurationId\":\"{{fcid}}\",\"PageInfo\":{\"SortingAttribute\":\"HierarchyEntityRecord.RecordId\",\"SortingOrder\":\"ASC\",\"PageSize\":1,\"PageNo\":5},\"GetParticipatingRecordsFetchXml\":false,\"ParticipatingRecordsViewId\":\"bf649add-6c30-ea11-a813-000d3a5475f7\"}"
}
```

#### Response

```json
{
   "@odata.context": "[Organization URI]/api/data/v9.1/$metadata#Microsoft.Dynamics.CRM.msdyn_ForecastApiResponse",
   "response": {
      "ForecastInstances": [
          "ForecastInstanceId": "95d2305a-a0be-4b34-84ac-b10e67b0771a",
          "ForecastConfigurationId": "04323a04-da7f-ea11-a811-000d3a37bb2c",
            ...],
      "HasMorePages": false,
      "ParticipatingRecordsFetchXml": "",
      "Code": 200,
      "Message": "OK"
   }
}
```

#### Return value

List of Forecast Instances.

### Update_SimpleColumnByEntityId

Updates the specific column values using the values of the passed parameters.

> [!NOTE]
> Large number of update requests in a single API call can hurt performance, so the updates per request are capped at 50.  

#### Example

```http
POST [Organization URI]/api/data/v9.1/msdyn_ForecastApi HTTP/1.1
content-type: application/json

{
    "WebApiName": "Update_ SimpleColumnByEntityId",
    "RequestJson": "
    {
      \"ForecastConfigurationId\":\"0461fb6b-8d85-ea11-a811-000d3a37bb2c\",
      \"ForecastRecurranceId\":\"f8b1122c-b913-4e88-9727-368b6134be3e\",
      \"SimpleColumnUpdateRequests\":[{
        \" HierarchyEntityRecordId\":\"d8680b00-fd31-46c2-8136-7c4df19cf2a8\",
        \"ForecastConfigurationColumnId\":\"65ec7bd1-2de6-49fa-b259-ba74bc721c78\",
        \"ForecastConfigurationColumnValue\":0.0,
        \"IsRolledUpColumnUpdate\":false},{
        \" HierarchyEntityRecordId\":\"11141300-131b-493a-9857-22bd8689b775\",
        \"ForecastConfigurationColumnId\":\"65ec7bd1-2de6-49fa-b259-ba74bc721c78\",
        \"ForecastConfigurationColumnValue\":0.0,
        \"IsRolledUpColumnUpdate\":false}]}"
}
```
|Parameter|Name|Description|
|----|----|----|
|WebApiName|String|Name of the API|
|ForecastConfigurationId|GUID|Forecast Configuration Id|
|ForecastRecurranceId|GUID|Forecast Recurrance Id or Forecast Period Id A list of `SimpleColumnUpdateRequests` is an array|
|HierarchyEntityRecordId|GUID|EntityRecordId|
|ForecastConfigurationColumnId|GUID|Forecast Configuration Column Id|
|ForecastConfigurationColumnValue|Datatype of ForecastConfigurationColumn|Value which needs to be updated to|
|IsRolledUpColumnUpdate(optional)|Boolean|`True` if the value is updated for the rolled up column, `False` if the value is update for aggregate column|

#### Response

```json
{
   "@odata.context": "[Organization URI]/api/data/v9.1/$metadata#Microsoft.Dynamics.CRM.msdyn_ForecastApiResponse",
   "response": [
      {
         "Message": "Update Successful",
         "StatusCode": 0,
         "HierarchyEntityRecordId": "d8680b00-fd31-46c2-8136-7c4df19cf2a8",
         "ForecastConfigurationColumnId": "65ec7bd1-2de6-49fa-b259-ba74bc721c78"
      },
      {
         "Message": "Update Successful",
         "StatusCode": 0,
         "HierarchyEntityRecordId": "11141300-131b-493a-9857-22bd8689b775",
         "ForecastConfigurationColumnId": "65ec7bd1-2de6-49fa-b259-ba74bc721c78"
      }
   ]
}
```

#### Return value

A list of `UpdateSimpleColumnByEntityResponse` records consisting of `HierarchyEntityRecordId`, `ForecastConfigurationColumnId`, `Message`, `StatusCode`.

### Update_SimpleColumnByFIId

Updates the specific column value by setting the values of the parameters passed.

> [!NOTE]
> Large number of update requests in a single API call can hurt performance, so the updates per request are capped at 50.  

#### Example

```http
POST [Organization URI]/api/data/v9.1/msdyn_ForecastApi HTTP/1.1
content-type: application/json

{
    "WebApiName": "Update_SimpleColumnByFIId",
    "RequestJson": "
    {
      \"ForecastConfigurationId\":\"0461fb6b-8d85-ea11-a811-000d3a37bb2c\",
      \"ForecastRecurranceId\":\"f8b1122c-b913-4e88-9727-368b6134be3e\",
      \"SimpleColumnUpdateRequests\":[
      {
        \"ForecastInstanceId\":\"d8680b00-fd31-46c2-8136-7c4df19cf2a8\",
        \"ForecastConfigurationColumnId\":\"65ec7bd1-2de6-49fa-b259-ba74bc721c78\",
        \"ForecastConfigurationColumnValue\":0.0,
        \"IsRolledUpColumnUpdate\":false},
        {
          \"ForecastInstanceId\":\"11141300-131b-493a-9857-22bd8689b775\",
          \"ForecastConfigurationColumnId\":\"65ec7bd1-2de6-49fa-b259-ba74bc721c78\",
          \"ForecastConfigurationColumnValue\":0.0,
          \"IsRolledUpColumnUpdate\":false}]}"
}
```
|Parameter|Type|Description|
|-----|-----|-----|
|WebApiName|String|Name of the API|
|ForecastConfigurationId|GUID|Forecast Configuration Id|
|ForecastRecurranceId|Guid|Forecast Recurrance Id or Forecast Period Id|
|SimpleColumnUpdateRequests|Array|Includes the following|
|ForecastInstanceId|GUID|Forecast Instance Id|
|ForecastConfigurationColumnId|GUID|Forecast Configuration Column Id|
|ForecastConfigurationColumnValue|Datatype of ForecastConfigurationColumn|Value which needs to be updated to|
|IsRolledUpColumnUpdate(optional)|Boolean|`True` if the value is updated for the rolled up column, `false` if the value is update for aggregate column|

#### Response

```json
{
   "@odata.context": "[Organization URI]/api/data/v9.1/$metadata#Microsoft.Dynamics.CRM.msdyn_ForecastApiResponse",
   "response": [
      {
         "Message": "Update Successful",
         "StatusCode": 0,
         "ForecastInstanceId": "d8680b00-fd31-46c2-8136-7c4df19cf2a8",
         "ForecastConfigurationColumnId": "65ec7bd1-2de6-49fa-b259-ba74bc721c78"
      },
      {
         "Message": "Update Successful",
         "StatusCode": 0,
         "ForecastInstanceId": "11141300-131b-493a-9857-22bd8689b775",
         "ForecastConfigurationColumnId": "65ec7bd1-2de6-49fa-b259-ba74bc721c78"
      }
   ]
}
```

#### Return value

A list of `UpdateSimpleColumnByEntityResponse` records consisting of `ForecastInstanceId`, `ForecastConfigurationColumnId`, `Message`, `StatusCode`.

### GET_ParticipatingRecordsFetchxml

Returns the fetch XML to retrieve the underlying records in a forecast.

#### Example

```http

POST /api/GET_ParticipatingRecordsFetchxml HTTP/1.1
Host: your-api-endpoint.com
Content-Type: application/json

{
    "ForecastConfigurationId": "a01f86da-1b45-ef11-bfe2-6045bd066f80",
    "ForecastPeriodId": "a51f86da-1b45-ef11-bfe2-6045bd066f80",
    "HierarchyRecordId": "697adf08-df43-ef11-bfe2-6045bd07ea28",
    "ForecastInstanceId": "69169046-520b-4040-abfa-2981a2f0aee3",
    "ForecastConfigurationColumnId": "f06490f5-6c27-453c-b06c-0194819202a4",
    "RecordViewId": "bf649add-6c30-ea11-a813-000d3a5475f7",
    "IsRolledUpNodeRequested": "true"
}

```

| Parameter | Type | Description |
|-----------|------|-------------|
| ForecastConfigurationId | GUID | Forecast configuration ID |
| ForecastPeriodId | GUID | Forecast Period ID |
| HierarchyRecordId | GUID | The record ID in Dataverse for which the underlying record should be retrieved. For example, the system user ID in the case of an Org Chart Forecast, or the territory ID in the case of a Territory Forecast. |
| ForecastInstanceId | GUID | Forecast instance ID |
| ForecastConfigurationColumnId | GUID | ID of the forecast column that needs to be retrieved. For example, when you want to fetch only the participating records for the **Best Case** column of your forecast, enter the column ID of the **Best Case** column. You can enter only one column ID for each request. To retrieve more columns, you should send a request for each column. Skip this parameter if you want to fetch XML for all columns of the forecast. You can get the column ID from the **Forecast Configuration** definition. |
| RecordViewId | GUID | Record view ID of the underlying records. Learn more about getting the view ID in [savedquery EntityType](/power-apps/developer/data-platform/webapi/reference/savedquery) |
| IsRolledUpNodeRequested | Boolean | Specifies whether to return the values for the rolled up node (group) or individual node. If set to true, all the records under the group node is returned. If set to false, just the individual's record is returned. |

#### Response

```json
{

    "@odata.context": "https://orgname.dynamics.com/api/data/v9.0/$metadata#Microsoft.Dynamics.CRM.msdyn_ForecastApiResponse",

    "response": "<fetch version=\"1.0\" mapping=\"logical\" distinct=\"true\"><entity name=\"opportunity\"><filter type=\"and\"><condition attribute=\"estimatedclosedate\" operator=\"between\"><value>2024-07-01T00:00:00.0000000Z</value><value>2024-09-30T23:59:59.0000000Z</value></condition><condition attribute=\"msdyn_forecastcategory\" operator=\"eq\" value=\"100000001\" /></filter><link-entity name=\"systemuser\" from=\"systemuserid\" to=\"ownerid\" link-type=\"inner\"><attribute name=\"systemuserid\" /><filter type=\"and\"><condition attribute=\"systemuserid\" operator=\"eq-or-under\" value=\"697adf08-df43-ef11-bfe2-6045bd07ea28\" /></filter></link-entity><attribute name=\"name\" /><attribute name=\"statuscode\" /><attribute name=\"statecode\" /><attribute name=\"customerid\" /><attribute name=\"ownerid\" /><attribute name=\"msdyn_forecastcategory\" /><attribute name=\"estimatedvalue\" /><attribute name=\"estimatedclosedate\" /><attribute name=\"actualvalue\" /><attribute name=\"actualclosedate\" /><attribute name=\"opportunityid\" /><order attribute=\"name\" descending=\"false\" /></entity></fetch>"

}
```

#### Return value

A fetch XML query that returns the underlying records in a forecast.

## Related information

[Custom actions for forecasting](../custom-actions-manual-forecasting.md)

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
