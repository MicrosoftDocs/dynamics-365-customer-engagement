---
title: "CORS protocol support for a portal in Dynamics 365 | MicrosoftDocs"
description: "Learn about CORS protocol support for a portal."
ms.custom: ""
ms.date: 09/28/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: D2ADCFCE-F7FC-4297-868F-E02DAFDFD50E
ms.reviewer: ""
redirect_url: /dynamics365/customer-engagement/portals/administer-manage-portal-dynamics-365
author: sbmjais
ms.author: shjais
manager: sakudes
---

# CORS protocol support

The [cross-origin resource sharing (CORS)](http://www.w3.org/TR/cors/) protocol consists of a set of headers that indicates whether a response can be shared with another domain.
The following site settings are used to configure CORS:
| Name                                  | Description                                                                                                                                                       |
|---------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| HTTP/Access-Control-Allow-Credentials | The only valid value for this header is true (case-sensitive). If you don't need credentials, omit this header entirely (rather than setting its value to false). |
| HTTP/Access-Control-Allow-Headers     | A comma-delimited list of the supported HTTP request headers.                                                                                                     |
| HTTP/Access-Control-Allow-Methods     | A comma-delimited list of the allowed HTTP request methods such as GET, POST, OPTIONS.                                                                            |
| HTTP/Access-Control-Allow-Origin      | To allow any resource to access your resources, you can specify *. Otherwise, specify the URI that can access the resources.                                      |
| HTTP/Access-Control-Expose-Headers    | A comma-delimited list of HTTP header names other than the simple response headers that the resource might use and can be exposed.                                |
| HTTP/Access-Control-Max-Age           | Maximum number of seconds the results can be cached.                                                                                                              |
||
