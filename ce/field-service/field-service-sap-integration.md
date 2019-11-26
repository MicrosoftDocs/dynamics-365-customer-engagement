---
title: "Field Service and SAP integration | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2019
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

# Field Service and SAP integration

Integrate Dynamics 365 Field Service with SAP C-4Hana and SAP S-4Hana to connect your work order scheduling system to your ERP system.

Microsoft offers guidance for integrating Field Service with the SAP Planned Maintenance and SAP Industry-Specific Utility (IS-U) modules. This is done by connecting SAP to the [Common Data Model](https://docs.microsoft.com/en-us/common-data-model/) which Field Service is built on along with other Dynamics modules. You can find details in the [Microsoft Consulting Services GitHub repo](https://github.com/microsoft/MCSBusinessApplicationsDynamicsFSUtilityIndustry), which is a baseline of materials created and updated by Microsoft but open to ISVs and SIs to improve and build upon in an open source manner as part of the Open Data Initiative.

Today the materials provide details on 3 main aspects of integrating Field Service with SAP:

1. Field Service and SAP business processes
2. Entity, field, and data models
3. Guiding principles and best practices 


Below is an example architecture for how the SAP Industry-Specific Utility "meter to cash" solution will interact with Dynamics 365 Field Service.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/sap-integration-meter-cash-example.png)


## Additional notes

[Microsoft Consulting Services GitHub repo](https://github.com/microsoft/MCSBusinessApplicationsDynamicsFSUtilityIndustry)

[Logic Apps SAP connector](https://docs.microsoft.com/en-us/connectors/sap/)