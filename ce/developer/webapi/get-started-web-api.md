---
title: "Get started with the Dynamics 365 for Customer Engagement Web API | MicrosoftDocs"
description: "Read about the various operations you can perform using the Dynamics 365 for Customer Engagement Web API."
ms.custom: 
ms.date: 04/12/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: C3BE3F70-37BA-4D03-A435-54E6127A287A
caps.latest.revision: 51
author: susikka
ms.author: susikka
manager: shujoshi
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Get started with the Dynamics 365 for Customer Engagement Web API

The Web API is one of two web services you can use to work with data and metadata in Common Data Service. The other is the [Organization Service](../org-service/overview.md).

The Common Data Service Web API provides a development experience that can be used across a wide variety of programming languages, platforms, and devices. The Web API implements the OData (Open Data Protocol), version 4.0, an OASIS standard for building and consuming RESTful APIs over rich data sources. You can learn more about this protocol at [http://www.odata.org/](http://www.odata.org/). Details about this standard are available at [https://www.oasis-open.org/standards#odatav4.0](https://www.oasis-open.org/standards#odatav4.0).  
  
Because the Web API is built on open standards, we don’t provide assemblies for a specific developer experience. You can compose HTTP requests for specific operations or use third-party libraries to generate classes for whatever language or platform you want. You can find a list of libraries that support OData version 4.0 at [http://www.odata.org/libraries/](http://www.odata.org/libraries/).  

## Web API and the Organization service

It is valuable to recognize that the organization service is what defines the platform. The Web API provides a RESTful programming experience but ultimately all data operations go through the underlying organization service. The organization service defines the supported operations as messages. Each message has a name. These names are bound to the events used in the event framework to evaluate what registered extensions should be initiated. More information: [Event Framework](../event-framework.md)

The Web API allows you to do all the same operations as the organization service but presents them in an RESTful style. OData v4 provides for named operations via *functions* or *actions*. Most messages available in the organization service are exposed as a corresponding named function or action. Those messages that correspond to CRUD operations are not available in the Web API because as a RESTful service they have implementations using GET, POST, PATCH, and DELETE HTTP methods, but within the platform the *retrieve*, *create*, *update*, and *delete* messages are invoked just as they are when the corresponding operations are performed using the .NET Framework assemblies.

## Start using the Web API

Here are a list of documents that will help you familiarize with the Web API and get started with using it.

- [Get started with Web API(C#)](/powerapps/common-data-service/webapi/get-started-dynamics365-web-api-csharp)
        - [Quick Start: Web API sample(C#)](/powerapps/common-data-service/webapi/quick-start-console-app-csharp)