---
title:
description: 
ms.date: 07/03/2023
ms.topic: how-to
ms.custom: bap-template
author: 
ms.author: 
---

# Work order recap with Copilot in Field Service

The AI-Powered Recap feature provides a succinct summary of a work order and its related contextual data. This feature is designed to help Service Managers, Dispatchers, and Front-Line Workers quickly understand the current disposition of a work order, including its past developments, future actions, arrival times, work criticality, and parts used or to be used.

## Generate a work order recap

Users can interact with the Recap feature from the Work Order form, which includes a new Copilot Recap control. After saving a work order, users can click the "Generate" button in the Copilot Recap control to trigger the system to create a recap summary. Users can also regenerate the recap by clicking the "Regenerate" button. Users are encouraged to provide feedback on the recap, indicating whether they found it useful or not, and can provide additional context about their preferences.

## Recap Generation and Content

On triggering the recap, the system passes the work order ID and its current system status to an API. The system then pulls relevant data based on the status of the work order to create the recap. The recap includes a summary of the work order, booking details, activities, notes, products, services, and service tasks involved in the work order. Additional information, such as requirement characteristics, asset details, and invoice information, may be included based on the work order's current system status.

The recap is tailored to the work order's lifecycle stage, focusing on the most relevant information for each.

## Feature Availability and Usage Limitations

The AI-Powered Recap feature is currently available in Preview for environments deployed in the North American geography. The feature also adheres to responsible AI guidelines, avoiding summarizing information that violates certain restrictions. An admin can enable or disable this feature from the Field Service Settings. When disabled, the Copilot Recap control is hidden from the Work Order form.

In the event of errors or service limitations, the system will return a relevant error message instead of a recap summary.
