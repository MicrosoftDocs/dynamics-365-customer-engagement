---
title: Hub Data APIs
description: These Hub APIs manage custom instances of modeled types. 
keywords: Customer Insights; types; metadata
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/14/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 7cbdbf5b-a197-4b02-a217-0c51e6c7faa1
---

Hub Data APIs (Hub)
=================

The Hub Data APIs are [OData](http://www.odata.org)-based. They are dynamic in the sense that the OData API shape is generated based on the model created for your Customer 
Insights Hub. The Service Metadata document for your Customer Insights hub is obtained using the following operation:

&emsp;  `GET <hub-endpoint>/data/$metadata`

>[!NOTE]
>The topics in this section represent common hub data operations, which are presented as reference examples. This section is _not_ exhaustive as there are considerably more custom types and associations that can be created, deleted, or queried.  Furthermore, many of these examples assume the existence of custom types, such as **Customer** profiles.


