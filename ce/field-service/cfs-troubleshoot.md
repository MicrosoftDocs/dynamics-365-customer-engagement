---
title: "Troubleshoot Connected Field Service | MicrosoftDocs"
description: Learn how to enable and set up location auditing for the Dynamics 365 Field Service mobile app
ms.custom:
- dyn365-fieldservice
ms.date: 11/19/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
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

# Troubleshoot Connected Field Service

You may encounter unexpected behavoir when using Connected Field Service like a device that will not register or a failure to pull device data. View the Azure IoT Logic Apps to help diagnose the issue.

1. Go to the Azure Portal and sign in with your Azure account. Go to Resource Groups and select the Resource Group where Azure IoT is deployed.

2. There are 2 sets of Logic Apps between IoT and Field Service. Select one depedening on if you think the issue originates in Field Service (named CRM in the image below), or if it originates in Azure IoT.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-troubleshoot-resource-group.png)

3. See the list of jobs that run when the system performs actions. As an example, when you attempt to register a device, the logic app will run.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-troubleshoot-logic-app-runs.png)

4. Select a failed run and view the logic app to understand where an error may have occured.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-troubleshoot-logic-app-fail.png)

Use the information in failed Logic Apps to diagnose the issue and to provide to the Microsoft support team. [Create a Dynamics 365 support ticket](https://dynamics.microsoft.com/contact-us/). 

> [!Note]
> It is not recommended to edit the Logic Apps that are deployed by the solution. 