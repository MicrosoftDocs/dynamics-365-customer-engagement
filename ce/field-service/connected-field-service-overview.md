---
title: "Build your own Connected Field Service (IoT) solution | MicrosoftDocs"
description: Provide pro-active field service with the Connected Field Service solution. Connect devices and equipment via the Internet of Things (IoT) and Microsoft cloud services to detect and diagnose problems and enable predictive maintenance. Extend or customize the Connected Field Service solution to meet your service organization's business needs.
ms.reviewer: krbjoran
ms.author: daclar
author: FieldServiceDave
manager: shellyha
ms.date: 05/04/2018
ms.topic: quickstart
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-fieldservice
search.app: 
  - D365CE
  - D365FS
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

Connected Field Service is installed automatically in the current version of Field Service. Make sure you have upgraded to the [latest version of Field Service](upgrade-field-service.md). 

You can then get to the deployment app in one of two ways: 

- By visiting https://cfsdeployment.crm.dynamics.com/, or
- By visiting the Connected Field Service dashboard in the Field Service org; once there, you'll see a welcome dialog with links.

   
## Watch a 2-minute video

> [!VIDEO https://www.youtube.com/embed/iMZpr5wVD_Q]

## Documentation resources

[Learn about Azure IoT extensibility, analytics, and more](https://azure.microsoft.com/product-categories/iot/)  
 
[See a component architecture diagram and learn which Azure IoT resources are included in a standard installation](https://msdn.microsoft.com/library/mt744253.aspx)  
 
[Check out more Azure documentation resources](https://docs.microsoft.com/azure/iot-hub/)  






  


[!INCLUDE[footer-include](../includes/footer-banner.md)]