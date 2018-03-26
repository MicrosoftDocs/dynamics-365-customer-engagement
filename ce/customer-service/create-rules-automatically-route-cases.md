---
title: Create rules to automatically route cases (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Understand how to create rules to automatically route cases in Dynamics 365 for Customer Service
keywords: Create rules; Route cases; Dynamics 365; Customer Service
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: sakudes
ms.date: 09/15/2017
ms.topic: article
ms.service: crm-online
ms.assetid: 85a8e762-c063-48a5-bf38-ffc4df6a7c79
---

# Create rules to automatically route cases (Customer Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Use routing rules in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] to automatically route cases to the right people at the right time without any manual intervention. You can also use routing rules to route cases that are escalated to specific queues.  
  
> [!NOTE]
> This feature was introduced in [!INCLUDE[pn_crm_online_2016_update_shortest](../includes/pn-crm-online-2016-update-shortest.md)].  
    
<a name="bkmk_CreateRule"></a>   
## Create a routing rule set  
  
1. [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  
  
     When you create and activate a routing rule set, internally a corresponding workflow is also created. Whatever action you do on the routing rule set, like creating or assigning the rule, you must have privileges to perform the same action on workflows. For the rule to work, you must have sufficient privileges to run a workflow. The routine rule set is applied in context of the privileges that the owner of the routing rule set has.  
  
    #### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_service_management](../includes/proc-settings-service-management.md)]  
  
3.  Click **Routing Rule Sets**.  
  
4.  To create a new routing rule set, click **New**.  
  
     -OR-  
  
     To edit a routing rule set that you already have, in the list of records, click the rule that’s in the Draft state, and then on the command bar, click **Edit**.  
  
5. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)]  
  
6.  After you enter information in all the required fields, click **Save**.  
  
7.  In the **Rule Items** section, click the **Add Rule Item** button **+** to specify conditions for routing cases to a queue.  
  
     You can add multiple conditions here and arrange them in the desired order. The rule items are run in the same order. As soon as an applicable rule item (based on the If Conditions) is applied on the case, the other rule items are not run on the case.  
  
    1. In the Rule Item form, type a descriptive name for the rule item.
  
    2. Under **Rule Criteria** in the **If Conditions** section, specify the conditions for which the case will be routed.
  
       For example, to route all cases that have the **IsEscalated** field set to **Yes** to the **Tier 2 support** queue, specify the conditions as shown here:  
  
       !["If Conditions" for a routing rule in Dynamics CRM](../customer-service/media/crm-ua-rule-criteria-if-conditions.png ""If Conditions" for a routing rule in Dynamics CRM")  
 
    3. Under **Then Conditions**, specify the queue to which the cases will be routed or the user or team to which the cases will be assigned if the conditions in the **If Conditions** section are met.
  
       !["Then Conditions"  for routing rule in Dynamics CRM](../customer-service/media/crm-ua-rule-criteria-then-conditions.png ""Then Conditions"  for routing rule in Dynamics CRM")  
  
    > [!TIP]
    >  To group conditions in the criteria, use the **Group And** or **Group Or** options.  
  
8. [!INCLUDE[proc_click_or_tap_save_and_close](../includes/proc-click-or-tap-save-and-close.md)]  
  
9. In the Routing Rule Set record, click **Activate** so that the rule set is applied to the cases matching the conditions in the rule.  
  
> [!NOTE]
> - Only one routing rule set can be active at any point of time. If you try to activate another rule when one rule is already active, it will deactivate the currently active rule. You can activate or deactivate only the rules that you own.  
> - You can’t edit an active routing rule set. Therefore, if you’re importing a solution that includes an active routing rule set into an organization where the rule already exists with the same ID, the solution import will fail.  
  
<a name="bkmk_ApplyRule"></a>   
## Apply a routing rule set  
 An active routing rule set automatically applies to all automatically-created cases.  
  
 To manually apply the rule to existing or manually-created cases, in the list of cases, select the cases that you want to route using this rule, and on the command bar, click **Apply Routing Rule**.  
  
> [!NOTE]
>  If you’re importing bulk records, and you don’t want the routing rules to apply to the cases that you’re importing, add a column “Route Case” to your spreadsheet, and add the value “No” for all the cases that you don’t want to route.  
  
### See also 
 [Automatically create a case from an email](../customer-service/automatically-create-case-from-email.md)   
 [Create or change a queue](../customer-service/create-edit-queue.md)</br>
 [Create and manage a case (Customer Service Hub)](../customer-service/user-guide-customer-service-hub.md)</br>
 [Create and manage a case (Customer Service)](../customer-service/user-guide-customer-service.md)   
