---
title: "Prequisites to take the tutorials | MicrosoftDocs"
ms.custom: "dyn365-fieldservice"
ms.date: 09/24/2018
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "field-service"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "shellyhaverkamp"
ms.author: "krbjoran"
ms.manager: "shellyhaverkamp"
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
--- 

## Get ready to take the tutorial

You need 5 things to connect IoT Central to Connected Field Service (CFS) using Microsoft Flow:

1. **Provision IoT Central using the Sample Contoso template**

[Go to Azure IoT Central](https://azure.microsoft.com/services/iot-central/). Click **Get started**. Click **New Application**. For the payment plan, select **Free** or **Paid**. For the application template, select **Sample Contoso**. Then, click **Create**.

![Azure IoT Central with payment plan and template selected](media/Azure-IoT-Central-create-app-dialog.PNG "Azure IoT Central with payment plan and template selected")  

- **Dynamics 365 for Field Service with system administrator credentials** 

     You'll need a Dynamics 365 for Field Service tenant. 
     
     New to Field Service and need a tenant? No worries. [Sign up for a free trial for development purposes.](https://appsource.microsoft.com/product/dynamics-365/mscrm.40fd37ef-dca4-4b0d-9f41-d16703b7d070)

- **Dynamics 365 Connected Field Service add-on**  

    The free Connected Field Service add-on automatically provisions a number of Azure IoT services seamlessly on top of Dynamics 365 for Field Service. 
 
    Wondering where to get it? [Go to AppSource to install the Connected Field Service add-on.](https://appsource.microsoft.com/product/dynamics-365/mscrm.58666c7d-65ee-452d-8708-70b4d471d4c0?tab=Overview)
    
- **Connected Field Service sample data installed**    
    Download and install a Connected Field Service sample data package that enables you to see the capabilities IoT data brings to Field Service, including command modeling, customer asset to device mapping, IoT alert – to – workorder workflow, and more.  
    
    Ready to download and install Connected Field Service sample data? [Go to the Download center to get the package and installation instructions.](https://www.microsoft.com/en-US/download)
   



DO we need this?
- **Azure subscription with admin credentials**     

    The Azure IoT services you'll deploy need to be associated with an Azure subscription. 
      
    New to IoT and need an Azure subscription? We've got you covered. [Sign up for an Azure free trial.](https://azure.microsoft.com/free/)
