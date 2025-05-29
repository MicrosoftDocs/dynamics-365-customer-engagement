---
title: Develop customized IoT solutions in Connected Customer Service
description: Learn how to create customized IoT solutions in Connected Customer Service for Azure IoT Central to help with business processes.
ms.date: 04/03/2020
ms.topic: reference
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
---

# Develop customized IoT solutions in Connected Customer Service

Connected Customer Service for Dynamics 365 integrates Internet of Things (IoT) devices with Customer Engagement apps for Dynamics 365 to enable their registration, monitoring, and management into established business processes. This guide explains the component architecture, supplied interfaces and customization points, and explains the approach to develop customized IoT solutions.

The initial release of Connected Customer Service supports the following two primary development scenarios:

- Extend Connected Customer Service for Dynamics 365 so that manufacturers and hardware service organizations can register, monitor, and manage—including controlling and correcting—IoT devices. Future releases will provide more support for predicative and prescriptive maintenance capabilities.

- Provide an IoT Platform that ISVs and partners can build on to IOT-enable their Dynamics 365 customer engagement custom entities and managed solutions.

To enable the first scenario, the following capabilities are supported:

- Abstract device registration in an action, so that devices can be easily registered using the CRM web client or the mobile client.

- Any CRM entity to be IOT-enabled, providing straightforward IoT integration within existing business processes by using [Connection entities](../../customerengagement/on-premises/developer/connection-entities.md).

- Ability to receive service alerts and automating their response with a customized workflow.

- Ability to send remote commands to IoT devices, for example after diagnosing a problem to correct a malfunctioning device.
   
- Ability to analyze incoming device data, and displaying aggregate, trends, and other metrics in custom dashboards.


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
