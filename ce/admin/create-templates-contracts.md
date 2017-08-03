---
title: "Create templates for contracts for Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: "2017-08-31"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 8d08bb4c-8804-4e37-a15b-257bd47e43f4
caps.latest.revision: 35
ms.author: "shujoshi"
manager: "sakudes"
---
# Create templates for contracts
Quickly create consistent contracts prefilled with basic information like the service level and discount, and the time and days when you’ll provide support, by using a contract template in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. For example, create a template for gold members, and then use this template to create contracts for every gold customer in your organization.  
  
 After a contract template is saved, the template is read-only and cannot be changed.  
  
1. [!INCLUDE[proc_permissions_system_admin](../includes/proc-permissions-system-admin.md)]  
  
    Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_service_management](../includes/proc-settings-service-management.md)]  
  
3.  Choose **Contract Templates**.  
  
4.  To create a new contract template, choose **New**.  
  
5.  Type information in the fields:  
  
    - **Name**:  Enter a name. When you create a new contract, this name will appear in the list of available contract templates.  
  
    - **Abbreviation**: Enter an abbreviated name. The name will be displayed as the abbreviated contract template name.  
  
    - **Billing Frequency**: Select how often the customer should be billed.  
  
    - **Allotment Type**: Select the criteria needed to track the cases. You cannot change the allotment type for contract lines in contracts that are created from a contract template.  
  
    - **Calendar**: Mark the days and times your organization offers customer support. Green dots indicate when the support is offered.  
  
    - **Contract Service Level**: Select the service level that will be allocated to the customer.  
  
    - **Description**: Enter a description of the template or any notes about how this template is to be used.  
  
    - **Use Discount as Percentage**: If you want the discount to be calculated in a percentage, select **Yes**.  
  
6.  Choose **Save** or **Save and Close**.  
  
> [!NOTE]
>  If you need to back up your templates, or export them for use in a different implementation of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], you can export them as part of exporting customizations. More information: [Export your customizations as a solution](export-customizations-solution.md).  
  
### See also  
 [Create or edit a contract (Customer Service)](../customer-service/create-edit-contract-customer-service.md)