---
title: "Entitlement entities (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about entitlement entities that allow you to set a default entitlement for a customer and control entitlement terms for incidents."
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: pehecke
ms.service:
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 30023495-fc7e-4b42-aa61-29d43647606a
author: KumarVivek
ms.author: kvivek
manager: annbe
search.audienceType: 
  - developer

---
# Entitlement entities

Entitlements specify the support term based on number of hours or number of cases. The customer’s support level can vary based on the product or service that the customer has purchased. Customers who’ve purchased different products can be entitled to different support levels. This information helps the customer support agents verify what the customers are eligible for and create cases for them accordingly.  
  
 Entitlement channel records contain the total terms and remaining terms for each channel in an entitlement. Default channels include Phone, Email, Web, [!INCLUDE[tn_facebook](../includes/tn-facebook.md)], and [!INCLUDE[tn_twitter](../includes/tn-twitter.md)]. You can add custom channels by editing the `incident_caseorigincode` global option set.  
  
 Use entitlement templates and entitlement template channels to create entitlements prefilled with the basic information like the start and end date, service level agreement (SLA), allocation type, and total term. You can also relate entitlement channels and products to entitlement templates. For example, create a template for a standard entitlement, and then apply this template for every standard customer in your organization.  
  
 If you’re using Dynamics 365 Customer Engagement (on-premises), you can also:  
  
- **Set a default entitlement for a customer**: When you create or update an incident (case) for the customer, the default entitlement is automatically applied to the incident. For incident updates, the default entitlement is automatically applied only if you are updating the customer, contact, or product information for an incident record. This is especially useful when you have a single entitlement per customer in your organization, and want the default entitlement to be automatically applied to the incidents that are created or updated for each customer instead of the customer service representatives having to manually select the entitlement, and apply it to the incident.  
  
     Use the `Entitlement.IsDefault` attribute to specify the default entitlement for a customer. Only an active entitlement for a customer can be set as the default entitlement. If an entitlement is already set as default for a customer, setting another entitlement as default for the customer will override the existing one, and set the new entitlement as default. For the default entitlement for a customer to be applied automatically to all the new or modified incidents for the customer, the `Organization.AutoApplyDefaultonCaseCreate` and `Organization.AutoApplyDefaultonCaseUpdate` attributes must be set to 1 (true).  
  
- **Control entitlement terms for incidents (cases)**: When an incident is created and an entitlement is applied to it, the entitlement terms from the associated entitlement are decremented. However, at times you don’t want the entitlement terms to be decremented for an incident (for example, faulty part is installed). To prevent the entitlement terms to be decremented for an incident, set the `Incident.DecrementEntitlementTerm` attribute to 0 (false).  
  
     If you accidentally prevented the entitlement terms to be decremented for a case, you can revert it as follows:  
  
  - If the associated entitlement is configured to have its remaining term decremented on case creation, setting the `Incident.DecrementEntitlementTerm` attribute back to 1 (true) won’t decrement the entitlement term automatically. You have to explicitly decrement from the remaining terms of the associated entitlement using workflow or programmatically.  
  
  - If the associated entitlement is configured to have its remaining term decremented on case resolution, set the `Incident.DecrementEntitlementTerm` back to 1 (true). This ensures that the entitlement terms get decremented when the case is resolved.  
  
    To set the `Incident.DecrementEntitlementTerm` attribute for an incident record, you must have the privileges on the incident record, and have the new `prvControlDecrementTerm` privilege. By default, the `prvControlDecrementTerm` privilege is available to only System Administrator and CSR Manager roles.  
  
## In This Section  
 [Entitlement Entity](entities/entitlement.md)  
  
 [EntitlementChannel Entity](entities/entitlementchannel.md)  
  
 [EntitlementTemplate Entity](entities/entitlementtemplate.md)  
  
 [EntitlementTemplateChannel Entity](entities/entitlementtemplatechannel.md)  
  
## Related Sections  
 [Incident (Case) Entities](incident-case-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]