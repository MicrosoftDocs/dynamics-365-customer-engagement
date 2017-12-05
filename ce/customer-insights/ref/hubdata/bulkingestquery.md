---
title: Query Blob Bulk Ingestion Jobs (Hub Data)
description: Create a job to ingest a blob file into a custom type.
keywords: Customer Insights; Hub Data API; Bulk Ingestion; create
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 11/03/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 6ccb25f4-1078-4980-96d6-7b8aec0f0207
---

Query Blob Bulk Ingestion Jobs (Hub Data)
========================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets all the current bulk ingestion jobs for the specified hub.  Results can be further refined by specifying a Job ID or a filter expression.

## Request 
The default request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`hub-endpoint>/data/BlobIngestionJobs?api-version=2017-04-26`|

Whereas the following requests limit the results to a specific Job ID or filtering expression, respectively:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/data/BlobIngestionJobs(<jobID>)?api-version=2017-04-26`|
|GET|`<hub-endpoint>/data/BlobIngestionJobs?api-version=2017-04-26&$filter=<filter-exp>`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub.|
|jobID|No|ID of the bulk ingestion job to retrieve| 
|filter-exp|No|The filtering expression to limit the result set|

The following are examples of this operation:

```{http}  
GET <hub-endpoint>/data/BlobIngestionJobs?api-version=2017-04-26
GET <hub-endpoint>/data/BlobIngestionJobs('85b2d30913de448290763a43e76295dc')?api-version=2017-04-26
GET <hub-endpoint>/data/BlobIngestionJobs?api-version=2017-04-26&$filter=Type eq 'Profile:Contact'
GET <hub-endpoint>/data/BlobIngestionJobs?api-version=2017-04-26&$filter=State eq 'Finished'
```    

<br/>

## Response  
 The response includes an HTTP status code, a response body and a set of response headers.  

Mulitple results may be returned as a set of pages. The existance of the server-side paging token ([OData $skiptoken](https://msdn.microsoft.com/en-us/library/dd942121.aspx)) enables the 
retrieval of the next page of results. The results are ordered by modification timestamp, with the most recently changed entities appearing first.  


### Response Body  

Zero or more job information JSON structures of the following form. 

```{json}  
{
    "@odata.context":"<hub-endpoint>/data/$metadata#BlobIngestionJobs/$entity",
    "JobId":"c8141c9846dd41c580c05ed096e9103b",
    "HubId":"<hubID>b",
    "SubmitTime":"2016-01-31T21:53:50.8377143Z",
    'DataFormat': 
    {
        'HasHeader':true,
        'ColumnSeparator':',',
        'PropertyMappings':
        [
            {
                 'ColumnName':'f_name',
                 'PropertyName':'FirstName',
                 'IsEncrypted':false     
            },
            {
                 'ColumnName':'l_name',
                 'PropertyName':'LastName',
                 'IsEncrypted':false       
            }
       ]
   },
   "FinishedTimeUtc":"2016-02-01T18:59:58.6Z",
   "TotalBytes":1074201999,
   "TotalBytesProcessed":1074201999,
   "TotalLinesProcessed":9143780,
   "TotalLinesFailedProcessing":0,
   "Result":200,
   "Response":null,
   "State":"Finished",
   "Type":"Profile.Contact",
   "Uri":"https://uicbulkingestion.blob.core.windows.net/ingestionfiles/1g.txt?sv=2015-04-05&sr=b&sig=CaFQVlY..."
 }

```    

### Status Code  
  
-   200 (OK) - the request succeeded.  
-   400 (Bad request) - required attributes in the request are missing or invalid.   
  
