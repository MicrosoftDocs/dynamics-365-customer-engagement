---
title: msdyn_WKWDeleteGDPRData custom action
description: Understand the parameters, and web API calls for deleting a user's Microsoft 365 data stored in Dynamics 365.
ms.date: 08/19/2022
ms.topic: reference
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---
# WKWDeleteGDPRData custom action 

To comply with the privacy law requirements, you may need to delete a user's data after they leave the organization or for other reasons. This includes data that Dynamics 365 collects from Microsoft 365 to provide business insights.  

As a developer, use WKWDeleteGDPRData API to delete a user's Microsoft 365 data that's stored in Dynamics 365.

## Parameters

|Name|Type|Required|Description|
|----|----|----|----|
|UserIds|list|Yes|Comma-separated list of system user IDs of users whose data you want to delete. |

## Request

**Request type**: POST  
**Request URL**: {orgUrl}/api/data/v9.1/msdyn_WKWDeleteGDPRData  
**Body**: {"UserIds": List of system userid’s}  

### Sample Request

The following snippet includes a sample request to delete users.

```html
POST {orgUrl}/api/data/v9.1/msdyn_WKWDeleteGDPRData
    {
        "UserIds": ["3671fb10-d6d0-ec11-a7b6-000d3a5bc91c", "5571fb10-d6d0-ec11-a7b6-000d3a5bc91c"]}
    }
```

## Response

If the request is submitted successfully, the following response is returned:  

HTTP 204 

## Related information

[msdyn_WKWGDPRDeleteStatus custom action](msdyn_WKWPrivacyDeleteStatus.md)
