---
title: "Build your own Connected Field Service (IoT) solution (contains video) | MicrosoftDocs"
description: Provide pro-active field service with the Connected Field Service solution. Connect devices and equipment via the Internet of Things (IoT) and Microsoft cloud services to detect and diagnose problems and enable predictive maintenance. Extend or customize the Connected Field Service solution to meet your service organization's business needs.
ms.author: vhorvath
author: vhorvathms
ms.date: 07/27/2022
ms.topic: overview

ms.subservice: connected-field-service
---
# Quickstart: Build your own Connected Field Service (IoT) solution

This article shows you how to get up and running quickly to build your own Connected Field Service solution that integrates IoT data with Dynamics 365 Field Service.

## What is Connected Field Service?
The Connected Field Service solution harnesses data from an IoT platform into the Dynamics 365 Field Service app to help organizations proactively detect, troubleshoot, and resolve issues remotely, dispatching a technician only when necessary. The solution enables you to shift from costly scheduled maintenance plans to just-in-time predictive maintenance.   

Connected Field Service helps you:  

- Reduce downtime by automatically creating work orders and dispatching the right technician for the job based on anomalies flagged in your IoT data  

- Improve customer service by addressing issues as soon as they arise, before your customers become aware of the issues 

## What you need to get started

Here are the three things you need to get started building your own IoT solution:

- **Dynamics 365 Field Service with system administrator credentials**

     You'll need a Dynamics 365 Field Service tenant so that you can import your IoT solution on top of it. You'll build an IoT app      within that Field Service tenant.  

     New to Field Service and need a tenant? No worries. [Sign up for a free trial for development purposes.](https://appsource.microsoft.com/product/dynamics-365/mscrm.40fd37ef-dca4-4b0d-9f41-d16703b7d070
)

- **Azure subscription with admin credentials**     

    The Azure IoT services you'll deploy must be associated with an Azure subscription. 
      
    New to IoT and need an Azure subscription? We've got you covered. [Sign up for an Azure free trial.](https://azure.microsoft.com/free/)

- **Dynamics 365 Connected Field Service add-on**  

Connected Field Service is installed automatically in the current version of Field Service. Make sure you have updated to the [latest version of Field Service](update-field-service.md). 

You can then deploy Azure IoT Hub by going to [https://github.com/microsoft/Dynamics-365-Connected-Field-Service-Deployment](https://github.com/microsoft/Dynamics-365-Connected-Field-Service-Deployment) and following the instructions.

[!INCLUDE [proc-more-information](../includes/proc-more-information.md)] [Installation and setup - Connected Field Service for Azure IoT Hub](installation-setup-iothub.md)

## Watch a 2-minute video

> [!VIDEO https://www.youtube.com/embed/iMZpr5wVD_Q]

## Documentation resources

[Learn about Azure IoT extensibility, analytics, and more](https://azure.microsoft.com/product-categories/iot/)  
 
[See a component architecture diagram and learn which Azure IoT resources are included in a standard installation](/previous-versions/dynamicscrm-2016/developers-guide/mt744253(v=crm.8))  
 
[Check out more Azure documentation resources](/azure/iot-hub/)  






  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
