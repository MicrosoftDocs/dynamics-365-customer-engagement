---
title: "Connected Customer Service for Azure IoT Central - Overview | MicrosoftDocs"
description: "Overview of Connected Customer Service for Azure IoT Central."
author: lalexms
ms.author: lalexms
manager: shujoshi
ms.date: 04/03/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---


# Connected Customer Service for Azure IoT Central - Overview

Connected Customer Service for Azure IoT Central provides a direct integration of Dynamics 365 Customer Service with Azure IoT Central, a fully managed IoT software-as-a-service (SaaS) solution. 

Azure IoT Central enables builders to configure rules and actions. Based on those actions, IoT alerts will be created in Connected Customer Service. Also, based on service activities in Connected Customer Service, information can be sent back to Azure IoT Central. This is accomplished by using Power Automate, a SaaS offering for automating workflows across applications and services. 

> [!div class="mx-imgBorder"]
> ![Diagram representing the relationship between Azure IoT Central, Power Automate, and Connected Customer Service](media/cs-iot-overview.png)
 
The below end-to-end integration processes can be easily implemented based on a pure configuration experience:

- Azure IoT Central can send information about device anomalies to Connected Customer Service (as an IoT Alert) for diagnosis
- Connected Customer Service can create cases or work orders triggered from device anomalies

Azure IoT Central requires no extensive cloud development or coding skills to get an IoT solution up and running.  

With [Power Automate templates](https://preview.flow.microsoft.com/templates/), users can connect their accounts, take advantage of our pre-built templates, and customize their own flows in an easy visual designer without the need for coding experience.

## Learn more about Azure IoT Central

- [What is Azure IoT Central?](https://docs.microsoft.com/azure/iot-central/core/overview-iot-central)
- [Tour of Azure IoT Central user interface](https://docs.microsoft.com/azure/iot-central/overview-iot-central-tour)
- [Create a new application in Azure IoT Central - tutorial](https://docs.microsoft.com/azure/iot-central/core/quick-deploy-iot-central)


[!INCLUDE[footer-include](../includes/footer-banner.md)]