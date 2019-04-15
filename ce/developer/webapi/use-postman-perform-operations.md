---
title: "Use Postman to perform operations with the Web API (Developer Guide for Dynamics 365 for Customer Engagement)| MicrosoftDocs"
description: "Learn how to compose and send Web API requests using Postman."
ms.custom: 
ms.date: 04/15/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: AB50128B-D8E3-47A3-A0F8-9594EF6B7022
caps.latest.revision: 7
author: susikka
ms.author: susikka
manager: shujoshi
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Use Postman to perform operations with the Web API

Use Postman to compose and send Web API requests and view responses. This topic describes how to use Postman to create Web API requests that perform create, retrieve, update, and delete (CRUD) operations and use functions and actions.

> [!NOTE]
> [!INCLUDE[](../includes/cc-cdsnote-2-topic.md)]

> [!IMPORTANT]
> You need to have an environment that was created by using the steps described in [Set up a Postman environment](setup-postman-environment.md).

The environment created by using the instructions in [Set up a Postman environment](setup-postman-environment.md) creates a `{{webapiurl}}` Postman variable that provides the base URL for requests. Append to this variable to define the URL for your requests.

> [!NOTE]
> To create your environment, use the instructions appropriate to your deployment type.
>
>    |Online|On-premises|
>    |--|--|
>    |[Connect with an online environment](setup-postman-environment.md#bkmk_connectonline)|[Connect with an on-premises environment](setup-postman-environment.md#bkmk_connectonpremise)|

> [!IMPORTANT]
> The operations that you can perform using the Web API are same for Online and On-premise deployments. For complete documentation on how to perform various Web API operations using Postman, see this PowerApps Common Data Service topic: [Use Postman to perform operations](/powerapps/developer/common-data-service/webapi/use-postman-perform-operations) for complete documentation.

## See also

[Set up a Postman environment](setup-postman-environment.md)<br />
[Use Postman with the Web API](use-postman-web-api.md)