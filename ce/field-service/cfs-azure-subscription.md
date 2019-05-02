---
title: "Azure subscription prerequisites for CFS with IoTHub | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 05/01/2019
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


# Azure subscription prerequisites for CFS with IoTHub

When deploying and administering CFS with IoTHub, there are a few considerations and prerequisites for your Azure subscription. 

**First,** CFS with IoTHub can only be deployed and administered to one Azure tenant, which should be your home (first) Azure tenant tied to your credentials.

**Second,** in order to deploy and administer IotHub, you must have one of the following Azure security roles:

- Owner in Role Assignments (see screenshot below)
- For classic administrator role:
  - Co-Administrator
  - Service Administrator
  - Account Administrator

> [!div class="mx-imgBorder"]
> ![Screenshot of azure security role dropdown](./media/cfs-azure-api-management-owner.png)


As an example, if I invite a new user to administer IoTHub, he or she must have one of the four security roles above.

**Third,** You will only see subscriptions that are tied to your login's **primary Active Directory**. For example, david@contoso.com will only see subscriptions from contoso.com directory. If jason@fabrikam.com invites David into their fabrikam.onmicrosoft.com subscription, David will not be able to use the fabrikam subscription on the deployment app.


**Fourth,** your user must have permission to use the Dynamics API within the Azure Active Directory tenant.

> [!div class="mx-imgBorder"]
> ![Screenshot of CRM API access](./media/cfs-azure-api-management.png)

