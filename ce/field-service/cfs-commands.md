---
title: "Send commands in Connected Field Service | MicrosoftDocs"
description: Learn how to send commands using Connected Field Service
ms.custom:
- dyn365-fieldservice
ms.date: 11/19/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app:
- D365CE
- D365FS
---

# Send commands in Connected Field Service

## Send commands from a registered asset

1. From the main menu, go to **Field Service** > **Registered Assets**.

2. From the list of assets, choose a registered asset or device.

3. On the command bar, select **CREATE COMMAND**.

4. Enter a **Name** for the command.

5. In the **MESSAGE TO SEND** box, copy and paste one of these supported commends. ``` `{"CommandName":"Reset Thermostat","Parameters":{}}` `{"CommandName":"Notification","Parameters":{"Message":"Technician has been dispatched"}}` `{"CommandName":"Set Values","Parameters":{"Reading":{"Temperature":"30","Humidity":"30"}}}` ```

    > [!NOTE]
    >  Before sending a command make sure there are no spaces or extra characters in the command.

6. On the command bar, select **SEND & CLOSE** to send the command.

## Respond to an alert

1. Go to **Field Service** > **IoT Alerts**.

2. Choose an existing IoT alert record.

3. On the command bar, select **CREATE COMMAND**.

4. Enter a **Name** for the command.

5. In the **MESSAGE TO SEND** box, copy and paste one of the supported commands listed section above.

6. On the command bar, select **SEND&CLOSE** to send the command.

## View history of commands sent to a device

1. From the main menu, go to **Field Service** > **Customer Assets**.

2. From the list, choose an asset.

3. Scroll down to the **Command** section to view the history.

## Create business process flows to automatically handle incoming IoT alerts

When you receive an alert from a device, your service team can manually monitor the alerts and troubleshoot the issue remotely. If the issue is not resolved by sending a remote command, the service rep can create a case or work order and dispatch a field tech. The provided business process flow guides you through the process of manually responding to IoT alerts. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a business process flow](../customize/create-business-process-flow.md)

 List of default IoT actions:

- IoT- Parent IoT Alerts (Action)

- IoT- Register Customer Entity (Action)

- IoT- Register Device (Action)

- IoT – Debounce IoT Alerts (Action)

- JSON-Based Field Value - Get Number (Action)

- JSON-Based Field Value - Get String (Action)

- JSON-Based Field Value - Get Boolean (Action)

[!INCLUDE[footer-include](../includes/footer-banner.md)]