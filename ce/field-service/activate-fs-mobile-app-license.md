---
title: "Activate or extend field service mobile licenses (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom: "dyn365-fieldservice"
ms.date: 09/25/2018
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "activate-fs-mobile-app-license"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "shellyhaverkamp"
ms.assetid: 49207db9-d1f0-46e0-ae2c-f4acf4593da9
caps.latest.revision: 24
ms.author: FieldServiceDave
ms.manager: "shellyhaverkamp"
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---
[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

# Activate or extend Field Service mobile licenses

Global admins preparing to use the [!include[Dynamics 365 for Field Service](../includes/pn-dyn-365-field-service.md)] application must activate mobile licenses to have access to the field service mobile app.There are a few important details to know before you activate or extend [!include[Dynamics 365 for Field Service](../includes/pn-dyn-365-field-service.md)] mobile licenses:

- Field service mobile licenses are allocated to one organization at a time, based on the organization ID.

- Each [!include[Dynamics 365 for Field Service](../includes/pn-dyn-365-field-service.md)] license you purchase from Microsoft allows you to assign one mobile license per user, with the total number of mobile users allocated across all your production, sandbox, and trial organizations not to exceed the total number of licenses you purchased. 

    For example, if you purchase 100 field service licenses and you manage one production organization and one sandbox, you could assign mobile licenses to 50 users at both organizations for a maximum total of 100 mobile users (not 100 mobile users at *each* organization for a total of 200).

- A 30-day trial automatically starts when you install the Woodford solution in your Dynamics 365 instance. Activate or extend the licenses before the trial period ends to maintain access to the field service mobile app. View your trial end date by logging into Woodford via Settings > Woodford

  > ![OrgID](media/woodford-expiration.png)  

# Request form

Fill out the following form to activate mobile licenses or extend Woodford trials: [request form](https://forms.office.com/Pages/ResponsePage.aspx?id=v4j5cvGGr0GRqy180BHbR_qdDvPY821Ojv3lrQCnA7JUNEVaR01JNFNIMDNOME8xNlBWMEVFSUhEQS4u)

Please note you will need your Dynamics 365 Org ID to complete the request form.

        > [!NOTE]
        > Here's how to find your org ID:
        >  - Open your Dynamics 365 instance.
        >  - Navigate to **Settings \> Customizations \>Developer Resources**.
        >  - In the Instance Reference Information section, locate the Org ID.
        
        
  > ![OrgID](media/admin-orgid.png)  
        






