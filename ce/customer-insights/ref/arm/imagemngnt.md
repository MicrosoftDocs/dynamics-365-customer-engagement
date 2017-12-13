---
title: Image Management APIs (ARM) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: These APIs help associate images with types.
keywords: Customer Insights; ARM API; image management
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 11/01/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3920008
---

Image Management APIs (ARM)
===========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

These APIs help associate images with [types](../metadatadefs.md) and data instances, which enrich the user experience. They take a description of the type or instance to associate an image to, and return a Shared Access Service (SAS) URL to a writable blob location. You can then use this URL to upload an appropriate image. 

The Hub APIs provide similar functionality with [Image Management APIs (Hub)](../hub/imagemngnt.md).
