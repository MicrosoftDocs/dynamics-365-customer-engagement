---
title: Enable entities for service level agreements
description: Learn how to enable entities for service-level agreements in Dynamics 365 Customer Service.
ms.date: 03/12/2024
ms.topic: article
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
---

# Enable entities for service-level agreements

You can enable entities for service-level agreements (SLAs) either through the Power Apps portal or your Dynamics 365 Customer Engagement (on-premises) organization.
  
> [!IMPORTANT]
> Only enhanced SLAs can be created for other entities. A standard SLA can be created only for the Case entity.

## Prerequisites

Make sure that you have the System Administrator or System Customizer security role or equivalent permissions.

## Entities (record types) that support SLAs

You can create enhanced SLAs for entities that are enabled for an SLA. A system administrator or customizer can enable SLAs for the following entities:  

- Account  
- Contact  
- Order  
- Invoice  
- Quote  
- Opportunity  
- Lead

- Activity entities such as Email, PhoneCall, and Appointment&mdash;but not RecurringAppointment or its instances.  

  > [!NOTE]
  >  SLAs can also be enabled for custom entities and custom activities. More information: [Enable custom entities for service-level agreements](enable-custom-entities-sla.md#enable-custom-entities-for-service-level-agreements)
  
## Enable from Power Apps

1. Sign in to [make.powerapps.com](https://make.powerapps.com) and select your environment.
1. Select **Solutions** > **Default Solution**.
1. From **Objects**, select **Table**.
1. Find the entity page name on the list and open it.
1. On the entity page, in the **Table properties** section, select **Properties**.
    1. On the **Edit table** dialog, expand **Advanced options**.
    1. Go to the **Make this table an option when** section and select the **Setting up service level agreements** checkbox.
    1. Select **Save**.
1. On the entity page, select **Advanced** > **Publish table**.
1. Go back to **Solutions** and select **Publish all customizations**.
  
> [!NOTE]
> - You can have active SLAs for a maximum of seven entities.
> - We recommend that you have a maximum of five SLA KPIs per entity.
> - You can have a maximum of 100 SLA items per SLA entity; however, we recommend that you have less than 15 SLA items per SLA entity.

## Enable from your Dynamics 365 Customer Engagement (on-premises) organization

1. Sign in to your Dynamics 365 Customer Engagement (on-premises) instance.
1. Go to **Settings** > **Advanced Settings** > **Customizations** > **Customize the System** to open the default solution.
1. Select **Entities**.
1. Find the entity from the list and open it.
1. In the **General** tab, in the **Communication & Collaboration** section, select the **Enable for SLA (Fields will be created)** checkbox.
1. Select **Save and close**. SLA is enabled for the entity.
1. Select **Save and close**, and then select **Publish All Customizations**.
  
## Related information

 [Configure service level agreements](define-service-level-agreements.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
