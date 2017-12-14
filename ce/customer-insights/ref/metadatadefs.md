---
title: Microsoft Dynamics 365 for Customer Insights Metadata Type Definitions | MicrosoftDocs
description: 
keywords: Customer Insights; types; metadata
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 07/26/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 7cbdbf5b-a197-44e2-a217-0c51e6c7faa8
---

Metadata Type Definitions
=========================

[!include[pre release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

This section contains the data types used throughout the Customer Insights public APIs, including the [Hub](./hubapiref.md) and [ARM](./armapiref.md) APIs.  

The types used in the Hub APIs (and the similar operations in the Hub API) are based upon the [OData](http://www.odata.org/documentation/) entity model. Under this model, an _entity set_ is the collection of all the instances of an _entity type_. For example, **Profiles** is the entity set for the **Profile** entity type. OData-based APIs are based on entity sets, for example, the following requests the full set of Profile type instances in the current application.

&emsp; `GET <hub-endpoint>/manage/model/Profiles`

In contrast, the following requests a single Profile type with the unique name "Customer1":

&emsp; `GET <hub-endpoint>/manage/model/Profiles/Customer1`

For more information, see [API Requests and Responses](./requestreponse.md).


## Returned Collections

This section does not contain type definitions for returned types that represent linked collections that have the form:

```{json}
{
    value: [<array-of-entity-instances>]
    nextLink: <string-URL> 
}
```

Where the **nextLink** parameter will be missing if there no additional results. These types will be returned for LIST operations.  Returning "chunked" results is a compromise between returning a single value at a time and the entire resultset. This approach is typically used for List operations, for example [List Hubs (ARM)](./arm/hublist.md).
