---
title: "Connected Field Service (IoT) overview | MicrosoftDocs"
ms.description: "Provide pro-active field service with the Connected Field Service solution. Connect devices and equipment via the Internet of Things (IoT) and Microsoft cloud services to detect and diagnose problems and enable predictive maintenance. Extend or customize the Connected Field Service solution to meet your service organization's business needs."   
applies_to: 
 - "Dynamics 365 (online)"
 - "Dynamics 365 Version 9.x"
ms.author: shellyha
manager: shellyha
ms.date: 05/04/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-fieldservice
---
# Build your own Connected Field Service (IoT) solution

This article provides an overview how to get started integrating IoT data with Dynamics 365 for Field Service to build your own Connected Field Service solution.

## What is Connected Field Service?
The Connected Field Service solution harnesses data from an IoT platform into the Dynamics 365 for Field Service app to help organizations proactively detect, troubleshoot, and resolve issues remotely, dispatching a technician only when necessary. This enables you to shift from costly scheduled maintenance plans to just-in-time predictive maintenance.   

Connected Field Service helps you:  

- Reduce downtime by automatically creating work orders and dispatching the right technician for the job based on anomalies flagged in your IoT data  

- Improve customer service by addressing issues as soon as they arise, before your customers become aware of the issues 

## What you need to start building your own Connected Field Service solution

Here are the 3 things you need to get started: 

- **Dynamics 365 for Field Service with system administrator credentials** 

     You'll need a Dynamics 365 for Field Service tenant so that you can import your IoT solution on top of it. You'll build an IoT app      within that Field Service tenant.  

     New to Field Service and need a tenant? No worries. [Sign up for a free trial for development purposes.]             (https://appsource.microsoft.com/product/dynamics-365/mscrm.40fd37ef-dca4-4b0d-9f41-d16703b7d070
)

- **Azure subscription with admin credentials**     

    The Azure IoT services you'll deploy need to be associated with an Azure subscription. 
  
    [Learn about Azure IoT extensibility, analytics, and more](https://azure.microsoft.com/product-categories/iot/)
  
 ^ [See a component architecture diagram and learn which Azure IoT resources are included in a standard installation](https://msdn.microsoft.com/library/mt744253.aspx)
 
^ New to IoT and need an Azure subscription? [We've got you covered. Sign up for an Azure free trial.](https://azure.microsoft.com/free/)

^ [Check out these Azure documentation resources](https://docs.microsoft.com/azure/iot-hub/)
 
- **Dynamics 365 Connected Field Service add-on**  

^ Get started quickly with sample data. The free Connected Field Service add-on automatically provisions a number of Azure IoT services with predefined demo data seamlessly on top of Dynamics 365 for Field Service. The demo data enables you to see the capabilities IoT data brings to Field Service, including command modeling, customer asset to device mapping, IoT alert – to – workorder workflow, and more.  
 
 ^ Wondering where to get it? [Go to AppSource to install the Connected Field Service add-on.](https://appsource.microsoft.com/product/dynamics-365/mscrm.58666c7d-65ee-452d-8708-70b4d471d4c0?tab=Overview)
   
## Watch a video

> [!VIDEO https://www.youtube.com/embed/iMZpr5wVD_Q]

[!INCLUDE[pn_connected_field_service_msdyn365](../includes/pn-connected-field-service-msdyn365.md)]  








  
