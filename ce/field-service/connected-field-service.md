---
title: "Connected Field Service - Overview | MicrosoftDocs"
description: Learn all about Connected Field Service for Dynamics 365 Field Service
ms.date: 09/30/2019

ms.subservice: connected-field-service

ms.topic: overview
ms.author: vhorvath
author: vhorvathms
---
# Connected Field Service - Overview

Connected Field Service enables organizations to transform the way they provide service from a costly break-fix model to a proactive and predictive service model through the combination of IoT diagnostics, scheduling, asset maintenance, and inventory on the same platform.

>[!Note]
> To see a video overview of Connected Field Service, [you can watch one here](https://www.youtube.com/watch?v=iMZpr5wVD_Q).

Key benefits of Connected Field Service:

- Reduce downtime by connecting to IoT devices to diagnose problems before customers are aware of an issue
- Address issues faster by remotely monitoring devices and keeping customers in the loop
- Device data and service maintenance data help to make intelligent decisions around dispatching technicians with the right expertise, availability, and proximity to the job 

There are two ways you can use to connect IoT-enabled devices into the Field Service solution:

- Connected Field Service for [**Azure IoT Hub**](https://azure.microsoft.com/services/iot-hub/)
- Connected Field Service for non-Azure IoT providers using the extensible IoT provider framework

## Connected Field Service for Azure IoT Hub

Connected Field Service for Azure IoT Hub is an add-on solution that brings Azure IoT platform-as-a-service (PaaS) offering into Dynamics365 for Field Service. With this offering, you can run a deployment app to put all the Azure IoT services and Dynamics puzzles together.

All Azure IoT services run in your own Azure cloud subscription. Additionally, we provide an enterprise-ready template that you can customize for each Azure IoT service.

> [!Note]
> Currently, the Connected Field Service implementation with IoT Hub does not support splitting out telemetry data for IoT Edge modules.

## Privacy notice

For more information, see [Privacy notice for Connected Field Service](cfs-privacy-notice.md).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
