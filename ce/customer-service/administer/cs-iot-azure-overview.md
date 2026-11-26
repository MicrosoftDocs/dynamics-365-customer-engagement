---
title: Connected Customer Service for Azure IoT Central
description: Learn how Connected Customer Service integrates Customer Service with Azure IoT Central to support IoT‑based service scenarios without custom development.
ms.date: 03/30/2026
ms.topic: overview
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
---

# Connected Customer Service for Azure IoT Central - Overview

Connected Customer Service for Azure IoT Central integrates Dynamics 365 Customer Service with Azure IoT Central, a fully managed IoT software-as-a-service (SaaS) solution. 

Azure IoT Central lets builders configure rules and actions that generate IoT alerts in Connected Customer Service. Service activity in Customer Service can also send information back to Azure IoT Central. This integration uses Power Automate to automate workflows across applications and services.

> [!div class="mx-imgBorder"]
> ![Diagram representing the relationship between Azure IoT Central, Power Automate, and Connected Customer Service.](../media/cs-iot-overview.png)

You can implement the following end-to-end integration scenarios through configuration only:

- Azure IoT Central sends information about device anomalies to Connected Customer Service as IoT alerts for diagnosis.
- Connected Customer Service creates cases or work orders triggered by device anomalies.

Azure IoT Central doesn't require extensive cloud development or coding skills to build an IoT solution.

With [Power Automate templates](https://powerautomate.microsoft.com/templates/), users can connect their accounts, use prebuilt templates, and customize workflows through a visual designer without writing code.

## Learn more about Azure IoT Central

- [What is Azure IoT Central?](/azure/iot-central/core/overview-iot-central)
- [Tour of Azure IoT Central user interface](/azure/iot-central/overview-iot-central-tour)
- [Create a new application in Azure IoT Central - tutorial](/azure/iot-central/core/quick-deploy-iot-central)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
