---
title: "Apply SLAs | MicrosoftDocs"
description: "Learn how to apply service-level agreements in Dynamics 365 Customer Service."
ms.date: 05/11/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
  - intro-internal
---

# Apply SLAs

You can apply service-level agreements (SLAs) to a case or an SLA-enabled entity record in one of the following ways:

- By updating the SLA information automatically through a workflow, Power Automate flow, or custom plug-in written for the entity.
- Through the entitlement associated with the case entity record. This isn't applicable for other SLA-enabled entities.
- By marking a particular SLA as default.
- Manually applying SLAs to records.

SLA gets reapplied whenever there is an update on an entity record and the updated field(s) are part of the **Applicable When** conditions of the SLA items.

When the SLA is reapplied, all the items of that SLA are evaluated based on the updated record fields. The failure or warning actions of the matching SLA Item get initiated, if the time has exceeded. This happens even if the failure or warning actions were already initiated before the record was updated.

In Unified Interface, by default, when the SLA moves to a terminal status (non-compliant or succeeded), the **Applicable When** and **Success Criteria** won't be evaluated again on the SLA. If you want the SLA to be reevaluated, you can enable the reevaluation setting in the service configuration settings. More information: [Enable SLA recalculation](enable-sla-recalculation.md)

> [!NOTE]
>
> Only one SLA can be applied to one record. When an entity record is updated by using a different SLA, the previously applied SLA is canceled.  

## Apply SLAs automatically

You can automatically apply SLAs to records based on your business logic by using workflows, Power Automate flows or custom plug-ins.

For example, if your customers are spread across different countries or regions, you can have multiple SLAs with different business hours and holiday schedules. You can set up business logic to apply SLAs on case records based on the customer's country or region, to make sure that the SLA time calculation is done correctly.  

To create workflows so that SLAs will be automatically applied, talk to your customer service managers, administrator, or customizer. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit workflow processes](../customerengagement/on-premises/customize/workflow-processes.md)

You can also use the Power Automate flow portal to update the SLA. Currently the flow expects a GUID of the SLA record. More information: [Create your first flow](/power-automate/getting-started#create-your-first-flow)

If you choose to write a custom plug-in on the SLA-enabled entity, you can update the SLA ID in the pre-update of the entity, like updating any lookup value in plug-in. For example, for case, code in plug-in would look like:
incident["slaid"] = new EntityReference("sla", new Guid("baa25488-6d99-es11-99da-225056836fb7")).

## Apply SLAs through entitlement

You can create entitlements to define support terms. More information: [Associate entitlements to cases](create-entitlement-define-support-terms-customer.md#associate-entitlements-to-cases)

## Mark SLAs as default

If you need only one SLA or want to apply a default SLA, perform the following steps:

1. In the Customer Service Hub sitemap, go to **Service Management**, and select **Service Level Agreements** in **Service Terms**.
2. Select the **Set As Default** option from the ribbon.

## Apply SLAs manually

To apply SLAs to records manually, select the SLA in the SLA field. This field isn't available by default on entity forms, so you will need to ask your system administrator to add it.

While applying the SLA, the applications first looks for automatically applied SLAs, followed by SLAs applied through entitlement. If there aren't any, the application looks for SLA marked as default.

### See also

[Enable entities for service-level agreements](enable-entities-service-level-agreements.md)  
[Troubleshoot issues in SLAs](troubleshoot-sla-issues.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
