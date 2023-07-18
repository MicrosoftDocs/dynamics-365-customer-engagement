---
title: FAQs for work order recap with copilot (preview)
description: This FAQs provides information about the AI technology used in the work order recap feature.
ms.date: 07/10/2023
ms.custom: 
  - responsible-ai-faqs
ms.topic: article
author: m-hartmann
ms.author: mhart
ms.reviewer: jacohen
---

# FAQs for work order recap with copilot (preview)

These FAQs describe the AI impact of the Dynamics 365 Field Service work order recap (preview) feature.

## What is work order recap with copilot?

The AI-Powered work order recap feature provides a succinct, status-relevant summary of a work order and its related contextual data. This feature is designed to help service managers, dispatchers, and frontline workers quickly understand the current state of a work order. The recap includes aspects of its past developments, future actions, arrival times, work criticality, and parts used or to be used.

## What are the feature’s capabilities?

The feature uses the requesting user's security context to pull relevant data based on the status of the work order to create the recap. If the data is present on the record, the recap includes a summary of the work order, booking details, activities, notes, products, services, and service tasks involved in the work order. Additional information, such as requirement characteristics, asset details, and invoice information, may be included based on the work order's current system status.

## What is the feature’s intended use?

As a work order progresses through its lifecycle, the work order recap provides a contextually relevant summary tailored to the status of the work order. It aims to provide a high-level recap that can be quickly consumed by a user. The recap may help them determine what about the given record requires deeper investigation. This feature uses AI to generate a brief summary and isn't intended to be a replacement for thorough investigation of each work order and relevant related information.

## How was work order recap with copilot evaluated? What metrics are used to measure performance?

- This feature was evaluated using English. It's currently available only in English (en-us).
- The recap was tested to evaluate prompt accuracy and performance. Responses are limited to the context provided from the work order.
  - During testing, the quality of the content is heavily influenced by the quality of the data in the system.
  - No content fabrication was observed during testing; however, there were some instances observed of inaccurate summarization of the data shared within the prompt.

## What are the limitations of work order recap with copilot? How can users minimize the impact of the limitations when using the system?

- This feature is currently in preview.
  - Users are encouraged to provide feedback on the quality of the content using the like/dislike icons within the feature's control. We use this data to evaluate and improve the quality of the capability.
- This feature is intended for use online. It's not available while users are offline.
- This feature was evaluated using English. It's currently available only in English (en-us). Inaccurate responses may be returned when users converse with the system in languages other than English.
- The system generates a summary based on the data the user who invoked the summary can see and based on the data that exists within the system. If the user is missing critical permissions, the summary may be of low value. Similarly, if the data in the system is of poor quality, the summary may be of low value. The output of the summary is based on the value of the inputs.

## What operational factors and settings allow for effective and responsible use of the feature?

- While this feature is in preview and only available for environments within the United States and the United Kingdom, the feature can be enabled or disabled for a given environment by an administrator through the Field Service **Settings**, **Copilot recap** toggle. When disabled, the **Copilot recap** control is hidden from the Work order form (preview). This feature is only available, out of the box, on the Work order form.
- While the prompt and contextual data provided within the prompt can't be customized at this time, the feature respects:
  - Personalization settings for date/time format and time zone to ensure time related outputs reflect the date/time and time zone settings of a given user.
  - Environment specific table and field labels for the contextual information passed in as part of the prompt for a given work order. The response should reflect the labels of the data within a given environment rather than the display labels defined in the default solution.

## See also

- [Work order recap with copilot](work-order-recap.md)
- [Responsible AI FAQs for Dynamics 365 Field Service](responsible-ai-overview.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
