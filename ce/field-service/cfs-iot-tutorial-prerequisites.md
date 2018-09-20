---
title: "What you need to get started | MicrosoftDocs"
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

# What you need to get started

Here are the 4 things you need to do before you connect Azure IoT Central to Connected Field Service (CFS) using Microsoft Flow:

## Provision the Azure IoT Central solution using the Sample Contoso template

First, [go to Azure IoT Central](https://azure.microsoft.com/services/iot-central/). Click **Get started**, and then click **New Application**. 
 
On the **Create Application** dialog: 
 1. For the payment plan, select **Paid** (you won't be asked for a credit card). 
 2. For the application template, select **Sample Contoso**. 
 3. Click **Create**.

![Azure IoT Central with payment plan and template selected](media/Azure-IoT-Central-create-app-dialog.PNG "Azure IoT Central with payment plan and template selected")  

After a few seconds, you'll see the Contoso home page. 

![Contoso home page for Azure IoT Central](media/Azure-IoT-Central-Contoso-home-dialog.PNG "Contoso home page for Azure IoT Central")

## Get a Dynamics 365 for Field Service tenant and system administrator credentials 

You'll need a Dynamics 365 for Field Service tenant that you can connect your IoT solution to.
     
New to Field Service and need a tenant? No worries. [Sign up for a free trial for development purposes](https://appsource.microsoft.com/product/dynamics-365/mscrm.40fd37ef-dca4-4b0d-9f41-d16703b7d070).

## Install the Dynamics 365 Connected Field Service add-on  

The free Connected Field Service add-on automatically provisions a number of Azure IoT services seamlessly on top of Dynamics 365 for Field Service. 
 
Wondering where to get the add-on? [Go to AppSource to install the Connected Field Service add-on](https://appsource.microsoft.com/product/dynamics-365/mscrm.58666c7d-65ee-452d-8708-70b4d471d4c0?tab=Overview).
    
## Install Connected Field Service sample data    
Next, you'll need to download and install the Connected Field Service sample data package, which is designed for use with the Contoso template in Azure IoT Central. The sample data also includes an **IoT Sample - Process alert** workflow that showcases automated alert triaging.

Follow these steps to install the Connected Field Service sample data:

1. [Download the PackageDeployer zip file](https://aka.ms/cfsdemodata).
2. In Windows File Manager, go to the folder where you downloaded the zip file. 
3. Right-click the zip file, and then select **Properties**. 
4. On the Properties dialog, select **Unblock**. Click **OK**.
![PackageDeployer properties dialog with Unblock selected](media/cfs-iot-package-deployer.png "PackageDeployer properties dialog with Unblock selected")
5. Right-click the zip file, select **Extract All**, and then select **Extract**.
6. Double-click **packagedeployer.exe** to run it and install the sample data. 
7. When prompted, enter your system administrator credentials to sign in to your Dynamics 365 tenant. When you see the Azure IoT Central and Connected Field Service sample data deployment page, follow the on-screen instructions to complete the installation.


   
