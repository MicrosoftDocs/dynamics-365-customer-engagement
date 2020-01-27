---
title: Cases SLAs in Customer Service Hub | Microsoft Docs
description: Understand Cases and SLA in Customer Service Hub for Dynamics 365 Customer Service.
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 11/27/2019
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Case SLAs 
The Customer Service Hub provides the ability to track and manage case SLAs.

## Track SLA details with Timer Control  
You or the CSR working on the case can see the SLA details right on the case form. See the below section to know what happens when an  SLA is applied to a case form. 

### Case form with Applicable SLA applied  

Only the failure time is tracked and saved on the case record. You can ask your system administrator or customizer to add a timer to the case form. The timer shows the time remaining to meet the SLA or the time elapsed since the SLA failed. 

> [!NOTE]
> It is recommended to use only Enhanced SLA as Standard SLA is deprecated. For more information, see [Important changes coming in Dynamics 365 Customer Service](https://docs.microsoft.com/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming).

### Case form with Enhanced SLA applied 
When an enhanced SLA is applied to a case, a related **SLA KPI Instance** record is created for each SLA KPI that is tracked for that case. On the **Summary** tab of the case record, you’ll see a timer that shows the time remaining to meet each SLA KPI.<br /><br /> ![Timer showing time left to achieve SLA KPI](../customer-service/media/v9-1-enhancedslatimer-case-form.png "Timer showing time left to achieve SLA KPI")<br /><br />When a service rep puts a case on hold, the status of the SLA KPI Instance is set to **Paused**. You can see the time for which a case was on hold and the last time the case was put on hold. These details are not available on the case form by default, but your system customizer can add these fields on the case form for you. 

![sla-paused](media/sla-paused.png "SLA paused")

The on-hold time is the time for which the case was set to a status that you defined as an **On-Hold** status in the **System settings** dialog box. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - Service tab.](../admin/system-settings-dialog-box-service-tab.md)<br /> When the service rep resumes a case, the status of the SLA KPI Instance record is updated. The following details are updated in the record if the SLA isn’t violated:<br /><br /> -   Failure time<br />-   Warning time<br />-   Total time the case is on hold<br /><br /> If the service rep puts the case on hold after the warning time, then the warning time isn’t updated when the case is resumed.

Similarly, the status of the SLA KPI instance is updated when the first response time on a case is:

- Nearing expiry 

  ![sla-nearing-expiry](media/sla-nearing-expiry.png "timer control nearing expiry")

- Has expired

  ![sla-expired](media/sla-expired.png "timer control expired")

- Has succeeded

  ![sla-succeeded](media/sla-succeeded.png "timer control succeeded")
 

> [!NOTE]
> - The SLA timer continues to run once it is triggered or un-paused. It includes the holiday hours, non-business hours, and pause time (only business hours) while projecting the SLA warning or failure time.  
> - The timer control auto-refreshes for **Pause** and **Resume** states to show the updated SLA. For all other states, you must refresh the page to view the refreshed SLA. Select **...** and select **Refresh** on the command bar to refresh the SLA timer control.

You can now also apply SLAs on demand. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Apply SLA on demand](define-service-level-agreements.md#apply-sla-on-demand)

To know more about adding a timer control to a case form, see [Add a timer control to the Case form to track time against an SLA](add-timer-control-case-form-track-time-against-sla.md). 







## Use SLA on the Customer Service Hub records 

Your system administrator can enable entities other than case for SLA. For the Customer Service Hub, the following other entities can be enabled for SLA:  

- Account  

- Contact  

- All activity entities: Email, Task, Appointment, Phone Call, Social Activity  

- All custom entities and activities  

  With this enhancement, you can define metrics or key performance indicators (KPIs) to meet the service level for these entity records.  

> [!NOTE]
>  SLAs can only be created in the Dynamics 365 Customer Service. However, you can ask your system administrator or customizer to add a timer to your interactive experience forms to track the SLA KPI details in the Customer Service Hub.  

To know more about how to create SLAs, see [Define Service Level Agreements (SLAs)](define-service-level-agreements.md).

### See also

[Learn the basics of the Customer Service Hub ](customer-service-hub-user-guide-basics.md)

[Use the Main form and its components](../customerengagement/on-premises/customize/use-main-form-and-components.md)
