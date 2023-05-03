---
title: "msdyn_WKWGDPRDeleteStatus custom action"
description: "Understand the parameters, and web API calls for checking the status of msdyn_WKWDeleteGDPRData request."
ms.date: 08/19/2022
ms.topic: reference
author: lavanyakr01
ms.author: lavanyakr
---
# msdyn_WKWGDPRDeleteStatus custom action 

To comply with the GDPR requirements, you may need to delete a user's data after they leave the organization or for other reasons. This includes data that Dynamics 365 collects from Microsoft 365 to provide business insights. 

After you request the deletion of user data using the msdyn_WKWDeleteGDPRData API, use the msdyn_WKWGDPRDeleteStatus API to get the status of the request.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System customizer <br>  More information: [Predefined security roles for Sales](../../../security-roles-for-sales.md)|


## Parameters

|Name|Type|Required|Description|
|----|----|----|----|
|UserIds|list|Yes|Comma-separated list of system user IDs of users whose data deletion status you want to check. |

## Request

**Request type**: POST  
**Request URL**: {orgUrl}/api/data/v9.1/msdyn_WKWGDPRDeleteStatus  
**Body**: {"UserIds": List of system userid’s}  

### Sample request: Check deletion status

The following snippet includes a sample request to check the deletion status.

```html
POST {orgUrl}/api/data/v9.1/msdyn_WKWGDPRDeleteStatus
    {
        UsersWithRequest:[{"SystemUserId" : Systemuser id, "Status": can be PROCESSING, COMPLETED or FAILED}],
    }
```

### Response

The API returns the following response:

```html
{
    UsersWithRequest:[{“SystemUserId” : Systemuser id, “Status”: can be PROCESSING, COMPLETED or FAILED}],
    UsersWithNoRequest: List of Systemuser ids provided for status check, but have no GDPR delete request for them
}

```

### Sample response

```html
{
    "@odata.context": {orgUrl}/api/data/v9.1/$metadata#Microsoft.Dynamics.CRM.msdyn_WKWGDPRDeleteStatusResponse,
    "Response": "{\"UsersWithRequest\":[{\"SystemUserId\":\"3671fb10-d6d0-ec11-a7b6-000d3a5bc91c\",\"Status\":\"PROCESSING\"},{\"SystemUserId\":\"5571fb10-d6d0-ec11-a7b6-000d3a5bc91c\",\"Status\":\"PROCESSING\"}],\"UsersWithNoRequest\":[\"7771fb10-d6d0-ec11-a7b6-000d3a5bc91c\"]}"
}
```
