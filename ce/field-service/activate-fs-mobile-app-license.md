---
title: "Activate Field Service mobile licenses (Dynamics 365 for Field Service) | MicrosoftDocs"
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

# Activate Field Service mobile licenses

When you set up an organization to use the [!include[Dynamics 365 for Field Service](../includes/pn-dyn-365-field-service.md)] application, you need to activate mobile licenses before users can access the Field Service mobile app. 

There are a few important details to know before you activate [!include[Dynamics 365 for Field Service](../includes/pn-dyn-365-field-service.md)] mobile licenses:

- You need Office 365 global admin privileges to manage licenses for an organization.

- Field service mobile licenses are allocated to one organization at a time, based on the organization ID.

- Each [!include[Dynamics 365 for Field Service](../includes/pn-dyn-365-field-service.md)] license you purchase from Microsoft allows you to assign one mobile license per user, with the total number of mobile users allocated across all your production, sandbox, and trial organizations not to exceed the total number of licenses you purchased. 

    For example, if you purchase 100 field service licenses and you manage one production organization and one sandbox, you could assign mobile licenses to 50 users at both organizations for a maximum total of 100 mobile users (not 100 mobile users at *each* organization for a total of 200).

- A 30-day trial automatically starts when you install the Woodford solution in your Dynamics 365 instance. You need to activate the licenses before the trial period ends. If you want to maintain access to the field service mobile app beyond the 30 trial, you need to extend the licenses. To find out your trial end date, go to **Settings** > **Woodford** > **MobileCRM Woodford**. You'll see the trial end date at the top of the screen.

  > ![OrgID](media/woodford-expiration.png)  

# Request form

Fill out the following form to **activate mobile licenses or extend Woodford trials**: [request form](https://forms.office.com/Pages/ResponsePage.aspx?id=v4j5cvGGr0GRqy180BHbR_qdDvPY821Ojv3lrQCnA7JUNEVaR01JNFNIMDNOME8xNlBWMEVFSUhEQS4u)

**Please note** you will need your Dynamics 365 Org ID to complete the request form.

        > [!NOTE]
        > Here's how to find your org ID:
        >  - Open your Dynamics 365 instance.
        >  - Navigate to **Settings \> Customizations \>Developer Resources**.
        >  - In the Instance Reference Information section, locate the Org ID.
        
  > ![OrgID](media/admin-orgid.png)  
        






