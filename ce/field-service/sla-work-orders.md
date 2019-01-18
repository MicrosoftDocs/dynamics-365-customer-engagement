---
title: "Service Level Agreements (SLA) for Work Orders | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 01/17/2019
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

# Service Level Agreements (SLA) for Work Orders


Enable SLA on Work Order.
> [!div class="mx-imgBorder"]
> ![Screenshot of Enable SLA on Work Order](./media/work-order-sla-enable-work-order-1.png)


Navigate to the Field Service Settings record. Navigate the tab "Field Service SLA Configuration." Add any new KPIs pertinent to your organization. OOTB we ship two KPIs for WO that can be used once SLA is enabled:
•	Work Order Arrival Time KPI (which is already set up as an SLA Type of Arrival Time)
•	Work Order Resolution KPI
> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service SLA Configuration](./media/work-order-sla-field-service-setting-2.png)

Navigate to Settings > Service Management > Service Level Agreements (in the Web client - SLA is not yet Unified Interface compatible).
> [!div class="mx-imgBorder"]
> ![Screenshot of Settings > Service Management > Service Level Agreements](./media/work-order-sla-create-sla-3.png)

Create a new SLA for Work Order entity.
> [!div class="mx-imgBorder"]
> ![Screenshot of creating a new SLA for Work Order entity](./media/work-order-sla-create-sla-add-work-order-4.png)

If appropriate, assign a Business Hours calendar and save.
> [!div class="mx-imgBorder"]
> ![Screenshot of assigning a Business Hours calendar](./media/work-order-sla-add-sla-details-5.png)

Create SLA Details on the KPI that was identified as Arrival Time related.
> [!div class="mx-imgBorder"]
> ![Screenshot of creating SLA Details on the KPI that was identified as Arrival Time related](./media/work-order-sla-add-actions-6.png)

Activate the SLA.
> [!div class="mx-imgBorder"]
> ![Screenshot of activating the SLA](./media/work-order-sla-add-more-details-7.png)

Add the SLA field to the WO form. The SLA field is created when SLA functionality is enabled for the work order entity.
> [!div class="mx-imgBorder"]
> ![Screenshot of adding the SLA field to the WO form](./media/work-order-add-sla-field-8.png)

Create a Work Order associated to your SLA.
> [!div class="mx-imgBorder"]
> ![Screenshot of creating a Work Order associated to your SLA](./media/work-order-add-to-work-order-9.png)

Asynchronously (meaning not instantaneously but along with other system jobs cadence typically one minute to five minutes), **Time From Promised** and **Time To Promised** will be populated according to the applied SLA and appropriate SLA Item.

> [!div class="mx-imgBorder"]
> ![Screenshot of Time From Promised and Time To Promised fields on the work order being updated according to the SLA](./media/work-order-sla-time-window-10.png)

Furthermore, Schedule Assistant and Resource Schedule Optimization consider Time From Promised and Time To Promised fields and therefore will respect the SLA.

> [!div class="mx-imgBorder"]
> ![Screenshot of Schedule Assistant parameters using Time From Promised and Time To Promised field values](./media/work-order-sla-schedule-11.png)

## Configuration Considerations

## Additional Notes
- Multiple SLAs and multiple business hours/calendars can be created and utlized for different customers, however a work order can only have one SLA assigned to it.
- SLAs on work orders will overwrite existing values for **Time From Promised** and **Time To Promised**
- Pausing an SLA timer on the work order will update **Time From Promised** and **Time To Promised** fields when resumed.

## Other

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-entitlement-asset-category.png)