---
title: Enhanced SLAs in Dynamics 365 Customer Engagement (on-premises)
description: "Learn about the features available in enhanced service level agreements (SLAs) and considerations for choosing a standard SLA or enhanced SLA."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
author: shujoshi
ms.assetid: 67599faa-8b55-420a-b0eb-9161b35a67ff
caps.latest.revision: 11
ms.author: shujoshi
search.audienceType: 
  - admin

---
# Enhanced service level agreements (SLAs)

Service level agreements (SLAs) are a formalized method to help organizations meet service levels when they provide customer service and support. For example, an organization can have an SLA to complete the first customer response within 48 business hours after a case is created. Another example is to escalate an unresolved case after a specified duration, such as five business days. SLAs are used to define these different aspects of service.  
  
Dynamics 365 Customer Engagement (on-premises) includes two kinds of SLAs, standard and enhanced. Enhanced SLAs include the following features not available in standard SLAs:  
  
-   Case-on-hold support  
  
-   Auto-pause and resume of time calculation  
  
-   Support for success actions  
  
-   Creation of dashboards or reports based on the SLA KPI Instance entity  
  
## Case-on-hold support  
 One feature of SLA tracking is the ability to control the case-on-hold status. For example, this functionality lets you pause a case for a time when the case is on hold waiting for a response from the customer. Once the response is received, the case is resumed.  
  
 System administrators turn on SLAs and select case hold functionality in **Settings** > **Service Management** > **Service Configuration Settings**. Afterwards, CSR Managers can create SLAs using the enhanced SLA type that allows pause and resume functionality. SLAs are created in **Settings** > **Service Management**.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Define service level agreements (SLAs)](../../../customer-service/administer/define-service-level-agreements.md)  
  
## Considerations when you choose a SLA type  
 Because there are two types of SLAs that have different functionality, consider the following features before you choose an SLA type. We recommend that you use only one type of SLA for an organization.  
  
-   After you select an SLA type, either standard or enhanced, you cannot change the SLA type for any record associated with the SLA.  
  
-   Because standard and enhanced SLAs exist as separate entities with separate forms, views, and fields, the following behaviors exist.  
  
    -   Case views cannot be sorted by enhanced SLA fields. To display enhanced SLA fields in Case views, you can modify any of the Case views to display the fields from the enhanced SLA (which has the entity name SLA KPI Instance).  Although you can sort on the fields that are part of the Case entity, because the enhanced SLA fields are on a related entity, you cannot sort on columns that are associated with the enhanced SLA fields.  
  
    -   Queue Item views do not display enhanced SLA fields. Although, Queue Item views display the standard fields SLA (First Response By and Resolve By), because the enhanced SLA (SLA KPI Instance entity) is not directly related to the Queue Item entity, the columns associated with enhanced SLAs cannot be displayed.  
  
> [!TIP]
>  To monitor enhanced SLA details, consider creating custom dashboards based on the SLA KPI Instance entity or custom views using the Regarding (Case) relationship.  
  
### See also  
 [Video: SLA Enhancements in Microsoft Dynamics CRM 2015](https://youtu.be/rgmPqLsG8WI)   
 [Enable languages](../admin/enable-languages.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
