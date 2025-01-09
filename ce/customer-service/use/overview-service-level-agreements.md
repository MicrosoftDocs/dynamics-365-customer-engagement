---
title: Overview of service-level agreements
description: Configure and manage service-level agreements (SLAs) to track support policies and provide customers with measured and predictable service.
ms.date: 12/13/2024
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
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:12/22/2023
ms.collection: get-started
---

# Overview of service-level agreements

Service-level agreements (SLAs) enable businesses to track support policies and ensure customers are being supported per the support policy to which they're entitled. Businesses use SLAs to govern support products that customers either receive as part of their purchase or add on to their purchase. SLAs include policy details, such as how quickly a customer is entitled to receive support, how many support requests a customer can make, and how long after purchases a customer can be supported as part of the agreement.

You can define the level of service or support that your organization agrees to offer to a customer by using SLAs in Dynamics 365 Customer Service. Providing support based on service levels ensures that you're delivering measured and predictable service.

You can associate an SLA with an entitlement, so that when an entitlement is added to a case, the associated SLA is also applied. You can only associate SLAs that are created for the Case entity with entitlements. For more information, go to: [Create entitlements to define support terms](../administer/create-entitlement-define-support-terms-customer.md#create-entitlements-to-define-support-terms). You can also enable SLAs for entities other than case. More information: [Enable entities for service level agreements](../administer/enable-entities-service-level-agreements.md#enable-entities-for-service-level-agreements).

Alternatively, you can set up a default SLA for the organization. More information: [Set a default SLA](../administer/apply-slas.md#set-a-default-sla)

## Benefits of service-level agreements

### Tracking

- After you configure the SLA KPIs, SLAs, and SLA items for an entity, you can add the SLA Timer control to display the SLA KPIs that are configured for the entity. You can customize the views to filter the KPIs and display only the relevant KPIs to customer service representatives (service representatives). For more information, go to: [Add a timer control for SLA-enabled entities](../administer/add-timer-control-case-form-track-time-against-sla.md#add-a-timer-control-for-sla-enabled-entities). This functionality helps service representatives monitor their service-level performance and meet their service-level goals.
- You can create SLA KPIs with target times by setting up customer holiday schedules or customer service schedules to calculate business hours to be considered during time calculation. 
- You can also enable recalculation of SLAs, providing service representatives with sufficient time to work on their services. More information: [Enable recalculation of SLAs on reaching terminal status](../administer/enable-sla-recalculation.md#enable-recalculation-of-slas-on-reaching-terminal-status)

### Prioritization

You can define the set of conditions that are based on which KPIs are applied to a case, or the set of actions to take as a warning or in an SLA breach. More information: [Manage service configuration settings](/power-platform/admin/system-settings-dialog-box-service-tab)

### Reminders

You can include detailed items to define metrics or key performance indicators (KPIs) to attain that service level. SLA KPIs help you get timely warnings about any issues your customer support team might be having. More information: [Create SLA KPIs](../administer/define-service-level-agreements.md#create-sla-kpis)

## Features of service-level agreements

### Configure SLAs

Configuring SLAs includes the process of creating SLA KPIs, SLAs, and then applying the SLAs you created.

#### Create SLA KPIs

Creating KPIs for your SLAs helps define the success, failure, or warning criteria for your SLAs. KPIs also include performance metrics, such as the response and resolution time, which help define whether the scope of services to be covered was met or breached. More information: [Create SLA KPIs <a name="create-sla-kpis"></a>](../administer/define-service-level-agreements.md)

#### Create SLAs

After you create the SLA KPIs, you can create SLAs from the Customer Service admin center or Customer Service Hub app. Creating an SLA includes creating an SLA and SLA item, configuring actions for the SLA item, and then activating the SLA. More information: [Create SLAs <a name="create-slas"></a>](../administer/define-service-level-agreements.md)

#### Apply SLAs

As a final step, you can apply SLAs automatically, manually, through entitlements, or by setting up a default SLA. More information: [Apply SLAs](../administer/apply-slas.md#apply-slas)

### Implement and manage SLAs

After you configure and apply your SLAs, you can manage the various aspects of your SLA.

#### Export and import a solution with SLAs

- You can export and import a solution with SLAs to another environment without having to create SLAs in the new environment all over again. More information: [Manage solutions with SLAs](../administer/manage-solution.md)
- Additionally, you can export or import a calendar with SLAs. SLA items are automatically inked to the corresponding imported calendars on import. More information: [Enable calendar export and import with SLAs](../administer/export-import-solution.md#enable-calendar-export-and-import-with-slas)

#### Calculate SLA KPIs

- You can manage the calculation of SLA KPIs. You can enable the recalculation of SLA KPIs that reach the terminal status in the Customer Service admin center or Customer Service Hub app. More information: [Enable recalculation of SLAs on reaching terminal status](../administer/enable-sla-recalculation.md#enable-recalculation-of-slas-on-reaching-terminal-status). 

- Additionally, you can enable the custom time calculation and custom recalculation of SLA KPIs. More information: [Enable custom time calculation of SLA KPIs](../administer/enable-sla-custom-time-calculation.md#enable-custom-time-calculation-of-sla-kpis) and [Enable custom recalculation of SLA KPIs](../administer/enable-sla-force-recalculation.md#enable-custom-recalculation-of-sla-kpis)

#### Create and manage customer service and holiday schedules

- You can create customer service schedules and define the work hours to determine the support team's availability to provide support to customers. More information: [Create customer service schedule and define the work hours](../administer/create-customer-service-schedule-define-work-hours.md#create-customer-service-schedule-and-define-the-work-hours)
- You can create and manage holiday schedules and any changes that occur to the schedules as well. This helps avoid any issues with your SLA in cases where your service organization has a holiday. More information: [Create and manage holiday schedules](../administer/set-up-holiday-schedule.md#create-and-manage-holiday-schedules)

#### Add a timer control to an SLA-enabled entity form and customize the SLA timer control display label

- To help your service organization manage the current status and the time remaining for the configured SLA KPIs, you can add a timer control to an SLA-enabled entity form. More information: [Add a timer control for SLA-enabled entities](../administer/add-timer-control-case-form-track-time-against-sla.md#add-a-timer-control-for-sla-enabled-entities). 
- Additionally, you can customize the SLA timer control display label according to the needs of your organization. More information: [Customize the SLA timer control display label](../administer/add-timer-control-case-form-track-time-against-sla.md#customize-the-sla-timer-control-display-label)


### Related information

[Troubleshoot issues in SLAs](../troubleshoot-sla-issues.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
