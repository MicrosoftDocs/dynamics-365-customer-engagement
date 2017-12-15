---
title: Segmentation Management APIs (Hub)
description: Enables management of Profile collections (Segments).
keywords: Customer Insights; Hub API; Segmentation API
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 04/28/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 2c6ac718-9758-43e8-b5f7-b8c27baf1230
---

Segmentation Management API (Hub)
================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

[Segmentation](https://en.wikipedia.org/wiki/Market_segmentation) operations include the definition and management of groups of profiles (sometimes referred to as the _audience_), typically for the purpose of marketing or sales investigations and campaigns. Segments are used not only to explore different audience groups, but also to design multiple marketing segments to reflect the same audience group along different stages in a business process. Designing proper segments is critical to this effort, and can be complex because membership often depends upon multiple properties of the audience, their interactions, and direct and indirect relationships with other entities. 

Within Customer Insights, a [Segment](../types/segment.md) takes the form of the creation and management of groups of [Profiles](../types/profile.md). There are two types of segments that are supported in Customer Insights:
* Static segments (lists) consist of a fixed set of members from the target audience. Inclusion in a static segment is an explicit operation that specifies existing profiles. 
* Dynamic segments are based upon a defined query that updates its members automatically at an defined refresh interval. For more information, see [Segmentation Query Language Reference](../segquerylang.md).

>[!Note]                                                                                                                                      
>Compound segments area end-user concept that is actually implemented as a Dynamic segment that typically contains a union of other segments.

The ARM APIs provide similar functionality with [Segmentation Management APIs (ARM)](../arm/segmngnt.md).

Segmentation APIs support Shared Access Signature authorization.
<!-- Does it support other security schemes? -->
