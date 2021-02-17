---
title: "Develop customized IoT solutions in Connected Customer Service | MicrosoftDocs"
description: "Learn how to create customized IoT solutions in Connected Customer Service for Azure IoT Central."
author: lalexms
ms.author: lalexms
manager: shujoshi
ms.date: 04/03/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Develop customized IoT solutions in Connected Customer Service

Connected Customer Service for Dynamics 365 integrates Internet of Things (IoT) devices with Dynamics 365 for Customer Engagement to enable their registration, monitoring and management into established business processes. This guide explains the component architecture, supplied interfaces and customization points, and explains the approach to develop customized IoT solutions.

The initial release of Connected Customer Service supports the following two primary development scenarios: 

- Extend Connected Customer Service for Dynamics 365 so that manufacturers and hardware service organizations can register, monitor, and manage—including controlling and correcting—IoT devices. Future releases will provide additional support for predicative and prescriptive maintenance capabilities. 

- Provide an IoT Platform that ISVs and partners can build on to IOT-enable their Dynamics 365 for Customer Engagement custom entities and managed solutions. 

To enable the first scenario, the following capabilities are supported: 

- Abstract device registration in an action, so that devices can be easily registered using the CRM web client or the mobile client 

- Enable any CRM entity to be IOT-enabled, enabling straightforward IoT integration within existing business processes by using [Connection entities](https://docs.microsoft.com/dynamics365/developer/connection-entities) 

- Receive service alerts and automating their response with a customized workflow 

- Send remote commands to IoT devices, for example after diagnosing a problem to correct a malfunctioning device 

- Analyze incoming device data, and displaying aggregate, trend and other metrics in custom dashboards 


[!INCLUDE[footer-include](../includes/footer-banner.md)]