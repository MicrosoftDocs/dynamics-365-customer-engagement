---
title: Get Profile Instance by ID (Hub Data)
description: Gets a Profile instance matching the specified ID. 
keywords: Customer Insights; Hub Data API;  Profile instance; get; ID
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/20/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 6ccb25f4-1078-4980-96d6-7b8aec0f0203
---

Get Profile Instance by ID (Hub Data)
====================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets a [Profile](../types/profile.md) instance matching the specified ID.

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/data/<profileTypes>('<profileId>')?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|profileType|Yes|The custom Profile (entity set) type|
|spid|Yes|ID of the profile to retrieve|
| | | |

### Example
`GET myapp.api.azurecustomerinsights.com/data/Contacts('cust0035')?api-version=2017-04-26` 

<br/>

### Using Strong IDs

This request can also be formed using the _strong identifiers_ instead of the profile ID. If the strong ID is composed of multiple keys, then they are included as a comma separated list.

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/data/<profileTypes>(KeyProperty='<kpValue>')?api-version=2017-04-26`|
|GET|`<hub-endpoint>/data/<profileTypes>(KeyProperty1='<kp1Value>', KeyProperty2='<kp2Value>')?api-version=2017-04-26`|
| | |


## Response  
 The response includes an HTTP status code, a response body and a set of response headers.  

### Response Body  
The body contains the custom [Profile](../types/profile.md) instance along with the assigned Profile ID, for example:

```{json}  
{
     'ProfileId' : 'cust0035',
     'Id' : 'cust0035', 
     'FirstName': 'Sparta',
     'LastName' : 'Cus',
     'Phone': '454-456-3456'
  }
```    
Note that in this example, 'Id' is a modeled property and specified as *IdProperty* for the Profile Type Contact.

### Status Code  
  
-   200 (OK) - the request succeeded.  
-   404 (Not found) - an instance matching the specified ID could not be found.  

