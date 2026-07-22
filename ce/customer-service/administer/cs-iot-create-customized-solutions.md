---
title: Develop customized IoT solutions in Connected Customer Service
description: Learn how to design and extend IoT-based solutions in Connected Customer Service using Azure IoT Central.
ms.date: 03/30/2026
ms.topic: reference
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
---

# Develop customized IoT solutions in Connected Customer Service

Connected Customer Service integrates Internet of Things (IoT) devices with Customer Service to support device registration, monitoring, and management as part of existing business processes. This article describes the supported architecture, extensibility points, and development scenarios for building customized IoT solutions.

## Supported development scenarios

Connected Customer Service supports the following development scenarios:

- Extend Connected Customer Service so that manufacturers and service organizations can register, monitor, manage, and send commands to IoT-enabled devices as part of service workflows.

- Provide an IoT platform that partners and independent software vendors (ISVs) can use to integrate IoT capabilities into custom Customer Service entities and managed solutions.

## Supported capabilities

To support these scenarios, Connected Customer Service provides the following capabilities:

- **Device registration abstraction**: Devices can be registered through Customer Service by using supported actions, without requiring direct interaction with IoT infrastructure.

- **IoT-enabled entities**: Customer Service entities can be associated with devices to enable IoT context within existing business processes.

- **Service alert processing**: IoT alerts can be received and handled through automated workflows to trigger service actions.

- **Remote device commands**: Commands can be sent to connected devices after diagnosing issues, enabling remote remediation actions.

- **Device data analysis**: Incoming device data can be aggregated and visualized by using custom dashboards to identify trends and operational insights.

These capabilities allow organizations to extend Customer Service workflows with IoT data while maintaining control over business logic and customization.

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
