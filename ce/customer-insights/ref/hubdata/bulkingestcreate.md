---
title: Create Blob Bulk Ingestion Job (Hub Data)
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

Create Blob Bulk Ingestion Job (Hub Data)
===================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Create a processing job to ingest a blob file into a Customer Insights custom type.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|POST|`<hub-endpoint>/data/BlobIngestionJobs?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|


### Request Body  
 A JSON object describing the blob source of the form:

```{json}  
{
    'Uri': '<SasUri>',
    'Type': '<customType> of the form Interaction.<InteractionName>, Profile.<ProfileName>, Relationship.<RelationshipName>',
    'DataFormat': <DataFormat-Definition>
}
```    
Where [DataFormat](../types/dataformat.md) describes the blob structure, which is typically uploaded from a CSV file.


For example:
1. For bulk ingestion into a profile 'Contact'
```{json}  
{
     'Uri':'https://dcisdktest.blob.core.windows.net/ingestionfiles/1g.txt?sv=2015-04-05&sr=b&sig=CCZ6Tl8...',
     'Type':'Profile.Contact',
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
      }
}
```    

2. For bulk ingestion into a relationship 'OwnedBy' between Device and User with a relationship property 'DevicePrice'
```{json}  
{
     'Uri':'https://dcisdktest.blob.core.windows.net/ingestionfiles/ownedby.txt?sv=2015-04-05&sr=b&sig=CCZ6Tl8...',
     'Type':'Relationship.OwnedBy',
     'DataFormat': 
      {
          'HasHeader':true,
          'ColumnSeparator':',',
          'PropertyMappings':
          [
              {
                  'ColumnName':'deviceid',
                  'PropertyName':'DeviceId',
                  'IsEncrypted':false,
                  'MappingPropertyKind': 'ProfileKeyPropertyInRelationship'   
              },
              {
                  'ColumnName':'ownerid',
                  'PropertyName':'UserId',
                  'IsEncrypted':false,
                  'MappingPropertyKind': 'RelatedProfileKeyPropertyInRelationship'         
              }
              {
                  'ColumnName':'Price',
                  'PropertyName':'DevicePrice',
                  'IsEncrypted':false       
              }
          ]
      }
}
``` 

<br/>


## Response  
 The response includes an HTTP status code, a response body and a set of response headers.  

### Response Body  
The body contains details about the newly created ingestion job, for example:

```{json}  
{
 "@odata.context":"https://dcisdktest.api.azurecustomerinsights.com/data/$metadata#BlobIngestionJobs/$entity",
 "JobId":"c8141c9846dd41c580c05ed096e9103b",
 "HubId":"blihub",
 "SubmitTime":"2016-02-01T21:53:50.8377143Z",
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
 "Type":"Profile.Contact",
 "Uri":"https://uicbulkingestion.blob.core.windows.net/ingestionfiles/1g.txt?sv=2015-04-05&sr=b&sig=Ca..."
 }

```    


### Status Code  
  
-   201 (Created) - the request succeeded.  
-   400 (Bad request) - required attributes in the request are missing or invalid.   


