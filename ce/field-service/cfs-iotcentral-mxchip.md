---
title: "Set up and test IoT alerts from a real device (MXChip) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 03/04/2020
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Set up and test IoT alerts from a real device (MXChip) 
## Prerequisites

Field Service v8.2+

Azure account

Azure IotCentral

![Video symbol](../field-service/media/video-icon.png "Video symbol") [Set up Connected Field Service with Azure IoTCentral](https://youtu.be/Sp7_JoXjHDk)

> [!Note]
>



## Perform initial MXChip device setup

### Connect Physical Device to PC

Connect the DevKit device to your development machine using provided USB cable
In Windows, a file explorer window opens on a drive mapped to the storage on the DevKit device. For example, the drive might be called AZ3166 (D:)

cfs-mxchip-1
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

### Flash Firmware on Device
Download Latest Firmware (Bundled with HOL Downloads)
	http://aka.ms/CFSFirmware 
	 The download filename on the releases page looks like AZ3166-IoT-Central-X.X.X.bin

Drag the AZ3166-IoT-Central-X.X.X.bin file onto the drive window. When the copying is complete, the device reboots with the new firmware.
	After rebooting the Firmware file will disappear

cfs-mxchip-2
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)
	

### Copy Firmware to Device

Drag and Drop .bin to your AZ3166 (D:)

cfs-mxchip-3
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Create Device Alert Rules in IoTCentral

In the next steps, we will create 2 device rules that will allow the passing of telemetry data from the MXChip  > IoT Central > CFS 

The first will be a B Button press that fires an alert into IoT Central > CFS
The Second will be a Temp Alert that fires when a threshold is met IoT Central > CFS

The Value:
- Anomaly detection from connected devices
- Uptime/Downtime Predictability  
- Dashboarding and Reporting on device specific information
- Integration to Work order creation, scheduling, and dispatching with Conencted Field Service


Navigate to IoT Central and login.

Example: https://YOURORG.azureiotcentral.com 

Once logged in Select Create Device Templates

cfs-mxchip-4
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

Select MXChip

cfs-mxchip-5
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

Select Create

cfs-mxchip-6
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

Select Device Templates and then select MXChip

cfs-mxchip-7
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

Select Rules

cfs-mxchip-8
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

### Button B press rule

Select +New Rule

cfs-mxchip-9
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

Select Event

cfs-mxchip-10
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

Name: Button B Press
Measurement: Button B Press 
Aggregation: None
Then Save

cfs-mxchip-11
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


### High temperature alert rule

Select +New Rule

cfs-mxchip-12
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

Select Telemetry  

cfs-mxchip-13
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

Name: Temperature Alert
Measurement: Temperature
Aggregation: None
Operator: Is Greater Than
Threshold: 15
Then Save

cfs-mxchip-14
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Set up Power Automate flows to create IoT Alerts

Navigate to CFS IoT Alerts under My Work and select Create IoT Flows 

cfs-mxchip-15
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

Select Create CFS alerts from IoT Central 
Make sure you select the CDS Version 

cfs-mxchip-16
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

**You might need to login to Power Automate with credentials if haven’t already**
In flow, you will want to make sure you are connected to your CFS org and your IoT Central 
Select continue 

cfs-mxchip-17
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

Application: Select IoT central application name 
Rule: Select Button B Press
Organization Name: Select Dynamics CFS Org 
Entity Name: Select IoT Alerts
Select Save

cfs-mxchip-18
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

Add Temp Alert to Power Automate Name
Application: Select IoT central application name 
Rule: Select Temperature Alert
Organization Name: Select Dynamics CFS Org 
Entity Name: Select IoT Alerts
Select Save

cfs-mxchip-19
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

Navigate to My Flows and see newly created Alert Flows

cfs-mxchip-20
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Add MXChip as connected device in IoTCentral 

Navigate to IoT Central Solution and loginhttps://YOURORG.azureiotcentral.com 

cfs-mxchip-21
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

Select Device and MXChip(1.0.0) TemplateSelect Real to Create and New Device 

cfs-mxchip-22
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

Create Device ID and Device Name
Create something unique but not too crazy  

cfs-mxchip-23
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

Select Connect 
You will need to copy and paste to Notepad the Scope and Device ID and Primary Key below for MXChip Setup In the next step

cfs-mxchip-24
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


## Plugin and connect MXChip

Connect AZ3166 to Power and press Reset button
Wait until the searching for Wi-Fi screen goes away – Normally 45-60 seconds
Hold down A+B Button AZ3166 will hard reset (Usually takes 15-20 seconds)
Press Reset when directed to by the LCD Screen
When device Reboots, it should be in AP Mode with the SSID Starting with AZ3166
Repeat Steps As Necessary –Should look like this

cfs-mxchip-25
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


After device reboots, you need to configure the Wi-Fi on the Device and should look like the below image 
You should see a device name starting with AZ3166_ in your Wi-Fi trayconnect to that. Once connected, go to below IP address. 
**THIS STEP WILL KICK YOU OFF INTERNET AND HOOK TO MXCHIP**
Go to this http://192.168.0.1/start 

cfs-mxchip-26
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

You will need to ask for the Wi-Fi and password to the network you are hooking your device to from proctor. 
Get device pin from your device
Add in Device, Scope, and Primary Key you copied from IoT Central.
Select Configure Device 

cfs-mxchip-27
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


After the Confirmation Page is shown on your PC, press the Reset Button on the Device

cfs-mxchip-28
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


## See Telemetry Data in IoT Central

Navigate to IoT Central 
Select Devices
Select your device

cfs-mxchip-29
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

You can control what telemetry you see on the chart by selecting the eyes

cfs-mxchip-30
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## See IoT Alerts in Dynamics 365 Field Service 

Press the B Button on the MXChip
Navigate to CFS
Select IoT Alerts 
You should see the two alerts flowing in
Select a Temperature Alert

cfs-mxchip-31
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


Look at Alert Data
Gives all information about the anomaly detected
You can switch to a JSON view if needed
This Temperature alert starts the Work Order Scheduling Process at the top

cfs-mxchip-32
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Create Customer Asset and Connect Device

Navigate to Customer Assets
Select New

cfs-mxchip-33
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

Name Asset: Master MXChip
Select Save
Select Connect Device

cfs-mxchip-34
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

Look up Device and press ok

cfs-mxchip-35
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


You should see the device added 

cfs-mxchip-36
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


## Configuration considerations
## Additional Notes

## See also

![Video symbol](../field-service/media/video-icon.png "Video symbol") [Set up Connected Field Service with Azure IoTCentral](https://youtu.be/Sp7_JoXjHDk)

[What is MXChip](https://aka.ms/iot-devkit)

[Connect an MXChip IoT DevKit device to IoTC](https://docs.microsoft.com/en-us/azure/iot-central/howto-connect-devkit)

[MXChip 2.1 Firmware on GitHub](https://github.com/Azure/iot-central-firmware/releases/tag/mxchip-v2.1.0)
