---
title: "Get started with Online Management API for Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "Provides basic information to help you get started with the Online Admin API for Customer Engagement."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "conceptual"
applies_to: "Dynamics 365 (online)"
ms.assetid: c292c148-01f0-41f6-a2fe-7ed05a01a733
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Get started with Online Management API 

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This topic provides basic information to help you get started with the Online Admin API for Customer Engagement.

## Office 365 Admin roles

To use the Online Management API, you must have one of the following admin roles assigned to you in your Office 365 tenant:

- Global administrator
- Service administrator

For information about these roles, see [About Office 365 admin roles](https://support.office.com/en-us/article/About-Office-365-admin-roles-da585eea-f576-4f55-a1e0-87090b6aaa9d)

## Service URL

The service URL defines the endpoint address for accessing REST API. To perform any operation using the Online Management API, you need to specify the request URL in the following format:

`{ServiceUrl}/api/v1/{resource}`

For example, you can pass in the following URL with a **GET** request to retrieve the instances in your Office 365 tenant in North America:

`https://admin.services.crm.dynamics.com/api/v1/instances`


The following table lists the service URL of Online Management API for worldwide Office 365 data centers.

|Location | Service URL |
|---------|-------------|
|North America | https://admin.services.crm.dynamics.com |
|North America 2 | https://admin.services.crm9.dynamics.com |
|Europe, Middle East and Africa (EMEA) | https://admin.services.crm4.dynamics.com |
|Asia Pacific (APAC) | https://admin.services.crm5.dynamics.com |
|Oceania | https://admin.services.crm6.dynamics.com |
|Japan (JPN) | https://admin.services.crm7.dynamics.com |
|South America | https://admin.services.crm2.dynamics.com |
|India (IND) | https://admin.services.crm8.dynamics.com |
|Canada | https://admin.services.crm3.dynamics.com |
|United Kingdom (UK) | https://admin.services.crm11.dynamics.com |


## Standard headers

The Online Management API has following standard request and response headers.   

### Request headers

| Header | Type | Description  |
|--------|------|--------------|
|**Accept-Language**|“en,” “es,” etc.|Specifies the preferred language for the response. Services are not required to support this, but if a service supports localization it MUST do so through the Accept-Language header.|
|**Authorization**|String|Authorization header for the request. See [Authenticate to use the Online Management API](authentication.md)|

### Response headers

| Header | Description  |
|--------|--------------|
|**Operation-Location**|For long-running operations, specifies the location of the operation query to check its status. For example:<br />`https://admin.services.crm.dynamics.com/operations/{operationid}`|
|**Retry-After**|For long-running operations, specifies the recommended period in seconds after which to query the operation status again. For example: **30**|
    
### Related Topics  

[Authenticate to use Online Management API](authentication.md)

[Operations supported by Online Management API](operations-supported.md)

[Online Management API Reference](/rest/api/admin.services.crm.dynamics.com)
